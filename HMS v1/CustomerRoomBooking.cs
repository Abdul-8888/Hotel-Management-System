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
    public partial class CustomerRoomBooking : Form
    {
        public CustomerRoomBooking()
        {
            InitializeComponent();
        }

        /*private void CustomerRoomBooking_Load(object sender, EventArgs e)
        {
            
        }

        private void customerRoomBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void CustomerRoomBooking_Load_1(object sender, EventArgs e)
        {
            //fronend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnBook.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnBook.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnBook.ForeColor = Color.White;

            customerRoomBGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            btnBook.Enabled = false;

            //backend
            customerRoomBGrid.DataSource = RoomDL.retrieveRoom();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer cus = new NewCustomer();
            cus.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            RoomDL.bookRoom(RoomDL.current.RoomId, fromDateTime.Value, toDateTime.Value, BillDL.current.BillId, CustomerDL.current.CustomerId);

            btnBook.Enabled = false;
        }

        private void customerRoomBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.customerRoomBGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["RoomId"].Value.ToString());
                int name = int.Parse(row.Cells["RoomNo"].Value.ToString());
                int cost = int.Parse(row.Cells["CostPerHour"].Value.ToString());
                int availability = int.Parse(row.Cells["Availability"].Value.ToString());
                int type = int.Parse(row.Cells["Type"].Value.ToString());

                LookUp a = LookUpDL.retrieveLookUp(availability);
                LookUp t = LookUpDL.retrieveLookUp(type);

                Room f = new Room(id, name, cost, a.Value, t.Value);
                RoomDL.current = f;

                btnBook.Enabled = true;
            }
        }
    }
}
