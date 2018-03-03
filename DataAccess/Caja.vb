Public Class Caja

    Function Existe(ByVal caja As Entities.Caja) As Entities.Caja
        Dim ret As New Entities.Caja

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select * from caja where nombre='" & caja.Nombre & "' and ip='" & caja.Ip & "'"
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    ret.Id = myReader.GetInt32(0)
                    ret.IdSucursal = myReader.GetInt32(1)
                    ret.Nombre = myReader.GetString(2).Trim
                    ret.Ip = myReader.GetString(3).Trim
                End While
                myReader.Close()

                If ret.Id = 0 Then
                    ret = Nothing
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

    Function Nueva(ByVal caja As Entities.Caja) As Boolean
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

                'Crear nueva Caja
                command.CommandText = "Insert into caja (idsucursal, nombre, ip) values (" & caja.IdSucursal & ", '" & caja.Nombre & "', '" & caja.Ip & "')"
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

    Function AsignarEmpleado(ByVal empleadoCaja As Entities.EmpleadoCaja) As Entities.EmpleadoCaja

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                'Crear nueva Asignacion de Empleado
                command.CommandText = "Insert into empleado_caja (ci, idcaja, apertura) values ('" & empleadoCaja.Ci & "', " & empleadoCaja.IdCaja & ", '" & empleadoCaja.Apertura.ToString("yyyy-MM-dd HH:mm:ss") & "')"
                command.ExecuteNonQuery()

                'Consigo el último id generado
                command.CommandText = "Select MAX(id) from empleado_caja"
                command.Connection = connection
                Dim myReader = command.ExecuteReader
                While myReader.Read
                    empleadoCaja.Id = myReader.GetInt32(0)
                End While
                myReader.Close()

                transaction.Commit()
            Catch ex As Exception
                If connection.State = ConnectionState.Open Then
                    transaction.Rollback()
                End If
            Finally
                connection.Close()
            End Try

        End Using

        Return empleadoCaja
    End Function

    Function DineroCaja(ByVal dinero As List(Of Entities.DineroCaja)) As Boolean
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

                'Dinero UYU
                command.CommandText = "Insert into dinero_caja (idempleadocaja, idmoneda, inicial) values (" & dinero.Item(0).IdEmpleadoCaja & ", " & dinero.Item(0).IdMoneda & ", " & dinero.Item(0).DineroIncial.ToString.Replace(",", ".") & ")"
                command.ExecuteNonQuery()

                'Dinero USD
                command.CommandText = "Insert into dinero_caja (idempleadocaja, idmoneda, inicial) values (" & dinero.Item(1).IdEmpleadoCaja & ", " & dinero.Item(1).IdMoneda & ", " & dinero.Item(1).DineroIncial.ToString.Replace(",", ".") & ")"
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

    Function CerrarCaja(ByVal empleadoCaja As Entities.EmpleadoCaja, ByVal dinero As List(Of Entities.DineroCaja)) As Boolean
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

                'Cerrar Caja
                command.CommandText = "Update empleado_caja set cierre='" & empleadoCaja.Cierre.ToString("yyyy-MM-dd HH:mm:ss") & "' where id = " & empleadoCaja.Id
                command.ExecuteNonQuery()

                'Dinero Final UYU
                command.CommandText = "Update dinero_caja set final='" & dinero.Item(0).DineroFinal & "' where idempleadocaja = " & dinero.Item(0).IdEmpleadoCaja & " and idmoneda=" & dinero.Item(0).IdMoneda
                command.ExecuteNonQuery()

                'Dinero Final USD
                command.CommandText = "Update dinero_caja set final='" & dinero.Item(1).DineroFinal & "' where idempleadocaja = " & dinero.Item(1).IdEmpleadoCaja & " and idmoneda=" & dinero.Item(1).IdMoneda
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

    Function CerrarCaja(ByVal empleadoCaja As Entities.EmpleadoCaja) As Boolean
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

                'Cerrar Caja
                command.CommandText = "Update empleado_caja set cierre='" & empleadoCaja.Cierre.ToString("yyyy-MM-dd HH:mm:ss") & "' where id = " & empleadoCaja.Id
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

    Function Listado(ByVal idSucursal As Integer) As List(Of Entities.Caja)
        Dim ret As New List(Of Entities.Caja)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                'Crear nueva Caja
                command.CommandText = "Select * from caja where idsucursal=" & idSucursal
                Dim myReader = command.ExecuteReader
                Dim caja As Entities.Caja
                While myReader.Read
                    caja = New Entities.Caja
                    caja.Id = myReader.GetInt32(0)
                    caja.IdSucursal = myReader.GetInt32(1)
                    caja.Nombre = myReader.GetString(2).Trim
                    caja.Ip = myReader.GetString(3).Trim
                    ret.Add(caja)
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

    Function GetEmpleadosCaja(ByVal idCaja As Integer) As List(Of Entities.EmpleadoCaja)
        Dim ret As New List(Of Entities.EmpleadoCaja)

        Using connection As New Odbc.OdbcConnection(ConectionString())
            Dim command As New Odbc.OdbcCommand()
            Dim transaction As Odbc.OdbcTransaction
            command.Connection = connection

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                command.Connection = connection
                command.Transaction = transaction

                command.CommandText = "Select LIMIT 20 * from empleado_caja EC join empleado E on EC.ci=E.ci where EC.idcaja=" & idCaja & " and (E.idcargo=4 or EC.cierre Is NULL) ORDER BY apertura DESC"
                Dim myReader = command.ExecuteReader
                Dim empleadoCaja As Entities.EmpleadoCaja
                While myReader.Read
                    empleadoCaja = New Entities.EmpleadoCaja
                    empleadoCaja.Id = myReader.GetInt32(0)
                    empleadoCaja.Ci = myReader.GetInt32(1)
                    empleadoCaja.IdCaja = myReader.GetInt32(2)
                    empleadoCaja.Apertura = myReader.GetDateTime(3)
                    If Not myReader.IsDBNull(4) Then
                        empleadoCaja.Cierre = myReader.GetDateTime(4)
                    End If
                    ret.Add(empleadoCaja)
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

    Function GetStatus(ByVal idCaja As Integer) As Boolean
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

                command.CommandText = "select first 1 * from empleado_caja where idcaja=" & idCaja & " order by id desc;"
                Dim myReader = command.ExecuteReader

                While myReader.Read
                    If myReader.IsDBNull(4) Then
                        ret = True
                    Else
                        ret = False
                    End If
                End While

                transaction.Commit()
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
