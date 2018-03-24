using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AlQuaedaAirlines
{
    public partial class FormGrafo : Form
    {
        Grafo g;
        List<Vuelo> listavuelos;    
        public FormGrafo(ref Grafo g, ref List<Vuelo> listavuelos)
        {
            this.g = g;
            this.listavuelos = listavuelos;
            InitializeComponent();
            //mostrarGrafo();
        }

        private void actualizarLista()
        {
            listView1.Items.Clear();
            for (int i = 0; i < g.getNodosCount(); i++)
            {
                string[] c = new string[4];
                c[0] = i.ToString();
                c[1] = g.getNodo(i).getCiudad().getNom().ToString();
                ListViewItem itm = new ListViewItem(c);
                listView1.Items.Add(itm);
            }
        }

        private void mostrarGrafo()
        {
            Pen pen1 = new Pen(Color.Black, 1);
            Pen pen2 = new Pen(Color.Red, 2);
            SolidBrush nomCiudad = new SolidBrush(Color.Black);
            //panel1.CreateGraphics().DrawEllipse(pen1, 25, 25, panel1.Width - 50, panel1.Height - 50);
            AdjustableArrowCap flecha = new AdjustableArrowCap(3, 5);
            pen2.CustomEndCap = flecha;

            double a = 2 * Math.PI / g.getNodosCount();
            int r = (panel1.Width - 50) / 2;
            for (int i = 0; i < g.getNodosCount(); i++)
            {

                int x = Convert.ToInt32(Math.Cos(i * a) * r + r + 10);
                int y = Convert.ToInt32(Math.Sin(i * a) * r + r + 10);


                panel1.CreateGraphics().DrawEllipse(pen2, x, y, 16, 16);
                panel1.CreateGraphics().DrawString(g.getNodo(i).getCiudad().getNom(), DefaultFont, nomCiudad, x + 3, y + 2);
                g.getNodo(i).getCiudad().setxy(x + 8, y + 8);
                //para flechas (pendiente (y2-y1/x2-x1)) arctangente(m)


            }
            for (int i = 0; i < g.getNodosCount(); i++)
            {
                Nodo n1 = g.getNodo(i);
                for (int j = 0; j < n1.getAdyCount(); j++)
                {
                    Nodo n2 = n1.getAdy(j).getNodo();
                    int x1 = n1.getCiudad().getX();
                    int y1 = n1.getCiudad().getY();
                    int x2 = n2.getCiudad().getX();
                    int y2 = n2.getCiudad().getY();
                    panel1.CreateGraphics().DrawLine(pen2, x1, y1, x2, y2);
                    panel1.CreateGraphics().DrawString(n1.getAdy(j).getPrecio().ToString(), DefaultFont, nomCiudad, (x1 + x2) / 2, (y1 + y2) / 2);
                }
            }

        }

        private void FormGrafo_Load(object sender, EventArgs e)
        {
            mostrarGrafo();
        }

        private void CargarGrabutton_Click(object sender, EventArgs e)
        {
            mostrarGrafo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            mostrarGrafo();
            actualizarLista();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            string rutaE = listView1.FocusedItem.SubItems[1].Text;
            int c = Convert.ToInt32(listView1.FocusedItem.Text);
            for (int i = 0; i < listavuelos.Count; i++)
            {
                if (listavuelos[i].getO() == rutaE || listavuelos[i].getD() == rutaE)
                {
                    string origen = listavuelos[i].getO();
                    string des = listavuelos[i].getD();
                    //eliminar de la lista
                    listavuelos.Remove(listavuelos[i]);
                    i--;
                    int x = 0;
                    //eliminar del grafo
                    bool existeEnlace = false;
                    for (int j = 0; j < g.getNodosCount(); j++)
                    {
                        for (int k = 0; k < g.getNodo(j).getAdyCount(); k++)
                        {
                            if (g.getNodo(j).getCiudad().getNom() == origen && g.getNodo(j).getAdy(k).getNodo().getCiudad().getNom() == des)
                            {
                                g.getNodo(j).eliminaAdy(k);
                                existeEnlace = true;
                                break;
                            }
                        }
                        if (existeEnlace)
                        {
                            break;
                        }
                    }
                    while (x < g.getNodosCount())
                    {
                        existeEnlace = false;
                        for (int j = 0; j < g.getNodosCount(); j++)
                        {
                            for (int k = 0; k < g.getNodo(j).getAdyCount(); k++)
                            {

                                if (g.getNodo(j).getAdy(k).getNodo().getCiudad().getNom() == g.getNodo(x).getCiudad().getNom())
                                {
                                    existeEnlace = true;
                                    break;
                                }
                            }
                            if (existeEnlace)
                            {
                                break;
                            }
                        }
                        if (g.getNodo(x).getAdyCount() == 0 && !existeEnlace)
                        {
                            g.eliminarNodoActual(x);
                        }
                        else
                        {
                            x++;
                        }
                    }
                }
            }
            this.Refresh();
            actualizarLista();
        }

        private void regresarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
