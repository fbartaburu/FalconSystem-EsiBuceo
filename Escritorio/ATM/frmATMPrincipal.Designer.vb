<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATMPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATMPrincipal))
        Me.btnRetiro = New System.Windows.Forms.Button
        Me.btnDeposito = New System.Windows.Forms.Button
        Me.btnTransferencia = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnCambiarPin = New System.Windows.Forms.Button
        Me.gbPrincipal = New System.Windows.Forms.GroupBox
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.btnCuenta = New System.Windows.Forms.Button
        Me.gbPrincipal.SuspendLayout()
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
        'btnDeposito
        '
        Me.btnDeposito.AccessibleDescription = Nothing
        Me.btnDeposito.AccessibleName = Nothing
        resources.ApplyResources(Me.btnDeposito, "btnDeposito")
        Me.btnDeposito.BackgroundImage = Nothing
        Me.btnDeposito.Font = Nothing
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.UseVisualStyleBackColor = True
        '
        'btnTransferencia
        '
        Me.btnTransferencia.AccessibleDescription = Nothing
        Me.btnTransferencia.AccessibleName = Nothing
        resources.ApplyResources(Me.btnTransferencia, "btnTransferencia")
        Me.btnTransferencia.BackgroundImage = Nothing
        Me.btnTransferencia.Font = Nothing
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleDescription = Nothing
        Me.btnSalir.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.BackgroundImage = Nothing
        Me.btnSalir.Font = Nothing
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCambiarPin
        '
        Me.btnCambiarPin.AccessibleDescription = Nothing
        Me.btnCambiarPin.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCambiarPin, "btnCambiarPin")
        Me.btnCambiarPin.BackgroundImage = Nothing
        Me.btnCambiarPin.Font = Nothing
        Me.btnCambiarPin.Name = "btnCambiarPin"
        Me.btnCambiarPin.UseVisualStyleBackColor = True
        '
        'gbPrincipal
        '
        Me.gbPrincipal.AccessibleDescription = Nothing
        Me.gbPrincipal.AccessibleName = Nothing
        resources.ApplyResources(Me.gbPrincipal, "gbPrincipal")
        Me.gbPrincipal.BackgroundImage = Nothing
        Me.gbPrincipal.Controls.Add(Me.pnlPrincipal)
        Me.gbPrincipal.Font = Nothing
        Me.gbPrincipal.Name = "gbPrincipal"
        Me.gbPrincipal.TabStop = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.AccessibleDescription = Nothing
        Me.pnlPrincipal.AccessibleName = Nothing
        resources.ApplyResources(Me.pnlPrincipal, "pnlPrincipal")
        Me.pnlPrincipal.BackgroundImage = Nothing
        Me.pnlPrincipal.Font = Nothing
        Me.pnlPrincipal.Name = "pnlPrincipal"
        '
        'btnCuenta
        '
        Me.btnCuenta.AccessibleDescription = Nothing
        Me.btnCuenta.AccessibleName = Nothing
        resources.ApplyResources(Me.btnCuenta, "btnCuenta")
        Me.btnCuenta.BackgroundImage = Nothing
        Me.btnCuenta.Font = Nothing
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.UseVisualStyleBackColor = True
        '
        'frmATMPrincipal
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.btnCuenta)
        Me.Controls.Add(Me.gbPrincipal)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCambiarPin)
        Me.Controls.Add(Me.btnTransferencia)
        Me.Controls.Add(Me.btnDeposito)
        Me.Controls.Add(Me.btnRetiro)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmATMPrincipal"
        Me.gbPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRetiro As System.Windows.Forms.Button
    Friend WithEvents btnDeposito As System.Windows.Forms.Button
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCambiarPin As System.Windows.Forms.Button
    Friend WithEvents gbPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents btnCuenta As System.Windows.Forms.Button
End Class
