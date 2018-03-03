<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobrarCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobrarCheque))
        Me.lblIsLocal = New System.Windows.Forms.Label
        Me.lblNumeroChequera = New System.Windows.Forms.Label
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblEmision = New System.Windows.Forms.Label
        Me.rdbLocalYes = New System.Windows.Forms.RadioButton
        Me.rdbLocalNo = New System.Windows.Forms.RadioButton
        Me.txtNumeroChequera = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.cboCurrency = New System.Windows.Forms.ComboBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.dtpEmision = New System.Windows.Forms.DateTimePicker
        Me.btnCobrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblIsLocal
        '
        resources.ApplyResources(Me.lblIsLocal, "lblIsLocal")
        Me.lblIsLocal.Name = "lblIsLocal"
        '
        'lblNumeroChequera
        '
        resources.ApplyResources(Me.lblNumeroChequera, "lblNumeroChequera")
        Me.lblNumeroChequera.Name = "lblNumeroChequera"
        '
        'lblNumero
        '
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Name = "lblNumero"
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
        'lblEmision
        '
        resources.ApplyResources(Me.lblEmision, "lblEmision")
        Me.lblEmision.Name = "lblEmision"
        '
        'rdbLocalYes
        '
        resources.ApplyResources(Me.rdbLocalYes, "rdbLocalYes")
        Me.rdbLocalYes.Name = "rdbLocalYes"
        Me.rdbLocalYes.UseVisualStyleBackColor = True
        '
        'rdbLocalNo
        '
        resources.ApplyResources(Me.rdbLocalNo, "rdbLocalNo")
        Me.rdbLocalNo.Checked = True
        Me.rdbLocalNo.Name = "rdbLocalNo"
        Me.rdbLocalNo.TabStop = True
        Me.rdbLocalNo.UseVisualStyleBackColor = True
        '
        'txtNumeroChequera
        '
        resources.ApplyResources(Me.txtNumeroChequera, "txtNumeroChequera")
        Me.txtNumeroChequera.Name = "txtNumeroChequera"
        '
        'txtNumero
        '
        resources.ApplyResources(Me.txtNumero, "txtNumero")
        Me.txtNumero.Name = "txtNumero"
        '
        'cboCurrency
        '
        Me.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrency.FormattingEnabled = True
        resources.ApplyResources(Me.cboCurrency, "cboCurrency")
        Me.cboCurrency.Name = "cboCurrency"
        '
        'txtMonto
        '
        resources.ApplyResources(Me.txtMonto, "txtMonto")
        Me.txtMonto.Name = "txtMonto"
        '
        'dtpEmision
        '
        Me.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.dtpEmision, "dtpEmision")
        Me.dtpEmision.Name = "dtpEmision"
        '
        'btnCobrar
        '
        resources.ApplyResources(Me.btnCobrar, "btnCobrar")
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'frmCobrarCheque
        '
        Me.AcceptButton = Me.btnCobrar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.dtpEmision)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.cboCurrency)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtNumeroChequera)
        Me.Controls.Add(Me.rdbLocalNo)
        Me.Controls.Add(Me.rdbLocalYes)
        Me.Controls.Add(Me.lblEmision)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblNumeroChequera)
        Me.Controls.Add(Me.lblIsLocal)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCobrarCheque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIsLocal As System.Windows.Forms.Label
    Friend WithEvents lblNumeroChequera As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblEmision As System.Windows.Forms.Label
    Friend WithEvents rdbLocalYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLocalNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtNumeroChequera As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents dtpEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
End Class
