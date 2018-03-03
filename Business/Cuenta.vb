Public Class Cuenta

    Function NuevaCuenta(ByVal cuenta As Entities.Cuenta, ByVal empleadoCajaId As Integer) As Boolean
        Dim daCuenta As New DataAccess.Cuenta

        Return daCuenta.NuevaCuenta(cuenta, empleadoCajaId)
    End Function

    Function ListadoCuentas(ByVal ci As Integer) As List(Of Integer)
        Dim daCuenta As New DataAccess.Cuenta

        Return daCuenta.ListadoCuentas(ci)
    End Function

    Function Datos(ByVal numeroCuenta As Integer) As Entities.Cuenta
        Dim daCuenta As New DataAccess.Cuenta

        Return daCuenta.Datos(numeroCuenta)
    End Function

    Function AccesoCuenta(ByVal numeroCuenta As Integer) As List(Of Entities.AccesoCuenta)
        Dim ret As List(Of Entities.AccesoCuenta)
        Dim daCuenta As New DataAccess.Cuenta

        ret = daCuenta.GetClientAccess(numeroCuenta)
        Dim bCliente As New Cliente
        For i = 0 To ret.Count - 1
            ret.Item(i).Clientes = bCliente.GetClientByCI(ret.Item(i).Clientes.CI)
        Next

        Return ret
    End Function

    Function GrantAccess(ByVal ci As Integer, ByVal numeroCuenta As Integer) As Boolean
        Dim daCuenta As New DataAccess.Cuenta

        Return daCuenta.GrantAccess(ci, numeroCuenta)
    End Function

    Function RevokeAccess(ByVal ci As Integer, ByVal numeroCuenta As Integer) As Boolean
        Dim daCuenta As New DataAccess.Cuenta

        Return daCuenta.RevokeAccess(ci, numeroCuenta)
    End Function

    Function Cerrar(ByVal numeroCuenta As Integer) As Boolean
        Dim daCuenta As New DataAccess.Cuenta

        Return daCuenta.Cerrar(numeroCuenta)
    End Function

End Class
