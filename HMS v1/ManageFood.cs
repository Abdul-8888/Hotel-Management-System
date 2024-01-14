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
using System.Xml.Linq;

namespace HMS_v1
{
    public partial class ManageFood : Form
    {
        public ManageFood()
        {
            InitializeComponent();
        }

        /*private void ManageFood_Load(object sender, EventArgs e)
        {

        }*/

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtDish.Text == "")
            {
                MessageBox.Show("Dish Name can't be left empty!");
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Price can't be left empty!");
            }
            if (!validation.CheckNumber(txtPrice.Text))
            {
                MessageBox.Show("Error! Price must be an integer");
            }

            Food f = new Food(txtDish.Text, int.Parse(txtPrice.Text));
            FoodDL.addFood(f);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDish.Text == "")
            {
                MessageBox.Show("Dish Name can't be left empty!");
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Price can't be left empty!");
            }
            if (!validation.CheckNumber(txtPrice.Text))
            {
                MessageBox.Show("Error! Price must be an integer");
            }

            FoodDL.updateFood(FoodDL.current);
            btnUpdate.Enabled = false;
        }

        private void ManageFood_Load_1(object sender, EventArgs e)
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
            foodGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            btnUpdate.ForeColor = Color.White;

            btnUpdate.Enabled = false;

            //backend
            foodGrid.DataSource = FoodDL.retrieveFood();
        }

        private void foodGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.foodGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["FoodId"].Value.ToString());
                string name = row.Cells["DishName"].Value.ToString();
                int price = int.Parse(row.Cells["Price"].Value.ToString());

                Food b = new Food(id, name, price);
                FoodDL.current = b;

                txtDish.Text = name;
                txtPrice.Text = price.ToString();

                btnUpdate.Enabled = true;
            }

            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.foodGrid.Rows[e.RowIndex];

                int id = int.Parse(row.Cells["FoodId"].Value.ToString());

                FoodDL.deleteFood(id);
            }
        }
    }
}
