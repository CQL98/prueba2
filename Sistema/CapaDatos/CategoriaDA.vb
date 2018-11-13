Imports CapaEntidad
Imports System.Data.SqlClient
Public Class CategoriaDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New CategoriaDA
    Public Shared ReadOnly Property Instancia() As CategoriaDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodas() As List(Of Categoria)
        Dim Coleccion As New List(Of Categoria)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("pa_categoria_listarTodos", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader
            While PaTable.Read
                Coleccion.Add(New Categoria(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2)))
            End While
            cnn.Close()
            cnn.Dispose()
            sqlcmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function

End Class
