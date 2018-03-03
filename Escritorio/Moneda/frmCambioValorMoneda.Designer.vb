<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioValorMoneda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioValorMoneda))
        Me.lblValor = New System.Windows.Forms.Label
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.btnValor = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblValor
        '
        resources.ApplyResources(Me.lblValor, "lblValor")
        Me.lblValor.Name = "lblValor"
        '
        'txtValor
        '
        resources.ApplyResources(Me.txtValor, "txtValor")
        Me.txtValor.Name = "txtValor"
        '
        'btnValor
        '
        resources.ApplyResources(Me.btnValor, "btnValor")
        Me.btnValor.Name = "btnValor"
        Me.btnValor.UseVisualStyleBackColor = True
        '
        'frmCambioValorMoneda
        '
        Me.AcceptButton = Me.btnValor
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnValor)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblValor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioValorMoneda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnValor As System.Windows.Forms.Button
End Class
