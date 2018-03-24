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
    public partial class FormPrincipal : Form
    {
        ListaVuelos listavuelos;
        public FormPrincipal(ref ListaVuelos listaVuelos)
        {
            this.listavuelos = listaVuelos;
            InitializeComponent();
        }


        private void btnVuelos_Click(object sender, EventArgs e)
        {
            FormVuelos ventanaVuelos = new FormVuelos(ref listavuelos);
            //this.Hide();
            ventanaVuelos.ShowDialog();
            //this.Show();
        }

        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            FormPasajeros ventanaPasajeros = new FormPasajeros(ref listavuelos);
            ventanaPasajeros.ShowDialog();
        }

        private void buttonVuelos_Click(object sender, EventArgs e)
        {
            FormAuctVuelos ventanaVuelosauc = new FormAuctVuelos(ref listavuelos);
            ventanaVuelosauc.ShowDialog();
        }

    }
}
