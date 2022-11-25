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
                while (datos.Lector.Read())
                {
                    usuario.IDUsuario = (int)datos.Lector["IdUsuario"];
                    usuario.TipoUsuario = (int)(datos.Lector["TipoUsuario"]) == 1 ? TipoUsuario.CLIENTE : TipoUsuario.ADMIN;
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
                datos.setearProcedimiento("insertarNuevo");
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

        public List<Usuario> listarConSP()
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
                    aux.IDUsuario = (short)datos.Lector["IdCliente"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Contraseña = (string)datos.Lector["Contraseña"];
                    aux.Nombres = (string)datos.Lector["Nombres"];
                    aux.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.Cliente.DNI = (string)datos.Lector["DNI"];
                    aux.Cliente.Telefono = (string)datos.Lector["Telefono"];
                    aux.Cliente.Celular = (string)datos.Lector["Celular"];
                    aux.Cliente.Direccion = new Direccion();
                    aux.Cliente.Direccion.Calle = (string)datos.Lector["Calle"];
                    aux.Cliente.Direccion.Numero = (string)datos.Lector["Numero"];
                    aux.Cliente.Direccion.Piso = (string)datos.Lector["Piso"];
                    aux.Cliente.Direccion.Depto = (string)datos.Lector["Departamento"];
                    aux.Cliente.Direccion.CodPostal = (string)datos.Lector["CP"];
                    aux.Cliente.Direccion.Localidad = (string)datos.Lector["Localidad"];
                    aux.Cliente.Direccion.Provincia = (string)datos.Lector["Provincia"];
                    aux.Cliente.Estado = (bool)datos.Lector["Estado"];

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
                string consulta = "select c.IdCliente,c.mail,c.Contraseña,c.Nombres,c.Apellidos,c.Dni,c.Telefono,c.Celular,c.Calle,c.Numero,c.Piso,c.Departamento,c.CP,c.Localidad,c.Provincia,c.estado from clientes c ";

                if (idUsuario != "")
                    consulta = consulta += "where c.IdCliente =" + idUsuario;

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IDUsuario = (short)datos.Lector["IdCliente"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Contraseña = (string)datos.Lector["Contraseña"];
                    aux.Nombres = (string)datos.Lector["Nombres"];
                    aux.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.Cliente.DNI = (string)datos.Lector["DNI"];
                    aux.Cliente.Telefono = (string)datos.Lector["Telefono"];
                    aux.Cliente.Celular = (string)datos.Lector["Celular"];
                    aux.Cliente.Direccion = new Direccion();
                    aux.Cliente.Direccion.Calle = (string)datos.Lector["Calle"];
                    aux.Cliente.Direccion.Numero = (string)datos.Lector["Numero"];
                    aux.Cliente.Direccion.Piso = (string)datos.Lector["Piso"];
                    aux.Cliente.Direccion.Depto = (string)datos.Lector["Departamento"];
                    aux.Cliente.Direccion.CodPostal = (string)datos.Lector["CP"];
                    aux.Cliente.Direccion.Localidad = (string)datos.Lector["Localidad"];
                    aux.Cliente.Direccion.Provincia = (string)datos.Lector["Provincia"];
                    aux.Cliente.Estado = (bool)datos.Lector["Estado"];

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
                datos.setearConsulta("update Clientes set Estado = @activo where IdCliente = @idCliente");
                datos.setearParametro("@idCliente", idUsuario);
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
                datos.setearProcedimiento("sp_ClienteEliminarFisico");
                datos.setearParametro("@idCliente", idUsuario);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarConSP(Usuario aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_modificarCliente");
                datos.setearParametro("@idCliente", aux.IDUsuario);
                datos.setearParametro("@contraseña", aux.Contraseña);
                datos.setearParametro("@nombres", aux.Nombres);
                datos.setearParametro("@apellidos", aux.Apellidos);
                datos.setearParametro("@dni", aux.Cliente.DNI);
                datos.setearParametro("@telefono", aux.Cliente.Telefono);
                datos.setearParametro("@celular", aux.Cliente.Celular);
                datos.setearParametro("@calle", aux.Cliente.Direccion.Calle);
                datos.setearParametro("@numero", aux.Cliente.Direccion.Numero);
                datos.setearParametro("@piso", aux.Cliente.Direccion.Piso);
                datos.setearParametro("@departamento", aux.Cliente.Direccion.Depto);
                datos.setearParametro("@cp", aux.Cliente.Direccion.CodPostal);
                datos.setearParametro("@localidad", aux.Cliente.Direccion.Localidad);
                datos.setearParametro("@provincia", aux.Cliente.Direccion.Provincia);
                datos.setearParametro("@estado", aux.Cliente.Estado);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}