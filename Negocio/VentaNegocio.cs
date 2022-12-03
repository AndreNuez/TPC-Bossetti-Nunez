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
            /*AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("--Consulta SQL");
                datos.ejecutarLectura();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }*/

            //MockUp
            lista.Add(new Venta());
            lista.Add(new Venta());
            lista[0].IDVenta = 1;
            lista[0].IDUsuario = 112233;
            lista[0].FormaPago = 'E';
            lista[0].MetodoEnvio = 'M';
            lista[0].PrecioTot = 9999;
            lista[0].CantTot = 12;
            lista[0].DomicilioEntrega = new Direccion();
            lista[0].DomicilioEntrega.Calle = "Calle Falsa";
            lista[0].DomicilioEntrega.Numero = "123";
            lista[0].Fecha = new DateTime (2022,10,31);
            lista[0].Estado = "Enviado";

            
            return lista;
        }
    }
}