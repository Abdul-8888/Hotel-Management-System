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
using HMS_v1.BL;

namespace HMS_v1
{
    public partial class EditInfoPage : Form
    {
        public Person p;

        public EditInfoPage()
        {
            InitializeComponent();
        }

        private void EditInfoPage_Load(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnUpdate.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.ForeColor = Color.White;

            //backend

            if(CustomerDL.current != null)
            {
                p = new Person(CustomerDL.current.PersonId,
                                CustomerDL.current.Username,
                                CustomerDL.current.Password,
                                CustomerDL.current.Cnic,
                                CustomerDL.current.FirstName,
                                CustomerDL.current.LastName,
                                CustomerDL.current.MiddleName,
                                CustomerDL.current.DateOfBirth,
                                CustomerDL.current.Gender,
                                CustomerDL.current.Email,
                                CustomerDL.current.Phone,
                                CustomerDL.current.Role);
            }
            else
            {

                p = new Person(EmployeeDL.current.PersonId,
                                EmployeeDL.current.Username,
                                EmployeeDL.current.Password,
                                EmployeeDL.current.Cnic,
                                EmployeeDL.current.FirstName,
                                EmployeeDL.current.LastName,
                                EmployeeDL.current.MiddleName,
                                EmployeeDL.current.DateOfBirth,
                                EmployeeDL.current.Gender,
                                EmployeeDL.current.Email,
                                EmployeeDL.current.Phone,
                                EmployeeDL.current.Role);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(p.Role == "customer")
            {
                this.Hide();
                NewCustomer cus = new NewCustomer();
                cus.Show();
            }
            else
            {
                this.Hide();
                BranchManagerDashboardPage cus = new BranchManagerDashboardPage();
                cus.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validation.CheckName(txtFirstName.Text))
            {
                MessageBox.Show("Incorrect First Name!");
            }
            if (!validation.CheckName(txtMidName.Text))
            {
                MessageBox.Show("Incorrect Middle Name");
            }
            if (!validation.CheckName(txtLastName.Text))
            {
                MessageBox.Show("Incorrect Last Name");
            }
            if (!validation.CheckPassword(txtPassword.Text))
            {
                MessageBox.Show(" Error! Incorrect Format. Password should be between 8 and 20 characters in length. It should contain at least one alphabetical character and at least one numeric digit. It may contain special characters.");
            }
            if (!validation.CheckCnic(txtCnic.Text))
            {
                MessageBox.Show("Incorrect CNIC. It must be a 13 digit number");
            }
            if (!validation.CheckGender(genderComboBox.Text))
            {
                MessageBox.Show("Incorrect Choice");
            }

            if (p.Role == "customer")
            {
                Customer c = new Customer(p.PersonId, CustomerDL.current.CustomerId, p.Username, txtPassword.Text, double.Parse(txtCnic.Text), txtFirstName.Text, txtLastName.Text, txtMidName.Text, dobPicker.Value, genderComboBox.SelectedValue.ToString(), p.Email, p.Phone, p.Role);
                CustomerDL.updateCustomer(c);
            }
            else
            {
                Employee c = new Employee(p.PersonId, EmployeeDL.current.EmployeeId, p.Username, txtPassword.Text, double.Parse(txtCnic.Text), txtFirstName.Text, txtLastName.Text, txtMidName.Text, dobPicker.Value, genderComboBox.SelectedValue.ToString(), p.Email, p.Phone, p.Role, EmployeeDL.current.BranchId, EmployeeDL.current.JobRole, EmployeeDL.current.Salary, EmployeeDL.current.Superviser);
                EmployeeDL.updateEmployee(c);
            }
        }
    }
}
