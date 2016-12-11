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
    public partial class frmMainMenuUpdate : MetroFramework.Forms.MetroForm
    {
        public frmMainMenuUpdate()
        {
            InitializeComponent();
        }

        private void MainMenuUpdate_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sAPSHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp myFrt = new frmHelp();
            myFrt.ShowDialog();

            
        }

        private void contactDevelopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactDeveloper myFrt = new frmContactDeveloper();
            myFrt.ShowDialog();
                
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About f2 = new About();
         //   f2.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmManagestudentsMain myFtT = new frmManagestudentsMain();
            myFtT.ShowDialog();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            frmManageStaff myFrT = new frmManageStaff ();
            myFrT.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmStudentDetails myFrT = new frmStudentDetails();
            myFrT.ShowDialog();            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmStaffDetails myFrT = new frmStaffDetails ();
            myFrT.ShowDialog();

        }

        private void metroTile26_Click(object sender, EventArgs e)
        {
            frmTransactions  myFrT = new frmTransactions();
            myFrT.ShowDialog();

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
           
        }

        private void btnManageClass_Click(object sender, EventArgs e)
        {
            frmAddClass myFrT = new frmAddClass();
            myFrT.ShowDialog();
        }

        private void contactDevelopersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmContactDeveloper myFrt = new frmContactDeveloper();
            myFrt.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnMangeUser_Click(object sender, EventArgs e)
        {
            frmManageUsers myFrt = new frmManageUsers();
            myFrt.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmAddUser myFrt = new frmAddUser();
            myFrt.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frmSettings myFrt = new frmSettings();
            myFrt.ShowDialog(); 

        }

        private void btnStaffReport_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp myFrt = new frmHelp();
            myFrt.ShowDialog();
        }

        private void BtnEmployeeDetails_Click(object sender, EventArgs e)
        {
          
        }
    }
}
