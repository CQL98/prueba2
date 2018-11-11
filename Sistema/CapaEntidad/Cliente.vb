Public Class Cliente
    Private _codcliente As Integer
    Private _apellidos As String
    Private _nombres As String
    Private _direccion As String
    Private _email As String
    Private _fecha_nacimiento As Date
    Private _telefono As String
    Public Property codcliente() As Integer
        Get
            Return _codcliente
        End Get
        Set(ByVal value As Integer)
            _codcliente = value
        End Set
    End Property
    Public Property apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property
    Public Property nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Public Property fecha_nacimiento() As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(ByVal value As Date)
            _fecha_nacimiento = value
        End Set
    End Property

    Public Sub New(ByVal ccodcliente As Integer, ByVal capellidos As String,
               ByVal cnombres As String, ByVal cdireccion As String,
               ByVal cemail As String, ByVal cfecha_nacimiento As Date, ByVal ctelefono As String)
        _codcliente = ccodcliente
        _apellidos = capellidos
        _nombres = cnombres
        _direccion = cdireccion
        _email = cemail
        _fecha_nacimiento = cfecha_nacimiento
        _telefono = ctelefono
    End Sub
End Class

