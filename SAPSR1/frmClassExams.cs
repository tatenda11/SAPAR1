using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    public partial class frmClassExams : MetroFramework.Forms.MetroForm
    {
        MySqlCommand query = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        public int examId;

        public frmClassExams()
        {
            InitializeComponent();
        }

        private void checkConnection()
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
                System.Windows.Forms.MessageBox.Show("Failed to connect  " + e);
            }
        }

        private void frmClassExams_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT examId,subjectId,examTyp,title,examDes FROM wizexams WHERE teacherId = '" + sessions.userId + "' AND termId = '" + sessions.currTerm + "' UNION (SELECT examId,subjectId,examTyp,title,examDes FROM wizexams WHERE classGrade = '"+ sessions.classGrade + "' AND termId = '"+ sessions.currTerm + "' AND examTyp = 'END OF TERM') ";
                this.fillExams(sql);
                this.btnRecordMarks.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in frmClassExams_Load() "+ ex.Message);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        public void fillExams(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvExams.DataSource = dt;
                // dt.Clear();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in fillExams() " + ex.Message);
            }
        }

        private void txtSearchExam_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtSearchExam_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var txt = this.txtSearchExam.Text;
                string sql = "SELECT examId,subjectId,examTyp,title,examDes FROM wizexams WHERE teacherId = '" + sessions.userId + "' AND termId = '" + sessions.currTerm + "' AND title LIKE '%" + txt + "%' UNION (SELECT examId,subjectId,examTyp,title,examDes FROM wizexams WHERE classGrade = '" + sessions.classGrade + "' AND termId = '" + sessions.currTerm + "' AND title LIKE '%" + txt + "%') ";
                this.fillExams(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in fillExams() " + ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var type = this.cmbExamTye.Text;
                var txt = this.txtSearchExam.Text;
                if(type == "")
                {
                    var sql = "SELECT examId,subjectId,examTyp,title,examDes FROM wizexams WHERE  termId = '" + sessions.currTerm + "' AND classGrade = '" + sessions.classGrade + "' AND examTyp = 'END OF TERM'";
                    // MessageBox.Show(sql);
                    this.fillExams(sql);
                }
                else
                {  
                    var sql = "SELECT examId,subjectId,examTyp,title,examDes FROM wizexams WHERE  termId = '" + sessions.currTerm + "' AND classGrade = '" + sessions.classGrade + "' AND subjectId = '" + type + "'  AND examTyp = 'END OF TERM'";
                    this.fillExams(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in fillExams() " + ex.Message);
            }
        }

        private void dgvExams_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.examId = Convert.ToInt32(dgvExams.SelectedRows[0].Cells[0].Value);
                this.btnRecordMarks.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in fillExams() " + ex.Message);
            }
        }

        private void btnRecordMarks_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnterMarks myM = new frmEnterMarks();
                myM.examId = this.examId;
                myM.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in btnRecordMarks_Click() " + ex.Message);
            }
        }
    }
}
