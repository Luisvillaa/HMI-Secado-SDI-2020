<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajustes_Variador_H3
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.AjustesV_H3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PilotLight5 = New AdvancedHMIControls.PilotLight()
        Me.MomentaryButton3 = New AdvancedHMIControls.MomentaryButton()
        Me.MomentaryButton2 = New AdvancedHMIControls.MomentaryButton()
        Me.MomentaryButton1 = New AdvancedHMIControls.MomentaryButton()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Meter1 = New AdvancedHMIControls.Meter()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.DigitalPanelMeter11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter8 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter7 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter6 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexVH3 = New System.Windows.Forms.Label()
        Me.FormChangeButton1 = New MfgControl.AdvancedHMI.FormChangeButton()
        CType(Me.AjustesV_H3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(344, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 32)
        Me.Label3.TabIndex = 1165
        Me.Label3.Text = "Ajustes Alimentador Cascarilla"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter3
        '
        Me.DigitalPanelMeter3.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter3.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter3.DecimalPosition = 2
        Me.DigitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter3.KeypadMaxValue = 0R
        Me.DigitalPanelMeter3.KeypadMinValue = 0R
        Me.DigitalPanelMeter3.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter3.KeypadText = Nothing
        Me.DigitalPanelMeter3.KeypadWidth = 300
        Me.DigitalPanelMeter3.Location = New System.Drawing.Point(1014, 315)
        Me.DigitalPanelMeter3.Name = "DigitalPanelMeter3"
        Me.DigitalPanelMeter3.NumberOfDigits = 5
        Me.DigitalPanelMeter3.PLCAddressKeypad = "40397"
        Me.DigitalPanelMeter3.PLCAddressValue = "40397"
        Me.DigitalPanelMeter3.PLCAddressVisible = "10071"
        Me.DigitalPanelMeter3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter3.TabIndex = 1164
        Me.DigitalPanelMeter3.Value = 0R
        Me.DigitalPanelMeter3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'AjustesV_H3
        '
        Me.AjustesV_H3.DisableSubscriptions = False
        Me.AjustesV_H3.IniFileName = ""
        Me.AjustesV_H3.IniFileSection = Nothing
        Me.AjustesV_H3.IPAddress = "10.1.108.8"
        Me.AjustesV_H3.MaxReadGroupSize = 20
        Me.AjustesV_H3.PollRateOverride = 500
        Me.AjustesV_H3.SwapBytes = True
        Me.AjustesV_H3.SwapWords = False
        Me.AjustesV_H3.TcpipPort = CType(20257US, UShort)
        Me.AjustesV_H3.TimeOut = 3000
        Me.AjustesV_H3.UnitId = CType(13, Byte)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1040, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 36)
        Me.Label2.TabIndex = 1163
        Me.Label2.Text = "Cambiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PilotLight5
        '
        Me.PilotLight5.Blink = False
        Me.PilotLight5.ComComponent = Me.AjustesV_H3
        Me.PilotLight5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight5.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight5.Location = New System.Drawing.Point(879, 251)
        Me.PilotLight5.Name = "PilotLight5"
        Me.PilotLight5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight5.PLCAddressClick = ""
        Me.PilotLight5.PLCAddressText = ""
        Me.PilotLight5.PLCAddressValue = "10014"
        Me.PilotLight5.PLCAddressVisible = "10071"
        Me.PilotLight5.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight5.TabIndex = 1162
        Me.PilotLight5.Text = "Marcha"
        Me.PilotLight5.Value = False
        Me.PilotLight5.ValueToWrite = 0
        '
        'MomentaryButton3
        '
        Me.MomentaryButton3.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MomentaryButton3.ComComponent = Me.AjustesV_H3
        Me.MomentaryButton3.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton3.Location = New System.Drawing.Point(734, 251)
        Me.MomentaryButton3.MaximumHoldTime = 3000
        Me.MomentaryButton3.MinimumHoldTime = 500
        Me.MomentaryButton3.Name = "MomentaryButton3"
        Me.MomentaryButton3.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton3.PLCAddressClick = "00014"
        Me.MomentaryButton3.PLCAddressVisible = "10071"
        Me.MomentaryButton3.Size = New System.Drawing.Size(120, 176)
        Me.MomentaryButton3.TabIndex = 1161
        Me.MomentaryButton3.Text = "Marcha"
        '
        'MomentaryButton2
        '
        Me.MomentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MomentaryButton2.ComComponent = Me.AjustesV_H3
        Me.MomentaryButton2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton2.Location = New System.Drawing.Point(734, 48)
        Me.MomentaryButton2.MaximumHoldTime = 3000
        Me.MomentaryButton2.MinimumHoldTime = 500
        Me.MomentaryButton2.Name = "MomentaryButton2"
        Me.MomentaryButton2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton2.PLCAddressClick = "00071"
        Me.MomentaryButton2.PLCAddressVisible = ""
        Me.MomentaryButton2.Size = New System.Drawing.Size(120, 176)
        Me.MomentaryButton2.TabIndex = 1160
        Me.MomentaryButton2.Text = "Modo Trabajo"
        '
        'MomentaryButton1
        '
        Me.MomentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MomentaryButton1.ComComponent = Me.AjustesV_H3
        Me.MomentaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton1.Location = New System.Drawing.Point(734, 456)
        Me.MomentaryButton1.MaximumHoldTime = 3000
        Me.MomentaryButton1.MinimumHoldTime = 500
        Me.MomentaryButton1.Name = "MomentaryButton1"
        Me.MomentaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton1.PLCAddressClick = "00100"
        Me.MomentaryButton1.PLCAddressVisible = ""
        Me.MomentaryButton1.Size = New System.Drawing.Size(120, 176)
        Me.MomentaryButton1.TabIndex = 1159
        Me.MomentaryButton1.Text = "Dirección"
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter2.DecimalPosition = 1
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(435, 383)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = ""
        Me.DigitalPanelMeter2.PLCAddressValue = "40530"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter2.TabIndex = 1158
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(461, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 36)
        Me.Label1.TabIndex = 1157
        Me.Label1.Text = "Procentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salida %"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meter1
        '
        Me.Meter1.ComComponent = Me.AjustesV_H3
        Me.Meter1.HighlightColor = System.Drawing.Color.Red
        Me.Meter1.Location = New System.Drawing.Point(425, 176)
        Me.Meter1.MaxValue = New Decimal(New Integer() {600, 0, 0, 65536})
        Me.Meter1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Meter1.Name = "Meter1"
        Me.Meter1.NumericFormat = Nothing
        Me.Meter1.PLCAddressText = ""
        Me.Meter1.PLCAddressValue = "40340"
        Me.Meter1.PLCAddressVisible = ""
        Me.Meter1.Size = New System.Drawing.Size(168, 144)
        Me.Meter1.TabIndex = 1156
        Me.Meter1.Text = "Hz"
        Me.Meter1.Value = 1.0R
        Me.Meter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.AjustesV_H3
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(1014, 455)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "10100"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight3.TabIndex = 1155
        Me.PilotLight3.Text = "Reversa"
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.AjustesV_H3
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(879, 455)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "10100"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight4.TabIndex = 1154
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
        Me.BCF_MenúP_Cascarilla.Location = New System.Drawing.Point(435, 650)
        Me.BCF_MenúP_Cascarilla.Name = "BCF_MenúP_Cascarilla"
        Me.BCF_MenúP_Cascarilla.Passcode = Nothing
        Me.BCF_MenúP_Cascarilla.PasswordChar = False
        Me.BCF_MenúP_Cascarilla.PLCAddressVisible = ""
        Me.BCF_MenúP_Cascarilla.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_Cascarilla.TabIndex = 1153
        Me.BCF_MenúP_Cascarilla.Text = "Menú Principal"
        Me.BCF_MenúP_Cascarilla.UseVisualStyleBackColor = False
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.AjustesV_H3
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(1014, 48)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "10071"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight2.TabIndex = 1152
        Me.PilotLight2.Text = "Manual"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.AjustesV_H3
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(879, 48)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "10071"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight1.TabIndex = 1151
        Me.PilotLight1.Text = "Automático"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'DigitalPanelMeter11
        '
        Me.DigitalPanelMeter11.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter11.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter11.DecimalPosition = 2
        Me.DigitalPanelMeter11.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter11.KeypadMaxValue = 0R
        Me.DigitalPanelMeter11.KeypadMinValue = 0R
        Me.DigitalPanelMeter11.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter11.KeypadText = Nothing
        Me.DigitalPanelMeter11.KeypadWidth = 300
        Me.DigitalPanelMeter11.Location = New System.Drawing.Point(435, 101)
        Me.DigitalPanelMeter11.Name = "DigitalPanelMeter11"
        Me.DigitalPanelMeter11.NumberOfDigits = 5
        Me.DigitalPanelMeter11.PLCAddressKeypad = ""
        Me.DigitalPanelMeter11.PLCAddressValue = "40340"
        Me.DigitalPanelMeter11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter11.TabIndex = 1150
        Me.DigitalPanelMeter11.Value = 0R
        Me.DigitalPanelMeter11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(461, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 36)
        Me.Label12.TabIndex = 1149
        Me.Label12.Text = "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salida Hz"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter10
        '
        Me.DigitalPanelMeter10.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter10.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter10.DecimalPosition = 2
        Me.DigitalPanelMeter10.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter10.KeypadMaxValue = 0R
        Me.DigitalPanelMeter10.KeypadMinValue = 0R
        Me.DigitalPanelMeter10.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter10.KeypadText = Nothing
        Me.DigitalPanelMeter10.KeypadWidth = 300
        Me.DigitalPanelMeter10.Location = New System.Drawing.Point(197, 518)
        Me.DigitalPanelMeter10.Name = "DigitalPanelMeter10"
        Me.DigitalPanelMeter10.NumberOfDigits = 5
        Me.DigitalPanelMeter10.PLCAddressKeypad = ""
        Me.DigitalPanelMeter10.PLCAddressValue = "40369"
        Me.DigitalPanelMeter10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter10.TabIndex = 1148
        Me.DigitalPanelMeter10.Value = 0R
        Me.DigitalPanelMeter10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(226, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 36)
        Me.Label11.TabIndex = 1147
        Me.Label11.Text = "Voltaje de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salida AC"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter8
        '
        Me.DigitalPanelMeter8.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter8.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter8.DecimalPosition = 2
        Me.DigitalPanelMeter8.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter8.KeypadMaxValue = 0R
        Me.DigitalPanelMeter8.KeypadMinValue = 0R
        Me.DigitalPanelMeter8.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter8.KeypadText = Nothing
        Me.DigitalPanelMeter8.KeypadWidth = 300
        Me.DigitalPanelMeter8.Location = New System.Drawing.Point(197, 383)
        Me.DigitalPanelMeter8.Name = "DigitalPanelMeter8"
        Me.DigitalPanelMeter8.NumberOfDigits = 5
        Me.DigitalPanelMeter8.PLCAddressKeypad = ""
        Me.DigitalPanelMeter8.PLCAddressValue = "40365"
        Me.DigitalPanelMeter8.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter8.TabIndex = 1146
        Me.DigitalPanelMeter8.Value = 0R
        Me.DigitalPanelMeter8.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(213, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 36)
        Me.Label9.TabIndex = 1145
        Me.Label9.Text = "Voltaje Interno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CC"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter7
        '
        Me.DigitalPanelMeter7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter7.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter7.DecimalPosition = 2
        Me.DigitalPanelMeter7.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter7.KeypadMaxValue = 0R
        Me.DigitalPanelMeter7.KeypadMinValue = 0R
        Me.DigitalPanelMeter7.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter7.KeypadText = Nothing
        Me.DigitalPanelMeter7.KeypadWidth = 300
        Me.DigitalPanelMeter7.Location = New System.Drawing.Point(197, 242)
        Me.DigitalPanelMeter7.Name = "DigitalPanelMeter7"
        Me.DigitalPanelMeter7.NumberOfDigits = 5
        Me.DigitalPanelMeter7.PLCAddressKeypad = ""
        Me.DigitalPanelMeter7.PLCAddressValue = "40346"
        Me.DigitalPanelMeter7.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter7.TabIndex = 1144
        Me.DigitalPanelMeter7.Value = 0R
        Me.DigitalPanelMeter7.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(218, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 36)
        Me.Label8.TabIndex = 1143
        Me.Label8.Text = "Corriente de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salida Amp"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter6.DecimalPosition = 0
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(197, 645)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 5
        Me.DigitalPanelMeter6.PLCAddressKeypad = ""
        Me.DigitalPanelMeter6.PLCAddressValue = "40370"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter6.TabIndex = 1142
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(207, 596)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 36)
        Me.Label7.TabIndex = 1141
        Me.Label7.Text = "Temperatura de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Variador °C"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.AjustesV_H3
        Me.DigitalPanelMeter1.DecimalPosition = 2
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(197, 101)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40339"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter1.TabIndex = 1140
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexVH3
        '
        Me.TexVH3.AutoSize = True
        Me.TexVH3.ForeColor = System.Drawing.Color.Black
        Me.TexVH3.Location = New System.Drawing.Point(211, 61)
        Me.TexVH3.Name = "TexVH3"
        Me.TexVH3.Size = New System.Drawing.Size(108, 36)
        Me.TexVH3.TabIndex = 1139
        Me.TexVH3.Text = "Comando de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia Hz"
        Me.TexVH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton1.FormToOpen = Nothing
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(996, 650)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = Nothing
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(151, 54)
        Me.FormChangeButton1.TabIndex = 1138
        Me.FormChangeButton1.Text = "Regresar"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'Ajustes_Variador_H3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DigitalPanelMeter3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PilotLight5)
        Me.Controls.Add(Me.MomentaryButton3)
        Me.Controls.Add(Me.MomentaryButton2)
        Me.Controls.Add(Me.MomentaryButton1)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Meter1)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.BCF_MenúP_Cascarilla)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.DigitalPanelMeter11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DigitalPanelMeter10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DigitalPanelMeter8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DigitalPanelMeter7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DigitalPanelMeter6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.TexVH3)
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Ajustes_Variador_H3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AjustesV_H3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DigitalPanelMeter3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents AjustesV_H3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents Label2 As Label
    Friend WithEvents PilotLight5 As AdvancedHMIControls.PilotLight
    Friend WithEvents MomentaryButton3 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MomentaryButton2 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MomentaryButton1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label1 As Label
    Friend WithEvents Meter1 As AdvancedHMIControls.Meter
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_Cascarilla As FormChangeButton
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents DigitalPanelMeter11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label12 As Label
    Friend WithEvents DigitalPanelMeter10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label11 As Label
    Friend WithEvents DigitalPanelMeter8 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label9 As Label
    Friend WithEvents DigitalPanelMeter7 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label8 As Label
    Friend WithEvents DigitalPanelMeter6 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label7 As Label
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexVH3 As Label
    Friend WithEvents FormChangeButton1 As FormChangeButton
End Class
