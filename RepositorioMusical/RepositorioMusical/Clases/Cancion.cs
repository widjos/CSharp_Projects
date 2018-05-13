using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositorioMusical.Clases
{

    [Serializable()]
    public class Cancion
    {
        string nombre;
        string duracion;
        string url;

        public Cancion(string nombre, string duracion, string url)
        {
            Nombre = nombre;
            Duracion = duracion;
            Url = url;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Url { get => url; set => url = value; }
    }
}