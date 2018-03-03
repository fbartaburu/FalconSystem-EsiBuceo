Public Class ucRetiro

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = CorrectInput(sender, e, 6, True, False, False)
    End Sub

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        Dim retiro As New Entities.Movimiento
        retiro.MonedaId = cboMoneda.SelectedValue
        retiro.Monto = txtMonto.Text
        retiro.NumeroCuenta = frmATMPrincipal.cuentaSeleccionada

        Dim bMovimiento As New Business.Movimiento
        If bMovimiento.RetiroCliente(retiro, clienteLogueado.CI) Then
            MessageBox.Show(My.Resources.MsgRetiro)
        Else
            MessageBox.Show(My.Resources.MsgRetiroError)
        End If
    End Sub

    Private Sub ucRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMoneda.DataSource = GetCurrencyType()
        cboMoneda.DisplayMember = "Display"
        cboMoneda.ValueMember = "Value"

        txtMonto.Focus()
    End Sub
End Class
