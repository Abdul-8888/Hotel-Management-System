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
    public partial class CustomerPayBill : Form
    {
        public CustomerPayBill()
        {
            InitializeComponent();
        }

        /*private void customerServiceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        /*private void CustomerPayBill_Load(object sender, EventArgs e)
        {
            
        }
*/
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer cus = new NewCustomer();
            cus.Show();
        }

        private void CustomerPayBill_Load_1(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;

            btnPay.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnPay.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnPay.ForeColor = Color.White;

            txtAccount.PlaceholderText = "Account Number";

            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            payBillGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            btnPay.Enabled = false;

            //backend
            //payBillGrid.DataSource = BillDL.getCustomerBill(CustomerDL.current.CustomerId);
            cmdMethod.DataSource = LookUpDL.retrieveLookUp("Method");
            cmdMethod.ValueMember = "Value";
        }

        private void payBillGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            BillDL.payBill(BillDL.current.BillId, CustomerDL.current.CustomerId, cmdMethod.SelectedValue.ToString());

            btnPay.Enabled=false;
        }
    }
}
