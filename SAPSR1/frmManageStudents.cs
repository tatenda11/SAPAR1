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
    public partial class frmManagestudentsMain : MetroFramework.Forms.MetroForm
    {

        MySqlCommand query = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        private int enId;
        Bitmap bmp;

        public frmManagestudentsMain()
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

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           try
            {
                string sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents ORDER BY systemId DESC ";
                this.fillStudents(sql);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("failed in manage students form load " + ex);
            }
        }

        private void fillStudents(string sql)
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
                MessageBox.Show("application error " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

   
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
           try
            {
                var txt = this.txtSearch.Text;
                string sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE lastName LIKE '%"+ txt + "%' UNION (SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE firstName LIKE '%" + txt + "%') ";
                this.fillStudents(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentDetails mysfrm = new frmStudentDetails();
                mysfrm.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentDetails mysfrm = new frmStudentDetails();
                mysfrm.update = true;
                mysfrm.enrollmentId = this.enId;
                mysfrm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error " + ex);
            }
        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.enId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
                this.btnUpdate.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error dgvStudents_CellDoubleClick() " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                manageStudent mys = new manageStudent();
                managestudentdetails mysd = new managestudentdetails();
                mys.getStudentId(this.enId);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + mys.firstName+ " " + mys.lastName , "Confirm Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (mysd.deleteStudent(this.enId.ToString()) == true)
                    {
                        if (mys.deleteStudent(this.enId) == true)
                        {
                            MessageBox.Show("student deleted success", "input error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents ORDER BY systemId DESC ";
                            this.fillStudents(sql);
                        }
                        else
                        {
                            MessageBox.Show("failed to delete student", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }      
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error dgvStudents_CellDoubleClick() " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var txt = this.txtSearch.Text;
                string sql = "SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE lastName LIKE '%" + txt + "%' UNION (SELECT enrolmentId,firstName,lastName,gender FROM wizstudents WHERE firstName LIKE '%" + txt + "%') ";
                this.fillStudents(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("application error dgvStudents_CellDoubleClick() " + ex);
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
                int height = this.dgvStudents.Height;
                int width = this.dgvStudents.Width;
                dgvStudents.Height = dgvStudents.RowCount * dgvStudents.RowTemplate.Height * 2;
                bmp = new Bitmap(width, dgvStudents.Height);
                dgvStudents.DrawToBitmap(bmp, new Rectangle(0, 0, width, dgvStudents.Height));
                dgvStudents.Height = height;
                this.printPreviewStudents.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("application error btnPrint_Click() " + ex);
            }
        }

        private void prtDocumentStudent_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
