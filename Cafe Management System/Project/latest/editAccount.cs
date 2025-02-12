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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace latest
{
    public partial class editAccount : Form
    {
        int cart_id;
        public editAccount()
        {
            InitializeComponent();
        }
        public editAccount(int a)
        {
            InitializeComponent();
            cart_id = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //get user id
            int u_id=-1;
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "Select customer_id from cart where id = @c";
            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@c", cart_id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        u_id = reader.GetInt32(0);
                    }
                    reader.Close();
                }
            }

            //check if user has already added a credit card
            bool added = false;
            query = "select * from CreditCard where customer_id = @c";
            connection = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@c", u_id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Check if there are rows returned by the query
                    {
                        added = true;
                    }
                }
            }
            //
            if (!added)
            {
                Verification v = new Verification();
                v.Show();
                v.Storeinfo("addCreditCard");
            }
            else
            {
                MessageBox.Show("Couldn't proceed. You have already added a card once before!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verification v = new Verification(cart_id);
            v.Show();
            v.Storeinfo("changePass");
        }

        private void editAccount_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True");
            connectionString.Open();
            string query = "delete from purchasehistory where customer_id = (select customer_id from cart where id = @c)";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            string connectionStr = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlDataReader reader;
            SqlConnection connection;
            using (connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@c", cart_id);
                    using (reader = cmd.ExecuteReader())
                    {}
                }
            }
            MessageBox.Show("History deleted successfully!");
        }
    }
}
