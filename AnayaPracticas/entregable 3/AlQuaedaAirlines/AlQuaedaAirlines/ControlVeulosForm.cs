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
    public partial class ControlVeulosForm : Form
    { 
        List<Vuelo> listavuelo;
        Grafo g;
        string buscar;
        int tipo;
        public ControlVeulosForm(ref List<Vuelo> listavuelo, ref Grafo g, int tipo)
        {
            this.g = g;
            this.tipo = tipo;
            this.listavuelo = listavuelo;
            InitializeComponent();
            mostrarPantallaIni();


            if (tipo == 0)
            {
                cargarListViewPasajero();
                agregarbutton.Enabled = false;
                agregarbutton.Visible = false;
            }

            else if (tipo == 1)
            {
                cargarListViewVuelo();
                agregarbutton.Enabled = true;
                agregarbutton.Visible = true;
            }


        }
        private void cargarListViewPasajero()
        {
            listViewPaVu.Clear();
            listViewPaVu.Columns.Add("Pasajero", 150);
            listViewPaVu.Columns.Add("Vuelo", 70);
            listViewPaVu.Columns.Add("Asiento", 100);
            listViewPaVu.Columns.Add("I", 5);
            listViewPaVu.Columns.Add("J", 5);
            actualizaListViewPasajero();
        }
        private void actualizaListViewPasajero()
        {
            listViewPaVu.Items.Clear();
            for(int i = 0; i < listavuelo.Count(); i++)
            {
                for (int j = 0; j < listavuelo[i].getListaPasajeros().Count(); j++)
                {
                    string[] item = new string[5];
                    item[0] = listavuelo[i].getPasajeros(j).getApNom();
                    item[1] = listavuelo[i].getRuta();
                    item[2] = listavuelo[i].getPasajeros(j).getAsiento();
                    item[3] = i.ToString();
                    item[4] = j.ToString();

                    ListViewItem pasa = new ListViewItem(item);
                    listViewPaVu.Items.Add(pasa);
                }
            }
        }
        private void cargarListViewVuelo()
        {
            listViewPaVu.Clear();
            listViewPaVu.Columns.Add("Ruta", 50);
            listViewPaVu.Columns.Add("Fecha",75);
            listViewPaVu.Columns.Add("Hora",50);
            listViewPaVu.Columns.Add("Costo", 50);
            listViewPaVu.Columns.Add("Duracion",50);
            listViewPaVu.Columns.Add("Asientos", 30);
            listViewPaVu.Columns.Add("id", 3);
            actualizaListViewVuelo();
        }
        private void actualizaListViewVuelo()
        {
            listViewPaVu.Items.Clear();
            for (int i = 0; i < listavuelo.Count(); i++)
            {
                string[] item = new string[7];
                item[0] = listavuelo[i].getRuta();
                item[1] = listavuelo[i].getFechaS();
                item[2] = listavuelo[i].getHora();
                item[3] = listavuelo[i].getCosto().ToString();
                item[4] = listavuelo[i].getDuracion().ToString();
                item[5] = listavuelo[i].getAsientosDisp().ToString();
                item[6] = i.ToString();
                ListViewItem vue = new ListViewItem(item);
                listViewPaVu.Items.Add(vue);

            }
        }
        
        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar = textBox1.Text;

            List<int> indiEncontradoV = new List<int>();
            List<int> indiEncontradoP = new List<int>();
            Eliminarbutton.Enabled = false;
            string busquedaPor;

            if (tipo == 0)
            {
                if (buscar == "")
                {
                    actualizaListViewPasajero();
                }
                else
                {
                    for (int bu = 0; bu < 3; bu++)
                    {
                        for (int i = 0; i < listavuelo.Count; i++)
                        {
                            for (int j = 0; j < listavuelo[i].getListaPasajeros().Count; j++)
                            {
                                busquedaPor = listavuelo[i].getListaPasajeros()[j].getApNom();

                                if (bu == 1)
                                {
                                    if (buscar == "1")
                                        break;
                                    busquedaPor = listavuelo[i].getRuta();
                                }

                                else if (bu == 2)
                                    busquedaPor = listavuelo[i].getListaPasajeros()[j].getAsiento();


                                encontrado(buscar, busquedaPor, ref indiEncontradoV, ref indiEncontradoP, i, j);
                            }
                        }
                    }
                    actListviewPasajeroEncontrado(ref indiEncontradoV, ref indiEncontradoP);
                }
            }
            else if (tipo == 1)
            {

                if (buscar == "")
                {
                    actualizaListViewVuelo();
                }
                else
                {
                    int tamBusc = buscar.Length;
                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < listavuelo.Count; i++)
                        {
                            busquedaPor = listavuelo[i].getRuta();
                            if (j == 1)
                                busquedaPor = listavuelo[i].getFechaS();
                            else if (j == 2)
                                busquedaPor = listavuelo[i].getHora();
                            encontrado(buscar, busquedaPor, ref indiEncontradoV, ref indiEncontradoP, i, i);
                        }
                    }
                    actListviewVueloEncontrado(ref indiEncontradoV);
                }
            }
        }

        private void encontrado(string buscar, string comparar, ref List<int> indiEncontradoV, ref List<int> indiEcontradoP, int i, int j)
        {
            bool yaIngresado = false;
            int tamBusc = buscar.Length;

            string tmpcomp;

            int tamRealativo;

            tamRealativo = comparar.Length;

            if (tipo == 0)
            {
                for (int o = 0; o < indiEncontradoV.Count; o++)
                {
                    if (indiEncontradoV[o] == i && indiEcontradoP[o] == j)
                    {
                        yaIngresado = true;
                    }
                }

                if (!yaIngresado)
                {
                    for (int k = 0; k <= (tamRealativo - tamBusc); k++)
                    {
                        tmpcomp = comparar.Substring(k, tamBusc);
                        if (buscar == tmpcomp || buscar.ToUpper() == tmpcomp)
                        {
                            indiEcontradoP.Add(j);
                            indiEncontradoV.Add(i);
                            break;
                        }
                    }
                }
            }
            else if (tipo == 1)
            {
                for (int o = 0; o < indiEncontradoV.Count; o++)
                {
                    if (indiEncontradoV[o] == i)
                    {
                        yaIngresado = true;
                    }
                }
                if (!yaIngresado)
                {
                    for (int k = 0; k <= (tamRealativo - tamBusc); k++)
                    {
                        tmpcomp = comparar.Substring(k, tamBusc);
                        if (buscar == tmpcomp || buscar.ToUpper() == tmpcomp)
                        {
                            indiEncontradoV.Add(i);
                            break;
                        }
                    }
                }
            }
        }

        private void actListviewVueloEncontrado(ref List<int> indices)
        {
            listViewPaVu.Items.Clear();
            for(int i = 0; i < indices.Count; i++)
            {
                string[] item = new string[7];
                item[0] = listavuelo[indices[i]].getRuta();
                item[1] = listavuelo[indices[i]].getFechaS();
                item[2] = listavuelo[indices[i]].getHora();
                item[3] = listavuelo[indices[i]].getCosto().ToString();
                item[4] = listavuelo[indices[i]].getDuracion().ToString();
                item[5] = listavuelo[indices[i]].getAsientosDisp().ToString();
                item[6] = indices[i].ToString();
                ListViewItem vue = new ListViewItem(item);
                listViewPaVu.Items.Add(vue);
            }
        }

        private void actListviewPasajeroEncontrado(ref List<int> indicesV, ref List<int> indicesP)
        {
            listViewPaVu.Items.Clear();
            for (int i = 0; i < indicesP.Count; i++)
            {
                string[] item = new string[5];
                item[0] = listavuelo[indicesV[i]].getListaPasajeros()[indicesP[i]].getApNom();
                item[1] = listavuelo[indicesV[i]].getRuta(); 
                item[2] = listavuelo[indicesV[i]].getListaPasajeros()[indicesP[i]].getAsiento();
                item[3] = indicesV[i].ToString();
                item[4] = indicesP[i].ToString();
                ListViewItem vue = new ListViewItem(item);
                listViewPaVu.Items.Add(vue);
            }
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            labeltype.Visible = true;
            labelagre.Visible = true;
            labelori.Visible = true;
            labeldes.Visible = true;
            labelcost.Visible = true;
            labeldu.Visible = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            textBox3.Visible = true;
            textBox3.Enabled = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
            textBox5.Visible = true;
            textBox5.Enabled = true;
            button_cancela.Visible = true;
            button_cancela.Enabled = true;
            button_agrega.Visible = true;
            button_agrega.Enabled = true;

            dateTimePicker1.Visible = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Visible = true;
            dateTimePicker2.Enabled = true;
            
            dateTimePicker1.Value = System.DateTime.Now.Date;
            dateTimePicker2.Value = System.DateTime.Now.Date;

            listViewPaVu.Visible = false;
            listViewPaVu.Enabled = false;
            textBox1.Visible = false;
            agregarbutton.Visible = false;
            Eliminarbutton.Visible = false;
            cancelarbutton.Visible = false;
            textBox1.Enabled = false;
            agregarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            cancelarbutton.Enabled = false;
            textBoxTipo.Visible = true;
            textBoxTipo.Enabled = true;

            this.Size = new System.Drawing.Size(447, 278);
        }

        private void button_cancela_Click(object sender, EventArgs e)
        {


            mostrarPantallaIni();
        }

        private void button_agrega_Click(object sender, EventArgs e)
        {
            string destino = textBox2.Text;
            string origen = textBox5.Text;

            bool exist = false;
            if (comprobar())
            {
                string ruta = "SK1" + origen + destino;
                for (int l = 0; l < listavuelo.Count; l++)
                {
                    if (listavuelo[l].getRuta() == ruta)
                    {
                        MessageBox.Show("No se puede agregar un vuelo que ya exsiste");
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    int tipo = Int32.Parse(textBoxTipo.Text);
                    int duracion = Int32.Parse(textBox4.Text);
                    int costo = Int32.Parse(textBox3.Text);

                    DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text + " " + dateTimePicker2.Text);

                    Vuelo vuelo = new Vuelo(origen, destino, fecha, costo, duracion, tipo);
                    listavuelo.Add(vuelo);
                    int nodoO = g.existeNodo(origen);
                    Ciudad c2 = new Ciudad(vuelo.getD());
                    if (nodoO == -1)
                    {
                        Ciudad c1 = new Ciudad(vuelo.getO());
                        g.insertaNodo(c1);

                        Nodo n1 = g.getNodo(g.getNodosCount()-1);
                        Nodo n2 = new Nodo(c2);
                        g.insertarAdy(n1, n2, costo, duracion);
                        g.insertaNodo(c2);
                        FormGrafo2 ventanaGrafo = new FormGrafo2(g, c1,c2);
                        ventanaGrafo.ShowDialog();
                    }
                    else
                    {
                        Nodo n1 = g.getNodo(nodoO);
                        Nodo n2 = new Nodo(c2);
                        g.insertarAdy(g.getNodo(nodoO), n2, costo, duracion);
                        FormGrafo2 ventanaGrafo = new FormGrafo2(g, c2);
                        ventanaGrafo.ShowDialog();
                    }
                    
                }
                mostrarPantallaIni();
            }
        }
        private bool comprobar()
        {
            if (textBox5.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Favor de incluir un origen y un destino");
                return false;
            }
            else if (textBox5.Text == textBox2.Text)
            {
                MessageBox.Show("No se puede agregar un vuelo con el mismo destino y origen");
                return false;
            }

            else if ((textBox3.Text == "" || textBox4.Text == "" || textBoxTipo.Text == "") && (textBox5.Text != "" || textBox2.Text != ""))
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return false;
            }
            return true;
        }

        private void mostrarPantallaIni()
        {
            this.Size = new System.Drawing.Size(581, 278);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            labeltype.Visible = false;
            labelagre.Visible = false;
            labelori.Visible = false;
            labeldes.Visible = false;
            labelcost.Visible = false;
            labeldu.Visible = false;
            textBox2.Visible = false;
            textBox2.Enabled = false;
            textBox3.Visible = false;
            textBox3.Enabled = false;
            textBox4.Visible = false;
            textBox4.Enabled = false;
            textBox5.Visible = false;
            textBox5.Enabled = false;
            button_cancela.Visible = false;
            button_cancela.Enabled = false;
            button_agrega.Visible = false;
            button_agrega.Enabled = false;

            dateTimePicker1.Visible = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Visible = false;
            dateTimePicker2.Enabled = false;

            listViewPaVu.Visible = true;
            listViewPaVu.Enabled = true;
            textBox1.Visible = true;
            agregarbutton.Visible = true;
            Eliminarbutton.Visible = true;
            cancelarbutton.Visible = true;
            textBox1.Enabled = true;
            agregarbutton.Enabled = true;
            Eliminarbutton.Enabled = true;
            cancelarbutton.Enabled = true;
            textBoxTipo.Visible = false;
            textBoxTipo.Enabled = false;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int eliminar;
            int eliminar1;

            if (tipo == 1)
            {
                eliminar = Int32.Parse(listViewPaVu.FocusedItem.SubItems[5].Text);
                listavuelo.Remove(listavuelo[eliminar]);

                actualizaListViewVuelo();
            }

            else if(tipo == 0)
            {
                eliminar = Int32.Parse(listViewPaVu.FocusedItem.SubItems[3].Text);
                eliminar1 = Int32.Parse(listViewPaVu.FocusedItem.SubItems[4].Text);

                listavuelo[eliminar].setAsientosLibre(Int32.Parse(listavuelo[eliminar].getPasajeros(eliminar1).getAsiento()) - 1);
                listavuelo[eliminar].contarDisponibles();
                listavuelo[eliminar].getListaPasajeros().Remove(listavuelo[eliminar].getListaPasajeros()[eliminar1]);
                actualizaListViewPasajero();
            }
        }
    }
}
