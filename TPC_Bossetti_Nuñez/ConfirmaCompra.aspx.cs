﻿using System;
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

            if (rdbDomicilio.Checked)
            {
                lblCalle.Text = usuario.Cliente.Direccion.Calle.ToString();
                lblCP.Text = usuario.Cliente.Direccion.CodPostal.ToString();
                lblLocalidad.Text = usuario.Cliente.Direccion.Localidad.ToString();
                lblProvincia.Text = usuario.Cliente.Direccion.Provincia.ToString();

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

                int IDVenta = negocio.Agregar(nueva);

                ItemCarrito itemc = new ItemCarrito();
                ItemCarritoNegocio nuevoi = new ItemCarritoNegocio();
                List<ItemCarrito> ListaCarrito = (List<ItemCarrito>)Session["ListaCarrito"];

                foreach (ItemCarrito item in ListaCarrito)
                {
                    itemc.IDItem = item.IDItem;
                    itemc.NombreItem = item.NombreItem;
                    itemc.Cantidad = item.Cantidad;
                    itemc.Precio = item.Precio;
                    itemc.IDVenta = IDVenta;

                    nuevoi.Agregar(itemc);
                }

                Session.Add("IDVenta", IDVenta);
                Session.Remove("CantidadCarrito");

                Response.Redirect("CompraRealizada.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
                throw;
            }
           
        }
    }
}