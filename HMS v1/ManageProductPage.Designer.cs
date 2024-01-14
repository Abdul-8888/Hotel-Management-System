namespace HMS_v1
{
    partial class ManageProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductPage));
            ManageProductPnl = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ProductGrid = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewButtonColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            cmbType = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnUpdate = new Button();
            btnInsert = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            pbLogo = new PictureBox();
            sideMenuPanel = new TableLayoutPanel();
            btnHome = new Button();
            ManageProductPnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGrid).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            sideMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ManageProductPnl
            // 
            ManageProductPnl.BackColor = Color.Transparent;
            ManageProductPnl.ColumnCount = 2;
            ManageProductPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1458F));
            ManageProductPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.8542F));
            ManageProductPnl.Controls.Add(tableLayoutPanel1, 0, 0);
            ManageProductPnl.Controls.Add(tableLayoutPanel2, 0, 0);
            ManageProductPnl.Dock = DockStyle.Fill;
            ManageProductPnl.Location = new Point(0, 0);
            ManageProductPnl.Margin = new Padding(0);
            ManageProductPnl.Name = "ManageProductPnl";
            ManageProductPnl.RowCount = 1;
            ManageProductPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ManageProductPnl.Size = new Size(1262, 673);
            ManageProductPnl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(ProductGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(229, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7224F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.10725F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.01262F));
            tableLayoutPanel1.Size = new Size(1033, 673);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 28);
            label1.Name = "label1";
            label1.Size = new Size(319, 35);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // ProductGrid
            // 
            ProductGrid.AllowUserToAddRows = false;
            ProductGrid.AllowUserToDeleteRows = false;
            ProductGrid.BackgroundColor = SystemColors.ActiveBorder;
            ProductGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            ProductGrid.Dock = DockStyle.Fill;
            ProductGrid.GridColor = SystemColors.ActiveBorder;
            ProductGrid.Location = new Point(10, 427);
            ProductGrid.Margin = new Padding(10, 11, 10, 11);
            ProductGrid.Name = "ProductGrid";
            ProductGrid.ReadOnly = true;
            ProductGrid.RowHeadersWidth = 51;
            ProductGrid.RowTemplate.Height = 29;
            ProductGrid.Size = new Size(1013, 235);
            ProductGrid.TabIndex = 1;
            ProductGrid.CellContentClick += ProductGrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Text = "Edit";
            Column1.UseColumnTextForButtonValue = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Text = "Delete";
            Column2.UseColumnTextForButtonValue = true;
            Column2.Width = 125;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.67183F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.32817F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 92);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1033, 324);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(txtPrice, 1, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(txtName, 1, 0);
            tableLayoutPanel4.Controls.Add(label6, 0, 2);
            tableLayoutPanel4.Controls.Add(cmbType, 1, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.Size = new Size(854, 324);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(430, 145);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(356, 34);
            txtPrice.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 42);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 150);
            label3.Margin = new Padding(30, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 1;
            label3.Text = "Unit Price";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(430, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 34);
            txtName.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(185, 258);
            label6.Margin = new Padding(0, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 4;
            label6.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Left;
            cmbType.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(430, 253);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(356, 34);
            cmbType.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel5.Controls.Add(btnInsert, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(854, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 49.38272F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.61728F));
            tableLayoutPanel5.Size = new Size(179, 324);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(20, 212);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 59);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(20, 50);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(139, 59);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pbLogo, 0, 0);
            tableLayoutPanel2.Controls.Add(sideMenuPanel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.81426F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.18574F));
            tableLayoutPanel2.Size = new Size(229, 673);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Dock = DockStyle.Fill;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 0);
            pbLogo.Margin = new Padding(0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(229, 166);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.ColumnCount = 1;
            sideMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideMenuPanel.Controls.Add(btnHome, 0, 0);
            sideMenuPanel.Dock = DockStyle.Fill;
            sideMenuPanel.Location = new Point(0, 166);
            sideMenuPanel.Margin = new Padding(0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.RowCount = 6;
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.25296F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.64822F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.04348F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.05534F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.04348F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 36.95652F));
            sideMenuPanel.Size = new Size(229, 507);
            sideMenuPanel.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(229, 62);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // ManageProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(ManageProductPnl);
            MinimumSize = new Size(1000, 598);
            Name = "ManageProductPage";
            Text = "ManageProductPage";
            Load += ManageProductPage_Load_1;
            ManageProductPnl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGrid).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            sideMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ManageProductPnl;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pbLogo;
        private TableLayoutPanel sideMenuPanel;
        private Button btnHome;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView ProductGrid;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnInsert;
        private Button btnUpdate;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbType;
    }
}