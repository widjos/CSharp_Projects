using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RepositorioMusical

{
    public partial class Registrarse : System.Web.UI.Page
    {

        RepositorioMusical.Clases.Insercion miInsert; // Declaro una variable de tipo Insercion
        RepositorioMusical.Clases.Consultas miConsulta; // Declaro una variable de tipo Consultas 


        protected void Page_Load(object sender, EventArgs e)
        {
            miInsert = new RepositorioMusical.Clases.Insercion(); // Inicializo la variable miInsert
            miConsulta = new RepositorioMusical.Clases.Consultas();

        }

        protected void CrearCuenta_Click(object sender, EventArgs e)
        {


            verificarLimpiar(Nombre, Mensaje);
            verificarLimpiar(apellido, Mensaje);
            verificarLimpiar(NomUser, Mensaje);
            verificarLimpiar(FechaNac, Mensaje);
            verificarLimpiar(CorreoElect, Mensaje);
            verificarLimpiar(Contraseña, Mensaje);
            verificarLimpiar(ContraseñaVerificacion, Mensaje);

            if (Contraseña.Text != ContraseñaVerificacion.Text) {

                Mensaje.Text = "Las contraseñas no coinciden";
            }
            else {

                // Inserta los datos del usuario nuevo en la tabla: USUARIO
                miInsert.insertarUsuario(Nombre.Text, apellido.Text, NomUser.Text, FechaNac.Text, Contraseña.Text, CorreoElect.Text);  // Cuando se presiona el boton se hara el insert

                // Inserta el estado actual del Usuario recien creado a la base de datos en la tabla : USUARIO_ESTADO

                miInsert.insertarUsuarioActivo((miConsulta.retornarIdUser(CorreoElect.Text, Contraseña.Text)));

                // Limpia todos los campos 
                limpiarCampos(Nombre);
                limpiarCampos(apellido);
                limpiarCampos(NomUser);
                limpiarCampos(FechaNac);
                limpiarCampos(CorreoElect);
                limpiarCampos(Contraseña);
                limpiarCampos(ContraseñaVerificacion);

           


            }
        }

        //Este metodo verifica que los campos no esten vacios para hacer la insercion .

        private void verificarLimpiar(TextBox entrada, Label mensaje) {
            if (entrada.Text != "")
            {
                mensaje.Text = "";
                return;
                
            }
            else {
                mensaje.Text = "Debe ingresar datos en el campo vacio";
            }

        }


        private void limpiarCampos(TextBox entrada) {
            entrada.Text = "";
        }
    }
}