using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SAPSR1
{
    class manageMarks:databaseUtilies
    {
        public string studentId;
        public int examId;
        public int markId;
        public int attainedMark;
        public int possibleMark;
        public int paperId;
        public string grade;
        public string remarks;
        public string examType;
        public int teacherId;
        public Boolean dacFound;

        public Boolean InsertMark(string stdId,int exanId, int atnMark, int posMark, string grde, string remark, string typ ,string tchr, int paper)
        {
            try
            {
                string sql = "INSERT INTO wizMarks (studentId,examId,attainedMark,grade,remarks,examType,teacherId,paperId,possibleMark) VALUES ('" + stdId + "','"+ exanId + "','" + atnMark + "','"+ grde  + "','"+ remark+"','"+ typ +"', '"+ tchr +"','"+ paper +"','"+ posMark + "')";
                return executeQuery(sql);

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean UpdateMark(int markId)
        {
            try
            {
                string sql = "UPDATE wizMarks SET attainedMark = '" + this.attainedMark + "', grade = '" + this.grade + "', remarks = '" + this.remarks + "' WHERE  markId = '" + markId + "' LIMIT 1";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void getMark(int mrkId)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM wizMarks WHERE markId = '"+ mrkId+ "' LIMIT 1  ";
                MySqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
                    while (dataReader.Read())
                    {
                        this.attainedMark = Convert.ToInt32(dataReader["attainedMark"]);
                        this.examId = Convert.ToInt32(dataReader["examId"]);
                        this.examType = dataReader["examType"].ToString();
                        this.grade = dataReader["grade"].ToString();
                        this.markId = Convert.ToInt32(dataReader["markId"]);
                        this.possibleMark = Convert.ToInt32(dataReader["possibleMark"]);
                        this.paperId = Convert.ToInt32(dataReader["paperId"]);
                        this.remarks = dataReader["remarks"].ToString();
                        this.studentId = dataReader["studentId"].ToString();
                        this.teacherId = Convert.ToInt32(dataReader["teacherId"]);
                    }
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean deleteMark(int mrkId)
        {
            try
            {
                string sql = "DELETE FROM wizMarks WHERE markId = '" + mrkId + "' LIMIT 1";
                System.Windows.Forms.MessageBox.Show(sql);
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in deleteMark()" + ex.Message);
                return false;
            }
        }

        public void getMarkByPaper(int student, int paper)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM wizMarks WHERE paperId = '" + paper + "' AND studentId = '"+ student +"' LIMIT 1  ";
                MySqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
                    while (dataReader.Read())
                    {
                        this.attainedMark = Convert.ToInt32(dataReader["attainedMark"]);
                        this.examId = Convert.ToInt32(dataReader["examId"]);
                        this.examType = dataReader["examType"].ToString();
                        this.grade = dataReader["grade"].ToString();
                        this.markId = Convert.ToInt32(dataReader["markId"]);
                        this.possibleMark = Convert.ToInt32(dataReader["possibleMark"]);
                        this.paperId = Convert.ToInt32(dataReader["paperId"]);
                        this.remarks = dataReader["remarks"].ToString();
                        this.studentId = dataReader["studentId"].ToString();
                        this.teacherId = Convert.ToInt32(dataReader["teacherId"]);
                    }
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("failed in  getMarkByPaper" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
