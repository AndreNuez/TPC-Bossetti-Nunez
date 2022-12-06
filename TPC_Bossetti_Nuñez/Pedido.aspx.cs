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
    public partial class Pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["usuario"];
            VentaNegocio pedido = new VentaNegocio();
            dgvPedidos.DataSource = pedido.listar(user.IDUsuario);
            dgvPedidos.DataBind();
        }

        protected void dgvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Add("idCompra", dgvPedidos.SelectedDataKey.Value.ToString());
            Response.Redirect("DetallePedido.aspx");
        }
    }
}