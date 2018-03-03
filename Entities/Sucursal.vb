Public Class Sucursal

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property

    Private pNombre As String
    Public Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
        End Set
    End Property

    Private pDepartamento As String
    Public Property Departamento() As String
        Get
            Return pDepartamento
        End Get
        Set(ByVal value As String)
            pDepartamento = value
        End Set
    End Property

    Private pDireccion As String
    Public Property Direccion() As String
        Get
            Return pDireccion
        End Get
        Set(ByVal value As String)
            pDireccion = value
        End Set
    End Property

End Class
