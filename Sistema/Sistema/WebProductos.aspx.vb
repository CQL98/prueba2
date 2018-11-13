
Imports CapaEntidad
Imports CapaNegocio
Public Class WebProductos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim oProducto As New ProductoCN
            GridView1.DataSource = oProducto.ListarTodos
            GridView1.DataBind()


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
    End Sub

    Protected Sub ddlCategoriaProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCategoriaProducto.SelectedIndexChanged


    End Sub

    Protected Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click

    End Sub
End Class