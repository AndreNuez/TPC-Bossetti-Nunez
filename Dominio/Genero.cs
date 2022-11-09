using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Generos
    {
        public int IdGenero { get; set; }
        public string Descripcion { get; set; }
        
        public override string ToString()
        {
            return Descripcion;
        }
    }
}