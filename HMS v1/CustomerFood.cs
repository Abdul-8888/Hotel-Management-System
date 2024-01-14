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
    public partial class CustomerFood : Form
    {
        public CustomerFood()
        {
            InitializeComponent();
        }

        private void CustomerFood_Load(object sender, EventArgs e)
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
            customerOrderGrid.DataSource = FoodDL.retrieveFood();////////////////USSI BRANCH WALY FOOD DIKHANY HAIN
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NewCustomer cus = new NewCustomer();
            cus.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int quantity = (int)quantityUpDown.Value;
            int customerId = CustomerDL.current.CustomerId;
            int billId = BillDL.current.BillId;

            FoodDL.orderFood(quantity, customerId, billId);
            btnOrder.Enabled = false;
        }

        private void customerOrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                btnOrder.Enabled = true;

                DataGridViewRow row = this.customerOrderGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["FoodId"].Value.ToString());
                string name = row.Cells["DishName"].Value.ToString();
                int price = int.Parse(row.Cells["Price"].Value.ToString());

                Food f = new Food(id,name,price);
                FoodDL.current = f;
            }
        }
    }
}
