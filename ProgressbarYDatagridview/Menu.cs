﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressbarYDatagridview
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcionDataGridview opcionDataGridview = new OpcionDataGridview();
            opcionDataGridview.Show();
            this.Hide();
        }

        private void btnusogroupbox_Click(object sender, EventArgs e)
        {
            OpcionGroupBox opcionGroupBox = new OpcionGroupBox();
            opcionGroupBox.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
