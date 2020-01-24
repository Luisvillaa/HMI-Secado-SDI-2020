<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajustes_Temperatura_H3
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
        Me.BCF_MenúP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BasicButton13 = New AdvancedHMIControls.BasicButton()
        Me.Ajustes_T_H3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BasicButton14 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter19 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter20 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter21 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton11 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton12 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter17 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter18 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton9 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton10 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton7 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton8 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton5 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton6 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter7 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter8 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter9 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton3 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton4 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter4 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter5 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter6 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_AjusMinH1 = New AdvancedHMIControls.BasicButton()
        Me.BP_AjusMaxH1 = New AdvancedHMIControls.BasicButton()
        Me.DM_AjusMinH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DM_AjustadoH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DM_AjusMaxH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Ajustes_T_H3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(1010, 658)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1284
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BCF_MenúP_Cascarilla
        '
        Me.BCF_MenúP_Cascarilla.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_Cascarilla.ComComponent = Nothing
        Me.BCF_MenúP_Cascarilla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_Cascarilla.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_Cascarilla.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_Cascarilla.KeypadWidth = 300
        Me.BCF_MenúP_Cascarilla.Location = New System.Drawing.Point(597, 652)
        Me.BCF_MenúP_Cascarilla.Name = "BCF_MenúP_Cascarilla"
        Me.BCF_MenúP_Cascarilla.Passcode = Nothing
        Me.BCF_MenúP_Cascarilla.PasswordChar = False
        Me.BCF_MenúP_Cascarilla.PLCAddressVisible = ""
        Me.BCF_MenúP_Cascarilla.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_Cascarilla.TabIndex = 1283
        Me.BCF_MenúP_Cascarilla.Text = "Menú Principal"
        Me.BCF_MenúP_Cascarilla.UseVisualStyleBackColor = False
        '
        'BasicButton13
        '
        Me.BasicButton13.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton13.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton13.ForeColor = System.Drawing.Color.Black
        Me.BasicButton13.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton13.Highlight = False
        Me.BasicButton13.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton13.Location = New System.Drawing.Point(1000, 382)
        Me.BasicButton13.MaximumHoldTime = 3000
        Me.BasicButton13.MinimumHoldTime = 500
        Me.BasicButton13.Name = "BasicButton13"
        Me.BasicButton13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton13.PLCAddressClick = "00030"
        Me.BasicButton13.SelectTextAlternate = False
        Me.BasicButton13.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton13.TabIndex = 1282
        Me.BasicButton13.Text = "Ajustar"
        Me.BasicButton13.TextAlternate = Nothing
        Me.BasicButton13.UseVisualStyleBackColor = True
        Me.BasicButton13.ValueToWrite = 0
        '
        'Ajustes_T_H3
        '
        Me.Ajustes_T_H3.DisableSubscriptions = False
        Me.Ajustes_T_H3.IniFileName = ""
        Me.Ajustes_T_H3.IniFileSection = Nothing
        Me.Ajustes_T_H3.IPAddress = "10.1.108.8"
        Me.Ajustes_T_H3.MaxReadGroupSize = 20
        Me.Ajustes_T_H3.PollRateOverride = 500
        Me.Ajustes_T_H3.SwapBytes = True
        Me.Ajustes_T_H3.SwapWords = False
        Me.Ajustes_T_H3.TcpipPort = CType(20257US, UShort)
        Me.Ajustes_T_H3.TimeOut = 3000
        Me.Ajustes_T_H3.UnitId = CType(13, Byte)
        '
        'BasicButton14
        '
        Me.BasicButton14.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton14.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton14.ForeColor = System.Drawing.Color.Black
        Me.BasicButton14.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton14.Highlight = False
        Me.BasicButton14.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton14.Location = New System.Drawing.Point(1000, 277)
        Me.BasicButton14.MaximumHoldTime = 3000
        Me.BasicButton14.MinimumHoldTime = 500
        Me.BasicButton14.Name = "BasicButton14"
        Me.BasicButton14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton14.PLCAddressClick = "00029"
        Me.BasicButton14.SelectTextAlternate = False
        Me.BasicButton14.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton14.TabIndex = 1281
        Me.BasicButton14.Text = "Ajustar"
        Me.BasicButton14.TextAlternate = Nothing
        Me.BasicButton14.UseVisualStyleBackColor = True
        Me.BasicButton14.ValueToWrite = 0
        '
        'DigitalPanelMeter19
        '
        Me.DigitalPanelMeter19.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter19.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter19.DecimalPosition = 1
        Me.DigitalPanelMeter19.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter19.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter19.KeypadMaxValue = 0R
        Me.DigitalPanelMeter19.KeypadMinValue = 0R
        Me.DigitalPanelMeter19.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter19.KeypadText = Nothing
        Me.DigitalPanelMeter19.KeypadWidth = 300
        Me.DigitalPanelMeter19.Location = New System.Drawing.Point(871, 382)
        Me.DigitalPanelMeter19.Name = "DigitalPanelMeter19"
        Me.DigitalPanelMeter19.NumberOfDigits = 5
        Me.DigitalPanelMeter19.PLCAddressKeypad = "40253"
        Me.DigitalPanelMeter19.PLCAddressValue = "40253"
        Me.DigitalPanelMeter19.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter19.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter19.TabIndex = 1280
        Me.DigitalPanelMeter19.Value = 0R
        Me.DigitalPanelMeter19.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter19.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter20
        '
        Me.DigitalPanelMeter20.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter20.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter20.DecimalPosition = 1
        Me.DigitalPanelMeter20.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter20.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter20.KeypadMaxValue = 0R
        Me.DigitalPanelMeter20.KeypadMinValue = 0R
        Me.DigitalPanelMeter20.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter20.KeypadText = Nothing
        Me.DigitalPanelMeter20.KeypadWidth = 300
        Me.DigitalPanelMeter20.Location = New System.Drawing.Point(1000, 328)
        Me.DigitalPanelMeter20.Name = "DigitalPanelMeter20"
        Me.DigitalPanelMeter20.NumberOfDigits = 5
        Me.DigitalPanelMeter20.PLCAddressKeypad = ""
        Me.DigitalPanelMeter20.PLCAddressValue = "40251"
        Me.DigitalPanelMeter20.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter20.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter20.TabIndex = 1279
        Me.DigitalPanelMeter20.Value = 0R
        Me.DigitalPanelMeter20.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter20.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter21
        '
        Me.DigitalPanelMeter21.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter21.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter21.DecimalPosition = 1
        Me.DigitalPanelMeter21.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter21.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter21.KeypadMaxValue = 0R
        Me.DigitalPanelMeter21.KeypadMinValue = 0R
        Me.DigitalPanelMeter21.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter21.KeypadText = Nothing
        Me.DigitalPanelMeter21.KeypadWidth = 300
        Me.DigitalPanelMeter21.Location = New System.Drawing.Point(871, 277)
        Me.DigitalPanelMeter21.Name = "DigitalPanelMeter21"
        Me.DigitalPanelMeter21.NumberOfDigits = 5
        Me.DigitalPanelMeter21.PLCAddressKeypad = "40252"
        Me.DigitalPanelMeter21.PLCAddressValue = "40252"
        Me.DigitalPanelMeter21.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter21.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter21.TabIndex = 1278
        Me.DigitalPanelMeter21.Value = 0R
        Me.DigitalPanelMeter21.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter21.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton11
        '
        Me.BasicButton11.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton11.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton11.ForeColor = System.Drawing.Color.Black
        Me.BasicButton11.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton11.Highlight = False
        Me.BasicButton11.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton11.Location = New System.Drawing.Point(1000, 178)
        Me.BasicButton11.MaximumHoldTime = 3000
        Me.BasicButton11.MinimumHoldTime = 500
        Me.BasicButton11.Name = "BasicButton11"
        Me.BasicButton11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton11.PLCAddressClick = "00025"
        Me.BasicButton11.SelectTextAlternate = False
        Me.BasicButton11.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton11.TabIndex = 1277
        Me.BasicButton11.Text = "Ajustar"
        Me.BasicButton11.TextAlternate = Nothing
        Me.BasicButton11.UseVisualStyleBackColor = True
        Me.BasicButton11.ValueToWrite = 0
        '
        'BasicButton12
        '
        Me.BasicButton12.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton12.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton12.ForeColor = System.Drawing.Color.Black
        Me.BasicButton12.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton12.Highlight = False
        Me.BasicButton12.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton12.Location = New System.Drawing.Point(1000, 73)
        Me.BasicButton12.MaximumHoldTime = 3000
        Me.BasicButton12.MinimumHoldTime = 500
        Me.BasicButton12.Name = "BasicButton12"
        Me.BasicButton12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton12.PLCAddressClick = "00024"
        Me.BasicButton12.SelectTextAlternate = False
        Me.BasicButton12.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton12.TabIndex = 1276
        Me.BasicButton12.Text = "Ajustar"
        Me.BasicButton12.TextAlternate = Nothing
        Me.BasicButton12.UseVisualStyleBackColor = True
        Me.BasicButton12.ValueToWrite = 0
        '
        'DigitalPanelMeter16
        '
        Me.DigitalPanelMeter16.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter16.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter16.DecimalPosition = 1
        Me.DigitalPanelMeter16.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter16.KeypadMaxValue = 0R
        Me.DigitalPanelMeter16.KeypadMinValue = 0R
        Me.DigitalPanelMeter16.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter16.KeypadText = Nothing
        Me.DigitalPanelMeter16.KeypadWidth = 300
        Me.DigitalPanelMeter16.Location = New System.Drawing.Point(871, 178)
        Me.DigitalPanelMeter16.Name = "DigitalPanelMeter16"
        Me.DigitalPanelMeter16.NumberOfDigits = 5
        Me.DigitalPanelMeter16.PLCAddressKeypad = "40202"
        Me.DigitalPanelMeter16.PLCAddressValue = "40202"
        Me.DigitalPanelMeter16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter16.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter16.TabIndex = 1275
        Me.DigitalPanelMeter16.Value = 0R
        Me.DigitalPanelMeter16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter17
        '
        Me.DigitalPanelMeter17.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter17.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter17.DecimalPosition = 1
        Me.DigitalPanelMeter17.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter17.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter17.KeypadMaxValue = 0R
        Me.DigitalPanelMeter17.KeypadMinValue = 0R
        Me.DigitalPanelMeter17.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter17.KeypadText = Nothing
        Me.DigitalPanelMeter17.KeypadWidth = 300
        Me.DigitalPanelMeter17.Location = New System.Drawing.Point(1000, 124)
        Me.DigitalPanelMeter17.Name = "DigitalPanelMeter17"
        Me.DigitalPanelMeter17.NumberOfDigits = 5
        Me.DigitalPanelMeter17.PLCAddressKeypad = ""
        Me.DigitalPanelMeter17.PLCAddressValue = "40200"
        Me.DigitalPanelMeter17.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter17.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter17.TabIndex = 1274
        Me.DigitalPanelMeter17.Value = 0R
        Me.DigitalPanelMeter17.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter17.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter18
        '
        Me.DigitalPanelMeter18.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter18.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter18.DecimalPosition = 1
        Me.DigitalPanelMeter18.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter18.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter18.KeypadMaxValue = 0R
        Me.DigitalPanelMeter18.KeypadMinValue = 0R
        Me.DigitalPanelMeter18.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter18.KeypadText = Nothing
        Me.DigitalPanelMeter18.KeypadWidth = 300
        Me.DigitalPanelMeter18.Location = New System.Drawing.Point(871, 73)
        Me.DigitalPanelMeter18.Name = "DigitalPanelMeter18"
        Me.DigitalPanelMeter18.NumberOfDigits = 5
        Me.DigitalPanelMeter18.PLCAddressKeypad = "40201"
        Me.DigitalPanelMeter18.PLCAddressValue = "40201"
        Me.DigitalPanelMeter18.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter18.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter18.TabIndex = 1273
        Me.DigitalPanelMeter18.Value = 0R
        Me.DigitalPanelMeter18.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter18.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton9
        '
        Me.BasicButton9.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton9.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton9.ForeColor = System.Drawing.Color.Black
        Me.BasicButton9.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton9.Highlight = False
        Me.BasicButton9.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton9.Location = New System.Drawing.Point(679, 382)
        Me.BasicButton9.MaximumHoldTime = 3000
        Me.BasicButton9.MinimumHoldTime = 500
        Me.BasicButton9.Name = "BasicButton9"
        Me.BasicButton9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton9.PLCAddressClick = "00013"
        Me.BasicButton9.SelectTextAlternate = False
        Me.BasicButton9.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton9.TabIndex = 1272
        Me.BasicButton9.Text = "Ajustar"
        Me.BasicButton9.TextAlternate = Nothing
        Me.BasicButton9.UseVisualStyleBackColor = True
        Me.BasicButton9.ValueToWrite = 0
        '
        'BasicButton10
        '
        Me.BasicButton10.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton10.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton10.ForeColor = System.Drawing.Color.Black
        Me.BasicButton10.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton10.Highlight = False
        Me.BasicButton10.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton10.Location = New System.Drawing.Point(679, 277)
        Me.BasicButton10.MaximumHoldTime = 3000
        Me.BasicButton10.MinimumHoldTime = 500
        Me.BasicButton10.Name = "BasicButton10"
        Me.BasicButton10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton10.PLCAddressClick = "00012"
        Me.BasicButton10.SelectTextAlternate = False
        Me.BasicButton10.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton10.TabIndex = 1271
        Me.BasicButton10.Text = "Ajustar"
        Me.BasicButton10.TextAlternate = Nothing
        Me.BasicButton10.UseVisualStyleBackColor = True
        Me.BasicButton10.ValueToWrite = 0
        '
        'DigitalPanelMeter13
        '
        Me.DigitalPanelMeter13.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter13.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter13.DecimalPosition = 1
        Me.DigitalPanelMeter13.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter13.KeypadMaxValue = 0R
        Me.DigitalPanelMeter13.KeypadMinValue = 0R
        Me.DigitalPanelMeter13.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter13.KeypadText = Nothing
        Me.DigitalPanelMeter13.KeypadWidth = 300
        Me.DigitalPanelMeter13.Location = New System.Drawing.Point(550, 382)
        Me.DigitalPanelMeter13.Name = "DigitalPanelMeter13"
        Me.DigitalPanelMeter13.NumberOfDigits = 5
        Me.DigitalPanelMeter13.PLCAddressKeypad = "40087"
        Me.DigitalPanelMeter13.PLCAddressValue = "40087"
        Me.DigitalPanelMeter13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter13.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter13.TabIndex = 1270
        Me.DigitalPanelMeter13.Value = 0R
        Me.DigitalPanelMeter13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter14
        '
        Me.DigitalPanelMeter14.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter14.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter14.DecimalPosition = 1
        Me.DigitalPanelMeter14.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter14.KeypadMaxValue = 0R
        Me.DigitalPanelMeter14.KeypadMinValue = 0R
        Me.DigitalPanelMeter14.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter14.KeypadText = Nothing
        Me.DigitalPanelMeter14.KeypadWidth = 300
        Me.DigitalPanelMeter14.Location = New System.Drawing.Point(679, 328)
        Me.DigitalPanelMeter14.Name = "DigitalPanelMeter14"
        Me.DigitalPanelMeter14.NumberOfDigits = 5
        Me.DigitalPanelMeter14.PLCAddressKeypad = ""
        Me.DigitalPanelMeter14.PLCAddressValue = "40085"
        Me.DigitalPanelMeter14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter14.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter14.TabIndex = 1269
        Me.DigitalPanelMeter14.Value = 0R
        Me.DigitalPanelMeter14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter15
        '
        Me.DigitalPanelMeter15.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter15.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter15.DecimalPosition = 1
        Me.DigitalPanelMeter15.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter15.KeypadMaxValue = 0R
        Me.DigitalPanelMeter15.KeypadMinValue = 0R
        Me.DigitalPanelMeter15.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter15.KeypadText = Nothing
        Me.DigitalPanelMeter15.KeypadWidth = 300
        Me.DigitalPanelMeter15.Location = New System.Drawing.Point(550, 277)
        Me.DigitalPanelMeter15.Name = "DigitalPanelMeter15"
        Me.DigitalPanelMeter15.NumberOfDigits = 5
        Me.DigitalPanelMeter15.PLCAddressKeypad = "40086"
        Me.DigitalPanelMeter15.PLCAddressValue = "40086"
        Me.DigitalPanelMeter15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter15.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter15.TabIndex = 1268
        Me.DigitalPanelMeter15.Value = 0R
        Me.DigitalPanelMeter15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton7
        '
        Me.BasicButton7.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton7.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton7.ForeColor = System.Drawing.Color.Black
        Me.BasicButton7.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton7.Highlight = False
        Me.BasicButton7.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton7.Location = New System.Drawing.Point(679, 594)
        Me.BasicButton7.MaximumHoldTime = 3000
        Me.BasicButton7.MinimumHoldTime = 500
        Me.BasicButton7.Name = "BasicButton7"
        Me.BasicButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton7.PLCAddressClick = "00018"
        Me.BasicButton7.SelectTextAlternate = False
        Me.BasicButton7.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton7.TabIndex = 1267
        Me.BasicButton7.Text = "Ajustar"
        Me.BasicButton7.TextAlternate = Nothing
        Me.BasicButton7.UseVisualStyleBackColor = True
        Me.BasicButton7.ValueToWrite = 0
        '
        'BasicButton8
        '
        Me.BasicButton8.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton8.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton8.ForeColor = System.Drawing.Color.Black
        Me.BasicButton8.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton8.Highlight = False
        Me.BasicButton8.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton8.Location = New System.Drawing.Point(679, 489)
        Me.BasicButton8.MaximumHoldTime = 3000
        Me.BasicButton8.MinimumHoldTime = 500
        Me.BasicButton8.Name = "BasicButton8"
        Me.BasicButton8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton8.PLCAddressClick = "00017"
        Me.BasicButton8.SelectTextAlternate = False
        Me.BasicButton8.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton8.TabIndex = 1266
        Me.BasicButton8.Text = "Ajustar"
        Me.BasicButton8.TextAlternate = Nothing
        Me.BasicButton8.UseVisualStyleBackColor = True
        Me.BasicButton8.ValueToWrite = 0
        '
        'DigitalPanelMeter10
        '
        Me.DigitalPanelMeter10.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter10.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter10.DecimalPosition = 1
        Me.DigitalPanelMeter10.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter10.KeypadMaxValue = 0R
        Me.DigitalPanelMeter10.KeypadMinValue = 0R
        Me.DigitalPanelMeter10.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter10.KeypadText = Nothing
        Me.DigitalPanelMeter10.KeypadWidth = 300
        Me.DigitalPanelMeter10.Location = New System.Drawing.Point(550, 594)
        Me.DigitalPanelMeter10.Name = "DigitalPanelMeter10"
        Me.DigitalPanelMeter10.NumberOfDigits = 5
        Me.DigitalPanelMeter10.PLCAddressKeypad = "40151"
        Me.DigitalPanelMeter10.PLCAddressValue = "40151"
        Me.DigitalPanelMeter10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter10.TabIndex = 1265
        Me.DigitalPanelMeter10.Value = 0R
        Me.DigitalPanelMeter10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter11
        '
        Me.DigitalPanelMeter11.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter11.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter11.DecimalPosition = 1
        Me.DigitalPanelMeter11.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter11.KeypadMaxValue = 0R
        Me.DigitalPanelMeter11.KeypadMinValue = 0R
        Me.DigitalPanelMeter11.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter11.KeypadText = Nothing
        Me.DigitalPanelMeter11.KeypadWidth = 300
        Me.DigitalPanelMeter11.Location = New System.Drawing.Point(679, 540)
        Me.DigitalPanelMeter11.Name = "DigitalPanelMeter11"
        Me.DigitalPanelMeter11.NumberOfDigits = 5
        Me.DigitalPanelMeter11.PLCAddressKeypad = ""
        Me.DigitalPanelMeter11.PLCAddressValue = "40149"
        Me.DigitalPanelMeter11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter11.TabIndex = 1264
        Me.DigitalPanelMeter11.Value = 0R
        Me.DigitalPanelMeter11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter12
        '
        Me.DigitalPanelMeter12.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter12.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter12.DecimalPosition = 1
        Me.DigitalPanelMeter12.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter12.KeypadMaxValue = 0R
        Me.DigitalPanelMeter12.KeypadMinValue = 0R
        Me.DigitalPanelMeter12.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter12.KeypadText = Nothing
        Me.DigitalPanelMeter12.KeypadWidth = 300
        Me.DigitalPanelMeter12.Location = New System.Drawing.Point(550, 489)
        Me.DigitalPanelMeter12.Name = "DigitalPanelMeter12"
        Me.DigitalPanelMeter12.NumberOfDigits = 5
        Me.DigitalPanelMeter12.PLCAddressKeypad = "40150"
        Me.DigitalPanelMeter12.PLCAddressValue = "40150"
        Me.DigitalPanelMeter12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter12.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter12.TabIndex = 1263
        Me.DigitalPanelMeter12.Value = 0R
        Me.DigitalPanelMeter12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton5
        '
        Me.BasicButton5.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton5.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton5.ForeColor = System.Drawing.Color.Black
        Me.BasicButton5.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton5.Highlight = False
        Me.BasicButton5.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton5.Location = New System.Drawing.Point(679, 178)
        Me.BasicButton5.MaximumHoldTime = 3000
        Me.BasicButton5.MinimumHoldTime = 500
        Me.BasicButton5.Name = "BasicButton5"
        Me.BasicButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton5.PLCAddressClick = "00010"
        Me.BasicButton5.SelectTextAlternate = False
        Me.BasicButton5.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton5.TabIndex = 1262
        Me.BasicButton5.Text = "Ajustar"
        Me.BasicButton5.TextAlternate = Nothing
        Me.BasicButton5.UseVisualStyleBackColor = True
        Me.BasicButton5.ValueToWrite = 0
        '
        'BasicButton6
        '
        Me.BasicButton6.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton6.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton6.ForeColor = System.Drawing.Color.Black
        Me.BasicButton6.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton6.Highlight = False
        Me.BasicButton6.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton6.Location = New System.Drawing.Point(679, 73)
        Me.BasicButton6.MaximumHoldTime = 3000
        Me.BasicButton6.MinimumHoldTime = 500
        Me.BasicButton6.Name = "BasicButton6"
        Me.BasicButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton6.PLCAddressClick = "00009"
        Me.BasicButton6.SelectTextAlternate = False
        Me.BasicButton6.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton6.TabIndex = 1261
        Me.BasicButton6.Text = "Ajustar"
        Me.BasicButton6.TextAlternate = Nothing
        Me.BasicButton6.UseVisualStyleBackColor = True
        Me.BasicButton6.ValueToWrite = 0
        '
        'DigitalPanelMeter7
        '
        Me.DigitalPanelMeter7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter7.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter7.DecimalPosition = 1
        Me.DigitalPanelMeter7.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter7.KeypadMaxValue = 0R
        Me.DigitalPanelMeter7.KeypadMinValue = 0R
        Me.DigitalPanelMeter7.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter7.KeypadText = Nothing
        Me.DigitalPanelMeter7.KeypadWidth = 300
        Me.DigitalPanelMeter7.Location = New System.Drawing.Point(550, 178)
        Me.DigitalPanelMeter7.Name = "DigitalPanelMeter7"
        Me.DigitalPanelMeter7.NumberOfDigits = 5
        Me.DigitalPanelMeter7.PLCAddressKeypad = "40036"
        Me.DigitalPanelMeter7.PLCAddressValue = "40036"
        Me.DigitalPanelMeter7.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter7.TabIndex = 1260
        Me.DigitalPanelMeter7.Value = 0R
        Me.DigitalPanelMeter7.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter8
        '
        Me.DigitalPanelMeter8.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter8.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter8.DecimalPosition = 1
        Me.DigitalPanelMeter8.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter8.KeypadMaxValue = 0R
        Me.DigitalPanelMeter8.KeypadMinValue = 0R
        Me.DigitalPanelMeter8.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter8.KeypadText = Nothing
        Me.DigitalPanelMeter8.KeypadWidth = 300
        Me.DigitalPanelMeter8.Location = New System.Drawing.Point(679, 124)
        Me.DigitalPanelMeter8.Name = "DigitalPanelMeter8"
        Me.DigitalPanelMeter8.NumberOfDigits = 5
        Me.DigitalPanelMeter8.PLCAddressKeypad = ""
        Me.DigitalPanelMeter8.PLCAddressValue = "40034"
        Me.DigitalPanelMeter8.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter8.TabIndex = 1259
        Me.DigitalPanelMeter8.Value = 0R
        Me.DigitalPanelMeter8.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter9
        '
        Me.DigitalPanelMeter9.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter9.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter9.DecimalPosition = 1
        Me.DigitalPanelMeter9.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter9.KeypadMaxValue = 0R
        Me.DigitalPanelMeter9.KeypadMinValue = 0R
        Me.DigitalPanelMeter9.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter9.KeypadText = Nothing
        Me.DigitalPanelMeter9.KeypadWidth = 300
        Me.DigitalPanelMeter9.Location = New System.Drawing.Point(550, 73)
        Me.DigitalPanelMeter9.Name = "DigitalPanelMeter9"
        Me.DigitalPanelMeter9.NumberOfDigits = 5
        Me.DigitalPanelMeter9.PLCAddressKeypad = "40035"
        Me.DigitalPanelMeter9.PLCAddressValue = "40035"
        Me.DigitalPanelMeter9.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter9.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter9.TabIndex = 1258
        Me.DigitalPanelMeter9.Value = 0R
        Me.DigitalPanelMeter9.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter9.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton3.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton3.ForeColor = System.Drawing.Color.Black
        Me.BasicButton3.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton3.Location = New System.Drawing.Point(329, 594)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton3.PLCAddressClick = "00008"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton3.TabIndex = 1257
        Me.BasicButton3.Text = "Ajustar"
        Me.BasicButton3.TextAlternate = Nothing
        Me.BasicButton3.UseVisualStyleBackColor = True
        Me.BasicButton3.ValueToWrite = 0
        '
        'BasicButton4
        '
        Me.BasicButton4.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton4.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton4.ForeColor = System.Drawing.Color.Black
        Me.BasicButton4.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton4.Highlight = False
        Me.BasicButton4.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton4.Location = New System.Drawing.Point(329, 489)
        Me.BasicButton4.MaximumHoldTime = 3000
        Me.BasicButton4.MinimumHoldTime = 500
        Me.BasicButton4.Name = "BasicButton4"
        Me.BasicButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton4.PLCAddressClick = "00007"
        Me.BasicButton4.SelectTextAlternate = False
        Me.BasicButton4.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton4.TabIndex = 1256
        Me.BasicButton4.Text = "Ajustar"
        Me.BasicButton4.TextAlternate = Nothing
        Me.BasicButton4.UseVisualStyleBackColor = True
        Me.BasicButton4.ValueToWrite = 0
        '
        'DigitalPanelMeter4
        '
        Me.DigitalPanelMeter4.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter4.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter4.DecimalPosition = 1
        Me.DigitalPanelMeter4.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter4.KeypadMaxValue = 0R
        Me.DigitalPanelMeter4.KeypadMinValue = 0R
        Me.DigitalPanelMeter4.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter4.KeypadText = Nothing
        Me.DigitalPanelMeter4.KeypadWidth = 300
        Me.DigitalPanelMeter4.Location = New System.Drawing.Point(200, 594)
        Me.DigitalPanelMeter4.Name = "DigitalPanelMeter4"
        Me.DigitalPanelMeter4.NumberOfDigits = 5
        Me.DigitalPanelMeter4.PLCAddressKeypad = "40029"
        Me.DigitalPanelMeter4.PLCAddressValue = "40029"
        Me.DigitalPanelMeter4.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter4.TabIndex = 1255
        Me.DigitalPanelMeter4.Value = 0R
        Me.DigitalPanelMeter4.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter5
        '
        Me.DigitalPanelMeter5.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter5.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter5.DecimalPosition = 1
        Me.DigitalPanelMeter5.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter5.KeypadMaxValue = 0R
        Me.DigitalPanelMeter5.KeypadMinValue = 0R
        Me.DigitalPanelMeter5.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter5.KeypadText = Nothing
        Me.DigitalPanelMeter5.KeypadWidth = 300
        Me.DigitalPanelMeter5.Location = New System.Drawing.Point(329, 540)
        Me.DigitalPanelMeter5.Name = "DigitalPanelMeter5"
        Me.DigitalPanelMeter5.NumberOfDigits = 5
        Me.DigitalPanelMeter5.PLCAddressKeypad = ""
        Me.DigitalPanelMeter5.PLCAddressValue = "40027"
        Me.DigitalPanelMeter5.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter5.TabIndex = 1254
        Me.DigitalPanelMeter5.Value = 0R
        Me.DigitalPanelMeter5.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter6.DecimalPosition = 1
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(200, 489)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 5
        Me.DigitalPanelMeter6.PLCAddressKeypad = "40028"
        Me.DigitalPanelMeter6.PLCAddressValue = "40028"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter6.TabIndex = 1253
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton1.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(329, 382)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton1.PLCAddressClick = "00004"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton1.TabIndex = 1252
        Me.BasicButton1.Text = "Ajustar"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton2.ComComponent = Me.Ajustes_T_H3
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.Location = New System.Drawing.Point(329, 277)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton2.PLCAddressClick = "00003"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton2.TabIndex = 1251
        Me.BasicButton2.Text = "Ajustar"
        Me.BasicButton2.TextAlternate = Nothing
        Me.BasicButton2.UseVisualStyleBackColor = True
        Me.BasicButton2.ValueToWrite = 0
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter1.DecimalPosition = 1
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(200, 382)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = "40015"
        Me.DigitalPanelMeter1.PLCAddressValue = "40015"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter1.TabIndex = 1250
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter2.DecimalPosition = 1
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(329, 328)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = ""
        Me.DigitalPanelMeter2.PLCAddressValue = "40013"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter2.TabIndex = 1249
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter3
        '
        Me.DigitalPanelMeter3.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter3.ComComponent = Me.Ajustes_T_H3
        Me.DigitalPanelMeter3.DecimalPosition = 1
        Me.DigitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter3.KeypadMaxValue = 0R
        Me.DigitalPanelMeter3.KeypadMinValue = 0R
        Me.DigitalPanelMeter3.KeypadScaleFactor = 0.1R
        Me.DigitalPanelMeter3.KeypadText = Nothing
        Me.DigitalPanelMeter3.KeypadWidth = 300
        Me.DigitalPanelMeter3.Location = New System.Drawing.Point(200, 277)
        Me.DigitalPanelMeter3.Name = "DigitalPanelMeter3"
        Me.DigitalPanelMeter3.NumberOfDigits = 5
        Me.DigitalPanelMeter3.PLCAddressKeypad = "40014"
        Me.DigitalPanelMeter3.PLCAddressValue = "40014"
        Me.DigitalPanelMeter3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter3.TabIndex = 1248
        Me.DigitalPanelMeter3.Value = 0R
        Me.DigitalPanelMeter3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_AjusMinH1
        '
        Me.BP_AjusMinH1.BackColor = System.Drawing.SystemColors.Control
        Me.BP_AjusMinH1.ComComponent = Me.Ajustes_T_H3
        Me.BP_AjusMinH1.ForeColor = System.Drawing.Color.Black
        Me.BP_AjusMinH1.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_AjusMinH1.Highlight = False
        Me.BP_AjusMinH1.HighlightColor = System.Drawing.Color.Green
        Me.BP_AjusMinH1.Location = New System.Drawing.Point(329, 178)
        Me.BP_AjusMinH1.MaximumHoldTime = 3000
        Me.BP_AjusMinH1.MinimumHoldTime = 500
        Me.BP_AjusMinH1.Name = "BP_AjusMinH1"
        Me.BP_AjusMinH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BP_AjusMinH1.PLCAddressClick = "00006"
        Me.BP_AjusMinH1.SelectTextAlternate = False
        Me.BP_AjusMinH1.Size = New System.Drawing.Size(97, 42)
        Me.BP_AjusMinH1.TabIndex = 1247
        Me.BP_AjusMinH1.Text = "Ajustar"
        Me.BP_AjusMinH1.TextAlternate = Nothing
        Me.BP_AjusMinH1.UseVisualStyleBackColor = True
        Me.BP_AjusMinH1.ValueToWrite = 0
        '
        'BP_AjusMaxH1
        '
        Me.BP_AjusMaxH1.BackColor = System.Drawing.SystemColors.Control
        Me.BP_AjusMaxH1.ComComponent = Me.Ajustes_T_H3
        Me.BP_AjusMaxH1.ForeColor = System.Drawing.Color.Black
        Me.BP_AjusMaxH1.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_AjusMaxH1.Highlight = False
        Me.BP_AjusMaxH1.HighlightColor = System.Drawing.Color.Green
        Me.BP_AjusMaxH1.Location = New System.Drawing.Point(329, 73)
        Me.BP_AjusMaxH1.MaximumHoldTime = 3000
        Me.BP_AjusMaxH1.MinimumHoldTime = 500
        Me.BP_AjusMaxH1.Name = "BP_AjusMaxH1"
        Me.BP_AjusMaxH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BP_AjusMaxH1.PLCAddressClick = "00005"
        Me.BP_AjusMaxH1.SelectTextAlternate = False
        Me.BP_AjusMaxH1.Size = New System.Drawing.Size(97, 42)
        Me.BP_AjusMaxH1.TabIndex = 1246
        Me.BP_AjusMaxH1.Text = "Ajustar"
        Me.BP_AjusMaxH1.TextAlternate = Nothing
        Me.BP_AjusMaxH1.UseVisualStyleBackColor = True
        Me.BP_AjusMaxH1.ValueToWrite = 0
        '
        'DM_AjusMinH1
        '
        Me.DM_AjusMinH1.BackColor = System.Drawing.Color.Transparent
        Me.DM_AjusMinH1.ComComponent = Me.Ajustes_T_H3
        Me.DM_AjusMinH1.DecimalPosition = 1
        Me.DM_AjusMinH1.ForeColor = System.Drawing.Color.LightGray
        Me.DM_AjusMinH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DM_AjusMinH1.KeypadMaxValue = 0R
        Me.DM_AjusMinH1.KeypadMinValue = 0R
        Me.DM_AjusMinH1.KeypadScaleFactor = 0.1R
        Me.DM_AjusMinH1.KeypadText = Nothing
        Me.DM_AjusMinH1.KeypadWidth = 300
        Me.DM_AjusMinH1.Location = New System.Drawing.Point(200, 178)
        Me.DM_AjusMinH1.Name = "DM_AjusMinH1"
        Me.DM_AjusMinH1.NumberOfDigits = 5
        Me.DM_AjusMinH1.PLCAddressKeypad = "40022"
        Me.DM_AjusMinH1.PLCAddressValue = "40022"
        Me.DM_AjusMinH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjusMinH1.Size = New System.Drawing.Size(97, 42)
        Me.DM_AjusMinH1.TabIndex = 1245
        Me.DM_AjusMinH1.Value = 0R
        Me.DM_AjusMinH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjusMinH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DM_AjustadoH1
        '
        Me.DM_AjustadoH1.BackColor = System.Drawing.Color.Transparent
        Me.DM_AjustadoH1.ComComponent = Me.Ajustes_T_H3
        Me.DM_AjustadoH1.DecimalPosition = 1
        Me.DM_AjustadoH1.ForeColor = System.Drawing.Color.LightGray
        Me.DM_AjustadoH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DM_AjustadoH1.KeypadMaxValue = 0R
        Me.DM_AjustadoH1.KeypadMinValue = 0R
        Me.DM_AjustadoH1.KeypadScaleFactor = 1.0R
        Me.DM_AjustadoH1.KeypadText = Nothing
        Me.DM_AjustadoH1.KeypadWidth = 300
        Me.DM_AjustadoH1.Location = New System.Drawing.Point(329, 124)
        Me.DM_AjustadoH1.Name = "DM_AjustadoH1"
        Me.DM_AjustadoH1.NumberOfDigits = 5
        Me.DM_AjustadoH1.PLCAddressKeypad = ""
        Me.DM_AjustadoH1.PLCAddressValue = "40020"
        Me.DM_AjustadoH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjustadoH1.Size = New System.Drawing.Size(97, 42)
        Me.DM_AjustadoH1.TabIndex = 1244
        Me.DM_AjustadoH1.Value = 0R
        Me.DM_AjustadoH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjustadoH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DM_AjusMaxH1
        '
        Me.DM_AjusMaxH1.BackColor = System.Drawing.Color.Transparent
        Me.DM_AjusMaxH1.ComComponent = Me.Ajustes_T_H3
        Me.DM_AjusMaxH1.DecimalPosition = 1
        Me.DM_AjusMaxH1.ForeColor = System.Drawing.Color.LightGray
        Me.DM_AjusMaxH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DM_AjusMaxH1.KeypadMaxValue = 0R
        Me.DM_AjusMaxH1.KeypadMinValue = 0R
        Me.DM_AjusMaxH1.KeypadScaleFactor = 0.1R
        Me.DM_AjusMaxH1.KeypadText = Nothing
        Me.DM_AjusMaxH1.KeypadWidth = 300
        Me.DM_AjusMaxH1.Location = New System.Drawing.Point(200, 73)
        Me.DM_AjusMaxH1.Name = "DM_AjusMaxH1"
        Me.DM_AjusMaxH1.NumberOfDigits = 5
        Me.DM_AjusMaxH1.PLCAddressKeypad = "40021"
        Me.DM_AjusMaxH1.PLCAddressValue = "40021"
        Me.DM_AjusMaxH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjusMaxH1.Size = New System.Drawing.Size(97, 42)
        Me.DM_AjusMaxH1.TabIndex = 1243
        Me.DM_AjusMaxH1.Value = 0R
        Me.DM_AjusMaxH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjusMaxH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(859, 244)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(230, 19)
        Me.Label15.TabIndex = 1242
        Me.Label15.Text = "Ajuste de Temperatura SC-05"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(883, 341)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 18)
        Me.Label16.TabIndex = 1241
        Me.Label16.Text = "Valor Ajustado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(869, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(230, 19)
        Me.Label13.TabIndex = 1240
        Me.Label13.Text = "Ajuste de Temperatura SC-04"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(883, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 18)
        Me.Label14.TabIndex = 1239
        Me.Label14.Text = "Valor Ajustado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(548, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(230, 19)
        Me.Label11.TabIndex = 1238
        Me.Label11.Text = "Ajuste de Temperatura SC-03"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(561, 551)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 18)
        Me.Label12.TabIndex = 1237
        Me.Label12.Text = "Valor Ajustado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(547, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(230, 19)
        Me.Label9.TabIndex = 1236
        Me.Label9.Text = "Ajuste de Temperatura SC-02"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(561, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 18)
        Me.Label10.TabIndex = 1235
        Me.Label10.Text = "Valor Ajustado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(551, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 19)
        Me.Label7.TabIndex = 1234
        Me.Label7.Text = "Ajuste de Temperatura Aire 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(561, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 1233
        Me.Label8.Text = "Valor Ajustado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(199, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 19)
        Me.Label5.TabIndex = 1232
        Me.Label5.Text = "Ajuste de Temperatura Aire 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 551)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 1231
        Me.Label6.Text = "Valor Ajustado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(187, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 19)
        Me.Label3.TabIndex = 1230
        Me.Label3.Text = "Ajuste de Temperatura Chimenea"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 1229
        Me.Label4.Text = "Valor Ajustado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(196, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 19)
        Me.Label2.TabIndex = 1228
        Me.Label2.Text = "Ajuste de Temperatura Hoguera"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 1227
        Me.Label1.Text = "Valor Ajustado:"
        '
        'Ajustes_Temperatura_H3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BCF_MenúP_Cascarilla)
        Me.Controls.Add(Me.BasicButton13)
        Me.Controls.Add(Me.BasicButton14)
        Me.Controls.Add(Me.DigitalPanelMeter19)
        Me.Controls.Add(Me.DigitalPanelMeter20)
        Me.Controls.Add(Me.DigitalPanelMeter21)
        Me.Controls.Add(Me.BasicButton11)
        Me.Controls.Add(Me.BasicButton12)
        Me.Controls.Add(Me.DigitalPanelMeter16)
        Me.Controls.Add(Me.DigitalPanelMeter17)
        Me.Controls.Add(Me.DigitalPanelMeter18)
        Me.Controls.Add(Me.BasicButton9)
        Me.Controls.Add(Me.BasicButton10)
        Me.Controls.Add(Me.DigitalPanelMeter13)
        Me.Controls.Add(Me.DigitalPanelMeter14)
        Me.Controls.Add(Me.DigitalPanelMeter15)
        Me.Controls.Add(Me.BasicButton7)
        Me.Controls.Add(Me.BasicButton8)
        Me.Controls.Add(Me.DigitalPanelMeter10)
        Me.Controls.Add(Me.DigitalPanelMeter11)
        Me.Controls.Add(Me.DigitalPanelMeter12)
        Me.Controls.Add(Me.BasicButton5)
        Me.Controls.Add(Me.BasicButton6)
        Me.Controls.Add(Me.DigitalPanelMeter7)
        Me.Controls.Add(Me.DigitalPanelMeter8)
        Me.Controls.Add(Me.DigitalPanelMeter9)
        Me.Controls.Add(Me.BasicButton3)
        Me.Controls.Add(Me.BasicButton4)
        Me.Controls.Add(Me.DigitalPanelMeter4)
        Me.Controls.Add(Me.DigitalPanelMeter5)
        Me.Controls.Add(Me.DigitalPanelMeter6)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.BasicButton2)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.DigitalPanelMeter3)
        Me.Controls.Add(Me.BP_AjusMinH1)
        Me.Controls.Add(Me.BP_AjusMaxH1)
        Me.Controls.Add(Me.DM_AjusMinH1)
        Me.Controls.Add(Me.DM_AjustadoH1)
        Me.Controls.Add(Me.DM_AjusMaxH1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Ajustes_Temperatura_H3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Ajustes_T_H3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BCF_MenúP_Cascarilla As FormChangeButton
    Friend WithEvents BasicButton13 As AdvancedHMIControls.BasicButton
    Friend WithEvents Ajustes_T_H3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BasicButton14 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter19 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter20 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter21 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton12 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter17 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter18 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton9 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton10 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton7 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton8 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton5 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton6 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter7 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter8 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter9 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton3 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton4 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter4 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter5 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter6 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_AjusMinH1 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_AjusMaxH1 As AdvancedHMIControls.BasicButton
    Friend WithEvents DM_AjusMinH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DM_AjustadoH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DM_AjusMaxH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
