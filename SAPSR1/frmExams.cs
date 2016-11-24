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
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlConnection connection = new MySqlConnection(databaseUtilies.GetConnectionStrings());
        int examId;

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
                MessageBox.Show("application error " + ex);
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
                query.CommandText = "SELECT * FROM wizexams WHERE termId = '"+ sessions.currTerm + "' AND teacherId = '"+ sessions.userId +"' ORDER BY examId DESC";
                da.SelectCommand = query;
                dt.Clear();
                da.Fill(dt);
                this.dgvExams.DataSource = dt;
                // dt.Clear();
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
    }
}
