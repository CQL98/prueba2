Imports CapaEntidad
Imports System.Data.SqlClient

Public Class ClienteDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New ClienteDA
    Public Shared ReadOnly Property Instancia() As ClienteDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Cliente)
        Dim Coleccion As New List(Of Cliente)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("pa_cliente_listarTodos", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Cliente(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4), PaTable.Item(5), PaTable.Item(6)))
            End While
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
    Public Function Agregar(ByVal Cliente As Cliente) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("pa_cliente_agregar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = Cliente.apellidos
            Sqlcmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = Cliente.nombres
            Sqlcmd.Parameters.Add("@direccion", SqlDbType.VarChar, 200).Value = Cliente.direccion
            Sqlcmd.Parameters.Add("@correo", SqlDbType.Char, 50).Value = Cliente.email
            Sqlcmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = Cliente.fecha_nacimiento
            Sqlcmd.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = Cliente.telefono
            Sqlcmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Function Editar(ByVal Cliente As Cliente) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("pa_cliente_editar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@codcliente", SqlDbType.Int).Value = Cliente.codcliente
            Sqlcmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = Cliente.apellidos
            Sqlcmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = Cliente.nombres
            Sqlcmd.Parameters.Add("@direccion", SqlDbType.VarChar, 200).Value = Cliente.direccion
            Sqlcmd.Parameters.Add("@correo", SqlDbType.Char, 50).Value = Cliente.email
            Sqlcmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = Cliente.fecha_nacimiento
            Sqlcmd.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = Cliente.telefono
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
            Dim Sqlcmd As New SqlCommand("pa_cliente_eliminar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@codcliente", SqlDbType.Int).Value = codcliente
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
            Dim da As New SqlDataAdapter("pa_cliente_buscar_x_nombres", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codcliente", SqlDbType.VarChar, 50).Value = entrada
            da.Fill(ds, "clientes")
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

End Class
