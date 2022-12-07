<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="TPC_Bossetti_Nuñez.DetallePedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>Detalle Pedido #IDVenta</h3>
        <div class="row">

            <div class="col-6">
                <br />
                <h5>Información general</h5>
                <div>
                    <label for="lblFechaPedido" class="form-label" style="margin-top: 10px">Realizado el:</label>
                    <asp:Label Text="00/00/00" ID="lblFechaPedido" runat="server" />
                </div>
                <div>
                    <label for="lblCantidad" class="form-label">Cantidad de Productos:</label>
                    <asp:Label Text="Cant" ID="lblCantidad" runat="server" />
                </div>
                <div>
                    <label for="lblFormaPago" class="form-label">Forma de Pago:</label>
                    <asp:Label Text="Efectivo - Tarjeta" ID="lblFormaPago" runat="server" />
                </div>
                <div>
                    <label for="lblTotal" class="form-label">Total abonado $:</label>
                    <asp:Label Text="100.00" ID="lblTotal" runat="server" />
                </div>
            </div>

            <div class="col-6">
                <br />
                <h5>Dirección de Envío</h5>
                <div>
                    <asp:Label CssClass="form-label" Style="margin-top: 10px" Text="Calle + Altura + Piso + Depto" ID="lblDireccion1" runat="server" />
                </div>
                <div>
                    <asp:Label CssClass="form-label" Text="(CP) + Localidad" ID="lblDireccion2" runat="server" />
                </div>
                <div>
                    <asp:Label CssClass="form-label" Text="Provincia" ID="lblProvincia" runat="server" />
                </div>
                <br />
            </div>
        </div>
        <hr />

        <div class="row">
            <div class="col-6">
                <h5>Detalle Productos</h5>
                <div>
                    <asp:GridView runat="server" ID="dgvItems"></asp:GridView>
                </div>
                <br />
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-6">
                <h5>Estado</h5>
                <asp:Label Text="Pendiente" runat="server" ID="lblEstadoPedido" />
                <br />
                <%if (lblEstadoPedido.Text == "Pendiente")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 25%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">25%</div>
                </div>
                <%} else if(lblEstadoPedido.Text == "En Preparación")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 50%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">50%</div>
                </div>
                <%} else if(lblEstadoPedido.Text == "Enviado")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 75%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">75%</div>
                </div>
                <%} else if(lblEstadoPedido.Text == "Entregado")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 100%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">100%</div>
                </div>
                <%}%>
                <div>
                    <%if (Negocio.Seguridad.esAdmin(Session["usuario"]) != Dominio.TipoUsuario.ADMIN)
                        { %>
                    <a href="PrincipalCliente.aspx" class="btn btn-secondary">Regresar</a>
                    <%}
                        else
                        {%>
                    <div>
                        <asp:Label CssClass="form-label" Style="margin-top: 10px" Text="Estado Pedido" ID="lblEstado" runat="server" />
                        <asp:RadioButton Text="Pendiente" runat="server" ID="rdbPendiente" GroupName="EstadoEntrega" />
                        <asp:RadioButton Text="En Preparación" runat="server" ID="rdbEnPreparacion" GroupName="EstadoEntrega" />
                        <asp:RadioButton Text="Enviado" runat="server" ID="rdbEnviado" GroupName="EstadoEntrega" />
                        <asp:RadioButton Text="Entregado" runat="server" ID="rdbEntregado" GroupName="EstadoEntrega" />
                    </div>
                    <asp:Button Text="Regresar ADMIN" runat="server" ID="btnRegresar" OnClick="btnRegresar_Click" />
                    <%} %>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
