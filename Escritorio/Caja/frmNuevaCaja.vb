Public Class frmNuevaCaja

    Private Sub frmNuevaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargo los datos en el formulario
        Dim bCaja As New Business.Caja
        Dim caja As Entities.Caja = bCaja.GetMyCajaData
        lblIPData.Text = caja.Ip
        lblNombreData.Text = caja.Nombre

        'Listado de sucursales
        Dim bSucursal As New Business.Sucursal
        cboSucursales.DataSource = bSucursal.Listado
        cboSucursales.DisplayMember = "Nombre"
        cboSucursales.ValueMember = "Id"


    End Sub

    Private Sub btnNuevaCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCaja.Click
        Dim caja As New Entities.Caja

        caja.IdSucursal = cboSucursales.SelectedValue
        caja.Ip = lblIPData.Text
        caja.Nombre = lblNombreData.Text

        Dim bCaja As New Business.Caja

        If bCaja.Nueva(caja) Then
            MessageBox.Show(My.Resources.MsgCajaCreada)
            frmPrincipal.Show()
            Me.Close()
        Else
            MessageBox.Show(My.Resources.MsgCajaNoCreada)
        End If


    End Sub
End Class