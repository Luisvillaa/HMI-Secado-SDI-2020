<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajustes_Cascarilla
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
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_H1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.AjustesCacarilla = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
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
        Me.DigitalPanelMeter4 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter5 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.TexDH5 = New System.Windows.Forms.Label()
        CType(Me.AjustesCacarilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = Nothing
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(732, 655)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1688
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
        Me.BCF_MenúP_H1.Location = New System.Drawing.Point(400, 655)
        Me.BCF_MenúP_H1.Name = "BCF_MenúP_H1"
        Me.BCF_MenúP_H1.Passcode = Nothing
        Me.BCF_MenúP_H1.PasswordChar = False
        Me.BCF_MenúP_H1.PLCAddressVisible = ""
        Me.BCF_MenúP_H1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_H1.TabIndex = 1687
        Me.BCF_MenúP_H1.Text = "Menú Principal"
        Me.BCF_MenúP_H1.UseVisualStyleBackColor = False
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.AjustesCacarilla
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(1023, 146)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "10076"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight2.TabIndex = 1686
        Me.PilotLight2.Text = "Comunicación"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'AjustesCacarilla
        '
        Me.AjustesCacarilla.DisableSubscriptions = False
        Me.AjustesCacarilla.IniFileName = ""
        Me.AjustesCacarilla.IniFileSection = Nothing
        Me.AjustesCacarilla.IPAddress = "10.1.108.17"
        Me.AjustesCacarilla.MaxReadGroupSize = 20
        Me.AjustesCacarilla.PollRateOverride = 500
        Me.AjustesCacarilla.SwapBytes = True
        Me.AjustesCacarilla.SwapWords = False
        Me.AjustesCacarilla.TcpipPort = CType(20257US, UShort)
        Me.AjustesCacarilla.TimeOut = 3000
        Me.AjustesCacarilla.UnitId = CType(15, Byte)
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.AjustesCacarilla
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(888, 146)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "10076"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(120, 176)
        Me.PilotLight1.TabIndex = 1685
        Me.PilotLight1.Text = "Eléctrico"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'DigitalPanelMeter11
        '
        Me.DigitalPanelMeter11.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter11.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter11.DecimalPosition = 2
        Me.DigitalPanelMeter11.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter11.KeypadMaxValue = 0R
        Me.DigitalPanelMeter11.KeypadMinValue = 0R
        Me.DigitalPanelMeter11.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter11.KeypadText = Nothing
        Me.DigitalPanelMeter11.KeypadWidth = 300
        Me.DigitalPanelMeter11.Location = New System.Drawing.Point(932, 383)
        Me.DigitalPanelMeter11.Name = "DigitalPanelMeter11"
        Me.DigitalPanelMeter11.NumberOfDigits = 5
        Me.DigitalPanelMeter11.PLCAddressKeypad = ""
        Me.DigitalPanelMeter11.PLCAddressValue = "40075"
        Me.DigitalPanelMeter11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter11.TabIndex = 1684
        Me.DigitalPanelMeter11.Value = 0R
        Me.DigitalPanelMeter11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(958, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 36)
        Me.Label12.TabIndex = 1683
        Me.Label12.Text = "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salida"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter10
        '
        Me.DigitalPanelMeter10.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter10.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter10.DecimalPosition = 2
        Me.DigitalPanelMeter10.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter10.KeypadMaxValue = 0R
        Me.DigitalPanelMeter10.KeypadMinValue = 0R
        Me.DigitalPanelMeter10.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter10.KeypadText = Nothing
        Me.DigitalPanelMeter10.KeypadWidth = 300
        Me.DigitalPanelMeter10.Location = New System.Drawing.Point(206, 518)
        Me.DigitalPanelMeter10.Name = "DigitalPanelMeter10"
        Me.DigitalPanelMeter10.NumberOfDigits = 5
        Me.DigitalPanelMeter10.PLCAddressKeypad = "40072"
        Me.DigitalPanelMeter10.PLCAddressValue = "40072"
        Me.DigitalPanelMeter10.PLCAddressVisible = "10076"
        Me.DigitalPanelMeter10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter10.TabIndex = 1682
        Me.DigitalPanelMeter10.Value = 0R
        Me.DigitalPanelMeter10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(228, 461)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 54)
        Me.Label11.TabIndex = 1681
        Me.Label11.Text = "Comando de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hornilla"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter8
        '
        Me.DigitalPanelMeter8.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter8.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter8.DecimalPosition = 2
        Me.DigitalPanelMeter8.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter8.KeypadMaxValue = 0R
        Me.DigitalPanelMeter8.KeypadMinValue = 0R
        Me.DigitalPanelMeter8.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter8.KeypadText = Nothing
        Me.DigitalPanelMeter8.KeypadWidth = 300
        Me.DigitalPanelMeter8.Location = New System.Drawing.Point(206, 383)
        Me.DigitalPanelMeter8.Name = "DigitalPanelMeter8"
        Me.DigitalPanelMeter8.NumberOfDigits = 5
        Me.DigitalPanelMeter8.PLCAddressKeypad = "40070"
        Me.DigitalPanelMeter8.PLCAddressValue = "40070"
        Me.DigitalPanelMeter8.PLCAddressVisible = "10076"
        Me.DigitalPanelMeter8.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter8.TabIndex = 1680
        Me.DigitalPanelMeter8.Value = 0R
        Me.DigitalPanelMeter8.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(228, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 54)
        Me.Label9.TabIndex = 1679
        Me.Label9.Text = "Comando de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Horno 3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter7
        '
        Me.DigitalPanelMeter7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter7.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter7.DecimalPosition = 2
        Me.DigitalPanelMeter7.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter7.KeypadMaxValue = 0R
        Me.DigitalPanelMeter7.KeypadMinValue = 0R
        Me.DigitalPanelMeter7.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter7.KeypadText = Nothing
        Me.DigitalPanelMeter7.KeypadWidth = 300
        Me.DigitalPanelMeter7.Location = New System.Drawing.Point(206, 242)
        Me.DigitalPanelMeter7.Name = "DigitalPanelMeter7"
        Me.DigitalPanelMeter7.NumberOfDigits = 5
        Me.DigitalPanelMeter7.PLCAddressKeypad = "40069"
        Me.DigitalPanelMeter7.PLCAddressValue = "40069"
        Me.DigitalPanelMeter7.PLCAddressVisible = "10076"
        Me.DigitalPanelMeter7.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter7.TabIndex = 1678
        Me.DigitalPanelMeter7.Value = 0R
        Me.DigitalPanelMeter7.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(228, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 54)
        Me.Label8.TabIndex = 1677
        Me.Label8.Text = "Comando de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Horno 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter6.DecimalPosition = 2
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(568, 650)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 5
        Me.DigitalPanelMeter6.PLCAddressKeypad = "40050"
        Me.DigitalPanelMeter6.PLCAddressValue = "40050"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter6.TabIndex = 1676
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(576, 610)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 36)
        Me.Label7.TabIndex = 1675
        Me.Label7.Text = "Tiempo Paro VE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Segundos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter4
        '
        Me.DigitalPanelMeter4.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter4.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter4.DecimalPosition = 0
        Me.DigitalPanelMeter4.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter4.KeypadMaxValue = 0R
        Me.DigitalPanelMeter4.KeypadMinValue = 0R
        Me.DigitalPanelMeter4.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter4.KeypadText = Nothing
        Me.DigitalPanelMeter4.KeypadWidth = 300
        Me.DigitalPanelMeter4.Location = New System.Drawing.Point(568, 501)
        Me.DigitalPanelMeter4.Name = "DigitalPanelMeter4"
        Me.DigitalPanelMeter4.NumberOfDigits = 5
        Me.DigitalPanelMeter4.PLCAddressKeypad = "40066"
        Me.DigitalPanelMeter4.PLCAddressValue = "40066"
        Me.DigitalPanelMeter4.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter4.TabIndex = 1674
        Me.DigitalPanelMeter4.Value = 0R
        Me.DigitalPanelMeter4.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter5
        '
        Me.DigitalPanelMeter5.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter5.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter5.DecimalPosition = 0
        Me.DigitalPanelMeter5.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter5.KeypadMaxValue = 0R
        Me.DigitalPanelMeter5.KeypadMinValue = 0R
        Me.DigitalPanelMeter5.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter5.KeypadText = Nothing
        Me.DigitalPanelMeter5.KeypadWidth = 300
        Me.DigitalPanelMeter5.Location = New System.Drawing.Point(568, 408)
        Me.DigitalPanelMeter5.Name = "DigitalPanelMeter5"
        Me.DigitalPanelMeter5.NumberOfDigits = 5
        Me.DigitalPanelMeter5.PLCAddressKeypad = "40065"
        Me.DigitalPanelMeter5.PLCAddressValue = "40065"
        Me.DigitalPanelMeter5.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter5.TabIndex = 1673
        Me.DigitalPanelMeter5.Value = 0R
        Me.DigitalPanelMeter5.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(611, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 1672
        Me.Label4.Text = "Pausa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(604, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 1671
        Me.Label5.Text = "Marcha"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(565, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 54)
        Me.Label6.TabIndex = 1670
        Me.Label6.Text = "Tiempo Alimentación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hornillas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minutos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter3
        '
        Me.DigitalPanelMeter3.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter3.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter3.DecimalPosition = 0
        Me.DigitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter3.KeypadMaxValue = 0R
        Me.DigitalPanelMeter3.KeypadMinValue = 0R
        Me.DigitalPanelMeter3.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter3.KeypadText = Nothing
        Me.DigitalPanelMeter3.KeypadWidth = 300
        Me.DigitalPanelMeter3.Location = New System.Drawing.Point(568, 229)
        Me.DigitalPanelMeter3.Name = "DigitalPanelMeter3"
        Me.DigitalPanelMeter3.NumberOfDigits = 5
        Me.DigitalPanelMeter3.PLCAddressKeypad = "40064"
        Me.DigitalPanelMeter3.PLCAddressValue = "40064"
        Me.DigitalPanelMeter3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter3.TabIndex = 1668
        Me.DigitalPanelMeter3.Value = 0R
        Me.DigitalPanelMeter3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter2.DecimalPosition = 0
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(568, 136)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = "40063"
        Me.DigitalPanelMeter2.PLCAddressValue = "40063"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter2.TabIndex = 1667
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(611, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 1666
        Me.Label3.Text = "Pausa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(604, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 1665
        Me.Label2.Text = "Marcha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(565, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 54)
        Me.Label1.TabIndex = 1664
        Me.Label1.Text = "Tiempo Alimentación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Horno 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minutos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.AjustesCacarilla
        Me.DigitalPanelMeter1.DecimalPosition = 2
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(206, 101)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = "40068"
        Me.DigitalPanelMeter1.PLCAddressValue = "40068"
        Me.DigitalPanelMeter1.PLCAddressVisible = "10076"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(137, 59)
        Me.DigitalPanelMeter1.TabIndex = 1663
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton1.ComComponent = Me.AjustesCacarilla
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(932, 78)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton1.PLCAddressClick = "00075"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(152, 46)
        Me.BasicButton1.TabIndex = 1669
        Me.BasicButton1.Text = "Trabajo Dosificador"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'TexDH5
        '
        Me.TexDH5.AutoSize = True
        Me.TexDH5.ForeColor = System.Drawing.Color.Blue
        Me.TexDH5.Location = New System.Drawing.Point(228, 44)
        Me.TexDH5.Name = "TexDH5"
        Me.TexDH5.Size = New System.Drawing.Size(99, 54)
        Me.TexDH5.TabIndex = 1662
        Me.TexDH5.Text = "Comando de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frecuencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Horno 1"
        Me.TexDH5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ajustes_Cascarilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BCF_MenúP_H1)
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
        Me.Controls.Add(Me.DigitalPanelMeter4)
        Me.Controls.Add(Me.DigitalPanelMeter5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DigitalPanelMeter3)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.TexDH5)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Ajustes_Cascarilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AjustesCacarilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BCF_MenúP_H1 As FormChangeButton
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents AjustesCacarilla As AdvancedHMIDrivers.ModbusTCPCom
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
    Friend WithEvents DigitalPanelMeter4 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter5 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DigitalPanelMeter3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents TexDH5 As Label
End Class
