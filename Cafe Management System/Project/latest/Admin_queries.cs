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
    public partial class Admin_queries : Form
    {
        public Admin_queries()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            { 
                try
                {
                    int a = int.Parse(textBox1.Text.ToString());
                    if(a < 0)
                    {
                        MessageBox.Show("Input must be a positive integer");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Input must be a positive integer");
                    return;
                    throw;
                }
            }
            switch (comboBox1.SelectedIndex) {
                    case 0:
                    {
                        string query;
                        if(textBox1.Text != "")
                        {
                            query = "select count(i.name), cat.description from userCustomer uc "+
                                    "join Cart c on uc.id = c.customer_id "+
                                    "join item_cart ic on ic.cart_id = c.id "+
                                    "join item i on i.id = ic.item_id "+
                                    "join Category cat on cat.id = i.category_id "+
                                    "where uc.id = @c "+
                                    "group by cat.description;";
                        }
                        else
                        {
                            query = "select count(i.name), cat.description from userCustomer uc " +
                                    "join Cart c on uc.id = c.customer_id " +
                                    "join item_cart ic on ic.cart_id = c.id " +
                                    "join item i on i.id = ic.item_id " +
                                    "join Category cat on cat.id = i.category_id " +
                                    "group by cat.description;";
                        }
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            if(textBox1.Text != "")
                            {
                                da.SelectCommand.Parameters.AddWithValue("@c", int.Parse(textBox1.Text.ToString()));
                            }
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 1:
                    {
                        string query = "select i.name from usercustomer uc "+
                                        "join purchaseHistory uh on uc.id = uh.customer_id "+
                                        "join item_cart ic on uh.item_cart_id = ic.id "+
                                        "join item i on i.id = ic.item_id "+
                                        "group by i.name, i.id "+
                                        "having i.id = 1 ";
                        if (textBox1.Text != "")
                        {
                            query += "having i.id = @c;";
                        }
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            if (textBox1.Text != "")
                            {
                                da.SelectCommand.Parameters.AddWithValue("@c", int.Parse(textBox1.Text.ToString()));
                            }
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 2:
                    {
                        string query = "select count(i.id), c.id from Cart c" +
                                        "join item_cart ic on c.id = ic.cart_id " +
                                        "join item i on i.id = ic.item_id " +
                                        "group by c.id ";
                        if (textBox1.Text != "")
                        {
                            query += "having c.id = @c";
                        }
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            if (textBox1.Text != "")
                            {
                                da.SelectCommand.Parameters.AddWithValue("@c", int.Parse(textBox1.Text.ToString()));
                            }
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 3:
                    {
                        string query;
                        if (textBox1.Text != "")
                        {
                            query = "select i.name, count(*) from item i "+
                                    "join item_cart ic on i.id = ic.item_id "+
                                    "join cart c on c.id = ic.cart_id "+
                                    "group by i.name, i.id " +
                                    "having i.id = @c " +
                                    "order by count(*) desc";
                        }
                        else
                        {
                            query = "select i.name, count(*) from item i " +
                                    "join item_cart ic on i.id = ic.item_id " +
                                    "join cart c on c.id = ic.cart_id " +
                                    "group by i.name, i.id " +
                                    "order by count(*) desc";
                        }
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            if (textBox1.Text != "")
                            {
                                da.SelectCommand.Parameters.AddWithValue("@c", int.Parse(textBox1.Text.ToString()));
                            }
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 4: {
                        string query = "select uc.id, uc.name, count(ic.item_id) from userCustomer uc " +
                                        "join Cart c on c.customer_id = uc.id " +
                                        "join item_cart ic on ic.cart_id = c.id " +
                                        "group by uc.name, uc.id ";
                        if (textBox1.Text != "")
                        {
                            query += "having uc.id = 1";
                        }
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            if (textBox1.Text != "")
                            {
                                da.SelectCommand.Parameters.AddWithValue("@c", int.Parse(textBox1.Text.ToString()));
                            }
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 5: {
                        string query = "select C.customer_id count(*) from userCustomer uc join cart C on uc.id = c.customer_id group by C.customer_id";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 6: {
                        string query = "select cat.description, count(i.id) from Category cat "+
                                        "join item i on i.category_id = cat.id "+
                                        "group by cat.description";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 7: {
                        string query = "select inv.location, count(i.id) from inventory inv "+
                                        "join item i on i.inventory_id = inv.id "+
                                        "group by inv.location";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 8: {
                        string query = "select a.id, "+
                                       "(select COUNT(inv.id) "+
                                       "from inventory inv  "+
                                       "where a.id = inv.admin_id) as inventory_count "+
                                       "from userAdmin a;";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    case 9: {
                        string query = "select cat.description, "+
                                       "(select SUM(i.quantity) " +
                                      "from item i " +
                                     "where i.category_id = cat.id) as total_quantity " +
                                    "from Category cat;";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                case 10:
                    {
                        string query = "select c.id, " +
                                        "(select SUM(ic.quantity) " +
                                        "from item_cart ic " +
                                        "where ic.cart_id = c.id) as total_quantity "+
                                        "from cart c;";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                case 11:
                    {
                        string query = "select cat.description, "+
                                        "(select AVG(i.price) "+
                                        "from item i "+
                                        "where i.category_id = cat.id) as avg_price "+
                                        "from category cat;";
                        SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
                        connectionString.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                        DataSet ds = new DataSet();
                        string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionStr))
                        {
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds, "fullCafe");
                            dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
                        }
                    }
                    break;
                    default: { }
                    break;
            }
            textBox1.Text = "";
        }
    }
}

/*




string query = "";
SqlConnection connectionString = new SqlConnection("Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True");
connectionString.Open();
SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
DataSet ds = new DataSet();
string connectionStr = "Data Source=Fadd;Initial Catalog=CafeSystem;Integrated Security=True";
using (SqlConnection connection = new SqlConnection(connectionStr))
{
    da = new SqlDataAdapter(query, connection);
    ds = new DataSet();
    da.Fill(ds, "fullCafe");
    dataGridView1.DataSource = ds.Tables["fullCafe"].DefaultView;
}


*/