<%@ Page Title="" Language="vb"  MasterPageFile="~/PaginaMaestra/Plantilla.Master" CodeFile="WebClientes.aspx.vb" Inherits="WebClientes" AutoEventWireup="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
            width: 880px;
        }
    .auto-style3 {
            width: 57px;
        }
        .auto-style4 {
            margin-right: 245px;
        }
        .auto-style5 {
            width: 57px;
            height: 20px;
        }
        .auto-style6 {
            width: 880px;
            height: 20px;
        }
        .auto-style7 {
            height: 20px;
        }
        .auto-style8 {
            width: 72px;
        }
        .auto-style9 {
            height: 20px;
            width: 72px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">Mantenedor de Clientes</td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Buscar por Descripcion"></asp:Label>
            <asp:TextBox ID="txtBuscar" runat="server" Width="202px"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Button" />
        </td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
            <asp:GridView ID="grdCliente" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" CssClass="auto-style4" Width="930px">
                <Columns>
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("id_cliente") %>' Height="74px" ImageUrl="~/imagenes/editar.png"  Width="58px" CommandName="Editar"  />
                            <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("id_cliente") %>' Height="53px" ImageUrl="~/imagenes/ELIMINAR.png" Width="56px" CommandName="Eliminar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id_cliente" HeaderText="Codigo" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="fecha_nacimiento" HeaderText="FechaNac" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
        </td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style6"></td>
        <td class="auto-style9"></td>
        <td class="auto-style7"></td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
        </td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>



</table>
&nbsp;
</asp:Content>
