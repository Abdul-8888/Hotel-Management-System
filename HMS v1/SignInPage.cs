using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_v1.DL;

namespace HMS_v1
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }
/*
        private void SignInPage_Load(object sender, EventArgs e)
        {

        }
*/
        private void lblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpPage signUpPg = new SignUpPage();
            signUpPg.Show();
        }

        private void SignInPage_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            txtUsername.PlaceholderText = "Username";
            txtPassword.PlaceholderText = "Password";

            loginPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            borderPanel.BackColor = Color.Black;

            btnLogin.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatAppearance.BorderColor = Color.Black;

            lblLogin.ForeColor = Color.Black;

            lblCreate.ForeColor = Color.White;
            lblCreate.VisitedLinkColor = lblCreate.ForeColor;
            lblCreate.ActiveLinkColor = lblCreate.ForeColor;
            lblCreate.LinkColor = lblCreate.ForeColor;
            lblCreate.LinkBehavior = LinkBehavior.NeverUnderline;
            lblCreate.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username field can't be left empty!");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password field can't be left empty!");
                return;
            }

            string result = PersonDL.checkPerson(txtUsername.Text, txtPassword.Text);

            if (result[0] == 'W')
            {
                CustomerDL.getCustomerType();//////////////////masla yaha ha

                NewCustomer f = new NewCustomer();
                f.Show();
                this.Hide();
            }
            else if (result[0] == 'L')
            {
                string user = EmployeeDL.getEmployeeRole();

                if(user == "owner")
                {
                    OwnerDashboard f = new OwnerDashboard();
                    f.Show();
                    this.Hide();
                }
                else if(user == "branch manager")
                {
                    BranchManagerDashboardPage f = new BranchManagerDashboardPage();
                    f.Show();
                    this.Hide();
                }
                else if(user == "service manager" || user == "kitchen manager")
                {
                    ServiceManagerPage f = new ServiceManagerPage();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    StaffDashboardPage f = new StaffDashboardPage();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
