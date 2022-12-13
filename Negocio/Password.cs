using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;

namespace Negocio
{
    public class Password
    {
        private string code { get; set; }
        public void generarCodigo(string mail)
        {
            AccesoDatos datos = new AccesoDatos();
            Random rnd = new Random();
            //creates a number between 1 and 12:
            int random = rnd.Next(1, 5);


            try
            {
                datos.setearProcedimiento("sp_setearCodigo");
                datos.setearParametro("@mail", mail);
                datos.setearParametro("@random", random);

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

        public void EnviarCodigo (string mail)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_enviarCodigo");
                datos.setearParametro("@mail", mail);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    code = (string)datos.Lector["codigo"];
                    EmailService enviarMail = new EmailService();
                    string asunto = "Codigo de confirmacion mail";
                    string cuerpo = "El código es: " + code;
                    enviarMail.ArmarCorreo(mail, asunto, cuerpo);
                    enviarMail.EnviarEmail();

                }

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