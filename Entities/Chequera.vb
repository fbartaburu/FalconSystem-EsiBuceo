Public Class Chequera

    Private pNumero As Integer
    Public Property Numero() As Integer
        Get
            Return pNumero
        End Get
        Set(ByVal value As Integer)
            pNumero = value
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

    Private pTipo As Integer
    Public Property Tipo() As Integer
        Get
            Return pTipo
        End Get
        Set(ByVal value As Integer)
            pTipo = value
        End Set
    End Property

    Private pDiaCobroCruzado As Integer
    Public Property DiaCobroCruzado() As Integer
        Get
            Return pDiaCobroCruzado
        End Get
        Set(ByVal value As Integer)
            pDiaCobroCruzado = value
        End Set
    End Property


End Class
