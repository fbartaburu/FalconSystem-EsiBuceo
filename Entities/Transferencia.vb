Public Class Transferencia : Inherits Movimiento

    Private pNumeroCuentaDestino As Integer
    Public Property NumeroCuentaDestino() As Integer
        Get
            Return pNumeroCuentaDestino
        End Get
        Set(ByVal value As Integer)
            pNumeroCuentaDestino = value
        End Set
    End Property

End Class
