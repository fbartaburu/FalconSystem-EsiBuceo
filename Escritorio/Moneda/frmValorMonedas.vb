Public Class frmValorMonedas

    Private Sub frmValorMonedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bMoneda As New Business.Moneda
        'UYU
        Dim uyuData As Entities.Moneda = bMoneda.GetValue(1)

        lblUYUValorActual.Text &= uyuData.Valor
        For Each valores As Entities.ValoresMoneda In uyuData.ListaAntiguosValores
            Dim item As New ListViewItem
            item = lstUYU.Items.Add(valores.Valor)
            item.SubItems.Add(valores.Fecha)
        Next


        'USD
        Dim usdData As Entities.Moneda = bMoneda.GetValue(2)

        lblUSDValorActual.Text &= usdData.Valor
        For Each valores As Entities.ValoresMoneda In usdData.ListaAntiguosValores
            Dim item As New ListViewItem
            item = lstUSD.Items.Add(valores.Valor)
            item.SubItems.Add(valores.Fecha)
        Next

        If empleadoLogueado.Cargo = 4 Or empleadoLogueado.Cargo = 3 Then
            gpUSD.Height = 405
            gpUYU.Height = 405
            Me.Height = 455
        End If

    End Sub

    Private Sub btnCambiarUYU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarUYU.Click
        With frmCambioValorMoneda
            .monedaId = 1
            .MdiParent = Me.MdiParent
            .Show()
        End With
    End Sub

    Private Sub btnCambiarUSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarUSD.Click
        With frmCambioValorMoneda
            .monedaId = 2
            .MdiParent = Me.MdiParent
            .Show()
        End With
    End Sub
End Class