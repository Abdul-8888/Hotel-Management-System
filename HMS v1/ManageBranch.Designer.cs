namespace HMS_v1
{
    partial class ManageBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBranch));
            manageEmployeesPnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            branchGrid = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewButtonColumn();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnUpdate = new Button();
            btnInsert = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            manageEmployeesPnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)branchGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // manageEmployeesPnl
            // 
            manageEmployeesPnl.BackColor = Color.Transparent;
            manageEmployeesPnl.ColumnCount = 2;
            manageEmployeesPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.67089F));
            manageEmployeesPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.32912F));
            manageEmployeesPnl.Controls.Add(sideBarPnl, 0, 0);
            manageEmployeesPnl.Controls.Add(detailsPanel, 1, 0);
            manageEmployeesPnl.Dock = DockStyle.Fill;
            manageEmployeesPnl.Location = new Point(0, 0);
            manageEmployeesPnl.Margin = new Padding(0);
            manageEmployeesPnl.Name = "manageEmployeesPnl";
            manageEmployeesPnl.RowCount = 1;
            manageEmployeesPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6975F));
            manageEmployeesPnl.Size = new Size(1445, 908);
            manageEmployeesPnl.TabIndex = 1;
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 22.32012F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.104259F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 17.03377F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 17.91483F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            sideBarPnl.Size = new Size(269, 908);
            sideBarPnl.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(5, 5);
            logoPictureBox.Margin = new Padding(5);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(259, 193);
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
            btnHome.Location = new Point(0, 203);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(269, 82);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // detailsPanel
            // 
            detailsPanel.ColumnCount = 1;
            detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsPanel.Controls.Add(branchGrid, 0, 2);
            detailsPanel.Controls.Add(header, 0, 0);
            detailsPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            detailsPanel.Dock = DockStyle.Fill;
            detailsPanel.Location = new Point(269, 0);
            detailsPanel.Margin = new Padding(0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.RowCount = 3;
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.01831F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.9817F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 373F));
            detailsPanel.Size = new Size(1176, 908);
            detailsPanel.TabIndex = 1;
            // 
            // branchGrid
            // 
            branchGrid.AllowUserToAddRows = false;
            branchGrid.AllowUserToDeleteRows = false;
            branchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            branchGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            branchGrid.Dock = DockStyle.Fill;
            branchGrid.Location = new Point(13, 549);
            branchGrid.Margin = new Padding(13, 15, 13, 15);
            branchGrid.Name = "branchGrid";
            branchGrid.ReadOnly = true;
            branchGrid.RowHeadersWidth = 51;
            branchGrid.Size = new Size(1150, 344);
            branchGrid.TabIndex = 1;
            branchGrid.CellContentClick += branchGrid_CellContentClick;
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
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(469, 25);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(238, 35);
            header.TabIndex = 2;
            header.Text = "Manage Branch";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.68482F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.31518F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 85);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1176, 449);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel4.Controls.Add(btnInsert, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(977, 5);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(194, 439);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(29, 293);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 71);
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
            btnInsert.Location = new Point(29, 74);
            btnInsert.Margin = new Padding(5);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(135, 71);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtName, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtCity, 1, 1);
            tableLayoutPanel3.Controls.Add(txtCountry, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Size = new Size(972, 449);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 63);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(491, 57);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(407, 35);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(221, 212);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 2;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 362);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 3;
            label3.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left;
            txtCity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(491, 206);
            txtCity.Margin = new Padding(5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(407, 35);
            txtCity.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.Left;
            txtCountry.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(491, 356);
            txtCountry.Margin = new Padding(5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(407, 35);
            txtCountry.TabIndex = 10;
            // 
            // ManageBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(manageEmployeesPnl);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 784);
            Name = "ManageBranch";
            Text = "ManageBranch";
            Load += ManageBranch_Load;
            manageEmployeesPnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)branchGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel manageEmployeesPnl;
        private TableLayoutPanel sideBarPnl;
        private PictureBox logoPictureBox;
        private Button btnHome;
        private TableLayoutPanel detailsPanel;
        private DataGridView branchGrid;
        private Label header;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnUpdate;
        private Button btnInsert;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtCity;
        private TextBox txtCountry;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
    }
}