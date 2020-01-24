<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_05
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_05))
        Me.CT_SGU05 = New AdvancedHMIControls.TempController()
        Me.Guardiola05 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU05 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU05 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU05 = New AdvancedHMIControls.BasicButton()
        Me.BP_INICIO_CICLO_SGU05 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU05 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU05 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU05 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU05 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU05 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU05 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU05 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU05 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU05 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU05 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU05 = New System.Windows.Forms.Label()
        Me.TexGuardiola5 = New System.Windows.Forms.Label()
        Me.TexTempGU05 = New System.Windows.Forms.Label()
        Me.TexPID_GU05 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU05 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU05 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU05 = New System.Windows.Forms.Label()
        Me.IGU05 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU05, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU05
        '
        Me.CT_SGU05.Button1Text = Nothing
        Me.CT_SGU05.Button2Text = Nothing
        Me.CT_SGU05.ComComponent = Me.Guardiola05
        Me.CT_SGU05.DecimalPosition = 1
        Me.CT_SGU05.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU05.Location = New System.Drawing.Point(204, 435)
        Me.CT_SGU05.Name = "CT_SGU05"
        Me.CT_SGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU05.PLCAddressClick1 = ""
        Me.CT_SGU05.PLCAddressClick2 = ""
        Me.CT_SGU05.PLCAddressClick3 = ""
        Me.CT_SGU05.PLCAddressClick4 = ""
        Me.CT_SGU05.PLCAddressText = ""
        Me.CT_SGU05.PLCAddressValuePV = "PID_SGU05.PV"
        Me.CT_SGU05.PLCAddressValueSP = "PID_SGU05.SP"
        Me.CT_SGU05.PLCAddressVisible = ""
        Me.CT_SGU05.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU05.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU05.TabIndex = 567
        Me.CT_SGU05.Text = "S-GU-05"
        Me.CT_SGU05.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU05.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU05.Value2Text = "SP"
        Me.CT_SGU05.ValuePV = 0!
        Me.CT_SGU05.ValueSP = 0!
        '
        'Guardiola05
        '
        Me.Guardiola05.CIPConnectionSize = 508
        Me.Guardiola05.DisableMultiServiceRequest = False
        Me.Guardiola05.DisableSubscriptions = False
        Me.Guardiola05.IniFileName = ""
        Me.Guardiola05.IniFileSection = Nothing
        Me.Guardiola05.IPAddress = "10.1.108.18"
        Me.Guardiola05.PollRateOverride = 500
        Me.Guardiola05.Port = 44818
        Me.Guardiola05.ProcessorSlot = 0
        Me.Guardiola05.RoutePath = Nothing
        Me.Guardiola05.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola05
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
        Me.BasicButton1.ComComponent = Me.Guardiola05
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
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU05"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 565
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU05
        '
        Me.LS_MarchaGU05.Blink = False
        Me.LS_MarchaGU05.ComComponent = Me.Guardiola05
        Me.LS_MarchaGU05.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU05.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU05.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU05.Location = New System.Drawing.Point(855, 320)
        Me.LS_MarchaGU05.Name = "LS_MarchaGU05"
        Me.LS_MarchaGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU05.PLCAddressClick = ""
        Me.LS_MarchaGU05.PLCAddressText = ""
        Me.LS_MarchaGU05.PLCAddressValue = "MARCHA_SGU05"
        Me.LS_MarchaGU05.PLCAddressVisible = ""
        Me.LS_MarchaGU05.Size = New System.Drawing.Size(53, 56)
        Me.LS_MarchaGU05.TabIndex = 562
        Me.LS_MarchaGU05.Value = False
        Me.LS_MarchaGU05.ValueToWrite = 0
        '
        'BCF_MenúP_GU05
        '
        Me.BCF_MenúP_GU05.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU05.ComComponent = Nothing
        Me.BCF_MenúP_GU05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU05.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU05.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU05.KeypadWidth = 300
        Me.BCF_MenúP_GU05.Location = New System.Drawing.Point(225, 644)
        Me.BCF_MenúP_GU05.Name = "BCF_MenúP_GU05"
        Me.BCF_MenúP_GU05.Passcode = Nothing
        Me.BCF_MenúP_GU05.PasswordChar = False
        Me.BCF_MenúP_GU05.PLCAddressVisible = ""
        Me.BCF_MenúP_GU05.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU05.TabIndex = 561
        Me.BCF_MenúP_GU05.Text = "Menú Principal"
        Me.BCF_MenúP_GU05.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU05
        '
        Me.BP_FinCicloGU05.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU05.ComComponent = Me.Guardiola05
        Me.BP_FinCicloGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU05.Highlight = False
        Me.BP_FinCicloGU05.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU05.Location = New System.Drawing.Point(711, 233)
        Me.BP_FinCicloGU05.MaximumHoldTime = 3000
        Me.BP_FinCicloGU05.MinimumHoldTime = 500
        Me.BP_FinCicloGU05.Name = "BP_FinCicloGU05"
        Me.BP_FinCicloGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU05.PLCAddressClick = "BP_DETENER_CICLO_SGU05"
        Me.BP_FinCicloGU05.SelectTextAlternate = False
        Me.BP_FinCicloGU05.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU05.TabIndex = 560
        Me.BP_FinCicloGU05.Text = "Detener Ciclo"
        Me.BP_FinCicloGU05.TextAlternate = Nothing
        Me.BP_FinCicloGU05.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU05.ValueToWrite = 0
        '
        'BP_INICIO_CICLO_SGU05
        '
        Me.BP_INICIO_CICLO_SGU05.BackColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU05.ComComponent = Me.Guardiola05
        Me.BP_INICIO_CICLO_SGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_INICIO_CICLO_SGU05.Highlight = False
        Me.BP_INICIO_CICLO_SGU05.HighlightColor = System.Drawing.Color.Green
        Me.BP_INICIO_CICLO_SGU05.Location = New System.Drawing.Point(509, 233)
        Me.BP_INICIO_CICLO_SGU05.MaximumHoldTime = 3000
        Me.BP_INICIO_CICLO_SGU05.MinimumHoldTime = 500
        Me.BP_INICIO_CICLO_SGU05.Name = "BP_INICIO_CICLO_SGU05"
        Me.BP_INICIO_CICLO_SGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_INICIO_CICLO_SGU05.PLCAddressClick = "BP_INICIO_CICLO_SGU05"
        Me.BP_INICIO_CICLO_SGU05.SelectTextAlternate = False
        Me.BP_INICIO_CICLO_SGU05.Size = New System.Drawing.Size(148, 52)
        Me.BP_INICIO_CICLO_SGU05.TabIndex = 559
        Me.BP_INICIO_CICLO_SGU05.Text = "Iniciar Ciclo"
        Me.BP_INICIO_CICLO_SGU05.TextAlternate = Nothing
        Me.BP_INICIO_CICLO_SGU05.UseVisualStyleBackColor = False
        Me.BP_INICIO_CICLO_SGU05.ValueToWrite = 0
        '
        'BCF_RegresarGU05
        '
        Me.BCF_RegresarGU05.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU05.ComComponent = Nothing
        Me.BCF_RegresarGU05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU05.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU05.FormToOpen = Nothing
        Me.BCF_RegresarGU05.KeypadWidth = 300
        Me.BCF_RegresarGU05.Location = New System.Drawing.Point(646, 103)
        Me.BCF_RegresarGU05.Name = "BCF_RegresarGU05"
        Me.BCF_RegresarGU05.Passcode = Nothing
        Me.BCF_RegresarGU05.PasswordChar = False
        Me.BCF_RegresarGU05.PLCAddressVisible = ""
        Me.BCF_RegresarGU05.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU05.TabIndex = 558
        Me.BCF_RegresarGU05.Text = "Regresar"
        Me.BCF_RegresarGU05.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU05
        '
        Me.BP_DescargaGU05.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU05.ComComponent = Me.Guardiola05
        Me.BP_DescargaGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU05.Highlight = False
        Me.BP_DescargaGU05.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU05.Location = New System.Drawing.Point(961, 126)
        Me.BP_DescargaGU05.MaximumHoldTime = 3000
        Me.BP_DescargaGU05.MinimumHoldTime = 500
        Me.BP_DescargaGU05.Name = "BP_DescargaGU05"
        Me.BP_DescargaGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU05.PLCAddressClick = "BP_FINALIZAR_SGU05"
        Me.BP_DescargaGU05.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU05"
        Me.BP_DescargaGU05.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU05"
        Me.BP_DescargaGU05.SelectTextAlternate = False
        Me.BP_DescargaGU05.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU05.TabIndex = 557
        Me.BP_DescargaGU05.Text = "Finalizar"
        Me.BP_DescargaGU05.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU05.UseVisualStyleBackColor = True
        Me.BP_DescargaGU05.ValueToWrite = 0
        '
        'BP_CofirDescagaGU05
        '
        Me.BP_CofirDescagaGU05.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU05.ComComponent = Me.Guardiola05
        Me.BP_CofirDescagaGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU05.Highlight = False
        Me.BP_CofirDescagaGU05.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU05.Location = New System.Drawing.Point(961, 67)
        Me.BP_CofirDescagaGU05.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU05.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU05.Name = "BP_CofirDescagaGU05"
        Me.BP_CofirDescagaGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU05.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU05"
        Me.BP_CofirDescagaGU05.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU05"
        Me.BP_CofirDescagaGU05.SelectTextAlternate = False
        Me.BP_CofirDescagaGU05.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU05.TabIndex = 556
        Me.BP_CofirDescagaGU05.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU05.TextAlternate = Nothing
        Me.BP_CofirDescagaGU05.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU05.ValueToWrite = 0
        '
        'BN_SalidaGU05
        '
        Me.BN_SalidaGU05.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU05.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU05.ComComponent = Me.Guardiola05
        Me.BN_SalidaGU05.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU05.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU05.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU05.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU05.Location = New System.Drawing.Point(358, 159)
        Me.BN_SalidaGU05.Maximum = 100.0R
        Me.BN_SalidaGU05.Minimum = 0R
        Me.BN_SalidaGU05.Name = "BN_SalidaGU05"
        Me.BN_SalidaGU05.NumericFormat = Nothing
        Me.BN_SalidaGU05.PLCAddressValue = "PID_SGU05.OUT"
        Me.BN_SalidaGU05.ShowValue = True
        Me.BN_SalidaGU05.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU05.TabIndex = 555
        Me.BN_SalidaGU05.Text = "BarLevel3"
        Me.BN_SalidaGU05.TextSuffix = Nothing
        Me.BN_SalidaGU05.Value = 0R
        Me.BN_SalidaGU05.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU05
        '
        Me.BN_SP_TempGU05.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU05.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU05.ComComponent = Me.Guardiola05
        Me.BN_SP_TempGU05.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU05.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU05.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU05.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU05.Location = New System.Drawing.Point(216, 160)
        Me.BN_SP_TempGU05.Maximum = 100.0R
        Me.BN_SP_TempGU05.Minimum = 0R
        Me.BN_SP_TempGU05.Name = "BN_SP_TempGU05"
        Me.BN_SP_TempGU05.NumericFormat = Nothing
        Me.BN_SP_TempGU05.PLCAddressValue = "PID_SGU05.SP"
        Me.BN_SP_TempGU05.ShowValue = True
        Me.BN_SP_TempGU05.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU05.TabIndex = 554
        Me.BN_SP_TempGU05.Text = "BarLevel1"
        Me.BN_SP_TempGU05.TextSuffix = Nothing
        Me.BN_SP_TempGU05.Value = 0R
        Me.BN_SP_TempGU05.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU05
        '
        Me.MD_OrdenTrabajoGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU05.ComComponent = Me.Guardiola05
        Me.MD_OrdenTrabajoGU05.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU05.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU05.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU05.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU05.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU05.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU05.Location = New System.Drawing.Point(989, 510)
        Me.MD_OrdenTrabajoGU05.Name = "MD_OrdenTrabajoGU05"
        Me.MD_OrdenTrabajoGU05.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU05.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU05"
        Me.MD_OrdenTrabajoGU05.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU05"
        Me.MD_OrdenTrabajoGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU05.TabIndex = 553
        Me.MD_OrdenTrabajoGU05.Value = 0R
        Me.MD_OrdenTrabajoGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU05
        '
        Me.MD_CosechaGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU05.ComComponent = Me.Guardiola05
        Me.MD_CosechaGU05.DecimalPosition = 0
        Me.MD_CosechaGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU05.KeypadMaxValue = 0R
        Me.MD_CosechaGU05.KeypadMinValue = 0R
        Me.MD_CosechaGU05.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU05.KeypadText = Nothing
        Me.MD_CosechaGU05.KeypadWidth = 300
        Me.MD_CosechaGU05.Location = New System.Drawing.Point(989, 413)
        Me.MD_CosechaGU05.Name = "MD_CosechaGU05"
        Me.MD_CosechaGU05.NumberOfDigits = 5
        Me.MD_CosechaGU05.PLCAddressKeypad = ""
        Me.MD_CosechaGU05.PLCAddressValue = "COSECHA_SGU05"
        Me.MD_CosechaGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU05.TabIndex = 552
        Me.MD_CosechaGU05.Value = 0R
        Me.MD_CosechaGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU05
        '
        Me.MD_HorasEstimadasGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU05.ComComponent = Me.Guardiola05
        Me.MD_HorasEstimadasGU05.DecimalPosition = 0
        Me.MD_HorasEstimadasGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU05.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU05.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU05.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU05.KeypadText = Nothing
        Me.MD_HorasEstimadasGU05.KeypadWidth = 300
        Me.MD_HorasEstimadasGU05.Location = New System.Drawing.Point(989, 320)
        Me.MD_HorasEstimadasGU05.Name = "MD_HorasEstimadasGU05"
        Me.MD_HorasEstimadasGU05.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU05.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU05"
        Me.MD_HorasEstimadasGU05.PLCAddressValue = "TIEMPO_ESTIMADO_SGU05"
        Me.MD_HorasEstimadasGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU05.TabIndex = 551
        Me.MD_HorasEstimadasGU05.Value = 0R
        Me.MD_HorasEstimadasGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU05
        '
        Me.MD_CicloGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU05.ComComponent = Me.Guardiola05
        Me.MD_CicloGU05.DecimalPosition = 0
        Me.MD_CicloGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU05.KeypadMaxValue = 0R
        Me.MD_CicloGU05.KeypadMinValue = 0R
        Me.MD_CicloGU05.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU05.KeypadText = Nothing
        Me.MD_CicloGU05.KeypadWidth = 300
        Me.MD_CicloGU05.Location = New System.Drawing.Point(989, 228)
        Me.MD_CicloGU05.Name = "MD_CicloGU05"
        Me.MD_CicloGU05.NumberOfDigits = 5
        Me.MD_CicloGU05.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU05"
        Me.MD_CicloGU05.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU05"
        Me.MD_CicloGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU05.TabIndex = 550
        Me.MD_CicloGU05.Value = 0R
        Me.MD_CicloGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU05
        '
        Me.TexCicloGU05.AutoSize = True
        Me.TexCicloGU05.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU05.ComComponent = Me.Guardiola05
        Me.TexCicloGU05.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU05.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU05.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU05.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU05.HighlightKeyCharacter = "!"
        Me.TexCicloGU05.HighlightKeyCharacter2 = "."
        Me.TexCicloGU05.IniFileName = Nothing
        Me.TexCicloGU05.Location = New System.Drawing.Point(578, 524)
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Messages.Add(CType(resources.GetObject("TexCicloGU05.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU05.Name = "TexCicloGU05"
        Me.TexCicloGU05.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU05"
        Me.TexCicloGU05.PLCAddressVisible = ""
        Me.TexCicloGU05.ShowMessageNumber = False
        Me.TexCicloGU05.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU05.SpeakMessage = False
        Me.TexCicloGU05.TabIndex = 563
        Me.TexCicloGU05.Text = "No Seleccionado"
        Me.TexCicloGU05.TextPrefix = Nothing
        Me.TexCicloGU05.Value = 0
        '
        'MD_TempGU05
        '
        Me.MD_TempGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU05.ComComponent = Me.Guardiola05
        Me.MD_TempGU05.DecimalPosition = 1
        Me.MD_TempGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU05.KeypadMaxValue = 0R
        Me.MD_TempGU05.KeypadMinValue = 0R
        Me.MD_TempGU05.KeypadScaleFactor = 1.0R
        Me.MD_TempGU05.KeypadText = Nothing
        Me.MD_TempGU05.KeypadWidth = 300
        Me.MD_TempGU05.Location = New System.Drawing.Point(605, 342)
        Me.MD_TempGU05.Name = "MD_TempGU05"
        Me.MD_TempGU05.NumberOfDigits = 5
        Me.MD_TempGU05.PLCAddressKeypad = ""
        Me.MD_TempGU05.PLCAddressValue = "PID_SGU05.PV"
        Me.MD_TempGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU05.TabIndex = 549
        Me.MD_TempGU05.Value = 0R
        Me.MD_TempGU05.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU05
        '
        Me.MD_HorasProcesoGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU05.ComComponent = Me.Guardiola05
        Me.MD_HorasProcesoGU05.DecimalPosition = 0
        Me.MD_HorasProcesoGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU05.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU05.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU05.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU05.KeypadText = Nothing
        Me.MD_HorasProcesoGU05.KeypadWidth = 300
        Me.MD_HorasProcesoGU05.Location = New System.Drawing.Point(466, 86)
        Me.MD_HorasProcesoGU05.Name = "MD_HorasProcesoGU05"
        Me.MD_HorasProcesoGU05.NumberOfDigits = 5
        Me.MD_HorasProcesoGU05.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU05.PLCAddressValue = "TIEMPO_SECADO_SGU05"
        Me.MD_HorasProcesoGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU05.TabIndex = 548
        Me.MD_HorasProcesoGU05.Value = 0R
        Me.MD_HorasProcesoGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU05
        '
        Me.Tex_CicloGU05.AutoSize = True
        Me.Tex_CicloGU05.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU05.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU05.Location = New System.Drawing.Point(976, 206)
        Me.Tex_CicloGU05.Name = "Tex_CicloGU05"
        Me.Tex_CicloGU05.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU05.TabIndex = 547
        Me.Tex_CicloGU05.Text = "Numero de Ciclo"
        Me.Tex_CicloGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU05
        '
        Me.Tex_OrdenTrabajoGU05.AutoSize = True
        Me.Tex_OrdenTrabajoGU05.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU05.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU05.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU05.Location = New System.Drawing.Point(1029, 485)
        Me.Tex_OrdenTrabajoGU05.Name = "Tex_OrdenTrabajoGU05"
        Me.Tex_OrdenTrabajoGU05.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU05.TabIndex = 546
        Me.Tex_OrdenTrabajoGU05.Text = "OT"
        Me.Tex_OrdenTrabajoGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU05
        '
        Me.Tex_CosechaGU05.AutoSize = True
        Me.Tex_CosechaGU05.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU05.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU05.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU05.Location = New System.Drawing.Point(997, 388)
        Me.Tex_CosechaGU05.Name = "Tex_CosechaGU05"
        Me.Tex_CosechaGU05.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU05.TabIndex = 545
        Me.Tex_CosechaGU05.Text = "Cosecha"
        Me.Tex_CosechaGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU05
        '
        Me.Tex_HorasEstimadasGU05.AutoSize = True
        Me.Tex_HorasEstimadasGU05.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU05.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU05.Location = New System.Drawing.Point(929, 298)
        Me.Tex_HorasEstimadasGU05.Name = "Tex_HorasEstimadasGU05"
        Me.Tex_HorasEstimadasGU05.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU05.TabIndex = 544
        Me.Tex_HorasEstimadasGU05.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU05
        '
        Me.Tex_HorasProcesoGU05.AutoSize = True
        Me.Tex_HorasProcesoGU05.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU05.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU05.Location = New System.Drawing.Point(450, 57)
        Me.Tex_HorasProcesoGU05.Name = "Tex_HorasProcesoGU05"
        Me.Tex_HorasProcesoGU05.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU05.TabIndex = 543
        Me.Tex_HorasProcesoGU05.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola5
        '
        Me.TexGuardiola5.AutoSize = True
        Me.TexGuardiola5.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola5.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola5.Location = New System.Drawing.Point(679, 58)
        Me.TexGuardiola5.Name = "TexGuardiola5"
        Me.TexGuardiola5.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola5.TabIndex = 542
        Me.TexGuardiola5.Text = "Guardiola 05"
        '
        'TexTempGU05
        '
        Me.TexTempGU05.AutoSize = True
        Me.TexTempGU05.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU05.Location = New System.Drawing.Point(602, 321)
        Me.TexTempGU05.Name = "TexTempGU05"
        Me.TexTempGU05.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU05.TabIndex = 541
        Me.TexTempGU05.Text = "Temperatura °C"
        Me.TexTempGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU05
        '
        Me.TexPID_GU05.AutoSize = True
        Me.TexPID_GU05.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU05.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU05.Location = New System.Drawing.Point(205, 77)
        Me.TexPID_GU05.Name = "TexPID_GU05"
        Me.TexPID_GU05.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU05.TabIndex = 540
        Me.TexPID_GU05.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU05
        '
        Me.TexBN_SalidaGU05.AutoSize = True
        Me.TexBN_SalidaGU05.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU05.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU05.Location = New System.Drawing.Point(351, 138)
        Me.TexBN_SalidaGU05.Name = "TexBN_SalidaGU05"
        Me.TexBN_SalidaGU05.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU05.TabIndex = 539
        Me.TexBN_SalidaGU05.Text = "Salida"
        Me.TexBN_SalidaGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU05
        '
        Me.TexBN_RealTempGU05.AutoSize = True
        Me.TexBN_RealTempGU05.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU05.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU05.Location = New System.Drawing.Point(288, 139)
        Me.TexBN_RealTempGU05.Name = "TexBN_RealTempGU05"
        Me.TexBN_RealTempGU05.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU05.TabIndex = 538
        Me.TexBN_RealTempGU05.Text = "Real"
        Me.TexBN_RealTempGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU05
        '
        Me.TexBN_SP_TempGU05.AutoSize = True
        Me.TexBN_SP_TempGU05.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU05.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU05.Location = New System.Drawing.Point(202, 139)
        Me.TexBN_SP_TempGU05.Name = "TexBN_SP_TempGU05"
        Me.TexBN_SP_TempGU05.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU05.TabIndex = 537
        Me.TexBN_SP_TempGU05.Text = "SetPoint"
        Me.TexBN_SP_TempGU05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU05
        '
        Me.IGU05.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IGU05.Location = New System.Drawing.Point(441, 312)
        Me.IGU05.Name = "IGU05"
        Me.IGU05.Size = New System.Drawing.Size(541, 274)
        Me.IGU05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU05.TabIndex = 564
        Me.IGU05.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola05
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 55)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 566
        '
        'Guardiola_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU05)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU05)
        Me.Controls.Add(Me.BCF_MenúP_GU05)
        Me.Controls.Add(Me.BP_FinCicloGU05)
        Me.Controls.Add(Me.BP_INICIO_CICLO_SGU05)
        Me.Controls.Add(Me.BCF_RegresarGU05)
        Me.Controls.Add(Me.BP_DescargaGU05)
        Me.Controls.Add(Me.BP_CofirDescagaGU05)
        Me.Controls.Add(Me.BN_SalidaGU05)
        Me.Controls.Add(Me.BN_SP_TempGU05)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU05)
        Me.Controls.Add(Me.MD_CosechaGU05)
        Me.Controls.Add(Me.MD_HorasEstimadasGU05)
        Me.Controls.Add(Me.MD_CicloGU05)
        Me.Controls.Add(Me.TexCicloGU05)
        Me.Controls.Add(Me.MD_TempGU05)
        Me.Controls.Add(Me.MD_HorasProcesoGU05)
        Me.Controls.Add(Me.Tex_CicloGU05)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU05)
        Me.Controls.Add(Me.Tex_CosechaGU05)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU05)
        Me.Controls.Add(Me.Tex_HorasProcesoGU05)
        Me.Controls.Add(Me.TexGuardiola5)
        Me.Controls.Add(Me.TexTempGU05)
        Me.Controls.Add(Me.TexPID_GU05)
        Me.Controls.Add(Me.TexBN_SalidaGU05)
        Me.Controls.Add(Me.TexBN_RealTempGU05)
        Me.Controls.Add(Me.TexBN_SP_TempGU05)
        Me.Controls.Add(Me.IGU05)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU05, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU05 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola05 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU05 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU05 As FormChangeButton
    Friend WithEvents BP_FinCicloGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_INICIO_CICLO_SGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU05 As FormChangeButton
    Friend WithEvents BP_DescargaGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU05 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU05 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU05 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU05 As Label
    Friend WithEvents Tex_OrdenTrabajoGU05 As Label
    Friend WithEvents Tex_CosechaGU05 As Label
    Friend WithEvents Tex_HorasEstimadasGU05 As Label
    Friend WithEvents Tex_HorasProcesoGU05 As Label
    Friend WithEvents TexGuardiola5 As Label
    Friend WithEvents TexTempGU05 As Label
    Friend WithEvents TexPID_GU05 As Label
    Friend WithEvents TexBN_SalidaGU05 As Label
    Friend WithEvents TexBN_RealTempGU05 As Label
    Friend WithEvents TexBN_SP_TempGU05 As Label
    Friend WithEvents IGU05 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
