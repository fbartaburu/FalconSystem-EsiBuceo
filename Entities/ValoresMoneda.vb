Public Class ValoresMoneda

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property

    Private pIdMoneda As Integer
    Public Property IdMoneda() As Integer
        Get
            Return pIdMoneda
        End Get
        Set(ByVal value As Integer)
            pIdMoneda = value
        End Set
    End Property

    Private pIdEmpleadoCaja As Integer
    Public Property IdEmpleadoCaja() As Integer
        Get
            Return pIdEmpleadoCaja
        End Get
        Set(ByVal value As Integer)
            pIdEmpleadoCaja = value
        End Set
    End Property

    Private pValor As Single
    Public Property Valor() As Single
        Get
            Return pValor
        End Get
        Set(ByVal value As Single)
            pValor = value
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

End Class
