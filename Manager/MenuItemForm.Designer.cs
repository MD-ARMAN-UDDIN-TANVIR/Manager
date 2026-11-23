namespace Manager
{
    partial class MenuItemsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblMenuSubtitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEditPanel = new System.Windows.Forms.Panel();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.lblStatusMiddle = new System.Windows.Forms.Label();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.pnlEditPanel.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.pnlTopBar.Controls.Add(this.lblMenuSubtitle);
            this.pnlTopBar.Controls.Add(this.lblMenuTitle);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1084, 60);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(160)))), ((int)(((byte)(69)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(15, 10);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(200, 25);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "🍽️ Menu Management";
            // 
            // lblMenuSubtitle
            // 
            this.lblMenuSubtitle.AutoSize = true;
            this.lblMenuSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMenuSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblMenuSubtitle.Location = new System.Drawing.Point(18, 40);
            this.lblMenuSubtitle.Name = "lblMenuSubtitle";
            this.lblMenuSubtitle.Size = new System.Drawing.Size(160, 13);
            this.lblMenuSubtitle.TabIndex = 1;
            this.lblMenuSubtitle.Text = "Manage menu items and pricing";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlMainContent.Controls.Add(this.pnlToolbar);
            this.pnlMainContent.Controls.Add(this.dgvMenuItems);
            this.pnlMainContent.Controls.Add(this.pnlEditPanel);
            this.pnlMainContent.Controls.Add(this.pnlStatusBar);
            this.pnlMainContent.Location = new System.Drawing.Point(0, 60);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1084, 601);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.btnUpdate);
            this.pnlToolbar.Controls.Add(this.btnRemove);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Location = new System.Drawing.Point(20, 15);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1044, 55);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+ Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(140, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "🖍️ Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRemove.Location = new System.Drawing.Point(270, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "🗑 Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(400, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "↺ Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowUserToAddRows = false;
            this.dgvMenuItems.AllowUserToDeleteRows = false;
            this.dgvMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colItemName,
            this.colCategory,
            this.colPrice,
            this.colAvailable,
            this.colAction});
            this.dgvMenuItems.Location = new System.Drawing.Point(20, 85);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.RowHeadersVisible = false;
            this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuItems.Size = new System.Drawing.Size(1044, 280);
            this.dgvMenuItems.TabIndex = 1;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "#";
            this.colNo.Name = "colNo";
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price (RM)";
            this.colPrice.Name = "colPrice";
            // 
            // colAvailable
            // 
            this.colAvailable.HeaderText = "Available";
            this.colAvailable.Name = "colAvailable";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            // 
            // pnlEditPanel
            // 
            this.pnlEditPanel.BackColor = System.Drawing.Color.White;
            this.pnlEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditPanel.Controls.Add(this.lblEditTitle);
            this.pnlEditPanel.Controls.Add(this.lblItemName);
            this.pnlEditPanel.Controls.Add(this.txtItemName);
            this.pnlEditPanel.Controls.Add(this.lblCategory);
            this.pnlEditPanel.Controls.Add(this.txtCategory);
            this.pnlEditPanel.Controls.Add(this.lblPrice);
            this.pnlEditPanel.Controls.Add(this.txtPrice);
            this.pnlEditPanel.Controls.Add(this.lblAvailable);
            this.pnlEditPanel.Controls.Add(this.txtAvailable);
            this.pnlEditPanel.Controls.Add(this.btnSave);
            this.pnlEditPanel.Controls.Add(this.btnCancel);
            this.pnlEditPanel.Location = new System.Drawing.Point(20, 380);
            this.pnlEditPanel.Name = "pnlEditPanel";
            this.pnlEditPanel.Size = new System.Drawing.Size(1044, 120);
            this.pnlEditPanel.TabIndex = 2;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblEditTitle.Location = new System.Drawing.Point(15, 10);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(150, 19);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "🍽️ Edit Menu Item";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblItemName.Location = new System.Drawing.Point(15, 40);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(60, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.txtItemName.Location = new System.Drawing.Point(15, 58);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(200, 23);
            this.txtItemName.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblCategory.Location = new System.Drawing.Point(230, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategory.Location = new System.Drawing.Point(230, 58);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(160, 23);
            this.txtCategory.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(405, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price (RM)";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(405, 58);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lblAvailable.Location = new System.Drawing.Point(540, 40);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(54, 13);
            this.lblAvailable.TabIndex = 7;
            this.lblAvailable.Text = "Available";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAvailable.Location = new System.Drawing.Point(540, 58);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(80, 23);
            this.txtAvailable.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(640, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(750, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.pnlStatusBar.Controls.Add(this.lblStatusLeft);
            this.pnlStatusBar.Controls.Add(this.lblStatusMiddle);
            this.pnlStatusBar.Controls.Add(this.lblStatusRight);
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 576);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(1084, 25);
            this.pnlStatusBar.TabIndex = 3;
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblStatusLeft.Location = new System.Drawing.Point(10, 5);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(80, 12);
            this.lblStatusLeft.TabIndex = 0;
            this.lblStatusLeft.Text = "✓ 0 items loaded";
            // 
            // lblStatusMiddle
            // 
            this.lblStatusMiddle.AutoSize = true;
            this.lblStatusMiddle.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStatusMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblStatusMiddle.Location = new System.Drawing.Point(430, 5);
            this.lblStatusMiddle.Name = "lblStatusMiddle";
            this.lblStatusMiddle.Size = new System.Drawing.Size(60, 12);
            this.lblStatusMiddle.TabIndex = 1;
            this.lblStatusMiddle.Text = "● Connected";
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.lblStatusRight.Location = new System.Drawing.Point(880, 5);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(100, 12);
            this.lblStatusRight.TabIndex = 2;
            this.lblStatusRight.Text = "Last updated: 23 Nov 2026";
            // 
            // MenuItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Management";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.pnlEditPanel.ResumeLayout(false);
            this.pnlEditPanel.PerformLayout();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.Load += new System.EventHandler(this.MenuItemsForm_Load);
            this.dgvMenuItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItems_CellClick);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblMenuSubtitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.Panel pnlEditPanel;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label lblStatusLeft;
        private System.Windows.Forms.Label lblStatusMiddle;
        private System.Windows.Forms.Label lblStatusRight;
    }
}