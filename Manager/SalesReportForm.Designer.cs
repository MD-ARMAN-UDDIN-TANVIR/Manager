namespace Manager
{
    partial class SalesReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblChef = new System.Windows.Forms.Label();
            this.cmbChef = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblCard3Value = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.lblCard4Value = new System.Windows.Forms.Label();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.lblStatusMiddle = new System.Windows.Forms.Label();
            this.lblStatusRight = new System.Windows.Forms.Label();

            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();

            // pnlTopBar
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 70;

            // lblTitle
            this.lblTitle.Text = "Sales Report";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Controls.Add(this.dgvSales);
            this.pnlMain.Controls.Add(this.pnlFilters);
            this.pnlMain.Controls.Add(this.pnlSummary);
            this.pnlMain.Controls.Add(this.pnlStatusBar);
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);

            // pnlFilters
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlFilters.Location = new System.Drawing.Point(15, 15);
            this.pnlFilters.Size = new System.Drawing.Size(1340, 80);
            this.pnlFilters.Controls.Add(this.lblMonth);
            this.pnlFilters.Controls.Add(this.cmbMonth);
            this.pnlFilters.Controls.Add(this.lblYear);
            this.pnlFilters.Controls.Add(this.cmbYear);
            this.pnlFilters.Controls.Add(this.lblCategory);
            this.pnlFilters.Controls.Add(this.cmbCategory);
            this.pnlFilters.Controls.Add(this.lblChef);
            this.pnlFilters.Controls.Add(this.cmbChef);
            this.pnlFilters.Controls.Add(this.btnFilter);
            this.pnlFilters.Controls.Add(this.btnReset);

            // lblMonth
            this.lblMonth.Text = "Month";
            this.lblMonth.ForeColor = System.Drawing.Color.Gray;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMonth.Location = new System.Drawing.Point(0, 0);
            this.lblMonth.AutoSize = true;

            // cmbMonth
            this.cmbMonth.Items.AddRange(new object[] { "All Months", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            this.cmbMonth.SelectedIndex = 0;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbMonth.ForeColor = System.Drawing.Color.White;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonth.Location = new System.Drawing.Point(0, 20);
            this.cmbMonth.Size = new System.Drawing.Size(160, 30);
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblYear
            this.lblYear.Text = "Year";
            this.lblYear.ForeColor = System.Drawing.Color.Gray;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblYear.Location = new System.Drawing.Point(175, 0);
            this.lblYear.AutoSize = true;

            // cmbYear
            this.cmbYear.Items.AddRange(new object[] { "2024", "2025", "2026" });
            this.cmbYear.SelectedIndex = 2;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbYear.ForeColor = System.Drawing.Color.White;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYear.Location = new System.Drawing.Point(175, 20);
            this.cmbYear.Size = new System.Drawing.Size(160, 30);
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblCategory
            this.lblCategory.Text = "Category";
            this.lblCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCategory.Location = new System.Drawing.Point(350, 0);
            this.lblCategory.AutoSize = true;

            // cmbCategory
            this.cmbCategory.Items.AddRange(new object[] { "All" });
            this.cmbCategory.SelectedIndex = 0;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location = new System.Drawing.Point(350, 20);
            this.cmbCategory.Size = new System.Drawing.Size(160, 30);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblChef
            this.lblChef.Text = "Chef";
            this.lblChef.ForeColor = System.Drawing.Color.Gray;
            this.lblChef.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblChef.Location = new System.Drawing.Point(525, 0);
            this.lblChef.AutoSize = true;

            // cmbChef
            this.cmbChef.Items.AddRange(new object[] { "All" });
            this.cmbChef.SelectedIndex = 0;
            this.cmbChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChef.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbChef.ForeColor = System.Drawing.Color.White;
            this.cmbChef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbChef.Location = new System.Drawing.Point(525, 20);
            this.cmbChef.Size = new System.Drawing.Size(160, 30);
            this.cmbChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnFilter
            this.btnFilter.Text = "Filter";
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(700, 20);
            this.btnFilter.Size = new System.Drawing.Size(100, 35);

            // btnReset
            this.btnReset.Text = "Reset";
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(810, 20);
            this.btnReset.Size = new System.Drawing.Size(100, 35);

            // dgvSales
            this.dgvSales.BackgroundColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.ColumnHeadersHeight = 40;
            this.dgvSales.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.dgvSales.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSales.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSales.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvSales.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSales.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(232, 160, 69);
            this.dgvSales.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ReadOnly = true;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.Location = new System.Drawing.Point(15, 105);
            this.dgvSales.Size = new System.Drawing.Size(1340, 380);
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNo, this.colTransID, this.colUserID, this.colType, this.colAmount, this.colDate, this.colLevel });

            // columns
            this.colNo.HeaderText = "#";
            this.colNo.Name = "colNo";
            this.colNo.FillWeight = 30;

            this.colTransID.HeaderText = "Trans ID";
            this.colTransID.Name = "colTransID";
            this.colTransID.FillWeight = 80;

            this.colUserID.HeaderText = "User ID";
            this.colUserID.Name = "colUserID";
            this.colUserID.FillWeight = 80;

            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.FillWeight = 100;

            this.colAmount.HeaderText = "Amount (RM)";
            this.colAmount.Name = "colAmount";
            this.colAmount.FillWeight = 120;

            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.FillWeight = 120;

            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.FillWeight = 80;

            // pnlSummary
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlSummary.Location = new System.Drawing.Point(15, 495);
            this.pnlSummary.Size = new System.Drawing.Size(1340, 100);
            this.pnlSummary.Controls.Add(this.pnlCard1);
            this.pnlSummary.Controls.Add(this.pnlCard2);
            this.pnlSummary.Controls.Add(this.pnlCard3);
            this.pnlSummary.Controls.Add(this.pnlCard4);

            // pnlCard1
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Location = new System.Drawing.Point(0, 5);
            this.pnlCard1.Size = new System.Drawing.Size(320, 80);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Value);

            this.lblCard1Title.Text = "Total Transactions";
            this.lblCard1Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard1Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard1Title.AutoSize = true;

            this.lblCard1Value.Text = "0";
            this.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.Location = new System.Drawing.Point(10, 30);
            this.lblCard1Value.AutoSize = true;

            // pnlCard2
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Location = new System.Drawing.Point(335, 5);
            this.pnlCard2.Size = new System.Drawing.Size(320, 80);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Value);

            this.lblCard2Title.Text = "Total Amount";
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard2Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard2Title.AutoSize = true;

            this.lblCard2Value.Text = "RM 0.00";
            this.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.Location = new System.Drawing.Point(10, 30);
            this.lblCard2Value.AutoSize = true;

            // pnlCard3
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Location = new System.Drawing.Point(670, 5);
            this.pnlCard3.Size = new System.Drawing.Size(320, 80);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblCard3Value);

            this.lblCard3Title.Text = "High Value";
            this.lblCard3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard3Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard3Title.AutoSize = true;

            this.lblCard3Value.Text = "0";
            this.lblCard3Value.ForeColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value.Location = new System.Drawing.Point(10, 30);
            this.lblCard3Value.AutoSize = true;

            // pnlCard4
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Location = new System.Drawing.Point(1005, 5);
            this.pnlCard4.Size = new System.Drawing.Size(320, 80);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Controls.Add(this.lblCard4Value);

            this.lblCard4Title.Text = "Refunds";
            this.lblCard4Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard4Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard4Title.AutoSize = true;

            this.lblCard4Value.Text = "0";
            this.lblCard4Value.ForeColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.lblCard4Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard4Value.Location = new System.Drawing.Point(10, 30);
            this.lblCard4Value.AutoSize = true;

            // pnlStatusBar
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(232, 220, 200);
            this.pnlStatusBar.Location = new System.Drawing.Point(15, 605);
            this.pnlStatusBar.Size = new System.Drawing.Size(1340, 30);
            this.pnlStatusBar.Controls.Add(this.lblStatusLeft);
            this.pnlStatusBar.Controls.Add(this.lblStatusMiddle);
            this.pnlStatusBar.Controls.Add(this.lblStatusRight);

            this.lblStatusLeft.Text = "0 records loaded";
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(92, 45, 0);
            this.lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusLeft.Location = new System.Drawing.Point(10, 7);
            this.lblStatusLeft.AutoSize = true;

            this.lblStatusMiddle.Text = "● Connected";
            this.lblStatusMiddle.ForeColor = System.Drawing.Color.Green;
            this.lblStatusMiddle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusMiddle.Location = new System.Drawing.Point(600, 7);
            this.lblStatusMiddle.AutoSize = true;

            this.lblStatusRight.Text = "Last updated: -";
            this.lblStatusRight.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusRight.Location = new System.Drawing.Point(1150, 7);
            this.lblStatusRight.AutoSize = true;

            // SalesReportForm
            this.ClientSize = new System.Drawing.Size(1380, 660);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.Text = "Sales Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);

            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlStatusBar.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
        }

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.ComboBox cmbChef;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblCard4Value;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label lblStatusLeft;
        private System.Windows.Forms.Label lblStatusMiddle;
        private System.Windows.Forms.Label lblStatusRight;
    }
}