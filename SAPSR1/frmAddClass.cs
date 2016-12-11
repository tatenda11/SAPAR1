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
using System.Configuration;


namespace SAPSR1
{

    public partial class frmAddClass : MetroFramework.Forms.MetroForm
    {
        public int teacherId;
        public int classId;
        public Boolean swapTeacher;
        public Boolean startIntract;
        MySqlCommand query = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());

        public frmAddClass()
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

        private void frmAddClass_Load(object sender, EventArgs e)
        {
            try
            {
                this.fillTeacher();
                this.fillClass();
                this.startIntract = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("application error  " + ex);
            }
        }

        private void fillTeacher()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT firstName ,lastName, userId FROM wizuserdetails WHERE userId IN (SELECT userId FROM wizuser WHERE userType = 'T')";
                MySqlDataReader myReader = query.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Columns.Add("firstName", typeof(string));
                 dt.Columns.Add("lastName", typeof(string));
                 dt.Columns.Add("userId", typeof(int));
                 dt.Load(myReader);
                 cmbTeacher.ValueMember = "userId";
                 cmbTeacher.DisplayMember = "lastName";
                 cmbTeacher.DataSource = dt;
                 connection.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("application error fillTeacher()  " + ex);
            }
        }

        public void fillClass()
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM wizclassrooms";
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvClassInfo.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("application error fillTeacher()  " + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var className = this.txtClassName.Text;
                var teacher = this.cmbTeacher.Text;
                var grade = this.cmbClassGrade.Text;
                var des = this.txtClassDes.Text;
                if(className == "" || teacher == "" || grade == "")
                {
                    MessageBox.Show("class name, teacher and grade required ");
                }
                else
                {
                    manageClassrooms myC = new manageClassrooms();
                    myC.getClass(this.classId);
                    myC.className = className;
                    myC.teacherId = Convert.ToInt32(cmbTeacher.SelectedValue);
                    myC.classGrade = Convert.ToInt32(grade);
                    myC.classDetails = des;
                    if (teacherId != Convert.ToInt32(cmbTeacher.SelectedValue))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the class teacher", "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if(swapTeacher == false)
                            {
                                DialogResult dialogResult2 = MessageBox.Show("this teacher was already assigned to a class if you update you the class will remail without a teacher", "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult2 == DialogResult.Yes)
                                {
                                    bool set = myC.updateClass(this.classId);
                                    if (set == true)
                                    {
                                        MessageBox.Show("Updated Class Successfully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.fillClass();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update class", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                bool set = myC.updateClass(this.classId);
                                if (set == true)
                                {
                                    MessageBox.Show("Updated Class Successfully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.fillClass();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update class", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this.classId.ToString());
                        bool set = myC.updateClass(this.classId);
                        if (set == true)
                        {
                            MessageBox.Show("Updated Class Successfully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.fillClass();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update class", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }                  
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("application error fillTeacher()  " + ex);
            }
            finally
            {
                this.txtClassName.Enabled = true;
                this.cmbClassGrade.Enabled = true;
                this.txtClassName.Text = "";
                this.txtClassDes.Text = "";
                this.btnAdd.Enabled = true;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var className = this.txtClassName.Text;
                //var teacher = this.cmbTeacher.ValueMember;
                var teacher = Convert.ToInt32(cmbTeacher.SelectedValue);
                var grade = this.cmbClassGrade.Text;
                var des = this.txtClassDes.Text;
                if (className == ""  || grade == "")
                {
                    MessageBox.Show("class name requied and grade is required ");
                }
                else
                {
                    manageClassrooms myC = new manageClassrooms();
                    if(myC.setClass(className,grade, Convert.ToInt32(teacher),des) == true)
                    {
                        MessageBox.Show("Added Class Successfully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.refresh();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add class"+ ex, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvClassInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed on dgvClassInfo_CellContentClick()" + ex, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void doNothing(object sender, EventArgs e)
        {
            this.fillTeacher();
            this.fillClass();
        }

        private void dgvClassInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.startIntract == true && this.dgvClassInfo.SelectedRows.Count > 0)
                {
                    this.swapTeacher = false;
                    this.txtClassName.Enabled = false;
                    this.cmbClassGrade.Enabled = false;
                    this.btnAdd.Enabled = false;
                    this.btnUpdate.Enabled = true;
                    var classId = dgvClassInfo.SelectedRows[0].Cells[0].Value.ToString();
                    manageClassrooms myC = new manageClassrooms();
                    myC.getClass(Convert.ToInt32(classId));
                    this.txtClassDes.Text = myC.classDetails;
                    this.txtClassName.Text = myC.className;
                    this.cmbClassGrade.Text = myC.classGrade.ToString();
                    manageUserDetails myU = new manageUserDetails();
                    myU.getUserDetails(myC.teacherId);
                    cmbTeacher.Text = myU.lastName;
                    cmbTeacher.SelectedValue = myC.teacherId;
                    this.classId = myC.classRoomId;
                    this.teacherId = myC.teacherId; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed on  dgvClassInfo_SelectionChange" + ex, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAddClass_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void frmAddClass_Click(object sender, EventArgs e)
        {
    
        }

        private void frmAddClass_Shown(object sender, EventArgs e)
        {
            this.startIntract = true;
        }

        private void txtClassName_Leave(object sender, EventArgs e)
        {
            var className = this.txtClassName.Text;
            if(validator.isValidAlphaNumeric(className) == false)
            {
                MessageBox.Show(validator.errorMsg , "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClassName.Focus();
            }
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {

        }

        private void cmbTeacher_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbTeacher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(startIntract == true)
                {
                    int teacherId = Convert.ToInt32(this.cmbTeacher.SelectedValue);
                    manageClassrooms myC = new manageClassrooms();
                    myC.getClassByTeacher(teacherId);
                    if (myC.dacFound == true)
                    {
                        this.swapTeacher = true;
                        MessageBox.Show(this.cmbTeacher.Text + "is already assigned to " + myC.className, "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.swapTeacher = false;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in cmbTeacher_Leave() " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void refresh()
        {
            this.txtClassDes.Text = "";
            this.txtClassName.Text = "";
            this.txtClassName.Enabled = true;
            this.cmbClassGrade.Enabled = true;
            this.cmbTeacher.Text = "";
            this.cmbClassGrade.Text = "";
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.fillClass();
        }
    }
}
