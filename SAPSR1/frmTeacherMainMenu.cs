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
    public partial class frmTeacherMainMenu : MetroFramework.Forms.MetroForm
    {
        public frmTeacherMainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                manageClassrooms myC = new manageClassrooms();
                myC.getClassByTeacher(sessions.userId);
                sessions.classId = myC.classRoomId;
                sessions.classGrade = myC.classGrade;
                manageControl myCntr = new manageControl();
                myCntr.getCntrl();
                sessions.curPeriod = myCntr.currentPeriod;
                sessions.currTerm = myCntr.currTerm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in frmTeacherMainMenu() " + ex.Message);
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {
                frmExams mysfrm = new frmExams();

                mysfrm.ShowDialog();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                frmAuthenticate mysfrm = new frmAuthenticate();
               
                mysfrm.ShowDialog();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }


        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnterMarks mysfrm = new frmEnterMarks();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendance mysfrm = new frmAttendance();
                mysfrm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp mysfrm = new frmHelp();
            mysfrm.ShowDialog();


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                frmManagestudentsMain mysfrm = new frmManagestudentsMain();
                mysfrm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }

            
        }

        private void btnViewPerfomance_Click(object sender, EventArgs e)
        {
            frmEnterMarks mysfrm = new frmEnterMarks();
            mysfrm.ShowDialog(); 
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            frmClassExams myfrm = new frmClassExams();
            myfrm.ShowDialog(); 
        }
    }
}
