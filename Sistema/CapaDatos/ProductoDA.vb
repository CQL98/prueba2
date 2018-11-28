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

    Public Function Eliminar(ByVal codcliente As String) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("pa_producto_eliminar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = codcliente
            Sqlcmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Function Buscar_x_Codigo(ByVal codProducto As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("pa_producto_buscar_x_codigo", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codcliente", SqlDbType.Int).Value = Convert.ToInt32(codProducto)
            da.Fill(ds, "producto")
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Public Function Editar(ByVal Producto As Producto) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("pa_producto_editar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@codProducto", SqlDbType.Int).Value = Producto.Id_producto
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
    Public Function Buscar_x_Nombre(ByVal entrada As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("pa_producto_buscar_x_nombres", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@entrada", SqlDbType.VarChar, 50).Value = entrada
            da.Fill(ds, "producto")
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Public Function ListarTodas() As List(Of Producto)
        Dim Coleccion As New List(Of Producto)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("pa_producto_listarTodosCombo", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader
            While PaTable.Read
                Coleccion.Add(New Producto(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4)))
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
