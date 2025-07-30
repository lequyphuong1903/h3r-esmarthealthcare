namespace HRBR_V300
{
    partial class HRControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRControl));
            HR = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            hrPic = new PictureBox();
            loadLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hrPic).BeginInit();
            SuspendLayout();
            // 
            // HR
            // 
            HR.AutoSize = true;
            HR.Font = new Font("Segoe UI", 45F);
            HR.ForeColor = Color.White;
            HR.Location = new Point(75, 123);
            HR.Name = "HR";
            HR.Size = new Size(83, 81);
            HR.TabIndex = 0;
            HR.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(48, 32);
            label2.TabIndex = 1;
            label2.Text = "HR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 42);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 4);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 3;
            label3.Text = "b/min";
            // 
            // hrPic
            // 
            hrPic.Image = (Image)resources.GetObject("hrPic.Image");
            hrPic.Location = new Point(63, 75);
            hrPic.Name = "hrPic";
            hrPic.Size = new Size(95, 85);
            hrPic.SizeMode = PictureBoxSizeMode.StretchImage;
            hrPic.TabIndex = 3;
            hrPic.TabStop = false;
            hrPic.Visible = false;
            // 
            // loadLabel
            // 
            loadLabel.AutoSize = true;
            loadLabel.Font = new Font("Segoe UI", 25F);
            loadLabel.ForeColor = Color.White;
            loadLabel.Location = new Point(44, 163);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(140, 46);
            loadLabel.TabIndex = 4;
            loadLabel.Text = "Loading";
            loadLabel.Visible = false;
            // 
            // HRControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(loadLabel);
            Controls.Add(hrPic);
            Controls.Add(panel1);
            Controls.Add(HR);
            Name = "HRControl";
            Size = new Size(228, 322);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hrPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HR;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private PictureBox hrPic;
        private Label loadLabel;
    }
}
