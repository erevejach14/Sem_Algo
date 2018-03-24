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
            this.Width = 420;
            actualizaListView();
            disableNuevo();
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enableNuevo();
            this.Width=700;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxOrigen.SelectedIndex != -1 && comboBoxDestino.SelectedIndex != -1 && textBoxPrecio.Text != "" && textBoxDuracion.Text != "")
            {
                if (comboBoxOrigen.Text != comboBoxDestino.Text)
                {
                    bool repetido = false;
                    for (int i = 0; i < listavuelos.Count; i++)
                    {
                        if (listavuelos[i].getO() == comboBoxOrigen.Text && listavuelos[i].getD() == comboBoxDestino.Text)
                        {
                            repetido = true;
                        }
                    }
                    if (!repetido)
                    {
                        Vuelo v = new Vuelo(comboBoxOrigen.Text, comboBoxDestino.Text, dateTimePickerFecha.Value.Date, Int32.Parse(textBoxPrecio.Text), Int32.Parse(textBoxDuracion.Text));
                        listavuelos.Add(v);
                        actualizaListView();
                        MessageBox.Show("Hecho!", "+10 Prro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Width = 420;
                        disableNuevo();
                    }
                    else
                    {
                        MessageBox.Show("Vuelo existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No se permite origen y destino idénticos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Datos Faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void listViewVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listavuelos.Remove(listavuelos[listViewVuelos.FocusedItem.Index]);
            actualizaListView();
        }

        private void buttonEA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listavuelos.Count;i++)
            {
                if (listavuelos[i].getFecha() < DateTime.Now)
                {
                    listavuelos.Remove(listavuelos[i]);
                }
            }
            actualizaListView();
        }
        private void enableNuevo()
        {
            comboBoxDestino.Enabled = true;
            comboBoxOrigen.Enabled = true;
            dateTimePickerFecha.Enabled = true;
            textBoxPrecio.Enabled = true;
            textBoxDuracion.Enabled=true;
            buttonGuardar.Enabled = true;
        }
        private void disableNuevo()
        {
            comboBoxDestino.Enabled = false;
            comboBoxOrigen.Enabled = false;
            dateTimePickerFecha.Enabled = false;
            textBoxPrecio.Enabled = false;
            textBoxDuracion.Enabled = false;
            buttonGuardar.Enabled = false;
        }
    }
}
