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
    public partial class FrmAsientos : Form
    {
        List<Vuelo> listavuelos;
        int ind;
        public int asientoSelec;
        public FrmAsientos(ref List<Vuelo> listavuelos, int ind)
        {
            this.listavuelos = listavuelos;
            this.ind = ind;
            asientoSelec = -1;
            InitializeComponent();
            inicializaAsientos();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            asientoSelec = Int32.Parse(boton.Text);
            this.Close();
        }
        public int getAsientoSelec(){
            return asientoSelec;
        }

        private void inicializaAsientos()
        {
            for (int i = 0; i < 20; i++)
            {
                if (listavuelos[ind].getAsientos(i))
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
    }
}
