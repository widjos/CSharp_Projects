using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class AdminAgregarGenero : System.Web.UI.Page
    {

        RepositorioMusical.Clases.Insercion nuevoGenero;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            nuevoGenero = new Clases.Insercion();
           
        }



     
        protected void crearGenero_Click(object sender, EventArgs e)
        {
            insertarnuevogenero();
        }

        public void insertarnuevogenero() {

            verificarLimpiar(generoTXT, mensaje);

            if (subirfotoGenero.HasFile)
            {

                string path = guardarArchivo(subirfotoGenero);

                imagen.ImageUrl = path;

                nuevoGenero.crearGenero(generoTXT.Text,path);
                mensaje.Text = " Se ha creado con exito un nuevo genero";

            }
            else {
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
                nu.PostedFile.SaveAs(Server.MapPath("~") + "/Imagenes/GneroImagenes" + nomb);
                pathArchivo = "~/Imagenes/GneroImagenes" + nomb;

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