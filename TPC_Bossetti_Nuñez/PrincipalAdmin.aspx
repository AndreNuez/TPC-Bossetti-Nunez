<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PrincipalAdmin.aspx.cs" Inherits="TPC_Bossetti_Nuñez.PrincipalAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-4"></div>
        <div class="col">
            <div class="text-center">
                <h2>Bienvenido Administrador</h2>
            </div>
            <div class="text-center text-muted">
                <p>Por favor, seleccione una opción</p>
            </div>
            <div class="col-2"></div>
            <div class="col-2"></div>
            <br />
            <div class="d-grid mx-auto">
                <asp:Button Text="Agregar Libro" ID="btnAgregarLibro" class="btn btn-primary" OnClick="btnAgregarLibro_Click" runat="server" />
            </div>
             <div class="d-grid mx-auto">
                <a href="ListadoLibros.aspx" class="btn btn-primary" style="margin-top: 20px">Listado Libros</a>
            </div>
            <div class="d-grid mx-auto">
                <a href="Pedido.aspx" class="btn btn-primary" style="margin-top: 20px">Listado Pedidos</a>
            </div>
            <div class="d-grid mx-auto">
                <a href="AdminClientes.aspx" class="btn btn-primary" style="margin-top: 20px">Administrar Clientes</a>
            </div>
            <br />
            <br />
            <div class="col-2"></div>
            <div class="col-2"></div>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
