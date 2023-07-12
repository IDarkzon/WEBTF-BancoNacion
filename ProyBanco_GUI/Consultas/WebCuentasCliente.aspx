<%@ Page Title="Cuentas por Cliente" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="WebCuentasCliente.aspx.cs" Inherits="ProyBanco_GUI.Consultas.WebCuentasCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            width: 85%;
        }
        .auto-style17 {
            width: 131px;
        }
        .auto-style19 {
            width: 52%;
        }
        .auto-style23 {
            width: 30px;
        }
        .auto-style26 {
            width: 561px;
        }
        .auto-style27 {
            width: 96px;
        }
        .auto-style28 {
            width: 140px;
        }
        .auto-style29 {
            width: 159px;
        }
        .auto-style31 {
            width: 102px;
        }
        .auto-style32 {
            width: 148px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <h3>Consulta del número de cuentas por cliente</h3>
            <br />
            <table cellpadding="0" cellspacing="0" class="auto-style14" id="InfoCliente">
                <tr>
                    <td class="auto-style31">Ingrese Código:</td>
                    <td class="auto-style32">
                        <asp:TextBox ID="txtCodigo" runat="server" MaxLength="4" Width="122px"></asp:TextBox>
                        <asp:ImageButton ID="imgBuscar" runat="server" Height="17px" ImageUrl="~/Images/lupa.png" Width="17px" OnClick="imgBuscar_Click" />
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style29">&nbsp;</td>
                    <td class="auto-style28">Estado:</td>
                    <td class="auto-style17">
                        <asp:Image ID="imgEstado" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Nombre:</td>
                    <td class="auto-style32">
                        <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" Width="122px"></asp:TextBox>
                    </td>
                    <td class="auto-style27">Apellidos:</td>
                    <td class="auto-style29">
                        <asp:TextBox ID="txtApellidos" runat="server" ReadOnly="True" Width="140px"></asp:TextBox>
                    </td>
                    <td class="auto-style28">Fecha de Nacimiento:</td>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtFecNacimiento" runat="server" ReadOnly="True" Width="110px" CssClass="centrar"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Documento:</td>
                    <td class="auto-style32">
                        <asp:TextBox ID="txtDocumento" runat="server" ReadOnly="True" Width="122px"></asp:TextBox>
                    </td>
                    <td class="auto-style27">T. Documento:</td>
                    <td class="auto-style29">
                        <asp:TextBox ID="txtTipoDocumento" runat="server" ReadOnly="True" Width="165px"></asp:TextBox>
                    </td>
                    <td class="auto-style28">Dirección:</td>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtDireccion" runat="server" ReadOnly="True" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Teléfono:</td>
                    <td class="auto-style32">
                        <asp:TextBox ID="txtTelefono" runat="server" ReadOnly="True" Width="122px"></asp:TextBox>
                    </td>
                    <td class="auto-style27">Correo:</td>
                    <td class="auto-style29">
                        <asp:TextBox ID="txtCorreo" runat="server" ReadOnly="True" Width="210px"></asp:TextBox>
                    </td>
                    <td class="auto-style28">Ubigeo:</td>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtUbigeo" runat="server" ReadOnly="True" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
                    </td>
                    <td class="auto-style29">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style17">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        &nbsp;</td>
                    <td class="auto-style32">&nbsp;</td>
                    <td colspan="2" id="celdaBTN">
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                    </td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style17">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style32">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style29">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style17">&nbsp;</td>
                </tr>
            </table>
            <asp:GridView ID="grvCuentas" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" Width="812px">
                <Columns>
                    <asp:BoundField DataField="Numero Cuenta" HeaderText="Número Cuenta" />
                    <asp:BoundField DataField="Tipo Moneda" HeaderText="Tipo Moneda" />
                    <asp:BoundField DataField="Saldo Cuenta" DataFormatString="{0:n}" HeaderText="Saldo Cuenta" />
                    <asp:BoundField DataField="Tipo Cuenta" HeaderText="Tipo Cuenta" />
                    <asp:BoundField DataField="Fecha Apertura" DataFormatString="{0:d}" HeaderText="Fecha Apertura" />
                    <asp:BoundField DataField="Estado Cuenta" HeaderText="Estado Cuenta" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:LinkButton runat="server" ID="lnkMensaje"></asp:LinkButton>
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" BackgroundCssClass="FondoAplicacion" BehaviorID="PopMensaje" OkControlID="btnAceptar" PopupControlID="pnlMensaje" TargetControlID="lnkMensaje">
            </ajaxToolkit:ModalPopupExtender>
            <asp:Panel ID="pnlMensaje" runat="server">
                <table cellpadding="0" cellspacing="0" class="auto-style19 panel">
                    <tr class="cabPopUp">
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style26 centrar">Mensaje</td>
                        <td class="centrar">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/inactivo.png" />
                        </td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Label ID="lblMensajePopup" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style26 centrar">
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr class="bodPopUp">
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </section>
</asp:Content>
