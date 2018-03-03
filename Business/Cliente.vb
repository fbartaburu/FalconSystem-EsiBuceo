Public Class Cliente

    Function GetClientByCI(ByVal ci As Integer) As Entities.Cliente
        Dim daCliente As New DataAccess.Cliente

        Return daCliente.Datos(ci)
    End Function

    Function Nuevo(ByVal cliente As Entities.Cliente) As Boolean
        Dim daCliente As New DataAccess.Cliente

        Return daCliente.Nuevo(cliente)
    End Function

    Function CambiarPin(ByVal cliente As Entities.Cliente) As Boolean
        Dim daCliente As New DataAccess.Cliente

        Return daCliente.CambiarPin(cliente)
    End Function

    Function Actualizar(ByVal cliente As Entities.Cliente) As Boolean
        Dim daCliente As New DataAccess.Cliente

        Return daCliente.Actualizar(cliente)
    End Function

End Class
