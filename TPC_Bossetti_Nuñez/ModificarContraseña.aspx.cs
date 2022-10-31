using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Bossetti_Nuñez
{
    public partial class ModificarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarPass_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosCliente.aspx");
        }
    }
}