<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoCajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoCajas))
        Me.gbSucursales = New System.Windows.Forms.GroupBox
        Me.lstSucursales = New System.Windows.Forms.ListView
        Me.colNombreS = New System.Windows.Forms.ColumnHeader
        Me.colDepartment = New System.Windows.Forms.ColumnHeader
        Me.lblBuscarSucursal = New System.Windows.Forms.Label
        Me.txtBuscarSucursal = New System.Windows.Forms.TextBox
        Me.gbCajas = New System.Windows.Forms.GroupBox
        Me.lstCajas = New System.Windows.Forms.ListView
        Me.colNombre = New System.Windows.Forms.ColumnHeader
        Me.colIP = New System.Windows.Forms.ColumnHeader
        Me.colEstado = New System.Windows.Forms.ColumnHeader
        Me.lblBuscarCaja = New System.Windows.Forms.Label
        Me.txtBuscarCaja = New System.Windows.Forms.TextBox
        Me.gbSucursales.SuspendLayout()
        Me.gbCajas.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSucursales
        '
        Me.gbSucursales.Controls.Add(Me.lstSucursales)
        Me.gbSucursales.Controls.Add(Me.lblBuscarSucursal)
        Me.gbSucursales.Controls.Add(Me.txtBuscarSucursal)
        resources.ApplyResources(Me.gbSucursales, "gbSucursales")
        Me.gbSucursales.Name = "gbSucursales"
        Me.gbSucursales.TabStop = False
        '
        'lstSucursales
        '
        Me.lstSucursales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNombreS, Me.colDepartment})
        Me.lstSucursales.FullRowSelect = True
        resources.ApplyResources(Me.lstSucursales, "lstSucursales")
        Me.lstSucursales.MultiSelect = False
        Me.lstSucursales.Name = "lstSucursales"
        Me.lstSucursales.UseCompatibleStateImageBehavior = False
        Me.lstSucursales.View = System.Windows.Forms.View.Details
        '
        'colNombreS
        '
        resources.ApplyResources(Me.colNombreS, "colNombreS")
        '
        'colDepartment
        '
        resources.ApplyResources(Me.colDepartment, "colDepartment")
        '
        'lblBuscarSucursal
        '
        resources.ApplyResources(Me.lblBuscarSucursal, "lblBuscarSucursal")
        Me.lblBuscarSucursal.Name = "lblBuscarSucursal"
        '
        'txtBuscarSucursal
        '
        resources.ApplyResources(Me.txtBuscarSucursal, "txtBuscarSucursal")
        Me.txtBuscarSucursal.Name = "txtBuscarSucursal"
        '
        'gbCajas
        '
        Me.gbCajas.Controls.Add(Me.lstCajas)
        Me.gbCajas.Controls.Add(Me.lblBuscarCaja)
        Me.gbCajas.Controls.Add(Me.txtBuscarCaja)
        resources.ApplyResources(Me.gbCajas, "gbCajas")
        Me.gbCajas.Name = "gbCajas"
        Me.gbCajas.TabStop = False
        '
        'lstCajas
        '
        Me.lstCajas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNombre, Me.colIP, Me.colEstado})
        Me.lstCajas.FullRowSelect = True
        resources.ApplyResources(Me.lstCajas, "lstCajas")
        Me.lstCajas.MultiSelect = False
        Me.lstCajas.Name = "lstCajas"
        Me.lstCajas.UseCompatibleStateImageBehavior = False
        Me.lstCajas.View = System.Windows.Forms.View.Details
        '
        'colNombre
        '
        resources.ApplyResources(Me.colNombre, "colNombre")
        '
        'colIP
        '
        resources.ApplyResources(Me.colIP, "colIP")
        '
        'colEstado
        '
        resources.ApplyResources(Me.colEstado, "colEstado")
        '
        'lblBuscarCaja
        '
        resources.ApplyResources(Me.lblBuscarCaja, "lblBuscarCaja")
        Me.lblBuscarCaja.Name = "lblBuscarCaja"
        '
        'txtBuscarCaja
        '
        resources.ApplyResources(Me.txtBuscarCaja, "txtBuscarCaja")
        Me.txtBuscarCaja.Name = "txtBuscarCaja"
        '
        'frmListadoCajas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbCajas)
        Me.Controls.Add(Me.gbSucursales)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListadoCajas"
        Me.gbSucursales.ResumeLayout(False)
        Me.gbSucursales.PerformLayout()
        Me.gbCajas.ResumeLayout(False)
        Me.gbCajas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSucursales As System.Windows.Forms.GroupBox
    Friend WithEvents lstSucursales As System.Windows.Forms.ListView
    Friend WithEvents colNombreS As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblBuscarSucursal As System.Windows.Forms.Label
    Friend WithEvents txtBuscarSucursal As System.Windows.Forms.TextBox
    Friend WithEvents gbCajas As System.Windows.Forms.GroupBox
    Friend WithEvents lstCajas As System.Windows.Forms.ListView
    Friend WithEvents lblBuscarCaja As System.Windows.Forms.Label
    Friend WithEvents txtBuscarCaja As System.Windows.Forms.TextBox
    Friend WithEvents colNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEstado As System.Windows.Forms.ColumnHeader
End Class
