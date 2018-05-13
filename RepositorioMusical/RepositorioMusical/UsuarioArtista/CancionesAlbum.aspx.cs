using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioArtista
{


    public partial class CancionesAlbum : System.Web.UI.Page
    {
        Consultas miConsulta;
        List<Cancion> canciones;
        public static string idAlbum;

        protected void Page_Load(object sender, EventArgs e)
        {
            idAlbum = Session["Codigo_Album"].ToString();
            miConsulta = new Consultas();
            canciones = new List<Cancion>();


        }



        protected void eliminarAlbum_Click(object sender, EventArgs e)
        {


        }

        public void multiplesBotones(List<Cancion> recorrido)
        {

            int numero;
            for (numero = 0; numero < recorrido.Count; numero++)
            {

                var botonAlbum = new ImageButton();
                {
                    botonAlbum.ID = recorrido.ElementAt(numero).Nombre;                                          //  comandos antiguos  "" + numero;
                    botonAlbum.ImageUrl = "../Imagenes/Botones/audio.png";                                   // "../Imagenes/Botones/eliminar.png";
                    botonAlbum.ToolTip = recorrido.ElementAt(numero).Duracion;                                       //"IrPor Esas Canciones";
                    botonAlbum.CssClass = "card card-img-top";

                    botonAlbum.Width = 400;

                    //botonCancelar.PostBackUrl = "AgregarAlbum.aspx";

                }
               botonAlbum.Command += mostrarCancion_Click;
              

                botonAlbum.Visible = true;

                // botonoesEliminar.Add(new botonAccion(botonCancelar));  // Se comenzara a guardar los botones en una lista 
                Panel1.Controls.Add(botonAlbum);

                var botonEliminar = new Button();
                {
                    botonEliminar.ID = recorrido.ElementAt(numero).Nombre;
                    botonEliminar.Text = "Eliminar este album";
                    botonEliminar.Command += eliminarAlbum_Click;
                    botonEliminar.Visible = true;
                    botonEliminar.CssClass = "btn btn-danger";
                }
                Panel1.Controls.Add(botonEliminar);
            }

        }



        protected void crearNuevoAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarAlbum.aspx");
        }

        protected void mostrarCancion_Click(object sender, EventArgs e)
        {
            canciones = miConsulta.mostrarCancionesAlbum(idAlbum);
            multiplesBotones(canciones);

        }
    }
}