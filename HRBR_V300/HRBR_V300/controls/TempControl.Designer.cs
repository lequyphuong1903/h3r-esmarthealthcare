namespace HRBR_V300
{
    partial class TempControl
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
            T1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            T2 = new Label();
            label5 = new Label();
            label6 = new Label();
            loadLabel1 = new Label();
            loadLabel2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // T1
            // 
            T1.AutoSize = true;
            T1.Font = new Font("Segoe UI", 35F);
            T1.ForeColor = Color.White;
            T1.Location = new Point(118, 82);
            T1.Name = "T1";
            T1.Size = new Size(65, 62);
            T1.TabIndex = 0;
            T1.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 1;
            label2.Text = "TEMP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 42);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(167, 7);
            label1.Name = "label1";
            label1.Size = new Size(14, 13);
            label1.TabIndex = 4;
            label1.Text = "o";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 4);
            label3.Name = "label3";
            label3.Size = new Size(29, 32);
            label3.TabIndex = 3;
            label3.Text = "C";
            // 
            // T2
            // 
            T2.AutoSize = true;
            T2.Font = new Font("Segoe UI", 35F);
            T2.ForeColor = Color.White;
            T2.Location = new Point(118, 157);
            T2.Name = "T2";
            T2.Size = new Size(65, 62);
            T2.TabIndex = 3;
            T2.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 82);
            label5.Name = "label5";
            label5.Size = new Size(66, 54);
            label5.TabIndex = 4;
            label5.Text = "T1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 30F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 157);
            label6.Name = "label6";
            label6.Size = new Size(66, 54);
            label6.TabIndex = 5;
            label6.Text = "T2";
            // 
            // loadLabel1
            // 
            loadLabel1.AutoSize = true;
            loadLabel1.Font = new Font("Segoe UI", 25F);
            loadLabel1.ForeColor = Color.White;
            loadLabel1.Location = new Point(85, 89);
            loadLabel1.Name = "loadLabel1";
            loadLabel1.Size = new Size(140, 46);
            loadLabel1.TabIndex = 6;
            loadLabel1.Text = "Loading";
            loadLabel1.Visible = false;
            // 
            // loadLabel2
            // 
            loadLabel2.AutoSize = true;
            loadLabel2.Font = new Font("Segoe UI", 25F);
            loadLabel2.ForeColor = Color.White;
            loadLabel2.Location = new Point(85, 161);
            loadLabel2.Name = "loadLabel2";
            loadLabel2.Size = new Size(140, 46);
            loadLabel2.TabIndex = 7;
            loadLabel2.Text = "Loading";
            loadLabel2.Visible = false;
            // 
            // TempControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            Controls.Add(loadLabel2);
            Controls.Add(loadLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(T2);
            Controls.Add(panel1);
            Controls.Add(T1);
            Name = "TempControl";
            Size = new Size(228, 270);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label T1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label T2;
        private Label label5;
        private Label label6;
        private Label loadLabel1;
        private Label loadLabel2;
    }
}
