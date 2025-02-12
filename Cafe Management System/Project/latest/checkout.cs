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
    public partial class checkout : Form
    {
        int cart_id;
        UserHome uh;
        bool isGuest;
        public checkout()
        {
            InitializeComponent();
        }
        public checkout(int a, UserHome u, bool isGuest)
        {
            InitializeComponent();
            cart_id = a;
            uh = u;
            this.isGuest = isGuest;
            if (isGuest)
            {
                radioButton1.Visible = false;
            }
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'cart_items.item_cart' table. You can move, or remove it, as needed.
            this.item_cartTableAdapter.Fill(this.cart_items.item_cart);
            // TODO: This line of code loads data into the 'cafeSystemDataSet1.cart' table. You can move, or remove it, as needed.
            //this.cartTableAdapter.Fill(this.cafeSystemDataSet1.cart);

            //SqlConnection connectionStr = new SqlConnection("Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True");
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT * FROM item_cart WHERE cart_id = @c";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@c", cart_id);
                DataSet ds = new DataSet();
                da.Fill(ds, "item_cart");
                //dataGridView1.DataSource = ds.Tables["item_cart"];
                dataGridView1.DataSource = ds.Tables["item_cart"].DefaultView;

            }


            //get total price
            decimal total = 0;
            int id, quant;
            decimal price;

            connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            query = "select price from item where id = @id";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        quant = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            price = reader.GetDecimal(0);
                            total += price * quant;
                        }
                    }
                }
            }
            label3.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("Empty Cart!");
                return;
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please choose a payment method");
                return;
            }
            else if (radioButton1.Checked)
            {
                decimal d = decimal.Parse(label3.Text.ToString());
                payment p = new payment(d, cart_id, this, uh);
                p.Show();
            }
            else
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query;
                SqlConnection connection;
                SqlCommand command;
                SqlDataReader reader;

                // Set quantity of items in inventory
                List<int> cartQ = new List<int>(); // Quantity in cart table
                List<int> cartQid = new List<int>(); // ID of item in cart
                connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                query = "select item_id, quantity from item_cart where cart_id = @c";
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(query, connection);
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@c", cart_id);
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cartQid.Add(reader.GetInt32(0));
                                cartQ.Add(reader.GetInt32(1));
                            }
                        }
                    }
                }
                query = "update item set quantity = quantity - @q where id = @i";
                for (int i = 0; i < cartQ.Count; i++)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@q", cartQ[i]);
                            command.Parameters.AddWithValue("@i", cartQid[i]);
                            reader = command.ExecuteReader();
                        }
                    }
                }

                // Cart is paid
                query = "UPDATE cart SET isPaid = 1 WHERE id = @i";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@i", cart_id);
                        reader = command.ExecuteReader();
                    }
                }

                reader.Close();
                // Get customer's id
                query = "SELECT customer_id FROM Cart WHERE id = @u";
                int c_id = -1; // Default value if no customer_id is found
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@u", cart_id);
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there are rows returned by the query
                            {
                                c_id = reader.GetInt32(0); // Retrieve the customer_id if a row is found
                            }
                            else
                            {
                                // Handle the case where no data is present
                                MessageBox.Show("No customer ID found for cart ID: " + cart_id);
                            }
                        }
                    }
                }
                // Set purchase history
                Random rnd = new Random();
                query = "insert into purchaseHistory(item_cart_id, customer_id, table_id) values((select id from item_cart where cart_id = @cart), @cust, @tabl)";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cart", cart_id);
                        cmd.Parameters.AddWithValue("@cust", c_id);
                        cmd.Parameters.AddWithValue("@tabl", rnd.Next(1, 8));
                        using (reader = cmd.ExecuteReader())
                        { }
                    }
                }
                // Assign a cart to customer
                query = "INSERT INTO cart(customer_id, isPaid) VALUES (@c_id, 0); SELECT SCOPE_IDENTITY()";
                int newCartId = -1;
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@c_id", c_id);
                        newCartId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                // Send back the id of the new cart to UserHome
                MessageBox.Show("Order placed successfully!");
                uh.setCartId(newCartId);
            }
            // Send new cart id to UserHome
            this.Close();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void back(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
