<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminClientes.aspx.cs" Inherits="TPC_Bossetti_Nuñez.AdminClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvClientesAdmin" runat="server" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Id Clientes" DataField="IdCliente" />
            <asp:BoundField HeaderText="Mail" DataField="Mail" />
            <asp:BoundField HeaderText="Nombres" DataField="Nombres" />
            <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" />
            <asp:CheckBoxField HeaderText="Activo"/>
        </Columns>
    </asp:GridView>


</asp:Content>
