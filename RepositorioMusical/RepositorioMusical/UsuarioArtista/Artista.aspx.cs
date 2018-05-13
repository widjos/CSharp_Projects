using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioArtista
{
    public partial class Artista : System.Web.UI.Page
    {
        Consultas miConsulta;
        Insercion miInsert;
        string artistaID;
        string anoArtista, descripArt, face, twit, youtub, paginaWeb;
        bool cambio;

      

        protected void Page_Load(object sender, EventArgs e)
        {
            miConsulta = new Consultas();
            miInsert = new Insercion();
            artistaID = (Session["Codigo_Artista"].ToString());
            cambio = false;
            descripArt = "";

            // Cargara todos los datos del usuario logueado 
            if (!IsPostBack)
            {

                cargardatos();
            }
       
          
            }

        protected void eliminarBT_Click(object sender, EventArgs e)
        {

        }

      

        private void cargardatos() {
            if (cambio != true)
            {

                miConsulta.mostrarinformacionArtista(TextNombArt, anoTex, paisTxt, descripArtista, imagenArtista, faceText, twitTxt, youtubTxt, paginaTxt, artistaID);

            }
            else {
               // Response.Write("se estan editanto datos");
            }

        }


        protected void actualizaBT_Click(object sender, EventArgs e)
        {
        

            string path = guardarArchivo(cambiarImag);

            if (path != "")
            {
                miInsert.actualizarArtista(anoArtista, descripArt, path, face, twit, youtub, paginaWeb, artistaID);
               // Response.Redirect("Artista.aspx");
            }
            else
            {

                Response.Redirect("Artista.aspx");
                Response.Write("Upss le hizo falta seleccionar una imagen");
            }

        }

        

        public string guardarArchivo(FileUpload cargador)
        {
            FileUpload nu = cargador;
            string pathArchivo = "";
            if (nu.HasFile)
            {
                string nomb = nu.FileName;
                nu.PostedFile.SaveAs(Server.MapPath("~") + "/AppData/" + nomb);
                pathArchivo = "~/AppData/" + nomb;

                return pathArchivo;
            }
            else
            {
                Response.Write("No ha seleccionando ningun archivo para cargar ");
            }

            return pathArchivo;
        }

        // METODOS QUE REGISTRAN LOS CAMBIOS EN EL TEXT BOX 

        protected void descripArtista_TextChanged(object sender, EventArgs e)
        {
            descripArt = descripArtista.Text;
           // Response.Write("su valor es :" + descripArt);
           // cambio = true;
        }

        protected void faceText_TextChanged(object sender, EventArgs e)
        {
            face = faceText.Text;
        }


        protected void twitTxt_TextChanged(object sender, EventArgs e)
        {
            twit = twitTxt.Text;
        }

        protected void youtubTxt_TextChanged(object sender, EventArgs e)
        {
            youtub = youtubTxt.Text;


        }

        protected void paginaTxt_TextChanged(object sender, EventArgs e)
        {
            paginaWeb = paginaTxt.Text;
        }

        protected void anoTex_TextChanged(object sender, EventArgs e)
        {
            anoArtista = anoTex.Text;

        }





    }
}