using HMS_v1.DL;
using HMS_v1.BL;
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
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }

        /*private void ManageEmployees_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }*/

        private void ManageEmployees_Load_1(object sender, EventArgs e)
        {
            //frontend
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideBarPnl.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            btnInsert.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnInsert.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnInsert.ForeColor = Color.White;

            btnUpdate.BackColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            employeeGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.ForeColor = Color.White;

            btnUpdate.Enabled = false;

            //backend
            employeeGrid.DataSource = EmployeeDL.retrieveEmployee();

            cmbBranch.DataSource = BranchDL.retrieveBranch();
            cmbBranch.ValueMember = "Name";

            roleComboBox.DataSource = LookUpDL.retrieveLookUp("Job Role");
            roleComboBox.ValueMember = "Value";

            genderComboBox.DataSource = LookUpDL.retrieveLookUp("Gender");
            genderComboBox.ValueMember = "Value";
        }

        private void btnInsert_Click(object sender, EventArgs e)
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
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Username Can Not Be Left Empty!");
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
            if (!validation.CheckSalary(txtSalary.Text))
            {
                MessageBox.Show("Error! Salary must be an integer");
            }
            if (cmbBranch.Text == "")
            {
                MessageBox.Show("Error! Branch Name can't be left empty!");
            }
            if (!validation.CheckJobRole(roleComboBox.Text))
            {
                MessageBox.Show("Error! Invalid Job Role");
            }

            /*double cnic = double.Parse(txtCnic.Text);
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string mName = txtMidName.Text;
            DateTime date = dobPicker.Value;
            string gender = genderComboBox.SelectedValue.ToString();
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = roleComboBox.SelectedValue.ToString();
            int salary = int.Parse(txtSalary.Text);
            string branch = cmbBranch.SelectedValue.ToString();

            int g = LookUpDL.retrieveLookUp("Gender", gender);
            int r = LookUpDL.retrieveLookUp("Role", role);
            Branch b = BranchDL.retrieveBranch(branch);

            Employee p = new Employee(username, password, cnic, fName, lName, mName, date, g, email, phone, r, b.BranchId, jr, salary, );*/
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
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Username Can Not Be Left Empty!");
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
            if (!validation.CheckSalary(txtSalary.Text))
            {
                MessageBox.Show("Error! Salary must be an integer");
            }
            if (!validation.CheckJobRole(roleComboBox.Text))
            {
                MessageBox.Show("Error! Invalid Job Role");
            }
        }
    }
}
