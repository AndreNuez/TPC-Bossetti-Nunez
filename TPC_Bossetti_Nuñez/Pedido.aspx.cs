using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Bossetti_Nuñez
{
    public partial class Pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VentaNegocio pedido = new VentaNegocio();
            dgvPedidos.DataSource = pedido.listar();
            dgvPedidos.DataBind();
        }
    }
}