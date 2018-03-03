<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValorMonedas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValorMonedas))
        Me.gpUYU = New System.Windows.Forms.GroupBox
        Me.btnCambiarUYU = New System.Windows.Forms.Button
        Me.lstUYU = New System.Windows.Forms.ListView
        Me.colUYUValor = New System.Windows.Forms.ColumnHeader
        Me.colUYUFecha = New System.Windows.Forms.ColumnHeader
        Me.lblUYUValorActual = New System.Windows.Forms.Label
        Me.gpUSD = New System.Windows.Forms.GroupBox
        Me.lstUSD = New System.Windows.Forms.ListView
        Me.colUSDValor = New System.Windows.Forms.ColumnHeader
        Me.colUSDFecha = New System.Windows.Forms.ColumnHeader
        Me.btnCambiarUSD = New System.Windows.Forms.Button
        Me.lblUSDValorActual = New System.Windows.Forms.Label
        Me.gpUYU.SuspendLayout()
        Me.gpUSD.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpUYU
        '
        Me.gpUYU.AccessibleDescription = Nothing
        Me.gpUYU.AccessibleName = Nothing
        resources.ApplyResources(Me.gpUYU, "gpUYU")
        Me.gpUYU.BackgroundImage = Nothing
        Me.gpUYU.Controls.Add(Me.btnCambiarUYU)
        Me.gpUYU.Controls.Add(Me.lstUYU)
        Me.gpUYU.Controls.Add(Me.lblUYUValorActual)
        Me.gpUYU.Font = Nothing
        Me.gpUYU.Name = "gpUYU"
        Me.gpUYU.TabStop = False
        '
        'btnCambiarUYU
        '
        Me.btnCambiarUYU.AccessibleDescription = Nothing
        Me.btnCambiarUYU.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCambiarUYU, "btnCambiarUYU")
        Me.btnCambiarUYU.BackgroundImage = Nothing
        Me.btnCambiarUYU.Font = Nothing
        Me.btnCambiarUYU.Name = "btnCambiarUYU"
        Me.btnCambiarUYU.UseVisualStyleBackColor = True
        '
        'lstUYU
        '
        Me.lstUYU.AccessibleDescription = Nothing
        Me.lstUYU.AccessibleName = Nothing
        resources.ApplyResources(Me.lstUYU, "lstUYU")
        Me.lstUYU.BackgroundImage = Nothing
        Me.lstUYU.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colUYUValor, Me.colUYUFecha})
        Me.lstUYU.Font = Nothing
        Me.lstUYU.FullRowSelect = True
        Me.lstUYU.MultiSelect = False
        Me.lstUYU.Name = "lstUYU"
        Me.lstUYU.UseCompatibleStateImageBehavior = False
        Me.lstUYU.View = System.Windows.Forms.View.Details
        '
        'colUYUValor
        '
        resources.ApplyResources(Me.colUYUValor, "colUYUValor")
        '
        'colUYUFecha
        '
        resources.ApplyResources(Me.colUYUFecha, "colUYUFecha")
        '
        'lblUYUValorActual
        '
        Me.lblUYUValorActual.AccessibleDescription = Nothing
        Me.lblUYUValorActual.AccessibleName = Nothing
        resources.ApplyResources(Me.lblUYUValorActual, "lblUYUValorActual")
        Me.lblUYUValorActual.Font = Nothing
        Me.lblUYUValorActual.Name = "lblUYUValorActual"
        '
        'gpUSD
        '
        Me.gpUSD.AccessibleDescription = Nothing
        Me.gpUSD.AccessibleName = Nothing
        resources.ApplyResources(Me.gpUSD, "gpUSD")
        Me.gpUSD.BackgroundImage = Nothing
        Me.gpUSD.Controls.Add(Me.lstUSD)
        Me.gpUSD.Controls.Add(Me.btnCambiarUSD)
        Me.gpUSD.Controls.Add(Me.lblUSDValorActual)
        Me.gpUSD.Font = Nothing
        Me.gpUSD.Name = "gpUSD"
        Me.gpUSD.TabStop = False
        '
        'lstUSD
        '
        Me.lstUSD.AccessibleDescription = Nothing
        Me.lstUSD.AccessibleName = Nothing
        resources.ApplyResources(Me.lstUSD, "lstUSD")
        Me.lstUSD.BackgroundImage = Nothing
        Me.lstUSD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colUSDValor, Me.colUSDFecha})
        Me.lstUSD.Font = Nothing
        Me.lstUSD.FullRowSelect = True
        Me.lstUSD.MultiSelect = False
        Me.lstUSD.Name = "lstUSD"
        Me.lstUSD.UseCompatibleStateImageBehavior = False
        Me.lstUSD.View = System.Windows.Forms.View.Details
        '
        'colUSDValor
        '
        resources.ApplyResources(Me.colUSDValor, "colUSDValor")
        '
        'colUSDFecha
        '
        resources.ApplyResources(Me.colUSDFecha, "colUSDFecha")
        '
        'btnCambiarUSD
        '
        Me.btnCambiarUSD.AccessibleDescription = Nothing
        Me.btnCambiarUSD.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCambiarUSD, "btnCambiarUSD")
        Me.btnCambiarUSD.BackgroundImage = Nothing
        Me.btnCambiarUSD.Font = Nothing
        Me.btnCambiarUSD.Name = "btnCambiarUSD"
        Me.btnCambiarUSD.UseVisualStyleBackColor = True
        '
        'lblUSDValorActual
        '
        Me.lblUSDValorActual.AccessibleDescription = Nothing
        Me.lblUSDValorActual.AccessibleName = Nothing
        resources.ApplyResources(Me.lblUSDValorActual, "lblUSDValorActual")
        Me.lblUSDValorActual.Font = Nothing
        Me.lblUSDValorActual.Name = "lblUSDValorActual"
        '
        'frmValorMonedas
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.gpUSD)
        Me.Controls.Add(Me.gpUYU)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.Name = "frmValorMonedas"
        Me.gpUYU.ResumeLayout(False)
        Me.gpUYU.PerformLayout()
        Me.gpUSD.ResumeLayout(False)
        Me.gpUSD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpUYU As System.Windows.Forms.GroupBox
    Friend WithEvents lstUYU As System.Windows.Forms.ListView
    Friend WithEvents colUYUValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUYUFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblUYUValorActual As System.Windows.Forms.Label
    Friend WithEvents btnCambiarUYU As System.Windows.Forms.Button
    Friend WithEvents gpUSD As System.Windows.Forms.GroupBox
    Friend WithEvents btnCambiarUSD As System.Windows.Forms.Button
    Friend WithEvents lblUSDValorActual As System.Windows.Forms.Label
    Friend WithEvents lstUSD As System.Windows.Forms.ListView
    Friend WithEvents colUSDValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUSDFecha As System.Windows.Forms.ColumnHeader
End Class
