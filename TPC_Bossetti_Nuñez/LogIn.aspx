<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TPC_Bossetti_Nuñez.LogIn" UnobtrusiveValidationMode="None" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email</label>
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" TextMode="Email" />
                <asp:RequiredFieldValidator ID="rfvemail"
                    runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Por favor, ingrese su correo"></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Contraseña</label>
                <asp:TextBox ID="txtPassword" runat="server" type="password" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvpassword"
                    runat="server" ControlToValidate="txtPassword"
                    ErrorMessage="Por favor, ingrese su contraseña"></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <asp:Button CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
                <div class="text-end">
                    <a class="btn btn-light" href="EnviarCodigo.aspx">Olvidé mi contraseña</a>
                </div>
            </div>
        </div>
        <div class="col-4"></div>
    </div>

</asp:Content>
