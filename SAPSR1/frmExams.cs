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
    public partial class frmExams : MetroFramework.Forms.MetroForm
    {


        MySqlCommand query = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        int examId;
        int paperId;

        public frmExams()
        {
            InitializeComponent();
        }


       private void frmExams_Load(object sender, EventArgs e)
        {
            try
            {
                this.fillExams();
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error of rtt" + ex);
            }
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
        private void fillExams()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                query.CommandText = "SELECT examId,title,subjectId,examDes FROM wizexams WHERE termId = '"+ sessions.currTerm + "' AND teacherId = '"+ sessions.userId +"' ORDER BY examId DESC";
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvExams.DataSource = dt;
                //dt.Clear();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void fillPapers(int exam)
        {
            try
            {
                checkConnection();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                query.Connection = connection;
                query.CommandText = "SELECT paperId,title,description,possibleMark FROM wizexampaper WHERE examId = '" + exam + "' ORDER BY examId DESC";
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvPapers.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }




        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = this.cmbSubject.Text;
                var grade = this.cmbGrade.Text;
                var typ = this.cmbExamType.Text;
                var title = this.txtExamTitle.Text;
                var des = this.txtExamDes.Text;
                if (subject == "" || grade == "" || typ == " " || title == "" || des == "")
                {
                    MessageBox.Show("make sure u fill in all fields", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    manageExams myE = new manageExams();
                    if(myE.setExam(subject,typ,sessions.currTerm,Convert.ToInt32(grade),sessions.userId,des,title) == true)
                    {
                        MessageBox.Show("exam added sucessifully", "system notificaton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fillExams();
                    }
                }
           }
            catch(Exception ex)
            {

                MessageBox.Show("Application error  " + ex);
            }
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvExams_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                examId = Convert.ToInt32(dgvExams.SelectedRows[0].Cells[0].Value);
                manageExams myE = new manageExams();
                myE.getExam(examId);
                this.cmbExamType.Text = myE.examTyp;
                this.cmbSubject.Text = myE.subjectId;
                this.cmbGrade.Text = myE.classGrade.ToString();
                this.txtExamTitle.Text = myE.title;
                this.txtExamDes.Text = myE.description;
                this.btnSaveExam.Enabled = false;
                this.fillPapers(examId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Application error  "+ ex);
            }
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = this.cmbSubject.Text;
                var grade = this.cmbGrade.Text;
                var typ = this.cmbExamType.Text;
                var title = this.txtExamTitle.Text;
                var des = this.txtExamDes.Text;
                if (subject == "" || grade == "" || typ == " " || title == "" || des == "")
                {
                    MessageBox.Show("make sure u fill in all fields", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    manageExams myE = new manageExams();
                    myE.getExam(this.examId);
                    myE.classGrade = Convert.ToInt16(grade);
                    myE.examTyp = typ;
                    myE.title = title;
                    myE.description = des;
                    if(myE.updateExam(this.examId) == true)
                    {
                        MessageBox.Show("Exam updated success", "System notifcation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.refresh();
                        this.fillExams();
                    }
                    else
                    {
                        MessageBox.Show("Exam updated failed", "System notifcation ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Application error  " + ex);
            }
        }

        public void refresh()
        {
            this.cmbExamType.Text ="";
            this.cmbSubject.Text = "";
            this.cmbGrade.Text ="";
            this.txtExamTitle.Text ="";
            this.txtExamDes.Text = "";
            this.btnSaveExam.Enabled = true;
            this.btnUpdateExam.Enabled = true;
            this.txtPossibleMark.Text = "";
            this.txtPaperDes.Text = "";
            this.txtPaperTitle.Text = "";
            this.btnSavePaper.Enabled = true;
            this.btnUpdatepaper.Enabled = true;
        }

        private void btnSavePaper_Click(object sender, EventArgs e)
        {
            try
            {
                var paperName = this.txtPaperTitle.Text;
                var mark = Convert.ToInt32(this.txtPossibleMark.Text);
                var des = this.txtPaperDes.Text;
                if(paperName == "")
                {
                    MessageBox.Show("exam paper should have a title", "Input error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(this.txtPossibleMark.Text == "")
                {
                    MessageBox.Show("please supply a possible mark for paper", "Input error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    manageExamPaper myEp = new manageExamPaper();
                    if(myEp.setPaper(this.examId,mark,des,paperName)== true)
                    {
                        this.refresh();
                        this.fillPapers(this.examId);
                        MessageBox.Show("exam paper added sucessifully", "system notification ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("exam paper failed to add", "system notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("applicaton error " + ex);
            }
        }

        private void dgvPapers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                paperId = Convert.ToInt32(this.dgvPapers.SelectedRows[0].Cells[0].Value);
                manageExamPaper myP = new manageExamPaper();
                myP.getPaper(paperId);
                this.txtPaperDes.Text = myP.description;
                this.txtPossibleMark.Text = myP.possibleMark.ToString();
                this.txtPaperTitle.Text = myP.title;
                this.btnSavePaper.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("applicaton error " + ex);
            }
        }

        private void btnUpdatepaper_Click(object sender, EventArgs e)
        {
            try
            {
                var paperName = this.txtPaperTitle.Text;
                var mark = Convert.ToInt32(this.txtPossibleMark.Text);
                var des = this.txtPaperDes.Text;
                if (paperName == "")
                {
                    MessageBox.Show("exam paper should have a title", "Input error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.txtPossibleMark.Text == "")
                {
                    MessageBox.Show("please supply a possible mark for paper", "Input error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    manageExamPaper myEp = new manageExamPaper();
                    myEp.getPaper(paperId);
                    myEp.title = paperName;
                    myEp.possibleMark = mark;
                    myEp.description = des;
                    if (myEp.updatePaper(this.paperId) == true)
                    {
                        this.refresh();
                        this.fillPapers(this.examId);
                        MessageBox.Show("exam paper updated sucessifully", "system notification ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("exam paper failed to updete", "system notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("applicaton error " + ex);
            }
        }
    }
}
