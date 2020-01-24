<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_06
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_06))
        Me.CT_SGU06 = New AdvancedHMIControls.TempController()
        Me.Guardiola06 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU06 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU06 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU06 = New AdvancedHMIControls.BasicButton()
        Me.BP_INICIO_CICLO_SGU06 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU06 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU06 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU06 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU06 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU06 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU06 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU06 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU06 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU06 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU06 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU06 = New System.Windows.Forms.Label()
        Me.TexGuardiola6 = New System.Windows.Forms.Label()
        Me.TexTempGU06 = New System.Windows.Forms.Label()
        Me.TexPID_GU06 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU06 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU06 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU06 = New System.Windows.Forms.Label()
        Me.IGU06 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU06, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU06
        '
        Me.CT_SGU06.Button1Text = Nothing
        Me.CT_SGU06.Button2Text = Nothing
        Me.CT_SGU06.ComComponent = Me.Guardiola06
        Me.CT_SGU06.DecimalPosition = 1
        Me.CT_SGU06.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU06.Location = New System.Drawing.Point(205, 431)
        Me.CT_SGU06.Name = "CT_SGU06"
        Me.CT_SGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU06.PLCAddressClick1 = ""
        Me.CT_SGU06.PLCAddressClick2 = ""
        Me.CT_SGU06.PLCAddressClick3 = ""
        Me.CT_SGU06.PLCAddressClick4 = ""
        Me.CT_SGU06.PLCAddressText = ""
        Me.CT_SGU06.PLCAddressValuePV = "PID_SGU06.PV"
        Me.CT_SGU06.PLCAddressValueSP = "PID_SGU06.SP"
        Me.CT_SGU06.PLCAddressVisible = ""
        Me.CT_SGU06.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU06.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU06.TabIndex = 603
        Me.CT_SGU06.Text = "S-GU-06"
        Me.CT_SGU06.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU06.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU06.Value2Text = "SP"
        Me.CT_SGU06.ValuePV = 0!
        Me.CT_SGU06.ValueSP = 0!
        '
        'Guardiola06
        '
        Me.Guardiola06.CIPConnectionSize = 508
        Me.Guardiola06.DisableMultiServiceRequest = False
        Me.Guardiola06.DisableSubscriptions = False
        Me.Guardiola06.IniFileName = ""
        Me.Guardiola06.IniFileSection = Nothing
        Me.Guardiola06.IPAddress = "10.1.108.18"
        Me.Guardiola06.PollRateOverride = 500
        Me.Guardiola06.Port = 44818
        Me.Guardiola06.ProcessorSlot = 0
        Me.Guardiola06.RoutePath = Nothing
        Me.Guardiola06.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola06
        Me.BarMeter1.HighlightColor = System.Drawing.Color.Red
        Me.BarMeter1.IniFileName = ""
        Me.BarMeter1.IniFileSection = Nothing
        Me.BarMeter1.Location = New System.Drawing.Point(96, 103)
        Me.BarMeter1.Maximum = 100.0R
        Me.BarMeter1.Minimum = 0R
        Me.BarMeter1.Name = "BarMeter1"
        Me.BarMeter1.PLCAddressText = ""
        Me.BarMeter1.PLCAddressValue = CType(resources.GetObject("BarMeter1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.BarMeter1.PLCAddressVisible = ""
        Me.BarMeter1.Size = New System.Drawing.Size(43, 237)
        Me.BarMeter1.TabIndex = 631
        Me.BarMeter1.Value = 0R
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Red
        Me.BasicButton1.ComComponent = Me.Guardiola06
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(960, 589)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU06"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 601
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU06
        '
        Me.LS_MarchaGU06.Blink = False
        Me.LS_MarchaGU06.ComComponent = Me.Guardiola06
        Me.LS_MarchaGU06.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU06.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU06.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU06.Location = New System.Drawing.Point(858, 317)
        Me.LS_MarchaGU06.Name = "LS_MarchaGU06"
        Me.LS_MarchaGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU06.PLCAddressClick = ""
        Me.LS_MarchaGU06.PLCAddressText = ""
        Me.LS_MarchaGU06.PLCAddressValue = "MARCHA_SGU06"
        Me.LS_MarchaGU06.PLCAddressVisible = ""
        Me.LS_MarchaGU06.Size = New System.Drawing.Size(49, 52)
        Me.LS_MarchaGU06.TabIndex = 598
        Me.LS_MarchaGU06.Value = False
        Me.LS_MarchaGU06.ValueToWrite = 0
        '
        'BCF_MenúP_GU06
        '
        Me.BCF_MenúP_GU06.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU06.ComComponent = Nothing
        Me.BCF_MenúP_GU06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU06.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU06.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU06.KeypadWidth = 300
        Me.BCF_MenúP_GU06.Location = New System.Drawing.Point(231, 647)
        Me.BCF_MenúP_GU06.Name = "BCF_MenúP_GU06"
        Me.BCF_MenúP_GU06.Passcode = Nothing
        Me.BCF_MenúP_GU06.PasswordChar = False
        Me.BCF_MenúP_GU06.PLCAddressVisible = ""
        Me.BCF_MenúP_GU06.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU06.TabIndex = 597
        Me.BCF_MenúP_GU06.Text = "Menú Principal"
        Me.BCF_MenúP_GU06.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU06
        '
        Me.BP_FinCicloGU06.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU06.ComComponent = Me.Guardiola06
        Me.BP_FinCicloGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU06.Highlight = False
        Me.BP_FinCicloGU06.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU06.Location = New System.Drawing.Point(710, 220)
        Me.BP_FinCicloGU06.MaximumHoldTime = 3000
        Me.BP_FinCicloGU06.MinimumHoldTime = 500
        Me.BP_FinCicloGU06.Name = "BP_FinCicloGU06"
        Me.BP_FinCicloGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU06.PLCAddressClick = "BP_DETENER_CICLO_SGU06"
        Me.BP_FinCicloGU06.SelectTextAlternate = False
        Me.BP_FinCicloGU06.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU06.TabIndex = 596
        Me.BP_FinCicloGU06.Text = "Detener Ciclo"
        Me.BP_FinCicloGU06.TextAlternate = Nothing
        Me.BP_FinCicloGU06.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU06.ValueToWrite = 0
        '
        'BP_INICIO_CICLO_SGU06
        '
        Me.BP_INICIO_CICLO_SGU06.BackColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU06.ComComponent = Me.Guardiola06
        Me.BP_INICIO_CICLO_SGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU06.Highlight = False
        Me.BP_INICIO_CICLO_SGU06.HighlightColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU06.Location = New System.Drawing.Point(508, 220)
        Me.BP_INICIO_CICLO_SGU06.MaximumHoldTime = 3000
        Me.BP_INICIO_CICLO_SGU06.MinimumHoldTime = 500
        Me.BP_INICIO_CICLO_SGU06.Name = "BP_INICIO_CICLO_SGU06"
        Me.BP_INICIO_CICLO_SGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_INICIO_CICLO_SGU06.PLCAddressClick = "BP_INICIO_CICLO_SGU06"
        Me.BP_INICIO_CICLO_SGU06.SelectTextAlternate = False
        Me.BP_INICIO_CICLO_SGU06.Size = New System.Drawing.Size(148, 52)
        Me.BP_INICIO_CICLO_SGU06.TabIndex = 595
        Me.BP_INICIO_CICLO_SGU06.Text = "Iniciar Ciclo"
        Me.BP_INICIO_CICLO_SGU06.TextAlternate = Nothing
        Me.BP_INICIO_CICLO_SGU06.UseVisualStyleBackColor = False
        Me.BP_INICIO_CICLO_SGU06.ValueToWrite = 0
        '
        'BCF_RegresarGU06
        '
        Me.BCF_RegresarGU06.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU06.ComComponent = Nothing
        Me.BCF_RegresarGU06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU06.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU06.FormToOpen = Nothing
        Me.BCF_RegresarGU06.KeypadWidth = 300
        Me.BCF_RegresarGU06.Location = New System.Drawing.Point(645, 100)
        Me.BCF_RegresarGU06.Name = "BCF_RegresarGU06"
        Me.BCF_RegresarGU06.Passcode = Nothing
        Me.BCF_RegresarGU06.PasswordChar = False
        Me.BCF_RegresarGU06.PLCAddressVisible = ""
        Me.BCF_RegresarGU06.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU06.TabIndex = 594
        Me.BCF_RegresarGU06.Text = "Regresar"
        Me.BCF_RegresarGU06.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU06
        '
        Me.BP_DescargaGU06.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU06.ComComponent = Me.Guardiola06
        Me.BP_DescargaGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU06.Highlight = False
        Me.BP_DescargaGU06.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU06.Location = New System.Drawing.Point(960, 123)
        Me.BP_DescargaGU06.MaximumHoldTime = 3000
        Me.BP_DescargaGU06.MinimumHoldTime = 500
        Me.BP_DescargaGU06.Name = "BP_DescargaGU06"
        Me.BP_DescargaGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU06.PLCAddressClick = "BP_FINALIZAR_SGU06"
        Me.BP_DescargaGU06.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU06"
        Me.BP_DescargaGU06.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU06"
        Me.BP_DescargaGU06.SelectTextAlternate = False
        Me.BP_DescargaGU06.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU06.TabIndex = 593
        Me.BP_DescargaGU06.Text = "Finalizar"
        Me.BP_DescargaGU06.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU06.UseVisualStyleBackColor = True
        Me.BP_DescargaGU06.ValueToWrite = 0
        '
        'BP_CofirDescagaGU06
        '
        Me.BP_CofirDescagaGU06.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU06.ComComponent = Me.Guardiola06
        Me.BP_CofirDescagaGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU06.Highlight = False
        Me.BP_CofirDescagaGU06.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU06.Location = New System.Drawing.Point(960, 64)
        Me.BP_CofirDescagaGU06.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU06.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU06.Name = "BP_CofirDescagaGU06"
        Me.BP_CofirDescagaGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU06.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU06"
        Me.BP_CofirDescagaGU06.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU06"
        Me.BP_CofirDescagaGU06.SelectTextAlternate = False
        Me.BP_CofirDescagaGU06.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU06.TabIndex = 592
        Me.BP_CofirDescagaGU06.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU06.TextAlternate = Nothing
        Me.BP_CofirDescagaGU06.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU06.ValueToWrite = 0
        '
        'BN_SalidaGU06
        '
        Me.BN_SalidaGU06.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU06.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU06.ComComponent = Me.Guardiola06
        Me.BN_SalidaGU06.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU06.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU06.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU06.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU06.Location = New System.Drawing.Point(357, 156)
        Me.BN_SalidaGU06.Maximum = 100.0R
        Me.BN_SalidaGU06.Minimum = 0R
        Me.BN_SalidaGU06.Name = "BN_SalidaGU06"
        Me.BN_SalidaGU06.NumericFormat = Nothing
        Me.BN_SalidaGU06.PLCAddressValue = "PID_SGU06.OUT"
        Me.BN_SalidaGU06.ShowValue = True
        Me.BN_SalidaGU06.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU06.TabIndex = 591
        Me.BN_SalidaGU06.Text = "BarLevel3"
        Me.BN_SalidaGU06.TextSuffix = Nothing
        Me.BN_SalidaGU06.Value = 0R
        Me.BN_SalidaGU06.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU06
        '
        Me.BN_SP_TempGU06.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU06.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU06.ComComponent = Me.Guardiola06
        Me.BN_SP_TempGU06.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU06.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU06.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU06.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU06.Location = New System.Drawing.Point(215, 157)
        Me.BN_SP_TempGU06.Maximum = 100.0R
        Me.BN_SP_TempGU06.Minimum = 0R
        Me.BN_SP_TempGU06.Name = "BN_SP_TempGU06"
        Me.BN_SP_TempGU06.NumericFormat = Nothing
        Me.BN_SP_TempGU06.PLCAddressValue = "PID_SGU06.SP"
        Me.BN_SP_TempGU06.ShowValue = True
        Me.BN_SP_TempGU06.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU06.TabIndex = 590
        Me.BN_SP_TempGU06.Text = "BarLevel1"
        Me.BN_SP_TempGU06.TextSuffix = Nothing
        Me.BN_SP_TempGU06.Value = 0R
        Me.BN_SP_TempGU06.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU06
        '
        Me.MD_OrdenTrabajoGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU06.ComComponent = Me.Guardiola06
        Me.MD_OrdenTrabajoGU06.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU06.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU06.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU06.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU06.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU06.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU06.Location = New System.Drawing.Point(988, 507)
        Me.MD_OrdenTrabajoGU06.Name = "MD_OrdenTrabajoGU06"
        Me.MD_OrdenTrabajoGU06.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU06.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU06"
        Me.MD_OrdenTrabajoGU06.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU06"
        Me.MD_OrdenTrabajoGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU06.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU06.TabIndex = 589
        Me.MD_OrdenTrabajoGU06.Value = 0R
        Me.MD_OrdenTrabajoGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU06
        '
        Me.MD_CosechaGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU06.ComComponent = Me.Guardiola06
        Me.MD_CosechaGU06.DecimalPosition = 0
        Me.MD_CosechaGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU06.KeypadMaxValue = 0R
        Me.MD_CosechaGU06.KeypadMinValue = 0R
        Me.MD_CosechaGU06.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU06.KeypadText = Nothing
        Me.MD_CosechaGU06.KeypadWidth = 300
        Me.MD_CosechaGU06.Location = New System.Drawing.Point(988, 410)
        Me.MD_CosechaGU06.Name = "MD_CosechaGU06"
        Me.MD_CosechaGU06.NumberOfDigits = 5
        Me.MD_CosechaGU06.PLCAddressKeypad = ""
        Me.MD_CosechaGU06.PLCAddressValue = "COSECHA_SGU06"
        Me.MD_CosechaGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU06.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU06.TabIndex = 588
        Me.MD_CosechaGU06.Value = 0R
        Me.MD_CosechaGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU06
        '
        Me.MD_HorasEstimadasGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU06.ComComponent = Me.Guardiola06
        Me.MD_HorasEstimadasGU06.DecimalPosition = 0
        Me.MD_HorasEstimadasGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU06.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU06.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU06.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU06.KeypadText = Nothing
        Me.MD_HorasEstimadasGU06.KeypadWidth = 300
        Me.MD_HorasEstimadasGU06.Location = New System.Drawing.Point(988, 317)
        Me.MD_HorasEstimadasGU06.Name = "MD_HorasEstimadasGU06"
        Me.MD_HorasEstimadasGU06.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU06.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU06"
        Me.MD_HorasEstimadasGU06.PLCAddressValue = "TIEMPO_ESTIMADO_SGU06"
        Me.MD_HorasEstimadasGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU06.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU06.TabIndex = 587
        Me.MD_HorasEstimadasGU06.Value = 0R
        Me.MD_HorasEstimadasGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU06
        '
        Me.MD_CicloGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU06.ComComponent = Me.Guardiola06
        Me.MD_CicloGU06.DecimalPosition = 0
        Me.MD_CicloGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU06.KeypadMaxValue = 0R
        Me.MD_CicloGU06.KeypadMinValue = 0R
        Me.MD_CicloGU06.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU06.KeypadText = Nothing
        Me.MD_CicloGU06.KeypadWidth = 300
        Me.MD_CicloGU06.Location = New System.Drawing.Point(988, 225)
        Me.MD_CicloGU06.Name = "MD_CicloGU06"
        Me.MD_CicloGU06.NumberOfDigits = 5
        Me.MD_CicloGU06.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU06"
        Me.MD_CicloGU06.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU06"
        Me.MD_CicloGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU06.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU06.TabIndex = 586
        Me.MD_CicloGU06.Value = 0R
        Me.MD_CicloGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU06
        '
        Me.TexCicloGU06.AutoSize = True
        Me.TexCicloGU06.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU06.ComComponent = Me.Guardiola06
        Me.TexCicloGU06.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU06.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU06.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU06.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU06.HighlightKeyCharacter = "!"
        Me.TexCicloGU06.HighlightKeyCharacter2 = "."
        Me.TexCicloGU06.IniFileName = Nothing
        Me.TexCicloGU06.Location = New System.Drawing.Point(578, 521)
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Messages.Add(CType(resources.GetObject("TexCicloGU06.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU06.Name = "TexCicloGU06"
        Me.TexCicloGU06.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU06"
        Me.TexCicloGU06.PLCAddressVisible = ""
        Me.TexCicloGU06.ShowMessageNumber = False
        Me.TexCicloGU06.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU06.SpeakMessage = False
        Me.TexCicloGU06.TabIndex = 599
        Me.TexCicloGU06.Text = "No Seleccionado"
        Me.TexCicloGU06.TextPrefix = Nothing
        Me.TexCicloGU06.Value = 0
        '
        'MD_TempGU06
        '
        Me.MD_TempGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU06.ComComponent = Me.Guardiola06
        Me.MD_TempGU06.DecimalPosition = 1
        Me.MD_TempGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU06.KeypadMaxValue = 0R
        Me.MD_TempGU06.KeypadMinValue = 0R
        Me.MD_TempGU06.KeypadScaleFactor = 1.0R
        Me.MD_TempGU06.KeypadText = Nothing
        Me.MD_TempGU06.KeypadWidth = 300
        Me.MD_TempGU06.Location = New System.Drawing.Point(605, 337)
        Me.MD_TempGU06.Name = "MD_TempGU06"
        Me.MD_TempGU06.NumberOfDigits = 5
        Me.MD_TempGU06.PLCAddressKeypad = ""
        Me.MD_TempGU06.PLCAddressValue = "PID_SGU06.PV"
        Me.MD_TempGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU06.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU06.TabIndex = 585
        Me.MD_TempGU06.Value = 0R
        Me.MD_TempGU06.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU06
        '
        Me.MD_HorasProcesoGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU06.ComComponent = Me.Guardiola06
        Me.MD_HorasProcesoGU06.DecimalPosition = 0
        Me.MD_HorasProcesoGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU06.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU06.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU06.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU06.KeypadText = Nothing
        Me.MD_HorasProcesoGU06.KeypadWidth = 300
        Me.MD_HorasProcesoGU06.Location = New System.Drawing.Point(465, 83)
        Me.MD_HorasProcesoGU06.Name = "MD_HorasProcesoGU06"
        Me.MD_HorasProcesoGU06.NumberOfDigits = 5
        Me.MD_HorasProcesoGU06.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU06.PLCAddressValue = "TIEMPO_SECADO_SGU06"
        Me.MD_HorasProcesoGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU06.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU06.TabIndex = 584
        Me.MD_HorasProcesoGU06.Value = 0R
        Me.MD_HorasProcesoGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU06
        '
        Me.Tex_CicloGU06.AutoSize = True
        Me.Tex_CicloGU06.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU06.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU06.Location = New System.Drawing.Point(975, 203)
        Me.Tex_CicloGU06.Name = "Tex_CicloGU06"
        Me.Tex_CicloGU06.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU06.TabIndex = 583
        Me.Tex_CicloGU06.Text = "Numero de Ciclo"
        Me.Tex_CicloGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU06
        '
        Me.Tex_OrdenTrabajoGU06.AutoSize = True
        Me.Tex_OrdenTrabajoGU06.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU06.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU06.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU06.Location = New System.Drawing.Point(1028, 482)
        Me.Tex_OrdenTrabajoGU06.Name = "Tex_OrdenTrabajoGU06"
        Me.Tex_OrdenTrabajoGU06.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU06.TabIndex = 582
        Me.Tex_OrdenTrabajoGU06.Text = "OT"
        Me.Tex_OrdenTrabajoGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU06
        '
        Me.Tex_CosechaGU06.AutoSize = True
        Me.Tex_CosechaGU06.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU06.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU06.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU06.Location = New System.Drawing.Point(996, 385)
        Me.Tex_CosechaGU06.Name = "Tex_CosechaGU06"
        Me.Tex_CosechaGU06.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU06.TabIndex = 581
        Me.Tex_CosechaGU06.Text = "Cosecha"
        Me.Tex_CosechaGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU06
        '
        Me.Tex_HorasEstimadasGU06.AutoSize = True
        Me.Tex_HorasEstimadasGU06.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU06.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU06.Location = New System.Drawing.Point(928, 295)
        Me.Tex_HorasEstimadasGU06.Name = "Tex_HorasEstimadasGU06"
        Me.Tex_HorasEstimadasGU06.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU06.TabIndex = 580
        Me.Tex_HorasEstimadasGU06.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU06
        '
        Me.Tex_HorasProcesoGU06.AutoSize = True
        Me.Tex_HorasProcesoGU06.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU06.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU06.Location = New System.Drawing.Point(449, 54)
        Me.Tex_HorasProcesoGU06.Name = "Tex_HorasProcesoGU06"
        Me.Tex_HorasProcesoGU06.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU06.TabIndex = 579
        Me.Tex_HorasProcesoGU06.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola6
        '
        Me.TexGuardiola6.AutoSize = True
        Me.TexGuardiola6.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola6.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola6.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola6.Location = New System.Drawing.Point(678, 55)
        Me.TexGuardiola6.Name = "TexGuardiola6"
        Me.TexGuardiola6.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola6.TabIndex = 578
        Me.TexGuardiola6.Text = "Guardiola 06"
        '
        'TexTempGU06
        '
        Me.TexTempGU06.AutoSize = True
        Me.TexTempGU06.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU06.Location = New System.Drawing.Point(602, 316)
        Me.TexTempGU06.Name = "TexTempGU06"
        Me.TexTempGU06.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU06.TabIndex = 577
        Me.TexTempGU06.Text = "Temperatura °C"
        Me.TexTempGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU06
        '
        Me.TexPID_GU06.AutoSize = True
        Me.TexPID_GU06.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU06.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU06.Location = New System.Drawing.Point(204, 74)
        Me.TexPID_GU06.Name = "TexPID_GU06"
        Me.TexPID_GU06.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU06.TabIndex = 576
        Me.TexPID_GU06.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU06
        '
        Me.TexBN_SalidaGU06.AutoSize = True
        Me.TexBN_SalidaGU06.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU06.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU06.Location = New System.Drawing.Point(350, 135)
        Me.TexBN_SalidaGU06.Name = "TexBN_SalidaGU06"
        Me.TexBN_SalidaGU06.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU06.TabIndex = 575
        Me.TexBN_SalidaGU06.Text = "Salida"
        Me.TexBN_SalidaGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU06
        '
        Me.TexBN_RealTempGU06.AutoSize = True
        Me.TexBN_RealTempGU06.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU06.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU06.Location = New System.Drawing.Point(287, 136)
        Me.TexBN_RealTempGU06.Name = "TexBN_RealTempGU06"
        Me.TexBN_RealTempGU06.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU06.TabIndex = 574
        Me.TexBN_RealTempGU06.Text = "Real"
        Me.TexBN_RealTempGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU06
        '
        Me.TexBN_SP_TempGU06.AutoSize = True
        Me.TexBN_SP_TempGU06.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU06.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU06.Location = New System.Drawing.Point(201, 136)
        Me.TexBN_SP_TempGU06.Name = "TexBN_SP_TempGU06"
        Me.TexBN_SP_TempGU06.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU06.TabIndex = 573
        Me.TexBN_SP_TempGU06.Text = "SetPoint"
        Me.TexBN_SP_TempGU06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU06
        '
        Me.IGU06.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IGU06.Location = New System.Drawing.Point(441, 309)
        Me.IGU06.Name = "IGU06"
        Me.IGU06.Size = New System.Drawing.Size(541, 274)
        Me.IGU06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU06.TabIndex = 600
        Me.IGU06.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola06
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(191, 51)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 602
        '
        'Guardiola_06
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU06)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU06)
        Me.Controls.Add(Me.BCF_MenúP_GU06)
        Me.Controls.Add(Me.BP_FinCicloGU06)
        Me.Controls.Add(Me.BP_INICIO_CICLO_SGU06)
        Me.Controls.Add(Me.BCF_RegresarGU06)
        Me.Controls.Add(Me.BP_DescargaGU06)
        Me.Controls.Add(Me.BP_CofirDescagaGU06)
        Me.Controls.Add(Me.BN_SalidaGU06)
        Me.Controls.Add(Me.BN_SP_TempGU06)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU06)
        Me.Controls.Add(Me.MD_CosechaGU06)
        Me.Controls.Add(Me.MD_HorasEstimadasGU06)
        Me.Controls.Add(Me.MD_CicloGU06)
        Me.Controls.Add(Me.TexCicloGU06)
        Me.Controls.Add(Me.MD_TempGU06)
        Me.Controls.Add(Me.MD_HorasProcesoGU06)
        Me.Controls.Add(Me.Tex_CicloGU06)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU06)
        Me.Controls.Add(Me.Tex_CosechaGU06)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU06)
        Me.Controls.Add(Me.Tex_HorasProcesoGU06)
        Me.Controls.Add(Me.TexGuardiola6)
        Me.Controls.Add(Me.TexTempGU06)
        Me.Controls.Add(Me.TexPID_GU06)
        Me.Controls.Add(Me.TexBN_SalidaGU06)
        Me.Controls.Add(Me.TexBN_RealTempGU06)
        Me.Controls.Add(Me.TexBN_SP_TempGU06)
        Me.Controls.Add(Me.IGU06)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_06"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU06, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU06 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola06 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU06 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU06 As FormChangeButton
    Friend WithEvents BP_FinCicloGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_INICIO_CICLO_SGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU06 As FormChangeButton
    Friend WithEvents BP_DescargaGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU06 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU06 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU06 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU06 As Label
    Friend WithEvents Tex_OrdenTrabajoGU06 As Label
    Friend WithEvents Tex_CosechaGU06 As Label
    Friend WithEvents Tex_HorasEstimadasGU06 As Label
    Friend WithEvents Tex_HorasProcesoGU06 As Label
    Friend WithEvents TexGuardiola6 As Label
    Friend WithEvents TexTempGU06 As Label
    Friend WithEvents TexPID_GU06 As Label
    Friend WithEvents TexBN_SalidaGU06 As Label
    Friend WithEvents TexBN_RealTempGU06 As Label
    Friend WithEvents TexBN_SP_TempGU06 As Label
    Friend WithEvents IGU06 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
