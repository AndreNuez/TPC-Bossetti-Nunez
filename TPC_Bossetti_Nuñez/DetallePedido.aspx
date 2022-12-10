<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="TPC_Bossetti_Nuñez.DetallePedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3 runat="server" id="idventa">Detalle Pedido #IDVenta</h3>
        <div class="row">
            <div class="col-6">
                <br />
                <h5>Información general</h5>
                <%--<%if (Negocio.Seguridad.esAdmin(Session["usuario"]) = Dominio.TipoUsuario.ADMIN)
                    { %>
                <div>
                    <label for="lblCliente" class="form-label" style="margin-top: 10px">Cliente:</label>
                    <asp:Label Text="" runat="server" ID="lblCliente" />
                </div>
                <%} %>--%>
                <div>
                    <label for="lblFechaPedido" class="form-label" style="margin-top: 10px">Realizado el:</label>
                    <asp:Label Text="" ID="lblFechaPedido" runat="server" />
                </div>
                <div>
                    <label for="lblCantidad" class="form-label">Cantidad de Productos:</label>
                    <asp:Label Text="" ID="lblCantidad" runat="server" />
                </div>
                <div>
                    <label for="lblFormaPago" class="form-label">Forma de Pago:</label>
                    <asp:Label Text="" ID="lblFormaPago" runat="server" />
                </div>
                <div>
                    <label for="lblTotal" class="form-label">Total abonado $:</label>
                    <asp:Label Text="" ID="lblTotal" runat="server" />
                </div>
            </div>

            <div class="col-6">
                <%if (Direccion)
                    {%>
                <br />
                <h5>Dirección de Envío</h5>
                <div>
                    <asp:Label CssClass="form-label" Style="margin-top: 10px" Text="" ID="lblCalle" runat="server" />
                    <asp:Label CssClass="form-label" Text="" ID="lblNumero" runat="server" />
                    <asp:Label CssClass="form-label" Text="" ID="lblPiso" runat="server" />
                    <asp:Label CssClass="form-label" Text="" ID="lblDepto" runat="server" />
                </div>
                <div>
                    <asp:Label CssClass="form-label" Text="" ID="lblLocalidad" runat="server" />
                    <asp:Label CssClass="form-label" Text="" ID="lblCP" runat="server" />
                </div>
                <div>
                    <asp:Label CssClass="form-label" Text="Provincia" ID="lblProvincia" runat="server" />
                </div>
                <br />
                <%} %>
            </div>
        </div>
        <hr />

        <div class="row">
            <div class="col-6">
                <h5>Detalle Productos</h5>
                <div>
                    <asp:GridView runat="server" ID="dgvItems" CssClass="table table-striped" DataKeyNames="IDItem" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField HeaderText="Cantidad" DataField="cantidad" />
                            <asp:BoundField HeaderText="Titulo" DataField="NombreItem" />
                            <asp:BoundField HeaderText="Importe $" DataField="precio" />
                        </Columns>
                    </asp:GridView>
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
                <br />
                <h6>Estaremos procesando tu pedido a la brevedad.</h6>
                <%}
                    else if (lblEstadoPedido.Text == "En Preparación")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 50%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">50%</div>
                </div>
                <br />
                <h6>Ya estamos preparando tu pedido.</h6>
                <%}
                    else if (lblEstadoPedido.Text == "Enviado")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 75%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">75%</div>
                </div>
                <br />
                <h6>¡Tu pedido ha sido enviado! Recibirás un correo con el número de seguimiento.</h6>
                <%}
                    else if (lblEstadoPedido.Text == "Entregado")
                    { %>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 100%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">100%</div>
                </div>
                <br />
                <h6>Desde el correo nos informan que tu pedido ha sido entregado. ¡Que disfrutes tu compra!</h6>
                <%}%>
                <div>
                    <%if (Negocio.Seguridad.esAdmin(Session["usuario"]) != Dominio.TipoUsuario.ADMIN)
                        { %>
                    <br />
                    <div>
                        <a href="Pedido.aspx" class="btn btn-secondary">Regresar</a>
                    </div>

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
                    <br />
                    <div>
                        <asp:Button Text="Regresar" runat="server" ID="btnRegresar" OnClick="btnRegresar_Click" CssClass="btn btn-secondary" />
                    </div>
                    <%} %>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
