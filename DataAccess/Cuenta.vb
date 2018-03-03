Public Class Cuenta

    Function NuevaCuenta(ByVal cuenta As Entities.Cuenta, ByVal emleadoCajaId As Integer) As Boolean
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
                command.CommandText = "Insert into cuenta (idmoneda, saldo, estado) values (" & cuenta.MonedaId & ", " & cuenta.Saldo & ", '1')"
                command.ExecuteNonQuery()

                'Conseguir el número de la cuenta anteriormente agregada
                command.CommandText = "Select MAX(numero) from cuenta"
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    cuenta.Numero = myReader.GetInt32(0)
                End While
                myReader.Close()

                'Guardar cuenta dependiendo del tipo (Ahorro, Corriente)
                If cuenta.Tipo = 0 Then
                    command.CommandText = "Insert into cuenta_ahorro values (" & cuenta.Numero & ");"
                Else
                    command.CommandText = "Insert into cuenta_corriente values (" & cuenta.Numero & ");"
                End If
                command.ExecuteNonQuery()

                'Dar acceso al cliente como propietario
                command.CommandText = "Insert into cliente_cuenta (ci, numerocuenta, propietario, estado) values (" & cuenta.Clientes.Item(0).Clientes.CI & ", " & cuenta.Numero & ", '1', '1');"
                command.ExecuteNonQuery()

                'Guardar que empleado creo la cuenta
                command.CommandText = "Insert into empleado_crea_cuenta values (" & cuenta.Numero & ", " & emleadoCajaId & ", '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "');"
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

    Function ListadoCuentas(ByVal ci As Integer) As List(Of Integer)
        Dim ret As New List(Of Integer)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from cliente_cuenta where ci=" & ci & " and estado='1';"
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    ret.Add(myReader.GetInt32(1))
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

    Function Datos(ByVal numeroCuenta As Integer) As Entities.Cuenta
        Dim ret As New Entities.Cuenta

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from cuenta C left join cuenta_ahorro CA on C.numero=CA.numero left join cuenta_corriente CC on C.numero=CC.numero where C.numero=" & numeroCuenta
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    ret.Numero = myReader.GetInt32(0)
                    ret.MonedaId = myReader.GetInt32(1)
                    ret.Saldo = myReader.GetInt32(2)
                    ret.Estado = myReader.GetInt32(3)
                    If myReader.IsDBNull(4) Then
                        ret.Tipo = 2
                    Else
                        ret.Tipo = 1
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

    Function GetClientAccess(ByVal numeroCuenta As Integer) As List(Of Entities.AccesoCuenta)
        Dim ret As New List(Of Entities.AccesoCuenta)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select ci, propietario from cliente_cuenta where numerocuenta=" & numeroCuenta & " and estado='1'"
                Dim myReader = command.ExecuteReader
                Dim accesoCuenta As Entities.AccesoCuenta
                While myReader.Read
                    accesoCuenta = New Entities.AccesoCuenta
                    accesoCuenta.Clientes.CI = myReader.GetInt32(0)
                    accesoCuenta.Propietario = myReader.GetInt32(1)

                    ret.Add(accesoCuenta)
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

    Function GrantAccess(ByVal ci As Integer, ByVal numeroCuenta As Integer) As Boolean
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

                command.CommandText = "select estado from cliente_cuenta where ci=" & ci & " and numerocuenta= " & numeroCuenta
                Dim myReader = command.ExecuteReader
                Dim hadAccess As Boolean
                If myReader.HasRows Then
                    hadAccess = True
                End If
                myReader.Close()

                If hadAccess Then
                    command.CommandText = "update cliente_cuenta set estado='1' where ci=" & ci & " and numerocuenta= " & numeroCuenta
                    command.ExecuteNonQuery()
                Else
                    command.CommandText = "Insert into cliente_cuenta (ci, numerocuenta, propietario, estado) values (" & ci & ", " & numeroCuenta & ", '0', '1');"
                    command.ExecuteNonQuery()
                End If

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

    Function RevokeAccess(ByVal ci As Integer, ByVal numeroCuenta As Integer) As Boolean
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

                command.CommandText = "select estado from cliente_cuenta where ci=" & ci & " and numerocuenta= " & numeroCuenta
                Dim myReader = command.ExecuteReader
                Dim hadAccess As Boolean
                If myReader.HasRows Then
                    hadAccess = True
                End If
                myReader.Close()

                If hadAccess Then
                    command.CommandText = "update cliente_cuenta set estado='0' where ci=" & ci & " and numerocuenta= " & numeroCuenta
                    command.ExecuteNonQuery()
                End If

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

    Function Cerrar(ByVal numeroCuenta As Integer) As Boolean
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

                command.CommandText = "update cuenta set estado='0' where numero= " & numeroCuenta
                command.ExecuteNonQuery()

                command.CommandText = "update cliente_cuenta set estado='0' where numerocuenta= " & numeroCuenta
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
