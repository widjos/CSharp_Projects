using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioMusical.Clases;

namespace RepositorioMusical.UsuarioConsulta
{
    public partial class Tendencias : System.Web.UI.Page
    {
        Consultas miconsulta;

        protected void Page_Load(object sender, EventArgs e)
        {
            miconsulta = new Consultas();

            top1.Text = miconsulta.masInfluyentesArtista();

            TOP2.Text = miconsulta.masInfluyentesCancionArtTOP10();

            TOP3.Text = miconsulta.AlbumesPopulares();


        }
    }
}