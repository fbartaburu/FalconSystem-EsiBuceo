Public Class Movimiento

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property

    Private pNumeroCuenta As Integer
    Public Property NumeroCuenta() As Integer
        Get
            Return pNumeroCuenta
        End Get
        Set(ByVal value As Integer)
            pNumeroCuenta = value
        End Set
    End Property

    Private pIdMoneda As Integer
    Public Property MonedaId() As Integer
        Get
            Return pIdMoneda
        End Get
        Set(ByVal value As Integer)
            pIdMoneda = value
        End Set
    End Property

    Private pMonto As Single
    Public Property Monto() As Single
        Get
            Return pMonto
        End Get
        Set(ByVal value As Single)
            pMonto = value
        End Set
    End Property

    Private pFecha As DateTime
    Public Property Fecha() As DateTime
        Get
            Return pFecha
        End Get
        Set(ByVal value As DateTime)
            pFecha = value
        End Set
    End Property

    Private pTipo As Integer
    Public Property Tipo() As Integer
        Get
            Return pTipo
        End Get
        Set(ByVal value As Integer)
            pTipo = value
        End Set
    End Property

End Class
