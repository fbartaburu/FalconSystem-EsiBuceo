Public Class frmQuitarAcceso

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtDocumento.Text.Length <> 0 Then
            Dim bCuenta As New Business.Cuenta

            If bCuenta.RevokeAccess(txtDocumento.Text, frmClientePrincipal.cboCuentas.SelectedValue) Then
                frmClientePrincipal.RefreshCuenta(frmClientePrincipal.cboCuentas.SelectedValue)
                MessageBox.Show(My.Resources.MsgQuitarAcceso)
                Me.Close()
            Else
                MessageBox.Show(My.Resources.MsgQuitarAccesoError)
            End If
        End If
    End Sub

    Private Sub txtDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumento.KeyPress
        e.Handled = CorrectInput(sender, e, 8, True, False, False)
    End Sub

    Private Sub frmQuitarAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmClientePrincipal.cboCuentas.Enabled = False
    End Sub

    Private Sub frmQuitarAcceso_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmClientePrincipal.cboCuentas.Enabled = True
    End Sub
End Class