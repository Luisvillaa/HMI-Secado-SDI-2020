<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horno_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horno_3))
        Me.CT_SHO03 = New AdvancedHMIControls.TempController()
        Me.Horno3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.FormChangeButton8 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.BP_ParoHorno1 = New AdvancedHMIControls.MomentaryButton()
        Me.BP_MarchaHorno1 = New AdvancedHMIControls.MomentaryButton()
        Me.TexRecetaHorno3 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempMul2H3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempMul1H3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CargaHorno3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CascarillaXMminuH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempHogueraH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_RegresarH3 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_H3 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BN_SalidaHorno3 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempHorno3 = New AdvancedHMIControls.BarLevel()
        Me.LS_MarchaHorno1 = New AdvancedHMIControls.PilotLight()
        Me.LT_Horno3 = New AdvancedHMIControls.StackLight()
        Me.Tex_TempMul2H3 = New System.Windows.Forms.Label()
        Me.TEX_Horno3 = New System.Windows.Forms.Label()
        Me.Tex_CargaHorno3 = New System.Windows.Forms.Label()
        Me.Tex_TempHogueraH3 = New System.Windows.Forms.Label()
        Me.Tex_CascarillaXMminuH3 = New System.Windows.Forms.Label()
        Me.Tex_TempChimeH3 = New System.Windows.Forms.Label()
        Me.Tex_TempMul1H3 = New System.Windows.Forms.Label()
        Me.IHorno3 = New System.Windows.Forms.PictureBox()
        Me.TexPID_Horno3 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaHorno3 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempHorno3 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempHorno3 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Horno3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IHorno3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SHO03
        '
        Me.CT_SHO03.Button1Text = Nothing
        Me.CT_SHO03.Button2Text = Nothing
        Me.CT_SHO03.ComComponent = Me.Horno3
        Me.CT_SHO03.DecimalPosition = 1
        Me.CT_SHO03.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SHO03.Location = New System.Drawing.Point(204, 418)
        Me.CT_SHO03.Name = "CT_SHO03"
        Me.CT_SHO03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SHO03.PLCAddressClick1 = ""
        Me.CT_SHO03.PLCAddressClick2 = ""
        Me.CT_SHO03.PLCAddressClick3 = ""
        Me.CT_SHO03.PLCAddressClick4 = ""
        Me.CT_SHO03.PLCAddressText = ""
        Me.CT_SHO03.PLCAddressValuePV = "40037"
        Me.CT_SHO03.PLCAddressValueSP = "40038"
        Me.CT_SHO03.PLCAddressVisible = ""
        Me.CT_SHO03.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SHO03.Size = New System.Drawing.Size(200, 201)
        Me.CT_SHO03.TabIndex = 1176
        Me.CT_SHO03.Text = "S-HO-03"
        Me.CT_SHO03.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.CT_SHO03.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.CT_SHO03.Value2Text = "SP"
        Me.CT_SHO03.ValuePV = 0!
        Me.CT_SHO03.ValueSP = 0!
        '
        'Horno3
        '
        Me.Horno3.DisableSubscriptions = False
        Me.Horno3.IniFileName = ""
        Me.Horno3.IniFileSection = Nothing
        Me.Horno3.IPAddress = "10.1.108.8"
        Me.Horno3.MaxReadGroupSize = 20
        Me.Horno3.PollRateOverride = 500
        Me.Horno3.SwapBytes = True
        Me.Horno3.SwapWords = False
        Me.Horno3.TcpipPort = CType(20257US, UShort)
        Me.Horno3.TimeOut = 3000
        Me.Horno3.UnitId = CType(13, Byte)
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.Horno3
        Me.DigitalPanelMeter1.DecimalPosition = 1
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(1052, 76)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40013"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(113, 49)
        Me.DigitalPanelMeter1.TabIndex = 1174
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 700.0R
        Me.BarMeter1.BarHighWarningSetPoint = 600.0R
        Me.BarMeter1.BarLowSetPoint = 250.0R
        Me.BarMeter1.ComComponent = Me.Horno3
        Me.BarMeter1.HighlightColor = System.Drawing.Color.Red
        Me.BarMeter1.IniFileName = ""
        Me.BarMeter1.IniFileSection = Nothing
        Me.BarMeter1.Location = New System.Drawing.Point(96, 103)
        Me.BarMeter1.Maximum = 1000.0R
        Me.BarMeter1.Minimum = 0R
        Me.BarMeter1.Name = "BarMeter1"
        Me.BarMeter1.PLCAddressText = ""
        Me.BarMeter1.PLCAddressValue = CType(resources.GetObject("BarMeter1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.BarMeter1.PLCAddressVisible = ""
        Me.BarMeter1.Size = New System.Drawing.Size(43, 237)
        Me.BarMeter1.TabIndex = 631
        Me.BarMeter1.Value = 0R
        '
        'FormChangeButton8
        '
        Me.FormChangeButton8.BackColor = System.Drawing.Color.Green
        Me.FormChangeButton8.ComComponent = Nothing
        Me.FormChangeButton8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormChangeButton8.ForeColor = System.Drawing.Color.White
        Me.FormChangeButton8.FormToOpen = Nothing
        Me.FormChangeButton8.KeypadWidth = 300
        Me.FormChangeButton8.Location = New System.Drawing.Point(417, 662)
        Me.FormChangeButton8.Name = "FormChangeButton8"
        Me.FormChangeButton8.Passcode = Nothing
        Me.FormChangeButton8.PasswordChar = False
        Me.FormChangeButton8.PLCAddressVisible = ""
        Me.FormChangeButton8.Size = New System.Drawing.Size(184, 54)
        Me.FormChangeButton8.TabIndex = 1173
        Me.FormChangeButton8.Text = "Variador TH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cascarilla"
        Me.FormChangeButton8.UseVisualStyleBackColor = False
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Red
        Me.BasicButton1.ComComponent = Me.Horno3
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(705, 139)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressVisible = "10123"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 1172
        Me.BasicButton1.Text = "Clientes sin Escoger"
        Me.BasicButton1.TextAlternate = ""
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'BP_ParoHorno1
        '
        Me.BP_ParoHorno1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.BP_ParoHorno1.ComComponent = Me.Horno3
        Me.BP_ParoHorno1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.BP_ParoHorno1.Location = New System.Drawing.Point(623, 80)
        Me.BP_ParoHorno1.MaximumHoldTime = 3000
        Me.BP_ParoHorno1.MinimumHoldTime = 500
        Me.BP_ParoHorno1.Name = "BP_ParoHorno1"
        Me.BP_ParoHorno1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.BP_ParoHorno1.PLCAddressClick = "00062"
        Me.BP_ParoHorno1.PLCAddressVisible = ""
        Me.BP_ParoHorno1.Size = New System.Drawing.Size(83, 122)
        Me.BP_ParoHorno1.TabIndex = 1169
        Me.BP_ParoHorno1.Text = "Paro"
        '
        'BP_MarchaHorno1
        '
        Me.BP_MarchaHorno1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.BP_MarchaHorno1.ComComponent = Me.Horno3
        Me.BP_MarchaHorno1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.BP_MarchaHorno1.Location = New System.Drawing.Point(460, 80)
        Me.BP_MarchaHorno1.MaximumHoldTime = 3000
        Me.BP_MarchaHorno1.MinimumHoldTime = 500
        Me.BP_MarchaHorno1.Name = "BP_MarchaHorno1"
        Me.BP_MarchaHorno1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.BP_MarchaHorno1.PLCAddressClick = "00061"
        Me.BP_MarchaHorno1.PLCAddressVisible = ""
        Me.BP_MarchaHorno1.Size = New System.Drawing.Size(83, 122)
        Me.BP_MarchaHorno1.TabIndex = 1168
        Me.BP_MarchaHorno1.Text = "Marcha"
        '
        'TexRecetaHorno3
        '
        Me.TexRecetaHorno3.AutoSize = True
        Me.TexRecetaHorno3.BackColor = System.Drawing.Color.Transparent
        Me.TexRecetaHorno3.ComComponent = Me.Horno3
        Me.TexRecetaHorno3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexRecetaHorno3.ForeColor = System.Drawing.Color.Black
        Me.TexRecetaHorno3.HighlightColor = System.Drawing.Color.Red
        Me.TexRecetaHorno3.HighlightColor2 = System.Drawing.Color.Red
        Me.TexRecetaHorno3.HighlightKeyCharacter = "!"
        Me.TexRecetaHorno3.HighlightKeyCharacter2 = "."
        Me.TexRecetaHorno3.IniFileName = Nothing
        Me.TexRecetaHorno3.Location = New System.Drawing.Point(920, 240)
        Me.TexRecetaHorno3.Messages.Add(CType(resources.GetObject("TexRecetaHorno3.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno3.Messages.Add(CType(resources.GetObject("TexRecetaHorno3.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno3.Messages.Add(CType(resources.GetObject("TexRecetaHorno3.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno3.Messages.Add(CType(resources.GetObject("TexRecetaHorno3.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno3.Messages.Add(CType(resources.GetObject("TexRecetaHorno3.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaHorno3.Name = "TexRecetaHorno3"
        Me.TexRecetaHorno3.PLCAddressValue = "40517"
        Me.TexRecetaHorno3.PLCAddressVisible = ""
        Me.TexRecetaHorno3.ShowMessageNumber = False
        Me.TexRecetaHorno3.Size = New System.Drawing.Size(89, 22)
        Me.TexRecetaHorno3.SpeakMessage = False
        Me.TexRecetaHorno3.TabIndex = 1167
        Me.TexRecetaHorno3.Text = "Receta 0"
        Me.TexRecetaHorno3.TextPrefix = Nothing
        Me.TexRecetaHorno3.Value = 0
        '
        'MD_TempMul2H3
        '
        Me.MD_TempMul2H3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul2H3.ComComponent = Me.Horno3
        Me.MD_TempMul2H3.DecimalPosition = 1
        Me.MD_TempMul2H3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul2H3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul2H3.KeypadMaxValue = 0R
        Me.MD_TempMul2H3.KeypadMinValue = 0R
        Me.MD_TempMul2H3.KeypadScaleFactor = 1.0R
        Me.MD_TempMul2H3.KeypadText = Nothing
        Me.MD_TempMul2H3.KeypadWidth = 300
        Me.MD_TempMul2H3.Location = New System.Drawing.Point(1033, 382)
        Me.MD_TempMul2H3.Name = "MD_TempMul2H3"
        Me.MD_TempMul2H3.NumberOfDigits = 5
        Me.MD_TempMul2H3.PLCAddressKeypad = ""
        Me.MD_TempMul2H3.PLCAddressValue = "40034"
        Me.MD_TempMul2H3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul2H3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul2H3.TabIndex = 1166
        Me.MD_TempMul2H3.Value = 0R
        Me.MD_TempMul2H3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul2H3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempMul1H3
        '
        Me.MD_TempMul1H3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul1H3.ComComponent = Me.Horno3
        Me.MD_TempMul1H3.DecimalPosition = 1
        Me.MD_TempMul1H3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul1H3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul1H3.KeypadMaxValue = 0R
        Me.MD_TempMul1H3.KeypadMinValue = 0R
        Me.MD_TempMul1H3.KeypadScaleFactor = 1.0R
        Me.MD_TempMul1H3.KeypadText = Nothing
        Me.MD_TempMul1H3.KeypadWidth = 300
        Me.MD_TempMul1H3.Location = New System.Drawing.Point(1033, 248)
        Me.MD_TempMul1H3.Name = "MD_TempMul1H3"
        Me.MD_TempMul1H3.NumberOfDigits = 5
        Me.MD_TempMul1H3.PLCAddressKeypad = ""
        Me.MD_TempMul1H3.PLCAddressValue = "40027"
        Me.MD_TempMul1H3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul1H3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul1H3.TabIndex = 1165
        Me.MD_TempMul1H3.Value = 0R
        Me.MD_TempMul1H3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul1H3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CargaHorno3
        '
        Me.MD_CargaHorno3.BackColor = System.Drawing.Color.Transparent
        Me.MD_CargaHorno3.ComComponent = Me.Horno3
        Me.MD_CargaHorno3.DecimalPosition = 0
        Me.MD_CargaHorno3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CargaHorno3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CargaHorno3.KeypadMaxValue = 0R
        Me.MD_CargaHorno3.KeypadMinValue = 0R
        Me.MD_CargaHorno3.KeypadScaleFactor = 1.0R
        Me.MD_CargaHorno3.KeypadText = Nothing
        Me.MD_CargaHorno3.KeypadWidth = 300
        Me.MD_CargaHorno3.Location = New System.Drawing.Point(782, 497)
        Me.MD_CargaHorno3.Name = "MD_CargaHorno3"
        Me.MD_CargaHorno3.NumberOfDigits = 5
        Me.MD_CargaHorno3.PLCAddressKeypad = ""
        Me.MD_CargaHorno3.PLCAddressValue = "40436"
        Me.MD_CargaHorno3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaHorno3.Size = New System.Drawing.Size(113, 49)
        Me.MD_CargaHorno3.TabIndex = 1164
        Me.MD_CargaHorno3.Value = 0R
        Me.MD_CargaHorno3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaHorno3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CascarillaXMminuH3
        '
        Me.MD_CascarillaXMminuH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_CascarillaXMminuH3.ComComponent = Me.Horno3
        Me.MD_CascarillaXMminuH3.DecimalPosition = 0
        Me.MD_CascarillaXMminuH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CascarillaXMminuH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CascarillaXMminuH3.KeypadMaxValue = 0R
        Me.MD_CascarillaXMminuH3.KeypadMinValue = 0R
        Me.MD_CascarillaXMminuH3.KeypadScaleFactor = 1.0R
        Me.MD_CascarillaXMminuH3.KeypadText = Nothing
        Me.MD_CascarillaXMminuH3.KeypadWidth = 300
        Me.MD_CascarillaXMminuH3.Location = New System.Drawing.Point(763, 263)
        Me.MD_CascarillaXMminuH3.Name = "MD_CascarillaXMminuH3"
        Me.MD_CascarillaXMminuH3.NumberOfDigits = 5
        Me.MD_CascarillaXMminuH3.PLCAddressKeypad = ""
        Me.MD_CascarillaXMminuH3.PLCAddressValue = "40556"
        Me.MD_CascarillaXMminuH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_CascarillaXMminuH3.TabIndex = 1163
        Me.MD_CascarillaXMminuH3.Value = 0R
        Me.MD_CascarillaXMminuH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempHogueraH3
        '
        Me.MD_TempHogueraH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempHogueraH3.ComComponent = Me.Horno3
        Me.MD_TempHogueraH3.DecimalPosition = 1
        Me.MD_TempHogueraH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempHogueraH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempHogueraH3.KeypadMaxValue = 0R
        Me.MD_TempHogueraH3.KeypadMinValue = 0R
        Me.MD_TempHogueraH3.KeypadScaleFactor = 1.0R
        Me.MD_TempHogueraH3.KeypadText = Nothing
        Me.MD_TempHogueraH3.KeypadWidth = 300
        Me.MD_TempHogueraH3.Location = New System.Drawing.Point(537, 273)
        Me.MD_TempHogueraH3.Name = "MD_TempHogueraH3"
        Me.MD_TempHogueraH3.NumberOfDigits = 5
        Me.MD_TempHogueraH3.PLCAddressKeypad = ""
        Me.MD_TempHogueraH3.PLCAddressValue = "40020"
        Me.MD_TempHogueraH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempHogueraH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempHogueraH3.TabIndex = 1162
        Me.MD_TempHogueraH3.Value = 0R
        Me.MD_TempHogueraH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempHogueraH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_RegresarH3
        '
        Me.BCF_RegresarH3.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH3.ComComponent = Nothing
        Me.BCF_RegresarH3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH3.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH3.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_RegresarH3.KeypadWidth = 300
        Me.BCF_RegresarH3.Location = New System.Drawing.Point(490, 545)
        Me.BCF_RegresarH3.Name = "BCF_RegresarH3"
        Me.BCF_RegresarH3.Passcode = Nothing
        Me.BCF_RegresarH3.PasswordChar = False
        Me.BCF_RegresarH3.PLCAddressVisible = ""
        Me.BCF_RegresarH3.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH3.TabIndex = 1161
        Me.BCF_RegresarH3.Text = "Regresar"
        Me.BCF_RegresarH3.UseVisualStyleBackColor = False
        '
        'BCF_MenúP_H3
        '
        Me.BCF_MenúP_H3.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_H3.ComComponent = Nothing
        Me.BCF_MenúP_H3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_H3.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_H3.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_H3.KeypadWidth = 300
        Me.BCF_MenúP_H3.Location = New System.Drawing.Point(176, 662)
        Me.BCF_MenúP_H3.Name = "BCF_MenúP_H3"
        Me.BCF_MenúP_H3.Passcode = Nothing
        Me.BCF_MenúP_H3.PasswordChar = False
        Me.BCF_MenúP_H3.PLCAddressVisible = ""
        Me.BCF_MenúP_H3.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_H3.TabIndex = 1160
        Me.BCF_MenúP_H3.Text = "Menú Principal"
        Me.BCF_MenúP_H3.UseVisualStyleBackColor = False
        '
        'BN_SalidaHorno3
        '
        Me.BN_SalidaHorno3.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaHorno3.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaHorno3.ComComponent = Me.Horno3
        Me.BN_SalidaHorno3.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaHorno3.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaHorno3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaHorno3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaHorno3.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaHorno3.Location = New System.Drawing.Point(358, 138)
        Me.BN_SalidaHorno3.Maximum = 1000.0R
        Me.BN_SalidaHorno3.Minimum = 0R
        Me.BN_SalidaHorno3.Name = "BN_SalidaHorno3"
        Me.BN_SalidaHorno3.NumericFormat = Nothing
        Me.BN_SalidaHorno3.PLCAddressValue = "40530"
        Me.BN_SalidaHorno3.ShowValue = True
        Me.BN_SalidaHorno3.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaHorno3.TabIndex = 1159
        Me.BN_SalidaHorno3.Text = "BarLevel3"
        Me.BN_SalidaHorno3.TextSuffix = Nothing
        Me.BN_SalidaHorno3.Value = 0R
        Me.BN_SalidaHorno3.ValueScaleFactor = 0.1R
        '
        'BN_SP_TempHorno3
        '
        Me.BN_SP_TempHorno3.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempHorno3.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempHorno3.ComComponent = Me.Horno3
        Me.BN_SP_TempHorno3.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempHorno3.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempHorno3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempHorno3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempHorno3.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempHorno3.Location = New System.Drawing.Point(216, 139)
        Me.BN_SP_TempHorno3.Maximum = 1000.0R
        Me.BN_SP_TempHorno3.Minimum = 0R
        Me.BN_SP_TempHorno3.Name = "BN_SP_TempHorno3"
        Me.BN_SP_TempHorno3.NumericFormat = Nothing
        Me.BN_SP_TempHorno3.PLCAddressValue = "40038"
        Me.BN_SP_TempHorno3.ShowValue = True
        Me.BN_SP_TempHorno3.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempHorno3.TabIndex = 1158
        Me.BN_SP_TempHorno3.Text = "BarLevel1"
        Me.BN_SP_TempHorno3.TextSuffix = Nothing
        Me.BN_SP_TempHorno3.Value = 0R
        Me.BN_SP_TempHorno3.ValueScaleFactor = 0.1R
        '
        'LS_MarchaHorno1
        '
        Me.LS_MarchaHorno1.Blink = False
        Me.LS_MarchaHorno1.ComComponent = Me.Horno3
        Me.LS_MarchaHorno1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaHorno1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaHorno1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaHorno1.Location = New System.Drawing.Point(542, 110)
        Me.LS_MarchaHorno1.Name = "LS_MarchaHorno1"
        Me.LS_MarchaHorno1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaHorno1.PLCAddressClick = ""
        Me.LS_MarchaHorno1.PLCAddressText = ""
        Me.LS_MarchaHorno1.PLCAddressValue = "10023"
        Me.LS_MarchaHorno1.PLCAddressVisible = ""
        Me.LS_MarchaHorno1.Size = New System.Drawing.Size(83, 88)
        Me.LS_MarchaHorno1.TabIndex = 1170
        Me.LS_MarchaHorno1.Value = False
        Me.LS_MarchaHorno1.ValueToWrite = 0
        '
        'LT_Horno3
        '
        Me.LT_Horno3.ComComponent = Me.Horno3
        Me.LT_Horno3.ForeColor = System.Drawing.Color.White
        Me.LT_Horno3.HighlightColor = System.Drawing.Color.Red
        Me.LT_Horno3.HighlightKeyCharacter = "!"
        Me.LT_Horno3.KeypadText = Nothing
        Me.LT_Horno3.LightAmberEnable = True
        Me.LT_Horno3.LightAmberValue = False
        Me.LT_Horno3.LightBlueEnable = True
        Me.LT_Horno3.LightBlueValue = False
        Me.LT_Horno3.LightGreenEnable = True
        Me.LT_Horno3.LightGreenValue = False
        Me.LT_Horno3.LightRedEnable = True
        Me.LT_Horno3.LightRedValue = False
        Me.LT_Horno3.Location = New System.Drawing.Point(990, 43)
        Me.LT_Horno3.Name = "LT_Horno3"
        Me.LT_Horno3.NumericFormat = Nothing
        Me.LT_Horno3.PLCAddressKeypad = ""
        Me.LT_Horno3.PLCAddressLightAmberValue = ""
        Me.LT_Horno3.PLCAddressLightGreenValue = "11024"
        Me.LT_Horno3.PLCAddressLightRedValue = "11025"
        Me.LT_Horno3.PLCAddressText = ""
        Me.LT_Horno3.PLCAddressVisible = ""
        Me.LT_Horno3.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LT_Horno3.Size = New System.Drawing.Size(37, 137)
        Me.LT_Horno3.TabIndex = 1171
        Me.LT_Horno3.TextPrefix = Nothing
        Me.LT_Horno3.TextSuffix = Nothing
        '
        'Tex_TempMul2H3
        '
        Me.Tex_TempMul2H3.AutoSize = True
        Me.Tex_TempMul2H3.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempMul2H3.Location = New System.Drawing.Point(1041, 343)
        Me.Tex_TempMul2H3.Name = "Tex_TempMul2H3"
        Me.Tex_TempMul2H3.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul2H3.TabIndex = 1157
        Me.Tex_TempMul2H3.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 2"
        Me.Tex_TempMul2H3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TEX_Horno3
        '
        Me.TEX_Horno3.AutoSize = True
        Me.TEX_Horno3.BackColor = System.Drawing.Color.White
        Me.TEX_Horno3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEX_Horno3.Location = New System.Drawing.Point(683, 43)
        Me.TEX_Horno3.Name = "TEX_Horno3"
        Me.TEX_Horno3.Size = New System.Drawing.Size(125, 34)
        Me.TEX_Horno3.TabIndex = 1156
        Me.TEX_Horno3.Text = "Horno 3"
        '
        'Tex_CargaHorno3
        '
        Me.Tex_CargaHorno3.AutoSize = True
        Me.Tex_CargaHorno3.BackColor = System.Drawing.Color.White
        Me.Tex_CargaHorno3.ForeColor = System.Drawing.Color.Black
        Me.Tex_CargaHorno3.Location = New System.Drawing.Point(793, 458)
        Me.Tex_CargaHorno3.Name = "Tex_CargaHorno3"
        Me.Tex_CargaHorno3.Size = New System.Drawing.Size(83, 36)
        Me.Tex_CargaHorno3.TabIndex = 1155
        Me.Tex_CargaHorno3.Text = "Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Carga"
        Me.Tex_CargaHorno3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempHogueraH3
        '
        Me.Tex_TempHogueraH3.AutoSize = True
        Me.Tex_TempHogueraH3.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempHogueraH3.Location = New System.Drawing.Point(542, 234)
        Me.Tex_TempHogueraH3.Name = "Tex_TempHogueraH3"
        Me.Tex_TempHogueraH3.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempHogueraH3.TabIndex = 1154
        Me.Tex_TempHogueraH3.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hoguera"
        Me.Tex_TempHogueraH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CascarillaXMminuH3
        '
        Me.Tex_CascarillaXMminuH3.AutoSize = True
        Me.Tex_CascarillaXMminuH3.BackColor = System.Drawing.Color.Silver
        Me.Tex_CascarillaXMminuH3.Location = New System.Drawing.Point(762, 224)
        Me.Tex_CascarillaXMminuH3.Name = "Tex_CascarillaXMminuH3"
        Me.Tex_CascarillaXMminuH3.Size = New System.Drawing.Size(114, 36)
        Me.Tex_CascarillaXMminuH3.TabIndex = 1153
        Me.Tex_CascarillaXMminuH3.Text = "Kgs. Cascarilla" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Minuto"
        Me.Tex_CascarillaXMminuH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempChimeH3
        '
        Me.Tex_TempChimeH3.AutoSize = True
        Me.Tex_TempChimeH3.BackColor = System.Drawing.Color.White
        Me.Tex_TempChimeH3.Location = New System.Drawing.Point(1060, 37)
        Me.Tex_TempChimeH3.Name = "Tex_TempChimeH3"
        Me.Tex_TempChimeH3.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempChimeH3.TabIndex = 1152
        Me.Tex_TempChimeH3.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chimenea"
        Me.Tex_TempChimeH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempMul1H3
        '
        Me.Tex_TempMul1H3.AutoSize = True
        Me.Tex_TempMul1H3.BackColor = System.Drawing.Color.Silver
        Me.Tex_TempMul1H3.Location = New System.Drawing.Point(1042, 209)
        Me.Tex_TempMul1H3.Name = "Tex_TempMul1H3"
        Me.Tex_TempMul1H3.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul1H3.TabIndex = 1151
        Me.Tex_TempMul1H3.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 1"
        Me.Tex_TempMul1H3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IHorno3
        '
        Me.IHorno3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Horno_sdi_1
        Me.IHorno3.Location = New System.Drawing.Point(438, 40)
        Me.IHorno3.Name = "IHorno3"
        Me.IHorno3.Size = New System.Drawing.Size(734, 499)
        Me.IHorno3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IHorno3.TabIndex = 1150
        Me.IHorno3.TabStop = False
        '
        'TexPID_Horno3
        '
        Me.TexPID_Horno3.AutoSize = True
        Me.TexPID_Horno3.BackColor = System.Drawing.Color.Silver
        Me.TexPID_Horno3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_Horno3.Location = New System.Drawing.Point(203, 59)
        Me.TexPID_Horno3.Name = "TexPID_Horno3"
        Me.TexPID_Horno3.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_Horno3.TabIndex = 1149
        Me.TexPID_Horno3.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_Horno3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaHorno3
        '
        Me.TexBN_SalidaHorno3.AutoSize = True
        Me.TexBN_SalidaHorno3.BackColor = System.Drawing.Color.DimGray
        Me.TexBN_SalidaHorno3.ForeColor = System.Drawing.Color.White
        Me.TexBN_SalidaHorno3.Location = New System.Drawing.Point(351, 120)
        Me.TexBN_SalidaHorno3.Name = "TexBN_SalidaHorno3"
        Me.TexBN_SalidaHorno3.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaHorno3.TabIndex = 1148
        Me.TexBN_SalidaHorno3.Text = "Salida"
        Me.TexBN_SalidaHorno3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempHorno3
        '
        Me.TexBN_RealTempHorno3.AutoSize = True
        Me.TexBN_RealTempHorno3.BackColor = System.Drawing.Color.DimGray
        Me.TexBN_RealTempHorno3.ForeColor = System.Drawing.Color.White
        Me.TexBN_RealTempHorno3.Location = New System.Drawing.Point(284, 121)
        Me.TexBN_RealTempHorno3.Name = "TexBN_RealTempHorno3"
        Me.TexBN_RealTempHorno3.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempHorno3.TabIndex = 1147
        Me.TexBN_RealTempHorno3.Text = "Real"
        Me.TexBN_RealTempHorno3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempHorno3
        '
        Me.TexBN_SP_TempHorno3.AutoSize = True
        Me.TexBN_SP_TempHorno3.BackColor = System.Drawing.Color.DimGray
        Me.TexBN_SP_TempHorno3.ForeColor = System.Drawing.Color.White
        Me.TexBN_SP_TempHorno3.Location = New System.Drawing.Point(198, 121)
        Me.TexBN_SP_TempHorno3.Name = "TexBN_SP_TempHorno3"
        Me.TexBN_SP_TempHorno3.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempHorno3.TabIndex = 1146
        Me.TexBN_SP_TempHorno3.Text = "SetPoint"
        Me.TexBN_SP_TempHorno3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Horno3
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 38)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 1175
        '
        'Horno_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SHO03)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.FormChangeButton8)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.BP_ParoHorno1)
        Me.Controls.Add(Me.BP_MarchaHorno1)
        Me.Controls.Add(Me.TexRecetaHorno3)
        Me.Controls.Add(Me.MD_TempMul2H3)
        Me.Controls.Add(Me.MD_TempMul1H3)
        Me.Controls.Add(Me.MD_CargaHorno3)
        Me.Controls.Add(Me.MD_CascarillaXMminuH3)
        Me.Controls.Add(Me.MD_TempHogueraH3)
        Me.Controls.Add(Me.BCF_RegresarH3)
        Me.Controls.Add(Me.BCF_MenúP_H3)
        Me.Controls.Add(Me.BN_SalidaHorno3)
        Me.Controls.Add(Me.BN_SP_TempHorno3)
        Me.Controls.Add(Me.LS_MarchaHorno1)
        Me.Controls.Add(Me.LT_Horno3)
        Me.Controls.Add(Me.Tex_TempMul2H3)
        Me.Controls.Add(Me.TEX_Horno3)
        Me.Controls.Add(Me.Tex_CargaHorno3)
        Me.Controls.Add(Me.Tex_TempHogueraH3)
        Me.Controls.Add(Me.Tex_CascarillaXMminuH3)
        Me.Controls.Add(Me.Tex_TempChimeH3)
        Me.Controls.Add(Me.Tex_TempMul1H3)
        Me.Controls.Add(Me.IHorno3)
        Me.Controls.Add(Me.TexPID_Horno3)
        Me.Controls.Add(Me.TexBN_SalidaHorno3)
        Me.Controls.Add(Me.TexBN_RealTempHorno3)
        Me.Controls.Add(Me.TexBN_SP_TempHorno3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Horno_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Horno3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IHorno3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SHO03 As AdvancedHMIControls.TempController
    Friend WithEvents Horno3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents FormChangeButton8 As FormChangeButton
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ParoHorno1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents BP_MarchaHorno1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents TexRecetaHorno3 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempMul2H3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempMul1H3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CargaHorno3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CascarillaXMminuH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempHogueraH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_RegresarH3 As FormChangeButton
    Friend WithEvents BCF_MenúP_H3 As FormChangeButton
    Friend WithEvents BN_SalidaHorno3 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempHorno3 As AdvancedHMIControls.BarLevel
    Friend WithEvents LS_MarchaHorno1 As AdvancedHMIControls.PilotLight
    Friend WithEvents LT_Horno3 As AdvancedHMIControls.StackLight
    Friend WithEvents Tex_TempMul2H3 As Label
    Friend WithEvents TEX_Horno3 As Label
    Friend WithEvents Tex_CargaHorno3 As Label
    Friend WithEvents Tex_TempHogueraH3 As Label
    Friend WithEvents Tex_CascarillaXMminuH3 As Label
    Friend WithEvents Tex_TempChimeH3 As Label
    Friend WithEvents Tex_TempMul1H3 As Label
    Friend WithEvents IHorno3 As PictureBox
    Friend WithEvents TexPID_Horno3 As Label
    Friend WithEvents TexBN_SalidaHorno3 As Label
    Friend WithEvents TexBN_RealTempHorno3 As Label
    Friend WithEvents TexBN_SP_TempHorno3 As Label
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
