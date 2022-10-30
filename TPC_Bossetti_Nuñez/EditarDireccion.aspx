<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarDireccion.aspx.cs" Inherits="TPC_Bossetti_Nuñez.EditarDireccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <h5>Modificar Dirección</h5>
            <div class="mb-3">
                <label for="txtCalle" class="form-label">Calle: </label>
                <asp:TextBox ID="txtCalle" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtNumero" class="form-label">Numero: </label>
                <asp:TextBox ID="txtNumero" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtPiso" class="form-label">Piso: </label>
                <asp:TextBox ID="txtPiso" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtDepto" class="form-label">Departamento: </label>
                <asp:TextBox ID="txtDepto" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtCP" class="form-label">Codigo Postal: </label>
                <asp:TextBox ID="txtCP" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtLocalidad" class="form-label">Localidad: </label>
                <asp:TextBox ID="txtLocalidad" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtProvincia" class="form-label">Provincia: </label>
                <asp:TextBox ID="txtProvincia" CssClass="form-control" runat="server" />
            </div>
            <asp:Button CssClass="btn btn-primary" ID="btnGuardarDireccion" runat="server" Text="Guardar" OnClick="btnGuardarDireccion_Click" />
            <a href="DatosCliente.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
