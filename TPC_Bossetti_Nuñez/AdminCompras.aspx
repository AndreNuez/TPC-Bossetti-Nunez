<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminCompras.aspx.cs" Inherits="TPC_Bossetti_Nuñez.AdminCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:GridView ID="dgvPedidos" runat="server" DataKeyNames="IDVenta" OnSelectedIndexChanged="dgvPedidos_SelectedIndexChanged" CssClass="table table-hover" AutoGenerateColumns="false">
        <Columns>
            <%--<asp:BoundField HeaderText="Id Venta" DataField="IDVenta" />--%>
            <asp:BoundField HeaderText="Cant. Productos" DataField="cantidad" />
            <asp:BoundField HeaderText="$ Total Platita" DataField="importe" />
            <asp:CommandField ShowSelectButton="true" SelectText="Ver Detalle" HeaderText="Ver Detalle" />
        </Columns>
    </asp:GridView>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <a href="PrincipalAdmin.aspx"> Regresar </a>
            </div>
        </div>
    </div>

</asp:Content>
