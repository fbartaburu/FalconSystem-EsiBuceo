<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCuentas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucListaCuentas))
        Me.lstCuentas = New System.Windows.Forms.ListView
        Me.colNumero = New System.Windows.Forms.ColumnHeader
        Me.colMonto = New System.Windows.Forms.ColumnHeader
        Me.colMoneda = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lstCuentas
        '
        Me.lstCuentas.AccessibleDescription = Nothing
        Me.lstCuentas.AccessibleName = Nothing
        resources.ApplyResources(Me.lstCuentas, "lstCuentas")
        Me.lstCuentas.BackgroundImage = Nothing
        Me.lstCuentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNumero, Me.colMonto, Me.colMoneda})
        Me.lstCuentas.Font = Nothing
        Me.lstCuentas.FullRowSelect = True
        Me.lstCuentas.MultiSelect = False
        Me.lstCuentas.Name = "lstCuentas"
        Me.lstCuentas.UseCompatibleStateImageBehavior = False
        Me.lstCuentas.View = System.Windows.Forms.View.Details
        '
        'colNumero
        '
        resources.ApplyResources(Me.colNumero, "colNumero")
        '
        'colMonto
        '
        resources.ApplyResources(Me.colMonto, "colMonto")
        '
        'colMoneda
        '
        resources.ApplyResources(Me.colMoneda, "colMoneda")
        '
        'ucListaCuentas
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lstCuentas)
        Me.Name = "ucListaCuentas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCuentas As System.Windows.Forms.ListView
    Friend WithEvents colNumero As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMoneda As System.Windows.Forms.ColumnHeader

End Class
