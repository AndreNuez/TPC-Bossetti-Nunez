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

        public List<ItemCarrito> Listar(int idVenta)
        {
            List<ItemCarrito> lista = new List<ItemCarrito>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_listarItems");
                datos.setearParametro("@idVenta", idVenta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ItemCarrito item = new ItemCarrito();
                    item.IDVenta = idVenta;
                    item.IDItem = (short)datos.Lector["IdItem"];
                    item.NombreItem = (string)datos.Lector["NombreItem"];
                    item.Cantidad = (int)datos.Lector["Cantidad"];
                    item.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(item);
                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void RestarStock(ItemCarrito item)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_restarStock");

                datos.setearParametro("@idItem", item.IDItem);
                datos.setearParametro("@cantidad", item.Cantidad);
                
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}