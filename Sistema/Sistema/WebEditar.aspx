<%@ Page Title="" Language="vb"  MasterPageFile="~/PaginaMaestra/Plantilla.Master" CodeFile="WebEditar.aspx.vb" Inherits="WebEditar" AutoEventWireup="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
            width: 171px;
        }
    .auto-style3 {
        width: 107px;
    }
        .auto-style5 {
            width: 107px;
            height: 20px;
        }
        .auto-style6 {
            width: 171px;
            height: 20px;
        }
        .auto-style7 {
            height: 20px;
        }
        .auto-style8 {
            width: 107px;
            height: 16px;
        }
        .auto-style9 {
            width: 171px;
            height: 16px;
        }
        .auto-style10 {
            height: 16px;
        }
        .auto-style11 {
            width: 325px;
        }
        .auto-style12 {
            height: 16px;
            width: 325px;
        }
        .auto-style13 {
            height: 20px;
            width: 325px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">Editar Cliente cod:</td>
        <td class="auto-style11">
            <asp:Label ID="lblCodigo" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
            Nombre:</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
            Apellidos:</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9">Fecha Nacimiento</td>
        <td class="auto-style12">
            <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
        </td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style6">Direccion</td>
        <td class="auto-style13">
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style7"></td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">Email</td>
        <td class="auto-style13">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style7">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">Telefono</td>
        <td class="auto-style13">
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style7">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="btnNuevo" runat="server" Text="Editar" />
        </td>
        <td class="auto-style11">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Regresa" />
        </td>
    </tr>



</table>
&nbsp;
</asp:Content>
