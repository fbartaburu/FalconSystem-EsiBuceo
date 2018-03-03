Public Class Moneda

    Function GetData(ByVal idMoneda As Integer) As Entities.Moneda 
        Dim ret As New Entities.Moneda

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from moneda where id=" & idMoneda
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    ret.Id = myReader.GetInt32(0)
                    ret.Nombre = myReader.GetString(1)
                    ret.Valor = myReader.GetValue(2)
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

    Function GetOldValues(ByVal idMoneda As Integer) As List(Of Entities.ValoresMoneda)
        Dim ret As New List(Of Entities.ValoresMoneda)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from cambia_valor_moneda where idmoneda=" & idMoneda & " order by fecha desc"
                Dim myReader = command.ExecuteReader
                Dim valor As Entities.ValoresMoneda
                While myReader.Read
                    valor = New Entities.ValoresMoneda
                    valor.Id = myReader.GetInt32(0)
                    valor.IdEmpleadoCaja = myReader.GetInt32(1)
                    valor.IdMoneda = myReader.GetInt32(2)
                    valor.Valor = myReader.GetValue(3)
                    valor.Fecha = myReader.GetDateTime(4)
                    ret.Add(valor)
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

    Function ActualizarMoneda(ByVal valorMoneda As Entities.ValoresMoneda) As Boolean
        Dim ret As Boolean

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Update moneda set valor='" & valorMoneda.Valor & "' where id = " & valorMoneda.IdMoneda
                command.ExecuteNonQuery()

                command.CommandText = "Insert into cambia_valor_moneda (idmoneda, idempleadocaja, valor, fecha) values (" & valorMoneda.IdMoneda & ", " & valorMoneda.IdEmpleadoCaja & ", '" & valorMoneda.Valor & "', '" & valorMoneda.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "')"
                command.ExecuteNonQuery()

                transaction.Commit()
                ret = True
            Catch ex As Exception
                If connection.State = ConnectionState.Open Then
                    transaction.Rollback()
                End If
            Finally
                connection.Close()
            End Try

        End Using

        Return ret
    End Function

End Class
