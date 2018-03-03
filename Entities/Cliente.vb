Public Class Cliente : Inherits Persona

    Private pPin As String
    Public Property Pin() As String
        Get
            Return pPin
        End Get
        Set(ByVal value As String)
            pPin = value
        End Set
    End Property

    Private pEstado As Boolean
    Public Property Estado() As Boolean
        Get
            Return pEstado
        End Get
        Set(ByVal value As Boolean)
            pEstado = value
        End Set
    End Property

End Class
