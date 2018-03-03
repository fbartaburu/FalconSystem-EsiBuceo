Public Class Persona

    Private pCI As Integer
    Public Property CI() As Integer
        Get
            Return pCI
        End Get
        Set(ByVal value As Integer)
            pCI = value
        End Set
    End Property

    Private pNombre1 As String
    Public Property Nombre1() As String
        Get
            Return pNombre1
        End Get
        Set(ByVal value As String)
            pNombre1 = value
        End Set
    End Property

    Private pNombre2 As String
    Public Property Nombre2() As String
        Get
            Return pNombre2
        End Get
        Set(ByVal value As String)
            pNombre2 = value
        End Set
    End Property

    Private pApellido1 As String
    Public Property Apellido1() As String
        Get
            Return pApellido1
        End Get
        Set(ByVal value As String)
            pApellido1 = value
        End Set
    End Property

    Private pApellido2 As String
    Public Property Apellido2() As String
        Get
            Return pApellido2
        End Get
        Set(ByVal value As String)
            pApellido2 = value
        End Set
    End Property

    Private pFechaNaciemiento As Date
    Public Property FechaNacimiento() As Date
        Get
            Return pFechaNaciemiento
        End Get
        Set(ByVal value As Date)
            pFechaNaciemiento = value
        End Set
    End Property

    Private pEstadoCivil As String
    Public Property EstadoCivil() As String
        Get
            Return pEstadoCivil
        End Get
        Set(ByVal value As String)
            pEstadoCivil = value
        End Set
    End Property

    Private pNacionalidad As String
    Public Property Nacionalidad() As String
        Get
            Return pNacionalidad
        End Get
        Set(ByVal value As String)
            pNacionalidad = value
        End Set
    End Property

    Private pDireccion As String
    Public Property Direccion() As String
        Get
            Return pDireccion
        End Get
        Set(ByVal value As String)
            pDireccion = value
        End Set
    End Property

    Private pEmail As String
    Public Property Email() As String
        Get
            Return pEmail
        End Get
        Set(ByVal value As String)
            pEmail = value
        End Set
    End Property

    Private pTelefono1 As String
    Public Property Telefono1() As String
        Get
            Return pTelefono1
        End Get
        Set(ByVal value As String)
            pTelefono1 = value
        End Set
    End Property

    Private pTelefono2 As String
    Public Property Telefono2() As String
        Get
            Return pTelefono2
        End Get
        Set(ByVal value As String)
            pTelefono2 = value
        End Set
    End Property

End Class
