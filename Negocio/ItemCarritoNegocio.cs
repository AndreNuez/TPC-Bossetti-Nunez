using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class ItemCarritoNegocio
    {
        public void Agregar(ItemCarrito nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_AltaItemCarrito");

                datos.setearParametro("@IDItem", nuevo.IDItem);
                datos.setearParametro("@NombreItem", nuevo.NombreItem);
                datos.setearParametro("@Cantidad", nuevo.Cantidad);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IDVenta", nuevo.IDVenta);

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