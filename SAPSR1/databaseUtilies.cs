using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace SAPSR1
{
    class databaseUtilies
    {
        protected static MySqlConnection connection = new MySqlConnection(GetConnectionStrings());
        protected static MySqlCommand query = new MySqlCommand();
        //protected static DataTable dt = new DataTable();
        //protected static MySqlDataAdapter da;

        public static string GetConnectionStrings()
        {

            return ConfigurationManager.ConnectionStrings["DatastoreDataContextConnectionString"].ConnectionString;
        }

        protected static void checkConnection()
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
                System.Windows.Forms.MessageBox.Show("Failed in manageUsers checkConnection()  " + e.Message);
            }
        }

        protected static Boolean executeQuery(String sql)
        {
            try
            {
                connection.Close();
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                int i = query.ExecuteNonQuery();
                return (i > 0) ? true : false;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed execute query  " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        protected static int row_count(string sql)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                return Convert.ToInt32(query.ExecuteScalar());
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed execute query  " + ex);
                return 0;
            }

        }


        protected static int rowCount(string sql)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader myReader = query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(myReader);
                int numberOfResults = dt.Rows.Count;
                dt.Clear();
                return numberOfResults; 
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in sdbutilities rowCount()  " + ex);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
