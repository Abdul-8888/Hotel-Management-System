using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_v1.BL;
using HMS_v1.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_v1
{
    public partial class SignUpPage : Form
    {

        public SignUpPage()
        {
            InitializeComponent();
        }
        /*
                private void SignUpPage_Load(object sender, EventArgs e)
                {

                }
        */
        private void lblAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInPage signInPg = new SignInPage();
            signInPg.Show();
        }

        private void SignUpPage_Load_1(object sender, EventArgs e)
        {
            //Frontend Work
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            lblSlogan.ForeColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);

            signUpPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            txtFirstName.PlaceholderText = "First Name";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtLastName.PlaceholderText = "Last Name";
            txtUsername.PlaceholderText = "Username";
            txtPassword.PlaceholderText = "Password";
            txtCnic.PlaceholderText = "CNIC No.";
            txtPhone.PlaceholderText = "Phone No.";
            txtEmail.PlaceholderText = "Email";

            lblAccount.ForeColor = Color.Black;
            lblAccount.VisitedLinkColor = lblAccount.ForeColor;
            lblAccount.ActiveLinkColor = lblAccount.ForeColor;
            lblAccount.LinkColor = lblAccount.ForeColor;
            lblAccount.LinkBehavior = LinkBehavior.NeverUnderline;
            lblAccount.LinkBehavior = LinkBehavior.HoverUnderline;

            btnSignUp.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.FlatAppearance.BorderColor = Color.Black;

            //backend Work
            cmbGender.DataSource = LookUpDL.retrieveLookUp("Gender");
            cmbGender.ValueMember = "Value";

            cmbRole.DataSource = LookUpDL.retrieveLookUp("Role");
            cmbRole.ValueMember = "Value";
            cmbRole.Enabled = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validation.CheckName(txtFirstName.Text))
                {
                    MessageBox.Show("Incorrect First Name!");
                    return;
                }
                if (!validation.CheckName(txtMiddleName.Text))
                {
                    MessageBox.Show("Incorrect Middle Name");
                }
                if (!validation.CheckName(txtLastName.Text))
                {
                    MessageBox.Show("Incorrect Last Name");
                    return;
                }
                if (!validation.CheckUsername(txtUsername.Text))
                {
                    MessageBox.Show("Incorrect Username");
                    return;
                }
                if(validation.usernameExist(txtUsername.Text))
                {
                    MessageBox.Show("Username already Exists");
                    return;
                }
                if (!validation.CheckPassword(txtPassword.Text))
                {
                    MessageBox.Show(" Error! Incorrect Format. Password should be between 8 and 20 characters in length. It should contain at least one alphabetical character and at least one numeric digit. It may contain special characters.");
                    return;
                }
                if (!validation.CheckCnic(txtCnic.Text))
                {
                    MessageBox.Show("Incorrect CNIC. It must be a 13 digit number");
                    return;
                }
                if (validation.cnicExist(txtCnic.Text))
                {
                    MessageBox.Show("CNIC already Exists");
                    return;
                }
                if (!validation.CheckContact(txtPhone.Text))
                {
                    MessageBox.Show("Incorrect Phone Number. It must be a 11 digit number");
                    return;
                }
                if (validation.phoneExist(txtPhone.Text))
                {
                    MessageBox.Show("Phone Number already Exists");
                    return;
                }
                if (!validation.CheckEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email is incorrect. It must include '@' and '.'");
                    return;
                }
                if (validation.emailExist(txtEmail.Text))
                {
                    MessageBox.Show("Email already Exists");
                    return;
                }
                if (validation.CheckGender(cmbGender.SelectedText))
                {
                    MessageBox.Show("Incorrect Choice of Gender");
                    return;
                }

                Customer c = new Customer(txtUsername.Text,
                                          txtPassword.Text,
                                          double.Parse(txtCnic.Text),
                                          txtFirstName.Text,
                                          txtLastName.Text,
                                          txtMiddleName.Text,
                                          dateTimePicker.Value,
                                          cmbGender.SelectedValue.ToString(),
                                          txtEmail.Text,
                                          double.Parse(txtPhone.Text),
                                          cmbRole.SelectedValue.ToString());

                PersonDL.addPerson(c);
                c.PersonId = PersonDL.getId();
                CustomerDL.addCustomer(c);

                MessageBox.Show("Customer Added Successfully!");

                clearAll();
            }
            catch
            {
                MessageBox.Show("All the fields must be filled with data in the correct format.");
            }
        }

        private void clearAll()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtCnic.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
