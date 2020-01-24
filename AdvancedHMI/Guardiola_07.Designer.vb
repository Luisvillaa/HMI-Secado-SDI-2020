<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_07
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_07))
        Me.CT_SGU07 = New AdvancedHMIControls.TempController()
        Me.Guardiola07 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU07 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU07 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU07 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU07 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU07 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU07 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU07 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU07 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU07 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU07 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU07 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU07 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU07 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU07 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU07 = New System.Windows.Forms.Label()
        Me.TexGuardiola7 = New System.Windows.Forms.Label()
        Me.TexTempGU07 = New System.Windows.Forms.Label()
        Me.TexPID_GU07 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU07 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU07 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU07 = New System.Windows.Forms.Label()
        Me.IGU07 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU07, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU07
        '
        Me.CT_SGU07.Button1Text = Nothing
        Me.CT_SGU07.Button2Text = Nothing
        Me.CT_SGU07.ComComponent = Me.Guardiola07
        Me.CT_SGU07.DecimalPosition = 1
        Me.CT_SGU07.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU07.Location = New System.Drawing.Point(204, 432)
        Me.CT_SGU07.Name = "CT_SGU07"
        Me.CT_SGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU07.PLCAddressClick1 = ""
        Me.CT_SGU07.PLCAddressClick2 = ""
        Me.CT_SGU07.PLCAddressClick3 = ""
        Me.CT_SGU07.PLCAddressClick4 = ""
        Me.CT_SGU07.PLCAddressText = ""
        Me.CT_SGU07.PLCAddressValuePV = "PID_SGU07.PV"
        Me.CT_SGU07.PLCAddressValueSP = "PID_SGU07.SP"
        Me.CT_SGU07.PLCAddressVisible = ""
        Me.CT_SGU07.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU07.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU07.TabIndex = 639
        Me.CT_SGU07.Text = "S-GU-07"
        Me.CT_SGU07.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU07.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU07.Value2Text = "SP"
        Me.CT_SGU07.ValuePV = 0!
        Me.CT_SGU07.ValueSP = 0!
        '
        'Guardiola07
        '
        Me.Guardiola07.CIPConnectionSize = 508
        Me.Guardiola07.DisableMultiServiceRequest = False
        Me.Guardiola07.DisableSubscriptions = False
        Me.Guardiola07.IniFileName = ""
        Me.Guardiola07.IniFileSection = Nothing
        Me.Guardiola07.IPAddress = "10.1.108.18"
        Me.Guardiola07.PollRateOverride = 500
        Me.Guardiola07.Port = 44818
        Me.Guardiola07.ProcessorSlot = 0
        Me.Guardiola07.RoutePath = Nothing
        Me.Guardiola07.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola07
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
        Me.BasicButton1.ComComponent = Me.Guardiola07
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(960, 590)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU07"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 637
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU07
        '
        Me.LS_MarchaGU07.Blink = False
        Me.LS_MarchaGU07.ComComponent = Me.Guardiola07
        Me.LS_MarchaGU07.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU07.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU07.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU07.Location = New System.Drawing.Point(854, 317)
        Me.LS_MarchaGU07.Name = "LS_MarchaGU07"
        Me.LS_MarchaGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU07.PLCAddressClick = ""
        Me.LS_MarchaGU07.PLCAddressText = ""
        Me.LS_MarchaGU07.PLCAddressValue = "MARCHA_GU07"
        Me.LS_MarchaGU07.PLCAddressVisible = ""
        Me.LS_MarchaGU07.Size = New System.Drawing.Size(53, 56)
        Me.LS_MarchaGU07.TabIndex = 634
        Me.LS_MarchaGU07.Value = False
        Me.LS_MarchaGU07.ValueToWrite = 0
        '
        'BCF_MenúP_GU07
        '
        Me.BCF_MenúP_GU07.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU07.ComComponent = Nothing
        Me.BCF_MenúP_GU07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU07.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU07.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU07.KeypadWidth = 300
        Me.BCF_MenúP_GU07.Location = New System.Drawing.Point(229, 646)
        Me.BCF_MenúP_GU07.Name = "BCF_MenúP_GU07"
        Me.BCF_MenúP_GU07.Passcode = Nothing
        Me.BCF_MenúP_GU07.PasswordChar = False
        Me.BCF_MenúP_GU07.PLCAddressVisible = ""
        Me.BCF_MenúP_GU07.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU07.TabIndex = 633
        Me.BCF_MenúP_GU07.Text = "Menú Principal"
        Me.BCF_MenúP_GU07.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU07
        '
        Me.BP_FinCicloGU07.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU07.ComComponent = Me.Guardiola07
        Me.BP_FinCicloGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU07.Highlight = False
        Me.BP_FinCicloGU07.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU07.Location = New System.Drawing.Point(710, 224)
        Me.BP_FinCicloGU07.MaximumHoldTime = 3000
        Me.BP_FinCicloGU07.MinimumHoldTime = 500
        Me.BP_FinCicloGU07.Name = "BP_FinCicloGU07"
        Me.BP_FinCicloGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU07.PLCAddressClick = "BP_DETENER_CICLO_SGU07"
        Me.BP_FinCicloGU07.SelectTextAlternate = False
        Me.BP_FinCicloGU07.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU07.TabIndex = 632
        Me.BP_FinCicloGU07.Text = "Detener Ciclo"
        Me.BP_FinCicloGU07.TextAlternate = Nothing
        Me.BP_FinCicloGU07.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU07.ValueToWrite = 0
        '
        'BP_IniCicloGU07
        '
        Me.BP_IniCicloGU07.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU07.ComComponent = Me.Guardiola07
        Me.BP_IniCicloGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU07.Highlight = False
        Me.BP_IniCicloGU07.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU07.Location = New System.Drawing.Point(508, 224)
        Me.BP_IniCicloGU07.MaximumHoldTime = 3000
        Me.BP_IniCicloGU07.MinimumHoldTime = 500
        Me.BP_IniCicloGU07.Name = "BP_IniCicloGU07"
        Me.BP_IniCicloGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU07.PLCAddressClick = "BP_INICIO_CICLO_SGU07"
        Me.BP_IniCicloGU07.SelectTextAlternate = False
        Me.BP_IniCicloGU07.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU07.TabIndex = 631
        Me.BP_IniCicloGU07.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU07.TextAlternate = Nothing
        Me.BP_IniCicloGU07.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU07.ValueToWrite = 0
        '
        'BCF_RegresarGU07
        '
        Me.BCF_RegresarGU07.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU07.ComComponent = Nothing
        Me.BCF_RegresarGU07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU07.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU07.FormToOpen = Nothing
        Me.BCF_RegresarGU07.KeypadWidth = 300
        Me.BCF_RegresarGU07.Location = New System.Drawing.Point(645, 100)
        Me.BCF_RegresarGU07.Name = "BCF_RegresarGU07"
        Me.BCF_RegresarGU07.Passcode = Nothing
        Me.BCF_RegresarGU07.PasswordChar = False
        Me.BCF_RegresarGU07.PLCAddressVisible = ""
        Me.BCF_RegresarGU07.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU07.TabIndex = 630
        Me.BCF_RegresarGU07.Text = "Regresar"
        Me.BCF_RegresarGU07.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU07
        '
        Me.BP_DescargaGU07.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU07.ComComponent = Me.Guardiola07
        Me.BP_DescargaGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU07.Highlight = False
        Me.BP_DescargaGU07.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU07.Location = New System.Drawing.Point(960, 123)
        Me.BP_DescargaGU07.MaximumHoldTime = 3000
        Me.BP_DescargaGU07.MinimumHoldTime = 500
        Me.BP_DescargaGU07.Name = "BP_DescargaGU07"
        Me.BP_DescargaGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU07.PLCAddressClick = "BP_FINALIZAR_SGU07"
        Me.BP_DescargaGU07.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU07"
        Me.BP_DescargaGU07.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU07"
        Me.BP_DescargaGU07.SelectTextAlternate = False
        Me.BP_DescargaGU07.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU07.TabIndex = 629
        Me.BP_DescargaGU07.Text = "Finalizar"
        Me.BP_DescargaGU07.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU07.UseVisualStyleBackColor = True
        Me.BP_DescargaGU07.ValueToWrite = 0
        '
        'BP_CofirDescagaGU07
        '
        Me.BP_CofirDescagaGU07.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU07.ComComponent = Me.Guardiola07
        Me.BP_CofirDescagaGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU07.Highlight = False
        Me.BP_CofirDescagaGU07.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU07.Location = New System.Drawing.Point(960, 64)
        Me.BP_CofirDescagaGU07.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU07.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU07.Name = "BP_CofirDescagaGU07"
        Me.BP_CofirDescagaGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU07.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU07"
        Me.BP_CofirDescagaGU07.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU07"
        Me.BP_CofirDescagaGU07.SelectTextAlternate = False
        Me.BP_CofirDescagaGU07.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU07.TabIndex = 628
        Me.BP_CofirDescagaGU07.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU07.TextAlternate = Nothing
        Me.BP_CofirDescagaGU07.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU07.ValueToWrite = 0
        '
        'BN_SalidaGU07
        '
        Me.BN_SalidaGU07.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU07.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU07.ComComponent = Me.Guardiola07
        Me.BN_SalidaGU07.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU07.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU07.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU07.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU07.Location = New System.Drawing.Point(357, 156)
        Me.BN_SalidaGU07.Maximum = 100.0R
        Me.BN_SalidaGU07.Minimum = 0R
        Me.BN_SalidaGU07.Name = "BN_SalidaGU07"
        Me.BN_SalidaGU07.NumericFormat = Nothing
        Me.BN_SalidaGU07.PLCAddressValue = "PID_SGU07.OUT"
        Me.BN_SalidaGU07.ShowValue = True
        Me.BN_SalidaGU07.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU07.TabIndex = 627
        Me.BN_SalidaGU07.Text = "BarLevel3"
        Me.BN_SalidaGU07.TextSuffix = Nothing
        Me.BN_SalidaGU07.Value = 0R
        Me.BN_SalidaGU07.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU07
        '
        Me.BN_SP_TempGU07.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU07.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU07.ComComponent = Me.Guardiola07
        Me.BN_SP_TempGU07.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU07.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU07.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU07.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU07.Location = New System.Drawing.Point(215, 157)
        Me.BN_SP_TempGU07.Maximum = 100.0R
        Me.BN_SP_TempGU07.Minimum = 0R
        Me.BN_SP_TempGU07.Name = "BN_SP_TempGU07"
        Me.BN_SP_TempGU07.NumericFormat = Nothing
        Me.BN_SP_TempGU07.PLCAddressValue = "PID_SGU07.SP"
        Me.BN_SP_TempGU07.ShowValue = True
        Me.BN_SP_TempGU07.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU07.TabIndex = 626
        Me.BN_SP_TempGU07.Text = "BarLevel1"
        Me.BN_SP_TempGU07.TextSuffix = Nothing
        Me.BN_SP_TempGU07.Value = 0R
        Me.BN_SP_TempGU07.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU07
        '
        Me.MD_OrdenTrabajoGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU07.ComComponent = Me.Guardiola07
        Me.MD_OrdenTrabajoGU07.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU07.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU07.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU07.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU07.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU07.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU07.Location = New System.Drawing.Point(988, 507)
        Me.MD_OrdenTrabajoGU07.Name = "MD_OrdenTrabajoGU07"
        Me.MD_OrdenTrabajoGU07.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU07.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU07"
        Me.MD_OrdenTrabajoGU07.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU07"
        Me.MD_OrdenTrabajoGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU07.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU07.TabIndex = 625
        Me.MD_OrdenTrabajoGU07.Value = 0R
        Me.MD_OrdenTrabajoGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU07
        '
        Me.MD_CosechaGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU07.ComComponent = Me.Guardiola07
        Me.MD_CosechaGU07.DecimalPosition = 0
        Me.MD_CosechaGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU07.KeypadMaxValue = 0R
        Me.MD_CosechaGU07.KeypadMinValue = 0R
        Me.MD_CosechaGU07.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU07.KeypadText = Nothing
        Me.MD_CosechaGU07.KeypadWidth = 300
        Me.MD_CosechaGU07.Location = New System.Drawing.Point(988, 410)
        Me.MD_CosechaGU07.Name = "MD_CosechaGU07"
        Me.MD_CosechaGU07.NumberOfDigits = 5
        Me.MD_CosechaGU07.PLCAddressKeypad = ""
        Me.MD_CosechaGU07.PLCAddressValue = "COSECHA_SGU07"
        Me.MD_CosechaGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU07.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU07.TabIndex = 624
        Me.MD_CosechaGU07.Value = 0R
        Me.MD_CosechaGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU07
        '
        Me.MD_HorasEstimadasGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU07.ComComponent = Me.Guardiola07
        Me.MD_HorasEstimadasGU07.DecimalPosition = 0
        Me.MD_HorasEstimadasGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU07.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU07.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU07.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU07.KeypadText = Nothing
        Me.MD_HorasEstimadasGU07.KeypadWidth = 300
        Me.MD_HorasEstimadasGU07.Location = New System.Drawing.Point(988, 317)
        Me.MD_HorasEstimadasGU07.Name = "MD_HorasEstimadasGU07"
        Me.MD_HorasEstimadasGU07.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU07.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU07"
        Me.MD_HorasEstimadasGU07.PLCAddressValue = "TIEMPO_ESTIMADO_SGU07"
        Me.MD_HorasEstimadasGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU07.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU07.TabIndex = 623
        Me.MD_HorasEstimadasGU07.Value = 0R
        Me.MD_HorasEstimadasGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU07
        '
        Me.MD_CicloGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU07.ComComponent = Me.Guardiola07
        Me.MD_CicloGU07.DecimalPosition = 0
        Me.MD_CicloGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU07.KeypadMaxValue = 0R
        Me.MD_CicloGU07.KeypadMinValue = 0R
        Me.MD_CicloGU07.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU07.KeypadText = Nothing
        Me.MD_CicloGU07.KeypadWidth = 300
        Me.MD_CicloGU07.Location = New System.Drawing.Point(988, 225)
        Me.MD_CicloGU07.Name = "MD_CicloGU07"
        Me.MD_CicloGU07.NumberOfDigits = 5
        Me.MD_CicloGU07.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU07"
        Me.MD_CicloGU07.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU07"
        Me.MD_CicloGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU07.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU07.TabIndex = 622
        Me.MD_CicloGU07.Value = 0R
        Me.MD_CicloGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU07
        '
        Me.TexCicloGU07.AutoSize = True
        Me.TexCicloGU07.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU07.ComComponent = Me.Guardiola07
        Me.TexCicloGU07.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU07.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU07.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU07.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU07.HighlightKeyCharacter = "!"
        Me.TexCicloGU07.HighlightKeyCharacter2 = "."
        Me.TexCicloGU07.IniFileName = Nothing
        Me.TexCicloGU07.Location = New System.Drawing.Point(577, 521)
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Messages.Add(CType(resources.GetObject("TexCicloGU07.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU07.Name = "TexCicloGU07"
        Me.TexCicloGU07.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU07"
        Me.TexCicloGU07.PLCAddressVisible = ""
        Me.TexCicloGU07.ShowMessageNumber = False
        Me.TexCicloGU07.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU07.SpeakMessage = False
        Me.TexCicloGU07.TabIndex = 635
        Me.TexCicloGU07.Text = "No Seleccionado"
        Me.TexCicloGU07.TextPrefix = Nothing
        Me.TexCicloGU07.Value = 0
        '
        'MD_TempGU07
        '
        Me.MD_TempGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU07.ComComponent = Me.Guardiola07
        Me.MD_TempGU07.DecimalPosition = 1
        Me.MD_TempGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU07.KeypadMaxValue = 0R
        Me.MD_TempGU07.KeypadMinValue = 0R
        Me.MD_TempGU07.KeypadScaleFactor = 1.0R
        Me.MD_TempGU07.KeypadText = Nothing
        Me.MD_TempGU07.KeypadWidth = 300
        Me.MD_TempGU07.Location = New System.Drawing.Point(604, 339)
        Me.MD_TempGU07.Name = "MD_TempGU07"
        Me.MD_TempGU07.NumberOfDigits = 5
        Me.MD_TempGU07.PLCAddressKeypad = ""
        Me.MD_TempGU07.PLCAddressValue = "PID_SGU07.PV"
        Me.MD_TempGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU07.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU07.TabIndex = 621
        Me.MD_TempGU07.Value = 0R
        Me.MD_TempGU07.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU07
        '
        Me.MD_HorasProcesoGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU07.ComComponent = Me.Guardiola07
        Me.MD_HorasProcesoGU07.DecimalPosition = 0
        Me.MD_HorasProcesoGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU07.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU07.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU07.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU07.KeypadText = Nothing
        Me.MD_HorasProcesoGU07.KeypadWidth = 300
        Me.MD_HorasProcesoGU07.Location = New System.Drawing.Point(465, 83)
        Me.MD_HorasProcesoGU07.Name = "MD_HorasProcesoGU07"
        Me.MD_HorasProcesoGU07.NumberOfDigits = 5
        Me.MD_HorasProcesoGU07.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU07.PLCAddressValue = "TIEMPO_SECADO_SGU07"
        Me.MD_HorasProcesoGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU07.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU07.TabIndex = 620
        Me.MD_HorasProcesoGU07.Value = 0R
        Me.MD_HorasProcesoGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU07
        '
        Me.Tex_CicloGU07.AutoSize = True
        Me.Tex_CicloGU07.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU07.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU07.Location = New System.Drawing.Point(975, 203)
        Me.Tex_CicloGU07.Name = "Tex_CicloGU07"
        Me.Tex_CicloGU07.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU07.TabIndex = 619
        Me.Tex_CicloGU07.Text = "Numero de Ciclo"
        Me.Tex_CicloGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU07
        '
        Me.Tex_OrdenTrabajoGU07.AutoSize = True
        Me.Tex_OrdenTrabajoGU07.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU07.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU07.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU07.Location = New System.Drawing.Point(1028, 482)
        Me.Tex_OrdenTrabajoGU07.Name = "Tex_OrdenTrabajoGU07"
        Me.Tex_OrdenTrabajoGU07.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU07.TabIndex = 618
        Me.Tex_OrdenTrabajoGU07.Text = "OT"
        Me.Tex_OrdenTrabajoGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU07
        '
        Me.Tex_CosechaGU07.AutoSize = True
        Me.Tex_CosechaGU07.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU07.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU07.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU07.Location = New System.Drawing.Point(996, 385)
        Me.Tex_CosechaGU07.Name = "Tex_CosechaGU07"
        Me.Tex_CosechaGU07.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU07.TabIndex = 617
        Me.Tex_CosechaGU07.Text = "Cosecha"
        Me.Tex_CosechaGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU07
        '
        Me.Tex_HorasEstimadasGU07.AutoSize = True
        Me.Tex_HorasEstimadasGU07.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU07.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU07.Location = New System.Drawing.Point(928, 295)
        Me.Tex_HorasEstimadasGU07.Name = "Tex_HorasEstimadasGU07"
        Me.Tex_HorasEstimadasGU07.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU07.TabIndex = 616
        Me.Tex_HorasEstimadasGU07.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU07
        '
        Me.Tex_HorasProcesoGU07.AutoSize = True
        Me.Tex_HorasProcesoGU07.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU07.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU07.Location = New System.Drawing.Point(449, 54)
        Me.Tex_HorasProcesoGU07.Name = "Tex_HorasProcesoGU07"
        Me.Tex_HorasProcesoGU07.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU07.TabIndex = 615
        Me.Tex_HorasProcesoGU07.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola7
        '
        Me.TexGuardiola7.AutoSize = True
        Me.TexGuardiola7.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola7.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola7.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola7.Location = New System.Drawing.Point(678, 55)
        Me.TexGuardiola7.Name = "TexGuardiola7"
        Me.TexGuardiola7.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola7.TabIndex = 614
        Me.TexGuardiola7.Text = "Guardiola 07"
        '
        'TexTempGU07
        '
        Me.TexTempGU07.AutoSize = True
        Me.TexTempGU07.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU07.Location = New System.Drawing.Point(601, 318)
        Me.TexTempGU07.Name = "TexTempGU07"
        Me.TexTempGU07.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU07.TabIndex = 613
        Me.TexTempGU07.Text = "Temperatura °C"
        Me.TexTempGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU07
        '
        Me.TexPID_GU07.AutoSize = True
        Me.TexPID_GU07.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU07.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU07.Location = New System.Drawing.Point(205, 74)
        Me.TexPID_GU07.Name = "TexPID_GU07"
        Me.TexPID_GU07.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU07.TabIndex = 612
        Me.TexPID_GU07.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU07
        '
        Me.TexBN_SalidaGU07.AutoSize = True
        Me.TexBN_SalidaGU07.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU07.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU07.Location = New System.Drawing.Point(350, 135)
        Me.TexBN_SalidaGU07.Name = "TexBN_SalidaGU07"
        Me.TexBN_SalidaGU07.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU07.TabIndex = 611
        Me.TexBN_SalidaGU07.Text = "Salida"
        Me.TexBN_SalidaGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU07
        '
        Me.TexBN_RealTempGU07.AutoSize = True
        Me.TexBN_RealTempGU07.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU07.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU07.Location = New System.Drawing.Point(287, 136)
        Me.TexBN_RealTempGU07.Name = "TexBN_RealTempGU07"
        Me.TexBN_RealTempGU07.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU07.TabIndex = 610
        Me.TexBN_RealTempGU07.Text = "Real"
        Me.TexBN_RealTempGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU07
        '
        Me.TexBN_SP_TempGU07.AutoSize = True
        Me.TexBN_SP_TempGU07.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU07.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU07.Location = New System.Drawing.Point(201, 136)
        Me.TexBN_SP_TempGU07.Name = "TexBN_SP_TempGU07"
        Me.TexBN_SP_TempGU07.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU07.TabIndex = 609
        Me.TexBN_SP_TempGU07.Text = "SetPoint"
        Me.TexBN_SP_TempGU07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU07
        '
        Me.IGU07.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU07.Location = New System.Drawing.Point(440, 310)
        Me.IGU07.Name = "IGU07"
        Me.IGU07.Size = New System.Drawing.Size(541, 274)
        Me.IGU07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU07.TabIndex = 636
        Me.IGU07.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola07
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 52)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 638
        '
        'Guardiola_07
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU07)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU07)
        Me.Controls.Add(Me.BCF_MenúP_GU07)
        Me.Controls.Add(Me.BP_FinCicloGU07)
        Me.Controls.Add(Me.BP_IniCicloGU07)
        Me.Controls.Add(Me.BCF_RegresarGU07)
        Me.Controls.Add(Me.BP_DescargaGU07)
        Me.Controls.Add(Me.BP_CofirDescagaGU07)
        Me.Controls.Add(Me.BN_SalidaGU07)
        Me.Controls.Add(Me.BN_SP_TempGU07)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU07)
        Me.Controls.Add(Me.MD_CosechaGU07)
        Me.Controls.Add(Me.MD_HorasEstimadasGU07)
        Me.Controls.Add(Me.MD_CicloGU07)
        Me.Controls.Add(Me.TexCicloGU07)
        Me.Controls.Add(Me.MD_TempGU07)
        Me.Controls.Add(Me.MD_HorasProcesoGU07)
        Me.Controls.Add(Me.Tex_CicloGU07)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU07)
        Me.Controls.Add(Me.Tex_CosechaGU07)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU07)
        Me.Controls.Add(Me.Tex_HorasProcesoGU07)
        Me.Controls.Add(Me.TexGuardiola7)
        Me.Controls.Add(Me.TexTempGU07)
        Me.Controls.Add(Me.TexPID_GU07)
        Me.Controls.Add(Me.TexBN_SalidaGU07)
        Me.Controls.Add(Me.TexBN_RealTempGU07)
        Me.Controls.Add(Me.TexBN_SP_TempGU07)
        Me.Controls.Add(Me.IGU07)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_07"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU07, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU07 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola07 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU07 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU07 As FormChangeButton
    Friend WithEvents BP_FinCicloGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU07 As FormChangeButton
    Friend WithEvents BP_DescargaGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU07 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU07 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU07 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU07 As Label
    Friend WithEvents Tex_OrdenTrabajoGU07 As Label
    Friend WithEvents Tex_CosechaGU07 As Label
    Friend WithEvents Tex_HorasEstimadasGU07 As Label
    Friend WithEvents Tex_HorasProcesoGU07 As Label
    Friend WithEvents TexGuardiola7 As Label
    Friend WithEvents TexTempGU07 As Label
    Friend WithEvents TexPID_GU07 As Label
    Friend WithEvents TexBN_SalidaGU07 As Label
    Friend WithEvents TexBN_RealTempGU07 As Label
    Friend WithEvents TexBN_SP_TempGU07 As Label
    Friend WithEvents IGU07 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
