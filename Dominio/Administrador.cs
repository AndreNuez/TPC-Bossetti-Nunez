using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Administrador : Usuario 
    {
        public int IDAdministrador { get; set; }

        public Administrador (string mail, string pass):base(mail, pass)
        {

        }
    }

}