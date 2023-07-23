<%@ Page Title="" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ProyBanco_GUI.Seguridad.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 104px;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            width: 31%
        }
        .auto-style4 {
            width: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <h3>Creación de Usuarios</h3>
            <br />
            <asp:Image ID="ImgUsuario" runat="server" CssClass="rounded mx-auto d-block" ImageUrl="~/Images/AddUser.png" />
            <br />
            <table cellpadding="0" cellspacing="0" class="auto-style3" id="InfoCliente">
                <tr>
                    <td class="auto-style1">ID Usuario:</td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="inputRO" Width="130px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Contraseña:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="inputRO" Width="130px" MaxLength="8" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="inputRO" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Roles:</td>
                    <td>
                        <asp:DropDownList ID="cboRoles" runat="server" Width="130px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2 centrar" colspan="2">
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
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style26 centrar">Mensaje</td>
                        <td class="centrar">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/inactivo.png" />
                        </td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Label ID="lblMensajePopup" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </section>
</asp:Content>
