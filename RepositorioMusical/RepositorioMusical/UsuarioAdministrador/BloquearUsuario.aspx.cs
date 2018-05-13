using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class BloquearUsuario : System.Web.UI.Page
    {
        Clases.Consultas miConsulta;
        Clases.Insercion miInsert;
        int idUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            idUser = 0;
            miConsulta = new Clases.Consultas();
            miInsert = new Clases.Insercion();
        }

        protected void BloquearUser_Click(object sender, EventArgs e)
        {
            if (UCorreo.Text == "")
            {
                error.Text = "Debe de ingresar un correo";
                error.Visible = true;
                UCorreo.Focus();
                return;
            }
            else if (Ufechanac.Text == "")
            {
                error.Text = "Debe la fecha de nacimiento del usuario.";
                error.Visible = true;
                Ufechanac.Focus();
                return;
            }

            try
            {
                idUser = miConsulta.retornarIdUserFecha(UCorreo.Text, Ufechanac.Text);
                Console.WriteLine("Valor de Iduser actual" + idUser);
                miInsert.insertarUsuarioBloqueado(idUser);

            }
            catch (Exception erre)
            {

                error.Text = "Correo o contraseña no valida!";
                Console.WriteLine("Valor de Iduser actual" + idUser);
                error.Visible = true;
            }


        }
    }
}