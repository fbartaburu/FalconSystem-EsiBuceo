Public Class frmDeposito
    Public isClient As Integer

    Private Sub frmDeposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMoneda.DataSource = GetCurrencyType()
        cboMoneda.DisplayMember = "Display"
        cboMoneda.ValueMember = "Value"

        If isClient = 1 Then
            btnDepositar.Location = New Point(100, 110)
            lblDestino.Visible = False
            txtDestino.Visible = False
            Me.Height = 185
        End If

    End Sub

    Private Sub btnDepositar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositar.Click
        Dim deposito As New Entities.Deposito

        deposito.MonedaId = cboMoneda.SelectedValue
        deposito.Monto = txtMonto.Text

        If isClient = 1 Then
            deposito.NumeroCuenta = frmClientePrincipal.cboCuentas.SelectedValue
        Else
            deposito.NumeroCuenta = txtDestino.Text
        End If

        deposito.IsClient = isClient

        Dim bMovimiento As New Business.Movimiento

        If bMovimiento.Deposito(deposito, empleadoCaja.Id) Then
            If empleadoLogueado.Cargo = 4 Then
                listDineroCaja.Item(deposito.MonedaId - 1).DineroFinal += txtMonto.Text
            End If

            MessageBox.Show(My.Resources.MsgDeposito)

            If isClient = 1 Then
                frmClientePrincipal.RefreshCuenta(deposito.NumeroCuenta)
            End If

            Me.Close()
        Else
            MessageBox.Show(My.Resources.MsgDepositoError)
        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = CorrectInput(sender, e, 6, True, False, False)
    End Sub
End Class