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
        ListaVuelos listaVuelos;
        int ind;
        public Form1(ref ListaVuelos listaVuelos, int ind)
        {
            this.listaVuelos = listaVuelos;
            this.ind = ind;
            InitializeComponent();
            label1.Text = listaVuelos[ind].getRuta();
            labelAsiento.Text="";
            button1.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAsiento_Click(object sender, EventArgs e)
        {
            FormAsientos AsDisp = new FormAsientos(ref listaVuelos,ind);
            AsDisp.ShowDialog();
            labelAsiento.Text = AsDisp.getAsientoSelec().ToString();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pasajero p = new Pasajero(textBoxNombre.Text,textBoxApellidos.Text,textBoxEdad.Text,labelAsiento.Text);
            listaVuelos[ind].setPasajero(p);
            listaVuelos[ind].setAsientos(Int32.Parse(labelAsiento.Text)-1);
            listaVuelos[ind].contarDisponibles();
            this.Close();
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
