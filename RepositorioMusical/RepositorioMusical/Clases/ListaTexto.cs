using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioMusical.Clases
{
   public class ListaTexto
    {
        NodoTexto cabeza;
        int longitud;

        public ListaTexto()
        {
            this.Cabeza = null;
            this.Longitud = 0;
          
        }

       

        public void Insertar(int valor) {
            NodoTexto nuevo = new NodoTexto(valor);
            if (Cabeza == null)
            {
                Cabeza = nuevo;
                longitud++;
            }
            else {
                NodoTexto aux = Cabeza;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevo;
                longitud++;
            }

        }


        public bool EsVacia()
        {
            return (cabeza == null);
        }

        public void VaciarLista()
        {
            Cabeza = null;
            longitud = 0;
        }


        public int Longitud { get => longitud; set => longitud = value; }
        internal NodoTexto Cabeza { get => cabeza; set => cabeza = value; }
    }

}
