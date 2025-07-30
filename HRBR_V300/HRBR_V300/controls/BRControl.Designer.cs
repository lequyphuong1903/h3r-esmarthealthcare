namespace HRBR_V300
{
    partial class BRControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRControl));
            BR = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            loadLabel = new Label();
            brPic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brPic).BeginInit();
            SuspendLayout();
            // 
            // BR
            // 
            BR.AutoSize = true;
            BR.Font = new Font("Segoe UI", 45F);
            BR.ForeColor = Color.White;
            BR.Location = new Point(76, 111);
            BR.Name = "BR";
            BR.Size = new Size(83, 81);
            BR.TabIndex = 0;
            BR.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 1;
            label2.Text = "RESP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
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
            // loadLabel
            // 
            loadLabel.AutoSize = true;
            loadLabel.Font = new Font("Segoe UI", 25F);
            loadLabel.ForeColor = Color.White;
            loadLabel.Location = new Point(44, 173);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(140, 46);
            loadLabel.TabIndex = 6;
            loadLabel.Text = "Loading";
            loadLabel.Visible = false;
            // 
            // brPic
            // 
            brPic.Image = (Image)resources.GetObject("brPic.Image");
            brPic.Location = new Point(63, 85);
            brPic.Name = "brPic";
            brPic.Size = new Size(95, 85);
            brPic.SizeMode = PictureBoxSizeMode.StretchImage;
            brPic.TabIndex = 5;
            brPic.TabStop = false;
            brPic.Visible = false;
            // 
            // BRControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            Controls.Add(loadLabel);
            Controls.Add(brPic);
            Controls.Add(panel1);
            Controls.Add(BR);
            Name = "BRControl";
            Size = new Size(228, 304);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BR;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label loadLabel;
        private PictureBox brPic;
    }
}
