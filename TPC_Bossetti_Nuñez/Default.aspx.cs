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
            Session.Add("ListaLibro", negocio.listarConSP());
            ListaLibro = (List<Libro>)Session["ListaLibro"];
            
            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaLibro;
                repRepetidor.DataBind();
            }

        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

            string IDLibro = ((Button)sender).CommandArgument;
            Session.Add("IDLibro", IDLibro);

            Response.Redirect("AltaLibro.aspx", false);
        }

        protected void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle.aspx", false);
        }

        protected void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Libro> Lista = (List<Libro>)Session["ListaLibro"];
            List<Libro> ListaFiltrada = Lista.FindAll(x => x.Titulo.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
            repRepetidor.DataSource = ListaFiltrada;
            repRepetidor.DataBind();
        }

        protected void chkAvanzado_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}