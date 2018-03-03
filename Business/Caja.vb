Public Class Caja

    ''' <summary>
    ''' Comprueba si la caja ya existe en la BD
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Existe() As Boolean
        Dim caja As Entities.Caja = GetMyCajaData()
        Dim daCaja As New DataAccess.Caja

        If daCaja.Existe(caja) Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Datos de la caja actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetMyCajaData() As Entities.Caja
        Dim caja As New Entities.Caja
        caja.Nombre = My.Computer.Name
        caja.Ip = System.Net.Dns.GetHostByName(caja.Nombre).AddressList(0).ToString

        Return caja
    End Function

    ''' <summary>
    ''' Guardar los datos de la caja en la BD
    ''' </summary>
    ''' <param name="caja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Nueva(ByVal caja As Entities.Caja) As Boolean
        Dim daCaja As New DataAccess.Caja

        Return daCaja.Nueva(caja)
    End Function

    ''' <summary>
    ''' Asignar empleado a la caja
    ''' </summary>
    ''' <param name="ci"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function AsignarEmpleado(ByVal ci As Integer) As Entities.EmpleadoCaja
        'Datos de la caja
        Dim caja As Entities.Caja = GetMyCajaData()
        Dim daCaja As New DataAccess.Caja
        caja = daCaja.Existe(caja)

        Dim empleadoCaja As New Entities.EmpleadoCaja
        empleadoCaja.IdCaja = caja.Id
        empleadoCaja.Ci = ci
        empleadoCaja.Apertura = DateTime.Now

        empleadoCaja = daCaja.AsignarEmpleado(empleadoCaja)

        If empleadoCaja.Id <> 0 Then
            Return empleadoCaja
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Dinero de la caja (Solo para cajeros)
    ''' </summary>
    ''' <param name="dinero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DineroCaja(ByVal dinero As List(Of Entities.DineroCaja)) As Boolean
        Dim daCaja As New DataAccess.Caja

        Return daCaja.DineroCaja(dinero)
    End Function

    ''' <summary>
    ''' Cerrar dinero de la caja (Solo para cajeros)
    ''' </summary>
    ''' <param name="empleadoCaja"></param>
    ''' <param name="dineroList"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CerrarCaja(ByVal empleadoCaja As Entities.EmpleadoCaja, ByVal dineroList As List(Of Entities.DineroCaja)) As Boolean
        empleadoCaja.Cierre = DateTime.Now

        Dim daCaja As New DataAccess.Caja
        Return daCaja.CerrarCaja(empleadoCaja, dineroList)
    End Function

    Function CerrarCaja(ByVal empleadoCaja As Entities.EmpleadoCaja) As Boolean
        empleadoCaja.Cierre = DateTime.Now

        Dim daCaja As New DataAccess.Caja
        Return daCaja.CerrarCaja(empleadoCaja)
    End Function

    Function Listado(ByVal idSucursal As Integer) As List(Of Entities.Caja)
        Dim daCaja As New DataAccess.Caja

        Return daCaja.Listado(idSucursal)
    End Function

    Function GetEmpleadosCaja(ByVal idCaja As Integer) As List(Of Entities.EmpleadoCaja)
        Dim daCaja As New DataAccess.Caja

        Return daCaja.GetEmpleadosCaja(idCaja)
    End Function

    Function GetStatus(ByVal idCaja As Integer) As Boolean
        Dim daCaja As New DataAccess.Caja

        Return daCaja.GetStatus(idCaja)
    End Function

End Class
