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
    public partial class DatosCliente : System.Web.UI.Page
    {
        public bool ConfirmaEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Seguridad.esAdmin(Session["usuario"]) != TipoUsuario.ADMIN)
            {
                Session.Add("error", "Se requieren permisos de Administrador para acceder a esta pantalla");
                Response.Redirect("Error.aspx");
            }

            if(!IsPostBack)
                ConfirmaEliminacion = false;

            //string idUsuario = Request.QueryString["idUsuario"] != null ? Request.QueryString["idUsuario"].ToString() : "";
            string idUsuario = (string)Session["idUsuario"];

            if (idUsuario != "")
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario seleccionado = (negocio.listar(idUsuario))[0];

                lblNombre.Text = seleccionado.Nombres;
                lblApellido.Text = seleccionado.Apellidos;
                lblMail.Text = seleccionado.Mail;
                lblDireccion1.Text = seleccionado.Cliente.Direccion.Calle + ", " +seleccionado.Cliente.Direccion.Numero + ", " + seleccionado.Cliente.Direccion.Piso + ", " + seleccionado.Cliente.Direccion.Depto;
                lblDireccion2.Text = "(" + seleccionado.Cliente.Direccion.CodPostal + ") " + seleccionado.Cliente.Direccion.Localidad;
                lblProvincia.Text = seleccionado.Cliente.Direccion.Provincia;
                lblCelular.Text = seleccionado.Cliente.Celular;

                Session.Add("usuarioSeleccionado", seleccionado);

                if (!seleccionado.Estado)
                {
                    btnActivar.Text = "Activar";
                }

            }
        }

        protected void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario seleccionado = (Usuario)Session["usuarioSeleccionado"];

                negocio.eliminarLogico(seleccionado.IDUsuario, !seleccionado.Estado);
                Response.Redirect("AdminClientes.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ConfirmaEliminacion)
                ConfirmaEliminacion = true;
            else
                ConfirmaEliminacion = false;
        }

        protected void btnConfirmaEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (chkConfirmaEliminacion.Checked)
                {
                    UsuarioNegocio negocio = new UsuarioNegocio();
                    //negocio.eliminarFisicoConSP(short.Parse(Request.QueryString["idUsuario"]));
                    Usuario seleccionado = (Usuario)Session["usuarioSeleccionado"];
                    negocio.eliminarFisicoConSP(short.Parse(seleccionado.IDUsuario.ToString()));
                    Response.Redirect("AdminClientes.aspx", false);
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