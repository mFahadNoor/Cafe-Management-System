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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace latest
{
    public partial class payment : Form
    {
        decimal total;
        int cart_id;
        checkout co;
        UserHome uh;
        public payment()
        {
            InitializeComponent();
        }
        public payment(decimal d, int a, checkout co, UserHome uh)
        {
            InitializeComponent();
            total = d;
            cart_id = a;
            this.co = co;
            this.uh = uh;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1 == null || textBox1.Text == "")
            {
                MessageBox.Show("Please enter pin");
                return;
            }
            int pin = int.Parse(textBox1.Text);
            List<int> pins = new List<int>();
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "select pin from CreditCard";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pins.Add(reader.GetInt32(0));
            }
            bool verified = false;
            for (int i = 0; i < pins.Count; i++)
            {
                if (pins[i] == pin)
                {
                    verified = true;
                    break;
                }
            }

            //login if correct
            textBox1.Clear();
            if (!verified)
            {
                MessageBox.Show("Invalid Credentials!");
            }
            else
            {
                //set quantity of items in inventory
                List<int> cartQ = new List<int>();//quantity in cart table
                List<int> cartQid = new List<int>();//id of item in cart
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

                //cart is paid
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
                //get customer's id
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
                //set purchase history
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
                //assign a cart to customer
                query = "INSERT INTO cart(customer_id, isPaid) VALUES (@c_id, 0)";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@c_id", c_id);
                        using (SqlDataReader readr = cmd.ExecuteReader())
                        { }
                    }
                }
                //get the id of new cart
                query = "select id from cart where customer_id = @c_id and isPaid = 0";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@c_id", c_id);
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there are rows returned by the query
                            {
                                cart_id = reader.GetInt32(0); // Retrieve the customer_id if a row is found
                            }
                            else
                            {
                                // Handle the case where no data is present
                                MessageBox.Show("No customer ID found for cart ID: " + cart_id);
                            }
                        }
                    }
                }
                //send back the id of new cart to userhome
                MessageBox.Show("Order placed successfully!");
                uh.setCartId(cart_id);
                co.Close();
                this.Close();
            }
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
