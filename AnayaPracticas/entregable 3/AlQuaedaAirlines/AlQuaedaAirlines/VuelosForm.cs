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
    public partial class VuelosForm : Form
    {
        List<Vuelo> listavuelos;
        Grafo g;
        public VuelosForm(ref List<Vuelo> listavuelos, ref Grafo g)
        {
            this.listavuelos = listavuelos;
            InitializeComponent();       
            actualiza();    
            reservarbutton.Enabled = false;
            
        }
        
        private void actualiza()
        {
            listViewVuelos.Items.Clear();
            for (int i = 0; i < listavuelos.Count(); i++)
            {
                string[] item = new string[7];

                item[0] = listavuelos[i].getRuta();
                item[1] = listavuelos[i].getNumAsientosDisponibles().ToString();
                item[2] = listavuelos[i].getCosto().ToString();
                item[3] = listavuelos[i].getDuracion().ToString();
                item[4] = listavuelos[i].getFechaS();
                item[5] = listavuelos[i].getHora();
                item[6] = i.ToString();

                ListViewItem vue = new ListViewItem(item);
                listViewVuelos.Items.Add(vue);

            }
        }
        private void reservarbutton_Click(object sender, EventArgs e)
        {

            int ind = Int32.Parse(listViewVuelos.FocusedItem.SubItems[6].Text);
            string cad = listViewVuelos.FocusedItem.SubItems[1].Text;

            FormFormulario formulario = new FormFormulario(listavuelos,ref g, ind);
            this.Visible = false;
            formulario.ShowDialog();
            this.Visible = true;
            actualiza();
            if (formulario.asientoSelec == -1 || !formulario.getAllFinish())
                reservarbutton.Enabled = false;
        }

        private void listViewVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            reservarbutton.Enabled = true;
            reservarbutton.TabIndex = listViewVuelos.TabIndex;
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
