using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPSR1
{
    class bzlTransactions
    {
        public string accountId;
        public Double transAmount;
        public string tranId;
        public double accumatedPayement;
        public string tranDate;
        public string tranDetails;
        public string tranType;
        public string payMethod;
        public int adminId;
        public string term;
        public string period;
        public double curBalance;
        public Boolean dacCrud = false;

        public void payFees()
        {
            try
            {
                /*enter the transacation*/
                manageTransaction myT = new manageTransaction();
                if (myT.setTrans(this.tranId,this.accountId,this.tranType,this.transAmount,this.tranDate,this.adminId,this.term,this.period,this.payMethod,this.tranDetails) == true)
                {
                    /*proccess ballance*/
                    managefeesBalance myFb = new managefeesBalance();
                    myFb.getBalance(accountId, term);
                    if(myFb.dacFound == true)
                    {
                        this.accumatedPayement = myFb.PaymentIn + transAmount;
                        this.curBalance = myFb.CurrentBal - transAmount;
                        myFb.CurrentBal = this.curBalance;
                        myFb.ClosingBal = this.curBalance;
                        myFb.PaymentIn = myFb.PaymentIn + transAmount;
                        if (myFb.updateBalances(accountId, term) == true)
                        {
                            this.dacCrud = true;
                        }
                    }
                    else
                    {
                        if(myFb.setBalance(accountId,term,sessions.fees) == true)
                        {
                            System.Windows.Forms.MessageBox.Show("balance entered");
                            myFb.getBalance(accountId, term);
                            this.curBalance = myFb.CurrentBal - transAmount;
                            this.accumatedPayement = myFb.PaymentIn + transAmount;
                            myFb.CurrentBal = this.curBalance;
                            myFb.ClosingBal = this.curBalance;
                            myFb.PaymentIn = myFb.PaymentIn + transAmount;
                            if (myFb.updateBalances(accountId,term) == true)
                            {
                                System.Windows.Forms.MessageBox.Show("balance updated");
                                this.dacCrud = true;
                            }
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("system error " + ex);
            }
        }

    }
}
