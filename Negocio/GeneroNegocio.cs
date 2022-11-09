using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class GeneroNegocio
    {
        public List<Generos> listar()
        {
            List<Generos> lista = new List<Generos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdGenero, Descripcion from Generos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Generos aux = new Generos();
                    aux.IdGenero = (short)datos.Lector["IdGenero"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
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