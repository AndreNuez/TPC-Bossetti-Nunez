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
        public bool Direccion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["usuario"];        

            if (rdbDomicilio.Checked)
            {
                Direccion = true;

                if (!string.IsNullOrEmpty(usuario.Cliente.Direccion.Calle))
                {
                    lblCalle.Text = usuario.Cliente.Direccion.Calle.ToString();
                    lblNumero.Text = usuario.Cliente.Direccion.Numero.ToString();

                    if (!string.IsNullOrEmpty(usuario.Cliente.Direccion.Piso))
                        lblPiso.Text = usuario.Cliente.Direccion.Piso.ToString();
                    
                    if (!string.IsNullOrEmpty(usuario.Cliente.Direccion.Depto))
                        lblDepto.Text = usuario.Cliente.Direccion.Depto.ToString();

                    lblLocalidad.Text = usuario.Cliente.Direccion.Localidad.ToString();
                    lblProvincia.Text = "  " + usuario.Cliente.Direccion.Provincia.ToString();
                    lblCP.Text = "CP " + usuario.Cliente.Direccion.CodPostal.ToString();
                }
                else
                {
                    Direccion = false;
                }
            }

        }

        protected void btnConfirmaCompra_Click(object sender, EventArgs e)
        {
            try
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
                    nueva.Envio = false;
                else
                    nueva.Envio = true;

                nueva.Importe = (decimal)Session["TotalCarrito"];
                nueva.Cantidad = (int)Session["CantidadCarrito"];

                nueva.DomicilioEntrega = new Direccion();
                nueva.DomicilioEntrega.Calle = usuario.Cliente.Direccion.Calle;
                nueva.DomicilioEntrega.Numero = usuario.Cliente.Direccion.Numero;
                nueva.DomicilioEntrega.Piso = usuario.Cliente.Direccion.Piso;
                nueva.DomicilioEntrega.Depto = usuario.Cliente.Direccion.Depto;
                nueva.DomicilioEntrega.CodPostal = usuario.Cliente.Direccion.CodPostal;
                nueva.DomicilioEntrega.Localidad = usuario.Cliente.Direccion.Localidad;
                nueva.DomicilioEntrega.Provincia = usuario.Cliente.Direccion.Provincia;

                List<ItemCarrito> ListaCarrito = (List<ItemCarrito>)Session["ListaCarrito"];
                string check = ChequearStock(ListaCarrito);
                
                //Chequeamos stock ANTES de generar Venta
                if (check != "ok")
                {
                    Session.Add("Error", "No contamos con la cantidad seleccionada de " + check +". Por favor, modifique la cantidad.");
                    Response.Redirect("Error.aspx", false);
                }
                else
                {
                    //Si check está en ok, agregamos Venta y procedemos a registrar items y restar stock
                    
                    int IDVenta = negocio.Agregar(nueva);

                    ItemCarrito itemc = new ItemCarrito();
                    ItemCarritoNegocio nuevoi = new ItemCarritoNegocio();

                    foreach (ItemCarrito item in ListaCarrito)
                    {
                        itemc.IDItem = item.IDItem;
                        itemc.NombreItem = item.NombreItem;
                        itemc.Cantidad = item.Cantidad;
                        itemc.Precio = item.Precio;
                        itemc.IDVenta = IDVenta;

                        nuevoi.Agregar(itemc);
                        nuevoi.RestarStock(itemc);
                    }

                    //Se crea registro para tabla EstadoVenta con IdVenta
                    negocio.creaRegistroEstadoCompra(IDVenta);

                    Session.Add("IDVenta", IDVenta);
                    Session.Remove("CantidadCarrito");

                    //Envio de mail
                    EmailService emailService = new EmailService();
                    emailService.ArmarCorreo(usuario.Mail, "Confirmación de pedido", "Gracias por comprar en TuLibro.com. Podrás ver todos los detalles de tu pedido desde el menú Mis Pedidos.");
                    emailService.EnviarEmail();

                    Response.Redirect("CompraRealizada.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected string ChequearStock(List<ItemCarrito> ListaCarrito)
        {
            List<Libro> ListaLibro = (List<Libro>)Session["ListaLibro"];
            Libro Libro = new Libro();
            
            foreach (ItemCarrito item in ListaCarrito)
            {
                Libro = ListaLibro.Find(x => x.ID == item.IDItem);

                if(Libro.Stock < item.Cantidad)
                {
                    return item.NombreItem;
                }
            }

            return "ok";
        }

    }
}