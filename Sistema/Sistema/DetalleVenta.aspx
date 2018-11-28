<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaestra/Plantilla.Master" CodeBehind="DetalleVenta.aspx.vb" Inherits="Sistema.DetalleVenta" %>
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
              <h3 class="box-title">VENTA</h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip"
                        title="Collapse">
                  <i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove" data-toggle="tooltip" title="Remove">
                  <i class="fa fa-times"></i></button>
                  <asp:Button ID="Button2" runat="server" Text="Button" />
              </div>
            </div>
            <div class="box-body">
                <section >
                    <div>
                        CREAR NUEVO VENTA
                    </div>
                    <div>   
                        <asp:Label ID="lblNombreCliente" runat="server" Text="Label">NOMBRE CLIENTE: </asp:Label>
                        <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
                    </div>
                    <div>   
                        <asp:Label ID="lblApellidoCliente" runat="server" Text="Label">APELLIDOS CLIENTE: </asp:Label>
                        <asp:TextBox ID="txtbApellidoCliente" runat="server"></asp:TextBox>
                    </div>

                     <div>   
                         <asp:Label ID="lblProducto" runat="server" Text="Label">PRODUCTO: </asp:Label>
                        <asp:DropDownList ID="ddlProducto" runat="server"></asp:DropDownList>
                    </div>

                    <div>   
                        <asp:Label ID="lblCantidad" runat="server" Text="Label">CANTIDAD: </asp:Label>
                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                    </div>
                    <div>   
                        <asp:Label ID="lblPrecio" runat="server" Text="Label">PRECIO: </asp:Label>
                        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                    </div>
                   
                    <div>   
                        <asp:Button ID="btnCrearNuevo" runat="server" Text="Agregar Producto" />
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
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="id_producto" HeaderText="ID" />
                                <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                                <asp:BoundField DataField="precio" HeaderText="PRECIO" />
                                <asp:BoundField DataField="cantidad" HeaderText="STOCK" />
                                <asp:BoundField DataField="id_categoria" HeaderText="CATEGORIA" />
                                <asp:TemplateField HeaderText="ACCIONES">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="editar" runat="server" CommandArgument='<%# Eval("id_producto") %>' Height="74px" ImageUrl="~/imagenes/editar.png" Width="71px" CommandName="Editar"/>
                                        <asp:ImageButton ID="eliminar" runat="server" CommandArgument='<%# Eval("id_producto") %>' Height="70px" ImageUrl="~/imagenes/ELIMINAR.png" Width="72px" CommandName="Eliminar" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </section>


                

            </div>
            <!-- /.box-body -->
            <div class="box-footer">
              Footer
            </div>
            <!-- /.box-footer-->
          </div>
          <!-- /.box GridView1 -->



        </section>

<div id="myModal" class="modal fade"  tabindex="-1" role="dialog" data-backdrop="static" data-keyboard="false">
  <div class="modal-dialog">
    
            <div class="modal-content">
                  <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;span></button>
                    <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                  </div>
                  <div class="modal-body">
                       <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <asp:Label ID="Label7" runat="server" Text="Codigo"></asp:Label>
                                        <asp:TextBox ID="Txtcodigo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label8" runat="server" Text="Descripcion"></asp:Label>
                                        <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lblPrecioM" runat="server" Text="Precio"></asp:Label>
                                        <asp:TextBox ID="TxtPrecioM" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="Label10" runat="server" Text="Cantidad"></asp:Label>
                                        <asp:TextBox ID="TxtcantidadM" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                      </div>
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>        
                    <asp:Button ID="BtnGuardar" cssClass="btn btn-primary" runat="server" Text="Guardar" />
                  </div>
            </div>
      
  </div>
</div>
<!-- jQuery 3 -->
<script src="../../bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->

<script src="../../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
</asp:Content>
