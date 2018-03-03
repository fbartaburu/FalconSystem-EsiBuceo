Public Class Moneda

    Function GetValue(ByVal id As Integer) As Entities.Moneda
        Dim ret As Entities.Moneda

        Dim daMoneda As New DataAccess.Moneda
        ret = daMoneda.GetData(id)
        ret.ListaAntiguosValores = daMoneda.GetOldValues(id)

        Return ret
    End Function

    Function CambiarValor(ByVal valorMoneda As Entities.ValoresMoneda) As Boolean
        Dim daMoneda As New DataAccess.Moneda

        Return daMoneda.ActualizarMoneda(valorMoneda)
    End Function

End Class
