Public Class Sucursal

    Function Listado() As List(Of Entities.Sucursal)
        Dim daS As New DataAccess.Sucursal

        Return daS.Listado()
    End Function

End Class
