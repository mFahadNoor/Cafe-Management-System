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

namespace latest
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox4.Text;
            string name= textBox3.Text;
            string confirmPassword = textBox2.Text;
            string message = "";

            // Check if any field is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(name))
            {
                message = "Please enter all fields.";
                 MessageBox.Show(message);
            }
        
            else if (password != confirmPassword)
            {
                message = "Password and confirm password must match.";
                MessageBox.Show(message);
            }
            else
            {
                //Check for same usernames
                List<string> usernames = new List<string>();
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = "select username, pass from userCustomer";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usernames.Add(reader.GetString(0));
                }
                for (int i = 0; i < usernames.Count; i++)
                {
                    if (usernames[i] == username)
                    {
                        MessageBox.Show("User Already Exists!");
                        return;
                    }
                }


                connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO userCustomer (name, username, pass) VALUES (@user, @username, @pass)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        using (SqlDataReader readr = cmd.ExecuteReader())
                        { }
                        MessageBox.Show("User created successfully!");
                    }
                    //get customer's id
                    query = "select id from userCustomer where username = @u";
                    int c_id;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", name);
                        using (SqlDataReader readr = cmd.ExecuteReader())
                        {
                            c_id = readr.GetInt32(0);
                        }
                    }
                    //assign a cart to customer
                    query = "INSERT INTO cart(customer_id, isPaid) VALUES (@c_id, 0)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_id", c_id);
                        using (SqlDataReader readr = cmd.ExecuteReader())
                        {}
                    }
                    /*
                    //get cart number
                    query = "select id from Cart where customer_id = @u and isPaid = 0";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader readr = cmd.ExecuteReader())
                        {
                            cmd.Parameters.AddWithValue("@u", name);
                            cart_id = readr.GetInt32(0);
                        }
                    }
                    */
                    login_button_Click(sender, e);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
