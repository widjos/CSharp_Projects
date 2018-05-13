using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class Reportes : System.Web.UI.Page
    {
        Consultas miconsulta;

        protected void Page_Load(object sender, EventArgs e)
        {
            miconsulta = new Consultas();


        }

        protected void masinfluyentes_Click(object sender, EventArgs e)
        {
            influyentes.Text = miconsulta.masInfluyentes();

        }

        protected void favoritos_Click(object sender, EventArgs e)
        {


        }
    }
}