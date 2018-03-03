Module Connection

    Function ConectionString() As String
        Dim user As Entities.Login = Entities.Login.GetSingleton()
        Dim ret As String = String.Empty

        If user.Tipo Then
            ret = "Driver={IBM INFORMIX ODBC DRIVER (64-bit)};uid=fbartaburu;pwd=Fabian@3226;database=falcon_system_proyecto;host=192.168.5.50;srvr=ol_esi;serv=9088;pro=olsoctcp"
        Else
            ret = "Driver={IBM INFORMIX ODBC DRIVER (64-bit)};uid=" & user.Usuario & ";pwd=" & user.Contrasena & ";database=falcon_system_proyecto;host=192.168.5.50;srvr=ol_esi;serv=9088;pro=olsoctcp"
        End If

        Return ret
    End Function

End Module
