Public Class frmMovimientos
    Public empleadoCajaId As Integer

    Private Sub frmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bMovimientos As New Business.Movimiento
        Dim caja As Entities.MovimientosCaja = bMovimientos.MovimientosPorCaja(empleadoCajaId)
        Dim bEmpleado As New Business.Empleado
        Dim empleado = bEmpleado.GetEmployeeByCI(caja.Ci)

        lblDocumento.Text &= empleado.CI
        lblNombre.Text &= empleado.Nombre1 & " " & empleado.Apellido1


        lblApertura.Text &= caja.Apertura
        lblCierre.Text &= caja.Cierre

        lblStartUYU.Text &= caja.Dinero.Item(0).DineroIncial
        lblFinalUYU.Text &= caja.Dinero.Item(0).DineroFinal

        lblStartUSD.Text &= caja.Dinero.Item(1).DineroIncial
        lblFinalUSD.Text &= caja.Dinero.Item(1).DineroFinal


        For Each movimiento As Entities.Movimiento In caja.Movimientos  '.OrderByDescending(Function(x) x.Fecha)

            Dim item As New ListViewItem

            item = lstMovimientos.Items.Add(movimiento.NumeroCuenta)

            Dim tipoRow() As DataRow = GetMovementType.Select("Value=" & movimiento.Tipo)
            For Each row As DataRow In tipoRow
                item.SubItems.Add(row(1))
            Next

            item.SubItems.Add(movimiento.Monto)

            Dim monedaRow() As DataRow = GetCurrencyType.Select("Value=" & movimiento.MonedaId)
            For Each row As DataRow In monedaRow
                item.SubItems.Add(row(1))
            Next


            item.SubItems.Add(movimiento.Fecha)
        Next

    End Sub
End Class