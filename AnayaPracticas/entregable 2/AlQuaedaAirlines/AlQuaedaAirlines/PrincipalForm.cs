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
        public PrincipalForm(ref List<Vuelo> listavuelos)
        {
            this.listavuelos = listavuelos;

            InitializeComponent();
        }

        private void VuelosButton_Click(object sender, EventArgs e)
        {
            VuelosForm ventanavuelos = new VuelosForm(ref listavuelos);
            Visible = false;
            ventanavuelos.ShowDialog();
            Visible = true;
        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            ControlVeulosForm ventanaControl = new ControlVeulosForm(ref listavuelos, 0);
            Visible = false;
            ventanaControl.ShowDialog();
            Visible = true;
        }

        private void VusquedaVuelosbutton_Click(object sender, EventArgs e)
        {

            ControlVeulosForm ventanaControl = new ControlVeulosForm(ref listavuelos, 1);
            Visible = false;
            ventanaControl.ShowDialog();
            Visible = true;
        }
    }
}
