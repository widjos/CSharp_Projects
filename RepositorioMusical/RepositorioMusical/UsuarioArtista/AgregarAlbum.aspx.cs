using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using RepositorioMusical.Clases;
using Microsoft.WindowsAPICodePack.Shell; // Libreria instalada para poder manipular archivos y caracteristicas de windows 
using System.Collections; // activa la lista 
using System.IO;


namespace RepositorioMusical.UsuarioArtista
{
    public partial class AgregarAlbum : System.Web.UI.Page
    {
        string idArtista, idAlbum, idCancion;
        Consultas miConsulta;
        Insercion miInsert;
        List<Cancion> cancionesAlbum;
        // List<botonAccion> botonoesEliminar;
        //List<ImageButton> botonesEliminar;


        protected void Page_Load(object sender, EventArgs e)
        {

            

            if (ViewState["arrayListInViewState"] != null)    /// Este cofigo podria salvarme el culooooo
            {
                cancionesAlbum = (List<Cancion>)ViewState["arrayListInViewState"];
                // botonoesEliminar = (List<botonAccion>)ViewState["arrayListBotones"];

                ///
                /// Solo necesitba agregar esatas cosas para que funcionara alv que emcion me quiero matar 15:22
                ///

                string datosdeTabla = mostrarTabladeCanciones(cancionesAlbum);
                cancionesTabla.Text = datosdeTabla;
                multiplesBotones(cancionesAlbum.Count);

            }
            else
            {
                // ArrayList isn't in view state, so it must be created and populated.
                cancionesAlbum = new List<Cancion>();
             //   botonoesEliminar = new List<botonAccion>();  // no se puede utilizar
             
            }

            idArtista = (Session["Codigo_Artista"].ToString());
            miConsulta = new Consultas();
            miInsert = new Insercion();


            // cancionesAlbum = new List<Cancion>();

        }


       void Page_PreRender(object sender, EventArgs e)
        {
            // Save PageArrayList before the page is rendered.
            ViewState.Add("arrayListInViewState",cancionesAlbum);
            //   ViewState.Add("arrayListBotones", botonoesEliminar);
            //  ViewState.Add("cantidadCanciones", cancionesAlbum.Count);  // Esto deberia almacenar la cantidad de cancines aexistentes 

           
        }

        // --------------------------Metodos que generan algo con el click 

        protected void agregarCancion_Click(object sender, EventArgs e)
        {
            string ubicacion;                                                    // aun no esta asigando el valor de esta vaarible 
            string nombreCancion;                                                     // nombre
            try
            {
                if (tituloTxt.Text != "")
                {
                    // Obtener nombre de la carpeta 
                   crearCarpetaParaGuardar(tituloTxt.Text);                        /// Revizar crear carpeta

               
                    nombreCancion = devolversoloPathdelAudio(subirCancion);
                    ubicacion = guardarArchivo(subirCancion, tituloTxt.Text);        // se asigna el nombre al archivo seleccionado   para guardar como ruta 

                    if (nombreCancion != "")
                    {

                        cancionesAlbum.Add(new Cancion(nombreCancion, "15:12", ubicacion));        // se agrega a la lista el dato del tiempo no es el correcto 
                        string datosdeTabla = mostrarTabladeCanciones(cancionesAlbum);
                        cancionesTabla.Text = datosdeTabla;
                        multiplesBotones(cancionesAlbum.Count);


                        //   mostrarBotones(cancionesAlbum.Count);                                 //Este metodo se usa para una Lista de botones pero no se puede serizaliar
                        // multiplesBotones(cancionesAlbum.Count);                                // El metodo de los botones que generara los botones segun sean agregada las canciones
                    }
                    else
                    {
                        Console.WriteLine("Upss no ha seleccionado nada");
                        if (cancionesAlbum != null)
                        {
                            string datosdeTabla = mostrarTabladeCanciones(cancionesAlbum);
                            cancionesTabla.Text = datosdeTabla;

                        }
                        else {
                            cancionesTabla.Text = "Ups no ha seleccionado ninguna Cancion para subir >:v ";
                        }
                       
                        
                    }
                }
                else
                {
                    cancionesTabla.Text = "Ups no puede cargar sus archivos si su Album no tiene un nombre D: ";
                }
            } catch (Exception error5) {

                cancionesTabla.Text =  "Al parecer hay un error "+ error5.ToString() ;
            }

        }





