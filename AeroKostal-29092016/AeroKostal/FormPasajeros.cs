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
    public partial class FormPasajeros : Form
    {
        ListaVuelos listaVuelos;
        public FormPasajeros(ref ListaVuelos listaVuelos)
        {
            InitializeComponent();
            buttonEliminar.Enabled = false;
            this.listaVuelos = listaVuelos;
            actualizaListView();
        }
        void actualizaListView()
        {
            string []s=new string[5];
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                for (int j = 0; j < listaVuelos[i].getListaPasajeros().Count; j++)
                {
                    s[0] = i.ToString();
                    s[1] = listaVuelos[i].getRuta();
                    s[2] = listaVuelos[i].getPasajero(j).getApNom();
                    s[3] = listaVuelos[i].getPasajero(j).getAsiento();
                    s[4] = j.ToString();
                    ListViewItem itm = new ListViewItem(s);
                    listView1.Items.Add(itm);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(listView1.FocusedItem.SubItems[0].Text);
            int j = Int32.Parse(listView1.FocusedItem.SubItems[4].Text);
            int a = Int32.Parse(listView1.FocusedItem.SubItems[3].Text) - 1;
            listaVuelos[i].getListaPasajeros().Remove(listaVuelos[i].getListaPasajeros()[j]);
            listaVuelos[i].setAsientosLibre(a);
            listView1.Items.Clear();
            actualizaListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
        }
    }
}
