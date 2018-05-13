using RepositorioMusical.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class AdminArtistasEliminados : System.Web.UI.Page
    {
        Consultas miconsulta;
        string var;

        protected void Page_Load(object sender, EventArgs e)
        {
            miconsulta = new Clases.Consultas();
            var = "";
        }

        protected void btnMostrareliminados_Click(object sender, EventArgs e)
        {
            var = miconsulta.selecArtistasEliminados();
            tablitaArtEliminados.Text = var;

        }
    }
}