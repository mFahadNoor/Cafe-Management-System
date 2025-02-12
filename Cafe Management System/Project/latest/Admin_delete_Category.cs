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
    public partial class Admin_delete_Category : Form
    {
        public Admin_delete_Category()
        {
            InitializeComponent();
        }

        private void Admin_delete_Category_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter Category ID.");
                return;
            }

            int categoryId;
            if (!int.TryParse(textBox1.Text, out categoryId))
            {
                MessageBox.Show("Invalid Category ID. Please enter a valid number.");
                return;
            }

            DeleteCategory(categoryId);
        }


        private void DeleteCategory(int categoryId)
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string checkQuery = "SELECT COUNT(*) FROM Category WHERE id = @CategoryID";
                string deleteQuery = "DELETE FROM Category WHERE id = @CategoryID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    int existingCategories = (int)checkCommand.ExecuteScalar();

                    if (existingCategories == 0)
                    {
                        MessageBox.Show("Category with provided ID does not exist.");
                        return;
                    }

                    // Check if the category has associated products
                    string productCheckQuery = "SELECT COUNT(*) FROM item WHERE category_id = @CategoryID";
                    SqlCommand productCheckCommand = new SqlCommand(productCheckQuery, connection);
                    productCheckCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    int associatedProducts = (int)productCheckCommand.ExecuteScalar();

                    if (associatedProducts > 0)
                    {
                        MessageBox.Show("Cannot delete category as it has associated products.");
                        return;
                    }

                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Category deleted successfully.");
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
