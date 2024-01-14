namespace HMS_v1
{
    partial class ManageEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployees));
            manageEmployeesPnl = new TableLayoutPanel();
            sideBarPnl = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            detailsPanel = new TableLayoutPanel();
            employeeGrid = new DataGridView();
            header = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnUpdate = new Button();
            btnInsert = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label1 = new Label();
            txtCnic = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtFirstName = new TextBox();
            txtMidName = new TextBox();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            genderComboBox = new ComboBox();
            dobPicker = new DateTimePicker();
            roleComboBox = new ComboBox();
            txtSalary = new TextBox();
            cmbBranch = new ComboBox();
            manageEmployeesPnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeGrid).BeginInit();
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
            manageEmployeesPnl.TabIndex = 0;
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
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 7.195301F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25.99119F));
            sideBarPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
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
            logoPictureBox.Size = new Size(259, 141);
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
            btnHome.Location = new Point(0, 151);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(269, 65);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // detailsPanel
            // 
            detailsPanel.ColumnCount = 1;
            detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsPanel.Controls.Add(employeeGrid, 0, 2);
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
            // employeeGrid
            // 
            employeeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGrid.Dock = DockStyle.Fill;
            employeeGrid.Location = new Point(13, 549);
            employeeGrid.Margin = new Padding(13, 15, 13, 15);
            employeeGrid.Name = "employeeGrid";
            employeeGrid.RowHeadersWidth = 51;
            employeeGrid.Size = new Size(1150, 344);
            employeeGrid.TabIndex = 1;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(415, 25);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(346, 35);
            header.TabIndex = 2;
            header.Text = "Employee Management";
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
            tableLayoutPanel3.Controls.Add(label11, 0, 10);
            tableLayoutPanel3.Controls.Add(label10, 0, 9);
            tableLayoutPanel3.Controls.Add(label9, 0, 8);
            tableLayoutPanel3.Controls.Add(label8, 0, 7);
            tableLayoutPanel3.Controls.Add(label6, 0, 5);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtCnic, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(label7, 0, 6);
            tableLayoutPanel3.Controls.Add(txtFirstName, 1, 1);
            tableLayoutPanel3.Controls.Add(txtMidName, 1, 2);
            tableLayoutPanel3.Controls.Add(txtLastName, 1, 3);
            tableLayoutPanel3.Controls.Add(txtUserName, 1, 6);
            tableLayoutPanel3.Controls.Add(txtPassword, 1, 7);
            tableLayoutPanel3.Controls.Add(genderComboBox, 1, 5);
            tableLayoutPanel3.Controls.Add(dobPicker, 1, 4);
            tableLayoutPanel3.Controls.Add(roleComboBox, 1, 8);
            tableLayoutPanel3.Controls.Add(txtSalary, 1, 9);
            tableLayoutPanel3.Controls.Add(cmbBranch, 1, 10);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel3.Size = new Size(972, 449);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(179, 413);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(128, 23);
            label11.TabIndex = 20;
            label11.Text = "Branch Name";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(210, 368);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(66, 23);
            label10.TabIndex = 18;
            label10.Text = "Salary";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(218, 328);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 23);
            label9.TabIndex = 16;
            label9.Text = "Role";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(194, 288);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 23);
            label8.TabIndex = 8;
            label8.Text = "Password";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(205, 208);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 6;
            label6.Text = "Gender";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(214, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "CNIC";
            // 
            // txtCnic
            // 
            txtCnic.Anchor = AnchorStyles.Left;
            txtCnic.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnic.Location = new Point(491, 5);
            txtCnic.Margin = new Padding(5);
            txtCnic.Name = "txtCnic";
            txtCnic.Size = new Size(407, 35);
            txtCnic.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 88);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 3;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(190, 128);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 4;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(180, 168);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 5;
            label5.Text = "Date Of Birth";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(193, 248);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 7;
            label7.Text = "Username";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left;
            txtFirstName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(491, 45);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(407, 35);
            txtFirstName.TabIndex = 9;
            // 
            // txtMidName
            // 
            txtMidName.Anchor = AnchorStyles.Left;
            txtMidName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMidName.Location = new Point(491, 85);
            txtMidName.Margin = new Padding(5);
            txtMidName.Name = "txtMidName";
            txtMidName.Size = new Size(407, 35);
            txtMidName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left;
            txtLastName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(491, 125);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(407, 35);
            txtLastName.TabIndex = 11;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Left;
            txtUserName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(491, 245);
            txtUserName.Margin = new Padding(5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(407, 35);
            txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(491, 285);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(407, 35);
            txtPassword.TabIndex = 13;
            // 
            // genderComboBox
            // 
            genderComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(491, 205);
            genderComboBox.Margin = new Padding(5);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(407, 35);
            genderComboBox.TabIndex = 14;
            // 
            // dobPicker
            // 
            dobPicker.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dobPicker.Location = new Point(491, 165);
            dobPicker.Margin = new Padding(5);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(407, 35);
            dobPicker.TabIndex = 15;
            // 
            // roleComboBox
            // 
            roleComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(491, 325);
            roleComboBox.Margin = new Padding(5);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(407, 35);
            roleComboBox.TabIndex = 17;
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.Left;
            txtSalary.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(491, 365);
            txtSalary.Margin = new Padding(5);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(407, 35);
            txtSalary.TabIndex = 19;
            // 
            // cmbBranch
            // 
            cmbBranch.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(491, 405);
            cmbBranch.Margin = new Padding(5);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(407, 35);
            cmbBranch.TabIndex = 21;
            // 
            // ManageEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(manageEmployeesPnl);
            Margin = new Padding(5);
            MinimumSize = new Size(1140, 784);
            Name = "ManageEmployees";
            Text = "ManageEmployees";
            Load += ManageEmployees_Load_1;
            manageEmployeesPnl.ResumeLayout(false);
            sideBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel manageEmployeesPnl;
        private System.Windows.Forms.TableLayoutPanel sideBarPnl;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel detailsPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMidName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalary;
        private Label label11;
        private ComboBox cmbBranch;
    }
}