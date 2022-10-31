using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> listar()
        {
            List<Venta> lista = new List<Venta>();
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