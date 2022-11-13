<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="TPC_Bossetti_Nuñez.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-4">
        <label for="validationCustom01" class="form-label">Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
        <div class="valid-feedback">
            Excelente
        </div>
    </div>
    <div class="col-md-4">
        <label for="validationCustom02" class="form-label">Apellido</label>
        <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
        <div class="valid-feedback">
            Perfecto
        </div>
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
        <label for="validationPassqord" class="form-label">Password</label>
        <div class="input-group has-validation">
            <asp:TextBox ID="txtPass" CssClass="form-control" runat="server" type="password" />
            <div class="invalid-feedback">
                Por favor, elija una constraseña válida.
            </div>
        </div>
    </div>

    <div class="col-md-6">
        <label for="validationDNI" class="form-label">DNI</label>
        <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
            Ingrese un DNI válido.
        </div>
    </div>

    <div class="col-md-6">
        <label for="validationCel" class="form-label">Celular</label>
        <asp:TextBox ID="txtCel" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
            Ingrese un Celular válido.
        </div>
    </div>

    <div class="col-md-6">
        <label for="validationTel" class="form-label">Celular</label>
        <asp:TextBox ID="txtTel" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
            Ingrese un Teléfono válido.
        </div>
    </div>

    <div class="col-md-6">
        <label for="validationCalle" class="form-label">Calle</label>
        <asp:TextBox ID="txtCalle" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
        Ingrese una ciudad válida.
    </div>


    <div class="col-md-6">
        <label for="validationNum" class="form-label">Numero</label>
        <asp:TextBox ID="txtNum" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
        Ingrese una ciudad válida.
    </div>

    <div class="col-md-6">
        <label for="validationNum" class="form-label">Piso</label>
        <asp:TextBox ID="txtPiso" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
        Ingrese una ciudad válida.
    </div>

    <div class="col-md-6">
        <label for="validationDepto" class="form-label">Departamento</label>
        <asp:TextBox ID="txtDepto" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
            Ingrese una ciudad válida.
        </div>

    <div class="col-md-6">
        <label for="validationCustom03" class="form-label">Ciudad</label>
        <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
            Ingrese una ciudad válida.
        </div>
    </div>
    <div class="col-md-3">
        <label for="validationCustom04" class="form-label">Provincia</label>
        <%--<asp:DropDownList ID="txtProvincia" CssClass="form-label" runat="server" />--%>
        <asp:TextBox ID="txtProvincia" CssClass="form-control" runat="server" />
        <div class="invalid-feedback">
            Seleccione una Provincia válida.
        </div>
    </div>
    <div class="col-md-3">
        <label for="validationCustom05" class="form-label">Código Postal</label>
        <asp:TextBox CssClass="form-control" ID="txtCopPostal" runat="server"></asp:TextBox>
        <div class="invalid-feedback">
            Por favor use un código postal válido.
        </div>
    </div>
    <div class="col-12">
        <div class="form-check">
            <asp:CheckBox CssClass="form-check-label" ID="chkTerminosCondiciones" runat="server" />
            <label class="form-check-label" for="invalidCheck">
                Acepto términos y condiciones
            </label>
            <div class="invalid-feedback">
                Debe aceptar antes de continuar.
            </div>
        </div>
    </div>
    <div class="col-12">
        <asp:Button CssClass="btn btn-primary" runat="server" Text="Enviar" ID="btnAceptar" OnClick="btnAceptar_Click" />
        <a href="Default.aspx">Cancelar</a>
    </div>
</asp:Content>
