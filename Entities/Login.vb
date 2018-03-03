Public Class Login

    Private pUsuario As String
    Public Property Usuario() As String
        Get
            Return pUsuario
        End Get
        Set(ByVal value As String)
            pUsuario = value
        End Set
    End Property

    Private pContrasena As String
    Public Property Contrasena() As String
        Get
            Return pContrasena
        End Get
        Set(ByVal value As String)
            pContrasena = value
        End Set
    End Property

    Private pTipo As Boolean
    Public Property Tipo() As Boolean
        Get
            Return pTipo
        End Get
        Set(ByVal value As Boolean)
            pTipo = value
        End Set
    End Property

    Private Shared _thisUserSingleton As Login

    Protected Sub New()
    End Sub

    Public Shared Function GetSingleton() As Login

        If _thisUserSingleton Is Nothing Then
            _thisUserSingleton = New Login
        End If

        Return _thisUserSingleton
    End Function

End Class
