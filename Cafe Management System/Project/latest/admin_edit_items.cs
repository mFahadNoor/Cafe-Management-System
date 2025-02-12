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
    public partial class admin_edit_items : Form
    {
        public admin_edit_items()
        {
            InitializeComponent();
            LoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
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
            string query = "update item set name = @name, quantity = @quantity, price = @price where id = @id";
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
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Edited successfully!");

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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
            /*
            query = "Select * from cart";
            da = new SqlDataAdapter(query, connectionString);
            ds = new DataSet();
            da.Fill(ds, "cart");
            cellsCart.DataSource = ds.Tables["cart"].DefaultView;
            */
        }

        private void admin_edit_items_Load(object sender, EventArgs e)
        {

        }
    }
}
