using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlQuaedaAirlines
{
    public partial class PrincipalForm : Form
    {
        List<Vuelo> listavuelos;
        Grafo g;
        public PrincipalForm(ref List<Vuelo> listavuelos, ref Grafo g)
        {
            this.listavuelos = listavuelos;
            this.g = g;
        
            InitializeComponent();
        }

        private void VuelosButton_Click(object sender, EventArgs e)
        {
            VuelosForm ventanavuelos = new VuelosForm(ref listavuelos, ref g);
            Visible = false;
            ventanavuelos.ShowDialog();
            Visible = true;
        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            ControlVeulosForm ventanaControl = new ControlVeulosForm(ref listavuelos, ref g, 0);
            Visible = false;
            ventanaControl.ShowDialog();
            Visible = true;
        }

        private void VusquedaVuelosbutton_Click(object sender, EventArgs e)
        {

            ControlVeulosForm ventanaControl = new ControlVeulosForm(ref listavuelos, ref g, 1);
            Visible = false;
            ventanaControl.ShowDialog();
            Visible = true;
        }

        private void Ruta_Click(object sender, EventArgs e)
        {
            FormGrafo ventanaGrafo = new FormGrafo(ref g, ref listavuelos);
            Visible = false;
            ventanaGrafo.ShowDialog();
            Visible = true;
        }
    }
}
