Public Class Movimiento

    Function Movimientos(ByVal numeroCuenta As Integer) As List(Of Entities.Movimiento)
        Dim ret As New List(Of Entities.Movimiento)
        Dim daMovimiento As New DataAccess.Movimiento

        ret = daMovimiento.GetDepositByAccountId(numeroCuenta)
        ret.AddRange(daMovimiento.GetWithdrawByAccountId(numeroCuenta))
        ret.AddRange(daMovimiento.GetTransferByAccountId(numeroCuenta))

        Return ret
    End Function

    Function Deposito(ByVal movimiento As Entities.Deposito, ByVal empleadoCajaId As Integer) As Boolean
        movimiento.Fecha = DateTime.Now

        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.Deposito(movimiento, empleadoCajaId)
    End Function

    Function Retiro(ByVal movimiento As Entities.Movimiento, ByVal empleadoCajaId As Integer) As Boolean
        movimiento.Fecha = DateTime.Now

        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.Retiro(movimiento, empleadoCajaId)
    End Function

    Function Transferencia(ByVal movimiento As Entities.Transferencia, ByVal empleadoCajaId As Integer) As Boolean
        movimiento.Fecha = DateTime.Now

        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.Transferencia(movimiento, empleadoCajaId)
    End Function

    Function MovimientosPorCaja(ByVal empleadoCajaId As Integer) As Entities.MovimientosCaja
        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.GetMovementsByWorkstation(empleadoCajaId)
    End Function

    Function RetiroCliente(ByVal movimiento As Entities.Movimiento, ByVal ci As Integer) As Boolean
        movimiento.Fecha = DateTime.Now

        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.RetiroCliente(movimiento, ci)
    End Function

    Function DepositoCliente(ByVal movimiento As Entities.Deposito, ByVal ci As Integer) As Boolean
        movimiento.Fecha = DateTime.Now

        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.DepositoCliente(movimiento, ci)
    End Function

    Function TransferenciaCliente(ByVal movimiento As Entities.Transferencia, ByVal ci As Integer) As Boolean
        movimiento.Fecha = DateTime.Now

        Dim daMovimiento As New DataAccess.Movimiento

        Return daMovimiento.TransferenciaCliente(movimiento, ci)
    End Function

End Class
