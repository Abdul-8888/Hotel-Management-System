namespace HMS_v1
{
    partial class BranchManagerReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchManagerReportPage));
            BranchManagerReportPanel = new TableLayoutPanel();
            sideMenuPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            reportsPanel = new TableLayoutPanel();
            label1 = new Label();
            reportButtonPanel = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BranchManagerReportPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            reportsPanel.SuspendLayout();
            reportButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BranchManagerReportPanel
            // 
            BranchManagerReportPanel.ColumnCount = 2;
            BranchManagerReportPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1458F));
            BranchManagerReportPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.8542F));
            BranchManagerReportPanel.Controls.Add(sideMenuPanel, 0, 0);
            BranchManagerReportPanel.Controls.Add(reportsPanel, 1, 0);
            BranchManagerReportPanel.Dock = DockStyle.Fill;
            BranchManagerReportPanel.Location = new Point(0, 0);
            BranchManagerReportPanel.Margin = new Padding(0);
            BranchManagerReportPanel.Name = "BranchManagerReportPanel";
            BranchManagerReportPanel.RowCount = 1;
            BranchManagerReportPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BranchManagerReportPanel.Size = new Size(1262, 673);
            BranchManagerReportPanel.TabIndex = 0;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.ColumnCount = 1;
            sideMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideMenuPanel.Controls.Add(pictureBox1, 0, 0);
            sideMenuPanel.Controls.Add(btnHome, 0, 1);
            sideMenuPanel.Dock = DockStyle.Fill;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Margin = new Padding(0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.RowCount = 3;
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.51709F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10401F));
            sideMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 65.3789F));
            sideMenuPanel.Size = new Size(229, 673);
            sideMenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(0, 165);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(229, 67);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // reportsPanel
            // 
            reportsPanel.ColumnCount = 1;
            reportsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            reportsPanel.Controls.Add(label1, 0, 0);
            reportsPanel.Controls.Add(reportButtonPanel, 0, 1);
            reportsPanel.Dock = DockStyle.Fill;
            reportsPanel.Location = new Point(229, 0);
            reportsPanel.Margin = new Padding(0);
            reportsPanel.Name = "reportsPanel";
            reportsPanel.RowCount = 2;
            reportsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.07578F));
            reportsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.92422F));
            reportsPanel.Size = new Size(1033, 673);
            reportsPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(406, 29);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 0;
            label1.Text = "Generate Reports";
            // 
            // reportButtonPanel
            // 
            reportButtonPanel.ColumnCount = 2;
            reportButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            reportButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            reportButtonPanel.Controls.Add(button4, 1, 1);
            reportButtonPanel.Controls.Add(button3, 0, 1);
            reportButtonPanel.Controls.Add(button2, 1, 0);
            reportButtonPanel.Controls.Add(button1, 0, 0);
            reportButtonPanel.Dock = DockStyle.Fill;
            reportButtonPanel.Location = new Point(0, 88);
            reportButtonPanel.Margin = new Padding(0);
            reportButtonPanel.Name = "reportButtonPanel";
            reportButtonPanel.RowCount = 2;
            reportButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            reportButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            reportButtonPanel.Size = new Size(1033, 585);
            reportButtonPanel.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(666, 387);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(217, 103);
            button4.TabIndex = 3;
            button4.Text = "Report 4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(149, 387);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(217, 103);
            button3.TabIndex = 2;
            button3.Text = "Report 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(666, 94);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(217, 103);
            button2.TabIndex = 1;
            button2.Text = "Report 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(149, 94);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(217, 103);
            button1.TabIndex = 0;
            button1.Text = "Report 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BranchManagerReportPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(BranchManagerReportPanel);
            MinimumSize = new Size(1000, 598);
            Name = "BranchManagerReportPage";
            Text = "BranchManagerReportPage";
            Load += BranchManagerReportPage_Load_1;
            BranchManagerReportPanel.ResumeLayout(false);
            sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            reportsPanel.ResumeLayout(false);
            reportsPanel.PerformLayout();
            reportButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BranchManagerReportPanel;
        private TableLayoutPanel sideMenuPanel;
        private PictureBox pictureBox1;
        private Button btnHome;
        private TableLayoutPanel reportsPanel;
        private Label label1;
        private TableLayoutPanel reportButtonPanel;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}