<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarDatos.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ModificarDatos" UnobtrusiveValidationMode="None" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-md-4">
            <label for="txtNombre" class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
            <asp:RequiredFieldValidator ID="rfvNombre"
                runat="server" ControlToValidate="txtNombre"
                ErrorMessage="Debe ingresar un nombre"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-4">
            <label for="txtApellido" class="form-label">Apellido</label>
            <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
            <asp:RequiredFieldValidator ID="rfvApellido"
                runat="server" ControlToValidate="txtApellido"
                ErrorMessage="Debe ingresar un apellido"></asp:RequiredFieldValidator>
        </div>
        <div class="row" style="margin-top: 15px">
            <div class="col-md-4">
                <label for="txtMail" class="form-label">Mail</label>
                <asp:TextBox ID="txtMail" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-4">
                <label for="txtPass" class="form-label">Password</label>
                <asp:TextBox ID="txtPass" CssClass="form-control" runat="server" type="password" />
                <asp:Button Text="Modificar contraseña" runat="server" ID="btnModificarPass" OnClick="btnModificarPass_Click" />
            </div>
        </div>
        <div class="col-md-4" style="margin-top: 15px">
            <label for="txtDNI" class="form-label">DNI</label>
            <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server" />
        </div>

        <h5 style="margin-top: 25px">Contacto</h5>
        <div class="col-md-4">
            <label for="txtCel" class="form-label">Celular</label>
            <asp:TextBox ID="txtCel" CssClass="form-control" runat="server" />
        </div>

        <div class="col-md-4">
            <label for="txtTel" class="form-label">Teléfono</label>
            <asp:TextBox ID="txtTel" CssClass="form-control" runat="server" />
        </div>

        <h5 style="margin-top: 25px">Domicilio</h5>
        <div class="col-md-3">
            <label for="txtCalle" class="form-label">Calle</label>
            <asp:TextBox ID="txtCalle" CssClass="form-control" runat="server" />
        </div>

        <div class="col-md-2">
            <label for="txtNum" class="form-label">Numero</label>
            <asp:TextBox ID="txtNum" CssClass="form-control" runat="server" />
        </div>

        <div class="col-md-2">
            <label for="txtPiso" class="form-label">Piso</label>
            <asp:TextBox ID="txtPiso" CssClass="form-control" runat="server" />
        </div>

        <div class="col-md-2">
            <label for="txtDepto" class="form-label">Departamento</label>
            <asp:TextBox ID="txtDepto" CssClass="form-control" runat="server" />
        </div>
        <div class="col-md-2">
            <label for="txtCopPostal" class="form-label">Código Postal</label>
            <asp:TextBox CssClass="form-control" ID="txtCopPostal" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <label for="txtCity" class="form-label">Ciudad</label>
            <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" />
        </div>
        <div class="col-md-3">
            <label for="txtProvincia" class="form-label">Provincia</label>
            <asp:TextBox ID="txtProvincia" CssClass="form-control" runat="server" />
        </div>

        <div class="col-12">
            <br />
            <asp:Button CssClass="btn btn-primary" runat="server" Text="Enviar" ID="btnAceptar" OnClick="btnAceptar_Click" />
            <a style="margin-left: 25px" class="btn btn-danger" href="Default.aspx">Cancelar</a>
        </div>
    </div>
</asp:Content>




