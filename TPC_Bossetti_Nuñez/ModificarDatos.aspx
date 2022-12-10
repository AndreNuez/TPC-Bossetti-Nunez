<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarDatos.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ModificarDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-4">
            <label for="txtNombre" class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
            <div class="valid-feedback">
                Excelente
            </div>
        </div>
        <div class="col-md-4">
            <label for="txtApellido" class="form-label">Apellido</label>
            <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
            <div class="valid-feedback">
                Perfecto
            </div>
        </div>
        <div class="row" style="margin-top: 15px">
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
                    <%--<% if (!txtPass.Enabled)
                { %>--%>
                    <asp:Button Text="Modificar contraseña" runat="server" ID="btnModificarPass" OnClick="btnModificarPass_Click" />
                    <%--            <%} %>--%>
                    <div class="invalid-feedback">
                        Por favor, elija una constraseña válida.
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4" style="margin-top: 15px">
            <label for="validationDNI" class="form-label">DNI</label>
            <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese un DNI válido.
            </div>
        </div>

        <h5 style="margin-top: 25px">Contacto</h5>
        <div class="col-md-4">
            <label for="validationCel" class="form-label">Celular</label>
            <asp:TextBox ID="txtCel" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese un Celular válido.
            </div>
        </div>

        <div class="col-md-4">
            <label for="validationTel" class="form-label">Teléfono</label>
            <asp:TextBox ID="txtTel" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese un Teléfono válido.
            </div>
        </div>

        <h5 style="margin-top: 25px">Domicilio</h5>
        <div class="col-md-3">
            <label for="validationCalle" class="form-label">Calle</label>
            <asp:TextBox ID="txtCalle" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese una ciudad válida.
            </div>
        </div>

        <div class="col-md-2">
            <label for="validationNum" class="form-label">Numero</label>
            <asp:TextBox ID="txtNum" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese una ciudad válida.
            </div>
        </div>

        <div class="col-md-2">
            <label for="validationNum" class="form-label">Piso</label>
            <asp:TextBox ID="txtPiso" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese una ciudad válida.
            </div>
        </div>

        <div class="col-md-2">
            <label for="validationDepto" class="form-label">Departamento</label>
            <asp:TextBox ID="txtDepto" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese una ciudad válida.
            </div>
        </div>
        <div class="col-md-2">
            <label for="validationCustom05" class="form-label">Código Postal</label>
            <asp:TextBox CssClass="form-control" ID="txtCopPostal" runat="server"></asp:TextBox>
            <div class="invalid-feedback">
                Por favor use un código postal válido.
            </div>
        </div>
        <div class="col-md-3">
            <label for="validationCustom03" class="form-label">Ciudad</label>
            <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Ingrese una ciudad válida.
            </div>
        </div>
        <div class="col-md-3">
            <label for="validationCustom04" class="form-label">Provincia</label>
            <asp:TextBox ID="txtProvincia" CssClass="form-control" runat="server" />
            <div class="invalid-feedback">
                Seleccione una Provincia válida.
            </div>
        </div>

        <div class="col-12">
            <br />
            <asp:Button CssClass="btn btn-primary" runat="server" Text="Enviar" ID="btnAceptar" OnClick="btnAceptar_Click" />
            <a style="margin-left:25px" class="btn btn-danger" href="Default.aspx">Cancelar</a>
        </div>
    </div>
</asp:Content>




