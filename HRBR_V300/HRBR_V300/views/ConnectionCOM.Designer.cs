namespace HRBR_V300.views
{
    partial class ConnectionCOM
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
            cmbPorts = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cmbPorts
            // 
            cmbPorts.BackColor = Color.AliceBlue;
            cmbPorts.Font = new Font("Segoe UI", 12F);
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(33, 25);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(205, 29);
            cmbPorts.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(12, 74);
            button1.Name = "button1";
            button1.Size = new Size(97, 33);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnConnect_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(150, 74);
            button2.Name = "button2";
            button2.Size = new Size(97, 33);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ConnectionCOM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(270, 119);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbPorts);
            Name = "ConnectionCOM";
            Text = "COM Connection";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPorts;
        private Button button1;
        private Button button2;
    }
}