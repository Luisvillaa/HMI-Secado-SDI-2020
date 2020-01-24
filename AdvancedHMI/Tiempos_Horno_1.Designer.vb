<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiempos_Horno_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiempos_Horno_1))
        Me.ValorVent_y_GU16H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.TiemposHorno1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ValorAlimCasH1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.TexVent_y_GU16H1Tiemp = New System.Windows.Forms.Label()
        Me.ValorVent_y_GU14H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU15H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU12H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU13H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU10H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU11H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVentChiH1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU09H1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.TexVent_y_GU14H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU12H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU10H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVentChiH1Tiemp = New System.Windows.Forms.Label()
        Me.ValorVentHogH1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVentCasH1Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.TexVentHogH1Tiemp = New System.Windows.Forms.Label()
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_ResetDatosH1Tiemp = New AdvancedHMIControls.BasicButton()
        Me.BCF_MenúP_TiemposH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.TexAlimCasH1Tiemp = New System.Windows.Forms.Label()
        Me.Tex1HorasH1Tiemp = New System.Windows.Forms.Label()
        Me.TexTiemposH1 = New System.Windows.Forms.Label()
        Me.Tex2HorasH1Tiemp = New System.Windows.Forms.Label()
        Me.Tex2EquiH1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU11H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU09H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVentCasH1Tiemp = New System.Windows.Forms.Label()
        Me.Tex1EquiH1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU13H1Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU15H1Tiemp = New System.Windows.Forms.Label()
        CType(Me.TiemposHorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValorVent_y_GU16H1Tiemp
        '
        Me.ValorVent_y_GU16H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU16H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU16H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU16H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU16H1Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU16H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU16H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU16H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU16H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU16H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU16H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU16H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU16H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU16H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU16H1Tiemp.Location = New System.Drawing.Point(864, 265)
        Me.ValorVent_y_GU16H1Tiemp.Name = "ValorVent_y_GU16H1Tiemp"
        Me.ValorVent_y_GU16H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU16H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU16H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU16H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU16H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU16H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU16H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU16H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU16H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU16H1Tiemp.TabIndex = 1158
        Me.ValorVent_y_GU16H1Tiemp.Value = 0R
        '
        'TiemposHorno1
        '
        Me.TiemposHorno1.CIPConnectionSize = 508
        Me.TiemposHorno1.DisableMultiServiceRequest = False
        Me.TiemposHorno1.DisableSubscriptions = False
        Me.TiemposHorno1.IniFileName = ""
        Me.TiemposHorno1.IniFileSection = Nothing
        Me.TiemposHorno1.IPAddress = "10.1.108.20"
        Me.TiemposHorno1.PollRateOverride = 500
        Me.TiemposHorno1.Port = 44818
        Me.TiemposHorno1.ProcessorSlot = 0
        Me.TiemposHorno1.RoutePath = Nothing
        Me.TiemposHorno1.Timeout = 4000
        '
        'ValorAlimCasH1Tiemp
        '
        Me.ValorAlimCasH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorAlimCasH1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorAlimCasH1Tiemp.DecimalPosition = 0
        Me.ValorAlimCasH1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorAlimCasH1Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorAlimCasH1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorAlimCasH1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorAlimCasH1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorAlimCasH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorAlimCasH1Tiemp.KeypadMaxValue = 0R
        Me.ValorAlimCasH1Tiemp.KeypadMinValue = 0R
        Me.ValorAlimCasH1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorAlimCasH1Tiemp.KeypadText = Nothing
        Me.ValorAlimCasH1Tiemp.KeypadWidth = 300
        Me.ValorAlimCasH1Tiemp.Location = New System.Drawing.Point(860, 311)
        Me.ValorAlimCasH1Tiemp.Name = "ValorAlimCasH1Tiemp"
        Me.ValorAlimCasH1Tiemp.NumberOfDigits = 5
        Me.ValorAlimCasH1Tiemp.PLCAddressKeypad = ""
        Me.ValorAlimCasH1Tiemp.PLCAddressText = ""
        Me.ValorAlimCasH1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorAlimCasH1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorAlimCasH1Tiemp.PLCAddressVisible = ""
        Me.ValorAlimCasH1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorAlimCasH1Tiemp.ShowOffSegments = True
        Me.ValorAlimCasH1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorAlimCasH1Tiemp.TabIndex = 1159
        Me.ValorAlimCasH1Tiemp.Value = 0R
        '
        'TexVent_y_GU16H1Tiemp
        '
        Me.TexVent_y_GU16H1Tiemp.AutoSize = True
        Me.TexVent_y_GU16H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU16H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU16H1Tiemp.Location = New System.Drawing.Point(667, 267)
        Me.TexVent_y_GU16H1Tiemp.Name = "TexVent_y_GU16H1Tiemp"
        Me.TexVent_y_GU16H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU16H1Tiemp.TabIndex = 1133
        Me.TexVent_y_GU16H1Tiemp.Text = "Ventilador Guardiola 16"
        '
        'ValorVent_y_GU14H1Tiemp
        '
        Me.ValorVent_y_GU14H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU14H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU14H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU14H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU14H1Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU14H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU14H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU14H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU14H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU14H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU14H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU14H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU14H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU14H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU14H1Tiemp.Location = New System.Drawing.Point(423, 593)
        Me.ValorVent_y_GU14H1Tiemp.Name = "ValorVent_y_GU14H1Tiemp"
        Me.ValorVent_y_GU14H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU14H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU14H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU14H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU14H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU14H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU14H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU14H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU14H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU14H1Tiemp.TabIndex = 1156
        Me.ValorVent_y_GU14H1Tiemp.Value = 0R
        '
        'ValorVent_y_GU15H1Tiemp
        '
        Me.ValorVent_y_GU15H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU15H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU15H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU15H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU15H1Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU15H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU15H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU15H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU15H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU15H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU15H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU15H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU15H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU15H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU15H1Tiemp.Location = New System.Drawing.Point(864, 219)
        Me.ValorVent_y_GU15H1Tiemp.Name = "ValorVent_y_GU15H1Tiemp"
        Me.ValorVent_y_GU15H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU15H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU15H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU15H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU15H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU15H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU15H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU15H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU15H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU15H1Tiemp.TabIndex = 1157
        Me.ValorVent_y_GU15H1Tiemp.Value = 0R
        '
        'ValorVent_y_GU12H1Tiemp
        '
        Me.ValorVent_y_GU12H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU12H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU12H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU12H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU12H1Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU12H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU12H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU12H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU12H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU12H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU12H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU12H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU12H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU12H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU12H1Tiemp.Location = New System.Drawing.Point(423, 499)
        Me.ValorVent_y_GU12H1Tiemp.Name = "ValorVent_y_GU12H1Tiemp"
        Me.ValorVent_y_GU12H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU12H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU12H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU12H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU12H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU12H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU12H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU12H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU12H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU12H1Tiemp.TabIndex = 1154
        Me.ValorVent_y_GU12H1Tiemp.Value = 0R
        '
        'ValorVent_y_GU13H1Tiemp
        '
        Me.ValorVent_y_GU13H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU13H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU13H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU13H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU13H1Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU13H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU13H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU13H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU13H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU13H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU13H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU13H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU13H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU13H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU13H1Tiemp.Location = New System.Drawing.Point(423, 546)
        Me.ValorVent_y_GU13H1Tiemp.Name = "ValorVent_y_GU13H1Tiemp"
        Me.ValorVent_y_GU13H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU13H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU13H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU13H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU13H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU13H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU13H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU13H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU13H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU13H1Tiemp.TabIndex = 1155
        Me.ValorVent_y_GU13H1Tiemp.Value = 0R
        '
        'ValorVent_y_GU10H1Tiemp
        '
        Me.ValorVent_y_GU10H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU10H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU10H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU10H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU10H1Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU10H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU10H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU10H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU10H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU10H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU10H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU10H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU10H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU10H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU10H1Tiemp.Location = New System.Drawing.Point(423, 405)
        Me.ValorVent_y_GU10H1Tiemp.Name = "ValorVent_y_GU10H1Tiemp"
        Me.ValorVent_y_GU10H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU10H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU10H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU10H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU10H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU10H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU10H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU10H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU10H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU10H1Tiemp.TabIndex = 1152
        Me.ValorVent_y_GU10H1Tiemp.Value = 0R
        '
        'ValorVent_y_GU11H1Tiemp
        '
        Me.ValorVent_y_GU11H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU11H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU11H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU11H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU11H1Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU11H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU11H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU11H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU11H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU11H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU11H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU11H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU11H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU11H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU11H1Tiemp.Location = New System.Drawing.Point(423, 452)
        Me.ValorVent_y_GU11H1Tiemp.Name = "ValorVent_y_GU11H1Tiemp"
        Me.ValorVent_y_GU11H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU11H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU11H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU11H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU11H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU11H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU11H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU11H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU11H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU11H1Tiemp.TabIndex = 1153
        Me.ValorVent_y_GU11H1Tiemp.Value = 0R
        '
        'ValorVentChiH1Tiemp
        '
        Me.ValorVentChiH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVentChiH1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVentChiH1Tiemp.DecimalPosition = 0
        Me.ValorVentChiH1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVentChiH1Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVentChiH1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVentChiH1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVentChiH1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVentChiH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVentChiH1Tiemp.KeypadMaxValue = 0R
        Me.ValorVentChiH1Tiemp.KeypadMinValue = 0R
        Me.ValorVentChiH1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVentChiH1Tiemp.KeypadText = Nothing
        Me.ValorVentChiH1Tiemp.KeypadWidth = 300
        Me.ValorVentChiH1Tiemp.Location = New System.Drawing.Point(423, 311)
        Me.ValorVentChiH1Tiemp.Name = "ValorVentChiH1Tiemp"
        Me.ValorVentChiH1Tiemp.NumberOfDigits = 5
        Me.ValorVentChiH1Tiemp.PLCAddressKeypad = ""
        Me.ValorVentChiH1Tiemp.PLCAddressText = ""
        Me.ValorVentChiH1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVentChiH1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVentChiH1Tiemp.PLCAddressVisible = ""
        Me.ValorVentChiH1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVentChiH1Tiemp.ShowOffSegments = True
        Me.ValorVentChiH1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVentChiH1Tiemp.TabIndex = 1150
        Me.ValorVentChiH1Tiemp.Value = 0R
        '
        'ValorVent_y_GU09H1Tiemp
        '
        Me.ValorVent_y_GU09H1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU09H1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVent_y_GU09H1Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU09H1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU09H1Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU09H1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU09H1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU09H1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU09H1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU09H1Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU09H1Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU09H1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU09H1Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU09H1Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU09H1Tiemp.Location = New System.Drawing.Point(423, 358)
        Me.ValorVent_y_GU09H1Tiemp.Name = "ValorVent_y_GU09H1Tiemp"
        Me.ValorVent_y_GU09H1Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU09H1Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU09H1Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU09H1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU09H1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU09H1Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU09H1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU09H1Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU09H1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU09H1Tiemp.TabIndex = 1151
        Me.ValorVent_y_GU09H1Tiemp.Value = 0R
        '
        'TexVent_y_GU14H1Tiemp
        '
        Me.TexVent_y_GU14H1Tiemp.AutoSize = True
        Me.TexVent_y_GU14H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU14H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU14H1Tiemp.Location = New System.Drawing.Point(227, 595)
        Me.TexVent_y_GU14H1Tiemp.Name = "TexVent_y_GU14H1Tiemp"
        Me.TexVent_y_GU14H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU14H1Tiemp.TabIndex = 1132
        Me.TexVent_y_GU14H1Tiemp.Text = "Ventilador Guardiola 14"
        '
        'TexVent_y_GU12H1Tiemp
        '
        Me.TexVent_y_GU12H1Tiemp.AutoSize = True
        Me.TexVent_y_GU12H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU12H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU12H1Tiemp.Location = New System.Drawing.Point(227, 501)
        Me.TexVent_y_GU12H1Tiemp.Name = "TexVent_y_GU12H1Tiemp"
        Me.TexVent_y_GU12H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU12H1Tiemp.TabIndex = 1131
        Me.TexVent_y_GU12H1Tiemp.Text = "Ventilador Guardiola 12"
        '
        'TexVent_y_GU10H1Tiemp
        '
        Me.TexVent_y_GU10H1Tiemp.AutoSize = True
        Me.TexVent_y_GU10H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU10H1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU10H1Tiemp.Location = New System.Drawing.Point(227, 407)
        Me.TexVent_y_GU10H1Tiemp.Name = "TexVent_y_GU10H1Tiemp"
        Me.TexVent_y_GU10H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU10H1Tiemp.TabIndex = 1130
        Me.TexVent_y_GU10H1Tiemp.Text = "Ventilador Guardiola 10"
        '
        'TexVentChiH1Tiemp
        '
        Me.TexVentChiH1Tiemp.AutoSize = True
        Me.TexVentChiH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentChiH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentChiH1Tiemp.Location = New System.Drawing.Point(227, 313)
        Me.TexVentChiH1Tiemp.Name = "TexVentChiH1Tiemp"
        Me.TexVentChiH1Tiemp.Size = New System.Drawing.Size(167, 19)
        Me.TexVentChiH1Tiemp.TabIndex = 1129
        Me.TexVentChiH1Tiemp.Text = "Ventilador Chimenea"
        '
        'ValorVentHogH1Tiemp
        '
        Me.ValorVentHogH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVentHogH1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVentHogH1Tiemp.DecimalPosition = 0
        Me.ValorVentHogH1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVentHogH1Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVentHogH1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVentHogH1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVentHogH1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVentHogH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVentHogH1Tiemp.KeypadMaxValue = 0R
        Me.ValorVentHogH1Tiemp.KeypadMinValue = 0R
        Me.ValorVentHogH1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVentHogH1Tiemp.KeypadText = Nothing
        Me.ValorVentHogH1Tiemp.KeypadWidth = 300
        Me.ValorVentHogH1Tiemp.Location = New System.Drawing.Point(423, 219)
        Me.ValorVentHogH1Tiemp.Name = "ValorVentHogH1Tiemp"
        Me.ValorVentHogH1Tiemp.NumberOfDigits = 5
        Me.ValorVentHogH1Tiemp.PLCAddressKeypad = ""
        Me.ValorVentHogH1Tiemp.PLCAddressText = ""
        Me.ValorVentHogH1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVentHogH1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVentHogH1Tiemp.PLCAddressVisible = ""
        Me.ValorVentHogH1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVentHogH1Tiemp.ShowOffSegments = True
        Me.ValorVentHogH1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVentHogH1Tiemp.TabIndex = 1148
        Me.ValorVentHogH1Tiemp.Value = 0R
        '
        'ValorVentCasH1Tiemp
        '
        Me.ValorVentCasH1Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVentCasH1Tiemp.ComComponent = Me.TiemposHorno1
        Me.ValorVentCasH1Tiemp.DecimalPosition = 0
        Me.ValorVentCasH1Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVentCasH1Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVentCasH1Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVentCasH1Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVentCasH1Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVentCasH1Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVentCasH1Tiemp.KeypadMaxValue = 0R
        Me.ValorVentCasH1Tiemp.KeypadMinValue = 0R
        Me.ValorVentCasH1Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVentCasH1Tiemp.KeypadText = Nothing
        Me.ValorVentCasH1Tiemp.KeypadWidth = 300
        Me.ValorVentCasH1Tiemp.Location = New System.Drawing.Point(423, 265)
        Me.ValorVentCasH1Tiemp.Name = "ValorVentCasH1Tiemp"
        Me.ValorVentCasH1Tiemp.NumberOfDigits = 5
        Me.ValorVentCasH1Tiemp.PLCAddressKeypad = ""
        Me.ValorVentCasH1Tiemp.PLCAddressText = ""
        Me.ValorVentCasH1Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVentCasH1Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVentCasH1Tiemp.PLCAddressVisible = ""
        Me.ValorVentCasH1Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVentCasH1Tiemp.ShowOffSegments = True
        Me.ValorVentCasH1Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVentCasH1Tiemp.TabIndex = 1149
        Me.ValorVentCasH1Tiemp.Value = 0R
        '
        'TexVentHogH1Tiemp
        '
        Me.TexVentHogH1Tiemp.AutoSize = True
        Me.TexVentHogH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentHogH1Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentHogH1Tiemp.Location = New System.Drawing.Point(227, 221)
        Me.TexVentHogH1Tiemp.Name = "TexVentHogH1Tiemp"
        Me.TexVentHogH1Tiemp.Size = New System.Drawing.Size(156, 19)
        Me.TexVentHogH1Tiemp.TabIndex = 1128
        Me.TexVentHogH1Tiemp.Text = "Ventilador Hoguera"
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = Nothing
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(981, 632)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1147
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BP_ResetDatosH1Tiemp
        '
        Me.BP_ResetDatosH1Tiemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ResetDatosH1Tiemp.ComComponent = Me.TiemposHorno1
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
        Me.BP_ResetDatosH1Tiemp.PLCAddressClick = "RESET_TIEMPOS_M"
        Me.BP_ResetDatosH1Tiemp.SelectTextAlternate = False
        Me.BP_ResetDatosH1Tiemp.Size = New System.Drawing.Size(143, 55)
        Me.BP_ResetDatosH1Tiemp.TabIndex = 1146
        Me.BP_ResetDatosH1Tiemp.Text = "Reset Valores"
        Me.BP_ResetDatosH1Tiemp.TextAlternate = Nothing
        Me.BP_ResetDatosH1Tiemp.UseVisualStyleBackColor = False
        Me.BP_ResetDatosH1Tiemp.ValueToWrite = 0
        '
        'BCF_MenúP_TiemposH1
        '
        Me.BCF_MenúP_TiemposH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_TiemposH1.ComComponent = Nothing
        Me.BCF_MenúP_TiemposH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_TiemposH1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_TiemposH1.FormToOpen = Nothing
        Me.BCF_MenúP_TiemposH1.KeypadWidth = 300
        Me.BCF_MenúP_TiemposH1.Location = New System.Drawing.Point(217, 66)
        Me.BCF_MenúP_TiemposH1.Name = "BCF_MenúP_TiemposH1"
        Me.BCF_MenúP_TiemposH1.Passcode = Nothing
        Me.BCF_MenúP_TiemposH1.PasswordChar = False
        Me.BCF_MenúP_TiemposH1.PLCAddressVisible = ""
        Me.BCF_MenúP_TiemposH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_TiemposH1.TabIndex = 1145
        Me.BCF_MenúP_TiemposH1.Text = "Menú Principal"
        Me.BCF_MenúP_TiemposH1.UseVisualStyleBackColor = False
        '
        'TexAlimCasH1Tiemp
        '
        Me.TexAlimCasH1Tiemp.AutoSize = True
        Me.TexAlimCasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexAlimCasH1Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexAlimCasH1Tiemp.Location = New System.Drawing.Point(667, 313)
        Me.TexAlimCasH1Tiemp.Name = "TexAlimCasH1Tiemp"
        Me.TexAlimCasH1Tiemp.Size = New System.Drawing.Size(180, 19)
        Me.TexAlimCasH1Tiemp.TabIndex = 1142
        Me.TexAlimCasH1Tiemp.Text = "Alimentador Cascarilla"
        '
        'Tex1HorasH1Tiemp
        '
        Me.Tex1HorasH1Tiemp.AutoSize = True
        Me.Tex1HorasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1HorasH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1HorasH1Tiemp.Location = New System.Drawing.Point(405, 183)
        Me.Tex1HorasH1Tiemp.Name = "Tex1HorasH1Tiemp"
        Me.Tex1HorasH1Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex1HorasH1Tiemp.TabIndex = 1136
        Me.Tex1HorasH1Tiemp.Text = "Horas de Trabajo"
        Me.Tex1HorasH1Tiemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexTiemposH1
        '
        Me.TexTiemposH1.AutoSize = True
        Me.TexTiemposH1.BackColor = System.Drawing.Color.DimGray
        Me.TexTiemposH1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTiemposH1.ForeColor = System.Drawing.Color.White
        Me.TexTiemposH1.Location = New System.Drawing.Point(595, 86)
        Me.TexTiemposH1.Name = "TexTiemposH1"
        Me.TexTiemposH1.Size = New System.Drawing.Size(252, 34)
        Me.TexTiemposH1.TabIndex = 1134
        Me.TexTiemposH1.Text = "Tiempos Horno 1"
        '
        'Tex2HorasH1Tiemp
        '
        Me.Tex2HorasH1Tiemp.AutoSize = True
        Me.Tex2HorasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2HorasH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2HorasH1Tiemp.Location = New System.Drawing.Point(844, 183)
        Me.Tex2HorasH1Tiemp.Name = "Tex2HorasH1Tiemp"
        Me.Tex2HorasH1Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex2HorasH1Tiemp.TabIndex = 1141
        Me.Tex2HorasH1Tiemp.Text = "Horas de Trabajo"
        Me.Tex2HorasH1Tiemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex2EquiH1Tiemp
        '
        Me.Tex2EquiH1Tiemp.AutoSize = True
        Me.Tex2EquiH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2EquiH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2EquiH1Tiemp.Location = New System.Drawing.Point(668, 183)
        Me.Tex2EquiH1Tiemp.Name = "Tex2EquiH1Tiemp"
        Me.Tex2EquiH1Tiemp.Size = New System.Drawing.Size(64, 19)
        Me.Tex2EquiH1Tiemp.TabIndex = 1140
        Me.Tex2EquiH1Tiemp.Text = "Equipo"
        '
        'TexVent_y_GU11H1Tiemp
        '
        Me.TexVent_y_GU11H1Tiemp.AutoSize = True
        Me.TexVent_y_GU11H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU11H1Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU11H1Tiemp.Location = New System.Drawing.Point(227, 454)
        Me.TexVent_y_GU11H1Tiemp.Name = "TexVent_y_GU11H1Tiemp"
        Me.TexVent_y_GU11H1Tiemp.Size = New System.Drawing.Size(185, 19)
        Me.TexVent_y_GU11H1Tiemp.TabIndex = 1139
        Me.TexVent_y_GU11H1Tiemp.Text = "Ventilador Guardiola 11"
        '
        'TexVent_y_GU09H1Tiemp
        '
        Me.TexVent_y_GU09H1Tiemp.AutoSize = True
        Me.TexVent_y_GU09H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU09H1Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU09H1Tiemp.Location = New System.Drawing.Point(227, 360)
        Me.TexVent_y_GU09H1Tiemp.Name = "TexVent_y_GU09H1Tiemp"
        Me.TexVent_y_GU09H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU09H1Tiemp.TabIndex = 1138
        Me.TexVent_y_GU09H1Tiemp.Text = "Ventilador Guardiola 09"
        '
        'TexVentCasH1Tiemp
        '
        Me.TexVentCasH1Tiemp.AutoSize = True
        Me.TexVentCasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentCasH1Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVentCasH1Tiemp.Location = New System.Drawing.Point(227, 267)
        Me.TexVentCasH1Tiemp.Name = "TexVentCasH1Tiemp"
        Me.TexVentCasH1Tiemp.Size = New System.Drawing.Size(165, 19)
        Me.TexVentCasH1Tiemp.TabIndex = 1137
        Me.TexVentCasH1Tiemp.Text = "Ventilador Cascarilla"
        '
        'Tex1EquiH1Tiemp
        '
        Me.Tex1EquiH1Tiemp.AutoSize = True
        Me.Tex1EquiH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1EquiH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1EquiH1Tiemp.Location = New System.Drawing.Point(227, 183)
        Me.Tex1EquiH1Tiemp.Name = "Tex1EquiH1Tiemp"
        Me.Tex1EquiH1Tiemp.Size = New System.Drawing.Size(64, 19)
        Me.Tex1EquiH1Tiemp.TabIndex = 1135
        Me.Tex1EquiH1Tiemp.Text = "Equipo"
        '
        'TexVent_y_GU13H1Tiemp
        '
        Me.TexVent_y_GU13H1Tiemp.AutoSize = True
        Me.TexVent_y_GU13H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU13H1Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU13H1Tiemp.Location = New System.Drawing.Point(227, 548)
        Me.TexVent_y_GU13H1Tiemp.Name = "TexVent_y_GU13H1Tiemp"
        Me.TexVent_y_GU13H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU13H1Tiemp.TabIndex = 1144
        Me.TexVent_y_GU13H1Tiemp.Text = "Ventilador Guardiola 13"
        '
        'TexVent_y_GU15H1Tiemp
        '
        Me.TexVent_y_GU15H1Tiemp.AutoSize = True
        Me.TexVent_y_GU15H1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU15H1Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU15H1Tiemp.Location = New System.Drawing.Point(668, 221)
        Me.TexVent_y_GU15H1Tiemp.Name = "TexVent_y_GU15H1Tiemp"
        Me.TexVent_y_GU15H1Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU15H1Tiemp.TabIndex = 1143
        Me.TexVent_y_GU15H1Tiemp.Text = "Ventilador Guardiola 15"
        '
        'Tiempos_Horno_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.ValorVent_y_GU16H1Tiemp)
        Me.Controls.Add(Me.ValorAlimCasH1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU16H1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU14H1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU15H1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU12H1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU13H1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU10H1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU11H1Tiemp)
        Me.Controls.Add(Me.ValorVentChiH1Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU09H1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU14H1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU12H1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU10H1Tiemp)
        Me.Controls.Add(Me.TexVentChiH1Tiemp)
        Me.Controls.Add(Me.ValorVentHogH1Tiemp)
        Me.Controls.Add(Me.ValorVentCasH1Tiemp)
        Me.Controls.Add(Me.TexVentHogH1Tiemp)
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BP_ResetDatosH1Tiemp)
        Me.Controls.Add(Me.BCF_MenúP_TiemposH1)
        Me.Controls.Add(Me.TexAlimCasH1Tiemp)
        Me.Controls.Add(Me.Tex1HorasH1Tiemp)
        Me.Controls.Add(Me.TexTiemposH1)
        Me.Controls.Add(Me.Tex2HorasH1Tiemp)
        Me.Controls.Add(Me.Tex2EquiH1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU11H1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU09H1Tiemp)
        Me.Controls.Add(Me.TexVentCasH1Tiemp)
        Me.Controls.Add(Me.Tex1EquiH1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU13H1Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU15H1Tiemp)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Tiempos_Horno_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TiemposHorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ValorVent_y_GU16H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TiemposHorno1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ValorAlimCasH1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexVent_y_GU16H1Tiemp As Label
    Friend WithEvents ValorVent_y_GU14H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU15H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU12H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU13H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU10H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU11H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVentChiH1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU09H1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexVent_y_GU14H1Tiemp As Label
    Friend WithEvents TexVent_y_GU12H1Tiemp As Label
    Friend WithEvents TexVent_y_GU10H1Tiemp As Label
    Friend WithEvents TexVentChiH1Tiemp As Label
    Friend WithEvents ValorVentHogH1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVentCasH1Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexVentHogH1Tiemp As Label
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BP_ResetDatosH1Tiemp As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_MenúP_TiemposH1 As FormChangeButton
    Friend WithEvents TexAlimCasH1Tiemp As Label
    Friend WithEvents Tex1HorasH1Tiemp As Label
    Friend WithEvents TexTiemposH1 As Label
    Friend WithEvents Tex2HorasH1Tiemp As Label
    Friend WithEvents Tex2EquiH1Tiemp As Label
    Friend WithEvents TexVent_y_GU11H1Tiemp As Label
    Friend WithEvents TexVent_y_GU09H1Tiemp As Label
    Friend WithEvents TexVentCasH1Tiemp As Label
    Friend WithEvents Tex1EquiH1Tiemp As Label
    Friend WithEvents TexVent_y_GU13H1Tiemp As Label
    Friend WithEvents TexVent_y_GU15H1Tiemp As Label
End Class
