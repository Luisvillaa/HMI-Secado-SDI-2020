<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajustes_Temperatura_H1_H2
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
        Me.FormChangeButton1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BasicButton9 = New AdvancedHMIControls.BasicButton()
        Me.Ajustes_T_H2_Cont = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
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
        Me.Ajustes_T_H1_Cont = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
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
        CType(Me.Ajustes_T_H2_Cont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ajustes_T_H1_Cont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.Color.Blue
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.White
        Me.FormChangeButton1.FormToOpen = GetType(MfgControl.AdvancedHMI.Ajustes_Temperatura_H1)
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(219, 655)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = Nothing
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(151, 54)
        Me.FormChangeButton1.TabIndex = 1303
        Me.FormChangeButton1.Text = "Regresar H1"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = Nothing
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(1015, 655)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1302
        Me.BCF_RegresarH1.Text = "Regresar H2"
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
        Me.BCF_MenúP_Cascarilla.Location = New System.Drawing.Point(602, 655)
        Me.BCF_MenúP_Cascarilla.Name = "BCF_MenúP_Cascarilla"
        Me.BCF_MenúP_Cascarilla.Passcode = Nothing
        Me.BCF_MenúP_Cascarilla.PasswordChar = False
        Me.BCF_MenúP_Cascarilla.PLCAddressVisible = ""
        Me.BCF_MenúP_Cascarilla.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_Cascarilla.TabIndex = 1301
        Me.BCF_MenúP_Cascarilla.Text = "Menú Principal"
        Me.BCF_MenúP_Cascarilla.UseVisualStyleBackColor = False
        '
        'BasicButton9
        '
        Me.BasicButton9.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton9.ComComponent = Me.Ajustes_T_H2_Cont
        Me.BasicButton9.ForeColor = System.Drawing.Color.Black
        Me.BasicButton9.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton9.Highlight = False
        Me.BasicButton9.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton9.Location = New System.Drawing.Point(721, 385)
        Me.BasicButton9.MaximumHoldTime = 3000
        Me.BasicButton9.MinimumHoldTime = 500
        Me.BasicButton9.Name = "BasicButton9"
        Me.BasicButton9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton9.PLCAddressClick = "BP_AJUSTET_MIN_AIRE1"
        Me.BasicButton9.SelectTextAlternate = False
        Me.BasicButton9.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton9.TabIndex = 1300
        Me.BasicButton9.Text = "Ajustar"
        Me.BasicButton9.TextAlternate = Nothing
        Me.BasicButton9.UseVisualStyleBackColor = True
        Me.BasicButton9.ValueToWrite = 0
        '
        'Ajustes_T_H2_Cont
        '
        Me.Ajustes_T_H2_Cont.CIPConnectionSize = 508
        Me.Ajustes_T_H2_Cont.DisableMultiServiceRequest = False
        Me.Ajustes_T_H2_Cont.DisableSubscriptions = False
        Me.Ajustes_T_H2_Cont.IniFileName = ""
        Me.Ajustes_T_H2_Cont.IniFileSection = Nothing
        Me.Ajustes_T_H2_Cont.IPAddress = "10.1.108.18"
        Me.Ajustes_T_H2_Cont.PollRateOverride = 500
        Me.Ajustes_T_H2_Cont.Port = 44818
        Me.Ajustes_T_H2_Cont.ProcessorSlot = 0
        Me.Ajustes_T_H2_Cont.RoutePath = Nothing
        Me.Ajustes_T_H2_Cont.Timeout = 4000
        '
        'BasicButton10
        '
        Me.BasicButton10.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton10.ComComponent = Me.Ajustes_T_H2_Cont
        Me.BasicButton10.ForeColor = System.Drawing.Color.Black
        Me.BasicButton10.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton10.Highlight = False
        Me.BasicButton10.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton10.Location = New System.Drawing.Point(721, 280)
        Me.BasicButton10.MaximumHoldTime = 3000
        Me.BasicButton10.MinimumHoldTime = 500
        Me.BasicButton10.Name = "BasicButton10"
        Me.BasicButton10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton10.PLCAddressClick = "BP_AJUSTET_MAX_AIRE1"
        Me.BasicButton10.SelectTextAlternate = False
        Me.BasicButton10.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton10.TabIndex = 1299
        Me.BasicButton10.Text = "Ajustar"
        Me.BasicButton10.TextAlternate = Nothing
        Me.BasicButton10.UseVisualStyleBackColor = True
        Me.BasicButton10.ValueToWrite = 0
        '
        'DigitalPanelMeter13
        '
        Me.DigitalPanelMeter13.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter13.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter13.DecimalPosition = 1
        Me.DigitalPanelMeter13.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter13.KeypadMaxValue = 0R
        Me.DigitalPanelMeter13.KeypadMinValue = 0R
        Me.DigitalPanelMeter13.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter13.KeypadText = Nothing
        Me.DigitalPanelMeter13.KeypadWidth = 300
        Me.DigitalPanelMeter13.Location = New System.Drawing.Point(592, 385)
        Me.DigitalPanelMeter13.Name = "DigitalPanelMeter13"
        Me.DigitalPanelMeter13.NumberOfDigits = 5
        Me.DigitalPanelMeter13.PLCAddressKeypad = "TL_MIN_DIGITADO_AIRE1"
        Me.DigitalPanelMeter13.PLCAddressValue = "TL_MIN_DIGITADO_AIRE1"
        Me.DigitalPanelMeter13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter13.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter13.TabIndex = 1298
        Me.DigitalPanelMeter13.Value = 0R
        Me.DigitalPanelMeter13.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter14
        '
        Me.DigitalPanelMeter14.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter14.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter14.DecimalPosition = 1
        Me.DigitalPanelMeter14.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter14.KeypadMaxValue = 0R
        Me.DigitalPanelMeter14.KeypadMinValue = 0R
        Me.DigitalPanelMeter14.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter14.KeypadText = Nothing
        Me.DigitalPanelMeter14.KeypadWidth = 300
        Me.DigitalPanelMeter14.Location = New System.Drawing.Point(721, 331)
        Me.DigitalPanelMeter14.Name = "DigitalPanelMeter14"
        Me.DigitalPanelMeter14.NumberOfDigits = 5
        Me.DigitalPanelMeter14.PLCAddressKeypad = ""
        Me.DigitalPanelMeter14.PLCAddressValue = "TEMPERATURA_AIRE_1_ESCALA_C"
        Me.DigitalPanelMeter14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter14.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter14.TabIndex = 1297
        Me.DigitalPanelMeter14.Value = 0R
        Me.DigitalPanelMeter14.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter15
        '
        Me.DigitalPanelMeter15.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter15.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter15.DecimalPosition = 1
        Me.DigitalPanelMeter15.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter15.KeypadMaxValue = 0R
        Me.DigitalPanelMeter15.KeypadMinValue = 0R
        Me.DigitalPanelMeter15.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter15.KeypadText = Nothing
        Me.DigitalPanelMeter15.KeypadWidth = 300
        Me.DigitalPanelMeter15.Location = New System.Drawing.Point(592, 280)
        Me.DigitalPanelMeter15.Name = "DigitalPanelMeter15"
        Me.DigitalPanelMeter15.NumberOfDigits = 5
        Me.DigitalPanelMeter15.PLCAddressKeypad = "TL_MAX_DIGITADO_AIRE1"
        Me.DigitalPanelMeter15.PLCAddressValue = "TL_MAX_DIGITADO_AIRE1"
        Me.DigitalPanelMeter15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter15.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter15.TabIndex = 1296
        Me.DigitalPanelMeter15.Value = 0R
        Me.DigitalPanelMeter15.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton7
        '
        Me.BasicButton7.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton7.ComComponent = Me.Ajustes_T_H2_Cont
        Me.BasicButton7.ForeColor = System.Drawing.Color.Black
        Me.BasicButton7.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton7.Highlight = False
        Me.BasicButton7.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton7.Location = New System.Drawing.Point(721, 597)
        Me.BasicButton7.MaximumHoldTime = 3000
        Me.BasicButton7.MinimumHoldTime = 500
        Me.BasicButton7.Name = "BasicButton7"
        Me.BasicButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton7.PLCAddressClick = "BP_AJUSTET_MIN_AIRE2"
        Me.BasicButton7.SelectTextAlternate = False
        Me.BasicButton7.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton7.TabIndex = 1295
        Me.BasicButton7.Text = "Ajustar"
        Me.BasicButton7.TextAlternate = Nothing
        Me.BasicButton7.UseVisualStyleBackColor = True
        Me.BasicButton7.ValueToWrite = 0
        '
        'BasicButton8
        '
        Me.BasicButton8.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton8.ComComponent = Me.Ajustes_T_H2_Cont
        Me.BasicButton8.ForeColor = System.Drawing.Color.Black
        Me.BasicButton8.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton8.Highlight = False
        Me.BasicButton8.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton8.Location = New System.Drawing.Point(721, 492)
        Me.BasicButton8.MaximumHoldTime = 3000
        Me.BasicButton8.MinimumHoldTime = 500
        Me.BasicButton8.Name = "BasicButton8"
        Me.BasicButton8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton8.PLCAddressClick = "BP_AJUSTET_MAX_AIRE2"
        Me.BasicButton8.SelectTextAlternate = False
        Me.BasicButton8.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton8.TabIndex = 1294
        Me.BasicButton8.Text = "Ajustar"
        Me.BasicButton8.TextAlternate = Nothing
        Me.BasicButton8.UseVisualStyleBackColor = True
        Me.BasicButton8.ValueToWrite = 0
        '
        'DigitalPanelMeter10
        '
        Me.DigitalPanelMeter10.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter10.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter10.DecimalPosition = 1
        Me.DigitalPanelMeter10.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter10.KeypadMaxValue = 0R
        Me.DigitalPanelMeter10.KeypadMinValue = 0R
        Me.DigitalPanelMeter10.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter10.KeypadText = Nothing
        Me.DigitalPanelMeter10.KeypadWidth = 300
        Me.DigitalPanelMeter10.Location = New System.Drawing.Point(592, 597)
        Me.DigitalPanelMeter10.Name = "DigitalPanelMeter10"
        Me.DigitalPanelMeter10.NumberOfDigits = 5
        Me.DigitalPanelMeter10.PLCAddressKeypad = "TL_MIN_DIGITADO_AIRE2"
        Me.DigitalPanelMeter10.PLCAddressValue = "TL_MIN_DIGITADO_AIRE2"
        Me.DigitalPanelMeter10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter10.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter10.TabIndex = 1293
        Me.DigitalPanelMeter10.Value = 0R
        Me.DigitalPanelMeter10.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter11
        '
        Me.DigitalPanelMeter11.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter11.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter11.DecimalPosition = 1
        Me.DigitalPanelMeter11.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter11.KeypadMaxValue = 0R
        Me.DigitalPanelMeter11.KeypadMinValue = 0R
        Me.DigitalPanelMeter11.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter11.KeypadText = Nothing
        Me.DigitalPanelMeter11.KeypadWidth = 300
        Me.DigitalPanelMeter11.Location = New System.Drawing.Point(721, 543)
        Me.DigitalPanelMeter11.Name = "DigitalPanelMeter11"
        Me.DigitalPanelMeter11.NumberOfDigits = 5
        Me.DigitalPanelMeter11.PLCAddressKeypad = ""
        Me.DigitalPanelMeter11.PLCAddressValue = "TEMPERATURA_AIRE_2_ESCALA_C"
        Me.DigitalPanelMeter11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter11.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter11.TabIndex = 1292
        Me.DigitalPanelMeter11.Value = 0R
        Me.DigitalPanelMeter11.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter12
        '
        Me.DigitalPanelMeter12.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter12.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter12.DecimalPosition = 1
        Me.DigitalPanelMeter12.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter12.KeypadMaxValue = 0R
        Me.DigitalPanelMeter12.KeypadMinValue = 0R
        Me.DigitalPanelMeter12.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter12.KeypadText = Nothing
        Me.DigitalPanelMeter12.KeypadWidth = 300
        Me.DigitalPanelMeter12.Location = New System.Drawing.Point(592, 492)
        Me.DigitalPanelMeter12.Name = "DigitalPanelMeter12"
        Me.DigitalPanelMeter12.NumberOfDigits = 5
        Me.DigitalPanelMeter12.PLCAddressKeypad = "TL_MAX_DIGITADO_AIRE2"
        Me.DigitalPanelMeter12.PLCAddressValue = "TL_MAX_DIGITADO_AIRE2"
        Me.DigitalPanelMeter12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter12.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter12.TabIndex = 1291
        Me.DigitalPanelMeter12.Value = 0R
        Me.DigitalPanelMeter12.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton5
        '
        Me.BasicButton5.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton5.ComComponent = Me.Ajustes_T_H2_Cont
        Me.BasicButton5.ForeColor = System.Drawing.Color.Black
        Me.BasicButton5.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton5.Highlight = False
        Me.BasicButton5.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton5.Location = New System.Drawing.Point(721, 181)
        Me.BasicButton5.MaximumHoldTime = 3000
        Me.BasicButton5.MinimumHoldTime = 500
        Me.BasicButton5.Name = "BasicButton5"
        Me.BasicButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton5.PLCAddressClick = "BP_AJUSTET_MIN_CHIMENEA"
        Me.BasicButton5.SelectTextAlternate = False
        Me.BasicButton5.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton5.TabIndex = 1290
        Me.BasicButton5.Text = "Ajustar"
        Me.BasicButton5.TextAlternate = Nothing
        Me.BasicButton5.UseVisualStyleBackColor = True
        Me.BasicButton5.ValueToWrite = 0
        '
        'BasicButton6
        '
        Me.BasicButton6.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton6.ComComponent = Me.Ajustes_T_H2_Cont
        Me.BasicButton6.ForeColor = System.Drawing.Color.Black
        Me.BasicButton6.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton6.Highlight = False
        Me.BasicButton6.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton6.Location = New System.Drawing.Point(721, 76)
        Me.BasicButton6.MaximumHoldTime = 3000
        Me.BasicButton6.MinimumHoldTime = 500
        Me.BasicButton6.Name = "BasicButton6"
        Me.BasicButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton6.PLCAddressClick = "BP_AJUSTET_MAX_CHIMENEA"
        Me.BasicButton6.SelectTextAlternate = False
        Me.BasicButton6.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton6.TabIndex = 1289
        Me.BasicButton6.Text = "Ajustar"
        Me.BasicButton6.TextAlternate = Nothing
        Me.BasicButton6.UseVisualStyleBackColor = True
        Me.BasicButton6.ValueToWrite = 0
        '
        'DigitalPanelMeter7
        '
        Me.DigitalPanelMeter7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter7.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter7.DecimalPosition = 1
        Me.DigitalPanelMeter7.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter7.KeypadMaxValue = 0R
        Me.DigitalPanelMeter7.KeypadMinValue = 0R
        Me.DigitalPanelMeter7.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter7.KeypadText = Nothing
        Me.DigitalPanelMeter7.KeypadWidth = 300
        Me.DigitalPanelMeter7.Location = New System.Drawing.Point(592, 181)
        Me.DigitalPanelMeter7.Name = "DigitalPanelMeter7"
        Me.DigitalPanelMeter7.NumberOfDigits = 5
        Me.DigitalPanelMeter7.PLCAddressKeypad = "TL_MIN_DIGITADO_CHIMENEA"
        Me.DigitalPanelMeter7.PLCAddressValue = "TL_MIN_DIGITADO_CHIMENEA"
        Me.DigitalPanelMeter7.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter7.TabIndex = 1288
        Me.DigitalPanelMeter7.Value = 0R
        Me.DigitalPanelMeter7.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter7.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter8
        '
        Me.DigitalPanelMeter8.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter8.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter8.DecimalPosition = 1
        Me.DigitalPanelMeter8.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter8.KeypadMaxValue = 0R
        Me.DigitalPanelMeter8.KeypadMinValue = 0R
        Me.DigitalPanelMeter8.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter8.KeypadText = Nothing
        Me.DigitalPanelMeter8.KeypadWidth = 300
        Me.DigitalPanelMeter8.Location = New System.Drawing.Point(721, 127)
        Me.DigitalPanelMeter8.Name = "DigitalPanelMeter8"
        Me.DigitalPanelMeter8.NumberOfDigits = 5
        Me.DigitalPanelMeter8.PLCAddressKeypad = ""
        Me.DigitalPanelMeter8.PLCAddressValue = "TEMP_CHIMENEA_ESCALADA_C"
        Me.DigitalPanelMeter8.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter8.TabIndex = 1287
        Me.DigitalPanelMeter8.Value = 0R
        Me.DigitalPanelMeter8.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter8.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter9
        '
        Me.DigitalPanelMeter9.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter9.ComComponent = Me.Ajustes_T_H2_Cont
        Me.DigitalPanelMeter9.DecimalPosition = 1
        Me.DigitalPanelMeter9.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter9.KeypadMaxValue = 0R
        Me.DigitalPanelMeter9.KeypadMinValue = 0R
        Me.DigitalPanelMeter9.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter9.KeypadText = Nothing
        Me.DigitalPanelMeter9.KeypadWidth = 300
        Me.DigitalPanelMeter9.Location = New System.Drawing.Point(592, 76)
        Me.DigitalPanelMeter9.Name = "DigitalPanelMeter9"
        Me.DigitalPanelMeter9.NumberOfDigits = 5
        Me.DigitalPanelMeter9.PLCAddressKeypad = "TL_MAX_DIGITADO_CHIMENEA"
        Me.DigitalPanelMeter9.PLCAddressValue = "TL_MAX_DIGITADO_CHIMENEA"
        Me.DigitalPanelMeter9.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter9.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter9.TabIndex = 1286
        Me.DigitalPanelMeter9.Value = 0R
        Me.DigitalPanelMeter9.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter9.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton3.ComComponent = Me.Ajustes_T_H1_Cont
        Me.BasicButton3.ForeColor = System.Drawing.Color.Black
        Me.BasicButton3.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton3.Location = New System.Drawing.Point(334, 597)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton3.PLCAddressClick = "BP_AJUSTET_MIN_AIRE2"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton3.TabIndex = 1285
        Me.BasicButton3.Text = "Ajustar"
        Me.BasicButton3.TextAlternate = Nothing
        Me.BasicButton3.UseVisualStyleBackColor = True
        Me.BasicButton3.ValueToWrite = 0
        '
        'Ajustes_T_H1_Cont
        '
        Me.Ajustes_T_H1_Cont.CIPConnectionSize = 508
        Me.Ajustes_T_H1_Cont.DisableMultiServiceRequest = False
        Me.Ajustes_T_H1_Cont.DisableSubscriptions = False
        Me.Ajustes_T_H1_Cont.IniFileName = ""
        Me.Ajustes_T_H1_Cont.IniFileSection = Nothing
        Me.Ajustes_T_H1_Cont.IPAddress = "10.1.108.20"
        Me.Ajustes_T_H1_Cont.PollRateOverride = 500
        Me.Ajustes_T_H1_Cont.Port = 44818
        Me.Ajustes_T_H1_Cont.ProcessorSlot = 0
        Me.Ajustes_T_H1_Cont.RoutePath = Nothing
        Me.Ajustes_T_H1_Cont.Timeout = 4000
        '
        'BasicButton4
        '
        Me.BasicButton4.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton4.ComComponent = Me.Ajustes_T_H1_Cont
        Me.BasicButton4.ForeColor = System.Drawing.Color.Black
        Me.BasicButton4.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton4.Highlight = False
        Me.BasicButton4.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton4.Location = New System.Drawing.Point(334, 492)
        Me.BasicButton4.MaximumHoldTime = 3000
        Me.BasicButton4.MinimumHoldTime = 500
        Me.BasicButton4.Name = "BasicButton4"
        Me.BasicButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton4.PLCAddressClick = "BP_AJUSTET_MAX_AIRE2"
        Me.BasicButton4.SelectTextAlternate = False
        Me.BasicButton4.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton4.TabIndex = 1284
        Me.BasicButton4.Text = "Ajustar"
        Me.BasicButton4.TextAlternate = Nothing
        Me.BasicButton4.UseVisualStyleBackColor = True
        Me.BasicButton4.ValueToWrite = 0
        '
        'DigitalPanelMeter4
        '
        Me.DigitalPanelMeter4.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter4.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DigitalPanelMeter4.DecimalPosition = 1
        Me.DigitalPanelMeter4.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter4.KeypadMaxValue = 0R
        Me.DigitalPanelMeter4.KeypadMinValue = 0R
        Me.DigitalPanelMeter4.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter4.KeypadText = Nothing
        Me.DigitalPanelMeter4.KeypadWidth = 300
        Me.DigitalPanelMeter4.Location = New System.Drawing.Point(205, 597)
        Me.DigitalPanelMeter4.Name = "DigitalPanelMeter4"
        Me.DigitalPanelMeter4.NumberOfDigits = 5
        Me.DigitalPanelMeter4.PLCAddressKeypad = "TL_MIN_DIGITADO_AIRE2"
        Me.DigitalPanelMeter4.PLCAddressValue = "TL_MIN_DIGITADO_AIRE2"
        Me.DigitalPanelMeter4.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter4.TabIndex = 1283
        Me.DigitalPanelMeter4.Value = 0R
        Me.DigitalPanelMeter4.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter4.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter5
        '
        Me.DigitalPanelMeter5.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter5.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DigitalPanelMeter5.DecimalPosition = 1
        Me.DigitalPanelMeter5.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter5.KeypadMaxValue = 0R
        Me.DigitalPanelMeter5.KeypadMinValue = 0R
        Me.DigitalPanelMeter5.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter5.KeypadText = Nothing
        Me.DigitalPanelMeter5.KeypadWidth = 300
        Me.DigitalPanelMeter5.Location = New System.Drawing.Point(334, 543)
        Me.DigitalPanelMeter5.Name = "DigitalPanelMeter5"
        Me.DigitalPanelMeter5.NumberOfDigits = 5
        Me.DigitalPanelMeter5.PLCAddressKeypad = ""
        Me.DigitalPanelMeter5.PLCAddressValue = "TEMPERATURA_AIRE_2_ESCALA_C"
        Me.DigitalPanelMeter5.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter5.TabIndex = 1282
        Me.DigitalPanelMeter5.Value = 0R
        Me.DigitalPanelMeter5.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter5.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DigitalPanelMeter6.DecimalPosition = 1
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(205, 492)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 5
        Me.DigitalPanelMeter6.PLCAddressKeypad = "TL_MAX_DIGITADO_AIRE2"
        Me.DigitalPanelMeter6.PLCAddressValue = "TL_MAX_DIGITADO_AIRE2"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter6.TabIndex = 1281
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(334, 385)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = "BP_AJUSTET_MIN_AIRE1"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton1.TabIndex = 1280
        Me.BasicButton1.Text = "Ajustar"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton2.ComComponent = Me.Ajustes_T_H1_Cont
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.Location = New System.Drawing.Point(334, 280)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton2.PLCAddressClick = "BP_AJUSTET_MAX_AIRE1"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(97, 42)
        Me.BasicButton2.TabIndex = 1279
        Me.BasicButton2.Text = "Ajustar"
        Me.BasicButton2.TextAlternate = Nothing
        Me.BasicButton2.UseVisualStyleBackColor = True
        Me.BasicButton2.ValueToWrite = 0
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DigitalPanelMeter1.DecimalPosition = 1
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(205, 385)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = "TL_MIN_DIGITADO_AIRE1"
        Me.DigitalPanelMeter1.PLCAddressValue = "TL_MIN_DIGITADO_AIRE1"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter1.TabIndex = 1278
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DigitalPanelMeter2.DecimalPosition = 1
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(334, 331)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = ""
        Me.DigitalPanelMeter2.PLCAddressValue = "TEMPERATURA_AIRE_1_ESCALA_C"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter2.TabIndex = 1277
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter3
        '
        Me.DigitalPanelMeter3.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter3.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DigitalPanelMeter3.DecimalPosition = 1
        Me.DigitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter3.KeypadMaxValue = 0R
        Me.DigitalPanelMeter3.KeypadMinValue = 0R
        Me.DigitalPanelMeter3.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter3.KeypadText = Nothing
        Me.DigitalPanelMeter3.KeypadWidth = 300
        Me.DigitalPanelMeter3.Location = New System.Drawing.Point(205, 280)
        Me.DigitalPanelMeter3.Name = "DigitalPanelMeter3"
        Me.DigitalPanelMeter3.NumberOfDigits = 5
        Me.DigitalPanelMeter3.PLCAddressKeypad = "TL_MAX_DIGITADO_AIRE1"
        Me.DigitalPanelMeter3.PLCAddressValue = "TL_MAX_DIGITADO_AIRE1"
        Me.DigitalPanelMeter3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.Size = New System.Drawing.Size(97, 42)
        Me.DigitalPanelMeter3.TabIndex = 1276
        Me.DigitalPanelMeter3.Value = 0R
        Me.DigitalPanelMeter3.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_AjusMinH1
        '
        Me.BP_AjusMinH1.BackColor = System.Drawing.SystemColors.Control
        Me.BP_AjusMinH1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.BP_AjusMinH1.ForeColor = System.Drawing.Color.Black
        Me.BP_AjusMinH1.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_AjusMinH1.Highlight = False
        Me.BP_AjusMinH1.HighlightColor = System.Drawing.Color.Green
        Me.BP_AjusMinH1.Location = New System.Drawing.Point(334, 181)
        Me.BP_AjusMinH1.MaximumHoldTime = 3000
        Me.BP_AjusMinH1.MinimumHoldTime = 500
        Me.BP_AjusMinH1.Name = "BP_AjusMinH1"
        Me.BP_AjusMinH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_AjusMinH1.PLCAddressClick = "BP_AJUSTET_MIN_CHIMENEA"
        Me.BP_AjusMinH1.SelectTextAlternate = False
        Me.BP_AjusMinH1.Size = New System.Drawing.Size(97, 42)
        Me.BP_AjusMinH1.TabIndex = 1275
        Me.BP_AjusMinH1.Text = "Ajustar"
        Me.BP_AjusMinH1.TextAlternate = Nothing
        Me.BP_AjusMinH1.UseVisualStyleBackColor = True
        Me.BP_AjusMinH1.ValueToWrite = 0
        '
        'BP_AjusMaxH1
        '
        Me.BP_AjusMaxH1.BackColor = System.Drawing.SystemColors.Control
        Me.BP_AjusMaxH1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.BP_AjusMaxH1.ForeColor = System.Drawing.Color.Black
        Me.BP_AjusMaxH1.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_AjusMaxH1.Highlight = False
        Me.BP_AjusMaxH1.HighlightColor = System.Drawing.Color.Green
        Me.BP_AjusMaxH1.Location = New System.Drawing.Point(334, 76)
        Me.BP_AjusMaxH1.MaximumHoldTime = 3000
        Me.BP_AjusMaxH1.MinimumHoldTime = 500
        Me.BP_AjusMaxH1.Name = "BP_AjusMaxH1"
        Me.BP_AjusMaxH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_AjusMaxH1.PLCAddressClick = "BP_AJUSTET_MAX_CHIMENEA"
        Me.BP_AjusMaxH1.SelectTextAlternate = False
        Me.BP_AjusMaxH1.Size = New System.Drawing.Size(97, 42)
        Me.BP_AjusMaxH1.TabIndex = 1274
        Me.BP_AjusMaxH1.Text = "Ajustar"
        Me.BP_AjusMaxH1.TextAlternate = Nothing
        Me.BP_AjusMaxH1.UseVisualStyleBackColor = True
        Me.BP_AjusMaxH1.ValueToWrite = 0
        '
        'DM_AjusMinH1
        '
        Me.DM_AjusMinH1.BackColor = System.Drawing.Color.Transparent
        Me.DM_AjusMinH1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DM_AjusMinH1.DecimalPosition = 1
        Me.DM_AjusMinH1.ForeColor = System.Drawing.Color.LightGray
        Me.DM_AjusMinH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DM_AjusMinH1.KeypadMaxValue = 0R
        Me.DM_AjusMinH1.KeypadMinValue = 0R
        Me.DM_AjusMinH1.KeypadScaleFactor = 1.0R
        Me.DM_AjusMinH1.KeypadText = Nothing
        Me.DM_AjusMinH1.KeypadWidth = 300
        Me.DM_AjusMinH1.Location = New System.Drawing.Point(205, 181)
        Me.DM_AjusMinH1.Name = "DM_AjusMinH1"
        Me.DM_AjusMinH1.NumberOfDigits = 5
        Me.DM_AjusMinH1.PLCAddressKeypad = "TL_MIN_DIGITADO_CHIMENEA"
        Me.DM_AjusMinH1.PLCAddressValue = "TL_MIN_DIGITADO_CHIMENEA"
        Me.DM_AjusMinH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjusMinH1.Size = New System.Drawing.Size(97, 42)
        Me.DM_AjusMinH1.TabIndex = 1273
        Me.DM_AjusMinH1.Value = 0R
        Me.DM_AjusMinH1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DM_AjusMinH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DM_AjustadoH1
        '
        Me.DM_AjustadoH1.BackColor = System.Drawing.Color.Transparent
        Me.DM_AjustadoH1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DM_AjustadoH1.DecimalPosition = 1
        Me.DM_AjustadoH1.ForeColor = System.Drawing.Color.LightGray
        Me.DM_AjustadoH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DM_AjustadoH1.KeypadMaxValue = 0R
        Me.DM_AjustadoH1.KeypadMinValue = 0R
        Me.DM_AjustadoH1.KeypadScaleFactor = 1.0R
        Me.DM_AjustadoH1.KeypadText = Nothing
        Me.DM_AjustadoH1.KeypadWidth = 300
        Me.DM_AjustadoH1.Location = New System.Drawing.Point(334, 127)
        Me.DM_AjustadoH1.Name = "DM_AjustadoH1"
        Me.DM_AjustadoH1.NumberOfDigits = 5
        Me.DM_AjustadoH1.PLCAddressKeypad = ""
        Me.DM_AjustadoH1.PLCAddressValue = "TEMP_CHIMENEA_ESCALADA_C"
        Me.DM_AjustadoH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjustadoH1.Size = New System.Drawing.Size(97, 42)
        Me.DM_AjustadoH1.TabIndex = 1272
        Me.DM_AjustadoH1.Value = 0R
        Me.DM_AjustadoH1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DM_AjustadoH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DM_AjusMaxH1
        '
        Me.DM_AjusMaxH1.BackColor = System.Drawing.Color.Transparent
        Me.DM_AjusMaxH1.ComComponent = Me.Ajustes_T_H1_Cont
        Me.DM_AjusMaxH1.DecimalPosition = 1
        Me.DM_AjusMaxH1.ForeColor = System.Drawing.Color.LightGray
        Me.DM_AjusMaxH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DM_AjusMaxH1.KeypadMaxValue = 0R
        Me.DM_AjusMaxH1.KeypadMinValue = 0R
        Me.DM_AjusMaxH1.KeypadScaleFactor = 1.0R
        Me.DM_AjusMaxH1.KeypadText = Nothing
        Me.DM_AjusMaxH1.KeypadWidth = 300
        Me.DM_AjusMaxH1.Location = New System.Drawing.Point(205, 76)
        Me.DM_AjusMaxH1.Name = "DM_AjusMaxH1"
        Me.DM_AjusMaxH1.NumberOfDigits = 5
        Me.DM_AjusMaxH1.PLCAddressKeypad = "TL_MAX_DIGITADO_CHIMENEA"
        Me.DM_AjusMaxH1.PLCAddressValue = "TL_MAX_DIGITADO_CHIMENEA"
        Me.DM_AjusMaxH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DM_AjusMaxH1.Size = New System.Drawing.Size(97, 42)
        Me.DM_AjusMaxH1.TabIndex = 1271
        Me.DM_AjusMaxH1.Value = 0R
        Me.DM_AjusMaxH1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DM_AjusMaxH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(542, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(291, 19)
        Me.Label11.TabIndex = 1270
        Me.Label11.Text = "Ajuste de Temperatura Aire 2 Horno 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(603, 554)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 18)
        Me.Label12.TabIndex = 1269
        Me.Label12.Text = "Valor Ajustado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(542, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 19)
        Me.Label9.TabIndex = 1268
        Me.Label9.Text = "Ajuste de Temperatura Aire 1 Horno 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(603, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 18)
        Me.Label10.TabIndex = 1267
        Me.Label10.Text = "Valor Ajustado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(542, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(326, 19)
        Me.Label7.TabIndex = 1266
        Me.Label7.Text = "Ajuste de Temperatura Chimenea Horno 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(603, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 1265
        Me.Label8.Text = "Valor Ajustado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(183, 457)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 19)
        Me.Label5.TabIndex = 1264
        Me.Label5.Text = "Ajuste de Temperatura Aire 2 Horno 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 554)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 1263
        Me.Label6.Text = "Valor Ajustado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(182, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 19)
        Me.Label3.TabIndex = 1262
        Me.Label3.Text = "Ajuste de Temperatura Aire 1 Horno 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 1261
        Me.Label4.Text = "Valor Ajustado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(184, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 19)
        Me.Label2.TabIndex = 1260
        Me.Label2.Text = "Ajuste de Temperatura Chimenea Horno 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 1259
        Me.Label1.Text = "Valor Ajustado:"
        '
        'Ajustes_Temperatura_H1_H2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BCF_MenúP_Cascarilla)
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
        Me.Name = "Ajustes_Temperatura_H1_H2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Ajustes_T_H2_Cont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ajustes_T_H1_Cont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormChangeButton1 As FormChangeButton
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BCF_MenúP_Cascarilla As FormChangeButton
    Friend WithEvents BasicButton9 As AdvancedHMIControls.BasicButton
    Friend WithEvents Ajustes_T_H2_Cont As AdvancedHMIDrivers.EthernetIPforCLXCom
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
    Friend WithEvents Ajustes_T_H1_Cont As AdvancedHMIDrivers.EthernetIPforCLXCom
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
