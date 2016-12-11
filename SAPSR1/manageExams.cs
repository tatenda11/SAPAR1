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
        public string subjectId;
        public string examTyp;
        public string termId;
        public int classGrade;
        public int teacherId;
        public string description;
        public string title;

        public manageExams()
        {
            connection.Close();
        }

        public Boolean setExam(string sub, string typ, string term,int grade,int tchr, string des, string title)
        {
            try
            {
                string sql = "INSERT INTO wizexams (subjectId,examTyp,termId,classGrade,teacherId,examDes,title) VALUES ('"+ sub +"','" + typ + "', '" + term + "','" + grade +"','"+ tchr  + "','"+ des +"','"+ title +"')";
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
                string sql = "UPDATE wizexams SET subjectId = '" + this.subjectId + "',examTyp = '" + this.examTyp + "', termId = '" + this.termId + "', classGrade = '" + this.classGrade + "',examDes = '" + this.description + "',title = '" + this.title + "' WHERE examId = '" + exam + "'";
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
                    this.examId = Convert.ToInt32(dataReader["examId"]);
                    this.classGrade = Convert.ToInt32(dataReader["classGrade"]);
                    this.examTyp= dataReader["examTyp"].ToString();
                    this.subjectId = dataReader["subjectId"].ToString();
                    this.teacherId = Convert.ToInt32(dataReader["teacherId"]);
                    this.termId = dataReader["termId"].ToString();
                    this.description = dataReader["examDes"].ToString();
                    this.title = dataReader["title"].ToString(); ;
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
                System.Windows.Forms.MessageBox.Show("failed in manageExam get Eaxm() " + ex.Message);
                return false;
            }
        }

        public Boolean checkEndTermExamSet(string subject, string grade, string term)
        {
            try
            {
                string sql = "SELECT examId FROM wizexams WHERE subjectId = '" + subject + "' AND classGrade = '" + grade + "' AND termId = '" + term + "' ";
                if(rowCount(sql) > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in manageExam get Eaxm() " + ex.Message);
                return true;
            }
        }
    }
}
