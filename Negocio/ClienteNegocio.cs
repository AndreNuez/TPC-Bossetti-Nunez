using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void Agregar (Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_altaCliente");

                datos.setearParametro("@mail", nuevo.Mail);
                datos.setearParametro("@contraseña", nuevo.Contraseña);
                datos.setearParametro("@nombres", nuevo.Nombres);
                datos.setearParametro("@apellidos", nuevo.Apellidos);
                datos.setearParametro("@DNI", nuevo.DNI);
                datos.setearParametro("@telefono", nuevo.Telefono);
                datos.setearParametro("@celular", nuevo.Celular);
                datos.setearParametro("@calle", nuevo.Direccion.Calle);
                datos.setearParametro("@numero", nuevo.Direccion.Numero);
                datos.setearParametro("@piso", nuevo.Direccion.Piso);
                datos.setearParametro("@departamento", nuevo.Direccion.Depto);
                datos.setearParametro("@CP", nuevo.Direccion.CodPostal);
                datos.setearParametro("@localidad", nuevo.Direccion.Localidad);
                datos.setearParametro("@provincia", nuevo.Direccion.Provincia);

                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> listarConSP()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
        
            try
            {
                datos.setearProcedimiento("sp_listarClientes");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.IDCliente = (short)datos.Lector["IdCliente"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Contraseña = (string)datos.Lector["Contraseña"];
                    aux.Nombres = (string)datos.Lector["Nombres"];
                    aux.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.DNI = (string)datos.Lector["DNI"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    aux.Celular = (string)datos.Lector["Celular"];
                    aux.Direccion = new Direccion();
                    aux.Direccion.Calle = (string)datos.Lector["Calle"];
                    aux.Direccion.Numero = (string)datos.Lector["Numero"];
                    aux.Direccion.Piso = (string)datos.Lector["Piso"];
                    aux.Direccion.Depto = (string)datos.Lector["Departamento"];
                    aux.Direccion.CodPostal = (string)datos.Lector["CP"];
                    aux.Direccion.Localidad = (string)datos.Lector["Localidad"];
                    aux.Direccion.Provincia = (string)datos.Lector["Provincia"];
                    aux.Estado = (bool)datos.Lector["Estado"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> listar(string idCliente = "")
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select c.IdCliente,c.mail,c.Contraseña,c.Nombres,c.Apellidos,c.Dni,c.Telefono,c.Celular,c.Calle,c.Numero,c.Piso,c.Departamento,c.CP,c.Localidad,c.Provincia,c.estado from clientes c ";
                
                if (idCliente != "")
                    consulta = consulta += "where c.IdCliente =" + idCliente;

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.IDCliente = (short)datos.Lector["IdCliente"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.Contraseña = (string)datos.Lector["Contraseña"];
                    aux.Nombres = (string)datos.Lector["Nombres"];
                    aux.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.DNI = (string)datos.Lector["DNI"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    aux.Celular = (string)datos.Lector["Celular"];
                    aux.Direccion = new Direccion();
                    aux.Direccion.Calle = (string)datos.Lector["Calle"];
                    aux.Direccion.Numero = (string)datos.Lector["Numero"];
                    aux.Direccion.Piso = (string)datos.Lector["Piso"];
                    aux.Direccion.Depto = (string)datos.Lector["Departamento"];
                    aux.Direccion.CodPostal = (string)datos.Lector["CP"];
                    aux.Direccion.Localidad = (string)datos.Lector["Localidad"];
                    aux.Direccion.Provincia = (string)datos.Lector["Provincia"];
                    aux.Estado = (bool)datos.Lector["Estado"];

                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarLogico (int idCliente, bool activo =  false)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Clientes set Estado = @activo where IdCliente = @idCliente");
                datos.setearParametro("@idCliente", idCliente);
                datos.setearParametro("@activo", activo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarConSP (Cliente aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_modificarCliente");
                datos.setearParametro("@idCliente", aux.IDCliente);
                datos.setearParametro("@contraseña", aux.Contraseña);
                datos.setearParametro("@nombres", aux.Nombres);
                datos.setearParametro("@apellidos", aux.Apellidos);
                datos.setearParametro("@dni", aux.DNI);
                datos.setearParametro("@telefono", aux.Telefono);
                datos.setearParametro("@celular", aux.Celular);
                datos.setearParametro("@calle", aux.Direccion.Calle);
                datos.setearParametro("@numero", aux.Direccion.Numero);
                datos.setearParametro("@piso", aux.Direccion.Piso);
                datos.setearParametro("@departamento", aux.Direccion.Depto);
                datos.setearParametro("@cp", aux.Direccion.CodPostal);
                datos.setearParametro("@localidad", aux.Direccion.Localidad);
                datos.setearParametro("@provincia", aux.Direccion.Provincia);
                datos.setearParametro("@estado", aux.Estado);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}