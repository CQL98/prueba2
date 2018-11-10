Imports CapaNegocio
Imports CapaEntidad

Public Class WebLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oUsuario As New UsuarioCN
        If oUsuario.Verificar(New Usuario(TextBox1.Text, TextBox2.Text)) Then
            Response.Redirect("WebPrincipal.aspx")
        End If


    End Sub
End Class