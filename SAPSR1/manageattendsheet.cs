using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageattendsheet:databaseUtilies
    {
        public string enrolmentId;
        public string entryData;
        public int classId;
        public string status;
        public string termId;
        public Boolean dacFound;

        public manageattendsheet()
        {
            connection.Close();
        }

        public Boolean setAttend(string enId, string enDate, int classId , string status, string termId)
        {
            try
            {
                string sql = "INSERT INTO wizattendsheet (enrolmentId,entryData,classId,status,termId) VALUES ('"+ enId +"','" + enDate +"', '" + classId + "', '" + status + "','" + termId + "')";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in setAttend()  " + ex);
                return false;
            }
        }

        public void checkEntered(string enId, string atnDate)
        {
            try
            {
                string sql = "SELECT status FROM wizattendsheet WHERE enrolmentId  = '" + enId+ "'  AND entryData = '" + atnDate + "' ";
                if (rowCount(sql) > 0)
                {
                    this.dacFound = true;
                }
                else
                {
                    this.dacFound = false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in setAttend()  " + ex);
            }
        }

        public void getAttend(string enId, string atnDate)
        {
            try
            {
                checkConnection();
                string sql = "SELECT * FROM wizattendsheet WHERE enrolmentId  = '" + enId + "'  AND entryData = '" + atnDate + "' ";
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read()) 
                {
                    this.enrolmentId = dataReader["enrolmentId"].ToString();
                    this.status = dataReader["status"].ToString();
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getAttend()  " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public Boolean updateStatus(string enId, string atnDate, string newStatus)
        {
            try
            {
                string sql = "UPDATE wizattendsheet SET status = '" + newStatus+ "' WHERE enrolmentId  = '" + enId + "'  AND entryData = '" + atnDate + "' LIMIT 1";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in  updateStatus()  " + ex);
                return false;
            }
        }
    }
}
