Public Class frmEstadoChequera
    Dim actualChequera As Integer = -1
    Dim chequeras As List(Of Entities.Chequera)

    Private Sub frmEstadoChequera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bChequera As New Business.Cheque
        chequeras = bChequera.ListadoChequeras(frmClientePrincipal.cboCuentas.SelectedValue)
        cboChequeras.DataSource = chequeras
        cboChequeras.ValueMember = "Numero"
        cboChequeras.DisplayMember = "Numero"
    End Sub

    Private Sub cboChequeras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChequeras.SelectedIndexChanged
        If cboChequeras.SelectedIndex <> actualChequera Then
            actualChequera = cboChequeras.SelectedIndex
            Dim bCheque As New Business.Cheque

            lstCheques.Items.Clear()
            For Each cheque As Entities.ChequeCobrado In bCheque.ListadoCheques(chequeras.Item(actualChequera).Numero)
                Dim item As New ListViewItem

                item = lstCheques.Items.Add(cheque.Numero)
                item.SubItems.Add(cheque.Monto)

                For Each row As DataRow In GetCurrencyType.Select("Value=" & cheque.MonedaId)
                    item.SubItems.Add(row(1))
                Next

                item.SubItems.Add(cheque.Emision)
                item.SubItems.Add(cheque.FechaCobro)
            Next

        End If
    End Sub
End Class