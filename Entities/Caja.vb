Public Class Caja

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property

    Private pIdSucursal As Integer
    Public Property IdSucursal() As Integer
        Get
            Return pIdSucursal
        End Get
        Set(ByVal value As Integer)
            pIdSucursal = value
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

    Private pIp As String
    Public Property Ip() As String
        Get
            Return pIp
        End Get
        Set(ByVal value As String)
            pIp = value
        End Set
    End Property

End Class
