using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlQuaedaAirlines
{
    public class Vuelo
    {
        string o;
        string d;
        int tipo;
        int type;
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
        public Vuelo(string o, string d, DateTime fecha, int costo, int duracion)
        {
            this.o = o;
            this.d = d;
            this.fecha = fecha;
            this.asientosDisp = new bool[type];
            this.costo = costo;
            this.duracion = duracion;
            inicializaAsientos();
            this.numAsientosDisp = contarDisponibles();
            this.listaP = new List<Pasajeros>();
        }
        /*
        public Vuelo(string datos)
        {
            this.listaP = new List<Pasajeros>();
            this.asientosDisp = new bool[type];
            inicializaAsientos();
            this.o = datos[0].ToString();
            this.d = datos[1].ToString();
            int z = 3;
            string dia = "";
            string mes = "";
            string anio = "";
            string hora = "";
            string min = "";
            bool coma = true;
            while (coma)
            {
                if (datos[z] != ',')
                {
                    dia += datos[z];
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
                    mes += datos[z];
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
                    anio += datos[z];
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
                    hora += datos[z];
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
                    min += datos[z];
                }
                else
                {
                    coma = false;
                }
                z++;
            }
            this.fecha = new DateTime(Int32.Parse(anio), Int32.Parse(mes), Int32.Parse(dia), Int32.Parse(hora), Int32.Parse(min), 0);
            coma = true;
            dia = "";
            while (coma)
            {
                if (datos[z] != ',')
                {
                    dia += datos[z];
                }
                else
                {
                    coma = false;
                }
                z++;
            }
            this.costo = Int32.Parse(dia);
            coma = true;
            dia = "";
            while (coma)
            {
                if (datos[z] != ',')
                {
                    dia += datos[z];
                }
                else
                {
                    coma = false;
                }
                z++;
            }
            this.duracion = Int32.Parse(dia);
            coma = true;
            dia = "";
            dia += datos[z];
            z++;
            dia += datos[z];
            z++;
            int asientosO = Int32.Parse(dia);
            for (int i = 0; i < asientosO; i++)
            {
                dia = "";
                dia += datos[z];
                z++;
                dia += datos[z];
                this.asientosDisp[Int32.Parse(dia)] = false;
                z++;
            }
        }
        */
        public void setPasajeros(Pasajeros pas)
        {

        }
        public override string ToString()
        {
            //return "Origen " + o + " Destino: " + d + " Disponibles: " + numAsientosDisp.ToString() + " Fecha: " + fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " Salida: " + fecha.TimeOfDay;
            return "Ruta: " + getRuta() + " Disponibles: " + numAsientosDisp.ToString() + " Fecha: " + fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " Salida: " + fecha.TimeOfDay + " Costo: " + costo + " Duracion: " + duracion + " mins.";
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
            return fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
        }
        public string getHora()
        {
            return fecha.TimeOfDay.ToString();
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
