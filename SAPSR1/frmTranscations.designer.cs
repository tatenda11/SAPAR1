namespace SAPSR1
{
    partial class frmTransactions
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnProcess = new MetroFramework.Controls.MetroButton();
            this.txtTranDate = new MetroFramework.Controls.MetroDateTime();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCurBalance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtOpenBal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtClass = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtEnrolId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbPayTyp = new MetroFramework.Controls.MetroComboBox();
            this.txtRefNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtTranDetails = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTranscations = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranscations)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(601, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Amount Paid US $";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(551, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Transaction  Date ";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(29, 374);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(114, 37);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Process Transacation";
            this.btnProcess.UseSelectable = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtTranDate
            // 
            this.txtTranDate.Location = new System.Drawing.Point(669, 19);
            this.txtTranDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtTranDate.Name = "txtTranDate";
            this.txtTranDate.Size = new System.Drawing.Size(178, 29);
            this.txtTranDate.TabIndex = 8;
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(733, 73);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(114, 23);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.Click += new System.EventHandler(this.metroTextBox1_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(757, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaid);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.txtCurBalance);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txtOpenBal);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.txtEnrolId);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 122);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPaid
            // 
            // 
            // 
            // 
            this.txtPaid.CustomButton.Image = null;
            this.txtPaid.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtPaid.CustomButton.Name = "";
            this.txtPaid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaid.CustomButton.TabIndex = 1;
            this.txtPaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaid.CustomButton.UseSelectable = true;
            this.txtPaid.CustomButton.Visible = false;
            this.txtPaid.Lines = new string[0];
            this.txtPaid.Location = new System.Drawing.Point(433, 67);
            this.txtPaid.MaxLength = 32767;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.PasswordChar = '\0';
            this.txtPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaid.SelectedText = "";
            this.txtPaid.SelectionLength = 0;
            this.txtPaid.SelectionStart = 0;
            this.txtPaid.ShortcutsEnabled = true;
            this.txtPaid.Size = new System.Drawing.Size(64, 23);
            this.txtPaid.TabIndex = 34;
            this.txtPaid.UseSelectable = true;
            this.txtPaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(364, 71);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(65, 19);
            this.metroLabel11.TabIndex = 33;
            this.metroLabel11.Text = "total paid";
            // 
            // txtCurBalance
            // 
            // 
            // 
            // 
            this.txtCurBalance.CustomButton.Image = null;
            this.txtCurBalance.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtCurBalance.CustomButton.Name = "";
            this.txtCurBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurBalance.CustomButton.TabIndex = 1;
            this.txtCurBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurBalance.CustomButton.UseSelectable = true;
            this.txtCurBalance.CustomButton.Visible = false;
            this.txtCurBalance.Lines = new string[0];
            this.txtCurBalance.Location = new System.Drawing.Point(294, 67);
            this.txtCurBalance.MaxLength = 32767;
            this.txtCurBalance.Name = "txtCurBalance";
            this.txtCurBalance.PasswordChar = '\0';
            this.txtCurBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurBalance.SelectedText = "";
            this.txtCurBalance.SelectionLength = 0;
            this.txtCurBalance.SelectionStart = 0;
            this.txtCurBalance.ShortcutsEnabled = true;
            this.txtCurBalance.Size = new System.Drawing.Size(64, 23);
            this.txtCurBalance.TabIndex = 32;
            this.txtCurBalance.UseSelectable = true;
            this.txtCurBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(186, 71);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 19);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "current balance ";
            // 
            // txtOpenBal
            // 
            // 
            // 
            // 
            this.txtOpenBal.CustomButton.Image = null;
            this.txtOpenBal.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtOpenBal.CustomButton.Name = "";
            this.txtOpenBal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOpenBal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpenBal.CustomButton.TabIndex = 1;
            this.txtOpenBal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpenBal.CustomButton.UseSelectable = true;
            this.txtOpenBal.CustomButton.Visible = false;
            this.txtOpenBal.Enabled = false;
            this.txtOpenBal.Lines = new string[0];
            this.txtOpenBal.Location = new System.Drawing.Point(116, 71);
            this.txtOpenBal.MaxLength = 32767;
            this.txtOpenBal.Name = "txtOpenBal";
            this.txtOpenBal.PasswordChar = '\0';
            this.txtOpenBal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpenBal.SelectedText = "";
            this.txtOpenBal.SelectionLength = 0;
            this.txtOpenBal.SelectionStart = 0;
            this.txtOpenBal.ShortcutsEnabled = true;
            this.txtOpenBal.Size = new System.Drawing.Size(64, 23);
            this.txtOpenBal.TabIndex = 30;
            this.txtOpenBal.UseSelectable = true;
            this.txtOpenBal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOpenBal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 71);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(110, 19);
            this.metroLabel9.TabIndex = 29;
            this.metroLabel9.Text = "opening balance ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(641, 34);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(35, 19);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "class";
            // 
            // txtClass
            // 
            // 
            // 
            // 
            this.txtClass.CustomButton.Image = null;
            this.txtClass.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtClass.CustomButton.Name = "";
            this.txtClass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClass.CustomButton.TabIndex = 1;
            this.txtClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClass.CustomButton.UseSelectable = true;
            this.txtClass.CustomButton.Visible = false;
            this.txtClass.Enabled = false;
            this.txtClass.Lines = new string[0];
            this.txtClass.Location = new System.Drawing.Point(682, 30);
            this.txtClass.MaxLength = 32767;
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClass.SelectedText = "";
            this.txtClass.SelectionLength = 0;
            this.txtClass.SelectionStart = 0;
            this.txtClass.ShortcutsEnabled = true;
            this.txtClass.Size = new System.Drawing.Size(114, 23);
            this.txtClass.TabIndex = 27;
            this.txtClass.UseSelectable = true;
            this.txtClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.Enabled = false;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(496, 30);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(139, 23);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(426, 34);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Last Name";
            // 
            // txtFname
            // 
            // 
            // 
            // 
            this.txtFname.CustomButton.Image = null;
            this.txtFname.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtFname.CustomButton.Name = "";
            this.txtFname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFname.CustomButton.TabIndex = 1;
            this.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFname.CustomButton.UseSelectable = true;
            this.txtFname.CustomButton.Visible = false;
            this.txtFname.Enabled = false;
            this.txtFname.Lines = new string[0];
            this.txtFname.Location = new System.Drawing.Point(294, 30);
            this.txtFname.MaxLength = 32767;
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFname.SelectedText = "";
            this.txtFname.SelectionLength = 0;
            this.txtFname.SelectionStart = 0;
            this.txtFname.ShortcutsEnabled = true;
            this.txtFname.Size = new System.Drawing.Size(126, 23);
            this.txtFname.TabIndex = 24;
            this.txtFname.UseSelectable = true;
            this.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(220, 30);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "First Name";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(146, 30);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(68, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "search ";
            this.metroButton1.UseSelectable = true;
            // 
            // txtEnrolId
            // 
            // 
            // 
            // 
            this.txtEnrolId.CustomButton.Image = null;
            this.txtEnrolId.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtEnrolId.CustomButton.Name = "";
            this.txtEnrolId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnrolId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnrolId.CustomButton.TabIndex = 1;
            this.txtEnrolId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnrolId.CustomButton.UseSelectable = true;
            this.txtEnrolId.CustomButton.Visible = false;
            this.txtEnrolId.Lines = new string[0];
            this.txtEnrolId.Location = new System.Drawing.Point(76, 30);
            this.txtEnrolId.MaxLength = 32767;
            this.txtEnrolId.Name = "txtEnrolId";
            this.txtEnrolId.PasswordChar = '\0';
            this.txtEnrolId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnrolId.SelectedText = "";
            this.txtEnrolId.SelectionLength = 0;
            this.txtEnrolId.SelectionStart = 0;
            this.txtEnrolId.ShortcutsEnabled = true;
            this.txtEnrolId.Size = new System.Drawing.Size(64, 23);
            this.txtEnrolId.TabIndex = 21;
            this.txtEnrolId.UseSelectable = true;
            this.txtEnrolId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnrolId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnrolId.TextChanged += new System.EventHandler(this.txtEnrolId_TextChanged);
            this.txtEnrolId.Leave += new System.EventHandler(this.txtEnrolId_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "StudentID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.cmbPayTyp);
            this.groupBox2.Controls.Add(this.txtRefNumber);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.txtTranDetails);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtTranDate);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(24, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 142);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "transaction Information";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(327, 67);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "payment method";
            // 
            // cmbPayTyp
            // 
            this.cmbPayTyp.FormattingEnabled = true;
            this.cmbPayTyp.ItemHeight = 23;
            this.cmbPayTyp.Items.AddRange(new object[] {
            "Bank",
            "Cash"});
            this.cmbPayTyp.Location = new System.Drawing.Point(443, 67);
            this.cmbPayTyp.Name = "cmbPayTyp";
            this.cmbPayTyp.Size = new System.Drawing.Size(114, 29);
            this.cmbPayTyp.TabIndex = 15;
            this.cmbPayTyp.UseSelectable = true;
            // 
            // txtRefNumber
            // 
            // 
            // 
            // 
            this.txtRefNumber.CustomButton.Image = null;
            this.txtRefNumber.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtRefNumber.CustomButton.Name = "";
            this.txtRefNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRefNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefNumber.CustomButton.TabIndex = 1;
            this.txtRefNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefNumber.CustomButton.UseSelectable = true;
            this.txtRefNumber.CustomButton.Visible = false;
            this.txtRefNumber.Lines = new string[0];
            this.txtRefNumber.Location = new System.Drawing.Point(443, 19);
            this.txtRefNumber.MaxLength = 32767;
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.PasswordChar = '\0';
            this.txtRefNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefNumber.SelectedText = "";
            this.txtRefNumber.SelectionLength = 0;
            this.txtRefNumber.SelectionStart = 0;
            this.txtRefNumber.ShortcutsEnabled = true;
            this.txtRefNumber.Size = new System.Drawing.Size(103, 23);
            this.txtRefNumber.TabIndex = 14;
            this.txtRefNumber.UseSelectable = true;
            this.txtRefNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(359, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "ref Number";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(10, 19);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(130, 19);
            this.metroLabel12.TabIndex = 12;
            this.metroLabel12.Text = "Transaction  Deetails ";
            // 
            // txtTranDetails
            // 
            // 
            // 
            // 
            this.txtTranDetails.CustomButton.Image = null;
            this.txtTranDetails.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtTranDetails.CustomButton.Name = "";
            this.txtTranDetails.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtTranDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTranDetails.CustomButton.TabIndex = 1;
            this.txtTranDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTranDetails.CustomButton.UseSelectable = true;
            this.txtTranDetails.CustomButton.Visible = false;
            this.txtTranDetails.Lines = new string[0];
            this.txtTranDetails.Location = new System.Drawing.Point(10, 50);
            this.txtTranDetails.MaxLength = 32767;
            this.txtTranDetails.Multiline = true;
            this.txtTranDetails.Name = "txtTranDetails";
            this.txtTranDetails.PasswordChar = '\0';
            this.txtTranDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTranDetails.SelectedText = "";
            this.txtTranDetails.SelectionLength = 0;
            this.txtTranDetails.SelectionStart = 0;
            this.txtTranDetails.ShortcutsEnabled = true;
            this.txtTranDetails.Size = new System.Drawing.Size(295, 77);
            this.txtTranDetails.TabIndex = 11;
            this.txtTranDetails.UseSelectable = true;
            this.txtTranDetails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTranDetails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTranDetails.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTranscations);
            this.groupBox3.Location = new System.Drawing.Point(33, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 205);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "account history";
            // 
            // dgvTranscations
            // 
            this.dgvTranscations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTranscations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranscations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTranscations.Location = new System.Drawing.Point(3, 16);
            this.dgvTranscations.Name = "dgvTranscations";
            this.dgvTranscations.Size = new System.Drawing.Size(849, 186);
            this.dgvTranscations.TabIndex = 0;
            this.dgvTranscations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTranscations_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(159, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update Transcation";
            this.btnUpdate.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(293, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 37);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete Transaction";
            this.btnDelete.UseSelectable = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 667);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProcess);
            this.Name = "frmTransactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranscations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnProcess;
        private MetroFramework.Controls.MetroDateTime txtTranDate;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPaid;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtCurBalance;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtOpenBal;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtClass;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtFname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtEnrolId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtTranDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTranscations;
        private MetroFramework.Controls.MetroTextBox txtRefNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbPayTyp;
    }
}