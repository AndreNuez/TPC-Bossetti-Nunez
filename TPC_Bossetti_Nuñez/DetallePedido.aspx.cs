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
    public partial class DetallePedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaNegocio ventaNegocio = new VentaNegocio();
            //ItemCarrito items = new ItemCarrito();
            ItemCarritoNegocio itemNegocio = new ItemCarritoNegocio();

            venta.IDVenta = int.Parse(Session["idVenta"].ToString());
            ventaNegocio.seleccionaVenta(venta);

            dgvItems.DataSource = itemNegocio.Listar(int.Parse(Session["idVenta"].ToString()));
            dgvItems.DataBind();
            
        }
    }
}