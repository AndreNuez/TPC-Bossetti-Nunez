<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="TPC_Bossetti_Nuñez.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
    <div class="col-md-4">
        <label for="validationCustom01" class="form-label">Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
    </div>
    <div class="col-md-4">
        <label for="validationCustom02" class="form-label">Apellido</label>
        <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
    </div>
    <div class="col-md-4">
        <label for="validationCustomUsername" class="form-label">Mail</label>
        <div class="input-group has-validation">
            <asp:TextBox ID="txtMail" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Por favor, elija un mail válido.
            </div>
        </div>
    </div>

    <div class="col-md-4">
        <label for="validationPassword" class="form-label">Password</label>
        <div class="input-group has-validation">
            <asp:TextBox ID="txtPass" CssClass="form-control" runat="server" type="password" />
            <div class="invalid-feedback">
                Por favor, elija una constraseña válida.
            </div>
        </div>
     </div>
    <div class="col-md-4">
        <asp:Button Text="Registrarse" runat="server" ID="btnRegistrarse" CssClass="btn btn-primary" OnClick="btnRegistrarse_Click"/>
        <a href="Default.aspx" class="btn btn-danger">Cancelar</a>
    </div>
</asp:Content>