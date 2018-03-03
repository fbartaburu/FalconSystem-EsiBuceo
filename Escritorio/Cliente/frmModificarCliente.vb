Public Class frmModificarCliente

    Private Sub txtCI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        e.Handled = CorrectInput(sender, e, 8, True, False, False)
    End Sub

    Private Sub txtNombre1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre1.KeyPress
        e.Handled = CorrectInput(sender, e, 15, False, True, False)
    End Sub

    Private Sub txtNombre2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre2.KeyPress
        e.Handled = CorrectInput(sender, e, 15, False, True, False)
    End Sub

    Private Sub txtApellido1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido1.KeyPress
        e.Handled = CorrectInput(sender, e, 15, False, True, False)
    End Sub

    Private Sub txtApellido2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido2.KeyPress
        e.Handled = CorrectInput(sender, e, 15, False, True, False)
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        e.Handled = CorrectInput(sender, e, 50, True, True, False)
    End Sub

    Private Sub txtMail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMail.KeyPress
        e.Handled = CorrectInput(sender, e, 25, False, False, False)
    End Sub

    Private Sub txtTel1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel1.KeyPress
        e.Handled = CorrectInput(sender, e, 10, True, False, False)
    End Sub

    Private Sub txtTel2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel2.KeyPress
        e.Handled = CorrectInput(sender, e, 10, True, False, False)
    End Sub

    Private Sub frmModificarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboEstadoCivil.DataSource = GetCivilStatus()
        cboEstadoCivil.DisplayMember = "Display"
        cboEstadoCivil.ValueMember = "Value"

        cboNacionalidad.DataSource = GetNationalities()
        cboNacionalidad.DisplayMember = "Display"
        cboNacionalidad.ValueMember = "Display"

        dtpDoB.MaxDate = New Date(Today.Year - 18, Today.Month, Today.Day)

        Dim bCliente As New Business.Cliente
        Dim cliente = bCliente.GetClientByCI(frmClientePrincipal.clientePrincipal.CI)

        txtCI.Text = cliente.CI
        txtNombre1.Text = cliente.Nombre1
        txtNombre2.Text = cliente.Nombre2
        txtApellido1.Text = cliente.Apellido1
        txtApellido2.Text = cliente.Apellido2
        dtpDoB.Value = cliente.FechaNacimiento
        cboEstadoCivil.SelectedValue = cliente.EstadoCivil
        cboNacionalidad.SelectedValue = cliente.Nacionalidad
        txtDireccion.Text = cliente.Direccion
        txtMail.Text = cliente.Email
        txtTel1.Text = cliente.Telefono1
        txtTel2.Text = cliente.Telefono2


    End Sub

    Private Sub btnModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCliente.Click

        If txtNombre2.Text.Length = 0 Then
            txtNombre2.Text = My.Resources.ValorDefecto
        End If
        If txtTel2.Text.Length = 0 Then
            txtTel2.Text = My.Resources.ValorDefecto
        End If


        If Not TextBoxIsEmpty(Me) Then
            Dim cliente As New Entities.Cliente

            If txtNombre2.Text = My.Resources.ValorDefecto Then
                txtNombre2.Text = String.Empty
            End If
            If txtTel2.Text = My.Resources.ValorDefecto Then
                txtTel2.Text = String.Empty
            End If

            cliente.CI = txtCI.Text
            cliente.Nombre1 = txtNombre1.Text
            cliente.Nombre2 = txtNombre2.Text
            cliente.Apellido1 = txtApellido1.Text
            cliente.Apellido2 = txtApellido2.Text
            cliente.FechaNacimiento = dtpDoB.Value
            cliente.EstadoCivil = cboEstadoCivil.SelectedValue
            cliente.Nacionalidad = cboNacionalidad.SelectedValue
            cliente.Direccion = txtDireccion.Text
            cliente.Email = txtMail.Text
            cliente.Telefono1 = txtTel1.Text
            cliente.Telefono2 = txtTel2.Text

            Dim bCliente As New Business.Cliente
            If bCliente.Actualizar(cliente) Then
                MessageBox.Show(My.Resources.MsgClienteActualizado)
                frmClientePrincipal.clientePrincipal = cliente
                OpenMdiChild(frmClientePrincipal)
                Me.Close()
            Else
                MessageBox.Show(My.Resources.MsgClienteActualizadoError)
            End If

        Else
            If txtNombre2.Text = My.Resources.ValorDefecto Then
                txtNombre2.Text = String.Empty
            End If
            If txtTel2.Text = My.Resources.ValorDefecto Then
                txtTel2.Text = String.Empty
            End If

            MessageBox.Show(My.Resources.MsgClienteActualizadoError)

        End If


    End Sub
End Class