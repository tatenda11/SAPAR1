namespace SAPSR1
{
    partial class frmExams
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateExam = new MetroFramework.Controls.MetroButton();
            this.btnSaveExam = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtExamDes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtExamTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbGrade = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbExamType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbSubject = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPapers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdatepaper = new MetroFramework.Controls.MetroButton();
            this.btnSavePaper = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPaperDes = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtPossibleMark = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPaperTitle = new System.Windows.Forms.TextBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 72);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(894, 425);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(886, 383);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Examination";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.dgvExams);
            this.groupBox2.Location = new System.Drawing.Point(555, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 318);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Exams";
            // 
            // dgvExams
            // 
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.Location = new System.Drawing.Point(3, 16);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.Size = new System.Drawing.Size(314, 299);
            this.dgvExams.TabIndex = 0;
            this.dgvExams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellContentClick);
            this.dgvExams.SelectionChanged += new System.EventHandler(this.dgvExams_SelectionChanged);
            this.dgvExams.DoubleClick += new System.EventHandler(this.dgvExams_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnUpdateExam);
            this.groupBox1.Controls.Add(this.btnSaveExam);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtExamDes);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtExamTitle);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cmbGrade);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cmbExamType);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cmbSubject);
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 318);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examination Details";
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.Location = new System.Drawing.Point(168, 235);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(143, 53);
            this.btnUpdateExam.TabIndex = 11;
            this.btnUpdateExam.Text = "Update";
            this.btnUpdateExam.UseSelectable = true;
            this.btnUpdateExam.Click += new System.EventHandler(this.btnUpdateExam_Click);
            // 
            // btnSaveExam
            // 
            this.btnSaveExam.Location = new System.Drawing.Point(7, 235);
            this.btnSaveExam.Name = "btnSaveExam";
            this.btnSaveExam.Size = new System.Drawing.Size(143, 53);
            this.btnSaveExam.TabIndex = 10;
            this.btnSaveExam.Text = "Save";
            this.btnSaveExam.UseSelectable = true;
            this.btnSaveExam.Click += new System.EventHandler(this.btnSaveExam_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 102);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Exam Description";
            // 
            // txtExamDes
            // 
            // 
            // 
            // 
            this.txtExamDes.CustomButton.Image = null;
            this.txtExamDes.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtExamDes.CustomButton.Name = "";
            this.txtExamDes.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtExamDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExamDes.CustomButton.TabIndex = 1;
            this.txtExamDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExamDes.CustomButton.UseSelectable = true;
            this.txtExamDes.CustomButton.Visible = false;
            this.txtExamDes.Lines = new string[0];
            this.txtExamDes.Location = new System.Drawing.Point(6, 133);
            this.txtExamDes.MaxLength = 32767;
            this.txtExamDes.Multiline = true;
            this.txtExamDes.Name = "txtExamDes";
            this.txtExamDes.PasswordChar = '\0';
            this.txtExamDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExamDes.SelectedText = "";
            this.txtExamDes.SelectionLength = 0;
            this.txtExamDes.SelectionStart = 0;
            this.txtExamDes.ShortcutsEnabled = true;
            this.txtExamDes.Size = new System.Drawing.Size(243, 81);
            this.txtExamDes.TabIndex = 8;
            this.txtExamDes.UseSelectable = true;
            this.txtExamDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExamDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(275, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Exam title";
            // 
            // txtExamTitle
            // 
            // 
            // 
            // 
            this.txtExamTitle.CustomButton.Image = null;
            this.txtExamTitle.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtExamTitle.CustomButton.Name = "";
            this.txtExamTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExamTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExamTitle.CustomButton.TabIndex = 1;
            this.txtExamTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExamTitle.CustomButton.UseSelectable = true;
            this.txtExamTitle.CustomButton.Visible = false;
            this.txtExamTitle.Lines = new string[0];
            this.txtExamTitle.Location = new System.Drawing.Point(275, 133);
            this.txtExamTitle.MaxLength = 32767;
            this.txtExamTitle.Name = "txtExamTitle";
            this.txtExamTitle.PasswordChar = '\0';
            this.txtExamTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExamTitle.SelectedText = "";
            this.txtExamTitle.SelectionLength = 0;
            this.txtExamTitle.SelectionStart = 0;
            this.txtExamTitle.ShortcutsEnabled = true;
            this.txtExamTitle.Size = new System.Drawing.Size(244, 23);
            this.txtExamTitle.TabIndex = 6;
            this.txtExamTitle.UseSelectable = true;
            this.txtExamTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExamTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(368, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "grade";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 23;
            this.cmbGrade.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbGrade.Location = new System.Drawing.Point(368, 48);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(51, 29);
            this.cmbGrade.TabIndex = 4;
            this.cmbGrade.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Exam Type";
            // 
            // cmbExamType
            // 
            this.cmbExamType.FormattingEnabled = true;
            this.cmbExamType.ItemHeight = 23;
            this.cmbExamType.Items.AddRange(new object[] {
            "INCLASS EXAM",
            "END OF TERM"});
            this.cmbExamType.Location = new System.Drawing.Point(168, 48);
            this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.Size = new System.Drawing.Size(179, 29);
            this.cmbExamType.TabIndex = 2;
            this.cmbExamType.UseSelectable = true;
            this.cmbExamType.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select Subject";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.ItemHeight = 23;
            this.cmbSubject.Items.AddRange(new object[] {
            "MATHEMATICS",
            "ENGLISH",
            "GENERAL PAPER",
            "NDEBELE"});
            this.cmbSubject.Location = new System.Drawing.Point(6, 48);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(144, 29);
            this.cmbSubject.TabIndex = 0;
            this.cmbSubject.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox4);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(886, 383);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Exam Papers";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.dgvPapers);
            this.groupBox4.Location = new System.Drawing.Point(492, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 338);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Papers For Exam";
            // 
            // dgvPapers
            // 
            this.dgvPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPapers.Location = new System.Drawing.Point(3, 16);
            this.dgvPapers.Name = "dgvPapers";
            this.dgvPapers.Size = new System.Drawing.Size(385, 319);
            this.dgvPapers.TabIndex = 0;
            this.dgvPapers.DoubleClick += new System.EventHandler(this.dgvPapers_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.btnUpdatepaper);
            this.groupBox3.Controls.Add(this.btnSavePaper);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.txtPaperDes);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.txtPossibleMark);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.txtPaperTitle);
            this.groupBox3.Location = new System.Drawing.Point(9, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Paper Details";
            // 
            // btnUpdatepaper
            // 
            this.btnUpdatepaper.Location = new System.Drawing.Point(175, 231);
            this.btnUpdatepaper.Name = "btnUpdatepaper";
            this.btnUpdatepaper.Size = new System.Drawing.Size(143, 53);
            this.btnUpdatepaper.TabIndex = 12;
            this.btnUpdatepaper.Text = "Update";
            this.btnUpdatepaper.UseSelectable = true;
            this.btnUpdatepaper.Click += new System.EventHandler(this.btnUpdatepaper_Click);
            // 
            // btnSavePaper
            // 
            this.btnSavePaper.Location = new System.Drawing.Point(15, 231);
            this.btnSavePaper.Name = "btnSavePaper";
            this.btnSavePaper.Size = new System.Drawing.Size(143, 53);
            this.btnSavePaper.TabIndex = 11;
            this.btnSavePaper.Text = "Save";
            this.btnSavePaper.UseSelectable = true;
            this.btnSavePaper.Click += new System.EventHandler(this.btnSavePaper_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 90);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Paper Description";
            // 
            // txtPaperDes
            // 
            this.txtPaperDes.Location = new System.Drawing.Point(15, 112);
            this.txtPaperDes.Multiline = true;
            this.txtPaperDes.Name = "txtPaperDes";
            this.txtPaperDes.Size = new System.Drawing.Size(303, 102);
            this.txtPaperDes.TabIndex = 5;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(175, 30);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(89, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Possible Mark";
            // 
            // txtPossibleMark
            // 
            this.txtPossibleMark.Location = new System.Drawing.Point(175, 52);
            this.txtPossibleMark.Name = "txtPossibleMark";
            this.txtPossibleMark.Size = new System.Drawing.Size(143, 20);
            this.txtPossibleMark.TabIndex = 3;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 30);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Paper Title";
            // 
            // txtPaperTitle
            // 
            this.txtPaperTitle.Location = new System.Drawing.Point(15, 52);
            this.txtPaperTitle.Name = "txtPaperTitle";
            this.txtPaperTitle.Size = new System.Drawing.Size(143, 20);
            this.txtPaperTitle.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(36, 503);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 53);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // frmExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 573);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmExams";
            this.Text = "Manage Exams";
            this.Load += new System.EventHandler(this.frmExams_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbGrade;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbExamType;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbSubject;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExams;
        private MetroFramework.Controls.MetroButton btnUpdateExam;
        private MetroFramework.Controls.MetroButton btnSaveExam;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtExamDes;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtExamTitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPapers;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnUpdatepaper;
        private MetroFramework.Controls.MetroButton btnSavePaper;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox txtPaperDes;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtPossibleMark;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtPaperTitle;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}