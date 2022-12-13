<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="TPC_Bossetti_Nuñez.SignUp" UnobtrusiveValidationMode="None" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<script>

        function validar() {
            var Nombre = document.getElementById("<%=txtNombre.ClientID%>").value;
            var Apellido = document.getElementById("<%=txtApellido.ClientID%>").value;
            var Mail = document.getElementById("<%=txtMail.ClientID%>").value;
            var Pass = document.getElementById("<%=txtPass.ClientID%>").value;
            var valido = true;

            if (Nombre === "") {
                $("#txtNombre").removeClass("is-valid");
                $("#txtNombre").addClass("is-invalid");
                valido = false;
            }
            else {
                $("#txtNombre").removeClass("is-invalid");
                $("#txtNombre").addClass("is-valid");
            }

            if (Apellido === "") {
                $("#txtApellido").removeClass("is-valid");
                $("#txtApellido").addClass("is-invalid");
                valido = false;
            }
            else {
                $("#txtApellido").removeClass("is-invalid");
                $("#txtApellido").addClass("is-valid");
            }

            if (Mail === "") {
                $("#txtMail").removeClass("is-valid");
                $("#txtMail").addClass("is-invalid");
                valido = false;
            }
            else {
                $("#txtMail").removeClass("is-invalid");
                $("#txtMail").addClass("is-valid");
            }

            if (Pass === "") {
                $("#txtPass").removeClass("is-valid");
                $("#txtPass").addClass("is-invalid");
                valido = false;
            }
            else {
                $("#txtPass").removeClass("is-invalid");
                $("#txtPass").addClass("is-valid");
            }

            if (!valido) {
                return false;
            }
        }
    </script>--%>

    <div class="row">
        <div class="col-4"></div>
        <div class="col">
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvnombre"
                    runat="server" ControlToValidate="txtNombre"
                    ErrorMessage="Por favor, ingrese un nombre"></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                    runat="server" ControlToValidate="txtApellido"
                    ErrorMessage="Por favor, ingrese un apellido"></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <label for="txtMail" class="form-label">Mail</label>
                <asp:TextBox ID="txtMail" CssClass="form-control" runat="server" TextMode="Email" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                    runat="server" ControlToValidate="txtMail"
                    ErrorMessage="Por favor, ingrese un mail"></asp:RequiredFieldValidator>
            </div>

            <div class="mb-3">
                <label for="txtPass" class="form-label">Contraseña</label>
                <asp:TextBox ID="txtPass" CssClass="form-control" runat="server" type="password" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                    runat="server" ControlToValidate="txtPass"
                    ErrorMessage="Por favor, ingrese una contraseña"></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <asp:Button AutoPostBack="false" Text="Registrarse" runat="server" ID="btnRegistrarse" CssClass="btn btn-primary" OnClientClick="return validar()" OnClick="btnRegistrarse_Click" />
                <a href="Default.aspx" class="btn btn-danger">Cancelar</a>
            </div>
        </div>
        <div class="col-4"></div>
    </div>

</asp:Content>
