Public Class frmBuscarCliente
    Dim cliente As Entities.Cliente

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Not txtDocumento.Text.Equals(String.Empty) Then

            Dim bCliente As New Business.Cliente
            cliente = bCliente.GetClientByCI(txtDocumento.Text)

            If cliente IsNot Nothing Then

                Me.Height = 380
                Me.StartPosition = FormStartPosition.CenterScreen
                lblNombreData.Text = cliente.Nombre1 & " " & cliente.Nombre2
                lblApellidoData.Text = cliente.Apellido1 & " " & cliente.Apellido2
                lblDoBData.Text = cliente.FechaNacimiento.ToString("dd-MMM-yyyy")

                Dim tipoRow() As DataRow = GetCivilStatus.Select("Value='" & cliente.EstadoCivil & "'")
                For Each row As DataRow In tipoRow
                    lblEstadoCivilData.Text = row(1)
                Next

                lblNacionalidadData.Text = cliente.Nacionalidad
                lblDireccionData.Text = cliente.Direccion
                lblTelData.Text = cliente.Telefono1 & " - " & cliente.Telefono2
                lblEmailData.Text = cliente.Email

                btnConfirmar.Focus()

            Else
                cliente = Nothing
                Me.Height = 110
                MessageBox.Show(My.Resources.MsgClienteNoExiste)
            End If

        Else
            cliente = Nothing
            Me.Height = 110
            MessageBox.Show(My.Resources.MsgClienteNoExiste)
        End If

        
    End Sub

    Private Sub txtDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumento.KeyPress
        e.Handled = CorrectInput(sender, e, 8, True, False, False)
    End Sub

    Private Sub frmBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 110
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        frmClientePrincipal.clientePrincipal = cliente
        OpenMdiChild(frmClientePrincipal)
        Me.Close()
    End Sub
End Class