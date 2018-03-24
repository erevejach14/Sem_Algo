using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlQuaedaAirlines
{
    [Serializable]
    public class Pasajeros
    {
        Pasajeros(){}
        string nombre;
        string apellido;
        string edad;
        string asiento;

        public Pasajeros(string nombre, string apellido, string edad, string asiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.asiento = asiento;
        }

        public string getApNom()
        {
            return nombre + " " + apellido;
        }
        public string getAsiento()
        {
            return asiento;
        }
    }
}
