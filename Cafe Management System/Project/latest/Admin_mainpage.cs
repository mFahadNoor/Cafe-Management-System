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
    public partial class Admin_mainpage : Form
    {
       
        public Admin_mainpage()
        {
         
        }
        public Admin_mainpage(string username)
        {
            InitializeComponent();
          
        label1.Text = username;
            LoadData();
        
        }

        private void allTabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_View_all_Tables admin_View_All_Tables = new Admin_View_all_Tables();
            admin_View_All_Tables.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ItemView";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cellsMain.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_change__pass admin_Change__Pass = new Admin_change__pass();
              admin_Change__Pass.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_View_all_items admin_View_All_ = new Admin_View_all_items();
            admin_View_All_.Show();
        }

        private void allPurchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_All_PurchaseHistory admin_All_PurchaseHistory = new Admin_All_PurchaseHistory();
            admin_All_PurchaseHistory.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Inventory admin_Inventory = new Admin_Inventory();
                admin_Inventory.Show();
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_add_table admin_Add_Table = new admin_add_table();
            admin_Add_Table.Show();
        }

        private void removeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Delete_Table admin_Delete_Table = new Admin_Delete_Table();   
            admin_Delete_Table.Show();
        }

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_edit_table admin_Edit_Table = new admin_edit_table();
            admin_Edit_Table.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Add_Items admin_Add_Items = new Admin_Add_Items();
            admin_Add_Items.Show();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_delete_Item admin_Delete_Item = new admin_delete_Item();
            admin_Delete_Item.Show();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_edit_items admin_Edit_Items = new admin_edit_items();
            admin_Edit_Items.Show();

        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_add_category admin_Add_Category = new Admin_add_category();
                admin_Add_Category.Show();

        }

        private void removeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_delete_Category admin_Delete_Category =new Admin_delete_Category();
            admin_Delete_Category.Show();
        }

        private void applyDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Add_disount admin_Add_Disount = new Admin_Add_disount();
            admin_Add_Disount.Show();
        }

        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            admin_search_table admin_Search_Table = new admin_search_table();
                admin_Search_Table.Show();  
        }

        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            admin_search_item admin_Search_Item = new admin_search_item();
            admin_Search_Item.Show();
        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_queries admin_Queries = new Admin_queries();
            admin_Queries.Show();
        }
    }
}
