namespace HRBR_V300.controls
{
    partial class Timing
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
            panel1 = new Panel();
            label = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label);
            panel1.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            panel1.ForeColor = Color.Gold;
            panel1.Location = new Point(51, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 93);
            panel1.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(231, 68);
            label.TabIndex = 0;
            label.Text = "00:00:00";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Timing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(panel1);
            Name = "Timing";
            Size = new Size(403, 118);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label;
    }
}
