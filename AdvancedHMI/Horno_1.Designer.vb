<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horno_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horno_1))
        Me.CT_SHO01 = New AdvancedHMIControls.TempController()
        Me.Horno1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.LS_MarchaHorno1 = New AdvancedHMIControls.PilotLight()
        Me.BP_MarchaHorno1 = New AdvancedHMIControls.MomentaryButton()
        Me.TexRecetaHorno1 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempMul2H1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempMul1H1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempChimeH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CargaHorno1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CascarillaXMminuH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempHogueraH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_H1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BN_SalidaHorno1 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempHorno1 = New AdvancedHMIControls.BarLevel()
        Me.BP_ParoHorno1 = New AdvancedHMIControls.MomentaryButton()
        Me.LT_Horno1 = New AdvancedHMIControls.StackLight()
        Me.Tex_TempMul2H1 = New System.Windows.Forms.Label()
        Me.TEX_Horno1 = New System.Windows.Forms.Label()
        Me.Tex_CargaHorno1 = New System.Windows.Forms.Label()
        Me.Tex_TempHogueraH1 = New System.Windows.Forms.Label()
        Me.Tex_CascarillaXMminuH1 = New System.Windows.Forms.Label()
        Me.Tex_TempChimeH1 = New System.Windows.Forms.Label()
        Me.Tex_TempMul1H1 = New System.Windows.Forms.Label()
        Me.IHorno1 = New System.Windows.Forms.PictureBox()
        Me.TexPID_Horno1 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaHorno1 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempHorno1 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempHorno1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Horno1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IHorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SHO01
        '
        Me.CT_SHO01.Button1Text = Nothing
        Me.CT_SHO01.Button2Text = Nothing
        Me.CT_SHO01.ComComponent = Me.Horno1
        Me.CT_SHO01.DecimalPosition = 1
        Me.CT_SHO01.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SHO01.Location = New System.Drawing.Point(197, 423)
        Me.CT_SHO01.Name = "CT_SHO01"
        Me.CT_SHO01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SHO01.PLCAddressClick1 = ""
        Me.CT_SHO01.PLCAddressClick2 = ""
        Me.CT_SHO01.PLCAddressClick3 = ""
        Me.CT_SHO01.PLCAddressClick4 = ""
        Me.CT_SHO01.PLCAddressText = ""
        Me.CT_SHO01.PLCAddressValuePV = "PID_HORNO.PV"
        Me.CT_SHO01.PLCAddressValueSP = "PID_HORNO.SP"
        Me.CT_SHO01.PLCAddressVisible = ""
        Me.CT_SHO01.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SHO01.Size = New System.Drawing.Size(200, 201)
        Me.CT_SHO01.TabIndex = 752
        Me.CT_SHO01.Text = "S-HO-01"
        Me.CT_SHO01.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SHO01.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SHO01.Value2Text = "SP"
        Me.CT_SHO01.ValuePV = 0!
        Me.CT_SHO01.ValueSP = 0!
        '
        'Horno1
        '
        Me.Horno1.CIPConnectionSize = 508
        Me.Horno1.DisableMultiServiceRequest = False
        Me.Horno1.DisableSubscriptions = False
        Me.Horno1.IniFileName = ""
        Me.Horno1.IniFileSection = Nothing
        Me.Horno1.IPAddress = "10.1.108.20"
        Me.Horno1.PollRateOverride = 500
        Me.Horno1.Port = 44818
        Me.Horno1.ProcessorSlot = 0
        Me.Horno1.RoutePath = Nothing
        Me.Horno1.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Horno1
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
        'LS_MarchaHorno1
        '
        Me.LS_MarchaHorno1.Blink = False
        Me.LS_MarchaHorno1.ComComponent = Me.Horno1
        Me.LS_MarchaHorno1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.LS_MarchaHorno1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaHorno1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaHorno1.Location = New System.Drawing.Point(535, 88)
        Me.LS_MarchaHorno1.Name = "LS_MarchaHorno1"
        Me.LS_MarchaHorno1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaHorno1.PLCAddressClick = ""
        Me.LS_MarchaHorno1.PLCAddressText = ""
        Me.LS_MarchaHorno1.PLCAddressValue = "BP_ARRANCAR_HORNO"
        Me.LS_MarchaHorno1.PLCAddressVisible = ""
        Me.LS_MarchaHorno1.Size = New System.Drawing.Size(83, 122)
        Me.LS_MarchaHorno1.TabIndex = 749
        Me.LS_MarchaHorno1.Text = "Marcha"
        Me.LS_MarchaHorno1.Value = False
        Me.LS_MarchaHorno1.ValueToWrite = 0
        '
        'BP_MarchaHorno1
        '
        Me.BP_MarchaHorno1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.BP_MarchaHorno1.ComComponent = Me.Horno1
        Me.BP_MarchaHorno1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.BP_MarchaHorno1.Location = New System.Drawing.Point(453, 88)
        Me.BP_MarchaHorno1.MaximumHoldTime = 3000
        Me.BP_MarchaHorno1.MinimumHoldTime = 500
        Me.BP_MarchaHorno1.Name = "BP_MarchaHorno1"
        Me.BP_MarchaHorno1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.BP_MarchaHorno1.PLCAddressClick = "BP_ARRANCAR_HORNO"
        Me.BP_MarchaHorno1.PLCAddressVisible = ""
        Me.BP_MarchaHorno1.Size = New System.Drawing.Size(83, 122)
        Me.BP_MarchaHorno1.TabIndex = 747
        Me.BP_MarchaHorno1.Text = "Marcha"
        '
        'TexRecetaHorno1
        '
        Me.TexRecetaHorno1.AutoSize = True
        Me.TexRecetaHorno1.BackColor = System.Drawing.Color.Transparent
        Me.TexRecetaHorno1.ComComponent = Me.Horno1
        Me.TexRecetaHorno1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexRecetaHorno1.ForeColor = System.Drawing.Color.Black
        Me.TexRecetaHorno1.HighlightColor = System.Drawing.Color.Red
        Me.TexRecetaHorno1.HighlightColor2 = System.Drawing.Color.Red
        Me.TexRecetaHorno1.HighlightKeyCharacter = "!"
        Me.TexRecetaHorno1.HighlightKeyCharacter2 = "."
        Me.TexRecetaHorno1.IniFileName = Nothing
        Me.TexRecetaHorno1.Location = New System.Drawing.Point(911, 202)
        Me.TexRecetaHorno1.Messages.Add(CType(resources.GetObject("TexRecetaHorno1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno1.Messages.Add(CType(resources.GetObject("TexRecetaHorno1.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno1.Messages.Add(CType(resources.GetObject("TexRecetaHorno1.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno1.Messages.Add(CType(resources.GetObject("TexRecetaHorno1.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno1.Messages.Add(CType(resources.GetObject("TexRecetaHorno1.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno1.Name = "TexRecetaHorno1"
        Me.TexRecetaHorno1.PLCAddressValue = "NUMERO_RECETAS"
        Me.TexRecetaHorno1.PLCAddressVisible = "MOSTRAR_RECETA"
        Me.TexRecetaHorno1.ShowMessageNumber = False
        Me.TexRecetaHorno1.Size = New System.Drawing.Size(89, 22)
        Me.TexRecetaHorno1.SpeakMessage = False
        Me.TexRecetaHorno1.TabIndex = 746
        Me.TexRecetaHorno1.Text = "Receta 0"
        Me.TexRecetaHorno1.TextPrefix = Nothing
        Me.TexRecetaHorno1.Value = 0
        '
        'MD_TempMul2H1
        '
        Me.MD_TempMul2H1.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul2H1.ComComponent = Me.Horno1
        Me.MD_TempMul2H1.DecimalPosition = 1
        Me.MD_TempMul2H1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul2H1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul2H1.KeypadMaxValue = 0R
        Me.MD_TempMul2H1.KeypadMinValue = 0R
        Me.MD_TempMul2H1.KeypadScaleFactor = 1.0R
        Me.MD_TempMul2H1.KeypadText = Nothing
        Me.MD_TempMul2H1.KeypadWidth = 300
        Me.MD_TempMul2H1.Location = New System.Drawing.Point(1022, 390)
        Me.MD_TempMul2H1.Name = "MD_TempMul2H1"
        Me.MD_TempMul2H1.NumberOfDigits = 5
        Me.MD_TempMul2H1.PLCAddressKeypad = ""
        Me.MD_TempMul2H1.PLCAddressValue = "TEMPERATURA_AIRE_2_ESCALA_C"
        Me.MD_TempMul2H1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul2H1.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul2H1.TabIndex = 745
        Me.MD_TempMul2H1.Value = 0R
        Me.MD_TempMul2H1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempMul2H1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempMul1H1
        '
        Me.MD_TempMul1H1.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul1H1.ComComponent = Me.Horno1
        Me.MD_TempMul1H1.DecimalPosition = 1
        Me.MD_TempMul1H1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul1H1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul1H1.KeypadMaxValue = 0R
        Me.MD_TempMul1H1.KeypadMinValue = 0R
        Me.MD_TempMul1H1.KeypadScaleFactor = 1.0R
        Me.MD_TempMul1H1.KeypadText = Nothing
        Me.MD_TempMul1H1.KeypadWidth = 300
        Me.MD_TempMul1H1.Location = New System.Drawing.Point(1022, 256)
        Me.MD_TempMul1H1.Name = "MD_TempMul1H1"
        Me.MD_TempMul1H1.NumberOfDigits = 5
        Me.MD_TempMul1H1.PLCAddressKeypad = ""
        Me.MD_TempMul1H1.PLCAddressValue = "TEMPERATURA_AIRE_1_ESCALA_C"
        Me.MD_TempMul1H1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul1H1.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul1H1.TabIndex = 744
        Me.MD_TempMul1H1.Value = 0R
        Me.MD_TempMul1H1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempMul1H1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempChimeH1
        '
        Me.MD_TempChimeH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempChimeH1.ComComponent = Me.Horno1
        Me.MD_TempChimeH1.DecimalPosition = 1
        Me.MD_TempChimeH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempChimeH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempChimeH1.KeypadMaxValue = 0R
        Me.MD_TempChimeH1.KeypadMinValue = 0R
        Me.MD_TempChimeH1.KeypadScaleFactor = 1.0R
        Me.MD_TempChimeH1.KeypadText = Nothing
        Me.MD_TempChimeH1.KeypadWidth = 300
        Me.MD_TempChimeH1.Location = New System.Drawing.Point(1043, 110)
        Me.MD_TempChimeH1.Name = "MD_TempChimeH1"
        Me.MD_TempChimeH1.NumberOfDigits = 5
        Me.MD_TempChimeH1.PLCAddressKeypad = ""
        Me.MD_TempChimeH1.PLCAddressValue = "TEMP_CHIMENEA_ESCALADA_C"
        Me.MD_TempChimeH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempChimeH1.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempChimeH1.TabIndex = 743
        Me.MD_TempChimeH1.Value = 0R
        Me.MD_TempChimeH1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempChimeH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CargaHorno1
        '
        Me.MD_CargaHorno1.BackColor = System.Drawing.Color.Transparent
        Me.MD_CargaHorno1.ComComponent = Me.Horno1
        Me.MD_CargaHorno1.DecimalPosition = 0
        Me.MD_CargaHorno1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CargaHorno1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CargaHorno1.KeypadMaxValue = 0R
        Me.MD_CargaHorno1.KeypadMinValue = 0R
        Me.MD_CargaHorno1.KeypadScaleFactor = 1.0R
        Me.MD_CargaHorno1.KeypadText = Nothing
        Me.MD_CargaHorno1.KeypadWidth = 300
        Me.MD_CargaHorno1.Location = New System.Drawing.Point(775, 505)
        Me.MD_CargaHorno1.Name = "MD_CargaHorno1"
        Me.MD_CargaHorno1.NumberOfDigits = 5
        Me.MD_CargaHorno1.PLCAddressKeypad = ""
        Me.MD_CargaHorno1.PLCAddressValue = "PORCIENTO_DE_CARGA"
        Me.MD_CargaHorno1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaHorno1.Size = New System.Drawing.Size(113, 49)
        Me.MD_CargaHorno1.TabIndex = 742
        Me.MD_CargaHorno1.Value = 0R
        Me.MD_CargaHorno1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaHorno1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CascarillaXMminuH1
        '
        Me.MD_CascarillaXMminuH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_CascarillaXMminuH1.ComComponent = Me.Horno1
        Me.MD_CascarillaXMminuH1.DecimalPosition = 2
        Me.MD_CascarillaXMminuH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CascarillaXMminuH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CascarillaXMminuH1.KeypadMaxValue = 0R
        Me.MD_CascarillaXMminuH1.KeypadMinValue = 0R
        Me.MD_CascarillaXMminuH1.KeypadScaleFactor = 1.0R
        Me.MD_CascarillaXMminuH1.KeypadText = Nothing
        Me.MD_CascarillaXMminuH1.KeypadWidth = 300
        Me.MD_CascarillaXMminuH1.Location = New System.Drawing.Point(775, 271)
        Me.MD_CascarillaXMminuH1.Name = "MD_CascarillaXMminuH1"
        Me.MD_CascarillaXMminuH1.NumberOfDigits = 5
        Me.MD_CascarillaXMminuH1.PLCAddressKeypad = ""
        Me.MD_CascarillaXMminuH1.PLCAddressValue = "CAUDAL_CASCARILLA_SEGUNDO_MONITOR"
        Me.MD_CascarillaXMminuH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuH1.Size = New System.Drawing.Size(113, 49)
        Me.MD_CascarillaXMminuH1.TabIndex = 741
        Me.MD_CascarillaXMminuH1.Value = 0R
        Me.MD_CascarillaXMminuH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempHogueraH1
        '
        Me.MD_TempHogueraH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempHogueraH1.ComComponent = Me.Horno1
        Me.MD_TempHogueraH1.DecimalPosition = 1
        Me.MD_TempHogueraH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempHogueraH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempHogueraH1.KeypadMaxValue = 0R
        Me.MD_TempHogueraH1.KeypadMinValue = 0R
        Me.MD_TempHogueraH1.KeypadScaleFactor = 1.0R
        Me.MD_TempHogueraH1.KeypadText = Nothing
        Me.MD_TempHogueraH1.KeypadWidth = 300
        Me.MD_TempHogueraH1.Location = New System.Drawing.Point(530, 281)
        Me.MD_TempHogueraH1.Name = "MD_TempHogueraH1"
        Me.MD_TempHogueraH1.NumberOfDigits = 5
        Me.MD_TempHogueraH1.PLCAddressKeypad = ""
        Me.MD_TempHogueraH1.PLCAddressValue = "TEMP_HOGUERA_ESCALADA_C"
        Me.MD_TempHogueraH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempHogueraH1.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempHogueraH1.TabIndex = 740
        Me.MD_TempHogueraH1.Value = 0R
        Me.MD_TempHogueraH1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempHogueraH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = GetType(MfgControl.AdvancedHMI.Menú_Horno_1)
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(483, 553)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 739
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BCF_MenúP_H1
        '
        Me.BCF_MenúP_H1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_H1.ComComponent = Nothing
        Me.BCF_MenúP_H1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_H1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_H1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_H1.KeypadWidth = 300
        Me.BCF_MenúP_H1.Location = New System.Drawing.Point(219, 655)
        Me.BCF_MenúP_H1.Name = "BCF_MenúP_H1"
        Me.BCF_MenúP_H1.Passcode = Nothing
        Me.BCF_MenúP_H1.PasswordChar = False
        Me.BCF_MenúP_H1.PLCAddressVisible = ""
        Me.BCF_MenúP_H1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_H1.TabIndex = 738
        Me.BCF_MenúP_H1.Text = "Menú Principal"
        Me.BCF_MenúP_H1.UseVisualStyleBackColor = False
        '
        'BN_SalidaHorno1
        '
        Me.BN_SalidaHorno1.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaHorno1.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaHorno1.ComComponent = Me.Horno1
        Me.BN_SalidaHorno1.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaHorno1.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaHorno1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaHorno1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaHorno1.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaHorno1.Location = New System.Drawing.Point(351, 146)
        Me.BN_SalidaHorno1.Maximum = 100.0R
        Me.BN_SalidaHorno1.Minimum = 0R
        Me.BN_SalidaHorno1.Name = "BN_SalidaHorno1"
        Me.BN_SalidaHorno1.NumericFormat = Nothing
        Me.BN_SalidaHorno1.PLCAddressValue = "PID_HORNO.OUT"
        Me.BN_SalidaHorno1.ShowValue = True
        Me.BN_SalidaHorno1.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaHorno1.TabIndex = 737
        Me.BN_SalidaHorno1.Text = "BarLevel3"
        Me.BN_SalidaHorno1.TextSuffix = Nothing
        Me.BN_SalidaHorno1.Value = 0R
        Me.BN_SalidaHorno1.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempHorno1
        '
        Me.BN_SP_TempHorno1.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempHorno1.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempHorno1.ComComponent = Me.Horno1
        Me.BN_SP_TempHorno1.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempHorno1.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempHorno1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempHorno1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempHorno1.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempHorno1.Location = New System.Drawing.Point(209, 147)
        Me.BN_SP_TempHorno1.Maximum = 100.0R
        Me.BN_SP_TempHorno1.Minimum = 0R
        Me.BN_SP_TempHorno1.Name = "BN_SP_TempHorno1"
        Me.BN_SP_TempHorno1.NumericFormat = Nothing
        Me.BN_SP_TempHorno1.PLCAddressValue = "PID_HORNO.SP"
        Me.BN_SP_TempHorno1.ShowValue = True
        Me.BN_SP_TempHorno1.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempHorno1.TabIndex = 736
        Me.BN_SP_TempHorno1.Text = "BarLevel1"
        Me.BN_SP_TempHorno1.TextSuffix = Nothing
        Me.BN_SP_TempHorno1.Value = 0R
        Me.BN_SP_TempHorno1.ValueScaleFactor = 1.0R
        '
        'BP_ParoHorno1
        '
        Me.BP_ParoHorno1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.BP_ParoHorno1.ComComponent = Me.Horno1
        Me.BP_ParoHorno1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.BP_ParoHorno1.Location = New System.Drawing.Point(616, 88)
        Me.BP_ParoHorno1.MaximumHoldTime = 3000
        Me.BP_ParoHorno1.MinimumHoldTime = 500
        Me.BP_ParoHorno1.Name = "BP_ParoHorno1"
        Me.BP_ParoHorno1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.BP_ParoHorno1.PLCAddressClick = "BP_ARRANCAR_HORNO"
        Me.BP_ParoHorno1.PLCAddressVisible = ""
        Me.BP_ParoHorno1.Size = New System.Drawing.Size(83, 122)
        Me.BP_ParoHorno1.TabIndex = 748
        Me.BP_ParoHorno1.Text = "Paro"
        '
        'LT_Horno1
        '
        Me.LT_Horno1.ComComponent = Me.Horno1
        Me.LT_Horno1.ForeColor = System.Drawing.Color.White
        Me.LT_Horno1.HighlightColor = System.Drawing.Color.Red
        Me.LT_Horno1.HighlightKeyCharacter = "!"
        Me.LT_Horno1.KeypadText = Nothing
        Me.LT_Horno1.LightAmberEnable = True
        Me.LT_Horno1.LightAmberValue = False
        Me.LT_Horno1.LightBlueEnable = True
        Me.LT_Horno1.LightBlueValue = False
        Me.LT_Horno1.LightGreenEnable = True
        Me.LT_Horno1.LightGreenValue = False
        Me.LT_Horno1.LightRedEnable = True
        Me.LT_Horno1.LightRedValue = False
        Me.LT_Horno1.Location = New System.Drawing.Point(976, 48)
        Me.LT_Horno1.Name = "LT_Horno1"
        Me.LT_Horno1.NumericFormat = Nothing
        Me.LT_Horno1.PLCAddressKeypad = ""
        Me.LT_Horno1.PLCAddressLightAmberValue = ""
        Me.LT_Horno1.PLCAddressLightGreenValue = "ALARMA_LUMINICA_VERDE_HORNO"
        Me.LT_Horno1.PLCAddressLightRedValue = "ALARMA_LUZ_ROJA_HORNO"
        Me.LT_Horno1.PLCAddressText = ""
        Me.LT_Horno1.PLCAddressVisible = ""
        Me.LT_Horno1.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LT_Horno1.Size = New System.Drawing.Size(37, 137)
        Me.LT_Horno1.TabIndex = 750
        Me.LT_Horno1.TextPrefix = Nothing
        Me.LT_Horno1.TextSuffix = Nothing
        '
        'Tex_TempMul2H1
        '
        Me.Tex_TempMul2H1.AutoSize = True
        Me.Tex_TempMul2H1.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempMul2H1.Location = New System.Drawing.Point(1030, 351)
        Me.Tex_TempMul2H1.Name = "Tex_TempMul2H1"
        Me.Tex_TempMul2H1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul2H1.TabIndex = 735
        Me.Tex_TempMul2H1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 2"
        Me.Tex_TempMul2H1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TEX_Horno1
        '
        Me.TEX_Horno1.AutoSize = True
        Me.TEX_Horno1.BackColor = System.Drawing.Color.White
        Me.TEX_Horno1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEX_Horno1.Location = New System.Drawing.Point(676, 51)
        Me.TEX_Horno1.Name = "TEX_Horno1"
        Me.TEX_Horno1.Size = New System.Drawing.Size(125, 34)
        Me.TEX_Horno1.TabIndex = 734
        Me.TEX_Horno1.Text = "Horno 1"
        '
        'Tex_CargaHorno1
        '
        Me.Tex_CargaHorno1.AutoSize = True
        Me.Tex_CargaHorno1.BackColor = System.Drawing.Color.White
        Me.Tex_CargaHorno1.ForeColor = System.Drawing.Color.Black
        Me.Tex_CargaHorno1.Location = New System.Drawing.Point(786, 466)
        Me.Tex_CargaHorno1.Name = "Tex_CargaHorno1"
        Me.Tex_CargaHorno1.Size = New System.Drawing.Size(83, 36)
        Me.Tex_CargaHorno1.TabIndex = 733
        Me.Tex_CargaHorno1.Text = "Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Carga"
        Me.Tex_CargaHorno1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempHogueraH1
        '
        Me.Tex_TempHogueraH1.AutoSize = True
        Me.Tex_TempHogueraH1.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempHogueraH1.Location = New System.Drawing.Point(535, 242)
        Me.Tex_TempHogueraH1.Name = "Tex_TempHogueraH1"
        Me.Tex_TempHogueraH1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempHogueraH1.TabIndex = 732
        Me.Tex_TempHogueraH1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hoguera"
        Me.Tex_TempHogueraH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CascarillaXMminuH1
        '
        Me.Tex_CascarillaXMminuH1.AutoSize = True
        Me.Tex_CascarillaXMminuH1.BackColor = System.Drawing.Color.Silver
        Me.Tex_CascarillaXMminuH1.Location = New System.Drawing.Point(774, 232)
        Me.Tex_CascarillaXMminuH1.Name = "Tex_CascarillaXMminuH1"
        Me.Tex_CascarillaXMminuH1.Size = New System.Drawing.Size(114, 36)
        Me.Tex_CascarillaXMminuH1.TabIndex = 731
        Me.Tex_CascarillaXMminuH1.Text = "Kgs. Cascarilla" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Minuto"
        Me.Tex_CascarillaXMminuH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempChimeH1
        '
        Me.Tex_TempChimeH1.AutoSize = True
        Me.Tex_TempChimeH1.BackColor = System.Drawing.Color.White
        Me.Tex_TempChimeH1.Location = New System.Drawing.Point(1049, 71)
        Me.Tex_TempChimeH1.Name = "Tex_TempChimeH1"
        Me.Tex_TempChimeH1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempChimeH1.TabIndex = 730
        Me.Tex_TempChimeH1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chimenea"
        Me.Tex_TempChimeH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempMul1H1
        '
        Me.Tex_TempMul1H1.AutoSize = True
        Me.Tex_TempMul1H1.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempMul1H1.Location = New System.Drawing.Point(1031, 217)
        Me.Tex_TempMul1H1.Name = "Tex_TempMul1H1"
        Me.Tex_TempMul1H1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul1H1.TabIndex = 729
        Me.Tex_TempMul1H1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 1"
        Me.Tex_TempMul1H1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IHorno1
        '
        Me.IHorno1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Horno_sdi_1
        Me.IHorno1.Location = New System.Drawing.Point(431, 48)
        Me.IHorno1.Name = "IHorno1"
        Me.IHorno1.Size = New System.Drawing.Size(734, 499)
        Me.IHorno1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IHorno1.TabIndex = 728
        Me.IHorno1.TabStop = False
        '
        'TexPID_Horno1
        '
        Me.TexPID_Horno1.AutoSize = True
        Me.TexPID_Horno1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_Horno1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_Horno1.Location = New System.Drawing.Point(197, 67)
        Me.TexPID_Horno1.Name = "TexPID_Horno1"
        Me.TexPID_Horno1.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_Horno1.TabIndex = 727
        Me.TexPID_Horno1.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_Horno1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaHorno1
        '
        Me.TexBN_SalidaHorno1.AutoSize = True
        Me.TexBN_SalidaHorno1.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaHorno1.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaHorno1.Location = New System.Drawing.Point(344, 128)
        Me.TexBN_SalidaHorno1.Name = "TexBN_SalidaHorno1"
        Me.TexBN_SalidaHorno1.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaHorno1.TabIndex = 726
        Me.TexBN_SalidaHorno1.Text = "Salida"
        Me.TexBN_SalidaHorno1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempHorno1
        '
        Me.TexBN_RealTempHorno1.AutoSize = True
        Me.TexBN_RealTempHorno1.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempHorno1.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempHorno1.Location = New System.Drawing.Point(276, 129)
        Me.TexBN_RealTempHorno1.Name = "TexBN_RealTempHorno1"
        Me.TexBN_RealTempHorno1.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempHorno1.TabIndex = 725
        Me.TexBN_RealTempHorno1.Text = "Real"
        Me.TexBN_RealTempHorno1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempHorno1
        '
        Me.TexBN_SP_TempHorno1.AutoSize = True
        Me.TexBN_SP_TempHorno1.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempHorno1.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempHorno1.Location = New System.Drawing.Point(191, 129)
        Me.TexBN_SP_TempHorno1.Name = "TexBN_SP_TempHorno1"
        Me.TexBN_SP_TempHorno1.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempHorno1.TabIndex = 724
        Me.TexBN_SP_TempHorno1.Text = "SetPoint"
        Me.TexBN_SP_TempHorno1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Horno1
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(183, 43)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 751
        '
        'Horno_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SHO01)
        Me.Controls.Add(Me.LS_MarchaHorno1)
        Me.Controls.Add(Me.BP_MarchaHorno1)
        Me.Controls.Add(Me.TexRecetaHorno1)
        Me.Controls.Add(Me.MD_TempMul2H1)
        Me.Controls.Add(Me.MD_TempMul1H1)
        Me.Controls.Add(Me.MD_TempChimeH1)
        Me.Controls.Add(Me.MD_CargaHorno1)
        Me.Controls.Add(Me.MD_CascarillaXMminuH1)
        Me.Controls.Add(Me.MD_TempHogueraH1)
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BCF_MenúP_H1)
        Me.Controls.Add(Me.BN_SalidaHorno1)
        Me.Controls.Add(Me.BN_SP_TempHorno1)
        Me.Controls.Add(Me.BP_ParoHorno1)
        Me.Controls.Add(Me.LT_Horno1)
        Me.Controls.Add(Me.Tex_TempMul2H1)
        Me.Controls.Add(Me.TEX_Horno1)
        Me.Controls.Add(Me.Tex_CargaHorno1)
        Me.Controls.Add(Me.Tex_TempHogueraH1)
        Me.Controls.Add(Me.Tex_CascarillaXMminuH1)
        Me.Controls.Add(Me.Tex_TempChimeH1)
        Me.Controls.Add(Me.Tex_TempMul1H1)
        Me.Controls.Add(Me.IHorno1)
        Me.Controls.Add(Me.TexPID_Horno1)
        Me.Controls.Add(Me.TexBN_SalidaHorno1)
        Me.Controls.Add(Me.TexBN_RealTempHorno1)
        Me.Controls.Add(Me.TexBN_SP_TempHorno1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Horno_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Horno1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IHorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SHO01 As AdvancedHMIControls.TempController
    Friend WithEvents Horno1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents LS_MarchaHorno1 As AdvancedHMIControls.PilotLight
    Friend WithEvents BP_MarchaHorno1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents TexRecetaHorno1 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempMul2H1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempMul1H1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempChimeH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CargaHorno1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CascarillaXMminuH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempHogueraH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BCF_MenúP_H1 As FormChangeButton
    Friend WithEvents BN_SalidaHorno1 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempHorno1 As AdvancedHMIControls.BarLevel
    Friend WithEvents BP_ParoHorno1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents LT_Horno1 As AdvancedHMIControls.StackLight
    Friend WithEvents Tex_TempMul2H1 As Label
    Friend WithEvents TEX_Horno1 As Label
    Friend WithEvents Tex_CargaHorno1 As Label
    Friend WithEvents Tex_TempHogueraH1 As Label
    Friend WithEvents Tex_CascarillaXMminuH1 As Label
    Friend WithEvents Tex_TempChimeH1 As Label
    Friend WithEvents Tex_TempMul1H1 As Label
    Friend WithEvents IHorno1 As PictureBox
    Friend WithEvents TexPID_Horno1 As Label
    Friend WithEvents TexBN_SalidaHorno1 As Label
    Friend WithEvents TexBN_RealTempHorno1 As Label
    Friend WithEvents TexBN_SP_TempHorno1 As Label
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
