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
    public partial class frmAttendance : MetroFramework.Forms.MetroForm
    {
        MySqlCommand query = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        int classId;
        int page = 0;
        int classTotal;
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            try
            {
                if (sessions.userType == "T")
                {
                    manageClassrooms myC = new manageClassrooms();
                    manageStudent myS = new manageStudent();
                    myC.getClassByTeacher(sessions.userId);
                    this.classId = myC.classRoomId;
                    this.classTotal = 3;
                    this.lbCounter.Text = page.ToString() + "/" + classTotal.ToString();
                    this.fillStudents();

                } 
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("frmAttendance_Load()  " + ex);
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

        public void fillStudents()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM wizstudents WHERE classId =" + this.classId;
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvStudents.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("application error fillTeacher()  " + ex);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if(page < 0)
                {
                    page = 0;
                }
                this.lbCounter.Text = page.ToString() + "/" + classTotal.ToString();
                manageStudent myS = new manageStudent();
                string sql = "SELECT * FROM wizstudents WHERE classId = " + this.classId + " ORDER BY systemId ASC LIMIT 1 OFFSET " + this.page;
                myS.getStudentByQuery(sql);
                //SELECT * FROM fi_posts WHERE wall = ? AND agent = ? ORDER BY postId DESC LIMIT $page ,$per_pa
                this.txtEnId.Text = myS.enrolmentId;
                this.txtFname.Text = myS.firstName;
                this.txtLname.Text = myS.lastName;
                //get Attendance information
                manageAttendence myA = new manageAttendence();
                myA.getAttendence(sessions.currTerm, myS.enrolmentId);
                this.txtAbsent.Text = myA.absentdays.ToString();
                this.txtPresent.Text = myA.presentdays.ToString();
                this.txtTotal.Text = myA.totaldays.ToString();
                this.page -= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in btnPrev_Click()" + ex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if(page < classTotal)
                {
                    this.lbCounter.Text = page.ToString() + "/" + classTotal.ToString(); 
                    manageStudent myS = new manageStudent();
                    string sql = "SELECT * FROM wizstudents WHERE classId = " + this.classId + " ORDER BY systemId ASC LIMIT 1 OFFSET " + this.page;
                    myS.getStudentByQuery(sql);
                    this.txtEnId.Text = myS.enrolmentId;
                    this.txtFname.Text = myS.firstName;
                    this.txtLname.Text = myS.lastName;
                    manageAttendence myA = new manageAttendence();
                    myA.getAttendence(sessions.currTerm, myS.enrolmentId);
                    this.txtAbsent.Text = myA.absentdays.ToString();
                    this.txtPresent.Text = myA.presentdays.ToString();
                    this.txtTotal.Text = myA.totaldays.ToString();
                    this.page += 1;
                }
                else
                {
                    MessageBox.Show("class total exceeded", "system notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in btnNext_Click()" + ex);
            }
        }

        private void lbCounter_Click(object sender, EventArgs e)
        {

        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            try
            {
                var student = this.txtEnId.Text;
                var attendDate = this.txtDate.Value.ToShortDateString();
                manageAttendence myA = new manageAttendence();
                manageattendsheet myAs = new manageattendsheet();
                myAs.checkEntered(student, attendDate);
                if (myAs.dacFound == false)
                {
                    myA.getAttendence(sessions.currTerm, student);
                    if (myA.addPresent(sessions.currTerm, student) == true)
                    {
                        if (myAs.setAttend(student, attendDate, this.classId, "P",sessions.currTerm) == true)
                        {
                            MessageBox.Show(this.txtFname.Text + " " + this.txtLname.Text + " marked present", "system info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtAbsent.Text = myA.absentdays.ToString();
                            this.txtPresent.Text = myA.presentdays.ToString();
                            this.txtTotal.Text = myA.totaldays.ToString();
                        }
                        else
                        {
                            MessageBox.Show("add atend failed");
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("this tudent has already been marked do you want to modifly", "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //get the attence enter
                            //update totals
                            //updade attendancee sheet
                        }
                    }
                }
                else
                {
                    MessageBox.Show("already marked");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnNext_Click()" + ex);
            }
        }
    }
}
