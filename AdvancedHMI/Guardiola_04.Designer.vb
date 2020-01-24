<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_04
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_04))
        Me.CT_SGU04 = New AdvancedHMIControls.TempController()
        Me.Guardiola04 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU04 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU04 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU04 = New AdvancedHMIControls.BasicButton()
        Me.BP_INICIO_CICLO_SGU04 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU04 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU04 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU04 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU04 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU04 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU04 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU04 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU04 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU04 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU04 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU04 = New System.Windows.Forms.Label()
        Me.TexGuardiola4 = New System.Windows.Forms.Label()
        Me.TexTempGU04 = New System.Windows.Forms.Label()
        Me.TexPID_GU04 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU04 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU04 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU04 = New System.Windows.Forms.Label()
        Me.IGU04 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU04, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU04
        '
        Me.CT_SGU04.Button1Text = Nothing
        Me.CT_SGU04.Button2Text = Nothing
        Me.CT_SGU04.ComComponent = Me.Guardiola04
        Me.CT_SGU04.DecimalPosition = 1
        Me.CT_SGU04.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU04.Location = New System.Drawing.Point(204, 434)
        Me.CT_SGU04.Name = "CT_SGU04"
        Me.CT_SGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU04.PLCAddressClick1 = ""
        Me.CT_SGU04.PLCAddressClick2 = ""
        Me.CT_SGU04.PLCAddressClick3 = ""
        Me.CT_SGU04.PLCAddressClick4 = ""
        Me.CT_SGU04.PLCAddressText = ""
        Me.CT_SGU04.PLCAddressValuePV = "PID_SGU04.PV"
        Me.CT_SGU04.PLCAddressValueSP = "PID_SGU04.SP"
        Me.CT_SGU04.PLCAddressVisible = ""
        Me.CT_SGU04.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU04.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU04.TabIndex = 531
        Me.CT_SGU04.Text = "S-GU-04"
        Me.CT_SGU04.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU04.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU04.Value2Text = "SP"
        Me.CT_SGU04.ValuePV = 0!
        Me.CT_SGU04.ValueSP = 0!
        '
        'Guardiola04
        '
        Me.Guardiola04.CIPConnectionSize = 508
        Me.Guardiola04.DisableMultiServiceRequest = False
        Me.Guardiola04.DisableSubscriptions = False
        Me.Guardiola04.IniFileName = ""
        Me.Guardiola04.IniFileSection = Nothing
        Me.Guardiola04.IPAddress = "10.1.108.18"
        Me.Guardiola04.PollRateOverride = 500
        Me.Guardiola04.Port = 44818
        Me.Guardiola04.ProcessorSlot = 0
        Me.Guardiola04.RoutePath = Nothing
        Me.Guardiola04.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola04
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
        Me.BasicButton1.ComComponent = Me.Guardiola04
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(961, 591)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU04"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 529
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU04
        '
        Me.LS_MarchaGU04.Blink = False
        Me.LS_MarchaGU04.ComComponent = Me.Guardiola04
        Me.LS_MarchaGU04.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU04.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU04.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU04.Location = New System.Drawing.Point(858, 318)
        Me.LS_MarchaGU04.Name = "LS_MarchaGU04"
        Me.LS_MarchaGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU04.PLCAddressClick = ""
        Me.LS_MarchaGU04.PLCAddressText = ""
        Me.LS_MarchaGU04.PLCAddressValue = "MARCHA_SGU04"
        Me.LS_MarchaGU04.PLCAddressVisible = ""
        Me.LS_MarchaGU04.Size = New System.Drawing.Size(46, 49)
        Me.LS_MarchaGU04.TabIndex = 526
        Me.LS_MarchaGU04.Value = False
        Me.LS_MarchaGU04.ValueToWrite = 0
        '
        'BCF_MenúP_GU04
        '
        Me.BCF_MenúP_GU04.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU04.ComComponent = Nothing
        Me.BCF_MenúP_GU04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU04.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU04.FormToOpen = Nothing
        Me.BCF_MenúP_GU04.KeypadWidth = 300
        Me.BCF_MenúP_GU04.Location = New System.Drawing.Point(229, 645)
        Me.BCF_MenúP_GU04.Name = "BCF_MenúP_GU04"
        Me.BCF_MenúP_GU04.Passcode = Nothing
        Me.BCF_MenúP_GU04.PasswordChar = False
        Me.BCF_MenúP_GU04.PLCAddressVisible = ""
        Me.BCF_MenúP_GU04.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU04.TabIndex = 525
        Me.BCF_MenúP_GU04.Text = "Menú Principal"
        Me.BCF_MenúP_GU04.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU04
        '
        Me.BP_FinCicloGU04.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU04.ComComponent = Me.Guardiola04
        Me.BP_FinCicloGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU04.Highlight = False
        Me.BP_FinCicloGU04.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU04.Location = New System.Drawing.Point(711, 217)
        Me.BP_FinCicloGU04.MaximumHoldTime = 3000
        Me.BP_FinCicloGU04.MinimumHoldTime = 500
        Me.BP_FinCicloGU04.Name = "BP_FinCicloGU04"
        Me.BP_FinCicloGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU04.PLCAddressClick = "BP_DETENER_CICLO_SGU04"
        Me.BP_FinCicloGU04.SelectTextAlternate = False
        Me.BP_FinCicloGU04.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU04.TabIndex = 524
        Me.BP_FinCicloGU04.Text = "Detener Ciclo"
        Me.BP_FinCicloGU04.TextAlternate = Nothing
        Me.BP_FinCicloGU04.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU04.ValueToWrite = 0
        '
        'BP_INICIO_CICLO_SGU04
        '
        Me.BP_INICIO_CICLO_SGU04.BackColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU04.ComComponent = Me.Guardiola04
        Me.BP_INICIO_CICLO_SGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU04.Highlight = False
        Me.BP_INICIO_CICLO_SGU04.HighlightColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU04.Location = New System.Drawing.Point(509, 217)
        Me.BP_INICIO_CICLO_SGU04.MaximumHoldTime = 3000
        Me.BP_INICIO_CICLO_SGU04.MinimumHoldTime = 500
        Me.BP_INICIO_CICLO_SGU04.Name = "BP_INICIO_CICLO_SGU04"
        Me.BP_INICIO_CICLO_SGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_INICIO_CICLO_SGU04.PLCAddressClick = "BP_INICIO_CICLO_SGU04"
        Me.BP_INICIO_CICLO_SGU04.SelectTextAlternate = False
        Me.BP_INICIO_CICLO_SGU04.Size = New System.Drawing.Size(148, 52)
        Me.BP_INICIO_CICLO_SGU04.TabIndex = 523
        Me.BP_INICIO_CICLO_SGU04.Text = "Iniciar Ciclo"
        Me.BP_INICIO_CICLO_SGU04.TextAlternate = Nothing
        Me.BP_INICIO_CICLO_SGU04.UseVisualStyleBackColor = False
        Me.BP_INICIO_CICLO_SGU04.ValueToWrite = 0
        '
        'BCF_RegresarGU04
        '
        Me.BCF_RegresarGU04.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU04.ComComponent = Nothing
        Me.BCF_RegresarGU04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU04.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU04.FormToOpen = Nothing
        Me.BCF_RegresarGU04.KeypadWidth = 300
        Me.BCF_RegresarGU04.Location = New System.Drawing.Point(646, 101)
        Me.BCF_RegresarGU04.Name = "BCF_RegresarGU04"
        Me.BCF_RegresarGU04.Passcode = Nothing
        Me.BCF_RegresarGU04.PasswordChar = False
        Me.BCF_RegresarGU04.PLCAddressVisible = ""
        Me.BCF_RegresarGU04.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU04.TabIndex = 522
        Me.BCF_RegresarGU04.Text = "Regresar"
        Me.BCF_RegresarGU04.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU04
        '
        Me.BP_DescargaGU04.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU04.ComComponent = Me.Guardiola04
        Me.BP_DescargaGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU04.Highlight = False
        Me.BP_DescargaGU04.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU04.Location = New System.Drawing.Point(961, 124)
        Me.BP_DescargaGU04.MaximumHoldTime = 3000
        Me.BP_DescargaGU04.MinimumHoldTime = 500
        Me.BP_DescargaGU04.Name = "BP_DescargaGU04"
        Me.BP_DescargaGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU04.PLCAddressClick = "BP_FINALIZAR_SGU04"
        Me.BP_DescargaGU04.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU04"
        Me.BP_DescargaGU04.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU04"
        Me.BP_DescargaGU04.SelectTextAlternate = False
        Me.BP_DescargaGU04.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU04.TabIndex = 521
        Me.BP_DescargaGU04.Text = "Finalizar"
        Me.BP_DescargaGU04.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU04.UseVisualStyleBackColor = True
        Me.BP_DescargaGU04.ValueToWrite = 0
        '
        'BP_CofirDescagaGU04
        '
        Me.BP_CofirDescagaGU04.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU04.ComComponent = Me.Guardiola04
        Me.BP_CofirDescagaGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU04.Highlight = False
        Me.BP_CofirDescagaGU04.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU04.Location = New System.Drawing.Point(961, 65)
        Me.BP_CofirDescagaGU04.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU04.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU04.Name = "BP_CofirDescagaGU04"
        Me.BP_CofirDescagaGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU04.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU04"
        Me.BP_CofirDescagaGU04.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU04"
        Me.BP_CofirDescagaGU04.SelectTextAlternate = False
        Me.BP_CofirDescagaGU04.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU04.TabIndex = 520
        Me.BP_CofirDescagaGU04.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU04.TextAlternate = Nothing
        Me.BP_CofirDescagaGU04.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU04.ValueToWrite = 0
        '
        'BN_SalidaGU04
        '
        Me.BN_SalidaGU04.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU04.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU04.ComComponent = Me.Guardiola04
        Me.BN_SalidaGU04.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU04.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU04.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU04.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU04.Location = New System.Drawing.Point(358, 157)
        Me.BN_SalidaGU04.Maximum = 100.0R
        Me.BN_SalidaGU04.Minimum = 0R
        Me.BN_SalidaGU04.Name = "BN_SalidaGU04"
        Me.BN_SalidaGU04.NumericFormat = Nothing
        Me.BN_SalidaGU04.PLCAddressValue = "PID_SGU04.OUT"
        Me.BN_SalidaGU04.ShowValue = True
        Me.BN_SalidaGU04.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU04.TabIndex = 519
        Me.BN_SalidaGU04.Text = "BarLevel3"
        Me.BN_SalidaGU04.TextSuffix = Nothing
        Me.BN_SalidaGU04.Value = 0R
        Me.BN_SalidaGU04.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU04
        '
        Me.BN_SP_TempGU04.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU04.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU04.ComComponent = Me.Guardiola04
        Me.BN_SP_TempGU04.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU04.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU04.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU04.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU04.Location = New System.Drawing.Point(216, 158)
        Me.BN_SP_TempGU04.Maximum = 100.0R
        Me.BN_SP_TempGU04.Minimum = 0R
        Me.BN_SP_TempGU04.Name = "BN_SP_TempGU04"
        Me.BN_SP_TempGU04.NumericFormat = Nothing
        Me.BN_SP_TempGU04.PLCAddressValue = "PID_SGU04.SP"
        Me.BN_SP_TempGU04.ShowValue = True
        Me.BN_SP_TempGU04.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU04.TabIndex = 518
        Me.BN_SP_TempGU04.Text = "BarLevel1"
        Me.BN_SP_TempGU04.TextSuffix = Nothing
        Me.BN_SP_TempGU04.Value = 0R
        Me.BN_SP_TempGU04.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU04
        '
        Me.MD_OrdenTrabajoGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU04.ComComponent = Me.Guardiola04
        Me.MD_OrdenTrabajoGU04.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU04.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU04.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU04.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU04.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU04.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU04.Location = New System.Drawing.Point(989, 508)
        Me.MD_OrdenTrabajoGU04.Name = "MD_OrdenTrabajoGU04"
        Me.MD_OrdenTrabajoGU04.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU04.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU04"
        Me.MD_OrdenTrabajoGU04.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU04"
        Me.MD_OrdenTrabajoGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU04.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU04.TabIndex = 517
        Me.MD_OrdenTrabajoGU04.Value = 0R
        Me.MD_OrdenTrabajoGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU04
        '
        Me.MD_CosechaGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU04.ComComponent = Me.Guardiola04
        Me.MD_CosechaGU04.DecimalPosition = 0
        Me.MD_CosechaGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU04.KeypadMaxValue = 0R
        Me.MD_CosechaGU04.KeypadMinValue = 0R
        Me.MD_CosechaGU04.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU04.KeypadText = Nothing
        Me.MD_CosechaGU04.KeypadWidth = 300
        Me.MD_CosechaGU04.Location = New System.Drawing.Point(989, 411)
        Me.MD_CosechaGU04.Name = "MD_CosechaGU04"
        Me.MD_CosechaGU04.NumberOfDigits = 5
        Me.MD_CosechaGU04.PLCAddressKeypad = ""
        Me.MD_CosechaGU04.PLCAddressValue = "COSECHA_SGU04"
        Me.MD_CosechaGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU04.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU04.TabIndex = 516
        Me.MD_CosechaGU04.Value = 0R
        Me.MD_CosechaGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU04
        '
        Me.MD_HorasEstimadasGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU04.ComComponent = Me.Guardiola04
        Me.MD_HorasEstimadasGU04.DecimalPosition = 0
        Me.MD_HorasEstimadasGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU04.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU04.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU04.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU04.KeypadText = Nothing
        Me.MD_HorasEstimadasGU04.KeypadWidth = 300
        Me.MD_HorasEstimadasGU04.Location = New System.Drawing.Point(989, 318)
        Me.MD_HorasEstimadasGU04.Name = "MD_HorasEstimadasGU04"
        Me.MD_HorasEstimadasGU04.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU04.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU04"
        Me.MD_HorasEstimadasGU04.PLCAddressValue = "TIEMPO_ESTIMADO_SGU04"
        Me.MD_HorasEstimadasGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU04.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU04.TabIndex = 515
        Me.MD_HorasEstimadasGU04.Value = 0R
        Me.MD_HorasEstimadasGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU04
        '
        Me.MD_CicloGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU04.ComComponent = Me.Guardiola04
        Me.MD_CicloGU04.DecimalPosition = 0
        Me.MD_CicloGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU04.KeypadMaxValue = 0R
        Me.MD_CicloGU04.KeypadMinValue = 0R
        Me.MD_CicloGU04.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU04.KeypadText = Nothing
        Me.MD_CicloGU04.KeypadWidth = 300
        Me.MD_CicloGU04.Location = New System.Drawing.Point(989, 226)
        Me.MD_CicloGU04.Name = "MD_CicloGU04"
        Me.MD_CicloGU04.NumberOfDigits = 5
        Me.MD_CicloGU04.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU04"
        Me.MD_CicloGU04.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU04"
        Me.MD_CicloGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU04.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU04.TabIndex = 514
        Me.MD_CicloGU04.Value = 0R
        Me.MD_CicloGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU04
        '
        Me.TexCicloGU04.AutoSize = True
        Me.TexCicloGU04.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU04.ComComponent = Me.Guardiola04
        Me.TexCicloGU04.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU04.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU04.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU04.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU04.HighlightKeyCharacter = "!"
        Me.TexCicloGU04.HighlightKeyCharacter2 = "."
        Me.TexCicloGU04.IniFileName = Nothing
        Me.TexCicloGU04.Location = New System.Drawing.Point(573, 522)
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Messages.Add(CType(resources.GetObject("TexCicloGU04.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU04.Name = "TexCicloGU04"
        Me.TexCicloGU04.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU04"
        Me.TexCicloGU04.PLCAddressVisible = ""
        Me.TexCicloGU04.ShowMessageNumber = False
        Me.TexCicloGU04.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU04.SpeakMessage = False
        Me.TexCicloGU04.TabIndex = 527
        Me.TexCicloGU04.Text = "No Seleccionado"
        Me.TexCicloGU04.TextPrefix = Nothing
        Me.TexCicloGU04.Value = 0
        '
        'MD_TempGU04
        '
        Me.MD_TempGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU04.ComComponent = Me.Guardiola04
        Me.MD_TempGU04.DecimalPosition = 1
        Me.MD_TempGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU04.KeypadMaxValue = 0R
        Me.MD_TempGU04.KeypadMinValue = 0R
        Me.MD_TempGU04.KeypadScaleFactor = 1.0R
        Me.MD_TempGU04.KeypadText = Nothing
        Me.MD_TempGU04.KeypadWidth = 300
        Me.MD_TempGU04.Location = New System.Drawing.Point(605, 338)
        Me.MD_TempGU04.Name = "MD_TempGU04"
        Me.MD_TempGU04.NumberOfDigits = 5
        Me.MD_TempGU04.PLCAddressKeypad = ""
        Me.MD_TempGU04.PLCAddressValue = "PID_SGU04.PV"
        Me.MD_TempGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU04.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU04.TabIndex = 513
        Me.MD_TempGU04.Value = 0R
        Me.MD_TempGU04.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU04
        '
        Me.MD_HorasProcesoGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU04.ComComponent = Me.Guardiola04
        Me.MD_HorasProcesoGU04.DecimalPosition = 0
        Me.MD_HorasProcesoGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU04.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU04.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU04.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU04.KeypadText = Nothing
        Me.MD_HorasProcesoGU04.KeypadWidth = 300
        Me.MD_HorasProcesoGU04.Location = New System.Drawing.Point(466, 84)
        Me.MD_HorasProcesoGU04.Name = "MD_HorasProcesoGU04"
        Me.MD_HorasProcesoGU04.NumberOfDigits = 5
        Me.MD_HorasProcesoGU04.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU04.PLCAddressValue = "TIEMPO_SECADO_SGU04"
        Me.MD_HorasProcesoGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU04.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU04.TabIndex = 512
        Me.MD_HorasProcesoGU04.Value = 0R
        Me.MD_HorasProcesoGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU04
        '
        Me.Tex_CicloGU04.AutoSize = True
        Me.Tex_CicloGU04.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU04.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU04.Location = New System.Drawing.Point(976, 204)
        Me.Tex_CicloGU04.Name = "Tex_CicloGU04"
        Me.Tex_CicloGU04.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU04.TabIndex = 511
        Me.Tex_CicloGU04.Text = "Numero de Ciclo"
        Me.Tex_CicloGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU04
        '
        Me.Tex_OrdenTrabajoGU04.AutoSize = True
        Me.Tex_OrdenTrabajoGU04.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU04.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU04.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU04.Location = New System.Drawing.Point(1029, 483)
        Me.Tex_OrdenTrabajoGU04.Name = "Tex_OrdenTrabajoGU04"
        Me.Tex_OrdenTrabajoGU04.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU04.TabIndex = 510
        Me.Tex_OrdenTrabajoGU04.Text = "OT"
        Me.Tex_OrdenTrabajoGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU04
        '
        Me.Tex_CosechaGU04.AutoSize = True
        Me.Tex_CosechaGU04.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU04.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU04.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU04.Location = New System.Drawing.Point(997, 386)
        Me.Tex_CosechaGU04.Name = "Tex_CosechaGU04"
        Me.Tex_CosechaGU04.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU04.TabIndex = 509
        Me.Tex_CosechaGU04.Text = "Cosecha"
        Me.Tex_CosechaGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU04
        '
        Me.Tex_HorasEstimadasGU04.AutoSize = True
        Me.Tex_HorasEstimadasGU04.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU04.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU04.Location = New System.Drawing.Point(929, 296)
        Me.Tex_HorasEstimadasGU04.Name = "Tex_HorasEstimadasGU04"
        Me.Tex_HorasEstimadasGU04.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU04.TabIndex = 508
        Me.Tex_HorasEstimadasGU04.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU04
        '
        Me.Tex_HorasProcesoGU04.AutoSize = True
        Me.Tex_HorasProcesoGU04.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU04.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU04.Location = New System.Drawing.Point(450, 55)
        Me.Tex_HorasProcesoGU04.Name = "Tex_HorasProcesoGU04"
        Me.Tex_HorasProcesoGU04.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU04.TabIndex = 507
        Me.Tex_HorasProcesoGU04.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola4
        '
        Me.TexGuardiola4.AutoSize = True
        Me.TexGuardiola4.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola4.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola4.Location = New System.Drawing.Point(679, 56)
        Me.TexGuardiola4.Name = "TexGuardiola4"
        Me.TexGuardiola4.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola4.TabIndex = 506
        Me.TexGuardiola4.Text = "Guardiola 04"
        '
        'TexTempGU04
        '
        Me.TexTempGU04.AutoSize = True
        Me.TexTempGU04.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU04.Location = New System.Drawing.Point(602, 317)
        Me.TexTempGU04.Name = "TexTempGU04"
        Me.TexTempGU04.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU04.TabIndex = 505
        Me.TexTempGU04.Text = "Temperatura °C"
        Me.TexTempGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU04
        '
        Me.TexPID_GU04.AutoSize = True
        Me.TexPID_GU04.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU04.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU04.Location = New System.Drawing.Point(203, 75)
        Me.TexPID_GU04.Name = "TexPID_GU04"
        Me.TexPID_GU04.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU04.TabIndex = 504
        Me.TexPID_GU04.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU04
        '
        Me.TexBN_SalidaGU04.AutoSize = True
        Me.TexBN_SalidaGU04.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU04.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU04.Location = New System.Drawing.Point(351, 136)
        Me.TexBN_SalidaGU04.Name = "TexBN_SalidaGU04"
        Me.TexBN_SalidaGU04.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU04.TabIndex = 503
        Me.TexBN_SalidaGU04.Text = "Salida"
        Me.TexBN_SalidaGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU04
        '
        Me.TexBN_RealTempGU04.AutoSize = True
        Me.TexBN_RealTempGU04.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU04.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU04.Location = New System.Drawing.Point(288, 137)
        Me.TexBN_RealTempGU04.Name = "TexBN_RealTempGU04"
        Me.TexBN_RealTempGU04.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU04.TabIndex = 502
        Me.TexBN_RealTempGU04.Text = "Real"
        Me.TexBN_RealTempGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU04
        '
        Me.TexBN_SP_TempGU04.AutoSize = True
        Me.TexBN_SP_TempGU04.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU04.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU04.Location = New System.Drawing.Point(202, 137)
        Me.TexBN_SP_TempGU04.Name = "TexBN_SP_TempGU04"
        Me.TexBN_SP_TempGU04.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU04.TabIndex = 501
        Me.TexBN_SP_TempGU04.Text = "SetPoint"
        Me.TexBN_SP_TempGU04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU04
        '
        Me.IGU04.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU04.Location = New System.Drawing.Point(441, 311)
        Me.IGU04.Name = "IGU04"
        Me.IGU04.Size = New System.Drawing.Size(541, 274)
        Me.IGU04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU04.TabIndex = 528
        Me.IGU04.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola04
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 54)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 530
        '
        'Guardiola_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU04)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU04)
        Me.Controls.Add(Me.BCF_MenúP_GU04)
        Me.Controls.Add(Me.BP_FinCicloGU04)
        Me.Controls.Add(Me.BP_INICIO_CICLO_SGU04)
        Me.Controls.Add(Me.BCF_RegresarGU04)
        Me.Controls.Add(Me.BP_DescargaGU04)
        Me.Controls.Add(Me.BP_CofirDescagaGU04)
        Me.Controls.Add(Me.BN_SalidaGU04)
        Me.Controls.Add(Me.BN_SP_TempGU04)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU04)
        Me.Controls.Add(Me.MD_CosechaGU04)
        Me.Controls.Add(Me.MD_HorasEstimadasGU04)
        Me.Controls.Add(Me.MD_CicloGU04)
        Me.Controls.Add(Me.TexCicloGU04)
        Me.Controls.Add(Me.MD_TempGU04)
        Me.Controls.Add(Me.MD_HorasProcesoGU04)
        Me.Controls.Add(Me.Tex_CicloGU04)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU04)
        Me.Controls.Add(Me.Tex_CosechaGU04)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU04)
        Me.Controls.Add(Me.Tex_HorasProcesoGU04)
        Me.Controls.Add(Me.TexGuardiola4)
        Me.Controls.Add(Me.TexTempGU04)
        Me.Controls.Add(Me.TexPID_GU04)
        Me.Controls.Add(Me.TexBN_SalidaGU04)
        Me.Controls.Add(Me.TexBN_RealTempGU04)
        Me.Controls.Add(Me.TexBN_SP_TempGU04)
        Me.Controls.Add(Me.IGU04)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU04, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU04 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola04 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU04 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU04 As FormChangeButton
    Friend WithEvents BP_FinCicloGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_INICIO_CICLO_SGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU04 As FormChangeButton
    Friend WithEvents BP_DescargaGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU04 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU04 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU04 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU04 As Label
    Friend WithEvents Tex_OrdenTrabajoGU04 As Label
    Friend WithEvents Tex_CosechaGU04 As Label
    Friend WithEvents Tex_HorasEstimadasGU04 As Label
    Friend WithEvents Tex_HorasProcesoGU04 As Label
    Friend WithEvents TexGuardiola4 As Label
    Friend WithEvents TexTempGU04 As Label
    Friend WithEvents TexPID_GU04 As Label
    Friend WithEvents TexBN_SalidaGU04 As Label
    Friend WithEvents TexBN_RealTempGU04 As Label
    Friend WithEvents TexBN_SP_TempGU04 As Label
    Friend WithEvents IGU04 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
