using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Carrito
    {
        public int IDCarrito { get; set; }
        public int IDCliente { get; set; }
        public Libro Items { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}