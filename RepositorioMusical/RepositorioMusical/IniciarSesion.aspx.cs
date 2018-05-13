using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepositorioMusical
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        RepositorioMusical.Clases.Consultas miConsulta;
        int idUser;
        int idUser2;

        protected void Page_Load(object sender, EventArgs e)
        {
            idUser = 0;  // Tipo de ususario
            idUser2 = 0; // id del usuario
            miConsulta = new RepositorioMusical.Clases.Consultas();
            
            
        }

        protected void IngresarUser_Click(object sender, EventArgs e)
        {
         

            if (Correo.Text == "")
            {
                error.Text = "Debe de ingresar un correo";
                error.Visible = true;
                Correo.Focus();
                return;
            }
            else if (contrasena.Text == "") {
                error.Text = "Debe de ingresar su contraseña.";
                error.Visible = true;
                contrasena.Focus();
                return;
            }

            try
            {
                idUser = miConsulta.retornarTipoUser(Correo.Text, contrasena.Text); // Devuelve el tipo de usuario que se esta logueando
                idUser2 = miConsulta.retornarIdUser(Correo.Text, contrasena.Text); 
                Console.WriteLine("Valor de Iduser actual" + idUser);
                if (idUser == 1)
                {

                    Session["Codigo_Usuario"] = idUser2; //La variable de sesion almacena el valor del id del usuario logueado que sera utilizado luego
                    
                    Response.Redirect("~/UsuarioAdministrador/AdministradorInicio.aspx");
                    
                }
                else if (idUser == 2)
                {
                    Session["Codigo_Usuario"] = idUser2; //La variable de sesion almacena el valor del id del usuario logueado que sera utilizado luego


                    Response.Redirect("~/UsuarioConsulta/Usuario.aspx");
                  
                    
                }
                else {
                    error.Visible = true;
                }

            }
            catch (Exception err) {

                error.Text = "Correo o contraseña no valida!";
                Console.WriteLine("Valor de Iduser actual" + idUser);
                error.Visible = true;
            }

            
         }
    }
}