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

        
    }
}
