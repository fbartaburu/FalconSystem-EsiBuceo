Public Class MovimientosCaja : Inherits EmpleadoCaja


    Private pMovimientos As List(Of Movimiento)
    Public Property Movimientos() As List(Of Movimiento)
        Get
            Return pMovimientos
        End Get
        Set(ByVal value As List(Of Movimiento))
            pMovimientos = value
        End Set
    End Property


    Private pDinero As List(Of DineroCaja)
    Public Property Dinero() As List(Of DineroCaja)
        Get
            Return pDinero
        End Get
        Set(ByVal value As List(Of DineroCaja))
            pDinero = value
        End Set
    End Property


    Sub New()
        Movimientos = New List(Of Movimiento)
        Dinero = New List(Of DineroCaja)
    End Sub
End Class
