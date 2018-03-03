<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaChequera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaChequera))
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblTipo = New System.Windows.Forms.Label
        Me.lblDiaCruzado = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.cboDiaCruzado = New System.Windows.Forms.ComboBox
        Me.btnNuevaChequera = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblNumero
        '
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Name = "lblNumero"
        '
        'lblTipo
        '
        resources.ApplyResources(Me.lblTipo, "lblTipo")
        Me.lblTipo.Name = "lblTipo"
        '
        'lblDiaCruzado
        '
        resources.ApplyResources(Me.lblDiaCruzado, "lblDiaCruzado")
        Me.lblDiaCruzado.Name = "lblDiaCruzado"
        '
        'txtNumero
        '
        resources.ApplyResources(Me.txtNumero, "txtNumero")
        Me.txtNumero.Name = "txtNumero"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        resources.ApplyResources(Me.cboTipo, "cboTipo")
        Me.cboTipo.Name = "cboTipo"
        '
        'cboDiaCruzado
        '
        Me.cboDiaCruzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaCruzado.FormattingEnabled = True
        resources.ApplyResources(Me.cboDiaCruzado, "cboDiaCruzado")
        Me.cboDiaCruzado.Name = "cboDiaCruzado"
        '
        'btnNuevaChequera
        '
        resources.ApplyResources(Me.btnNuevaChequera, "btnNuevaChequera")
        Me.btnNuevaChequera.Name = "btnNuevaChequera"
        Me.btnNuevaChequera.UseVisualStyleBackColor = True
        '
        'frmNuevaChequera
        '
        Me.AcceptButton = Me.btnNuevaChequera
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnNuevaChequera)
        Me.Controls.Add(Me.cboDiaCruzado)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblDiaCruzado)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblNumero)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaChequera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblDiaCruzado As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaCruzado As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevaChequera As System.Windows.Forms.Button
End Class
