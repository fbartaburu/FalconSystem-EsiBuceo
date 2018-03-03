Public Class Deposito : Inherits Movimiento

    Private pIsClient As Integer
    Public Property IsClient() As Integer
        Get
            Return pIsClient
        End Get
        Set(ByVal value As Integer)
            pIsClient = value
        End Set
    End Property

End Class
