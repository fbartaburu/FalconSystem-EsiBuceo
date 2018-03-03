<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosCaja))
        Me.gbActual = New System.Windows.Forms.GroupBox
        Me.btnMovimientos = New System.Windows.Forms.Button
        Me.lblAperturaData = New System.Windows.Forms.Label
        Me.lblApertura = New System.Windows.Forms.Label
        Me.lblEmpleadoData = New System.Windows.Forms.Label
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.gbAntiguos = New System.Windows.Forms.GroupBox
        Me.lstEmpleados = New System.Windows.Forms.ListView
        Me.colCI = New System.Windows.Forms.ColumnHeader
        Me.colNombre = New System.Windows.Forms.ColumnHeader
        Me.colApertura = New System.Windows.Forms.ColumnHeader
        Me.colCierre = New System.Windows.Forms.ColumnHeader
        Me.gbActual.SuspendLayout()
        Me.gbAntiguos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbActual
        '
        Me.gbActual.Controls.Add(Me.btnMovimientos)
        Me.gbActual.Controls.Add(Me.lblAperturaData)
        Me.gbActual.Controls.Add(Me.lblApertura)
        Me.gbActual.Controls.Add(Me.lblEmpleadoData)
        Me.gbActual.Controls.Add(Me.lblEmpleado)
        resources.ApplyResources(Me.gbActual, "gbActual")
        Me.gbActual.Name = "gbActual"
        Me.gbActual.TabStop = False
        '
        'btnMovimientos
        '
        resources.ApplyResources(Me.btnMovimientos, "btnMovimientos")
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.UseVisualStyleBackColor = True
        '
        'lblAperturaData
        '
        resources.ApplyResources(Me.lblAperturaData, "lblAperturaData")
        Me.lblAperturaData.Name = "lblAperturaData"
        '
        'lblApertura
        '
        resources.ApplyResources(Me.lblApertura, "lblApertura")
        Me.lblApertura.Name = "lblApertura"
        '
        'lblEmpleadoData
        '
        resources.ApplyResources(Me.lblEmpleadoData, "lblEmpleadoData")
        Me.lblEmpleadoData.Name = "lblEmpleadoData"
        '
        'lblEmpleado
        '
        resources.ApplyResources(Me.lblEmpleado, "lblEmpleado")
        Me.lblEmpleado.Name = "lblEmpleado"
        '
        'gbAntiguos
        '
        Me.gbAntiguos.Controls.Add(Me.lstEmpleados)
        resources.ApplyResources(Me.gbAntiguos, "gbAntiguos")
        Me.gbAntiguos.Name = "gbAntiguos"
        Me.gbAntiguos.TabStop = False
        '
        'lstEmpleados
        '
        Me.lstEmpleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCI, Me.colNombre, Me.colApertura, Me.colCierre})
        Me.lstEmpleados.FullRowSelect = True
        resources.ApplyResources(Me.lstEmpleados, "lstEmpleados")
        Me.lstEmpleados.MultiSelect = False
        Me.lstEmpleados.Name = "lstEmpleados"
        Me.lstEmpleados.UseCompatibleStateImageBehavior = False
        Me.lstEmpleados.View = System.Windows.Forms.View.Details
        '
        'colCI
        '
        resources.ApplyResources(Me.colCI, "colCI")
        '
        'colNombre
        '
        resources.ApplyResources(Me.colNombre, "colNombre")
        '
        'colApertura
        '
        resources.ApplyResources(Me.colApertura, "colApertura")
        '
        'colCierre
        '
        resources.ApplyResources(Me.colCierre, "colCierre")
        '
        'frmDatosCaja
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbAntiguos)
        Me.Controls.Add(Me.gbActual)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatosCaja"
        Me.gbActual.ResumeLayout(False)
        Me.gbActual.PerformLayout()
        Me.gbAntiguos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbActual As System.Windows.Forms.GroupBox
    Friend WithEvents btnMovimientos As System.Windows.Forms.Button
    Friend WithEvents lblAperturaData As System.Windows.Forms.Label
    Friend WithEvents lblApertura As System.Windows.Forms.Label
    Friend WithEvents lblEmpleadoData As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents gbAntiguos As System.Windows.Forms.GroupBox
    Friend WithEvents lstEmpleados As System.Windows.Forms.ListView
    Friend WithEvents colCI As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents colApertura As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCierre As System.Windows.Forms.ColumnHeader
End Class
