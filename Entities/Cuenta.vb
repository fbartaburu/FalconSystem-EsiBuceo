Public Class Cuenta

    Private pNumero As Integer
    Public Property Numero() As Integer
        Get
            Return pNumero
        End Get
        Set(ByVal value As Integer)
            pNumero = value
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

    Private pSaldo As Single
    Public Property Saldo() As Single
        Get
            Return pSaldo
        End Get
        Set(ByVal value As Single)
            pSaldo = value
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

    Private pTipo As Integer
    Public Property Tipo() As Integer
        Get
            Return pTipo
        End Get
        Set(ByVal value As Integer)
            pTipo = value
        End Set
    End Property

    Private pClientes As List(Of AccesoCuenta)
    Public Property Clientes() As List(Of AccesoCuenta)
        Get
            Return pClientes
        End Get
        Set(ByVal value As List(Of AccesoCuenta))
            pClientes = value
        End Set
    End Property

    Sub New()
        Clientes = New List(Of Entities.AccesoCuenta)
    End Sub

End Class
