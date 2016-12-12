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
    public partial class frmManageStaff : MetroFramework.Forms.MetroForm
    {


        MySqlCommand query = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        private string empId;
        Bitmap bmp;

        public frmManageStaff()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           try
            {
                string sql = "SELECT employeeId,Fname,Sname,Dpt,Email FROM wizemployes";
                this.fillEmployee(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in Form1_Load() "+ex.Message );
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

        private void fillEmployee(string sql)
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
                this.dgvStaff.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            frmStaffDetails myS = new frmStaffDetails();
            myS.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var txt = this.txtSearch.Text;
                string sql = "SELECT employeeId,Fname,Sname,Dpt,Email FROM wizemployes WHERE Fname LIKE '%" + txt + "%' UNION (SELECT employeeId,Fname,Sname,Dpt,Email FROM wizemployes WHERE Sname LIKE '%" + txt + "%') ";
                this.fillEmployee(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in txtSearch_TextChanged() "+ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmStaffDetails myS = new frmStaffDetails();
                myS.empIdStr = this.empId;
                myS.isEdit = true;
                myS.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnUpdate_Click() " + ex.Message);
            }
        }

        private void dgvStaff_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.empId = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
                this.btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in  dgvStaff_DoubleClick() " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete employee ","Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    manageUsers myU = new manageUsers();
                    myU.getByEmpId(this.empId);
                    myU.deleteUser(myU.userId);
                    manageUserDetails myD = new manageUserDetails();
                    myD.deleteUser(myU.userId);
                    manageEmployees myE = new manageEmployees();
                   if(myE.deleteEmployee(this.empId) == true)
                    {
                        MessageBox.Show("Employee deleted from system system", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string sql = "SELECT employeeId,Fname,Sname,Dpt,Email FROM wizemployes";
                        this.fillEmployee(sql);
                    }
                    else
                    {
                        MessageBox.Show(" failed to deleted from system system", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnDelete_Click()"+ ex.Message);
            }
        }
    }
}
