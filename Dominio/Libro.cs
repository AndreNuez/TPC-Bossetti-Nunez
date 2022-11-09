using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public Generos Genero { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string PortadaURL { get; set; }
        public bool Estado { get; set; }
    }
}