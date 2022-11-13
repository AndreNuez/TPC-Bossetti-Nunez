using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Depto { get; set; }
        public string CodPostal { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
    }
}