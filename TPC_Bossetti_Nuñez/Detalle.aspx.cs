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
        public List<Libro> ListaLibro { get; set; }
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
            string IDLibro = Session["IDLibro"].ToString();

            List<ItemCarrito> ListaCarrito = (List<ItemCarrito>)Session["ListaCarrito"] != null ?
                (List<ItemCarrito>)Session["ListaCarrito"] : ListaCarrito = new List<ItemCarrito>();

            LibroNegocio negocio = new LibroNegocio();

            ListaLibro = negocio.listar(IDLibro);

            ItemCarrito NuevoItem = new ItemCarrito();
            NuevoItem.IDItem = ListaLibro[0].ID;
            NuevoItem.NombreItem = ListaLibro[0].Titulo;
            NuevoItem.Cantidad = 1;
            NuevoItem.Precio = ListaLibro[0].Precio;

            if ((List<ItemCarrito>)Session["ListaCarrito"] != null)
            {
                int posItem = BuscarItem(ListaCarrito, NuevoItem);

                if (posItem != -1)
                {
                    ListaCarrito[posItem].Cantidad++;
                    ListaCarrito[posItem].Precio += NuevoItem.Precio;
                }
                else
                {
                    ListaCarrito.Add(NuevoItem);
                }
            }
            else
            {
                ListaCarrito.Add(NuevoItem);
            }

            Session.Add("ListaCarrito", ListaCarrito);
            Response.Redirect("Carrito.aspx", false);
        }

        protected int BuscarItem(List<ItemCarrito> ListaCarrito, ItemCarrito NuevoItem)
        {
            int pos;

            foreach (ItemCarrito item in ListaCarrito)
            {
                if (item.IDItem == NuevoItem.IDItem)
                {
                    pos = ListaCarrito.IndexOf(item);
                    return pos;
                }
            }

            return -1;
        }

    }
}