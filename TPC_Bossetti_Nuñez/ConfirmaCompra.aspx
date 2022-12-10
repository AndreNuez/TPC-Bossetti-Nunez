<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConfirmaCompra.aspx.cs" Inherits="TPC_Bossetti_Nuñez.ConfirmaCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-6">
        <br />
        <br />
        <h5>Método de Pago</h5>
        <div>
            <asp:RadioButton ID="rdbEfectivo" Text="Efectivo" runat="server" AutoPostBack="true" Checked="true" GroupName="Pago" />
            <asp:RadioButton ID="rdbMP" Text="Mercado Pago" runat="server" AutoPostBack="true" GroupName="Pago" />
        </div>
        <br />
        <h5>Método de Envío</h5>
        <div>
            <asp:RadioButton ID="rdbRetiro" Text="Retiro Sucursal" runat="server" AutoPostBack="true" Checked="true" GroupName="Envio" />
            <asp:RadioButton ID="rdbDomicilio" Text="Envío a Domicilio" runat="server" AutoPostBack="true" GroupName="Envio" />
        </div>

        <%if (rdbRetiro.Checked && rdbEfectivo.Checked || rdbMP.Checked)
            {%>
        <br />
        <p>Retira en nuestro local situado en</p>
        <p>Av. Hipólito Yrigoyen 288</p>
        <p>Gral. Pacheco, Provincia de Buenos Aires</p>
        <br />
        <%} %>

        <%if (rdbDomicilio.Checked && rdbEfectivo.Checked && Direccion)
            {%>
        <br />
        <p>Motomensajería con pago contraentrega </p>
        <p>$1500 - SOLO CABA Y AMBA</p>
        <br />
        <%} %>

        <%if (rdbDomicilio.Checked && rdbMP.Checked && !Direccion)
            {%>
        <div>
            <br />
            <h5>Por favor, registre una dirección</h5>
            <a href="ModificarDatos.aspx">Agregar Dirección</a>
        </div>
        <%} %>

        <%if (rdbDomicilio.Checked && rdbMP.Checked && Direccion)
            {%>
        <div>
            <br />
            <h5>Correo Argentino</h5>
            <p>Envío a Domicilio clásico - 3 a 6 días hábiles.</p>
            <p>$1.039,59</p>
        </div>
        <h5>Dirección de envío</h5>
        <div>
            <asp:Label ID="lblCalle" Text="" runat="server" />
            <asp:Label ID="lblNumero" Text="" runat="server" />
            <asp:Label ID="lblPiso" Text="" runat="server" />
            <asp:Label ID="lblDepto" Text="" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblLocalidad" Text="" runat="server" />
            <asp:Label ID="lblProvincia" runat="server" Text="" />
        </div>
        <div>
            <asp:Label ID="lblCP" Text="" runat="server" />
        </div>
    </div>
    <div>
        <a href="ModificarDatos.aspx">Editar Dirección</a>
    </div>
    <br />
    <br />
    <%} %>
    <asp:Button CssClass="btn btn-primary" ID="btnConfirmaCompra" runat="server" Text="Confirmar" OnClick="btnConfirmaCompra_Click" />
    <a href="Carrito.aspx" class="btn btn-danger" style="margin-left: 5px">Cancelar</a>




</asp:Content>
