using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioArtista
{
    public partial class ArtistaPrincipal : System.Web.UI.MasterPage
    {
        Consultas miConsulta;
        string idArtista;

        protected void Page_Load(object sender, EventArgs e)
        {

            idArtista = Session["Codigo_Artista"].ToString();
            miConsulta = new Consultas();
        }

        protected void informacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Artista.aspx");
        }

        protected void albums_Click(object sender, EventArgs e)
        {
            if (miConsulta.artistatieneAlbum(idArtista))
            {

                Response.Redirect("MostrarMisAlbums.aspx");
            }
            else {
                Response.Redirect("AgregarAlbum.aspx");
            }

       
        }
    }
}