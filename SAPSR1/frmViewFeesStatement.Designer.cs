namespace SAPSR1
{
    partial class frmViewFeesStatement
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
            this.btnProcess = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTerm = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEnId = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptFeesStatement1 = new SAPSR1.rptFeesStatement();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtTerm);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtSname);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtEnId);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statement Parameters";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(767, 19);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(170, 39);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process Statement";
            this.btnProcess.UseSelectable = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(616, 32);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Term";
            // 
            // txtTerm
            // 
            // 
            // 
            // 
            this.txtTerm.CustomButton.Image = null;
            this.txtTerm.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtTerm.CustomButton.Name = "";
            this.txtTerm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTerm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTerm.CustomButton.TabIndex = 1;
            this.txtTerm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTerm.CustomButton.UseSelectable = true;
            this.txtTerm.CustomButton.Visible = false;
            this.txtTerm.Lines = new string[0];
            this.txtTerm.Location = new System.Drawing.Point(660, 28);
            this.txtTerm.MaxLength = 32767;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.PasswordChar = '\0';
            this.txtTerm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTerm.SelectedText = "";
            this.txtTerm.SelectionLength = 0;
            this.txtTerm.SelectionStart = 0;
            this.txtTerm.ShortcutsEnabled = true;
            this.txtTerm.Size = new System.Drawing.Size(91, 23);
            this.txtTerm.TabIndex = 7;
            this.txtTerm.UseSelectable = true;
            this.txtTerm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTerm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(159, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(400, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Sname";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtSname
            // 
            // 
            // 
            // 
            this.txtSname.CustomButton.Image = null;
            this.txtSname.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtSname.CustomButton.Name = "";
            this.txtSname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSname.CustomButton.TabIndex = 1;
            this.txtSname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSname.CustomButton.UseSelectable = true;
            this.txtSname.CustomButton.Visible = false;
            this.txtSname.Lines = new string[0];
            this.txtSname.Location = new System.Drawing.Point(455, 28);
            this.txtSname.MaxLength = 32767;
            this.txtSname.Name = "txtSname";
            this.txtSname.PasswordChar = '\0';
            this.txtSname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSname.SelectedText = "";
            this.txtSname.SelectionLength = 0;
            this.txtSname.SelectionStart = 0;
            this.txtSname.ShortcutsEnabled = true;
            this.txtSname.Size = new System.Drawing.Size(155, 23);
            this.txtSname.TabIndex = 4;
            this.txtSname.UseSelectable = true;
            this.txtSname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(209, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Fname";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtFname
            // 
            // 
            // 
            // 
            this.txtFname.CustomButton.Image = null;
            this.txtFname.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txtFname.CustomButton.Name = "";
            this.txtFname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFname.CustomButton.TabIndex = 1;
            this.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFname.CustomButton.UseSelectable = true;
            this.txtFname.CustomButton.Visible = false;
            this.txtFname.Lines = new string[0];
            this.txtFname.Location = new System.Drawing.Point(264, 28);
            this.txtFname.MaxLength = 32767;
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFname.SelectedText = "";
            this.txtFname.SelectionLength = 0;
            this.txtFname.SelectionStart = 0;
            this.txtFname.ShortcutsEnabled = true;
            this.txtFname.Size = new System.Drawing.Size(130, 23);
            this.txtFname.TabIndex = 2;
            this.txtFname.UseSelectable = true;
            this.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFname.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Enrolment Id";
            // 
            // txtEnId
            // 
            // 
            // 
            // 
            this.txtEnId.CustomButton.Image = null;
            this.txtEnId.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txtEnId.CustomButton.Name = "";
            this.txtEnId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnId.CustomButton.TabIndex = 1;
            this.txtEnId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnId.CustomButton.UseSelectable = true;
            this.txtEnId.CustomButton.Visible = false;
            this.txtEnId.Lines = new string[0];
            this.txtEnId.Location = new System.Drawing.Point(97, 28);
            this.txtEnId.MaxLength = 32767;
            this.txtEnId.Name = "txtEnId";
            this.txtEnId.PasswordChar = '\0';
            this.txtEnId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnId.SelectedText = "";
            this.txtEnId.SelectionLength = 0;
            this.txtEnId.SelectionStart = 0;
            this.txtEnId.ShortcutsEnabled = true;
            this.txtEnId.Size = new System.Drawing.Size(56, 23);
            this.txtEnId.TabIndex = 0;
            this.txtEnId.UseSelectable = true;
            this.txtEnId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnId.Leave += new System.EventHandler(this.txtEnId_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.crystalReportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(23, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1250, 604);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptFeesStatement1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1244, 585);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmViewFeesStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViewFeesStatement";
            this.Text = "Fees Statements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewFeesStatement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEnId;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnProcess;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTerm;
        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptFeesStatement rptFeesStatement1;
    }
}