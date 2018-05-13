using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;
using RepositorioMusical.UsuarioArtista;

namespace RepositorioMusical.UsuarioArtista
{
    public partial class MostrarMisAlbums : System.Web.UI.Page
    {
        List<Album> albumes;
        Consultas miConsulta;
        string idArtista;

        protected void Page_Load(object sender, EventArgs e)
        {



            if (ViewState["arrayListInViewState"] != null)
            {

                albumes = (List<Album>)ViewState["arrayListInViewState"];
            }
            else {
                albumes = new List<Album>();

            }

                miConsulta = new Consultas();
                idArtista = Session["Codigo_Artista"].ToString();
                // albumes = new List<Album>();
               
            
        }


        void Page_PreRender(object sender, EventArgs e)
        {

            ViewState.Add("arrayListInViewState", albumes);
           


        }

        protected void mostrarAlbums_Click(object sender, EventArgs e)
        {
           albumes = miConsulta.mostrarMisAlbums(idArtista);
            multiplesBotones( albumes);
           multiplesBotones2(albumes.Count);
    
        }

        protected void Canciones_Click(Object sender, EventArgs e)
        {
            ImageButton imagenClickeada = (ImageButton)sender;
            string idAlbum = imagenClickeada.ID;
            misalbums.Text = "Useted esta ingresando a este album:" + idAlbum;
            Response.Write("" + misalbums.Text);
            
            Session["Codigo_Album"] = idAlbum;
            
            Response.Redirect("CancionesAlbum.aspx");

        }

        protected void eliminarAlbum_Click(object sender, EventArgs e) {

            Response.Redirect("CancionesAlbum.aspx");
        }

        public void multiplesBotones( List<Album> recorrido)
        {

            int numero;
            for (numero = 0; numero < recorrido.Count; numero++)
            {
                var botonAlbum = new ImageButton();
                {
                    botonAlbum.ID = recorrido.ElementAt(numero).Nombre;                                          //  comandos antiguos  "" + numero;
                    botonAlbum.ImageUrl = recorrido.ElementAt(numero).Imagen;                                     // "../Imagenes/Botones/eliminar.png";
                    botonAlbum.ToolTip = recorrido.ElementAt(numero).Toltip;

                    //botonAlbum.PostBackUrl = "MostrarMisAlbums.aspx";
                  //  botonAlbum.
                    //"IrPor Esas Canciones";
                    //  botonAlbum.CssClass = "card card-img-top";


                    //botonCancelar.PostBackUrl = "AgregarAlbum.aspx";

                }
             //   botonAlbum.Width = 400;
              botonAlbum.Command += Canciones_Click;
        

                botonAlbum.Visible = true;
             


                // botonoesEliminar.Add(new botonAccion(botonCancelar));  // Se comenzara a guardar los botones en una lista 
                albumPanel.Controls.Add(botonAlbum);
               
                var botonEliminar = new Button();
                {
                    botonEliminar.ID = recorrido.ElementAt(numero).Nombre;
                    botonEliminar.Text = "Eliminar este album";
                    botonEliminar.Command += eliminarAlbum_Click;
                    botonEliminar.Visible = true;
                    botonEliminar.CssClass = "btn btn-danger";
                    botonEliminar.CausesValidation = false;
                }
                albumPanel.Controls.Add(botonEliminar);
            }

        }

        public void multiplesBotones2(int numBtb)
        {

            int limite = numBtb;
            int numero;
            for (numero = 0; numero < limite; numero++)
            {

                var botonCancelar = new ImageButton();
                {
                    botonCancelar.ID = "" + numero;
                    botonCancelar.ImageUrl = "../Imagenes/Botones/eliminar.png";
                    botonCancelar.ToolTip = "Eliminar";
                //    botonCancelar.PostBackUrl = "AgregarAlbum.aspx";


                }
                botonCancelar.OnClientClick = "return micanciones(botonCancelar.ID)";
               // botonCancelar.Command += mostrarCanciones_Click;
                // botonCancelar.OnClientClick += "return false";   // no hace post bac
                botonCancelar.Visible = true;

                // botonoesEliminar.Add(new botonAccion(botonCancelar));  // Se comenzara a guardar los botones en una lista 
               Panel1.Controls.Add(botonCancelar);
            }
            //  Controls.Add(botonCancelar);


        }

        public void botonCancelar(string id) {
            Response.Write("acoasa " + id);

        }


        protected void crearNuevoAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarAlbum.aspx");
        }

        protected void mostrarCanciones_Click(object sender,EventArgs e)
        {
            ImageButton imagenClickeada = (ImageButton)sender;
            string idAlbum = imagenClickeada.ID;
            Session["Codigo_Album"] = idAlbum;
            Response.Redirect("CancionesAlbum.aspx");
        }


    }
}