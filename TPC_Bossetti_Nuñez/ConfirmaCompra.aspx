<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConfirmaCompra.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ConfirmaCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-6">
        <br />
        <h5>Dirección de envío</h5>
        <div>
            <asp:Label ID="lblCalle" Text="" runat="server" />
            <asp:Label ID="lblCP" Text="" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblLocalidad" Text="" runat="server" />
            <asp:Label ID="lblProvincia" runat="server" Text=""></asp:Label>
        </div>
        <h5>Método de Pago</h5>
        <div>
            <asp:RadioButton ID="rdbEfectivo" Text="Efectivo" runat="server" Checked="true" GroupName="Pago"/>
            <asp:RadioButton ID="rdbMP" Text="Mercado Pago" runat="server" GroupName="Pago"/>
        </div>
        <h5>Método de Envío</h5>
        <div>
            <asp:RadioButton ID="rdbRetiro" Text="Retiro Sucursal" runat="server" Checked="true" GroupName="Envio"/>
            <asp:RadioButton ID="rdbDomicilio" Text="Envío a Domicilio" runat="server" GroupName="Envio"/>
        </div>
    </div>
    <div>
        <a href="EditarDireccion.aspx">Editar Dirección</a>
    </div>
    <asp:Button CssClass="btn btn-primary" ID="btnConfirmaCompra" runat="server" Text="Confirmar" OnClick="btnConfirmaCompra_Click" />
    <a href="Carrito.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>




</asp:Content>
