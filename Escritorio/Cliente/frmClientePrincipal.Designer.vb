<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientePrincipal
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientePrincipal))
        Me.gbCuentas = New System.Windows.Forms.GroupBox
        Me.cboCuentas = New System.Windows.Forms.ComboBox
        Me.btnNuevaCuenta = New System.Windows.Forms.Button
        Me.gbChequera = New System.Windows.Forms.GroupBox
        Me.btnEstadoChequera = New System.Windows.Forms.Button
        Me.btnNuevaChequera = New System.Windows.Forms.Button
        Me.gbMovimientos = New System.Windows.Forms.GroupBox
        Me.lstMovimientos = New System.Windows.Forms.ListView
        Me.colTipo = New System.Windows.Forms.ColumnHeader
        Me.colCantidad = New System.Windows.Forms.ColumnHeader
        Me.colMoneda = New System.Windows.Forms.ColumnHeader
        Me.colFecha = New System.Windows.Forms.ColumnHeader
        Me.gbAcciones = New System.Windows.Forms.GroupBox
        Me.btnCerrarCuenta = New System.Windows.Forms.Button
        Me.btnTransferencia = New System.Windows.Forms.Button
        Me.btnDeposito = New System.Windows.Forms.Button
        Me.btnRetiro = New System.Windows.Forms.Button
        Me.btnAcceso = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.gbAccesoClientes = New System.Windows.Forms.GroupBox
        Me.lstAcceso = New System.Windows.Forms.ListView
        Me.colDocumento = New System.Windows.Forms.ColumnHeader
        Me.colNombre = New System.Windows.Forms.ColumnHeader
        Me.gbSaldo = New System.Windows.Forms.GroupBox
        Me.lblPropietarioData = New System.Windows.Forms.Label
        Me.lblPropietario = New System.Windows.Forms.Label
        Me.lblMonedaData = New System.Windows.Forms.Label
        Me.lblSaldoData = New System.Windows.Forms.Label
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.lblSaldo = New System.Windows.Forms.Label
        Me.gbCliente = New System.Windows.Forms.GroupBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.gbCuentas.SuspendLayout()
        Me.gbChequera.SuspendLayout()
        Me.gbMovimientos.SuspendLayout()
        Me.gbAcciones.SuspendLayout()
        Me.gbAccesoClientes.SuspendLayout()
        Me.gbSaldo.SuspendLayout()
        Me.gbCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCuentas
        '
        Me.gbCuentas.AccessibleDescription = Nothing
        Me.gbCuentas.AccessibleName = Nothing
        resources.ApplyResources(Me.gbCuentas, "gbCuentas")
        Me.gbCuentas.BackgroundImage = Nothing
        Me.gbCuentas.Controls.Add(Me.cboCuentas)
        Me.gbCuentas.Controls.Add(Me.btnNuevaCuenta)
        Me.gbCuentas.Font = Nothing
        Me.gbCuentas.Name = "gbCuentas"
        Me.gbCuentas.TabStop = False
        '
        'cboCuentas
        '
        Me.cboCuentas.AccessibleDescription = Nothing
        Me.cboCuentas.AccessibleName = Nothing
        resources.ApplyResources(Me.cboCuentas, "cboCuentas")
        Me.cboCuentas.BackgroundImage = Nothing
        Me.cboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuentas.Font = Nothing
        Me.cboCuentas.FormattingEnabled = True
        Me.cboCuentas.Name = "cboCuentas"
        '
        'btnNuevaCuenta
        '
        Me.btnNuevaCuenta.AccessibleDescription = Nothing
        Me.btnNuevaCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNuevaCuenta, "btnNuevaCuenta")
        Me.btnNuevaCuenta.BackgroundImage = Nothing
        Me.btnNuevaCuenta.Font = Nothing
        Me.btnNuevaCuenta.Name = "btnNuevaCuenta"
        Me.btnNuevaCuenta.UseVisualStyleBackColor = True
        '
        'gbChequera
        '
        Me.gbChequera.AccessibleDescription = Nothing
        Me.gbChequera.AccessibleName = Nothing
        resources.ApplyResources(Me.gbChequera, "gbChequera")
        Me.gbChequera.BackgroundImage = Nothing
        Me.gbChequera.Controls.Add(Me.btnEstadoChequera)
        Me.gbChequera.Controls.Add(Me.btnNuevaChequera)
        Me.gbChequera.Font = Nothing
        Me.gbChequera.Name = "gbChequera"
        Me.gbChequera.TabStop = False
        '
        'btnEstadoChequera
        '
        Me.btnEstadoChequera.AccessibleDescription = Nothing
        Me.btnEstadoChequera.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEstadoChequera, "btnEstadoChequera")
        Me.btnEstadoChequera.BackgroundImage = Nothing
        Me.btnEstadoChequera.Font = Nothing
        Me.btnEstadoChequera.Name = "btnEstadoChequera"
        Me.btnEstadoChequera.UseVisualStyleBackColor = True
        '
        'btnNuevaChequera
        '
        Me.btnNuevaChequera.AccessibleDescription = Nothing
        Me.btnNuevaChequera.AccessibleName = Nothing
        resources.ApplyResources(Me.btnNuevaChequera, "btnNuevaChequera")
        Me.btnNuevaChequera.BackgroundImage = Nothing
        Me.btnNuevaChequera.Font = Nothing
        Me.btnNuevaChequera.Name = "btnNuevaChequera"
        Me.btnNuevaChequera.UseVisualStyleBackColor = True
        '
        'gbMovimientos
        '
        Me.gbMovimientos.AccessibleDescription = Nothing
        Me.gbMovimientos.AccessibleName = Nothing
        resources.ApplyResources(Me.gbMovimientos, "gbMovimientos")
        Me.gbMovimientos.BackgroundImage = Nothing
        Me.gbMovimientos.Controls.Add(Me.lstMovimientos)
        Me.gbMovimientos.Font = Nothing
        Me.gbMovimientos.Name = "gbMovimientos"
        Me.gbMovimientos.TabStop = False
        '
        'lstMovimientos
        '
        Me.lstMovimientos.AccessibleDescription = Nothing
        Me.lstMovimientos.AccessibleName = Nothing
        resources.ApplyResources(Me.lstMovimientos, "lstMovimientos")
        Me.lstMovimientos.BackgroundImage = Nothing
        Me.lstMovimientos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTipo, Me.colCantidad, Me.colMoneda, Me.colFecha})
        Me.lstMovimientos.Font = Nothing
        Me.lstMovimientos.FullRowSelect = True
        Me.lstMovimientos.MultiSelect = False
        Me.lstMovimientos.Name = "lstMovimientos"
        Me.lstMovimientos.UseCompatibleStateImageBehavior = False
        Me.lstMovimientos.View = System.Windows.Forms.View.Details
        '
        'colTipo
        '
        resources.ApplyResources(Me.colTipo, "colTipo")
        '
        'colCantidad
        '
        resources.ApplyResources(Me.colCantidad, "colCantidad")
        '
        'colMoneda
        '
        resources.ApplyResources(Me.colMoneda, "colMoneda")
        '
        'colFecha
        '
        resources.ApplyResources(Me.colFecha, "colFecha")
        '
        'gbAcciones
        '
        Me.gbAcciones.AccessibleDescription = Nothing
        Me.gbAcciones.AccessibleName = Nothing
        resources.ApplyResources(Me.gbAcciones, "gbAcciones")
        Me.gbAcciones.BackgroundImage = Nothing
        Me.gbAcciones.Controls.Add(Me.btnCerrarCuenta)
        Me.gbAcciones.Controls.Add(Me.btnTransferencia)
        Me.gbAcciones.Controls.Add(Me.btnDeposito)
        Me.gbAcciones.Controls.Add(Me.btnRetiro)
        Me.gbAcciones.Font = Nothing
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.TabStop = False
        '
        'btnCerrarCuenta
        '
        Me.btnCerrarCuenta.AccessibleDescription = Nothing
        Me.btnCerrarCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCerrarCuenta, "btnCerrarCuenta")
        Me.btnCerrarCuenta.BackgroundImage = Nothing
        Me.btnCerrarCuenta.Font = Nothing
        Me.btnCerrarCuenta.Name = "btnCerrarCuenta"
        Me.btnCerrarCuenta.UseVisualStyleBackColor = True
        '
        'btnTransferencia
        '
        Me.btnTransferencia.AccessibleDescription = Nothing
        Me.btnTransferencia.AccessibleName = Nothing
        resources.ApplyResources(Me.btnTransferencia, "btnTransferencia")
        Me.btnTransferencia.BackgroundImage = Nothing
        Me.btnTransferencia.Font = Nothing
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.UseVisualStyleBackColor = True
        '
        'btnDeposito
        '
        Me.btnDeposito.AccessibleDescription = Nothing
        Me.btnDeposito.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDeposito, "btnDeposito")
        Me.btnDeposito.BackgroundImage = Nothing
        Me.btnDeposito.Font = Nothing
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.UseVisualStyleBackColor = True
        '
        'btnRetiro
        '
        Me.btnRetiro.AccessibleDescription = Nothing
        Me.btnRetiro.AccessibleName = Nothing
        resources.ApplyResources(Me.btnRetiro, "btnRetiro")
        Me.btnRetiro.BackgroundImage = Nothing
        Me.btnRetiro.Font = Nothing
        Me.btnRetiro.Name = "btnRetiro"
        Me.btnRetiro.UseVisualStyleBackColor = True
        '
        'btnAcceso
        '
        Me.btnAcceso.AccessibleDescription = Nothing
        Me.btnAcceso.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAcceso, "btnAcceso")
        Me.btnAcceso.BackgroundImage = Nothing
        Me.btnAcceso.Font = Nothing
        Me.btnAcceso.Name = "btnAcceso"
        Me.btnAcceso.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.AccessibleDescription = Nothing
        Me.btnQuitar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnQuitar, "btnQuitar")
        Me.btnQuitar.BackgroundImage = Nothing
        Me.btnQuitar.Font = Nothing
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'gbAccesoClientes
        '
        Me.gbAccesoClientes.AccessibleDescription = Nothing
        Me.gbAccesoClientes.AccessibleName = Nothing
        resources.ApplyResources(Me.gbAccesoClientes, "gbAccesoClientes")
        Me.gbAccesoClientes.BackgroundImage = Nothing
        Me.gbAccesoClientes.Controls.Add(Me.lstAcceso)
        Me.gbAccesoClientes.Controls.Add(Me.btnQuitar)
        Me.gbAccesoClientes.Controls.Add(Me.btnAcceso)
        Me.gbAccesoClientes.Font = Nothing
        Me.gbAccesoClientes.Name = "gbAccesoClientes"
        Me.gbAccesoClientes.TabStop = False
        '
        'lstAcceso
        '
        Me.lstAcceso.AccessibleDescription = Nothing
        Me.lstAcceso.AccessibleName = Nothing
        resources.ApplyResources(Me.lstAcceso, "lstAcceso")
        Me.lstAcceso.BackgroundImage = Nothing
        Me.lstAcceso.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDocumento, Me.colNombre})
        Me.lstAcceso.Font = Nothing
        Me.lstAcceso.FullRowSelect = True
        Me.lstAcceso.Name = "lstAcceso"
        Me.lstAcceso.UseCompatibleStateImageBehavior = False
        Me.lstAcceso.View = System.Windows.Forms.View.Details
        '
        'colDocumento
        '
        resources.ApplyResources(Me.colDocumento, "colDocumento")
        '
        'colNombre
        '
        resources.ApplyResources(Me.colNombre, "colNombre")
        '
        'gbSaldo
        '
        Me.gbSaldo.AccessibleDescription = Nothing
        Me.gbSaldo.AccessibleName = Nothing
        resources.ApplyResources(Me.gbSaldo, "gbSaldo")
        Me.gbSaldo.BackgroundImage = Nothing
        Me.gbSaldo.Controls.Add(Me.lblPropietarioData)
        Me.gbSaldo.Controls.Add(Me.lblPropietario)
        Me.gbSaldo.Controls.Add(Me.lblMonedaData)
        Me.gbSaldo.Controls.Add(Me.lblSaldoData)
        Me.gbSaldo.Controls.Add(Me.lblMoneda)
        Me.gbSaldo.Controls.Add(Me.lblSaldo)
        Me.gbSaldo.Font = Nothing
        Me.gbSaldo.Name = "gbSaldo"
        Me.gbSaldo.TabStop = False
        '
        'lblPropietarioData
        '
        Me.lblPropietarioData.AccessibleDescription = Nothing
        Me.lblPropietarioData.AccessibleName = Nothing
        resources.ApplyResources(Me.lblPropietarioData, "lblPropietarioData")
        Me.lblPropietarioData.Font = Nothing
        Me.lblPropietarioData.Name = "lblPropietarioData"
        '
        'lblPropietario
        '
        Me.lblPropietario.AccessibleDescription = Nothing
        Me.lblPropietario.AccessibleName = Nothing
        resources.ApplyResources(Me.lblPropietario, "lblPropietario")
        Me.lblPropietario.Font = Nothing
        Me.lblPropietario.Name = "lblPropietario"
        '
        'lblMonedaData
        '
        Me.lblMonedaData.AccessibleDescription = Nothing
        Me.lblMonedaData.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMonedaData, "lblMonedaData")
        Me.lblMonedaData.Font = Nothing
        Me.lblMonedaData.Name = "lblMonedaData"
        '
        'lblSaldoData
        '
        Me.lblSaldoData.AccessibleDescription = Nothing
        Me.lblSaldoData.AccessibleName = Nothing
        resources.ApplyResources(Me.lblSaldoData, "lblSaldoData")
        Me.lblSaldoData.Font = Nothing
        Me.lblSaldoData.Name = "lblSaldoData"
        '
        'lblMoneda
        '
        Me.lblMoneda.AccessibleDescription = Nothing
        Me.lblMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.Font = Nothing
        Me.lblMoneda.Name = "lblMoneda"
        '
        'lblSaldo
        '
        Me.lblSaldo.AccessibleDescription = Nothing
        Me.lblSaldo.AccessibleName = Nothing
        resources.ApplyResources(Me.lblSaldo, "lblSaldo")
        Me.lblSaldo.Font = Nothing
        Me.lblSaldo.Name = "lblSaldo"
        '
        'gbCliente
        '
        Me.gbCliente.AccessibleDescription = Nothing
        Me.gbCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.gbCliente, "gbCliente")
        Me.gbCliente.BackgroundImage = Nothing
        Me.gbCliente.Controls.Add(Me.btnModificar)
        Me.gbCliente.Font = Nothing
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleDescription = Nothing
        Me.btnModificar.AccessibleName = Nothing
        resources.ApplyResources(Me.btnModificar, "btnModificar")
        Me.btnModificar.BackgroundImage = Nothing
        Me.btnModificar.Font = Nothing
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmClientePrincipal
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.gbCliente)
        Me.Controls.Add(Me.gbSaldo)
        Me.Controls.Add(Me.gbAccesoClientes)
        Me.Controls.Add(Me.gbAcciones)
        Me.Controls.Add(Me.gbMovimientos)
        Me.Controls.Add(Me.gbChequera)
        Me.Controls.Add(Me.gbCuentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientePrincipal"
        Me.gbCuentas.ResumeLayout(False)
        Me.gbChequera.ResumeLayout(False)
        Me.gbMovimientos.ResumeLayout(False)
        Me.gbAcciones.ResumeLayout(False)
        Me.gbAccesoClientes.ResumeLayout(False)
        Me.gbSaldo.ResumeLayout(False)
        Me.gbSaldo.PerformLayout()
        Me.gbCliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbChequera As System.Windows.Forms.GroupBox
    Friend WithEvents gbMovimientos As System.Windows.Forms.GroupBox
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents cboCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevaCuenta As System.Windows.Forms.Button
    Friend WithEvents btnEstadoChequera As System.Windows.Forms.Button
    Friend WithEvents btnNuevaChequera As System.Windows.Forms.Button
    Friend WithEvents lstMovimientos As System.Windows.Forms.ListView
    Friend WithEvents colTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAcceso As System.Windows.Forms.Button
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents btnDeposito As System.Windows.Forms.Button
    Friend WithEvents btnRetiro As System.Windows.Forms.Button
    Friend WithEvents btnCerrarCuenta As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents gbAccesoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents lstAcceso As System.Windows.Forms.ListView
    Friend WithEvents colDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbSaldo As System.Windows.Forms.GroupBox
    Friend WithEvents lblMonedaData As System.Windows.Forms.Label
    Friend WithEvents lblSaldoData As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblPropietarioData As System.Windows.Forms.Label
    Friend WithEvents lblPropietario As System.Windows.Forms.Label
    Friend WithEvents gbCliente As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
