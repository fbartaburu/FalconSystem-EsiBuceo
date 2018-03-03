<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaCaja))
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblIP = New System.Windows.Forms.Label
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.lblNombreData = New System.Windows.Forms.Label
        Me.lblIPData = New System.Windows.Forms.Label
        Me.cboSucursales = New System.Windows.Forms.ComboBox
        Me.btnNuevaCaja = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblNombre
        '
        resources.ApplyResources(Me.lblNombre, "lblNombre")
        Me.lblNombre.Name = "lblNombre"
        '
        'lblIP
        '
        resources.ApplyResources(Me.lblIP, "lblIP")
        Me.lblIP.Name = "lblIP"
        '
        'lblSucursal
        '
        resources.ApplyResources(Me.lblSucursal, "lblSucursal")
        Me.lblSucursal.Name = "lblSucursal"
        '
        'lblNombreData
        '
        resources.ApplyResources(Me.lblNombreData, "lblNombreData")
        Me.lblNombreData.Name = "lblNombreData"
        '
        'lblIPData
        '
        resources.ApplyResources(Me.lblIPData, "lblIPData")
        Me.lblIPData.Name = "lblIPData"
        '
        'cboSucursales
        '
        Me.cboSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursales.FormattingEnabled = True
        resources.ApplyResources(Me.cboSucursales, "cboSucursales")
        Me.cboSucursales.Name = "cboSucursales"
        '
        'btnNuevaCaja
        '
        resources.ApplyResources(Me.btnNuevaCaja, "btnNuevaCaja")
        Me.btnNuevaCaja.Name = "btnNuevaCaja"
        Me.btnNuevaCaja.UseVisualStyleBackColor = True
        '
        'frmNuevaCaja
        '
        Me.AcceptButton = Me.btnNuevaCaja
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnNuevaCaja)
        Me.Controls.Add(Me.cboSucursales)
        Me.Controls.Add(Me.lblIPData)
        Me.Controls.Add(Me.lblNombreData)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.lblNombre)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaCaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblNombreData As System.Windows.Forms.Label
    Friend WithEvents lblIPData As System.Windows.Forms.Label
    Friend WithEvents cboSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevaCaja As System.Windows.Forms.Button
End Class
