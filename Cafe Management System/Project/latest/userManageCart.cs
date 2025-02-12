using System;
using System.Collections;
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
    public partial class userManageCart : Form
    {
        DataGridView itemGrid;
        int cart_id;
        public userManageCart()
        {
            InitializeComponent();
        }
        public userManageCart(int a)
        {
            InitializeComponent();
            cart_id = a;
        }

        private void UserBrowse_Load(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True");
            connectionString.Open();
            string query = "Select * from item";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();

            //Item Grid
            itemGrid = new DataGridView();
            da.Fill(ds, "item");
            itemGrid.DataSource = ds.Tables["item"].DefaultView;

            //itemCart Grid
            query = "SELECT * FROM item_cart WHERE cart_id = @c";
            string connectionStr = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@c", cart_id);
                ds = new DataSet();
                da.Fill(ds, "item_cart");
                //dataGridView1.DataSource = ds.Tables["item_cart"];
                cartGrid.DataSource = ds.Tables["item_cart"].DefaultView;

            }

        }

        private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int setQ;
            string setQStr = textBox1.Text;
            int.TryParse(setQStr, out setQ);
            string query = "SELECT quantity FROM item WHERE id = @Id";
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            if (textBox1.Text == "" || setQ < 1)
            {
                MessageBox.Show("Value of Quantity must be an Integer and greater than 0");
                return;
            }
            else
            {
                int selIndex;
                string selIndexStr = cartGrid.SelectedRows[0].Cells[2].Value.ToString();
                int.TryParse((string)selIndexStr, out selIndex);

                int availableQuantity;
                // Create and open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", selIndex);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                availableQuantity = reader.GetInt32(0);
                            }
                            else
                            {
                                availableQuantity = -1; // or some other value indicating no result
                            }
                        }
                    }
                }
                //MessageBox.Show(availableQuantity + " " + selIndex);
                //return;
                if (setQ > availableQuantity)
                {
                    MessageBox.Show("Quantity must not be greater than available amount \nAvailable Amount = " + availableQuantity);
                    return;
                }
                query = "UPDATE item_cart " +
                        "SET quantity = " + setQ +
                        " WHERE cart_id = " + cart_id + " AND item_id = " + selIndex;
            }
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "item_cart");
            //cartGrid.DataSource = ds.Tables["cart"].DefaultView;
            UserBrowse_Load(sender, e);
        }

        private void itemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userManageCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeSystemDataSet2.Cart' table. You can move, or remove it, as needed.
            //this.cartTableAdapter.Fill(this.cafeSystemDataSet2.Cart);
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string query = "SELECT * FROM item_cart WHERE cart_id = @c";
            string connectionStr = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@c", cart_id);
                ds = new DataSet();
                da.Fill(ds, "item_cart");
                //dataGridView1.DataSource = ds.Tables["item_cart"];
                cartGrid.DataSource = ds.Tables["item_cart"].DefaultView;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int item, cust;
            string selIndexStr = cartGrid.SelectedRows[0].Cells[2].Value.ToString();
            int.TryParse((string)selIndexStr, out item);

            string query = "DELETE FROM item_cart WHERE cart_id = @crt AND item_id = @item";
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@crt", cart_id);
                    command.Parameters.AddWithValue("@item", item);
                    using (SqlDataReader reader = command.ExecuteReader())
                    { }
                }
            }


            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "cart");
            //cartGrid.DataSource = ds.Tables["cart"].DefaultView;
            UserBrowse_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
