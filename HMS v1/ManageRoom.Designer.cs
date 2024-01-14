namespace HMS_v1
{
    partial class ManageRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoom));
            manageRoomPnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            roomGrid = new DataGridView();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnUpdate = new Button();
            btnInsert = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            label1 = new Label();
            txtRoomNo = new TextBox();
            label2 = new Label();
            txtCost = new TextBox();
            label3 = new Label();
            availabilityComboBox = new ComboBox();
            typeComboBox = new ComboBox();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewButtonColumn();
            manageRoomPnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // manageRoomPnl
            // 
            manageRoomPnl.BackColor = Color.Transparent;
            manageRoomPnl.ColumnCount = 2;
            manageRoomPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.67089F));
            manageRoomPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.32912F));
            manageRoomPnl.Controls.Add(sideBarPnl, 0, 0);
            manageRoomPnl.Controls.Add(detailsPanel, 1, 0);
            manageRoomPnl.Dock = DockStyle.Fill;
            manageRoomPnl.Location = new Point(0, 0);
            manageRoomPnl.Margin = new Padding(0);
            manageRoomPnl.Name = "manageRoomPnl";
            manageRoomPnl.RowCount = 1;
            manageRoomPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6975F));
            manageRoomPnl.Size = new Size(1370, 749);
            manageRoomPnl.TabIndex = 2;
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 23.18668F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10.14235F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.786477F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.430605F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 9.608541F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 37.54448F));
            sideBarPnl.Size = new Size(255, 749);
            sideBarPnl.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(5, 5);
            logoPictureBox.Margin = new Padding(5);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(245, 164);
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
            btnHome.Location = new Point(0, 174);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(255, 76);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // detailsPanel
            // 
            detailsPanel.ColumnCount = 1;
            detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsPanel.Controls.Add(roomGrid, 0, 2);
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
            // roomGrid
            // 
            roomGrid.AllowUserToAddRows = false;
            roomGrid.AllowUserToDeleteRows = false;
            roomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            roomGrid.Dock = DockStyle.Fill;
            roomGrid.Location = new Point(13, 360);
            roomGrid.Margin = new Padding(13, 15, 13, 15);
            roomGrid.Name = "roomGrid";
            roomGrid.ReadOnly = true;
            roomGrid.RowHeadersWidth = 51;
            roomGrid.Size = new Size(1089, 374);
            roomGrid.TabIndex = 1;
            roomGrid.CellContentClick += roomGrid_CellContentClick;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(412, 11);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(290, 35);
            header.TabIndex = 2;
            header.Text = "Room Management";
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
            tableLayoutPanel4.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel4.Controls.Add(btnInsert, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(926, 5);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(184, 277);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(24, 172);
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
            btnInsert.Location = new Point(24, 33);
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
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtRoomNo, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(txtCost, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(availabilityComboBox, 1, 2);
            tableLayoutPanel3.Controls.Add(typeComboBox, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(921, 287);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(203, 238);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 11;
            label4.Text = "Type";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 0;
            label1.Text = "Room Number";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Anchor = AnchorStyles.Left;
            txtRoomNo.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomNo.Location = new Point(465, 18);
            txtRoomNo.Margin = new Padding(5);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(407, 35);
            txtRoomNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 95);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 2;
            label2.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Anchor = AnchorStyles.Left;
            txtCost.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCost.Location = new Point(465, 89);
            txtCost.Margin = new Padding(5);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(407, 35);
            txtCost.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(179, 166);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 10;
            label3.Text = "Availability";
            // 
            // availabilityComboBox
            // 
            availabilityComboBox.Anchor = AnchorStyles.Left;
            availabilityComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            availabilityComboBox.FormattingEnabled = true;
            availabilityComboBox.Location = new Point(465, 160);
            availabilityComboBox.Margin = new Padding(5);
            availabilityComboBox.Name = "availabilityComboBox";
            availabilityComboBox.Size = new Size(407, 35);
            availabilityComboBox.TabIndex = 15;
            // 
            // typeComboBox
            // 
            typeComboBox.Anchor = AnchorStyles.Left;
            typeComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(465, 232);
            typeComboBox.Margin = new Padding(5);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(407, 35);
            typeComboBox.TabIndex = 16;
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
            // ManageRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(manageRoomPnl);
            Margin = new Padding(5);
            MinimumSize = new Size(1327, 723);
            Name = "ManageRoom";
            Text = "ManageRoom";
            Load += ManageRoom_Load_1;
            manageRoomPnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel manageRoomPnl;
        private System.Windows.Forms.TableLayoutPanel sideBarPnl;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TableLayoutPanel detailsPanel;
        private System.Windows.Forms.DataGridView roomGrid;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox availabilityComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
    }
}