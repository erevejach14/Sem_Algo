using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AeroKostal
{
    public class Vuelo
    {
        string o;
        string d;
        DateTime fecha;
        int costo;
        int duracion;
        bool [] asientosDisp;
        int numAsientosDisp;
        public List<Pasajero> listaP;
        public Vuelo(string o,string d,int hora,int minuto,int dia, int mes, int anio,int costo, int duracion)
        {
            this.o = o;
            this.d = d;
            this.fecha = new DateTime(anio,mes,dia,hora,minuto,0);
            this.asientosDisp = new bool[20];
            this.costo = costo;
            this.duracion=duracion;
            inicializaAsientos();
            this.numAsientosDisp = contarDisponibles();
            this.listaP = new List<Pasajero>();
        }
        public Vuelo(string o, string d, DateTime fecha,int costo, int duracion)
        {
            this.o = o;
            this.d = d;
            this.fecha = fecha;
            this.asientosDisp = new bool[20];
            this.costo = costo;
            this.duracion = duracion;
            inicializaAsientos();
            this.numAsientosDisp = contarDisponibles();
            this.listaP = new List<Pasajero>();
        }
        public Vuelo(string datos){
            this.listaP = new List<Pasajero>();
            this.asientosDisp = new bool[20];
            inicializaAsientos();
            this.o = datos[0].ToString();
            this.d = datos[1].ToString();
            int z=3;
            string dia = "";
            string mes = "";
            string anio = "";
            string hora="";
            string min = "";
            bool coma=true;
            while(coma)
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
            /*Console.WriteLine(anio + mes + dia + hora + min);
            Console.WriteLine("feik");*/
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
            int asientosO=Int32.Parse(dia);
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
        public override string ToString()
        {
            //return "Origen " + o + " Destino: " + d + " Disponibles: " + numAsientosDisp.ToString() + " Fecha: " + fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " Salida: " + fecha.TimeOfDay;
            return "Ruta: " + getRuta()+" Disponibles: " + numAsientosDisp.ToString() + " Fecha: " + fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " Salida: " + fecha.TimeOfDay+ " Costo: "+costo+" Duracion: "+duracion+ " mins.";
        }
        public string getRuta()
        {
            return "SK1"+o+d;
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
        public bool getAsientos(int ind) {
            return asientosDisp[ind];
        }
        public void setPasajero(Pasajero pasa)
        {
            this.listaP.Add(pasa);
        }
        public Pasajero getPasajero(int ind)
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
            numAsientosDisp=0;
            for (int i = 0; i < 20; i++)
            {
                if (asientosDisp[i] == true)
                {
                    numAsientosDisp += 1;
                }
            }
            return numAsientosDisp;
        }
        public List<Pasajero> getListaPasajeros()
        {
            return listaP;
        }
        public DateTime getFecha(){
            return fecha;
        }
        public int getNumAsientosDisponibles()
        {
            return numAsientosDisp;
        }
        public string guardarS()
        {
            string asientoOcupado="";
            for (int c = 0; c < 20; c++)
            {
                if (asientosDisp[c] == false)
                {
                    if (c < 10) asientoOcupado += 0;
                    asientoOcupado += c;
                }
            }
            string numDisponible = "";
            if (20 - contarDisponibles() < 10) numDisponible += 0;
            numDisponible+=20-contarDisponibles();
            return o + d + "," + fecha.Day + "," + fecha.Month + "," + fecha.Year+ ","+ fecha.Hour + "," + fecha.Minute + "," + costo + "," + duracion + "," +numDisponible+asientoOcupado;
        }
        private void inicializaAsientos()
        {
            for (int i = 0; i < 20; i++)
            {
                this.asientosDisp[i] = true;
            }
        }
    }
}
