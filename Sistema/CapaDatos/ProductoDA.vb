Imports CapaEntidad
Imports System.Data.SqlClient


Public Class ProductoDA
    Private Shared ReadOnly _instancia As New ProductoDA
    Public Shared ReadOnly Property Instancia() As ProductoDA
        Get
            Return _instancia
        End Get
    End Property

    Public Function ListarTodos() As List(Of Producto)
        Dim Coleccion As New List(Of Producto)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("pa_producto_listarTodos", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Producto(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4)))
            End While
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
    Public Function Agregar(ByVal Producto As Producto) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("pa_producto_agregar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = Producto.Nombre
            Sqlcmd.Parameters.Add("@precio", SqlDbType.Decimal, 18.2).Value = Producto.Precio
            Sqlcmd.Parameters.Add("@stock", SqlDbType.Int).Value = Producto.Stock
            Sqlcmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = Producto.Id_categoria
            Sqlcmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
End Class
