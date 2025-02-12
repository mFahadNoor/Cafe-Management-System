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
    public partial class admin_delete_Item : Form
    {
        public admin_delete_Item()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection connectionString = new SqlConnection("Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True");
            connectionString.Open();
            string query = "Select * from item";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            cellsMain.DataSource = ds.Tables["item"].DefaultView;
            /*
            query = "Select * from cart";
            da = new SqlDataAdapter(query, connectionString);
            ds = new DataSet();
            da.Fill(ds, "cart");
            cellsCart.DataSource = ds.Tables["cart"].DefaultView;
            */
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void admin_delete_Item_Load(object sender, EventArgs e)
        {

        }

        private void cellsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("ID must be a valid integer.");
                return;
            }

            string connectionString = "Data Source=fadd;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM item WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Row deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No row was deleted.");
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting row: " + ex.Message);
                }
            }
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_view_allcategories admin_View_Allcategories = new Admin_view_allcategories();
            admin_View_Allcategories.Show();
        }
        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_Item admin_Delete_Item = new admin_delete_Item(); ;
            admin_Delete_Item.Show();
        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_View_all_items admin_View_All_Items = new Admin_View_all_items();
            admin_View_All_Items.Show();




        }

        private void allTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_View_all_Tables admin_View_All_tables = new Admin_View_all_Tables();
            admin_View_All_tables.Show();
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_search_table admin_Search = new admin_search_table();
            admin_Search.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_search_item admin_Search_Item = new admin_search_item();
            ; admin_Search_Item.Show();
        }

        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_table admin_Add_ = new admin_add_table();
            admin_Add_.Show();
        }

        private void removeTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Delete_Table admin_Delete_Table = new Admin_Delete_Table();
            admin_Delete_Table.Show();
        }

        private void editTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_edit_table admin_Edit_Table = new admin_edit_table();
            admin_Edit_Table.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_add_category admin_Add_Category = new Admin_add_category();
            admin_Add_Category.Show();
        }

        private void removeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_delete_Category admin_Delete_Category = new Admin_delete_Category();
            admin_Delete_Category.Show();

        }

        private void addDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Add_disount admin_Add_Disount = new Admin_Add_disount();
            admin_Add_Disount.Show();
        }

        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Inventory admin_Inventory = new Admin_Inventory();
            admin_Inventory.Show();
        }

        private void allPurchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_All_PurchaseHistory admin_All_PurchaseHistory = new Admin_All_PurchaseHistory();
            admin_All_PurchaseHistory.Show();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_change__pass admin_Change__Pass = new Admin_change__pass();
            admin_Change__Pass.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchaseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_All_PurchaseHistory admin_All_PurchaseHistory = new Admin_All_PurchaseHistory();
            admin_All_PurchaseHistory.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Inventory admin_Inventory = new Admin_Inventory();
        }

    }
}
