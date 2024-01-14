using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_v1.BL;
using HMS_v1.DL;

namespace HMS_v1
{
    public partial class ManageServicePage : Form
    {
        int id;

        public ManageServicePage()
        {
            InitializeComponent();
        }

        /*private void ManageServicePage_Load(object sender, EventArgs e)
        {
            
        }*/

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Service name can't be left empty!");
            }

            Service s = new Service(txtName.Text, int.Parse(txtCost.Text));
            ServiceDL.addService(s);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Service name can't be left empty!");
            }

            Service s = new Service(id, txtName.Text, int.Parse(txtCost.Text));
            ServiceDL.updateService(s);

            btnUpdate.Enabled = false;
        }

        private void ManageServicePage_Load_1(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            sideMenuPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            btnInsert.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnInsert.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnInsert.ForeColor = Color.White;

            btnUpdate.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.ForeColor = Color.White;

            ServiceGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            btnUpdate.Enabled = false;

            //backend
            ServiceGrid.DataSource = ServiceDL.retrieveService();
        }

        private void ServiceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.ServiceGrid.Rows[e.RowIndex];

                id = int.Parse(row.Cells["ServiceId"].Value.ToString());
                string name = row.Cells["Name"].Value.ToString();
                int cost = int.Parse(row.Cells["Cost"].Value.ToString());

                txtName.Text = name;
                txtCost.Text = cost.ToString();

                btnUpdate.Enabled = true;
            }
            else if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.ServiceGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["ServiceId"].Value.ToString());

                ServiceDL.deleteService(id);
            }
        }
    }
}
