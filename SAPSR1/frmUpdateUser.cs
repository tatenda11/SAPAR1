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
    public partial class frmUpdateUser : MetroFramework.Forms.MetroForm
    {

        public int userId;
        public frmUpdateUser()
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

                case "Admin":
                    str = "C";
                    break;

                default:
                    str = "B";
                    break;
            }
            return str;

        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {

            try
            {
                if (sessions.userType == "A")
                {
                    manageUsers myU = new manageUsers();
                    myU.getUser(this.userId);
                    manageUserDetails myD = new manageUserDetails();
                    myD.getUserDetails(this.userId);
                    this.txtFname.Text = myD.firstName;
                    this.txtLastName.Text = myD.lastName;
                    if (myU.userType == "A")
                    {
                        this.cmbUserTyp.Text = "Admin";
                    }
                    else if (myU.userType == "T")
                    {
                        this.cmbUserTyp.Text = "Teacher";
                    }
                    else if (myU.userType == "C")
                    {
                        this.cmbUserTyp.Text = "Clerk";
                    }
                    else
                    {
                        this.cmbUserTyp.Text = "Blocked Account";
                    }
                }
                else
                {
                    MessageBox.Show("user type not authorised to perform account management");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in frmUpdateUser_Load() " + ex.Message);
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var userTyp = this.getUserEnum(this.cmbUserTyp.Text);
                manageUsers myU = new manageUsers();
                myU.getUser(this.userId);
                myU.userType = userTyp;
                if(myU.editUser(this.userId)== true)
                {
                    MessageBox.Show("User Update Success", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("failed to Update User ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in btnUpdate_Click() " + ex.Message);
            }
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            try
            {
                manageUsers myU = new manageUsers();
                myU.getUser(this.userId);
                myU.userType = "B";
                if (myU.editUser(this.userId) == true)
                {
                    MessageBox.Show("User Account deactivated Success", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("failed to deactivated account ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in btnSuspend_Click() " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
