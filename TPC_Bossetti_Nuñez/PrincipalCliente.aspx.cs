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
    public partial class PrincipalCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["usuario"];
            UsuarioNegocio negocio = new UsuarioNegocio();

            negocio.eliminarFisicoClienteConSP(user.IDUsuario);
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}