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
    public partial class Admin_Add_disount : Form
    {
        public Admin_Add_disount()
        {
            InitializeComponent();
            LoadCategories();
        }


        private void LoadCategories()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = "SELECT id, description FROM Category";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    categoryDrop.DisplayMember = "description";
                    categoryDrop.ValueMember = "id";
                    categoryDrop.DataSource = dataTable;

                    
                    categoryDrop.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading categories: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //duscount percentage
        }

        private void categoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //has all categories
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal discountPercentage;
            if (!decimal.TryParse(textBox1.Text, out discountPercentage))
            {
                MessageBox.Show("Please enter a valid discount percentage.");
                return;
            }

            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ApplyDiscount", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter categoryIdParameter = new SqlParameter("@CategoryId", SqlDbType.Int);
                    categoryIdParameter.Value = (categoryDrop.SelectedIndex == 0) ? (object)DBNull.Value : categoryDrop.SelectedValue;
                    command.Parameters.Add(categoryIdParameter);

                    SqlParameter discountParameter = new SqlParameter("@DiscountPercentage", SqlDbType.Decimal);
                    discountParameter.Value = discountPercentage;
                    command.Parameters.Add(discountParameter);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Discount applied successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying discount: " + ex.Message);
            }
        }
    }
}
