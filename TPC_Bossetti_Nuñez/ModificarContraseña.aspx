<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarContraseña.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ModificarContraseña" UnobtrusiveValidationMode="None" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <h5>Modificar Contraseña</h5>
            <div class="mb-3">
                <label for="txtNuevaPass" class="form-label">Nueva contraseña: </label>
                <asp:TextBox ID="txtNuevaPass" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ID="rfvnuevapass"
                    runat="server" ControlToValidate="txtNuevaPass"
                    ErrorMessage="Por favor, ingrese una contraseña"></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <label for="txtConfirmarPass" class="form-label">Confirmar contraseña: </label>
                <asp:TextBox ID="txtConfirmarPass" runat="server" CssClass="form-control" />
                <div>
                    <asp:Label ID="lblPass" runat="server" />
                </div>
            </div>
            <asp:Button CssClass="btn btn-primary" ID="btnGuardarPass" runat="server" Text="Guardar" OnClick="btnGuardarPass_Click" />
            <a href="Default.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
