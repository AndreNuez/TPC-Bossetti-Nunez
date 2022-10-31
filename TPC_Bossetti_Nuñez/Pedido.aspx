<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvPedidos" runat="server" OnSelectedIndexChanged="dgvPedidos_SelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Id Venta" DataField="IDVenta" />
            <asp:BoundField HeaderText="Id Cliente" DataField="FormaPago" />
            <asp:BoundField HeaderText="Cant. Productos" DataField="Fecha" />
            <asp:BoundField HeaderText="$ Total Platita" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Editar" />
        </Columns>
    </asp:GridView>

</asp:Content>
