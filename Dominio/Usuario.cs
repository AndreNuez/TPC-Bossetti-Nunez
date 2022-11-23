using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public Cliente cliente { get; set; }

        public Usuario (string mail, string pass)
        {
            Mail = mail;
            Contraseña = pass;
        }
    }
}