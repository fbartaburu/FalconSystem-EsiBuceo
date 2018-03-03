Public Class frmAcceso
    Dim cliente As Entities.Cliente

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        lstAcceso.Items.Clear()

        Dim bCliente As New Business.Cliente
        cliente = bCliente.GetClientByCI(txtDocumento.Text)
        If cliente IsNot Nothing Then
            Dim item As New ListViewItem
            item = lstAcceso.Items.Add(cliente.CI)
            item.SubItems.Add(cliente.Nombre1 & " " & cliente.Apellido1)
        Else
            MessageBox.Show(My.Resources.MsgClienteNoExiste)
        End If

    End Sub

    Private Sub txtDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumento.KeyPress
        e.Handled = CorrectInput(sender, e, 8, True, False, False)
    End Sub

    Private Sub lstAcceso_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAcceso.DoubleClick
        Dim bCuenta As New Business.Cuenta

        If bCuenta.GrantAccess(lstAcceso.SelectedItems.Item(0).Text, frmClientePrincipal.cboCuentas.SelectedValue) Then
            frmClientePrincipal.RefreshCuenta(frmClientePrincipal.cboCuentas.SelectedValue)
            MessageBox.Show(My.Resources.MsgAgregarAcceso)
            Me.Close()
        Else
            MessageBox.Show(My.Resources.MsgAgregarAccesoError)
        End If
    End Sub

    Private Sub frmAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmClientePrincipal.cboCuentas.Enabled = False
    End Sub

    Private Sub frmAcceso_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmClientePrincipal.cboCuentas.Enabled = True
    End Sub
End Class