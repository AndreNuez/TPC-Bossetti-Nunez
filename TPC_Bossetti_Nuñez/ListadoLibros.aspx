<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoLibros.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ListadoLibros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h2>Listado Libros</h2>
    </div>
    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-4">
                    <div class="mb-3">
                        <asp:Label Text="Filtrar:" ID="lblFiltrar" runat="server" />
                        <asp:TextBox ID="txtFiltrar" AutoPostBack="true" CssClass="form-control" runat="server" OnTextChanged="txtFiltrar_TextChanged" />
                    </div>
                </div>
            </div>
            <asp:GridView ID="dgvListaLibros" runat="server" OnSelectedIndexChanged="dgvListaLibros_SelectedIndexChanged" CssClass="table table-hover" AutoGenerateColumns="false" DataKeyNames="ID">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="ID" />
                    <asp:BoundField HeaderText="Titulo" DataField="Titulo" />
                    <asp:BoundField HeaderText="Stock" DataField="Stock" />
                    <asp:CheckBoxField HeaderText="Estado" DataField="Estado" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Editar" />
                </Columns>
            </asp:GridView>
            <div class="row">
                <div class="col-6">
                    <div class="mb-3">
                        <a href="PrincipalAdmin.aspx">Regresar </a>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
