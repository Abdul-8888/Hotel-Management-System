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
    public partial class BranchManagerDashboardPage : Form
    {
        public BranchManagerDashboardPage()
        {
            InitializeComponent();
        }

        private void BranchManagerDashboardPage_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            sideMenuPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            btnResource.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnResource.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnResource.ForeColor = Color.White;

            btnOrder.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnOrder.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnOrder.ForeColor = Color.White;

            btnSettings.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSettings.ForeColor = Color.White;

            btnReport.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnReport.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnReport.ForeColor = Color.White;

            workflowPanel.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            orderProductPanel.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
        }

        private void AddButton(string text, Panel panel)
        {
            Button button = new Button();

            button.Text = text;

            button.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button.ForeColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button.ForeColor = Color.White;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button.Width = panel.Width - 3;
            button.Dock = DockStyle.Top;

            panel.Controls.Add(button);

            if (panel.Name == workflowPanel.Name)
            {
                button.Click += workflowButton_Click;
            }
            else
            {
                button.Click += orderProductButton_Click;
            }
        }

        private void workflowButton_Click(object sender, EventArgs e)
        {
            //Show detail of work performed
            MessageBox.Show("Work Detail");
        }

        private void orderProductButton_Click(object sender, EventArgs e)
        {
            //Take to product order Form
            MessageBox.Show("Order Product");
        }

        /*private void btnHome_Click(object sender, EventArgs e)
        {

        }*/

        private void btnResource_Click(object sender, EventArgs e)
        {
            ResourceAssignment f = new ResourceAssignment();
            f.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderProduct f = new OrderProduct();
            f.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            BranchManagerReportPage f = new BranchManagerReportPage();
            f.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            EditInfoPage f = new EditInfoPage();
            f.Show();
            this.Hide();
        }
    }
}
