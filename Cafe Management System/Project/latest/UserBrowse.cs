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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace latest
{
    public partial class UserBrowse : Form
    {
        int cart_id;
        public UserBrowse()
        {
            InitializeComponent();
        }
        public UserBrowse(int a)
        {
            InitializeComponent();
            cart_id = a;    
        }
        private void UserBrowse_Load(object sender, EventArgs e)
        {
            LoadItems();

            // Load categories
            LoadCategories();

        }


        private void LoadItems()
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT * FROM item";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            itemGrid.DataSource = ds.Tables["item"].DefaultView;

            // Load Cart
            LoadCart();
        }
        private void LoadCategories()
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT description FROM category";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtCategories = new DataTable();
                adapter.Fill(dtCategories);

                comboBox1.Items.Clear();
                comboBox1.Items.Add("All");
                foreach (DataRow row in dtCategories.Rows)
                {
                    comboBox1.Items.Add(row["description"].ToString());
                }
            }
        }
        //comboBox1
        private void LoadCart()
        {
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "SELECT * FROM item_cart WHERE cart_id = @cartId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@cartId", cart_id);
                DataSet ds = new DataSet();
                da.Fill(ds, "item_cart");
                cartGrid.DataSource = ds.Tables["item_cart"].DefaultView;
            }
        }

        private void comboBox1_Filter(object sender, EventArgs e)
        {

            SqlConnection connectionString = new SqlConnection("Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True");

            //using join to filter items by category
            string query = "Select i.id, i.name, i.quantity, i.price from item i " +
                           "join category c on i.category_id = c.id " +
                           "where c.description = '" + comboBox1.Text + "';";
            if (comboBox1.Text == "" || comboBox1.Text == "All")
                query = "select * from item";
            
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            itemGrid.DataSource = ds.Tables["item"].DefaultView;

        }

        private void itemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quant;
            if (itemGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to add to the cart.");
                return;
            }

            string id = itemGrid.SelectedRows[0].Cells[0].Value.ToString();
            int availQuant;
            int.TryParse(itemGrid.SelectedRows[0].Cells[2].Value.ToString(), out availQuant);
            if (!int.TryParse(quantityBox.Text, out quant) || quantityBox.Text == "")
            {
                MessageBox.Show("Quantity must be a valid integer.");
                return;
            }
            else if (quant < 1)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }
            else if (quant > availQuant)
            {
                MessageBox.Show("Quantity must not be greater than available amount");
                return;
            }
            else
            {
                int selIndex = int.Parse(id);

                bool flg = false;
                //check if already added in cart
                foreach (DataGridViewRow row in cartGrid.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == id)
                    {
                        flg = true; //found item in cart
                        break;
                    }
                }
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                string query = " ";

                if (flg)
                {
                    //update
                    int currQuant = int.Parse(cartGrid.SelectedRows[0].Cells[1].Value.ToString());

                    if (quant + currQuant > availQuant)
                    {
                        MessageBox.Show("Quantity must not be greater than available amount");
                        return;
                    }

                    quant += currQuant;
                    query = "UPDATE item_cart " +
                            "SET quantity = " + quant +
                            " WHERE cart_id = " + cart_id + " AND item_id = " + selIndex;
                }
                else
                {
                    //add
                    query = "insert into item_cart(cart_id, item_id, quantity, item_name) " +
                            "values(" + cart_id + ", " + selIndex + ", " + quant + ", '" + itemGrid.SelectedRows[0].Cells[1].Value.ToString() + "');";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "item_cart");
                }

                // Reload the cart
                LoadCart();
            }
        }

        private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
