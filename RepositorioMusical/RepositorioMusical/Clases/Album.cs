using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositorioMusical.Clases
{
    [Serializable()]
    public class Album
    {
        string nombre;
        string imagen;
        string toltip;

        public Album(string nombre, string imagen, string toltip)
        {
            Nombre = nombre;
            Imagen = imagen;
            Toltip = toltip;
       
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Toltip { get => toltip; set => toltip = value; }
    }
}