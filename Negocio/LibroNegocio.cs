using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class LibroNegocio
    {
        public List<Libro> listarConSP()
        {
            List<Libro> lista = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_librosListar");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Libro aux = new Libro();
                    //aux.ID = (int)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    //aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Autor = (string)datos.Lector["Autor"];
                    //aux.Editorial = (string)datos.Lector["Editorial"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    //aux.Stock = (int)datos.Lector["Stock"];
                    //aux.Genero = new Genero();
                    //aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    aux.PortadaURL = (string)datos.Lector["Portada"];
                    //aux.Estado = (bool)datos.Lector["estado"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(Libro nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_AltaLibro");

                datos.setearParametro("@Titulo", nuevo.Titulo);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Autor", nuevo.Autor);
                datos.setearParametro("@Editorial", nuevo.Editorial);
                datos.setearParametro("@IdGenero", nuevo.Genero.IdGenero);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@Stock", nuevo.Stock);
                datos.setearParametro("@PortadaURL", nuevo.PortadaURL);

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