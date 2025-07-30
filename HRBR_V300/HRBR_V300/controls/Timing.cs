
using System.Timers;

namespace HRBR_V300.controls
{
    public partial class Timing : UserControl
    {
        private System.Timers.Timer _timer;
        private TimeSpan _elapsedTime;
        public Timing()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _elapsedTime = new TimeSpan(0, 0, 0);
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _elapsedTime = _elapsedTime.Add(TimeSpan.FromSeconds(1));
            this.Invoke((MethodInvoker)delegate
            {
                label.Text = _elapsedTime.ToString(@"hh\:mm\:ss");
            });

        }
        public void StartCount()
        {
            _timer.Enabled = true;
        }

        public void StopCount()
        {
            _timer.Enabled = false;
            _elapsedTime = new TimeSpan(0, 0, 0);
            this.Invoke((MethodInvoker)delegate
            {
                label.Text = _elapsedTime.ToString(@"hh\:mm\:ss");
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
