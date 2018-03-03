Public Class frmListadoCajas
    Dim sucursales As List(Of Entities.Sucursal)
    Dim cajas As List(Of Entities.Caja)

    Private Sub frmListadoCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bSucursal As New Business.Sucursal

        sucursales = bSucursal.Listado

        For Each sucursal As Entities.Sucursal In sucursales
            Dim item As New ListViewItem
            item = lstSucursales.Items.Add(sucursal.Nombre)
            item.SubItems.Add(sucursal.Departamento)
        Next
    End Sub

    Private Sub lstSucursales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSucursales.Click
        lstCajas.Items.Clear()

        Dim sucursal As Entities.Sucursal = sucursales.Item(lstSucursales.SelectedIndices(0))

        Dim bCaja As New Business.Caja

        cajas = bCaja.Listado(sucursal.Id)

        For Each caja As Entities.Caja In cajas
            Dim item As New ListViewItem
            item = lstCajas.Items.Add(caja.Nombre)
            item.SubItems.Add(caja.Ip)
            If bCaja.GetStatus(caja.Id) Then
                item.SubItems.Add(My.Resources.CajaAbierta)
            Else
                item.SubItems.Add(My.Resources.CajaCerrada)
            End If
        Next
    End Sub

    Private Sub lstCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCajas.Click
        With frmDatosCaja
            .cajaId = cajas.Item(lstCajas.SelectedIndices(0)).Id
            .MdiParent = Me.MdiParent
            .Show()
        End With
    End Sub

    Private Sub txtBuscarSucursal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarSucursal.TextChanged
        lstSucursales.Items.Clear()
        If sucursales IsNot Nothing And sucursales.Count <> 0 Then
            For Each sucursal As Entities.Sucursal In sucursales.Where(Function(x) x.Nombre.ToLower.Contains(txtBuscarSucursal.Text.ToLower))
                Dim item As New ListViewItem
                item = lstSucursales.Items.Add(sucursal.Nombre)
                item.SubItems.Add(sucursal.Departamento)
            Next
        End If
    End Sub

    Private Sub txtBuscarCaja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCaja.TextChanged
        lstCajas.Items.Clear()

        If cajas IsNot Nothing Then
            If cajas.Count <> 0 Then
                Dim bCaja As New Business.Caja

                For Each caja As Entities.Caja In cajas.Where(Function(x) x.Nombre.ToLower.Contains(txtBuscarCaja.Text.ToLower))
                    Dim item As New ListViewItem
                    item = lstCajas.Items.Add(caja.Nombre)
                    item.SubItems.Add(caja.Ip)
                    If bCaja.GetStatus(caja.Id) Then
                        item.SubItems.Add(My.Resources.CajaAbierta)
                    Else
                        item.SubItems.Add(My.Resources.CajaCerrada)
                    End If
                Next
            End If
        End If

    End Sub
End Class