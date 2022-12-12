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
        public DateTime Envio { get; set; }
        public DateTime Entrega { get; set; }

    }
}