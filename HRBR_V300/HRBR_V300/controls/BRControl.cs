using HRBR_V300.utils;
using Microsoft.ML.OnnxRuntime;
using System.ComponentModel;

namespace HRBR_V300
{
    public partial class BRControl : UserControl
    {
        public int BRValue { get; set; }
        public int currentBRValue { get; set; }
        public int previousBRValue1 { get; set; }
        public int previousBRValue2 { get; set; }
        public BackgroundWorker blinkThread = new BackgroundWorker();
        private bool isBlink = false;
        private bool isCalib = false;
        public BRControl()
        {
            InitializeComponent();
            blinkThread.WorkerSupportsCancellation = true;
            blinkThread.DoWork += BlinkImage;
            blinkThread.RunWorkerAsync();
        }
        #region Transmiss
        public void UpdateBR()
        {
            int[] arr = RemoveOutliersUsingIQR(FindPeaks.history);
            int BRtemp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                BRtemp += arr[i];
            }
            BRtemp /= arr.Length + 1;
            BRValue = BRtemp;
            if (isCalib)
            {
                if (BRValue < (previousBRValue1 - 2) || BRValue > (previousBRValue1 + 2))
                {
                    if (BRValue < (previousBRValue2 - 2) || BRValue > (previousBRValue2 + 2))
                    {
                        currentBRValue = BRValue;
                    }
                }
                else
                {
                    currentBRValue = BRValue;
                }
                previousBRValue2 = previousBRValue1;
                previousBRValue1 = BRValue;
                BR.Invoke(new Action(() => { BR.Text = (currentBRValue).ToString(); }));
            }
            else
            {
                BR.Invoke(new Action(() => { BR.Text = (BRValue).ToString(); }));
                currentBRValue = BRValue;
            }
            
        }
        public void Calib()
        {
            isCalib = true;
        }
        public void ResetValue()
        {
            isCalib = false;
            BR.Invoke(new Action(() => { BR.Text = "--"; }));
            BR.Visible = false;
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
                    brPic.Invoke((MethodInvoker)(() => { brPic.Visible = !brPic.Visible; loadLabel.Visible = !loadLabel.Visible; }));
                    Thread.Sleep(1000);
                }
            }
        }
        public void StartBlink()
        {
            BR.BeginInvoke(new Action(() =>
            {
                BR.Visible = false;
                isBlink = true;
            }));
        }
        public void StopBlink()
        {
            BR.Invoke(new Action(() => { BR.Visible = true; }));
            isBlink = false;
            brPic.Invoke((MethodInvoker)(() => { brPic.Visible = false; loadLabel.Visible = false; }));
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
