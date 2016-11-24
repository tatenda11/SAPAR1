using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageExamPaper:databaseUtilies
    {
        public int paperId;
        public int examId;
        public int possibleMark;
        public string description; 
        public manageExamPaper()
        {
            connection.Close();
        }

        public Boolean setPaper(int exam, int mark, string des)
        {
            try
            {
                string sql = "INSERT INTO wizexampaper (examId, possibleMark, description) VALUES ('" + exam +"','"+ mark +"','"+ des +"' )";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExamPaper setPaper" + ex);
                return false;
            }

        }

        public Boolean updatePaper(int paper)
        {
            try
            {
                string sql = "UPDATE wizexampaper SET examId = '"+ this.examId +"', possibleMark = '"+ this.possibleMark + "', description = '" + this.description + "' WHERE paperId = '" + paper +"' LIMIT 1 ";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExamPaper setPaper" + ex);
                return false;
            }
        }

        public void getPaper(int paper)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                string sql = "SELECT * FROM wizexampaper WHERE paperId = '" + paper + "' LIMIT 1";
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.examId = Convert.ToInt32(dataReader["examId"]);
                    this.possibleMark = Convert.ToInt32(dataReader["possibleMark"]);
                    this.description = dataReader["description"].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExamPaper getPaper" + ex);
            }
            finally
            {
                connection.Close();
            }

        }


    }
}
