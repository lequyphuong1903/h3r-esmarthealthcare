using ScottPlot;
using Color = ScottPlot.Color;

namespace HRBR_V300
{
    public partial class BCGPlotControl : UserControl
    {
        private float[] BCGData;
        private int index = 0;
        private ScottPlot.Plottables.Annotation? anno;
        private ScottPlot.Plottables.Signal? sig;
        ScottPlot.IPlotControl PlotControl;
        public BCGPlotControl()
        {
            InitializeComponent();
            BCGData = new float[1000];
            sig = chart.Plot.Add.Signal(BCGData);
            chart.Plot.Axes.SetLimits(0, 1000, -600, 4500);
            chart.Plot.HideAxesAndGrid(false);
            chart.Plot.FigureBackground.Color = Color.FromHex("#07263b");
            chart.Plot.DataBackground.Color = Color.FromHex("#0b3049");
            chart.Plot.Axes.Color(Color.FromHex("#a0acb5"));
            sig.LineWidth = 3;
            chart.Interaction.Disable();
            anno = chart.Plot.Add.Annotation("Interval: ", Alignment.LowerLeft);
            anno.LabelBackgroundColor = Colors.Transparent;
            anno.LabelFontColor = Colors.Yellow;
            anno.LabelBorderColor = Colors.Transparent;
           
        }

        public void UpdatePlot(float value, double interval)
        {
            BCGData[index] = value;
            index++;
            if (index == BCGData.Length) 
            {
                index = 0;
            }

            anno.Text = "Interval: " + interval.ToString("F1") + " ms";
            chart.Invoke((MethodInvoker)delegate
            {
                chart.Refresh();
            });
            
        }
        public void SignalColor(bool isBCG)
        {
            if (isBCG)
            {
                sig.Color = Colors.Green;
            }
        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }
    }
}
