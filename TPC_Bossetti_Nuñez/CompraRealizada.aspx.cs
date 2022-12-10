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
    public partial class CompraRealizada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaNegocio ventaNegocio = new VentaNegocio();

            if (!IsPostBack)
            {
                dgvCarrito.DataSource = (List<ItemCarrito>)Session["ListaCarrito"];
                dgvCarrito.DataBind();
            }

            venta.IDVenta = (int)Session["IDVenta"];
            ventaNegocio.seleccionaVenta(venta);

            if(venta.FormaPago == 'T' && venta.Envio)
            {
                lblPago.Text = "A la brevedad te estaremos enviando un correo con los datos para realizar el pago.";
                lblEnvio.Text = "Recibirás tu pedido en la dirección proporcionada a través de Correo Argentino.";
            }
            else if (venta.FormaPago == 'E' && venta.Envio)
            {
                lblPago.Text = "Abona contraentrega al repartidor.";
                lblEnvio.Text = "Recibirás tu pedido por motomensajéría.";
            }
            else if (venta.FormaPago=='T' && !venta.Envio)
            {
                lblPago.Text = "A la brevedad te estaremos enviando un correo con los datos para realizar el pago.";
                lblEnvio.Text = "Retira en nuestro local situado en Av.Hipólito Yrigoyen 288 - Gral.Pacheco, Provincia de Buenos Aires.";
            }
            else
            {
                lblPago.Text = "Abona al retirar.";
                lblEnvio.Text = "Retira en nuestro local situado en Av.Hipólito Yrigoyen 288 - Gral.Pacheco, Provincia de Buenos Aires.";
            }

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Session.Remove("ListaCarrito");
            Response.Redirect("Default.aspx", false);
        }
    }
}