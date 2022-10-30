using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Bossetti_Nuñez
{
    public partial class AltaLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtID.Enabled= false;

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