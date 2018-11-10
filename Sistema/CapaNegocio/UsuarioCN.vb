Imports CapaEntidad
Imports CapaDatos

Public Class UsuarioCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New UsuarioCN
    Public Shared ReadOnly Property Instancia() As UsuarioCN
        Get
            Return _instancia
        End Get
    End Property

    Public Function Verificar(ByVal usuario As Usuario) As Boolean
        Return UsuarioDA.Instancia.verificar(usuario)
    End Function



End Class
