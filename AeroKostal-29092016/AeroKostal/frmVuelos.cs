using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AeroKostal
{
    public partial class frmVuelos : Form
    {
        List<Vuelo> listavuelos;

        public frmVuelos(ref List<Vuelo> listavuelos)
        {
            this.listavuelos = listavuelos;
            InitializeComponent();
            actualizaListBox();

        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            string cad = listBox1.SelectedItem.ToString();
            Form1 ventanaFormulario = new Form1(ref listavuelos, ind);
            ventanaFormulario.ShowDialog();
            this.Close();
        }
        void actualizaListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < listavuelos.Count; i++)
            {
                listBox1.Items.Add(listavuelos[i]);
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_venta.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
