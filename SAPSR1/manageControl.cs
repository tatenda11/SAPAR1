using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SAPSR1
{
    class manageControl : databaseUtilies
    {
        public string currentPeriod;
        public string prevPeriod;
        public string nextPeriod;
        public string currTerm;
        public string prevTerm;
        public string nextTerm;
        public int empId;
        public int enrollmentId;
        public Double fees;
        public int transHeader;

        public Boolean updateCntrl()
        {
            try
            {
                string sql = "UPDATE control SET currentPeriod = '"+ this.currentPeriod + "', prevPeriod = '"+ this.prevPeriod +"', nextPeriod = '" + this.nextPeriod + "', currTerm = '" + this.currTerm + "', prevTerm = '" + this.prevTerm + "', nextTerm = '" + this.nextTerm+ "', enrollmentId = '" + this.enrollmentId + "', transHeader = '" + this.transHeader + "', empId = '"+ this.empId  + "' ";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in setStudentDetails()  " + ex);
                return false;
            }
        }

        public void getCntrl()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM control";
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.currentPeriod = dataReader["currentPeriod"].ToString();
                    this.currTerm = dataReader["currTerm"].ToString();
                    this.enrollmentId = Convert.ToInt32(dataReader["enrollmentId"]);
                    this.nextPeriod = dataReader["nextPeriod"].ToString();
                    this.nextTerm = dataReader["nextTerm"].ToString();
                    this.prevPeriod = dataReader["prevPeriod"].ToString();
                    this.fees = Convert.ToDouble(dataReader["feesAmount"]);
                    this.prevTerm = dataReader["prevTerm"].ToString();
                    this.transHeader = Convert.ToInt32(dataReader["transHeader"]);
                    this.empId = Convert.ToInt32(dataReader["empId"]); 
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getCntrl()  " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public int useTranHeader(int header)
        {
            try
            {
                header += 1;
                String sql = "UPDATE control SET transHeader = '" + header + "' ";
                if(executeQuery(sql) == true)
                {
                    return header;
                }
                else
                {
                    return header;
                }

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in useTranHeader()  " + ex);
                return 0;
            }
        }

        public int useEmpHeader(int header)
        {
            try
            {
                header += 1;
                String sql = "UPDATE control SET empId = '" + header + "' ";
                if (executeQuery(sql) == true)
                {
                    return header;
                }
                else
                {
                    return header;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in useTranHeader()  " + ex);
                return 0;
            }
        }
        public Boolean useEnrolmentId()
        {
            try
            {
                this.enrollmentId += 1;
                String sql = "UPDATE control SET enrollmentId = '" + this.enrollmentId + "' ";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in useEnrolmentId  " + ex);
                return false;
            }
        } 
    }
}
