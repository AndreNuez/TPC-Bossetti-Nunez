using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Bossetti_Nuñez
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Libro> ListaLibro { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            LibroNegocio negocio = new LibroNegocio();
            ListaLibro = negocio.listarConSP();

            repRepetidor.DataSource = ListaLibro;
            repRepetidor.DataBind();
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaLibro.aspx");
        }

        protected void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle.aspx", false);
        }
    }
}