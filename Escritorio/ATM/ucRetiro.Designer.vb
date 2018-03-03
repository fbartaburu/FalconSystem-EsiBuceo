<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRetiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucRetiro))
        Me.btnRetiro = New System.Windows.Forms.Button
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.SuspendLayout()
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
        'cboMoneda
        '
        Me.cboMoneda.AccessibleDescription = Nothing
        Me.cboMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.cboMoneda, "cboMoneda")
        Me.cboMoneda.BackgroundImage = Nothing
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = Nothing
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Name = "cboMoneda"
        '
        'txtMonto
        '
        Me.txtMonto.AccessibleDescription = Nothing
        Me.txtMonto.AccessibleName = Nothing
        resources.ApplyResources(Me.txtMonto, "txtMonto")
        Me.txtMonto.BackgroundImage = Nothing
        Me.txtMonto.Font = Nothing
        Me.txtMonto.Name = "txtMonto"
        '
        'lblMoneda
        '
        Me.lblMoneda.AccessibleDescription = Nothing
        Me.lblMoneda.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.Font = Nothing
        Me.lblMoneda.Name = "lblMoneda"
        '
        'lblMonto
        '
        Me.lblMonto.AccessibleDescription = Nothing
        Me.lblMonto.AccessibleName = Nothing
        resources.ApplyResources(Me.lblMonto, "lblMonto")
        Me.lblMonto.Font = Nothing
        Me.lblMonto.Name = "lblMonto"
        '
        'ucRetiro
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnRetiro)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblMonto)
        Me.Name = "ucRetiro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRetiro As System.Windows.Forms.Button
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label

End Class
