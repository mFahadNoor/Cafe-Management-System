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
    public partial class Admin_Delete_Table : Form
    {
        public Admin_Delete_Table()
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
        

        private void DeleteTable(int tableId)
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = "DELETE FROM TableInfo WHERE id = @TableID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TableID", tableId);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Table deleted successfully.");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        

        private void Admin_Delete_Table_Load(object sender, EventArgs e)
        {

        }

        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delButton_Click_1(object sender, EventArgs e)
        {
            if (cellsMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a table to delete.");
                return;
            }
            int tableId = Convert.ToInt32(cellsMain.SelectedRows[0].Cells["TableID"].Value);
            DeleteTable(tableId);

        }
    }
}
