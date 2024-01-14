using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_v1
{
    public partial class ServiceManagerPage : Form
    {
        public ServiceManagerPage()
        {
            InitializeComponent();
        }

        private void ServiceManagerPage_Load(object sender, EventArgs e)
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
            DialogResult result = MessageBox.Show("Assign this task?", "Confirmation...", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //Bring data to grid view
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddButton("Temporary");
        }

        private void EmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditInfoPage editInfoPg = new EditInfoPage();
            editInfoPg.Show();
        }

        private void ServiceManagerPage_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            sideMenuPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            notificationPanel.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            EmployeeGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
        }
    }
}
