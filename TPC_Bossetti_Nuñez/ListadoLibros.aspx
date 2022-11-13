<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoLibros.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ListadoLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvListaLibros" runat="server" OnSelectedIndexChanged="dgvListaLibros_SelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false" DataKeyNames="ID">
        <Columns>
            <asp:BoundField HeaderText="Id Libro" DataField="ID" />
            <asp:BoundField HeaderText="Titulo" DataField="Titulo" />
            <asp:BoundField HeaderText="Stock" DataField="Stock" />
            <asp:CheckBoxField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Editar" />
        </Columns>
    </asp:GridView>
</asp:Content>
