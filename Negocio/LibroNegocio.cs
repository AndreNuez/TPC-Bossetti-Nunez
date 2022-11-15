using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class LibroNegocio
    {
        public List<Libro> listar(string id = "")
        {
            List<Libro> lista = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select l.id, l.Titulo, l.Descripcion, l.Autor, l.Editorial, l.Precio, l.Stock, g.IdGenero as Genero_ID, g.Descripcion as Genero_Desc, l.Portada, l.estado from Libros l inner join Generos g on l.IdGenero = g.IdGenero ";

                if (id != "")
                    consulta = consulta += "and l.id =" + id;


                datos.setearConsulta(consulta);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Libro aux = new Libro();
                    aux.ID = (short)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Autor = (string)datos.Lector["Autor"];
                    aux.Editorial = (string)datos.Lector["Editorial"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Genero = new Generos();
                    aux.Genero.IdGenero = (short)datos.Lector["Genero_ID"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero_Desc"];
                    aux.PortadaURL = (string)datos.Lector["Portada"];
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
                    aux.ID = (short)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Autor = (string)datos.Lector["Autor"];
                    aux.Editorial = (string)datos.Lector["Editorial"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Genero = new Generos();
                    aux.Genero.IdGenero = (short)datos.Lector["Genero_ID"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero_Desc"];
                    aux.PortadaURL = (string)datos.Lector["Portada"];
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

        public List<Libro> Filtrar(string Campo, string Criterio, string Filtro)
        {
            List<Libro> lista = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select l.id, l.Titulo, l.Descripcion, l.Autor, l.Editorial, l.Precio, l.Stock, g.IdGenero as Genero_ID, g.Descripcion as Genero_Desc, l.Portada, l.estado from Libros l inner join Generos g on l.IdGenero = g.IdGenero where l.Estado = 1 And ";

                if (Campo == "Precio")
                {
                    switch (Criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + Filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + Filtro;
                            break;
                        default:
                            consulta += "Precio = " + Filtro;
                            break;
                    }
                }
                
                else if (Campo == "Autor")
                {
                    switch (Criterio)
                    {
                        case "Comienza con":
                            consulta += "Autor like '" + Filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Autor like '%" + Filtro + "'";
                            break;
                        default:
                            consulta += "Autor like '%" + Filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (Criterio)
                    {
                        case "Comienza con":
                            consulta += "Editorial like '" + Filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Editorial like '%" + Filtro + "'";
                            break;
                        default:
                            consulta += "Editorial like '%" + Filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Libro aux = new Libro();
                    aux.ID = (short)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Autor = (string)datos.Lector["Autor"];
                    aux.Editorial = (string)datos.Lector["Editorial"];
                    aux.Precio = decimal.Parse(datos.Lector["Precio"].ToString());
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Genero = new Generos();
                    aux.Genero.IdGenero = (short)datos.Lector["Genero_ID"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero_Desc"];
                    aux.PortadaURL = (string)datos.Lector["Portada"];
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

        public List<Libro> ListarSPInactivos()
        {
            List<Libro> lista = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_ListarLibrosInactivos");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Libro aux = new Libro();
                    aux.ID = (short)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Autor = (string)datos.Lector["Autor"];
                    aux.Editorial = (string)datos.Lector["Editorial"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Genero = new Generos();
                    aux.Genero.IdGenero = (short)datos.Lector["Genero_ID"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero_Desc"];
                    aux.PortadaURL = (string)datos.Lector["Portada"];
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

        public void Eliminar(short id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearProcedimiento("SP_EliminarFisico");
                datos.setearParametro("@ID", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarLogico(short id, bool activo = false)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearProcedimiento("SP_EliminarLogico");
                datos.setearParametro("@ID", id);
                datos.setearParametro("@Estado", activo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Libro Libro)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_ModificarLibro");

                datos.setearParametro("ID", Libro.ID);
                datos.setearParametro("@Titulo", Libro.Titulo);
                datos.setearParametro("@Descripcion", Libro.Descripcion);
                datos.setearParametro("@Autor", Libro.Autor);
                datos.setearParametro("Editorial", Libro.Editorial);
                datos.setearParametro("IdGenero", Libro.Genero.IdGenero);
                datos.setearParametro("Precio", Libro.Precio);
                datos.setearParametro("Stock", Libro.Stock);
                datos.setearParametro("PortadaURL", Libro.PortadaURL);

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