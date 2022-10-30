<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="TPC_Bossetti_Nuñez.DatosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="row">
            <div class="col-6">
                <h5>Información de cuenta</h5>
                <div class="mb-3">
                    <asp:Label Text="Nombre Apellido" ID="lblApeNom" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Label Text="mail@unmail.com" ID="lblMail" runat="server" />
                </div>
            </div>
            <div class="col-6">
                <br />
                <div class="mb-3">
                    <a href="#">Editar Datos</a>
                </div>
                <div class="mb-3">
                    <a href="#">Modificar Contraseña</a>
                </div>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-6">
                <h5>Dirección</h5>
                <div class="mb-3">
                    <asp:Label Text="Calle + Altura + Piso + Depto" ID="lblDireccion1" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Label Text="(CP) + Localidad" ID="lblDireccion2" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Label Text="Provincia" ID="lblProvincia" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Label Text="Celular" ID="lblCelular" runat="server" />
                </div>
            </div>
            <div class="col-6">
                <br />
                <div class="mb-3">
                    <a href="#">Editar Dirección</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
