Public Class ucEstadoCuenta

    Private Sub ucEstadoCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bCuenta As New Business.Cuenta
        Dim cuenta = bCuenta.Datos(frmATMPrincipal.cuentaSeleccionada)

        lblNumero.Text &= cuenta.Numero
        lblMonto.Text &= cuenta.Saldo

        For Each row As DataRow In GetCurrencyType.Select("Value=" & cuenta.MonedaId)
            lblMoneda.Text &= row(1)
        Next
    End Sub
End Class
