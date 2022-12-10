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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public int CantidadCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Page is LogIn || Page is SignUp || Page is Default || Page is Error || Page is RestablecerContraseña || Page is EnviarCodigo || Page is Carrito))
            {
                if (!Seguridad.sesionActiva(Session["usuario"]))
                    Response.Redirect("LogIn.aspx", false);
                else
                {
                    Usuario user = (Usuario)Session["usuario"];
                    //lblUser.Text = user.Nombres + user.Apellidos;
                }
            }

            CantidadCarrito = Session["CantidadCarrito"] != null ? (int)Session["CantidadCarrito"] : 0;
            cant.InnerHtml = "Carrito (" +CantidadCarrito.ToString() + ")";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}