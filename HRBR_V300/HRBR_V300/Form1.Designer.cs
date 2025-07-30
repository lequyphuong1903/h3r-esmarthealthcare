namespace HRBR_V300
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            bcgPlot2 = new BCGPlotControl();
            bcgPlot1 = new BCGPlotControl();
            hrControl1 = new HRControl();
            brControl1 = new BRControl();
            tempControl1 = new TempControl();
            dashBoardControl1 = new DashBoardControl();
            timer1 = new System.Windows.Forms.Timer(components);
            timing1 = new controls.Timing();
            timBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            patsetBtn = new Button();
            connectBtn = new Button();
            saveBtn = new Button();
            recordBtn = new Button();
            startBtn = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            calibBtn = new Button();
            resetBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.65756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3424368F));
            tableLayoutPanel1.Controls.Add(bcgPlot2, 0, 1);
            tableLayoutPanel1.Controls.Add(bcgPlot1, 0, 0);
            tableLayoutPanel1.Controls.Add(hrControl1, 1, 0);
            tableLayoutPanel1.Controls.Add(brControl1, 1, 1);
            tableLayoutPanel1.Controls.Add(tempControl1, 1, 2);
            tableLayoutPanel1.Controls.Add(dashBoardControl1, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.27027F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.72973F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Size = new Size(1913, 784);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // bcgPlot2
            // 
            bcgPlot2.Dock = DockStyle.Fill;
            bcgPlot2.Location = new Point(3, 271);
            bcgPlot2.Name = "bcgPlot2";
            bcgPlot2.Size = new Size(1670, 259);
            bcgPlot2.TabIndex = 7;
            // 
            // bcgPlot1
            // 
            bcgPlot1.Dock = DockStyle.Fill;
            bcgPlot1.Location = new Point(3, 3);
            bcgPlot1.Name = "bcgPlot1";
            bcgPlot1.Size = new Size(1670, 262);
            bcgPlot1.TabIndex = 6;
            // 
            // hrControl1
            // 
            hrControl1.BackColor = Color.SeaGreen;
            hrControl1.Dock = DockStyle.Fill;
            hrControl1.HRValue = 0;
            hrControl1.Location = new Point(1679, 3);
            hrControl1.Name = "hrControl1";
            hrControl1.previousHRValue1 = 0;
            hrControl1.previousHRValue2 = 0;
            hrControl1.Size = new Size(231, 262);
            hrControl1.TabIndex = 8;
            // 
            // brControl1
            // 
            brControl1.BackColor = Color.CornflowerBlue;
            brControl1.BRValue = 0;
            brControl1.currentBRValue = 0;
            brControl1.Dock = DockStyle.Fill;
            brControl1.Location = new Point(1679, 271);
            brControl1.Name = "brControl1";
            brControl1.previousBRValue1 = 0;
            brControl1.previousBRValue2 = 0;
            brControl1.Size = new Size(231, 259);
            brControl1.TabIndex = 9;
            // 
            // tempControl1
            // 
            tempControl1.BackColor = Color.SlateBlue;
            tempControl1.Dock = DockStyle.Fill;
            tempControl1.Location = new Point(1679, 536);
            tempControl1.Name = "tempControl1";
            tempControl1.Size = new Size(231, 245);
            tempControl1.TabIndex = 10;
            // 
            // dashBoardControl1
            // 
            dashBoardControl1.Dock = DockStyle.Fill;
            dashBoardControl1.Location = new Point(3, 536);
            dashBoardControl1.Name = "dashBoardControl1";
            dashBoardControl1.Size = new Size(1670, 245);
            dashBoardControl1.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // timing1
            // 
            timing1.BackColor = SystemColors.ActiveCaptionText;
            timing1.Dock = DockStyle.Fill;
            timing1.Location = new Point(1416, 3);
            timing1.Name = "timing1";
            timing1.Size = new Size(336, 136);
            timing1.TabIndex = 13;
            // 
            // timBtn
            // 
            timBtn.BackColor = SystemColors.ActiveCaptionText;
            timBtn.Dock = DockStyle.Fill;
            timBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            timBtn.ForeColor = Color.Gold;
            timBtn.Location = new Point(1416, 145);
            timBtn.Name = "timBtn";
            timBtn.Size = new Size(336, 49);
            timBtn.TabIndex = 12;
            timBtn.Text = "TIMING";
            timBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(733, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(187, 136);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Save_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(556, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Record_Click;
            // 
            // patsetBtn
            // 
            patsetBtn.BackColor = SystemColors.ActiveCaptionText;
            patsetBtn.Dock = DockStyle.Fill;
            patsetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            patsetBtn.ForeColor = Color.Gold;
            patsetBtn.Location = new Point(1141, 145);
            patsetBtn.Name = "patsetBtn";
            patsetBtn.Size = new Size(269, 49);
            patsetBtn.TabIndex = 7;
            patsetBtn.Text = "PATIENT SETTING";
            patsetBtn.UseVisualStyleBackColor = false;
            patsetBtn.Click += PatientSet_Click;
            // 
            // connectBtn
            // 
            connectBtn.BackColor = SystemColors.ActiveCaptionText;
            connectBtn.Dock = DockStyle.Fill;
            connectBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            connectBtn.ForeColor = Color.Gold;
            connectBtn.Location = new Point(926, 145);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(209, 49);
            connectBtn.TabIndex = 6;
            connectBtn.Text = "CONNECT";
            connectBtn.UseVisualStyleBackColor = false;
            connectBtn.Click += Connect_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ActiveCaptionText;
            saveBtn.Dock = DockStyle.Fill;
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            saveBtn.ForeColor = Color.Gold;
            saveBtn.Location = new Point(733, 145);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(187, 49);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += Save_Click;
            // 
            // recordBtn
            // 
            recordBtn.BackColor = SystemColors.ActiveCaptionText;
            recordBtn.Dock = DockStyle.Fill;
            recordBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            recordBtn.ForeColor = Color.Gold;
            recordBtn.Location = new Point(556, 145);
            recordBtn.Name = "recordBtn";
            recordBtn.Size = new Size(171, 49);
            recordBtn.TabIndex = 4;
            recordBtn.Text = "RECORD";
            recordBtn.UseVisualStyleBackColor = false;
            recordBtn.Click += Record_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.ActiveCaptionText;
            startBtn.Dock = DockStyle.Fill;
            startBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            startBtn.ForeColor = Color.Gold;
            startBtn.Location = new Point(362, 145);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(188, 49);
            startBtn.TabIndex = 3;
            startBtn.Text = "START";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += Start_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.start;
            pictureBox1.Location = new Point(362, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Start_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(3, 142);
            label2.Name = "label2";
            label2.Size = new Size(353, 55);
            label2.TabIndex = 1;
            label2.Text = "HRBR V2.0.1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(353, 142);
            label1.TabIndex = 0;
            label1.Text = "Regional Leading Research Center";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(926, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(209, 136);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += Connect_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1141, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(269, 136);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += PatientSet_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.9186249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.0813751F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            tableLayoutPanel2.Controls.Add(pictureBox5, 5, 0);
            tableLayoutPanel2.Controls.Add(pictureBox4, 4, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(startBtn, 1, 1);
            tableLayoutPanel2.Controls.Add(recordBtn, 2, 1);
            tableLayoutPanel2.Controls.Add(saveBtn, 3, 1);
            tableLayoutPanel2.Controls.Add(connectBtn, 4, 1);
            tableLayoutPanel2.Controls.Add(patsetBtn, 5, 1);
            tableLayoutPanel2.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox3, 3, 0);
            tableLayoutPanel2.Controls.Add(timBtn, 6, 1);
            tableLayoutPanel2.Controls.Add(timing1, 6, 0);
            tableLayoutPanel2.Controls.Add(calibBtn, 7, 1);
            tableLayoutPanel2.Controls.Add(resetBtn, 7, 0);
            tableLayoutPanel2.Location = new Point(3, 789);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.28261F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.717392F));
            tableLayoutPanel2.Size = new Size(1899, 197);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // calibBtn
            // 
            calibBtn.BackColor = SystemColors.ActiveCaptionText;
            calibBtn.Dock = DockStyle.Fill;
            calibBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            calibBtn.ForeColor = Color.Gold;
            calibBtn.Location = new Point(1758, 145);
            calibBtn.Name = "calibBtn";
            calibBtn.Size = new Size(138, 49);
            calibBtn.TabIndex = 14;
            calibBtn.Text = "CALIB";
            calibBtn.UseVisualStyleBackColor = false;
            calibBtn.Click += Calib_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.ActiveCaptionText;
            resetBtn.Dock = DockStyle.Fill;
            resetBtn.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            resetBtn.ForeColor = Color.Gold;
            resetBtn.Location = new Point(1758, 3);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(138, 136);
            resetBtn.TabIndex = 15;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += Reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HRBR201";
            Load += Form_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private BCGPlotControl bcgPlot1;
        private BCGPlotControl bcgPlot2;
        private HRControl hrControl1;
        private BRControl brControl1;
        private TempControl tempControl1;
        private DashBoardControl dashBoardControl1;
        private System.Windows.Forms.Timer timer1;
        private controls.Timing timing1;
        private Button timBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button patsetBtn;
        private Button connectBtn;
        private Button saveBtn;
        private Button recordBtn;
        private Button startBtn;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button calibBtn;
        private Button resetBtn;
    }
}
