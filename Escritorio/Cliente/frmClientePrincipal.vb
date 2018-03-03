Public Class frmClientePrincipal
    Public clientePrincipal As Entities.Cliente
    Dim cuentas As List(Of Integer)
    Dim actualAccount As Integer = -1

    Private Sub frmClientePrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cargar Listado de Cuentas
        Dim bCuentas As New Business.Cuenta
        cuentas = bCuentas.ListadoCuentas(clientePrincipal.CI)
        cboCuentas.DataSource = cuentas

        If empleadoLogueado.Cargo = 3 Then
            If cuentas.Count = 0 Then
                gbChequera.Visible = False
                gbAcciones.Visible = False
                gbSaldo.Visible = False
                lstMovimientos.Enabled = False
                gbAccesoClientes.Visible = False
            End If
            btnNuevaCuenta.Visible = True
            gbCliente.Visible = True
        Else
            If cuentas.Count = 0 Then
                cboCuentas.Location = New Point(15, 25)
                gbCuentas.Height = 70
                gbChequera.Visible = False
                gbAcciones.Visible = False
                gbSaldo.Visible = False
                lstMovimientos.Enabled = False
                gbAccesoClientes.Visible = False
            End If
        End If
        


        gbAcciones.Height = 75

    End Sub

    Private Sub cboCuentas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentas.SelectedIndexChanged
        'Para no volver a cargar la misma cuenta
        If actualAccount <> cboCuentas.SelectedIndex Then
            actualAccount = cboCuentas.SelectedIndex

            RefreshCuenta(cuentas.Item(actualAccount))

        End If
    End Sub

    Private Sub btnNuevaCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCuenta.Click
        OpenMdiChild(frmNuevaCuenta)
    End Sub

    Private Sub btnAcceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceso.Click
        OpenMdiChild(frmAcceso)
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        OpenMdiChild(frmQuitarAcceso)
    End Sub

    Private Sub btnDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposito.Click
        frmDeposito.isClient = 1
        OpenMdiChild(frmDeposito)
    End Sub

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        OpenMdiChild(frmRetiro)
    End Sub

    Private Sub btnTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferencia.Click
        OpenMdiChild(frmTransferencia)
    End Sub

    Private Sub btnCerrarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarCuenta.Click
        'Preguntar si está seguro
        If MessageBox.Show(My.Resources.MsgCerrarCuenta, String.Empty, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim bCuenta As New Business.Cuenta
            If bCuenta.Cerrar(cboCuentas.SelectedValue) Then
                MessageBox.Show(My.Resources.MsgCuentaCerrada)
                frmClientePrincipal_Load(Nothing, Nothing)
            Else
                MessageBox.Show(My.Resources.MsgCuentaCerradaError)
            End If
        End If
    End Sub

    Private Sub btnNuevaChequera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaChequera.Click
        OpenMdiChild(frmNuevaChequera)
    End Sub

    Public Sub RefreshCuenta(ByVal numeroCuenta As Integer)
        Dim bCuenta As New Business.Cuenta
        Dim cuenta As Entities.Cuenta = bCuenta.Datos(numeroCuenta)
        cuenta.Clientes = bCuenta.AccesoCuenta(numeroCuenta)

        'Ocultar Chequeras si es cuenta de ahorro
        If cuenta.Tipo = 1 Then
            gbChequera.Visible = False
        Else
            gbChequera.Visible = True
        End If

        If empleadoLogueado.Cargo = 3 Then
            btnNuevaCuenta.Visible = True
            cboCuentas.Location = New Point(15, 70)
            gbAccesoClientes.Visible = True
            btnRetiro.Visible = False
            btnDeposito.Visible = False
            btnTransferencia.Visible = False
            btnCerrarCuenta.Location = btnDeposito.Location
            btnCerrarCuenta.Visible = True
        Else
            gbChequera.Visible = False
            gbCuentas.Height = 70
            cboCuentas.Location = New Point(15, 25)
        End If

        'Cargar Movimientos
        lstMovimientos.Items.Clear()
        Dim bMovimientos As New Business.Movimiento
        For Each mov As Entities.Movimiento In bMovimientos.Movimientos(cuenta.Numero).OrderByDescending(Function(x) x.Fecha)
            Dim item As New ListViewItem

            For Each row As DataRow In GetMovementType.Select("Value=" & mov.Tipo)
                item = lstMovimientos.Items.Add(row(1))
            Next

            item.SubItems.Add(mov.Monto)

            For Each row As DataRow In GetCurrencyType.Select("Value=" & mov.MonedaId)
                item.SubItems.Add(row(1))
            Next

            item.SubItems.Add(mov.Fecha)
        Next


        'Cargar Panel de Status
        lblSaldoData.Text = cuenta.Saldo
        For Each row As DataRow In GetCurrencyType.Select("Value=" & cuenta.MonedaId)
            lblMonedaData.Text = row(1)
        Next

        lstAcceso.Items.Clear()
        For i = 0 To cuenta.Clientes.Count - 1


            If cuenta.Clientes.Item(i).Propietario = 1 Then
                lblPropietarioData.Text = cuenta.Clientes.Item(i).Clientes.Nombre1 & " " & cuenta.Clientes.Item(i).Clientes.Apellido1

                'Si soy el propietario mostar los botones para agregar y quitar acceso a la cuenta
                If cuenta.Clientes.Item(i).Clientes.CI = clientePrincipal.CI Then
                    gbAccesoClientes.Height = 380
                    gbAcciones.Visible = True
                Else
                    gbAccesoClientes.Height = 270
                    gbAcciones.Visible = False
                End If
            Else
                'Cargar listado de clientes con acceso a la cuenta
                If cuenta.Clientes.Item(i).Propietario = 0 Then
                    Dim item As New ListViewItem
                    item = lstAcceso.Items.Add(cuenta.Clientes.Item(i).Clientes.CI)
                    item.SubItems.Add(cuenta.Clientes.Item(i).Clientes.Nombre1 & " " & cuenta.Clientes.Item(i).Clientes.Apellido1)
                End If
            End If


        Next
    End Sub

    Private Sub btnEstadoChequera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoChequera.Click
        OpenMdiChild(frmEstadoChequera)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        OpenMdiChild(frmModificarCliente)
    End Sub
End Class