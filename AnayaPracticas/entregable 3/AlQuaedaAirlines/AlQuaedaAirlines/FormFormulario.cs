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
    public partial class FormFormulario : Form
    {
        List<Vuelo> vuelo;
        int ind;
        int count;
        int tipo;
        bool nomval = false;
        bool apeval = false;
        bool edavel = false;
        bool terminadoExito = false;
        public int asientoSelec;

        bool isClicked = false;

        public FormFormulario(List<Vuelo> v, ref Grafo g, int ind)
        {
            this.ind = ind;
            asientoSelec = -1;
            count = 0;
            vuelo = v;
            int type = v[ind].getTipo();
            tipo = (((type % 4)+1) * 10);
            InitializeComponent();

            inicializaBotones();

            Vuelola.Text = vuelo[ind].getRuta();
            textBoxEdad.MaxLength = 2;
            sellbutton.Enabled = false;
        }

        public int getAsientoSel()
        {
            return asientoSelec;
        }

        private void inicializaBotones()
        {
            for (int i = 0; i < tipo; i++)
            {
                if (vuelo[ind].getAsientos(i))
                {
                    buttons[i].BackColor = Color.Green;
                    buttons[i].Enabled = true;
                }
                else
                {
                    buttons[i].BackColor = Color.Red;
                    buttons[i].Enabled = false;
                }
            }
        }
        public int getind()
        {
            return tipo;
        }


        private void buttons_Click(object sender, EventArgs e)
        {
            inicializaBotones();
            Button boton = sender as Button;
            asientoSelec = Int32.Parse(boton.Text);
            labelAsiento.Text = boton.Text;
            isClicked = true;
            sellbutton.Enabled = true;
            sellbutton.TabIndex = boton.TabIndex;
            boton.BackColor = Color.Violet;
        }

        public bool getAllFinish()
        {
            return terminadoExito;
        }

        public int getAsientoSelec()
        {
            return asientoSelec;
        }


        public bool getIsClick()
        {
            return isClicked;
        }

        private void sellbutton_Click(object sender, EventArgs e)
        {
            if (isValid(nomval, apeval, edavel))
            {
                Pasajeros p = new Pasajeros(textBoxNombre.Text, textBoxApellidos.Text, textBoxEdad.Text, labelAsiento.Text);
                vuelo[ind].setPasajero(p);
                vuelo[ind].setAsientos(Int32.Parse(labelAsiento.Text) - 1);
                vuelo[ind].contarDisponibles();
                labelAsiento.Text = "Asientos Disponibles " + (count - 1);
                terminadoExito = true;

                this.Close();
            }
            
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (Text == "")
                nomval = false;
            for (int i = 0; i < 99; i++)
            {
                if (Text == i.ToString())
                {
                    nomval = false;
                }
                else
                {
                    nomval = true;
                }
            }
        }


        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            if (Text == "")
                apeval = false;
            for (int i = 0; i < 99; i++)
            {
                if (Text == i.ToString())
                    apeval = false;
                else
                    apeval = true;
            }

        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if (Text == "")
                edavel = false;
            else
                edavel = true;
        }

        private bool isValid(bool a, bool b, bool c)
        {
            return a && b && c;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            asientoSelec = -1;
            this.Close();
        }

        private void textBoxNombre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            //if (Char.IsDigit(e.KeyValue)
            {

            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            */
            e.Handled = ((!Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar)) &&  !Char.IsControl(e.KeyChar)) && (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsDigit(e.KeyChar));
        }

        private void textBoxEdad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            */
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxEdad_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
