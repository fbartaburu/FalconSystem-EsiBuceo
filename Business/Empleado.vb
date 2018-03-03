Public Class Empleado

    Function GetEmployeeByCI(ByVal ci As Integer) As Entities.Empleado
        Dim daE As New DataAccess.Empleado

        Return daE.Datos(ci)
    End Function

End Class
