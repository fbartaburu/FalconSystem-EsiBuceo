Public Class Cheque

    Private pNumero As Integer
    Public Property Numero() As Integer
        Get
            Return pNumero
        End Get
        Set(ByVal value As Integer)
            pNumero = value
        End Set
    End Property

    Private pNumeroChequera As Integer
    Public Property NumeroChequera() As Integer
        Get
            Return pNumeroChequera
        End Get
        Set(ByVal value As Integer)
            pNumeroChequera = value
        End Set
    End Property

    Private pMonedaId As Integer
    Public Property MonedaId() As Integer
        Get
            Return pMonedaId
        End Get
        Set(ByVal value As Integer)
            pMonedaId = value
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

    Private pEmision As Date
    Public Property Emision() As Date
        Get
            Return pEmision
        End Get
        Set(ByVal value As Date)
            pEmision = value
        End Set
    End Property

End Class
