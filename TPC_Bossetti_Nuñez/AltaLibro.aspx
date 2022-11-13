<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AltaLibro.aspx.cs" Inherits="TPC_Bossetti_Nuñez.AltaLibro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <div class="text-center">
        <h2>Agregar Nuevo Libro</h2>
        <br />
    </div>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtID" class="form-label">ID: </label>
                <asp:TextBox runat="server" ID="txtID" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtTitulo" class="form-label">Título: </label>
                <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion: </label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" />
            </div>
            <div class="mb-3">
                <label for="txtAutor" class="form-label">Autor: </label>
                <asp:TextBox runat="server" ID="txtAutor" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtEditorial" class="form-label">Editorial: </label>
                <asp:TextBox runat="server" ID="txtEditorial" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="ddlGenero" class="form-label">Genero: </label>
                <asp:DropDownList runat="server" ID="ddlGenero" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio $: </label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" runat="server" ID="btnAceptarAlta" CssClass="btn btn-primary" OnClick="btnAceptarAlta_Click" />
                <a href="PrincipalAdmin.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>
            </div>
            <div class="mb-3">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                        <div class="mb-3">
                            <%if (ConfirmaEliminacion)
                                {%>
                            <asp:CheckBox Text="¿Confirma Eliminacion?" runat="server" ID="chkConfirma" />
                            <asp:Button Text="Confirmar" runat="server" ID="ConfirmarEliminacion" CssClass=" btn btn-danger" OnClick="ConfirmaEliminacion_Click" />
                            <%} %>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
        </div>

        <div class="col-6">
            <div class="mb-3">
                <label for="txtStock" class="form-label">Stock: </label>
                <asp:TextBox runat="server" ID="txtStock" CssClass="form-control" />
            </div>
            <asp:UpdatePanel ID="UpdatePanelPortada" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtPortadaURL" class="form-label">URL Portada: </label>
                        <asp:TextBox runat="server" ID="txtPortadaURL" CssClass="form-control"
                            AutoPostBack="true" OnTextChanged="txtPortadaURL_TextChanged" />
                    </div>
                    <asp:Image ImageUrl="https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc="
                        runat="server" ID="imgPortada" Width="60%" Style="margin-left: 110px" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

    </div>
</asp:Content>
