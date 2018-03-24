using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlQuaedaAirlines
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Vuelo> listavuelos = new ListaVuelos();
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
            v1 = new Vuelo("A", "B", 0, 0, 11, 9, 2001, 600, 50, 2);
            v2 = new Vuelo("A", "F", 4, 20, 12, 9, 2001, 1050, 90, 2);
            v3 = new Vuelo("A", "G", 9, 11, 20, 4, 2001, 1150, 80, 1);
            v4 = new Vuelo("B", "A", 8, 30, 21, 12, 2012, 600, 50, 4);
            v5 = new Vuelo("B", "C", 20, 30, 1, 1, 2000, 750, 40, 3);
            v6 = new Vuelo("B", "D", 9, 55, 11, 3, 1996, 650, 60, 2);
            v7 = new Vuelo("B", "Q", 13, 25, 30, 4, 1994, 1850, 70, 1);
            v8 = new Vuelo("C", "D", 10, 10, 11, 4, 2005, 800, 35, 2);
            v9 = new Vuelo("C", "E", 11, 11, 9, 5, 2003, 850, 50, 3);
            v10 = new Vuelo("E", "C", 10, 50, 16, 9, 2016, 750, 45, 2);
            v11 = new Vuelo("E", "G", 14, 45, 31, 10, 2016, 1150, 80, 1);
            v12 = new Vuelo("E", "L", 5, 10, 14, 2, 2017, 1650, 60, 1);
            v13 = new Vuelo("E", "D", 2, 40, 21, 3, 2017, 700, 35, 2);
            v14 = new Vuelo("D", "E", 21, 0, 25, 12, 2016, 900, 45, 3);
            v15 = new Vuelo("D", "B", 22, 0, 30, 4, 2017, 700, 55, 2);
            v16 = new Vuelo("F", "B", 0, 0, 12, 12, 2012, 800, 65, 4);
            v17 = new Vuelo("F", "L", 15, 35, 15, 9, 1910, 2850, 140, 1);
            v18 = new Vuelo("G", "A", 9, 45, 21, 7, 1987, 1250, 95, 3);
            v19 = new Vuelo("G", "E", 8, 30, 11, 9, 2001, 1175, 75, 1);
            v20 = new Vuelo("G", "L", 20, 20, 28, 2, 1459, 2675, 135, 3);
            v21 = new Vuelo("G", "J", 4, 20, 1, 5, 2020, 1400, 60, 2);
            v22 = new Vuelo("G", "H", 16, 20, 4, 7, 2025, 450, 25, 1);
            v23 = new Vuelo("H", "G", 9, 15, 5, 5, 1906, 350, 30, 3);
            v24 = new Vuelo("H", "I", 19, 45, 19, 11, 2019, 400, 35, 1);
            v25 = new Vuelo("I", "H", 16, 40, 6, 6, 2006, 400, 30, 4);
            v26 = new Vuelo("I", "K", 4, 50, 14, 3, 2016, 400, 35, 1);
            v27 = new Vuelo("K", "I", 10, 15, 28, 6, 2032, 400, 35, 3);
            v28 = new Vuelo("K", "J", 18, 10, 11, 9, 2001, 300, 25, 1);
            v29 = new Vuelo("J", "L", 10, 40, 22, 2, 2022, 750, 40, 2);
            v30 = new Vuelo("J", "M", 12, 0, 12, 12, 2012, 1450, 70, 2);
            v31 = new Vuelo("L", "M", 12, 5, 4, 4, 2004, 650, 40, 2);
            v32 = new Vuelo("L", "K", 13, 15, 30, 8, 2008, 700, 70, 1);
            v33 = new Vuelo("L", "E", 21, 0, 7, 7, 2017, 1550, 60, 3);
            v34 = new Vuelo("M", "L", 4, 20, 14, 9, 2016, 700, 40, 2);
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

            PrincipalForm ventanaPrincipal = new PrincipalForm(ref listavuelos);
            ventanaPrincipal.ShowDialog();
            //listavuelos.guardar();
        }
    }
}
