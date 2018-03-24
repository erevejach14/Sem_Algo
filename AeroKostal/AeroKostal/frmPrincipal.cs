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
    public partial class frmPrincipal : Form
    {
        Vuelo v1;
        Vuelo v2;
        Vuelo v3;
        Vuelo v4;
        Vuelo v5;
        Vuelo v6;
        Vuelo v7;
        Vuelo v8;
        Vuelo v9;
        Vuelo v10;
        Vuelo v11;
        Vuelo v12;
        Vuelo v13;
        Vuelo v14;
        Vuelo v15;
        Vuelo v16;
        Vuelo v17;
        Vuelo v18;
        Vuelo v19;
        Vuelo v20;
        Vuelo v21;
        Vuelo v22;
        Vuelo v23;
        Vuelo v24;
        Vuelo v25;
        Vuelo v26;
        Vuelo v27;
        Vuelo v28;
        Vuelo v29;
        Vuelo v30;
        Vuelo v31;
        Vuelo v32;
        Vuelo v33;
        Vuelo v34;
        List<Vuelo> listavuelos;
        public frmPrincipal()
        {
            listavuelos = new List<Vuelo>();
            v1 = new Vuelo("SK1AB");
            v2 = new Vuelo("SK1AF");
            v3 = new Vuelo("SK1AG");
            v4 = new Vuelo("SK1BA");
            v5 = new Vuelo("SK1BC");
            v6 = new Vuelo("SK1BD");
            v7 = new Vuelo("SK1BD");
            v8 = new Vuelo("SKICD");
            v9 = new Vuelo("SK1CE");
            v10 = new Vuelo("SK1EC");
            v11 = new Vuelo("SK1EG");
            v12 = new Vuelo("SK1EL");
            v13 = new Vuelo("SK1ED");
            v14 = new Vuelo("SK1DE");
            v15 = new Vuelo("SK1DB");
            v16 = new Vuelo("SK1FB");
            v17 = new Vuelo("SK1FL");
            v18 = new Vuelo("SK1GA");
            v19 = new Vuelo("SK1GE");
            v20 = new Vuelo("SK1GL");
            v21 = new Vuelo("SK1GJ");
            v22 = new Vuelo("SK1GH");
            v23 = new Vuelo("SK1HG");
            v24 = new Vuelo("SK1HI");
            v25 = new Vuelo("SK1IH");
            v26 = new Vuelo("SK1IK");
            v27 = new Vuelo("SK1KI");
            v28 = new Vuelo("SK1KJ");
            v29 = new Vuelo("SK1JL");
            v30 = new Vuelo("SK1JM");
            v31 = new Vuelo("SK1LM");
            v32 = new Vuelo("SK1LK");
            v33 = new Vuelo("SK1LE");
            v34 = new Vuelo("SK1ML");
            listavuelos.Add(v1);
            listavuelos.Add(v2);
            listavuelos.Add(v3);
            listavuelos.Add(v4);
            listavuelos.Add(v5);
            listavuelos.Add(v6);
            listavuelos.Add(v7);
            listavuelos.Add(v8);
            listavuelos.Add(v9);
            listavuelos.Add(v10);
            listavuelos.Add(v11);
            listavuelos.Add(v12);
            listavuelos.Add(v13);
            listavuelos.Add(v14);
            listavuelos.Add(v15);
            listavuelos.Add(v16);
            listavuelos.Add(v17);
            listavuelos.Add(v18);
            listavuelos.Add(v19);
            listavuelos.Add(v20);
            listavuelos.Add(v21);
            listavuelos.Add(v22);
            listavuelos.Add(v23);
            listavuelos.Add(v24);
            listavuelos.Add(v25);
            listavuelos.Add(v26);
            listavuelos.Add(v27);
            listavuelos.Add(v28);
            listavuelos.Add(v29);
            listavuelos.Add(v30);
            listavuelos.Add(v31);
            listavuelos.Add(v32);
            listavuelos.Add(v33);
            listavuelos.Add(v34);
            InitializeComponent();
        }


        private void btnVuelos_Click(object sender, EventArgs e)
        {
            frmVuelos ventanaVuelos = new frmVuelos(ref listavuelos);
            //this.Hide();
            ventanaVuelos.ShowDialog();
            //this.Show();
        }

        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            FormPasajeros ventanaPasajeros = new FormPasajeros();
            ventanaPasajeros.ShowDialog();
        }

    }
}
