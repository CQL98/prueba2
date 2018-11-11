Imports CapaEntidad
Imports CapaNegocio

Public Class WbClientes
    Inherits System.Web.UI.Page
    Dim mpContentPlaceHolder As ContentPlaceHolder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mpContentPlaceHolder = CType(Master.FindControl("ContentPlaceHolder1"), ContentPlaceHolder)
        If Not mpContentPlaceHolder Is Nothing Then
            If Not IsPostBack Then
                mostrar()
            End If

        End If




    End Sub

    Sub mostrar()
        Dim oCliente As New ClienteCN
        Dim grdCliente As GridView
        grdCliente = CType(mpContentPlaceHolder.FindControl("grdCliente"), GridView)
        grdCliente.DataSource = oCliente.ListarTodos
        grdCliente.DataBind()



    End Sub

End Class