namespace SAPSR1
{
    partial class frmEnterMarks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaperTitle = new MetroFramework.Controls.MetroTextBox();
            this.cmbSelectPaper = new MetroFramework.Controls.MetroComboBox();
            this.txtPossible = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtExamCater = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtExamDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtExamID = new MetroFramework.Controls.MetroTextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCom = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtComment = new MetroFramework.Controls.MetroTextBox();
            this.txtMark = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtFname = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnRecord = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(23, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 129);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaperTitle);
            this.groupBox1.Controls.Add(this.cmbSelectPaper);
            this.groupBox1.Controls.Add(this.txtPossible);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtExamCater);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtExamDescription);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtExamID);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 110);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Infomation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPaperTitle
            // 
            // 
            // 
            // 
            this.txtPaperTitle.CustomButton.Image = null;
            this.txtPaperTitle.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPaperTitle.CustomButton.Name = "";
            this.txtPaperTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaperTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaperTitle.CustomButton.TabIndex = 1;
            this.txtPaperTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaperTitle.CustomButton.UseSelectable = true;
            this.txtPaperTitle.CustomButton.Visible = false;
            this.txtPaperTitle.Enabled = false;
            this.txtPaperTitle.Lines = new string[0];
            this.txtPaperTitle.Location = new System.Drawing.Point(388, 68);
            this.txtPaperTitle.MaxLength = 32767;
            this.txtPaperTitle.Name = "txtPaperTitle";
            this.txtPaperTitle.PasswordChar = '\0';
            this.txtPaperTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaperTitle.SelectedText = "";
            this.txtPaperTitle.SelectionLength = 0;
            this.txtPaperTitle.SelectionStart = 0;
            this.txtPaperTitle.ShortcutsEnabled = true;
            this.txtPaperTitle.Size = new System.Drawing.Size(215, 23);
            this.txtPaperTitle.TabIndex = 18;
            this.txtPaperTitle.UseSelectable = true;
            this.txtPaperTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaperTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbSelectPaper
            // 
            this.cmbSelectPaper.FormattingEnabled = true;
            this.cmbSelectPaper.ItemHeight = 23;
            this.cmbSelectPaper.Location = new System.Drawing.Point(104, 62);
            this.cmbSelectPaper.Name = "cmbSelectPaper";
            this.cmbSelectPaper.Size = new System.Drawing.Size(185, 29);
            this.cmbSelectPaper.TabIndex = 17;
            this.cmbSelectPaper.UseSelectable = true;
            this.cmbSelectPaper.ValueMemberChanged += new System.EventHandler(this.cmbSelectPaper_ValueMemberChanged);
            this.cmbSelectPaper.SelectedValueChanged += new System.EventHandler(this.cmbSelectPaper_SelectedValueChanged);
            this.cmbSelectPaper.TextChanged += new System.EventHandler(this.cmbSelectPaper_TextChanged);
            // 
            // txtPossible
            // 
            // 
            // 
            // 
            this.txtPossible.CustomButton.Image = null;
            this.txtPossible.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtPossible.CustomButton.Name = "";
            this.txtPossible.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPossible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPossible.CustomButton.TabIndex = 1;
            this.txtPossible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPossible.CustomButton.UseSelectable = true;
            this.txtPossible.CustomButton.Visible = false;
            this.txtPossible.Enabled = false;
            this.txtPossible.Lines = new string[0];
            this.txtPossible.Location = new System.Drawing.Point(502, 28);
            this.txtPossible.MaxLength = 32767;
            this.txtPossible.Name = "txtPossible";
            this.txtPossible.PasswordChar = '\0';
            this.txtPossible.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPossible.SelectedText = "";
            this.txtPossible.SelectionLength = 0;
            this.txtPossible.SelectionStart = 0;
            this.txtPossible.ShortcutsEnabled = true;
            this.txtPossible.Size = new System.Drawing.Size(101, 23);
            this.txtPossible.TabIndex = 15;
            this.txtPossible.UseSelectable = true;
            this.txtPossible.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPossible.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(403, 30);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Possible Mark ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(311, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Paper Title";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Select Paper ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(762, 49);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 11;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(609, 30);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Exam Catergory ";
            // 
            // txtExamCater
            // 
            // 
            // 
            // 
            this.txtExamCater.CustomButton.Image = null;
            this.txtExamCater.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtExamCater.CustomButton.Name = "";
            this.txtExamCater.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExamCater.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExamCater.CustomButton.TabIndex = 1;
            this.txtExamCater.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExamCater.CustomButton.UseSelectable = true;
            this.txtExamCater.CustomButton.Visible = false;
            this.txtExamCater.Enabled = false;
            this.txtExamCater.Lines = new string[0];
            this.txtExamCater.Location = new System.Drawing.Point(724, 28);
            this.txtExamCater.MaxLength = 32767;
            this.txtExamCater.Name = "txtExamCater";
            this.txtExamCater.PasswordChar = '\0';
            this.txtExamCater.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExamCater.SelectedText = "";
            this.txtExamCater.SelectionLength = 0;
            this.txtExamCater.SelectionStart = 0;
            this.txtExamCater.ShortcutsEnabled = true;
            this.txtExamCater.Size = new System.Drawing.Size(137, 23);
            this.txtExamCater.TabIndex = 6;
            this.txtExamCater.UseSelectable = true;
            this.txtExamCater.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExamCater.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(172, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Exam Description";
            // 
            // txtExamDescription
            // 
            // 
            // 
            // 
            this.txtExamDescription.CustomButton.Image = null;
            this.txtExamDescription.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtExamDescription.CustomButton.Name = "";
            this.txtExamDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExamDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExamDescription.CustomButton.TabIndex = 1;
            this.txtExamDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExamDescription.CustomButton.UseSelectable = true;
            this.txtExamDescription.CustomButton.Visible = false;
            this.txtExamDescription.Enabled = false;
            this.txtExamDescription.Lines = new string[0];
            this.txtExamDescription.Location = new System.Drawing.Point(288, 28);
            this.txtExamDescription.MaxLength = 32767;
            this.txtExamDescription.Name = "txtExamDescription";
            this.txtExamDescription.PasswordChar = '\0';
            this.txtExamDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExamDescription.SelectedText = "";
            this.txtExamDescription.SelectionLength = 0;
            this.txtExamDescription.SelectionStart = 0;
            this.txtExamDescription.ShortcutsEnabled = true;
            this.txtExamDescription.Size = new System.Drawing.Size(109, 23);
            this.txtExamDescription.TabIndex = 4;
            this.txtExamDescription.UseSelectable = true;
            this.txtExamDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExamDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "ExamID";
            // 
            // txtExamID
            // 
            // 
            // 
            // 
            this.txtExamID.CustomButton.Image = null;
            this.txtExamID.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txtExamID.CustomButton.Name = "";
            this.txtExamID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExamID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExamID.CustomButton.TabIndex = 1;
            this.txtExamID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExamID.CustomButton.UseSelectable = true;
            this.txtExamID.CustomButton.Visible = false;
            this.txtExamID.Enabled = false;
            this.txtExamID.Lines = new string[0];
            this.txtExamID.Location = new System.Drawing.Point(65, 28);
            this.txtExamID.MaxLength = 32767;
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.PasswordChar = '\0';
            this.txtExamID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExamID.SelectedText = "";
            this.txtExamID.SelectionLength = 0;
            this.txtExamID.SelectionStart = 0;
            this.txtExamID.ShortcutsEnabled = true;
            this.txtExamID.Size = new System.Drawing.Size(72, 23);
            this.txtExamID.TabIndex = 2;
            this.txtExamID.UseSelectable = true;
            this.txtExamID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExamID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(23, 407);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(874, 184);
            this.dgvStudents.TabIndex = 20;
            this.dgvStudents.DoubleClick += new System.EventHandler(this.dgvStudents_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCom);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txtComment);
            this.groupBox2.Controls.Add(this.txtMark);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.txtLastname);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.txtFname);
            this.groupBox2.Location = new System.Drawing.Point(26, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 128);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(487, 28);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(116, 19);
            this.lblCom.TabIndex = 9;
            this.lblCom.Text = "Teacher Comment";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 61);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Attained Mark";
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.CustomButton.Image = null;
            this.txtComment.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(606, 28);
            this.txtComment.MaxLength = 32767;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.Size = new System.Drawing.Size(255, 57);
            this.txtComment.TabIndex = 8;
            this.txtComment.UseSelectable = true;
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMark
            // 
            // 
            // 
            // 
            this.txtMark.CustomButton.Image = null;
            this.txtMark.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtMark.CustomButton.Name = "";
            this.txtMark.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMark.CustomButton.TabIndex = 1;
            this.txtMark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMark.CustomButton.UseSelectable = true;
            this.txtMark.CustomButton.Visible = false;
            this.txtMark.Lines = new string[0];
            this.txtMark.Location = new System.Drawing.Point(104, 61);
            this.txtMark.MaxLength = 32767;
            this.txtMark.Name = "txtMark";
            this.txtMark.PasswordChar = '\0';
            this.txtMark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMark.SelectedText = "";
            this.txtMark.SelectionLength = 0;
            this.txtMark.SelectionStart = 0;
            this.txtMark.ShortcutsEnabled = true;
            this.txtMark.Size = new System.Drawing.Size(125, 23);
            this.txtMark.TabIndex = 6;
            this.txtMark.UseSelectable = true;
            this.txtMark.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMark.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMark.Leave += new System.EventHandler(this.txtMark_Leave);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(245, 28);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Last Name";
            // 
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.Enabled = false;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(338, 28);
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.Size = new System.Drawing.Size(140, 23);
            this.txtLastname.TabIndex = 4;
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 28);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(73, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "First Name";
            // 
            // txtFname
            // 
            // 
            // 
            // 
            this.txtFname.CustomButton.Image = null;
            this.txtFname.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtFname.CustomButton.Name = "";
            this.txtFname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFname.CustomButton.TabIndex = 1;
            this.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFname.CustomButton.UseSelectable = true;
            this.txtFname.CustomButton.Visible = false;
            this.txtFname.Enabled = false;
            this.txtFname.Lines = new string[0];
            this.txtFname.Location = new System.Drawing.Point(104, 28);
            this.txtFname.MaxLength = 32767;
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFname.SelectedText = "";
            this.txtFname.SelectionLength = 0;
            this.txtFname.SelectionStart = 0;
            this.txtFname.ShortcutsEnabled = true;
            this.txtFname.Size = new System.Drawing.Size(125, 23);
            this.txtFname.TabIndex = 2;
            this.txtFname.UseSelectable = true;
            this.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(760, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Mark";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(448, 368);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(140, 33);
            this.btnRecord.TabIndex = 14;
            this.btnRecord.Text = "Record Mark";
            this.btnRecord.UseSelectable = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 597);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 33);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(604, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 33);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update Mark";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmEnterMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 641);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEnterMarks";
            this.Text = " Examinations Records";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtExamCater;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtExamDescription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtExamID;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnRecord;
        private MetroFramework.Controls.MetroLabel lblCom;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtComment;
        private MetroFramework.Controls.MetroTextBox txtMark;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtFname;
        private MetroFramework.Controls.MetroTextBox txtPossible;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPaperTitle;
        private MetroFramework.Controls.MetroComboBox cmbSelectPaper;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}