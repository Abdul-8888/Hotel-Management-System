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
    public partial class CustomerProducts : Form
    {
        public CustomerProducts()
        {
            InitializeComponent();
        }

        private void CustomerProducts_Load(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnOrder.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnOrder.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnOrder.ForeColor = Color.White;

            customerOrderGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnOrder.Enabled = false;

            //backend
            customerOrderGrid.DataSource = ProductDL.retrieveProduct();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer cus = new NewCustomer();
            cus.Show();
        }

        private void customerOrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.customerOrderGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["ProductId"].Value.ToString());
                string name = row.Cells["Name"].Value.ToString();
                int unitPrice = int.Parse(row.Cells["unitPrice"].Value.ToString());
                int type = int.Parse(row.Cells["Type"].Value.ToString());

                LookUp t = LookUpDL.retrieveLookUp(type);

                Product p = new Product(id, name, unitPrice, t.Value);

                btnOrder.Enabled = true;

                ProductDL.OrderProduct(p , (int)numericUpDown1.Value, EmployeeDL.current.EmployeeId);
            }
        }
    }
}
