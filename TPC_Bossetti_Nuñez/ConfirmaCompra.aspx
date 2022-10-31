<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConfirmaCompra.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ConfirmaCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-6">
        <br />
        <h5>Dirección de envío</h5>
        <div>
            <asp:Label ID="lblCalle" Text="Av. Siempre Viva 123" runat="server" />
            <asp:Label Text="1234" ID="lblCP" runat="server" />
        </div>
        <div>
            <asp:Label Text="Localidad" ID="lblLocalidad" runat="server" />
            <asp:Label ID="lblProvincia" runat="server" Text="Provincia"></asp:Label>
        </div>
        <div>
            <asp:DropDownList ID="ddlFormaPago" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div>
        <a href="EditarDireccion.aspx">Editar Dirección</a>
    </div>
    <asp:Button CssClass="btn btn-primary" ID="btnConfirmaCompra" runat="server" Text="Confirmar" OnClick="btnConfirmaCompra_Click" />
    <a href="Carrito.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>




</asp:Content>
