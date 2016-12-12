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
    public partial class frmManageUsers :  MetroFramework.Forms.MetroForm
    {

        MySqlCommand query = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        public int userId;
        Bitmap bmp;

        public frmManageUsers()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1_Load");
        }

        private void fillUsers(string sql)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                query.CommandText = sql;
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvUsers.DataSource = dt;
                //dt.Clear();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT wizuserdetails.userId,wizuserdetails.firstName,wizuserdetails.lastName,wizuserdetails.phoneNumber FROM wizuserdetails";
                this.fillUsers(sql); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in frmManageUsers_Load() " + ex.Message);
            }
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddUser frmAdd = new frmAddUser();
                frmAdd.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in BtnUser_Click() " + ex.Message);
            }
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
                this.btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in dgvUsers_DoubleClick() " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateUser frmU = new frmUpdateUser();
                frmU.userId = this.userId;
                frmU.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in dgvUsers_DoubleClick() " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var txt = this.txtSearch.Text;
                string sql = "SELECT userId,firstName,lastName,phoneNumber FROM wizuserdetails WHERE firstName LIKE '%" + txt + "%' UNION (SELECT userId,firstName,lastName,phoneNumber FROM wizuserdetails WHERE lastName LIKE '%" + txt + "%')";
                this.fillUsers(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in dgvUsers_DoubleClick() " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var txt = this.txtSearch.Text;
                string sql = "SELECT userId,firstName,lastName,phoneNumber FROM wizuserdetails WHERE firstName LIKE '%" + txt + "%' UNION (SELECT userId,firstName,lastName,phoneNumber FROM wizuserdetails WHERE lastName LIKE '%" + txt + "%')";
                this.fillUsers(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed in dgvUsers_DoubleClick() " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int height = this.dgvUsers.Height;
                int width = this.dgvUsers.Width;
                dgvUsers.Height = dgvUsers.RowCount * dgvUsers.RowTemplate.Height * 2;
                bmp = new Bitmap(width, dgvUsers.Height);
                dgvUsers.DrawToBitmap(bmp, new Rectangle(0, 0, width, dgvUsers.Height));
                dgvUsers.Height = height;
                //this.printPreviewUsers.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in btnPrint_Click() " + ex.Message);
            }
        }

        private void printDocumentUsers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("application error btnPrint_Click() " + ex);
            }

        }
    }
}
