Public Class Empleado

    Function Datos(ByVal ci As String) As Entities.Empleado
        Dim ret As New Entities.Empleado

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from empleado E join persona P on E.ci=P.ci where E.ci=" & ci
                Dim myReader = command.ExecuteReader

                If Not myReader.HasRows Then
                    ret = Nothing
                End If

                While myReader.Read
                    ret.CI = myReader.GetInt32(0)
                    ret.Cargo = myReader.GetInt32(1)
                    ret.Usuario = myReader.GetString(2).Trim
                    ret.Estado = myReader.GetBoolean(3)

                    ret.Nombre1 = myReader.GetString(5).Trim
                    ret.Nombre2 = myReader.GetString(6).Trim
                    ret.Apellido1 = myReader.GetString(7).Trim
                    ret.Apellido2 = myReader.GetString(8).Trim
                    ret.FechaNacimiento = myReader.GetDate(9)
                    ret.EstadoCivil = myReader.GetChar(10)
                    ret.Nacionalidad = myReader.GetString(11).Trim
                    ret.Direccion = myReader.GetString(12).Trim
                    ret.Email = myReader.GetString(13).Trim
                    ret.Telefono1 = myReader.GetInt32(14)
                    ret.Telefono2 = myReader.GetInt32(15)
                End While
                myReader.Close()

                transaction.Commit()
            Catch ex As Exception
                If connection.State = ConnectionState.Open Then
                    transaction.Rollback()
                End If

                ret = Nothing
            Finally
                connection.Close()
            End Try

        End Using

        Return ret
    End Function

End Class
