Imports CapaEntidad
Imports CapaDatos

Public Class ProductoCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New ProductoCN
    Public Shared ReadOnly Property Instancia() As ProductoCN
        Get
            Return _instancia
        End Get
    End Property

    Public Function ListarTodos() As List(Of Producto)
        Return ProductoDA.Instancia.ListarTodos
    End Function
    Public Function Insertar(ByVal Producto As Producto) As Boolean
        Return ProductoDA.Instancia.Agregar(Producto)
    End Function
    Public Function Eliminar(ByVal codcliente As String) As Boolean
        Return ProductoDA.Instancia.Eliminar(codcliente)
    End Function
    Public Function Buscar_x_codigo(ByVal codProducto As Integer) As DataSet
        Return ProductoDA.Instancia.Buscar_x_Codigo(codProducto)
    End Function
    Public Function Editar(ByVal producto As Producto) As Boolean
        Return ProductoDA.Instancia.Editar(producto)
    End Function
    Public Function Buscar_x_nombre(ByVal entrada As String) As DataSet
        Return ProductoDA.Instancia.Buscar_x_Nombre(entrada)
    End Function
    Public Function ListarCombo() As List(Of Producto)
        Return ProductoDA.Instancia.ListarTodas
    End Function
End Class
