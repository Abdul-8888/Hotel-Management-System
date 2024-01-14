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
    public partial class ManageProductPage : Form
    {
        public ManageProductPage()
        {
            InitializeComponent();
        }

        private void ManageProductPage_Load(object sender, EventArgs e)
        {

        }

        private void ManageProductPage_Load_1(object sender, EventArgs e)
        {
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

            ProductGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            //backend
            cmbType.DataSource = LookUpDL.retrieveLookUp("Room Type");
            cmbType.ValueMember = "Value";
            btnUpdate.Enabled = false;
            ProductGrid.DataSource = RoomDL.retrieveRoom();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Product Name can't be left empty");
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Product price can't be left wmpty!");
            }
            if (!validation.CheckNumber(txtPrice.Text))
            {
                MessageBox.Show("Error! Price must be an integer");
            }
            if (cmbType.Text == "")
            {
                MessageBox.Show("Error! Product type can't be left empty");
            }
            if (!validation.CheckProType(cmbType.Text))
            {
                MessageBox.Show("Error! Invalid product type");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Product Name can't be left empty");
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Product price can't be left wmpty!");
            }
            if (!validation.CheckNumber(txtPrice.Text))
            {
                MessageBox.Show("Error! Price must be an integer");
            }
            if (cmbType.Text == "")
            {
                MessageBox.Show("Error! Product type can't be left empty");
            }
            if (!validation.CheckProType(cmbType.Text))
            {
                MessageBox.Show("Error! Invalid product type");
            }
        }

        private void ProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {

            }
        }
    }
}
