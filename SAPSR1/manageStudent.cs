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
        public string DOB;
        public string gender;
        /* public Boolean dacCrud;*/
        public Boolean dacFound;

        public Boolean setStudent(int enId, string fname, string mname, string lname, int classid, string db, string gndr)
        {
            try
            {
                string sql = "INSERT INTO wizstudents (enrolmentId,firstName,middleName,lastName,classId,DOB,gender)";
                sql += "VALUES ('" + enId + "','" + fname + "','" + mname + "', '" + lname + "', '" + classId + "','"+ db +"','"+gndr+"')";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return false;
            }
        }

        public Boolean updateStudent(int enrl)
        {
            try
            {
                string sql = "UPDATE wizstudents SET firstName = '" + this.firstName + "',DOB = '" + this.DOB +"', middleName = '" + this.middleName + "', lastName = '" + this.lastName + "',gender = '"+this.gender+"', classId = '" + this.classId + "' WHERE enrolmentId = '"+ enrl +"'";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return false;
            }
        }
        public Boolean deleteStudent(int enId)
        {
            try
            {
                string sql = "DELETE FROM wizstudents WHERE enrolmentId = '"+ enId+"' LIMIT 1";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return false;
            }
        }

        public int checkExists(int enId)
        {
            try
            {
                string sql = "SELECT * FROM wizstudents WHERE enrolmentId = '"+ enId +"'";
                return rowCount(sql);
            } 
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return 10;// return 10 becouse we want 0 users existing to control
            }
        }

        public int countByClass(int classId)
        {
            try
            {
                string sql = "SELECT firstName FROM wizstudents WHERE classId =" + classId;
                return rowCount(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getClass()  " + ex);
                return 0;
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
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
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
                else
                {
                    this.dacFound = false;
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

        public void getStudentId(int id)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                string sql = "SELECT * FROM wizstudents WHERE enrolmentId = '" + id  +"' LIMIT 1";
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
                    while (dataReader.Read())
                    {
                        this.enrolmentId = dataReader["enrolmentId"].ToString();
                        this.firstName = dataReader["firstName"].ToString();
                        this.lastName = dataReader["lastName"].ToString();
                        this.middleName = dataReader["middleName"].ToString();
                        this.systemId = Convert.ToInt32(dataReader["systemId"]);
                        this.classId = Convert.ToInt32(dataReader["classId"]);
                        this.gender = dataReader["gender"].ToString();
                        this.DOB = dataReader["DOB"].ToString();
                    }

                }
                else
                {
                    this.dacFound = false;
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
