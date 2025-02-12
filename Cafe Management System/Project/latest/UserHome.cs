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
    public partial class UserHome : Form
    {
        int cart_id;
        bool isGuest;
        public UserHome()
        {
            InitializeComponent();
            isGuest = false;
        }
        public UserHome(bool g)
        {
            InitializeComponent();
            this.isGuest = true;
                historyButton.Visible = false;
                editButton.Visible = false;
        }

        public void updateUser(string a, int id)
        {
            label1.Text = "Welcome, ";
            label1.Text += a;
            cart_id = id;
        }
        public void setCartId(int id)
        {
            cart_id = id;
        }
        private void UserHome_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserBrowse U = new UserBrowse(cart_id);
            U.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkout c = new checkout(cart_id, this, isGuest);
            c.Show();
        }
        private void logout(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            userManageCart a = new userManageCart(cart_id);
            a.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editAccount a = new editAccount(cart_id);
            a.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            viewHistory vh = new viewHistory(cart_id);
            vh.Show();
        }
      
    }
}
