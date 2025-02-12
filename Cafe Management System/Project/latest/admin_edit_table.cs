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
    public partial class admin_edit_table : Form
    {
        public admin_edit_table()
        {
            InitializeComponent();
            categoryDrop.Items.Add("Available");
            categoryDrop.Items.Add("Unavailable");
            categoryDrop.SelectedIndex = 0; // Default value
        }

       

        private void admin_edit_table_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the Table ID and Capacity are provided
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Table ID and Capacity.");
                return;
            }

            // Parse Table ID and Capacity
            int tableId;
            if (!int.TryParse(textBox1.Text, out tableId))
            {
                MessageBox.Show("Invalid Table ID. Please enter a valid number.");
                return;
            }

            int capacity;
            if (!int.TryParse(textBox2.Text, out capacity))
            {
                MessageBox.Show("Invalid Capacity. Please enter a valid number.");
                return;
            }

            // Determine availability
            int availability = (categoryDrop.SelectedIndex == 0) ? 1 : 0;

            // Add the table to the database
            UpdateTable(tableId, capacity, availability);



        }





        private void UpdateTable(int tableId, int capacity, int availability)
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = "IF EXISTS(SELECT 1 FROM TableInfo WHERE id = @TableID) " +
                               "BEGIN " +
                               "   UPDATE TableInfo SET capacity = @Capacity, isAvailable = @Availability WHERE id = @TableID " +
                               "   SELECT 1 " +
                               "END " +
                               "ELSE " +
                               "BEGIN " +
                               "   SELECT 0 " +
                               "END";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TableID", tableId);
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@Availability", availability);
                    int tableExists = Convert.ToInt32(command.ExecuteScalar());

                    if (tableExists == 1)
                    {
                        MessageBox.Show("Table updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Table with provided ID does not exist. Please add a new table.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