        // Necesito un metodo que retorne un codigo de album 
        public void insertarAlbum() {



            // Insert del album a la tabla Albums
            if (subirfotoAlbum.HasFile)
            {

                if (miConsulta.existeElAlbum(tituloTxt.Text, idArtista))
                {
                    // Variable de sesion para el codigo del album actual donde se generara el inserte de las canciones actuales
                    Session["Codigo_Album"] = miConsulta.devolverCodigoAlbum(tituloTxt.Text, idArtista);

                    // aSIGAN EL ID DEL ALBUM
                    idAlbum = Session["Codigo_Album"].ToString();

                    // Insertar el estado del album actual 

                    miInsert.insertarAlbumEstado(1, idAlbum);

                    // Insertar las canciones del album 

                    miInsert.insertarCancion(idAlbum, cancionesAlbum);

                    //iInsertar todos los estados de las canciones con una lista primero devolver los Numeros de canciones;

                    List<int> cancionCodigo = miConsulta.devolverCodigoCancion(cancionesAlbum, idAlbum);

                    if (cancionCodigo != null)
                    {
                        miInsert.insertarCancionEstado(1, cancionCodigo);
                        mensaje.Text = "Ha creado un album con mucho exito";
                    }
                    else
                    {

                        mensaje.Text = "Error Fatla";
                    }


                }
                else
                {
                    miInsert.insertarAlbum(tituloTxt.Text, fechaTxt.Text, resenaTxt.Text, guardarArchivo(subirfotoAlbum, tituloTxt.Text), idArtista);

                    // Variable de sesion para el codigo del album actual donde se generara el inserte de las canciones actuales
                    Session["Codigo_Album"] = miConsulta.devolverCodigoAlbum(tituloTxt.Text, idArtista);

                    // aSIGAN EL ID DEL ALBUM
                    idAlbum = Session["Codigo_Album"].ToString();

                    // Insertar el estado del album actual 

                    miInsert.insertarAlbumEstado(1, idAlbum);

                    // Insertar las canciones del album 

                    miInsert.insertarCancion(idAlbum, cancionesAlbum);

                    //iInsertar todos los estados de las canciones con una lista primero devolver los Numeros de canciones;

                    List<int> cancionCodigo = miConsulta.devolverCodigoCancion(cancionesAlbum, idAlbum);

                    if (cancionCodigo != null)
                    {
                        miInsert.insertarCancionEstado(1, cancionCodigo);
                        mensaje.Text = "Ha creado un album con mucho exito";
                    }
                    else
                    {

                        mensaje.Text = "Error Fatla";
                    }


                }

            }
            else {

                mensaje.Text = "mas despacito   debe seleccionar una imagen para su album";
            }

        }

        // Este metodo mostrara las canciones actuales a agregar . se recargara cada vez que se ingresa una nueva cancion. cuando se presiona el boton cancion ----
        public string mostrarTabladeCanciones(List<Cancion> cancionesEntrantes) {
            
            string encabezado = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>  <td> Numero </td> <td> Nombre</td> <td> Duracion </td> <td> Ubicacion </td>  </tr>";
            for (int i = 0; i < cancionesEntrantes.Count; i++) {

               encabezado += "<tr> <td>" + i + "</td> <td>" + cancionesEntrantes.ElementAt(i).Nombre + "</td> <td>" + cancionesEntrantes.ElementAt(i).Duracion + "</td>  <td>"+ cancionesEntrantes.ElementAt(i).Url +"</td>  <tr>";
            }
            encabezado += "</table>";
            return encabezado;


        }


        // Metodo para crear la carpeta 
        public void crearCarpetaParaGuardar(string nombreCarpeta) {

            //  cancionesAlbum = (List<Cancion>)ViewState["arrayListInViewState"];


            //  var rutaAlbum = "~/AppDataMusica/";
            // rutaAlbum += nombreCarpeta + "/";
            // Directory.CreateDirectory(rutaAlbum);
            
                string directoryPath = Server.MapPath(string.Format("~/AppDataMusica/"+ nombreCarpeta.Trim()+"/"));
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                else
                {
                mensaje.Text = "Su directorio ya existe ";
                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory already exists.');", true);
                }
          
        }


       

        //Metodo para devolver la duracion de una cancion 
        //Si da tiempo si lo hago 


