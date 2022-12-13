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
        public bool ConfirmaEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            ConfirmaEliminacion = false;

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

                string IDLibro = Session["IDLibro"] != null ? Session["IDLibro"].ToString() : "";

                if (IDLibro != "" && !IsPostBack)
                {
                    LibroNegocio negocio = new LibroNegocio();
                    Libro seleccionado = (negocio.listar(IDLibro))[0];
                    Session.Add("LibroSeleccionado", seleccionado);

                    txtTitulo.Text = seleccionado.Titulo;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    txtAutor.Text = seleccionado.Autor;
                    txtEditorial.Text = seleccionado.Editorial;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtStock.Text = seleccionado.Stock.ToString();
                    txtPortadaURL.Text = seleccionado.PortadaURL;
                    ddlGenero.SelectedValue = seleccionado.Genero.IdGenero.ToString();
                    txtID.Text = IDLibro;

                    txtPortadaURL_TextChanged(sender, e);

                    if (!seleccionado.Estado)
                        btnInactivar.Text = "Reactivar";
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }


        }

        protected void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

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

                if (Session["IDLibro"] != null)
                {
                    nuevo.ID = short.Parse(txtID.Text);
                    negocio.Modificar(nuevo);
                    Session.Remove("IDLibro");
                }
                else
                    negocio.Agregar(nuevo);


                Response.Redirect("PrincipalAdmin.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void txtPortadaURL_TextChanged(object sender, EventArgs e)
        {
            imgPortada.ImageUrl = txtPortadaURL.Text;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmaEliminacion = true;
        }

        protected void ConfirmaEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkConfirma.Checked)
                {
                    LibroNegocio negocio = new LibroNegocio();
                    negocio.Eliminar(short.Parse(txtID.Text));
                    Response.Redirect("Default.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }

        }

        protected void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                LibroNegocio negocio = new LibroNegocio();
                Libro seleccionado = (Libro)Session["LibroSeleccionado"];

                negocio.EliminarLogico(seleccionado.ID, !seleccionado.Estado);
                
                Response.Redirect("Default.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Session.Remove("IDLibro");
            Response.Redirect("PrincipalAdmin.aspx", false);
        }
    }
}