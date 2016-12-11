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
    public partial class frmEnterMarks : MetroFramework.Forms.MetroForm
    {
        public int examId,studentId,paperId,markId;
        MySqlCommand query = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());

        public frmEnterMarks()
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
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                this.fillPapers();
                this.txtComment.Enabled = true;
                this.cmbSelectPaper.Focus();
                this.txtExamID.Text = this.examId.ToString();
                string sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE classId = '"+ sessions.classId +"'ORDER BY systemId DESC ";
                this.fillStudents(sql);
                this.btnDelete.Enabled = false;
                this.btnUpdate.Enabled = false;
                this.btnRecord.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in frmEnterMarks_Load() " + ex.Message);
            }
        }

        private void fillPapers()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                string sql = "SELECT paperId,title FROM wizexampaper WHERE examId =" + this.examId;
                query.CommandText = sql;
                MySqlDataReader myReader = query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("title", typeof(string));
                dt.Columns.Add("paperId", typeof(int));
                dt.Load(myReader);
                this.cmbSelectPaper.ValueMember = "paperId";
                this.cmbSelectPaper.DisplayMember = "title";
                this.cmbSelectPaper.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in fillPapers() " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void fillStudents(string sql)
        {
            try
            {
                checkConnection();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                query.Connection = connection;
                query.CommandText = sql;
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvStudents.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in fillPapers() " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void btnPresent_Click(object sender, EventArgs e)
        {

        }
        */
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSelectPaper_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbSelectPaper_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                var paperId = Convert.ToInt32(cmbSelectPaper.SelectedValue);
                MessageBox.Show(paperId.ToString() + "paper");
                manageExamPaper myP = new manageExamPaper();
                myP.getPaper(paperId);
                this.txtPaperTitle.Text = myP.title;
                this.txtPossible.Text = myP.possibleMark.ToString();*/
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in mbSelectPaper_ValueMemberChanged() " + ex.Message);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //InsertMark(string stdId,int exanId, int atnMark, int posMark, string grde, string remark, string typ ,string tchr, int paper)
                this.btnRecord.Enabled = false;
                int mark = Convert.ToInt32(this.txtMark.Text);
                var comment = this.txtComment.Text;
                int possibleMark = Convert.ToInt32(this.txtPossible.Text);
                string type = this.txtExamCater.Text;
                if(this.txtMark.Text == "")
                {
                    MessageBox.Show("enter the mark to record ",  "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMark.Focus();
                    this.btnRecord.Enabled = true;
                }
                else if(mark > possibleMark)
                {
                    MessageBox.Show("attained mark can not be greater than possible ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMark.Focus();
                    this.btnRecord.Enabled = true;
                }
                else if(comment == "")
                {
                    MessageBox.Show("teacher perfomance analysis required ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtComment.Focus();
                    this.btnRecord.Enabled = true;
                }
                else
                {
                    manageMarks myM = new manageMarks();
                    //InsertMark(string stdId, int exanId, int atnMark, int posMark, string grde, string remark, string typ, string tchr, int paper)
                    myM.getMarkByPaper(this.studentId, this.paperId);
                    if(myM.dacFound == false)
                    {
                        if (myM.InsertMark(this.studentId.ToString(), this.examId, mark, possibleMark, getGrade(mark).ToString(), comment, type, sessions.userId.ToString(), this.paperId) == true)
                        {
                            MessageBox.Show("Marks enter success ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnRecord.Enabled = true;
                            this.btnDelete.Enabled = false;
                            this.btnUpdate.Enabled = false;
                            refresh();
                        }
                        else
                        {
                            this.btnRecord.Enabled = true;
                            MessageBox.Show("faled to insert mark", "system info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("mark already entered", "system info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnRecord_Click() " + ex.Message);
            }
        }

        private void cmbSelectPaper_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.paperId = Convert.ToInt32(cmbSelectPaper.SelectedValue);
                manageExamPaper myP = new manageExamPaper();
                myP.getPaper(this.paperId);
                this.txtPaperTitle.Text = myP.title;
                this.txtPossible.Text = myP.possibleMark.ToString();
                manageExams myE = new manageExams();
                myE.getExam(this.examId);
                this.txtExamDescription.Text = myE.description;
                this.txtExamCater.Text = myE.examTyp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in mbSelectPaper_ValueMemberChanged() " + ex.Message);
            }
        }

        private void dgvStudents_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
                this.txtComment.Text = "";
                this.txtMark.Text = "";
                manageStudent myS = new manageStudent();
                myS.getStudentId(this.studentId);
                this.txtFname.Text = myS.firstName;
                this.txtLastname.Text = myS.lastName;
                manageMarks myM = new manageMarks();
                myM.getMarkByPaper(studentId, paperId);
                if(myM.dacFound == true)
                {
                    MessageBox.Show("Marks for this paper already " + myS.firstName + " "+ myS.lastName, "system info", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.txtComment.Text = myM.remarks;
                    this.markId = myM.markId;
                    this.txtMark.Text = myM.attainedMark.ToString();
                    this.btnRecord.Enabled = false;
                    this.btnDelete.Enabled = true;
                    this.btnUpdate.Enabled = true;
                }
                else
                {
                    this.btnDelete.Enabled = false;
                    this.btnUpdate.Enabled = false;
                    this.btnRecord.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in dgvStudents_DoubleClick() " + ex.Message);
            }
        }

        private void refresh()
        {
            this.txtComment.Text = "";
            this.txtMark.Text = "0";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //InsertMark(string stdId,int exanId, int atnMark, int posMark, string grde, string remark, string typ ,string tchr, int paper)
                int mark = Convert.ToInt32(this.txtMark.Text);
                var comment = this.txtComment.Text;
                int possibleMark = Convert.ToInt32(this.txtPossible.Text);
                string type = this.txtExamCater.Text;
                if (this.txtMark.Text == "")
                {
                    MessageBox.Show("enter the mark to record ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMark.Focus();
                }
                else if (mark > possibleMark)
                {
                    MessageBox.Show("attained mark can not be greater than possible ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMark.Focus();
                }
                else if (comment == "")
                {
                    MessageBox.Show("teacher perfomance analysis required ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtComment.Focus();
                }
                else
                {
                    manageMarks myM = new manageMarks();
                    myM.getMark(this.markId);
                    myM.attainedMark = mark;
                    myM.remarks = comment;
                    myM.grade = getGrade(mark);
                    if (myM.UpdateMark(this.markId)== true)
                    {
                        MessageBox.Show("Marks update success success ", "system info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnDelete.Enabled = false;
                        this.btnUpdate.Enabled = false;
                        this.btnRecord.Enabled = true;
                        refresh();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnUpdate_Click() " + ex.Message);
            }
        }

        private void txtMark_Leave(object sender, EventArgs e)
        {
            if(validator.isValidMoney(this.txtMark.Text) == false)
            {
                MessageBox.Show("please enter a valid mark", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMark.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                manageMarks myM = new manageMarks();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this mark record", "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    if(myM.deleteMark(this.markId) == true)
                    {
                        MessageBox.Show("mark deleted success", "Confirm Option", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.btnDelete.Enabled = false;
                        this.btnUpdate.Enabled = false;
                        this.btnRecord.Enabled = true;
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete mark", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnDelete_Click() " + ex.Message);
            }
        }

        private double getPercernt(double mark)
        {
            return ((mark / Convert.ToDouble(this.txtPossible.Text)) * 100);
        }

        private string getGrade(double mark)
        {

            mark = getPercernt(mark);
            string grade = "";
            if (mark >= 90)
            {
                grade = "1";
            }
            else if(mark >= 80 && 90 > mark)
            {
                grade = "2";
            }
            else if (mark >= 70 && 80 > mark)
            {
                grade = "3";
            }
            else if(mark >= 60 && 70 > mark)
            {
                grade = "4";
            }
            else if(mark >= 50 && 60 > mark)
            {
                grade = "5";
            }
            else if(mark >= 40 && 50 > mark)
            {
                grade = "5";
            }
            else if (mark >= 30 && 40 > mark)
            {
                grade = "6";
            }
            else if (mark >= 20 && 30 > mark)
            {
                grade = "7";
            }
            else if (mark >= 10 && 20 > mark)
            {
                grade = "8";
            }
            else
            {
                grade = "9";
            }
            return grade;
        }
    }
}
