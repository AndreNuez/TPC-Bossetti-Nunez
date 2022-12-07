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
    public partial class CompraRealizada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                dgvCarrito.DataSource = (List<ItemCarrito>)Session["ListaCarrito"];
                dgvCarrito.DataBind();
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Session.Remove("ListaCarrito");
            Response.Redirect("Default.aspx", false);
        }
    }
}