<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PrincipalCliente.aspx.cs" Inherits="TPC_Bossetti_Nuñez.PrincipalCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-4"></div>
        <div class="col">
            <div class="text-center">
                <h2>Bienvenido Usuario</h2>
            </div>
            <div class="text-center text-muted">
                <p>Por favor, seleccione una opción</p>
            </div>
            <div class="col-2"></div>
            <div class="col-2"></div>
            <br />
            <div class="d-grid mx-auto">
                <a href="ModificarDatos.aspx" class="btn btn-primary" style="margin-top: 20px">Ver Mis Datos</a>
            </div>
            <div class="d-grid mx-auto">
                <a href="Pedido.aspx" class="btn btn-primary" style="margin-top: 20px">Ver Mis Pedidos</a>
            </div>
            <div class="d-grid mx-auto">
                <asp:Button Text="Eliminar Usuario" runat="server" ID="btnEliminarUsuario" OnClick="btnEliminarUsuario_Click"  CssClass="btn btn-primary" CssStyle="margin-top: 20px"/>
            </div>
            <br />
            <br />
            <div class="col-2"></div>
            <div class="col-2"></div>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
