<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoChequera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoChequera))
        Me.cboChequeras = New System.Windows.Forms.ComboBox
        Me.lblChequeras = New System.Windows.Forms.Label
        Me.lstCheques = New System.Windows.Forms.ListView
        Me.colNumero = New System.Windows.Forms.ColumnHeader
        Me.colMonto = New System.Windows.Forms.ColumnHeader
        Me.colMoneda = New System.Windows.Forms.ColumnHeader
        Me.colEmision = New System.Windows.Forms.ColumnHeader
        Me.colPagado = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'cboChequeras
        '
        Me.cboChequeras.AccessibleDescription = Nothing
        Me.cboChequeras.AccessibleName = Nothing
        resources.ApplyResources(Me.cboChequeras, "cboChequeras")
        Me.cboChequeras.BackgroundImage = Nothing
        Me.cboChequeras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChequeras.Font = Nothing
        Me.cboChequeras.FormattingEnabled = True
        Me.cboChequeras.Name = "cboChequeras"
        '
        'lblChequeras
        '
        Me.lblChequeras.AccessibleDescription = Nothing
        Me.lblChequeras.AccessibleName = Nothing
        resources.ApplyResources(Me.lblChequeras, "lblChequeras")
        Me.lblChequeras.Font = Nothing
        Me.lblChequeras.Name = "lblChequeras"
        '
        'lstCheques
        '
        Me.lstCheques.AccessibleDescription = Nothing
        Me.lstCheques.AccessibleName = Nothing
        resources.ApplyResources(Me.lstCheques, "lstCheques")
        Me.lstCheques.BackgroundImage = Nothing
        Me.lstCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNumero, Me.colMonto, Me.colMoneda, Me.colEmision, Me.colPagado})
        Me.lstCheques.Font = Nothing
        Me.lstCheques.FullRowSelect = True
        Me.lstCheques.MultiSelect = False
        Me.lstCheques.Name = "lstCheques"
        Me.lstCheques.UseCompatibleStateImageBehavior = False
        Me.lstCheques.View = System.Windows.Forms.View.Details
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
        'colEmision
        '
        resources.ApplyResources(Me.colEmision, "colEmision")
        '
        'colPagado
        '
        resources.ApplyResources(Me.colPagado, "colPagado")
        '
        'frmEstadoChequera
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lstCheques)
        Me.Controls.Add(Me.lblChequeras)
        Me.Controls.Add(Me.cboChequeras)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstadoChequera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboChequeras As System.Windows.Forms.ComboBox
    Friend WithEvents lblChequeras As System.Windows.Forms.Label
    Friend WithEvents lstCheques As System.Windows.Forms.ListView
    Friend WithEvents colNumero As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEmision As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPagado As System.Windows.Forms.ColumnHeader
End Class
