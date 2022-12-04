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
    public partial class ConfirmaCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["usuario"];

            lblCalle.Text = usuario.Cliente.Direccion.Calle.ToString();
            lblCP.Text = usuario.Cliente.Direccion.CodPostal.ToString();
            lblLocalidad.Text = usuario.Cliente.Direccion.Localidad.ToString();
            lblProvincia.Text = usuario.Cliente.Direccion.Provincia.ToString();


                
        }

        protected void btnConfirmaCompra_Click(object sender, EventArgs e)
        {
            Venta nueva = new Venta();
            VentaNegocio negocio = new VentaNegocio();
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["usuario"];

            nueva.IDUsuario = usuario.IDUsuario;
            
            if (rdbEfectivo.Checked)
                nueva.FormaPago = 'E';
            else
                nueva.FormaPago = 'T';

            if (rdbRetiro.Checked)
                nueva.MetodoEnvio = 'R';
            else
                nueva.MetodoEnvio = 'E';

            nueva.PrecioTot = (decimal)Session["TotalCarrito"];
            nueva.CantTot = (int)Session["CantidadCarrito"];
            nueva.DomicilioEntrega.Calle = usuario.Cliente.Direccion.Calle;
            nueva.DomicilioEntrega.Numero = usuario.Cliente.Direccion.Numero;
            nueva.DomicilioEntrega.Piso = usuario.Cliente.Direccion.Piso;
            nueva.DomicilioEntrega.Depto = usuario.Cliente.Direccion.Depto;
            nueva.DomicilioEntrega.CodPostal = usuario.Cliente.Direccion.CodPostal;
            nueva.DomicilioEntrega.Localidad = usuario.Cliente.Direccion.Localidad;
            nueva.DomicilioEntrega.Provincia = usuario.Cliente.Direccion.Provincia;

            negocio.Agregar(nueva);

            Response.Redirect("CompraRealizada.aspx", false);
        }
    }
}