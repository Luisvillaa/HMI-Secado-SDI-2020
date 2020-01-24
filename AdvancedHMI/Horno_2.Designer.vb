<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horno_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horno_2))
        Me.CT_SHO02 = New AdvancedHMIControls.TempController()
        Me.Horno2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.LT_Horno2 = New AdvancedHMIControls.StackLight()
        Me.BP_ParoHorno2 = New AdvancedHMIControls.MomentaryButton()
        Me.BP_MarchaHorno2 = New AdvancedHMIControls.MomentaryButton()
        Me.TexRecetaHorno2 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempMul2H2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempMul1H2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempChimeH2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CargaHorno2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CascarillaXMminuH2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempHogueraH2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_RegresarH2 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_H1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BN_SalidaHorno2 = New AdvancedHMIControls.BarLevel()
        Me.LS_MarchaHorno2 = New AdvancedHMIControls.PilotLight()
        Me.BN_SP_TempHorno2 = New AdvancedHMIControls.BarLevel()
        Me.Tex_TempMul2H2 = New System.Windows.Forms.Label()
        Me.TEX_Horno2 = New System.Windows.Forms.Label()
        Me.Tex_CargaHorno2 = New System.Windows.Forms.Label()
        Me.Tex_TempHogueraH2 = New System.Windows.Forms.Label()
        Me.Tex_CascarillaXMminuH2 = New System.Windows.Forms.Label()
        Me.Tex_TempChimeH2 = New System.Windows.Forms.Label()
        Me.Tex_TempMul1H2 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaHorno2 = New System.Windows.Forms.Label()
        Me.TexPID_Horno2 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempHorno2 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempHorno2 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        Me.IHorno1 = New System.Windows.Forms.PictureBox()
        CType(Me.Horno2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.IHorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CT_SHO02
        '
        Me.CT_SHO02.Button1Text = Nothing
        Me.CT_SHO02.Button2Text = Nothing
        Me.CT_SHO02.ComComponent = Me.Horno2
        Me.CT_SHO02.DecimalPosition = 1
        Me.CT_SHO02.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SHO02.Location = New System.Drawing.Point(197, 425)
        Me.CT_SHO02.Name = "CT_SHO02"
        Me.CT_SHO02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SHO02.PLCAddressClick1 = ""
        Me.CT_SHO02.PLCAddressClick2 = ""
        Me.CT_SHO02.PLCAddressClick3 = ""
        Me.CT_SHO02.PLCAddressClick4 = ""
        Me.CT_SHO02.PLCAddressText = ""
        Me.CT_SHO02.PLCAddressValuePV = "PID_HORNO.PV"
        Me.CT_SHO02.PLCAddressValueSP = "PID_HORNO.SP"
        Me.CT_SHO02.PLCAddressVisible = ""
        Me.CT_SHO02.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SHO02.Size = New System.Drawing.Size(200, 201)
        Me.CT_SHO02.TabIndex = 788
        Me.CT_SHO02.Text = "S-HO-02"
        Me.CT_SHO02.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SHO02.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SHO02.Value2Text = "SP"
        Me.CT_SHO02.ValuePV = 0!
        Me.CT_SHO02.ValueSP = 0!
        '
        'Horno2
        '
        Me.Horno2.CIPConnectionSize = 508
        Me.Horno2.DisableMultiServiceRequest = False
        Me.Horno2.DisableSubscriptions = False
        Me.Horno2.IniFileName = ""
        Me.Horno2.IniFileSection = Nothing
        Me.Horno2.IPAddress = "10.1.108.18"
        Me.Horno2.PollRateOverride = 500
        Me.Horno2.Port = 44818
        Me.Horno2.ProcessorSlot = 0
        Me.Horno2.RoutePath = Nothing
        Me.Horno2.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Horno2
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
        'LT_Horno2
        '
        Me.LT_Horno2.ComComponent = Me.Horno2
        Me.LT_Horno2.ForeColor = System.Drawing.Color.White
        Me.LT_Horno2.HighlightColor = System.Drawing.Color.Red
        Me.LT_Horno2.HighlightKeyCharacter = "!"
        Me.LT_Horno2.KeypadText = Nothing
        Me.LT_Horno2.LightAmberEnable = True
        Me.LT_Horno2.LightAmberValue = False
        Me.LT_Horno2.LightBlueEnable = True
        Me.LT_Horno2.LightBlueValue = False
        Me.LT_Horno2.LightGreenEnable = True
        Me.LT_Horno2.LightGreenValue = False
        Me.LT_Horno2.LightRedEnable = True
        Me.LT_Horno2.LightRedValue = False
        Me.LT_Horno2.Location = New System.Drawing.Point(977, 48)
        Me.LT_Horno2.Name = "LT_Horno2"
        Me.LT_Horno2.NumericFormat = Nothing
        Me.LT_Horno2.PLCAddressKeypad = ""
        Me.LT_Horno2.PLCAddressLightAmberValue = ""
        Me.LT_Horno2.PLCAddressLightGreenValue = "ALARMA_LUMINICA_VERDE_HORNO"
        Me.LT_Horno2.PLCAddressLightRedValue = "ALARMA_LUZ_ROJA_HORNO"
        Me.LT_Horno2.PLCAddressText = ""
        Me.LT_Horno2.PLCAddressVisible = ""
        Me.LT_Horno2.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LT_Horno2.Size = New System.Drawing.Size(37, 137)
        Me.LT_Horno2.TabIndex = 786
        Me.LT_Horno2.TextPrefix = Nothing
        Me.LT_Horno2.TextSuffix = Nothing
        '
        'BP_ParoHorno2
        '
        Me.BP_ParoHorno2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.BP_ParoHorno2.ComComponent = Me.Horno2
        Me.BP_ParoHorno2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.BP_ParoHorno2.Location = New System.Drawing.Point(616, 89)
        Me.BP_ParoHorno2.MaximumHoldTime = 3000
        Me.BP_ParoHorno2.MinimumHoldTime = 500
        Me.BP_ParoHorno2.Name = "BP_ParoHorno2"
        Me.BP_ParoHorno2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.BP_ParoHorno2.PLCAddressClick = "BP_ARRANCAR_SHO02"
        Me.BP_ParoHorno2.PLCAddressVisible = ""
        Me.BP_ParoHorno2.Size = New System.Drawing.Size(83, 122)
        Me.BP_ParoHorno2.TabIndex = 784
        Me.BP_ParoHorno2.Text = "Paro"
        '
        'BP_MarchaHorno2
        '
        Me.BP_MarchaHorno2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.BP_MarchaHorno2.ComComponent = Me.Horno2
        Me.BP_MarchaHorno2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.BP_MarchaHorno2.Location = New System.Drawing.Point(453, 89)
        Me.BP_MarchaHorno2.MaximumHoldTime = 3000
        Me.BP_MarchaHorno2.MinimumHoldTime = 500
        Me.BP_MarchaHorno2.Name = "BP_MarchaHorno2"
        Me.BP_MarchaHorno2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.BP_MarchaHorno2.PLCAddressClick = "BP_ARRANCAR_SHO02"
        Me.BP_MarchaHorno2.PLCAddressVisible = ""
        Me.BP_MarchaHorno2.Size = New System.Drawing.Size(83, 122)
        Me.BP_MarchaHorno2.TabIndex = 783
        Me.BP_MarchaHorno2.Text = "Marcha"
        '
        'TexRecetaHorno2
        '
        Me.TexRecetaHorno2.AutoSize = True
        Me.TexRecetaHorno2.BackColor = System.Drawing.Color.Transparent
        Me.TexRecetaHorno2.ComComponent = Me.Horno2
        Me.TexRecetaHorno2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexRecetaHorno2.ForeColor = System.Drawing.Color.Black
        Me.TexRecetaHorno2.HighlightColor = System.Drawing.Color.Red
        Me.TexRecetaHorno2.HighlightColor2 = System.Drawing.Color.Red
        Me.TexRecetaHorno2.HighlightKeyCharacter = "!"
        Me.TexRecetaHorno2.HighlightKeyCharacter2 = "."
        Me.TexRecetaHorno2.IniFileName = Nothing
        Me.TexRecetaHorno2.Location = New System.Drawing.Point(913, 249)
        Me.TexRecetaHorno2.Messages.Add(CType(resources.GetObject("TexRecetaHorno2.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno2.Messages.Add(CType(resources.GetObject("TexRecetaHorno2.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno2.Messages.Add(CType(resources.GetObject("TexRecetaHorno2.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno2.Messages.Add(CType(resources.GetObject("TexRecetaHorno2.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno2.Messages.Add(CType(resources.GetObject("TexRecetaHorno2.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno2.Name = "TexRecetaHorno2"
        Me.TexRecetaHorno2.PLCAddressValue = "NUMERO_RECETAS"
        Me.TexRecetaHorno2.PLCAddressVisible = "MOSTRAR_RECETA"
        Me.TexRecetaHorno2.ShowMessageNumber = False
        Me.TexRecetaHorno2.Size = New System.Drawing.Size(89, 22)
        Me.TexRecetaHorno2.SpeakMessage = False
        Me.TexRecetaHorno2.TabIndex = 782
        Me.TexRecetaHorno2.Text = "Receta 0"
        Me.TexRecetaHorno2.TextPrefix = Nothing
        Me.TexRecetaHorno2.Value = 0
        '
        'MD_TempMul2H2
        '
        Me.MD_TempMul2H2.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul2H2.ComComponent = Me.Horno2
        Me.MD_TempMul2H2.DecimalPosition = 1
        Me.MD_TempMul2H2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul2H2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul2H2.KeypadMaxValue = 0R
        Me.MD_TempMul2H2.KeypadMinValue = 0R
        Me.MD_TempMul2H2.KeypadScaleFactor = 1.0R
        Me.MD_TempMul2H2.KeypadText = Nothing
        Me.MD_TempMul2H2.KeypadWidth = 300
        Me.MD_TempMul2H2.Location = New System.Drawing.Point(1020, 391)
        Me.MD_TempMul2H2.Name = "MD_TempMul2H2"
        Me.MD_TempMul2H2.NumberOfDigits = 5
        Me.MD_TempMul2H2.PLCAddressKeypad = ""
        Me.MD_TempMul2H2.PLCAddressValue = "TEMPERATURA_AIRE_2_ESCALA_C"
        Me.MD_TempMul2H2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul2H2.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul2H2.TabIndex = 781
        Me.MD_TempMul2H2.Value = 0R
        Me.MD_TempMul2H2.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempMul2H2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempMul1H2
        '
        Me.MD_TempMul1H2.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul1H2.ComComponent = Me.Horno2
        Me.MD_TempMul1H2.DecimalPosition = 1
        Me.MD_TempMul1H2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul1H2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul1H2.KeypadMaxValue = 0R
        Me.MD_TempMul1H2.KeypadMinValue = 0R
        Me.MD_TempMul1H2.KeypadScaleFactor = 1.0R
        Me.MD_TempMul1H2.KeypadText = Nothing
        Me.MD_TempMul1H2.KeypadWidth = 300
        Me.MD_TempMul1H2.Location = New System.Drawing.Point(1020, 257)
        Me.MD_TempMul1H2.Name = "MD_TempMul1H2"
        Me.MD_TempMul1H2.NumberOfDigits = 5
        Me.MD_TempMul1H2.PLCAddressKeypad = ""
        Me.MD_TempMul1H2.PLCAddressValue = "TEMPERATURA_AIRE_1_ESCALA_C"
        Me.MD_TempMul1H2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul1H2.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul1H2.TabIndex = 780
        Me.MD_TempMul1H2.Value = 0R
        Me.MD_TempMul1H2.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempMul1H2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempChimeH2
        '
        Me.MD_TempChimeH2.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempChimeH2.ComComponent = Me.Horno2
        Me.MD_TempChimeH2.DecimalPosition = 1
        Me.MD_TempChimeH2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempChimeH2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempChimeH2.KeypadMaxValue = 0R
        Me.MD_TempChimeH2.KeypadMinValue = 0R
        Me.MD_TempChimeH2.KeypadScaleFactor = 1.0R
        Me.MD_TempChimeH2.KeypadText = Nothing
        Me.MD_TempChimeH2.KeypadWidth = 300
        Me.MD_TempChimeH2.Location = New System.Drawing.Point(1041, 111)
        Me.MD_TempChimeH2.Name = "MD_TempChimeH2"
        Me.MD_TempChimeH2.NumberOfDigits = 5
        Me.MD_TempChimeH2.PLCAddressKeypad = ""
        Me.MD_TempChimeH2.PLCAddressValue = "TEMP_CHIMENEA_ESCALADA_C"
        Me.MD_TempChimeH2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempChimeH2.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempChimeH2.TabIndex = 779
        Me.MD_TempChimeH2.Value = 0R
        Me.MD_TempChimeH2.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempChimeH2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CargaHorno2
        '
        Me.MD_CargaHorno2.BackColor = System.Drawing.Color.Transparent
        Me.MD_CargaHorno2.ComComponent = Me.Horno2
        Me.MD_CargaHorno2.DecimalPosition = 0
        Me.MD_CargaHorno2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CargaHorno2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CargaHorno2.KeypadMaxValue = 0R
        Me.MD_CargaHorno2.KeypadMinValue = 0R
        Me.MD_CargaHorno2.KeypadScaleFactor = 1.0R
        Me.MD_CargaHorno2.KeypadText = Nothing
        Me.MD_CargaHorno2.KeypadWidth = 300
        Me.MD_CargaHorno2.Location = New System.Drawing.Point(775, 506)
        Me.MD_CargaHorno2.Name = "MD_CargaHorno2"
        Me.MD_CargaHorno2.NumberOfDigits = 5
        Me.MD_CargaHorno2.PLCAddressKeypad = ""
        Me.MD_CargaHorno2.PLCAddressValue = "PORCIENTO_DE_CARGA"
        Me.MD_CargaHorno2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaHorno2.Size = New System.Drawing.Size(113, 49)
        Me.MD_CargaHorno2.TabIndex = 778
        Me.MD_CargaHorno2.Value = 0R
        Me.MD_CargaHorno2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaHorno2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CascarillaXMminuH2
        '
        Me.MD_CascarillaXMminuH2.BackColor = System.Drawing.Color.Transparent
        Me.MD_CascarillaXMminuH2.ComComponent = Me.Horno2
        Me.MD_CascarillaXMminuH2.DecimalPosition = 2
        Me.MD_CascarillaXMminuH2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CascarillaXMminuH2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CascarillaXMminuH2.KeypadMaxValue = 0R
        Me.MD_CascarillaXMminuH2.KeypadMinValue = 0R
        Me.MD_CascarillaXMminuH2.KeypadScaleFactor = 1.0R
        Me.MD_CascarillaXMminuH2.KeypadText = Nothing
        Me.MD_CascarillaXMminuH2.KeypadWidth = 300
        Me.MD_CascarillaXMminuH2.Location = New System.Drawing.Point(775, 270)
        Me.MD_CascarillaXMminuH2.Name = "MD_CascarillaXMminuH2"
        Me.MD_CascarillaXMminuH2.NumberOfDigits = 5
        Me.MD_CascarillaXMminuH2.PLCAddressKeypad = ""
        Me.MD_CascarillaXMminuH2.PLCAddressValue = "CAUDAL_CASCARILLA_SEGUNDO_MONITOR"
        Me.MD_CascarillaXMminuH2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuH2.Size = New System.Drawing.Size(113, 49)
        Me.MD_CascarillaXMminuH2.TabIndex = 777
        Me.MD_CascarillaXMminuH2.Value = 0R
        Me.MD_CascarillaXMminuH2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuH2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempHogueraH2
        '
        Me.MD_TempHogueraH2.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempHogueraH2.ComComponent = Me.Horno2
        Me.MD_TempHogueraH2.DecimalPosition = 1
        Me.MD_TempHogueraH2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempHogueraH2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempHogueraH2.KeypadMaxValue = 0R
        Me.MD_TempHogueraH2.KeypadMinValue = 0R
        Me.MD_TempHogueraH2.KeypadScaleFactor = 1.0R
        Me.MD_TempHogueraH2.KeypadText = Nothing
        Me.MD_TempHogueraH2.KeypadWidth = 300
        Me.MD_TempHogueraH2.Location = New System.Drawing.Point(530, 282)
        Me.MD_TempHogueraH2.Name = "MD_TempHogueraH2"
        Me.MD_TempHogueraH2.NumberOfDigits = 5
        Me.MD_TempHogueraH2.PLCAddressKeypad = ""
        Me.MD_TempHogueraH2.PLCAddressValue = "TEMP_HOGUERA_ESCALADA_C"
        Me.MD_TempHogueraH2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempHogueraH2.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempHogueraH2.TabIndex = 776
        Me.MD_TempHogueraH2.Value = 0R
        Me.MD_TempHogueraH2.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempHogueraH2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_RegresarH2
        '
        Me.BCF_RegresarH2.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH2.ComComponent = Nothing
        Me.BCF_RegresarH2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH2.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH2.FormToOpen = GetType(MfgControl.AdvancedHMI.Menú_Horno_2)
        Me.BCF_RegresarH2.KeypadWidth = 300
        Me.BCF_RegresarH2.Location = New System.Drawing.Point(483, 554)
        Me.BCF_RegresarH2.Name = "BCF_RegresarH2"
        Me.BCF_RegresarH2.Passcode = Nothing
        Me.BCF_RegresarH2.PasswordChar = False
        Me.BCF_RegresarH2.PLCAddressVisible = ""
        Me.BCF_RegresarH2.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH2.TabIndex = 775
        Me.BCF_RegresarH2.Text = "Regresar"
        Me.BCF_RegresarH2.UseVisualStyleBackColor = False
        '
        'BCF_MenúP_H1
        '
        Me.BCF_MenúP_H1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_H1.ComComponent = Nothing
        Me.BCF_MenúP_H1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_H1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_H1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_H1.KeypadWidth = 300
        Me.BCF_MenúP_H1.Location = New System.Drawing.Point(225, 653)
        Me.BCF_MenúP_H1.Name = "BCF_MenúP_H1"
        Me.BCF_MenúP_H1.Passcode = Nothing
        Me.BCF_MenúP_H1.PasswordChar = False
        Me.BCF_MenúP_H1.PLCAddressVisible = ""
        Me.BCF_MenúP_H1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_H1.TabIndex = 774
        Me.BCF_MenúP_H1.Text = "Menú Principal"
        Me.BCF_MenúP_H1.UseVisualStyleBackColor = False
        '
        'BN_SalidaHorno2
        '
        Me.BN_SalidaHorno2.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaHorno2.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaHorno2.ComComponent = Me.Horno2
        Me.BN_SalidaHorno2.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaHorno2.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaHorno2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaHorno2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaHorno2.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaHorno2.Location = New System.Drawing.Point(351, 147)
        Me.BN_SalidaHorno2.Maximum = 100.0R
        Me.BN_SalidaHorno2.Minimum = 0R
        Me.BN_SalidaHorno2.Name = "BN_SalidaHorno2"
        Me.BN_SalidaHorno2.NumericFormat = Nothing
        Me.BN_SalidaHorno2.PLCAddressValue = "PID_HORNO.OUT"
        Me.BN_SalidaHorno2.ShowValue = True
        Me.BN_SalidaHorno2.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaHorno2.TabIndex = 773
        Me.BN_SalidaHorno2.Text = "BarLevel3"
        Me.BN_SalidaHorno2.TextSuffix = Nothing
        Me.BN_SalidaHorno2.Value = 0R
        Me.BN_SalidaHorno2.ValueScaleFactor = 1.0R
        '
        'LS_MarchaHorno2
        '
        Me.LS_MarchaHorno2.Blink = False
        Me.LS_MarchaHorno2.ComComponent = Me.Horno2
        Me.LS_MarchaHorno2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.LS_MarchaHorno2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaHorno2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaHorno2.Location = New System.Drawing.Point(535, 89)
        Me.LS_MarchaHorno2.Name = "LS_MarchaHorno2"
        Me.LS_MarchaHorno2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaHorno2.PLCAddressClick = ""
        Me.LS_MarchaHorno2.PLCAddressText = ""
        Me.LS_MarchaHorno2.PLCAddressValue = "HORNO_ENCENDIDO_OUT"
        Me.LS_MarchaHorno2.PLCAddressVisible = ""
        Me.LS_MarchaHorno2.Size = New System.Drawing.Size(83, 122)
        Me.LS_MarchaHorno2.TabIndex = 785
        Me.LS_MarchaHorno2.Text = "Marcha"
        Me.LS_MarchaHorno2.Value = False
        Me.LS_MarchaHorno2.ValueToWrite = 0
        '
        'BN_SP_TempHorno2
        '
        Me.BN_SP_TempHorno2.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempHorno2.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempHorno2.ComComponent = Me.Horno2
        Me.BN_SP_TempHorno2.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempHorno2.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempHorno2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempHorno2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempHorno2.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempHorno2.Location = New System.Drawing.Point(209, 148)
        Me.BN_SP_TempHorno2.Maximum = 100.0R
        Me.BN_SP_TempHorno2.Minimum = 0R
        Me.BN_SP_TempHorno2.Name = "BN_SP_TempHorno2"
        Me.BN_SP_TempHorno2.NumericFormat = Nothing
        Me.BN_SP_TempHorno2.PLCAddressValue = "PID_HORNO.SP"
        Me.BN_SP_TempHorno2.ShowValue = True
        Me.BN_SP_TempHorno2.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempHorno2.TabIndex = 772
        Me.BN_SP_TempHorno2.Text = "BarLevel1"
        Me.BN_SP_TempHorno2.TextSuffix = Nothing
        Me.BN_SP_TempHorno2.Value = 0R
        Me.BN_SP_TempHorno2.ValueScaleFactor = 1.0R
        '
        'Tex_TempMul2H2
        '
        Me.Tex_TempMul2H2.AutoSize = True
        Me.Tex_TempMul2H2.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempMul2H2.Location = New System.Drawing.Point(1028, 352)
        Me.Tex_TempMul2H2.Name = "Tex_TempMul2H2"
        Me.Tex_TempMul2H2.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul2H2.TabIndex = 771
        Me.Tex_TempMul2H2.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 2"
        Me.Tex_TempMul2H2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TEX_Horno2
        '
        Me.TEX_Horno2.AutoSize = True
        Me.TEX_Horno2.BackColor = System.Drawing.Color.White
        Me.TEX_Horno2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEX_Horno2.Location = New System.Drawing.Point(676, 52)
        Me.TEX_Horno2.Name = "TEX_Horno2"
        Me.TEX_Horno2.Size = New System.Drawing.Size(125, 34)
        Me.TEX_Horno2.TabIndex = 770
        Me.TEX_Horno2.Text = "Horno 2"
        '
        'Tex_CargaHorno2
        '
        Me.Tex_CargaHorno2.AutoSize = True
        Me.Tex_CargaHorno2.BackColor = System.Drawing.Color.White
        Me.Tex_CargaHorno2.ForeColor = System.Drawing.Color.Black
        Me.Tex_CargaHorno2.Location = New System.Drawing.Point(786, 467)
        Me.Tex_CargaHorno2.Name = "Tex_CargaHorno2"
        Me.Tex_CargaHorno2.Size = New System.Drawing.Size(83, 36)
        Me.Tex_CargaHorno2.TabIndex = 769
        Me.Tex_CargaHorno2.Text = "Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Carga"
        Me.Tex_CargaHorno2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempHogueraH2
        '
        Me.Tex_TempHogueraH2.AutoSize = True
        Me.Tex_TempHogueraH2.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempHogueraH2.Location = New System.Drawing.Point(535, 243)
        Me.Tex_TempHogueraH2.Name = "Tex_TempHogueraH2"
        Me.Tex_TempHogueraH2.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempHogueraH2.TabIndex = 768
        Me.Tex_TempHogueraH2.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hoguera"
        Me.Tex_TempHogueraH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CascarillaXMminuH2
        '
        Me.Tex_CascarillaXMminuH2.AutoSize = True
        Me.Tex_CascarillaXMminuH2.BackColor = System.Drawing.Color.Silver
        Me.Tex_CascarillaXMminuH2.Location = New System.Drawing.Point(774, 231)
        Me.Tex_CascarillaXMminuH2.Name = "Tex_CascarillaXMminuH2"
        Me.Tex_CascarillaXMminuH2.Size = New System.Drawing.Size(114, 36)
        Me.Tex_CascarillaXMminuH2.TabIndex = 767
        Me.Tex_CascarillaXMminuH2.Text = "Kgs. Cascarilla" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Minuto"
        Me.Tex_CascarillaXMminuH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempChimeH2
        '
        Me.Tex_TempChimeH2.AutoSize = True
        Me.Tex_TempChimeH2.BackColor = System.Drawing.Color.White
        Me.Tex_TempChimeH2.Location = New System.Drawing.Point(1047, 72)
        Me.Tex_TempChimeH2.Name = "Tex_TempChimeH2"
        Me.Tex_TempChimeH2.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempChimeH2.TabIndex = 766
        Me.Tex_TempChimeH2.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chimenea"
        Me.Tex_TempChimeH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempMul1H2
        '
        Me.Tex_TempMul1H2.AutoSize = True
        Me.Tex_TempMul1H2.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempMul1H2.Location = New System.Drawing.Point(1029, 218)
        Me.Tex_TempMul1H2.Name = "Tex_TempMul1H2"
        Me.Tex_TempMul1H2.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul1H2.TabIndex = 765
        Me.Tex_TempMul1H2.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 1"
        Me.Tex_TempMul1H2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaHorno2
        '
        Me.TexBN_SalidaHorno2.AutoSize = True
        Me.TexBN_SalidaHorno2.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaHorno2.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaHorno2.Location = New System.Drawing.Point(344, 129)
        Me.TexBN_SalidaHorno2.Name = "TexBN_SalidaHorno2"
        Me.TexBN_SalidaHorno2.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaHorno2.TabIndex = 762
        Me.TexBN_SalidaHorno2.Text = "Salida"
        Me.TexBN_SalidaHorno2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_Horno2
        '
        Me.TexPID_Horno2.AutoSize = True
        Me.TexPID_Horno2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_Horno2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_Horno2.Location = New System.Drawing.Point(197, 68)
        Me.TexPID_Horno2.Name = "TexPID_Horno2"
        Me.TexPID_Horno2.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_Horno2.TabIndex = 763
        Me.TexPID_Horno2.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_Horno2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempHorno2
        '
        Me.TexBN_RealTempHorno2.AutoSize = True
        Me.TexBN_RealTempHorno2.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempHorno2.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempHorno2.Location = New System.Drawing.Point(276, 130)
        Me.TexBN_RealTempHorno2.Name = "TexBN_RealTempHorno2"
        Me.TexBN_RealTempHorno2.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempHorno2.TabIndex = 761
        Me.TexBN_RealTempHorno2.Text = "Real"
        Me.TexBN_RealTempHorno2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempHorno2
        '
        Me.TexBN_SP_TempHorno2.AutoSize = True
        Me.TexBN_SP_TempHorno2.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempHorno2.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempHorno2.Location = New System.Drawing.Point(191, 130)
        Me.TexBN_SP_TempHorno2.Name = "TexBN_SP_TempHorno2"
        Me.TexBN_SP_TempHorno2.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempHorno2.TabIndex = 760
        Me.TexBN_SP_TempHorno2.Text = "SetPoint"
        Me.TexBN_SP_TempHorno2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Horno2
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(183, 45)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 787
        '
        'IHorno1
        '
        Me.IHorno1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Horno_sdi_1
        Me.IHorno1.Location = New System.Drawing.Point(431, 49)
        Me.IHorno1.Name = "IHorno1"
        Me.IHorno1.Size = New System.Drawing.Size(734, 499)
        Me.IHorno1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IHorno1.TabIndex = 764
        Me.IHorno1.TabStop = False
        '
        'Horno_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SHO02)
        Me.Controls.Add(Me.LT_Horno2)
        Me.Controls.Add(Me.BP_ParoHorno2)
        Me.Controls.Add(Me.BP_MarchaHorno2)
        Me.Controls.Add(Me.TexRecetaHorno2)
        Me.Controls.Add(Me.MD_TempMul2H2)
        Me.Controls.Add(Me.MD_TempMul1H2)
        Me.Controls.Add(Me.MD_TempChimeH2)
        Me.Controls.Add(Me.MD_CargaHorno2)
        Me.Controls.Add(Me.MD_CascarillaXMminuH2)
        Me.Controls.Add(Me.MD_TempHogueraH2)
        Me.Controls.Add(Me.BCF_RegresarH2)
        Me.Controls.Add(Me.BCF_MenúP_H1)
        Me.Controls.Add(Me.BN_SalidaHorno2)
        Me.Controls.Add(Me.LS_MarchaHorno2)
        Me.Controls.Add(Me.BN_SP_TempHorno2)
        Me.Controls.Add(Me.Tex_TempMul2H2)
        Me.Controls.Add(Me.TEX_Horno2)
        Me.Controls.Add(Me.Tex_CargaHorno2)
        Me.Controls.Add(Me.Tex_TempHogueraH2)
        Me.Controls.Add(Me.Tex_CascarillaXMminuH2)
        Me.Controls.Add(Me.Tex_TempChimeH2)
        Me.Controls.Add(Me.Tex_TempMul1H2)
        Me.Controls.Add(Me.TexBN_SalidaHorno2)
        Me.Controls.Add(Me.IHorno1)
        Me.Controls.Add(Me.TexPID_Horno2)
        Me.Controls.Add(Me.TexBN_RealTempHorno2)
        Me.Controls.Add(Me.TexBN_SP_TempHorno2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Horno_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Horno2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.IHorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SHO02 As AdvancedHMIControls.TempController
    Friend WithEvents Horno2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents LT_Horno2 As AdvancedHMIControls.StackLight
    Friend WithEvents BP_ParoHorno2 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents BP_MarchaHorno2 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents TexRecetaHorno2 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempMul2H2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempMul1H2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempChimeH2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CargaHorno2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CascarillaXMminuH2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempHogueraH2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_RegresarH2 As FormChangeButton
    Friend WithEvents BCF_MenúP_H1 As FormChangeButton
    Friend WithEvents BN_SalidaHorno2 As AdvancedHMIControls.BarLevel
    Friend WithEvents LS_MarchaHorno2 As AdvancedHMIControls.PilotLight
    Friend WithEvents BN_SP_TempHorno2 As AdvancedHMIControls.BarLevel
    Friend WithEvents Tex_TempMul2H2 As Label
    Friend WithEvents TEX_Horno2 As Label
    Friend WithEvents Tex_CargaHorno2 As Label
    Friend WithEvents Tex_TempHogueraH2 As Label
    Friend WithEvents Tex_CascarillaXMminuH2 As Label
    Friend WithEvents Tex_TempChimeH2 As Label
    Friend WithEvents Tex_TempMul1H2 As Label
    Friend WithEvents TexBN_SalidaHorno2 As Label
    Friend WithEvents IHorno1 As PictureBox
    Friend WithEvents TexPID_Horno2 As Label
    Friend WithEvents TexBN_RealTempHorno2 As Label
    Friend WithEvents TexBN_SP_TempHorno2 As Label
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
