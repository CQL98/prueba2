Imports CapaEntidad
Imports CapaNegocio
Public Class DetalleVenta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            mostrar()

            Dim oProducto As New ProductoCN
            ddlProducto.DataSource = oProducto.ListarCombo

            ddlProducto.DataTextField = "nombre"
            ddlProducto.DataValueField = "num_detalle"
            ddlProducto.DataBind()
        End If
    End Sub

    Protected Sub btnCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnCrearNuevo.Click

    End Sub

    Public Sub mostrar()

        Dim oProducto As New ProductoCN
        GridView1.DataSource = oProducto.ListarTodos
        GridView1.DataBind()
    End Sub
End Class