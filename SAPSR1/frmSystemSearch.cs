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
    public partial class frmSystemSearch : MetroFramework.Forms.MetroForm
    {

        public string searchType;
        public string searchedId;
        MySqlCommand query = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());

        public frmSystemSearch()
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

        private void frmSystemSearch_Load(object sender, EventArgs e)
        {
            try
            {
                string sql;
                switch (this.searchType)
                {
                    case "students":
                        sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents ORDER BY systemId DESC ";
                    break;
                    case "employees":
                        sql = "SELECT employeeId,Fname,Sname,Dpt FROM wizemployes ORDER BY entryId DESC ";
                    break;
                    default:
                        sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents ORDER BY systemId DESC ";
                    break;
                }
                this.fillSearch(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed frmSystemSearch_Load()  " + ex);
            }
        }

        private void fillSearch(string sql)
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
                this.dgvSearchResults.DataSource = dt;
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

        private void dgvSearchResults_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.searchedId = Convert.ToString(dgvSearchResults.SelectedRows[0].Cells[0].Value);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error dgvStudents_CellDoubleClick() " + ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtSearch.Text;
                string sql = "";
                switch (this.searchType)
                {
                    case "students":
                        sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE lastName LIKE '%" + txt + "%' UNION (SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE firstName LIKE '%" + txt + "%') ";
                        break;

                    case "employees":
                        sql = "SELECT employeeId,Fname,Sname,Dpt FROM wizemployes WHERE Fname LIKE '%" + txt + "%' UNION (SELECT employeeId,Fname,Sname,Dpt FROM wizemployes WHERE Sname LIKE '%" + txt + "%')";
                        break;

                    default:
                        sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents ORDER BY systemId DESC ";
                        break;
                }
                this.fillSearch(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error txtSearch_TextChanged() " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtSearch.Text;
                string sql = "";
                switch (this.searchType)
                {
                    case "students":
                        sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE lastName LIKE '%" + txt + "%' UNION (SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE firstName LIKE '%" + txt + "%') ";
                    break;

                    case "employees":
                        sql = "SELECT employeeId,Fname,Sname,Dpt FROM wizemployes WHERE Fname LIKE '%" + txt + "%' UNION (SELECT employeeId,Fname,Sname,Dpt FROM wizemployes WHERE Sname LIKE '%" + txt + "%')";
                    break;

                    default:
                        sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents ORDER BY systemId DESC ";
                   break;
                }
                this.fillSearch(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error txtSearch_TextChanged() " + ex);
            }
        }
    }
}
