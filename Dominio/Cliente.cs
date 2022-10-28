﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Cliente : Usuario
    {
        public int IDCliente { get; set; }
        public int DNI { get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
    }
}