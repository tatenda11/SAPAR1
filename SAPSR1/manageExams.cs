using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageExams:databaseUtilies
    {
        public int examId;
        public int subjectId;
        public string examTyp;
        public string termId;
        public int classGrade;
        public int teacherId;
        public string description; 

        public manageExams()
        {
            connection.Close();
        }

        public Boolean setExam(int sub, string typ, string term,int grade,int tchr, string des)
        {
            try
            {
                string sql = "INSERT INTO wizexams (subjectId,examTyp,termId,classGrade,teacherId,description) VALUES ('"+ sub +"','" + typ + "', '" + term + "','" + grade +"','"+ teacherId+"','"+ des +"')";
                return executeQuery(sql);

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExam setEaxm()");
                return false;
            }
        }

        public Boolean updateExam(int exam)
        {
            try
            {
                string sql = "UPDATE wizexams SET subjectId = '" + this.subjectId + "',examTyp = '" + this.examTyp + "', termId = '" + this.termId + "', grade = '" + this.classGrade + "',description = '" + this.description + "' WHERE examId = '" + exam + "'";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExam setEaxm()");
                return false;
            }

        }

        public void getExam(int examId)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                string sql = "SELECT * FROM wizexams WHERE examId = '" + examId +"' LIMIT 1";
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.examId = Convert.ToInt32(dataReader["systemId"]);
                    this.classGrade = Convert.ToInt32(dataReader["systemId"]);
                    this.examTyp= dataReader["lastName"].ToString();
                    this.subjectId = Convert.ToInt32(dataReader["systemId"]);
                    this.teacherId = Convert.ToInt32(dataReader["teacherId"]);
                    this.termId = dataReader["lastName"].ToString();
                    this.description = dataReader["description"].ToString();
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExam get Eaxm() " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean deleteExam(int exId)
        {
            try
            {
                string sql = "DELETE FROM wizexams WHERE examId = '" + exId + "' LIMIT 1";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExam get Eaxm() " + ex);
                return false;
            }
        }
    }
}
