namespace SAPSR1
{
    partial class frmStudentDetails
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Student = new MetroFramework.Controls.MetroTabControl();
            this.tabStudentInfo = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbClassRoom = new MetroFramework.Controls.MetroComboBox();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.rdbMale = new MetroFramework.Controls.MetroRadioButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.txtEnroiD = new MetroFramework.Controls.MetroTextBox();
            this.StudentID = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtMidName = new MetroFramework.Controls.MetroTextBox();
            this.tXTSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtDob = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabContactDetails = new MetroFramework.Controls.MetroTabPage();
            this.btnNext1 = new MetroFramework.Controls.MetroButton();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tabGuardianFname = new MetroFramework.Controls.MetroTabPage();
            this.btnFinish = new MetroFramework.Controls.MetroButton();
            this.txtGuardianFname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtGuardianSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtMobileNumbe = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtRel = new MetroFramework.Controls.MetroTextBox();
            this.relationship = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.Student.SuspendLayout();
            this.tabStudentInfo.SuspendLayout();
            this.tabContactDetails.SuspendLayout();
            this.tabGuardianFname.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "First Name ";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // Student
            // 
            this.Student.Controls.Add(this.tabStudentInfo);
            this.Student.Controls.Add(this.tabContactDetails);
            this.Student.Controls.Add(this.tabGuardianFname);
            this.Student.Location = new System.Drawing.Point(21, 91);
            this.Student.Name = "Student";
            this.Student.SelectedIndex = 2;
            this.Student.Size = new System.Drawing.Size(494, 410);
            this.Student.TabIndex = 1;
            this.Student.UseSelectable = true;
            // 
            // tabStudentInfo
            // 
            this.tabStudentInfo.Controls.Add(this.metroLabel11);
            this.tabStudentInfo.Controls.Add(this.cmbClassRoom);
            this.tabStudentInfo.Controls.Add(this.btnGenerate);
            this.tabStudentInfo.Controls.Add(this.metroLabel12);
            this.tabStudentInfo.Controls.Add(this.metroRadioButton2);
            this.tabStudentInfo.Controls.Add(this.rdbMale);
            this.tabStudentInfo.Controls.Add(this.btnNext);
            this.tabStudentInfo.Controls.Add(this.txtEnroiD);
            this.tabStudentInfo.Controls.Add(this.StudentID);
            this.tabStudentInfo.Controls.Add(this.txtFirstName);
            this.tabStudentInfo.Controls.Add(this.txtMidName);
            this.tabStudentInfo.Controls.Add(this.tXTSurname);
            this.tabStudentInfo.Controls.Add(this.txtDob);
            this.tabStudentInfo.Controls.Add(this.metroLabel4);
            this.tabStudentInfo.Controls.Add(this.metroLabel3);
            this.tabStudentInfo.Controls.Add(this.metroLabel2);
            this.tabStudentInfo.Controls.Add(this.metroLabel1);
            this.tabStudentInfo.HorizontalScrollbarBarColor = true;
            this.tabStudentInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStudentInfo.HorizontalScrollbarSize = 10;
            this.tabStudentInfo.Location = new System.Drawing.Point(4, 38);
            this.tabStudentInfo.Name = "tabStudentInfo";
            this.tabStudentInfo.Size = new System.Drawing.Size(486, 368);
            this.tabStudentInfo.TabIndex = 0;
            this.tabStudentInfo.Text = "Student";
            this.tabStudentInfo.VerticalScrollbarBarColor = true;
            this.tabStudentInfo.VerticalScrollbarHighlightOnWheel = false;
            this.tabStudentInfo.VerticalScrollbarSize = 10;
            this.tabStudentInfo.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 259);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(76, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Select Class";
            // 
            // cmbClassRoom
            // 
            this.cmbClassRoom.FormattingEnabled = true;
            this.cmbClassRoom.ItemHeight = 23;
            this.cmbClassRoom.Location = new System.Drawing.Point(149, 249);
            this.cmbClassRoom.Name = "cmbClassRoom";
            this.cmbClassRoom.Size = new System.Drawing.Size(231, 29);
            this.cmbClassRoom.TabIndex = 15;
            this.cmbClassRoom.UseSelectable = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(292, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "add Existing";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 213);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(52, 19);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Gender";
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(217, 213);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(59, 15);
            this.metroRadioButton2.TabIndex = 13;
            this.metroRadioButton2.Text = "female";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(149, 213);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(49, 15);
            this.rdbMale.TabIndex = 12;
            this.rdbMale.Text = "male";
            this.rdbMale.UseSelectable = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(292, 306);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 42);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEnroiD
            // 
            // 
            // 
            // 
            this.txtEnroiD.CustomButton.Image = null;
            this.txtEnroiD.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtEnroiD.CustomButton.Name = "";
            this.txtEnroiD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnroiD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnroiD.CustomButton.TabIndex = 1;
            this.txtEnroiD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnroiD.CustomButton.UseSelectable = true;
            this.txtEnroiD.CustomButton.Visible = false;
            this.txtEnroiD.Enabled = false;
            this.txtEnroiD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEnroiD.Lines = new string[0];
            this.txtEnroiD.Location = new System.Drawing.Point(149, 14);
            this.txtEnroiD.MaxLength = 32767;
            this.txtEnroiD.Name = "txtEnroiD";
            this.txtEnroiD.PasswordChar = '\0';
            this.txtEnroiD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnroiD.SelectedText = "";
            this.txtEnroiD.SelectionLength = 0;
            this.txtEnroiD.SelectionStart = 0;
            this.txtEnroiD.ShortcutsEnabled = true;
            this.txtEnroiD.Size = new System.Drawing.Size(137, 23);
            this.txtEnroiD.TabIndex = 10;
            this.txtEnroiD.UseSelectable = true;
            this.txtEnroiD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnroiD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(3, 18);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(73, 19);
            this.StudentID.TabIndex = 9;
            this.StudentID.Text = "Student ID ";
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(149, 51);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(231, 23);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMidName
            // 
            // 
            // 
            // 
            this.txtMidName.CustomButton.Image = null;
            this.txtMidName.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtMidName.CustomButton.Name = "";
            this.txtMidName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMidName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMidName.CustomButton.TabIndex = 1;
            this.txtMidName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMidName.CustomButton.UseSelectable = true;
            this.txtMidName.CustomButton.Visible = false;
            this.txtMidName.Lines = new string[0];
            this.txtMidName.Location = new System.Drawing.Point(149, 85);
            this.txtMidName.MaxLength = 32767;
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.PasswordChar = '\0';
            this.txtMidName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMidName.SelectedText = "";
            this.txtMidName.SelectionLength = 0;
            this.txtMidName.SelectionStart = 0;
            this.txtMidName.ShortcutsEnabled = true;
            this.txtMidName.Size = new System.Drawing.Size(231, 23);
            this.txtMidName.TabIndex = 7;
            this.txtMidName.UseSelectable = true;
            this.txtMidName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMidName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tXTSurname
            // 
            // 
            // 
            // 
            this.tXTSurname.CustomButton.Image = null;
            this.tXTSurname.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.tXTSurname.CustomButton.Name = "";
            this.tXTSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tXTSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tXTSurname.CustomButton.TabIndex = 1;
            this.tXTSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tXTSurname.CustomButton.UseSelectable = true;
            this.tXTSurname.CustomButton.Visible = false;
            this.tXTSurname.Lines = new string[0];
            this.tXTSurname.Location = new System.Drawing.Point(149, 119);
            this.tXTSurname.MaxLength = 32767;
            this.tXTSurname.Name = "tXTSurname";
            this.tXTSurname.PasswordChar = '\0';
            this.tXTSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tXTSurname.SelectedText = "";
            this.tXTSurname.SelectionLength = 0;
            this.tXTSurname.SelectionStart = 0;
            this.tXTSurname.ShortcutsEnabled = true;
            this.tXTSurname.Size = new System.Drawing.Size(231, 23);
            this.tXTSurname.TabIndex = 6;
            this.tXTSurname.UseSelectable = true;
            this.tXTSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tXTSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(149, 165);
            this.txtDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(176, 29);
            this.txtDob.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "DOB";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 119);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Surname";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Middle Name";
            // 
            // tabContactDetails
            // 
            this.tabContactDetails.Controls.Add(this.btnNext1);
            this.tabContactDetails.Controls.Add(this.txtPhone);
            this.tabContactDetails.Controls.Add(this.metroLabel6);
            this.tabContactDetails.Controls.Add(this.txtAddress);
            this.tabContactDetails.Controls.Add(this.metroLabel5);
            this.tabContactDetails.HorizontalScrollbarBarColor = true;
            this.tabContactDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.tabContactDetails.HorizontalScrollbarSize = 10;
            this.tabContactDetails.Location = new System.Drawing.Point(4, 38);
            this.tabContactDetails.Name = "tabContactDetails";
            this.tabContactDetails.Size = new System.Drawing.Size(486, 368);
            this.tabContactDetails.TabIndex = 1;
            this.tabContactDetails.Text = "Contact Details";
            this.tabContactDetails.VerticalScrollbarBarColor = true;
            this.tabContactDetails.VerticalScrollbarHighlightOnWheel = false;
            this.tabContactDetails.VerticalScrollbarSize = 10;
            this.tabContactDetails.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(378, 213);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(105, 23);
            this.btnNext1.TabIndex = 12;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseSelectable = true;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(124, 101);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(231, 23);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 101);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Phone";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(124, 20);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(231, 70);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Address";
            // 
            // tabGuardianFname
            // 
            this.tabGuardianFname.Controls.Add(this.txtRel);
            this.tabGuardianFname.Controls.Add(this.relationship);
            this.tabGuardianFname.Controls.Add(this.txtEmail);
            this.tabGuardianFname.Controls.Add(this.metroLabel8);
            this.tabGuardianFname.Controls.Add(this.btnFinish);
            this.tabGuardianFname.Controls.Add(this.txtGuardianFname);
            this.tabGuardianFname.Controls.Add(this.metroLabel7);
            this.tabGuardianFname.Controls.Add(this.txtGuardianSurname);
            this.tabGuardianFname.Controls.Add(this.txtMobileNumbe);
            this.tabGuardianFname.Controls.Add(this.metroLabel9);
            this.tabGuardianFname.Controls.Add(this.metroLabel10);
            this.tabGuardianFname.HorizontalScrollbarBarColor = true;
            this.tabGuardianFname.HorizontalScrollbarHighlightOnWheel = false;
            this.tabGuardianFname.HorizontalScrollbarSize = 10;
            this.tabGuardianFname.Location = new System.Drawing.Point(4, 38);
            this.tabGuardianFname.Name = "tabGuardianFname";
            this.tabGuardianFname.Size = new System.Drawing.Size(486, 368);
            this.tabGuardianFname.TabIndex = 2;
            this.tabGuardianFname.Text = "Guardian";
            this.tabGuardianFname.VerticalScrollbarBarColor = true;
            this.tabGuardianFname.VerticalScrollbarHighlightOnWheel = false;
            this.tabGuardianFname.VerticalScrollbarSize = 10;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(275, 293);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(105, 23);
            this.btnFinish.TabIndex = 19;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseSelectable = true;
            // 
            // txtGuardianFname
            // 
            // 
            // 
            // 
            this.txtGuardianFname.CustomButton.Image = null;
            this.txtGuardianFname.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtGuardianFname.CustomButton.Name = "";
            this.txtGuardianFname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuardianFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuardianFname.CustomButton.TabIndex = 1;
            this.txtGuardianFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuardianFname.CustomButton.UseSelectable = true;
            this.txtGuardianFname.CustomButton.Visible = false;
            this.txtGuardianFname.Lines = new string[0];
            this.txtGuardianFname.Location = new System.Drawing.Point(149, 16);
            this.txtGuardianFname.MaxLength = 32767;
            this.txtGuardianFname.Name = "txtGuardianFname";
            this.txtGuardianFname.PasswordChar = '\0';
            this.txtGuardianFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuardianFname.SelectedText = "";
            this.txtGuardianFname.SelectionLength = 0;
            this.txtGuardianFname.SelectionStart = 0;
            this.txtGuardianFname.ShortcutsEnabled = true;
            this.txtGuardianFname.Size = new System.Drawing.Size(231, 23);
            this.txtGuardianFname.TabIndex = 18;
            this.txtGuardianFname.UseSelectable = true;
            this.txtGuardianFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuardianFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuardianFname.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(130, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Guardian First Name";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // txtGuardianSurname
            // 
            // 
            // 
            // 
            this.txtGuardianSurname.CustomButton.Image = null;
            this.txtGuardianSurname.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtGuardianSurname.CustomButton.Name = "";
            this.txtGuardianSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuardianSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuardianSurname.CustomButton.TabIndex = 1;
            this.txtGuardianSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuardianSurname.CustomButton.UseSelectable = true;
            this.txtGuardianSurname.CustomButton.Visible = false;
            this.txtGuardianSurname.Lines = new string[0];
            this.txtGuardianSurname.Location = new System.Drawing.Point(149, 53);
            this.txtGuardianSurname.MaxLength = 32767;
            this.txtGuardianSurname.Name = "txtGuardianSurname";
            this.txtGuardianSurname.PasswordChar = '\0';
            this.txtGuardianSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuardianSurname.SelectedText = "";
            this.txtGuardianSurname.SelectionLength = 0;
            this.txtGuardianSurname.SelectionStart = 0;
            this.txtGuardianSurname.ShortcutsEnabled = true;
            this.txtGuardianSurname.Size = new System.Drawing.Size(231, 23);
            this.txtGuardianSurname.TabIndex = 16;
            this.txtGuardianSurname.UseSelectable = true;
            this.txtGuardianSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuardianSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuardianSurname.Click += new System.EventHandler(this.metroTextBox4_Click);
            // 
            // txtMobileNumbe
            // 
            // 
            // 
            // 
            this.txtMobileNumbe.CustomButton.Image = null;
            this.txtMobileNumbe.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtMobileNumbe.CustomButton.Name = "";
            this.txtMobileNumbe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMobileNumbe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobileNumbe.CustomButton.TabIndex = 1;
            this.txtMobileNumbe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobileNumbe.CustomButton.UseSelectable = true;
            this.txtMobileNumbe.CustomButton.Visible = false;
            this.txtMobileNumbe.Lines = new string[0];
            this.txtMobileNumbe.Location = new System.Drawing.Point(149, 87);
            this.txtMobileNumbe.MaxLength = 32767;
            this.txtMobileNumbe.Name = "txtMobileNumbe";
            this.txtMobileNumbe.PasswordChar = '\0';
            this.txtMobileNumbe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobileNumbe.SelectedText = "";
            this.txtMobileNumbe.SelectionLength = 0;
            this.txtMobileNumbe.SelectionStart = 0;
            this.txtMobileNumbe.ShortcutsEnabled = true;
            this.txtMobileNumbe.Size = new System.Drawing.Size(231, 23);
            this.txtMobileNumbe.TabIndex = 15;
            this.txtMobileNumbe.UseSelectable = true;
            this.txtMobileNumbe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobileNumbe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMobileNumbe.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 87);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(76, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Mobile No ";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 53);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(122, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Guardian Surname ";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(149, 130);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(231, 23);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 130);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(90, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "email address";
            // 
            // txtRel
            // 
            // 
            // 
            // 
            this.txtRel.CustomButton.Image = null;
            this.txtRel.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtRel.CustomButton.Name = "";
            this.txtRel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRel.CustomButton.TabIndex = 1;
            this.txtRel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRel.CustomButton.UseSelectable = true;
            this.txtRel.CustomButton.Visible = false;
            this.txtRel.Lines = new string[0];
            this.txtRel.Location = new System.Drawing.Point(149, 182);
            this.txtRel.MaxLength = 32767;
            this.txtRel.Name = "txtRel";
            this.txtRel.PasswordChar = '\0';
            this.txtRel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRel.SelectedText = "";
            this.txtRel.SelectionLength = 0;
            this.txtRel.SelectionStart = 0;
            this.txtRel.ShortcutsEnabled = true;
            this.txtRel.Size = new System.Drawing.Size(231, 23);
            this.txtRel.TabIndex = 23;
            this.txtRel.UseSelectable = true;
            this.txtRel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // relationship
            // 
            this.relationship.AutoSize = true;
            this.relationship.Location = new System.Drawing.Point(3, 182);
            this.relationship.Name = "relationship";
            this.relationship.Size = new System.Drawing.Size(76, 19);
            this.relationship.TabIndex = 22;
            this.relationship.Text = "relationship";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 42);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 572);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Student);
            this.Name = "frmStudentDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frmStudentDetails_Load);
            this.Student.ResumeLayout(false);
            this.tabStudentInfo.ResumeLayout(false);
            this.tabStudentInfo.PerformLayout();
            this.tabContactDetails.ResumeLayout(false);
            this.tabContactDetails.PerformLayout();
            this.tabGuardianFname.ResumeLayout(false);
            this.tabGuardianFname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl Student;
        private MetroFramework.Controls.MetroTabPage tabStudentInfo;
        private MetroFramework.Controls.MetroTabPage tabContactDetails;
        private MetroFramework.Controls.MetroTabPage tabGuardianFname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tXTSurname;
        private MetroFramework.Controls.MetroDateTime txtDob;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroTextBox txtMidName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroTextBox txtEnroiD;
        private MetroFramework.Controls.MetroLabel StudentID;
        private MetroFramework.Controls.MetroButton btnNext1;
        private MetroFramework.Controls.MetroTextBox txtGuardianFname;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtGuardianSurname;
        private MetroFramework.Controls.MetroTextBox txtMobileNumbe;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnFinish;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton rdbMale;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbClassRoom;
        private MetroFramework.Controls.MetroTextBox txtRel;
        private MetroFramework.Controls.MetroLabel relationship;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}