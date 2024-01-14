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
    public partial class BranchManagerReportPage : Form
    {
        public BranchManagerReportPage()
        {
            InitializeComponent();
        }

        /*private void BranchManagerReportPage_Load(object sender, EventArgs e)
        {
            
        }*/

        private void BranchManagerReportPage_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            sideMenuPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            button1.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button1.ForeColor = Color.White;

            button2.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button2.ForeColor = Color.White;

            button3.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button3.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button3.ForeColor = Color.White;

            button4.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button4.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            button4.ForeColor = Color.White;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            BranchManagerDashboardPage f = new BranchManagerDashboardPage();
            f.Show();
            this.Hide();
        }
    }
}
