<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CompraRealizada.aspx.cs" Inherits="TPC_Bossetti_Nuñez.CompraRealizada" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col text-center">
        <h3>Su pedido ha sido realizado con éxito!</h3>
    </div>
    <div class="col text-center">
        <p>Ha solicitado los siguientes artículos: </p>
        <br />
        <asp:GridView ID="dgvCarrito" runat="server" CssClass="table table-light" DataKeyNames="IDItem" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="NombreItem" />
                <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
            </Columns>
        </asp:GridView>
    </div>
    <br />

    <div class="container text-center">
        <div class="row">
            <div class="col-6">
                <div class="mb-3 col text-center">
                    <h5>Forma de Pago</h5>
                    <asp:Label Text="" runat="server" ID="lblPago" />
                </div>
            </div>

            <div class="col-6">
                <div class="mb-3 col text-center">
                    <h5>Método de envío</h5>
                    <asp:Label Text="" runat="server" ID="lblEnvio" />
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="col text-center">
        <h5>Gracias por elegirnos.</h5>
    </div>

    <div class="col text-center">
        <asp:Button Text="Regresar al catálogo" runat="server" ID="btnRegresar" OnClick="btnRegresar_Click" CssClass="btn btn-link" />
    </div>



</asp:Content>
