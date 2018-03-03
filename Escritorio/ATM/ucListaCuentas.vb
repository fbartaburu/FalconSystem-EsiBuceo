Public Class ucListaCuentas

    Private Sub ucListaCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bCuentas As New Business.Cuenta
        Dim cuentas = bCuentas.ListadoCuentas(clienteLogueado.CI)

        For Each c As Integer In cuentas
            Dim item As New ListViewItem
            Dim cuenta = bCuentas.Datos(c)

            item = lstCuentas.Items.Add(cuenta.Numero)
            item.SubItems.Add(cuenta.Saldo)

            For Each row As DataRow In GetCurrencyType.Select("Value=" & cuenta.MonedaId)
                item.SubItems.Add(row(1))
            Next
        Next

    End Sub

    Private Sub lstCuentas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCuentas.DoubleClick
        frmATMPrincipal.cuentaSeleccionada = lstCuentas.SelectedItems.Item(0).Text()

        'Habilitar el resto de opciones
        frmATMPrincipal.btnCambiarPin.Enabled = True
        frmATMPrincipal.btnSalir.Enabled = True
        frmATMPrincipal.btnRetiro.Enabled = True
        frmATMPrincipal.btnDeposito.Enabled = True
        frmATMPrincipal.btnTransferencia.Enabled = True
        frmATMPrincipal.btnCuenta.Enabled = True

        frmATMPrincipal.pnlPrincipal.Controls.Clear()
    End Sub
End Class
