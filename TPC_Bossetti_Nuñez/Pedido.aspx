<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h2>Mis Pedidos</h2>
    </div>
    <br />
    <asp:GridView ID="dgvPedidos" runat="server" DataKeyNames="IDVenta"
        OnSelectedIndexChanged="dgvPedidos_SelectedIndexChanged" CssClass="table table-hover"
        AutoGenerateColumns="false"
        OnPageIndexChanging="dgvPedidos_PageIndexChanging"
        AllowPaging="true" PageSize="10">
        <Columns>
            <%--<asp:BoundField HeaderText="Id Venta" DataField="IDVenta" />--%>
            <%--<asp:BoundField HeaderText="Cant. Productos" DataField="cantidad" />--%>
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="$ Total Platita" DataField="importe" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Ver Detalle" />
        </Columns>
    </asp:GridView>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <asp:Button Text="Regresar" ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" CssClass="btn btn-link" />
            </div>
        </div>
    </div>
</asp:Content>
