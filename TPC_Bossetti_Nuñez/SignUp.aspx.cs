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
                EmailService emailService = new EmailService();
                
                user.Apellidos = txtApellido.Text;
                user.Nombres = txtNombre.Text;
                user.Mail = txtMail.Text;
                user.Contraseña = txtPass.Text;
                user.TipoUsuario = TipoUsuario.CLIENTE;
                user.IDUsuario = usuarionegocio.insertarNuevo(user);
                Session.Add("usuario", user);

                emailService.ArmarCorreo(txtMail.Text,"Registración Exitosa","Te has registrado correctamente en TuLibro.com");
                emailService.EnviarEmail();

                Response.Redirect("Default.aspx", false);
                
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
            }
    }
}