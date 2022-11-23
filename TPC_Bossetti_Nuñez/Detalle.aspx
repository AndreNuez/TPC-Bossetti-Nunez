<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label Text="" CssClass="fs-1 fw-bolder" ID="lblTitulo" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="" CssClass="fs-3" ID="lblDescripcion" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="" CssClass="fs-4" ID="lblAutor" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="" CssClass="fs-4" ID="lblEditorial" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="" CssClass="fs-3 fw-bolder" ID="lblPrecio" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="" CssClass="fs-4" ID="lblStock" runat="server" />
            </div>
            <br />
            <br />
            <div class="mb-3">
                <asp:Button Text="Agregar al Carrito" ID="btnAgregarCarrito" CssClass="btn btn-primary" runat="server" Onclick="btnAgregarCarrito_Click" />
            </div>
            <br />
            <br />
            <br />
            <div class="mb-3">
                <a href="Default.aspx"> Regresar al Catálogo</a>
            </div>
        </div>

        <div class="col-6">
            <div>
                <asp:Image ID="img" CssClass="img-fluid" runat="server" onerror="this.src='https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=';" />
            </div>
        </div>
    </div>
</asp:Content>
