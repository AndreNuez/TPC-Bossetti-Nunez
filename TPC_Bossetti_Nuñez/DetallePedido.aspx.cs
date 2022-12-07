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
    public partial class DetallePedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaNegocio ventaNegocio = new VentaNegocio();
            //ItemCarrito items = new ItemCarrito();
            ItemCarritoNegocio itemNegocio = new ItemCarritoNegocio();

            venta.IDVenta = int.Parse(Session["idVenta"].ToString());
            ventaNegocio.seleccionaVenta(venta);

            dgvItems.DataSource = itemNegocio.Listar(int.Parse(Session["idVenta"].ToString()));
            dgvItems.DataBind();

            //if(Seguridad.esAdmin(Session["usuario"]) != TipoUsuario.ADMIN)
            //{
            //    rdbPendiente.Enabled = false;
            //    rdbEnPreparacion.Enabled = false;
            //    rdbEnviado.Enabled = false;
            //    rdbEntregado.Enabled = false;
            //
            //}

            if (char.Parse(venta.Estado.ToString()) == 'R')
            {
                lblEstadoPedido.Text = "Pendiente";
                //rdbPendiente.Checked = true;
            }
            else if (char.Parse(venta.Estado.ToString()) == 'P')
            {
                lblEstadoPedido.Text = "En Preparación";
                //rdbEnPreparacion.Checked = true;
            }
            else if (char.Parse(venta.Estado.ToString()) == 'E')
            {
                lblEstadoPedido.Text = "Enviado";
                //rdbEnviado.Checked = true;
            }
            else if (char.Parse(venta.Estado.ToString()) == 'C')
            {
                lblEstadoPedido.Text = "Entregado";
                //rdbEntregado.Checked = true;
            }

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            char estadoEnvio = 'R';

            if (rdbEnPreparacion.Checked)
                estadoEnvio = 'P';
            else if (rdbEnviado.Checked)
                estadoEnvio = 'E';
            else if (rdbEntregado.Checked)
                estadoEnvio = 'C';

            VentaNegocio negocio = new VentaNegocio();
            negocio.ModificaEstadoEnvio(int.Parse(Session["idVenta"].ToString()), estadoEnvio);
            Response.Redirect("PrincipalAdmin.aspx");
        }
    }
}