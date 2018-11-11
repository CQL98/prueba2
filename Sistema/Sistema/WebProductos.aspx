<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaestra/Plantilla.Master" CodeBehind="WebProductos.aspx.vb" Inherits="Sistema.WebProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <section class="content-header">
          <h1>
              Mantenedor de productos
          </h1>
          <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
            <li><a href="#">Examples</a></li>
            <li class="active">Blank page</li>
          </ol>
        </section>

     <section class="content">

          <!-- Default box -->
          <div class="box">
            <div class="box-header with-border">
              <h3 class="box-title">PRODUCTOS</h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip"
                        title="Collapse">
                  <i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove" data-toggle="tooltip" title="Remove">
                  <i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
                <section >
                    <div>
                        CREAR NUEVO PRODUCTO
                    </div>
                    <div>   
                        <asp:Label ID="lblNombreProducto" runat="server" Text="Label">NOMBRE: </asp:Label>
                        <asp:TextBox ID="txtbNombreProducto" runat="server"></asp:TextBox>
                    </div>
                    <div>   
                        <asp:Label ID="lblPrecioProducto" runat="server" Text="Label">PRECIO: </asp:Label>
                        <asp:TextBox ID="txtbPrecioProducto" runat="server"></asp:TextBox>
                    </div>
                    <div>   
                        <asp:Label ID="lblStockProducto" runat="server" Text="Label">STOCK: </asp:Label>
                        <asp:TextBox ID="txtbStockProducto" runat="server"></asp:TextBox>
                    </div>
                    <div>   
                         <asp:Label ID="lblCategoriaProducto" runat="server" Text="Label">CATEGORIA: </asp:Label>
                        <asp:DropDownList ID="ddlCategoriaProducto" runat="server"></asp:DropDownList>
                    </div>
                </section>

                <section>
                    <div>
                        LISTADO DE PRODUCTOS
                    </div>
                    <div>
                        <asp:Label ID="lblBuscarProducto" runat="server" Text="Label">BUSCAR: </asp:Label>
                        <asp:TextBox ID="txtbBuscarProducto" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscarProducto" runat="server" Text="BUSCAR" />
                    </div>
                    <div>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </div>
                </section>


            </div>
            <!-- /.box-body -->
            <div class="box-footer">
              Footer
            </div>
            <!-- /.box-footer-->
          </div>
          <!-- /.box -->

        </section>

</asp:Content>
