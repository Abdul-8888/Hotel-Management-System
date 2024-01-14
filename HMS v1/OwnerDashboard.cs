using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_v1.DL;

namespace HMS_v1
{
    public partial class OwnerDashboard : Form
    {
        public OwnerDashboard()
        {
            InitializeComponent();
        }

        private void OwnerDashboard_Load(object sender, EventArgs e)
        {
            //fornent
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            sideMenuPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            btnReport.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnReport.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnReport.ForeColor = Color.White;

            btnRoom.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnRoom.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnRoom.ForeColor = Color.White;

            btnProduct.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnProduct.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnProduct.ForeColor = Color.White;

            btnService.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnService.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnService.ForeColor = Color.White;

            btnFood.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnFood.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnFood.ForeColor = Color.White;

            btnBranch.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnBranch.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnBranch.ForeColor = Color.White;

            btnLookUp.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnLookUp.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnLookUp.ForeColor = Color.White;

            btnEmployee.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnEmployee.ForeColor = Color.White;

            btnSettings.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSettings.ForeColor = Color.White;

            notificationPanel.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

        }

        private void AddButton(string text)
        {
            Button button = new Button();

            button.Text = text;

            button.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button.ForeColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button.ForeColor = Color.White;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button.Width = notificationPanel.Width - 3;
            button.Dock = DockStyle.Top;

            notificationPanel.Controls.Add(button);

            button.Click += notificationButton_Click;
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            //Show detail of work performed
            MessageBox.Show("new Notification");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            StaffDashboardPage f = new StaffDashboardPage();
            f.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ManageRoom f = new ManageRoom();
            f.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ManageProductPage f = new ManageProductPage();
            f.Show();
            this.Hide();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            ManageServicePage f = new ManageServicePage();
            f.Show();
            this.Hide();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ManageServicePage f = new ManageServicePage();
            f.Show();
            this.Hide();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            ManageBranch f = new ManageBranch();
            f.Show();
            this.Hide();
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            ManageLookUpPage f = new ManageLookUpPage();
            f.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployees f = new ManageEmployees();
            f.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            EditInfoPage f = new EditInfoPage();
            f.Show();
            this.Hide();
        }

        private void notificatoinTimer_Tick(object sender, EventArgs e)
        {
            /*DataTable dt = NotificationDL.retrieveNotification(CustomerDL.current.PersonId);

            string category;
            int from;

            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                      dr[dc];
                }
            }*/
        }
    }
}