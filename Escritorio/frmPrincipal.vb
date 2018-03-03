Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Valores de la barra de status
        tssLabel1.Text &= empleadoLogueado.CI
        tssLabel3.Text &= CStr(Today())
        tssLabel5.Text &= CStr(Hour(Now)) & ":" & CStr(Minute(Now))
        tssLabel7.Text &= My.Computer.Name
        tssLabel9.Text &= GetEmployeePosition()

        'Caja
        Dim bCaja As New Business.Caja


        'Asignar Empleado
        empleadoCaja = bCaja.AsignarEmpleado(empleadoLogueado.CI)
        If empleadoCaja Is Nothing Then
            Me.Close()
        End If

        If empleadoLogueado.Cargo = 4 Then      'Cajero
            rcPrincipal.Visible = False
            rtabCajero.Visible = True
            rtabCajero.Select()
            OpenMdiChild(frmAbrirCaja)
        ElseIf empleadoLogueado.Cargo = 3 Then  'AComercial
            rtabAComercial.Visible = True
            rtabAComercial.Select()
        ElseIf empleadoLogueado.Cargo = 2 Then  'Gerente
            rtabGerente.Visible = True
            rtabGerente.Select()
        End If

    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim bCaja As New Business.Caja
        If empleadoLogueado.Cargo = 4 Then
            bCaja.CerrarCaja(empleadoCaja, listDineroCaja)
        Else
            bCaja.CerrarCaja(empleadoCaja)
        End If

    End Sub

    Private Sub btnCajeroBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajeroBuscarCliente.Click
        OpenMdiChild(frmBuscarCliente)
    End Sub

    Private Sub btnCajeroDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajeroDeposito.Click
        frmDeposito.isClient = 0
        OpenMdiChild(frmDeposito)
    End Sub

    Private Sub btnCajeroMonedas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajeroMonedas.Click
        OpenMdiChild(frmValorMonedas)
    End Sub

    Private Sub btnAcomNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcomNuevoCliente.Click
        OpenMdiChild(frmNuevoCliente)
    End Sub

    Private Sub btnAcomBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcomBuscarCliente.Click
        OpenMdiChild(frmBuscarCliente)
    End Sub

    Private Sub btnAcomMonedas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcomMonedas.Click
        OpenMdiChild(frmValorMonedas)
    End Sub

    Private Sub btnGerenteBuscarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerenteBuscarSucursal.Click
        OpenMdiChild(frmListadoCajas)
    End Sub

    Private Sub btnGerenteMonedas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerenteMonedas.Click
        OpenMdiChild(frmValorMonedas)
    End Sub

    Private Sub btnCajeroCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajeroCheque.Click
        OpenMdiChild(frmCobrarCheque)
    End Sub
End Class