Public Class Sucursal

    Function Listado() As List(Of Entities.Sucursal)
        Dim ret As New List(Of Entities.Sucursal)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from sucursal"
                Dim myReader = command.ExecuteReader
                Dim sucursal As Entities.Sucursal
                While myReader.Read
                    sucursal = New Entities.Sucursal
                    sucursal.Id = myReader.GetInt32(0)
                    sucursal.Nombre = myReader.GetString(1).Trim
                    sucursal.Departamento = myReader.GetString(2).Trim
                    sucursal.Direccion = myReader.GetString(3).Trim
                    ret.Add(sucursal)
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
