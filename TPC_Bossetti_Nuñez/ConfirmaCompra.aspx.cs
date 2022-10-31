using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Bossetti_Nuñez
{
    public partial class ConfirmaCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlFormaPago.Items.Add("Efectivo");
            ddlFormaPago.Items.Add("Pago digital");
        }

        protected void btnConfirmaCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompraRealizada.aspx", false);
        }
    }
}