using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AeroKostal
{
    public class ListaVuelos:List<Vuelo>
    {
        public void ordenarFecha(int primero, int ultimo){
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = this[central];
            i = primero;
            j = ultimo;
            do
            {
                while (this[i].getFecha() < pivote.getFecha())
                {
                    i++;
                    if (i > ultimo)
                        break;
                }
                while (this[j].getFecha() > pivote.getFecha())
                {
                    j--;
                    if (j < primero)
                        break;
                }
                if (i <= j)
                {
                    Vuelo temp;
                    temp = this[i];
                    this[i] = this[j];
                    this[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                ordenarFecha(primero, j);
            }
            if (i < ultimo)
            {
                ordenarFecha(i, ultimo);
            }
        }
        public void ordenarDisponibles(int primero, int ultimo)
        {
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = this[central];
            i = primero;
            j = ultimo;
            do
            {
                while (this[i].getNumAsientosDisponibles() < pivote.getNumAsientosDisponibles())
                {
                    i++;
                    if (i < ultimo)
                        break;
                }
                while (this[j].getNumAsientosDisponibles() > pivote.getNumAsientosDisponibles())
                {
                    j--;
                    if (j < primero)
                        break;
                }
                if (i <= j)
                {
                    Vuelo temp;
                    temp = this[i];
                    this[i] = this[j];
                    this[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                ordenarDisponibles(primero, j);
            }
            if (i < ultimo)
            {
                ordenarDisponibles(i, ultimo);
            }
        }
        public void ordenarDisponiblesInv(int primero, int ultimo)
        {
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = this[central];
            i = primero;
            j = ultimo;
            do
            {
                while (this[i].getNumAsientosDisponibles() < pivote.getNumAsientosDisponibles())
                {
                    Console.WriteLine(this[i].getNumAsientosDisponibles());
                    i++;
                    if (i < ultimo)
                        break;
                }
                while (this[j].getNumAsientosDisponibles() > pivote.getNumAsientosDisponibles())
                {
                    j--;
                    if (j < primero)
                        break;
                }
                if (i <= j)
                {
                    Vuelo temp;
                    temp = this[i];
                    this[i] = this[j];
                    this[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                ordenarDisponibles(primero, j);
            }
            if (i < ultimo)
            {
                ordenarDisponibles(i, ultimo);
            }
        }
        public void guardar()
        {
            System.IO.StreamWriter escribir = new System.IO.StreamWriter("dataBase.txt");
            foreach (Vuelo v in this)
            {
                escribir.WriteLine("¬");
                escribir.WriteLine(v.guardarS());
                if (v.contarDisponibles() < 20)
                {
                    foreach (Pasajero p in v.getListaPasajeros())
                    {
                        escribir.WriteLine("|");
                        escribir.WriteLine(p.guardarS());
                    }
                }
            }
            escribir.Close();
        }
        public void cargar()
        {
            string datosVuelo="";
            System.IO.StreamReader leer = new System.IO.StreamReader("dataBase.txt");
            datosVuelo=leer.ReadLine();
            do{
                if (datosVuelo == "¬")
                {
                    datosVuelo = leer.ReadLine();
                    Vuelo v = new Vuelo(datosVuelo);
                    datosVuelo = leer.ReadLine();
                    if (datosVuelo == "|")
                    {
                        do{
                            datosVuelo = leer.ReadLine();
                            Pasajero p = new Pasajero(datosVuelo);
                            v.listaP.Add(p);
                            datosVuelo = leer.ReadLine();
                        }while(datosVuelo=="|");
                    }
                    this.Add(v);
                }
                //System.Console.WriteLine(datosVuelo);
            }while(!leer.EndOfStream);
            leer.Close();
        }
    }
}
