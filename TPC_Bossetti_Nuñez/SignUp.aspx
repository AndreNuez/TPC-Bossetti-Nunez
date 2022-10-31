<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="TPC_Bossetti_Nuñez.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-4">
        <label for="validationCustom01" class="form-label">Nombre</label>
        <asp:TextBox id="txtNombre" runat="server" cssClass="form-control"/>
        <div class="valid-feedback">
            Excelente
        </div>
    </div>
    <div class="col-md-4">
        <label for="validationCustom02" class="form-label">Apellido</label>
        <asp:TextBox id="txtApellido" cssClass="form-control" runat="server"/>
        <div class="valid-feedback">
            Perfecto
        </div>
    </div>
    <div class="col-md-4">
        <label for="validationCustomUsername" class="form-label">Nombre de usuario</label>
        <div class="input-group has-validation">
            <span class="input-group-text" id="inputGroupPrepend">@</span>
            <asp:TextBox id="txtUserName" cssClass="form-control" runat="server"/>
            <div class="invalid-feedback">
                Por favor, elija un nombre de usuario.
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <label for="validationCustom03" class="form-label">Ciudad</label>
        <asp:TextBox id="txtCity" cssClass="form-control" runat="server"/>
        <div class="invalid-feedback">
            Ingrese una ciudad válida.
        </div>
    </div>
    <div class="col-md-3">
        <label for="validationCustom04" class="form-label">Provincia</label>
        <asp:DropDownList id="Provincia" cssClass="form-label" runat="server"/>
        <div class="invalid-feedback">
            Seleccione una Provincia válida.
        </div>
    </div>
    <div class="col-md-3">
        <label for="validationCustom05" class="form-label">Código Postal</label>
        <asp:TextBox cssClass="form-control" id="txtCopPostal" runat="server"></asp:TextBox>
        <div class="invalid-feedback">
            Por favor use un código postal válido.
        </div>
    </div>
    <div class="col-12">
        <div class="form-check">
            <asp:CheckBox cssClass="form-check-label" id="chkTerminosCondiciones" runat="server"/>
            <label class="form-check-label" for="invalidCheck">
                Acepto términos y condiciones
            </label>
            <div class="invalid-feedback">
                Debe aceptar antes de continuar.
            </div>
        </div>
    </div>
    <div class="col-12">
        <asp:Button cssClass="btn btn-primary" runat="server" Text="Enviar" id="btnATerminosCondiciones"/>
    </div>


</asp:Content>
