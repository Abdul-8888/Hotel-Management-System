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
    public partial class CustomerReview : Form
    {
        public CustomerReview()
        {
            InitializeComponent();
        }

        /*private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }*/

        /*private void CustomerReview_Load(object sender, EventArgs e)
        {
            
        }*/

        private void btnHome_Click(object sender, EventArgs e)
        {
            NewCustomer cus = new NewCustomer();
            cus.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtComment.Text == "")
            {
                MessageBox.Show("Comment can't be left empty!");
            }
        }

        private void CustomerReview_Load_1(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnAdd.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnAdd.ForeColor = Color.White;

            reviewGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            //backend
            reviewGrid.DataSource = ReviewDL.retrieveReview(CustomerDL.current.CustomerId);
        }
    }
}
