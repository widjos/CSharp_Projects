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
                if (nombre.Length > 4 && apellido.Length > 4 && usuario.Length > 5 && Contrasena.Length > 6)
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



    }


}