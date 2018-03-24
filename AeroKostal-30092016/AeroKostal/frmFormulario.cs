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
    public partial class Form1 : Form
    {
        List<Vuelo> listaVuelos;
        int ind;
        public Form1(ref List<Vuelo> listaVuelos, int ind)
        {
            this.listaVuelos = listaVuelos;
            this.ind = ind;
            InitializeComponent();
            label1.Text = listaVuelos[ind].ToString();
            lblAsiento.Text="";
            button1.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAsiento_Click(object sender, EventArgs e)
        {
            FrmAsientos AsDisp = new FrmAsientos(ref listaVuelos,ind);
            AsDisp.ShowDialog();
            lblAsiento.Text = AsDisp.getAsientoSelec().ToString();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaVuelos[ind].setAsientos(Int32.Parse(lblAsiento.Text)-1);
            listaVuelos[ind].contarDisponibles();
            this.Close();
        }
    }
}
