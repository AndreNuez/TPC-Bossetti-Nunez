using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Bossetti_Nuñez
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                btnLogin.Text = "LogIn";
                Response.Redirect("LogIn.aspx", false);
            }
            else
            {
                btnLogin.Text = "LogOut";
                Session.Remove("usuario");
            }

        }
    }
}