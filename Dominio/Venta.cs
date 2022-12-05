using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Venta
    {
        public int IDVenta { get; set; }
        public int IDUsuario { get; set; }
        public char FormaPago { get; set; }
        public bool Envio { get; set; }
        public decimal Importe { get; set; }
        public int Cantidad { get; set; }
        public Direccion DomicilioEntrega { get; set; }
        public DateTime Fecha { get; set; }
        public char Estado { get; set; }
    }
}