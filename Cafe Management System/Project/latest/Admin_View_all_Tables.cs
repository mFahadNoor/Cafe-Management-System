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
    public partial class Admin_View_all_Tables : Form
    {
        public Admin_View_all_Tables()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT id AS TableID, capacity AS Capacity, " +
                           "CASE WHEN isAvailable = 1 THEN 'Available' ELSE 'Not Available' END AS Availability " +
                           "FROM TableInfo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cellsMain.DataSource = dataTable;
            }
        }
        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
