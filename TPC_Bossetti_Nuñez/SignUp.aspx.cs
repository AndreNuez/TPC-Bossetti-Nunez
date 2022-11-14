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
            txtidCliente.Enabled = false;

            //configuración si estamos modificando
            string idCliente = Request.QueryString["idCliente"] != null ? Request.QueryString["idCliente"].ToString() : "";
            if (idCliente != "" && !IsPostBack)
            {
                ClienteNegocio negocio = new ClienteNegocio();
                Cliente modificar = (negocio.listar(idCliente))[0];

                txtidCliente.Text = modificar.IDCliente.ToString();
                txtApellido.Text = modificar.Apellidos;
                txtNombre.Text = modificar.Nombres;
                txtMail.Text = modificar.Mail;
                txtPass.Text = modificar.Contraseña;
                txtDNI.Text = modificar.DNI;
                txtCel.Text = modificar.Celular;
                txtTel.Text = modificar.Telefono;
                txtCalle.Text = modificar.Direccion.Calle;
                txtNum.Text = modificar.Direccion.Numero;
                txtPiso.Text = modificar.Direccion.Piso;
                txtDepto.Text = modificar.Direccion.Depto;
                txtCity.Text = modificar.Direccion.Localidad;
                txtProvincia.Text = modificar.Direccion.Provincia;
                txtCopPostal.Text = modificar.Direccion.CodPostal;

            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();

            nuevo.IDCliente = int.Parse(txtidCliente.Text);
            nuevo.Mail = txtMail.Text;
            nuevo.Contraseña = txtPass.Text;
            nuevo.Nombres = txtNombre.Text;
            nuevo.Apellidos = txtApellido.Text;
            nuevo.DNI = txtDNI.Text;
            nuevo.Telefono = txtTel.Text;
            nuevo.Celular = txtCel.Text;

            nuevo.Direccion = new Direccion();
            nuevo.Direccion.Calle = txtCalle.Text;
            nuevo.Direccion.Numero = txtNum.Text;
            nuevo.Direccion.Piso = txtPiso.Text;
            nuevo.Direccion.Depto = txtDepto.Text;
            nuevo.Direccion.Localidad = txtCity.Text;
            nuevo.Direccion.Provincia = txtProvincia.Text;
            nuevo.Direccion.CodPostal = txtCopPostal.Text;

            if (Request.QueryString["idCliente"] != null)
                negocio.modificarConSP(nuevo);
            else
                negocio.Agregar(nuevo);


            Response.Redirect("Default.aspx", false);

        }
    }
}