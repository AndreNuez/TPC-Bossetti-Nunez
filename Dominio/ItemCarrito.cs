using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class ItemCarrito
    {
        public int IDItem { get; set; }
        public string NombreItem { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IDVenta { get; set; }
    }
}