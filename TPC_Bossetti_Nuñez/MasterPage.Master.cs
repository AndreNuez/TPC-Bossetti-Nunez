using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Bossetti_Nuñez
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public int CantidadCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Page is LogIn || Page is SignUp || Page is Default || Page is Error || Page is Carrito || Page is PrincipalAdmin || Page is AltaLibro || Page is Detalle))
            {
                if (!Seguridad.sesionActiva(Session["usuario"]))
                    Response.Redirect("LogIn.aspx", false);
            }

            CantidadCarrito = Session["CantidadCarrito"] != null ? (int)Session["CantidadCarrito"] : 0;
        }
    }
}