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
    public partial class PrincipalAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Seguridad.esAdmin(Session["usuario"]) != TipoUsuario.ADMIN)
            {
                Session.Add("error", "Se requieren permisos de Administrador para acceder a esta pantalla");
                Response.Redirect("Error.aspx");
            }

        }

        protected void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            Session.Remove("IDLibro");
            Response.Redirect("AltaLibro.aspx", false);
        }
    }
}