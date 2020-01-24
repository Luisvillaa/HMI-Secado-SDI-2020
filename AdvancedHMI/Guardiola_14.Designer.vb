<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_14))
        Me.CT_SGU14 = New AdvancedHMIControls.TempController()
        Me.Guardiola14 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU14 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU14 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU14 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU14 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU14 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU14 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU14 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU14 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU14 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU14 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU14 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU14 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU14 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU14 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU14 = New System.Windows.Forms.Label()
        Me.TexGuardiola14 = New System.Windows.Forms.Label()
        Me.TexTempGU14 = New System.Windows.Forms.Label()
        Me.TexPID_GU14 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU14 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU14 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU14 = New System.Windows.Forms.Label()
        Me.IGU14 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU14
        '
        Me.CT_SGU14.Button1Text = Nothing
        Me.CT_SGU14.Button2Text = Nothing
        Me.CT_SGU14.ComComponent = Me.Guardiola14
        Me.CT_SGU14.DecimalPosition = 1
        Me.CT_SGU14.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU14.Location = New System.Drawing.Point(203, 431)
        Me.CT_SGU14.Name = "CT_SGU14"
        Me.CT_SGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU14.PLCAddressClick1 = ""
        Me.CT_SGU14.PLCAddressClick2 = ""
        Me.CT_SGU14.PLCAddressClick3 = ""
        Me.CT_SGU14.PLCAddressClick4 = ""
        Me.CT_SGU14.PLCAddressText = ""
        Me.CT_SGU14.PLCAddressValuePV = "PID_GUARDIOLA7.PV"
        Me.CT_SGU14.PLCAddressValueSP = "PID_GUARDIOLA7.SP"
        Me.CT_SGU14.PLCAddressVisible = ""
        Me.CT_SGU14.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU14.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU14.TabIndex = 687
        Me.CT_SGU14.Text = "S-GU-14"
        Me.CT_SGU14.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU14.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU14.Value2Text = "SP"
        Me.CT_SGU14.ValuePV = 0!
        Me.CT_SGU14.ValueSP = 0!
        '
        'Guardiola14
        '
        Me.Guardiola14.CIPConnectionSize = 508
        Me.Guardiola14.DisableMultiServiceRequest = False
        Me.Guardiola14.DisableSubscriptions = False
        Me.Guardiola14.IniFileName = ""
        Me.Guardiola14.IniFileSection = Nothing
        Me.Guardiola14.IPAddress = "10.1.108.20"
        Me.Guardiola14.PollRateOverride = 500
        Me.Guardiola14.Port = 44818
        Me.Guardiola14.ProcessorSlot = 0
        Me.Guardiola14.RoutePath = Nothing
        Me.Guardiola14.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola14
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
        Me.BasicButton1.ComComponent = Me.Guardiola14
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(961, 588)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA07"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 685
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU14
        '
        Me.LS_MarchaGU14.Blink = False
        Me.LS_MarchaGU14.ComComponent = Me.Guardiola14
        Me.LS_MarchaGU14.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU14.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU14.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU14.Location = New System.Drawing.Point(854, 316)
        Me.LS_MarchaGU14.Name = "LS_MarchaGU14"
        Me.LS_MarchaGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU14.PLCAddressClick = ""
        Me.LS_MarchaGU14.PLCAddressText = ""
        Me.LS_MarchaGU14.PLCAddressValue = "MARCHA_GU14"
        Me.LS_MarchaGU14.PLCAddressVisible = ""
        Me.LS_MarchaGU14.Size = New System.Drawing.Size(52, 55)
        Me.LS_MarchaGU14.TabIndex = 682
        Me.LS_MarchaGU14.Value = False
        Me.LS_MarchaGU14.ValueToWrite = 0
        '
        'BCF_MenúP_GU14
        '
        Me.BCF_MenúP_GU14.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU14.ComComponent = Nothing
        Me.BCF_MenúP_GU14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU14.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU14.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU14.KeypadWidth = 300
        Me.BCF_MenúP_GU14.Location = New System.Drawing.Point(226, 647)
        Me.BCF_MenúP_GU14.Name = "BCF_MenúP_GU14"
        Me.BCF_MenúP_GU14.Passcode = Nothing
        Me.BCF_MenúP_GU14.PasswordChar = False
        Me.BCF_MenúP_GU14.PLCAddressVisible = ""
        Me.BCF_MenúP_GU14.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU14.TabIndex = 681
        Me.BCF_MenúP_GU14.Text = "Menú Principal"
        Me.BCF_MenúP_GU14.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU14
        '
        Me.BP_FinCicloGU14.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU14.ComComponent = Me.Guardiola14
        Me.BP_FinCicloGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU14.Highlight = False
        Me.BP_FinCicloGU14.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU14.Location = New System.Drawing.Point(711, 216)
        Me.BP_FinCicloGU14.MaximumHoldTime = 3000
        Me.BP_FinCicloGU14.MinimumHoldTime = 500
        Me.BP_FinCicloGU14.Name = "BP_FinCicloGU14"
        Me.BP_FinCicloGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU14.PLCAddressClick = "BP_FIN_CICLO_GA7"
        Me.BP_FinCicloGU14.SelectTextAlternate = False
        Me.BP_FinCicloGU14.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU14.TabIndex = 680
        Me.BP_FinCicloGU14.Text = "Detener Ciclo"
        Me.BP_FinCicloGU14.TextAlternate = Nothing
        Me.BP_FinCicloGU14.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU14.ValueToWrite = 0
        '
        'BP_IniCicloGU14
        '
        Me.BP_IniCicloGU14.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU14.ComComponent = Me.Guardiola14
        Me.BP_IniCicloGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU14.Highlight = False
        Me.BP_IniCicloGU14.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU14.Location = New System.Drawing.Point(509, 216)
        Me.BP_IniCicloGU14.MaximumHoldTime = 3000
        Me.BP_IniCicloGU14.MinimumHoldTime = 500
        Me.BP_IniCicloGU14.Name = "BP_IniCicloGU14"
        Me.BP_IniCicloGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU14.PLCAddressClick = "BP_ARRANQUE_G7"
        Me.BP_IniCicloGU14.SelectTextAlternate = False
        Me.BP_IniCicloGU14.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU14.TabIndex = 679
        Me.BP_IniCicloGU14.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU14.TextAlternate = Nothing
        Me.BP_IniCicloGU14.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU14.ValueToWrite = 0
        '
        'BCF_RegresarGU14
        '
        Me.BCF_RegresarGU14.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU14.ComComponent = Nothing
        Me.BCF_RegresarGU14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU14.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU14.FormToOpen = Nothing
        Me.BCF_RegresarGU14.KeypadWidth = 300
        Me.BCF_RegresarGU14.Location = New System.Drawing.Point(646, 99)
        Me.BCF_RegresarGU14.Name = "BCF_RegresarGU14"
        Me.BCF_RegresarGU14.Passcode = Nothing
        Me.BCF_RegresarGU14.PasswordChar = False
        Me.BCF_RegresarGU14.PLCAddressVisible = ""
        Me.BCF_RegresarGU14.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU14.TabIndex = 678
        Me.BCF_RegresarGU14.Text = "Regresar"
        Me.BCF_RegresarGU14.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU14
        '
        Me.BP_DescargaGU14.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU14.ComComponent = Me.Guardiola14
        Me.BP_DescargaGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU14.Highlight = False
        Me.BP_DescargaGU14.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU14.Location = New System.Drawing.Point(961, 122)
        Me.BP_DescargaGU14.MaximumHoldTime = 3000
        Me.BP_DescargaGU14.MinimumHoldTime = 500
        Me.BP_DescargaGU14.Name = "BP_DescargaGU14"
        Me.BP_DescargaGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU14.PLCAddressClick = "BP_DESCARGAR_GA7"
        Me.BP_DescargaGU14.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA7"
        Me.BP_DescargaGU14.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA7"
        Me.BP_DescargaGU14.SelectTextAlternate = False
        Me.BP_DescargaGU14.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU14.TabIndex = 677
        Me.BP_DescargaGU14.Text = "Finalizar"
        Me.BP_DescargaGU14.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU14.UseVisualStyleBackColor = True
        Me.BP_DescargaGU14.ValueToWrite = 0
        '
        'BP_CofirDescagaGU14
        '
        Me.BP_CofirDescagaGU14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU14.ComComponent = Me.Guardiola14
        Me.BP_CofirDescagaGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU14.Highlight = False
        Me.BP_CofirDescagaGU14.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU14.Location = New System.Drawing.Point(961, 63)
        Me.BP_CofirDescagaGU14.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU14.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU14.Name = "BP_CofirDescagaGU14"
        Me.BP_CofirDescagaGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU14.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA7"
        Me.BP_CofirDescagaGU14.PLCAddressVisible = "CONFIMAR_DESCARGA_GA7"
        Me.BP_CofirDescagaGU14.SelectTextAlternate = False
        Me.BP_CofirDescagaGU14.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU14.TabIndex = 676
        Me.BP_CofirDescagaGU14.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU14.TextAlternate = Nothing
        Me.BP_CofirDescagaGU14.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU14.ValueToWrite = 0
        '
        'BN_SalidaGU14
        '
        Me.BN_SalidaGU14.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU14.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU14.ComComponent = Me.Guardiola14
        Me.BN_SalidaGU14.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU14.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU14.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU14.Location = New System.Drawing.Point(358, 155)
        Me.BN_SalidaGU14.Maximum = 100.0R
        Me.BN_SalidaGU14.Minimum = 0R
        Me.BN_SalidaGU14.Name = "BN_SalidaGU14"
        Me.BN_SalidaGU14.NumericFormat = Nothing
        Me.BN_SalidaGU14.PLCAddressValue = "PID_GUARDIOLA7.OUT"
        Me.BN_SalidaGU14.ShowValue = True
        Me.BN_SalidaGU14.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU14.TabIndex = 675
        Me.BN_SalidaGU14.Text = "BarLevel3"
        Me.BN_SalidaGU14.TextSuffix = Nothing
        Me.BN_SalidaGU14.Value = 0R
        Me.BN_SalidaGU14.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU14
        '
        Me.BN_SP_TempGU14.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU14.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU14.ComComponent = Me.Guardiola14
        Me.BN_SP_TempGU14.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU14.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU14.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU14.Location = New System.Drawing.Point(216, 156)
        Me.BN_SP_TempGU14.Maximum = 100.0R
        Me.BN_SP_TempGU14.Minimum = 0R
        Me.BN_SP_TempGU14.Name = "BN_SP_TempGU14"
        Me.BN_SP_TempGU14.NumericFormat = Nothing
        Me.BN_SP_TempGU14.PLCAddressValue = "PID_GUARDIOLA7.SP"
        Me.BN_SP_TempGU14.ShowValue = True
        Me.BN_SP_TempGU14.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU14.TabIndex = 674
        Me.BN_SP_TempGU14.Text = "BarLevel1"
        Me.BN_SP_TempGU14.TextSuffix = Nothing
        Me.BN_SP_TempGU14.Value = 0R
        Me.BN_SP_TempGU14.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU14
        '
        Me.MD_OrdenTrabajoGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU14.ComComponent = Me.Guardiola14
        Me.MD_OrdenTrabajoGU14.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU14.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU14.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU14.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU14.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU14.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU14.Location = New System.Drawing.Point(989, 506)
        Me.MD_OrdenTrabajoGU14.Name = "MD_OrdenTrabajoGU14"
        Me.MD_OrdenTrabajoGU14.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU14.PLCAddressKeypad = "ORDEN_DE_CARGA_GA07"
        Me.MD_OrdenTrabajoGU14.PLCAddressValue = "ORDEN_DE_CARGA_GA07"
        Me.MD_OrdenTrabajoGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU14.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU14.TabIndex = 673
        Me.MD_OrdenTrabajoGU14.Value = 0R
        Me.MD_OrdenTrabajoGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU14
        '
        Me.MD_CosechaGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU14.ComComponent = Me.Guardiola14
        Me.MD_CosechaGU14.DecimalPosition = 0
        Me.MD_CosechaGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU14.KeypadMaxValue = 0R
        Me.MD_CosechaGU14.KeypadMinValue = 0R
        Me.MD_CosechaGU14.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU14.KeypadText = Nothing
        Me.MD_CosechaGU14.KeypadWidth = 300
        Me.MD_CosechaGU14.Location = New System.Drawing.Point(989, 409)
        Me.MD_CosechaGU14.Name = "MD_CosechaGU14"
        Me.MD_CosechaGU14.NumberOfDigits = 5
        Me.MD_CosechaGU14.PLCAddressKeypad = "GA07_LOTE_NUMERO"
        Me.MD_CosechaGU14.PLCAddressValue = "GA07_LOTE_NUMERO"
        Me.MD_CosechaGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU14.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU14.TabIndex = 672
        Me.MD_CosechaGU14.Value = 0R
        Me.MD_CosechaGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU14
        '
        Me.MD_HorasEstimadasGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU14.ComComponent = Me.Guardiola14
        Me.MD_HorasEstimadasGU14.DecimalPosition = 0
        Me.MD_HorasEstimadasGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU14.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU14.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU14.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU14.KeypadText = Nothing
        Me.MD_HorasEstimadasGU14.KeypadWidth = 300
        Me.MD_HorasEstimadasGU14.Location = New System.Drawing.Point(989, 316)
        Me.MD_HorasEstimadasGU14.Name = "MD_HorasEstimadasGU14"
        Me.MD_HorasEstimadasGU14.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU14.PLCAddressKeypad = "TIEMPO_SECADO_H_GA7"
        Me.MD_HorasEstimadasGU14.PLCAddressValue = "TIEMPO_SECADO_H_GA7"
        Me.MD_HorasEstimadasGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU14.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU14.TabIndex = 671
        Me.MD_HorasEstimadasGU14.Value = 0R
        Me.MD_HorasEstimadasGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU14
        '
        Me.MD_CicloGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU14.ComComponent = Me.Guardiola14
        Me.MD_CicloGU14.DecimalPosition = 0
        Me.MD_CicloGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU14.KeypadMaxValue = 0R
        Me.MD_CicloGU14.KeypadMinValue = 0R
        Me.MD_CicloGU14.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU14.KeypadText = Nothing
        Me.MD_CicloGU14.KeypadWidth = 300
        Me.MD_CicloGU14.Location = New System.Drawing.Point(989, 224)
        Me.MD_CicloGU14.Name = "MD_CicloGU14"
        Me.MD_CicloGU14.NumberOfDigits = 5
        Me.MD_CicloGU14.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA07"
        Me.MD_CicloGU14.PLCAddressValue = "NUMERO_CICLO_SECADO_GA07"
        Me.MD_CicloGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU14.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU14.TabIndex = 670
        Me.MD_CicloGU14.Value = 0R
        Me.MD_CicloGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU14
        '
        Me.TexCicloGU14.AutoSize = True
        Me.TexCicloGU14.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU14.ComComponent = Me.Guardiola14
        Me.TexCicloGU14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU14.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU14.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU14.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU14.HighlightKeyCharacter = "!"
        Me.TexCicloGU14.HighlightKeyCharacter2 = "."
        Me.TexCicloGU14.IniFileName = Nothing
        Me.TexCicloGU14.Location = New System.Drawing.Point(582, 520)
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Messages.Add(CType(resources.GetObject("TexCicloGU14.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU14.Name = "TexCicloGU14"
        Me.TexCicloGU14.PLCAddressValue = "NUMERO_CICLO_SECADO_GA07"
        Me.TexCicloGU14.PLCAddressVisible = ""
        Me.TexCicloGU14.ShowMessageNumber = False
        Me.TexCicloGU14.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU14.SpeakMessage = False
        Me.TexCicloGU14.TabIndex = 683
        Me.TexCicloGU14.Text = "No Seleccionado"
        Me.TexCicloGU14.TextPrefix = Nothing
        Me.TexCicloGU14.Value = 0
        '
        'MD_TempGU14
        '
        Me.MD_TempGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU14.ComComponent = Me.Guardiola14
        Me.MD_TempGU14.DecimalPosition = 1
        Me.MD_TempGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU14.KeypadMaxValue = 0R
        Me.MD_TempGU14.KeypadMinValue = 0R
        Me.MD_TempGU14.KeypadScaleFactor = 1.0R
        Me.MD_TempGU14.KeypadText = Nothing
        Me.MD_TempGU14.KeypadWidth = 300
        Me.MD_TempGU14.Location = New System.Drawing.Point(604, 335)
        Me.MD_TempGU14.Name = "MD_TempGU14"
        Me.MD_TempGU14.NumberOfDigits = 5
        Me.MD_TempGU14.PLCAddressKeypad = ""
        Me.MD_TempGU14.PLCAddressValue = "PID_GUARDIOLA7.PV"
        Me.MD_TempGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU14.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU14.TabIndex = 669
        Me.MD_TempGU14.Value = 0R
        Me.MD_TempGU14.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU14
        '
        Me.MD_HorasProcesoGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU14.ComComponent = Me.Guardiola14
        Me.MD_HorasProcesoGU14.DecimalPosition = 0
        Me.MD_HorasProcesoGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU14.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU14.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU14.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU14.KeypadText = Nothing
        Me.MD_HorasProcesoGU14.KeypadWidth = 300
        Me.MD_HorasProcesoGU14.Location = New System.Drawing.Point(466, 82)
        Me.MD_HorasProcesoGU14.Name = "MD_HorasProcesoGU14"
        Me.MD_HorasProcesoGU14.NumberOfDigits = 5
        Me.MD_HorasProcesoGU14.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU14.PLCAddressValue = "SECADO_G7_MONITOR"
        Me.MD_HorasProcesoGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU14.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU14.TabIndex = 668
        Me.MD_HorasProcesoGU14.Value = 0R
        Me.MD_HorasProcesoGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU14
        '
        Me.Tex_CicloGU14.AutoSize = True
        Me.Tex_CicloGU14.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU14.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU14.Location = New System.Drawing.Point(976, 202)
        Me.Tex_CicloGU14.Name = "Tex_CicloGU14"
        Me.Tex_CicloGU14.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU14.TabIndex = 667
        Me.Tex_CicloGU14.Text = "Numero de Ciclo"
        Me.Tex_CicloGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU14
        '
        Me.Tex_OrdenTrabajoGU14.AutoSize = True
        Me.Tex_OrdenTrabajoGU14.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU14.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU14.Location = New System.Drawing.Point(1029, 481)
        Me.Tex_OrdenTrabajoGU14.Name = "Tex_OrdenTrabajoGU14"
        Me.Tex_OrdenTrabajoGU14.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU14.TabIndex = 666
        Me.Tex_OrdenTrabajoGU14.Text = "OT"
        Me.Tex_OrdenTrabajoGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU14
        '
        Me.Tex_CosechaGU14.AutoSize = True
        Me.Tex_CosechaGU14.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU14.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU14.Location = New System.Drawing.Point(997, 384)
        Me.Tex_CosechaGU14.Name = "Tex_CosechaGU14"
        Me.Tex_CosechaGU14.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU14.TabIndex = 665
        Me.Tex_CosechaGU14.Text = "Cosecha"
        Me.Tex_CosechaGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU14
        '
        Me.Tex_HorasEstimadasGU14.AutoSize = True
        Me.Tex_HorasEstimadasGU14.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU14.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU14.Location = New System.Drawing.Point(929, 294)
        Me.Tex_HorasEstimadasGU14.Name = "Tex_HorasEstimadasGU14"
        Me.Tex_HorasEstimadasGU14.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU14.TabIndex = 664
        Me.Tex_HorasEstimadasGU14.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU14
        '
        Me.Tex_HorasProcesoGU14.AutoSize = True
        Me.Tex_HorasProcesoGU14.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU14.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU14.Location = New System.Drawing.Point(450, 53)
        Me.Tex_HorasProcesoGU14.Name = "Tex_HorasProcesoGU14"
        Me.Tex_HorasProcesoGU14.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU14.TabIndex = 663
        Me.Tex_HorasProcesoGU14.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola14
        '
        Me.TexGuardiola14.AutoSize = True
        Me.TexGuardiola14.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola14.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola14.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola14.Location = New System.Drawing.Point(679, 54)
        Me.TexGuardiola14.Name = "TexGuardiola14"
        Me.TexGuardiola14.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola14.TabIndex = 662
        Me.TexGuardiola14.Text = "Guardiola 14"
        '
        'TexTempGU14
        '
        Me.TexTempGU14.AutoSize = True
        Me.TexTempGU14.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU14.Location = New System.Drawing.Point(601, 314)
        Me.TexTempGU14.Name = "TexTempGU14"
        Me.TexTempGU14.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU14.TabIndex = 661
        Me.TexTempGU14.Text = "Temperatura °C"
        Me.TexTempGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU14
        '
        Me.TexPID_GU14.AutoSize = True
        Me.TexPID_GU14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU14.Location = New System.Drawing.Point(201, 73)
        Me.TexPID_GU14.Name = "TexPID_GU14"
        Me.TexPID_GU14.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU14.TabIndex = 660
        Me.TexPID_GU14.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU14
        '
        Me.TexBN_SalidaGU14.AutoSize = True
        Me.TexBN_SalidaGU14.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU14.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU14.Location = New System.Drawing.Point(351, 134)
        Me.TexBN_SalidaGU14.Name = "TexBN_SalidaGU14"
        Me.TexBN_SalidaGU14.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU14.TabIndex = 659
        Me.TexBN_SalidaGU14.Text = "Salida"
        Me.TexBN_SalidaGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU14
        '
        Me.TexBN_RealTempGU14.AutoSize = True
        Me.TexBN_RealTempGU14.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU14.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU14.Location = New System.Drawing.Point(286, 135)
        Me.TexBN_RealTempGU14.Name = "TexBN_RealTempGU14"
        Me.TexBN_RealTempGU14.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU14.TabIndex = 658
        Me.TexBN_RealTempGU14.Text = "Real"
        Me.TexBN_RealTempGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU14
        '
        Me.TexBN_SP_TempGU14.AutoSize = True
        Me.TexBN_SP_TempGU14.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU14.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU14.Location = New System.Drawing.Point(202, 135)
        Me.TexBN_SP_TempGU14.Name = "TexBN_SP_TempGU14"
        Me.TexBN_SP_TempGU14.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU14.TabIndex = 657
        Me.TexBN_SP_TempGU14.Text = "SetPoint"
        Me.TexBN_SP_TempGU14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU14
        '
        Me.IGU14.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU14.Location = New System.Drawing.Point(441, 308)
        Me.IGU14.Name = "IGU14"
        Me.IGU14.Size = New System.Drawing.Size(541, 274)
        Me.IGU14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU14.TabIndex = 684
        Me.IGU14.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola14
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(189, 51)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 686
        '
        'Guardiola_14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU14)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU14)
        Me.Controls.Add(Me.BCF_MenúP_GU14)
        Me.Controls.Add(Me.BP_FinCicloGU14)
        Me.Controls.Add(Me.BP_IniCicloGU14)
        Me.Controls.Add(Me.BCF_RegresarGU14)
        Me.Controls.Add(Me.BP_DescargaGU14)
        Me.Controls.Add(Me.BP_CofirDescagaGU14)
        Me.Controls.Add(Me.BN_SalidaGU14)
        Me.Controls.Add(Me.BN_SP_TempGU14)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU14)
        Me.Controls.Add(Me.MD_CosechaGU14)
        Me.Controls.Add(Me.MD_HorasEstimadasGU14)
        Me.Controls.Add(Me.MD_CicloGU14)
        Me.Controls.Add(Me.TexCicloGU14)
        Me.Controls.Add(Me.MD_TempGU14)
        Me.Controls.Add(Me.MD_HorasProcesoGU14)
        Me.Controls.Add(Me.Tex_CicloGU14)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU14)
        Me.Controls.Add(Me.Tex_CosechaGU14)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU14)
        Me.Controls.Add(Me.Tex_HorasProcesoGU14)
        Me.Controls.Add(Me.TexGuardiola14)
        Me.Controls.Add(Me.TexTempGU14)
        Me.Controls.Add(Me.TexPID_GU14)
        Me.Controls.Add(Me.TexBN_SalidaGU14)
        Me.Controls.Add(Me.TexBN_RealTempGU14)
        Me.Controls.Add(Me.TexBN_SP_TempGU14)
        Me.Controls.Add(Me.IGU14)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU14 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola14 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU14 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU14 As FormChangeButton
    Friend WithEvents BP_FinCicloGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU14 As FormChangeButton
    Friend WithEvents BP_DescargaGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU14 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU14 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU14 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU14 As Label
    Friend WithEvents Tex_OrdenTrabajoGU14 As Label
    Friend WithEvents Tex_CosechaGU14 As Label
    Friend WithEvents Tex_HorasEstimadasGU14 As Label
    Friend WithEvents Tex_HorasProcesoGU14 As Label
    Friend WithEvents TexGuardiola14 As Label
    Friend WithEvents TexTempGU14 As Label
    Friend WithEvents TexPID_GU14 As Label
    Friend WithEvents TexBN_SalidaGU14 As Label
    Friend WithEvents TexBN_RealTempGU14 As Label
    Friend WithEvents TexBN_SP_TempGU14 As Label
    Friend WithEvents IGU14 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
