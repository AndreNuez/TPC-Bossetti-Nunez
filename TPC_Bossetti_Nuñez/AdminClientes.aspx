<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminClientes.aspx.cs" Inherits="TPC_Bossetti_Nuñez.AdminClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvClientesAdmin" runat="server" DataKeyNames="IdCliente"
        CssClass="table table-dark table-bordered" AutoGenerateColumns="false"
        OnSelectedIndexChanged="dgvClientesAdmin_SelectedIndexChanged"
        OnPageIndexChanging="dgvClientesAdmin_PageIndexChanging"
        AllowPaging="true" PageSize="4">
        <Columns>
            <asp:BoundField HeaderText="Id Clientes" DataField="IdCliente" />
            <asp:BoundField HeaderText="Mail" DataField="Mail" />
            <asp:BoundField HeaderText="Nombres" DataField="Nombres" />
            <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" />
            <asp:CheckBoxField HeaderText="Activo" DataField="Estado"/>
            <asp:CommandField HeaderText="Modificar Estado" ShowSelectButton="true" SelectText="X" />
        </Columns>
    </asp:GridView>


</asp:Content>
