<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminCompras.aspx.cs" Inherits="TPC_Bossetti_Nuñez.AdminCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h2>Listado Pedidos</h2>
    </div>
    <br />
    <asp:GridView ID="dgvPedidos" runat="server" DataKeyNames="IDVenta" OnSelectedIndexChanged="dgvPedidos_SelectedIndexChanged"
        CssClass="table table-hover" AutoGenerateColumns="false"
        OnPageIndexChanging="dgvPedidos_PageIndexChanging"
        AllowPaging="true" PageSize="10">
        <Columns>
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="Cant. Productos" DataField="cantidad" />
            <asp:BoundField HeaderText="$ Total Platita" DataField="importe" />
            <asp:BoundField HeaderText="Estado" DataField="estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Ver Detalle" HeaderText="Ver Detalle" />
        </Columns>
    </asp:GridView>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <a href="PrincipalAdmin.aspx">Regresar </a>
            </div>
        </div>
    </div>

</asp:Content>
