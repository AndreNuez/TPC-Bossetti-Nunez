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
        public bool Direccion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaNegocio ventaNegocio = new VentaNegocio();
            ItemCarritoNegocio itemNegocio = new ItemCarritoNegocio();
            Direccion = true;

            venta.IDVenta = int.Parse(Session["idVenta"].ToString());
            ventaNegocio.seleccionaVenta(venta);

            idventa.InnerHtml = "Detalle Pedido #" + venta.IDVenta;

            dgvItems.DataSource = itemNegocio.Listar(int.Parse(Session["idVenta"].ToString()));
            dgvItems.DataBind();

            UsuarioNegocio clientenegocio = new UsuarioNegocio();
            string id = venta.IDUsuario.ToString();
            Usuario cliente = (clientenegocio.listar(id))[0];

            lblCliente.Text = cliente.Apellidos + ',' + cliente.Nombres;
            lblMail.Text = cliente.Mail;

            lblFechaPedido.Text = venta.Fecha.ToString();
            lblCantidad.Text = venta.Cantidad.ToString();
            lblFormaPago.Text = venta.FormaPago == 'E' ? "Efectivo" : "Mercado Pago";
            lblTotal.Text = venta.Importe.ToString();

            if (!string.IsNullOrEmpty(venta.DomicilioEntrega.Calle))
            {
                lblCalle.Text = venta.DomicilioEntrega.Calle.ToString();
                lblNumero.Text = venta.DomicilioEntrega.Numero.ToString();

                if (!string.IsNullOrEmpty(venta.DomicilioEntrega.Piso))
                    lblPiso.Text = venta.DomicilioEntrega.Piso.ToString();

                if (!string.IsNullOrEmpty(venta.DomicilioEntrega.Depto))
                    lblDepto.Text = venta.DomicilioEntrega.Depto.ToString();

                lblLocalidad.Text = venta.DomicilioEntrega.Localidad.ToString();
                lblProvincia.Text = "  " + venta.DomicilioEntrega.Localidad.ToString();
                lblCP.Text = "CP " + venta.DomicilioEntrega.CodPostal.ToString();
            }
            else
            {
                Direccion = false;
            }


            if (char.Parse(venta.Estado.ToString()) == 'R')
            {
                lblEstadoPedido.Text = "Pendiente";
            }
            else if (char.Parse(venta.Estado.ToString()) == 'P')
            {
                lblEstadoPedido.Text = "En Preparación";
            }
            else if (char.Parse(venta.Estado.ToString()) == 'E')
            {
                lblEstadoPedido.Text = "Enviado";
            }
            else if (char.Parse(venta.Estado.ToString()) == 'C')
            {
                lblEstadoPedido.Text = "Entregado";
            }

            if (!IsPostBack)
            {
                EstadoCompra estadoCompra = new EstadoCompra();
                //estadoCompra.IdVenta = int.Parse(Session["idVenta"].ToString());
                estadoCompra.IdVenta = venta.IDVenta;
                ventaNegocio.leeEstadoCompra(estadoCompra);

                //txtPendiente.Text = estadoCompra.IdVenta.ToString();
                //if (estadoCompra.CodCompra != null)
                //    txtEnPreparacion.Text = estadoCompra.CodCompra.ToString();
                //if(estadoCompra.Envio != null)
                //    txtEnviado.Text = estadoCompra.Envio.ToString();
                //if(estadoCompra.Entrega != null)
                //    txtEntregado.Text = estadoCompra.Entrega.ToString();

                if (estadoCompra.CodCompra != null)
                    txtEnPreparacion.Text = estadoCompra.CodCompra.ToString();
                if (!string.IsNullOrEmpty(estadoCompra.Envio.ToString()))
                {
                    estadoCompra.Envio2 = (DateTime)estadoCompra.Envio;
                    txtEnviado.Text = estadoCompra.Envio2.ToString("yyyy-MM-dd");
                }
                if (!string.IsNullOrEmpty(estadoCompra.Entrega.ToString()))
                {
                    estadoCompra.Entrega2 = (DateTime)estadoCompra.Entrega;
                    txtEntregado.Text = estadoCompra.Entrega2.ToString("yyyy-MM-dd");
                }
            }
            
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            /*
            Venta venta = new Venta();
            VentaNegocio ventaNegocio = new VentaNegocio();
            venta.IDVenta = int.Parse(Session["idVenta"].ToString());
            ventaNegocio.seleccionaVenta(venta);
            */
            
            //char estadoEnvio = char.Parse(venta.Estado.ToString());

            //Modifico para modificar estado compra con TextBox
            /*
            if (rdbEnPreparacion.Checked)
                estadoEnvio = 'P';
            else if (rdbEnviado.Checked)
                estadoEnvio = 'E';
            else if (rdbEntregado.Checked)
                estadoEnvio = 'C';
            */

            //Esto debería de tomarse según a Tabla EstadoVenta -> que lea los campos de la tabla y en función de si es Null o no, vaya cambiando estar de compra
            /*if (txtEnPreparacion.Text != null && txtEnPreparacion.Text != "")
                estadoEnvio = 'P';
            else if (txtEnviado.Text != null && txtEnviado.Text != "")
                estadoEnvio = 'E';
            else if (txtEntregado.Text != null && txtEntregado.Text != "")
                estadoEnvio = 'C';
            */
            EstadoCompra estadoCompra = new EstadoCompra();
            //estadoCompra.IdVenta = venta.IDVenta;
            estadoCompra.IdVenta = int.Parse(Session["idVenta"].ToString());
            if (txtEnPreparacion.Text != "")
                estadoCompra.CodCompra = txtEnPreparacion.Text;
            if (txtEnviado.Text != "")
                estadoCompra.Envio = DateTime.Parse(txtEnviado.Text);
            else
                estadoCompra.Envio = null;
            /*
            else
            {
                estadoCompra.Envio = (DateTime?) null;
            }
            */
            if (txtEntregado.Text != "")
                estadoCompra.Entrega = DateTime.Parse(txtEntregado.Text);
            else
                estadoCompra.Entrega = null;
            
            VentaNegocio ventaNegocio = new VentaNegocio();
            ventaNegocio.cargaEstadoCompra(estadoCompra);
            ventaNegocio.cambiaEstadoCompra(int.Parse(Session["idVenta"].ToString()));

            //VentaNegocio negocio = new VentaNegocio();
            //negocio.ModificaEstadoEnvio(int.Parse(Session["idVenta"].ToString()), estadoEnvio);
            Response.Redirect("AdminCompras.aspx");
        }
    }
}