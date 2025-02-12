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
    public partial class admin_search_item : Form
    {
        public admin_search_item()
        {
            InitializeComponent();
        }

        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {

            string keyword = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            LoadData(keyword);
        }

        private void LoadData(string keyword)
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT i.name AS ItemName, i.quantity AS Quantity, i.price AS Price, " +
                           "c.description AS Category " +
                           "FROM item i " +
                           "INNER JOIN Category c ON i.category_id = c.id " +
                           "WHERE i.name LIKE @Keyword OR c.description LIKE @Keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    cellsMain.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No items found matching the keyword: " + keyword);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_search_item_Load(object sender, EventArgs e)
        {

        }
    }
}
