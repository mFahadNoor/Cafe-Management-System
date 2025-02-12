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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace latest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string message;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                message = "Please Enter both Username and Password";
                MessageBox.Show(message);
                textBox1.Clear();
                textBox2.Clear();
                return;
                
            }
            else if (!Customer.Checked && !radioButton1.Checked)
            {
                message = "Please select user type";
                MessageBox.Show(message);
                textBox1.Clear();
                textBox2.Clear();
                return;
                
            }
          
            else
            {
                //verify details
                string user = textBox1.Text;
                string pass = textBox2.Text;

                List<string> usernames = new List<string>();
                List<string> passwords = new List<string>();
                List<int> admins = new List<int>();
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query;
                if (Customer.Checked)
                {
                    query = "select username, pass from userCustomer";
                }
                else
                {
                    query = "select username, pass from userAdmin";
                }
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usernames.Add(reader.GetString(0));
                    passwords.Add(reader.GetString(1));
                }
                bool verified = false;
                for (int i = 0; i < usernames.Count; i++)
                {
                    if (usernames[i] == user && passwords[i] == pass)
                    {
                        verified = true;
                        break;
                    }
                }

                //login if correct
                textBox1.Clear();
                textBox2.Clear();
                if (!verified)
                {
                    MessageBox.Show("Invalid Credentials!");
                    return;
                }
                if (!Customer.Checked)
                {
                    Admin_mainpage admin_Mainpage = new Admin_mainpage(username);   
                      admin_Mainpage.Show();
                }
                else
                {
                    reader.Close();
                    //get customer's id
                    query = "select id from userCustomer where username = @u";
                    int c_id=-1;
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@u", user);
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there are rows returned by the query
                            {
                                c_id = reader.GetInt32(0); 
                            }
                        }
                    }
                    //get cart id
                    int cart_id=-1;
                    query = "select id from Cart where customer_id = @u and isPaid = 0";
                    reader.Close();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@u", c_id);
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there are rows returned by the query
                            {
                                cart_id = reader.GetInt32(0);
                            }
                        }
                    }
                    UserHome u = new UserHome();
                    u.updateUser(user, cart_id);
                    u.Show();
                }
            }
        }







        private void Customer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {

            
            signup signupPage = new signup();

            // Show the signup page
           signupPage.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            string query;
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader readr;
            connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            query = "INSERT INTO userGuest(name) VALUES ('GUEST')";
            conn = new SqlConnection(connectionString);
            conn.Open();
            using (cmd = new SqlCommand(query, conn))
            {
                using (readr = cmd.ExecuteReader())
                { }
                //guest created
            }
            conn.Close();
            readr.Close();
            //get guest's id



            query = "select top 1 id from userGuest order by id desc";
            int g_id=-1;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            readr = cmd.ExecuteReader();

            if (readr.HasRows)
            {
                readr.Read();
                g_id = readr.GetInt32(0); // Assuming 'id' is an integer
            }
            else
            {
                Console.WriteLine("No data found in userGuest table.");
            }
            //make a cart for guest
            query = "INSERT INTO cart(Guest_id, isPaid) VALUES (@g_id, 0)";
            cmd = new SqlCommand(query, conn);
            readr.Close();
            cmd.Parameters.AddWithValue("@g_id", g_id);
            readr = cmd.ExecuteReader();
            //get cart id
            int cart_id=-1;
            query = "select id from cart where isPaid = 0 and guest_id = @g_id";
            cmd = new SqlCommand(query, conn);
            readr.Close();
            cmd.Parameters.AddWithValue("@g_id", g_id);
            readr = cmd.ExecuteReader();

            if (readr.HasRows)
            {
                readr.Read();
                cart_id = readr.GetInt32(0); // Assuming 'id' is an integer
            }
            else
            {
                Console.WriteLine("No data found in userGuest table.");
            }
            MessageBox.Show(cart_id + "");
            UserHome u = new UserHome(true);
            u.updateUser("GUEST", cart_id);
            u.Show();
        }
    }
}
