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
        protected void Page_Load(object sender, EventArgs e)
        {
            string idCliente = Request.QueryString["idCliente"] != null ? Request.QueryString["idCliente"].ToString() : "";
            if (idCliente != "")
            {
                ClienteNegocio negocio = new ClienteNegocio();
                Cliente seleccionado = (negocio.listar(idCliente))[0];

                lblNombre.Text = seleccionado.Nombres;
                lblApellido.Text = seleccionado.Apellidos;
                lblMail.Text = seleccionado.Mail;
                lblDireccion1.Text = seleccionado.Direccion.Calle + ", " +seleccionado.Direccion.Numero + ", " + seleccionado.Direccion.Piso + ", " + seleccionado.Direccion.Depto;
                lblDireccion2.Text = "(" + seleccionado.Direccion.CodPostal + ") " + seleccionado.Direccion.Localidad;
                lblProvincia.Text = seleccionado.Direccion.Provincia;
                lblCelular.Text = seleccionado.Celular;

                Session.Add("clienteSeleccionado", seleccionado);

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
                ClienteNegocio negocio = new ClienteNegocio();
                Cliente seleccionado = (Cliente)Session["clienteSeleccionado"];

                negocio.eliminarLogico(seleccionado.IDCliente, !seleccionado.Estado);
                Response.Redirect("AdminClientes.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}