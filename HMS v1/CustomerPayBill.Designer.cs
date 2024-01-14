namespace HMS_v1
{
    partial class CustomerPayBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPayBill));
            customerServicePnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            payBillGrid = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAccount = new TextBox();
            cmdMethod = new ComboBox();
            btnPay = new Button();
            customerServicePnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payBillGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customerServicePnl
            // 
            customerServicePnl.BackColor = Color.Transparent;
            customerServicePnl.ColumnCount = 2;
            customerServicePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.67089F));
            customerServicePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.32912F));
            customerServicePnl.Controls.Add(sideBarPnl, 0, 0);
            customerServicePnl.Controls.Add(detailsPanel, 1, 0);
            customerServicePnl.Dock = DockStyle.Fill;
            customerServicePnl.Location = new Point(0, 0);
            customerServicePnl.Margin = new Padding(0);
            customerServicePnl.Name = "customerServicePnl";
            customerServicePnl.RowCount = 1;
            customerServicePnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6975F));
            customerServicePnl.Size = new Size(1370, 749);
            customerServicePnl.TabIndex = 6;
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20.81851F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 11.92171F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 11.74377F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 11.56584F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 11.56584F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 32.38434F));
            sideBarPnl.Size = new Size(255, 749);
            sideBarPnl.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(5, 4);
            logoPictureBox.Margin = new Padding(5, 4, 5, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(245, 147);
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
            btnHome.Location = new Point(0, 155);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(255, 89);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // detailsPanel
            // 
            detailsPanel.ColumnCount = 1;
            detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            detailsPanel.Controls.Add(header, 0, 0);
            detailsPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            detailsPanel.Controls.Add(tableLayoutPanel1, 0, 2);
            detailsPanel.Dock = DockStyle.Fill;
            detailsPanel.Location = new Point(255, 0);
            detailsPanel.Margin = new Padding(0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.RowCount = 3;
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.29674F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60.7476654F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.037384F));
            detailsPanel.Size = new Size(1115, 749);
            detailsPanel.TabIndex = 1;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(431, 24);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(252, 35);
            header.TabIndex = 2;
            header.Text = "Customer Billing";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.68482F));
            tableLayoutPanel2.Controls.Add(payBillGrid, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 84);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1115, 454);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // payBillGrid
            // 
            payBillGrid.AllowUserToAddRows = false;
            payBillGrid.AllowUserToDeleteRows = false;
            payBillGrid.Anchor = AnchorStyles.None;
            payBillGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payBillGrid.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            payBillGrid.Location = new Point(14, 16);
            payBillGrid.Margin = new Padding(14, 16, 14, 16);
            payBillGrid.Name = "payBillGrid";
            payBillGrid.ReadOnly = true;
            payBillGrid.RowHeadersWidth = 51;
            payBillGrid.Size = new Size(1087, 422);
            payBillGrid.TabIndex = 1;
            payBillGrid.CellContentClick += payBillGrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Text = "Pay";
            Column1.UseColumnTextForButtonValue = true;
            Column1.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.7219734F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1748886F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0134525F));
            tableLayoutPanel1.Controls.Add(txtAccount, 0, 0);
            tableLayoutPanel1.Controls.Add(cmdMethod, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPay, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 538);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1115, 211);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtAccount
            // 
            txtAccount.Anchor = AnchorStyles.None;
            txtAccount.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.Location = new Point(67, 90);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(464, 30);
            txtAccount.TabIndex = 0;
            // 
            // cmdMethod
            // 
            cmdMethod.Anchor = AnchorStyles.Left;
            cmdMethod.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdMethod.FormattingEnabled = true;
            cmdMethod.Location = new Point(602, 89);
            cmdMethod.Name = "cmdMethod";
            cmdMethod.Size = new Size(249, 32);
            cmdMethod.TabIndex = 1;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Left;
            btnPay.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPay.Location = new Point(905, 76);
            btnPay.Margin = new Padding(3, 0, 0, 0);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(137, 59);
            btnPay.TabIndex = 2;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // CustomerPayBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(customerServicePnl);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 723);
            Name = "CustomerPayBill";
            Text = "CustomerPayBill";
            Load += CustomerPayBill_Load_1;
            customerServicePnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payBillGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel customerServicePnl;
        private TableLayoutPanel sideBarPnl;
        private PictureBox logoPictureBox;
        private Button btnHome;
        private TableLayoutPanel detailsPanel;
        private Label header;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView payBillGrid;
        private DataGridViewButtonColumn Column1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtAccount;
        private ComboBox cmdMethod;
        private Button btnPay;
    }
}