using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class MenuItemsForm : Form
    {
        public MenuItemsForm()
        {
            InitializeComponent();
        }
        private void MenuItemsForm_Load(object sender, EventArgs e)
        {
            loadMenuItems();
        }
        private void loadMenuItems()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT m.ItemName, c.CategoryName, m.Price, m.IsAvailable FROM MenuItems m INNER JOIN Categories c ON m.CategoryID = c.CategoryID", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvMenuItems.Rows.Clear();
                int i = 1;
                while (reader.Read() == true)
                {
                    string avail = "No";
                    if (reader["IsAvailable"].ToString() == "True" || reader["IsAvailable"].ToString() == "1")
                    {
                        avail = "Yes";
                    }
                    dgvMenuItems.Rows.Add(i, reader["ItemName"], reader["CategoryName"], reader["Price"], avail, "Select");
                    i = i + 1;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtItemName.Text = dgvMenuItems.Rows[e.RowIndex].Cells["colItemName"].Value.ToString();
                txtCategory.Text = dgvMenuItems.Rows[e.RowIndex].Cells["colCategory"].Value.ToString();
                txtPrice.Text = dgvMenuItems.Rows[e.RowIndex].Cells["colPrice"].Value.ToString();
                txtAvailable.Text = dgvMenuItems.Rows[e.RowIndex].Cells["colAvailable"].Value.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter item name:", "New Item", "");
            if (name == "") return;
            string cat = Microsoft.VisualBasic.Interaction.InputBox("Enter category:", "New Item", "");
            if (cat == "") return;
            string priceText = Microsoft.VisualBasic.Interaction.InputBox("Enter price:", "New Item", "0.00");
            if (priceText == "") return;
            decimal price = 0;
            bool ok = decimal.TryParse(priceText, out price);
            if (ok == false)
            {
                MessageBox.Show("Invalid price!");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MenuItems (ItemName, CategoryID, Price, IsAvailable) VALUES (@n, (SELECT CategoryID FROM Categories WHERE CategoryName=@c), @p, @a)", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@c", cat);
                cmd.Parameters.AddWithValue("@p", price);
                cmd.Parameters.AddWithValue("@a", true);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Item added!");
                loadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Select an item first!");
                return;
            }
            decimal price = 0;
            bool ok = decimal.TryParse(txtPrice.Text, out price);
            if (ok == false)
            {
                MessageBox.Show("Invalid price!");
                return;
            }
            bool avail = false;
            if (txtAvailable.Text == "Yes")
            {
                avail = true;
            }
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE MenuItems SET CategoryID=(SELECT CategoryID FROM Categories WHERE CategoryName=@c), Price=@p, IsAvailable=@a WHERE ItemName=@n", conn);
                cmd.Parameters.AddWithValue("@c", txtCategory.Text);
                cmd.Parameters.AddWithValue("@p", price);
                cmd.Parameters.AddWithValue("@a", avail);
                cmd.Parameters.AddWithValue("@n", txtItemName.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Item updated!");
                txtItemName.Text = "";
                txtCategory.Text = "";
                txtPrice.Text = "";
                txtAvailable.Text = "";
                loadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Select an item first!");
                return;
            }
            DialogResult ans = MessageBox.Show("Remove " + txtItemName.Text + "?", "Confirm", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM MenuItems WHERE ItemName=@n", conn);
                    cmd.Parameters.AddWithValue("@n", txtItemName.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Item removed!");
                    txtItemName.Text = "";
                    txtCategory.Text = "";
                    txtPrice.Text = "";
                    txtAvailable.Text = "";
                    loadMenuItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMenuItems();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtCategory.Text = "";
            txtPrice.Text = "";
            txtAvailable.Text = "";
        }
    }
}