        // Obtiene el path y guarda el archivo a subir ;

        public string guardarArchivo(FileUpload cargador, string carpetaGuardar)
        {
            FileUpload nu = cargador;
            string pathArchivo = "";
            if (nu.HasFile)
            {
                string nomb = nu.FileName;
                nu.PostedFile.SaveAs(Server.MapPath("~") + "/AppDataMusica/" +carpetaGuardar+"/" + nomb);
                pathArchivo = "~/AppDataMusica/" + carpetaGuardar + "/" + nomb;

                return pathArchivo;
            }
            else
            {
                Response.Write("No ha seleccionando ningun archivo para cargar ");
            }

            return pathArchivo;
        }

        public string devolversoloPathdelAudio(FileUpload cargador) {

            FileUpload nuevo = cargador;

            string nombre = "";

                if (nuevo.HasFile)
                {
                   string nom = nuevo.FileName;
                   nombre  = nom;
                   return nombre;
                }
                else
                {
                mensaje.Text = "Debe ingresar datos en el campo vacio";
            }
          

            return nombre;
        }

        // Son metodos que genera los botones
        // tabla.Text = multiplesBotones2(); // Esto generaba la tabla que use para pruebas 
        //
        
 ////////////////////////////////////////////////////////////////////////////////////////////////////////// Metodos para eliminar la cancion 

        protected void eliminarCancion_Click(Object sender , EventArgs e) {

            
                // Para la accion del boton eliminar
                ImageButton clickedButton = (ImageButton)sender;
                int valorBoton = int.Parse(clickedButton.ID);
                acciones.Text = "" + valorBoton;

            int idcan = valorBoton;
            string cancionnom = devolverNombre(idcan);
            string url = tituloTxt.Text;                     //devolverruta(idcan);
            EliminandoCancion(cancionnom, url);


            eliminarCancionLista(valorBoton);
        }




        protected void crearAlbum_Click(object sender, EventArgs e)
        {

            insertarAlbum();
        }

        // a


        // Metodo para eliminar una cancion en el directorio 
        public string  devolverNombre(int entra) {
            int indice = entra;
           string nom = cancionesAlbum.ElementAt(entra).Nombre;
            return nom;
        }

        public string devolverruta(int entra)
        {
            int indice = entra;
            string ruta = cancionesAlbum.ElementAt(entra).Url;
            ruta = retirarCaracter(ruta);
            return ruta;
        }

        public  void eliminarCancionLista(int entra)
        {
            int indice = entra;
            cancionesAlbum.RemoveAt(indice); 
           
        }

        /// <summary>
        ///  Eliminar el signo ~
        /// </summary>
        /// <param name="path"></param>

        public string retirarCaracter(string entra)
        {
            string nueva = entra.Replace(@"~", "");
            nueva = nueva.Replace(@"/", "\\");
            return nueva;
        }

        // Eliminar Cancion del directorio 

        private void EliminandoCancion(string cancion,string ul)
        {
            string path2 = @"C:\Users\Wid\source\repos\RepositorioMusical\RepositorioMusical\AppDataMusica\"+ul+"\\";

           
            if (Directory.Exists(path2))
            {
                //Delete all files from the Directory

                foreach (string file in Directory.GetFiles(path2))
                {
                    File.Delete(path2 + cancion);
                }
            }
            else {
                mensaje.Text = "Ups creo que ya ha sido eliminado lo que usted busca";
            }

        }

                // 

                /*  // Muestra los botones generados 
                  public void mostrarBotones(int entra) {
                      int numero ;
                      for ( numero = 0; numero <entra; numero++)
                      {
                          Panel1.Controls.Add(botonoesEliminar.ElementAt(numero).MiBotoncito);
                      }

                  }
                  */

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                // El metodo funciona para hacer mas de todos los botones boton wiii :D 09/05/2018
                public void multiplesBotones(int numBtb)
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
                    botonCancelar.PostBackUrl = "AgregarAlbum.aspx";
                    

                }
                botonCancelar.Command += eliminarCancion_Click;
               // botonCancelar.OnClientClick += "return false";   // no hace post bac
                botonCancelar.Visible = true;

               // botonoesEliminar.Add(new botonAccion(botonCancelar));  // Se comenzara a guardar los botones en una lista 
                Panel1.Controls.Add(botonCancelar);
            }
            //  Controls.Add(botonCancelar);


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