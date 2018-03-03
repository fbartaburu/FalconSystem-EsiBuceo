<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaCuenta))
        Me.lblTipoCuenta = New System.Windows.Forms.Label
        Me.cboTipoCuenta = New System.Windows.Forms.ComboBox
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.btnNuevaCuenta = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTipoCuenta
        '
        resources.ApplyResources(Me.lblTipoCuenta, "lblTipoCuenta")
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCuenta.FormattingEnabled = True
        resources.ApplyResources(Me.cboTipoCuenta, "cboTipoCuenta")
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        '
        'lblMoneda
        '
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.Name = "lblMoneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        resources.ApplyResources(Me.cboMoneda, "cboMoneda")
        Me.cboMoneda.Name = "cboMoneda"
        '
        'btnNuevaCuenta
        '
        resources.ApplyResources(Me.btnNuevaCuenta, "btnNuevaCuenta")
        Me.btnNuevaCuenta.Name = "btnNuevaCuenta"
        Me.btnNuevaCuenta.UseVisualStyleBackColor = True
        '
        'frmNuevaCuenta
        '
        Me.AcceptButton = Me.btnNuevaCuenta
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnNuevaCuenta)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.cboTipoCuenta)
        Me.Controls.Add(Me.lblTipoCuenta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaCuenta"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
    Friend WithEvents cboTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevaCuenta As System.Windows.Forms.Button
End Class
