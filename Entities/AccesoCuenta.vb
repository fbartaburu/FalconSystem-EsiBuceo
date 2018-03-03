Public Class AccesoCuenta

    Private pClientes As Cliente
    Public Property Clientes() As Cliente
        Get
            Return pClientes
        End Get
        Set(ByVal value As Cliente)
            pClientes = value
        End Set
    End Property

    Private pPropietario As Integer
    Public Property Propietario() As Integer
        Get
            Return pPropietario
        End Get
        Set(ByVal value As Integer)
            pPropietario = value
        End Set
    End Property

    Sub New()
        Clientes = New Cliente
    End Sub

End Class
