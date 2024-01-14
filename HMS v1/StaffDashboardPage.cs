using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HMS_v1
{
    public partial class StaffDashboardPage : Form
    {
        public StaffDashboardPage()
        {
            InitializeComponent();
        }

        private void StaffDashboardPage_Load(object sender, EventArgs e)
        {
            
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

            Notifications.Controls.Add(button);
            button.Click += NotificationButton_Click;
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to Start this task?", "Confirmation...", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Get a reference to the clicked button
                Button clickedButton = sender as Button;

                Button button = new Button();

                button.Text = clickedButton.Text;

                button.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
                button.ForeColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
                button.ForeColor = Color.White;
                button.Height = 50;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.White;
                button.Width = WorkAreaPanel.Width;
                button.Dock = DockStyle.Top;

                WorkAreaPanel.Controls.Add(button);
                button.Click += WorkButton_Click;

                WorkAreaPanel.Controls.Remove(clickedButton);
            }
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            // Get a reference to the clicked button
            Button clickedButton = sender as Button;

            DialogResult result = MessageBox.Show("Do you wish to End this Task?", "Confirmation...", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                WorkAreaPanel.Controls.Remove(clickedButton);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddButton("Temporary \n 2");
        }

        private void StaffDashboardPage_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditInfoPage editInfo = new EditInfoPage();
            editInfo.Show();
        }

        private void StaffDashboardPage_Load_2(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            sideMenuPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            notificationPanel.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
        }
    }
}
