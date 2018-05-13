using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;
namespace RepositorioMusical.UsuarioConsulta
{
    public partial class misFavoritos : System.Web.UI.Page
    {

        string idUsuario;
        Consultas miconsulta;

        protected void Page_Load(object sender, EventArgs e)
        {

            miconsulta = new Consultas();
            idUsuario = Session["Codigo_Usuario"].ToString();

            Albumes.Text = miconsulta.mostrarFaVAlbumes(idUsuario);

            Canciones.Text = miconsulta.mostrarFaVACanciones(idUsuario);

        }
    }
}