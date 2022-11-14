<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="TPC_Bossetti_Nuñez.DatosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="row">
            <div class="col-6">
                <h5>Información de cuenta</h5>
                    <div class="mb-3">
                        <asp:Label Text="Nombre" ID="lblApellido" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label Text="Apellido" ID="lblNombre" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label Text="mail@unmail.com" ID="lblMail" runat="server" />
                    </div>
            </div>
            <%--<div class="col-6">
                <br />
                <div class="mb-3">
                    <a href="ModificarDatos.aspx">Editar Datos</a>
                </div>
                <div class="mb-3">
                    <a href="ModificarContraseña.aspx">Modificar Contraseña</a>
                </div>
            </div>--%>
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
                <div class="mb-3">
                    <a href="AdminClientes.aspx" class="btn btn-secondary">Regresar</a>
                    <asp:Button ID="btnActivar" CssClass="btn btn-warning" runat="server" Text="Inactivar" OnClick="btnActivar_Click" />
                </div>
            </div>
            <%--<div class="col-6">
                <br />
                <div class="mb-3">
                    <a href="EditarDireccion.aspx">Editar Dirección</a>
                </div>
            </div>--%>
        </div>
    </div>
</asp:Content>
