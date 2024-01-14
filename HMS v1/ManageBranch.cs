using HMS_v1.BL;
using HMS_v1.DL;
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
    public partial class ManageBranch : Form
    {
        public ManageBranch()
        {
            InitializeComponent();
        }

        private void ManageBranch_Load(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnInsert.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnInsert.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnInsert.ForeColor = Color.White;

            btnUpdate.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            branchGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.ForeColor = Color.White;

            btnUpdate.Enabled = false;

            //backend
            branchGrid.DataSource = BranchDL.retrieveBranch();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name can't be left empty!");
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("City can't be left empty!");
            }
            if (txtCountry.Text == "")
            {
                MessageBox.Show("Country can't be left empty!");
            }

            Branch b = new Branch(txtName.Text, txtCity.Text, txtCountry.Text);
            BranchDL.insertBranch(b);
            BranchDL.current = BranchDL.retrieveBranch(b.Name);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BranchDL.updateBranch(BranchDL.current);

            btnUpdate.Enabled = false;
        }

        private void branchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.branchGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["BranchId"].Value.ToString());
                string name = row.Cells["Name"].Value.ToString();
                string city = row.Cells["City"].Value.ToString();
                string country = row.Cells["Country"].Value.ToString();

                Branch b = new Branch(id, name, city, country);
                BranchDL.current = b;

                txtName.Text = name;
                txtCity.Text = city;
                txtCountry.Text = country;

                btnUpdate.Enabled = true;
            }

            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.branchGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["BranchId"].Value.ToString());

                BranchDL.deleteBranch(id);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OwnerDashboard f = new OwnerDashboard();
            f.Show();
            this.Hide();
        }
    }
}
