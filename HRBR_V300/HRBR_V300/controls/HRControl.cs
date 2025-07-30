using System.ComponentModel;
using HRBR_V300.utils;

namespace HRBR_V300
{
    public partial class HRControl : UserControl
    {
        public int HRValue { get; set; }
        public int currentHRValue { get; set; }
        public int previousHRValue1 { get; set; }
        public int previousHRValue2 { get; set; }
        public BackgroundWorker blinkThread = new BackgroundWorker();

        private bool isBlink = false;
        private bool isCalib = false;
        public HRControl()
        {
            InitializeComponent();
            blinkThread.WorkerSupportsCancellation = true;
            blinkThread.DoWork += BlinkImage;
            blinkThread.RunWorkerAsync();
            isCalib = false;
        }
        #region Transmiss
        public void UpdateHR()
        {
            int[] arr = RemoveOutliersUsingIQR(OutputRuntime.historyhr);
            int HRtemp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                HRtemp += arr[i];
            }
            HRtemp /= arr.Length;
            HRValue = HRtemp;
            if (isCalib)
            {
                if (HRValue < (previousHRValue1 - 4) || HRValue > (previousHRValue1 + 4))
                {
                    if (HRValue < (previousHRValue2 - 4) || HRValue > (previousHRValue2 + 4))
                    {
                        currentHRValue = HRValue;
                    }
                }
                else
                {
                    currentHRValue = HRValue;
                }
                previousHRValue2 = previousHRValue1;
                previousHRValue1 = HRValue;
                HR.Invoke(new Action(() => { HR.Text = (currentHRValue).ToString(); }));
            }
            else
            {
                HR.Invoke(new Action(() => { HR.Text = (HRValue).ToString(); }));
                currentHRValue = HRValue;
            }
        }
        public void Calib()
        {
            isCalib = true;
        }
        public void ResetValue()
        {
            isCalib = false;
            HR.Invoke(new Action(() => { HR.Text = "--"; }));
            HR.Visible = false;
            isBlink = true;
        }
        #endregion
        #region ThreadBlink
        private void BlinkImage(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (isBlink)
                { 
                    hrPic.Invoke((MethodInvoker)(() => { hrPic.Visible = !hrPic.Visible; loadLabel.Visible = !loadLabel.Visible; }));
                    Thread.Sleep(1000);
                }
            }
        }
        public void StartBlink()
        {
            HR.BeginInvoke(new Action(() =>
            {
                HR.Visible = false;
                isBlink = true;
            }));

        }
        public void StopBlink()
        {
            HR.Invoke(new Action(() => { HR.Visible = true; }));
            isBlink = false;
            hrPic.Invoke((MethodInvoker)(() => { hrPic.Visible = false; loadLabel.Visible = false; }));
        }
        #endregion
        #region Processing
        static int[] RemoveOutliersUsingIQR(int[] arr)
        {
            Array.Sort(arr);

            double q1 = GetPercentile(arr, 25);
            double q3 = GetPercentile(arr, 75);
            double iqr = q3 - q1;

            double lowerBound = q1 - 1.5 * iqr;
            double upperBound = q3 + 1.5 * iqr;

            return arr.Where(val => val >= lowerBound && val <= upperBound).ToArray();
        }

        static double GetPercentile(int[] sortedArray, double percentile)
        {
            double realIndex = percentile / 100.0 * (sortedArray.Length - 1);
            int index = (int)realIndex;
            double frac = realIndex - index;

            if (index + 1 < sortedArray.Length)
                return sortedArray[index] * (1 - frac) + sortedArray[index + 1] * frac;
            else
                return sortedArray[index];
        }
        #endregion
    }
}
