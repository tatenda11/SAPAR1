namespace SAPSR1
{
    partial class frmClassExams
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbExamTye = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchExam = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.btnRecordMarks = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.cmbExamTye);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtSearchExam);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examanation Information";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(316, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(183, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "End Of Term Exam By Subject";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(505, 31);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(155, 55);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "View End Of Term Exams";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbExamTye
            // 
            this.cmbExamTye.FormattingEnabled = true;
            this.cmbExamTye.ItemHeight = 23;
            this.cmbExamTye.Items.AddRange(new object[] {
            "MATHEMATICS",
            "ENGLISH",
            "GENERAL PAPER",
            "NDEBELE"});
            this.cmbExamTye.Location = new System.Drawing.Point(321, 57);
            this.cmbExamTye.Name = "cmbExamTye";
            this.cmbExamTye.Size = new System.Drawing.Size(145, 29);
            this.cmbExamTye.TabIndex = 2;
            this.cmbExamTye.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Search Exam By Name";
            // 
            // txtSearchExam
            // 
            // 
            // 
            // 
            this.txtSearchExam.CustomButton.Image = null;
            this.txtSearchExam.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.txtSearchExam.CustomButton.Name = "";
            this.txtSearchExam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchExam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchExam.CustomButton.TabIndex = 1;
            this.txtSearchExam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchExam.CustomButton.UseSelectable = true;
            this.txtSearchExam.CustomButton.Visible = false;
            this.txtSearchExam.Lines = new string[0];
            this.txtSearchExam.Location = new System.Drawing.Point(7, 57);
            this.txtSearchExam.MaxLength = 32767;
            this.txtSearchExam.Name = "txtSearchExam";
            this.txtSearchExam.PasswordChar = '\0';
            this.txtSearchExam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchExam.SelectedText = "";
            this.txtSearchExam.SelectionLength = 0;
            this.txtSearchExam.SelectionStart = 0;
            this.txtSearchExam.ShortcutsEnabled = true;
            this.txtSearchExam.Size = new System.Drawing.Size(291, 23);
            this.txtSearchExam.TabIndex = 0;
            this.txtSearchExam.UseSelectable = true;
            this.txtSearchExam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchExam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchExam.TextChanged += new System.EventHandler(this.txtSearchExam_TextChanged);
            this.txtSearchExam.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.txtSearchExam.Leave += new System.EventHandler(this.txtSearchExam_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvExams);
            this.groupBox2.Location = new System.Drawing.Point(23, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "exam list";
            // 
            // dgvExams
            // 
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.Location = new System.Drawing.Point(3, 16);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.Size = new System.Drawing.Size(734, 184);
            this.dgvExams.TabIndex = 0;
            this.dgvExams.DoubleClick += new System.EventHandler(this.dgvExams_DoubleClick);
            // 
            // btnRecordMarks
            // 
            this.btnRecordMarks.Location = new System.Drawing.Point(26, 427);
            this.btnRecordMarks.Name = "btnRecordMarks";
            this.btnRecordMarks.Size = new System.Drawing.Size(152, 53);
            this.btnRecordMarks.TabIndex = 2;
            this.btnRecordMarks.Text = "Record Marks";
            this.btnRecordMarks.UseSelectable = true;
            this.btnRecordMarks.Click += new System.EventHandler(this.btnRecordMarks_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(198, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 53);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // frmClassExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRecordMarks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClassExams";
            this.Text = "Exams For Your Class";
            this.Load += new System.EventHandler(this.frmClassExams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchExam;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbExamTye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExams;
        private MetroFramework.Controls.MetroButton btnRecordMarks;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}