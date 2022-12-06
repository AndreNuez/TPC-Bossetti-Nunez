using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_login");
                datos.setearParametro("@mail", usuario.Mail);
                datos.setearParametro("@pass", usuario.Contraseña);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    usuario.IDUsuario = (short)datos.Lector["IdUsuario"];
                    usuario.TipoUsuario = (short)(datos.Lector["TipoUsuario"]) == 1 ? TipoUsuario.CLIENTE : TipoUsuario.ADMIN;
                    usuario.Apellidos = (string)datos.Lector["Apellidos"];
                    usuario.Nombres = (string)datos.Lector["Nombres"];
                    usuario.Estado = (bool)datos.Lector["Estado"];
                    usuario.Cliente = new Cliente();
                    usuario.Cliente.Direccion = new Direccion();

                    if (!(datos.Lector["DNI"] is DBNull))
                        usuario.Cliente.DNI = (string)datos.Lector["DNI"];

                    if (!(datos.Lector["Telefono"] is DBNull))
                        usuario.Cliente.Telefono = (string)datos.Lector["Telefono"];

                    if (!(datos.Lector["Celular"] is DBNull))
                        usuario.Cliente.Celular = (string)datos.Lector["Celular"];

                    if (!(datos.Lector["Calle"] is DBNull))
                        usuario.Cliente.Direccion.Calle = (string)datos.Lector["Calle"];

                    if (!(datos.Lector["Numero"] is DBNull))
                        usuario.Cliente.Direccion.Numero = (string)datos.Lector["Numero"];

                    if (!(datos.Lector["Piso"] is DBNull))
                        usuario.Cliente.Direccion.Piso = (string)datos.Lector["Piso"];

                    if (!(datos.Lector["Departamento"] is DBNull))
                        usuario.Cliente.Direccion.Depto = (string)datos.Lector["Departamento"];

                    if (!(datos.Lector["CP"] is DBNull))
                        usuario.Cliente.Direccion.CodPostal = (string)datos.Lector["CP"];

                    if (!(datos.Lector["Localidad"] is DBNull))
                        usuario.Cliente.Direccion.Localidad = (string)datos.Lector["Localidad"];

                    if (!(datos.Lector["Provincia"] is DBNull))
                        usuario.Cliente.Direccion.Provincia = (string)datos.Lector["Provincia"];


                    return true;
                }
                return false;
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

        public bool seleccionarClienteConSP(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_buscarPorID");
                datos.setearParametro("@idUsuario", usuario.IDUsuario);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    usuario.Estado = (bool)datos.Lector["Estado"];
                    usuario.Cliente = new Cliente();
                    usuario.Cliente.DNI = (string)datos.Lector["DNI"];
                    usuario.Cliente.Telefono = (string)datos.Lector["Telefono"];
                    usuario.Cliente.Celular = (string)datos.Lector["Celular"];
                    usuario.Cliente.Direccion = new Direccion();
                    usuario.Cliente.Direccion.Calle = (string)datos.Lector["Calle"];
                    usuario.Cliente.Direccion.Numero = (string)datos.Lector["Numero"];
                    usuario.Cliente.Direccion.Piso = (string)datos.Lector["Piso"];
                    usuario.Cliente.Direccion.Depto = (string)datos.Lector["Departamento"];
                    usuario.Cliente.Direccion.CodPostal = (string)datos.Lector["CP"];
                    usuario.Cliente.Direccion.Localidad = (string)datos.Lector["Localidad"];
                    usuario.Cliente.Direccion.Provincia = (string)datos.Lector["Provincia"];

                    return true;
                }
                return false;
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
        /*public void Agregar(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_altaCliente");

                datos.setearParametro("@mail", nuevo.Mail);
                datos.setearParametro("@contraseña", nuevo.Contraseña);
                datos.setearParametro("@nombres", nuevo.Nombres);
                datos.setearParametro("@apellidos", nuevo.Apellidos);
                datos.setearParametro("@DNI", nuevo.Cliente.DNI);
                datos.setearParametro("@telefono", nuevo.Cliente.Telefono);
                datos.setearParametro("@celular", nuevo.Cliente.Celular);
                datos.setearParametro("@calle", nuevo.Cliente.Direccion.Calle);
                datos.setearParametro("@numero", nuevo.Cliente.Direccion.Numero);
                datos.setearParametro("@piso", nuevo.Cliente.Direccion.Piso);
                datos.setearParametro("@departamento", nuevo.Cliente.Direccion.Depto);
                datos.setearParametro("@CP", nuevo.Cliente.Direccion.CodPostal);
                datos.setearParametro("@localidad", nuevo.Cliente.Direccion.Localidad);
                datos.setearParametro("@provincia", nuevo.Cliente.Direccion.Provincia);

                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        public int insertarNuevo(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_insertarNuevo");
                datos.setearParametro("@Apellidos", nuevo.Apellidos);
                datos.setearParametro("@Nombres", nuevo.Nombres);
                datos.setearParametro("@Mail", nuevo.Mail);
                datos.setearParametro("@Contraseña", nuevo.Contraseña);
                datos.setearParametro("@TipoUsuario", nuevo.TipoUsuario);
                return datos.ejecutarAccionScalar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }

        public List<Usuario> listarClientesConSP()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_listarClientes");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IDUsuario = (short)datos.Lector["IdUsuario"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Nombres = (string)datos.Lector["Nombres"];
                    aux.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.Estado = (bool)datos.Lector["Estado"];
                    aux.Cliente = new Cliente();
                    aux.Cliente.Direccion = new Direccion();

                    if (!(datos.Lector["DNI"] is DBNull))
                        aux.Cliente.DNI = (string)datos.Lector["DNI"];

                    if (!(datos.Lector["Telefono"] is DBNull))
                        aux.Cliente.Telefono = (string)datos.Lector["Telefono"];
                    
                    if (!(datos.Lector["Celular"] is DBNull))
                        aux.Cliente.Celular = (string)datos.Lector["Celular"];

                    aux.Cliente.Direccion = new Direccion();
                    if (!(datos.Lector["Calle"] is DBNull))
                        aux.Cliente.Direccion.Calle = (string)datos.Lector["Calle"];

                    if (!(datos.Lector["Numero"] is DBNull))
                        aux.Cliente.Direccion.Numero = (string)datos.Lector["Numero"];

                    if (!(datos.Lector["Piso"] is DBNull))
                        aux.Cliente.Direccion.Piso = (string)datos.Lector["Piso"];

                    if (!(datos.Lector["Departamento"] is DBNull))
                        aux.Cliente.Direccion.Depto = (string)datos.Lector["Departamento"];

                    if (!(datos.Lector["CP"] is DBNull))
                        aux.Cliente.Direccion.CodPostal = (string)datos.Lector["CP"];

                    if (!(datos.Lector["Localidad"] is DBNull))
                        aux.Cliente.Direccion.Localidad = (string)datos.Lector["Localidad"];

                    if (!(datos.Lector["Provincia"] is DBNull))
                        aux.Cliente.Direccion.Provincia = (string)datos.Lector["Provincia"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario> listar(string idUsuario = "")
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select u.IdUsuario, u.Mail, u.Contraseña, u.Nombres, u.Apellidos, u.Estado, du.DNI, du.Telefono, du.Celular, du.Calle, du.Numero, du.Piso, du.Departamento, du.CP, du.Localidad, du.Provincia from usuarios u left join datos_usuario du on u.IdUsuario = du.IdUsuario ";

                if (idUsuario != "")
                    consulta = consulta += "where u.IdUsuario =" + idUsuario;

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IDUsuario = (short)datos.Lector["IdUsuario"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Contraseña = (string)datos.Lector["Contraseña"];
                    aux.Nombres = (string)datos.Lector["Nombres"];
                    aux.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.Estado = (bool)datos.Lector["Estado"];
                   
                    aux.Cliente = new Cliente();
                    
                    if (!(datos.Lector["DNI"] is DBNull))
                        aux.Cliente.DNI = (string)datos.Lector["DNI"];

                    if (!(datos.Lector["Telefono"] is DBNull))
                        aux.Cliente.Telefono = (string)datos.Lector["Telefono"];

                    if (!(datos.Lector["Celular"] is DBNull))
                        aux.Cliente.Celular = (string)datos.Lector["Celular"];

                    aux.Cliente.Direccion = new Direccion();
                    
                    if (!(datos.Lector["Calle"] is DBNull))
                        aux.Cliente.Direccion.Calle = (string)datos.Lector["Calle"];

                    if (!(datos.Lector["Numero"] is DBNull))
                        aux.Cliente.Direccion.Numero = (string)datos.Lector["Numero"];

                    if (!(datos.Lector["Piso"] is DBNull))
                        aux.Cliente.Direccion.Piso = (string)datos.Lector["Piso"];

                    if (!(datos.Lector["Departamento"] is DBNull))
                        aux.Cliente.Direccion.Depto = (string)datos.Lector["Departamento"];

                    if (!(datos.Lector["CP"] is DBNull))
                        aux.Cliente.Direccion.CodPostal = (string)datos.Lector["CP"];

                    if (!(datos.Lector["Localidad"] is DBNull))
                        aux.Cliente.Direccion.Localidad = (string)datos.Lector["Localidad"];

                    if (!(datos.Lector["Provincia"] is DBNull))
                        aux.Cliente.Direccion.Provincia = (string)datos.Lector["Provincia"];

                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminarLogico(int idUsuario, bool activo = false)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Usuarios set Estado = @activo where IdUsuario = @idUsuario");
                datos.setearParametro("@idUsuario", idUsuario);
                datos.setearParametro("@activo", activo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminarLogicoConSP(int idUsuario, bool activo = false)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("sp_UsuarioEliminarLogico");
                datos.setearParametro("@IdUsuario", idUsuario);
                datos.setearParametro("@activo", activo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public void eliminarFisicoConSP(short idUsuario)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearProcedimiento("sp_UsuarioEliminarFisico");
                datos.setearParametro("@idUsuario", idUsuario);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarFisicoClienteConSP(int idusuario)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearProcedimiento("sp_ClienteEliminarFisico");
                datos.setearParametro("@idUsuario", idusuario);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void modificarConSP(Usuario aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_modificarCliente");
                datos.setearParametro("@idUsuario", aux.IDUsuario);
                datos.setearParametro("@contraseña", aux.Contraseña);
                datos.setearParametro("@nombres", aux.Nombres);
                datos.setearParametro("@apellidos", aux.Apellidos);
                datos.setearParametro("@estado", aux.Estado);
                // //datos.setearParametro("@dni", aux.Cliente.DNI != null ? aux.Cliente.DNI : (object)DBNull.Value);
                datos.setearParametro("@dni", (object)aux.Cliente.DNI ?? DBNull.Value);
                datos.setearParametro("@telefono", (object)aux.Cliente.Telefono ?? DBNull.Value);
                datos.setearParametro("@celular", (object)aux.Cliente.Celular ?? DBNull.Value);
                datos.setearParametro("@calle", (object)aux.Cliente.Direccion.Calle ?? DBNull.Value);
                datos.setearParametro("@numero", (object)aux.Cliente.Direccion.Numero ?? DBNull.Value);
                datos.setearParametro("@piso", (object)aux.Cliente.Direccion.Piso ?? DBNull.Value);
                datos.setearParametro("@departamento", (object)aux.Cliente.Direccion.Depto ?? DBNull.Value);
                datos.setearParametro("@cp", (object)aux.Cliente.Direccion.CodPostal ?? DBNull.Value);
                datos.setearParametro("@localidad", (object)aux.Cliente.Direccion.Localidad ?? DBNull.Value);
                datos.setearParametro("@provincia", (object)aux.Cliente.Direccion.Provincia ?? DBNull.Value);

                // //datos.setearParametro("@dni", aux.Cliente.DNI != null ? aux.Cliente.DNI : (object)DBNull.Value);
                //datos.setearParametro("@dni", aux.Cliente.DNI);
                //datos.setearParametro("@telefono", aux.Cliente.Telefono);
                //datos.setearParametro("@celular", aux.Cliente.Celular);
                //datos.setearParametro("@calle", aux.Cliente.Direccion.Calle);
                //datos.setearParametro("@numero", aux.Cliente.Direccion.Numero);
                //datos.setearParametro("@piso", aux.Cliente.Direccion.Piso);
                //datos.setearParametro("@departamento", aux.Cliente.Direccion.Depto);
                //datos.setearParametro("@cp", aux.Cliente.Direccion.CodPostal);
                //datos.setearParametro("@localidad", aux.Cliente.Direccion.Localidad);
                //datos.setearParametro("@provincia", aux.Cliente.Direccion.Provincia);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}