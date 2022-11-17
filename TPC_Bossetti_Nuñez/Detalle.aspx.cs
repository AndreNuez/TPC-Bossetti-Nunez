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
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string IDLibro = Session["IDLibro"] != null ? Session["IDLibro"].ToString() : "";

            if (IDLibro != "" && !IsPostBack)
            {
                LibroNegocio negocio = new LibroNegocio();
                Libro seleccionado = (negocio.listar(IDLibro))[0];

                lblTitulo.Text = seleccionado.Titulo;
                lblDescripcion.Text = seleccionado.Descripcion;
                lblAutor.Text = seleccionado.Autor;
                lblEditorial.Text = "Editorial " + seleccionado.Editorial;
                lblPrecio.Text = "Precio $ " + seleccionado.Precio.ToString();
                lblStock.Text = "Stock disponible: " + seleccionado.Stock.ToString() + " unidades";
                img.ImageUrl = seleccionado.PortadaURL.ToString();

            }
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx", false);
        }
    }
}