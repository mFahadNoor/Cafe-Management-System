using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latest
{
    public partial class Admin_View_all_items : Form
    {
        public Admin_View_all_items()
        {
            InitializeComponent();
            LoadData();
        }

        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_View_all_tables_Load(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ItemView";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cellsMain.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
    }
}
