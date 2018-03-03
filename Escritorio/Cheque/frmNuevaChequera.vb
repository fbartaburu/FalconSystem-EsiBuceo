Public Class frmNuevaChequera

    Private Sub frmNuevaChequera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmClientePrincipal.cboCuentas.Enabled = False

        cboTipo.DataSource = GetCheckBookType()
        cboTipo.DisplayMember = "Display"
        cboTipo.ValueMember = "Value"

        cboDiaCruzado.DataSource = GetDatedDay()

        cboDiaCruzado.Enabled = False
    End Sub

    Private Sub btnNuevaChequera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaChequera.Click

        If Not TextBoxIsEmpty(Me) Then
            Dim chequera As New Entities.Chequera
            chequera.Numero = txtNumero.Text
            chequera.NumeroCuenta = frmClientePrincipal.cboCuentas.SelectedValue
            chequera.Tipo = cboTipo.SelectedValue
            If chequera.Tipo = 1 Then
                chequera.DiaCobroCruzado = cboDiaCruzado.SelectedValue
            End If

            Dim bChequera As New Business.Cheque
            If bChequera.NuevaChequera(chequera) Then
                MessageBox.Show(My.Resources.MsgChequeraNueva)
                Me.Close()
            Else
                MessageBox.Show(My.Resources.MsgChequeraNuevaError)
            End If
        End If

    End Sub

    Private Sub cboTipo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectionChangeCommitted
        If cboTipo.SelectedValue = 0 Then
            cboDiaCruzado.Enabled = False
        Else
            cboDiaCruzado.Enabled = True
        End If
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        e.Handled = CorrectInput(sender, e, 6, True, False, False)
    End Sub

    Private Sub frmNuevaChequera_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmClientePrincipal.cboCuentas.Enabled = True
    End Sub
End Class