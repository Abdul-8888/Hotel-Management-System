namespace HMS_v1
{
    partial class CustomerRoomBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRoomBooking));
            customerOrderPnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            customerRoomBGrid = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBook = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            toDateTime = new DateTimePicker();
            lblQuantity = new Label();
            label1 = new Label();
            fromDateTime = new DateTimePicker();
            Column1 = new DataGridViewButtonColumn();
            customerOrderPnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerRoomBGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            customerOrderPnl.Size = new Size(1370, 749);
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 27.04626F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.430605F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10.32028F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.608541F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.786477F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.80783F));
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
            logoPictureBox.Size = new Size(245, 194);
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
            btnHome.Location = new Point(0, 202);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(255, 70);
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
            detailsPanel.Location = new Point(255, 0);
            detailsPanel.Margin = new Padding(0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.RowCount = 2;
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.94511F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.05489F));
            detailsPanel.Size = new Size(1115, 749);
            detailsPanel.TabIndex = 1;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(445, 45);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(225, 35);
            header.TabIndex = 2;
            header.Text = "Room Booking";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.68482F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(customerRoomBGrid, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 126);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tableLayoutPanel2.Size = new Size(1115, 623);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // customerRoomBGrid
            // 
            customerRoomBGrid.AllowUserToAddRows = false;
            customerRoomBGrid.AllowUserToDeleteRows = false;
            customerRoomBGrid.Anchor = AnchorStyles.None;
            customerRoomBGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerRoomBGrid.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            customerRoomBGrid.Location = new Point(14, 16);
            customerRoomBGrid.Margin = new Padding(14, 16, 14, 16);
            customerRoomBGrid.Name = "customerRoomBGrid";
            customerRoomBGrid.ReadOnly = true;
            customerRoomBGrid.RowHeadersWidth = 51;
            customerRoomBGrid.Size = new Size(1087, 456);
            customerRoomBGrid.TabIndex = 1;
            customerRoomBGrid.CellContentClick += customerRoomBGrid_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.9144F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0856F));
            tableLayoutPanel1.Controls.Add(btnBook, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 488);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1115, 135);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.None;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBook.Location = new Point(862, 39);
            btnBook.Margin = new Padding(5, 4, 57, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(128, 56);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
            tableLayoutPanel3.Controls.Add(toDateTime, 3, 0);
            tableLayoutPanel3.Controls.Add(lblQuantity, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 2, 0);
            tableLayoutPanel3.Controls.Add(fromDateTime, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(790, 135);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // toDateTime
            // 
            toDateTime.Anchor = AnchorStyles.None;
            toDateTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toDateTime.Location = new Point(589, 52);
            toDateTime.Margin = new Padding(3, 4, 3, 4);
            toDateTime.Name = "toDateTime";
            toDateTime.Size = new Size(196, 30);
            toDateTime.TabIndex = 3;
            toDateTime.Value = new DateTime(2023, 4, 20, 0, 0, 0, 0);
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.None;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantity.Location = new Point(64, 56);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(62, 23);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "From:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(464, 56);
            label1.Name = "label1";
            label1.Size = new Size(37, 23);
            label1.TabIndex = 1;
            label1.Text = "To:";
            // 
            // fromDateTime
            // 
            fromDateTime.Anchor = AnchorStyles.None;
            fromDateTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fromDateTime.Location = new Point(194, 52);
            fromDateTime.Margin = new Padding(3, 4, 3, 4);
            fromDateTime.Name = "fromDateTime";
            fromDateTime.Size = new Size(185, 30);
            fromDateTime.TabIndex = 2;
            fromDateTime.Value = new DateTime(2023, 4, 20, 0, 0, 0, 0);
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Text = "Choose";
            Column1.UseColumnTextForButtonValue = true;
            Column1.Width = 125;
            // 
            // CustomerRoomBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(customerOrderPnl);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 723);
            Name = "CustomerRoomBooking";
            Text = "CustomerRoomBooking";
            Load += CustomerRoomBooking_Load_1;
            customerOrderPnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerRoomBGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private DataGridView customerRoomBGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBook;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblQuantity;
        private DateTimePicker toDateTime;
        private Label label1;
        private DateTimePicker fromDateTime;
        private DataGridViewButtonColumn Column1;
    }
}