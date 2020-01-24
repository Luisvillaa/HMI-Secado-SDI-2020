<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerVariadorTH_Cascarilla
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Meter1 = New AdvancedHMIControls.Meter()
        Me.VerV_TH_Cacarilla = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.DigitalPanelMeter11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter8 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter7 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter6 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexVH3 = New System.Windows.Forms.Label()
        Me.FormChangeButton1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.VerV_TH_Cacarilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(655, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 36)
        Me.Label1.TabIndex = 1166
        Me.Label1.Text = "Procentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salida %"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meter1
        '
        Me.Meter1.ComComponent = Me.VerV_TH_Cacarilla
        Me.Meter1.HighlightColor = System.Drawing.Color.Red
        Me.Meter1.Location = New System.Drawing.Point(619, 173)
        Me.Meter1.MaxValue = New Decimal(New Integer() {600, 0, 0, 65536})
        Me.Meter1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Meter1.Name = "Meter1"
        Me.Meter1.NumericFormat = Nothing
        Me.Meter1.PLCAddressText = ""
        Me.Meter1.PLCAddressValue = "40075"
        Me.Meter1.PLCAddressVisible = ""
        Me.Meter1.Size = New System.Drawing.Size(168, 144)
        Me.Meter1.TabIndex = 1165
        Me.Meter1.Text = "Hz"
        Me.Meter1.Value = 1.0R
        Me.Meter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VerV_TH_Cacarilla
        '
        Me.VerV_TH_Cacarilla.DisableSubscriptions = False
        Me.VerV_TH_Cacarilla.IniFileName = ""
        Me.VerV_TH_Cacarilla.IniFileSection = Nothing
        Me.VerV_TH_Cacarilla.IPAddress = "10.1.108.17"
        Me.VerV_TH_Cacarilla.MaxReadGroupSize = 20
        Me.VerV_TH_Cacarilla.PollRateOverride = 500
        Me.VerV_TH_Cacarilla.SwapBytes = True
        Me.VerV_TH_Cacarilla.SwapWords = False
        Me.VerV_TH_Cacarilla.TcpipPort = CType(20257US, UShort)
        Me.VerV_TH_Cacarilla.TimeOut = 3000
        Me.VerV_TH_Cacarilla.UnitId = CType(15, Byte)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(857, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 32)
        Me.Label3.TabIndex = 1168
        Me.Label3.Text = "Alimentador Cascarilla"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter2.DecimalPosition = 1
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(629, 380)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = ""
        Me.DigitalPanelMeter2.PLCAddressValue = "41532"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter2.TabIndex = 1167
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.VerV_TH_Cacarilla
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(1007, 408)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "10082"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight3.TabIndex = 1164
        Me.PilotLight3.Text = "Reversa"
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.VerV_TH_Cacarilla
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(872, 408)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "10082"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight4.TabIndex = 1163
        Me.PilotLight4.Text = "Adelante"
        Me.PilotLight4.Value = False
        Me.PilotLight4.ValueToWrite = 0
        '
        'BCF_MenúP_Cascarilla
        '
        Me.BCF_MenúP_Cascarilla.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_Cascarilla.ComComponent = Nothing
        Me.BCF_MenúP_Cascarilla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_Cascarilla.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_Cascarilla.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_Cascarilla.KeypadWidth = 300
        Me.BCF_MenúP_Cascarilla.Location = New System.Drawing.Point(205, 647)
        Me.BCF_MenúP_Cascarilla.Name = "BCF_MenúP_Cascarilla"
        Me.BCF_MenúP_Cascarilla.Passcode = Nothing
        Me.BCF_MenúP_Cascarilla.PasswordChar = False
        Me.BCF_MenúP_Cascarilla.PLCAddressVisible = ""
        Me.BCF_MenúP_Cascarilla.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_Cascarilla.TabIndex = 1162
        Me.BCF_MenúP_Cascarilla.Text = "Menú Principal"
        Me.BCF_MenúP_Cascarilla.UseVisualStyleBackColor = False
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.VerV_TH_Cacarilla
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(1007, 138)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "10076"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight2.TabIndex = 1161
        Me.PilotLight2.Text = "Electrico"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.VerV_TH_Cacarilla
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(872, 138)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "10076"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight1.TabIndex = 1160
        Me.PilotLight1.Text = "Comunicacón"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'DigitalPanelMeter11
        '
        Me.DigitalPanelMeter11.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter11.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter11.DecimalPosition = 2
        Me.DigitalPanelMeter11.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter11.KeypadMaxValue = 0R
        Me.DigitalPanelMeter11.KeypadMinValue = 0R
        Me.DigitalPanelMeter11.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter11.KeypadText = Nothing
        Me.DigitalPanelMeter11.KeypadWidth = 300
        Me.DigitalPanelMeter11.Location = New System.Drawing.Point(629, 98)
        Me.DigitalPanelMeter11.Name = "DigitalPanelMeter11"
        Me.DigitalPanelMeter11.NumberOfDigits = 5
        Me.DigitalPanelMeter11.PLCAddressKeypad = ""
        Me.DigitalPanelMeter11.PLCAddressValue = "40075"
        Me.DigitalPanelMeter11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter11.TabIndex = 1159
        Me.DigitalPanelMeter11.Value = 0R
        Me.DigitalPanelMeter11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(655, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 36)
        Me.Label12.TabIndex = 1158
        Me.Label12.Text = "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salida Hz"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter10
        '
        Me.DigitalPanelMeter10.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter10.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter10.DecimalPosition = 2
        Me.DigitalPanelMeter10.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter10.KeypadMaxValue = 0R
        Me.DigitalPanelMeter10.KeypadMinValue = 0R
        Me.DigitalPanelMeter10.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter10.KeypadText = Nothing
        Me.DigitalPanelMeter10.KeypadWidth = 300
        Me.DigitalPanelMeter10.Location = New System.Drawing.Point(391, 515)
        Me.DigitalPanelMeter10.Name = "DigitalPanelMeter10"
        Me.DigitalPanelMeter10.NumberOfDigits = 5
        Me.DigitalPanelMeter10.PLCAddressKeypad = ""
        Me.DigitalPanelMeter10.PLCAddressValue = "40079"
        Me.DigitalPanelMeter10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter10.TabIndex = 1157
        Me.DigitalPanelMeter10.Value = 0R
        Me.DigitalPanelMeter10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter8
        '
        Me.DigitalPanelMeter8.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter8.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter8.DecimalPosition = 1
        Me.DigitalPanelMeter8.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter8.KeypadMaxValue = 0R
        Me.DigitalPanelMeter8.KeypadMinValue = 0R
        Me.DigitalPanelMeter8.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter8.KeypadText = Nothing
        Me.DigitalPanelMeter8.KeypadWidth = 300
        Me.DigitalPanelMeter8.Location = New System.Drawing.Point(391, 380)
        Me.DigitalPanelMeter8.Name = "DigitalPanelMeter8"
        Me.DigitalPanelMeter8.NumberOfDigits = 5
        Me.DigitalPanelMeter8.PLCAddressKeypad = ""
        Me.DigitalPanelMeter8.PLCAddressValue = "40078"
        Me.DigitalPanelMeter8.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter8.TabIndex = 1155
        Me.DigitalPanelMeter8.Value = 0R
        Me.DigitalPanelMeter8.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(407, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 36)
        Me.Label9.TabIndex = 1154
        Me.Label9.Text = "Voltaje Interno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CC"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter7
        '
        Me.DigitalPanelMeter7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter7.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter7.DecimalPosition = 2
        Me.DigitalPanelMeter7.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter7.KeypadMaxValue = 0R
        Me.DigitalPanelMeter7.KeypadMinValue = 0R
        Me.DigitalPanelMeter7.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter7.KeypadText = Nothing
        Me.DigitalPanelMeter7.KeypadWidth = 300
        Me.DigitalPanelMeter7.Location = New System.Drawing.Point(391, 239)
        Me.DigitalPanelMeter7.Name = "DigitalPanelMeter7"
        Me.DigitalPanelMeter7.NumberOfDigits = 5
        Me.DigitalPanelMeter7.PLCAddressKeypad = ""
        Me.DigitalPanelMeter7.PLCAddressValue = "40077"
        Me.DigitalPanelMeter7.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter7.TabIndex = 1153
        Me.DigitalPanelMeter7.Value = 0R
        Me.DigitalPanelMeter7.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter6.DecimalPosition = 0
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(391, 642)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 5
        Me.DigitalPanelMeter6.PLCAddressKeypad = ""
        Me.DigitalPanelMeter6.PLCAddressValue = "40080"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter6.TabIndex = 1151
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(401, 593)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 36)
        Me.Label7.TabIndex = 1150
        Me.Label7.Text = "Temperatura de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Variador °C"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.VerV_TH_Cacarilla
        Me.DigitalPanelMeter1.DecimalPosition = 2
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(391, 98)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40074"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter1.TabIndex = 1149
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexVH3
        '
        Me.TexVH3.AutoSize = True
        Me.TexVH3.ForeColor = System.Drawing.Color.Black
        Me.TexVH3.Location = New System.Drawing.Point(405, 58)
        Me.TexVH3.Name = "TexVH3"
        Me.TexVH3.Size = New System.Drawing.Size(108, 36)
        Me.TexVH3.TabIndex = 1148
        Me.TexVH3.Text = "Comando de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia Hz"
        Me.TexVH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton1.FormToOpen = GetType(MfgControl.AdvancedHMI.Ingeniería)
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(989, 647)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = Nothing
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(151, 54)
        Me.FormChangeButton1.TabIndex = 1147
        Me.FormChangeButton1.Text = "Regresar"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(420, 468)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 36)
        Me.Label11.TabIndex = 1156
        Me.Label11.Text = "Voltaje de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salida AC"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(412, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 36)
        Me.Label8.TabIndex = 1152
        Me.Label8.Text = "Corriente de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salida Amp"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VerVariadorTH_Cascarilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Meter1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.BCF_MenúP_Cascarilla)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.DigitalPanelMeter11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DigitalPanelMeter10)
        Me.Controls.Add(Me.DigitalPanelMeter8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DigitalPanelMeter7)
        Me.Controls.Add(Me.DigitalPanelMeter6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.TexVH3)
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "VerVariadorTH_Cascarilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.VerV_TH_Cacarilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Meter1 As AdvancedHMIControls.Meter
    Friend WithEvents VerV_TH_Cacarilla As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents Label3 As Label
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_Cascarilla As FormChangeButton
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents DigitalPanelMeter11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label12 As Label
    Friend WithEvents DigitalPanelMeter10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter8 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label9 As Label
    Friend WithEvents DigitalPanelMeter7 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter6 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label7 As Label
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexVH3 As Label
    Friend WithEvents FormChangeButton1 As FormChangeButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
End Class
