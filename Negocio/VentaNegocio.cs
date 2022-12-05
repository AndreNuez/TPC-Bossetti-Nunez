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
            lista[0].Importe = 9999;
            lista[0].Cantidad = 12;
            lista[0].DomicilioEntrega = new Direccion();
            lista[0].DomicilioEntrega.Calle = "Calle Falsa";
            lista[0].DomicilioEntrega.Numero = "123";
            lista[0].Fecha = new DateTime(2022, 10, 31);
            lista[0].Estado = 'E';


            return lista;
        }

        public int Agregar(Venta nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_AltaVenta");

                datos.setearParametro("@IDUsuario", nueva.IDUsuario);
                datos.setearParametro("@FormaPago", nueva.FormaPago);
                datos.setearParametro("@Envio", nueva.Envio);
                datos.setearParametro("@Importe", nueva.Importe);
                datos.setearParametro("@Cantidad", nueva.Cantidad);
                datos.setearParametro("@Calle", (object)nueva.DomicilioEntrega.Calle ?? DBNull.Value);
                datos.setearParametro("@Numero", (object)nueva.DomicilioEntrega.Numero ?? DBNull.Value);
                datos.setearParametro("@Piso", (object)nueva.DomicilioEntrega.Piso ?? DBNull.Value);
                datos.setearParametro("@Depto", (object)nueva.DomicilioEntrega.Depto ?? DBNull.Value);
                datos.setearParametro("@CodPostal", (object)nueva.DomicilioEntrega.CodPostal ?? DBNull.Value);
                datos.setearParametro("@Localidad", (object)nueva.DomicilioEntrega.Localidad ?? DBNull.Value);
                datos.setearParametro("@Provincia", (object)nueva.DomicilioEntrega.Provincia ?? DBNull.Value);
                //datos.setearParametro("@Fecha", nueva.Fecha); -- fecha y hora de sistema
                //datos.setearParametro("@Estado", nueva.Estado); -- siempre la seteamos en 'R' de Recepcionada

                return datos.ejecutarAccionScalar(); 

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