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

    public partial class ModificarContraseña : System.Web.UI.Page
    {
        private string Pass1 { get; set; }
        private string Pass2 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Qué onda pillín, tenés que loguearte primero");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnGuardarPass_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

                Pass1 = txtNuevaPass.Text;
                Pass2 = txtConfirmarPass.Text;

                if (Pass1 == Pass2)
                {
                    /*Usuario seleccionado = (Usuario)Session["usuario"];
                    string idUsuario = seleccionado.IDUsuario.ToString();

                    UsuarioNegocio negocio = new UsuarioNegocio();
                    Usuario usuario = (negocio.listar(idUsuario))[0];

                    usuario.Contraseña = txtConfirmarPass.Text;
                    negocio.modificarConSP(usuario);
                    Response.Redirect("Default.aspx", false);*/

                    Usuario user = (Usuario)Session["usuario"];
                    UsuarioNegocio negocio = new UsuarioNegocio();

                    negocio.modificarPass(user.IDUsuario, Pass2);
                    Response.Redirect("Default.aspx", false);

                }
                else
                {
                    lblPass.Text = "Ingrese una contraseña correcta";
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}