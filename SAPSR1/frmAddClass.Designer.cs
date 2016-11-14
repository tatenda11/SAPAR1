using System;
using System.Windows.Forms;

namespace SAPSR1
{
    partial class frmAddClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtClassDes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbClassGrade = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbTeacher = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtClassName = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.dgvClasses = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtClassDes);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cmbClassGrade);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cmbTeacher);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Location = new System.Drawing.Point(32, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "class information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(643, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "update class";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(643, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Class";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(298, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "descrpition";
            // 
            // txtClassDes
            // 
            // 
            // 
            // 
            this.txtClassDes.CustomButton.Image = null;
            this.txtClassDes.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtClassDes.CustomButton.Name = "";
            this.txtClassDes.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txtClassDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClassDes.CustomButton.TabIndex = 1;
            this.txtClassDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClassDes.CustomButton.UseSelectable = true;
            this.txtClassDes.CustomButton.Visible = false;
            this.txtClassDes.Lines = new string[0];
            this.txtClassDes.Location = new System.Drawing.Point(377, 80);
            this.txtClassDes.MaxLength = 32767;
            this.txtClassDes.Multiline = true;
            this.txtClassDes.Name = "txtClassDes";
            this.txtClassDes.PasswordChar = '\0';
            this.txtClassDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClassDes.SelectedText = "";
            this.txtClassDes.SelectionLength = 0;
            this.txtClassDes.SelectionStart = 0;
            this.txtClassDes.ShortcutsEnabled = true;
            this.txtClassDes.Size = new System.Drawing.Size(236, 71);
            this.txtClassDes.TabIndex = 6;
            this.txtClassDes.UseSelectable = true;
            this.txtClassDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClassDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "class grade";
            // 
            // cmbClassGrade
            // 
            this.cmbClassGrade.FormattingEnabled = true;
            this.cmbClassGrade.ItemHeight = 23;
            this.cmbClassGrade.Items.AddRange(new object[] {
            "grade 0",
            "grade 1",
            "grade 2",
            "grade 3",
            "grade 4",
            "grade 5",
            "grade 6",
            "grade 7"});
            this.cmbClassGrade.Location = new System.Drawing.Point(94, 74);
            this.cmbClassGrade.Name = "cmbClassGrade";
            this.cmbClassGrade.Size = new System.Drawing.Size(187, 29);
            this.cmbClassGrade.TabIndex = 4;
            this.cmbClassGrade.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(308, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "teacher";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.ItemHeight = 23;
            this.cmbTeacher.Location = new System.Drawing.Point(375, 34);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(238, 29);
            this.cmbTeacher.TabIndex = 2;
            this.cmbTeacher.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "class name";
            // 
            // txtClassName
            // 
            // 
            // 
            // 
            this.txtClassName.CustomButton.Image = null;
            this.txtClassName.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtClassName.CustomButton.Name = "";
            this.txtClassName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClassName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClassName.CustomButton.TabIndex = 1;
            this.txtClassName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClassName.CustomButton.UseSelectable = true;
            this.txtClassName.CustomButton.Visible = false;
            this.txtClassName.Lines = new string[0];
            this.txtClassName.Location = new System.Drawing.Point(94, 34);
            this.txtClassName.MaxLength = 32767;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClassName.SelectedText = "";
            this.txtClassName.SelectionLength = 0;
            this.txtClassName.SelectionStart = 0;
            this.txtClassName.ShortcutsEnabled = true;
            this.txtClassName.Size = new System.Drawing.Size(185, 23);
            this.txtClassName.TabIndex = 0;
            this.txtClassName.UseSelectable = true;
            this.txtClassName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClassName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(32, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToResizeRows = false;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClasses.EnableHeadersVisualStyles = false;
            this.dgvClasses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClasses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClasses.Location = new System.Drawing.Point(32, 284);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClasses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(802, 150);
            this.dgvClasses.TabIndex = 10;
            this.dgvClasses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // frmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 539);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddClass";
            this.Text = "Add class";
            this.Load += new System.EventHandler(this.frmAddClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtClassDes;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbClassGrade;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbTeacher;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtClassName;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroGrid dgvClasses;
    }
}