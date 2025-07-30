namespace HRBR_V300
{
    partial class BCGPlotControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chart = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // chart
            // 
            chart.DisplayScale = 1F;
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            chart.Size = new Size(1695, 262);
            chart.TabIndex = 0;
            // 
            // BCGPlotControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chart);
            Name = "BCGPlotControl";
            Size = new Size(1804, 264);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot chart;
    }
}
