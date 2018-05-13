using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioAdministrador
{
    public partial class AdminAlbumesEliminados : System.Web.UI.Page
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
            var = miconsulta.selecAlbumesEliminados();
           tablitaAlbumEliminados.Text = var;
        }
    }
}