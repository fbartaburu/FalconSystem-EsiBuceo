Public Class frmCambioValorMoneda
    Public monedaId As Integer


    Private Sub btnValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValor.Click
        Dim nuevoValor As New Entities.ValoresMoneda

        nuevoValor.IdEmpleadoCaja = empleadoCaja.Id
        nuevoValor.Valor = txtValor.Text
        nuevoValor.Fecha = DateTime.Now
        nuevoValor.IdMoneda = monedaId

        Dim bMoneda As New Business.Moneda

        If bMoneda.CambiarValor(nuevoValor) Then
            MessageBox.Show(My.Resources.MsgMonedaCambiada)
            frmValorMonedas.Close()
            OpenMdiChild(frmValorMonedas)
            Me.Close()
        Else
            MessageBox.Show(My.Resources.MsgMonedaNoCambiada)
        End If

    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        e.Handled = CorrectInput(sender, e, 10, False, False, True)
    End Sub
End Class