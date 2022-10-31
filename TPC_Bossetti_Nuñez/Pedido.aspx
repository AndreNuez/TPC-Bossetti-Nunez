<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvPedidos" runat="server" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="1" DataField="IDVenta" />
            <asp:BoundField HeaderText="2" DataField="FormaPago" />
            <asp:BoundField HeaderText="3" DataField="Fecha" />
            <asp:BoundField HeaderText="4" DataField="Estado" />
        </Columns>
    </asp:GridView>

</asp:Content>
