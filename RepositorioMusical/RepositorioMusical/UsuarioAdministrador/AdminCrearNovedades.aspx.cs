using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;
using System.Data;

namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class AdminCrearNovedaes : System.Web.UI.Page
    {
        Insercion miInsert;

        protected void Page_Load(object sender, EventArgs e)
        {
            miInsert = new Insercion();
           

        }


        protected void crearNovedad_Click(object sender, EventArgs e)
        {
          
            insertarNuevaNovedad();

        }


        /// <summary>
        /// Se creo todo el 
        /// </summary>

        public void insertarNuevaNovedad()
        {

            verificarLimpiar(tituloTXT, mensaje);
            verificarLimpiar(contenidoTXT, mensaje);


            if (subirfotoNovedad.HasFile)
            {
                if (tituloTXT.Text.Length < 100 && contenidoTXT.Text.Length < 100)
                {
                    string path = guardarArchivo(subirfotoNovedad);

                    imagen.ImageUrl = path;

                    miInsert.crearNovedad(tituloTXT.Text, contenidoTXT.Text, path);


                    mensaje.Text = " Se ha creado con exito una nueva Novedad";
                    limpiarCampos(tituloTXT);
                    limpiarCampos(contenidoTXT);
                }
                else {
                    mensaje.Text = "Los campos de escritura solo aceptan 100 caracteres , trate de ser breve";
                }


            }
            else
            {
                mensaje.Text = "Upss no  ha seleccionado una imagen.";
            }




        }

        // Obtiene el path y guarda el archivo a subir ;

        public string guardarArchivo(FileUpload cargador)
        {
            FileUpload nu = cargador;
            string pathArchivo = "";
            if (nu.HasFile)
            {
                string nomb = nu.FileName;
                nu.PostedFile.SaveAs(Server.MapPath("~") + "/AppData/Novedades/" + nomb);
                pathArchivo = "~/AppData/Novedades/" + nomb;

                return pathArchivo;
            }
            else
            {
                Response.Write("No ha seleccionando ningun archivo para cargar ");
            }

            return pathArchivo;
        }



        private void verificarLimpiar(TextBox entrada, Label mensaje)
        {
            if (entrada.Text != "")
            {
                mensaje.Text = "";
                return;

            }
            else
            {
                mensaje.Text = "Debe ingresar datos en el campo vacio";
            }

        }


        private void limpiarCampos(TextBox entrada)
        {
            entrada.Text = "";
        }

      
    }
}