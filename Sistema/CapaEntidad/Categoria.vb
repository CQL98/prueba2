Public Class Categoria
    Private _id_categoria As Integer
    Private _nombre As String
    Private _descripcion As String

    Public Sub New(id_categoria As Integer, nombre As String, descripcion As String)
        _id_categoria = id_categoria
        _nombre = nombre
        _descripcion = descripcion
    End Sub

    Public Property Id_categoria As Integer
        Get
            Return _id_categoria
        End Get
        Set(value As Integer)
            _id_categoria = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class
