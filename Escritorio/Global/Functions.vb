Imports System.Resources

Module Functions

    Function GetEmployeePosition() As String

        If empleadoLogueado.Cargo = 1 Then
            Return My.Resources.Admin
        ElseIf empleadoLogueado.Cargo = 2 Then
            Return My.Resources.Gerente
        ElseIf empleadoLogueado.Cargo = 3 Then
            Return My.Resources.AComercial
        ElseIf empleadoLogueado.Cargo = 4 Then
            Return My.Resources.Cajero
        End If

        Return String.Empty
    End Function


    Function GetDepartments() As List(Of String)
        Dim departamentos As New List(Of String)

        departamentos.Add("Artigas")
        departamentos.Add("Canelones")
        departamentos.Add("Cerro Largo")
        departamentos.Add("Colonia")
        departamentos.Add("Durazno")
        departamentos.Add("Flores")
        departamentos.Add("Florida")
        departamentos.Add("Lavalleja")
        departamentos.Add("Maldonado")
        departamentos.Add("Montevideo")
        departamentos.Add("Paysandú")
        departamentos.Add("Río Negro")
        departamentos.Add("Rivera")
        departamentos.Add("San José")
        departamentos.Add("Soriano")
        departamentos.Add("Tacuarmbó")
        departamentos.Add("Treinta y Tres")

        Return departamentos
    End Function

    Function GetCivilStatus() As DataTable
        Dim civilStatus As DataTable
        civilStatus = New DataTable("CivilStatus")

        civilStatus.Columns.Add("Value", GetType(String))
        civilStatus.Columns.Add("Display", GetType(String))

        civilStatus.Rows.Add("S", My.Resources.Soltero)
        civilStatus.Rows.Add("C", My.Resources.Casado)
        civilStatus.Rows.Add("V", My.Resources.Viudo)

        Return civilStatus
    End Function

    Function GetNationalities() As DataTable
        Dim nationalities As DataTable
        nationalities = New DataTable("Nationalities")

        nationalities.Columns.Add("Display", GetType(String))

        nationalities.Rows.Add("Uruguayo")
        nationalities.Rows.Add("Argentino")
        nationalities.Rows.Add("Brasilero")

        Return nationalities
    End Function

    Function GetAccountType() As DataTable
        Dim accountType As DataTable
        accountType = New DataTable("AccountType")

        accountType.Columns.Add("Value", GetType(Integer))
        accountType.Columns.Add("Display", GetType(String))

        accountType.Rows.Add(0, My.Resources.CuentaAhorro)
        accountType.Rows.Add(1, My.Resources.CuentaCorriente)

        Return accountType
    End Function

    Function GetCurrencyType() As DataTable
        Dim currencyType As DataTable
        currencyType = New DataTable("CurrencyType")

        currencyType.Columns.Add("Value", GetType(Integer))
        currencyType.Columns.Add("Display", GetType(String))

        currencyType.Rows.Add(1, My.Resources.MonedaPesoUYU)
        currencyType.Rows.Add(2, My.Resources.MonedaDolarUSD)

        Return currencyType
    End Function

    Function GetMovementType() As DataTable
        Dim movementType As DataTable
        movementType = New DataTable("CurrencyType")

        movementType.Columns.Add("Value", GetType(Integer))
        movementType.Columns.Add("Display", GetType(String))

        movementType.Rows.Add(1, My.Resources.Deposito)
        movementType.Rows.Add(2, My.Resources.Retiro)
        movementType.Rows.Add(3, My.Resources.Transferencia)

        Return movementType
    End Function

    Function GetCheckBookType() As DataTable
        Dim checkBookType As DataTable
        checkBookType = New DataTable("CheckBookType")

        checkBookType.Columns.Add("Value", GetType(Integer))
        checkBookType.Columns.Add("Display", GetType(String))

        checkBookType.Rows.Add(0, My.Resources.ChequeDirecto)
        checkBookType.Rows.Add(1, My.Resources.ChequeDiferido)

        Return checkBookType
    End Function

    Function GetDatedDay() As List(Of Integer)
        Dim diaDiferido As New List(Of Integer)

        For i = 1 To 31
            diaDiferido.Add(i)
        Next

        Return diaDiferido
    End Function


    Public Sub OpenMdiChild(ByVal frm As Form)
        frm.MdiParent = frmPrincipal
        frm.Show()
    End Sub


    ''' <summary>
    ''' Verifica el texto ingresado en los textboxes
    ''' </summary>
    ''' <param name="sender">TextBox</param>
    ''' <param name="e">KeyPressEvent</param>
    ''' <param name="length">Largo</param>
    ''' <param name="isNumeric">Acepta números</param>
    ''' <param name="isLetter">Acepta letras</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function CorrectInput(ByVal sender As TextBox, _
                                 ByVal e As System.Windows.Forms.KeyPressEventArgs, _
                                 ByVal length As Integer, _
                                 ByVal isNumeric As Boolean, _
                                 ByVal isLetter As Boolean, _
                                 ByVal isMoney As Boolean) As Boolean

        If sender.Text.Length <= length Then
            If isMoney Then
                If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
                    Return True
                Else
                    Return False
                End If
            ElseIf isNumeric And Not isLetter Then ' Solo Numeros
                If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then
                    Return True
                Else
                    Return False
                End If
            ElseIf Not isNumeric And isLetter Then ' Solo Letras
                If Not (Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar)) Then
                    Return True
                Else
                    Return False
                End If
            ElseIf isNumeric And isLetter Then ' Ambos
                If Not (Char.IsControl(e.KeyChar) Or Char.IsLetterOrDigit(e.KeyChar) Or Char.IsSeparator(e.KeyChar)) Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                Return False
            End If
            Return True
        End If



    End Function

    Public Function TextBoxIsEmpty(ByVal frm As Form) As Boolean
        Dim ret As Boolean
        Dim ctrl As Control

        For Each ctrl In frm.Controls.OfType(Of System.Windows.Forms.TextBox).OrderBy(Function(x) x.TabIndex)
            Dim txt As System.Windows.Forms.TextBox = CType(ctrl, System.Windows.Forms.TextBox)
            If txt.Text.Equals(String.Empty) Then
                txt.Focus()
                ret = True
                Return ret
            End If
        Next

        ret = False

        Return ret
    End Function



End Module
