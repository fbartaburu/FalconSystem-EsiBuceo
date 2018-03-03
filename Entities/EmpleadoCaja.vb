Public Class EmpleadoCaja

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property

    Private pCi As Integer
    Public Property Ci() As Integer
        Get
            Return pCi
        End Get
        Set(ByVal value As Integer)
            pCi = value
        End Set
    End Property

    Private pIdCaja As Integer
    Public Property IdCaja() As Integer
        Get
            Return pIdCaja
        End Get
        Set(ByVal value As Integer)
            pIdCaja = value
        End Set
    End Property

    Private pApertura As DateTime
    Public Property Apertura() As DateTime
        Get
            Return pApertura
        End Get
        Set(ByVal value As DateTime)
            pApertura = value
        End Set
    End Property

    Private pCierre As DateTime
    Public Property Cierre() As DateTime
        Get
            Return pCierre
        End Get
        Set(ByVal value As DateTime)
            pCierre = value
        End Set
    End Property

End Class
