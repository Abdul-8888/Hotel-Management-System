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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void NewCustomer_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnFood.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnFood.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnFood.ForeColor = Color.White;

            btnPayBill.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnPayBill.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnPayBill.ForeColor = Color.White;

            btnRoom.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnRoom.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnRoom.ForeColor = Color.White;

            btnReview.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnReview.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnReview.ForeColor = Color.White;

            btnSettings.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSettings.ForeColor = Color.White;


            btnServices.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnServices.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnServices.ForeColor = Color.White;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
        int imageNumber = 6;

        private void loadNextImage()
        {
            if (imageNumber == 11)
            {
                imageNumber = 6;
            }
            imagesPictureBox.ImageLocation = string.Format(@"../../../Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void imagesTimer_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRoomBooking roomPage = new CustomerRoomBooking();
            roomPage.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerService servicePage = new CustomerService();
            servicePage.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFood foodPage = new CustomerFood();
            foodPage.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerProducts productsPage = new CustomerProducts();
            productsPage.Show();
        }

        private void btnSettings_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            EditInfoPage editInfo = new EditInfoPage();
            editInfo.Show();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerReview customerRev = new CustomerReview();
            customerRev.Show();
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPayBill customerBill = new CustomerPayBill();
            customerBill.Show();
        }

        private void btnFood_Click_1(object sender, EventArgs e)
        {

        }
    }
}
