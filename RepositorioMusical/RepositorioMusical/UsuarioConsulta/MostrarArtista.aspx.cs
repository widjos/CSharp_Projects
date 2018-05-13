using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;
namespace RepositorioMusical.UsuarioConsulta
{
    public partial class MostrarArtista : System.Web.UI.Page
    {

        Consultas miconsulta;
        string var;
        string idUsuario;
        Insercion miinsert;

        protected void Page_Load(object sender, EventArgs e)
        {
            miinsert = new Insercion();

            idUsuario = Session["Codigo_Usuario"].ToString();

            miconsulta = new Clases.Consultas();
            var = "";

            var = miconsulta.selecArtistasEliminados();
            artistas.Text = var;



        }


        public void insertarFavorito(string iduser, string idAlbum) {

         

                miinsert.crearFavoritoAlbum(iduser, idAlbum);
                mensaje1.Text = "Agrego exitosamente el album a sus favoritotos"; 
      
                
         



        }

        protected void ArtistaFav_Click(object sender, EventArgs e)
        {
            if (entraArtista.Text != "")
            {

                insertarFavorito(idUsuario, entraArtista.Text);
            }
            else {
                mensaje1.Text = "Ingrese un numero de album";
            }
            

        }

        protected void mostrarCanciones_Click(object sender, EventArgs e)
        {
            if (codigoalbum.Text != "")
            {
                canciones.Text = miconsulta.selecCancionesAlbum(codigoalbum.Text);
            }
            else {
                mensaje2.Text = "Ups debe seleccionar un codigo album";
            }
           
        }

        protected void AgragarCancionFav_Click(object sender, EventArgs e)
        {
            if (favCanciones.Text != "")
            {
                miinsert.crearFavoritoCancion(idUsuario, favCanciones.Text);
            }
            else
            {

                mensaje2.Text = "Ingrese un codigo de cancion";
            }
            }

        protected void megustaAl_Click(object sender, EventArgs e)
        {
            if (megustaAl.Text != null)
            {
                if (miconsulta.existemegustaAlbum(megustaAlbum.Text) == false)
                {
                    miinsert.ingrearMegustaAlbum(megustaAlbum.Text);
                }
                else {
                    miinsert.updateMegustaAlbum(megustaAlbum.Text);
                }
            }
          
        }

        protected void btnCancionMegusta_Click(object sender, EventArgs e)
        {
            if (txtmegustaCancion.Text != "") {

                if (miconsulta.existemegustaCancion(txtmegustaCancion.Text)== false)
                {

                    miinsert.ingrearMegustaCancion(txtmegustaCancion.Text);
                }
                else {
                    miinsert.updateMegustaCancion(txtmegustaCancion.Text);
                }

            }

        }
    }
}