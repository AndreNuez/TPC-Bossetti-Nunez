<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RestablecerContraseña.aspx.cs" Inherits="TPC_Bossetti_Nuñez.RestablecerContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <h5>Modificar Contraseña</h5>
            <p>Para verificar su identidad se ha enviado a su casilla de correo electrónico un código de confirmación.</p>
            <div class="mb-3">
                <label class="form-label">Mail</label>
                <asp:TextBox runat="server" ID="txtMail" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNuevaPass" class="form-label">Nueva contraseña: </label>
                <asp:TextBox ID="txtNuevaPass" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtConfirmarPass" class="form-label">Confirmar contraseña: </label>
                <asp:TextBox ID="txtConfirmarPass" runat="server" CssClass="form-control" />
                <asp:Label ID="lblPass" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Código de confirmación</label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control" />
            </div>
            <asp:Button CssClass="btn btn-primary" ID="btnRestablecerPass" runat="server" Text="Restablecer Contraseña" OnClick="btnRestablecerPass_Click" />
            <a href="Default.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>
        </div>
        <div class="col-4"></div>
    </div>



</asp:Content>
