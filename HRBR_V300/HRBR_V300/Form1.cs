using System.IO.Ports;
using System.ComponentModel;
using System.Diagnostics;
using HRBR_V300.utils;
using HRBR_V300.views;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace HRBR_V300
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        static SerialPort serialPort;
        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        CircularBuffer buffer = new CircularBuffer(1000);
        const byte sof = 0x02;
        const byte eof = 0x03;
        private float[] inputData1 = new float[500];
        private float[] inputData2 = new float[500];
        int[] inputDimensions = new int[] { 1, 500, 1 };
        private int count = 0;
        private bool isCalib = false;
        private bool isRecord = false;
        private int countCalib = 0;
        public Stopwatch stopwatch = new Stopwatch();
        static double _previousTime = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "DIENVAO",
            BasePath = "DIENVAO",
        };
        public IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
            bcgPlot1.SignalColor(true);
            bcgPlot2.SignalColor(false);
        }
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            client = new FireSharp.FirebaseClient(config);
            if(client == null)
            {
                MessageBox.Show("Could not connect to Firebase. Please check your internet connection.");
            }
        }
        #region Button
        public void SelectCOM(string COM)
        {
            serialPort = new SerialPort(COM, 250000);
            
        }
        public void Start_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            serialPort.DiscardInBuffer();
            serialPort.DataReceived += (sender, e) =>
            {
                int bytesToRead = serialPort.BytesToRead;
                byte[] receivedBytes = new byte[bytesToRead];
                serialPort.Read(receivedBytes, 0, bytesToRead);

                foreach (byte b in receivedBytes)
                {
                    buffer.Enqueue(b);
                }
            };
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();
            timer1.Enabled = true;
            timer1.Start();
            hrControl1.StartBlink();
            brControl1.StartBlink();
            tempControl1.StartBlink();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectionCOM connectionForm = new ConnectionCOM();
            connectionForm.ShowDialog();
        }
        private void PatientSet_Click(object sender, EventArgs e)
        {
            PatientSetting patientForm = new PatientSetting();
            patientForm.ShowDialog();
        }
        private void Record_Click(object sender, EventArgs e) 
        {
            isRecord = true;
            timing1.StartCount();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (isRecord)
            {
                dashBoardControl1.SaveCSV();
                isRecord = false;
                timing1.StopCount();
            }
        }
        private void Calib_Click(object sender, EventArgs e)
        {
            hrControl1.Calib();
            brControl1.Calib();
            tempControl1.Calib();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            isCalib = false;
            countCalib = 0;
            hrControl1.ResetValue();
            brControl1.ResetValue();
            tempControl1.ResetValue();
        }
        #endregion
        #region BufferProcess
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                ProcessBuffer(buffer);
            }
        }
        void ProcessBuffer(CircularBuffer buffer)
        {
            stopwatch.Start();
            while (buffer.Count >= 12)
            {
                byte firstByte = buffer.Dequeue();
                if (firstByte == sof)
                {
                    byte length = buffer.Dequeue();
                    if (length == 8)
                    {
                        byte[] data = new byte[8];
                        for (int i = 0; i < 8; i++)
                        {
                            data[i] = buffer.Dequeue();
                        }
                        byte receivedChecksum = buffer.Dequeue();
                        byte endFrame = buffer.Dequeue();

                        if (endFrame == eof)
                        {
                            byte calculatedChecksum = CalculateChecksum(data);
                            if (receivedChecksum == calculatedChecksum)
                            {
                                double currentTime = stopwatch.Elapsed.TotalMilliseconds;
                                double interval = currentTime - _previousTime;
                                bcgPlot1.UpdatePlot(BitConverter.ToInt16(data, 0), interval);
                                bcgPlot2.UpdatePlot(BitConverter.ToInt16(data, 2), interval);
                                inputData1 = PushBack(inputData1, BitConverter.ToInt16(data, 0));
                                inputData2 = PushBack(inputData2, BitConverter.ToInt16(data, 2));
                                float t1 = BitConverter.ToInt16(data, 4) * 0.02f - 273.15f;
                                float t2 = BitConverter.ToInt16(data, 6) * 0.02f - 273.15f;
                                if (!isCalib)
                                    tempControl1.UpdateTemp(t1, t2);
                                count++;
                                if (count == 100)
                                {
                                    FindPeaks.FindPeak(inputData2);
                                    using (var model = new Runtime())
                                    {
                                        OutputRuntime.outputhr = (int)model.RunInference(inputData1, inputDimensions);
                                        OutputRuntime.historyhr[OutputRuntime.counthr] = OutputRuntime.outputhr;
                                        OutputRuntime.counthr++;
                                        if (OutputRuntime.counthr == 5)
                                        {
                                            OutputRuntime.counthr = 0;
                                            if (!isCalib)
                                            {
                                                hrControl1.UpdateHR();
                                                brControl1.UpdateBR();
                                            }
                                        }
                                        count = 0;
                                    }
                                }
                                _previousTime = currentTime;
                            }
                        }
                    }
                }
            }
        }
        static byte CalculateChecksum(byte[] data)
        {
            byte checksum = 0;
            foreach (byte b in data)
            {
                checksum ^= b;
            }
            return checksum;
        }
        private float[] PushBack(float[] array, float newValue)
        {
            float[] newArray = new float[array.Length];
            for (int i = 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            newArray[newArray.Length - 1] = newValue;
            return newArray;
        }
        #endregion
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (countCalib <= 0)
            {
                countCalib++;
            }
            else
            {
                isCalib = false;
                await dashBoardControl1.UpdatePlot( hrControl1.currentHRValue, brControl1.currentBRValue, tempControl1.T1Value, tempControl1.T2Value, isRecord, client);
                hrControl1.StopBlink();
                brControl1.StopBlink();
                tempControl1.StopBlink();
            }

        }


    }
}
