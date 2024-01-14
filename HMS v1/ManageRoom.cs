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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_v1
{
    public partial class ManageRoom : Form
    {
        int id;

        public ManageRoom()
        {
            InitializeComponent();
        }

        /*private void ManageRoom_Load(object sender, EventArgs e)
        {
            
        }*/

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtRoomNo.Text == "")
                {
                    MessageBox.Show("Room number can't be left empty!");
                    return;
                }
                if (!validation.CheckNumber(txtRoomNo.Text))
                {
                    MessageBox.Show("Error! Room number must be an integer!");
                    return;
                }
                if (txtCost.Text == "")
                {
                    MessageBox.Show("Cost field can't be left empty!");
                    return;
                }
                if (!validation.CheckNumber(txtCost.Text))
                {
                    MessageBox.Show("Error! Cost must be an integer!");
                    return;
                }
                if (availabilityComboBox.Text == "")
                {
                    MessageBox.Show("Availability status can't be left empty!");
                    return;
                }
                if (!validation.CheckAvailability(availabilityComboBox.Text))
                {
                    MessageBox.Show("Error! Incorrect Input");
                    return;
                }
                if (typeComboBox.Text == "")
                {
                    MessageBox.Show("Type can't be left empty!");
                    return;
                }
                if (!validation.CheckRoom(typeComboBox.Text))
                {
                    MessageBox.Show("Error! Incorrect Input");
                    return;
                }

                Room r = new Room(int.Parse(txtRoomNo.Text), int.Parse(txtCost.Text), availabilityComboBox.SelectedValue.ToString(), typeComboBox.SelectedValue.ToString());
                RoomDL.addRoom(r);

                MessageBox.Show("Room Added Successfully!");

                clearAll();
            }
            catch
            {
                MessageBox.Show("Error! Please Try Again.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNo.Text == "")
                {
                    MessageBox.Show("Room number can't be left empty!");
                    return;
                }
                if (!validation.CheckNumber(txtRoomNo.Text))
                {
                    MessageBox.Show("Error! Room number must be an integer!");
                    return;
                }
                if(validation.roomExist(txtRoomNo.Text))
                {
                    MessageBox.Show("Room Number already exist");
                    return;
                }
                if (txtCost.Text == "")
                {
                    MessageBox.Show("Cost field can't be left empty!");
                    return;
                }
                if (!validation.CheckNumber(txtCost.Text))
                {
                    MessageBox.Show("Error! Cost must be an integer!");
                    return;
                }
                if (availabilityComboBox.Text == "")
                {
                    MessageBox.Show("Availability status can't be left empty!");
                    return;
                }
                if (!validation.CheckAvailability(availabilityComboBox.Text))
                {
                    MessageBox.Show("Error! Incorrect Input");
                    return;
                }
                if (typeComboBox.Text == "")
                {
                    MessageBox.Show("Type can't be left empty!");
                    return;
                }
                if (!validation.CheckRoom(typeComboBox.Text))
                {
                    MessageBox.Show("Error! Incorrect Input");
                    return;
                }

                Room r = new Room(int.Parse(txtRoomNo.Text), int.Parse(txtCost.Text), availabilityComboBox.SelectedValue.ToString(), typeComboBox.SelectedValue.ToString());
                r.RoomId = id;
                RoomDL.updateRoom(r);

                MessageBox.Show("Room Updated Successfully!");

                clearAll();
            }
            catch
            {
                MessageBox.Show("Error! Please Try Again.");
            }
        }

        private void ManageRoom_Load_1(object sender, EventArgs e)
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
            roomGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.ForeColor = Color.White;

            //backend
            btnUpdate.Enabled = false;
            roomGrid.DataSource = RoomDL.retrieveRoom();

            availabilityComboBox.DataSource = LookUpDL.retrieveLookUp("Availability");
            availabilityComboBox.ValueMember = "Value";
            availabilityComboBox.Enabled = false;

            typeComboBox.DataSource = LookUpDL.retrieveLookUp("Room Type");
            typeComboBox.ValueMember = "Value";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OwnerDashboard f = new OwnerDashboard();
            f.Show();
            this.Hide();
        }

        private void clearAll()
        {
            btnUpdate.Enabled = false;
            txtRoomNo.Text = "";
            txtCost.Text = "";
        }

        private void roomGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.roomGrid.Rows[e.RowIndex];

                id = int.Parse(row.Cells["RoomId"].Value.ToString());
                int roomNo = int.Parse(row.Cells["RoomNo"].Value.ToString());
                int costPerHour = int.Parse(row.Cells["CostPerHour"].Value.ToString());
                int availability = int.Parse(row.Cells["Availability"].Value.ToString());
                int type = int.Parse(row.Cells["Type"].Value.ToString());

                LookUp a = LookUpDL.retrieveLookUp(availability);
                LookUp t = LookUpDL.retrieveLookUp(type);

                txtRoomNo.Text = roomNo.ToString();
                txtCost.Text = costPerHour.ToString();

                availabilityComboBox.SelectedValue = a.Value;
                typeComboBox.SelectedValue = t.Value;

                btnUpdate.Enabled = true;
            }
            else if(e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.roomGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["RoomId"].Value.ToString());

                RoomDL.removeRoom(id);
            }
        }
    }
}
