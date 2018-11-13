Imports CapaDatos
Imports CapaEntidad

Public Class CategoriaCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New CategoriaCN
    Public Shared ReadOnly Property Instancia() As CategoriaCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodas() As List(Of Categoria)
        Return CategoriaDA.Instancia.ListarTodas
    End Function

End Class