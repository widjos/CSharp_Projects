using RepositorioMusical.Clases;
using RepositorioMusical.UsuarioConsulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepositorioMusical.UsuarioConsulta
{
  

    public partial class RegistrarArtista : System.Web.UI.Page
    {
        RepositorioMusical.Clases.Consultas miConsulta;
        RepositorioMusical.Clases.Insercion miInsert;
        int indiceSeleccionado, idUsuario, idArtista;
        ListaTexto generos;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            generos = new ListaTexto();
            miConsulta = new Clases.Consultas();
            miInsert = new Clases.Insercion();
            miConsulta.cargarPaises(Pais);                      // carga los paises y los generos de los cuales pueden ser parte los artistas 
        //  miConsulta.cargarGenero(Genero);
            miConsulta.cargarGeneroCheck(Genero2);              // llena un check box
            indiceSeleccionado = 0;
            
        }

        protected void CrearArtista_Click(object sender, EventArgs e)
        {
            if (Session["Codigo_Usuario"] != null)
            {
                idUsuario = int.Parse(Session["Codigo_Usuario"].ToString());
                Response.Write("Su seleccion es: " + devolverIndice(Pais));
                insertarArt();
            }
            else {
                Response.Write("No esta logeado como un usuario registrado wee");
            }
           

        }

        public void insertarArt()
        {

            // Verificar que las siguietes casillas no esten vacias.

            verificarLimpiar(Nombre, Mensaje);
            verificarLimpiar(Formacion, Mensaje);
            verificarLimpiar(Descripcion, Mensaje);

            try
            {
                // El metodo que insertara al artista a excepcion de su estado y los generos que le pertenecen.
                miInsert.insertarArtista(Nombre.Text, Formacion.Text, devolverIndice(Pais), Descripcion.Text, FB.Text, Twitt.Text, Youtube.Text, PaginaWeb.Text, Session["Codigo_Usuario"].ToString(), guardarArchivo(imagenArtista));

                // Variable de sesion que almacenara el id del artista actual.
                Session["Codigo_Artista"] = miConsulta.retornarIdArsta(idUsuario);
                idArtista = int.Parse(Session["Codigo_Artista"].ToString());

                // Insertar los generos para el artita en la tabla GENERO_ARTISTA invocando al metodo guardarGenero del artista actual.
                miInsert.insertarArtistaGenero(guardarGeneros(generos, Genero2), idArtista);

                // Insertar el estado actual del artista ;
                miInsert.insertarArtistaEstado(1, idArtista);

                Response.Redirect("Artista.aspx");
            }
            catch (Exception e) {
                Response.Write("Existio un error en la creacion de su nuevo artista " + e.ToString());
            }
            

        }

        private int devolverIndice(DropDownList n) {
            DropDownList nuevo = n;
          
            indiceSeleccionado = nuevo.SelectedIndex+1;
          
            return indiceSeleccionado;
        }




        public ListaTexto guardarGeneros(ListaTexto nue, CheckBoxList entra) {
            // NodoTexto nuevo = nue.Cabeza;
            try
            {
                foreach (ListItem item in entra.Items)                  // Recorre los items del checkboxlist.
                    if (item.Selected)                                  // Verifica que el item sea seleccionado.
                        nue.Insertar(entra.Items.IndexOf(item) + 1);        // Llena la lista con los indices seleccionados sumandole 1 porque el indice es 0.
                    
                       
            }
            catch (Exception e) {

            }
            return nue;
        }


        public void sacarvalores(ListaTexto nuevo) {
            NodoTexto nue;
            for (nue = nuevo.Cabeza; nue != null; nue = nue.Siguiente) {
                Response.Write("Los valores seleccionados son: " + nue.Texto);
                Console.WriteLine("Los valores seleccionados son: " + nue.Texto);
            }
        }


        public string obtenerPath(FileUpload entra)
        {

            string filepath = System.IO.Path.GetFullPath(entra.PostedFile.FileName);

            return filepath;
        }

        public string guardarArchivo(FileUpload cargador) {
            FileUpload nu = cargador;
            string pathArchivo = "";
            if (nu.HasFile)
            {
                string nomb = nu.FileName;
                nu.PostedFile.SaveAs(Server.MapPath("~")  +"/AppData/" + nomb);
                 pathArchivo = "~/AppData/" + nomb;

                return pathArchivo;
            }
            else {
                Response.Write("No ha seleccionando ningun archivo para cargar ");
            }

            return pathArchivo;
        }


        //Este metodo verifica que los campos no esten vacios para hacer la insercion .

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