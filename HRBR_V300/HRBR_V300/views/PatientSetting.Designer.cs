namespace HRBR_V300.views
{
    partial class PatientSetting
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            nameTxt = new TextBox();
            idTxt = new TextBox();
            ageTxt = new TextBox();
            sexTxt = new TextBox();
            heightTxt = new TextBox();
            weightTxt = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 13F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 35);
            label1.TabIndex = 0;
            label1.Text = "1. Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 13F);
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(106, 34);
            label2.TabIndex = 1;
            label2.Text = "3. Age:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 13F);
            label3.Location = new Point(3, 107);
            label3.Name = "label3";
            label3.Size = new Size(106, 34);
            label3.TabIndex = 2;
            label3.Text = "4. Sex:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 13F);
            label4.Location = new Point(3, 35);
            label4.Name = "label4";
            label4.Size = new Size(106, 38);
            label4.TabIndex = 3;
            label4.Text = "2. ID:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 13F);
            label5.Location = new Point(3, 141);
            label5.Name = "label5";
            label5.Size = new Size(106, 34);
            label5.TabIndex = 4;
            label5.Text = "5. Height:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 13F);
            label6.Location = new Point(3, 175);
            label6.Name = "label6";
            label6.Size = new Size(106, 33);
            label6.TabIndex = 5;
            label6.Text = "6. Weight:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(31, 230);
            button1.Name = "button1";
            button1.Size = new Size(82, 37);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(202, 230);
            button2.Name = "button2";
            button2.Size = new Size(82, 37);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.9032249F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0967751F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(nameTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(idTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(ageTxt, 1, 2);
            tableLayoutPanel1.Controls.Add(sexTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(heightTxt, 1, 4);
            tableLayoutPanel1.Controls.Add(weightTxt, 1, 5);
            tableLayoutPanel1.Location = new Point(13, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(296, 208);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // nameTxt
            // 
            nameTxt.Dock = DockStyle.Fill;
            nameTxt.Location = new Point(115, 3);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(178, 23);
            nameTxt.TabIndex = 6;
            // 
            // idTxt
            // 
            idTxt.Dock = DockStyle.Fill;
            idTxt.Location = new Point(115, 38);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(178, 23);
            idTxt.TabIndex = 7;
            // 
            // ageTxt
            // 
            ageTxt.Dock = DockStyle.Fill;
            ageTxt.Location = new Point(115, 76);
            ageTxt.Name = "ageTxt";
            ageTxt.Size = new Size(178, 23);
            ageTxt.TabIndex = 8;
            // 
            // sexTxt
            // 
            sexTxt.Dock = DockStyle.Fill;
            sexTxt.Location = new Point(115, 110);
            sexTxt.Name = "sexTxt";
            sexTxt.Size = new Size(178, 23);
            sexTxt.TabIndex = 9;
            // 
            // heightTxt
            // 
            heightTxt.Dock = DockStyle.Fill;
            heightTxt.Location = new Point(115, 144);
            heightTxt.Name = "heightTxt";
            heightTxt.Size = new Size(178, 23);
            heightTxt.TabIndex = 10;
            // 
            // weightTxt
            // 
            weightTxt.Dock = DockStyle.Fill;
            weightTxt.Location = new Point(115, 178);
            weightTxt.Name = "weightTxt";
            weightTxt.Size = new Size(178, 23);
            weightTxt.TabIndex = 11;
            // 
            // PatientSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 274);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PatientSetting";
            Text = "PatientSetting";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox nameTxt;
        private TextBox idTxt;
        private TextBox ageTxt;
        private TextBox sexTxt;
        private TextBox heightTxt;
        private TextBox weightTxt;
    }
}