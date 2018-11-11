
Imports CapaEntidad
Imports CapaNegocio
Public Class WebClientes
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
        Try
            Dim oCliente As New ClienteCN
            Dim grdCliente As GridView
            grdCliente = CType(mpContentPlaceHolder.FindControl("grdCliente"), GridView)
            grdCliente.DataSource = oCliente.ListarTodos
            grdCliente.DataBind()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub



    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub
    Protected Sub grdCliente_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grdCliente.RowCommand

    End Sub
End Class