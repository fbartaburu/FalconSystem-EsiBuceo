Public Class Moneda

    Private pId As Integer
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property

    Private pNombre As String
    Public Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
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

    Private pListaAntiguosValores As List(Of ValoresMoneda)
    Public Property ListaAntiguosValores() As List(Of ValoresMoneda)
        Get
            Return pListaAntiguosValores
        End Get
        Set(ByVal value As List(Of ValoresMoneda))
            pListaAntiguosValores = value
        End Set
    End Property

    Sub New()
        ListaAntiguosValores = New List(Of ValoresMoneda)
    End Sub

End Class
