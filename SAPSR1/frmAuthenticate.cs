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
    public partial class frmAuthenticate : MetroFramework.Forms.MetroForm
    {

        public string userName,password;

        public frmAuthenticate()
        {
            InitializeComponent();
        }

        private void frmAuthenticate_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var usrName = this.txtUserName.Text;
            var passWord = this.txtPassword.Text;
            if(usrName == "")
            {
                MessageBox.Show("Username Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserName.Focus();
            }
            else if(passWord == "")
            {
                MessageBox.Show("Passwword Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
            }
            else
            {
                this.userName = usrName;
                this.password = passWord;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
