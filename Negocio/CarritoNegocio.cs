using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class CarritoNegocio
    {
        public List<Carrito> listar()
        {
            List<Carrito> lista = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("--Consulta SQL");
                datos.ejecutarLectura();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
             
        }

    }
}