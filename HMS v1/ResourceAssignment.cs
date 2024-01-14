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
    public partial class ResourceAssignment : Form
    {
        public ResourceAssignment()
        {
            InitializeComponent();
        }

        private void ResourceAssignment_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6);

            btnHome.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);
            btnHome.ForeColor = Color.White;
            sideMenuPanel.BackColor = Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E);

            removeGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
            addGrid.BackgroundColor = Color.FromArgb(0xFF, 0x65, 0x86, 0xAD);
        }
    }
}
