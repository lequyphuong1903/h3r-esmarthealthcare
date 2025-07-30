using System.ComponentModel;

namespace HRBR_V300
{
    public partial class TempControl : UserControl
    {
        private int count = 0;
        public float T1Value;
        public float T2Value;
        public BackgroundWorker blinkThread = new BackgroundWorker();
        private bool isBlink = false;
        public TempControl()
        {
            InitializeComponent();
            blinkThread.WorkerSupportsCancellation = true;
            blinkThread.DoWork += BlinkImage;
            blinkThread.RunWorkerAsync();
        }
        public void UpdateTemp(float t1Value, float t2Value)
        {
            T1Value = t1Value;
            T2Value = t2Value;
            count++;
            if (count == 50) 
            {
                T1.Invoke(new Action(() => { T1.Text = (T1Value).ToString("F1"); }));
                T2.Invoke(new Action(() => { T2.Text = (T2Value).ToString("F1"); }));
                count = 0;
            }
        }
        private void BlinkImage(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (isBlink)
                {
                    loadLabel1.Invoke((MethodInvoker)(() => { loadLabel1.Visible = !loadLabel1.Visible; loadLabel2.Visible = !loadLabel2.Visible; }));
                    Thread.Sleep(1000);
                }
            }
        }
        public void StartBlink()
        {
            T1.BeginInvoke(new Action(() =>
            {
                T1.Visible = false; T2.Visible = false;
                isBlink = true;
            }));
        }
        public void StopBlink()
        {
            T1.Invoke(new Action(() => { T1.Visible = true; T2.Visible = true; }));
            isBlink = false;
            loadLabel1.Invoke((MethodInvoker)(() => { loadLabel1.Visible = false; loadLabel2.Visible = false; })) ;
        }
        public void Calib()
        {
        }
        public void ResetValue()
        {
            T1.Invoke(new Action(() => { T1.Text = "--"; T2.Text = "--"; }));
            T1.Visible = false;
            T2.Visible = false;
            isBlink = true;
        }
    }
}
