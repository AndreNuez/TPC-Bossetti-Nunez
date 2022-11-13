using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Bossetti_Nuñez
{
    public partial class ListadoLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LibroNegocio negocio = new LibroNegocio();
            dgvListaLibros.DataSource = negocio.ListarSPInactivos();
            dgvListaLibros.DataBind();

        }

        protected void dgvListaLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var IDLibro = dgvListaLibros.SelectedDataKey.Value;
            Session.Add("IDLibro", IDLibro);
            Response.Redirect("AltaLibro.aspx", false);
        }
    }
}