using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace RepositorioMusical.Clases
{

    public class Insercion
    {
        Conexion transConexion;
        SqlCommand query;

        public Insercion()
        {
            transConexion = new Conexion();
        }

        public void insertarUsuario(String nombre, String apellido, String usuario, String fechaNac, String Contrasena, String correo  ) {
            try
            {
                if (nombre.Length > 2 && apellido.Length > 2 && usuario.Length > 2 && Contrasena.Length > 2)
                //El nombre, apellido deben ser mayores de 4 caracteres
                //El usuario debe ser mayor a 5 caracteres 
                //La contrasena debe tener mas de 5 caracteres.
                {
                    transConexion.abrirConexion();
                    query = new SqlCommand("INSERT INTO USUARIO VALUES('" + nombre + "','" + apellido + "','" + usuario + "','" + fechaNac + "','" + Contrasena + "'," + 2 + ",'" + correo + "');", transConexion.miConexion);
                    query.ExecuteNonQuery(); //Ejecuta la consulta
                    Console.WriteLine("La insercion de los dataos a la tabla usuario ha sido un exito");
                    transConexion.cerrarConexion();
                }
                else {
                    Console.WriteLine("Existe un error");

                }


            }
            catch(Exception e) {

                Console.WriteLine("Error al ingresar su usuario: " + e.ToString());

            }


        }

        public void insertarUsuarioActivo(int iduser) {
            //resivira un entero que es el id del usuario que actualmente se crea para agregar los datos a la tabla de USUARIO_ESTADO
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO USUARIO_ESTADO VALUES(GETDATE(),1,"+iduser+");", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla usuario ha sido un exito");
                transConexion.cerrarConexion();
            }
            catch (Exception e) {

                Console.WriteLine("Error al ingresar su usuario: " + e.ToString());
            }

        }

        public void insertarUsuarioBloqueado(int iduser)
        {
            //resivira un entero que es el id del usuario que actualmente se crea para agregar los datos a la tabla de USUARIO_ESTADO como bloqueado
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO USUARIO_ESTADO VALUES(GETDATE(),3," + iduser + ");", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla usuario ha sido un exito");
                transConexion.cerrarConexion();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error al ingresar su usuario: " + e.ToString());
            }

        }

        public void insertarUsuarioEliminado(int iduser)
        {
            //resivira un entero que es el id del usuario que actualmente se crea para agregar los datos a la tabla de USUARIO_ESTADO eliminado
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO USUARIO_ESTADO VALUES(GETDATE(),2," + iduser + ");", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla usuario ha sido un exito");
                transConexion.cerrarConexion();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error al ingresar su usuario: " + e.ToString());
            }

        }

        public void insertarGenero(string nombre, string direccion) {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO GENERO VALUES('" + nombre + "','" + direccion+"');", transConexion.miConexion);
                query.ExecuteNonQuery();
                transConexion.cerrarConexion();
            }
            catch (Exception e) {

                Console.WriteLine("Error al ingresar su usuario: " + e.ToString());

            }

        }

        public void insertarArtista( string nombre, string anoFormacion, int codigopais, string descripcionartist, string facebok, string twitt, string youtub, string web,  string codigouser, string imagen) {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO ARTISTA VALUES('" + nombre + "','"+ anoFormacion+"',"+codigopais+",'"+ descripcionartist +"','"+ facebok+"','" + twitt +"','"+youtub +"','" + web +"',"+ codigouser + ",'"+imagen+"');", transConexion.miConexion);
                query.ExecuteNonQuery();
                transConexion.cerrarConexion();

            }
            catch (Exception e) {

                Console.WriteLine("Error al ingresar su usuario: " + e.ToString());
            }


        }
        // Funciona para el estado cualquiera solo recibira un entero segun sea el caso en el boton o la clase donde se implemente 
        public void insertarArtistaEstado(int estado, int artista) {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO ARTISTA_ESTADO VALUES("+estado+"," + artista + ",GETDATE());", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch(Exception ex) {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }



        }

        public void insertarArtistaGenero(ListaTexto listagenero, int codigoArtist) {
            try
            {
                NodoTexto nuevo;
                transConexion.abrirConexion();
                for (nuevo = listagenero.Cabeza; nuevo != null; nuevo = nuevo.Siguiente)
                {
                    query = new SqlCommand("INSERT INTO GENERO_ARTISTA VALUES(" + nuevo.Texto + "," + codigoArtist + ");", transConexion.miConexion);
                    query.ExecuteNonQuery();
                }
                transConexion.cerrarConexion();

            }
            catch (Exception ex) {
               Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }



        }

        // No voy a actualizar pais porque el usuario solo esta asociado a un solo pais 
        public void actualizarArtista(string ano, string descrip, string fotopath, string facebo, string twit, string youtube, string pagina, string idArtista)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("UPDATE ARTISTA SET Ano_Formacion = '"+ ano +"', Descripcion_Artista = '"+ descrip +"', Imagen = '"+ fotopath +"', Facebook = '"+facebo+"', Twitter= '"+twit+"', YouTube = '"+youtube+"', PaginaWeb = '"+pagina+"' WHERE Codigo_Artista ="+idArtista+";", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA ha sido un actualizado");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }



        }

        public void insertarAlbum( string titulo, string fecha , string  resena , string foto, string cofigoArtista ) {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO ALBUM VALUES('"+ titulo + "','" +fecha + "','"+resena+"','"+foto+"',"+cofigoArtista+"  );", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }




        }


        public void insertarAlbumEstado(int estado, string album)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO ALBUM_ESTADO VALUES(GETDATE()," + album + "," + estado + ");", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }

        public void insertarCancion(string album,  List<Cancion> listaEntrante) {

            try
            {
                transConexion.abrirConexion();


                for (int i = 0; i < listaEntrante.Count; i++) {

                    
                    query = new SqlCommand("INSERT INTO CANCION VALUES('" + listaEntrante.ElementAt(i).Nombre + "','" + listaEntrante.ElementAt(i).Duracion + "'," + album +",'"+listaEntrante.ElementAt(i).Url +"');", transConexion.miConexion);
                    query.ExecuteNonQuery(); //Ejecuta la consulta
                   


                }
                Console.WriteLine("La insercion de los dataos a la tabla canciones ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }



        }

        public void insertarCancionEstado(int estado, List<int> codigoCancion) {
            try
            {
                transConexion.abrirConexion();
                for (int i = 0; i < codigoCancion.Count; i++)
                {
                    query = new SqlCommand("INSERT INTO CANCION_ESTADO VALUES(GETDATE()," + codigoCancion.ElementAt(i) + "," + estado + ");", transConexion.miConexion);
                    query.ExecuteNonQuery(); //Ejecuta la consulta
                    Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                }
                 
               
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }


        }

        public void crearGenero(string nombre, string imagen) {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO GENERO VALUES('" + nombre + "','" + imagen + "');", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }

        public void crearNovedad(string titulo , string info , string imagen) {

            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO NOVEDAD VALUES('" + titulo + "','"+info +"','" + imagen + "');", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            
            }

        }


         public void crearFavoritoAlbum(string user, string album) {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO FAVORITO_ALBUM VALUES("+album+","+user+",GETDATE(),1);", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }



        public void crearFavoritoCancion(string codigouser,string cancion)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO FAVORITO_CANCION VALUES("+cancion + ","+codigouser+",GETDATE(),1);", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }



        public void ingrearMegustaAlbum(string album)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO ALBUM_MEGUSTA VALUES(1,"+album+");", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }




        public void ingrearMegustaCancion(string cancion)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("INSERT INTO CANCION_MEGUSTA VALUES(1," + cancion + ");", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }



        public void updateMegustaAlbum(string album)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("UPDATE ALBUM_MEGUSTA SET Me_Gusta = Me_Gusta + 1 WHERE FK_Codigo_Album =" + album + " ;", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }


        public void updateMegustaCancion(string cancion)
        {
            try
            {
                transConexion.abrirConexion();
                query = new SqlCommand("UPDATE CANCION_MEGUSTA SET Me_Gusta = Me_Gusta + 1 WHERE FK_Numero_Cancion =" + cancion + " ;", transConexion.miConexion);
                query.ExecuteNonQuery(); //Ejecuta la consulta
                Console.WriteLine("La insercion de los dataos a la tabla ARTISTA_ESTADO ha sido un exito");
                transConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar su usuario: " + ex.ToString());
            }

        }


    }







}

