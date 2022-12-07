using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> ListarVentasCliente(int idUsuario)
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_listarVentas");
                datos.setearParametro("@idUsuario", (decimal)idUsuario);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Venta venta = new Venta();
                    venta.IDUsuario = idUsuario;
                    venta.IDVenta = (int)datos.Lector["idventa"];
                    venta.FormaPago = char.Parse(datos.Lector["formaPago"].ToString());
                    venta.Envio = (bool)datos.Lector["envio"];
                    venta.Importe = (decimal)datos.Lector["importe"];
                    venta.Cantidad = (int)datos.Lector["cantidad"];
                    venta.Fecha = (DateTime)datos.Lector["fecha"];
                    venta.Estado = char.Parse(datos.Lector["estado"].ToString());
                    venta.DomicilioEntrega = new Direccion();
                    if(!(datos.Lector["calle"] is DBNull))
                        venta.DomicilioEntrega.Calle = (string)datos.Lector["calle"];
                    if(!(datos.Lector["numero"] is DBNull))
                        venta.DomicilioEntrega.Numero = (string)datos.Lector["numero"];
                    if(!(datos.Lector["piso"] is DBNull))
                        venta.DomicilioEntrega.Piso = (string)datos.Lector["piso"];
                    if(!(datos.Lector["depto"] is DBNull))
                        venta.DomicilioEntrega.Depto = (string)datos.Lector["depto"];
                    if(!(datos.Lector["codPostal"] is DBNull))    
                        venta.DomicilioEntrega.CodPostal = (string)datos.Lector["codPostal"];
                    if(!(datos.Lector["localidad"] is DBNull))
                        venta.DomicilioEntrega.Localidad = (string)datos.Lector["localidad"];
                    if(!(datos.Lector["provincia"] is DBNull))
                        venta.DomicilioEntrega.Provincia = (string)datos.Lector["provincia"];

                    lista.Add(venta);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }



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

        public void seleccionaVenta (Venta venta)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_seleccionarVenta");
                datos.setearParametro("@idVenta", venta.IDVenta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    venta.FormaPago = char.Parse(datos.Lector["formaPago"].ToString());
                    venta.Envio = (bool)datos.Lector["envio"];
                    venta.Importe = (decimal)datos.Lector["importe"];
                    venta.Cantidad = (int)datos.Lector["cantidad"];
                    venta.Fecha = (DateTime)datos.Lector["fecha"];
                    venta.Estado = char.Parse(datos.Lector["estado"].ToString());
                    venta.DomicilioEntrega = new Direccion();
                    if (!(datos.Lector["calle"] is DBNull))
                        venta.DomicilioEntrega.Calle = (string)datos.Lector["calle"];
                    if (!(datos.Lector["numero"] is DBNull))
                        venta.DomicilioEntrega.Numero = (string)datos.Lector["numero"];
                    if (!(datos.Lector["piso"] is DBNull))
                        venta.DomicilioEntrega.Piso = (string)datos.Lector["piso"];
                    if (!(datos.Lector["depto"] is DBNull))
                        venta.DomicilioEntrega.Depto = (string)datos.Lector["depto"];
                    if (!(datos.Lector["codPostal"] is DBNull))
                        venta.DomicilioEntrega.CodPostal = (string)datos.Lector["codPostal"];
                    if (!(datos.Lector["localidad"] is DBNull))
                        venta.DomicilioEntrega.Localidad = (string)datos.Lector["localidad"];
                    if (!(datos.Lector["provincia"] is DBNull))
                        venta.DomicilioEntrega.Provincia = (string)datos.Lector["provincia"];
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_listarVentas");
                datos.setearParametro("@idUsuario", DBNull.Value);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Venta venta = new Venta();
                    //venta.IDUsuario = idUsuario;
                    venta.IDVenta = (int)datos.Lector["idventa"];
                    //venta.FormaPago = (char)datos.Lector["formaPago"];
                    //venta.FormaPago = (string)datos.Lector["formaPago"];
                    venta.FormaPago = char.Parse(datos.Lector["formaPago"].ToString());
                    venta.Envio = (bool)datos.Lector["envio"];
                    venta.Importe = (decimal)datos.Lector["importe"];
                    venta.Cantidad = (int)datos.Lector["cantidad"];
                    venta.Fecha = (DateTime)datos.Lector["fecha"];
                    //venta.Estado = (char)datos.Lector["estado"];
                    //venta.Estado = (string)datos.Lector["estado"];
                    venta.Estado = char.Parse(datos.Lector["estado"].ToString());
                    venta.DomicilioEntrega = new Direccion();
                    if (!(datos.Lector["calle"] is DBNull))
                        venta.DomicilioEntrega.Calle = (string)datos.Lector["calle"];
                    if (!(datos.Lector["numero"] is DBNull))
                        venta.DomicilioEntrega.Numero = (string)datos.Lector["numero"];
                    if (!(datos.Lector["piso"] is DBNull))
                        venta.DomicilioEntrega.Piso = (string)datos.Lector["piso"];
                    if (!(datos.Lector["depto"] is DBNull))
                        venta.DomicilioEntrega.Depto = (string)datos.Lector["depto"];
                    if (!(datos.Lector["codPostal"] is DBNull))
                        venta.DomicilioEntrega.CodPostal = (string)datos.Lector["codPostal"];
                    if (!(datos.Lector["localidad"] is DBNull))
                        venta.DomicilioEntrega.Localidad = (string)datos.Lector["localidad"];
                    if (!(datos.Lector["provincia"] is DBNull))
                        venta.DomicilioEntrega.Provincia = (string)datos.Lector["provincia"];

                    lista.Add(venta);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void ModificaEstadoEnvio(int idVenta, char estadoEnvio)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_modificaEstadoEnvio");
                datos.setearParametro("@estadoEnvio", estadoEnvio);
                datos.setearParametro("@idVenta", idVenta);

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

        
        public char ConsultaEstadoEnvio(int idVenta)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_consultaEstadoEnvio");
                datos.setearParametro("@idVenta", idVenta);
                datos.ejecutarLectura();
                
                char estadoEntrega = 'R';
                
                while (datos.Lector.Read())
                {
                    estadoEntrega = (char)datos.Lector["estado"];
                }

            return estadoEntrega;
            }

            catch (Exception)
            {

                throw;
            }
            
        }
    
    
    
    }





}