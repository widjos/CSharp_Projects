using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace RepositorioMusical.Clases
{
    public class Conexion
    {
        public String DB_Nombre;
        public SqlConnection miConexion;


        public Conexion()
        {
            DB_Nombre = " server=WINDOWS-RL87E9Q; database=RepositorioMusica ; Integrated security = true"; // Conexion de la base de datos   
        }

        // Metodo para abrir la conexion a la base de datos y comenzar a realizar consultas.

        public void abrirConexion() {
            try
            {
                miConexion = new SqlConnection(DB_Nombre);
                miConexion.Open();
                Console.WriteLine("Se ha abierto la conexion de la base de datos actual");

            }
            catch (Exception e) {
                Console.WriteLine("Error al cerrar la conexion de la base de datos");

            }

        }

        // Metodo para cerrar la conexion a la base de datos y finalizar la consulta.

        public void cerrarConexion() {
            try
            {
                miConexion.Close();
                Console.WriteLine("Se ha cerrado la conexion a su base de datos exitosamente.");
            }
            catch (Exception e) {
                
                Console.WriteLine(" Error al cerrar la conexion con su base de datos.");

            }


        }







    }
}