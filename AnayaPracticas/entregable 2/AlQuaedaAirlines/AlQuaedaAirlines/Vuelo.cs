using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlQuaedaAirlines
{
    [Serializable]
    public class Vuelo
    {
        string o;
        string d;
        int tipo;
        int type;
        //DateTime fecha;

        int hora;
        int minuto;
        int dia;
        int mes;
        int anio;
        DateTime fecha;
        int costo;
        int duracion;
        bool[] asientosDisp;
        int numAsientosDisp;
        public List<Pasajeros> listaP;
        public Vuelo(string o, string d, int hora, int minuto, int dia, int mes, int anio, int costo, int duracion, int tipo)
        {
            this.tipo = tipo;
            type = (((tipo % 4)+1) * 10);

            this.o = o;
            this.d = d;
            this.fecha = new DateTime(anio, mes, dia, hora, minuto, 0);
            this.hora = hora;
            this.minuto = minuto;
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;

            this.asientosDisp = new bool[type];
            this.costo = costo;
            this.duracion = duracion;
            inicializaAsientos();
            this.numAsientosDisp = contarDisponibles();
            this.listaP = new List<Pasajeros>();
        }

        public int getTipo()
        {
            return tipo;
        }
        public Vuelo(string o, string d, DateTime fecha, int costo, int duracion, int tipo)
        {
            this.o = o;
            this.d = d;
            this.fecha = fecha;
            this.tipo = tipo;
            type = (((tipo % 4) + 1) * 10);
            this.asientosDisp = new bool[type];
            this.costo = costo;
            this.duracion = duracion;
            inicializaAsientos();
            this.numAsientosDisp = contarDisponibles();
            this.listaP = new List<Pasajeros>();
        }
        public override string ToString()
        {
            //return "Origen " + o + " Destino: " + d + " Disponibles: " + numAsientosDisp.ToString() + " Fecha: " + fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " Salida: " + fecha.TimeOfDay;
            return "Ruta: " + getRuta() + " Disponibles: " + numAsientosDisp.ToString() /*+ " Fecha: " + fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " Salida: " + fecha.TimeOfDay + " Costo: " + costo + " Duracion: " + duracion + " mins."*/;
        }
        public string getRuta()
        {
            return "SK1" + o + d;
        }
        public int getCosto()
        {
            return costo;
        }
        public int getDuracion()
        {
            return duracion;
        }
        public string getFechaS()
        {
            return dia + "/" + mes + "/" + anio;
        }
        public string getHora()
        {
            return hora + ":" + minuto;
        }
        public void setAsientos(int ind)
        {
            this.asientosDisp[ind] = false;
        }
        public void setAsientosLibre(int ind)
        {
            this.asientosDisp[ind] = true;
        }
        public bool getAsientos(int ind)
        {
            return asientosDisp[ind];
        }
        public void setPasajero(Pasajeros pasa)
        {
            this.listaP.Add(pasa);
        }
        public Pasajeros getPasajeros(int ind)
        {
            return this.listaP[ind];
        }
        public string getO()
        {
            return o;
        }
        public string getD()
        {
            return d;
        }
        public int contarDisponibles()
        {
            numAsientosDisp = 0;
            for (int i = 0; i < type; i++)
            {
                if (asientosDisp[i] == true)
                {
                    numAsientosDisp += 1;
                }
            }
            return numAsientosDisp;
        }
        public List<Pasajeros> getListaPasajeros()
        {
            return listaP;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public int getNumAsientosDisponibles()
        {
            return numAsientosDisp;
        }
        
        private void inicializaAsientos()
        {
            for (int i = 0; i < type; i++)
            {
                this.asientosDisp[i] = true;
            }
        }


        public void setAsientoOcu(int i)
        {
            asientosDisp[i] = true;
        }
        public bool getAsientoOcu(int i)
        {
            return asientosDisp[i];
        }
        public void setAsientosDisp(int i)
        {
            numAsientosDisp = i;
        }
        public int getAsientosDisp()
        {
            return numAsientosDisp;
        }

    }
}
