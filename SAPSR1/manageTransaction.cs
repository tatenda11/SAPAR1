using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageTransaction : databaseUtilies
    {
        public string transId;
        public string transAccount;
        public string transType;
        public double transAmount;
        public int adminId;
        public string transDate;
        public string transTerm;
        public string transPeriod;
        public string transDetails;
        public string payMethod;
        public Boolean dacFound;

        public manageTransaction()
        {
            connection.Close();
        }

        public Boolean setTrans(string tranId, string acc, string typ, double amnt, string tranDate, int id, string term, string period, string payMethod, string details)
        {
            try
            {
                string sql = "INSERT INTO wiztransacations (transId,transAccount,transType,transAmount,transDate,adminId,transTerm,transPeriod,transDetails,payMethod)";
                sql += "VALUES ('"+ tranId + "','" + acc + "','"+ typ + "','"+ amnt + "', '"+ tranDate + "','"+ id +"','"+ term +"','"+ period +"','"+ details + "', '"+ payMethod +"')";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("system error " + ex);
                return false;
            }
        }

        public Boolean updateTransaction(string transId, int admin)
        {
            try
            {
                string sql = "UPDATE wiztransacations SET transAmount = '"+ this.transAmount + "' , transDate = '"+ this.transDate + "', payMethod = '"+ this.payMethod+"' LIMIT 1";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("system error " + ex);
                return false;
            }
        }
        public void getTransacation(string tranId)
        {
            try
            {
                string sql = "SELECT * FROM wiztransacations WHERE transId = '"+ tranId +"'";
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
                    while (dataReader.Read())
                    {
                        this.payMethod = dataReader["payMethod"].ToString();
                        this.transAccount= dataReader["transAccount"].ToString();
                        this.adminId = Convert.ToInt32(dataReader["adminId"]);
                        this.transAmount = Convert.ToDouble(dataReader["transAmount"]);
                        this.transDate = dataReader["transDate"].ToString();
                        this.transDetails = dataReader["transDetails"].ToString();
                        this.transPeriod = dataReader["transPeriod"].ToString();
                        this.transTerm = dataReader["transTerm"].ToString();
                        this.transType = dataReader["transType"].ToString();
                        this.transId = dataReader["transId"].ToString();
                    }

                }
                else
                {
                    this.dacFound = false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("system error " + ex);
            }
            finally
            {
                connection.Close();
            }

        } 

        public Boolean DeleteTrans(string tranId)
        {
            try
            {
                string sql = "DELETE FROM wiztransacations WHERE transId = '" + tranId + "'";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("system error " + ex);
                return false;
            }
        }

    }
}
