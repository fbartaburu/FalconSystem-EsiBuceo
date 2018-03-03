Public Class frmAbrirCaja

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click

        If Not TextBoxIsEmpty(Me) Then

            Dim dineroCaja As New Entities.DineroCaja

            dineroCaja.IdEmpleadoCaja = empleadoCaja.Id
            dineroCaja.DineroIncial = txtCantidadUYU.Text
            dineroCaja.DineroFinal = txtCantidadUYU.Text
            dineroCaja.IdMoneda = 1

            listDineroCaja.Add(dineroCaja)

            dineroCaja = New Entities.DineroCaja
            dineroCaja.IdEmpleadoCaja = empleadoCaja.Id
            dineroCaja.DineroIncial = txtCantidadUSD.Text
            dineroCaja.DineroFinal = txtCantidadUSD.Text
            dineroCaja.IdMoneda = 2

            listDineroCaja.Add(dineroCaja)

            Dim bCaja As New Business.Caja
            If bCaja.DineroCaja(listDineroCaja) Then
                MessageBox.Show(My.Resources.MsgCajaAbierta)
                frmPrincipal.rcPrincipal.Visible = True
                Me.Close()

            Else
                txtCantidadUSD.Text = String.Empty
                txtCantidadUYU.Text = String.Empty
                txtCantidadUYU.Focus()

                MessageBox.Show(My.Resources.MsgCajaNoAbierta)
            End If
        Else
            MessageBox.Show(My.Resources.MsgCajaNoAbierta)
        End If

    End Sub

    Private Sub txtCantidadUYU_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadUYU.KeyPress
        e.Handled = CorrectInput(sender, e, 13, False, False, True)
    End Sub

    Private Sub txtCantidadUSD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadUSD.KeyPress
        e.Handled = CorrectInput(sender, e, 13, False, False, True)
    End Sub

    Private Sub frmAbrirCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCantidadUYU.Focus()
    End Sub
End Class