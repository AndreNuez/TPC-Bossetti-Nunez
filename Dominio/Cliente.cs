using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Cliente
    {
        public string DNI { get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime FNac { get; set; }
    }


}