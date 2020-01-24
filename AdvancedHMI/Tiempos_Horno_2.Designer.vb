<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiempos_Horno_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiempos_Horno_2))
        Me.ValorVent_y_GU08H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.TiemposHorno2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ValorAlimCasH2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU06H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU07H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU04H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU05H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU02H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU03H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVentChiH2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVent_y_GU01H2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVentHogH2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.ValorVentCasH2Tiemp = New AdvancedHMIControls.SevenSegment2()
        Me.TexVent_y_GU08H2Tiemp = New System.Windows.Forms.Label()
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.TexVentChiH2Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU02H2Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU04H2Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU06H2Tiemp = New System.Windows.Forms.Label()
        Me.TexVentHogH2Tiemp = New System.Windows.Forms.Label()
        Me.BP_ResetDatosH1Tiemp = New AdvancedHMIControls.BasicButton()
        Me.BCF_MenúP_TiemposH2 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.TexVent_y_GU05H2Tiemp = New System.Windows.Forms.Label()
        Me.Tex2HorasH2Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU07H2Tiemp = New System.Windows.Forms.Label()
        Me.TexAlimCasH2Tiemp = New System.Windows.Forms.Label()
        Me.Tex1HorasH2Tiemp = New System.Windows.Forms.Label()
        Me.TexTiemposH2 = New System.Windows.Forms.Label()
        Me.Tex2EquiH2Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU01H2Tiemp = New System.Windows.Forms.Label()
        Me.TexVentCasH2Tiemp = New System.Windows.Forms.Label()
        Me.TexVent_y_GU03H2Tiemp = New System.Windows.Forms.Label()
        Me.Tex1EquiH2Tiemp = New System.Windows.Forms.Label()
        CType(Me.TiemposHorno2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValorVent_y_GU08H2Tiemp
        '
        Me.ValorVent_y_GU08H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU08H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU08H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU08H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU08H2Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU08H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU08H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU08H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU08H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU08H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU08H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU08H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU08H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU08H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU08H2Tiemp.Location = New System.Drawing.Point(868, 265)
        Me.ValorVent_y_GU08H2Tiemp.Name = "ValorVent_y_GU08H2Tiemp"
        Me.ValorVent_y_GU08H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU08H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU08H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU08H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU08H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU08H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU08H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU08H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU08H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU08H2Tiemp.TabIndex = 1202
        Me.ValorVent_y_GU08H2Tiemp.Value = 0R
        '
        'TiemposHorno2
        '
        Me.TiemposHorno2.CIPConnectionSize = 508
        Me.TiemposHorno2.DisableMultiServiceRequest = False
        Me.TiemposHorno2.DisableSubscriptions = False
        Me.TiemposHorno2.IniFileName = ""
        Me.TiemposHorno2.IniFileSection = Nothing
        Me.TiemposHorno2.IPAddress = "10.1.108.18"
        Me.TiemposHorno2.PollRateOverride = 500
        Me.TiemposHorno2.Port = 44818
        Me.TiemposHorno2.ProcessorSlot = 0
        Me.TiemposHorno2.RoutePath = Nothing
        Me.TiemposHorno2.Timeout = 4000
        '
        'ValorAlimCasH2Tiemp
        '
        Me.ValorAlimCasH2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorAlimCasH2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorAlimCasH2Tiemp.DecimalPosition = 0
        Me.ValorAlimCasH2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorAlimCasH2Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorAlimCasH2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorAlimCasH2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorAlimCasH2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorAlimCasH2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorAlimCasH2Tiemp.KeypadMaxValue = 0R
        Me.ValorAlimCasH2Tiemp.KeypadMinValue = 0R
        Me.ValorAlimCasH2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorAlimCasH2Tiemp.KeypadText = Nothing
        Me.ValorAlimCasH2Tiemp.KeypadWidth = 300
        Me.ValorAlimCasH2Tiemp.Location = New System.Drawing.Point(864, 312)
        Me.ValorAlimCasH2Tiemp.Name = "ValorAlimCasH2Tiemp"
        Me.ValorAlimCasH2Tiemp.NumberOfDigits = 5
        Me.ValorAlimCasH2Tiemp.PLCAddressKeypad = ""
        Me.ValorAlimCasH2Tiemp.PLCAddressText = ""
        Me.ValorAlimCasH2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorAlimCasH2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorAlimCasH2Tiemp.PLCAddressVisible = ""
        Me.ValorAlimCasH2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorAlimCasH2Tiemp.ShowOffSegments = True
        Me.ValorAlimCasH2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorAlimCasH2Tiemp.TabIndex = 1203
        Me.ValorAlimCasH2Tiemp.Value = 0R
        '
        'ValorVent_y_GU06H2Tiemp
        '
        Me.ValorVent_y_GU06H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU06H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU06H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU06H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU06H2Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU06H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU06H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU06H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU06H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU06H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU06H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU06H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU06H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU06H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU06H2Tiemp.Location = New System.Drawing.Point(427, 596)
        Me.ValorVent_y_GU06H2Tiemp.Name = "ValorVent_y_GU06H2Tiemp"
        Me.ValorVent_y_GU06H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU06H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU06H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU06H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU06H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU06H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU06H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU06H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU06H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU06H2Tiemp.TabIndex = 1200
        Me.ValorVent_y_GU06H2Tiemp.Value = 0R
        '
        'ValorVent_y_GU07H2Tiemp
        '
        Me.ValorVent_y_GU07H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU07H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU07H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU07H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU07H2Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU07H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU07H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU07H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU07H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU07H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU07H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU07H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU07H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU07H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU07H2Tiemp.Location = New System.Drawing.Point(868, 218)
        Me.ValorVent_y_GU07H2Tiemp.Name = "ValorVent_y_GU07H2Tiemp"
        Me.ValorVent_y_GU07H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU07H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU07H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU07H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU07H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU07H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU07H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU07H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU07H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU07H2Tiemp.TabIndex = 1201
        Me.ValorVent_y_GU07H2Tiemp.Value = 0R
        '
        'ValorVent_y_GU04H2Tiemp
        '
        Me.ValorVent_y_GU04H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU04H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU04H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU04H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU04H2Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU04H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU04H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU04H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU04H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU04H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU04H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU04H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU04H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU04H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU04H2Tiemp.Location = New System.Drawing.Point(427, 500)
        Me.ValorVent_y_GU04H2Tiemp.Name = "ValorVent_y_GU04H2Tiemp"
        Me.ValorVent_y_GU04H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU04H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU04H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU04H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU04H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU04H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU04H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU04H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU04H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU04H2Tiemp.TabIndex = 1198
        Me.ValorVent_y_GU04H2Tiemp.Value = 0R
        '
        'ValorVent_y_GU05H2Tiemp
        '
        Me.ValorVent_y_GU05H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU05H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU05H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU05H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU05H2Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU05H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU05H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU05H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU05H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU05H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU05H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU05H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU05H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU05H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU05H2Tiemp.Location = New System.Drawing.Point(427, 548)
        Me.ValorVent_y_GU05H2Tiemp.Name = "ValorVent_y_GU05H2Tiemp"
        Me.ValorVent_y_GU05H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU05H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU05H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU05H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU05H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU05H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU05H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU05H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU05H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU05H2Tiemp.TabIndex = 1199
        Me.ValorVent_y_GU05H2Tiemp.Value = 0R
        '
        'ValorVent_y_GU02H2Tiemp
        '
        Me.ValorVent_y_GU02H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU02H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU02H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU02H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU02H2Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVent_y_GU02H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU02H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU02H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU02H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU02H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU02H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU02H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU02H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU02H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU02H2Tiemp.Location = New System.Drawing.Point(427, 406)
        Me.ValorVent_y_GU02H2Tiemp.Name = "ValorVent_y_GU02H2Tiemp"
        Me.ValorVent_y_GU02H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU02H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU02H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU02H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU02H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU02H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU02H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU02H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU02H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU02H2Tiemp.TabIndex = 1196
        Me.ValorVent_y_GU02H2Tiemp.Value = 0R
        '
        'ValorVent_y_GU03H2Tiemp
        '
        Me.ValorVent_y_GU03H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU03H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU03H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU03H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU03H2Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU03H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU03H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU03H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU03H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU03H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU03H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU03H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU03H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU03H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU03H2Tiemp.Location = New System.Drawing.Point(427, 453)
        Me.ValorVent_y_GU03H2Tiemp.Name = "ValorVent_y_GU03H2Tiemp"
        Me.ValorVent_y_GU03H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU03H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU03H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU03H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU03H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU03H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU03H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU03H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU03H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU03H2Tiemp.TabIndex = 1197
        Me.ValorVent_y_GU03H2Tiemp.Value = 0R
        '
        'ValorVentChiH2Tiemp
        '
        Me.ValorVentChiH2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVentChiH2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVentChiH2Tiemp.DecimalPosition = 0
        Me.ValorVentChiH2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVentChiH2Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVentChiH2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVentChiH2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVentChiH2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVentChiH2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVentChiH2Tiemp.KeypadMaxValue = 0R
        Me.ValorVentChiH2Tiemp.KeypadMinValue = 0R
        Me.ValorVentChiH2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVentChiH2Tiemp.KeypadText = Nothing
        Me.ValorVentChiH2Tiemp.KeypadWidth = 300
        Me.ValorVentChiH2Tiemp.Location = New System.Drawing.Point(427, 312)
        Me.ValorVentChiH2Tiemp.Name = "ValorVentChiH2Tiemp"
        Me.ValorVentChiH2Tiemp.NumberOfDigits = 5
        Me.ValorVentChiH2Tiemp.PLCAddressKeypad = ""
        Me.ValorVentChiH2Tiemp.PLCAddressText = ""
        Me.ValorVentChiH2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVentChiH2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVentChiH2Tiemp.PLCAddressVisible = ""
        Me.ValorVentChiH2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVentChiH2Tiemp.ShowOffSegments = True
        Me.ValorVentChiH2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVentChiH2Tiemp.TabIndex = 1194
        Me.ValorVentChiH2Tiemp.Value = 0R
        '
        'ValorVent_y_GU01H2Tiemp
        '
        Me.ValorVent_y_GU01H2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVent_y_GU01H2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVent_y_GU01H2Tiemp.DecimalPosition = 0
        Me.ValorVent_y_GU01H2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVent_y_GU01H2Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVent_y_GU01H2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVent_y_GU01H2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVent_y_GU01H2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVent_y_GU01H2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVent_y_GU01H2Tiemp.KeypadMaxValue = 0R
        Me.ValorVent_y_GU01H2Tiemp.KeypadMinValue = 0R
        Me.ValorVent_y_GU01H2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVent_y_GU01H2Tiemp.KeypadText = Nothing
        Me.ValorVent_y_GU01H2Tiemp.KeypadWidth = 300
        Me.ValorVent_y_GU01H2Tiemp.Location = New System.Drawing.Point(427, 359)
        Me.ValorVent_y_GU01H2Tiemp.Name = "ValorVent_y_GU01H2Tiemp"
        Me.ValorVent_y_GU01H2Tiemp.NumberOfDigits = 5
        Me.ValorVent_y_GU01H2Tiemp.PLCAddressKeypad = ""
        Me.ValorVent_y_GU01H2Tiemp.PLCAddressText = ""
        Me.ValorVent_y_GU01H2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVent_y_GU01H2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVent_y_GU01H2Tiemp.PLCAddressVisible = ""
        Me.ValorVent_y_GU01H2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVent_y_GU01H2Tiemp.ShowOffSegments = True
        Me.ValorVent_y_GU01H2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVent_y_GU01H2Tiemp.TabIndex = 1195
        Me.ValorVent_y_GU01H2Tiemp.Value = 0R
        '
        'ValorVentHogH2Tiemp
        '
        Me.ValorVentHogH2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVentHogH2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVentHogH2Tiemp.DecimalPosition = 0
        Me.ValorVentHogH2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVentHogH2Tiemp.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorVentHogH2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVentHogH2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVentHogH2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVentHogH2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVentHogH2Tiemp.KeypadMaxValue = 0R
        Me.ValorVentHogH2Tiemp.KeypadMinValue = 0R
        Me.ValorVentHogH2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVentHogH2Tiemp.KeypadText = Nothing
        Me.ValorVentHogH2Tiemp.KeypadWidth = 300
        Me.ValorVentHogH2Tiemp.Location = New System.Drawing.Point(427, 218)
        Me.ValorVentHogH2Tiemp.Name = "ValorVentHogH2Tiemp"
        Me.ValorVentHogH2Tiemp.NumberOfDigits = 5
        Me.ValorVentHogH2Tiemp.PLCAddressKeypad = ""
        Me.ValorVentHogH2Tiemp.PLCAddressText = ""
        Me.ValorVentHogH2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVentHogH2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVentHogH2Tiemp.PLCAddressVisible = ""
        Me.ValorVentHogH2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVentHogH2Tiemp.ShowOffSegments = True
        Me.ValorVentHogH2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVentHogH2Tiemp.TabIndex = 1192
        Me.ValorVentHogH2Tiemp.Value = 0R
        '
        'ValorVentCasH2Tiemp
        '
        Me.ValorVentCasH2Tiemp.BackColor = System.Drawing.Color.Transparent
        Me.ValorVentCasH2Tiemp.ComComponent = Me.TiemposHorno2
        Me.ValorVentCasH2Tiemp.DecimalPosition = 0
        Me.ValorVentCasH2Tiemp.ForecolorHighLimitValue = 999999.0R
        Me.ValorVentCasH2Tiemp.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorVentCasH2Tiemp.ForecolorLowLimitValue = -999999.0R
        Me.ValorVentCasH2Tiemp.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorVentCasH2Tiemp.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorVentCasH2Tiemp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorVentCasH2Tiemp.KeypadMaxValue = 0R
        Me.ValorVentCasH2Tiemp.KeypadMinValue = 0R
        Me.ValorVentCasH2Tiemp.KeypadScaleFactor = 1.0R
        Me.ValorVentCasH2Tiemp.KeypadText = Nothing
        Me.ValorVentCasH2Tiemp.KeypadWidth = 300
        Me.ValorVentCasH2Tiemp.Location = New System.Drawing.Point(427, 265)
        Me.ValorVentCasH2Tiemp.Name = "ValorVentCasH2Tiemp"
        Me.ValorVentCasH2Tiemp.NumberOfDigits = 5
        Me.ValorVentCasH2Tiemp.PLCAddressKeypad = ""
        Me.ValorVentCasH2Tiemp.PLCAddressText = ""
        Me.ValorVentCasH2Tiemp.PLCAddressValue = CType(resources.GetObject("ValorVentCasH2Tiemp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorVentCasH2Tiemp.PLCAddressVisible = ""
        Me.ValorVentCasH2Tiemp.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorVentCasH2Tiemp.ShowOffSegments = True
        Me.ValorVentCasH2Tiemp.Size = New System.Drawing.Size(90, 23)
        Me.ValorVentCasH2Tiemp.TabIndex = 1193
        Me.ValorVentCasH2Tiemp.Value = 0R
        '
        'TexVent_y_GU08H2Tiemp
        '
        Me.TexVent_y_GU08H2Tiemp.AutoSize = True
        Me.TexVent_y_GU08H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU08H2Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU08H2Tiemp.Location = New System.Drawing.Point(668, 267)
        Me.TexVent_y_GU08H2Tiemp.Name = "TexVent_y_GU08H2Tiemp"
        Me.TexVent_y_GU08H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU08H2Tiemp.TabIndex = 1177
        Me.TexVent_y_GU08H2Tiemp.Text = "Ventilador Guardiola 08"
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
        Me.BCF_RegresarH1.TabIndex = 1191
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'TexVentChiH2Tiemp
        '
        Me.TexVentChiH2Tiemp.AutoSize = True
        Me.TexVentChiH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentChiH2Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentChiH2Tiemp.Location = New System.Drawing.Point(227, 314)
        Me.TexVentChiH2Tiemp.Name = "TexVentChiH2Tiemp"
        Me.TexVentChiH2Tiemp.Size = New System.Drawing.Size(167, 19)
        Me.TexVentChiH2Tiemp.TabIndex = 1173
        Me.TexVentChiH2Tiemp.Text = "Ventilador Chimenea"
        '
        'TexVent_y_GU02H2Tiemp
        '
        Me.TexVent_y_GU02H2Tiemp.AutoSize = True
        Me.TexVent_y_GU02H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU02H2Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU02H2Tiemp.Location = New System.Drawing.Point(227, 408)
        Me.TexVent_y_GU02H2Tiemp.Name = "TexVent_y_GU02H2Tiemp"
        Me.TexVent_y_GU02H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU02H2Tiemp.TabIndex = 1174
        Me.TexVent_y_GU02H2Tiemp.Text = "Ventilador Guardiola 02"
        '
        'TexVent_y_GU04H2Tiemp
        '
        Me.TexVent_y_GU04H2Tiemp.AutoSize = True
        Me.TexVent_y_GU04H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU04H2Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU04H2Tiemp.Location = New System.Drawing.Point(227, 502)
        Me.TexVent_y_GU04H2Tiemp.Name = "TexVent_y_GU04H2Tiemp"
        Me.TexVent_y_GU04H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU04H2Tiemp.TabIndex = 1175
        Me.TexVent_y_GU04H2Tiemp.Text = "Ventilador Guardiola 04"
        '
        'TexVent_y_GU06H2Tiemp
        '
        Me.TexVent_y_GU06H2Tiemp.AutoSize = True
        Me.TexVent_y_GU06H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU06H2Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVent_y_GU06H2Tiemp.Location = New System.Drawing.Point(227, 598)
        Me.TexVent_y_GU06H2Tiemp.Name = "TexVent_y_GU06H2Tiemp"
        Me.TexVent_y_GU06H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU06H2Tiemp.TabIndex = 1176
        Me.TexVent_y_GU06H2Tiemp.Text = "Ventilador Guardiola 06"
        '
        'TexVentHogH2Tiemp
        '
        Me.TexVentHogH2Tiemp.AutoSize = True
        Me.TexVentHogH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentHogH2Tiemp.ForeColor = System.Drawing.Color.White
        Me.TexVentHogH2Tiemp.Location = New System.Drawing.Point(227, 220)
        Me.TexVentHogH2Tiemp.Name = "TexVentHogH2Tiemp"
        Me.TexVentHogH2Tiemp.Size = New System.Drawing.Size(156, 19)
        Me.TexVentHogH2Tiemp.TabIndex = 1172
        Me.TexVentHogH2Tiemp.Text = "Ventilador Hoguera"
        '
        'BP_ResetDatosH1Tiemp
        '
        Me.BP_ResetDatosH1Tiemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ResetDatosH1Tiemp.ComComponent = Me.TiemposHorno2
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
        Me.BP_ResetDatosH1Tiemp.TabIndex = 1190
        Me.BP_ResetDatosH1Tiemp.Text = "Reset Valores"
        Me.BP_ResetDatosH1Tiemp.TextAlternate = Nothing
        Me.BP_ResetDatosH1Tiemp.UseVisualStyleBackColor = False
        Me.BP_ResetDatosH1Tiemp.ValueToWrite = 0
        '
        'BCF_MenúP_TiemposH2
        '
        Me.BCF_MenúP_TiemposH2.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_TiemposH2.ComComponent = Nothing
        Me.BCF_MenúP_TiemposH2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_TiemposH2.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_TiemposH2.FormToOpen = Nothing
        Me.BCF_MenúP_TiemposH2.KeypadWidth = 300
        Me.BCF_MenúP_TiemposH2.Location = New System.Drawing.Point(217, 66)
        Me.BCF_MenúP_TiemposH2.Name = "BCF_MenúP_TiemposH2"
        Me.BCF_MenúP_TiemposH2.Passcode = Nothing
        Me.BCF_MenúP_TiemposH2.PasswordChar = False
        Me.BCF_MenúP_TiemposH2.PLCAddressVisible = ""
        Me.BCF_MenúP_TiemposH2.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_TiemposH2.TabIndex = 1189
        Me.BCF_MenúP_TiemposH2.Text = "Menú Principal"
        Me.BCF_MenúP_TiemposH2.UseVisualStyleBackColor = False
        '
        'TexVent_y_GU05H2Tiemp
        '
        Me.TexVent_y_GU05H2Tiemp.AutoSize = True
        Me.TexVent_y_GU05H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU05H2Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU05H2Tiemp.Location = New System.Drawing.Point(227, 550)
        Me.TexVent_y_GU05H2Tiemp.Name = "TexVent_y_GU05H2Tiemp"
        Me.TexVent_y_GU05H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU05H2Tiemp.TabIndex = 1188
        Me.TexVent_y_GU05H2Tiemp.Text = "Ventilador Guardiola 05"
        '
        'Tex2HorasH2Tiemp
        '
        Me.Tex2HorasH2Tiemp.AutoSize = True
        Me.Tex2HorasH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2HorasH2Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2HorasH2Tiemp.Location = New System.Drawing.Point(843, 183)
        Me.Tex2HorasH2Tiemp.Name = "Tex2HorasH2Tiemp"
        Me.Tex2HorasH2Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex2HorasH2Tiemp.TabIndex = 1185
        Me.Tex2HorasH2Tiemp.Text = "Horas de Trabajo"
        Me.Tex2HorasH2Tiemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexVent_y_GU07H2Tiemp
        '
        Me.TexVent_y_GU07H2Tiemp.AutoSize = True
        Me.TexVent_y_GU07H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU07H2Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU07H2Tiemp.Location = New System.Drawing.Point(668, 220)
        Me.TexVent_y_GU07H2Tiemp.Name = "TexVent_y_GU07H2Tiemp"
        Me.TexVent_y_GU07H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU07H2Tiemp.TabIndex = 1187
        Me.TexVent_y_GU07H2Tiemp.Text = "Ventilador Guardiola 07"
        '
        'TexAlimCasH2Tiemp
        '
        Me.TexAlimCasH2Tiemp.AutoSize = True
        Me.TexAlimCasH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexAlimCasH2Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexAlimCasH2Tiemp.Location = New System.Drawing.Point(667, 314)
        Me.TexAlimCasH2Tiemp.Name = "TexAlimCasH2Tiemp"
        Me.TexAlimCasH2Tiemp.Size = New System.Drawing.Size(180, 19)
        Me.TexAlimCasH2Tiemp.TabIndex = 1186
        Me.TexAlimCasH2Tiemp.Text = "Alimentador Cascarilla"
        '
        'Tex1HorasH2Tiemp
        '
        Me.Tex1HorasH2Tiemp.AutoSize = True
        Me.Tex1HorasH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1HorasH2Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1HorasH2Tiemp.Location = New System.Drawing.Point(404, 183)
        Me.Tex1HorasH2Tiemp.Name = "Tex1HorasH2Tiemp"
        Me.Tex1HorasH2Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex1HorasH2Tiemp.TabIndex = 1180
        Me.Tex1HorasH2Tiemp.Text = "Horas de Trabajo"
        Me.Tex1HorasH2Tiemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexTiemposH2
        '
        Me.TexTiemposH2.AutoSize = True
        Me.TexTiemposH2.BackColor = System.Drawing.Color.DimGray
        Me.TexTiemposH2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTiemposH2.ForeColor = System.Drawing.Color.White
        Me.TexTiemposH2.Location = New System.Drawing.Point(552, 86)
        Me.TexTiemposH2.Name = "TexTiemposH2"
        Me.TexTiemposH2.Size = New System.Drawing.Size(252, 34)
        Me.TexTiemposH2.TabIndex = 1178
        Me.TexTiemposH2.Text = "Tiempos Horno 2"
        '
        'Tex2EquiH2Tiemp
        '
        Me.Tex2EquiH2Tiemp.AutoSize = True
        Me.Tex2EquiH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2EquiH2Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2EquiH2Tiemp.Location = New System.Drawing.Point(668, 183)
        Me.Tex2EquiH2Tiemp.Name = "Tex2EquiH2Tiemp"
        Me.Tex2EquiH2Tiemp.Size = New System.Drawing.Size(64, 19)
        Me.Tex2EquiH2Tiemp.TabIndex = 1184
        Me.Tex2EquiH2Tiemp.Text = "Equipo"
        '
        'TexVent_y_GU01H2Tiemp
        '
        Me.TexVent_y_GU01H2Tiemp.AutoSize = True
        Me.TexVent_y_GU01H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU01H2Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU01H2Tiemp.Location = New System.Drawing.Point(227, 361)
        Me.TexVent_y_GU01H2Tiemp.Name = "TexVent_y_GU01H2Tiemp"
        Me.TexVent_y_GU01H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU01H2Tiemp.TabIndex = 1182
        Me.TexVent_y_GU01H2Tiemp.Text = "Ventilador Guardiola 01"
        '
        'TexVentCasH2Tiemp
        '
        Me.TexVentCasH2Tiemp.AutoSize = True
        Me.TexVentCasH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVentCasH2Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVentCasH2Tiemp.Location = New System.Drawing.Point(227, 267)
        Me.TexVentCasH2Tiemp.Name = "TexVentCasH2Tiemp"
        Me.TexVentCasH2Tiemp.Size = New System.Drawing.Size(165, 19)
        Me.TexVentCasH2Tiemp.TabIndex = 1181
        Me.TexVentCasH2Tiemp.Text = "Ventilador Cascarilla"
        '
        'TexVent_y_GU03H2Tiemp
        '
        Me.TexVent_y_GU03H2Tiemp.AutoSize = True
        Me.TexVent_y_GU03H2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexVent_y_GU03H2Tiemp.ForeColor = System.Drawing.Color.Blue
        Me.TexVent_y_GU03H2Tiemp.Location = New System.Drawing.Point(227, 455)
        Me.TexVent_y_GU03H2Tiemp.Name = "TexVent_y_GU03H2Tiemp"
        Me.TexVent_y_GU03H2Tiemp.Size = New System.Drawing.Size(186, 19)
        Me.TexVent_y_GU03H2Tiemp.TabIndex = 1183
        Me.TexVent_y_GU03H2Tiemp.Text = "Ventilador Guardiola 03"
        '
        'Tex1EquiH2Tiemp
        '
        Me.Tex1EquiH2Tiemp.AutoSize = True
        Me.Tex1EquiH2Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1EquiH2Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1EquiH2Tiemp.Location = New System.Drawing.Point(227, 183)
        Me.Tex1EquiH2Tiemp.Name = "Tex1EquiH2Tiemp"
        Me.Tex1EquiH2Tiemp.Size = New System.Drawing.Size(64, 19)
        Me.Tex1EquiH2Tiemp.TabIndex = 1179
        Me.Tex1EquiH2Tiemp.Text = "Equipo"
        '
        'Tiempos_Horno_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.ValorVent_y_GU08H2Tiemp)
        Me.Controls.Add(Me.ValorAlimCasH2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU06H2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU07H2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU04H2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU05H2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU02H2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU03H2Tiemp)
        Me.Controls.Add(Me.ValorVentChiH2Tiemp)
        Me.Controls.Add(Me.ValorVent_y_GU01H2Tiemp)
        Me.Controls.Add(Me.ValorVentHogH2Tiemp)
        Me.Controls.Add(Me.ValorVentCasH2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU08H2Tiemp)
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.TexVentChiH2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU02H2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU04H2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU06H2Tiemp)
        Me.Controls.Add(Me.TexVentHogH2Tiemp)
        Me.Controls.Add(Me.BP_ResetDatosH1Tiemp)
        Me.Controls.Add(Me.BCF_MenúP_TiemposH2)
        Me.Controls.Add(Me.TexVent_y_GU05H2Tiemp)
        Me.Controls.Add(Me.Tex2HorasH2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU07H2Tiemp)
        Me.Controls.Add(Me.TexAlimCasH2Tiemp)
        Me.Controls.Add(Me.Tex1HorasH2Tiemp)
        Me.Controls.Add(Me.TexTiemposH2)
        Me.Controls.Add(Me.Tex2EquiH2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU01H2Tiemp)
        Me.Controls.Add(Me.TexVentCasH2Tiemp)
        Me.Controls.Add(Me.TexVent_y_GU03H2Tiemp)
        Me.Controls.Add(Me.Tex1EquiH2Tiemp)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Tiempos_Horno_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TiemposHorno2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ValorVent_y_GU08H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TiemposHorno2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ValorAlimCasH2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU06H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU07H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU04H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU05H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU02H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU03H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVentChiH2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVent_y_GU01H2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVentHogH2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorVentCasH2Tiemp As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexVent_y_GU08H2Tiemp As Label
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents TexVentChiH2Tiemp As Label
    Friend WithEvents TexVent_y_GU02H2Tiemp As Label
    Friend WithEvents TexVent_y_GU04H2Tiemp As Label
    Friend WithEvents TexVent_y_GU06H2Tiemp As Label
    Friend WithEvents TexVentHogH2Tiemp As Label
    Friend WithEvents BP_ResetDatosH1Tiemp As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_MenúP_TiemposH2 As FormChangeButton
    Friend WithEvents TexVent_y_GU05H2Tiemp As Label
    Friend WithEvents Tex2HorasH2Tiemp As Label
    Friend WithEvents TexVent_y_GU07H2Tiemp As Label
    Friend WithEvents TexAlimCasH2Tiemp As Label
    Friend WithEvents Tex1HorasH2Tiemp As Label
    Friend WithEvents TexTiemposH2 As Label
    Friend WithEvents Tex2EquiH2Tiemp As Label
    Friend WithEvents TexVent_y_GU01H2Tiemp As Label
    Friend WithEvents TexVentCasH2Tiemp As Label
    Friend WithEvents TexVent_y_GU03H2Tiemp As Label
    Friend WithEvents Tex1EquiH2Tiemp As Label
End Class
