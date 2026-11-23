using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Manager
{
    public partial class ManagerHomeForm : Form
    {
        public ManagerHomeForm()
        {
            InitializeComponent();
        }
        private void ManagerHomeForm_Load(object sender, EventArgs e)
        {
            loadCounts();
        }
        private void loadCounts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM MenuItems", conn);
                int menuCount = (int)cmd1.ExecuteScalar();
                lblCard1Value.Text = menuCount.ToString();
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Ingredients", conn);
                int ingCount = (int)cmd2.ExecuteScalar();
                lblCard2Value.Text = ingCount.ToString();
                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Ingredients WHERE QuantityInStock <= 10", conn);
                int lowCount = (int)cmd3.ExecuteScalar();
                lblCard3Value.Text = lowCount.ToString();
                SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Categories", conn);
                int catCount = (int)cmd4.ExecuteScalar();
                lblCard4Value.Text = catCount.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lblRoleBadge_Click(object sender, EventArgs e)
        {
        }
        private void lblManagerName_Click(object sender, EventArgs e)
        {
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
        }
        private void btnMenuItems_Click(object sender, EventArgs e)
        {
            MenuItemsForm frm = new MenuItemsForm();
            frm.Show();
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            IngredientForm frm = new IngredientForm();
            frm.Show();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports coming soon!");
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff coming soon!");
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings coming soon!");
        }
        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Account coming soon!");
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnIngredient_Click(object sender, EventArgs e)
        {
            IngredientForm frm = new IngredientForm();
            frm.Show();
        }
    }
}