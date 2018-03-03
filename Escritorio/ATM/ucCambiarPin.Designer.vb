<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCambiarPin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCambiarPin))
        Me.lblCambiarPin = New System.Windows.Forms.Label
        Me.txtNuevoPin = New System.Windows.Forms.TextBox
        Me.btnNuevoPin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCambiarPin
        '
        resources.ApplyResources(Me.lblCambiarPin, "lblCambiarPin")
        Me.lblCambiarPin.Name = "lblCambiarPin"
        '
        'txtNuevoPin
        '
        resources.ApplyResources(Me.txtNuevoPin, "txtNuevoPin")
        Me.txtNuevoPin.Name = "txtNuevoPin"
        '
        'btnNuevoPin
        '
        resources.ApplyResources(Me.btnNuevoPin, "btnNuevoPin")
        Me.btnNuevoPin.Name = "btnNuevoPin"
        Me.btnNuevoPin.UseVisualStyleBackColor = True
        '
        'ucCambiarPin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnNuevoPin)
        Me.Controls.Add(Me.txtNuevoPin)
        Me.Controls.Add(Me.lblCambiarPin)
        Me.Name = "ucCambiarPin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCambiarPin As System.Windows.Forms.Label
    Friend WithEvents txtNuevoPin As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevoPin As System.Windows.Forms.Button

End Class
