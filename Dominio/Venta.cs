using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Venta
    {
        public int IDVenta { get; set; }
        //public int IDCarrito { get; set; }
        public Carrito CarritoVenta { get; set; }
        public char FormaPago { get; set; }
        public Direccion DomicilioEntrega { get; set; }
        public string Estado { get; set; }
    }
}