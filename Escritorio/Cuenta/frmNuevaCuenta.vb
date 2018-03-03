Public Class frmNuevaCuenta

    Private Sub frmNuevaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboTipoCuenta.DataSource = GetAccountType()
        cboTipoCuenta.DisplayMember = "Display"
        cboTipoCuenta.ValueMember = "Value"

        cboMoneda.DataSource = GetCurrencyType()
        cboMoneda.DisplayMember = "Display"
        cboMoneda.ValueMember = "Value"
    End Sub

    Private Sub btnNuevaCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCuenta.Click
        Dim cuenta As New Entities.Cuenta

        cuenta.MonedaId = cboMoneda.SelectedValue
        cuenta.Tipo = cboTipoCuenta.SelectedValue

        Dim clienteAcceso As New Entities.AccesoCuenta
        clienteAcceso.Clientes.CI = frmClientePrincipal.clientePrincipal.CI
        cuenta.Clientes.Add(clienteAcceso)


        Dim bCuenta As New Business.Cuenta
        If bCuenta.NuevaCuenta(cuenta, empleadoCaja.Id) Then
            Dim cliente = frmClientePrincipal.clientePrincipal
            frmClientePrincipal.Close()
            frmClientePrincipal.clientePrincipal = cliente
            OpenMdiChild(frmClientePrincipal)

            MessageBox.Show(My.Resources.MsgNuevaCuenta)
            Me.Close()
        Else
            MessageBox.Show(My.Resources.MsgNuevaCuentaError)
        End If


    End Sub
End Class