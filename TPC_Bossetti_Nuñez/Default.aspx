<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
        </div>
        <div class="carousel-inner">
            <div class="carousel-item active" data-bs-interval="10000">
                <img height="300" src="https://www.tematika.com/media/wysiwyg/Colecciones/2020/harry2020.jpg" class="d-block w-100" alt="img1">
            </div>
            <div class="carousel-item" data-bs-interval="3000">
                <img height="300" src="https://www.tematika.com/media/wysiwyg/Colecciones/coleccion-king.jpg" class="d-block w-100" alt="img2">
            </div>
            <div class="carousel-item">
                <img height="300" src="https://www.penguinlibros.com/cl/img/cms/CHILE_Gustavo/banner_prh_tablet%20.jpg" class="d-block w-100" alt="img3">
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>
    <hr />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-6">
                    <div class="mb-3">
                        <asp:Label Text="Filtrar:" runat="server" />
                        <asp:TextBox runat="server" ID="txtFiltroRapido" CssClass="form-control" PlaceHolder="(Titulo Libro)" AutoPostBack="true" OnTextChanged="txtFiltroRapido_TextChanged" />
                    </div>
                </div>
                <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end;">
                    <div class="mb-3">
                        <asp:CheckBox Text="Filtro Avanzado"
                            CssClass="" ID="chkAvanzado" runat="server"
                            AutoPostBack="true" OnCheckedChanged="chkAvanzado_CheckedChanged"/>
                    </div>
                </div>

                <%if (chkAvanzado.Checked)
                    { %>
                <div class="row">
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Campo" ID="lblCampo" runat="server" />
                            <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged">
                                <asp:ListItem Text="Autor" />
                                <asp:ListItem Text="Editorial" />
                                <asp:ListItem Text="Precio" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Criterio" runat="server" />
                            <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Filtro" runat="server" />
                            <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Button Text="Buscar" runat="server" CssClass="btn btn-primary" ID="btnBuscar" OnClick="btnBuscar_Click" />
                        </div>
                    </div>
                </div>
                <%} %>
            </div>
            <hr />
            <div class="row row-cols-1 row-cols-md-3 g-4">
                <asp:Repeater ID="repRepetidor" runat="server">
                    <ItemTemplate>
                        <div class="col">
                            <div class="card h-100">
                                <img src="<%# Eval("PortadaURL")%>" class="card-img-top" alt="img_portada_libro" onerror="this.src='https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=';">
                                <div class="card-body">
                                    <h5 class="card-title"><%#Eval("Titulo") %></h5>
                                    <p class="card-text"><%#Eval("Autor")%></p>
                                    <h5 class="card-title"><%#Eval("Precio")%></h5>
                                    <div class="d-grid mx-auto">
                                        <asp:Button Text="Agregar al Carrito" ID="btnAgregarCarrito" CssClass="btn btn-success" runat="server" CommandArgument='' CommandName="" OnClick="btnAgregarCarrito_Click" />
                                    </div>
                                    <div class="d-grid mx-auto">
                                        <asp:Button Text="Ver Detalles" Style="margin-top: 5px" ID="btnVerDetalles" CssClass="btn btn-info" runat="server" CommandArgument='<%#Eval("ID")%>' CommandName="IDLibro" OnClick="btnVerDetalles_Click" />
                                    </div>
                                    <div class="d-grid mx-auto">
                                        <asp:Button Text="Editar" Style="margin-top: 5px" ID="btnEditar" CssClass="btn btn-secondary" runat="server" CommandArgument='<%#Eval("ID")%>' CommandName="IDLibro" OnClick="btnEditar_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
