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
        private string pass1 { get; set; }
        private string pass2 { get; set; }
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
                pass1 = txtNuevaPass.Text;
                pass2 = txtConfirmarPass.Text;

                if (pass1 == pass2)
                {
                    string idUsuario = Request.QueryString["idUsuario"].ToString();
                    
                    UsuarioNegocio negocio = new UsuarioNegocio();
                    Usuario usuario = (negocio.listar(idUsuario))[0];

                    usuario.Contraseña = txtConfirmarPass.Text;
                    negocio.modificarConSP(usuario);
                    Response.Redirect("SignUp.aspx?idUsuario=" + idUsuario);
                }
                else
                {
                    lblPass.Text = "Ingrese una contraseña correcta";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}