Imports System.Data.SqlClient
Imports CapaEntidad

Public Class UsuarioDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New UsuarioDA
    Public Shared ReadOnly Property Instancia() As UsuarioDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function verificar(ByVal usuario As Usuario) As Boolean

        Dim numero As String
        Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
        cnn.Open()
        Dim Sqlcmd As New SqlCommand("pa_verificar", cnn)
        Sqlcmd.CommandType = CommandType.StoredProcedure
        Sqlcmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = usuario.codUsername
        Sqlcmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = usuario.codContrasena
        Sqlcmd.Parameters.Add("@numero", SqlDbType.VarChar, 10)
        Sqlcmd.Parameters("@numero").Direction = ParameterDirection.Output
        Sqlcmd.ExecuteNonQuery()
        numero = Sqlcmd.Parameters("@numero").Value
        cnn.Close()
        cnn.Dispose()
        If numero = "existe" Then
            Return True
        End If
        Return False

    End Function


End Class
