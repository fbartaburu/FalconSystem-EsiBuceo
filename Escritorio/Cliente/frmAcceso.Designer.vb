<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcceso))
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtDocumento = New System.Windows.Forms.TextBox
        Me.lblDocumento = New System.Windows.Forms.Label
        Me.lstAcceso = New System.Windows.Forms.ListView
        Me.colDocumento = New System.Windows.Forms.ColumnHeader
        Me.colNombre = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDocumento
        '
        resources.ApplyResources(Me.txtDocumento, "txtDocumento")
        Me.txtDocumento.Name = "txtDocumento"
        '
        'lblDocumento
        '
        resources.ApplyResources(Me.lblDocumento, "lblDocumento")
        Me.lblDocumento.Name = "lblDocumento"
        '
        'lstAcceso
        '
        Me.lstAcceso.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDocumento, Me.colNombre})
        Me.lstAcceso.FullRowSelect = True
        resources.ApplyResources(Me.lstAcceso, "lstAcceso")
        Me.lstAcceso.MultiSelect = False
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
        'frmAcceso
        '
        Me.AcceptButton = Me.btnBuscar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstAcceso)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblDocumento)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents lstAcceso As System.Windows.Forms.ListView
    Friend WithEvents colDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNombre As System.Windows.Forms.ColumnHeader
End Class
