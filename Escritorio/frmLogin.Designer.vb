<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasena As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblContrasena = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtContrasena = New System.Windows.Forms.TextBox
        Me.btnEntrar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.smEstilo = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        resources.ApplyResources(Me.lblUsuario, "lblUsuario")
        Me.lblUsuario.Name = "lblUsuario"
        '
        'lblContrasena
        '
        resources.ApplyResources(Me.lblContrasena, "lblContrasena")
        Me.lblContrasena.Name = "lblContrasena"
        '
        'txtUsuario
        '
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.txtUsuario.Name = "txtUsuario"
        '
        'txtContrasena
        '
        resources.ApplyResources(Me.txtContrasena, "txtContrasena")
        Me.txtContrasena.Name = "txtContrasena"
        '
        'btnEntrar
        '
        resources.ApplyResources(Me.btnEntrar, "btnEntrar")
        Me.btnEntrar.Name = "btnEntrar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.Name = "btnCancelar"
        '
        'smEstilo
        '
        Me.smEstilo.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Escritorio.My.Resources.Resources.FSystems
        resources.ApplyResources(Me.LogoPictureBox, "LogoPictureBox")
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents smEstilo As DevComponents.DotNetBar.StyleManager

End Class
