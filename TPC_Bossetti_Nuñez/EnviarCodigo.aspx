<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EnviarCodigo.aspx.cs" Inherits="TPC_Bossetti_Nuñez.EnviarCodigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <h5>Restablecer Contraseña</h5>
            <p>Enviara código de confirmación mail para restablecer contraseña</p>
            <div class="mb-3">
                <label for="txtMail" class="form-label">Mail</label>
                <asp:TextBox ID="txtMail" CssClass="form-control" runat="server" />
            </div>
            <asp:Button Text="Generar Código" runat="server" ID="btnGenerarCodigo" OnClick="btnGenerarCodigo_Click"/>
            <a href="Default.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
