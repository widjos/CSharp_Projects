using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical
{
    public partial class Usuario : System.Web.UI.MasterPage
    {
        Consultas miConsulta;
        int idArtista, idUsuario;
        string iduser;

        protected void Page_Load(object sender, EventArgs e)
        {
            miConsulta = new Consultas();
            
            idUsuario = int.Parse(Session["Codigo_Usuario"].ToString());
        }

        protected void cerrarSesion_Click(object sender, EventArgs e) // Cierra la sesion de usuario 
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../Home.aspx");
        }

        protected void btnFavoritos_Click(object sender, EventArgs e)
        {
         
            Response.Redirect("MostrarArtista.aspx");
        }

        protected void MisFavoritos_Click(object sender, EventArgs e)
        {
            Response.Redirect("misFavoritos.aspx");
        }

        protected void registArtista_Click(object sender, EventArgs e) // Valida si el usuario tiene un artista asociado lo dirige a su artista si no a registrar un artista .
        {
            try
            {
                Session["Codigo_Artista"] = miConsulta.retornarIdArsta(idUsuario);
                idArtista = int.Parse(Session["Codigo_Artista"].ToString());
                if (idArtista.Equals(null)) {
                    Response.Redirect("RegistrarArtista.aspx");
                }
                else {
                    Response.Redirect("~/UsuarioArtista/Artista.aspx");
                }

            }
            catch (Exception error) {
                Response.Write("Existe un error");
            }

        }

       
    }
}