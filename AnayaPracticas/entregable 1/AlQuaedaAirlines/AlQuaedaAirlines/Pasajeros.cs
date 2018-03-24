using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlQuaedaAirlines
{
    public class Pasajeros
    {
        Pasajeros(){}
        public Pasajeros(string nombre, string apellido, string edad, string asiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.asiento = asiento;
        }

        public Pasajeros(string datos)
        {
            string nom = "";
            string ap = "";
            string ed = "";
            string asi = "";
            bool coma = true;
            int z = 0;
            while (coma)
            {
                if (datos[z] != ',')
                {
                    nom += datos[z];
                }
                else
                {
                    coma = false;
                }
                z++;
            }
            coma = true;
            while (coma)
            {
                if (datos[z] != ',')
                {
                    ap += datos[z];
                }
                else
                {
                    coma = false;
                }
                z++;
            }
            for (int i = 0; i < 2; i++)
            {
                ed += datos[z];
                z++;
            }
            for (int i = 0; i < 2; i++)
            {
                asi += datos[z];
                z++;
            }
            this.nombre = nom;
            this.apellido = ap;
            this.edad = Int32.Parse(ed).ToString();
            this.asiento = Int32.Parse(asi).ToString();
        }
        string nombre;
        string apellido;
        string edad;
        string asiento;
        public string getApNom()
        {
            return nombre + " " + apellido;
        }
        public string getAsiento()
        {
            return asiento;
        }
        public string guardarS()
        {
            string nAsiento = "";
            string nEdad = "";
            int w = asiento.Length;
            if (edad.Length < 2) nEdad += 0;
            nEdad += edad;
            if (asiento.Length < 2) nAsiento += 0;
            nAsiento += asiento;
            return nombre + "," + apellido + "," + nEdad + nAsiento;
        }
    }
}
