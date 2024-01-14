namespace HMS_v1
{
    partial class ManageServicePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageServicePage));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ManageServicePnl = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pbLogo = new PictureBox();
            sideMenuPanel = new TableLayoutPanel();
            btnHome = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            ServiceGrid = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewButtonColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnUpdate = new Button();
            btnInsert = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCost = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ManageServicePnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            sideMenuPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceGrid).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 115);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(180, 222);
            dataGridView1.TabIndex = 1;
            // 
            // ManageServicePnl
            // 
            ManageServicePnl.BackColor = Color.Transparent;
            ManageServicePnl.ColumnCount = 2;
            ManageServicePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1458F));
            ManageServicePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.8542F));
            ManageServicePnl.Controls.Add(tableLayoutPanel2, 0, 0);
            ManageServicePnl.Controls.Add(tableLayoutPanel3, 1, 0);
            ManageServicePnl.Dock = DockStyle.Fill;
            ManageServicePnl.Location = new Point(0, 0);
            ManageServicePnl.Margin = new Padding(0);
            ManageServicePnl.Name = "ManageServicePnl";
            ManageServicePnl.RowCount = 1;
            ManageServicePnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ManageServicePnl.Size = new Size(1262, 673);
            ManageServicePnl.TabIndex = 2;
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
            sideMenuPanel.Controls.Add(button1, 0, 1);
            sideMenuPanel.Controls.Add(button2, 0, 2);
            sideMenuPanel.Controls.Add(button3, 0, 3);
            sideMenuPanel.Controls.Add(button4, 0, 4);
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
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 62);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(229, 64);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 126);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(229, 66);
            button2.TabIndex = 2;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(0, 192);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(229, 61);
            button3.TabIndex = 3;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(0, 253);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(229, 66);
            button4.TabIndex = 4;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(ServiceGrid, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(229, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 17.53343F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35.80981F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 46.65676F));
            tableLayoutPanel3.Size = new Size(1033, 673);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(359, 41);
            label2.Name = "label2";
            label2.Size = new Size(314, 35);
            label2.TabIndex = 0;
            label2.Text = "Service Management";
            // 
            // ServiceGrid
            // 
            ServiceGrid.AllowUserToAddRows = false;
            ServiceGrid.AllowUserToDeleteRows = false;
            ServiceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            ServiceGrid.Dock = DockStyle.Fill;
            ServiceGrid.Location = new Point(10, 369);
            ServiceGrid.Margin = new Padding(10, 11, 10, 11);
            ServiceGrid.Name = "ServiceGrid";
            ServiceGrid.ReadOnly = true;
            ServiceGrid.RowHeadersWidth = 51;
            ServiceGrid.RowTemplate.Height = 29;
            ServiceGrid.Size = new Size(1013, 293);
            ServiceGrid.TabIndex = 1;
            ServiceGrid.CellContentClick += ServiceGrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
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
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            Column2.Text = "Delete";
            Column2.UseColumnTextForButtonValue = true;
            Column2.Width = 125;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.49564F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.69119F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.71636F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 117);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1033, 241);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel5.Controls.Add(btnInsert, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(818, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(215, 241);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(38, 151);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 59);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(38, 30);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(139, 59);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label4, 0, 1);
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(371, 235);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(txtCost, 0, 1);
            tableLayoutPanel7.Controls.Add(txtName, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(380, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(435, 235);
            tableLayoutPanel7.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(154, 45);
            label3.Name = "label3";
            label3.Size = new Size(63, 27);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(158, 162);
            label4.Name = "label4";
            label4.Size = new Size(54, 27);
            label4.TabIndex = 1;
            label4.Text = "Cost";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(3, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(429, 34);
            txtName.TabIndex = 0;
            // 
            // txtCost
            // 
            txtCost.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCost.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCost.Location = new Point(3, 159);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(429, 34);
            txtCost.TabIndex = 1;
            // 
            // ManageServicePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(ManageServicePnl);
            MinimumSize = new Size(1000, 598);
            Name = "ManageServicePage";
            Text = "ManageServicePage";
            Load += ManageServicePage_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ManageServicePnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            sideMenuPanel.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceGrid).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel ManageServicePnl;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pbLogo;
        private TableLayoutPanel sideMenuPanel;
        private Button btnHome;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private DataGridView ServiceGrid;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnInsert;
        private Button btnUpdate;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtCost;
    }
}