<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_15))
        Me.CT_SGU15 = New AdvancedHMIControls.TempController()
        Me.Guardiola15 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU15 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU15 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU15 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU15 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU15 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU15 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU15 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU15 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU15 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU15 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU15 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU15 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU15 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU15 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU15 = New System.Windows.Forms.Label()
        Me.TexGuardiola15 = New System.Windows.Forms.Label()
        Me.TexTempGU15 = New System.Windows.Forms.Label()
        Me.TexPID_GU15 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU15 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU15 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU15 = New System.Windows.Forms.Label()
        Me.IGU15 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU15
        '
        Me.CT_SGU15.Button1Text = Nothing
        Me.CT_SGU15.Button2Text = Nothing
        Me.CT_SGU15.ComComponent = Me.Guardiola15
        Me.CT_SGU15.DecimalPosition = 1
        Me.CT_SGU15.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU15.Location = New System.Drawing.Point(204, 432)
        Me.CT_SGU15.Name = "CT_SGU15"
        Me.CT_SGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU15.PLCAddressClick1 = ""
        Me.CT_SGU15.PLCAddressClick2 = ""
        Me.CT_SGU15.PLCAddressClick3 = ""
        Me.CT_SGU15.PLCAddressClick4 = ""
        Me.CT_SGU15.PLCAddressText = ""
        Me.CT_SGU15.PLCAddressValuePV = "PID_GUARDIOLA8.PV"
        Me.CT_SGU15.PLCAddressValueSP = "PID_GUARDIOLA8.SP"
        Me.CT_SGU15.PLCAddressVisible = ""
        Me.CT_SGU15.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU15.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU15.TabIndex = 711
        Me.CT_SGU15.Text = "S-GU-15"
        Me.CT_SGU15.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU15.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU15.Value2Text = "SP"
        Me.CT_SGU15.ValuePV = 0!
        Me.CT_SGU15.ValueSP = 0!
        '
        'Guardiola15
        '
        Me.Guardiola15.CIPConnectionSize = 508
        Me.Guardiola15.DisableMultiServiceRequest = False
        Me.Guardiola15.DisableSubscriptions = False
        Me.Guardiola15.IniFileName = ""
        Me.Guardiola15.IniFileSection = Nothing
        Me.Guardiola15.IPAddress = "10.1.108.20"
        Me.Guardiola15.PollRateOverride = 500
        Me.Guardiola15.Port = 44818
        Me.Guardiola15.ProcessorSlot = 0
        Me.Guardiola15.RoutePath = Nothing
        Me.Guardiola15.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola15
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
        Me.BasicButton1.ComComponent = Me.Guardiola15
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
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA08"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 709
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU15
        '
        Me.LS_MarchaGU15.Blink = False
        Me.LS_MarchaGU15.ComComponent = Me.Guardiola15
        Me.LS_MarchaGU15.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU15.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU15.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU15.Location = New System.Drawing.Point(853, 317)
        Me.LS_MarchaGU15.Name = "LS_MarchaGU15"
        Me.LS_MarchaGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU15.PLCAddressClick = ""
        Me.LS_MarchaGU15.PLCAddressText = ""
        Me.LS_MarchaGU15.PLCAddressValue = "MARCHA_GU15"
        Me.LS_MarchaGU15.PLCAddressVisible = ""
        Me.LS_MarchaGU15.Size = New System.Drawing.Size(54, 57)
        Me.LS_MarchaGU15.TabIndex = 706
        Me.LS_MarchaGU15.Value = False
        Me.LS_MarchaGU15.ValueToWrite = 0
        '
        'BCF_MenúP_GU15
        '
        Me.BCF_MenúP_GU15.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU15.ComComponent = Nothing
        Me.BCF_MenúP_GU15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU15.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU15.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU15.KeypadWidth = 300
        Me.BCF_MenúP_GU15.Location = New System.Drawing.Point(229, 646)
        Me.BCF_MenúP_GU15.Name = "BCF_MenúP_GU15"
        Me.BCF_MenúP_GU15.Passcode = Nothing
        Me.BCF_MenúP_GU15.PasswordChar = False
        Me.BCF_MenúP_GU15.PLCAddressVisible = ""
        Me.BCF_MenúP_GU15.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU15.TabIndex = 705
        Me.BCF_MenúP_GU15.Text = "Menú Principal"
        Me.BCF_MenúP_GU15.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU15
        '
        Me.BP_FinCicloGU15.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU15.ComComponent = Me.Guardiola15
        Me.BP_FinCicloGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU15.Highlight = False
        Me.BP_FinCicloGU15.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU15.Location = New System.Drawing.Point(710, 218)
        Me.BP_FinCicloGU15.MaximumHoldTime = 3000
        Me.BP_FinCicloGU15.MinimumHoldTime = 500
        Me.BP_FinCicloGU15.Name = "BP_FinCicloGU15"
        Me.BP_FinCicloGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU15.PLCAddressClick = "BP_FIN_CICLO_GA8"
        Me.BP_FinCicloGU15.SelectTextAlternate = False
        Me.BP_FinCicloGU15.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU15.TabIndex = 704
        Me.BP_FinCicloGU15.Text = "Detener Ciclo"
        Me.BP_FinCicloGU15.TextAlternate = Nothing
        Me.BP_FinCicloGU15.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU15.ValueToWrite = 0
        '
        'BP_IniCicloGU15
        '
        Me.BP_IniCicloGU15.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU15.ComComponent = Me.Guardiola15
        Me.BP_IniCicloGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU15.Highlight = False
        Me.BP_IniCicloGU15.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU15.Location = New System.Drawing.Point(508, 218)
        Me.BP_IniCicloGU15.MaximumHoldTime = 3000
        Me.BP_IniCicloGU15.MinimumHoldTime = 500
        Me.BP_IniCicloGU15.Name = "BP_IniCicloGU15"
        Me.BP_IniCicloGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU15.PLCAddressClick = "BP_ARRANQUE_G8"
        Me.BP_IniCicloGU15.SelectTextAlternate = False
        Me.BP_IniCicloGU15.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU15.TabIndex = 703
        Me.BP_IniCicloGU15.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU15.TextAlternate = Nothing
        Me.BP_IniCicloGU15.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU15.ValueToWrite = 0
        '
        'BCF_RegresarGU15
        '
        Me.BCF_RegresarGU15.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU15.ComComponent = Nothing
        Me.BCF_RegresarGU15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU15.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU15.FormToOpen = Nothing
        Me.BCF_RegresarGU15.KeypadWidth = 300
        Me.BCF_RegresarGU15.Location = New System.Drawing.Point(645, 100)
        Me.BCF_RegresarGU15.Name = "BCF_RegresarGU15"
        Me.BCF_RegresarGU15.Passcode = Nothing
        Me.BCF_RegresarGU15.PasswordChar = False
        Me.BCF_RegresarGU15.PLCAddressVisible = ""
        Me.BCF_RegresarGU15.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU15.TabIndex = 702
        Me.BCF_RegresarGU15.Text = "Regresar"
        Me.BCF_RegresarGU15.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU15
        '
        Me.BP_DescargaGU15.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU15.ComComponent = Me.Guardiola15
        Me.BP_DescargaGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU15.Highlight = False
        Me.BP_DescargaGU15.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU15.Location = New System.Drawing.Point(960, 123)
        Me.BP_DescargaGU15.MaximumHoldTime = 3000
        Me.BP_DescargaGU15.MinimumHoldTime = 500
        Me.BP_DescargaGU15.Name = "BP_DescargaGU15"
        Me.BP_DescargaGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU15.PLCAddressClick = "BP_DESCARGAR_GA8"
        Me.BP_DescargaGU15.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA8"
        Me.BP_DescargaGU15.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA8"
        Me.BP_DescargaGU15.SelectTextAlternate = False
        Me.BP_DescargaGU15.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU15.TabIndex = 701
        Me.BP_DescargaGU15.Text = "Finalizar"
        Me.BP_DescargaGU15.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU15.UseVisualStyleBackColor = True
        Me.BP_DescargaGU15.ValueToWrite = 0
        '
        'BP_CofirDescagaGU15
        '
        Me.BP_CofirDescagaGU15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU15.ComComponent = Me.Guardiola15
        Me.BP_CofirDescagaGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU15.Highlight = False
        Me.BP_CofirDescagaGU15.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU15.Location = New System.Drawing.Point(960, 64)
        Me.BP_CofirDescagaGU15.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU15.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU15.Name = "BP_CofirDescagaGU15"
        Me.BP_CofirDescagaGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU15.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA8"
        Me.BP_CofirDescagaGU15.PLCAddressVisible = "CONFIMAR_DESCARGA_GA8"
        Me.BP_CofirDescagaGU15.SelectTextAlternate = False
        Me.BP_CofirDescagaGU15.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU15.TabIndex = 700
        Me.BP_CofirDescagaGU15.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU15.TextAlternate = Nothing
        Me.BP_CofirDescagaGU15.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU15.ValueToWrite = 0
        '
        'BN_SalidaGU15
        '
        Me.BN_SalidaGU15.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU15.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU15.ComComponent = Me.Guardiola15
        Me.BN_SalidaGU15.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU15.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU15.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU15.Location = New System.Drawing.Point(357, 156)
        Me.BN_SalidaGU15.Maximum = 100.0R
        Me.BN_SalidaGU15.Minimum = 0R
        Me.BN_SalidaGU15.Name = "BN_SalidaGU15"
        Me.BN_SalidaGU15.NumericFormat = Nothing
        Me.BN_SalidaGU15.PLCAddressValue = "PID_GUARDIOLA8.OUT"
        Me.BN_SalidaGU15.ShowValue = True
        Me.BN_SalidaGU15.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU15.TabIndex = 699
        Me.BN_SalidaGU15.Text = "BarLevel3"
        Me.BN_SalidaGU15.TextSuffix = Nothing
        Me.BN_SalidaGU15.Value = 0R
        Me.BN_SalidaGU15.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU15
        '
        Me.BN_SP_TempGU15.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU15.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU15.ComComponent = Me.Guardiola15
        Me.BN_SP_TempGU15.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU15.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU15.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU15.Location = New System.Drawing.Point(215, 157)
        Me.BN_SP_TempGU15.Maximum = 100.0R
        Me.BN_SP_TempGU15.Minimum = 0R
        Me.BN_SP_TempGU15.Name = "BN_SP_TempGU15"
        Me.BN_SP_TempGU15.NumericFormat = Nothing
        Me.BN_SP_TempGU15.PLCAddressValue = "PID_GUARDIOLA8.SP"
        Me.BN_SP_TempGU15.ShowValue = True
        Me.BN_SP_TempGU15.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU15.TabIndex = 698
        Me.BN_SP_TempGU15.Text = "BarLevel1"
        Me.BN_SP_TempGU15.TextSuffix = Nothing
        Me.BN_SP_TempGU15.Value = 0R
        Me.BN_SP_TempGU15.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU15
        '
        Me.MD_OrdenTrabajoGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU15.ComComponent = Me.Guardiola15
        Me.MD_OrdenTrabajoGU15.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU15.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU15.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU15.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU15.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU15.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU15.Location = New System.Drawing.Point(988, 507)
        Me.MD_OrdenTrabajoGU15.Name = "MD_OrdenTrabajoGU15"
        Me.MD_OrdenTrabajoGU15.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU15.PLCAddressKeypad = "ORDEN_DE_CARGA_GA08"
        Me.MD_OrdenTrabajoGU15.PLCAddressValue = "ORDEN_DE_CARGA_GA08"
        Me.MD_OrdenTrabajoGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU15.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU15.TabIndex = 697
        Me.MD_OrdenTrabajoGU15.Value = 0R
        Me.MD_OrdenTrabajoGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU15
        '
        Me.MD_CosechaGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU15.ComComponent = Me.Guardiola15
        Me.MD_CosechaGU15.DecimalPosition = 0
        Me.MD_CosechaGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU15.KeypadMaxValue = 0R
        Me.MD_CosechaGU15.KeypadMinValue = 0R
        Me.MD_CosechaGU15.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU15.KeypadText = Nothing
        Me.MD_CosechaGU15.KeypadWidth = 300
        Me.MD_CosechaGU15.Location = New System.Drawing.Point(988, 410)
        Me.MD_CosechaGU15.Name = "MD_CosechaGU15"
        Me.MD_CosechaGU15.NumberOfDigits = 5
        Me.MD_CosechaGU15.PLCAddressKeypad = "GA08_LOTE_NUMERO"
        Me.MD_CosechaGU15.PLCAddressValue = "GA08_LOTE_NUMERO"
        Me.MD_CosechaGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU15.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU15.TabIndex = 696
        Me.MD_CosechaGU15.Value = 0R
        Me.MD_CosechaGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU15
        '
        Me.MD_HorasEstimadasGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU15.ComComponent = Me.Guardiola15
        Me.MD_HorasEstimadasGU15.DecimalPosition = 0
        Me.MD_HorasEstimadasGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU15.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU15.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU15.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU15.KeypadText = Nothing
        Me.MD_HorasEstimadasGU15.KeypadWidth = 300
        Me.MD_HorasEstimadasGU15.Location = New System.Drawing.Point(988, 317)
        Me.MD_HorasEstimadasGU15.Name = "MD_HorasEstimadasGU15"
        Me.MD_HorasEstimadasGU15.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU15.PLCAddressKeypad = "TIEMPO_SECADO_H_GA8"
        Me.MD_HorasEstimadasGU15.PLCAddressValue = "TIEMPO_SECADO_H_GA8"
        Me.MD_HorasEstimadasGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU15.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU15.TabIndex = 695
        Me.MD_HorasEstimadasGU15.Value = 0R
        Me.MD_HorasEstimadasGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU15
        '
        Me.MD_CicloGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU15.ComComponent = Me.Guardiola15
        Me.MD_CicloGU15.DecimalPosition = 0
        Me.MD_CicloGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU15.KeypadMaxValue = 0R
        Me.MD_CicloGU15.KeypadMinValue = 0R
        Me.MD_CicloGU15.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU15.KeypadText = Nothing
        Me.MD_CicloGU15.KeypadWidth = 300
        Me.MD_CicloGU15.Location = New System.Drawing.Point(988, 225)
        Me.MD_CicloGU15.Name = "MD_CicloGU15"
        Me.MD_CicloGU15.NumberOfDigits = 5
        Me.MD_CicloGU15.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA08"
        Me.MD_CicloGU15.PLCAddressValue = "NUMERO_CICLO_SECADO_GA08"
        Me.MD_CicloGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU15.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU15.TabIndex = 694
        Me.MD_CicloGU15.Value = 0R
        Me.MD_CicloGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU15
        '
        Me.TexCicloGU15.AutoSize = True
        Me.TexCicloGU15.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU15.ComComponent = Me.Guardiola15
        Me.TexCicloGU15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU15.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU15.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU15.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU15.HighlightKeyCharacter = "!"
        Me.TexCicloGU15.HighlightKeyCharacter2 = "."
        Me.TexCicloGU15.IniFileName = Nothing
        Me.TexCicloGU15.Location = New System.Drawing.Point(575, 521)
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Messages.Add(CType(resources.GetObject("TexCicloGU15.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU15.Name = "TexCicloGU15"
        Me.TexCicloGU15.PLCAddressValue = "NUMERO_CICLO_SECADO_GA07"
        Me.TexCicloGU15.PLCAddressVisible = ""
        Me.TexCicloGU15.ShowMessageNumber = False
        Me.TexCicloGU15.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU15.SpeakMessage = False
        Me.TexCicloGU15.TabIndex = 707
        Me.TexCicloGU15.Text = "No Seleccionado"
        Me.TexCicloGU15.TextPrefix = Nothing
        Me.TexCicloGU15.Value = 0
        '
        'MD_TempGU15
        '
        Me.MD_TempGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU15.ComComponent = Me.Guardiola15
        Me.MD_TempGU15.DecimalPosition = 1
        Me.MD_TempGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU15.KeypadMaxValue = 0R
        Me.MD_TempGU15.KeypadMinValue = 0R
        Me.MD_TempGU15.KeypadScaleFactor = 1.0R
        Me.MD_TempGU15.KeypadText = Nothing
        Me.MD_TempGU15.KeypadWidth = 300
        Me.MD_TempGU15.Location = New System.Drawing.Point(604, 337)
        Me.MD_TempGU15.Name = "MD_TempGU15"
        Me.MD_TempGU15.NumberOfDigits = 5
        Me.MD_TempGU15.PLCAddressKeypad = ""
        Me.MD_TempGU15.PLCAddressValue = "PID_GUARDIOLA8.PV"
        Me.MD_TempGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU15.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU15.TabIndex = 693
        Me.MD_TempGU15.Value = 0R
        Me.MD_TempGU15.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU15
        '
        Me.MD_HorasProcesoGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU15.ComComponent = Me.Guardiola15
        Me.MD_HorasProcesoGU15.DecimalPosition = 0
        Me.MD_HorasProcesoGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU15.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU15.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU15.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU15.KeypadText = Nothing
        Me.MD_HorasProcesoGU15.KeypadWidth = 300
        Me.MD_HorasProcesoGU15.Location = New System.Drawing.Point(465, 83)
        Me.MD_HorasProcesoGU15.Name = "MD_HorasProcesoGU15"
        Me.MD_HorasProcesoGU15.NumberOfDigits = 5
        Me.MD_HorasProcesoGU15.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU15.PLCAddressValue = "SECADO_G8_MONITOR"
        Me.MD_HorasProcesoGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU15.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU15.TabIndex = 692
        Me.MD_HorasProcesoGU15.Value = 0R
        Me.MD_HorasProcesoGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU15
        '
        Me.Tex_CicloGU15.AutoSize = True
        Me.Tex_CicloGU15.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU15.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU15.Location = New System.Drawing.Point(975, 203)
        Me.Tex_CicloGU15.Name = "Tex_CicloGU15"
        Me.Tex_CicloGU15.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU15.TabIndex = 691
        Me.Tex_CicloGU15.Text = "Numero de Ciclo"
        Me.Tex_CicloGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU15
        '
        Me.Tex_OrdenTrabajoGU15.AutoSize = True
        Me.Tex_OrdenTrabajoGU15.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU15.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU15.Location = New System.Drawing.Point(1028, 482)
        Me.Tex_OrdenTrabajoGU15.Name = "Tex_OrdenTrabajoGU15"
        Me.Tex_OrdenTrabajoGU15.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU15.TabIndex = 690
        Me.Tex_OrdenTrabajoGU15.Text = "OT"
        Me.Tex_OrdenTrabajoGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU15
        '
        Me.Tex_CosechaGU15.AutoSize = True
        Me.Tex_CosechaGU15.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU15.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU15.Location = New System.Drawing.Point(996, 385)
        Me.Tex_CosechaGU15.Name = "Tex_CosechaGU15"
        Me.Tex_CosechaGU15.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU15.TabIndex = 689
        Me.Tex_CosechaGU15.Text = "Cosecha"
        Me.Tex_CosechaGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU15
        '
        Me.Tex_HorasEstimadasGU15.AutoSize = True
        Me.Tex_HorasEstimadasGU15.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU15.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU15.Location = New System.Drawing.Point(928, 295)
        Me.Tex_HorasEstimadasGU15.Name = "Tex_HorasEstimadasGU15"
        Me.Tex_HorasEstimadasGU15.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU15.TabIndex = 688
        Me.Tex_HorasEstimadasGU15.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU15
        '
        Me.Tex_HorasProcesoGU15.AutoSize = True
        Me.Tex_HorasProcesoGU15.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU15.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU15.Location = New System.Drawing.Point(449, 54)
        Me.Tex_HorasProcesoGU15.Name = "Tex_HorasProcesoGU15"
        Me.Tex_HorasProcesoGU15.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU15.TabIndex = 687
        Me.Tex_HorasProcesoGU15.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola15
        '
        Me.TexGuardiola15.AutoSize = True
        Me.TexGuardiola15.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola15.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola15.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola15.Location = New System.Drawing.Point(678, 55)
        Me.TexGuardiola15.Name = "TexGuardiola15"
        Me.TexGuardiola15.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola15.TabIndex = 686
        Me.TexGuardiola15.Text = "Guardiola 15"
        '
        'TexTempGU15
        '
        Me.TexTempGU15.AutoSize = True
        Me.TexTempGU15.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU15.Location = New System.Drawing.Point(601, 316)
        Me.TexTempGU15.Name = "TexTempGU15"
        Me.TexTempGU15.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU15.TabIndex = 685
        Me.TexTempGU15.Text = "Temperatura °C"
        Me.TexTempGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU15
        '
        Me.TexPID_GU15.AutoSize = True
        Me.TexPID_GU15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU15.Location = New System.Drawing.Point(205, 74)
        Me.TexPID_GU15.Name = "TexPID_GU15"
        Me.TexPID_GU15.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU15.TabIndex = 684
        Me.TexPID_GU15.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU15
        '
        Me.TexBN_SalidaGU15.AutoSize = True
        Me.TexBN_SalidaGU15.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU15.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU15.Location = New System.Drawing.Point(350, 135)
        Me.TexBN_SalidaGU15.Name = "TexBN_SalidaGU15"
        Me.TexBN_SalidaGU15.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU15.TabIndex = 683
        Me.TexBN_SalidaGU15.Text = "Salida"
        Me.TexBN_SalidaGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU15
        '
        Me.TexBN_RealTempGU15.AutoSize = True
        Me.TexBN_RealTempGU15.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU15.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU15.Location = New System.Drawing.Point(285, 136)
        Me.TexBN_RealTempGU15.Name = "TexBN_RealTempGU15"
        Me.TexBN_RealTempGU15.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU15.TabIndex = 682
        Me.TexBN_RealTempGU15.Text = "Real"
        Me.TexBN_RealTempGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU15
        '
        Me.TexBN_SP_TempGU15.AutoSize = True
        Me.TexBN_SP_TempGU15.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU15.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU15.Location = New System.Drawing.Point(201, 136)
        Me.TexBN_SP_TempGU15.Name = "TexBN_SP_TempGU15"
        Me.TexBN_SP_TempGU15.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU15.TabIndex = 681
        Me.TexBN_SP_TempGU15.Text = "SetPoint"
        Me.TexBN_SP_TempGU15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU15
        '
        Me.IGU15.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU15.Location = New System.Drawing.Point(440, 309)
        Me.IGU15.Name = "IGU15"
        Me.IGU15.Size = New System.Drawing.Size(541, 274)
        Me.IGU15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU15.TabIndex = 708
        Me.IGU15.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola15
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 52)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 710
        '
        'Guardiola_15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU15)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU15)
        Me.Controls.Add(Me.BCF_MenúP_GU15)
        Me.Controls.Add(Me.BP_FinCicloGU15)
        Me.Controls.Add(Me.BP_IniCicloGU15)
        Me.Controls.Add(Me.BCF_RegresarGU15)
        Me.Controls.Add(Me.BP_DescargaGU15)
        Me.Controls.Add(Me.BP_CofirDescagaGU15)
        Me.Controls.Add(Me.BN_SalidaGU15)
        Me.Controls.Add(Me.BN_SP_TempGU15)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU15)
        Me.Controls.Add(Me.MD_CosechaGU15)
        Me.Controls.Add(Me.MD_HorasEstimadasGU15)
        Me.Controls.Add(Me.MD_CicloGU15)
        Me.Controls.Add(Me.TexCicloGU15)
        Me.Controls.Add(Me.MD_TempGU15)
        Me.Controls.Add(Me.MD_HorasProcesoGU15)
        Me.Controls.Add(Me.Tex_CicloGU15)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU15)
        Me.Controls.Add(Me.Tex_CosechaGU15)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU15)
        Me.Controls.Add(Me.Tex_HorasProcesoGU15)
        Me.Controls.Add(Me.TexGuardiola15)
        Me.Controls.Add(Me.TexTempGU15)
        Me.Controls.Add(Me.TexPID_GU15)
        Me.Controls.Add(Me.TexBN_SalidaGU15)
        Me.Controls.Add(Me.TexBN_RealTempGU15)
        Me.Controls.Add(Me.TexBN_SP_TempGU15)
        Me.Controls.Add(Me.IGU15)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU15 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola15 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU15 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU15 As FormChangeButton
    Friend WithEvents BP_FinCicloGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU15 As FormChangeButton
    Friend WithEvents BP_DescargaGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU15 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU15 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU15 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU15 As Label
    Friend WithEvents Tex_OrdenTrabajoGU15 As Label
    Friend WithEvents Tex_CosechaGU15 As Label
    Friend WithEvents Tex_HorasEstimadasGU15 As Label
    Friend WithEvents Tex_HorasProcesoGU15 As Label
    Friend WithEvents TexGuardiola15 As Label
    Friend WithEvents TexTempGU15 As Label
    Friend WithEvents TexPID_GU15 As Label
    Friend WithEvents TexBN_SalidaGU15 As Label
    Friend WithEvents TexBN_RealTempGU15 As Label
    Friend WithEvents TexBN_SP_TempGU15 As Label
    Friend WithEvents IGU15 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
