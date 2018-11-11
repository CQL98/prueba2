Imports CapaEntidad
Imports CapaNegocio

Public Class WbClientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then
            mostrar()
        End If
    End Sub

    Sub mostrar()
        Dim oCliente As New ClienteCN

        'GrdClientes.DataSource = oCliente.ListarTodos
        'GrdClientes.DataBind()
    End Sub

End Class