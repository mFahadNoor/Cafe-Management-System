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
    public partial class Admin_Add_Items : Form
    {
        public Admin_Add_Items()
        {
            InitializeComponent();
            PopulateCategoriesDropDown();
            LoadData();


        }

        private void PopulateCategoriesDropDown()
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "select description from Category";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dtCategories = new DataTable();
            connection.Open();
            adapter.Fill(dtCategories);

            // Clear existing items in dropdown, if any
            categoryDrop.Items.Clear();

            // Add categories to dropdown
            foreach (DataRow row in dtCategories.Rows)
            {
                categoryDrop.Items.Add(row["description"].ToString());
            }
        }

        private void LoadData()
        {
            SqlConnection connectionString = new SqlConnection("Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True");
            connectionString.Open();
            string query = "Select * from item";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            cellsMain.DataSource = ds.Tables["item"].DefaultView;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("ID must be a valid integer.");
                return;
            }

            string name = textBox2.Text;

            int quantity;
            if (!int.TryParse(textBox3.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative integer.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(textBox4.Text, out price) || price < 0)
            {
                MessageBox.Show("Price must be a non-negative decimal.");
                return;
            }

            int category = categoryDrop.SelectedIndex + 1; // Get selected category ID

            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SET IDENTITY_INSERT item ON; INSERT INTO item (id, name, quantity, price, category_id, inventory_id) VALUES (@id, @name, @quantity, @price, @category, 1); SET IDENTITY_INSERT item OFF;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category);

                try
                {
                    conn.Open();
                    string checkIdQuery = "SELECT COUNT(*) FROM item WHERE id = @id";
                    SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, conn);
                    checkIdCmd.Parameters.AddWithValue("@id", id);
                    int existingIdCount = Convert.ToInt32(checkIdCmd.ExecuteScalar());
                    if (existingIdCount > 0)
                    {
                        MessageBox.Show("ID already exists. Please enter a different ID.");
                        return;
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully!");

                    LoadData();

                    // Refresh the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Admin_Add_Items_Load(object sender, EventArgs e)
        {

        }
    }
}
