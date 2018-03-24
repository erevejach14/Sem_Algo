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
    public partial class FormAuctVuelos : Form
    {
        ListaVuelos listavuelos;
        public FormAuctVuelos(ref ListaVuelos listavuelos)
        {
            this.listavuelos = listavuelos;
            InitializeComponent();
            actualizaListView();
        }
        void actualizaListView()
        {
            listViewVuelos.Items.Clear();
            for (int i = 0; i < listavuelos.Count; i++)
            {
                string[] s = new string[7];
                s[0] = i.ToString();
                s[1] = listavuelos[i].getRuta();
                s[2] = listavuelos[i].contarDisponibles().ToString();
                s[3] = "$" + listavuelos[i].getCosto().ToString();
                s[4] = listavuelos[i].getDuracion() + " Minutos";
                s[5] = listavuelos[i].getFechaS();
                s[6] = listavuelos[i].getHora();
                ListViewItem lvi = new ListViewItem(s);
                listViewVuelos.Items.Add(lvi);
            }
        }
    }
}
