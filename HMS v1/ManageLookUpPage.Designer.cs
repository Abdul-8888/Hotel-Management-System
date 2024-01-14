namespace HMS_v1
{
    partial class ManageLookUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLookUpPage));
            ManageLookUpPnl = new TableLayoutPanel();
            sideMenuPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHome = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            LookUpGrid = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtValue = new TextBox();
            label2 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            txtCategory = new TextBox();
            ManageLookUpPnl.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LookUpGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ManageLookUpPnl
            // 
            ManageLookUpPnl.ColumnCount = 2;
            ManageLookUpPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.62124F));
            ManageLookUpPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.37876F));
            ManageLookUpPnl.Controls.Add(sideMenuPanel, 0, 0);
            ManageLookUpPnl.Controls.Add(tableLayoutPanel3, 1, 0);
            ManageLookUpPnl.Dock = DockStyle.Fill;
            ManageLookUpPnl.Location = new Point(0, 0);
            ManageLookUpPnl.Margin = new Padding(0);
            ManageLookUpPnl.Name = "ManageLookUpPnl";
            ManageLookUpPnl.RowCount = 1;
            ManageLookUpPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ManageLookUpPnl.Size = new Size(1262, 673);
            ManageLookUpPnl.TabIndex = 0;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.ColumnCount = 1;
            sideMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sideMenuPanel.Controls.Add(pictureBox1, 0, 0);
            sideMenuPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            sideMenuPanel.Dock = DockStyle.Fill;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Margin = new Padding(0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.RowCount = 2;
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.59733F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 73.40267F));
            sideMenuPanel.Size = new Size(235, 673);
            sideMenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 179);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.62226F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.09434F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8248F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8248F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.50943F));
            tableLayoutPanel2.Size = new Size(235, 494);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(235, 71);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(LookUpGrid, 0, 2);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(235, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.79049F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.75334F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.45617F));
            tableLayoutPanel3.Size = new Size(1027, 673);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // LookUpGrid
            // 
            LookUpGrid.AllowUserToAddRows = false;
            LookUpGrid.AllowUserToDeleteRows = false;
            LookUpGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LookUpGrid.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            LookUpGrid.Dock = DockStyle.Fill;
            LookUpGrid.Location = new Point(10, 403);
            LookUpGrid.Margin = new Padding(10, 11, 10, 11);
            LookUpGrid.Name = "LookUpGrid";
            LookUpGrid.ReadOnly = true;
            LookUpGrid.RowHeadersWidth = 51;
            LookUpGrid.RowTemplate.Height = 29;
            LookUpGrid.Size = new Size(1007, 259);
            LookUpGrid.TabIndex = 0;
            LookUpGrid.CellContentClick += LookUpGrid_CellContentClick;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 38);
            label1.Name = "label1";
            label1.Size = new Size(317, 35);
            label1.TabIndex = 1;
            label1.Text = "LookUp Management";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.14635F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.60976F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2439F));
            tableLayoutPanel1.Controls.Add(txtValue, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnInsert, 2, 0);
            tableLayoutPanel1.Controls.Add(btnUpdate, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCategory, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 112);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1027, 280);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Left;
            txtValue.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtValue.Location = new Point(353, 193);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(367, 34);
            txtValue.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(153, 58);
            label2.Margin = new Padding(50, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(839, 38);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(145, 63);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(839, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 63);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(164, 198);
            label3.Margin = new Padding(40, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 3;
            label3.Text = "Value";
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Left;
            txtCategory.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(353, 53);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(367, 34);
            txtCategory.TabIndex = 4;
            // 
            // ManageLookUpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(ManageLookUpPnl);
            MinimumSize = new Size(1000, 598);
            Name = "ManageLookUpPage";
            Text = "ManageLookUpPage";
            Load += ManageLookUpPage_Load_1;
            ManageLookUpPnl.ResumeLayout(false);
            sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LookUpGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ManageLookUpPnl;
        private TableLayoutPanel sideMenuPanel;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnHome;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView LookUpGrid;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnInsert;
        private Button btnUpdate;
        private Label label2;
        private Label label3;
        private TextBox txtCategory;
        private TextBox txtValue;
        private DataGridViewButtonColumn Column1;
    }
}