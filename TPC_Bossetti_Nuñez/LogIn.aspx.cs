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
    public partial class Loguin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            try
            {
                usuario = new Usuario(txtEmail.Text, txtPassword.Text);
                if (usuarioNegocio.Loguear(usuario))
                {
                    if (usuario.TipoUsuario == TipoUsuario.ADMIN)
                    {
                        AdminNegocio adminNegocio = new AdminNegocio();
                        Administrador admin = (adminNegocio.listar(usuario.IDUsuario.ToString()))[0];
                        Session.Add("usuario", admin);
                        Response.Redirect("Default.aspx");
                    }
                    else if (usuario.TipoUsuario == TipoUsuario.CLIENTE)
                    {
                        ClienteNegocio clienteNegocio = new ClienteNegocio();
                        Cliente cliente = (clienteNegocio.listar(usuario.IDUsuario.ToString()))[0];
                        Session.Add("usuario", cliente);
                        Response.Redirect("Default.aspx");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}