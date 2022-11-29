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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Page is LogIn || Page is SignUp))
            {
                if (!Seguridad.sesionActiva(Session["usuario"]))
                    Response.Redirect("LogIn.aspx", false);
            }
        }
    }
}