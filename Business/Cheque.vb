Public Class Cheque

    Function NuevaChequera(ByVal chequera As Entities.Chequera) As Boolean
        Dim daChequera As New DataAccess.Cheque

        Return daChequera.NuevaChequera(chequera)
    End Function

    Function Cobro(ByVal cheque As Entities.Cheque, ByVal empleadoCajaId As Integer) As Boolean
        Dim daCheque As New DataAccess.Cheque

        Return daCheque.CobroCheque(cheque, empleadoCajaId)
    End Function

    Function ListadoChequeras(ByVal numeroCuenta As Integer) As List(Of Entities.Chequera)
        Dim daChequera As New DataAccess.Cheque

        Return daChequera.LisatdoChequera(numeroCuenta)
    End Function

    Function ListadoCheques(ByVal numeroChequera As Integer) As List(Of Entities.ChequeCobrado)
        Dim daChequera As New DataAccess.Cheque

        Return daChequera.LisatdoCheque(numeroChequera)
    End Function

End Class
