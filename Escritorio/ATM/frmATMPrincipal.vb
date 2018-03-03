Public Class frmATMPrincipal
    Public cuentaSeleccionada As Integer

    Private Sub btnCambiarPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPin.Click
        pnlPrincipal.Controls.Clear()
        pnlPrincipal.Controls.Add(New ucCambiarPin)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        pnlPrincipal.Controls.Clear()
        Me.Close()
    End Sub

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        pnlPrincipal.Controls.Clear()
        pnlPrincipal.Controls.Add(New ucRetiro)
    End Sub

    Private Sub frmATMPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If clienteLogueado.Pin = My.Resources.DefaultPin Then
            pnlPrincipal.Controls.Clear()
            pnlPrincipal.Controls.Add(New ucCambiarPin)
        Else
            pnlPrincipal.Controls.Clear()
            pnlPrincipal.Controls.Add(New ucListaCuentas)
        End If

        'Deshabilitar el resto de opciones
        btnCambiarPin.Enabled = False
        btnSalir.Enabled = False
        btnRetiro.Enabled = False
        btnDeposito.Enabled = False
        btnTransferencia.Enabled = False
        btnCuenta.Enabled = False
    End Sub

    Private Sub btnDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposito.Click
        pnlPrincipal.Controls.Clear()
        pnlPrincipal.Controls.Add(New ucDeposito)
    End Sub

    Private Sub btnTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferencia.Click
        pnlPrincipal.Controls.Clear()
        pnlPrincipal.Controls.Add(New ucTransferencia)
    End Sub

    Private Sub btnCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuenta.Click
        pnlPrincipal.Controls.Clear()
        pnlPrincipal.Controls.Add(New ucEstadoCuenta)
    End Sub
End Class