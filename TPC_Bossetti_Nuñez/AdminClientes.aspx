<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminClientes.aspx.cs" Inherits="TPC_Bossetti_Nuñez.AdminClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h2>Listado Clientes</h2>
    </div>
    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-4">
                    <div class="mb-3">
                        <asp:Label Text="Filtrar:" runat="server" />
                        <asp:TextBox ID="txtFiltrarClientes" AutoPostBack="true" CssClass="form-control" PlaceHolder="(Mail, Apellido)" runat="server" OnTextChanged="txtFiltrarClientes_TextChanged" />
                    </div>
                </div>
            </div>
            <asp:GridView ID="dgvClientesAdmin" runat="server" DataKeyNames="IdUsuario"
                CssClass="table table-hover" AutoGenerateColumns="false"
                OnSelectedIndexChanged="dgvClientesAdmin_SelectedIndexChanged"
                OnPageIndexChanging="dgvClientesAdmin_PageIndexChanging"
                AllowPaging="true" PageSize="9">
                <Columns>
                    <asp:BoundField HeaderText="Id Clientes" DataField="IdUsuario" />
                    <asp:BoundField HeaderText="Mail" DataField="Mail" />
                    <asp:BoundField HeaderText="Nombres" DataField="Nombres" />
                    <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" />
                    <asp:CheckBoxField HeaderText="Activo" DataField="Estado" />
                    <asp:CommandField HeaderText="Modificar Estado" ShowSelectButton="true" SelectText="X" />
                    <%--<asp:CommandField HeaderText="Ver Compras" ShowSelectButton="true" SelectText="O" />--%>
                    <%--<asp:ButtonField Buttontype="Button" Commandname="Select" Headertext="Select Customer" Text="Ver Compras" ID="btnVerCompras"/>  --%>
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="mb-3">
        <a href="PrincipalAdmin.aspx">Regresar </a>
    </div>
</asp:Content>
