<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="TPC_Bossetti_Nuñez.DetallePedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3 runat="server" id="idventa" class="text-center">Detalle Pedido #IDVenta</h3>
        <div class="row">
            <%if (Negocio.Seguridad.esAdmin(Session["usuario"]) == Dominio.TipoUsuario.ADMIN)
                { %>
            <div class="text-center">
                <br />
                <label for="lblCliente" class="form-label" style="font-weight: bold">Cliente:</label>
                <asp:Label Text="" runat="server" ID="lblCliente" />
            </div>
            <div class="text-center">
                <label for="lblMail" class="form-label" style="font-weight: bold">Mail:</label>
                <asp:Label Text="" runat="server" ID="lblMail" />
            </div>
            <%} %>
            <br />
            <hr />
            <div class="col-6">
                <h5>Información general</h5>
                <div>
                    <label for="lblFechaPedido" class="form-label">Realizado el:</label>
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
                <h6>Dirección de Envío</h6>
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
                <h6>Ya estamos preparando tu pedido. Te avisaremos cuando esté en camino.</h6>
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
                <h6>Tu pedido ha sido entregado. ¡Que lo disfrutes!</h6>
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
                        <div>
                            <br />
                            <asp:Label CssClass="form-label" Style="font-weight:bold" Text="Estado Pedido" ID="lblEstado" runat="server" />
                        </div>
                        <asp:RadioButton Text="Pendiente" runat="server" ID="rdbPendiente" GroupName="EstadoEntrega" />
                        <asp:RadioButton Text="En Preparación" runat="server" ID="rdbEnPreparacion" GroupName="EstadoEntrega" />
                        <asp:RadioButton Text="Enviado" runat="server" ID="rdbEnviado" GroupName="EstadoEntrega" />
                        <asp:RadioButton Text="Entregado" runat="server" ID="rdbEntregado" GroupName="EstadoEntrega" />

                        <asp:TextBox runat="server" ID="txtPendiente"/>
                        <asp:TextBox runat="server" ID="txtEnPreparacion"/>
                        <asp:TextBox runat="server" ID="txtEnviado" TextMode="Date"/>
                        <asp:TextBox runat="server" ID="txtEntregado" TextMode="Date"/>
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
