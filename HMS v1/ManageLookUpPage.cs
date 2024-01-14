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
    public partial class ManageLookUpPage : Form
    {
        int id;

        public ManageLookUpPage()
        {
            InitializeComponent();
        }

        /*private void ManageLookUpPage_Load(object sender, EventArgs e)
        {

        }*/

        private void ManageLookUpPage_Load_1(object sender, EventArgs e)
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

            LookUpGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            btnUpdate.Hide();

            //backend
            LookUpGrid.DataSource = LookUpDL.retrieveLookUp();
        }

        private void LookUpGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.LookUpGrid.Rows[e.RowIndex];

                id = int.Parse(row.Cells["LookUpId"].Value.ToString());
                string category = (row.Cells["Category"].Value.ToString());
                string value = (row.Cells["Value"].Value.ToString());

                txtCategory.Text = category;
                txtValue.Text = value;

                btnUpdate.Enabled = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text;
            string value = txtValue.Text;

            LookUp l = new LookUp(category, value);
            LookUpDL.addLookUp(l);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text;
            string value = txtValue.Text;

            LookUp l = new LookUp(id, category, value);
            LookUpDL.updateLookUp(l);

            btnUpdate.Enabled = false;
        }
    }
}
