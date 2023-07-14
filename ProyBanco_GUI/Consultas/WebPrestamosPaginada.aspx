<%@ Page Title="Préstamos Paginada" Language="C#" MasterPageFile="~/Consulta.Master" AutoEventWireup="true" CodeBehind="WebPrestamosPaginada.aspx.cs" Inherits="ProyBanco_GUI.Consultas.WebPrestamosPaginada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <section class="espaciado">
                <div class="contenedor">
                    <h3>Consulta de préstamos</h3>
                    <br />
                    <table cellpadding="5" cellspacing="5" class="auto-style14">
                        <tr>
                            <td Width="200px">Seleccione un cliente:</td>
                            <td>
                                <asp:DropDownList ID="cboCliente" runat="server" Width="330px"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Seleccione un empleado:</td>
                            <td>
                                <asp:DropDownList ID="cboEmpleado" runat="server" Width="330px"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Seleccione el estado:</td>
                            <td>
                                <asp:DropDownList ID="cboEstado" runat="server" Width="330px" CssClass="DropDownList">
                                    <asp:ListItem Selected="True" Value="X">-- Seleccionar --</asp:ListItem>
                                    <asp:ListItem>Por Aprobar</asp:ListItem>
                                    <asp:ListItem>Aprobado</asp:ListItem>
                                    <asp:ListItem>Rechazado</asp:ListItem>
                                    <asp:ListItem>En Pago</asp:ListItem>
                                    <asp:ListItem>Cancelado</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                            </td>
                        </tr>

                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:GridView ID="grvPrestamos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" CellPadding="6" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" Width="100%" OnRowDataBound="grvPrestamos_RowDataBound" ShowHeaderWhenEmpty="True">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField HeaderText="Código" DataField="Codigo" />
                            <asp:BoundField DataFormatString="{0:n}" HeaderText="Monto" DataField="Monto">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Cuotas" DataField="Cuotas">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataFormatString="{0:d}" HeaderText="Fec. Solicitud" DataField="Fecha Solicitud">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataFormatString="{0:d}" HeaderText="Fec. Rechazo" DataField="Fecha Rechazo">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataFormatString="{0:d}" HeaderText="Fec. Cancelación" DataField="Fecha Cancelacion">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Prestamo Estudio" DataField="Prestamo Estudio" />
                            <asp:BoundField HeaderText="Compra Deuda" DataField="Compra Deuda" />
                            <asp:BoundField HeaderText="Cliente" DataField="Cliente" />
                            <asp:BoundField HeaderText="Empleado" DataField="Empleado" />
                            <asp:BoundField HeaderText="Agencia" DataField="Agencia" />
                            <asp:BoundField HeaderText="Estado" DataField="Estado Prestamo" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <br />
                    <table>
                        <tr>
                            <td>
                                <asp:DropDownList ID="cboPaginas" runat="server" Width="60px" AutoPostBack="True" CssClass="DropDownList" OnSelectedIndexChanged="cboPaginas_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                    <br />
                </div>
            </section>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="overlay">
                <div class="overlayContent">
                    <h2>Cargando...</h2>
                    <img src="../Images/loading2.gif" alt="Loading" border="0" />
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
