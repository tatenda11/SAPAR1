using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPSR1
{
    public partial class frmStaffDetails : MetroFramework.Forms.MetroForm
    {
        public int empId;
        public string empIdStr;
        public Boolean isEdit;
        public frmStaffDetails()
        {
            InitializeComponent();
        }

        private void frmStaffDetails_Load(object sender, EventArgs e)
        {
            try
            {
                manageControl myC = new manageControl();
                myC.getCntrl();
                this.empId = myC.empId;
                this.txtStaffId.Text = "emp" + this.empId;
                this.txtStaffId.Focus();
                if(this.isEdit == true)
                {
                    manageEmployees myE = new manageEmployees();
                    myE.getEmpDetails(this.empIdStr);
                    this.btnAdd.Enabled = false;
                    this.btnUpdate.Enabled = true;
                    this.ckbStatus.Checked = false;
                    this.txtAdress.Text = myE.address;
                    this.txtDob.Value = Convert.ToDateTime(myE.DOB);
                    this.txtempCell.Text = myE.Mobile;
                    this.txtempDate.Value = Convert.ToDateTime(myE.EmpDate);
                    this.txtEmpEmail.Text = myE.Email;
                    this.txtGndr.Text = myE.gender;
                    this.txtFname.Text = myE.Fname;
                    this.txtnatId.Text = myE.nationalId;
                    this.txtNextOfKeenCell.Text = myE.iceContact;
                    this.txtNextOfKeenName.Text = myE.iceName;
                    this.txtRel.Text = myE.iceRelationship;
                    this.txtSname.Text = myE.Sname;
                    if (myE.Status == "A")
                    {
                        this.ckbStatus.Checked = true;
                    }
                    this.cmbDpt.Text = myE.Dpt;
                    this.txtSname.Text = myE.Sname;
                    this.txtSupervisorId.Text = myE.supervisorId;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed in frmStaffDetails_Load() "+ ex.Message);
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtStaffId_Leave(object sender, EventArgs e)
        {
            try
            {
                var empId = this.txtStaffId.Text;
                manageEmployees myE = new manageEmployees();

                myE.getEmpDetails(empId);
                if(myE.dacFound == true)
                {
                    this.btnAdd.Enabled = false;
                    this.btnUpdate.Enabled = true;
                    this.ckbStatus.Checked = false;
                    this.txtAdress.Text = myE.address;
                    this.txtDob.Value = Convert.ToDateTime(myE.DOB);
                    this.txtempCell.Text = myE.Mobile;
                    this.txtempDate.Value = Convert.ToDateTime(myE.EmpDate);
                    this.txtEmpEmail.Text = myE.Email;
                    this.txtGndr.Text = myE.gender;
                    this.txtFname.Text = myE.Fname;
                    this.txtnatId.Text = myE.nationalId;
                    this.txtNextOfKeenCell.Text = myE.iceContact;
                    this.txtNextOfKeenName.Text = myE.iceName;
                    this.txtRel.Text = myE.iceRelationship;
                    this.txtSname.Text = myE.Sname;
                    if(myE.Status == "A")
                    {
                        this.ckbStatus.Checked = true;
                    }
                    this.cmbDpt.Text = myE.Dpt;
                    this.txtSname.Text = myE.Sname;
                    this.txtSupervisorId.Text = myE.supervisorId;
                }
                else
                {
                    MessageBox.Show("Employee Id not registered in system", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.btnUpdate.Enabled = false;
                    this.btnAdd.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in txtStaffId_Leave() " + ex.Message);
            }
        }

        public void refresh()
        {
            try
            {

                this.btnAdd.Enabled = true;
                this.ckbStatus.Checked = false;
                this.txtAdress.Text ="";
                this.txtDob.Value = DateTime.Now;
                this.txtempCell.Text ="";
                this.txtempDate.Value = DateTime.Now;
                this.txtEmpEmail.Text = "";
                this.txtGndr.Text ="";
                this.txtnatId.Text ="";
                this.txtNextOfKeenCell.Text = "";
                this.txtNextOfKeenName.Text = "";
                this.txtRel.Text = "";
                this.txtSname.Text = "";
                this.cmbDpt.Text ="";
                this.txtSname.Text = "";
                this.txtFname.Text = "";
                this.txtSupervisorId.Text ="";
            }
            catch(Exception ex)
            {
                MessageBox.Show("faltes in refresh() " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txtFname.Text == "")
                {
                    MessageBox.Show("firstname required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtFname.Focus();
                }
                else if(this.txtSname.Text == "")
                {
                    MessageBox.Show("Surname required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtSname.Focus();
                }
                else if (this.txtStaffId.Text == "")
                {
                    MessageBox.Show("Staff id number required required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtStaffId.Focus();
                }
                else
                {
                    manageEmployees myE = new manageEmployees();
                    myE.employeeId = this.txtStaffId.Text;
                    myE.Fname = this.txtFname.Text;
                    myE.address = this.txtAdress.Text;
                    myE.DOB = this.txtDob.Value.ToShortDateString();
                    myE.Mobile = this.txtempCell.Text;
                    myE.EmpDate = this.txtempDate.Value.ToShortDateString();
                    myE.Email = this.txtEmpEmail.Text;
                    myE.gender = this.txtGndr.Text;
                    myE.nationalId = this.txtnatId.Text;
                    myE.iceContact =this.txtNextOfKeenCell.Text;
                    myE.iceName = this.txtNextOfKeenName.Text;
                    myE.iceRelationship = this.txtRel.Text;
                    myE.Sname = this.txtSname.Text;
                    if (this.ckbStatus.Checked == true)
                    {
                        myE.Status = "A";
                    }
                    else
                    {
                        myE.Status = "D";
                    }
                    myE.Dpt = this.cmbDpt.Text;
                    myE.supervisorId = this.txtSupervisorId.Text;
                    if(myE.SetEmpDetails() == true)
                    {
                        MessageBox.Show("employee added successifully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manageControl myC = new manageControl();
                        this.txtStaffId.Text = "emp"+myC.useEmpHeader(this.empId).ToString();
                    }
                    else
                    {
                       MessageBox.Show("failed to add employee", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("faltes in refresh() " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtFname.Text == "")
                {
                    MessageBox.Show("firstname required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtFname.Focus();
                }
                else if (this.txtSname.Text == "")
                {
                    MessageBox.Show("Surname required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtSname.Focus();
                }
                else if (this.txtStaffId.Text == "")
                {
                    MessageBox.Show("Staff id number required required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtStaffId.Focus();
                }
                else
                {
                    manageEmployees myE = new manageEmployees();
                    myE.getEmpDetails(this.txtStaffId.Text);
                    myE.employeeId = this.txtStaffId.Text;
                    myE.Fname = this.txtFname.Text;
                    myE.address = this.txtAdress.Text;
                    myE.DOB = this.txtDob.Value.ToShortDateString();
                    myE.Mobile = this.txtempCell.Text;
                    myE.EmpDate = this.txtempDate.Value.ToShortDateString();
                    myE.Email = this.txtEmpEmail.Text;
                    myE.Fname = this.txtFname.Text;
                    myE.gender = this.txtGndr.Text;
                    myE.nationalId = this.txtnatId.Text;
                    myE.iceContact = this.txtNextOfKeenCell.Text;
                    myE.iceName = this.txtNextOfKeenName.Text;
                    myE.iceRelationship = this.txtRel.Text;
                    myE.Sname = this.txtSname.Text;
                    if (this.ckbStatus.Checked == true)
                    {
                        myE.Status = "A";
                    }
                    else
                    {
                        myE.Status = "D";
                    }
                    myE.Dpt = this.cmbDpt.Text;
                    myE.supervisorId = this.txtSupervisorId.Text;
                    if (myE.updateEmplyee(this.txtStaffId.Text) == true)
                    {
                        MessageBox.Show("Employee updated success", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("failed to update employee", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("faltes in refresh() " + ex.Message);
            }
        }

        private void txtStaffId_TextChanged(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            if (validator.isValidateName(this.txtFname.Text)== false)
            {
                MessageBox.Show(validator.errorMsg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFname.Focus();
            }
        }

        private void txtSname_Leave(object sender, EventArgs e)
        {
            if (validator.isValidateName(this.txtSname.Text)== false)
            {
                MessageBox.Show(validator.errorMsg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSname.Focus();
            }
        }

        private void txtDob_Leave(object sender, EventArgs e)
        {
            if (validator.isValidDateOfBirth(this.txtDob.Value.ToShortDateString(),70,17)== false)
            {
                MessageBox.Show(validator.errorMsg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDob.Focus();
            }
        }

        private void txtGndr_Leave(object sender, EventArgs e)
        {
            if(this.txtGndr.Text == "")
            {
                MessageBox.Show("please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtGndr.Focus();
            }
        }

        private void txtempDate_Leave(object sender, EventArgs e)
        {
            if (validator.isValidDateOfBirth(this.txtempDate.Value.ToShortDateString(), 30, 0) == false)
            {
                MessageBox.Show("Invalid employement date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDob.Focus();
            }
        }

        private void txtempCell_Leave(object sender, EventArgs e)
        {
            /*if (validator.isValidPhoneNumber(this.txtempCell.Text) == false)
            {
                MessageBox.Show(validator.errorMsg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtempCell.Focus();
            }*/
        }

        private void txtEmpEmail_Leave(object sender, EventArgs e)
        {
            if (validator.isValidEmail(this.txtEmpEmail.Text) == false)
            {
                MessageBox.Show(validator.errorMsg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmpEmail.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
