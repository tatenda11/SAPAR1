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
                this.dgvClasses.DataSource = dt;
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
                    MessageBox.Show("application error fillTeacher ");
                }
                else
                {
                    manageClassrooms myC = new manageClassrooms();
                    myC.getClass(this.classId);
                    myC.className = className;
                    myC.teacherId = Convert.ToInt32(teacher);
                    myC.classGrade = Convert.ToInt32(grade);
                    myC.classDetails = des;
                    bool set = myC.updateClass(this.classId);
                    if(set == true)
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
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("application error fillTeacher()  " + ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var className = this.txtClassName.Text;
                var teacher = this.cmbTeacher.Text;
                var grade = this.cmbClassGrade.Text;
                var des = this.txtClassDes.Text;
                if (className == "" || teacher == "" || grade == "")
                {
                    MessageBox.Show("application error fillTeacher ");
                }
                else
                {
                    manageClassrooms myC = new manageClassrooms();
                    if(myC.setClass(className,grade, Convert.ToInt32(teacher),des) == true)
                    {
                        MessageBox.Show("Updated Class Successfully", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fillClass();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add class", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvClasses.SelectedRows[0].Cells[1].Value.ToString());
        }
    }
}
