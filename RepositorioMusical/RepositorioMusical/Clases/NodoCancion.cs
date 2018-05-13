using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositorioMusical.Clases
{
    public class NodoCancion
    {
        string duracion;
        string nombre;
        NodoCancion siguiente;

        public NodoCancion(string duracion, string nombre)
        {
            this.Duracion = duracion;
            this.Nombre = nombre;
            this.Siguiente = null;
        }

        public string Duracion { get => duracion; set => duracion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public NodoCancion Siguiente { get => siguiente; set => siguiente = value; }
    }
}