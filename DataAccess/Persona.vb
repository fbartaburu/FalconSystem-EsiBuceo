Public Class Persona

    Function Datos(ByVal ci As Integer) As Entities.Persona
        Dim ret As New Entities.Persona

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from persona where ci=" & ci
                Dim myReader = command.ExecuteReader

                If Not myReader.HasRows Then
                    ret = Nothing
                End If

                While myReader.Read
                    ret.CI = myReader.GetInt32(0)
                    ret.Nombre1 = myReader.GetString(1).Trim
                    ret.Nombre2 = myReader.GetString(2).Trim
                    ret.Apellido1 = myReader.GetString(3).Trim
                    ret.Apellido2 = myReader.GetString(4).Trim
                    ret.FechaNacimiento = myReader.GetDate(5)
                    ret.EstadoCivil = myReader.GetChar(6)
                    ret.Nacionalidad = myReader.GetString(7).Trim
                    ret.Direccion = myReader.GetString(8).Trim
                    ret.Email = myReader.GetString(9).Trim
                    ret.Telefono1 = myReader.GetInt32(10)
                    ret.Telefono2 = myReader.GetInt32(11)
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
