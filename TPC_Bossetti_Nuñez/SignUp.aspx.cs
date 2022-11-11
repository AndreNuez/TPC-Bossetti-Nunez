﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace TPC_Bossetti_Nuñez
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();

            nuevo.Mail = txtMail.Text;
            nuevo.Contraseña = txtPass.Text;
            nuevo.Nombres = txtNombre.Text;
            nuevo.Apellidos = txtNombre.Text;
            nuevo.DNI = txtDNI.Text;
            nuevo.Telefono = txtTel.Text;
            nuevo.Celular = txtCel.Text;

            nuevo.Direccion = new Direccion();
            nuevo.Direccion.Calle = txtCalle.Text;
            nuevo.Direccion.Numero = int.Parse(txtNum.Text);
            nuevo.Direccion.Depto = txtDepto.Text;
            nuevo.Direccion.Localidad = txtCity.Text;
            nuevo.Direccion.Provincia = txtProvincia.Text;
            nuevo.Direccion.CodPostal = int.Parse(txtCopPostal.Text);

            negocio.Agregar(nuevo);
            Response.Redirect("Default.aspx", false);

        }
    }
}