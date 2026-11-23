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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }
        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            loadSales();
            loadCounts();
        }
        private void loadSales()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FlavorCraveDB"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TransactionID, UserID, TransactionType, Amount, TransactionDate FROM EWalletTransactions ORDER BY TransactionDate DESC", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvSales.Rows.Clear();
                int i = 1;
                while (reader.Read() == true)
                {
                    string type = reader["TransactionType"].ToString();
                    decimal amount = Convert.ToDecimal(reader["Amount"]);
                    string date = Convert.ToDateTime(reader["TransactionDate"]).ToString("dd MMM yyyy");
                    string level = "Low";
                    if (amount >= 100)
                    {
                        level = "High";
                    }
                    else if (amount >= 50)
                    {
                        level = "Medium";
                    }
                    dgvSales.Rows.Add(i, reader["TransactionID"], reader["UserID"], type, amount.ToString("0.00"), date, level);
                    i = i + 1;
                }
                conn.Close();
                lblStatusLeft.Text = "✓ " + (i - 1).ToString() + " records loaded";
                lblStatusRight.Text = "Last updated: " + DateTime.Now.ToString("dd MMM yyyy");
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

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM EWalletTransactions", conn);
                int total = (int)cmd1.ExecuteScalar();
                lblCard1Value.Text = total.ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT SUM(Amount) FROM EWalletTransactions", conn);
                object result = cmd2.ExecuteScalar();
                decimal totalAmount = 0;
                if (result != DBNull.Value)
                {
                    totalAmount = Convert.ToDecimal(result);
                }
                lblCard2Value.Text = "RM " + totalAmount.ToString("0.00");

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM EWalletTransactions WHERE Amount >= 100", conn);
                int highCount = (int)cmd3.ExecuteScalar();
                lblCard3Value.Text = highCount.ToString();

                SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM EWalletTransactions WHERE TransactionType = 'Refund'", conn);
                int refundCount = (int)cmd4.ExecuteScalar();
                lblCard4Value.Text = refundCount.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            loadSales();
            loadCounts();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 2;
            cmbCategory.SelectedIndex = 0;
            cmbChef.SelectedIndex = 0;
            loadSales();
            loadCounts();
        }
    }
}