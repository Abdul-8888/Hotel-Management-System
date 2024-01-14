namespace HMS_v1
{
    partial class CustomerFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFood));
            customerOrderPnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            customerOrderGrid = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnOrder = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblQuantity = new Label();
            quantityUpDown = new NumericUpDown();
            Column1 = new DataGridViewButtonColumn();
            customerOrderPnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerOrderGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).BeginInit();
            SuspendLayout();
            // 
            // customerOrderPnl
            // 
            customerOrderPnl.BackColor = Color.Transparent;
            customerOrderPnl.ColumnCount = 2;
            customerOrderPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.67089F));
            customerOrderPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.32912F));
            customerOrderPnl.Controls.Add(sideBarPnl, 0, 0);
            customerOrderPnl.Controls.Add(detailsPanel, 1, 0);
            customerOrderPnl.Dock = DockStyle.Fill;
            customerOrderPnl.Location = new Point(0, 0);
            customerOrderPnl.Margin = new Padding(0);
            customerOrderPnl.Name = "customerOrderPnl";
            customerOrderPnl.RowCount = 1;
            customerOrderPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6975F));
            customerOrderPnl.Size = new Size(1262, 737);
            customerOrderPnl.TabIndex = 6;
            // 
            // sideBarPnl
            // 
            sideBarPnl.BackColor = Color.Transparent;
            sideBarPnl.ColumnCount = 1;
            sideBarPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideBarPnl.Controls.Add(logoPictureBox, 0, 0);
            sideBarPnl.Controls.Add(btnHome, 0, 1);
            sideBarPnl.Dock = DockStyle.Fill;
            sideBarPnl.Location = new Point(0, 0);
            sideBarPnl.Margin = new Padding(0);
            sideBarPnl.Name = "sideBarPnl";
            sideBarPnl.RowCount = 6;
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 24.7331F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10.32028F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.430605F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.252669F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.964413F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 36.29893F));
            sideBarPnl.Size = new Size(235, 737);
            sideBarPnl.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(5, 4);
            logoPictureBox.Margin = new Padding(5, 4, 5, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(225, 174);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Black;
            btnHome.Location = new Point(0, 182);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(235, 76);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // detailsPanel
            // 
            detailsPanel.ColumnCount = 1;
            detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsPanel.Controls.Add(header, 0, 0);
            detailsPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            detailsPanel.Dock = DockStyle.Fill;
            detailsPanel.Location = new Point(235, 0);
            detailsPanel.Margin = new Padding(0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.RowCount = 2;
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.94511F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.05489F));
            detailsPanel.Size = new Size(1027, 737);
            detailsPanel.TabIndex = 1;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(425, 44);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(177, 35);
            header.TabIndex = 2;
            header.Text = "Order Food";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.68482F));
            tableLayoutPanel2.Controls.Add(customerOrderGrid, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 124);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tableLayoutPanel2.Size = new Size(1027, 613);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // customerOrderGrid
            // 
            customerOrderGrid.AllowUserToAddRows = false;
            customerOrderGrid.AllowUserToDeleteRows = false;
            customerOrderGrid.Anchor = AnchorStyles.None;
            customerOrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerOrderGrid.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            customerOrderGrid.Location = new Point(14, 16);
            customerOrderGrid.Margin = new Padding(14, 16, 14, 16);
            customerOrderGrid.Name = "customerOrderGrid";
            customerOrderGrid.ReadOnly = true;
            customerOrderGrid.RowHeadersWidth = 51;
            customerOrderGrid.Size = new Size(999, 446);
            customerOrderGrid.TabIndex = 1;
            customerOrderGrid.CellContentClick += customerOrderGrid_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.86996F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.13004F));
            tableLayoutPanel1.Controls.Add(btnOrder, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 478);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1027, 135);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnOrder
            // 
            btnOrder.Anchor = AnchorStyles.None;
            btnOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(746, 39);
            btnOrder.Margin = new Padding(5, 4, 57, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(128, 56);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblQuantity, 0, 0);
            tableLayoutPanel3.Controls.Add(quantityUpDown, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(645, 135);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.None;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantity.Location = new Point(119, 56);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(83, 23);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity";
            // 
            // quantityUpDown
            // 
            quantityUpDown.Anchor = AnchorStyles.None;
            quantityUpDown.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantityUpDown.Location = new Point(403, 52);
            quantityUpDown.Margin = new Padding(5, 4, 5, 4);
            quantityUpDown.Name = "quantityUpDown";
            quantityUpDown.Size = new Size(160, 30);
            quantityUpDown.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Text = "Order";
            Column1.UseColumnTextForButtonValue = true;
            Column1.Width = 125;
            // 
            // CustomerFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 737);
            Controls.Add(customerOrderPnl);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 784);
            Name = "CustomerFood";
            Text = "CustomerFood";
            Load += CustomerFood_Load;
            customerOrderPnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerOrderGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel customerOrderPnl;
        private TableLayoutPanel sideBarPnl;
        private PictureBox logoPictureBox;
        private Button btnHome;
        private TableLayoutPanel detailsPanel;
        private Label header;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView customerOrderGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnOrder;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblQuantity;
        private NumericUpDown quantityUpDown;
        private DataGridViewButtonColumn Column1;
    }
}