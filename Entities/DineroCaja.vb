Public Class DineroCaja

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
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

    Private pDineroInicial As Single
    Public Property DineroIncial() As Single
        Get
            Return pDineroInicial
        End Get
        Set(ByVal value As Single)
            pDineroInicial = value
        End Set
    End Property

    Private pDineroFinal As Single
    Public Property DineroFinal() As Single
        Get
            Return pDineroFinal
        End Get
        Set(ByVal value As Single)
            pDineroFinal = value
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

End Class
