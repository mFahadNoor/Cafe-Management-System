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
    public partial class admin_search_table : Form
    {
        public admin_search_table()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string tableId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(tableId))
            {
                MessageBox.Show("Please enter a Table ID.");
                return;
            }

            int id;
            if (!int.TryParse(tableId, out id))
            {
                MessageBox.Show("Invalid Table ID. Please enter a valid number.");
                return;
            }

            LoadData(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadData(int tableId)
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT id AS TableID, capacity AS Capacity, " +
                           "CASE WHEN isAvailable = 1 THEN 'Available' ELSE 'Not Available' END AS Availability " +
                           "FROM TableInfo " +
                           "WHERE id = @TableID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TableID", tableId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    cellsMain.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Table with ID " + tableId + " not found.");
                }
            }
        }
        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void admin_search_table_Load(object sender, EventArgs e)
        {

        }
    }
}
