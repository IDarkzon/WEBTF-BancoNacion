<%@ Page Title="Creación de Roles" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="ProyBanco_GUI.Seguridad.Roles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 572px;
        }
        .auto-style5 {
            width: 572px;
            height: 19px;
        }
        .auto-style6 {
            width: 22%
        }
        .auto-style7 {
            width: 1409px;
        }
        .auto-style8 {
            width: 1409px;
            height: 19px;
        }
        .auto-style9 {
            width: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <h3>Creación de Roles</h3>
            <br />
            <asp:Image ID="ImgRol" runat="server" CssClass="rounded mx-auto d-block" ImageUrl="~/Images/Task.png" />
            <br />
            <table cellpadding="0" cellspacing="0" class="auto-style6" id="InfoCliente">
                <tr>
                    <td class="auto-style7">Ingresar Rol:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtRol" runat="server" CssClass="inputRO" Width="124px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Roles:</td>
                    <td class="auto-style5">
                        <asp:ListBox ID="lstRoles" runat="server" Width="124px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" class="centrar">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </td>
                </tr>
            </table>
            <asp:LinkButton runat="server" ID="lnkMensaje"></asp:LinkButton>
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" BackgroundCssClass="FondoAplicacion" BehaviorID="PopMensaje" OkControlID="btnAceptar" PopupControlID="pnlMensaje" TargetControlID="lnkMensaje">
            </ajaxToolkit:ModalPopupExtender>
            <asp:Panel ID="pnlMensaje" runat="server">
                <table cellpadding="0" cellspacing="0" class="auto-style19 panel">
                    <tr class="cabPopUp">
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style26 centrar">Mensaje</td>
                        <td class="centrar">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/inactivo.png" />
                        </td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Label ID="lblMensajePopup" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </section>
</asp:Content>
