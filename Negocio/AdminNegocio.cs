using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class AdminNegocio
    {
        public List<Administrador> listar (string idCliente = "")
        {
            List<Administrador> lista = new List<Administrador>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select a.IdAdministrador, a.Mail, a.Contraseña, a.Nombres, a.Apellidos, a.TipoUser from Administradores a ";
                
                if(idCliente != "")
                {
                    consulta = consulta += "where a.IdAdministrador =" + idCliente;

                    datos.setearConsulta(consulta);
                    datos.ejecutarLectura();
                    while (datos.Lector.Read())
                    {
                        Administrador aux = new Administrador();
                        aux.IDAdministrador = (short)datos.Lector["IdAdminsitrador"];
                        aux.Mail = (string)datos.Lector["Mail"];
                        aux.Contraseña = (string)datos.Lector["Contraseña"];
                        aux.Nombres = (string)datos.Lector["Nombres"];
                        aux.Apellidos = (string)datos.Lector["Apellidos"];
                        //aux.TipoUsuario = TipoUsuario.ADMIN;
                        aux.TipoUsuario = (int)(datos.Lector["TipoUser"]) == 2 ? TipoUsuario.ADMIN : TipoUsuario.CLIENTE;

                        lista.Add(aux);
                    }
                }
                return lista;
            
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}