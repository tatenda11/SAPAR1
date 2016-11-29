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
    public partial class frmUtility : Form
    {
        public frmUtility()
        {
            InitializeComponent();
        }

        private void frmUtility_Load(object sender, EventArgs e)
        {
            manageControl myC = new manageControl();
            myC.getCntrl();
            sessions.curPeriod = myC.currentPeriod;
            sessions.currTerm = myC.currTerm;
            sessions.userId = 15;
            sessions.userType = "T";
            sessions.fees = myC.fees;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*frmManagestudentsMain frmM = new frmManagestudentsMain();
             frmM.ShowDialog();*/
            frmTransactions myFrT = new frmTransactions();
            myFrT.ShowDialog();
        }
    }
}
