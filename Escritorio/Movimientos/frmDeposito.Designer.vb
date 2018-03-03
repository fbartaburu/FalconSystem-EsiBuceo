<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposito))
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.btnDepositar = New System.Windows.Forms.Button
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.lblDestino = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblMonto
        '
        resources.ApplyResources(Me.lblMonto, "lblMonto")
        Me.lblMonto.Name = "lblMonto"
        '
        'lblMoneda
        '
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.Name = "lblMoneda"
        '
        'txtMonto
        '
        resources.ApplyResources(Me.txtMonto, "txtMonto")
        Me.txtMonto.Name = "txtMonto"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        resources.ApplyResources(Me.cboMoneda, "cboMoneda")
        Me.cboMoneda.Name = "cboMoneda"
        '
        'btnDepositar
        '
        resources.ApplyResources(Me.btnDepositar, "btnDepositar")
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'txtDestino
        '
        resources.ApplyResources(Me.txtDestino, "txtDestino")
        Me.txtDestino.Name = "txtDestino"
        '
        'lblDestino
        '
        resources.ApplyResources(Me.lblDestino, "lblDestino")
        Me.lblDestino.Name = "lblDestino"
        '
        'frmDeposito
        '
        Me.AcceptButton = Me.btnDepositar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblMonto)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeposito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnDepositar As System.Windows.Forms.Button
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents lblDestino As System.Windows.Forms.Label
End Class
