using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
   
 
    public partial class frmStudentDetails : MetroFramework.Forms.MetroForm
   
    {
        public Boolean update;
        public int enrollmentId;
        MySqlCommand query = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());

        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void checkConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Failed to connect  " + e);
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
    {
        
    }

    private void metroTabPage1_Click(object sender, EventArgs e)
    {

    }

    private void metroTabPage2_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel7_Click(object sender, EventArgs e)
    {

    }

    private void metroTextBox3_Click(object sender, EventArgs e)
    {

    }

    private void metroTextBox4_Click(object sender, EventArgs e)
    {

    }

    private void metroTextBox5_Click(object sender, EventArgs e)
    {

    }

    private void metroTextBox6_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel8_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel9_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel10_Click(object sender, EventArgs e)
    {

    }

    private void frmStudentDetails_Load(object sender, EventArgs e)
    {
        try
        {
           //this.ta.Focus();
           this.fillClass();
           this.Student.SelectedIndex = 0;
                this.txtFirstName.Focus();
           if (this.update == true)
            {
                this.btnSave.Enabled = false;
                this.btnGenerate.Enabled = false;
                this.txtEnroiD.Text = this.enrollmentId.ToString();
                manageStudent myS = new manageStudent();
                managestudentdetails mySd = new managestudentdetails();
                manageClassrooms myC = new manageClassrooms();        
                myS.getStudentId(this.enrollmentId);
                mySd.getStudentDetails(Convert.ToString(this.enrollmentId));
                myC.getClass(myS.classId);
                this.txtFirstName.Text = myS.firstName;
                this.txtMidName.Text = myS.middleName;
                this.tXTSurname.Text = myS.lastName;
                this.cmbClassRoom.SelectedValue = myS.classId.ToString();
                string bday = myS.DOB.Replace("/", ".");
                this.txtDob.Value = Convert.ToDateTime(bday);
                //this.txtDob.Text = ;
                // this.cmbClassRoom.Text = myC.className;
                if (myS.gender == "M")
                {
                     this.rdbMale.Checked = true;
                }
                
               else if (myS.gender == "F")
               {
                    this.metroRadioButton2.Checked = true;
               }
                    this.txtAddress.Text = mySd.address;
                    this.txtEmail.Text = mySd.email;
                    this.txtGuardianSurname.Text = mySd.guardianSname;
                    this.txtGuardianFname.Text = mySd.guardianFname;
                    this.txtRel.Text = mySd.relationship;
                    this.txtPhone.Text = mySd.mobileNumber;
           }
           else
            {
                 manageControl myC = new manageControl();
                 myC.getCntrl();
                 this.txtEnroiD.Text = myC.enrollmentId.ToString();
            } 
        }
        catch(Exception ex)
        {
                MessageBox.Show("application error frmStudentDetails_Load()" + ex);
        }
    }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabContactDetails.Focus();
        }

        private void fillClass()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT classRoomId,className FROM wizclassrooms";
                MySqlDataReader myReader = query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("className", typeof(string));
                dt.Columns.Add("classRoomId", typeof(int));
                dt.Load(myReader);
                this.cmbClassRoom.ValueMember = "classRoomId";
                this.cmbClassRoom.DisplayMember = "className";
                this.cmbClassRoom.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                var enrID = Convert.ToInt32(this.txtEnroiD.Text);
                var firstName = this.txtFirstName.Text;
                var mdlName = this.txtMidName.Text;
                var lastName = this.tXTSurname.Text;
                var DOB = this.txtDob.Value.ToShortDateString();
                string sex = "";
                var classId = Convert.ToInt32(this.cmbClassRoom.SelectedValue);
                if (this.rdbMale.Checked == true)
                {
                    sex = "M";
                }
                 if(this.metroRadioButton2.Checked == true)
                {
                    sex = "F";
                }
                /*other information*/
                var address = this.txtAddress.Text;
                var phone = this.txtPhone.Text;
                var gurdFname = this.txtGuardianFname.Text;
                var gurdSname = this.txtGuardianSurname.Text;
                var gurdPhone = this.txtMobileNumbe.Text;
                var email = this.txtEmail.Text;
                var rel = this.txtRel.Text;
                /*validate required field*/
                if (enrID.ToString() == "")
                {
                    MessageBox.Show("Enrollmend Id is required", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtEnroiD.Focus();
                }
                else if(firstName == "")
                {
                    MessageBox.Show("firstName is required", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFirstName.Focus();
                }
                else if(lastName == "")
                {
                    MessageBox.Show("lastName is required", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tXTSurname.Focus();
                }
                else
                {
                    manageStudent myS = new manageStudent();
                    if(myS.checkExists(enrID) == 0)
                    {
                        if (myS.setStudent(enrID, firstName, mdlName, lastName, classId, DOB, sex) == true)
                        {
                            managestudentdetails mydetails = new managestudentdetails();
                            if(mydetails.setStudentDetails(enrID, address, gurdFname, gurdSname,rel, gurdPhone,email) == true)
                            {
                                MessageBox.Show("student enrolled succesifully", "System notifification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                myS.deleteStudent(enrID);
                                MessageBox.Show("failed to add student to system try again ", "System notifification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("enrollmentId already in system", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("application error frmStudentDetails_Load()" + ex);
            }
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            this.metroRadioButton2.Checked = false;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.rdbMale.Checked = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.txtEnroiD.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var enrID = Convert.ToInt32(this.txtEnroiD.Text);
                var firstName = this.txtFirstName.Text;
                var mdlName = this.txtMidName.Text;
                var lastName = this.tXTSurname.Text;
                var DOB = this.txtDob.Value.ToShortDateString();
                string sex = "";
                var classId = Convert.ToInt32(this.cmbClassRoom.SelectedValue);
                if (this.rdbMale.Checked == true)
                {
                    sex = "M";
                }
                if (this.metroRadioButton2.Checked == true)
                {
                    sex = "F";
                }
                /*other information*/
                var address = this.txtAddress.Text;
                var phone = this.txtPhone.Text;
                var gurdFname = this.txtGuardianFname.Text;
                var gurdSname = this.txtGuardianSurname.Text;
                var gurdPhone = this.txtMobileNumbe.Text;
                var email = this.txtEmail.Text;
                var rel = this.txtRel.Text;
                /*validate required field*/
                if (enrID.ToString() == "")
                {
                    MessageBox.Show("Enrollmend Id is required", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtEnroiD.Focus();
                }
                else if (firstName == "")
                {
                    MessageBox.Show("firstName is required", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFirstName.Focus();
                }
                else if (lastName == "")
                {
                    MessageBox.Show("lastName is required", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tXTSurname.Focus();
                }
                else
                {
                    manageStudent myS = new manageStudent();
                    managestudentdetails mydetails = new managestudentdetails();
                    if (myS.checkExists(enrID) == 1)
                    {
                        if (mydetails.checkExists(enrID) == 1)
                        {
                            myS.getStudentId(enrID);
                            myS.firstName = firstName;
                            myS.DOB = DOB;
                            myS.lastName = lastName;
                            myS.classId = classId;
                            myS.gender = sex;
                            myS.middleName = txtMidName.Text;
                            if (myS.updateStudent(enrID) == true)
                            {
                                mydetails.getStudentDetails(enrID.ToString());
                                mydetails.address = address;
                                mydetails.guardianFname = gurdFname;
                                mydetails.guardianSname = gurdSname;
                                mydetails.relationship = rel;
                                mydetails.mobileNumber = phone;
                                if(mydetails.updateStudentDetails(enrID.ToString())== true)
                                {
                                    MessageBox.Show("student updated success ", "System notifification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }
                        else
                        {
                            if (mydetails.setStudentDetails(enrID, address, gurdFname, gurdSname, rel, gurdPhone, email) == true)
                            {
                                myS.getStudentId(enrID);
                                myS.firstName = firstName;
                                myS.DOB = DOB;
                                myS.lastName = lastName;
                                myS.classId = classId;
                                myS.gender = sex;
                                if (myS.updateStudent(enrID) == true)
                                {
                                    MessageBox.Show("student updated success ", "System notifification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }   
                    }
                    else
                    {
                        MessageBox.Show("student not in the system", "System notifification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            string txt = this.txtFirstName.Text;
            if(validator.isValidateName(txt) == false && txt != "")
            {
                MessageBox.Show(validator.errorMsg, "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
        }

        private void txtMidName_Leave(object sender, EventArgs e)
        {
            string txt = this.txtMidName.Text;
            if (validator.isValidateName(txt) == false && txt != "")
            {
                MessageBox.Show(validator.errorMsg, "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMidName.Focus();
            }
        }

        private void tXTSurname_Leave(object sender, EventArgs e)
        {
            string txt = this.tXTSurname.Text;
            if (validator.isValidateName(txt) == false && txt != "")
            {
                MessageBox.Show(validator.errorMsg, "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tXTSurname.Focus();
            }
        }

        private void txtDob_Leave(object sender, EventArgs e)
        {
            string txt = this.txtDob.Value.ToShortDateString();
            if (validator.isValidDateOfBirth(txt,18,3) == false && txt != "")
            {
                MessageBox.Show(validator.errorMsg, "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDob.Focus();
            }
        }

        private void txtGuardianFname_Leave(object sender, EventArgs e)
        {
            string txt = this.txtGuardianFname.Text;
            if (validator.isValidateName(txt) == false && txt != "")
            {
                MessageBox.Show(validator.errorMsg, "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtGuardianFname.Focus();
            }
        }

        private void txtGuardianSurname_Leave(object sender, EventArgs e)
        {
            string txt = this.txtGuardianSurname.Text;
            if (validator.isValidateName(txt) == false && txt != "")
            {
                MessageBox.Show(validator.errorMsg, "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtGuardianSurname.Focus();
            }
        }
    }
}
