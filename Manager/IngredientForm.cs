using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace Manager
{
    public partial class IngredientForm : Form
    {
        public IngredientForm()
        {
            InitializeComponent();
        }
        private void IngredientForm_Load(object sender, EventArgs e)
        {
            loadIngredients();
            loadCounts();
        }
        private void loadIngredients()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IngredientID, IngredientName, Unit, QuantityInStock FROM Ingredients ORDER BY IngredientID ASC", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvIngredients.Rows.Clear();
                int i = 1;
                while (reader.Read() == true)
                {
                    Ingredient ing = new Ingredient();
                    ing.IngredientID = Convert.ToInt32(reader["IngredientID"]);
                    ing.IngredientName = reader["IngredientName"].ToString();
                    ing.Unit = reader["Unit"].ToString();
                    ing.QuantityInStock = Convert.ToDecimal(reader["QuantityInStock"]);
                    string status = ing.getStatus();
                    dgvIngredients.Rows.Add(i, ing.IngredientName, ing.Unit, ing.QuantityInStock, status, "Edit");
                    i = i + 1;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void loadCounts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Ingredients", conn);
                int total = (int)cmd1.ExecuteScalar();
                lblCard1Value.Text = total.ToString();
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Ingredients WHERE QuantityInStock > 10", conn);
                int inStock = (int)cmd2.ExecuteScalar();
                lblCard2Value.Text = inStock.ToString();
                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Ingredients WHERE QuantityInStock <= 10 AND QuantityInStock > 0", conn);
                int lowStock = (int)cmd3.ExecuteScalar();
                lblCard3Value.Text = lowStock.ToString();
                SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Ingredients WHERE QuantityInStock = 0", conn);
                int outStock = (int)cmd4.ExecuteScalar();
                lblCard4Value.Text = outStock.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadIngredients();
            loadCounts();
        }
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter ingredient name:", "Add Ingredient", "");
            if (name == "") return;
            string unit = Microsoft.VisualBasic.Interaction.InputBox("Enter unit (kg/g/l/ml):", "Add Ingredient", "kg");
            if (unit == "") return;
            string qtyText = Microsoft.VisualBasic.Interaction.InputBox("Enter quantity:", "Add Ingredient", "0");
            if (qtyText == "") return;
            decimal qty = 0;
            bool ok = decimal.TryParse(qtyText, out qty);
            if (ok == false)
            {
                MessageBox.Show("Invalid quantity!");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Ingredients (IngredientName, Unit, QuantityInStock) VALUES (@n, @u, @q)", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@u", unit);
                cmd.Parameters.AddWithValue("@q", qty);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ingredient added!");
                loadIngredients();
                loadCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (txtSelectedIng.Text == "")
            {
                MessageBox.Show("Select an ingredient first!");
                return;
            }
            if (txtNewQty.Text == "")
            {
                MessageBox.Show("Enter a quantity!");
                return;
            }
            decimal qty = 0;
            bool ok = decimal.TryParse(txtNewQty.Text, out qty);
            if (ok == false)
            {
                MessageBox.Show("Invalid quantity!");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Ingredients SET QuantityInStock = @q WHERE IngredientName = @n", conn);
                cmd.Parameters.AddWithValue("@q", qty);
                cmd.Parameters.AddWithValue("@n", txtSelectedIng.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Stock updated!");
                txtSelectedIng.Text = "";
                txtNewQty.Text = "";
                txtUnit.Text = "";
                loadIngredients();
                loadCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtSelectedIng.Text == "")
            {
                MessageBox.Show("Select an ingredient first!");
                return;
            }
            DialogResult ans = MessageBox.Show("Remove " + txtSelectedIng.Text + "?", "Confirm", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Ingredients WHERE IngredientName = @n", conn);
                    cmd.Parameters.AddWithValue("@n", txtSelectedIng.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Removed!");
                    txtSelectedIng.Text = "";
                    txtNewQty.Text = "";
                    txtUnit.Text = "";
                    loadIngredients();
                    loadCounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSelectedIng.Text = "";
            txtNewQty.Text = "";
            txtUnit.Text = "";
        }
        private void dgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSelectedIng.Text = dgvIngredients.Rows[e.RowIndex].Cells["colIngName"].Value.ToString();
                txtUnit.Text = dgvIngredients.Rows[e.RowIndex].Cells["colUnit"].Value.ToString();
                txtNewQty.Text = dgvIngredients.Rows[e.RowIndex].Cells["colQty"].Value.ToString();
            }
        }
    }
}

