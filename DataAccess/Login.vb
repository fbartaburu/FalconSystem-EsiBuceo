Public Class Login

    Function Login(ByRef data As Entities.Login) As Object
        Dim ret As New Object

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                If data.Tipo Then 'Login de Cliente

                    command.CommandText = "Select * from cliente C join persona P On C.ci=P.ci where C.ci='" & data.Usuario & "' and C.pin='" & data.Contrasena & "' and C.estado='1'"
                    Dim myReader = command.ExecuteReader
                    Dim cliente As New Entities.Cliente
                    If myReader.HasRows Then
                        While myReader.Read
                            cliente.CI = myReader.GetInt32(0)
                            cliente.Pin = myReader.GetString(1).Trim
                            cliente.Estado = myReader.GetString(2).Trim
                            cliente.Nombre1 = myReader.GetString(4).Trim
                            cliente.Nombre2 = myReader.GetString(5).Trim
                            cliente.Apellido1 = myReader.GetString(6).Trim
                            cliente.Apellido2 = myReader.GetString(7).Trim
                            cliente.FechaNacimiento = myReader.GetDate(8)
                            cliente.EstadoCivil = myReader.GetChar(9)
                            cliente.Nacionalidad = myReader.GetString(10).Trim
                            cliente.Direccion = myReader.GetString(11).Trim
                            cliente.Email = myReader.GetString(12).Trim
                            cliente.Telefono1 = myReader.GetInt32(13)
                            cliente.Telefono2 = myReader.GetInt32(14)
                        End While
                        ret = cliente
                    Else
                        ret = Nothing
                    End If
                    myReader.Close()
                Else 'Login de Empleado
                    command.CommandText = "select * from empleado E join persona P On E.ci=P.ci where E.usuario='" & data.Usuario & "' and estado='1';"
                    Dim myReader = command.ExecuteReader
                    Dim empleado As New Entities.Empleado
                    While myReader.Read
                        empleado.CI = myReader.GetInt32(0)
                        empleado.Cargo = myReader.GetInt32(1)
                        empleado.Usuario = myReader.GetString(2).Trim
                        empleado.Estado = myReader.GetString(3).Trim
                        empleado.Nombre1 = myReader.GetString(5).Trim
                        empleado.Nombre2 = myReader.GetString(6).Trim
                        empleado.Apellido1 = myReader.GetString(7).Trim
                        empleado.Apellido2 = myReader.GetString(8).Trim
                        empleado.FechaNacimiento = myReader.GetDate(9)
                        empleado.EstadoCivil = myReader.GetChar(10)
                        empleado.Nacionalidad = myReader.GetString(11).Trim
                        empleado.Direccion = myReader.GetString(12).Trim
                        empleado.Email = myReader.GetString(13).Trim
                        empleado.Telefono1 = myReader.GetInt32(14)
                        empleado.Telefono2 = myReader.GetInt32(15)
                    End While
                    ret = empleado
                    myReader.Close()
                End If

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
