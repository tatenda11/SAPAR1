using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageStudent: databaseUtilies
    {
        public int systemId;
        public string enrolmentId;
        public string firstName;
        public string middleName;
        public string lastName;
        public int classId;
        public Boolean dacCrud;
        public Boolean dacFound;

        public Boolean setStudent(int enId, string fname, string mname, string lname, int classid)
        {
            try
            {
                string sql = "INSERT INTO wizstudents (enrolmentI,firstName,middleName,lastName,classId)";
                sql += "VALUES ('" + enId + "','" + fname + "','" + mname + "', '" + lname + "', '" + classId + "')";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return false;
            }
        }

        public Boolean updateStudent(int sysId)
        {
            try
            {
                string sql = "UPDATE wizstudents SET firstName = '" + this.firstName + "', middleName = '" + this.middleName + "', lastName = '" + this.lastName + "', classId = '" + this.classId + "'";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return false;
            }
        }

        public void getStudentByQuery(string sql)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.enrolmentId = dataReader["enrolmentId"].ToString();
                    this.firstName = dataReader["firstName"].ToString();
                    this.lastName = dataReader["lastName"].ToString();
                    this.middleName = dataReader["middleName"].ToString();
                    this.systemId = Convert.ToInt32(dataReader["systemId"]);
                    this.classId = Convert.ToInt32(dataReader["classId"]);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getStudentByQuery()  " + ex);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
