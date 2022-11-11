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

    }
}