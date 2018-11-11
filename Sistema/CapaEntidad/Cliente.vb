Public Class Cliente
    Private _id_cliente As Integer
    Private _apellido As String
    Private _nombre As String
    Private _direccion As String
    Private _email As String
    Private _fecha_nacimiento As Date
    Private _telefono As String
    Public Property id_cliente() As Integer
        Get
            Return _id_cliente
        End Get
        Set(ByVal value As Integer)
            _id_cliente = value
        End Set
    End Property
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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

    Public Sub New(ByVal cid_cliente As Integer, ByVal capellidos As String,
               ByVal cnombres As String, ByVal cdireccion As String,
               ByVal cemail As String, ByVal cfecha_nacimiento As Date, ByVal ctelefono As String)
        _id_cliente = cid_cliente
        _apellido = capellidos
        _nombre = cnombres
        _direccion = cdireccion
        _email = cemail
        _fecha_nacimiento = cfecha_nacimiento
        _telefono = ctelefono
    End Sub
End Class

