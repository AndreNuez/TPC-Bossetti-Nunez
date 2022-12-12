using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class EstadoCompra
    {
        public int IdVenta { get; set; }
        public string CodCompra { get; set; }
        public DateTime Envio2 { get; set; }
        public DateTime Entrega2 { get; set; }
        public Nullable<System.DateTime> Envio { get; set; }
        public Nullable<System.DateTime> Entrega { get; set; }

    }
}