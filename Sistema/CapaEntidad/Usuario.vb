Public Class Usuario
    Private _username As String
    Private _contrasena As String

    Public Property codUsername() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Public Property codContrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property

    Public Sub New(ByVal cusername As String, ByVal ccontrasena As String)
        _username = cusername
        _contrasena = ccontrasena

    End Sub


End Class
