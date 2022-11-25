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
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                UsuarioNegocio usuarionegocio = new UsuarioNegocio();
                user.Apellidos = txtApellido.Text;
                user.Nombres = txtNombre.Text;
                user.Mail = txtMail.Text;
                user.Contraseña = txtPass.Text;
                user.TipoUsuario = (int)(Session["TipoUsuario"]) == 1 ? TipoUsuario.CLIENTE : TipoUsuario.ADMIN;
                int id = usuarionegocio.insertarNuevo(user);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}