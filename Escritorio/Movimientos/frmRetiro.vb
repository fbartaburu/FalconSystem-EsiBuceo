Public Class frmRetiro

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        Dim retiro As New Entities.Movimiento

        retiro.MonedaId = cboMoneda.SelectedValue
        retiro.Monto = txtMonto.Text
        retiro.NumeroCuenta = frmClientePrincipal.cboCuentas.SelectedValue

        Dim bMovimiento As New Business.Movimiento

        If bMovimiento.Retiro(retiro, empleadoCaja.Id) Then

            listDineroCaja.Item(retiro.MonedaId - 1).DineroFinal -= txtMonto.Text

            MessageBox.Show(My.Resources.MsgRetiro)

            frmClientePrincipal.RefreshCuenta(retiro.NumeroCuenta)

            Me.Close()
        Else
            MessageBox.Show(My.Resources.MsgRetiroError)
        End If


    End Sub

    Private Sub frmRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMoneda.DataSource = GetCurrencyType()
        cboMoneda.DisplayMember = "Display"
        cboMoneda.ValueMember = "Value"
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = CorrectInput(sender, e, 6, True, False, False)
    End Sub

End Class