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
    public partial class Admin_add_category : Form
    {
        public Admin_add_category()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Category ID and Name.");
                return;
            }

            int categoryId;
            if (!int.TryParse(textBox1.Text, out categoryId))
            {
                MessageBox.Show("Invalid Category ID. Please enter a valid number.");
                return;
            }

            AddCategory(categoryId, textBox2.Text.Trim());
        }

        private void AddCategory(int categoryId, string categoryName)
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string checkQuery = "SELECT COUNT(*) FROM Category WHERE id = @CategoryID";
                string insertQuery = "INSERT INTO Category (id, description) VALUES (@CategoryID, @CategoryName)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    int existingCategories = (int)checkCommand.ExecuteScalar();

                    if (existingCategories > 0)
                    {
                        MessageBox.Show("Category with provided ID already exists. Please enter a different ID.");
                        return;
                    }

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    insertCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Category added successfully.");
                    textBox1.Clear(); 
                    textBox2.Clear(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void Admin_add_category_Load(object sender, EventArgs e)
        {

        }
    }
}
