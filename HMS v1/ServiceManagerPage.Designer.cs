namespace HMS_v1
{
    partial class ServiceManagerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagerPage));
            ServiceManagerPanel = new TableLayoutPanel();
            notificationPanel = new TableLayoutPanel();
            label2 = new Label();
            Notifications = new Panel();
            WorkAreaPnl = new TableLayoutPanel();
            label1 = new Label();
            EmployeeGrid = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            sideMenuPnl = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            btnSettings = new Button();
            ServiceManagerPanel.SuspendLayout();
            notificationPanel.SuspendLayout();
            WorkAreaPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeGrid).BeginInit();
            sideMenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ServiceManagerPanel
            // 
            ServiceManagerPanel.BackColor = Color.Transparent;
            ServiceManagerPanel.ColumnCount = 3;
            ServiceManagerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.17591F));
            ServiceManagerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.01426F));
            ServiceManagerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.88906F));
            ServiceManagerPanel.Controls.Add(notificationPanel, 2, 0);
            ServiceManagerPanel.Controls.Add(WorkAreaPnl, 1, 0);
            ServiceManagerPanel.Controls.Add(sideMenuPnl, 0, 0);
            ServiceManagerPanel.Dock = DockStyle.Fill;
            ServiceManagerPanel.Location = new Point(0, 0);
            ServiceManagerPanel.Margin = new Padding(0);
            ServiceManagerPanel.Name = "ServiceManagerPanel";
            ServiceManagerPanel.RowCount = 1;
            ServiceManagerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ServiceManagerPanel.Size = new Size(1262, 673);
            ServiceManagerPanel.TabIndex = 0;
            // 
            // notificationPanel
            // 
            notificationPanel.BackColor = Color.Transparent;
            notificationPanel.ColumnCount = 1;
            notificationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            notificationPanel.Controls.Add(label2, 0, 0);
            notificationPanel.Controls.Add(Notifications, 0, 1);
            notificationPanel.Dock = DockStyle.Fill;
            notificationPanel.Location = new Point(1010, 0);
            notificationPanel.Margin = new Padding(0);
            notificationPanel.Name = "notificationPanel";
            notificationPanel.RowCount = 2;
            notificationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.915304F));
            notificationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 91.08469F));
            notificationPanel.Size = new Size(252, 673);
            notificationPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(53, 15);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(145, 29);
            label2.TabIndex = 0;
            label2.Text = "Notification";
            // 
            // Notifications
            // 
            Notifications.AutoScroll = true;
            Notifications.Dock = DockStyle.Fill;
            Notifications.Location = new Point(0, 60);
            Notifications.Margin = new Padding(0);
            Notifications.Name = "Notifications";
            Notifications.Size = new Size(252, 613);
            Notifications.TabIndex = 1;
            // 
            // WorkAreaPnl
            // 
            WorkAreaPnl.BackColor = Color.Transparent;
            WorkAreaPnl.ColumnCount = 1;
            WorkAreaPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            WorkAreaPnl.Controls.Add(label1, 0, 0);
            WorkAreaPnl.Controls.Add(EmployeeGrid, 0, 1);
            WorkAreaPnl.Dock = DockStyle.Fill;
            WorkAreaPnl.Location = new Point(241, 0);
            WorkAreaPnl.Margin = new Padding(0);
            WorkAreaPnl.Name = "WorkAreaPnl";
            WorkAreaPnl.RowCount = 2;
            WorkAreaPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 8.915304F));
            WorkAreaPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 91.08469F));
            WorkAreaPnl.Size = new Size(769, 673);
            WorkAreaPnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(317, 15);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 0;
            label1.Text = "Work Area";
            // 
            // EmployeeGrid
            // 
            EmployeeGrid.AllowUserToAddRows = false;
            EmployeeGrid.AllowUserToDeleteRows = false;
            EmployeeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeGrid.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            EmployeeGrid.Dock = DockStyle.Fill;
            EmployeeGrid.Location = new Point(30, 135);
            EmployeeGrid.Margin = new Padding(30, 75, 30, 75);
            EmployeeGrid.Name = "EmployeeGrid";
            EmployeeGrid.ReadOnly = true;
            EmployeeGrid.RowHeadersWidth = 51;
            EmployeeGrid.RowTemplate.Height = 29;
            EmployeeGrid.Size = new Size(709, 463);
            EmployeeGrid.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Text = "Assign";
            Column1.UseColumnTextForButtonValue = true;
            Column1.Width = 125;
            // 
            // sideMenuPnl
            // 
            sideMenuPnl.BackColor = Color.Transparent;
            sideMenuPnl.ColumnCount = 1;
            sideMenuPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideMenuPnl.Controls.Add(pictureBox1, 0, 0);
            sideMenuPnl.Controls.Add(btnHome, 0, 1);
            sideMenuPnl.Controls.Add(btnSettings, 0, 2);
            sideMenuPnl.Dock = DockStyle.Fill;
            sideMenuPnl.Location = new Point(0, 0);
            sideMenuPnl.Margin = new Padding(0);
            sideMenuPnl.Name = "sideMenuPnl";
            sideMenuPnl.RowCount = 4;
            sideMenuPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 58.44156F));
            sideMenuPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 21.42857F));
            sideMenuPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 19.64286F));
            sideMenuPnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 353F));
            sideMenuPnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            sideMenuPnl.Size = new Size(241, 673);
            sideMenuPnl.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(0, 187);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(241, 68);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Location = new Point(0, 255);
            btnSettings.Margin = new Padding(0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(241, 63);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // ServiceManagerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(ServiceManagerPanel);
            MinimumSize = new Size(1000, 598);
            Name = "ServiceManagerPage";
            Text = "ServiceManagerForm";
            Load += ServiceManagerPage_Load_1;
            ServiceManagerPanel.ResumeLayout(false);
            notificationPanel.ResumeLayout(false);
            notificationPanel.PerformLayout();
            WorkAreaPnl.ResumeLayout(false);
            WorkAreaPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeGrid).EndInit();
            sideMenuPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ServiceManagerPanel;
        private TableLayoutPanel notificationPanel;
        private TableLayoutPanel WorkAreaPnl;
        private TableLayoutPanel sideMenuPnl;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel Notifications;
        private Button btnHome;
        private DataGridView EmployeeGrid;
        private DataGridViewButtonColumn Column1;
        private Button btnSettings;
    }
}