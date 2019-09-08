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
    public partial class OpcionDataGridview : Form
    {
        public OpcionDataGridview()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            dtregistros.Rows.Add(txtcedula.Text, txtnombre.Text, txtedad.Text);
            MessageBox.Show("Registro guardado exitosamente");
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtedad.Text = "";
            txtcedula.Focus();

        }

        private void dtregistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcedula.Text = dtregistros.Rows[dtregistros.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dtregistros.Rows[dtregistros.CurrentRow.Index].Cells[1].Value.ToString();
            txtedad.Text = dtregistros.Rows[dtregistros.CurrentRow.Index].Cells[2].Value.ToString();

            dtregistros.Rows.RemoveAt(dtregistros.CurrentRow.Index);


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int fila = int.Parse(txtfila.Text);
            dtregistros.CurrentCell = dtregistros.Rows[(fila - 1)].Cells[0];

            DialogResult respuesta = MessageBox.Show("estás seguro de eliminar?"
                    ,"validación de respuesta"
                    ,MessageBoxButtons.YesNo
                    ,MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) {
                dtregistros.Rows.RemoveAt(dtregistros.CurrentRow.Index);
                txtfila.Text = "";
                //txtfila.Focus();
                txtcedula.Focus();
            }
            else {
                txtfila.Focus();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
