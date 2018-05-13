using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class ConsultaUsuariosActuales : System.Web.UI.Page
    {
        Clases.Consultas miconsulta;
        string var;

        protected void Page_Load(object sender, EventArgs e)
        {
            miconsulta = new Clases.Consultas();
            var = "";
        }

        protected void mostrarUser_Click(object sender, EventArgs e)
        {
            var = miconsulta.selecUsuariosActuales();
            codigo.Text = var;
        }
    }
}