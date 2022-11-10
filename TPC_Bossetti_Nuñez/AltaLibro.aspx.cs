using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Bossetti_Nuñez
{
    public partial class AltaLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            try
            {
                if (!IsPostBack)
                {
                    GeneroNegocio negocio = new GeneroNegocio();
                    List<Generos> Lista = negocio.listar();

                    ddlGenero.DataSource = Lista;
                    ddlGenero.DataValueField = "IdGenero";
                    ddlGenero.DataTextField = "Descripcion";
                    ddlGenero.DataBind();
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex);
                throw;
            }


        }

        protected void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Libro nuevo = new Libro();
                LibroNegocio negocio = new LibroNegocio();

                nuevo.Titulo = txtTitulo.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Autor = txtAutor.Text;
                nuevo.Editorial = txtEditorial.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.Stock = int.Parse(txtStock.Text);
                nuevo.PortadaURL = txtPortadaURL.Text;

                nuevo.Genero = new Generos();
                nuevo.Genero.IdGenero = short.Parse(ddlGenero.SelectedValue);


                negocio.Agregar(nuevo);
                Response.Redirect("Default.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
                throw;
            }
        }

        protected void txtPortadaURL_TextChanged(object sender, EventArgs e)
        {
            imgPortada.ImageUrl = txtPortadaURL.Text;
        }
    }
}