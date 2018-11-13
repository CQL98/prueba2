Public Class Producto
    Private _id_producto As Integer
    Private _nombre As String
    Private _precio As Decimal
    Private _stock As Integer
    Private _id_categoria As Integer

    Public Sub New(id_producto As Integer, nombre As String, precio As Decimal, stock As Integer, id_categoria As Integer)
        _id_producto = id_producto
        _nombre = nombre
        _precio = precio
        _stock = stock
        _id_categoria = id_categoria
    End Sub

    Public Property Id_producto As Integer
        Get
            Return _id_producto
        End Get
        Set(value As Integer)
            _id_producto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property

    Public Property Id_categoria As Integer
        Get
            Return _id_categoria
        End Get
        Set(value As Integer)
            _id_categoria = value
        End Set
    End Property
End Class
