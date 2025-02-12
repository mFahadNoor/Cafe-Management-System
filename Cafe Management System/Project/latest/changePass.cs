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
    public partial class changePass : Form
    {
        int c_id;
        Verification ver;
        public changePass()
        {
            InitializeComponent();
        }
        public changePass(int a, Verification v)
        {
            InitializeComponent();
            this.c_id = a;
            this.ver = v;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newP_confirm = textBox2.Text;
            string newP = textBox1.Text;

            if (newP == "")
            {
                MessageBox.Show("New Password cant be empty");
                return;
            }

            if (newP != newP_confirm)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "update userCustomer set pass = @pass where id = @c_id";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pass", newP);
                command.Parameters.AddWithValue("@c_id", c_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Password changed Successfully!");
                this.Close();
                ver.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void changePass_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
