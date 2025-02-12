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
    public partial class Admin_All_PurchaseHistory : Form
    {
        public Admin_All_PurchaseHistory()
        {
            InitializeComponent();
            create_or_updateView();
            LoadData();
        }

        private void create_or_updateView()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        IF OBJECT_ID('PurchaseHistoryView', 'V') IS NOT NULL
                        BEGIN
                            DROP VIEW PurchaseHistoryView;
                        END

                        CREATE VIEW PurchaseHistoryView
                        AS
                        SELECT 
                            ph.id AS PurchaseID, 
                            u.name AS CustomerName, 
                            ic.item_name AS ItemName, 
                            ic.quantity AS Quantity, 
                            i.price AS Price, 
                            c.description AS Category
                        FROM 
                            purchaseHistory ph
                        FULL JOIN 
                            item_cart ic ON ph.item_cart_id = ic.id
                        FULL JOIN 
                            item i ON ic.item_id = i.id
                        FULL JOIN 
                            Category c ON i.category_id = c.id
                        FULL JOIN
                            userCustomer u ON ph.customer_id = u.id;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("An error occurred while creating or updating the view: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PurchaseHistoryView";
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
        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
