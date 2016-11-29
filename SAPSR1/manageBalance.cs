using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageBalance : databaseUtilies
    {
        public string accountId;
        public string periodId;
        public double openBalance;
        public double currentBalance;
        public double closingBalance;
        public double paymentIn;
        public double paymentOut;

        public Boolean setBalance(string acc, string period, double opnbal)
        {
            try
            {
                string sql = "INSERT INTO wizbalances (accountId,periodId,openBalance) VALUES ('" + acc + "','" + period + "','" + opnbal + "' )";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in setBalance()  " + ex);
                return false;
            }
        }

        public void getBalances(string acc, string period)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM wizbalances WHERE accountId= '" + acc + "',periodId = '" + period + "' ";
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.closingBalance = Convert.ToDouble(dataReader["closingBalance"]);
                    this.currentBalance = Convert.ToDouble(dataReader["currentBalance"]);
                    this.openBalance = Convert.ToDouble(dataReader["openBalance"]);
                    this.periodId = dataReader["periodId"].ToString();
                    this.accountId = dataReader["accountId"].ToString();
                    this.paymentOut = Convert.ToDouble(dataReader["paymentOut"]);
                    this.paymentIn = Convert.ToDouble(dataReader["paymentIn"]);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getBalances()  " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public Boolean updateBalance(string acc, string period)
        {
            try
            {
                string sql = "UPDATE wizbalances SET closingBalance = '" + this.accountId + "',currentBalance = '" + this.currentBalance + "',paymentIn= '" + this.paymentIn + "',paymentOut= '" + this.paymentOut + "' WHERE accountId = '" + this.accountId + "' AND periodId = '" + periodId + "' LIMIT 1";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getBalances()  " + ex);
                return false;
            }
        }

       
    }
}
