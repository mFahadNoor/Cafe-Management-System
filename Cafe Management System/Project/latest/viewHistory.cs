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
    public partial class viewHistory : Form
    {
        int cart_id;
        int cust_id;
        public viewHistory()
        {
            InitializeComponent();
        }
        public viewHistory(int c)
        {
            InitializeComponent();
            cart_id = c;

            string query = "SELECT customer_id FROM Cart WHERE id = @u";
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection connection;
            SqlDataReader reader;
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
            cust_id = c_id;

        }

        private void viewHistory_Load(object sender, EventArgs e)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
            connectionString.Open();
            string query = "select ph.customer_id, ic.cart_id, i.name, ic.quantity from purchaseHistory ph " +
                            "join item_cart ic on ic.cart_id = (select cart_id from item_cart where item_cart.id = ph.item_cart_id) " +
                            "join item i on i.id = ic.item_id " +
                            "where ph.customer_id = @c";
            //MessageBox.Show();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@c", cust_id);
                ds = new DataSet();
                da.Fill(ds, "purchase_history");
                //dataGridView1.DataSource = ds.Tables["item_cart"];
                dataGridView1.DataSource = ds.Tables["purchase_history"].DefaultView;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
