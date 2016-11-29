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

    public partial class frmTransactions:MetroFramework.Forms.MetroForm
    {
        MySqlCommand query = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        private int enId;
        int refNumber;
        DataTable dt = new DataTable();
        Bitmap bmp;

        public frmTransactions()
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

        private void fillTrans(int enrId)
        {
            try
            {
                checkConnection();
                MySqlDataAdapter da = new MySqlDataAdapter();
                query.Connection = connection;
                query.CommandText = "SELECT transId,transAmount,payMethod,transDate,transDetails,adminId FROM wiztransacations WHERE transType = 'F' AND transAccount = '" + enrId + "' ORDER BY entryId  DESC";
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvTranscations.DataSource = dt;
                connection.Close();

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to fillTrans()  " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                manageControl myC = new manageControl();
                myC.getCntrl();
                this.refNumber = myC.transHeader;
                this.txtRefNumber.Text = "ref" + this.refNumber.ToString();
                this.txtRefNumber.Enabled = false;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to fillTrans()  " + ex);
            }
        }

        private void refreshTrans()
        {
            try
            {
                this.dt.Clear();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to fillTrans()  " + ex);
            }
        }


    private void metroLabel1_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel3_Click(object sender, EventArgs e)
    {

    }

    private void metroTextBox1_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel4_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel2_Click(object sender, EventArgs e)
    {

    }

    private void tlbSelectForm_Click(object sender, EventArgs e)
    {

    }

    private void metroTextBox1_Click_1(object sender, EventArgs e)
    {

    }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void txtEnrolId_Leave(object sender, EventArgs e)
        {
            try
            {
                /*get student information*/
                manageStudent myS = new manageStudent();
                myS.getStudentId(Convert.ToInt32(this.txtEnrolId.Text));
                if(myS.dacFound == true)
                {
                    this.txtFname.Text = myS.firstName;
                    this.btnProcess.Enabled = true;
                    this.txtLastName.Text = myS.lastName;
                    manageClassrooms myClass = new manageClassrooms();
                    myClass.getClass(myS.classId);
                    this.txtClass.Text = myClass.className;
                    /*get balance information*/
                    managefeesBalance  myB = new managefeesBalance();
                    myB.getBalance(this.txtEnrolId.Text, sessions.currTerm);
                    this.txtCurBalance.Text = myB.ClosingBal.ToString();
                    this.txtOpenBal.Text = myB.OpenBal.ToString();
                    this.txtPaid.Text = myB.PaymentIn.ToString();
                    /*populate transactions*/
                    this.fillTrans(Convert.ToInt32(this.txtEnrolId.Text));
                }
                else
                {
                    MessageBox.Show("Enrolment id not registered in system", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in txtEnrolId_Leave() "+ ex, "system error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
  
                var enId = this.txtEnrolId.Text;
                Double amount;
                var tranId = this.txtRefNumber.Text;
                var tranDate = this.txtTranDate.Value.ToShortDateString();
                var details = this.txtTranDetails.Text;
                var payMethod = this.cmbPayTyp.Text;
                if(enId == "" || this.txtFname.Text == "")
                {
                    MessageBox.Show("enrollment id invalid", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtEnrolId.Focus();
                }
                else if(Double.TryParse(this.txtAmount.Text, out amount) == false)
                {
                    MessageBox.Show("enrollment transaction amount", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtAmount.Focus();
                }
                else if(payMethod == ""){
                    MessageBox.Show("select payment method", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtAmount.Focus();
                }
                else
                {
                    bzlTransactions myTran = new bzlTransactions();
                    myTran.accountId = enId;
                    myTran.transAmount = amount;
                    myTran.tranId = tranId;
                    myTran.tranDate = tranDate;
                    myTran.tranDetails = details;
                    myTran.tranType = "F";
                    myTran.payMethod = payMethod;
                    myTran.adminId = sessions.userId;
                    myTran.term = sessions.currTerm;
                    myTran.period = sessions.curPeriod;
                    myTran.payFees();
                    if(myTran.dacCrud == true)
                    {
                        manageControl myC = new manageControl();
                        managefeesBalance myFb = new managefeesBalance();
                        myFb.getBalance(enId, sessions.currTerm);
                        this.refNumber = myC.useTranHeader(this.refNumber);
                        this.txtRefNumber.Text = "ref" + this.refNumber.ToString();
                        this.txtCurBalance.Text = myFb.CurrentBal.ToString();
                        this.txtOpenBal.Text = myFb.OpenBal.ToString();
                        this.txtPaid.Text = myFb.PaymentIn.ToString();
                        this.fillTrans(Convert.ToInt32(enId));
                        MessageBox.Show("transaction processing complete", "system notfication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("failed to process transaction", "system notfication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnProcess_Click() " + ex, "system error");
            }
        }

        private void txtEnrolId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.refreshTrans();
                this.txtAmount.Text = "";
                this.txtClass.Text = "";
                this.txtCurBalance.Text = "";
                this.txtFname.Text = "";
                this.txtLastName.Text = "";
                this.txtOpenBal.Text = "";
                this.txtPaid.Text = "";
                this.txtTranDetails.Text = "";
                this.btnUpdate.Enabled = false;
                this.btnProcess.Enabled = false;
                this.btnDelete.Enabled = false;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to fillTrans()  " + ex);
            }
        }

        private void dgvTranscations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                manageTransaction myT = new manageTransaction();
                int tran = Convert.ToInt32(dgvTranscations.SelectedRows[0].Cells[0].Value);
                myT.getTransacation(tran.ToString());
                this.txtAmount.Text = myT.transAccount.ToString();
                this.txtTranDetails.Text = myT.transDetails;
                this.cmbPayTyp.Text = myT.payMethod;
                this.txtRefNumber.Text = tran.ToString();
                this.txtTranDate.Value = Convert.ToDateTime(myT.transDate);
                this.btnProcess.Enabled = false;
                this.btnDelete.Enabled = true;
                this.btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to fillTrans()  " + ex);
            }
        }

        
    }
}
