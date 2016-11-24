namespace SAPSR1
{
    partial class frmAttendance
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
            this.btnAbsent = new MetroFramework.Controls.MetroButton();
            this.btnPresent = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAbsent = new MetroFramework.Controls.MetroTextBox();
            this.txtPresent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtLname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFname = new MetroFramework.Controls.MetroTextBox();
            this.txtEnId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPrev = new MetroFramework.Controls.MetroButton();
            this.lbCounter = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbsent);
            this.groupBox1.Controls.Add(this.btnPresent);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtAbsent);
            this.groupBox1.Controls.Add(this.txtPresent);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Location = new System.Drawing.Point(32, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAbsent
            // 
            this.btnAbsent.BackColor = System.Drawing.Color.Red;
            this.btnAbsent.Location = new System.Drawing.Point(458, 75);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(140, 33);
            this.btnAbsent.TabIndex = 15;
            this.btnAbsent.Text = "Mark Absent";
            this.btnAbsent.UseSelectable = true;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(312, 75);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(140, 33);
            this.btnPresent.TabIndex = 14;
            this.btnPresent.Text = "Mark Present";
            this.btnPresent.UseSelectable = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(7, 89);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Choose date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(86, 79);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 29);
            this.txtDate.TabIndex = 12;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(745, 28);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "total ";
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(790, 28);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(53, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(601, 28);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "total Absent";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(458, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "total Present";
            // 
            // txtAbsent
            // 
            // 
            // 
            // 
            this.txtAbsent.CustomButton.Image = null;
            this.txtAbsent.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.txtAbsent.CustomButton.Name = "";
            this.txtAbsent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAbsent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAbsent.CustomButton.TabIndex = 1;
            this.txtAbsent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAbsent.CustomButton.UseSelectable = true;
            this.txtAbsent.CustomButton.Visible = false;
            this.txtAbsent.Enabled = false;
            this.txtAbsent.Lines = new string[0];
            this.txtAbsent.Location = new System.Drawing.Point(686, 28);
            this.txtAbsent.MaxLength = 32767;
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.PasswordChar = '\0';
            this.txtAbsent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbsent.SelectedText = "";
            this.txtAbsent.SelectionLength = 0;
            this.txtAbsent.SelectionStart = 0;
            this.txtAbsent.ShortcutsEnabled = true;
            this.txtAbsent.Size = new System.Drawing.Size(53, 23);
            this.txtAbsent.TabIndex = 8;
            this.txtAbsent.UseSelectable = true;
            this.txtAbsent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAbsent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPresent
            // 
            // 
            // 
            // 
            this.txtPresent.CustomButton.Image = null;
            this.txtPresent.CustomButton.Location = new System.Drawing.Point(27, 1);
            this.txtPresent.CustomButton.Name = "";
            this.txtPresent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPresent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPresent.CustomButton.TabIndex = 1;
            this.txtPresent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPresent.CustomButton.UseSelectable = true;
            this.txtPresent.CustomButton.Visible = false;
            this.txtPresent.Lines = new string[0];
            this.txtPresent.Location = new System.Drawing.Point(546, 28);
            this.txtPresent.MaxLength = 32767;
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.PasswordChar = '\0';
            this.txtPresent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPresent.SelectedText = "";
            this.txtPresent.SelectionLength = 0;
            this.txtPresent.SelectionStart = 0;
            this.txtPresent.ShortcutsEnabled = true;
            this.txtPresent.Size = new System.Drawing.Size(49, 23);
            this.txtPresent.TabIndex = 6;
            this.txtPresent.UseSelectable = true;
            this.txtPresent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPresent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(235, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Last Name";
            // 
            // txtLname
            // 
            // 
            // 
            // 
            this.txtLname.CustomButton.Image = null;
            this.txtLname.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtLname.CustomButton.Name = "";
            this.txtLname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLname.CustomButton.TabIndex = 1;
            this.txtLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLname.CustomButton.UseSelectable = true;
            this.txtLname.CustomButton.Visible = false;
            this.txtLname.Enabled = false;
            this.txtLname.Lines = new string[0];
            this.txtLname.Location = new System.Drawing.Point(312, 28);
            this.txtLname.MaxLength = 32767;
            this.txtLname.Name = "txtLname";
            this.txtLname.PasswordChar = '\0';
            this.txtLname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLname.SelectedText = "";
            this.txtLname.SelectionLength = 0;
            this.txtLname.SelectionStart = 0;
            this.txtLname.ShortcutsEnabled = true;
            this.txtLname.Size = new System.Drawing.Size(140, 23);
            this.txtLname.TabIndex = 4;
            this.txtLname.UseSelectable = true;
            this.txtLname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "First Name";
            // 
            // txtFname
            // 
            // 
            // 
            // 
            this.txtFname.CustomButton.Image = null;
            this.txtFname.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtFname.CustomButton.Name = "";
            this.txtFname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFname.CustomButton.TabIndex = 1;
            this.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFname.CustomButton.UseSelectable = true;
            this.txtFname.CustomButton.Visible = false;
            this.txtFname.Enabled = false;
            this.txtFname.Lines = new string[0];
            this.txtFname.Location = new System.Drawing.Point(86, 28);
            this.txtFname.MaxLength = 32767;
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFname.SelectedText = "";
            this.txtFname.SelectionLength = 0;
            this.txtFname.SelectionStart = 0;
            this.txtFname.ShortcutsEnabled = true;
            this.txtFname.Size = new System.Drawing.Size(143, 23);
            this.txtFname.TabIndex = 2;
            this.txtFname.UseSelectable = true;
            this.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEnId
            // 
            // 
            // 
            // 
            this.txtEnId.CustomButton.Image = null;
            this.txtEnId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtEnId.CustomButton.Name = "";
            this.txtEnId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnId.CustomButton.TabIndex = 1;
            this.txtEnId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnId.CustomButton.UseSelectable = true;
            this.txtEnId.CustomButton.Visible = false;
            this.txtEnId.Enabled = false;
            this.txtEnId.Lines = new string[0];
            this.txtEnId.Location = new System.Drawing.Point(830, 25);
            this.txtEnId.MaxLength = 32767;
            this.txtEnId.Name = "txtEnId";
            this.txtEnId.PasswordChar = '\0';
            this.txtEnId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnId.SelectedText = "";
            this.txtEnId.SelectionLength = 0;
            this.txtEnId.SelectionStart = 0;
            this.txtEnId.ShortcutsEnabled = true;
            this.txtEnId.Size = new System.Drawing.Size(75, 23);
            this.txtEnId.TabIndex = 0;
            this.txtEnId.UseSelectable = true;
            this.txtEnId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(729, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Enrollment Id";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(32, 249);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(874, 184);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvStudents_RowStateChanged);
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // cmbCondition
            // 
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "All"});
            this.cmbCondition.Location = new System.Drawing.Point(32, 212);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(174, 21);
            this.cmbCondition.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(223, 200);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 33);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "filter";
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(830, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 33);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">>";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(744, 200);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(72, 33);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseSelectable = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbCounter.Location = new System.Drawing.Point(638, 208);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(62, 25);
            this.lbCounter.TabIndex = 18;
            this.lbCounter.Text = "10 / 30";
            this.lbCounter.Click += new System.EventHandler(this.lbCounter_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 456);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEnId);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAttendance";
            this.Text = "student attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtEnId;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtLname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAbsent;
        private MetroFramework.Controls.MetroTextBox txtPresent;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroButton btnAbsent;
        private MetroFramework.Controls.MetroButton btnPresent;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime txtDate;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cmbCondition;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrev;
        private MetroFramework.Controls.MetroLabel lbCounter;
    }
}