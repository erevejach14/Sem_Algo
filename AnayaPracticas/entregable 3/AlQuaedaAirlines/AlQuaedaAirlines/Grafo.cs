using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlQuaedaAirlines
{
    public class Grafo
    {
        List<Nodo> ln;

        public Grafo(List<Vuelo> lv)
        {
            ln = new List<Nodo>();
            foreach(Vuelo v in lv)
            {
                bool bandO = true;
                bool bandD = true;
                foreach(Nodo n in ln)
                {
                    if (v.getO() == n.getCiudad().getNom())
                        bandO = false;
                    if (v.getD() == n.getCiudad().getNom())
                        bandD = false;
                }
                if (bandO)
                {
                    Ciudad c = new Ciudad(v.getO());
                    Nodo nodoNuevo = new Nodo(c);
                    ln.Add(nodoNuevo);
                }
                if (bandD)
                {
                    Ciudad c = new Ciudad(v.getD());
                    Nodo nodoNuevo = new Nodo(c);
                    ln.Add(nodoNuevo);
                }
            }
  
            foreach(Nodo n in ln)
            {
                foreach(Vuelo v in lv)
                {
                    if(n.getCiudad().getNom() == v.getO())
                    {
                        foreach(Nodo rel in ln)
                        {
                            if(rel.getCiudad().getNom() == v.getD())
                            {
                                Ady a = new Ady(rel, v.getCosto(), v.getDuracion() ); //relacion del nodo
                                n.setAdy(a);
                            }
                        }
                        
                    }
                }
            }
        }

        public int getNodosCount()
        {
            return ln.Count;
        }

        public Nodo getNodo(int i)
        {
            return ln[i];
        }


        //public Nodo avanza3()
        //{
        //    System.Console.WriteLine(ln[0].getCiudad().getNom());
        //    System.Console.WriteLine(ln[0].getAdy(0).getNodo().getCiudad().getNom());
        //    System.Console.WriteLine(ln[0].getAdy(0).getNodo().getAdy(0).getNodo().getCiudad().getNom());
        //    System.Console.WriteLine(ln[0].getAdy(0).getNodo().getAdy(0).getNodo().getAdy(0).getNodo().getCiudad().getNom());
        //    return ln[0].getAdy(0).getNodo().getAdy(0).getNodo().getAdy(0).getNodo();
        //}

        public Nodo insertaNodo(Ciudad c)
        {
            Nodo n = new Nodo(c);
            ln.Add(n);
            return n;
        }

        public void eliminarNodo(Nodo n)
        {
            ln.Remove(n);
        }

        public void eliminarNodoActual(int i)
        {
            ln.RemoveAt(i);
        }

        public int existeNodo(string nodoBuscado)
        {
            for(int i = 0; i < getNodosCount(); i++)
                if (nodoBuscado == this.ln[i].getCiudad().getNom())
                    return i;
            return -1;
        }

        public void insertarAdy(Nodo n1, Nodo n2, int peso, int duracion)
        {
            Ady ad = new Ady(n2, peso, duracion);
            n1.setAdy(ad);
        }
    }

    public class Nodo
    {
        List<Ady> la;
        Ciudad c;

        public Nodo(Ciudad c)
        {
            la = new List<Ady>();
            this.c = c;
        }

        public int getAdyCount()
        {
            return this.la.Count;
        }

        public void setAdy(Ady a)
        {
            la.Add(a);
        }

        public Ady getAdy(int i)
        {
            return la[i];
        }

        public Ciudad getCiudad()
        {
            return c;
        }

        public void eliminaAdy(int i)
        {
            la.RemoveAt(i);
        }
    }

    public class Ady
    {
        int precio;
        int duracion;
        Nodo n;

        public Ady(Nodo n, int p, int d)
        {
            this.n = n;
            precio = p;
            duracion = d;
        }

        public Nodo getNodo()
        {
            return n;
        }

        public int getPrecio()
        {
            return precio;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        public int getDuracion()
        {
            return duracion;
        }

        public void setDuracion(int duracion)
        {
            this.duracion = duracion;
        }
    }

    public class Ciudad
    {
        string nom;
        int x;
        int y;
        public Ciudad(string nom)
        {
            this.nom = nom;
        }

        public Ciudad(string nom, int x, int y)
        {
            this.nom = nom;
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public string getNom()
        {
            return nom;
        }

        public void setxy(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
