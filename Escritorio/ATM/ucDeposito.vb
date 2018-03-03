Public Class ucDeposito

    Private Sub ucDeposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMoneda.DataSource = GetCurrencyType()
        cboMoneda.DisplayMember = "Display"
        cboMoneda.ValueMember = "Value"

        txtMonto.Focus()
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = CorrectInput(sender, e, 6, True, False, False)
    End Sub

    Private Sub btnDepositar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositar.Click
        Dim deposito As New Entities.Deposito
        deposito.MonedaId = cboMoneda.SelectedValue
        deposito.Monto = txtMonto.Text
        deposito.NumeroCuenta = frmATMPrincipal.cuentaSeleccionada
        deposito.IsClient = 1

        Dim bMovimiento As New Business.Movimiento
        If bMovimiento.DepositoCliente(deposito, clienteLogueado.CI) Then
            MessageBox.Show(My.Resources.MsgDeposito)
        Else
            MessageBox.Show(My.Resources.MsgDepositoError)
        End If
    End Sub
End Class
