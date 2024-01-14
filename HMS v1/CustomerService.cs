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
    public partial class CustomerService : Form
    {
        public CustomerService()
        {
            InitializeComponent();
        }

        /*private void CustomerService_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAvail_Click(object sender, EventArgs e)
        {

        }*/

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer cus = new NewCustomer();
            cus.Show();
        }

        private void CustomerService_Load_1(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnAvail.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnAvail.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnAvail.ForeColor = Color.White;

            customerServiceGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            btnAvail.Enabled = false;

            //backend
            customerServiceGrid.DataSource = ServiceDL.retrieveService();
        }

        private void customerServiceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.customerServiceGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["Service"].Value.ToString());
                string name = row.Cells["Name"].Value.ToString();
                int price = int.Parse(row.Cells["Cost"].Value.ToString());

                Service f = new Service(id, name, price);
                ServiceDL.current = f;

                btnAvail.Enabled = true;
            }
        }

        private void btnAvail_Click(object sender, EventArgs e)
        {
            ServiceDL.availService(ServiceDL.current, CustomerDL.current.CustomerId, BillDL.current.BillId);

            btnAvail.Enabled = false;
        }
    }
}
