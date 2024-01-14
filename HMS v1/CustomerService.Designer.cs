namespace HMS_v1
{
    partial class CustomerService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerService));
            customerServicePnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            customerServiceGrid = new DataGridView();
            btnAvail = new Button();
            customerServicePnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerServiceGrid).BeginInit();
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
            customerServicePnl.TabIndex = 5;
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 22.59786F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10.49822F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
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
            logoPictureBox.Size = new Size(245, 161);
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
            btnHome.Location = new Point(0, 169);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(255, 78);
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
            header.Location = new Point(422, 45);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(271, 35);
            header.TabIndex = 2;
            header.Text = "Customer Service";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.68482F));
            tableLayoutPanel2.Controls.Add(customerServiceGrid, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAvail, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 126);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel2.Size = new Size(1115, 623);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // customerServiceGrid
            // 
            customerServiceGrid.Anchor = AnchorStyles.None;
            customerServiceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerServiceGrid.Location = new Point(14, 16);
            customerServiceGrid.Margin = new Padding(14, 16, 14, 16);
            customerServiceGrid.Name = "customerServiceGrid";
            customerServiceGrid.RowHeadersWidth = 51;
            customerServiceGrid.Size = new Size(1087, 481);
            customerServiceGrid.TabIndex = 1;
            customerServiceGrid.CellContentClick += customerServiceGrid_CellContentClick;
            // 
            // btnAvail
            // 
            btnAvail.Anchor = AnchorStyles.Right;
            btnAvail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAvail.Location = new Point(930, 540);
            btnAvail.Margin = new Padding(5, 4, 57, 4);
            btnAvail.Name = "btnAvail";
            btnAvail.Size = new Size(128, 56);
            btnAvail.TabIndex = 3;
            btnAvail.Text = "Avail";
            btnAvail.UseVisualStyleBackColor = true;
            btnAvail.Click += btnAvail_Click;
            // 
            // CustomerService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(customerServicePnl);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1140, 723);
            Name = "CustomerService";
            Text = "CustomerService";
            Load += CustomerService_Load_1;
            customerServicePnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerServiceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customerServicePnl;
        private System.Windows.Forms.TableLayoutPanel sideBarPnl;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TableLayoutPanel detailsPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView customerServiceGrid;
        private Button btnAvail;
    }
}