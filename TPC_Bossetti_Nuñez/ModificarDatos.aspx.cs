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
    public partial class ModificarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario prueba = (Usuario)Session["usuario"];
            if (Session["usuario"] == null)
            //if (!Seguridad.sesionActiva(Session["usuario"]))
            {
                Session.Add("error", "Qué onda pillín, tenés que loguearte primero");
                Response.Redirect("Error.aspx");
            }

            
            Usuario sesion = (Usuario)Session["usuario"];
            string idUsuario = sesion.IDUsuario.ToString();

            //string idUsuario = sesion.IDUsuario.ToString() != null ? sesion.IDUsuario.ToString() : "";

            if (idUsuario != "" && !IsPostBack)

            {
                //txtDNI.Enabled = false;
                txtMail.Enabled = false;
                txtPass.Enabled = false;

                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario modificar = (negocio.listar(idUsuario))[0];

                //txtidCliente.Text = idCliente;
                //txtidCliente.Text = modificar.IDCliente.ToString();
                txtApellido.Text = modificar.Apellidos;
                txtNombre.Text = modificar.Nombres;
                txtMail.Text = modificar.Mail;
                txtPass.Text = modificar.Contraseña;
                txtDNI.Text = modificar.Cliente.DNI;
                txtCel.Text = modificar.Cliente.Celular;
                txtTel.Text = modificar.Cliente.Telefono;
                txtCalle.Text = modificar.Cliente.Direccion.Calle;
                txtNum.Text = modificar.Cliente.Direccion.Numero;
                txtPiso.Text = modificar.Cliente.Direccion.Piso;
                txtDepto.Text = modificar.Cliente.Direccion.Depto;
                txtCity.Text = modificar.Cliente.Direccion.Localidad;
                txtProvincia.Text = modificar.Cliente.Direccion.Provincia;
                txtCopPostal.Text = modificar.Cliente.Direccion.CodPostal;
            }
            

            //2da PRUEBA 
            /**
            Usuario modificar = (Usuario)Session["usuario"];

            //txtDNI.Text = modificar.Cliente.DNI != null ? modificar.Cliente.DNI : "";
            txtDNI.Text = modificar.Cliente.DNI is null ? "" : modificar.Cliente.DNI;
            txtCel.Text = modificar.Cliente.Celular != null ? modificar.Cliente.Celular : "";
            txtTel.Text = modificar.Cliente.Telefono != null ? modificar.Cliente.Telefono : "";
            txtCalle.Text = modificar.Cliente.Direccion.Calle != null ? modificar.Cliente.Direccion.Calle : "";
            txtNum.Text = modificar.Cliente.Direccion.Numero;
            txtPiso.Text = modificar.Cliente.Direccion.Piso;
            txtDepto.Text = modificar.Cliente.Direccion.Depto;
            txtCity.Text = modificar.Cliente.Direccion.Localidad;
            txtProvincia.Text = modificar.Cliente.Direccion.Provincia;
            txtCopPostal.Text = modificar.Cliente.Direccion.CodPostal;
            

            //3era PRUEBA
            
            Usuario modificar = (Usuario)Session["usuario"];
            UsuarioNegocio negocio = new UsuarioNegocio();

            if (negocio.seleccionarClienteConSP((Usuario)Session["usuario"]))
                {
                txtApellido.Text = modificar.Apellidos;
                txtNombre.Text = modificar.Nombres;
                txtMail.Text = modificar.Mail;
                txtPass.Text = modificar.Contraseña;
                txtDNI.Text = modificar.Cliente.DNI;
                txtCel.Text = modificar.Cliente.Celular;
                txtTel.Text = modificar.Cliente.Telefono;
                txtCalle.Text = modificar.Cliente.Direccion.Calle;
                txtNum.Text = modificar.Cliente.Direccion.Numero;
                txtPiso.Text = modificar.Cliente.Direccion.Piso;
                txtDepto.Text = modificar.Cliente.Direccion.Depto;
                txtCity.Text = modificar.Cliente.Direccion.Localidad;
                txtProvincia.Text = modificar.Cliente.Direccion.Provincia;
                txtCopPostal.Text = modificar.Cliente.Direccion.CodPostal;
            }
            */

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();

            nuevo.Mail = txtMail.Text;
            nuevo.Contraseña = txtPass.Text;
            nuevo.Nombres = txtNombre.Text;
            nuevo.Apellidos = txtApellido.Text;
            nuevo.Cliente = new Cliente();
            nuevo.Cliente.DNI = txtDNI.Text;
            nuevo.Cliente.Telefono = txtTel.Text;
            nuevo.Cliente.Celular = txtCel.Text;

            nuevo.Cliente.Direccion = new Direccion();
            nuevo.Cliente.Direccion.Calle = txtCalle.Text;
            nuevo.Cliente.Direccion.Numero = txtNum.Text;
            nuevo.Cliente.Direccion.Piso = txtPiso.Text;
            nuevo.Cliente.Direccion.Depto = txtDepto.Text;
            nuevo.Cliente.Direccion.Localidad = txtCity.Text;
            nuevo.Cliente.Direccion.Provincia = txtProvincia.Text;
            nuevo.Cliente.Direccion.CodPostal = txtCopPostal.Text;
            //nuevo.IDCliente = int.Parse(txtidUsuario.Text);
            //nuevo.IDUsuario = int.Parse(Request.QueryString["idUsuario"]);

            Usuario sesion = (Usuario)Session["usuario"];
            nuevo.IDUsuario = sesion.IDUsuario;
            negocio.modificarConSP(nuevo);
            
            Response.Redirect("Default.aspx", false);
        }

        protected void btnModificarPass_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarContraseña.aspx?idCliente=" + Request.QueryString["idCliente"]);
        }
    }
}