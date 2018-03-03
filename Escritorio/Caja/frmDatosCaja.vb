Public Class frmDatosCaja
    Public cajaId As Integer
    Dim empleadoCajaId As Integer
    Dim empleadosCaja As List(Of Entities.EmpleadoCaja)

    Private Sub frmDatosCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bCaja As New Business.Caja
        Dim bEmpleado As New Business.Empleado
        empleadosCaja = bCaja.GetEmpleadosCaja(cajaId)

        If empleadosCaja.Count > 0 Then
            If empleadosCaja.Item(0).Cierre = New DateTime Then
                empleadoCajaId = empleadosCaja.Item(0).Id
                Dim empleado = bEmpleado.GetEmployeeByCI(empleadosCaja.Item(0).Ci)
                lblEmpleadoData.Text = empleado.CI & " - " & empleado.Nombre1 & " " & empleado.Apellido1
                lblAperturaData.Text = empleadosCaja.Item(0).Apertura
                btnMovimientos.Visible = True
                If empleado.Cargo = 4 Then
                    btnMovimientos.Enabled = True
                End If
            End If

            For i = 1 To empleadosCaja.Count - 1
                Dim item As New ListViewItem
                item = lstEmpleados.Items.Add(empleadosCaja.Item(i).Ci)
                Dim empleado = bEmpleado.GetEmployeeByCI(empleadosCaja.Item(i).Ci)
                item.SubItems.Add(empleado.Nombre1 & " " & empleado.Apellido1)
                item.SubItems.Add(empleadosCaja.Item(i).Apertura)
                item.SubItems.Add(empleadosCaja.Item(i).Cierre)

            Next
        End If
        
    End Sub

    Private Sub btnMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovimientos.Click
        frmMovimientos.empleadoCajaId = empleadoCajaId
        OpenMdiChild(frmMovimientos)
    End Sub

    Private Sub lstEmpleados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmpleados.DoubleClick
        frmMovimientos.empleadoCajaId = empleadosCaja.Item(lstEmpleados.SelectedIndices(0) + 1).Id
        OpenMdiChild(frmMovimientos)
    End Sub
End Class