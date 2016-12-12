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
    public partial class frmViewFeesStatement : MetroFramework.Forms.MetroForm
    {
        public frmViewFeesStatement()
        {
            InitializeComponent();
        }

        private void frmViewFeesStatement_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtTerm.Text = sessions.currTerm;
                crystalReportViewer1.ReportSource = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in frmViewFeesStatement_Load()");
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmSystemSearch myS = new frmSystemSearch();
                myS.searchType = "students";
                DialogResult access = myS.ShowDialog();
                if (access == DialogResult.OK)
                {
                    if (myS.searchedId != "")
                    {
                        this.txtEnId.Focus();
                        this.txtEnId.Text = myS.searchedId;
                        this.txtTerm.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No student was selected please double click disired student", "System notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No student was selected please double click disired student "+ ex.Message);
            }
        }

        private void txtEnId_Leave(object sender, EventArgs e)
        {
            try
            {
                /*get student information*/
                manageStudent myS = new manageStudent();
                myS.getStudentId(Convert.ToInt32(this.txtEnId.Text));
                if (myS.dacFound == true)
                {
                    this.txtFname.Text = myS.firstName;
                    this.txtSname.Text = myS.lastName;
                }
                else
                {
                    MessageBox.Show("Enrolment id not registered in system", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in txtEnId_Leave()"+ex.Message);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTerm.Text != "" && this.txtTerm.Text != "" )
                {
                    rptFeesStatement1.SetParameterValue("studentId", this.txtEnId.Text);
                    rptFeesStatement1.SetParameterValue("term", this.txtTerm.Text);
                    crystalReportViewer1.ReportSource = rptFeesStatement1;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("Enter Student id and term to view statement", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnProcess_Click()" + ex.Message);
            }
        }
    }
}
