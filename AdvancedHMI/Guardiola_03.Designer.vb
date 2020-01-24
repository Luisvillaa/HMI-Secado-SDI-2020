<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_03))
        Me.CT_SGU03 = New AdvancedHMIControls.TempController()
        Me.Guardiola03 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU03 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU03 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU03 = New AdvancedHMIControls.BasicButton()
        Me.BP_INICIO_CICLO_SGU03 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU03 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU03 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU03 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU03 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU03 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU03 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU03 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU03 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU03 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU03 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU03 = New System.Windows.Forms.Label()
        Me.TexGuardiola3 = New System.Windows.Forms.Label()
        Me.TexTempGU03 = New System.Windows.Forms.Label()
        Me.TexPID_GU03 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU03 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU03 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU03 = New System.Windows.Forms.Label()
        Me.IGU03 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU03, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU03
        '
        Me.CT_SGU03.Button1Text = Nothing
        Me.CT_SGU03.Button2Text = Nothing
        Me.CT_SGU03.ComComponent = Me.Guardiola03
        Me.CT_SGU03.DecimalPosition = 1
        Me.CT_SGU03.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU03.Location = New System.Drawing.Point(204, 434)
        Me.CT_SGU03.Name = "CT_SGU03"
        Me.CT_SGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU03.PLCAddressClick1 = ""
        Me.CT_SGU03.PLCAddressClick2 = ""
        Me.CT_SGU03.PLCAddressClick3 = ""
        Me.CT_SGU03.PLCAddressClick4 = ""
        Me.CT_SGU03.PLCAddressText = ""
        Me.CT_SGU03.PLCAddressValuePV = "PID_SGU03.PV"
        Me.CT_SGU03.PLCAddressValueSP = "PID_SGU03.SP"
        Me.CT_SGU03.PLCAddressVisible = ""
        Me.CT_SGU03.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU03.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU03.TabIndex = 510
        Me.CT_SGU03.Text = "S-GU-03"
        Me.CT_SGU03.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU03.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU03.Value2Text = "SP"
        Me.CT_SGU03.ValuePV = 0!
        Me.CT_SGU03.ValueSP = 0!
        '
        'Guardiola03
        '
        Me.Guardiola03.CIPConnectionSize = 508
        Me.Guardiola03.DisableMultiServiceRequest = False
        Me.Guardiola03.DisableSubscriptions = False
        Me.Guardiola03.IniFileName = ""
        Me.Guardiola03.IniFileSection = Nothing
        Me.Guardiola03.IPAddress = "10.1.108.18"
        Me.Guardiola03.PollRateOverride = 500
        Me.Guardiola03.Port = 44818
        Me.Guardiola03.ProcessorSlot = 0
        Me.Guardiola03.RoutePath = Nothing
        Me.Guardiola03.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola03
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
        Me.BasicButton1.ComComponent = Me.Guardiola03
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(961, 592)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU03"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 508
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU03
        '
        Me.LS_MarchaGU03.Blink = False
        Me.LS_MarchaGU03.ComComponent = Me.Guardiola03
        Me.LS_MarchaGU03.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU03.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU03.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU03.Location = New System.Drawing.Point(855, 319)
        Me.LS_MarchaGU03.Name = "LS_MarchaGU03"
        Me.LS_MarchaGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU03.PLCAddressClick = ""
        Me.LS_MarchaGU03.PLCAddressText = ""
        Me.LS_MarchaGU03.PLCAddressValue = "MARCHA_SGU03"
        Me.LS_MarchaGU03.PLCAddressVisible = ""
        Me.LS_MarchaGU03.Size = New System.Drawing.Size(53, 56)
        Me.LS_MarchaGU03.TabIndex = 505
        Me.LS_MarchaGU03.Value = False
        Me.LS_MarchaGU03.ValueToWrite = 0
        '
        'BCF_MenúP_GU03
        '
        Me.BCF_MenúP_GU03.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU03.ComComponent = Nothing
        Me.BCF_MenúP_GU03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU03.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU03.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU03.KeypadWidth = 300
        Me.BCF_MenúP_GU03.Location = New System.Drawing.Point(228, 645)
        Me.BCF_MenúP_GU03.Name = "BCF_MenúP_GU03"
        Me.BCF_MenúP_GU03.Passcode = Nothing
        Me.BCF_MenúP_GU03.PasswordChar = False
        Me.BCF_MenúP_GU03.PLCAddressVisible = ""
        Me.BCF_MenúP_GU03.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU03.TabIndex = 504
        Me.BCF_MenúP_GU03.Text = "Menú Principal"
        Me.BCF_MenúP_GU03.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU03
        '
        Me.BP_FinCicloGU03.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU03.ComComponent = Me.Guardiola03
        Me.BP_FinCicloGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU03.Highlight = False
        Me.BP_FinCicloGU03.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU03.Location = New System.Drawing.Point(711, 225)
        Me.BP_FinCicloGU03.MaximumHoldTime = 3000
        Me.BP_FinCicloGU03.MinimumHoldTime = 500
        Me.BP_FinCicloGU03.Name = "BP_FinCicloGU03"
        Me.BP_FinCicloGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU03.PLCAddressClick = "BP_DETENER_CICLO_SGU03"
        Me.BP_FinCicloGU03.SelectTextAlternate = False
        Me.BP_FinCicloGU03.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU03.TabIndex = 503
        Me.BP_FinCicloGU03.Text = "Detener Ciclo"
        Me.BP_FinCicloGU03.TextAlternate = Nothing
        Me.BP_FinCicloGU03.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU03.ValueToWrite = 0
        '
        'BP_INICIO_CICLO_SGU03
        '
        Me.BP_INICIO_CICLO_SGU03.BackColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU03.ComComponent = Me.Guardiola03
        Me.BP_INICIO_CICLO_SGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU03.Highlight = False
        Me.BP_INICIO_CICLO_SGU03.HighlightColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU03.Location = New System.Drawing.Point(509, 225)
        Me.BP_INICIO_CICLO_SGU03.MaximumHoldTime = 3000
        Me.BP_INICIO_CICLO_SGU03.MinimumHoldTime = 500
        Me.BP_INICIO_CICLO_SGU03.Name = "BP_INICIO_CICLO_SGU03"
        Me.BP_INICIO_CICLO_SGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_INICIO_CICLO_SGU03.PLCAddressClick = "BP_INICIO_CICLO_SGU03"
        Me.BP_INICIO_CICLO_SGU03.SelectTextAlternate = False
        Me.BP_INICIO_CICLO_SGU03.Size = New System.Drawing.Size(148, 52)
        Me.BP_INICIO_CICLO_SGU03.TabIndex = 502
        Me.BP_INICIO_CICLO_SGU03.Text = "Iniciar Ciclo"
        Me.BP_INICIO_CICLO_SGU03.TextAlternate = Nothing
        Me.BP_INICIO_CICLO_SGU03.UseVisualStyleBackColor = False
        Me.BP_INICIO_CICLO_SGU03.ValueToWrite = 0
        '
        'BCF_RegresarGU03
        '
        Me.BCF_RegresarGU03.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU03.ComComponent = Nothing
        Me.BCF_RegresarGU03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU03.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU03.FormToOpen = Nothing
        Me.BCF_RegresarGU03.KeypadWidth = 300
        Me.BCF_RegresarGU03.Location = New System.Drawing.Point(646, 102)
        Me.BCF_RegresarGU03.Name = "BCF_RegresarGU03"
        Me.BCF_RegresarGU03.Passcode = Nothing
        Me.BCF_RegresarGU03.PasswordChar = False
        Me.BCF_RegresarGU03.PLCAddressVisible = ""
        Me.BCF_RegresarGU03.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU03.TabIndex = 501
        Me.BCF_RegresarGU03.Text = "Regresar"
        Me.BCF_RegresarGU03.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU03
        '
        Me.BP_DescargaGU03.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU03.ComComponent = Me.Guardiola03
        Me.BP_DescargaGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU03.Highlight = False
        Me.BP_DescargaGU03.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU03.Location = New System.Drawing.Point(961, 125)
        Me.BP_DescargaGU03.MaximumHoldTime = 3000
        Me.BP_DescargaGU03.MinimumHoldTime = 500
        Me.BP_DescargaGU03.Name = "BP_DescargaGU03"
        Me.BP_DescargaGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU03.PLCAddressClick = "BP_FINALIZAR_SGU03"
        Me.BP_DescargaGU03.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU03"
        Me.BP_DescargaGU03.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU03"
        Me.BP_DescargaGU03.SelectTextAlternate = False
        Me.BP_DescargaGU03.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU03.TabIndex = 500
        Me.BP_DescargaGU03.Text = "Finalizar"
        Me.BP_DescargaGU03.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU03.UseVisualStyleBackColor = True
        Me.BP_DescargaGU03.ValueToWrite = 0
        '
        'BP_CofirDescagaGU03
        '
        Me.BP_CofirDescagaGU03.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU03.ComComponent = Me.Guardiola03
        Me.BP_CofirDescagaGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU03.Highlight = False
        Me.BP_CofirDescagaGU03.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU03.Location = New System.Drawing.Point(961, 66)
        Me.BP_CofirDescagaGU03.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU03.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU03.Name = "BP_CofirDescagaGU03"
        Me.BP_CofirDescagaGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU03.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU03"
        Me.BP_CofirDescagaGU03.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU03"
        Me.BP_CofirDescagaGU03.SelectTextAlternate = False
        Me.BP_CofirDescagaGU03.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU03.TabIndex = 499
        Me.BP_CofirDescagaGU03.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU03.TextAlternate = Nothing
        Me.BP_CofirDescagaGU03.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU03.ValueToWrite = 0
        '
        'BN_SalidaGU03
        '
        Me.BN_SalidaGU03.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU03.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU03.ComComponent = Me.Guardiola03
        Me.BN_SalidaGU03.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU03.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU03.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU03.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU03.Location = New System.Drawing.Point(358, 158)
        Me.BN_SalidaGU03.Maximum = 100.0R
        Me.BN_SalidaGU03.Minimum = 0R
        Me.BN_SalidaGU03.Name = "BN_SalidaGU03"
        Me.BN_SalidaGU03.NumericFormat = Nothing
        Me.BN_SalidaGU03.PLCAddressValue = "PID_SGU03.OUT"
        Me.BN_SalidaGU03.ShowValue = True
        Me.BN_SalidaGU03.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU03.TabIndex = 498
        Me.BN_SalidaGU03.Text = "BarLevel3"
        Me.BN_SalidaGU03.TextSuffix = Nothing
        Me.BN_SalidaGU03.Value = 0R
        Me.BN_SalidaGU03.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU03
        '
        Me.BN_SP_TempGU03.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU03.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU03.ComComponent = Me.Guardiola03
        Me.BN_SP_TempGU03.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU03.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU03.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU03.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU03.Location = New System.Drawing.Point(216, 159)
        Me.BN_SP_TempGU03.Maximum = 100.0R
        Me.BN_SP_TempGU03.Minimum = 0R
        Me.BN_SP_TempGU03.Name = "BN_SP_TempGU03"
        Me.BN_SP_TempGU03.NumericFormat = Nothing
        Me.BN_SP_TempGU03.PLCAddressValue = "PID_SGU03.SP"
        Me.BN_SP_TempGU03.ShowValue = True
        Me.BN_SP_TempGU03.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU03.TabIndex = 497
        Me.BN_SP_TempGU03.Text = "BarLevel1"
        Me.BN_SP_TempGU03.TextSuffix = Nothing
        Me.BN_SP_TempGU03.Value = 0R
        Me.BN_SP_TempGU03.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU03
        '
        Me.MD_OrdenTrabajoGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU03.ComComponent = Me.Guardiola03
        Me.MD_OrdenTrabajoGU03.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU03.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU03.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU03.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU03.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU03.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU03.Location = New System.Drawing.Point(989, 509)
        Me.MD_OrdenTrabajoGU03.Name = "MD_OrdenTrabajoGU03"
        Me.MD_OrdenTrabajoGU03.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU03.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU03"
        Me.MD_OrdenTrabajoGU03.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU03"
        Me.MD_OrdenTrabajoGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU03.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU03.TabIndex = 496
        Me.MD_OrdenTrabajoGU03.Value = 0R
        Me.MD_OrdenTrabajoGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU03
        '
        Me.MD_CosechaGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU03.ComComponent = Me.Guardiola03
        Me.MD_CosechaGU03.DecimalPosition = 0
        Me.MD_CosechaGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU03.KeypadMaxValue = 0R
        Me.MD_CosechaGU03.KeypadMinValue = 0R
        Me.MD_CosechaGU03.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU03.KeypadText = Nothing
        Me.MD_CosechaGU03.KeypadWidth = 300
        Me.MD_CosechaGU03.Location = New System.Drawing.Point(989, 412)
        Me.MD_CosechaGU03.Name = "MD_CosechaGU03"
        Me.MD_CosechaGU03.NumberOfDigits = 5
        Me.MD_CosechaGU03.PLCAddressKeypad = ""
        Me.MD_CosechaGU03.PLCAddressValue = "COSECHA_SGU03"
        Me.MD_CosechaGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU03.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU03.TabIndex = 495
        Me.MD_CosechaGU03.Value = 0R
        Me.MD_CosechaGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU03
        '
        Me.MD_HorasEstimadasGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU03.ComComponent = Me.Guardiola03
        Me.MD_HorasEstimadasGU03.DecimalPosition = 0
        Me.MD_HorasEstimadasGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU03.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU03.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU03.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU03.KeypadText = Nothing
        Me.MD_HorasEstimadasGU03.KeypadWidth = 300
        Me.MD_HorasEstimadasGU03.Location = New System.Drawing.Point(989, 319)
        Me.MD_HorasEstimadasGU03.Name = "MD_HorasEstimadasGU03"
        Me.MD_HorasEstimadasGU03.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU03.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU03"
        Me.MD_HorasEstimadasGU03.PLCAddressValue = "TIEMPO_ESTIMADO_SGU03"
        Me.MD_HorasEstimadasGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU03.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU03.TabIndex = 494
        Me.MD_HorasEstimadasGU03.Value = 0R
        Me.MD_HorasEstimadasGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU03
        '
        Me.MD_CicloGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU03.ComComponent = Me.Guardiola03
        Me.MD_CicloGU03.DecimalPosition = 0
        Me.MD_CicloGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU03.KeypadMaxValue = 0R
        Me.MD_CicloGU03.KeypadMinValue = 0R
        Me.MD_CicloGU03.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU03.KeypadText = Nothing
        Me.MD_CicloGU03.KeypadWidth = 300
        Me.MD_CicloGU03.Location = New System.Drawing.Point(989, 227)
        Me.MD_CicloGU03.Name = "MD_CicloGU03"
        Me.MD_CicloGU03.NumberOfDigits = 5
        Me.MD_CicloGU03.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU03"
        Me.MD_CicloGU03.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU03"
        Me.MD_CicloGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU03.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU03.TabIndex = 493
        Me.MD_CicloGU03.Value = 0R
        Me.MD_CicloGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU03
        '
        Me.TexCicloGU03.AutoSize = True
        Me.TexCicloGU03.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU03.ComComponent = Me.Guardiola03
        Me.TexCicloGU03.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU03.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU03.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU03.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU03.HighlightKeyCharacter = "!"
        Me.TexCicloGU03.HighlightKeyCharacter2 = "."
        Me.TexCicloGU03.IniFileName = Nothing
        Me.TexCicloGU03.Location = New System.Drawing.Point(587, 523)
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Messages.Add(CType(resources.GetObject("TexCicloGU03.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU03.Name = "TexCicloGU03"
        Me.TexCicloGU03.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU03"
        Me.TexCicloGU03.PLCAddressVisible = ""
        Me.TexCicloGU03.ShowMessageNumber = False
        Me.TexCicloGU03.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU03.SpeakMessage = False
        Me.TexCicloGU03.TabIndex = 506
        Me.TexCicloGU03.Text = "No Seleccionado"
        Me.TexCicloGU03.TextPrefix = Nothing
        Me.TexCicloGU03.Value = 0
        '
        'MD_TempGU03
        '
        Me.MD_TempGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU03.ComComponent = Me.Guardiola03
        Me.MD_TempGU03.DecimalPosition = 1
        Me.MD_TempGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU03.KeypadMaxValue = 0R
        Me.MD_TempGU03.KeypadMinValue = 0R
        Me.MD_TempGU03.KeypadScaleFactor = 1.0R
        Me.MD_TempGU03.KeypadText = Nothing
        Me.MD_TempGU03.KeypadWidth = 300
        Me.MD_TempGU03.Location = New System.Drawing.Point(606, 340)
        Me.MD_TempGU03.Name = "MD_TempGU03"
        Me.MD_TempGU03.NumberOfDigits = 5
        Me.MD_TempGU03.PLCAddressKeypad = ""
        Me.MD_TempGU03.PLCAddressValue = "PID_SGU03.PV"
        Me.MD_TempGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU03.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU03.TabIndex = 492
        Me.MD_TempGU03.Value = 0R
        Me.MD_TempGU03.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU03
        '
        Me.MD_HorasProcesoGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU03.ComComponent = Me.Guardiola03
        Me.MD_HorasProcesoGU03.DecimalPosition = 0
        Me.MD_HorasProcesoGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU03.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU03.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU03.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU03.KeypadText = Nothing
        Me.MD_HorasProcesoGU03.KeypadWidth = 300
        Me.MD_HorasProcesoGU03.Location = New System.Drawing.Point(466, 85)
        Me.MD_HorasProcesoGU03.Name = "MD_HorasProcesoGU03"
        Me.MD_HorasProcesoGU03.NumberOfDigits = 5
        Me.MD_HorasProcesoGU03.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU03.PLCAddressValue = "TIEMPO_SECADO_SGU03"
        Me.MD_HorasProcesoGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU03.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU03.TabIndex = 491
        Me.MD_HorasProcesoGU03.Value = 0R
        Me.MD_HorasProcesoGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU03
        '
        Me.Tex_CicloGU03.AutoSize = True
        Me.Tex_CicloGU03.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU03.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU03.Location = New System.Drawing.Point(976, 205)
        Me.Tex_CicloGU03.Name = "Tex_CicloGU03"
        Me.Tex_CicloGU03.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU03.TabIndex = 490
        Me.Tex_CicloGU03.Text = "Numero de Ciclo"
        Me.Tex_CicloGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU03
        '
        Me.Tex_OrdenTrabajoGU03.AutoSize = True
        Me.Tex_OrdenTrabajoGU03.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU03.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU03.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU03.Location = New System.Drawing.Point(1029, 484)
        Me.Tex_OrdenTrabajoGU03.Name = "Tex_OrdenTrabajoGU03"
        Me.Tex_OrdenTrabajoGU03.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU03.TabIndex = 489
        Me.Tex_OrdenTrabajoGU03.Text = "OT"
        Me.Tex_OrdenTrabajoGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU03
        '
        Me.Tex_CosechaGU03.AutoSize = True
        Me.Tex_CosechaGU03.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU03.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU03.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU03.Location = New System.Drawing.Point(997, 387)
        Me.Tex_CosechaGU03.Name = "Tex_CosechaGU03"
        Me.Tex_CosechaGU03.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU03.TabIndex = 488
        Me.Tex_CosechaGU03.Text = "Cosecha"
        Me.Tex_CosechaGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU03
        '
        Me.Tex_HorasEstimadasGU03.AutoSize = True
        Me.Tex_HorasEstimadasGU03.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU03.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU03.Location = New System.Drawing.Point(929, 297)
        Me.Tex_HorasEstimadasGU03.Name = "Tex_HorasEstimadasGU03"
        Me.Tex_HorasEstimadasGU03.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU03.TabIndex = 487
        Me.Tex_HorasEstimadasGU03.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU03
        '
        Me.Tex_HorasProcesoGU03.AutoSize = True
        Me.Tex_HorasProcesoGU03.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU03.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU03.Location = New System.Drawing.Point(450, 56)
        Me.Tex_HorasProcesoGU03.Name = "Tex_HorasProcesoGU03"
        Me.Tex_HorasProcesoGU03.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU03.TabIndex = 486
        Me.Tex_HorasProcesoGU03.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola3
        '
        Me.TexGuardiola3.AutoSize = True
        Me.TexGuardiola3.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola3.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola3.Location = New System.Drawing.Point(679, 57)
        Me.TexGuardiola3.Name = "TexGuardiola3"
        Me.TexGuardiola3.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola3.TabIndex = 485
        Me.TexGuardiola3.Text = "Guardiola 03"
        '
        'TexTempGU03
        '
        Me.TexTempGU03.AutoSize = True
        Me.TexTempGU03.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU03.Location = New System.Drawing.Point(603, 319)
        Me.TexTempGU03.Name = "TexTempGU03"
        Me.TexTempGU03.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU03.TabIndex = 484
        Me.TexTempGU03.Text = "Temperatura °C"
        Me.TexTempGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU03
        '
        Me.TexPID_GU03.AutoSize = True
        Me.TexPID_GU03.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU03.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU03.Location = New System.Drawing.Point(204, 76)
        Me.TexPID_GU03.Name = "TexPID_GU03"
        Me.TexPID_GU03.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU03.TabIndex = 483
        Me.TexPID_GU03.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU03
        '
        Me.TexBN_SalidaGU03.AutoSize = True
        Me.TexBN_SalidaGU03.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU03.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU03.Location = New System.Drawing.Point(351, 137)
        Me.TexBN_SalidaGU03.Name = "TexBN_SalidaGU03"
        Me.TexBN_SalidaGU03.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU03.TabIndex = 482
        Me.TexBN_SalidaGU03.Text = "Salida"
        Me.TexBN_SalidaGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU03
        '
        Me.TexBN_RealTempGU03.AutoSize = True
        Me.TexBN_RealTempGU03.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU03.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU03.Location = New System.Drawing.Point(288, 138)
        Me.TexBN_RealTempGU03.Name = "TexBN_RealTempGU03"
        Me.TexBN_RealTempGU03.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU03.TabIndex = 481
        Me.TexBN_RealTempGU03.Text = "Real"
        Me.TexBN_RealTempGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU03
        '
        Me.TexBN_SP_TempGU03.AutoSize = True
        Me.TexBN_SP_TempGU03.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU03.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU03.Location = New System.Drawing.Point(202, 138)
        Me.TexBN_SP_TempGU03.Name = "TexBN_SP_TempGU03"
        Me.TexBN_SP_TempGU03.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU03.TabIndex = 480
        Me.TexBN_SP_TempGU03.Text = "SetPoint"
        Me.TexBN_SP_TempGU03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU03
        '
        Me.IGU03.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU03.Location = New System.Drawing.Point(442, 312)
        Me.IGU03.Name = "IGU03"
        Me.IGU03.Size = New System.Drawing.Size(541, 274)
        Me.IGU03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU03.TabIndex = 507
        Me.IGU03.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola03
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 54)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 509
        '
        'Guardiola_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU03)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU03)
        Me.Controls.Add(Me.BCF_MenúP_GU03)
        Me.Controls.Add(Me.BP_FinCicloGU03)
        Me.Controls.Add(Me.BP_INICIO_CICLO_SGU03)
        Me.Controls.Add(Me.BCF_RegresarGU03)
        Me.Controls.Add(Me.BP_DescargaGU03)
        Me.Controls.Add(Me.BP_CofirDescagaGU03)
        Me.Controls.Add(Me.BN_SalidaGU03)
        Me.Controls.Add(Me.BN_SP_TempGU03)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU03)
        Me.Controls.Add(Me.MD_CosechaGU03)
        Me.Controls.Add(Me.MD_HorasEstimadasGU03)
        Me.Controls.Add(Me.MD_CicloGU03)
        Me.Controls.Add(Me.TexCicloGU03)
        Me.Controls.Add(Me.MD_TempGU03)
        Me.Controls.Add(Me.MD_HorasProcesoGU03)
        Me.Controls.Add(Me.Tex_CicloGU03)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU03)
        Me.Controls.Add(Me.Tex_CosechaGU03)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU03)
        Me.Controls.Add(Me.Tex_HorasProcesoGU03)
        Me.Controls.Add(Me.TexGuardiola3)
        Me.Controls.Add(Me.TexTempGU03)
        Me.Controls.Add(Me.TexPID_GU03)
        Me.Controls.Add(Me.TexBN_SalidaGU03)
        Me.Controls.Add(Me.TexBN_RealTempGU03)
        Me.Controls.Add(Me.TexBN_SP_TempGU03)
        Me.Controls.Add(Me.IGU03)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU03, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU03 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola03 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU03 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU03 As FormChangeButton
    Friend WithEvents BP_FinCicloGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_INICIO_CICLO_SGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU03 As FormChangeButton
    Friend WithEvents BP_DescargaGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU03 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU03 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU03 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU03 As Label
    Friend WithEvents Tex_OrdenTrabajoGU03 As Label
    Friend WithEvents Tex_CosechaGU03 As Label
    Friend WithEvents Tex_HorasEstimadasGU03 As Label
    Friend WithEvents Tex_HorasProcesoGU03 As Label
    Friend WithEvents TexGuardiola3 As Label
    Friend WithEvents TexTempGU03 As Label
    Friend WithEvents TexPID_GU03 As Label
    Friend WithEvents TexBN_SalidaGU03 As Label
    Friend WithEvents TexBN_RealTempGU03 As Label
    Friend WithEvents TexBN_SP_TempGU03 As Label
    Friend WithEvents IGU03 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
