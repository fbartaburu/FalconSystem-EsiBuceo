<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.rcPrincipal = New DevComponents.DotNetBar.RibbonControl
        Me.rpGerente = New DevComponents.DotNetBar.RibbonPanel
        Me.rbGerenteMonedas = New DevComponents.DotNetBar.RibbonBar
        Me.icGerenteMonedas = New DevComponents.DotNetBar.ItemContainer
        Me.btnGerenteMonedas = New DevComponents.DotNetBar.ButtonItem
        Me.lblGerenteMonedas = New DevComponents.DotNetBar.LabelItem
        Me.rbGerenteSucursal = New DevComponents.DotNetBar.RibbonBar
        Me.icGerenteSucursal = New DevComponents.DotNetBar.ItemContainer
        Me.btnGerenteBuscarSucursal = New DevComponents.DotNetBar.ButtonItem
        Me.icGerenteBuscarSucursal = New DevComponents.DotNetBar.LabelItem
        Me.rpAComercial = New DevComponents.DotNetBar.RibbonPanel
        Me.rbAcomMonedas = New DevComponents.DotNetBar.RibbonBar
        Me.icAcomMonedas = New DevComponents.DotNetBar.ItemContainer
        Me.btnAcomMonedas = New DevComponents.DotNetBar.ButtonItem
        Me.lblAcomMonedas = New DevComponents.DotNetBar.LabelItem
        Me.rbAcomCliente = New DevComponents.DotNetBar.RibbonBar
        Me.icAcomNuevoCliente = New DevComponents.DotNetBar.ItemContainer
        Me.btnAcomNuevoCliente = New DevComponents.DotNetBar.ButtonItem
        Me.lblAcomNuevoCliente = New DevComponents.DotNetBar.LabelItem
        Me.icAcomBuscarCliente = New DevComponents.DotNetBar.ItemContainer
        Me.btnAcomBuscarCliente = New DevComponents.DotNetBar.ButtonItem
        Me.lblAcomBuscarCliente = New DevComponents.DotNetBar.LabelItem
        Me.rpCajero = New DevComponents.DotNetBar.RibbonPanel
        Me.rbCajeroCheque = New DevComponents.DotNetBar.RibbonBar
        Me.icCajeroCheques = New DevComponents.DotNetBar.ItemContainer
        Me.btnCajeroCheque = New DevComponents.DotNetBar.ButtonItem
        Me.lblCajeroCheque = New DevComponents.DotNetBar.LabelItem
        Me.rbCajeroMonedas = New DevComponents.DotNetBar.RibbonBar
        Me.icCajeroMonedas = New DevComponents.DotNetBar.ItemContainer
        Me.btnCajeroMonedas = New DevComponents.DotNetBar.ButtonItem
        Me.lblCajeroMonedas = New DevComponents.DotNetBar.LabelItem
        Me.rbCajeroNoClientes = New DevComponents.DotNetBar.RibbonBar
        Me.icCajeroNoCliente = New DevComponents.DotNetBar.ItemContainer
        Me.btnCajeroDeposito = New DevComponents.DotNetBar.ButtonItem
        Me.lblCajeroDeposito = New DevComponents.DotNetBar.LabelItem
        Me.rbCajeroClientes = New DevComponents.DotNetBar.RibbonBar
        Me.icCajeroBuscarCliente = New DevComponents.DotNetBar.ItemContainer
        Me.btnCajeroBuscarCliente = New DevComponents.DotNetBar.ButtonItem
        Me.lblCajeroBuscarCliente = New DevComponents.DotNetBar.LabelItem
        Me.rtabCajero = New DevComponents.DotNetBar.RibbonTabItem
        Me.rtabAComercial = New DevComponents.DotNetBar.RibbonTabItem
        Me.rtabGerente = New DevComponents.DotNetBar.RibbonTabItem
        Me.smEstilo = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ssBar = New System.Windows.Forms.StatusStrip
        Me.tssLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.rcPrincipal.SuspendLayout()
        Me.rpGerente.SuspendLayout()
        Me.rpAComercial.SuspendLayout()
        Me.rpCajero.SuspendLayout()
        Me.ssBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'rcPrincipal
        '
        '
        '
        '
        Me.rcPrincipal.BackgroundStyle.Class = ""
        Me.rcPrincipal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rcPrincipal.CaptionVisible = True
        Me.rcPrincipal.Controls.Add(Me.rpGerente)
        Me.rcPrincipal.Controls.Add(Me.rpAComercial)
        Me.rcPrincipal.Controls.Add(Me.rpCajero)
        resources.ApplyResources(Me.rcPrincipal, "rcPrincipal")
        Me.rcPrincipal.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.rtabCajero, Me.rtabAComercial, Me.rtabGerente})
        Me.rcPrincipal.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.rcPrincipal.Name = "rcPrincipal"
        Me.rcPrincipal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rcPrincipal.TabGroupHeight = 14
        '
        'rpGerente
        '
        Me.rpGerente.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rpGerente.Controls.Add(Me.rbGerenteMonedas)
        Me.rpGerente.Controls.Add(Me.rbGerenteSucursal)
        resources.ApplyResources(Me.rpGerente, "rpGerente")
        Me.rpGerente.Name = "rpGerente"
        '
        '
        '
        Me.rpGerente.Style.Class = ""
        Me.rpGerente.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rpGerente.StyleMouseDown.Class = ""
        Me.rpGerente.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rpGerente.StyleMouseOver.Class = ""
        Me.rpGerente.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'rbGerenteMonedas
        '
        Me.rbGerenteMonedas.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbGerenteMonedas.BackgroundMouseOverStyle.Class = ""
        Me.rbGerenteMonedas.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbGerenteMonedas.BackgroundStyle.Class = ""
        Me.rbGerenteMonedas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbGerenteMonedas.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbGerenteMonedas, "rbGerenteMonedas")
        Me.rbGerenteMonedas.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icGerenteMonedas})
        Me.rbGerenteMonedas.Name = "rbGerenteMonedas"
        Me.rbGerenteMonedas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbGerenteMonedas.TitleStyle.Class = ""
        Me.rbGerenteMonedas.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbGerenteMonedas.TitleStyleMouseOver.Class = ""
        Me.rbGerenteMonedas.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icGerenteMonedas
        '
        '
        '
        '
        Me.icGerenteMonedas.BackgroundStyle.Class = ""
        Me.icGerenteMonedas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icGerenteMonedas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icGerenteMonedas.Name = "icGerenteMonedas"
        Me.icGerenteMonedas.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnGerenteMonedas, Me.lblGerenteMonedas})
        '
        'btnGerenteMonedas
        '
        Me.btnGerenteMonedas.Image = Global.Escritorio.My.Resources.Resources.if_resolutions_16_897226
        Me.btnGerenteMonedas.ImageFixedSize = New System.Drawing.Size(72, 72)
        Me.btnGerenteMonedas.Name = "btnGerenteMonedas"
        Me.btnGerenteMonedas.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnGerenteMonedas.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnGerenteMonedas, "btnGerenteMonedas")
        '
        'lblGerenteMonedas
        '
        Me.lblGerenteMonedas.Name = "lblGerenteMonedas"
        resources.ApplyResources(Me.lblGerenteMonedas, "lblGerenteMonedas")
        Me.lblGerenteMonedas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbGerenteSucursal
        '
        Me.rbGerenteSucursal.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbGerenteSucursal.BackgroundMouseOverStyle.Class = ""
        Me.rbGerenteSucursal.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbGerenteSucursal.BackgroundStyle.Class = ""
        Me.rbGerenteSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbGerenteSucursal.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbGerenteSucursal, "rbGerenteSucursal")
        Me.rbGerenteSucursal.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icGerenteSucursal})
        Me.rbGerenteSucursal.Name = "rbGerenteSucursal"
        Me.rbGerenteSucursal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbGerenteSucursal.TitleStyle.Class = ""
        Me.rbGerenteSucursal.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbGerenteSucursal.TitleStyleMouseOver.Class = ""
        Me.rbGerenteSucursal.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icGerenteSucursal
        '
        '
        '
        '
        Me.icGerenteSucursal.BackgroundStyle.Class = ""
        Me.icGerenteSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icGerenteSucursal.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icGerenteSucursal.Name = "icGerenteSucursal"
        Me.icGerenteSucursal.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnGerenteBuscarSucursal, Me.icGerenteBuscarSucursal})
        '
        'btnGerenteBuscarSucursal
        '
        Me.btnGerenteBuscarSucursal.Image = CType(resources.GetObject("btnGerenteBuscarSucursal.Image"), System.Drawing.Image)
        Me.btnGerenteBuscarSucursal.ImageFixedSize = New System.Drawing.Size(72, 72)
        Me.btnGerenteBuscarSucursal.Name = "btnGerenteBuscarSucursal"
        Me.btnGerenteBuscarSucursal.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnGerenteBuscarSucursal.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnGerenteBuscarSucursal, "btnGerenteBuscarSucursal")
        '
        'icGerenteBuscarSucursal
        '
        Me.icGerenteBuscarSucursal.Name = "icGerenteBuscarSucursal"
        resources.ApplyResources(Me.icGerenteBuscarSucursal, "icGerenteBuscarSucursal")
        Me.icGerenteBuscarSucursal.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rpAComercial
        '
        Me.rpAComercial.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rpAComercial.Controls.Add(Me.rbAcomMonedas)
        Me.rpAComercial.Controls.Add(Me.rbAcomCliente)
        resources.ApplyResources(Me.rpAComercial, "rpAComercial")
        Me.rpAComercial.Name = "rpAComercial"
        '
        '
        '
        Me.rpAComercial.Style.Class = ""
        Me.rpAComercial.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rpAComercial.StyleMouseDown.Class = ""
        Me.rpAComercial.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rpAComercial.StyleMouseOver.Class = ""
        Me.rpAComercial.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'rbAcomMonedas
        '
        Me.rbAcomMonedas.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbAcomMonedas.BackgroundMouseOverStyle.Class = ""
        Me.rbAcomMonedas.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbAcomMonedas.BackgroundStyle.Class = ""
        Me.rbAcomMonedas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbAcomMonedas.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbAcomMonedas, "rbAcomMonedas")
        Me.rbAcomMonedas.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icAcomMonedas})
        Me.rbAcomMonedas.Name = "rbAcomMonedas"
        Me.rbAcomMonedas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbAcomMonedas.TitleStyle.Class = ""
        Me.rbAcomMonedas.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbAcomMonedas.TitleStyleMouseOver.Class = ""
        Me.rbAcomMonedas.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icAcomMonedas
        '
        '
        '
        '
        Me.icAcomMonedas.BackgroundStyle.Class = ""
        Me.icAcomMonedas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icAcomMonedas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icAcomMonedas.Name = "icAcomMonedas"
        Me.icAcomMonedas.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAcomMonedas, Me.lblAcomMonedas})
        '
        'btnAcomMonedas
        '
        Me.btnAcomMonedas.Image = Global.Escritorio.My.Resources.Resources.if_resolutions_16_897226
        Me.btnAcomMonedas.ImageFixedSize = New System.Drawing.Size(72, 72)
        Me.btnAcomMonedas.Name = "btnAcomMonedas"
        Me.btnAcomMonedas.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAcomMonedas.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnAcomMonedas, "btnAcomMonedas")
        '
        'lblAcomMonedas
        '
        Me.lblAcomMonedas.Name = "lblAcomMonedas"
        resources.ApplyResources(Me.lblAcomMonedas, "lblAcomMonedas")
        Me.lblAcomMonedas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbAcomCliente
        '
        Me.rbAcomCliente.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbAcomCliente.BackgroundMouseOverStyle.Class = ""
        Me.rbAcomCliente.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbAcomCliente.BackgroundStyle.Class = ""
        Me.rbAcomCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbAcomCliente.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbAcomCliente, "rbAcomCliente")
        Me.rbAcomCliente.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icAcomNuevoCliente, Me.icAcomBuscarCliente})
        Me.rbAcomCliente.Name = "rbAcomCliente"
        Me.rbAcomCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbAcomCliente.TitleStyle.Class = ""
        Me.rbAcomCliente.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbAcomCliente.TitleStyleMouseOver.Class = ""
        Me.rbAcomCliente.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icAcomNuevoCliente
        '
        '
        '
        '
        Me.icAcomNuevoCliente.BackgroundStyle.Class = ""
        Me.icAcomNuevoCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icAcomNuevoCliente.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icAcomNuevoCliente.Name = "icAcomNuevoCliente"
        Me.icAcomNuevoCliente.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAcomNuevoCliente, Me.lblAcomNuevoCliente})
        '
        'btnAcomNuevoCliente
        '
        Me.btnAcomNuevoCliente.Image = Global.Escritorio.My.Resources.Resources.if_contact_new_23203
        Me.btnAcomNuevoCliente.Name = "btnAcomNuevoCliente"
        Me.btnAcomNuevoCliente.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAcomNuevoCliente.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnAcomNuevoCliente, "btnAcomNuevoCliente")
        '
        'lblAcomNuevoCliente
        '
        Me.lblAcomNuevoCliente.Name = "lblAcomNuevoCliente"
        resources.ApplyResources(Me.lblAcomNuevoCliente, "lblAcomNuevoCliente")
        Me.lblAcomNuevoCliente.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'icAcomBuscarCliente
        '
        '
        '
        '
        Me.icAcomBuscarCliente.BackgroundStyle.Class = ""
        Me.icAcomBuscarCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icAcomBuscarCliente.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icAcomBuscarCliente.Name = "icAcomBuscarCliente"
        Me.icAcomBuscarCliente.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAcomBuscarCliente, Me.lblAcomBuscarCliente})
        '
        'btnAcomBuscarCliente
        '
        Me.btnAcomBuscarCliente.Image = Global.Escritorio.My.Resources.Resources.if_new_zoom_best_fit_23480
        Me.btnAcomBuscarCliente.Name = "btnAcomBuscarCliente"
        Me.btnAcomBuscarCliente.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAcomBuscarCliente.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnAcomBuscarCliente, "btnAcomBuscarCliente")
        '
        'lblAcomBuscarCliente
        '
        Me.lblAcomBuscarCliente.Name = "lblAcomBuscarCliente"
        resources.ApplyResources(Me.lblAcomBuscarCliente, "lblAcomBuscarCliente")
        Me.lblAcomBuscarCliente.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rpCajero
        '
        Me.rpCajero.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rpCajero.Controls.Add(Me.rbCajeroCheque)
        Me.rpCajero.Controls.Add(Me.rbCajeroMonedas)
        Me.rpCajero.Controls.Add(Me.rbCajeroNoClientes)
        Me.rpCajero.Controls.Add(Me.rbCajeroClientes)
        resources.ApplyResources(Me.rpCajero, "rpCajero")
        Me.rpCajero.Name = "rpCajero"
        '
        '
        '
        Me.rpCajero.Style.Class = ""
        Me.rpCajero.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rpCajero.StyleMouseDown.Class = ""
        Me.rpCajero.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rpCajero.StyleMouseOver.Class = ""
        Me.rpCajero.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'rbCajeroCheque
        '
        Me.rbCajeroCheque.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbCajeroCheque.BackgroundMouseOverStyle.Class = ""
        Me.rbCajeroCheque.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroCheque.BackgroundStyle.Class = ""
        Me.rbCajeroCheque.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbCajeroCheque.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbCajeroCheque, "rbCajeroCheque")
        Me.rbCajeroCheque.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icCajeroCheques})
        Me.rbCajeroCheque.Name = "rbCajeroCheque"
        Me.rbCajeroCheque.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbCajeroCheque.TitleStyle.Class = ""
        Me.rbCajeroCheque.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroCheque.TitleStyleMouseOver.Class = ""
        Me.rbCajeroCheque.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icCajeroCheques
        '
        '
        '
        '
        Me.icCajeroCheques.BackgroundStyle.Class = ""
        Me.icCajeroCheques.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icCajeroCheques.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icCajeroCheques.Name = "icCajeroCheques"
        Me.icCajeroCheques.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCajeroCheque, Me.lblCajeroCheque})
        '
        'btnCajeroCheque
        '
        Me.btnCajeroCheque.Image = Global.Escritorio.My.Resources.Resources.if_checks_87418
        Me.btnCajeroCheque.ImageFixedSize = New System.Drawing.Size(72, 72)
        Me.btnCajeroCheque.Name = "btnCajeroCheque"
        Me.btnCajeroCheque.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCajeroCheque.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnCajeroCheque, "btnCajeroCheque")
        '
        'lblCajeroCheque
        '
        Me.lblCajeroCheque.Name = "lblCajeroCheque"
        resources.ApplyResources(Me.lblCajeroCheque, "lblCajeroCheque")
        Me.lblCajeroCheque.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbCajeroMonedas
        '
        Me.rbCajeroMonedas.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbCajeroMonedas.BackgroundMouseOverStyle.Class = ""
        Me.rbCajeroMonedas.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroMonedas.BackgroundStyle.Class = ""
        Me.rbCajeroMonedas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbCajeroMonedas.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbCajeroMonedas, "rbCajeroMonedas")
        Me.rbCajeroMonedas.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icCajeroMonedas})
        Me.rbCajeroMonedas.Name = "rbCajeroMonedas"
        Me.rbCajeroMonedas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbCajeroMonedas.TitleStyle.Class = ""
        Me.rbCajeroMonedas.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroMonedas.TitleStyleMouseOver.Class = ""
        Me.rbCajeroMonedas.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icCajeroMonedas
        '
        '
        '
        '
        Me.icCajeroMonedas.BackgroundStyle.Class = ""
        Me.icCajeroMonedas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icCajeroMonedas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icCajeroMonedas.Name = "icCajeroMonedas"
        Me.icCajeroMonedas.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCajeroMonedas, Me.lblCajeroMonedas})
        '
        'btnCajeroMonedas
        '
        Me.btnCajeroMonedas.Image = Global.Escritorio.My.Resources.Resources.if_resolutions_16_897226
        Me.btnCajeroMonedas.ImageFixedSize = New System.Drawing.Size(72, 72)
        Me.btnCajeroMonedas.Name = "btnCajeroMonedas"
        Me.btnCajeroMonedas.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCajeroMonedas.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnCajeroMonedas, "btnCajeroMonedas")
        '
        'lblCajeroMonedas
        '
        Me.lblCajeroMonedas.Name = "lblCajeroMonedas"
        resources.ApplyResources(Me.lblCajeroMonedas, "lblCajeroMonedas")
        Me.lblCajeroMonedas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbCajeroNoClientes
        '
        Me.rbCajeroNoClientes.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbCajeroNoClientes.BackgroundMouseOverStyle.Class = ""
        Me.rbCajeroNoClientes.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroNoClientes.BackgroundStyle.Class = ""
        Me.rbCajeroNoClientes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbCajeroNoClientes.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbCajeroNoClientes, "rbCajeroNoClientes")
        Me.rbCajeroNoClientes.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icCajeroNoCliente})
        Me.rbCajeroNoClientes.Name = "rbCajeroNoClientes"
        Me.rbCajeroNoClientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbCajeroNoClientes.TitleStyle.Class = ""
        Me.rbCajeroNoClientes.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroNoClientes.TitleStyleMouseOver.Class = ""
        Me.rbCajeroNoClientes.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icCajeroNoCliente
        '
        '
        '
        '
        Me.icCajeroNoCliente.BackgroundStyle.Class = ""
        Me.icCajeroNoCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icCajeroNoCliente.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icCajeroNoCliente.Name = "icCajeroNoCliente"
        Me.icCajeroNoCliente.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCajeroDeposito, Me.lblCajeroDeposito})
        '
        'btnCajeroDeposito
        '
        Me.btnCajeroDeposito.Image = Global.Escritorio.My.Resources.Resources.if_Money_Increase_379473
        Me.btnCajeroDeposito.ImageFixedSize = New System.Drawing.Size(72, 72)
        Me.btnCajeroDeposito.Name = "btnCajeroDeposito"
        Me.btnCajeroDeposito.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCajeroDeposito.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnCajeroDeposito, "btnCajeroDeposito")
        '
        'lblCajeroDeposito
        '
        Me.lblCajeroDeposito.Name = "lblCajeroDeposito"
        resources.ApplyResources(Me.lblCajeroDeposito, "lblCajeroDeposito")
        Me.lblCajeroDeposito.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbCajeroClientes
        '
        Me.rbCajeroClientes.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbCajeroClientes.BackgroundMouseOverStyle.Class = ""
        Me.rbCajeroClientes.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroClientes.BackgroundStyle.Class = ""
        Me.rbCajeroClientes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbCajeroClientes.ContainerControlProcessDialogKey = True
        resources.ApplyResources(Me.rbCajeroClientes, "rbCajeroClientes")
        Me.rbCajeroClientes.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.icCajeroBuscarCliente})
        Me.rbCajeroClientes.Name = "rbCajeroClientes"
        Me.rbCajeroClientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        '
        '
        Me.rbCajeroClientes.TitleStyle.Class = ""
        Me.rbCajeroClientes.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbCajeroClientes.TitleStyleMouseOver.Class = ""
        Me.rbCajeroClientes.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'icCajeroBuscarCliente
        '
        '
        '
        '
        Me.icCajeroBuscarCliente.BackgroundStyle.Class = ""
        Me.icCajeroBuscarCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.icCajeroBuscarCliente.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.icCajeroBuscarCliente.Name = "icCajeroBuscarCliente"
        Me.icCajeroBuscarCliente.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCajeroBuscarCliente, Me.lblCajeroBuscarCliente})
        '
        'btnCajeroBuscarCliente
        '
        Me.btnCajeroBuscarCliente.Image = Global.Escritorio.My.Resources.Resources.if_new_zoom_best_fit_23480
        Me.btnCajeroBuscarCliente.Name = "btnCajeroBuscarCliente"
        Me.btnCajeroBuscarCliente.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCajeroBuscarCliente.SubItemsExpandWidth = 14
        resources.ApplyResources(Me.btnCajeroBuscarCliente, "btnCajeroBuscarCliente")
        '
        'lblCajeroBuscarCliente
        '
        Me.lblCajeroBuscarCliente.Name = "lblCajeroBuscarCliente"
        resources.ApplyResources(Me.lblCajeroBuscarCliente, "lblCajeroBuscarCliente")
        Me.lblCajeroBuscarCliente.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rtabCajero
        '
        Me.rtabCajero.Name = "rtabCajero"
        Me.rtabCajero.Panel = Me.rpCajero
        resources.ApplyResources(Me.rtabCajero, "rtabCajero")
        Me.rtabCajero.Visible = False
        '
        'rtabAComercial
        '
        Me.rtabAComercial.Name = "rtabAComercial"
        Me.rtabAComercial.Panel = Me.rpAComercial
        resources.ApplyResources(Me.rtabAComercial, "rtabAComercial")
        Me.rtabAComercial.Visible = False
        '
        'rtabGerente
        '
        Me.rtabGerente.Checked = True
        Me.rtabGerente.Name = "rtabGerente"
        Me.rtabGerente.Panel = Me.rpGerente
        resources.ApplyResources(Me.rtabGerente, "rtabGerente")
        Me.rtabGerente.Visible = False
        '
        'smEstilo
        '
        Me.smEstilo.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        '
        'ssBar
        '
        Me.ssBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabel1, Me.tssLabel2, Me.tssLabel3, Me.tssLabel4, Me.tssLabel5, Me.tssLabel6, Me.tssLabel7, Me.tssLabel8, Me.tssLabel9})
        resources.ApplyResources(Me.ssBar, "ssBar")
        Me.ssBar.Name = "ssBar"
        Me.ssBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        '
        'tssLabel1
        '
        Me.tssLabel1.Name = "tssLabel1"
        resources.ApplyResources(Me.tssLabel1, "tssLabel1")
        '
        'tssLabel2
        '
        Me.tssLabel2.Name = "tssLabel2"
        resources.ApplyResources(Me.tssLabel2, "tssLabel2")
        '
        'tssLabel3
        '
        Me.tssLabel3.Name = "tssLabel3"
        resources.ApplyResources(Me.tssLabel3, "tssLabel3")
        '
        'tssLabel4
        '
        Me.tssLabel4.Name = "tssLabel4"
        resources.ApplyResources(Me.tssLabel4, "tssLabel4")
        '
        'tssLabel5
        '
        Me.tssLabel5.Name = "tssLabel5"
        resources.ApplyResources(Me.tssLabel5, "tssLabel5")
        '
        'tssLabel6
        '
        Me.tssLabel6.Name = "tssLabel6"
        resources.ApplyResources(Me.tssLabel6, "tssLabel6")
        '
        'tssLabel7
        '
        Me.tssLabel7.Name = "tssLabel7"
        resources.ApplyResources(Me.tssLabel7, "tssLabel7")
        '
        'tssLabel8
        '
        Me.tssLabel8.Name = "tssLabel8"
        resources.ApplyResources(Me.tssLabel8, "tssLabel8")
        '
        'tssLabel9
        '
        Me.tssLabel9.Name = "tssLabel9"
        resources.ApplyResources(Me.tssLabel9, "tssLabel9")
        '
        'frmPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ssBar)
        Me.Controls.Add(Me.rcPrincipal)
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.rcPrincipal.ResumeLayout(False)
        Me.rcPrincipal.PerformLayout()
        Me.rpGerente.ResumeLayout(False)
        Me.rpAComercial.ResumeLayout(False)
        Me.rpCajero.ResumeLayout(False)
        Me.ssBar.ResumeLayout(False)
        Me.ssBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rcPrincipal As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents smEstilo As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ssBar As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rpCajero As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rbCajeroClientes As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icCajeroBuscarCliente As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnCajeroBuscarCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblCajeroBuscarCliente As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rtabCajero As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents rbCajeroNoClientes As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icCajeroNoCliente As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnCajeroDeposito As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblCajeroDeposito As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rbCajeroMonedas As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnCajeroMonedas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents icCajeroMonedas As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents lblCajeroMonedas As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rbCajeroCheque As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icCajeroCheques As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnCajeroCheque As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblCajeroCheque As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rpAComercial As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rtabAComercial As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents rbAcomCliente As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icAcomNuevoCliente As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnAcomNuevoCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblAcomNuevoCliente As DevComponents.DotNetBar.LabelItem
    Friend WithEvents icAcomBuscarCliente As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnAcomBuscarCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblAcomBuscarCliente As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rbAcomMonedas As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icAcomMonedas As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnAcomMonedas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblAcomMonedas As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rpGerente As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rtabGerente As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents rbGerenteSucursal As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icGerenteSucursal As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnGerenteBuscarSucursal As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents icGerenteBuscarSucursal As DevComponents.DotNetBar.LabelItem
    Friend WithEvents rbGerenteMonedas As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents icGerenteMonedas As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnGerenteMonedas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblGerenteMonedas As DevComponents.DotNetBar.LabelItem
End Class
