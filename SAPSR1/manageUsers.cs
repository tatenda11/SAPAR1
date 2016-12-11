using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageUsers : databaseUtilies
    {

        public int userId;
        public string userName;
        public string password;
        public string userType;
        public string email;
        public string empId;
        /******************Flags*********************************/
        public Boolean dacCrud;
        public Boolean dacFound;


        private void checkConnectionq()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {

                    connection.Open();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers checkConnection()  " + e);
            }
        }

        public Boolean setUser(string uName, string password, string uTyp, string email, string emId)
        {
            try
            {
                checkConnection();
                string sql = "INSERT INTO wizuser (userId,userName,password,userType,email,empId)";
                sql += "VALUES ('','" + uName + "', '" + password + "','" + uTyp + "','" + email + "','"+ emId + "')";
                query.Connection = connection;
                query.CommandText = sql;
                int i = query.ExecuteNonQuery();
                this.userId = Convert.ToInt32(query.LastInsertedId);
                this.dacCrud = (i > 0) ? true : false;
                return this.dacCrud;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers setUser()  " + e);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean checkExist(string uName)
        {
            try
            {
                checkConnection();
                string sql = "SELECT userId FROM wizuser WHERE userName = '" + uName + "'";
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader myReader = query.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                this.dacFound = (count > 0) ? true : false;
                return this.dacFound;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers checkExist()  " + e);
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public Boolean loginUser(string uName, string password)
        {
            try
            {
                checkConnection();
                string sql = "SELECT * FROM wizuser WHERE userName = '" + uName + "' AND password = '" + password + "' LIMIT 1";
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader myReader = query.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                    this.userId = Convert.ToInt32(myReader["userId"]);
                }
                this.dacFound = (count > 0) ? true : false;
                return this.dacFound;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers loginUser()  " + e);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public void getUser(int userId)
        {
            try
            {
                checkConnection();
                string sql = "SELECT * FROM wizuser WHERE userId = '" + userId + "'";
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.userId = Convert.ToInt32(dataReader["userId"]);
                    this.userName = dataReader["userName"].ToString();
                    this.password = dataReader["password"].ToString();
                    this.email = dataReader["email"].ToString();
                    this.userType = dataReader["userType"].ToString();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers getUser()  " + e);
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean checkEmployeeIdExist(string emp)
        {
            try
            {
                checkConnection();
                string sql = "SELECT userId FROM wizuser WHERE empId = '" + emp + "'";
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader myReader = query.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                this.dacFound = (count > 0) ? true : false;
                return this.dacFound;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers adminAuth()  " + ex);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean adminAuth(string usr,string  pass)
        {
            try
            {
                string sql = "SELECT * FROM wizuser WHERE userName = '" + usr + "' AND password = '" + pass + "' AND userType = 'A' LIMIT 1";
                if (rowCount(sql) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers adminAuth()  " + e);
                return false;
            }
        }
        public Boolean editUser(int user)
        {
            try
            {
                string sql = "UPDATE wizuser SET userType = '"+ this.userType +"' WHERE userId = '"+ this.userId +"' LIMIT 1";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers editUser()  " + ex);
                return false;
            }
        }

    }
}

