﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TPC_Bossetti_Nuñez.Loguin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email address</label>
                <asp:TextBox ID="txtEmail" cssClass="form-control" runat="server"/>
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" type="password" CssClass="form-control"/> 
            </div>
            <div class="mb-3">   
                <label for="InputNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"/>      
            </div>
            <div class="mb-3">
                <label for="InputApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"/>  
            </div>
            <asp:Button CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
        </div>
        <div class="col-4"></div>
    </div>

</asp:Content>
