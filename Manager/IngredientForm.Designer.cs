namespace Manager
{
    partial class IngredientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblLowStockBadge = new System.Windows.Forms.Label();
            this.lblIngSubtitle = new System.Windows.Forms.Label();
            this.lblIngTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblStatusMiddle = new System.Windows.Forms.Label();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblCard3Value = new System.Windows.Forms.Label();
            this.lblCard3Sub = new System.Windows.Forms.Label();
            this.pnlUpdateStock = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtNewQty = new System.Windows.Forms.TextBox();
            this.txtSelectedIng = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblNewQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblSelectedIng = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.lblCard4Value = new System.Windows.Forms.Label();
            this.lblCard4Sub = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblCard2Sub = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.lblCard1Sub = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.pnlStatusBar.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlUpdateStock.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.pnlTopBar.Controls.Add(this.lblConnected);
            this.pnlTopBar.Controls.Add(this.lblLowStockBadge);
            this.pnlTopBar.Controls.Add(this.lblIngSubtitle);
            this.pnlTopBar.Controls.Add(this.lblIngTitle);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1626, 92);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblConnected
            // 
            this.lblConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.lblConnected.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblConnected.ForeColor = System.Drawing.Color.White;
            this.lblConnected.Location = new System.Drawing.Point(1425, 28);
            this.lblConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(165, 38);
            this.lblConnected.TabIndex = 3;
            this.lblConnected.Text = "✓ Connected";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowStockBadge
            // 
            this.lblLowStockBadge.BackColor = System.Drawing.Color.DarkOrange;
            this.lblLowStockBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLowStockBadge.ForeColor = System.Drawing.Color.White;
            this.lblLowStockBadge.Location = new System.Drawing.Point(1230, 28);
            this.lblLowStockBadge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowStockBadge.Name = "lblLowStockBadge";
            this.lblLowStockBadge.Size = new System.Drawing.Size(180, 38);
            this.lblLowStockBadge.TabIndex = 2;
            this.lblLowStockBadge.Text = "⚠ Low Stock";
            this.lblLowStockBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngSubtitle
            // 
            this.lblIngSubtitle.AutoSize = true;
            this.lblIngSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIngSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblIngSubtitle.Location = new System.Drawing.Point(68, 62);
            this.lblIngSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngSubtitle.Name = "lblIngSubtitle";
            this.lblIngSubtitle.Size = new System.Drawing.Size(224, 21);
            this.lblIngSubtitle.TabIndex = 1;
            this.lblIngSubtitle.Text = "Manage ingredient stock levels";
            this.lblIngSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIngTitle
            // 
            this.lblIngTitle.AutoSize = true;
            this.lblIngTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblIngTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(160)))), ((int)(((byte)(69)))));
            this.lblIngTitle.Location = new System.Drawing.Point(22, 28);
            this.lblIngTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngTitle.Name = "lblIngTitle";
            this.lblIngTitle.Size = new System.Drawing.Size(384, 38);
            this.lblIngTitle.TabIndex = 0;
            this.lblIngTitle.Text = "📦 Ingredient Management";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.dgvIngredients);
            this.pnlMainContent.Controls.Add(this.pnlStatusBar);
            this.pnlMainContent.Controls.Add(this.pnlCard3);
            this.pnlMainContent.Controls.Add(this.pnlUpdateStock);
            this.pnlMainContent.Controls.Add(this.pnlCard4);
            this.pnlMainContent.Controls.Add(this.pnlCard2);
            this.pnlMainContent.Controls.Add(this.pnlCard1);
            this.pnlMainContent.Controls.Add(this.pnlToolbar);
            this.pnlMainContent.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.pnlMainContent.Location = new System.Drawing.Point(0, 92);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1626, 923);
            this.pnlMainContent.TabIndex = 1;
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colIngName,
            this.colUnit,
            this.colQty,
            this.colStatus,
            this.colAction});
            this.dgvIngredients.Location = new System.Drawing.Point(30, 292);
            this.dgvIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.RowHeadersVisible = false;
            this.dgvIngredients.RowHeadersWidth = 62;
            this.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredients.Size = new System.Drawing.Size(1566, 385);
            this.dgvIngredients.TabIndex = 25;
            this.dgvIngredients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredients_CellClick);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "#";
            this.colNo.MinimumWidth = 8;
            this.colNo.Name = "colNo";
            // 
            // colIngName
            // 
            this.colIngName.HeaderText = "Ingredient Name";
            this.colIngName.MinimumWidth = 8;
            this.colIngName.Name = "colIngName";
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.MinimumWidth = 8;
            this.colUnit.Name = "colUnit";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty In Stock";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 8;
            this.colAction.Name = "colAction";
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.pnlStatusBar.Controls.Add(this.lblStatusMiddle);
            this.pnlStatusBar.Controls.Add(this.lblStatusRight);
            this.pnlStatusBar.Controls.Add(this.lblStatusLeft);
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 885);
            this.pnlStatusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(1626, 38);
            this.pnlStatusBar.TabIndex = 6;
            // 
            // lblStatusMiddle
            // 
            this.lblStatusMiddle.AutoSize = true;
            this.lblStatusMiddle.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStatusMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblStatusMiddle.Location = new System.Drawing.Point(600, 8);
            this.lblStatusMiddle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusMiddle.Name = "lblStatusMiddle";
            this.lblStatusMiddle.Size = new System.Drawing.Size(178, 19);
            this.lblStatusMiddle.TabIndex = 27;
            this.lblStatusMiddle.Text = "⚠ 0 items need restocking";
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblStatusRight.Location = new System.Drawing.Point(1275, 8);
            this.lblStatusRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(177, 19);
            this.lblStatusRight.TabIndex = 28;
            this.lblStatusRight.Text = "Last updated: 23 Nov 2026";
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblStatusLeft.Location = new System.Drawing.Point(15, 8);
            this.lblStatusLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(148, 19);
            this.lblStatusLeft.TabIndex = 26;
            this.lblStatusLeft.Text = "✓ 0 ingredients loaded";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblCard3Value);
            this.pnlCard3.Controls.Add(this.lblCard3Sub);
            this.pnlCard3.Location = new System.Drawing.Point(795, 131);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(366, 137);
            this.pnlCard3.TabIndex = 5;
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblCard3Title.Location = new System.Drawing.Point(15, 12);
            this.lblCard3Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(80, 21);
            this.lblCard3Title.TabIndex = 13;
            this.lblCard3Title.Text = "Low Stock";
            // 
            // lblCard3Value
            // 
            this.lblCard3Value.AutoSize = true;
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCard3Value.Location = new System.Drawing.Point(15, 38);
            this.lblCard3Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard3Value.Name = "lblCard3Value";
            this.lblCard3Value.Size = new System.Drawing.Size(46, 54);
            this.lblCard3Value.TabIndex = 14;
            this.lblCard3Value.Text = "0";
            // 
            // lblCard3Sub
            // 
            this.lblCard3Sub.AutoSize = true;
            this.lblCard3Sub.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCard3Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCard3Sub.Location = new System.Drawing.Point(15, 95);
            this.lblCard3Sub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard3Sub.Name = "lblCard3Sub";
            this.lblCard3Sub.Size = new System.Drawing.Size(108, 19);
            this.lblCard3Sub.TabIndex = 15;
            this.lblCard3Sub.Text = "Need restocking";
            // 
            // pnlUpdateStock
            // 
            this.pnlUpdateStock.BackColor = System.Drawing.Color.White;
            this.pnlUpdateStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateStock.Controls.Add(this.btnCancel);
            this.pnlUpdateStock.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateStock.Controls.Add(this.txtUnit);
            this.pnlUpdateStock.Controls.Add(this.txtNewQty);
            this.pnlUpdateStock.Controls.Add(this.txtSelectedIng);
            this.pnlUpdateStock.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdateStock.Controls.Add(this.lblNewQty);
            this.pnlUpdateStock.Controls.Add(this.lblUnit);
            this.pnlUpdateStock.Controls.Add(this.lblSelectedIng);
            this.pnlUpdateStock.Location = new System.Drawing.Point(30, 700);
            this.pnlUpdateStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUpdateStock.Name = "pnlUpdateStock";
            this.pnlUpdateStock.Size = new System.Drawing.Size(1565, 168);
            this.pnlUpdateStock.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(855, 85);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 46);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(660, 85);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(180, 46);
            this.btnSaveChanges.TabIndex = 28;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.txtUnit.Location = new System.Drawing.Point(548, 89);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(88, 31);
            this.txtUnit.TabIndex = 27;
            this.txtUnit.Text = "``";
            // 
            // txtNewQty
            // 
            this.txtNewQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewQty.Location = new System.Drawing.Point(345, 89);
            this.txtNewQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewQty.Name = "txtNewQty";
            this.txtNewQty.Size = new System.Drawing.Size(178, 31);
            this.txtNewQty.TabIndex = 26;
            this.txtNewQty.Text = "``";
            // 
            // txtSelectedIng
            // 
            this.txtSelectedIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.txtSelectedIng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSelectedIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.txtSelectedIng.Location = new System.Drawing.Point(22, 89);
            this.txtSelectedIng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelectedIng.Name = "txtSelectedIng";
            this.txtSelectedIng.ReadOnly = true;
            this.txtSelectedIng.Size = new System.Drawing.Size(298, 31);
            this.txtSelectedIng.TabIndex = 25;
            this.txtSelectedIng.Text = "``";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblUpdateTitle.Location = new System.Drawing.Point(22, 15);
            this.lblUpdateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(261, 28);
            this.lblUpdateTitle.TabIndex = 18;
            this.lblUpdateTitle.Text = "🖍️ Update Stock Quantity";
            // 
            // lblNewQty
            // 
            this.lblNewQty.AutoSize = true;
            this.lblNewQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblNewQty.Location = new System.Drawing.Point(345, 62);
            this.lblNewQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewQty.Name = "lblNewQty";
            this.lblNewQty.Size = new System.Drawing.Size(106, 21);
            this.lblNewQty.TabIndex = 21;
            this.lblNewQty.Text = "New Quantity";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblUnit.Location = new System.Drawing.Point(548, 62);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 21);
            this.lblUnit.TabIndex = 22;
            this.lblUnit.Text = "Unit";
            // 
            // lblSelectedIng
            // 
            this.lblSelectedIng.AutoSize = true;
            this.lblSelectedIng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblSelectedIng.Location = new System.Drawing.Point(22, 62);
            this.lblSelectedIng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedIng.Name = "lblSelectedIng";
            this.lblSelectedIng.Size = new System.Drawing.Size(164, 25);
            this.lblSelectedIng.TabIndex = 20;
            this.lblSelectedIng.Text = "Selected Ingredient";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Controls.Add(this.lblCard4Value);
            this.pnlCard4.Controls.Add(this.lblCard4Sub);
            this.pnlCard4.Location = new System.Drawing.Point(1178, 131);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(366, 137);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblCard4Title.Location = new System.Drawing.Point(15, 12);
            this.lblCard4Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(95, 21);
            this.lblCard4Title.TabIndex = 16;
            this.lblCard4Title.Text = "Out of Stock";
            // 
            // lblCard4Value
            // 
            this.lblCard4Value.AutoSize = true;
            this.lblCard4Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCard4Value.Location = new System.Drawing.Point(15, 38);
            this.lblCard4Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard4Value.Name = "lblCard4Value";
            this.lblCard4Value.Size = new System.Drawing.Size(46, 54);
            this.lblCard4Value.TabIndex = 19;
            this.lblCard4Value.Text = "0";
            // 
            // lblCard4Sub
            // 
            this.lblCard4Sub.AutoSize = true;
            this.lblCard4Sub.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCard4Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCard4Sub.Location = new System.Drawing.Point(15, 95);
            this.lblCard4Sub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard4Sub.Name = "lblCard4Sub";
            this.lblCard4Sub.Size = new System.Drawing.Size(79, 19);
            this.lblCard4Sub.TabIndex = 17;
            this.lblCard4Sub.Text = "Unavailable";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Controls.Add(this.lblCard2Sub);
            this.pnlCard2.Location = new System.Drawing.Point(412, 131);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(366, 137);
            this.pnlCard2.TabIndex = 2;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblCard2Title.Location = new System.Drawing.Point(15, 12);
            this.lblCard2Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(64, 21);
            this.lblCard2Title.TabIndex = 10;
            this.lblCard2Title.Text = "In Stock";
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.lblCard2Value.Location = new System.Drawing.Point(15, 38);
            this.lblCard2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(46, 54);
            this.lblCard2Value.TabIndex = 11;
            this.lblCard2Value.Text = "0";
            // 
            // lblCard2Sub
            // 
            this.lblCard2Sub.AutoSize = true;
            this.lblCard2Sub.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCard2Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCard2Sub.Location = new System.Drawing.Point(15, 95);
            this.lblCard2Sub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard2Sub.Name = "lblCard2Sub";
            this.lblCard2Sub.Size = new System.Drawing.Size(95, 19);
            this.lblCard2Sub.TabIndex = 12;
            this.lblCard2Sub.Text = "Sufficient level";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Controls.Add(this.lblCard1Sub);
            this.pnlCard1.Location = new System.Drawing.Point(30, 131);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(366, 137);
            this.pnlCard1.TabIndex = 1;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblCard1Title.Location = new System.Drawing.Point(15, 12);
            this.lblCard1Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(124, 21);
            this.lblCard1Title.TabIndex = 7;
            this.lblCard1Title.Text = "Total Ingredients";
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblCard1Value.Location = new System.Drawing.Point(15, 34);
            this.lblCard1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(46, 54);
            this.lblCard1Value.TabIndex = 8;
            this.lblCard1Value.Text = "0";
            // 
            // lblCard1Sub
            // 
            this.lblCard1Sub.AutoSize = true;
            this.lblCard1Sub.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCard1Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCard1Sub.Location = new System.Drawing.Point(15, 95);
            this.lblCard1Sub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard1Sub.Name = "lblCard1Sub";
            this.lblCard1Sub.Size = new System.Drawing.Size(80, 19);
            this.lblCard1Sub.TabIndex = 9;
            this.lblCard1Sub.Text = "In database";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnRemove);
            this.pnlToolbar.Controls.Add(this.btnUpdateStock);
            this.pnlToolbar.Controls.Add(this.btnAddIngredient);
            this.pnlToolbar.Location = new System.Drawing.Point(30, 23);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1565, 84);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(938, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 46);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "↺ Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtSearch.Location = new System.Drawing.Point(15, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 31);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "🔍 Search ingredient...";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRemove.Location = new System.Drawing.Point(772, 18);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 46);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "🗑 Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnUpdateStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnUpdateStock.Location = new System.Drawing.Point(578, 18);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(180, 46);
            this.btnUpdateStock.TabIndex = 1;
            this.btnUpdateStock.Text = "🖍️ Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnAddIngredient.FlatAppearance.BorderSize = 0;
            this.btnAddIngredient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddIngredient.ForeColor = System.Drawing.Color.White;
            this.btnAddIngredient.Location = new System.Drawing.Point(368, 18);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(195, 46);
            this.btnAddIngredient.TabIndex = 0;
            this.btnAddIngredient.Text = "+ Add Ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1626, 1017);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "IngredientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredient Management";
            this.Load += new System.EventHandler(this.IngredientForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlUpdateStock.ResumeLayout(false);
            this.pnlUpdateStock.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblIngTitle;
        private System.Windows.Forms.Label lblIngSubtitle;
        private System.Windows.Forms.Label lblLowStockBadge;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlUpdateStock;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblNewQty;
        private System.Windows.Forms.Label lblSelectedIng;
        private System.Windows.Forms.Label lblCard4Value;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblCard4Sub;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblCard3Sub;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard2Sub;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Label lblCard1Sub;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.TextBox txtSelectedIng;
        private System.Windows.Forms.TextBox txtNewQty;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.Label lblStatusMiddle;
        private System.Windows.Forms.Label lblStatusRight;
        private System.Windows.Forms.Label lblStatusLeft;
    }
}