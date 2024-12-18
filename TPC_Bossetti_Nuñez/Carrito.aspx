﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h2>Productos en Carrito</h2>
        <br />
    </div>
    <div class="col text-center">
        <%if ((int)Session["CantidadCarrito"] != 0)
            {%>
        <asp:GridView ID="dgvCarrito" runat="server" CssClass="table table-light" DataKeyNames="IDItem" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged" AutoGenerateColumns="false">
            <Columns>
                <asp:CommandField ShowSelectButton="true" SelectText="Quitar" HeaderText=" " />
                <asp:BoundField HeaderText="Nombre" DataField="NombreItem" />
                <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />   
            </Columns>
        </asp:GridView>
          <% }
              else
              {%>
        <div class="text-center">
            <br />
            <br />
            <br />
            <h3>El carrito está vacío.</h3>
            <p class="text-muted">Agrega productos al carrito desde el catálogo.</p>
            <br />
            <br />
            <br />
        </div>
        <% }%>
    </div>
    <div class="text-end fs-2"">
        <asp:Label ID="lblTotalCarrito" runat="server" />
    </div>
    <div class="text-end">
        <asp:Button Text="Vaciar Carrito" CssClass="btn btn-warning" runat="server" Id="btnVaciar" OnClick="btnVaciar_Click" />
    </div>
    <br />
    <br />
    <%if ((int)Session["CantidadCarrito"] != 0)
        {%>
    <div class="text-end">
        <asp:Button Text="Comprar Carrito" CssClass="btn btn-primary" runat="server" Id="btnComprarCarrito" OnClick="btnComprarCarrito_Click"/>
    </div>
     <% }%>
    <div>
        <a class="nav-link" href="Default.aspx">Regresar al catalogo</a>
    </div>
</asp:Content>
