Public Class Cheque
    'Nuevas
    Function NuevaChequera(ByVal chequera As Entities.Chequera) As Boolean
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

                command.CommandText = "Insert into chequera (numero, numerocuentacorriente, tipo, diacobrocruzado) values (" & chequera.Numero & ", " & chequera.NumeroCuenta & ", '" & chequera.Tipo & "', " & chequera.DiaCobroCruzado & ")"
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

    Function CobroCheque(ByVal cheque As Entities.Cheque, ByVal empleadoCajaId As Integer) As Boolean
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

                command.CommandText = "Insert into cheque (numero, idmoneda, monto, emision) values (" & cheque.Numero & ", " & cheque.MonedaId & ", '" & cheque.Monto & "', '" & cheque.Emision.ToString("yyyy-MM-dd") & "');"
                command.ExecuteNonQuery()

                If cheque.NumeroChequera <> 0 Then
                    command.CommandText = "Insert into chequera_cheque (numerocheque, numerochequera) values (" & cheque.Numero & ", " & cheque.NumeroChequera & ");"
                    command.ExecuteNonQuery()

                    'Realizar el retiro de la cuenta en cuestion
                    Dim retiro As New Entities.Movimiento
                    retiro.Fecha = Today.Date
                    retiro.MonedaId = cheque.MonedaId
                    retiro.Monto = cheque.Monto
                    retiro.Tipo = 2

                    command.CommandText = "Select numerocuentacorriente from chequera where numero=" & cheque.NumeroChequera
                    Dim myReader = command.ExecuteReader

                    While myReader.Read
                        retiro.NumeroCuenta = myReader.GetInt32(0)
                    End While
                    myReader.Close()

                    Dim monto As Single
                    'Comprobar el tipo de moneda
                    Dim daCuenta As New Cuenta
                    Dim cuenta As Entities.Cuenta = daCuenta.Datos(retiro.NumeroCuenta)

                    If cuenta.MonedaId <> retiro.MonedaId Then ' Cambio de moneda
                        monto = retiro.Monto

                        Dim daMoneda As New Moneda
                        Dim moneda1 = daMoneda.GetData(retiro.MonedaId)
                        monto *= moneda1.Valor

                        Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                        monto /= moneda2.Valor

                        retiro.Monto = monto
                    End If

                    If cuenta.Saldo >= retiro.Monto Then
                        retiro.Monto = cuenta.Saldo - retiro.Monto
                        command.CommandText = "Update cuenta set saldo='" & retiro.Monto.ToString.Replace(",", ".") & "' where numero=" & retiro.NumeroCuenta
                        command.ExecuteNonQuery()
                    End If

                End If

                command.CommandText = "Insert into cobro_cheque (numerocheque, idempleadocaja, fecha) values (" & cheque.Numero & ", " & empleadoCajaId & ", '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "');"
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

    Function LisatdoChequera(ByVal numeroCuenta As Integer) As List(Of Entities.Chequera)
        Dim ret As New List(Of Entities.Chequera)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from chequera where numerocuentacorriente=" & numeroCuenta
                Dim myReader = command.ExecuteReader()
                Dim chequera As Entities.Chequera

                While myReader.Read
                    chequera = New Entities.Chequera
                    chequera.Numero = myReader.GetInt32(0)
                    chequera.NumeroCuenta = myReader.GetInt32(1)
                    chequera.Tipo = myReader.GetInt32(2)
                    chequera.DiaCobroCruzado = myReader.GetInt32(3)
                    ret.Add(chequera)
                End While

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

    Function LisatdoCheque(ByVal numeroChequera As Integer) As List(Of Entities.ChequeCobrado)
        Dim ret As New List(Of Entities.ChequeCobrado)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from cheque C join chequera_cheque CC on CC.numerocheque=C.numero Join cobro_cheque CCF on CCF.numerocheque=C.numero where CC.numerochequera=" & numeroChequera
                Dim myReader = command.ExecuteReader()
                Dim cheque As Entities.ChequeCobrado

                While myReader.Read
                    cheque = New Entities.ChequeCobrado
                    cheque.Numero = myReader.GetInt32(0)
                    cheque.MonedaId = myReader.GetInt32(1)
                    cheque.Monto = myReader.GetValue(2)
                    cheque.Emision = myReader.GetDate(3)
                    cheque.NumeroChequera = myReader.GetInt32(5)
                    cheque.FechaCobro = myReader.GetDateTime(8)
                    ret.Add(cheque)
                End While

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
