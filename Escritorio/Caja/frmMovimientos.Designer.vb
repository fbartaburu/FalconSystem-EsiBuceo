<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos))
        Me.lstMovimientos = New System.Windows.Forms.ListView
        Me.colCuenta = New System.Windows.Forms.ColumnHeader
        Me.colTipo = New System.Windows.Forms.ColumnHeader
        Me.colCantidad = New System.Windows.Forms.ColumnHeader
        Me.colMoneda = New System.Windows.Forms.ColumnHeader
        Me.colFecha = New System.Windows.Forms.ColumnHeader
        Me.lblDocumento = New System.Windows.Forms.Label
        Me.lblApertura = New System.Windows.Forms.Label
        Me.lblCierre = New System.Windows.Forms.Label
        Me.gbEmpleado = New System.Windows.Forms.GroupBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.gbHorarios = New System.Windows.Forms.GroupBox
        Me.gbUYU = New System.Windows.Forms.GroupBox
        Me.lblFinalUYU = New System.Windows.Forms.Label
        Me.lblStartUYU = New System.Windows.Forms.Label
        Me.gbUSD = New System.Windows.Forms.GroupBox
        Me.lblFinalUSD = New System.Windows.Forms.Label
        Me.lblStartUSD = New System.Windows.Forms.Label
        Me.gbEmpleado.SuspendLayout()
        Me.gbHorarios.SuspendLayout()
        Me.gbUYU.SuspendLayout()
        Me.gbUSD.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMovimientos
        '
        Me.lstMovimientos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCuenta, Me.colTipo, Me.colCantidad, Me.colMoneda, Me.colFecha})
        Me.lstMovimientos.FullRowSelect = True
        resources.ApplyResources(Me.lstMovimientos, "lstMovimientos")
        Me.lstMovimientos.MultiSelect = False
        Me.lstMovimientos.Name = "lstMovimientos"
        Me.lstMovimientos.UseCompatibleStateImageBehavior = False
        Me.lstMovimientos.View = System.Windows.Forms.View.Details
        '
        'colCuenta
        '
        resources.ApplyResources(Me.colCuenta, "colCuenta")
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
        'lblDocumento
        '
        resources.ApplyResources(Me.lblDocumento, "lblDocumento")
        Me.lblDocumento.Name = "lblDocumento"
        '
        'lblApertura
        '
        resources.ApplyResources(Me.lblApertura, "lblApertura")
        Me.lblApertura.Name = "lblApertura"
        '
        'lblCierre
        '
        resources.ApplyResources(Me.lblCierre, "lblCierre")
        Me.lblCierre.Name = "lblCierre"
        '
        'gbEmpleado
        '
        Me.gbEmpleado.Controls.Add(Me.lblNombre)
        Me.gbEmpleado.Controls.Add(Me.lblDocumento)
        resources.ApplyResources(Me.gbEmpleado, "gbEmpleado")
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.TabStop = False
        '
        'lblNombre
        '
        resources.ApplyResources(Me.lblNombre, "lblNombre")
        Me.lblNombre.Name = "lblNombre"
        '
        'gbHorarios
        '
        Me.gbHorarios.Controls.Add(Me.lblApertura)
        Me.gbHorarios.Controls.Add(Me.lblCierre)
        resources.ApplyResources(Me.gbHorarios, "gbHorarios")
        Me.gbHorarios.Name = "gbHorarios"
        Me.gbHorarios.TabStop = False
        '
        'gbUYU
        '
        Me.gbUYU.Controls.Add(Me.lblFinalUYU)
        Me.gbUYU.Controls.Add(Me.lblStartUYU)
        resources.ApplyResources(Me.gbUYU, "gbUYU")
        Me.gbUYU.Name = "gbUYU"
        Me.gbUYU.TabStop = False
        '
        'lblFinalUYU
        '
        resources.ApplyResources(Me.lblFinalUYU, "lblFinalUYU")
        Me.lblFinalUYU.Name = "lblFinalUYU"
        '
        'lblStartUYU
        '
        resources.ApplyResources(Me.lblStartUYU, "lblStartUYU")
        Me.lblStartUYU.Name = "lblStartUYU"
        '
        'gbUSD
        '
        Me.gbUSD.Controls.Add(Me.lblFinalUSD)
        Me.gbUSD.Controls.Add(Me.lblStartUSD)
        resources.ApplyResources(Me.gbUSD, "gbUSD")
        Me.gbUSD.Name = "gbUSD"
        Me.gbUSD.TabStop = False
        '
        'lblFinalUSD
        '
        resources.ApplyResources(Me.lblFinalUSD, "lblFinalUSD")
        Me.lblFinalUSD.Name = "lblFinalUSD"
        '
        'lblStartUSD
        '
        resources.ApplyResources(Me.lblStartUSD, "lblStartUSD")
        Me.lblStartUSD.Name = "lblStartUSD"
        '
        'frmMovimientos
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbUSD)
        Me.Controls.Add(Me.gbUYU)
        Me.Controls.Add(Me.gbHorarios)
        Me.Controls.Add(Me.gbEmpleado)
        Me.Controls.Add(Me.lstMovimientos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovimientos"
        Me.gbEmpleado.ResumeLayout(False)
        Me.gbEmpleado.PerformLayout()
        Me.gbHorarios.ResumeLayout(False)
        Me.gbHorarios.PerformLayout()
        Me.gbUYU.ResumeLayout(False)
        Me.gbUYU.PerformLayout()
        Me.gbUSD.ResumeLayout(False)
        Me.gbUSD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstMovimientos As System.Windows.Forms.ListView
    Friend WithEvents colTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents lblApertura As System.Windows.Forms.Label
    Friend WithEvents lblCierre As System.Windows.Forms.Label
    Friend WithEvents gbEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents gbHorarios As System.Windows.Forms.GroupBox
    Friend WithEvents gbUYU As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinalUYU As System.Windows.Forms.Label
    Friend WithEvents lblStartUYU As System.Windows.Forms.Label
    Friend WithEvents gbUSD As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinalUSD As System.Windows.Forms.Label
    Friend WithEvents lblStartUSD As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
End Class
