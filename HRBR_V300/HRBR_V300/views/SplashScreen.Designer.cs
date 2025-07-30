namespace HRBR_V300.views
{
    partial class SplashScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblLoading = new Label();
            emailTxt = new TextBox();
            passTxt = new TextBox();
            panel1 = new Panel();
            loginBtn = new Button();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 80F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(278, 118);
            label1.Name = "label1";
            label1.Size = new Size(351, 142);
            label1.TabIndex = 0;
            label1.Text = "HRBR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(196, 237);
            label2.Name = "label2";
            label2.Size = new Size(533, 62);
            label2.TabIndex = 1;
            label2.Text = "Heart Rate Breath Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 476);
            label3.Name = "label3";
            label3.Size = new Size(283, 15);
            label3.TabIndex = 2;
            label3.Text = "Copyright © 2024 Regional Leading Research Center";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(12, 461);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "V.2.0.1";
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.BackColor = Color.Transparent;
            lblLoading.Location = new Point(729, 476);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(134, 15);
            lblLoading.TabIndex = 4;
            lblLoading.Text = "Loading configuration...";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 12F);
            emailTxt.Location = new Point(85, 25);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(229, 29);
            emailTxt.TabIndex = 5;
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Segoe UI", 12F);
            passTxt.Location = new Point(85, 66);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(229, 29);
            passTxt.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(passTxt);
            panel1.Location = new Point(288, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 174);
            panel1.TabIndex = 7;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginBtn.Location = new Point(74, 129);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(167, 42);
            loginBtn.TabIndex = 10;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox1.ForeColor = Color.Blue;
            checkBox1.Location = new Point(176, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 25);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(3, 74);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(3, 28);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(875, 500);
            Controls.Add(panel1);
            Controls.Add(lblLoading);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblLoading;
        private TextBox emailTxt;
        private TextBox passTxt;
        private Panel panel1;
        private CheckBox checkBox1;
        private Label label6;
        private Label label5;
        private Button loginBtn;
    }
}