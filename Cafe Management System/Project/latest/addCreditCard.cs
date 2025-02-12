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
    public partial class addCreditCard : Form
    {
        int c_id;//customer ID
        Verification ver;
        public addCreditCard()
        {
            InitializeComponent();
        }

        public addCreditCard(int id, Verification v)
        {
            InitializeComponent();
            this.c_id = id;
            this.ver = v;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string exp = textBox1.Text;
            int pin = int.Parse(textBox2.Text);
            int num = int.Parse(textBox3.Text);

            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";

            string query = "INSERT INTO CreditCard (customer_id, pin, number, expiry) VALUES (@customer_id, @pin, @num, @expiry)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_id", c_id);
                    command.Parameters.AddWithValue("@pin", pin);
                    command.Parameters.AddWithValue("@num", num);
                    command.Parameters.AddWithValue("@expiry", exp);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Credit card added successfully!");
                        this.Close();
                        ver.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add credit card!");
                    }
                }
            }
        }

        private void addCreditCard_Load(object sender, EventArgs e)
        {

        }
    }
}
