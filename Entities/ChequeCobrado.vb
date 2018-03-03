Public Class ChequeCobrado : Inherits Cheque

    Private pFechaCobro As DateTime
    Public Property FechaCobro() As DateTime
        Get
            Return pFechaCobro
        End Get
        Set(ByVal value As DateTime)
            pFechaCobro = value
        End Set
    End Property

End Class
