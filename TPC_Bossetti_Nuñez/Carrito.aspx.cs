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
        protected void Page_Load(object sender, EventArgs e)
        {

            List<ItemCarrito> ListaCarrito = (List<ItemCarrito>)Session["ListaCarrito"] != null ?
                (List<ItemCarrito>)Session["ListaCarrito"] : ListaCarrito = new List<ItemCarrito>();

            Session.Add("ListaCarrito", ListaCarrito);

            if (!IsPostBack)
            {
                dgvCarrito.DataSource = ListaCarrito;
                dgvCarrito.DataBind();
            }
        }

        protected void btnComprarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfirmaCompra.aspx", false);
        }
    }
}