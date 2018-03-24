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
    public partial class FormVuelos : Form
    {
        ListaVuelos listavuelos;

        public FormVuelos(ref ListaVuelos listavuelos)
        {
            this.listavuelos = listavuelos;
            InitializeComponent();
            actualizaListView();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            int ind =Int32.Parse(listViewVuelos.FocusedItem.SubItems[0].Text);
            string cad = listViewVuelos.FocusedItem.SubItems[1].Text;
            Form1 ventanaFormulario = new Form1(ref listavuelos, ind);
            ventanaFormulario.ShowDialog();
            this.Close();
        }
        void actualizaListView()
        {
            listViewVuelos.Items.Clear();
            for(int i=0;i<listavuelos.Count;i++)
            {
                string []s=new string[7];
                s[0] = i.ToString();
                s[1] = listavuelos[i].getRuta();
                s[2] = listavuelos[i].contarDisponibles().ToString();
                s[3] = "$"+listavuelos[i].getCosto().ToString();
                s[4] = listavuelos[i].getDuracion() + " Minutos";
                s[5] = listavuelos[i].getFechaS();
                s[6] = listavuelos[i].getHora();
                ListViewItem lvi = new ListViewItem(s);
                listViewVuelos.Items.Add(lvi);
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_venta.Enabled = true;
        }
        private void listViewVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_venta.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOrdenFecha_Click(object sender, EventArgs e)
        {
            listavuelos.ordenarFecha(0,listavuelos.Count-1);
            listViewVuelos.Items.Clear();
            actualizaListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listavuelos.ordenarDisponiblesInv(0, listavuelos.Count - 1);
            listViewVuelos.Items.Clear();
            actualizaListView();
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewVuelos.Items.Clear();
            for (int i = 0; i < listavuelos.Count; i++)
            {
                if(listavuelos[i].getO()==comboBoxOrigen.Text){
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

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewVuelos.Items.Clear();
            for (int i = 0; i < listavuelos.Count; i++)
            {
                if (listavuelos[i].getD() == comboBoxDestino.Text)
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

        private void comboBoxOrigen_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxDestino.SelectedIndex = -1;
            comboBoxOrigen.SelectedIndex = -1;
        }

        private void comboBoxDestino_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxDestino.SelectedIndex = -1;
            comboBoxOrigen.SelectedIndex = -1;
        }
    }
}
