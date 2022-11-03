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
    }
}