<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEstadoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucEstadoCuenta))
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AccessibleDescription = Nothing
        Me.lblNumero.AccessibleName = Nothing
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Font = Nothing
        Me.lblNumero.Name = "lblNumero"
        '
        'lblMonto
        '
        Me.lblMonto.AccessibleDescription = Nothing
        Me.lblMonto.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMonto, "lblMonto")
        Me.lblMonto.Font = Nothing
        Me.lblMonto.Name = "lblMonto"
        '
        'lblMoneda
        '
        Me.lblMoneda.AccessibleDescription = Nothing
        Me.lblMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.Font = Nothing
        Me.lblMoneda.Name = "lblMoneda"
        '
        'ucEstadoCuenta
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "ucEstadoCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label

End Class
