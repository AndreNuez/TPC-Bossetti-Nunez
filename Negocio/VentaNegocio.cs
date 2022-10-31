using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> listar()
        {
            List<Venta> lista = new List<Venta>();
            /*AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("--Consulta SQL");
                datos.ejecutarLectura();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }*/

            //MockUp
            lista.Add(new Venta());
            lista.Add(new Venta());
            lista[0].IDVenta = 1;
            //lista[0].Carrito.IDCarrito = 111;
            //lista[0].Carrito.IDCliente = 112233;
            //lista[0].Carrito.Items.ID = 456;
            //lista[0].Carrito.Items.Titulo = "Título libro";
            //lista[0].Carrito.Items.Descripcion = "Lorem Impsum";
            //lista[0].Carrito.Items.Autor = "Autor";
            //lista[0].Carrito.Items.Editorial = "Editorial";
            //lista[0].Carrito.Items.Genero.IDGenero = 1;
            //lista[0].Carrito.Items.Genero.Descripcion = "Ciencia Ficción";
            //lista[0].Carrito.Items.Precio = 9999;
            //lista[0].Carrito.Items.Stock = 3;
            //lista[0].Carrito.Items.PortadaURL = "www.esnecesarioaca?.com";
            //lista[0].Carrito.Cantidad = 555;
            //lista[0].Carrito.PrecioTotal = 999999;
            lista[0].FormaPago = 'E';
            lista[0].Fecha = new DateTime (2022,10,31);
            lista[0].Estado = "Enviado";


            lista[1].IDVenta = 2;
            //lista[1].Carrito.IDCarrito = 111;
            //lista[1].Carrito.IDCliente = 112233;
            //lista[1].Carrito.Items.ID = 456;
            //lista[1].Carrito.Items.Titulo = "Título libro";
            //lista[1].Carrito.Items.Descripcion = "Lorem Impsum";
            //lista[1].Carrito.Items.Autor = "Autor";
            //lista[1].Carrito.Items.Editorial = "Editorial";
            //lista[1].Carrito.Items.Genero.IDGenero = 1;
            //lista[1].Carrito.Items.Genero.Descripcion = "Ciencia Ficción";
            //lista[1].Carrito.Items.Precio = 9999;
            //lista[1].Carrito.Items.Stock = 3;
            //lista[1].Carrito.Items.PortadaURL = "www.esnecesarioaca?.com";
            //lista[1].Carrito.Cantidad = 555;
            //lista[1].Carrito.PrecioTotal = 999999;
            lista[1].FormaPago = 'E';
            lista[1].Fecha = new DateTime(2022, 10, 31);
            lista[1].Estado = "Enviado";
            return lista;
        }
    }
}