<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiempos_Horno_3
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
        Me.BP_ResetDatosH1Tiemp = New AdvancedHMIControls.BasicButton()
        Me.TiemposH3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.MD_Vent_y_GU11H1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_Vent_y_GU09H1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_MenúP_TiemposH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.Tex1HorasH1Tiemp = New System.Windows.Forms.Label()
        Me.MD_Vent_y_GU12H1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentCasH1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexTiemposH3 = New System.Windows.Forms.Label()
        Me.TexVent_y_GU11H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVentCasH1Tiemp = New System.Windows.Forms.Label()
        Me.Tex1EquiH1Tiemp = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TexVent_y_GU12H1Tiemp = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.MD_Vent_y_GU10H1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexVent_y_GU10H1Tiemp = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MD_VentChiH1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexVentChiH1Tiemp = New System.Windows.Forms.Label()
        Me.TexVentHogH1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU09H1Tiemp = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MD_VentHogH1Tiemp = New AdvancedHMIControls.DigitalPanelMeter()
        CType(Me.TiemposH3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = GetType(MfgControl.AdvancedHMI.Ingeniería)
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(981, 632)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1151
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BP_ResetDatosH1Tiemp
        '
        Me.BP_ResetDatosH1Tiemp.BackColor = System.Drawing.Color.Red
        Me.BP_ResetDatosH1Tiemp.ComComponent = Me.TiemposH3
        Me.BP_ResetDatosH1Tiemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BP_ResetDatosH1Tiemp.ForeColor = System.Drawing.Color.Black
        Me.BP_ResetDatosH1Tiemp.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ResetDatosH1Tiemp.Highlight = False
        Me.BP_ResetDatosH1Tiemp.HighlightColor = System.Drawing.Color.Green
        Me.BP_ResetDatosH1Tiemp.Location = New System.Drawing.Point(909, 74)
        Me.BP_ResetDatosH1Tiemp.MaximumHoldTime = 3000
        Me.BP_ResetDatosH1Tiemp.MinimumHoldTime = 500
        Me.BP_ResetDatosH1Tiemp.Name = "BP_ResetDatosH1Tiemp"
        Me.BP_ResetDatosH1Tiemp.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_ResetDatosH1Tiemp.PLCAddressClick = "00238"
        Me.BP_ResetDatosH1Tiemp.SelectTextAlternate = False
        Me.BP_ResetDatosH1Tiemp.Size = New System.Drawing.Size(143, 55)
        Me.BP_ResetDatosH1Tiemp.TabIndex = 1150
        Me.BP_ResetDatosH1Tiemp.Text = "Reset Valores"
        Me.BP_ResetDatosH1Tiemp.TextAlternate = Nothing
        Me.BP_ResetDatosH1Tiemp.UseVisualStyleBackColor = False
        Me.BP_ResetDatosH1Tiemp.ValueToWrite = 0
        '
        'TiemposH3
        '
        Me.TiemposH3.DisableSubscriptions = False
        Me.TiemposH3.IniFileName = ""
        Me.TiemposH3.IniFileSection = Nothing
        Me.TiemposH3.IPAddress = "10.1.108.8"
        Me.TiemposH3.MaxReadGroupSize = 20
        Me.TiemposH3.PollRateOverride = 500
        Me.TiemposH3.SwapBytes = True
        Me.TiemposH3.SwapWords = False
        Me.TiemposH3.TcpipPort = CType(20257US, UShort)
        Me.TiemposH3.TimeOut = 3000
        Me.TiemposH3.UnitId = CType(13, Byte)
        '
        'MD_Vent_y_GU11H1Tiemp
        '
        Me.MD_Vent_y_GU11H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_Vent_y_GU11H1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_Vent_y_GU11H1Tiemp.DecimalPosition = 0
        Me.MD_Vent_y_GU11H1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_Vent_y_GU11H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_Vent_y_GU11H1Tiemp.KeypadMaxValue = 0R
        Me.MD_Vent_y_GU11H1Tiemp.KeypadMinValue = 0R
        Me.MD_Vent_y_GU11H1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_Vent_y_GU11H1Tiemp.KeypadText = Nothing
        Me.MD_Vent_y_GU11H1Tiemp.KeypadWidth = 300
        Me.MD_Vent_y_GU11H1Tiemp.Location = New System.Drawing.Point(432, 449)
        Me.MD_Vent_y_GU11H1Tiemp.Name = "MD_Vent_y_GU11H1Tiemp"
        Me.MD_Vent_y_GU11H1Tiemp.NumberOfDigits = 5
        Me.MD_Vent_y_GU11H1Tiemp.PLCAddressKeypad = ""
        Me.MD_Vent_y_GU11H1Tiemp.PLCAddressValue = "40393"
        Me.MD_Vent_y_GU11H1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU11H1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_Vent_y_GU11H1Tiemp.TabIndex = 1149
        Me.MD_Vent_y_GU11H1Tiemp.Value = 0R
        Me.MD_Vent_y_GU11H1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU11H1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_Vent_y_GU09H1Tiemp
        '
        Me.MD_Vent_y_GU09H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_Vent_y_GU09H1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_Vent_y_GU09H1Tiemp.DecimalPosition = 0
        Me.MD_Vent_y_GU09H1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_Vent_y_GU09H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_Vent_y_GU09H1Tiemp.KeypadMaxValue = 0R
        Me.MD_Vent_y_GU09H1Tiemp.KeypadMinValue = 0R
        Me.MD_Vent_y_GU09H1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_Vent_y_GU09H1Tiemp.KeypadText = Nothing
        Me.MD_Vent_y_GU09H1Tiemp.KeypadWidth = 300
        Me.MD_Vent_y_GU09H1Tiemp.Location = New System.Drawing.Point(431, 353)
        Me.MD_Vent_y_GU09H1Tiemp.Name = "MD_Vent_y_GU09H1Tiemp"
        Me.MD_Vent_y_GU09H1Tiemp.NumberOfDigits = 5
        Me.MD_Vent_y_GU09H1Tiemp.PLCAddressKeypad = ""
        Me.MD_Vent_y_GU09H1Tiemp.PLCAddressValue = "40391"
        Me.MD_Vent_y_GU09H1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU09H1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_Vent_y_GU09H1Tiemp.TabIndex = 1148
        Me.MD_Vent_y_GU09H1Tiemp.Value = 0R
        Me.MD_Vent_y_GU09H1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU09H1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_MenúP_TiemposH1
        '
        Me.BCF_MenúP_TiemposH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_TiemposH1.ComComponent = Nothing
        Me.BCF_MenúP_TiemposH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_TiemposH1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_TiemposH1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_TiemposH1.KeypadWidth = 300
        Me.BCF_MenúP_TiemposH1.Location = New System.Drawing.Point(217, 66)
        Me.BCF_MenúP_TiemposH1.Name = "BCF_MenúP_TiemposH1"
        Me.BCF_MenúP_TiemposH1.Passcode = Nothing
        Me.BCF_MenúP_TiemposH1.PasswordChar = False
        Me.BCF_MenúP_TiemposH1.PLCAddressVisible = ""
        Me.BCF_MenúP_TiemposH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_TiemposH1.TabIndex = 1146
        Me.BCF_MenúP_TiemposH1.Text = "Menú Principal"
        Me.BCF_MenúP_TiemposH1.UseVisualStyleBackColor = False
        '
        'Tex1HorasH1Tiemp
        '
        Me.Tex1HorasH1Tiemp.AutoSize = True
        Me.Tex1HorasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1HorasH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.Tex1HorasH1Tiemp.Location = New System.Drawing.Point(405, 183)
        Me.Tex1HorasH1Tiemp.Name = "Tex1HorasH1Tiemp"
        Me.Tex1HorasH1Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex1HorasH1Tiemp.TabIndex = 1138
        Me.Tex1HorasH1Tiemp.Text = "Horas de Trabajo"
        Me.Tex1HorasH1Tiemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MD_Vent_y_GU12H1Tiemp
        '
        Me.MD_Vent_y_GU12H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_Vent_y_GU12H1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_Vent_y_GU12H1Tiemp.DecimalPosition = 0
        Me.MD_Vent_y_GU12H1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_Vent_y_GU12H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_Vent_y_GU12H1Tiemp.KeypadMaxValue = 0R
        Me.MD_Vent_y_GU12H1Tiemp.KeypadMinValue = 0R
        Me.MD_Vent_y_GU12H1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_Vent_y_GU12H1Tiemp.KeypadText = Nothing
        Me.MD_Vent_y_GU12H1Tiemp.KeypadWidth = 300
        Me.MD_Vent_y_GU12H1Tiemp.Location = New System.Drawing.Point(208, 2)
        Me.MD_Vent_y_GU12H1Tiemp.Name = "MD_Vent_y_GU12H1Tiemp"
        Me.MD_Vent_y_GU12H1Tiemp.NumberOfDigits = 5
        Me.MD_Vent_y_GU12H1Tiemp.PLCAddressKeypad = ""
        Me.MD_Vent_y_GU12H1Tiemp.PLCAddressValue = "40394"
        Me.MD_Vent_y_GU12H1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU12H1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_Vent_y_GU12H1Tiemp.TabIndex = 940
        Me.MD_Vent_y_GU12H1Tiemp.Value = 0R
        Me.MD_Vent_y_GU12H1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU12H1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentCasH1Tiemp
        '
        Me.MD_VentCasH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentCasH1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_VentCasH1Tiemp.DecimalPosition = 0
        Me.MD_VentCasH1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentCasH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentCasH1Tiemp.KeypadMaxValue = 0R
        Me.MD_VentCasH1Tiemp.KeypadMinValue = 0R
        Me.MD_VentCasH1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_VentCasH1Tiemp.KeypadText = Nothing
        Me.MD_VentCasH1Tiemp.KeypadWidth = 300
        Me.MD_VentCasH1Tiemp.Location = New System.Drawing.Point(432, 259)
        Me.MD_VentCasH1Tiemp.Name = "MD_VentCasH1Tiemp"
        Me.MD_VentCasH1Tiemp.NumberOfDigits = 5
        Me.MD_VentCasH1Tiemp.PLCAddressKeypad = ""
        Me.MD_VentCasH1Tiemp.PLCAddressValue = "40390"
        Me.MD_VentCasH1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentCasH1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentCasH1Tiemp.TabIndex = 1147
        Me.MD_VentCasH1Tiemp.Value = 0R
        Me.MD_VentCasH1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentCasH1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexTiemposH3
        '
        Me.TexTiemposH3.AutoSize = True
        Me.TexTiemposH3.BackColor = System.Drawing.Color.DimGray
        Me.TexTiemposH3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTiemposH3.ForeColor = System.Drawing.Color.White
        Me.TexTiemposH3.Location = New System.Drawing.Point(595, 86)
        Me.TexTiemposH3.Name = "TexTiemposH3"
        Me.TexTiemposH3.Size = New System.Drawing.Size(252, 34)
        Me.TexTiemposH3.TabIndex = 1136
        Me.TexTiemposH3.Text = "Tiempos Horno 3"
        '
        'TexVent_y_GU11H1Tiemp
        '
        Me.TexVent_y_GU11H1Tiemp.AutoSize = True
        Me.TexVent_y_GU11H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU11H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU11H1Tiemp.Location = New System.Drawing.Point(227, 455)
        Me.TexVent_y_GU11H1Tiemp.Name = "TexVent_y_GU11H1Tiemp"
        Me.TexVent_y_GU11H1Tiemp.Size = New System.Drawing.Size(187, 19)
        Me.TexVent_y_GU11H1Tiemp.TabIndex = 1141
        Me.TexVent_y_GU11H1Tiemp.Text = "Ventilador Columnar 04"
        '
        'TexVentCasH1Tiemp
        '
        Me.TexVentCasH1Tiemp.AutoSize = True
        Me.TexVentCasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentCasH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentCasH1Tiemp.Location = New System.Drawing.Point(227, 267)
        Me.TexVentCasH1Tiemp.Name = "TexVentCasH1Tiemp"
        Me.TexVentCasH1Tiemp.Size = New System.Drawing.Size(165, 19)
        Me.TexVentCasH1Tiemp.TabIndex = 1139
        Me.TexVentCasH1Tiemp.Text = "Ventilador Cascarilla"
        '
        'Tex1EquiH1Tiemp
        '
        Me.Tex1EquiH1Tiemp.AutoSize = True
        Me.Tex1EquiH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1EquiH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.Tex1EquiH1Tiemp.Location = New System.Drawing.Point(227, 183)
        Me.Tex1EquiH1Tiemp.Name = "Tex1EquiH1Tiemp"
        Me.Tex1EquiH1Tiemp.Size = New System.Drawing.Size(64, 19)
        Me.Tex1EquiH1Tiemp.TabIndex = 1137
        Me.Tex1EquiH1Tiemp.Text = "Equipo"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.Controls.Add(Me.MD_Vent_y_GU12H1Tiemp)
        Me.Panel6.Controls.Add(Me.TexVent_y_GU12H1Tiemp)
        Me.Panel6.Location = New System.Drawing.Point(222, 496)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(284, 36)
        Me.Panel6.TabIndex = 1145
        '
        'TexVent_y_GU12H1Tiemp
        '
        Me.TexVent_y_GU12H1Tiemp.AutoSize = True
        Me.TexVent_y_GU12H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU12H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU12H1Tiemp.Location = New System.Drawing.Point(5, 7)
        Me.TexVent_y_GU12H1Tiemp.Name = "TexVent_y_GU12H1Tiemp"
        Me.TexVent_y_GU12H1Tiemp.Size = New System.Drawing.Size(187, 19)
        Me.TexVent_y_GU12H1Tiemp.TabIndex = 210
        Me.TexVent_y_GU12H1Tiemp.Text = "Ventilador Columnar 05"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.MD_Vent_y_GU10H1Tiemp)
        Me.Panel5.Controls.Add(Me.TexVent_y_GU10H1Tiemp)
        Me.Panel5.Location = New System.Drawing.Point(219, 402)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(288, 37)
        Me.Panel5.TabIndex = 1144
        '
        'MD_Vent_y_GU10H1Tiemp
        '
        Me.MD_Vent_y_GU10H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_Vent_y_GU10H1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_Vent_y_GU10H1Tiemp.DecimalPosition = 0
        Me.MD_Vent_y_GU10H1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_Vent_y_GU10H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_Vent_y_GU10H1Tiemp.KeypadMaxValue = 0R
        Me.MD_Vent_y_GU10H1Tiemp.KeypadMinValue = 0R
        Me.MD_Vent_y_GU10H1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_Vent_y_GU10H1Tiemp.KeypadText = Nothing
        Me.MD_Vent_y_GU10H1Tiemp.KeypadWidth = 300
        Me.MD_Vent_y_GU10H1Tiemp.Location = New System.Drawing.Point(213, 2)
        Me.MD_Vent_y_GU10H1Tiemp.Name = "MD_Vent_y_GU10H1Tiemp"
        Me.MD_Vent_y_GU10H1Tiemp.NumberOfDigits = 5
        Me.MD_Vent_y_GU10H1Tiemp.PLCAddressKeypad = ""
        Me.MD_Vent_y_GU10H1Tiemp.PLCAddressValue = "40392"
        Me.MD_Vent_y_GU10H1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU10H1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_Vent_y_GU10H1Tiemp.TabIndex = 939
        Me.MD_Vent_y_GU10H1Tiemp.Value = 0R
        Me.MD_Vent_y_GU10H1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_Vent_y_GU10H1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexVent_y_GU10H1Tiemp
        '
        Me.TexVent_y_GU10H1Tiemp.AutoSize = True
        Me.TexVent_y_GU10H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU10H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU10H1Tiemp.Location = New System.Drawing.Point(8, 6)
        Me.TexVent_y_GU10H1Tiemp.Name = "TexVent_y_GU10H1Tiemp"
        Me.TexVent_y_GU10H1Tiemp.Size = New System.Drawing.Size(187, 19)
        Me.TexVent_y_GU10H1Tiemp.TabIndex = 208
        Me.TexVent_y_GU10H1Tiemp.Text = "Ventilador Columnar 03"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Controls.Add(Me.MD_VentChiH1Tiemp)
        Me.Panel4.Controls.Add(Me.TexVentChiH1Tiemp)
        Me.Panel4.Location = New System.Drawing.Point(217, 305)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(291, 36)
        Me.Panel4.TabIndex = 1143
        '
        'MD_VentChiH1Tiemp
        '
        Me.MD_VentChiH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentChiH1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_VentChiH1Tiemp.DecimalPosition = 0
        Me.MD_VentChiH1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentChiH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentChiH1Tiemp.KeypadMaxValue = 0R
        Me.MD_VentChiH1Tiemp.KeypadMinValue = 0R
        Me.MD_VentChiH1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_VentChiH1Tiemp.KeypadText = Nothing
        Me.MD_VentChiH1Tiemp.KeypadWidth = 300
        Me.MD_VentChiH1Tiemp.Location = New System.Drawing.Point(213, 2)
        Me.MD_VentChiH1Tiemp.Name = "MD_VentChiH1Tiemp"
        Me.MD_VentChiH1Tiemp.NumberOfDigits = 5
        Me.MD_VentChiH1Tiemp.PLCAddressKeypad = ""
        Me.MD_VentChiH1Tiemp.PLCAddressValue = "40389"
        Me.MD_VentChiH1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentChiH1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentChiH1Tiemp.TabIndex = 937
        Me.MD_VentChiH1Tiemp.Value = 0R
        Me.MD_VentChiH1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentChiH1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexVentChiH1Tiemp
        '
        Me.TexVentChiH1Tiemp.AutoSize = True
        Me.TexVentChiH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentChiH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentChiH1Tiemp.Location = New System.Drawing.Point(10, 9)
        Me.TexVentChiH1Tiemp.Name = "TexVentChiH1Tiemp"
        Me.TexVentChiH1Tiemp.Size = New System.Drawing.Size(167, 19)
        Me.TexVentChiH1Tiemp.TabIndex = 206
        Me.TexVentChiH1Tiemp.Text = "Ventilador Chimenea"
        '
        'TexVentHogH1Tiemp
        '
        Me.TexVentHogH1Tiemp.AutoSize = True
        Me.TexVentHogH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentHogH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentHogH1Tiemp.Location = New System.Drawing.Point(8, 7)
        Me.TexVentHogH1Tiemp.Name = "TexVentHogH1Tiemp"
        Me.TexVentHogH1Tiemp.Size = New System.Drawing.Size(156, 19)
        Me.TexVentHogH1Tiemp.TabIndex = 201
        Me.TexVentHogH1Tiemp.Text = "Ventilador Hoguera"
        '
        'TexVent_y_GU09H1Tiemp
        '
        Me.TexVent_y_GU09H1Tiemp.AutoSize = True
        Me.TexVent_y_GU09H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU09H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU09H1Tiemp.Location = New System.Drawing.Point(227, 361)
        Me.TexVent_y_GU09H1Tiemp.Name = "TexVent_y_GU09H1Tiemp"
        Me.TexVent_y_GU09H1Tiemp.Size = New System.Drawing.Size(187, 19)
        Me.TexVent_y_GU09H1Tiemp.TabIndex = 1140
        Me.TexVent_y_GU09H1Tiemp.Text = "Ventilador Columnar 02"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.MD_VentHogH1Tiemp)
        Me.Panel3.Controls.Add(Me.TexVentHogH1Tiemp)
        Me.Panel3.Location = New System.Drawing.Point(219, 213)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 37)
        Me.Panel3.TabIndex = 1142
        '
        'MD_VentHogH1Tiemp
        '
        Me.MD_VentHogH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentHogH1Tiemp.ComComponent = Me.TiemposH3
        Me.MD_VentHogH1Tiemp.DecimalPosition = 0
        Me.MD_VentHogH1Tiemp.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentHogH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentHogH1Tiemp.KeypadMaxValue = 0R
        Me.MD_VentHogH1Tiemp.KeypadMinValue = 0R
        Me.MD_VentHogH1Tiemp.KeypadScaleFactor = 1.0R
        Me.MD_VentHogH1Tiemp.KeypadText = Nothing
        Me.MD_VentHogH1Tiemp.KeypadWidth = 300
        Me.MD_VentHogH1Tiemp.Location = New System.Drawing.Point(213, 2)
        Me.MD_VentHogH1Tiemp.Name = "MD_VentHogH1Tiemp"
        Me.MD_VentHogH1Tiemp.NumberOfDigits = 5
        Me.MD_VentHogH1Tiemp.PLCAddressKeypad = ""
        Me.MD_VentHogH1Tiemp.PLCAddressValue = "40388"
        Me.MD_VentHogH1Tiemp.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentHogH1Tiemp.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentHogH1Tiemp.TabIndex = 936
        Me.MD_VentHogH1Tiemp.Value = 0R
        Me.MD_VentHogH1Tiemp.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentHogH1Tiemp.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tiempos_Horno_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BP_ResetDatosH1Tiemp)
        Me.Controls.Add(Me.MD_Vent_y_GU11H1Tiemp)
        Me.Controls.Add(Me.MD_Vent_y_GU09H1Tiemp)
        Me.Controls.Add(Me.BCF_MenúP_TiemposH1)
        Me.Controls.Add(Me.Tex1HorasH1Tiemp)
        Me.Controls.Add(Me.MD_VentCasH1Tiemp)
        Me.Controls.Add(Me.TexTiemposH3)
        Me.Controls.Add(Me.TexVent_y_GU11H1Tiemp)
        Me.Controls.Add(Me.TexVentCasH1Tiemp)
        Me.Controls.Add(Me.Tex1EquiH1Tiemp)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TexVent_y_GU09H1Tiemp)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Tiempos_Horno_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TiemposH3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BP_ResetDatosH1Tiemp As AdvancedHMIControls.BasicButton
    Friend WithEvents TiemposH3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents MD_Vent_y_GU11H1Tiemp As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_Vent_y_GU09H1Tiemp As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_MenúP_TiemposH1 As FormChangeButton
    Friend WithEvents Tex1HorasH1Tiemp As Label
    Friend WithEvents MD_Vent_y_GU12H1Tiemp As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentCasH1Tiemp As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexTiemposH3 As Label
    Friend WithEvents TexVent_y_GU11H1Tiemp As Label
    Friend WithEvents TexVentCasH1Tiemp As Label
    Friend WithEvents Tex1EquiH1Tiemp As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TexVent_y_GU12H1Tiemp As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents MD_Vent_y_GU10H1Tiemp As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexVent_y_GU10H1Tiemp As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MD_VentChiH1Tiemp As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexVentChiH1Tiemp As Label
    Friend WithEvents TexVentHogH1Tiemp As Label
    Friend WithEvents TexVent_y_GU09H1Tiemp As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MD_VentHogH1Tiemp As AdvancedHMIControls.DigitalPanelMeter
End Class
