Imports CapaEntidad
Imports CapaDatos

Public Class ClienteCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New ClienteCN
    Public Shared ReadOnly Property Instancia() As ClienteCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Cliente)
        Return ClienteDA.Instancia.ListarTodos
    End Function
    Public Function Insertar(ByVal cliente As Cliente) As Boolean
        Return ClienteDA.Instancia.Agregar(cliente)
    End Function
    Public Function Editar(ByVal cliente As Cliente) As Boolean
        Return ClienteDA.Instancia.Editar(cliente)
    End Function
    Public Function Eliminar(ByVal codcliente As String) As Boolean
        Return ClienteDA.Instancia.Eliminar(codcliente)
    End Function
    Public Function Buscar_x_codigo(ByVal entrada As String) As DataSet
        Return ClienteDA.Instancia.Buscar_x_Nombre(entrada)
    End Function

End Class
