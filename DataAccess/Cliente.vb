Public Class Cliente

    Function Datos(ByVal ci As Integer) As Entities.Cliente
        Dim ret As New Entities.Cliente

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from cliente C join persona P on C.ci=P.ci where C.ci=" & ci
                Dim myReader = command.ExecuteReader

                If Not myReader.HasRows Then
                    ret = Nothing
                End If

                While myReader.Read
                    ret.CI = myReader.GetInt32(0)
                    ret.Pin = myReader.GetString(1).Trim
                    ret.Estado = myReader.GetBoolean(2)
                    ret.Nombre1 = myReader.GetString(4).Trim
                    ret.Nombre2 = myReader.GetString(5).Trim
                    ret.Apellido1 = myReader.GetString(6).Trim
                    ret.Apellido2 = myReader.GetString(7).Trim
                    ret.FechaNacimiento = myReader.GetDate(8)
                    ret.EstadoCivil = myReader.GetChar(9)
                    ret.Nacionalidad = myReader.GetString(10).Trim
                    ret.Direccion = myReader.GetString(11).Trim
                    ret.Email = myReader.GetString(12).Trim
                    ret.Telefono1 = myReader.GetInt32(13)
                    If Not myReader.IsDBNull(14) Then
                        ret.Telefono2 = myReader.GetInt32(14)
                    Else
                        ret.Telefono2 = String.Empty
                    End If
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

    Function Nuevo(ByVal cliente As Entities.Cliente) As Boolean
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

                'Crear nueva cuenta
                command.CommandText = "Select ci from persona where ci=" & cliente.CI
                Dim myReader = command.ExecuteReader()
                Dim existePersona As Boolean = myReader.HasRows
                myReader.Close()

                If Not existePersona Then
                    command.CommandText = "Insert into persona (ci, nombre1, nombre2, apellido1, apellido2, fechanac, estadocivil, nacionalidad, direccion, email, telefono1, telefono2) values (" & cliente.CI & ", '" & cliente.Nombre1 & "', '" & cliente.Nombre2 & "', '" & cliente.Apellido1 & "', '" & cliente.Apellido2 & "', '" & cliente.FechaNacimiento.ToString("yyyy-MM-dd") & "', '" & cliente.EstadoCivil & "', '" & cliente.Nacionalidad & "', '" & cliente.Direccion & "', '" & cliente.Email & "', '" & cliente.Telefono1 & "', '" & cliente.Telefono2 & "')"
                    command.ExecuteNonQuery()
                End If

                command.CommandText = "Insert into cliente (ci, estado) values (" & cliente.CI & ", '1')"
                command.ExecuteNonQuery()

                transaction.Commit()
                ret = True
            Catch ex As Exception
                If connection.State = ConnectionState.Open Then
                    transaction.Rollback()
                End If
                ret = False
            Finally
                connection.Close()
            End Try

        End Using

        Return ret
    End Function

    Function CambiarPin(ByVal cliente As Entities.Cliente) As Boolean
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

                'Cambiar Pin
                command.CommandText = "Update cliente set pin='" & cliente.Pin & "' where ci=" & cliente.CI
                command.ExecuteNonQuery()

                transaction.Commit()
                ret = True
            Catch ex As Exception
                If connection.State = ConnectionState.Open Then
                    transaction.Rollback()
                End If
                ret = False
            Finally
                connection.Close()
            End Try

        End Using

        Return ret
    End Function

    Function Actualizar(ByVal cliente As Entities.Cliente) As Boolean
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

                command.CommandText = "update persona set nombre1='" & cliente.Nombre1 & "', nombre2='" & cliente.Nombre2 & "', apellido1='" & cliente.Apellido1 & "', apellido2='" & cliente.Apellido2 & "', fechanac='" & cliente.FechaNacimiento.ToString("yyyy-MM-dd") & "', estadocivil='" & cliente.EstadoCivil & "', nacionalidad='" & cliente.Nacionalidad & "', direccion='" & cliente.Direccion & "', email='" & cliente.Email & "', telefono1='" & cliente.Telefono1 & "', telefono2='" & cliente.Telefono2 & "' where ci='" & cliente.CI & "'"
                command.ExecuteNonQuery()

                transaction.Commit()
                ret = True
            Catch ex As Exception
                If connection.State = ConnectionState.Open Then
                    transaction.Rollback()
                End If
                ret = False
            Finally
                connection.Close()
            End Try

        End Using

        Return ret
    End Function
End Class
