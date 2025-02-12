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
    public partial class Verification : Form
    {
        string Parent;//stores name of window who called this window
        bool verified;
        int cart_id;
        public Verification()
        {
            InitializeComponent();
            verified = false;
        }
        public Verification(int a)
        {
            InitializeComponent();
            cart_id = a;
        }

        public void Storeinfo(string info)
        {
            Parent = info;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();
            List<int> admins = new List<int>();
            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            string query = "select username, pass from userCustomer";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                usernames.Add(reader.GetString(0));
                passwords.Add(reader.GetString(1));
            }
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
            //get customer id
            int c_id = -1; 
            query = "Select id from userCustomer where username = @username and pass = @password";
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", user);
                    command.Parameters.AddWithValue("@password", pass);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        c_id = reader.GetInt32(0);
                    }
                }
            }
            if (Parent == "addCreditCard")
            {
                addCreditCard a = new addCreditCard(c_id, this);
                a.Show();
            }
            else if(Parent == "changePass")
            {
                changePass c = new changePass(c_id, this);
                c.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Verification_Load(object sender, EventArgs e)
        {

        }
    }
}
