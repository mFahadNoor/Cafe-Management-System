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
    public partial class Admin_Inventory : Form
    {
        public Admin_Inventory()
        {
            InitializeComponent();
            AddOrUpdateView();
            LoadData();
            
        }

        private void AddOrUpdateView()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = @"IF EXISTS(SELECT * FROM sys.views WHERE name = 'InventoryView')
                                DROP VIEW InventoryView;
                                GO

                                CREATE VIEW InventoryView
                                AS
                                SELECT 
                                    item.id AS ItemID, 
                                    item.name AS ItemName, 
                                    item.quantity AS Quantity, 
                                    item.price AS Price, 
                                    Category.description AS Category, 
                                    inventory.location AS Location, 
                                    userAdmin.name AS AdminName
                                FROM 
                                    item
                                JOIN 
                                    Category ON item.category_id = Category.id
                                JOIN 
                                    inventory ON item.inventory_id = inventory.id
                                JOIN 
                                    userAdmin ON inventory.admin_id = userAdmin.id;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("An error occurred while creating or updating the view: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = "SELECT * FROM InventoryView";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cellsMain.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading inventory data: " + ex.Message);
            }
        }

        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
