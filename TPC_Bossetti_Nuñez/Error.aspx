<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Houston, we have a problem!</h1>
    <asp:Label Text="Error 404, ahre" runat="server" ID="lblMensaje"/>
</asp:Content>
