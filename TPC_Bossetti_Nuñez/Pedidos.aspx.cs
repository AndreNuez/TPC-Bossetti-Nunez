using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Bossetti_Nuñez
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarritoNegocio pedido = new CarritoNegocio();
            dgvPedidos.DataSource = pedido.listar();
            dgvPedidos.DataBind();
        }
    }
}