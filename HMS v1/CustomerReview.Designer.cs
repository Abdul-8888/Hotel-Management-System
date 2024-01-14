namespace HMS_v1
{
    partial class CustomerReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReview));
            customerReviewPnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            reviewGrid = new DataGridView();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAdd = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtComment = new TextBox();
            ratingNumericUpDown = new NumericUpDown();
            customerReviewPnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reviewGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ratingNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // customerReviewPnl
            // 
            customerReviewPnl.BackColor = Color.Transparent;
            customerReviewPnl.ColumnCount = 2;
            customerReviewPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.67089F));
            customerReviewPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.32912F));
            customerReviewPnl.Controls.Add(sideBarPnl, 0, 0);
            customerReviewPnl.Controls.Add(detailsPanel, 1, 0);
            customerReviewPnl.Dock = DockStyle.Fill;
            customerReviewPnl.Location = new Point(0, 0);
            customerReviewPnl.Margin = new Padding(0);
            customerReviewPnl.Name = "customerReviewPnl";
            customerReviewPnl.RowCount = 1;
            customerReviewPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6975F));
            customerReviewPnl.Size = new Size(1370, 749);
            customerReviewPnl.TabIndex = 3;
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2669F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.786477F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.608541F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10.14235F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.964413F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 36.12099F));
            sideBarPnl.Size = new Size(255, 749);
            sideBarPnl.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(5, 5);
            logoPictureBox.Margin = new Padding(5, 5, 5, 5);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(245, 177);
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
            btnHome.Location = new Point(0, 187);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(255, 72);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // detailsPanel
            // 
            detailsPanel.ColumnCount = 1;
            detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsPanel.Controls.Add(reviewGrid, 0, 2);
            detailsPanel.Controls.Add(header, 0, 0);
            detailsPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            detailsPanel.Dock = DockStyle.Fill;
            detailsPanel.Location = new Point(255, 0);
            detailsPanel.Margin = new Padding(0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.RowCount = 3;
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.94511F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.05489F));
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 403F));
            detailsPanel.Size = new Size(1115, 749);
            detailsPanel.TabIndex = 1;
            // 
            // reviewGrid
            // 
            reviewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reviewGrid.Dock = DockStyle.Fill;
            reviewGrid.Location = new Point(13, 360);
            reviewGrid.Margin = new Padding(13, 15, 13, 15);
            reviewGrid.Name = "reviewGrid";
            reviewGrid.RowHeadersWidth = 51;
            reviewGrid.Size = new Size(1089, 374);
            reviewGrid.TabIndex = 1;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(423, 11);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(269, 35);
            header.TabIndex = 2;
            header.Text = "Customer Review";
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
            tableLayoutPanel2.Location = new Point(0, 58);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1115, 287);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(926, 5);
            tableLayoutPanel4.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(184, 277);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(24, 103);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 71);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(txtComment, 1, 0);
            tableLayoutPanel3.Controls.Add(ratingNumericUpDown, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(921, 287);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 60);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "Comment";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 203);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 2;
            label2.Text = "Rating";
            // 
            // txtComment
            // 
            txtComment.Anchor = AnchorStyles.Left;
            txtComment.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtComment.Location = new Point(465, 54);
            txtComment.Margin = new Padding(5, 5, 5, 5);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(407, 35);
            txtComment.TabIndex = 3;
            // 
            // ratingNumericUpDown
            // 
            ratingNumericUpDown.Anchor = AnchorStyles.Left;
            ratingNumericUpDown.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ratingNumericUpDown.Location = new Point(463, 197);
            ratingNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ratingNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ratingNumericUpDown.Name = "ratingNumericUpDown";
            ratingNumericUpDown.Size = new Size(409, 35);
            ratingNumericUpDown.TabIndex = 4;
            ratingNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CustomerReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(customerReviewPnl);
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(1327, 723);
            Name = "CustomerReview";
            Text = "CustomerReview";
            Load += CustomerReview_Load_1;
            customerReviewPnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reviewGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ratingNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customerReviewPnl;
        private System.Windows.Forms.TableLayoutPanel sideBarPnl;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TableLayoutPanel detailsPanel;
        private System.Windows.Forms.DataGridView reviewGrid;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private NumericUpDown ratingNumericUpDown;
    }
}