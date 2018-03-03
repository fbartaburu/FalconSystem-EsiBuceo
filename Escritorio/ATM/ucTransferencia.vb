Public Class ucTransferencia

    Private Sub ucTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMoneda.DataSource = GetCurrencyType()
        cboMoneda.DisplayMember = "Display"
        cboMoneda.ValueMember = "Value"

        txtMonto.Focus()
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = CorrectInput(sender, e, 6, True, False, False)
    End Sub

    Private Sub txtDestino_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDestino.KeyPress
        e.Handled = CorrectInput(sender, e, 10, True, False, False)
    End Sub

    Private Sub btnTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferencia.Click
        Dim transferencia As New Entities.Transferencia

        transferencia.MonedaId = cboMoneda.SelectedValue
        transferencia.Monto = txtMonto.Text
        transferencia.NumeroCuenta = frmATMPrincipal.cuentaSeleccionada
        transferencia.NumeroCuentaDestino = txtDestino.Text

        Dim bMovimiento As New Business.Movimiento

        If bMovimiento.TransferenciaCliente(transferencia, clienteLogueado.CI) Then
            MessageBox.Show(My.Resources.MsgTransferencia)
        Else
            MessageBox.Show(My.Resources.MsgTransferenciaError)
        End If
    End Sub
End Class
