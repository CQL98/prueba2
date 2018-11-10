Public Class Conexion
    Private Shared ReadOnly _instancia As New Conexion
    Private Sub New()

    End Sub
    Public Shared ReadOnly Property Instancia() As Conexion
        Get
            Return _instancia
        End Get
    End Property
    Public Function cadenaconexion() As String
        Return "Data Source=.;Initial Catalog=PLANTILLA;Integrated Security=True"
    End Function

End Class
