using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepositorioMusical.Clases
{
    [Serializable()]
    public class botonAccion
    {
        ImageButton miBotoncito;

        public botonAccion(ImageButton miBotoncito)
        {
            MiBotoncito = miBotoncito;
         
        }

        public ImageButton MiBotoncito { get => miBotoncito; set => miBotoncito = value; }
    }
}