Public Class frmNuevoCliente
    Dim existe As Boolean

    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click

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
            If bCliente.Nuevo(cliente) Then
                MessageBox.Show(My.Resources.MsgNuevoCliente)
                frmClientePrincipal.clientePrincipal = cliente
                OpenMdiChild(frmClientePrincipal)
                Me.Close()
            Else
                MessageBox.Show(My.Resources.MsgNuevoClienteError)
            End If

        Else
            If txtNombre2.Text = My.Resources.ValorDefecto Then
                txtNombre2.Text = String.Empty
            End If
            If txtTel2.Text = My.Resources.ValorDefecto Then
                txtTel2.Text = String.Empty
            End If

            MessageBox.Show(My.Resources.MsgNuevoClienteError)

        End If



    End Sub

    Private Sub frmNuevoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboEstadoCivil.DataSource = GetCivilStatus()
        cboEstadoCivil.DisplayMember = "Display"
        cboEstadoCivil.ValueMember = "Value"

        cboNacionalidad.DataSource = GetNationalities()
        cboNacionalidad.DisplayMember = "Display"
        cboNacionalidad.ValueMember = "Display"

        dtpDoB.MaxDate = New Date(Today.Year - 18, Today.Month, Today.Day)

    End Sub

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

    Private Sub txtCI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCI.Leave
        If txtCI.Text.Length <> 0 Then
            If Not existe Then
                Dim bCliente As New Business.Cliente
                Dim cliente = bCliente.GetClientByCI(txtCI.Text)

                If cliente IsNot Nothing Then
                    existe = True
                    MessageBox.Show(My.Resources.MsgClienteExiste)
                    frmClientePrincipal.clientePrincipal = cliente
                    OpenMdiChild(frmClientePrincipal)
                    Me.Close()
                    Exit Sub
                End If

                Dim bEmpleado As New Business.Empleado
                Dim empleado = bEmpleado.GetEmployeeByCI(CInt(txtCI.Text))
                If empleado IsNot Nothing Then

                    txtNombre1.Text = empleado.Nombre1
                    txtNombre2.Text = empleado.Nombre2
                    txtApellido1.Text = empleado.Apellido1
                    txtApellido2.Text = empleado.Apellido2
                    dtpDoB.Value = empleado.FechaNacimiento
                    cboEstadoCivil.SelectedValue = empleado.EstadoCivil
                    cboNacionalidad.SelectedValue = empleado.Nacionalidad
                    txtDireccion.Text = empleado.Direccion
                    txtMail.Text = empleado.Email
                    txtTel1.Text = empleado.Telefono1
                    txtTel2.Text = empleado.Telefono2

                End If
            End If
        End If
    End Sub
End Class