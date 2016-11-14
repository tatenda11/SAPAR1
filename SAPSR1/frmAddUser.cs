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
    public partial class frmAddUser : MetroFramework.Forms.MetroForm
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private String getUserEnum(String utyp)
        {
            string str;
            switch (utyp)
            {
                case "Teacher":
                    str = "T";  
                break;
                case "Clerk":
                    str = "C";
                break;
                default:
                    str = "A";
                break;
            }
            return str;

        }
        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                var usrname = this.txtUserName.Text;
                var password = this.txtPassword.Text;
                var usrtyp = this.txtUserType.Text;
                var email = this.txtEmail.Text;
                var fname = this.txtFname.Text;
                var sname = this.txtLastName.Text;
                var cell = this.txtMobile.Text;
                var msg = this.txtMsg.Text;
                /*validate input*/
                if(usrname.Length < 4)
                {
                    MessageBox.Show("username should be at least 5 characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserName.Focus();
                }
                else if(password == "")
                {
                    MessageBox.Show("password required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtPassword.Focus();
                }
                else if(usrtyp == "")
                {
                    MessageBox.Show("select a user type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserType.Focus();
                }
                else if(validator.IsValidEmail(email) == false)
                {
                    MessageBox.Show("invalid email address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtEmail.Focus();
                }
                /*enter login information*/
                else
                {
                    manageUsers myU = new manageUsers();
                    if(myU.checkExist(usrname)== false)
                    {
                        if(myU.setUser(usrname,password, getUserEnum(usrtyp), email) == true)
                        {
                            /*enter other info*/
                            manageUserDetails myD = new manageUserDetails();
                            if(myD.setDetails(myU.userId,fname,sname,cell) == true)
                            {
                                /* notification email*/
                                MessageBox.Show("Added User Successfully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                /*notifly user of creation success*/
                            }
                        }
                        else
                        {
                            MessageBox.Show("failed to add user close the system and retry", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("username already in the system", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Applcation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = appHelper.GetUniqueKey(7);
        }
    }
}
