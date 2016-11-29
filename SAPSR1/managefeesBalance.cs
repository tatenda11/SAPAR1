using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class managefeesBalance:databaseUtilies
    {
        public String enrollmentId;
        public String termPeriod;
        public double OpenBal;
        public double CurrentBal;
        public double ClosingBal;
        public double PaymentIn;
        public Boolean dacFound;

       public managefeesBalance()
        {
            connection.Close();
        }

        public Boolean setBalance(string enId, string term, double openBal)
        {
            try
            {
                string sql = "INSERT INTO wizfeesbalances (enrollmentId, termPeriod,OpenBal,CurrentBal,ClosingBal) VALUES ('"+ enId +"','"+ term +"','"+ openBal + "','" + openBal + "','" + openBal + "')";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in managefees setBalance()  ", "system error");
                return false;
            }
        }

        public void getBalance(string enId, string term)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM wizfeesbalances WHERE enrollmentId= '" + enId + "' AND termPeriod = '" + term + "' ";
                MySqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
                    while (dataReader.Read())
                    {
                        this.CurrentBal = Convert.ToDouble(dataReader["CurrentBal"]);
                        this.ClosingBal = Convert.ToDouble(dataReader["ClosingBal"]);
                        this.OpenBal = Convert.ToDouble(dataReader["OpenBal"]);
                        this.termPeriod = dataReader["termPeriod"].ToString();
                        this.enrollmentId = dataReader["enrollmentId"].ToString();
                        this.PaymentIn = Convert.ToDouble(dataReader["PaymentIn"]);
                    }
                }
                else
                {
                    this.dacFound = false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in managefees setBalance()  ", "system error");
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean updateBalances(string enId, string term)
        {
            try
            {
                string sql = "UPDATE wizfeesbalances SET CurrentBal = '"+ this.CurrentBal +"',ClosingBal = '"+ this.ClosingBal + "',PaymentIn = '"+ this.PaymentIn + "' WHERE enrollmentId = '" + enId + "' AND termPeriod = '"+ this.termPeriod +"' LIMIT 1";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in managefees setBalance()  ", "system error");
                return false;
            }
        }

        public void checkExist(string term, string enrl)
        {
            try
            {
                string sql = "SELECT CurrentBal FROM wizfeesbalances WHERE enrollmentId = '"+ enrl + "' AND termPeriod = '" + term + "' ";
                if(rowCount(sql) > 0)
                {
                    this.dacFound = true;
                }
                else
                {
                    this.dacFound = false;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getBalances()  " + ex);
            }
        }


    }
}
