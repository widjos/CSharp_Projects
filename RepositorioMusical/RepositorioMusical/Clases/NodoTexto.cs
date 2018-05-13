using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioMusical.Clases
{
    class NodoTexto
    {
        int Valor;
        NodoTexto siguiente;

        public NodoTexto(int valor)
        {
            this.Valor = valor;
            this.Siguiente = null;
        }

        public int Texto { get => Valor; set => Valor = value; }
        internal NodoTexto Siguiente { get => siguiente; set => siguiente = value; }
    }
}
