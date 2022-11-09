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

        protected void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void txtPortadaURL_TextChanged(object sender, EventArgs e)
        {
            imgPortada.ImageUrl = txtPortadaURL.Text;
        }
    }
}