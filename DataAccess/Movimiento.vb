Public Class Movimiento

    'Nuevas
    Function GetDepositByAccountId(ByVal numeroCuenta As Integer) As List(Of Entities.Movimiento)
        Dim ret As New List(Of Entities.Movimiento)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from movimiento M join deposito D on M.id=D.idmovimiento where M.numerocuenta=" & numeroCuenta
                Dim myReader = command.ExecuteReader
                Dim deposito As Entities.Movimiento
                While myReader.Read
                    deposito = New Entities.Deposito
                    deposito.Id = myReader.GetInt32(0)
                    deposito.NumeroCuenta = myReader.GetInt32(1)
                    deposito.MonedaId = myReader.GetInt32(2)
                    deposito.Monto = myReader.GetValue(3)
                    deposito.Fecha = myReader.GetDateTime(4)
                    deposito.Tipo = 1
                    ret.Add(deposito)
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

    Function GetWithdrawByAccountId(ByVal numeroCuenta As Integer) As List(Of Entities.Movimiento)
        Dim ret As New List(Of Entities.Movimiento)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from movimiento M join retiro R on M.id=R.idmovimiento where M.numerocuenta=" & numeroCuenta
                Dim myReader = command.ExecuteReader
                Dim retiro As Entities.Movimiento
                While myReader.Read
                    retiro = New Entities.Deposito
                    retiro.Id = myReader.GetInt32(0)
                    retiro.NumeroCuenta = myReader.GetInt32(1)
                    retiro.MonedaId = myReader.GetInt32(2)
                    retiro.Monto = myReader.GetValue(3)
                    retiro.Fecha = myReader.GetDateTime(4)
                    retiro.Tipo = 2
                    ret.Add(retiro)
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

    Function GetTransferByAccountId(ByVal numeroCuenta As Integer) As List(Of Entities.Movimiento)
        Dim ret As New List(Of Entities.Movimiento)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from movimiento M join transferencia T on M.id=T.idmovimiento where M.numerocuenta=" & numeroCuenta & " or T.numerocuentadestino=" & numeroCuenta
                Dim myReader = command.ExecuteReader
                Dim transferencia As Entities.Movimiento
                While myReader.Read
                    transferencia = New Entities.Deposito
                    transferencia.Id = myReader.GetInt32(0)
                    transferencia.NumeroCuenta = myReader.GetInt32(1)
                    transferencia.MonedaId = myReader.GetInt32(2)
                    transferencia.Monto = myReader.GetValue(3)
                    transferencia.Fecha = myReader.GetDateTime(4)
                    transferencia.Tipo = 3
                    ret.Add(transferencia)
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

    Function Deposito(ByVal movement As Entities.Deposito, ByVal empleadoCajaId As Integer) As Boolean
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

                'Crear nuevo Movimiento
                command.CommandText = "Insert into movimiento (numerocuenta, idmoneda, monto, fecha) values (" & movement.NumeroCuenta & ", " & movement.MonedaId & ", '" & movement.Monto & "', '" & movement.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "');"
                command.ExecuteNonQuery()

                'Conseguir el ID del movimiento agregado
                command.CommandText = "Select MAX(id) from movimiento;"
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    movement.Id = myReader.GetInt32(0)
                End While
                myReader.Close()

                'Guardar el ID del movimiento en Depósito
                command.CommandText = "Insert into deposito values (" & movement.Id & ", '" & movement.IsClient & "');"
                command.ExecuteNonQuery()

                'Quien generó el Depósito
                command.CommandText = "Insert into empleado_crea_movimiento values (" & movement.Id & ", " & empleadoCajaId & ");"
                command.ExecuteNonQuery()


                'Comprobar el tipo de moneda
                Dim daCuenta As New Cuenta
                Dim cuenta As Entities.Cuenta = daCuenta.Datos(movement.NumeroCuenta)

                If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                    Dim monto As Single = movement.Monto

                    Dim daMoneda As New Moneda
                    Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                    monto *= moneda1.Valor

                    Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                    monto /= moneda2.Valor

                    movement.Monto = monto
                End If

                movement.Monto += cuenta.Saldo

                'Actualizar Saldo en la Cuenta
                command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuenta & ""
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

    Function Retiro(ByVal movement As Entities.Movimiento, ByVal empleadoCajaId As Integer) As Boolean
        Dim ret As Boolean
        Dim monto As Single

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                'Comprobar el tipo de moneda
                Dim daCuenta As New Cuenta
                Dim cuenta As Entities.Cuenta = daCuenta.Datos(movement.NumeroCuenta)

                If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                    monto = movement.Monto

                    Dim daMoneda As New Moneda
                    Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                    monto *= moneda1.Valor

                    Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                    monto /= moneda2.Valor

                End If

                If cuenta.Saldo >= movement.Monto Then
                    'Crear nuevo Movimiento
                    command.CommandText = "Insert into movimiento (numerocuenta, idmoneda, monto, fecha) values (" & movement.NumeroCuenta & ", " & movement.MonedaId & ", '" & movement.Monto & "', '" & movement.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "');"
                    command.ExecuteNonQuery()

                    If monto <> 0 Then
                        movement.Monto = monto
                    End If

                    'Conseguir el ID del movimiento agregado
                    command.CommandText = "Select MAX(id) from movimiento;"
                    Dim myReader = command.ExecuteReader
                    While myReader.Read
                        movement.Id = myReader.GetInt32(0)
                    End While
                    myReader.Close()

                    'Guardar el ID del movimiento en Retiro
                    command.CommandText = "Insert into retiro values (" & movement.Id & ");"
                    command.ExecuteNonQuery()

                    'Quien generó el Retiro
                    command.CommandText = "Insert into empleado_crea_movimiento values (" & movement.Id & ", " & empleadoCajaId & ");"
                    command.ExecuteNonQuery()

                    movement.Monto = cuenta.Saldo - movement.Monto

                    'Actualizar Saldo en la Cuenta
                    command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuenta & ""
                    command.ExecuteNonQuery()

                    ret = True
                End If

                transaction.Commit()

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

    Function Transferencia(ByVal movement As Entities.Transferencia, ByVal empleadoCajaId As Integer) As Boolean
        Dim ret As Boolean

        Dim monto As Single
        Dim montoOriginal As Single = movement.Monto

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                'Comprobar el tipo de moneda
                Dim cuenta As New Entities.Cuenta
                command.CommandText = "select * from cuenta C left join cuenta_ahorro CA on C.numero=CA.numero left join cuenta_corriente CC on C.numero=CC.numero where C.numero=" & movement.NumeroCuenta
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    cuenta.Numero = myReader.GetInt32(0)
                    cuenta.MonedaId = myReader.GetInt32(1)
                    cuenta.Saldo = myReader.GetInt32(2)
                    cuenta.Estado = myReader.GetInt32(3)
                    If myReader.IsDBNull(4) Then
                        cuenta.Tipo = 2
                    Else
                        cuenta.Tipo = 1
                    End If
                End While
                myReader.Close()

                If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                    monto = movement.Monto

                    Dim daMoneda As New Moneda
                    Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                    monto *= moneda1.Valor

                    Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                    monto /= moneda2.Valor

                    movement.Monto = monto
                End If

                If cuenta.Saldo >= movement.Monto Then
                    'Crear nuevo Movimiento
                    command.CommandText = "Insert into movimiento (numerocuenta, idmoneda, monto, fecha) values (" & movement.NumeroCuenta & ", " & movement.MonedaId & ", '" & montoOriginal & "', '" & movement.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "');"
                    command.ExecuteNonQuery()

                    'Conseguir el ID del movimiento agregado
                    command.CommandText = "Select MAX(id) from movimiento;"
                    myReader = command.ExecuteReader
                    While myReader.Read
                        movement.Id = myReader.GetInt32(0)
                    End While
                    myReader.Close()

                    'Guardar el ID del movimiento en Transferencia
                    command.CommandText = "Insert into transferencia values (" & movement.Id & ", " & movement.NumeroCuentaDestino & ");"
                    command.ExecuteNonQuery()

                    'Quien generó el Transferencia
                    command.CommandText = "Insert into empleado_crea_movimiento values (" & movement.Id & ", " & empleadoCajaId & ");"
                    command.ExecuteNonQuery()

                    movement.Monto = cuenta.Saldo - movement.Monto

                    'Actualizar Saldo en la Cuenta
                    command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuenta & ""
                    command.ExecuteNonQuery()

                    cuenta = New Entities.Cuenta
                    command.CommandText = "select * from cuenta C left join cuenta_ahorro CA on C.numero=CA.numero left join cuenta_corriente CC on C.numero=CC.numero where C.numero=" & movement.NumeroCuentaDestino
                    myReader = command.ExecuteReader
                    While myReader.Read
                        cuenta.Numero = myReader.GetInt32(0)
                        cuenta.MonedaId = myReader.GetInt32(1)
                        cuenta.Saldo = myReader.GetInt32(2)
                        cuenta.Estado = myReader.GetInt32(3)
                        If myReader.IsDBNull(4) Then
                            cuenta.Tipo = 2
                        Else
                            cuenta.Tipo = 1
                        End If
                    End While
                    myReader.Close()

                    movement.Monto = montoOriginal
                    If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                        monto = movement.Monto

                        Dim daMoneda As New Moneda
                        Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                        monto *= moneda1.Valor

                        Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                        monto /= moneda2.Valor

                        movement.Monto = monto
                    End If

                    movement.Monto += cuenta.Saldo

                    'Actualizar Saldo en la Cuenta
                    command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuentaDestino & ""
                    command.ExecuteNonQuery()

                    ret = True
                End If

                transaction.Commit()

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

    Function GetMovementsByWorkstation(ByVal empleadoCajaId As Integer) As Entities.MovimientosCaja
        Dim ret As New Entities.MovimientosCaja

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "select * from empleado_caja where id=" & empleadoCajaId
                Dim myReader = command.ExecuteReader

                While myReader.Read
                    ret.Id = myReader.GetInt32(0)
                    ret.Ci = myReader.GetInt32(1)
                    ret.IdCaja = myReader.GetInt32(2)
                    ret.Apertura = myReader.GetDateTime(3)
                    If Not myReader.IsDBNull(4) Then
                        ret.Cierre = myReader.GetDateTime(4)
                    End If
                End While
                myReader.Close()


                command.CommandText = "select * from dinero_caja where idempleadocaja=" & empleadoCajaId
                myReader = command.ExecuteReader
                Dim dinero As Entities.DineroCaja

                While myReader.Read
                    dinero = New Entities.DineroCaja
                    dinero.IdEmpleadoCaja = myReader.GetInt32(0)
                    dinero.IdMoneda = myReader.GetInt32(1)
                    dinero.DineroIncial = myReader.GetValue(2)
                    dinero.DineroFinal = myReader.GetValue(3)
                    ret.Dinero.Add(dinero)
                End While
                myReader.Close()

                command.CommandText = "select * from empleado_crea_movimiento ECM join movimiento M on M.id=ECM.idmovimiento left join retiro R on M.id=R.idmovimiento left join deposito D on M.id=D.idmovimiento left join transferencia T on M.id=T.idmovimiento where ECM.idempleadocaja=" & empleadoCajaId
                myReader = command.ExecuteReader
                Dim movimiento As Entities.Movimiento

                While myReader.Read
                    movimiento = New Entities.Movimiento
                    movimiento.Id = myReader.GetInt32(0)
                    movimiento.NumeroCuenta = myReader.GetInt32(3)
                    movimiento.MonedaId = myReader.GetInt32(4)
                    movimiento.Monto = myReader.GetValue(5)
                    movimiento.Fecha = myReader.GetDateTime(6)
                    If Not myReader.IsDBNull(7) Then
                        movimiento.Tipo = 2
                    ElseIf Not myReader.IsDBNull(8) Then
                        movimiento.Tipo = 1
                    Else
                        movimiento.Tipo = 3
                    End If
                    ret.Movimientos.Add(movimiento)
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

    Function RetiroCliente(ByVal movement As Entities.Movimiento, ByVal ci As Integer) As Boolean
        Dim ret As Boolean
        Dim monto As Single

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                'Comprobar el tipo de moneda
                Dim daCuenta As New Cuenta
                Dim cuenta As Entities.Cuenta = daCuenta.Datos(movement.NumeroCuenta)

                If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                    monto = movement.Monto

                    Dim daMoneda As New Moneda
                    Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                    monto *= moneda1.Valor

                    Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                    monto /= moneda2.Valor

                End If

                If cuenta.Saldo >= movement.Monto Then
                    'Crear nuevo Movimiento
                    command.CommandText = "Insert into movimiento (numerocuenta, idmoneda, monto, fecha) values (" & movement.NumeroCuenta & ", " & movement.MonedaId & ", '" & movement.Monto & "', '" & movement.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "');"
                    command.ExecuteNonQuery()

                    If monto <> 0 Then
                        movement.Monto = monto
                    End If

                    'Conseguir el ID del movimiento agregado
                    command.CommandText = "Select MAX(id) from movimiento;"
                    Dim myReader = command.ExecuteReader
                    While myReader.Read
                        movement.Id = myReader.GetInt32(0)
                    End While
                    myReader.Close()

                    'Guardar el ID del movimiento en Retiro
                    command.CommandText = "Insert into retiro values (" & movement.Id & ");"
                    command.ExecuteNonQuery()

                    'Quien generó el Retiro
                    command.CommandText = "Insert into cliente_crea_movimiento values (" & movement.Id & ", " & ci & ");"
                    command.ExecuteNonQuery()

                    movement.Monto = cuenta.Saldo - movement.Monto

                    'Actualizar Saldo en la Cuenta
                    command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuenta & ""
                    command.ExecuteNonQuery()

                    ret = True
                End If

                transaction.Commit()

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

    Function DepositoCliente(ByVal movement As Entities.Deposito, ByVal ci As Integer) As Boolean
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

                'Crear nuevo Movimiento
                command.CommandText = "Insert into movimiento (numerocuenta, idmoneda, monto, fecha) values (" & movement.NumeroCuenta & ", " & movement.MonedaId & ", '" & movement.Monto & "', '" & movement.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "');"
                command.ExecuteNonQuery()

                'Conseguir el ID del movimiento agregado
                command.CommandText = "Select MAX(id) from movimiento;"
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    movement.Id = myReader.GetInt32(0)
                End While
                myReader.Close()

                'Guardar el ID del movimiento en Depósito
                command.CommandText = "Insert into deposito values (" & movement.Id & ", '" & movement.IsClient & "');"
                command.ExecuteNonQuery()

                'Quien generó el Depósito
                command.CommandText = "Insert into cliente_crea_movimiento values (" & movement.Id & ", " & ci & ");"
                command.ExecuteNonQuery()


                'Comprobar el tipo de moneda
                Dim daCuenta As New Cuenta
                Dim cuenta As Entities.Cuenta = daCuenta.Datos(movement.NumeroCuenta)

                If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                    Dim monto As Single = movement.Monto

                    Dim daMoneda As New Moneda
                    Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                    monto *= moneda1.Valor

                    Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                    monto /= moneda2.Valor

                    movement.Monto = monto
                End If

                movement.Monto += cuenta.Saldo

                'Actualizar Saldo en la Cuenta
                command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuenta & ""
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

    Function TransferenciaCliente(ByVal movement As Entities.Transferencia, ByVal ci As Integer) As Boolean
        Dim ret As Boolean

        Dim monto As Single
        Dim montoOriginal As Single = movement.Monto

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                'Comprobar el tipo de moneda
                Dim cuenta As New Entities.Cuenta
                command.CommandText = "select * from cuenta C left join cuenta_ahorro CA on C.numero=CA.numero left join cuenta_corriente CC on C.numero=CC.numero where C.numero=" & movement.NumeroCuenta
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    cuenta.Numero = myReader.GetInt32(0)
                    cuenta.MonedaId = myReader.GetInt32(1)
                    cuenta.Saldo = myReader.GetInt32(2)
                    cuenta.Estado = myReader.GetInt32(3)
                    If myReader.IsDBNull(4) Then
                        cuenta.Tipo = 2
                    Else
                        cuenta.Tipo = 1
                    End If
                End While
                myReader.Close()

                If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                    monto = movement.Monto

                    Dim daMoneda As New Moneda
                    Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                    monto *= moneda1.Valor

                    Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                    monto /= moneda2.Valor

                    movement.Monto = monto
                End If

                If cuenta.Saldo >= movement.Monto Then
                    'Crear nuevo Movimiento
                    command.CommandText = "Insert into movimiento (numerocuenta, idmoneda, monto, fecha) values (" & movement.NumeroCuenta & ", " & movement.MonedaId & ", '" & montoOriginal & "', '" & movement.Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "');"
                    command.ExecuteNonQuery()

                    'Conseguir el ID del movimiento agregado
                    command.CommandText = "Select MAX(id) from movimiento;"
                    myReader = command.ExecuteReader
                    While myReader.Read
                        movement.Id = myReader.GetInt32(0)
                    End While
                    myReader.Close()

                    'Guardar el ID del movimiento en Transferencia
                    command.CommandText = "Insert into transferencia values (" & movement.Id & ", " & movement.NumeroCuentaDestino & ");"
                    command.ExecuteNonQuery()

                    'Quien generó el Transferencia
                    command.CommandText = "Insert into cliente_crea_movimiento values (" & movement.Id & ", " & ci & ");"
                    command.ExecuteNonQuery()

                    movement.Monto = cuenta.Saldo - movement.Monto

                    'Actualizar Saldo en la Cuenta
                    command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuenta & ""
                    command.ExecuteNonQuery()

                    cuenta = New Entities.Cuenta
                    command.CommandText = "select * from cuenta C left join cuenta_ahorro CA on C.numero=CA.numero left join cuenta_corriente CC on C.numero=CC.numero where C.numero=" & movement.NumeroCuentaDestino
                    myReader = command.ExecuteReader
                    While myReader.Read
                        cuenta.Numero = myReader.GetInt32(0)
                        cuenta.MonedaId = myReader.GetInt32(1)
                        cuenta.Saldo = myReader.GetInt32(2)
                        cuenta.Estado = myReader.GetInt32(3)
                        If myReader.IsDBNull(4) Then
                            cuenta.Tipo = 2
                        Else
                            cuenta.Tipo = 1
                        End If
                    End While
                    myReader.Close()

                    movement.Monto = montoOriginal
                    If cuenta.MonedaId <> movement.MonedaId Then ' Cambio de moneda
                        monto = movement.Monto

                        Dim daMoneda As New Moneda
                        Dim moneda1 = daMoneda.GetData(movement.MonedaId)
                        monto *= moneda1.Valor

                        Dim moneda2 = daMoneda.GetData(cuenta.MonedaId)
                        monto /= moneda2.Valor

                        movement.Monto = monto
                    End If

                    movement.Monto += cuenta.Saldo

                    'Actualizar Saldo en la Cuenta
                    command.CommandText = "Update cuenta set saldo='" & movement.Monto.ToString.Replace(",", ".") & "' where numero=" & movement.NumeroCuentaDestino & ""
                    command.ExecuteNonQuery()

                    ret = True
                End If

                transaction.Commit()
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
