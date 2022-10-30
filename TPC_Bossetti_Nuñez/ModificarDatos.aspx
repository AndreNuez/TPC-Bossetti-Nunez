<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarDatos.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ModificarDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <h5>Modificar Datos</h5>
            <div class="mb-3">
                <label for="txtNombres" class="form-label">Nombres: </label>
                <asp:TextBox ID="txtNombres" CssClass="form-control" runat="server" />
            </div>
               <div class="mb-3">
                <label for="txtApellidos" class="form-label">Apellidos: </label>
                <asp:TextBox ID="txtApellidos" CssClass="form-control" runat="server" />
            </div>
               <div class="mb-3">
                <label for="txtDNI" class="form-label">DNI: </label>
                <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server" />
            </div>
               <div class="mb-3">
                <label for="txtFNac" class="form-label">Fecha de Nacimiento: </label>
                <asp:TextBox ID="txtFNac" CssClass="form-control" TextMode="Date" runat="server" />
            </div>
            <asp:Button CssClass="btn btn-primary" ID="btnGuardarDatos" runat="server" Text="Guardar" OnClick="btnGuardarDatos_Click" />
            <a href="DatosCliente.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
