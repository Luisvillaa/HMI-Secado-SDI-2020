<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_01))
        Me.CT_SGU01 = New AdvancedHMIControls.TempController()
        Me.Guardiola01 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU01 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU01 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU01 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU01 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU01 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU01 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU01 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU01 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU01 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU01 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU01 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU01 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU01 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU01 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU01 = New System.Windows.Forms.Label()
        Me.TexGuardiola1 = New System.Windows.Forms.Label()
        Me.TexTempGU01 = New System.Windows.Forms.Label()
        Me.TexPID_GU01 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU01 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU01 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU01 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        Me.IGU01 = New System.Windows.Forms.PictureBox()
        CType(Me.Guardiola01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.IGU01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CT_SGU01
        '
        Me.CT_SGU01.Button1Text = Nothing
        Me.CT_SGU01.Button2Text = Nothing
        Me.CT_SGU01.ComComponent = Me.Guardiola01
        Me.CT_SGU01.DecimalPosition = 1
        Me.CT_SGU01.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU01.Location = New System.Drawing.Point(204, 433)
        Me.CT_SGU01.Name = "CT_SGU01"
        Me.CT_SGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU01.PLCAddressClick1 = ""
        Me.CT_SGU01.PLCAddressClick2 = ""
        Me.CT_SGU01.PLCAddressClick3 = ""
        Me.CT_SGU01.PLCAddressClick4 = ""
        Me.CT_SGU01.PLCAddressText = ""
        Me.CT_SGU01.PLCAddressValuePV = "PID_SGU01.PV"
        Me.CT_SGU01.PLCAddressValueSP = "PID_SGU01.SP"
        Me.CT_SGU01.PLCAddressVisible = ""
        Me.CT_SGU01.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU01.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU01.TabIndex = 506
        Me.CT_SGU01.Text = "S-GU-01"
        Me.CT_SGU01.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU01.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU01.Value2Text = "SP"
        Me.CT_SGU01.ValuePV = 0!
        Me.CT_SGU01.ValueSP = 0!
        '
        'Guardiola01
        '
        Me.Guardiola01.CIPConnectionSize = 508
        Me.Guardiola01.DisableMultiServiceRequest = False
        Me.Guardiola01.DisableSubscriptions = False
        Me.Guardiola01.IniFileName = ""
        Me.Guardiola01.IniFileSection = Nothing
        Me.Guardiola01.IPAddress = "10.1.108.18"
        Me.Guardiola01.PollRateOverride = 500
        Me.Guardiola01.Port = 44818
        Me.Guardiola01.ProcessorSlot = 0
        Me.Guardiola01.RoutePath = Nothing
        Me.Guardiola01.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola01
        Me.BarMeter1.HighlightColor = System.Drawing.Color.Red
        Me.BarMeter1.IniFileName = ""
        Me.BarMeter1.IniFileSection = Nothing
        Me.BarMeter1.Location = New System.Drawing.Point(95, 104)
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
        Me.BasicButton1.ComComponent = Me.Guardiola01
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
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU01"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 504
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU01
        '
        Me.LS_MarchaGU01.Blink = False
        Me.LS_MarchaGU01.ComComponent = Me.Guardiola01
        Me.LS_MarchaGU01.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU01.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU01.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU01.Location = New System.Drawing.Point(857, 325)
        Me.LS_MarchaGU01.Name = "LS_MarchaGU01"
        Me.LS_MarchaGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU01.PLCAddressClick = ""
        Me.LS_MarchaGU01.PLCAddressText = ""
        Me.LS_MarchaGU01.PLCAddressValue = "MARCHA_SGU01"
        Me.LS_MarchaGU01.PLCAddressVisible = ""
        Me.LS_MarchaGU01.Size = New System.Drawing.Size(50, 53)
        Me.LS_MarchaGU01.TabIndex = 502
        Me.LS_MarchaGU01.Value = False
        Me.LS_MarchaGU01.ValueToWrite = 0
        '
        'BCF_MenúP_GU01
        '
        Me.BCF_MenúP_GU01.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU01.ComComponent = Nothing
        Me.BCF_MenúP_GU01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU01.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU01.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU01.KeypadWidth = 300
        Me.BCF_MenúP_GU01.Location = New System.Drawing.Point(228, 645)
        Me.BCF_MenúP_GU01.Name = "BCF_MenúP_GU01"
        Me.BCF_MenúP_GU01.Passcode = Nothing
        Me.BCF_MenúP_GU01.PasswordChar = False
        Me.BCF_MenúP_GU01.PLCAddressVisible = ""
        Me.BCF_MenúP_GU01.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU01.TabIndex = 501
        Me.BCF_MenúP_GU01.Text = "Menú Principal"
        Me.BCF_MenúP_GU01.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU01
        '
        Me.BP_FinCicloGU01.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU01.ComComponent = Me.Guardiola01
        Me.BP_FinCicloGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU01.Highlight = False
        Me.BP_FinCicloGU01.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU01.Location = New System.Drawing.Point(711, 218)
        Me.BP_FinCicloGU01.MaximumHoldTime = 3000
        Me.BP_FinCicloGU01.MinimumHoldTime = 500
        Me.BP_FinCicloGU01.Name = "BP_FinCicloGU01"
        Me.BP_FinCicloGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU01.PLCAddressClick = "BP_DETENER_CICLO_SGU01"
        Me.BP_FinCicloGU01.SelectTextAlternate = False
        Me.BP_FinCicloGU01.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU01.TabIndex = 500
        Me.BP_FinCicloGU01.Text = "Detener Ciclo"
        Me.BP_FinCicloGU01.TextAlternate = Nothing
        Me.BP_FinCicloGU01.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU01.ValueToWrite = 0
        '
        'BP_IniCicloGU01
        '
        Me.BP_IniCicloGU01.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU01.ComComponent = Me.Guardiola01
        Me.BP_IniCicloGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU01.Highlight = False
        Me.BP_IniCicloGU01.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU01.Location = New System.Drawing.Point(509, 218)
        Me.BP_IniCicloGU01.MaximumHoldTime = 3000
        Me.BP_IniCicloGU01.MinimumHoldTime = 500
        Me.BP_IniCicloGU01.Name = "BP_IniCicloGU01"
        Me.BP_IniCicloGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU01.PLCAddressClick = "BP_INICIO_CICLO_SGU01"
        Me.BP_IniCicloGU01.SelectTextAlternate = False
        Me.BP_IniCicloGU01.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU01.TabIndex = 499
        Me.BP_IniCicloGU01.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU01.TextAlternate = Nothing
        Me.BP_IniCicloGU01.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU01.ValueToWrite = 0
        '
        'BCF_RegresarGU01
        '
        Me.BCF_RegresarGU01.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU01.ComComponent = Nothing
        Me.BCF_RegresarGU01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU01.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU01.FormToOpen = Nothing
        Me.BCF_RegresarGU01.KeypadWidth = 300
        Me.BCF_RegresarGU01.Location = New System.Drawing.Point(646, 101)
        Me.BCF_RegresarGU01.Name = "BCF_RegresarGU01"
        Me.BCF_RegresarGU01.Passcode = Nothing
        Me.BCF_RegresarGU01.PasswordChar = False
        Me.BCF_RegresarGU01.PLCAddressVisible = ""
        Me.BCF_RegresarGU01.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU01.TabIndex = 498
        Me.BCF_RegresarGU01.Text = "Regresar"
        Me.BCF_RegresarGU01.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU01
        '
        Me.BP_DescargaGU01.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU01.ComComponent = Me.Guardiola01
        Me.BP_DescargaGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU01.Highlight = False
        Me.BP_DescargaGU01.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU01.Location = New System.Drawing.Point(961, 124)
        Me.BP_DescargaGU01.MaximumHoldTime = 3000
        Me.BP_DescargaGU01.MinimumHoldTime = 500
        Me.BP_DescargaGU01.Name = "BP_DescargaGU01"
        Me.BP_DescargaGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU01.PLCAddressClick = "BP_FINALIZAR_SGU01"
        Me.BP_DescargaGU01.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU01"
        Me.BP_DescargaGU01.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU01"
        Me.BP_DescargaGU01.SelectTextAlternate = False
        Me.BP_DescargaGU01.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU01.TabIndex = 497
        Me.BP_DescargaGU01.Text = "Finalizar"
        Me.BP_DescargaGU01.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU01.UseVisualStyleBackColor = False
        Me.BP_DescargaGU01.ValueToWrite = 0
        '
        'BP_CofirDescagaGU01
        '
        Me.BP_CofirDescagaGU01.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU01.ComComponent = Me.Guardiola01
        Me.BP_CofirDescagaGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU01.Highlight = False
        Me.BP_CofirDescagaGU01.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU01.Location = New System.Drawing.Point(961, 65)
        Me.BP_CofirDescagaGU01.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU01.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU01.Name = "BP_CofirDescagaGU01"
        Me.BP_CofirDescagaGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU01.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU01"
        Me.BP_CofirDescagaGU01.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU01"
        Me.BP_CofirDescagaGU01.SelectTextAlternate = False
        Me.BP_CofirDescagaGU01.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU01.TabIndex = 496
        Me.BP_CofirDescagaGU01.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU01.TextAlternate = Nothing
        Me.BP_CofirDescagaGU01.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU01.ValueToWrite = 0
        '
        'BN_SalidaGU01
        '
        Me.BN_SalidaGU01.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU01.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU01.ComComponent = Me.Guardiola01
        Me.BN_SalidaGU01.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU01.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU01.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU01.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU01.Location = New System.Drawing.Point(358, 157)
        Me.BN_SalidaGU01.Maximum = 100.0R
        Me.BN_SalidaGU01.Minimum = 0R
        Me.BN_SalidaGU01.Name = "BN_SalidaGU01"
        Me.BN_SalidaGU01.NumericFormat = Nothing
        Me.BN_SalidaGU01.PLCAddressValue = "PID_SGU01.OUT"
        Me.BN_SalidaGU01.ShowValue = True
        Me.BN_SalidaGU01.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU01.TabIndex = 495
        Me.BN_SalidaGU01.Text = "BarLevel3"
        Me.BN_SalidaGU01.TextSuffix = Nothing
        Me.BN_SalidaGU01.Value = 0R
        Me.BN_SalidaGU01.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU01
        '
        Me.BN_SP_TempGU01.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU01.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU01.ComComponent = Me.Guardiola01
        Me.BN_SP_TempGU01.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU01.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU01.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU01.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU01.Location = New System.Drawing.Point(216, 158)
        Me.BN_SP_TempGU01.Maximum = 100.0R
        Me.BN_SP_TempGU01.Minimum = 0R
        Me.BN_SP_TempGU01.Name = "BN_SP_TempGU01"
        Me.BN_SP_TempGU01.NumericFormat = Nothing
        Me.BN_SP_TempGU01.PLCAddressValue = "PID_SGU01.SP"
        Me.BN_SP_TempGU01.ShowValue = True
        Me.BN_SP_TempGU01.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU01.TabIndex = 494
        Me.BN_SP_TempGU01.Text = "BarLevel1"
        Me.BN_SP_TempGU01.TextSuffix = Nothing
        Me.BN_SP_TempGU01.Value = 0R
        Me.BN_SP_TempGU01.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU01
        '
        Me.MD_OrdenTrabajoGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU01.ComComponent = Me.Guardiola01
        Me.MD_OrdenTrabajoGU01.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU01.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU01.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU01.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU01.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU01.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU01.Location = New System.Drawing.Point(989, 508)
        Me.MD_OrdenTrabajoGU01.Name = "MD_OrdenTrabajoGU01"
        Me.MD_OrdenTrabajoGU01.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU01.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU01"
        Me.MD_OrdenTrabajoGU01.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU01"
        Me.MD_OrdenTrabajoGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU01.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU01.TabIndex = 493
        Me.MD_OrdenTrabajoGU01.Value = 0R
        Me.MD_OrdenTrabajoGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU01
        '
        Me.MD_CosechaGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU01.ComComponent = Me.Guardiola01
        Me.MD_CosechaGU01.DecimalPosition = 0
        Me.MD_CosechaGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU01.KeypadMaxValue = 0R
        Me.MD_CosechaGU01.KeypadMinValue = 0R
        Me.MD_CosechaGU01.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU01.KeypadText = Nothing
        Me.MD_CosechaGU01.KeypadWidth = 300
        Me.MD_CosechaGU01.Location = New System.Drawing.Point(989, 411)
        Me.MD_CosechaGU01.Name = "MD_CosechaGU01"
        Me.MD_CosechaGU01.NumberOfDigits = 5
        Me.MD_CosechaGU01.PLCAddressKeypad = ""
        Me.MD_CosechaGU01.PLCAddressValue = "COSECHA_SGU01"
        Me.MD_CosechaGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU01.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU01.TabIndex = 492
        Me.MD_CosechaGU01.Value = 0R
        Me.MD_CosechaGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU01
        '
        Me.MD_HorasEstimadasGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU01.ComComponent = Me.Guardiola01
        Me.MD_HorasEstimadasGU01.DecimalPosition = 0
        Me.MD_HorasEstimadasGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU01.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU01.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU01.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU01.KeypadText = Nothing
        Me.MD_HorasEstimadasGU01.KeypadWidth = 300
        Me.MD_HorasEstimadasGU01.Location = New System.Drawing.Point(989, 318)
        Me.MD_HorasEstimadasGU01.Name = "MD_HorasEstimadasGU01"
        Me.MD_HorasEstimadasGU01.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU01.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU01"
        Me.MD_HorasEstimadasGU01.PLCAddressValue = "TIEMPO_ESTIMADO_SGU01"
        Me.MD_HorasEstimadasGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU01.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU01.TabIndex = 491
        Me.MD_HorasEstimadasGU01.Value = 0R
        Me.MD_HorasEstimadasGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU01
        '
        Me.MD_CicloGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU01.ComComponent = Me.Guardiola01
        Me.MD_CicloGU01.DecimalPosition = 0
        Me.MD_CicloGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU01.KeypadMaxValue = 0R
        Me.MD_CicloGU01.KeypadMinValue = 0R
        Me.MD_CicloGU01.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU01.KeypadText = Nothing
        Me.MD_CicloGU01.KeypadWidth = 300
        Me.MD_CicloGU01.Location = New System.Drawing.Point(989, 226)
        Me.MD_CicloGU01.Name = "MD_CicloGU01"
        Me.MD_CicloGU01.NumberOfDigits = 5
        Me.MD_CicloGU01.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU01"
        Me.MD_CicloGU01.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU01"
        Me.MD_CicloGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU01.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU01.TabIndex = 490
        Me.MD_CicloGU01.Value = 0R
        Me.MD_CicloGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU01
        '
        Me.TexCicloGU01.AutoSize = True
        Me.TexCicloGU01.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU01.ComComponent = Me.Guardiola01
        Me.TexCicloGU01.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU01.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU01.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU01.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU01.HighlightKeyCharacter = "!"
        Me.TexCicloGU01.HighlightKeyCharacter2 = "."
        Me.TexCicloGU01.IniFileName = Nothing
        Me.TexCicloGU01.Location = New System.Drawing.Point(586, 531)
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Messages.Add(CType(resources.GetObject("TexCicloGU01.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU01.Name = "TexCicloGU01"
        Me.TexCicloGU01.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU01"
        Me.TexCicloGU01.PLCAddressVisible = ""
        Me.TexCicloGU01.ShowMessageNumber = False
        Me.TexCicloGU01.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU01.SpeakMessage = False
        Me.TexCicloGU01.TabIndex = 503
        Me.TexCicloGU01.Text = "No Seleccionado"
        Me.TexCicloGU01.TextPrefix = Nothing
        Me.TexCicloGU01.Value = 0
        '
        'MD_TempGU01
        '
        Me.MD_TempGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU01.ComComponent = Me.Guardiola01
        Me.MD_TempGU01.DecimalPosition = 1
        Me.MD_TempGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU01.KeypadMaxValue = 0R
        Me.MD_TempGU01.KeypadMinValue = 0R
        Me.MD_TempGU01.KeypadScaleFactor = 1.0R
        Me.MD_TempGU01.KeypadText = Nothing
        Me.MD_TempGU01.KeypadWidth = 300
        Me.MD_TempGU01.Location = New System.Drawing.Point(608, 348)
        Me.MD_TempGU01.Name = "MD_TempGU01"
        Me.MD_TempGU01.NumberOfDigits = 5
        Me.MD_TempGU01.PLCAddressKeypad = ""
        Me.MD_TempGU01.PLCAddressValue = "PID_SGU01.PV"
        Me.MD_TempGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU01.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU01.TabIndex = 489
        Me.MD_TempGU01.Value = 0R
        Me.MD_TempGU01.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU01
        '
        Me.MD_HorasProcesoGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU01.ComComponent = Me.Guardiola01
        Me.MD_HorasProcesoGU01.DecimalPosition = 0
        Me.MD_HorasProcesoGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU01.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU01.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU01.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU01.KeypadText = Nothing
        Me.MD_HorasProcesoGU01.KeypadWidth = 300
        Me.MD_HorasProcesoGU01.Location = New System.Drawing.Point(466, 84)
        Me.MD_HorasProcesoGU01.Name = "MD_HorasProcesoGU01"
        Me.MD_HorasProcesoGU01.NumberOfDigits = 5
        Me.MD_HorasProcesoGU01.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU01.PLCAddressValue = "TIEMPO_SECADO_SGU01"
        Me.MD_HorasProcesoGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU01.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU01.TabIndex = 488
        Me.MD_HorasProcesoGU01.Value = 0R
        Me.MD_HorasProcesoGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU01
        '
        Me.Tex_CicloGU01.AutoSize = True
        Me.Tex_CicloGU01.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU01.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU01.Location = New System.Drawing.Point(976, 204)
        Me.Tex_CicloGU01.Name = "Tex_CicloGU01"
        Me.Tex_CicloGU01.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU01.TabIndex = 487
        Me.Tex_CicloGU01.Text = "Numero de Ciclo"
        Me.Tex_CicloGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU01
        '
        Me.Tex_OrdenTrabajoGU01.AutoSize = True
        Me.Tex_OrdenTrabajoGU01.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU01.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU01.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU01.Location = New System.Drawing.Point(1029, 483)
        Me.Tex_OrdenTrabajoGU01.Name = "Tex_OrdenTrabajoGU01"
        Me.Tex_OrdenTrabajoGU01.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU01.TabIndex = 486
        Me.Tex_OrdenTrabajoGU01.Text = "OT"
        Me.Tex_OrdenTrabajoGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU01
        '
        Me.Tex_CosechaGU01.AutoSize = True
        Me.Tex_CosechaGU01.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU01.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU01.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU01.Location = New System.Drawing.Point(997, 386)
        Me.Tex_CosechaGU01.Name = "Tex_CosechaGU01"
        Me.Tex_CosechaGU01.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU01.TabIndex = 485
        Me.Tex_CosechaGU01.Text = "Cosecha"
        Me.Tex_CosechaGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU01
        '
        Me.Tex_HorasEstimadasGU01.AutoSize = True
        Me.Tex_HorasEstimadasGU01.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU01.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU01.Location = New System.Drawing.Point(929, 296)
        Me.Tex_HorasEstimadasGU01.Name = "Tex_HorasEstimadasGU01"
        Me.Tex_HorasEstimadasGU01.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU01.TabIndex = 484
        Me.Tex_HorasEstimadasGU01.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU01
        '
        Me.Tex_HorasProcesoGU01.AutoSize = True
        Me.Tex_HorasProcesoGU01.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU01.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU01.Location = New System.Drawing.Point(450, 55)
        Me.Tex_HorasProcesoGU01.Name = "Tex_HorasProcesoGU01"
        Me.Tex_HorasProcesoGU01.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU01.TabIndex = 483
        Me.Tex_HorasProcesoGU01.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola1
        '
        Me.TexGuardiola1.AutoSize = True
        Me.TexGuardiola1.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola1.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola1.Location = New System.Drawing.Point(679, 56)
        Me.TexGuardiola1.Name = "TexGuardiola1"
        Me.TexGuardiola1.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola1.TabIndex = 482
        Me.TexGuardiola1.Text = "Guardiola 01"
        '
        'TexTempGU01
        '
        Me.TexTempGU01.AutoSize = True
        Me.TexTempGU01.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU01.Location = New System.Drawing.Point(605, 327)
        Me.TexTempGU01.Name = "TexTempGU01"
        Me.TexTempGU01.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU01.TabIndex = 481
        Me.TexTempGU01.Text = "Temperatura °C"
        Me.TexTempGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU01
        '
        Me.TexPID_GU01.AutoSize = True
        Me.TexPID_GU01.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU01.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU01.Location = New System.Drawing.Point(201, 75)
        Me.TexPID_GU01.Name = "TexPID_GU01"
        Me.TexPID_GU01.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU01.TabIndex = 479
        Me.TexPID_GU01.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU01
        '
        Me.TexBN_SalidaGU01.AutoSize = True
        Me.TexBN_SalidaGU01.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU01.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU01.Location = New System.Drawing.Point(355, 136)
        Me.TexBN_SalidaGU01.Name = "TexBN_SalidaGU01"
        Me.TexBN_SalidaGU01.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU01.TabIndex = 478
        Me.TexBN_SalidaGU01.Text = "Salida"
        Me.TexBN_SalidaGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU01
        '
        Me.TexBN_RealTempGU01.AutoSize = True
        Me.TexBN_RealTempGU01.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU01.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU01.Location = New System.Drawing.Point(288, 137)
        Me.TexBN_RealTempGU01.Name = "TexBN_RealTempGU01"
        Me.TexBN_RealTempGU01.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU01.TabIndex = 477
        Me.TexBN_RealTempGU01.Text = "Real"
        Me.TexBN_RealTempGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU01
        '
        Me.TexBN_SP_TempGU01.AutoSize = True
        Me.TexBN_SP_TempGU01.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU01.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU01.Location = New System.Drawing.Point(202, 137)
        Me.TexBN_SP_TempGU01.Name = "TexBN_SP_TempGU01"
        Me.TexBN_SP_TempGU01.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU01.TabIndex = 476
        Me.TexBN_SP_TempGU01.Text = "SetPoint"
        Me.TexBN_SP_TempGU01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola01
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 53)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 505
        '
        'IGU01
        '
        Me.IGU01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IGU01.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU01.Location = New System.Drawing.Point(442, 314)
        Me.IGU01.Name = "IGU01"
        Me.IGU01.Size = New System.Drawing.Size(541, 274)
        Me.IGU01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU01.TabIndex = 480
        Me.IGU01.TabStop = False
        '
        'Guardiola_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU01)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU01)
        Me.Controls.Add(Me.BCF_MenúP_GU01)
        Me.Controls.Add(Me.BP_FinCicloGU01)
        Me.Controls.Add(Me.BP_IniCicloGU01)
        Me.Controls.Add(Me.BCF_RegresarGU01)
        Me.Controls.Add(Me.BP_DescargaGU01)
        Me.Controls.Add(Me.BP_CofirDescagaGU01)
        Me.Controls.Add(Me.BN_SalidaGU01)
        Me.Controls.Add(Me.BN_SP_TempGU01)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU01)
        Me.Controls.Add(Me.MD_CosechaGU01)
        Me.Controls.Add(Me.MD_HorasEstimadasGU01)
        Me.Controls.Add(Me.MD_CicloGU01)
        Me.Controls.Add(Me.TexCicloGU01)
        Me.Controls.Add(Me.MD_TempGU01)
        Me.Controls.Add(Me.MD_HorasProcesoGU01)
        Me.Controls.Add(Me.Tex_CicloGU01)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU01)
        Me.Controls.Add(Me.Tex_CosechaGU01)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU01)
        Me.Controls.Add(Me.Tex_HorasProcesoGU01)
        Me.Controls.Add(Me.TexGuardiola1)
        Me.Controls.Add(Me.TexTempGU01)
        Me.Controls.Add(Me.IGU01)
        Me.Controls.Add(Me.TexPID_GU01)
        Me.Controls.Add(Me.TexBN_SalidaGU01)
        Me.Controls.Add(Me.TexBN_RealTempGU01)
        Me.Controls.Add(Me.TexBN_SP_TempGU01)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.IGU01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU01 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola01 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU01 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU01 As FormChangeButton
    Friend WithEvents BP_FinCicloGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU01 As FormChangeButton
    Friend WithEvents BP_DescargaGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU01 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU01 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU01 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU01 As Label
    Friend WithEvents Tex_OrdenTrabajoGU01 As Label
    Friend WithEvents Tex_CosechaGU01 As Label
    Friend WithEvents Tex_HorasEstimadasGU01 As Label
    Friend WithEvents Tex_HorasProcesoGU01 As Label
    Friend WithEvents TexGuardiola1 As Label
    Friend WithEvents TexTempGU01 As Label
    Friend WithEvents IGU01 As PictureBox
    Friend WithEvents TexPID_GU01 As Label
    Friend WithEvents TexBN_SalidaGU01 As Label
    Friend WithEvents TexBN_RealTempGU01 As Label
    Friend WithEvents TexBN_SP_TempGU01 As Label
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
