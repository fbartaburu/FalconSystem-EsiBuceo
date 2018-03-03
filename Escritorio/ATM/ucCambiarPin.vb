Public Class ucCambiarPin

    Private Sub txtNuevoPin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevoPin.KeyPress
        e.Handled = CorrectInput(sender, e, 3, True, False, False)
    End Sub

    Private Sub btnNuevoPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPin.Click

        If Not txtNuevoPin.Text.Equals(String.Empty) Then
            Dim cliente As Entities.Cliente = clienteLogueado
            cliente.Pin = txtNuevoPin.Text

            Dim bCliente As New Business.Cliente

            If bCliente.CambiarPin(cliente) Then
                MessageBox.Show(My.Resources.MsgNuevoPin)
                Application.Exit()
            Else
                MessageBox.Show(My.Resources.MsgNuevoPinError)
            End If
        Else
            MessageBox.Show(My.Resources.MsgPinIncorrecto)
        End If
       
    End Sub

    Private Sub ucCambiarPin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNuevoPin.Focus()
    End Sub
End Class
