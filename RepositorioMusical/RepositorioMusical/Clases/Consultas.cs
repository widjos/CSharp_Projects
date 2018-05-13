using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RepositorioMusical.Clases
{
    public class Consultas
    {
        Conexion conexionActual;
        
        SqlCommand query;
        SqlDataReader lector;
        string encabezadodelatabla;
           int codigoPais;                     //Codigo del pais que se espera devolver 


        public Consultas()
        {
            conexionActual = new Conexion();
          
        }


      //----------------------------------------------Busqueda------------------------------

        public int retornarTipoUser(String correo, String password) {
            int validacion = 0;
            try
            {
                Console.WriteLine("Aqui va el analisis");
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT FK_Tipo_Usuario FROM USUARIO WHERE Correo_Electronico ='"+correo+"' AND Contrasena ='"+password+"'", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                validacion = (int) query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado


                Console.WriteLine("El valor de " + validacion);
                conexionActual.cerrarConexion();
                return validacion;

            }
            catch (Exception e) {
                Console.WriteLine("Error" + e.ToString());
                
            }

            return validacion;

        }

        public int retornarIdUser(String correo, String password)
        {
            int validacion = 0;
            try
            {
                Console.WriteLine("Aqui va el analisis");
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Codigo_Usuario FROM USUARIO WHERE Correo_Electronico ='" + correo + "' AND Contrasena ='" + password + "'", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                validacion = (int)query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado


                Console.WriteLine("El valor de " + validacion);
                conexionActual.cerrarConexion();
                return validacion;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.ToString());

            }

            return validacion;

        }

        // Retorna el id del usuario con su correo ; su fecha de nacimiento 

        public int retornarIdUserFecha(String correo, String fechaNacimiento)
        {
            int validacion = 0;
            try
            {
                Console.WriteLine("Aqui va el analisis");
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Codigo_Usuario FROM USUARIO WHERE Correo_Electronico ='" + correo + "' AND Fecha_Nacimiento ='" + fechaNacimiento + "'", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                validacion = (int)query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado


                Console.WriteLine("El valor de " + validacion);
                conexionActual.cerrarConexion();
                return validacion;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.ToString());

            }

            return validacion;

        }


        public int retornarIdArsta(int idUser) {

            int idArtista = 0;
            try
            {
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Codigo_Artista FROM Artista WHERE FK_Codigo_Usuario =" + idUser + "", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                idArtista = (int)query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado

                conexionActual.cerrarConexion();
                return idArtista;

            }
            catch (Exception e) {


            }

            return idArtista;
        }


        // ---- Seleccion todos los usuarios con su : Nombre , Apellido , Uusuario , El nombre de estado actual, Fecha de creacion del usuario.
        // --alv me lleve 2 horas en una puta consulta

        public string selecUsuariosActuales() {
            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>  <td> Nombre </td> <td> Apellido</td> <td> Nom_User </td> <td> Estado Actual</td> <td>Fecha de Creacion</td> </tr>";
                query = new SqlCommand("SELECT USUARIO.Nombre, USUARIO.Apellido, USUARIO.Usuario, ESTADO.Nombre_Estado AS Estado_Actual, USUARIO_ESTADO.Fecha_Modificacion AS Fecha_de_Creacion " +
                    "FROM USUARIO JOIN USUARIO_ESTADO ON USUARIO_ESTADO.Codigo_UE = (SELECT MIN(USUARIO_ESTADO.Codigo_UE) FROM USUARIO_ESTADO WHERE USUARIO_ESTADO.FK_Codigo_Usuario = USUARIO.Codigo_Usuario) " +
                    "JOIN ESTADO ON ESTADO.Codigo_Estado = (SELECT USUARIO_ESTADO.FK_Codigo_Estado FROM USUARIO_ESTADO WHERE USUARIO_ESTADO.Codigo_UE = " +
                    "(SELECT  MAX(USUARIO_ESTADO.Codigo_UE)  FROM USUARIO_ESTADO WHERE USUARIO_ESTADO.FK_Codigo_Usuario = USUARIO.Codigo_Usuario ) ) ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read()) {

                    encabezadodelatabla += "<tr> <td>" + lector["Nombre"].ToString() + "</td><td>" + lector["Apellido"].ToString() + "</td><td>" + lector["Usuario"] + "</td><td>" +
                                            lector["Estado_Actual"].ToString() + "</td><td>" + lector["Fecha_de_Creacion"].ToString() + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e) {
                return "Error al mostrar los usuarios";
            }



        }


        public void cargarPaises(DropDownList entra) {
            try
            {
                DropDownList entrada = entra;
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Nombre_Pais fROM PAIS", conexionActual.miConexion) ;
                lector = query.ExecuteReader();
                while (lector.Read()) {
                    entrada.Items.Add(lector["Nombre_Pais"].ToString());
                }
                conexionActual.cerrarConexion();


            }
            catch(Exception e) {
                Console.WriteLine("Erroraros");
            }

        }


        public void cargarGenero(DropDownList entra) {
            try
            {
                DropDownList entrada = entra;
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT GENERO.Nombre_Genero FROM GENERO", conexionActual.miConexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    entrada.Items.Add(lector["Nombre_Genero"].ToString());
                }
                conexionActual.cerrarConexion();


            }
            catch (Exception e)
            {
                Console.WriteLine("Erroraros");
            }

        }


        public void cargarGeneroCheck(CheckBoxList entra)
        {
            try
            {
                CheckBoxList entrada = entra;
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Nombre_Genero FROM GENERO", conexionActual.miConexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    entrada.Items.Add(lector["Nombre_Genero"].ToString());
                }
                conexionActual.cerrarConexion();


            }
            catch (Exception e)
            {
                Console.WriteLine("Erroraros");
            }

        }

        public void actualizarArtista() {


        }

        public string reotrnarPaisNombre(int id) {
            string paisNom = "";
            try
            {
                
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Nombre_Pais FROM Pais WHERE Codigo_Pais ="+id+";", conexionActual.miConexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    paisNom = lector["Nombre_Pais"].ToString();
                }
                conexionActual.cerrarConexion();

                return paisNom;

            }
            catch(Exception pasierro) {

            }
            return paisNom;

        }


        public void mostrarinformacionArtista(TextBox nombrebox, TextBox anobox , TextBox paisbox , TextBox descripbox, Image fotobox, TextBox facebox , TextBox twitBox, TextBox youtubebox, TextBox paginaBox, string idArtista ) {
            try
            {
                
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Nombre , Ano_Formacion, Codigo_Pais , Descripcion_Artista, Imagen, Facebook, Twitter, YouTube, PaginaWeb FROM ARTISTA WHERE Codigo_Artista ="+idArtista+";", conexionActual.miConexion);
                lector = query.ExecuteReader(System.Data.CommandBehavior.SequentialAccess);
                //lector = query.ExecuteReaderAsync();
                while (lector.Read())
                {
                   
                    // Aqui se asignan todos los datos a los TextBox del Artista asociado
                    nombrebox.Text = (lector["Nombre"].ToString());
                    anobox.Text = (lector["Ano_Formacion"].ToString());
                    codigoPais = int.Parse(lector["Codigo_Pais"].ToString());
                    // paisbox.Text = (reotrnarPaisNombre(int.Parse(lector["Codigo_Pais"].ToString())));                //obtine el nombre del pais de otro metodo y luego lo asigna
                   
                    descripbox.Text =  lector["Descripcion_Artista"].ToString();                                     // Cambie el nombre de la columan por el indice dentro del query

                    fotobox.ImageUrl = (lector["Imagen"].ToString());
                    facebox.Text = (lector["Facebook"].ToString());
                    twitBox.Text = (lector["Twitter"].ToString());
                    youtubebox.Text = (lector["YouTube"].ToString());
                    paginaBox.Text = (lector["PaginaWeb"].ToString());

                  
                }
               conexionActual.cerrarConexion();

                paisbox.Text = reotrnarPaisNombre(codigoPais);



            }
            catch (Exception info) {

                Console.WriteLine("HORROR " + info.ToString()); 
            }

        }


        public int devolverCodigoAlbum(string titulo, string idArtista) {

            int idAlbum = 0;
            try
            {
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Codigo_Album FROM ALBUM WHERE FK_Codigo_Artista =" + idArtista +" AND Titulo='"+titulo+"';", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                idAlbum = (int)query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado

                conexionActual.cerrarConexion();
                return idAlbum;

            }
            catch (Exception e)
            {


            }

            return idAlbum;


        }


        public bool existeElAlbum(string titulo, string idArtista)
        {

            int idAlbum = 0;
            try
            {
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Codigo_Album FROM ALBUM WHERE FK_Codigo_Artista =" + idArtista + " AND Titulo='" + titulo + "';", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                idAlbum = (int)query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado

                conexionActual.cerrarConexion();
                return true;

            }
            catch (Exception e)
            {

                return false;
            }

           // return true;


        }


        public bool artistatieneAlbum(string idArtista) {
            try {
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT * FROM ALBUM WHERE FK_Codigo_Artista =" + idArtista+ ";", conexionActual.miConexion);
                Console.WriteLine("SE asigno el query");
                query.ExecuteScalar(); // Validacion Toma el valor de tipo de usuario del usuario logeado

                conexionActual.cerrarConexion();

                return true;

            }
            catch (Exception existeArtistaexp) {

                return false;

            }


        }


        public List<int> devolverCodigoCancion(List<Cancion> entra, string idAlbum)
        {

            int idCancion = 0;
            List<int> codigo = new List<int>();
            try
                {
                   
                    conexionActual.abrirConexion();

                    for (int i = 0; i < entra.Count; i++)
                    {
                        query = new SqlCommand("SELECT Numero_Cancion FROM CANCION WHERE FK_Codigo_Album =" + idAlbum + " AND Nombre_Cancion ='" + entra.ElementAt(i).Nombre + "';", conexionActual.miConexion);
                        Console.WriteLine("SE asigno el query");
                        idCancion = (int)query.ExecuteScalar();
                        codigo.Add(idCancion);
                    }


                    conexionActual.cerrarConexion();
                    return codigo;

                }
                catch (Exception e)
                {
                
                }
                return codigo;
        }

        public string selecArtistasActuales()
        {
            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>  <td> Nombre </td> <td> Año de Formacion</td> <td> Codigo Pais </td> <td> Descripcion Artista</td> <td> Facebook</td> <td>Twitter</td> <td>Youtube</td> <td>Pagina Web</td>  <td>Imagen</td></tr>";
                query = new SqlCommand("SELECT Nombre, Ano_Formacion, Codigo_Pais, Descripcion_Artista, Facebook, Twitter,YouTube ,PaginaWeb, Imagen  FROM ARTISTA ;", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Nombre"].ToString() + "</td><td>" + lector["Ano_Formacion"].ToString() + "</td><td>" + lector["Codigo_Pais"] + "</td><td>" +
                                            lector["Descripcion_Artista"].ToString() + "</td><td>" + lector["Facebook"].ToString() + "</td><td>" + lector["Twitter"].ToString() + "</td> <td>" + lector["YouTube"].ToString() + "</td> " +
                                            "<td>" + lector["PaginaWeb"].ToString() + "</td><td>" + lector["Imagen"].ToString() + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios";
            }



        }


        public string selecArtistasEliminados()
        {
            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>  <td> cODIGO </td> <td> nOMBRE</td> </tr>";
                query = new SqlCommand("SELECT Codigo_Album, Titulo FROM ALBUM; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Codigo_Album"].ToString() + "</td><td>" + lector["Titulo"].ToString()  + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }



        }

        public string selecAlbumesEliminados() {
            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>  <td> Titulo </td> <td> Fecha de Creacion</td> <td> Reseña </td> <td> Imagen del album</td> <td>Estado</td> <td>Twitter</td> <td>Youtube</td> <td>Pagina Web</td>  <td>Imagen</td> <td>Estado</td></tr>";
                query = new SqlCommand("SELECT ALBUM.Titulo , ALBUM.Fecha, ALBUM.Resena	,ALBUM.Foto_Portada	, ESTADO.Nombre_Estado FROM ALBUM" +
                    " JOIN ALBUM_ESTADO ON ALBUM_ESTADO.Codigo_ALE = (SELECT ALBUM_ESTADO.Codigo_ALE FROM ALBUM_ESTADO WHERE ALBUM.FK_Codigo_Artista = ALBUM.Codigo_Album)" +
                    "JOIN ESTADO ON ESTADO.Codigo_Estado = (SELECT ALBUM_ESTADO.FK_Codigo_Estado FROM ALBUM_ESTADO WHERE ALBUM_ESTADO.Codigo_ALE = (SELECT ALBUM_ESTADO.Codigo_ALE FROM ALBUM_ESTADO WHERE ALBUM_ESTADO.FK_Codigo_Estado = 2 )); ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Titulo"].ToString() + "</td><td>" + lector["Fecha"].ToString() + "</td><td>" + lector["Resena"] + "</td><td>" +
                                            lector["Foto_Portada"].ToString() + "</td><td>" + lector["Nombre_Estado"].ToString() + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay albumes eliminados.";
            }



        }

        public string mostrarNovedades() {
            try
            {
                string imagphat = "";
                conexionActual.abrirConexion();
                encabezadodelatabla = "<div class=\"card-columns\">";
                query = new SqlCommand("SELECT Imagen, Titulo, Contenido FROM NOVEDAD; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    imagphat  = retirarCaracter( lector["Imagen"].ToString());

                    encabezadodelatabla += "<div class=\"card\" style=\"width: 25rem; \"><img class=\"card-img-top\" src=\""+""+imagphat+"\" alt=\"Card image cap\">" +
                   " <div class=\"card-body\">   <h5 class=\"card-title\">" + lector["Titulo"].ToString() + "</h5> <p class=\"card-text\">" + lector["Contenido"].ToString() + "</p> </div> </ div > " ;




                }
                encabezadodelatabla += "</div>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;



            }
            catch (Exception e) {
                return "Quizas no hay ninguna Novedad Publicada D: ";
            }


        }

        // Necesitaba eliminar el caracter (~) para poder mostrar la imagen .
        public string retirarCaracter(string entra) {
            string nueva = entra.Replace(@"~","");

            return nueva;
        }


        public List<Album> mostrarMisAlbums(string idArtista)
        {
            List<Album> auxiliar = new List<Album>();
            try
            {
               
                string imagphat = "";
                conexionActual.abrirConexion();    
                query = new SqlCommand("SELECT Foto_Portada, Titulo, Codigo_Album FROM ALBUM WHERE FK_Codigo_Artista ="+idArtista+"; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {
                    imagphat = retirarCaracter(lector["Foto_Portada"].ToString());

                    auxiliar.Add(new Album(lector["Codigo_Album"].ToString(), imagphat, lector["Titulo"].ToString())); 

                }
            
                conexionActual.cerrarConexion();
                return auxiliar;
            }
            catch (Exception e)
            {
                
            }
            return auxiliar;

        }


        public List<Cancion> mostrarCancionesAlbum(string idAlbum)
        {
            List<Cancion> auxiliar = new List<Cancion>();
            try
            {

                string imagphat = "";
                conexionActual.abrirConexion();
                query = new SqlCommand("SELECT Numero_Cancion, Nombre_Cancion FROM ALBUM WHERE FK_Codigo_Album =" + idAlbum + "; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {
                    //imagphat = retirarCaracter(lector["Foto_Portada"].ToString());

                    auxiliar.Add(new Cancion(lector["Numero_Cancion"].ToString(), lector["Nombre_Cancion"].ToString(), ""));
                  

                }

                conexionActual.cerrarConexion();
                return auxiliar;
            }
            catch (Exception e)
            {

            }
            return auxiliar;

        }


        public string mostrarGeneros()
        {
        
                try
                {
                    string imagphat = "";
                    conexionActual.abrirConexion();
                    encabezadodelatabla = "<div class=\"card-columns\">";
                    query = new SqlCommand("SELECT Nombre_Genero, Imagen FROM GENERO; ", conexionActual.miConexion);
                    lector = query.ExecuteReader(); // Ejecuta el comando 
                    while (lector.Read())
                    {

                        imagphat = retirarCaracter(lector["Imagen"].ToString());

                        encabezadodelatabla += "<div class=\"card\" style=\"width: 25rem; \"><img class=\"card-img-top\" src=\"" + "" + imagphat + "\" alt=\"Card image cap\">" +
                       " <div class=\"card-body\">   <h5 class=\"card-title\">" + lector["Nombre_Genero"].ToString() + "</h5> <p class=\"card-text\">   </p> </div> </ div > ";




                    }
                    encabezadodelatabla += "</div>";
                    conexionActual.cerrarConexion();
                    return encabezadodelatabla;



                }
                catch (Exception e)
                {
                    return "Quizas no hay ninguna Novedad Publicada D: ";
                }


            


        }


        public bool existemegustaAlbum(string album) {
            string imagphat;
            try { 
            conexionActual.abrirConexion();
            // encabezadodelatabla = "<div class=\"card-columns\">";
            query = new SqlCommand("SELECT Me_Gusta FROM ALBUM_MEGUSTA WHERE FK_Codigo_Album = " + album + "; ", conexionActual.miConexion);
            lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read()) {
                    string casa = lector["Me_Gusta"].ToString();
                    imagphat = casa;
                }
                
            conexionActual.cerrarConexion();
            return true;



        } catch (Exception e)
                {
                    return false;
                }


        }


        public bool existemegustaCancion(string cancion)
        {
            bool imagphat;
            try
            {
                conexionActual.abrirConexion();
                // encabezadodelatabla = "<div class=\"card-columns\">";
                query = new SqlCommand("SELECT Me_Gusta FROM CANCION_MEGUSTA WHERE FK_Codigo_Cancion = " + cancion + "; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read()) {
                    string casa = lector["Me_Gusta"].ToString();
                }
                

                conexionActual.cerrarConexion();
                return true;



            }
            catch (Exception e)
            {
                return false;
            }


        }



        public string selecCancionesAlbum(string codigoAlbum)
        {
            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>  <td> cODIGO </td> <td> nOMBRE</td> </tr>";
                query = new SqlCommand("SELECT Numero_Cancion, Nombre_Cancion FROM CANCION WHERE FK_Codigo_Album = " + codigoAlbum + "; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Numero_Cancion"].ToString() + "</td><td>" + lector["Nombre_Cancion"].ToString() + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }



        }

        public string mostrarFaVAlbumes(string idUser)
        {

            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>   <td> Album</td> </tr>";
                query = new SqlCommand("SELECT Titulo FROM ALBUM JOIN FAVORITO_ALBUM ON ALBUM.Codigo_Album = " +
                    "(SELECT ALBUM.Codigo_Album FROM ALBUM WHERE ALBUM.Codigo_Album = FAVORITO_ALBUM.FK_Codigo_Album) " +
                    "JOIN USUARIO ON USUARIO.Codigo_Usuario = (SELECT USUARIO.Codigo_Usuario FROM USUARIO WHERE USUARIO.Codigo_Usuario = "+idUser+"); ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Titulo"].ToString() + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }




        }


        public string mostrarFaVACanciones(string idUser)
        {

            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>   <td> Album</td> </tr>";
                query = new SqlCommand("SELECT Nombre_Cancion FROM CANCION JOIN "
                + "FAVORITO_CANCION ON CANCION.Numero_Cancion = (SELECT CANCION.Numero_Cancion FROM CANCION WHERE CANCION.Numero_Cancion = FAVORITO_CANCION.FK_Numero_Cancion)" +
                "JOIN USUARIO ON USUARIO.Codigo_Usuario = (SELECT USUARIO.Codigo_Usuario FROM USUARIO WHERE USUARIO.Codigo_Usuario = " + idUser + ");", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Nombre_Cancion"].ToString() + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }




        }


        public string masInfluyentes()
        {

            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>   <td> Nombre</td> <td> Me Gustas</td> </tr>";
                query = new SqlCommand("SELECT ARTISTA.Nombre, CANCION_MEGUSTA.Me_Gusta " +
                    "FROM ARTISTA  INNER JOIN CANCION_MEGUSTA  ON ARTISTA.Codigo_Artista = " +
                    "(SELECT ALBUM.FK_Codigo_Artista FROM ALBUM WHERE ALBUM.Codigo_Album = " +
                    "(SELECT CANCION.FK_Codigo_Album FROM CANCION WHERE CANCION.Numero_Cancion = CANCION_MEGUSTA.FK_Numero_Cancion) );", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Nombre"].ToString() + "</td> <td>" + lector["Me_Gusta"] + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }




        }



        public string masInfluyentesCancionArtTOP10()
        {

            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>   <td> Cancion</td> <td> ARTISTA</td> </tr>";
                query = new SqlCommand("SELECT TOP(10) CANCION.Nombre_Cancion , ARTISTA.Nombre  FROM ARTISTA " +
                    "JOIN ALBUM ON ARTISTA.Codigo_Artista = ALBUM.FK_Codigo_Artista " +
                    "JOIN CANCION ON ALBUM.Codigo_Album = CANCION.FK_Codigo_Album " +
                    "JOIN CANCION_MEGUSTA ON CANCION.Numero_Cancion = CANCION_MEGUSTA.FK_Numero_Cancion " +
                    "ORDER BY ARTISTA.Nombre DESC;", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Nombre_Cancion"].ToString() + "</td> <td>" + lector["Nombre"] + "</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }




        }


        public string masInfluyentesArtista()
        {

            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>   <td> Cancion o Album</td>   <td> Artista/td> </tr>";
                query = new SqlCommand("SELECT TOP(10) CANCION.Nombre_Cancion AS CANCIONALBUM,  ARTISTA.Nombre FROM ARTISTA " +
                    "JOIN ALBUM ON ARTISTA.Codigo_Artista = ALBUM.FK_Codigo_Artista " +
                    "JOIN CANCION ON ALBUM.Codigo_Album = CANCION.FK_Codigo_Album " +
                    "JOIN CANCION_MEGUSTA ON CANCION.Numero_Cancion = CANCION_MEGUSTA.FK_Numero_Cancion  UNION ALL " +
                    "SELECT TOP(10) ALBUM.Titulo AS CANCIONALBUM, ARTISTA.Nombre FROM ARTISTA " +
                    "JOIN ALBUM ON ARTISTA.Codigo_Artista = ALBUM.FK_Codigo_Artista " +
                    "JOIN ALBUM_MEGUSTA ON ALBUM.Codigo_Album = ALBUM_MEGUSTA.FK_Codigo_Album " +
                    "ORDER BY ARTISTA.Nombre DESC; ; ", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["CANCIONALBUM"].ToString() + "</td> <td>" + lector["Nombre"].ToString() +"</td> <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }




        }


        public string AlbumesPopulares()
        {

            try
            {
                conexionActual.abrirConexion();
                encabezadodelatabla = "<table class=\"table table-striped table-bordered table-condensed \" ><tr>   <td> ALBUMES POPULARES</td>  </tr>";
                query = new SqlCommand("SELECT Titulo FROM ALBUM JOIN ALBUM_MEGUSTA ON ALBUM.Codigo_Album = (SELECT ALBUM.Codigo_Album FROM ALBUM WHERE ALBUM.Codigo_Album = ALBUM_MEGUSTA.FK_Codigo_Album) ORDER BY Titulo DESC;", conexionActual.miConexion);
                lector = query.ExecuteReader(); // Ejecuta el comando 
                while (lector.Read())
                {

                    encabezadodelatabla += "<tr> <td>" + lector["Titulo"].ToString() + "</td>  <tr>";

                }
                encabezadodelatabla += "</table>";
                conexionActual.cerrarConexion();
                return encabezadodelatabla;
            }
            catch (Exception e)
            {
                return "Error al mostrar los usuarios o no hay usuarios para mostrar.";
            }




        }







    }





}