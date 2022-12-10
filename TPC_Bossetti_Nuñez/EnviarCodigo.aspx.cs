using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace TPC_Bossetti_Nuñez
{
    public partial class EnviarCodigo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            Password pass = new Password();
            pass.generarCodigo(txtMail.Text);
            pass.EnviarCodigo(txtMail.Text);
            Response.Redirect("RestablecerContraseña.aspx", false);
        }
    }
}