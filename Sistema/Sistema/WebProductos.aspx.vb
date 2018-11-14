
Imports CapaEntidad
Imports CapaNegocio
Public Class WebProductos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        If Not IsPostBack Then
            mostrar()

            Dim oCategoria As New CategoriaCN
            ddlCategoriaProducto.DataSource = oCategoria.ListarTodas

            ddlCategoriaProducto.DataTextField = "nombre"
            ddlCategoriaProducto.DataValueField = "id_categoria"
            ddlCategoriaProducto.DataBind()
        End If
    End Sub

    Protected Sub btnCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnCrearNuevo.Click
        Dim oProducto As New ProductoCN
        oProducto.Insertar(New Producto(0, txtbNombreProducto.Text, txtbPrecioProducto.Text, txtbStockProducto.Text, ddlCategoriaProducto.SelectedValue))
        txtbNombreProducto.Text = ""
        txtbPrecioProducto.Text = ""
        txtbStockProducto.Text = ""
        Response.Redirect("WebProductos.aspx")

    End Sub

    Protected Sub ddlCategoriaProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCategoriaProducto.SelectedIndexChanged


    End Sub

    Protected Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim oProducto As New ProductoCN
        Dim descripcion As String
        descripcion = txtbBuscarProducto.Text
        GridView1.DataSource = oProducto.Buscar_x_nombre(descripcion)
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand

        If e.CommandName = "Eliminar" Then
            Dim codCliente As String
            codCliente = e.CommandArgument
            Dim oProducto As New ProductoCN
            oProducto.Eliminar(codCliente)
            Response.Redirect("WebProductos.aspx")
        End If
        If e.CommandName = "Editar" Then
            Dim codCliente As String
            codCliente = e.CommandArgument

            Dim oProducto As New ProductoCN
            Dim ds As New DataSet
            ds = oProducto.Buscar_x_codigo(codCliente)

            Label6.Text = codCliente
            TextBox1.Text = ds.Tables(0).Rows(0).Item(1)
                TextBox2.Text = ds.Tables(0).Rows(0).Item(2)
                TextBox3.Text = ds.Tables(0).Rows(0).Item(3)
            Dim oCategoria2 As New CategoriaCN
            DropDownList1.DataSource = oCategoria2.ListarTodas
            DropDownList1.DataTextField = "nombre"
            DropDownList1.DataValueField = "id_categoria"
            DropDownList1.DataBind()

        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oProducto As New ProductoCN
        oProducto.Editar(New Producto(Label6.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, DropDownList1.SelectedValue))
        Response.Redirect("WebProductos.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", True)
        Session("edicion") = False
        mostrar()

    End Sub

    Public Sub mostrar()

        Dim oProducto As New ProductoCN
        GridView1.DataSource = oProducto.ListarTodos
        GridView1.DataBind()
    End Sub
End Class