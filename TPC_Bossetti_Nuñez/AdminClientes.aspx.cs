﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Bossetti_Nuñez
{
    public partial class AdminClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Seguridad.esAdmin(Session["usuario"]) != TipoUsuario.ADMIN)
            {
                Session.Add("error", "Se requieren permisos de Administrador para acceder a esta pantalla");
                Response.Redirect("Error.aspx");
            }
            UsuarioNegocio usuario = new UsuarioNegocio();
            Session.Add("ListaClientes", usuario.listarClientesConSP());

            if (!IsPostBack)
            {
                dgvClientesAdmin.DataSource = Session["ListaClientes"];
                dgvClientesAdmin.DataBind();
            }

        }

        protected void dgvClientesAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string idCliente = dgvClientesAdmin.SelectedDataKey.Value.ToString();
            //Response.Redirect("DatosCliente.aspx?idCliente=" + idCliente);

            string idUsuario = dgvClientesAdmin.SelectedDataKey.Value.ToString();
            Session.Add("idUsuario", idUsuario);
            Response.Redirect("DatosCliente.aspx");



        }

        /*protected void dgvClientesAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCliente = (int)dgvClientesAdmin.SelectedDataKey.Value;
            //Response.Redirect("DatosCliente.aspx?idCliente=" + idCliente);
            Usuario seleccionado = new Usuario();
            seleccionado.IDUsuario = idCliente;
            UsuarioNegocio negocio = new UsuarioNegocio();
            if (negocio.seleccionarClienteConSP(seleccionado))
            {
                Session.Add("usuarioSeleccionado", seleccionado);
            }
        }
        */
        protected void dgvClientesAdmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvClientesAdmin.PageIndex = e.NewPageIndex;
            dgvClientesAdmin.DataBind();
        }

        protected void txtFiltrarClientes_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> Lista = (List<Usuario>)Session["ListaClientes"];
            List<Usuario> ListaFiltrada = Lista.FindAll(x => x.Apellidos.ToUpper().Contains(txtFiltrarClientes.Text.ToUpper()) || x.Mail.ToUpper().Contains(txtFiltrarClientes.Text.ToUpper()));
            dgvClientesAdmin.DataSource = ListaFiltrada;
            dgvClientesAdmin.DataBind();
        }
    }
}