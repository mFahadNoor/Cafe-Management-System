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
    public partial class Admin_view_allcategories : Form
    {
        public Admin_view_allcategories()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void Admin_view_allcategories_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT c.description AS Category, i.name AS Product " +
                           "FROM Category c " +
                           "LEFT JOIN item i ON c.id = i.category_id " +
                           "ORDER BY c.description, i.name";
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