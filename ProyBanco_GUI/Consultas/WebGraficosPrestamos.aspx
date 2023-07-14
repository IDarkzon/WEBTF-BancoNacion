<%@ Page Title="Prestamos Info" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="WebGraficosPrestamos.aspx.cs" Inherits="ProyBanco_GUI.Consultas.WebGraficosPrestamos" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="espaciado">
        <div class="contenedor">
            <h3>Consulta Información General de Prestamos</h3>
            <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
            <br />
            <table class="w-100">
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="grvPrestamos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Width="385px">
                            <Columns>
                                <asp:BoundField DataField="Año" HeaderText="Año">
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="cantPrestamos" HeaderText="Nº Prestamos">
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Monto" DataFormatString="{0:n}" HeaderText="Monto Total (S/.)">
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
                <tr>
                    <td class="centrar">
                        <asp:Chart ID="grafPresTotales" runat="server" Width="430px" Palette="Fire">
                            <series>
                                <asp:Series Name="Series1">
                                </asp:Series>
                            </series>
                            <chartareas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </chartareas>
                            <Titles>
                                <asp:Title Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Title1" Text="Monto total de prestamos por Año">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                    </td>
                    <td class="centrar">
                        <asp:Chart ID="grafPresCantidades" runat="server" Width="430px" Palette="Fire">
                            <series>
                                <asp:Series Name="Series1">
                                </asp:Series>
                            </series>
                            <chartareas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </chartareas>
                            <Titles>
                                <asp:Title Font="Microsoft Sans Serif, 8pt, style=Bold" Name="Title1" Text="Cantidad de prestamos por Año">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                    </td>
                </tr>
            </table>
            <br />

        </div>
    </section>
</asp:Content>
