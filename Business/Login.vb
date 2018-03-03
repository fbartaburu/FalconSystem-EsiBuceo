Public Class Login


    Function Login(ByRef data As Entities.Login) As Object
        Dim ret As New Object
        Dim daLogin As New DataAccess.Login

        If data.Contrasena.Length = 4 Then
            data.Tipo = True
        Else
            data.Tipo = False
        End If

        ret = daLogin.Login(data)

        Return ret
    End Function

End Class
