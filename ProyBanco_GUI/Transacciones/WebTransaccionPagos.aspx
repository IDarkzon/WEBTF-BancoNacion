<%@ Page Title="" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="WebTransaccionPagos.aspx.cs" Inherits="ProyBanco_GUI.Consultas.WebTransaccionPagos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style17 {
            width: 131px;
        }
        .auto-style32 {
            width: 148px;
        }
        .auto-style34 {
            width: 5px;
        }
        .auto-style35 {
            height: 19px;
        }
        .auto-style38 {
            width: 131px;
            height: 19px;
        }
        .auto-style41 {
            height: 27px;
        }
        .auto-style44 {
            width: 80%
        }
        .auto-style49 {
            width: 148px;
            height: 38px;
        }
        .auto-style50 {
            width: 5px;
            height: 38px;
        }
        .auto-style52 {
            width: 131px;
            height: 38px;
        }
        .fecha {
            cursor: pointer;
        }
        .auto-style53 {
            width: 118px;
            height: 38px;
        }
        .auto-style54 {
            width: 118px;
        }
        .auto-style55 {
            width: 118px;
            height: 19px;
        }
        .auto-style57 {
            width: 148px;
            height: 19px;
        }
        .auto-style58 {
            width: 5px;
            height: 19px;
        }
        .auto-style59 {
            width: 178px;
            height: 38px;
        }
        .auto-style60 {
            width: 178px;
            height: 19px;
        }
        .auto-style61 {
            width: 178px;
        }
        .auto-style62 {
            width: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <h3>Registrar Pago</h3>
            <br />
            <table cellpadding="0" cellspacing="0" class="auto-style44" id="InfoCliente">
                <tr>
                    <td class="auto-style59">Documento del Cliente:</td>
                    <td class="auto-style49">
                        <asp:TextBox ID="txtDocCli" runat="server" CssClass="inputRO" Width="122px" MaxLength="8"></asp:TextBox>
                        <asp:ImageButton ID="imgBuscar" runat="server" Height="17px" ImageUrl="~/Images/lupa.png" OnClick="imgBuscar_Click" Width="17px" />
                    </td>
                    <td class="auto-style50">&nbsp;</td>
                    <td class="auto-style53">&nbsp;</td>
                    <td class="auto-style52">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style59">Ingrese Código de Prestamo:</td>
                    <td class="auto-style49">
                        <asp:DropDownList ID="cboPrestamo" runat="server" Width="122px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style50"></td>
                    <td class="auto-style53">Activo:</td>
                    <td class="auto-style52">
                        <asp:CheckBox ID="chkActivo" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style59">Monto:</td>
                    <td class="auto-style49">
                        <asp:TextBox ID="txtMonto" runat="server" Width="122px" CssClass="inputRO Inumber" TextMode="Number"></asp:TextBox>
                    </td>
                    <td class="auto-style50"></td>
                    <td class="auto-style53">Num. de Cuotas:</td>
                    <td class="auto-style52">
                        <asp:DropDownList ID="cboCuotas" runat="server" Width="125px">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style59">Fecha Real:</td>
                    <td class="auto-style49">
                        <asp:TextBox ID="txtFecReal" runat="server" Width="122px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtFecReal_CalendarExtender" runat="server" BehaviorID="txtFecReal_CalendarExtender" TargetControlID="txtFecReal" />
                    </td>
                    <td class="auto-style50"></td>
                    <td class="auto-style53">Fecha Programada:</td>
                    <td class="auto-style52">
                        <asp:TextBox ID="txtFecProgramada" runat="server" Width="122px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtFecProgramada_CalendarExtender" runat="server" BehaviorID="txtFecProgramada_CalendarExtender" TargetControlID="txtFecProgramada" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style60"></td>
                    <td class="auto-style57">
                        </td>
                    <td class="auto-style58"></td>
                    <td class="auto-style55"></td>
                    <td class="auto-style38">
                        </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style35">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
                    </td>
                    <td class="auto-style55"></td>
                    <td class="auto-style38"></td>
                </tr>
                <tr>
                    <td class="auto-style41 centrar" colspan="5">
                        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                        </td>
                </tr>
                <tr>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style32">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                    <td class="auto-style54">&nbsp;</td>
                    <td class="auto-style17">&nbsp;</td>
                </tr>
            </table>
            <asp:LinkButton runat="server" ID="lnkMensaje"></asp:LinkButton>
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" BackgroundCssClass="FondoAplicacion" BehaviorID="PopMensaje" OkControlID="btnAceptar" PopupControlID="pnlMensaje" TargetControlID="lnkMensaje">
            </ajaxToolkit:ModalPopupExtender>
            <asp:Panel ID="pnlMensaje" runat="server">
                <table cellpadding="0" cellspacing="0" class="auto-style19 panel">
                    <tr class="cabPopUp">
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style26 centrar">Mensaje</td>
                        <td class="centrar">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/inactivo.png" />
                        </td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Label ID="lblMensajePopup" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </section>
</asp:Content>
