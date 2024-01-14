namespace HMS_v1
{
    partial class StaffDashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboardPage));
            StaffDashboardPanel = new TableLayoutPanel();
            sideMenuPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSettings = new Button();
            btnHome = new Button();
            notificationPanel = new TableLayoutPanel();
            label1 = new Label();
            Notifications = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            WorkAreaPanel = new Panel();
            StaffDashboardPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            notificationPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // StaffDashboardPanel
            // 
            StaffDashboardPanel.BackColor = Color.Transparent;
            StaffDashboardPanel.ColumnCount = 3;
            StaffDashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.77971F));
            StaffDashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.28209F));
            StaffDashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.93819F));
            StaffDashboardPanel.Controls.Add(sideMenuPanel, 0, 0);
            StaffDashboardPanel.Controls.Add(notificationPanel, 2, 0);
            StaffDashboardPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            StaffDashboardPanel.Dock = DockStyle.Fill;
            StaffDashboardPanel.Location = new Point(0, 0);
            StaffDashboardPanel.Margin = new Padding(0);
            StaffDashboardPanel.Name = "StaffDashboardPanel";
            StaffDashboardPanel.RowCount = 1;
            StaffDashboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9792F));
            StaffDashboardPanel.Size = new Size(1262, 673);
            StaffDashboardPanel.TabIndex = 0;
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
            sideMenuPanel.RowCount = 3;
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.30739F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.69261F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 329F));
            sideMenuPanel.Size = new Size(236, 673);
            sideMenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnSettings, 0, 1);
            tableLayoutPanel2.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 183);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.52381F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.47619F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.Size = new Size(235, 160);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Location = new Point(0, 79);
            btnSettings.Margin = new Padding(0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(235, 81);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(235, 79);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // notificationPanel
            // 
            notificationPanel.ColumnCount = 1;
            notificationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            notificationPanel.Controls.Add(label1, 0, 0);
            notificationPanel.Controls.Add(Notifications, 0, 1);
            notificationPanel.Dock = DockStyle.Fill;
            notificationPanel.Location = new Point(1022, 0);
            notificationPanel.Margin = new Padding(0);
            notificationPanel.Name = "notificationPanel";
            notificationPanel.RowCount = 2;
            notificationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.280832F));
            notificationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.71917F));
            notificationPanel.Size = new Size(240, 673);
            notificationPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(41, 10);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 0;
            label1.Text = "Notifications";
            // 
            // Notifications
            // 
            Notifications.AutoScroll = true;
            Notifications.Dock = DockStyle.Fill;
            Notifications.Location = new Point(0, 49);
            Notifications.Margin = new Padding(0);
            Notifications.Name = "Notifications";
            Notifications.Size = new Size(240, 624);
            Notifications.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(WorkAreaPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(236, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.280832F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.71917F));
            tableLayoutPanel1.Size = new Size(786, 673);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(326, 10);
            label2.Name = "label2";
            label2.Size = new Size(134, 29);
            label2.TabIndex = 1;
            label2.Text = "Work Area";
            // 
            // WorkAreaPanel
            // 
            WorkAreaPanel.AutoScroll = true;
            WorkAreaPanel.Dock = DockStyle.Fill;
            WorkAreaPanel.Location = new Point(0, 49);
            WorkAreaPanel.Margin = new Padding(0);
            WorkAreaPanel.Name = "WorkAreaPanel";
            WorkAreaPanel.Size = new Size(786, 624);
            WorkAreaPanel.TabIndex = 2;
            // 
            // StaffDashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(StaffDashboardPanel);
            MinimumSize = new Size(1000, 598);
            Name = "StaffDashboardPage";
            Text = "StaffDashboardPage";
            Load += StaffDashboardPage_Load_2;
            StaffDashboardPanel.ResumeLayout(false);
            sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            notificationPanel.ResumeLayout(false);
            notificationPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel StaffDashboardPanel;
        private TableLayoutPanel sideMenuPanel;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel notificationPanel;
        private Label label1;
        private Panel Notifications;
        private Button btnHome;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Panel WorkAreaPanel;
        private Button btnSettings;
    }
}