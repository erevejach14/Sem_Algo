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
    public partial class FormGrafo2 : Form
    {
        Grafo g;
        Ciudad c1;
        Ciudad c2;

        public FormGrafo2(Grafo g, Ciudad c)
        {
            InitializeComponent();
            this.g = g;
            this.c1 = c;
        }


        public FormGrafo2(Grafo g, Ciudad c1, Ciudad c2)
        {
            InitializeComponent();
            this.g = g;
            this.c1 = c1;
            this.c2 = c2;
            mostrarGrafo();
        }

        private void mostrarGrafo()
        {
            //Pen pen1 = new Pen(Color.Black, 1);
            //for (int i = 0; i < g.getNodosCount(); i++)
            //{
            //    int x = g.getNodo(i).getCiudad().getX();
            //    int y = g.getNodo(i).getCiudad().getY();
            //    panel1.CreateGraphics().DrawEllipse(pen1,x-10,y-10,20,20);

            //}
            Pen pen2 = new Pen(Color.Red, 2);

            SolidBrush nomCiudad = new SolidBrush(Color.Black);
            //panel1.CreateGraphics().DrawEllipse(pen1, 25, 25, panel1.Width - 50, panel1.Height - 50);

            double a = 2 * Math.PI / g.getNodosCount();

            int r = (panel1.Width - 50) / 2;
            for (int i = 0; i < g.getNodosCount(); i++)
            {

                int x = Convert.ToInt32(Math.Cos(i * a) * r + r + 25 - 8);
                int y = Convert.ToInt32(Math.Sin(i * a) * r + r + 25 - 8);
                System.Console.WriteLine(x + " x");
                System.Console.WriteLine(y + " y");

                panel1.CreateGraphics().DrawEllipse(pen2, x, y, 16, 16);
                g.getNodo(i).getCiudad().setxy(x, y);

                panel1.CreateGraphics().DrawString(g.getNodo(i).getCiudad().getNom(), DefaultFont, nomCiudad, x + 3, y + 2);
                //para flechas (pendiente (y2-y1/x2-x1)) arctangente(m)
            }
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X + " " + e.Y);
            mostrarGrafo();
            
        }

        
    }
}
