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
                    //this.fillStudents("SELECT * FROM wizstudents WHERE classId =" + this.classId);

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

        public void fillStudents(string sql)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvStudents.DataSource = dt;
               // dt.Clear();
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
                if(page < 0 || page > classTotal)
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
                if (page < 0)
                {
                    page = 0;
                }
                if (page < classTotal)
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
                        MessageBox.Show("failed tp add present in sumation file");
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("this student has already been marked do you want to modifly", "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //get the attence enter
                        myAs.getAttend(student, attendDate);
                        //update totals
                       if(myAs.status == "P")
                        {
                            MessageBox.Show(this.txtFname.Text + " " + this.txtLname.Text + " already marked present", "system info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                       else
                        {
                            myA.getAttendence(sessions.currTerm, student);
                            myA.updateEntry(sessions.currTerm, student, "undo_Absent");
                            if(myAs.updateStatus(student,attendDate,"P") == true)
                            {
                                this.txtAbsent.Text = myA.absentdays.ToString();
                                this.txtPresent.Text = myA.presentdays.ToString();
                                this.txtTotal.Text = myA.totaldays.ToString();
                                MessageBox.Show(this.txtFname.Text + " " + this.txtLname.Text + " updated marked present", "system info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("failed to update", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //updade attendancee sheet
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnNext_Click()" + ex);
            }
        }

        private void btnAbsent_Click(object sender, EventArgs e)
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
                    if (myA.addAbsent(sessions.currTerm, student) == true)
                    {
                        if (myAs.setAttend(student, attendDate, this.classId, "A", sessions.currTerm) == true)
                        {
                            MessageBox.Show(this.txtFname.Text + " " + this.txtLname.Text + " marked absent", "system info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("failed tp add present in sumation file");
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("this student has already been marked do you want to modifly", "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //get the attence enter
                        myAs.getAttend(student, attendDate);
                        //update totals
                        if (myAs.status == "A")
                        {
                            MessageBox.Show(this.txtFname.Text + " " + this.txtLname.Text + " already marked Absent", "system info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            myAs.getAttend(student, attendDate);
                            myA.getAttendence(sessions.currTerm, student);
                            myA.updateEntry(sessions.currTerm, student, "undo_present");
                            if (myAs.updateStatus(student, attendDate, "A") == true)
                            {
                                this.txtAbsent.Text = myA.absentdays.ToString();
                                this.txtPresent.Text = myA.presentdays.ToString();

                                this.txtTotal.Text = myA.totaldays.ToString();
                                MessageBox.Show(this.txtFname.Text + " " + this.txtLname.Text + " updated marked absent", "system info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("failed to update", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //updade attendancee sheet
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnNext_Click()" + ex);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var condition = this.cmbCondition.Text;
                var attendDate = this.txtDate.Value.ToShortDateString();
                string sql;
                switch (condition)
                {
                    case "present":
                        sql = "SELECT * FROM wizstudents WHERE classId = '"+ this.classId + "' AND enrolmentId IN (SELECT enrolmentId FROM wizattendsheet WHERE entryData = '"+ attendDate +"'AND status = P ) ";
                        break;
                    case "absent":
                        sql = "SELECT * FROM wizstudents WHERE classId = '" + this.classId + "' AND enrolmentId IN (SELECT enrolmentId FROM wizattendsheet WHERE entryData = '" + attendDate + "'AND status = A ) ";
                        break;
                    default:
                        sql = "SELECT * FROM wizstudents WHERE classId =" + this.classId;
                    break;
                }
                //MessageBox.Show(condition);
                this.fillStudents(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnNext_Click()" + ex);
            }
        }

        private void dgvStudents_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               //var classId = dgvStudents.SelectedRows[0].Cells[3].Value.ToString();
                //MessageBox.Show(classId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in dgvStudents_SelectionChanged()" + ex);
            }
        }
    }
}
