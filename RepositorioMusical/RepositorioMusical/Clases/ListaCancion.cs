using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositorioMusical.Clases
{
    public class ListaCancion
    {
        NodoCancion cabeza;
        int longitud;

        public ListaCancion()
        {
            this.Cabeza = null;
            this.Longitud = 0;

        }


        public void Insertar(string duracion, string nombre)
        {
            NodoCancion nuevo = new NodoCancion(duracion, nombre);
            if (Cabeza == null)
            {
                Cabeza = nuevo;
                longitud++;
            }
            else
            {
                NodoCancion aux = Cabeza;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevo;
                longitud++;
            }

        }

        public int Longitud { get => longitud; set => longitud = value; }
        internal NodoCancion Cabeza { get => cabeza; set => cabeza = value; }
    }
}