namespace HRBR_V300
{
    partial class DashBoardControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            hrDB = new ScottPlot.WinForms.FormsPlot();
            brDB = new ScottPlot.WinForms.FormsPlot();
            tDB = new ScottPlot.WinForms.FormsPlot();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.08889F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.91111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 541F));
            tableLayoutPanel1.Controls.Add(hrDB, 0, 0);
            tableLayoutPanel1.Controls.Add(brDB, 1, 0);
            tableLayoutPanel1.Controls.Add(tDB, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1678, 248);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // hrDB
            // 
            hrDB.DisplayScale = 1F;
            hrDB.Dock = DockStyle.Fill;
            hrDB.Location = new Point(3, 3);
            hrDB.Name = "hrDB";
            hrDB.Size = new Size(540, 242);
            hrDB.TabIndex = 0;
            // 
            // brDB
            // 
            brDB.DisplayScale = 1F;
            brDB.Dock = DockStyle.Fill;
            brDB.Font = new Font("Segoe UI", 9F);
            brDB.Location = new Point(549, 3);
            brDB.Name = "brDB";
            brDB.Size = new Size(584, 242);
            brDB.TabIndex = 1;
            // 
            // tDB
            // 
            tDB.DisplayScale = 1F;
            tDB.Dock = DockStyle.Fill;
            tDB.Location = new Point(1139, 3);
            tDB.Name = "tDB";
            tDB.Size = new Size(536, 242);
            tDB.TabIndex = 2;
            // 
            // DashBoardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DashBoardControl";
            Size = new Size(1860, 325);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot hrDB;
        private ScottPlot.WinForms.FormsPlot brDB;
        private ScottPlot.WinForms.FormsPlot tDB;
    }
}
