using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioArtista
{
    public partial class MisAlbumes : System.Web.UI.Page
    {
        List<Album> albumes;
        Consultas miConsulta;
        string idArtista;

        protected void Page_Load(object sender, EventArgs e)
        {
            miConsulta = new Consultas();
            idArtista =Session["Codigo_Artista"].ToString();
            // albumes = new List<Album>();
            albumes = new List<Album>();
          

        }

        protected void Canciones_Click(object sender, EventArgs e) {
           
            
        }


        protected void MostrarAlbumes_Click(object sender, EventArgs e)
        {
            albumes = miConsulta.mostrarMisAlbums(idArtista);
            multiplesBotones(albumes);
         

        }


        public void multiplesBotones(List<Album> recorrido)
        {

            int numero;
            for (numero = 0; numero < recorrido.Count; numero++)
            {

                var botonAlbum = new ImageButton();
                {
                    botonAlbum.ID = recorrido.ElementAt(numero).Nombre;                                          //  comandos antiguos  "" + numero;
                    botonAlbum.ImageUrl = recorrido.ElementAt(numero).Imagen;                                     // "../Imagenes/Botones/eliminar.png";
                    botonAlbum.ToolTip = recorrido.ElementAt(numero).Toltip;                                       //"IrPor Esas Canciones";
                                                                                                                   //  botonAlbum.CssClass = "card card-img-top";


                    //botonCancelar.PostBackUrl = "AgregarAlbum.aspx";

                }
                //   botonAlbum.Width = 400;
                botonAlbum.Command += Canciones_Click;
                //botonAlbum.Click += new System.Web.UI.ImageClickEventHandler(Canciones_Click);
                // botonAlbum.OnClientClick = "mostrarCancion_Click";                           ///Canciones_Click;
               // botonAlbum.PostBackUrl = "MisAlbumes.aspx";
                // botonAlbum.CommandName = "Canciones_Click";


                botonAlbum.Visible = true;



                // botonoesEliminar.Add(new botonAccion(botonCancelar));  // Se comenzara a guardar los botones en una lista 
                Panel1.Controls.Add(botonAlbum);
          
            }
        }
    }
}