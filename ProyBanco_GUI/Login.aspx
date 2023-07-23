<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyBanco_GUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <asp:Login ID="Login1" runat="server" CssClass="auto-style1 centrarLogin" Height="276px" Width="478px" Font-Size="Large" LoginButtonText="Iniciar sesión">
                <LoginButtonStyle CssClass="btn" />
                <TextBoxStyle CssClass="inputRO" />
            </asp:Login>
        </div>
    </section>
</asp:Content>
