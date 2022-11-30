using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TPC_Bossetti_Nuñez
{
    public partial class Carrito : System.Web.UI.Page
    {
        public decimal TotalCarrito { get; set; }
        public int CantidadCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            List<ItemCarrito> ListaCarrito = (List<ItemCarrito>)Session["ListaCarrito"] != null ?
                (List<ItemCarrito>)Session["ListaCarrito"] : ListaCarrito = new List<ItemCarrito>();

            CantidadCarrito = CalcularCantidad(ListaCarrito);
            Session.Add("CantidadCarrito", CantidadCarrito);
            Session.Add("ListaCarrito", ListaCarrito);
            lblTotalCarrito.Text = "Total Carrito $" + CalcularTotal(ListaCarrito).ToString();

            if (!IsPostBack)
            {
                dgvCarrito.DataSource = ListaCarrito;
                dgvCarrito.DataBind();
            }
        }

        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            short IDItem = (short)dgvCarrito.SelectedDataKey.Value;

            int posItem = BuscarItem((List<ItemCarrito>)Session["ListaCarrito"], IDItem);

            List<ItemCarrito> Temporal = (List<ItemCarrito>)Session["ListaCarrito"];

            if (Temporal[posItem].Cantidad > 1)
            {
                Temporal[posItem].Precio -= Temporal[posItem].Precio / Temporal[posItem].Cantidad;
                Temporal[posItem].Cantidad--;
            }
            else
            {
                ItemCarrito Eliminado = Temporal.Find(x => x.IDItem == IDItem);
                Temporal.Remove(Eliminado);
            }

            CantidadCarrito = CalcularCantidad(Temporal);
            
            Session.Add("CantidadCarrito", CantidadCarrito);
            Session.Add("ListaCarrito", Temporal);
            
            Response.Redirect("Carrito.aspx", false);

        }

        protected int BuscarItem(List<ItemCarrito> ListaCarrito, int IDItem)
        {
            int pos;

            foreach (ItemCarrito item in ListaCarrito)
            {
                if (item.IDItem == IDItem)
                {
                    pos = ListaCarrito.IndexOf(item);
                    return pos;
                }
            }

            return -1;
        }

        protected decimal CalcularTotal(List<ItemCarrito> ListaCarrito)
        {
            foreach (ItemCarrito item in ListaCarrito)
            {
                TotalCarrito += item.Precio;
            }

            return TotalCarrito;
        }

        protected int CalcularCantidad(List<ItemCarrito> ListaCarrito)
        {
            foreach (ItemCarrito item in ListaCarrito)
            {
                CantidadCarrito += item.Cantidad;
            }

            return CantidadCarrito;
        }

        protected void btnComprarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfirmaCompra.aspx", false);
        }
    }
}