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
    public partial class AdminCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario cliente = new Usuario();
            VentaNegocio pedido = new VentaNegocio();
            dgvPedidos.DataSource = pedido.ListarVentas();
            dgvPedidos.DataBind();
        }

        protected void dgvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idVenta = dgvPedidos.SelectedDataKey.Value.ToString();
            Session.Add("idVenta", idVenta);
            Response.Redirect("DetallePedido.aspx");
        }

        protected void dgvPedidos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvPedidos.PageIndex = e.NewPageIndex;
            dgvPedidos.DataBind();
        }
    }
}