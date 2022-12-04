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
            lista[0].Envio = true;
            lista[0].PrecioTot = 9999;
            lista[0].CantTot = 12;
            lista[0].DomicilioEntrega = new Direccion();
            lista[0].DomicilioEntrega.Calle = "Calle Falsa";
            lista[0].DomicilioEntrega.Numero = "123";
            lista[0].Fecha = new DateTime(2022, 10, 31);
            lista[0].Estado = 'E';


            return lista;
        }

        public void Agregar(Venta nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("");

                datos.setearParametro("@IDUsuario", nueva.IDUsuario);
                datos.setearParametro("@FormaPago", nueva.FormaPago);
                datos.setearParametro("@MetodoEnvio", nueva.Envio);
                datos.setearParametro("@PrecioTot", nueva.PrecioTot);
                datos.setearParametro("@CantTot", nueva.CantTot);
                datos.setearParametro("@Calle", nueva.DomicilioEntrega.Calle);
                datos.setearParametro("@Numero", nueva.DomicilioEntrega.Numero);
                datos.setearParametro("@Piso", nueva.DomicilioEntrega.Piso);
                datos.setearParametro("@Depto", nueva.DomicilioEntrega.Depto);
                datos.setearParametro("@CodPostal", nueva.DomicilioEntrega.CodPostal);
                datos.setearParametro("@Localidad", nueva.DomicilioEntrega.Localidad);
                datos.setearParametro("@Provincia", nueva.DomicilioEntrega.Provincia);
                //datos.setearParametro("@Fecha", nueva.Fecha); -- fecha y hora de sistema
                //datos.setearParametro("@Estado", nueva.Estado); -- siempre la seteamos en 'R' de Recepcionada

                datos.ejecutarAccion(); 

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}