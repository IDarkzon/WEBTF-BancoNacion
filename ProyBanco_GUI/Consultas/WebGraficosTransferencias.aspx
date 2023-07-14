<%@ Page Title="Transferencias Info" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="WebGraficosTransferencias.aspx.cs" Inherits="ProyBanco_GUI.Consultas.WebGraficosTransacciones" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
        width: 482px;
    }
        .auto-style3 {
            width: 85%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <h3>Consulta Información General de Transferencias</h3>
            <br />
            <table cellpadding="0" cellspacing="0" class="auto-style3 centrarTabla">
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="grvTransferenciasInfo" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Width="385px">
                        <Columns>
                            <asp:BoundField DataField="Mes" HeaderText="Mes" >
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="N° Transferencias" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Monto" DataFormatString="{0:n}" HeaderText="Total (S/.)" >
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
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
                        <br />
                    </td>
                </tr>
                <tr class="centrar">
                    <td class="auto-style2">
                        <asp:Chart ID="grafCantidad" runat="server" Width="450px" Palette="Fire">
                            <series>
                                <asp:Series Name="Series1">
                                </asp:Series>
                            </series>
                            <chartareas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </chartareas>
                            <Titles>
                                <asp:Title Name="Title1" Text="Cantidad Total de Transferencias por Mes">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                    </td>
                    <td>
                        <asp:Chart ID="grafMonto" runat="server" Palette="Fire" Width="450px">
                            <series>
                                <asp:Series Name="Series1" ChartType="Line">
                                </asp:Series>
                            </series>
                            <chartareas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </chartareas>
                            <Titles>
                                <asp:Title Name="Title1" Text="Monto Total de Transferencias por Mes">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                    </td>
                </tr>
            </table>
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
