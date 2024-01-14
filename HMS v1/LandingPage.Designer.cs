namespace HMS_v1
{
    partial class LandingPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            landingPagePnl = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            imagesPictureBox = new PictureBox();
            headerPnl = new TableLayoutPanel();
            btnSignUp = new Button();
            logoPictureBox = new PictureBox();
            btnSignIn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            loadingProgressBar = new ProgressBar();
            loadTimer = new System.Windows.Forms.Timer(components);
            imagesTimer = new System.Windows.Forms.Timer(components);
            landingPagePnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagesPictureBox).BeginInit();
            headerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // landingPagePnl
            // 
            landingPagePnl.BackColor = Color.Transparent;
            landingPagePnl.ColumnCount = 1;
            landingPagePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            landingPagePnl.Controls.Add(tableLayoutPanel1, 0, 1);
            landingPagePnl.Controls.Add(headerPnl, 0, 0);
            landingPagePnl.Controls.Add(tableLayoutPanel2, 0, 2);
            landingPagePnl.Dock = DockStyle.Fill;
            landingPagePnl.Location = new Point(0, 0);
            landingPagePnl.Margin = new Padding(0);
            landingPagePnl.MinimumSize = new Size(1143, 800);
            landingPagePnl.Name = "landingPagePnl";
            landingPagePnl.RowCount = 3;
            landingPagePnl.RowStyles.Add(new RowStyle(SizeType.Percent, 24.81203F));
            landingPagePnl.RowStyles.Add(new RowStyle(SizeType.Percent, 75.18797F));
            landingPagePnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            landingPagePnl.Size = new Size(1370, 800);
            landingPagePnl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(imagesPictureBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 159);
            tableLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1360, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // imagesPictureBox
            // 
            imagesPictureBox.Dock = DockStyle.Fill;
            imagesPictureBox.Image = (Image)resources.GetObject("imagesPictureBox.Image");
            imagesPictureBox.Location = new Point(0, 0);
            imagesPictureBox.Margin = new Padding(0);
            imagesPictureBox.Name = "imagesPictureBox";
            imagesPictureBox.Size = new Size(1360, 461);
            imagesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imagesPictureBox.TabIndex = 2;
            imagesPictureBox.TabStop = false;
            // 
            // headerPnl
            // 
            headerPnl.ColumnCount = 3;
            headerPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.26605F));
            headerPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.73395F));
            headerPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            headerPnl.Controls.Add(btnSignUp, 2, 0);
            headerPnl.Controls.Add(logoPictureBox, 0, 0);
            headerPnl.Controls.Add(btnSignIn, 1, 0);
            headerPnl.Dock = DockStyle.Fill;
            headerPnl.Location = new Point(0, 0);
            headerPnl.Margin = new Padding(0);
            headerPnl.Name = "headerPnl";
            headerPnl.RowCount = 1;
            headerPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            headerPnl.Size = new Size(1370, 155);
            headerPnl.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnSignUp.Location = new Point(1176, 49);
            btnSignUp.Margin = new Padding(5, 4, 5, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(128, 56);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(0, 0);
            logoPictureBox.Margin = new Padding(0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(214, 155);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Right;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnSignIn.Location = new Point(977, 49);
            btnSignIn.Margin = new Padding(5, 4, 5, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(128, 56);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(loadingProgressBar, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 624);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1370, 176);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // loadingProgressBar
            // 
            loadingProgressBar.Anchor = AnchorStyles.None;
            loadingProgressBar.Location = new Point(324, 76);
            loadingProgressBar.Margin = new Padding(5, 4, 5, 4);
            loadingProgressBar.Maximum = 500;
            loadingProgressBar.Name = "loadingProgressBar";
            loadingProgressBar.Size = new Size(722, 24);
            loadingProgressBar.TabIndex = 4;
            // 
            // loadTimer
            // 
            loadTimer.Enabled = true;
            loadTimer.Interval = 1;
            loadTimer.Tick += loadTimer_Tick_1;
            // 
            // imagesTimer
            // 
            imagesTimer.Enabled = true;
            imagesTimer.Interval = 2000;
            imagesTimer.Tick += imagesTimer_Tick_1;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(landingPagePnl);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1328, 723);
            Name = "LandingPage";
            Text = "LandingPage";
            Load += LandingPage_Load_1;
            landingPagePnl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagesPictureBox).EndInit();
            headerPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel landingPagePnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel headerPnl;
        private System.Windows.Forms.PictureBox imagesPictureBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Timer loadTimer;
        private System.Windows.Forms.Timer imagesTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}