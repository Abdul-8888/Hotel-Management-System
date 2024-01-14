using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

using System.Runtime.InteropServices;

namespace HMS_v1
{
    public partial class LandingPage : Form
    {
        private int count = 0;
        private int imageNumber = 1;

        public LandingPage()
        {
            InitializeComponent();
        }
        /*
                private void LandingPage_Load(object sender, EventArgs e)
                {

                }
        */
        /*        private void loadTimer_Tick(object sender, EventArgs e)
                {

                }*/

        private void LandingPage_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnSignIn.Enabled = false;
            btnSignUp.Enabled = false;

            btnSignUp.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnSignIn.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);
        }

        private void loadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            imagesPictureBox.ImageLocation = string.Format(@"../../../Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        /*
                private void imagesTimer_Tick(object sender, EventArgs e)
                {

                }
        */
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInPage signInPg = new SignInPage();
            signInPg.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPage signUpPg = new SignUpPage();
            signUpPg.Show();
        }

        private void imagesTimer_Tick_1(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void loadTimer_Tick_1(object sender, EventArgs e)
        {
            if (count < 500)
            {
                count += 2;
                loadingProgressBar.Value = count;
            }
            else
            {
                loadTimer.Stop();
                //MessageBox.Show("Successfully Loaded!");
                //loadingProgressBar.Hide();
                btnSignIn.Enabled = true;
                btnSignUp.Enabled = true;
            }
        }
    }
}
