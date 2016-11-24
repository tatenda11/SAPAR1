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
    public partial class frmMainMenu : MetroFramework.Forms.MetroForm
    {
        public frmMainMenu()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            sessions.userId = 15;
            sessions.userType = "T";
            manageControl myCnrl = new manageControl();
            myCnrl.getCntrl();
            sessions.curPeriod = myCnrl.currentPeriod;
            sessions.currTerm = myCnrl.currTerm;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //frmAddUser addUser = new frmAddUser();
            //addUser.ShowDialog();
            frmExams exm = new frmExams();
            exm.ShowDialog();
            //msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            /*var m = new Random();
            int next = m.Next(0, 13);
            this.Style = (MetroFramework.MetroColorStyle)next;
            this.components.SetDefaultStyle(this, MetroFramework.MetroColorStyle.Purple);*/
        }

                private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Applcation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmAddClass myC = new frmAddClass();
            myC.ShowDialog(); 
        }
    }

}