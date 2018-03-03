Public Class frmLogin

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click

        'Controla que los textboxes no estén vacíos
        If Not TextBoxIsEmpty(Me) Then
            Dim loginData As Entities.Login = Entities.Login.GetSingleton()
            loginData.Usuario = txtUsuario.Text
            loginData.Contrasena = txtContrasena.Text

            Dim bLogin As New Business.Login
            Dim data As Object = bLogin.Login(loginData)

            If data IsNot Nothing Then
                If data.GetType Is GetType(Entities.Cliente) Then 'Cliente
                    clienteLogueado = data
                    frmATMPrincipal.Show()
                ElseIf data.GetType Is GetType(Entities.Empleado) Then 'Empleado
                    'Guardo los datos del empleado en la memoria
                    empleadoLogueado = data

                    'Corroboro si la caja ya existe en la BD
                    Dim bCaja As New Business.Caja
                    If bCaja.Existe() Then
                        frmPrincipal.Show()
                    Else
                        frmNuevaCaja.Show()
                    End If
                End If

                Me.Close()
            Else
                MessageBox.Show("No existe")
            End If
        End If

    End Sub

End Class
