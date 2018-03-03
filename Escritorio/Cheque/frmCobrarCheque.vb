Public Class frmCobrarCheque

    Private Sub frmCobrarCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboCurrency.DataSource = GetCurrencyType()
        cboCurrency.DisplayMember = "Display"
        cboCurrency.ValueMember = "Value"
    End Sub

    Private Sub rdbLocalYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLocalYes.CheckedChanged
        txtNumeroChequera.Enabled = Not txtNumeroChequera.Enabled
    End Sub

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Dim cheque As New Entities.Cheque
        cheque.Numero = txtNumero.Text
        If rdbLocalYes.Checked Then
            cheque.NumeroChequera = txtNumeroChequera.Text
        End If
        cheque.MonedaId = cboCurrency.SelectedValue
        cheque.Monto = txtMonto.Text
        cheque.Emision = dtpEmision.Value

        Dim bCheque As New Business.Cheque

        If bCheque.Cobro(cheque, empleadoCaja.Id) Then
            MessageBox.Show(My.Resources.MsgChequeCobrado)
        Else
            MessageBox.Show(My.Resources.MsgChequeCobradoError)
        End If

    End Sub
End Class