Public Class Empleado : Inherits Persona

    Private pUsuario As String
    Public Property Usuario() As String
        Get
            Return pUsuario
        End Get
        Set(ByVal value As String)
            pUsuario = value
        End Set
    End Property

    Private pCargo As Integer
    Public Property Cargo() As Integer
        Get
            Return pCargo
        End Get
        Set(ByVal value As Integer)
            pCargo = value
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
