<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferencia))
        Me.btnTransferencia = New System.Windows.Forms.Button
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblDestino = New System.Windows.Forms.Label
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnTransferencia
        '
        resources.ApplyResources(Me.btnTransferencia, "btnTransferencia")
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.UseVisualStyleBackColor = True
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        resources.ApplyResources(Me.cboMoneda, "cboMoneda")
        Me.cboMoneda.Name = "cboMoneda"
        '
        'txtMonto
        '
        resources.ApplyResources(Me.txtMonto, "txtMonto")
        Me.txtMonto.Name = "txtMonto"
        '
        'lblMoneda
        '
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.Name = "lblMoneda"
        '
        'lblMonto
        '
        resources.ApplyResources(Me.lblMonto, "lblMonto")
        Me.lblMonto.Name = "lblMonto"
        '
        'lblDestino
        '
        resources.ApplyResources(Me.lblDestino, "lblDestino")
        Me.lblDestino.Name = "lblDestino"
        '
        'txtDestino
        '
        resources.ApplyResources(Me.txtDestino, "txtDestino")
        Me.txtDestino.Name = "txtDestino"
        '
        'frmTransferencia
        '
        Me.AcceptButton = Me.btnTransferencia
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.btnTransferencia)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblMonto)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
End Class
