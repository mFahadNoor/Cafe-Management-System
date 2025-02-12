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
    public partial class Admin_change__pass : Form
    {
        public Admin_change__pass()
        {
            InitializeComponent();
        }

        private void Admin_change__pass_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //old pass
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //new passs
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //confirm new pass
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string oldPass = textBox2.Text;
            string newPass = textBox3.Text;
            string confirmPass = textBox4.Text;

            if (newPass != confirmPass)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "UPDATE userAdmin SET pass = @newPass WHERE username = @username AND pass = @oldPass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newPass", newPass);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@oldPass", oldPass);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password changed successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or old password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
    }
}
