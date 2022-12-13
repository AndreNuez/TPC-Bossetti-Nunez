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

    public partial class RestablecerContraseña : System.Web.UI.Page
    {
        private string Pass1 { get; set; }
        
        private string Pass2 { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRestablecerPass_Click(object sender, EventArgs e)
        {
            Pass1 = txtNuevaPass.Text;
            Pass2 = txtConfirmarPass.Text;

            if (Pass1 == Pass2)
            {
                UsuarioNegocio negocio = new UsuarioNegocio();

                try
                {
                    Page.Validate();
                    if (!Page.IsValid)
                        return;

                    negocio.RestablecerPass(txtMail.Text, txtConfirmarPass.Text, txtCodigo.Text);
                    Response.Redirect("LogIn.aspx", false);
                }
                catch (Exception ex)
                {
                    Session.Add("error", ex.ToString());
                    Response.Redirect("Error.aspx", false);
                    
                }

            }

            else
            {
                lblPass.Text = "Las contraseñas deben ser iguales.";
            }

        }
    }
}