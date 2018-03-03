<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbrirCaja))
        Me.gbUYU = New System.Windows.Forms.GroupBox
        Me.txtCantidadUYU = New System.Windows.Forms.TextBox
        Me.lblCantidadUYU = New System.Windows.Forms.Label
        Me.gbUSD = New System.Windows.Forms.GroupBox
        Me.txtCantidadUSD = New System.Windows.Forms.TextBox
        Me.lblCantidadUSD = New System.Windows.Forms.Label
        Me.btnAbrir = New System.Windows.Forms.Button
        Me.gbUYU.SuspendLayout()
        Me.gbUSD.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbUYU
        '
        Me.gbUYU.AccessibleDescription = Nothing
        Me.gbUYU.AccessibleName = Nothing
        resources.ApplyResources(Me.gbUYU, "gbUYU")
        Me.gbUYU.BackgroundImage = Nothing
        Me.gbUYU.Controls.Add(Me.txtCantidadUYU)
        Me.gbUYU.Controls.Add(Me.lblCantidadUYU)
        Me.gbUYU.Font = Nothing
        Me.gbUYU.Name = "gbUYU"
        Me.gbUYU.TabStop = False
        '
        'txtCantidadUYU
        '
        Me.txtCantidadUYU.AccessibleDescription = Nothing
        Me.txtCantidadUYU.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCantidadUYU, "txtCantidadUYU")
        Me.txtCantidadUYU.BackgroundImage = Nothing
        Me.txtCantidadUYU.Font = Nothing
        Me.txtCantidadUYU.Name = "txtCantidadUYU"
        '
        'lblCantidadUYU
        '
        Me.lblCantidadUYU.AccessibleDescription = Nothing
        Me.lblCantidadUYU.AccessibleName = Nothing
        resources.ApplyResources(Me.lblCantidadUYU, "lblCantidadUYU")
        Me.lblCantidadUYU.Font = Nothing
        Me.lblCantidadUYU.Name = "lblCantidadUYU"
        '
        'gbUSD
        '
        Me.gbUSD.AccessibleDescription = Nothing
        Me.gbUSD.AccessibleName = Nothing
        resources.ApplyResources(Me.gbUSD, "gbUSD")
        Me.gbUSD.BackgroundImage = Nothing
        Me.gbUSD.Controls.Add(Me.txtCantidadUSD)
        Me.gbUSD.Controls.Add(Me.lblCantidadUSD)
        Me.gbUSD.Font = Nothing
        Me.gbUSD.Name = "gbUSD"
        Me.gbUSD.TabStop = False
        '
        'txtCantidadUSD
        '
        Me.txtCantidadUSD.AccessibleDescription = Nothing
        Me.txtCantidadUSD.AccessibleName = Nothing
        resources.ApplyResources(Me.txtCantidadUSD, "txtCantidadUSD")
        Me.txtCantidadUSD.BackgroundImage = Nothing
        Me.txtCantidadUSD.Font = Nothing
        Me.txtCantidadUSD.Name = "txtCantidadUSD"
        '
        'lblCantidadUSD
        '
        Me.lblCantidadUSD.AccessibleDescription = Nothing
        Me.lblCantidadUSD.AccessibleName = Nothing
        resources.ApplyResources(Me.lblCantidadUSD, "lblCantidadUSD")
        Me.lblCantidadUSD.Font = Nothing
        Me.lblCantidadUSD.Name = "lblCantidadUSD"
        '
        'btnAbrir
        '
        Me.btnAbrir.AccessibleDescription = Nothing
        Me.btnAbrir.AccessibleName = Nothing
        resources.ApplyResources(Me.btnAbrir, "btnAbrir")
        Me.btnAbrir.BackgroundImage = Nothing
        Me.btnAbrir.Font = Nothing
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'frmAbrirCaja
        '
        Me.AcceptButton = Me.btnAbrir
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.gbUSD)
        Me.Controls.Add(Me.gbUYU)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.Name = "frmAbrirCaja"
        Me.gbUYU.ResumeLayout(False)
        Me.gbUYU.PerformLayout()
        Me.gbUSD.ResumeLayout(False)
        Me.gbUSD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbUYU As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantidadUYU As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadUYU As System.Windows.Forms.Label
    Friend WithEvents gbUSD As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantidadUSD As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadUSD As System.Windows.Forms.Label
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
End Class
