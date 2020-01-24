<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiemposParoAlmacenamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TiemposParoAlmacenamiento))
        Me.TiemposP_Elevado = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.ValorSegundosParoTH53_2 = New AdvancedHMIControls.SevenSegment2()
        Me.TexSegundosParoTH53_2 = New System.Windows.Forms.Label()
        Me.TexSegundosParoEC16 = New System.Windows.Forms.Label()
        Me.ValorSegundosParoEC05 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH104 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoEC04 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH103 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoEC16 = New AdvancedHMIControls.SevenSegment2()
        Me.TexSegundosParoEC05 = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH104 = New System.Windows.Forms.Label()
        Me.TexSegundosParoEC04 = New System.Windows.Forms.Label()
        Me.ValorSegundosParoTH52 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH41 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH53_1 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH54 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH48 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH50 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH42 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorSegundosParoTH43 = New AdvancedHMIControls.SevenSegment2()
        Me.TexSegundosParoTH52 = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH53_1 = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH48 = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH42 = New System.Windows.Forms.Label()
        Me.ValorSegundosParoTH51 = New AdvancedHMIControls.SevenSegment2()
        Me.TexSegundosParoTH51 = New System.Windows.Forms.Label()
        Me.BCF_RegresarSP_Almac = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_ResetDatosH1Tiemp = New AdvancedHMIControls.BasicButton()
        Me.BCF_MenúP_TiemposH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.TexSegundosParoTH103 = New System.Windows.Forms.Label()
        Me.Tex1SegundosParoAlmac = New System.Windows.Forms.Label()
        Me.TexTiemposParoAlmace = New System.Windows.Forms.Label()
        Me.Tex2SegundosParoAlmac = New System.Windows.Forms.Label()
        Me.Tex2EquipoParoAlmac = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH50 = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH43 = New System.Windows.Forms.Label()
        Me.Tex1EquipoParoAlmac = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH54 = New System.Windows.Forms.Label()
        Me.TexSegundosParoTH41 = New System.Windows.Forms.Label()
        CType(Me.TiemposP_Elevado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TiemposP_Elevado
        '
        Me.TiemposP_Elevado.DisableSubscriptions = False
        Me.TiemposP_Elevado.IniFileName = ""
        Me.TiemposP_Elevado.IniFileSection = Nothing
        Me.TiemposP_Elevado.IPAddress = "10.1.108.14"
        Me.TiemposP_Elevado.MaxReadGroupSize = 20
        Me.TiemposP_Elevado.PollRateOverride = 500
        Me.TiemposP_Elevado.SwapBytes = True
        Me.TiemposP_Elevado.SwapWords = False
        Me.TiemposP_Elevado.TcpipPort = CType(20257US, UShort)
        Me.TiemposP_Elevado.TimeOut = 3000
        Me.TiemposP_Elevado.UnitId = CType(17, Byte)
        '
        'ValorSegundosParoTH53_2
        '
        Me.ValorSegundosParoTH53_2.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH53_2.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH53_2.DecimalPosition = 0
        Me.ValorSegundosParoTH53_2.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH53_2.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH53_2.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH53_2.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH53_2.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH53_2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH53_2.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH53_2.KeypadMinValue = 0R
        Me.ValorSegundosParoTH53_2.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH53_2.KeypadText = Nothing
        Me.ValorSegundosParoTH53_2.KeypadWidth = 300
        Me.ValorSegundosParoTH53_2.Location = New System.Drawing.Point(860, 452)
        Me.ValorSegundosParoTH53_2.Name = "ValorSegundosParoTH53_2"
        Me.ValorSegundosParoTH53_2.NumberOfDigits = 5
        Me.ValorSegundosParoTH53_2.PLCAddressKeypad = "40013"
        Me.ValorSegundosParoTH53_2.PLCAddressText = ""
        Me.ValorSegundosParoTH53_2.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH53_2.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH53_2.PLCAddressVisible = ""
        Me.ValorSegundosParoTH53_2.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH53_2.ShowOffSegments = True
        Me.ValorSegundosParoTH53_2.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH53_2.TabIndex = 1249
        Me.ValorSegundosParoTH53_2.Value = 0R
        '
        'TexSegundosParoTH53_2
        '
        Me.TexSegundosParoTH53_2.AutoSize = True
        Me.TexSegundosParoTH53_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH53_2.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH53_2.Location = New System.Drawing.Point(664, 454)
        Me.TexSegundosParoTH53_2.Name = "TexSegundosParoTH53_2"
        Me.TexSegundosParoTH53_2.Size = New System.Drawing.Size(190, 19)
        Me.TexSegundosParoTH53_2.TabIndex = 1248
        Me.TexSegundosParoTH53_2.Text = "Segundos Paro TH-53.2"
        '
        'TexSegundosParoEC16
        '
        Me.TexSegundosParoEC16.AutoSize = True
        Me.TexSegundosParoEC16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoEC16.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoEC16.Location = New System.Drawing.Point(226, 267)
        Me.TexSegundosParoEC16.Name = "TexSegundosParoEC16"
        Me.TexSegundosParoEC16.Size = New System.Drawing.Size(178, 19)
        Me.TexSegundosParoEC16.TabIndex = 1246
        Me.TexSegundosParoEC16.Text = "Segundos Paro EC-16"
        '
        'ValorSegundosParoEC05
        '
        Me.ValorSegundosParoEC05.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoEC05.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoEC05.DecimalPosition = 0
        Me.ValorSegundosParoEC05.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoEC05.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoEC05.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoEC05.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoEC05.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoEC05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoEC05.KeypadMaxValue = 0R
        Me.ValorSegundosParoEC05.KeypadMinValue = 0R
        Me.ValorSegundosParoEC05.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoEC05.KeypadText = Nothing
        Me.ValorSegundosParoEC05.KeypadWidth = 300
        Me.ValorSegundosParoEC05.Location = New System.Drawing.Point(860, 405)
        Me.ValorSegundosParoEC05.Name = "ValorSegundosParoEC05"
        Me.ValorSegundosParoEC05.NumberOfDigits = 5
        Me.ValorSegundosParoEC05.PLCAddressKeypad = "40004"
        Me.ValorSegundosParoEC05.PLCAddressText = ""
        Me.ValorSegundosParoEC05.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoEC05.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoEC05.PLCAddressVisible = ""
        Me.ValorSegundosParoEC05.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoEC05.ShowOffSegments = True
        Me.ValorSegundosParoEC05.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoEC05.TabIndex = 1245
        Me.ValorSegundosParoEC05.Value = 0R
        '
        'ValorSegundosParoTH104
        '
        Me.ValorSegundosParoTH104.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH104.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH104.DecimalPosition = 0
        Me.ValorSegundosParoTH104.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH104.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH104.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH104.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH104.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH104.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH104.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH104.KeypadMinValue = 0R
        Me.ValorSegundosParoTH104.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH104.KeypadText = Nothing
        Me.ValorSegundosParoTH104.KeypadWidth = 300
        Me.ValorSegundosParoTH104.Location = New System.Drawing.Point(860, 358)
        Me.ValorSegundosParoTH104.Name = "ValorSegundosParoTH104"
        Me.ValorSegundosParoTH104.NumberOfDigits = 5
        Me.ValorSegundosParoTH104.PLCAddressKeypad = "40016"
        Me.ValorSegundosParoTH104.PLCAddressText = ""
        Me.ValorSegundosParoTH104.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH104.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH104.PLCAddressVisible = ""
        Me.ValorSegundosParoTH104.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH104.ShowOffSegments = True
        Me.ValorSegundosParoTH104.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH104.TabIndex = 1243
        Me.ValorSegundosParoTH104.Value = 0R
        '
        'ValorSegundosParoEC04
        '
        Me.ValorSegundosParoEC04.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoEC04.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoEC04.DecimalPosition = 0
        Me.ValorSegundosParoEC04.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoEC04.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoEC04.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoEC04.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoEC04.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoEC04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoEC04.KeypadMaxValue = 0R
        Me.ValorSegundosParoEC04.KeypadMinValue = 0R
        Me.ValorSegundosParoEC04.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoEC04.KeypadText = Nothing
        Me.ValorSegundosParoEC04.KeypadWidth = 300
        Me.ValorSegundosParoEC04.Location = New System.Drawing.Point(864, 265)
        Me.ValorSegundosParoEC04.Name = "ValorSegundosParoEC04"
        Me.ValorSegundosParoEC04.NumberOfDigits = 5
        Me.ValorSegundosParoEC04.PLCAddressKeypad = "40003"
        Me.ValorSegundosParoEC04.PLCAddressText = ""
        Me.ValorSegundosParoEC04.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoEC04.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoEC04.PLCAddressVisible = ""
        Me.ValorSegundosParoEC04.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoEC04.ShowOffSegments = True
        Me.ValorSegundosParoEC04.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoEC04.TabIndex = 1240
        Me.ValorSegundosParoEC04.Value = 0R
        '
        'ValorSegundosParoTH103
        '
        Me.ValorSegundosParoTH103.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoTH103.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH103.DecimalPosition = 0
        Me.ValorSegundosParoTH103.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH103.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH103.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH103.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH103.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH103.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH103.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH103.KeypadMinValue = 0R
        Me.ValorSegundosParoTH103.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH103.KeypadText = Nothing
        Me.ValorSegundosParoTH103.KeypadWidth = 300
        Me.ValorSegundosParoTH103.Location = New System.Drawing.Point(860, 311)
        Me.ValorSegundosParoTH103.Name = "ValorSegundosParoTH103"
        Me.ValorSegundosParoTH103.NumberOfDigits = 5
        Me.ValorSegundosParoTH103.PLCAddressKeypad = "40015"
        Me.ValorSegundosParoTH103.PLCAddressText = ""
        Me.ValorSegundosParoTH103.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH103.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH103.PLCAddressVisible = ""
        Me.ValorSegundosParoTH103.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH103.ShowOffSegments = True
        Me.ValorSegundosParoTH103.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH103.TabIndex = 1241
        Me.ValorSegundosParoTH103.Value = 0R
        '
        'ValorSegundosParoEC16
        '
        Me.ValorSegundosParoEC16.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoEC16.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoEC16.DecimalPosition = 0
        Me.ValorSegundosParoEC16.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoEC16.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoEC16.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoEC16.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoEC16.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoEC16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoEC16.KeypadMaxValue = 0R
        Me.ValorSegundosParoEC16.KeypadMinValue = 0R
        Me.ValorSegundosParoEC16.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoEC16.KeypadText = Nothing
        Me.ValorSegundosParoEC16.KeypadWidth = 300
        Me.ValorSegundosParoEC16.Location = New System.Drawing.Point(423, 265)
        Me.ValorSegundosParoEC16.Name = "ValorSegundosParoEC16"
        Me.ValorSegundosParoEC16.NumberOfDigits = 5
        Me.ValorSegundosParoEC16.PLCAddressKeypad = "40008"
        Me.ValorSegundosParoEC16.PLCAddressText = ""
        Me.ValorSegundosParoEC16.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoEC16.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoEC16.PLCAddressVisible = ""
        Me.ValorSegundosParoEC16.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoEC16.ShowOffSegments = True
        Me.ValorSegundosParoEC16.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoEC16.TabIndex = 1247
        Me.ValorSegundosParoEC16.Value = 0R
        '
        'TexSegundosParoEC05
        '
        Me.TexSegundosParoEC05.AutoSize = True
        Me.TexSegundosParoEC05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoEC05.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoEC05.Location = New System.Drawing.Point(667, 407)
        Me.TexSegundosParoEC05.Name = "TexSegundosParoEC05"
        Me.TexSegundosParoEC05.Size = New System.Drawing.Size(178, 19)
        Me.TexSegundosParoEC05.TabIndex = 1244
        Me.TexSegundosParoEC05.Text = "Segundos Paro EC-05"
        '
        'TexSegundosParoTH104
        '
        Me.TexSegundosParoTH104.AutoSize = True
        Me.TexSegundosParoTH104.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH104.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH104.Location = New System.Drawing.Point(663, 360)
        Me.TexSegundosParoTH104.Name = "TexSegundosParoTH104"
        Me.TexSegundosParoTH104.Size = New System.Drawing.Size(186, 19)
        Me.TexSegundosParoTH104.TabIndex = 1242
        Me.TexSegundosParoTH104.Text = "Segundos Paro TH-104"
        '
        'TexSegundosParoEC04
        '
        Me.TexSegundosParoEC04.AutoSize = True
        Me.TexSegundosParoEC04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoEC04.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoEC04.Location = New System.Drawing.Point(667, 267)
        Me.TexSegundosParoEC04.Name = "TexSegundosParoEC04"
        Me.TexSegundosParoEC04.Size = New System.Drawing.Size(178, 19)
        Me.TexSegundosParoEC04.TabIndex = 1217
        Me.TexSegundosParoEC04.Text = "Segundos Paro EC-04"
        '
        'ValorSegundosParoTH52
        '
        Me.ValorSegundosParoTH52.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH52.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH52.DecimalPosition = 0
        Me.ValorSegundosParoTH52.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH52.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH52.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH52.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH52.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH52.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH52.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH52.KeypadMinValue = 0R
        Me.ValorSegundosParoTH52.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH52.KeypadText = Nothing
        Me.ValorSegundosParoTH52.KeypadWidth = 300
        Me.ValorSegundosParoTH52.Location = New System.Drawing.Point(423, 593)
        Me.ValorSegundosParoTH52.Name = "ValorSegundosParoTH52"
        Me.ValorSegundosParoTH52.NumberOfDigits = 5
        Me.ValorSegundosParoTH52.PLCAddressKeypad = "40010"
        Me.ValorSegundosParoTH52.PLCAddressText = ""
        Me.ValorSegundosParoTH52.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH52.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH52.PLCAddressVisible = ""
        Me.ValorSegundosParoTH52.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH52.ShowOffSegments = True
        Me.ValorSegundosParoTH52.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH52.TabIndex = 1238
        Me.ValorSegundosParoTH52.Value = 0R
        '
        'ValorSegundosParoTH41
        '
        Me.ValorSegundosParoTH41.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoTH41.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH41.DecimalPosition = 0
        Me.ValorSegundosParoTH41.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH41.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH41.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH41.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH41.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH41.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH41.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH41.KeypadMinValue = 0R
        Me.ValorSegundosParoTH41.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH41.KeypadText = Nothing
        Me.ValorSegundosParoTH41.KeypadWidth = 300
        Me.ValorSegundosParoTH41.Location = New System.Drawing.Point(864, 219)
        Me.ValorSegundosParoTH41.Name = "ValorSegundosParoTH41"
        Me.ValorSegundosParoTH41.NumberOfDigits = 5
        Me.ValorSegundosParoTH41.PLCAddressKeypad = "40014"
        Me.ValorSegundosParoTH41.PLCAddressText = ""
        Me.ValorSegundosParoTH41.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH41.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH41.PLCAddressVisible = ""
        Me.ValorSegundosParoTH41.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH41.ShowOffSegments = True
        Me.ValorSegundosParoTH41.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH41.TabIndex = 1239
        Me.ValorSegundosParoTH41.Value = 0R
        '
        'ValorSegundosParoTH53_1
        '
        Me.ValorSegundosParoTH53_1.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH53_1.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH53_1.DecimalPosition = 0
        Me.ValorSegundosParoTH53_1.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH53_1.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH53_1.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH53_1.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH53_1.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH53_1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH53_1.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH53_1.KeypadMinValue = 0R
        Me.ValorSegundosParoTH53_1.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH53_1.KeypadText = Nothing
        Me.ValorSegundosParoTH53_1.KeypadWidth = 300
        Me.ValorSegundosParoTH53_1.Location = New System.Drawing.Point(423, 499)
        Me.ValorSegundosParoTH53_1.Name = "ValorSegundosParoTH53_1"
        Me.ValorSegundosParoTH53_1.NumberOfDigits = 5
        Me.ValorSegundosParoTH53_1.PLCAddressKeypad = "40012"
        Me.ValorSegundosParoTH53_1.PLCAddressText = ""
        Me.ValorSegundosParoTH53_1.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH53_1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH53_1.PLCAddressVisible = ""
        Me.ValorSegundosParoTH53_1.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH53_1.ShowOffSegments = True
        Me.ValorSegundosParoTH53_1.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH53_1.TabIndex = 1236
        Me.ValorSegundosParoTH53_1.Value = 0R
        '
        'ValorSegundosParoTH54
        '
        Me.ValorSegundosParoTH54.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoTH54.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH54.DecimalPosition = 0
        Me.ValorSegundosParoTH54.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH54.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH54.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH54.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH54.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH54.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH54.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH54.KeypadMinValue = 0R
        Me.ValorSegundosParoTH54.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH54.KeypadText = Nothing
        Me.ValorSegundosParoTH54.KeypadWidth = 300
        Me.ValorSegundosParoTH54.Location = New System.Drawing.Point(423, 546)
        Me.ValorSegundosParoTH54.Name = "ValorSegundosParoTH54"
        Me.ValorSegundosParoTH54.NumberOfDigits = 5
        Me.ValorSegundosParoTH54.PLCAddressKeypad = "40006"
        Me.ValorSegundosParoTH54.PLCAddressText = ""
        Me.ValorSegundosParoTH54.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH54.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH54.PLCAddressVisible = ""
        Me.ValorSegundosParoTH54.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH54.ShowOffSegments = True
        Me.ValorSegundosParoTH54.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH54.TabIndex = 1237
        Me.ValorSegundosParoTH54.Value = 0R
        '
        'ValorSegundosParoTH48
        '
        Me.ValorSegundosParoTH48.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH48.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH48.DecimalPosition = 0
        Me.ValorSegundosParoTH48.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH48.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH48.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH48.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH48.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH48.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH48.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH48.KeypadMinValue = 0R
        Me.ValorSegundosParoTH48.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH48.KeypadText = Nothing
        Me.ValorSegundosParoTH48.KeypadWidth = 300
        Me.ValorSegundosParoTH48.Location = New System.Drawing.Point(423, 405)
        Me.ValorSegundosParoTH48.Name = "ValorSegundosParoTH48"
        Me.ValorSegundosParoTH48.NumberOfDigits = 5
        Me.ValorSegundosParoTH48.PLCAddressKeypad = "40009"
        Me.ValorSegundosParoTH48.PLCAddressText = ""
        Me.ValorSegundosParoTH48.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH48.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH48.PLCAddressVisible = ""
        Me.ValorSegundosParoTH48.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH48.ShowOffSegments = True
        Me.ValorSegundosParoTH48.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH48.TabIndex = 1234
        Me.ValorSegundosParoTH48.Value = 0R
        '
        'ValorSegundosParoTH50
        '
        Me.ValorSegundosParoTH50.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoTH50.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH50.DecimalPosition = 0
        Me.ValorSegundosParoTH50.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH50.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH50.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH50.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH50.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH50.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH50.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH50.KeypadMinValue = 0R
        Me.ValorSegundosParoTH50.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH50.KeypadText = Nothing
        Me.ValorSegundosParoTH50.KeypadWidth = 300
        Me.ValorSegundosParoTH50.Location = New System.Drawing.Point(423, 452)
        Me.ValorSegundosParoTH50.Name = "ValorSegundosParoTH50"
        Me.ValorSegundosParoTH50.NumberOfDigits = 5
        Me.ValorSegundosParoTH50.PLCAddressKeypad = "40007"
        Me.ValorSegundosParoTH50.PLCAddressText = ""
        Me.ValorSegundosParoTH50.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH50.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH50.PLCAddressVisible = ""
        Me.ValorSegundosParoTH50.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH50.ShowOffSegments = True
        Me.ValorSegundosParoTH50.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH50.TabIndex = 1235
        Me.ValorSegundosParoTH50.Value = 0R
        '
        'ValorSegundosParoTH42
        '
        Me.ValorSegundosParoTH42.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH42.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH42.DecimalPosition = 0
        Me.ValorSegundosParoTH42.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH42.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH42.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH42.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH42.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH42.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH42.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH42.KeypadMinValue = 0R
        Me.ValorSegundosParoTH42.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH42.KeypadText = Nothing
        Me.ValorSegundosParoTH42.KeypadWidth = 300
        Me.ValorSegundosParoTH42.Location = New System.Drawing.Point(423, 311)
        Me.ValorSegundosParoTH42.Name = "ValorSegundosParoTH42"
        Me.ValorSegundosParoTH42.NumberOfDigits = 5
        Me.ValorSegundosParoTH42.PLCAddressKeypad = "40002"
        Me.ValorSegundosParoTH42.PLCAddressText = ""
        Me.ValorSegundosParoTH42.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH42.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH42.PLCAddressVisible = ""
        Me.ValorSegundosParoTH42.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH42.ShowOffSegments = True
        Me.ValorSegundosParoTH42.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH42.TabIndex = 1232
        Me.ValorSegundosParoTH42.Value = 0R
        '
        'ValorSegundosParoTH43
        '
        Me.ValorSegundosParoTH43.BackColor = System.Drawing.Color.White
        Me.ValorSegundosParoTH43.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH43.DecimalPosition = 0
        Me.ValorSegundosParoTH43.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH43.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH43.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH43.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH43.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH43.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH43.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH43.KeypadMinValue = 0R
        Me.ValorSegundosParoTH43.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH43.KeypadText = Nothing
        Me.ValorSegundosParoTH43.KeypadWidth = 300
        Me.ValorSegundosParoTH43.Location = New System.Drawing.Point(423, 358)
        Me.ValorSegundosParoTH43.Name = "ValorSegundosParoTH43"
        Me.ValorSegundosParoTH43.NumberOfDigits = 5
        Me.ValorSegundosParoTH43.PLCAddressKeypad = "40005"
        Me.ValorSegundosParoTH43.PLCAddressText = ""
        Me.ValorSegundosParoTH43.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH43.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH43.PLCAddressVisible = ""
        Me.ValorSegundosParoTH43.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH43.ShowOffSegments = True
        Me.ValorSegundosParoTH43.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH43.TabIndex = 1233
        Me.ValorSegundosParoTH43.Value = 0R
        '
        'TexSegundosParoTH52
        '
        Me.TexSegundosParoTH52.AutoSize = True
        Me.TexSegundosParoTH52.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH52.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH52.Location = New System.Drawing.Point(227, 595)
        Me.TexSegundosParoTH52.Name = "TexSegundosParoTH52"
        Me.TexSegundosParoTH52.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH52.TabIndex = 1216
        Me.TexSegundosParoTH52.Text = "Segundos Paro TH-52"
        '
        'TexSegundosParoTH53_1
        '
        Me.TexSegundosParoTH53_1.AutoSize = True
        Me.TexSegundosParoTH53_1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH53_1.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH53_1.Location = New System.Drawing.Point(227, 501)
        Me.TexSegundosParoTH53_1.Name = "TexSegundosParoTH53_1"
        Me.TexSegundosParoTH53_1.Size = New System.Drawing.Size(190, 19)
        Me.TexSegundosParoTH53_1.TabIndex = 1215
        Me.TexSegundosParoTH53_1.Text = "Segundos Paro TH-53.1"
        '
        'TexSegundosParoTH48
        '
        Me.TexSegundosParoTH48.AutoSize = True
        Me.TexSegundosParoTH48.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH48.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH48.Location = New System.Drawing.Point(227, 407)
        Me.TexSegundosParoTH48.Name = "TexSegundosParoTH48"
        Me.TexSegundosParoTH48.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH48.TabIndex = 1214
        Me.TexSegundosParoTH48.Text = "Segundos Paro TH-48"
        '
        'TexSegundosParoTH42
        '
        Me.TexSegundosParoTH42.AutoSize = True
        Me.TexSegundosParoTH42.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH42.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH42.Location = New System.Drawing.Point(227, 313)
        Me.TexSegundosParoTH42.Name = "TexSegundosParoTH42"
        Me.TexSegundosParoTH42.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH42.TabIndex = 1213
        Me.TexSegundosParoTH42.Text = "Segundos Paro TH-42"
        '
        'ValorSegundosParoTH51
        '
        Me.ValorSegundosParoTH51.BackColor = System.Drawing.Color.Blue
        Me.ValorSegundosParoTH51.ComComponent = Me.TiemposP_Elevado
        Me.ValorSegundosParoTH51.DecimalPosition = 0
        Me.ValorSegundosParoTH51.ForecolorHighLimitValue = 999999.0R
        Me.ValorSegundosParoTH51.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorSegundosParoTH51.ForecolorLowLimitValue = -999999.0R
        Me.ValorSegundosParoTH51.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorSegundosParoTH51.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorSegundosParoTH51.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorSegundosParoTH51.KeypadMaxValue = 0R
        Me.ValorSegundosParoTH51.KeypadMinValue = 0R
        Me.ValorSegundosParoTH51.KeypadScaleFactor = 1.0R
        Me.ValorSegundosParoTH51.KeypadText = Nothing
        Me.ValorSegundosParoTH51.KeypadWidth = 300
        Me.ValorSegundosParoTH51.Location = New System.Drawing.Point(423, 219)
        Me.ValorSegundosParoTH51.Name = "ValorSegundosParoTH51"
        Me.ValorSegundosParoTH51.NumberOfDigits = 5
        Me.ValorSegundosParoTH51.PLCAddressKeypad = "40011"
        Me.ValorSegundosParoTH51.PLCAddressText = ""
        Me.ValorSegundosParoTH51.PLCAddressValue = CType(resources.GetObject("ValorSegundosParoTH51.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorSegundosParoTH51.PLCAddressVisible = ""
        Me.ValorSegundosParoTH51.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorSegundosParoTH51.ShowOffSegments = True
        Me.ValorSegundosParoTH51.Size = New System.Drawing.Size(90, 23)
        Me.ValorSegundosParoTH51.TabIndex = 1231
        Me.ValorSegundosParoTH51.Value = 0R
        '
        'TexSegundosParoTH51
        '
        Me.TexSegundosParoTH51.AutoSize = True
        Me.TexSegundosParoTH51.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH51.ForeColor = System.Drawing.Color.White
        Me.TexSegundosParoTH51.Location = New System.Drawing.Point(227, 221)
        Me.TexSegundosParoTH51.Name = "TexSegundosParoTH51"
        Me.TexSegundosParoTH51.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH51.TabIndex = 1212
        Me.TexSegundosParoTH51.Text = "Segundos Paro TH-51"
        '
        'BCF_RegresarSP_Almac
        '
        Me.BCF_RegresarSP_Almac.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarSP_Almac.ComComponent = Nothing
        Me.BCF_RegresarSP_Almac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarSP_Almac.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarSP_Almac.FormToOpen = GetType(MfgControl.AdvancedHMI.Ingeniería)
        Me.BCF_RegresarSP_Almac.KeypadWidth = 300
        Me.BCF_RegresarSP_Almac.Location = New System.Drawing.Point(981, 632)
        Me.BCF_RegresarSP_Almac.Name = "BCF_RegresarSP_Almac"
        Me.BCF_RegresarSP_Almac.Passcode = Nothing
        Me.BCF_RegresarSP_Almac.PasswordChar = False
        Me.BCF_RegresarSP_Almac.PLCAddressVisible = ""
        Me.BCF_RegresarSP_Almac.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarSP_Almac.TabIndex = 1230
        Me.BCF_RegresarSP_Almac.Text = "Regresar"
        Me.BCF_RegresarSP_Almac.UseVisualStyleBackColor = False
        '
        'BP_ResetDatosH1Tiemp
        '
        Me.BP_ResetDatosH1Tiemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ResetDatosH1Tiemp.ComComponent = Me.TiemposP_Elevado
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
        Me.BP_ResetDatosH1Tiemp.PLCAddressClick = "ElevadoSDI.MB68"
        Me.BP_ResetDatosH1Tiemp.SelectTextAlternate = False
        Me.BP_ResetDatosH1Tiemp.Size = New System.Drawing.Size(143, 55)
        Me.BP_ResetDatosH1Tiemp.TabIndex = 1229
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
        Me.BCF_MenúP_TiemposH1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_TiemposH1.KeypadWidth = 300
        Me.BCF_MenúP_TiemposH1.Location = New System.Drawing.Point(217, 66)
        Me.BCF_MenúP_TiemposH1.Name = "BCF_MenúP_TiemposH1"
        Me.BCF_MenúP_TiemposH1.Passcode = Nothing
        Me.BCF_MenúP_TiemposH1.PasswordChar = False
        Me.BCF_MenúP_TiemposH1.PLCAddressVisible = ""
        Me.BCF_MenúP_TiemposH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_TiemposH1.TabIndex = 1228
        Me.BCF_MenúP_TiemposH1.Text = "Menú Principal"
        Me.BCF_MenúP_TiemposH1.UseVisualStyleBackColor = False
        '
        'TexSegundosParoTH103
        '
        Me.TexSegundosParoTH103.AutoSize = True
        Me.TexSegundosParoTH103.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH103.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoTH103.Location = New System.Drawing.Point(667, 313)
        Me.TexSegundosParoTH103.Name = "TexSegundosParoTH103"
        Me.TexSegundosParoTH103.Size = New System.Drawing.Size(186, 19)
        Me.TexSegundosParoTH103.TabIndex = 1225
        Me.TexSegundosParoTH103.Text = "Segundos Paro TH-103"
        '
        'Tex1SegundosParoAlmac
        '
        Me.Tex1SegundosParoAlmac.AutoSize = True
        Me.Tex1SegundosParoAlmac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1SegundosParoAlmac.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1SegundosParoAlmac.Location = New System.Drawing.Point(423, 183)
        Me.Tex1SegundosParoAlmac.Name = "Tex1SegundosParoAlmac"
        Me.Tex1SegundosParoAlmac.Size = New System.Drawing.Size(88, 19)
        Me.Tex1SegundosParoAlmac.TabIndex = 1220
        Me.Tex1SegundosParoAlmac.Text = "Segundos"
        Me.Tex1SegundosParoAlmac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexTiemposParoAlmace
        '
        Me.TexTiemposParoAlmace.AutoSize = True
        Me.TexTiemposParoAlmace.BackColor = System.Drawing.Color.DimGray
        Me.TexTiemposParoAlmace.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTiemposParoAlmace.ForeColor = System.Drawing.Color.White
        Me.TexTiemposParoAlmace.Location = New System.Drawing.Point(428, 86)
        Me.TexTiemposParoAlmace.Name = "TexTiemposParoAlmace"
        Me.TexTiemposParoAlmace.Size = New System.Drawing.Size(466, 34)
        Me.TexTiemposParoAlmace.TabIndex = 1218
        Me.TexTiemposParoAlmace.Text = "Segundos Paro Almacenamiento"
        '
        'Tex2SegundosParoAlmac
        '
        Me.Tex2SegundosParoAlmac.AutoSize = True
        Me.Tex2SegundosParoAlmac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2SegundosParoAlmac.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2SegundosParoAlmac.Location = New System.Drawing.Point(865, 183)
        Me.Tex2SegundosParoAlmac.Name = "Tex2SegundosParoAlmac"
        Me.Tex2SegundosParoAlmac.Size = New System.Drawing.Size(88, 19)
        Me.Tex2SegundosParoAlmac.TabIndex = 1224
        Me.Tex2SegundosParoAlmac.Text = "Segundos"
        Me.Tex2SegundosParoAlmac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex2EquipoParoAlmac
        '
        Me.Tex2EquipoParoAlmac.AutoSize = True
        Me.Tex2EquipoParoAlmac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2EquipoParoAlmac.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2EquipoParoAlmac.Location = New System.Drawing.Point(668, 183)
        Me.Tex2EquipoParoAlmac.Name = "Tex2EquipoParoAlmac"
        Me.Tex2EquipoParoAlmac.Size = New System.Drawing.Size(64, 19)
        Me.Tex2EquipoParoAlmac.TabIndex = 1223
        Me.Tex2EquipoParoAlmac.Text = "Equipo"
        '
        'TexSegundosParoTH50
        '
        Me.TexSegundosParoTH50.AutoSize = True
        Me.TexSegundosParoTH50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH50.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoTH50.Location = New System.Drawing.Point(227, 454)
        Me.TexSegundosParoTH50.Name = "TexSegundosParoTH50"
        Me.TexSegundosParoTH50.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH50.TabIndex = 1222
        Me.TexSegundosParoTH50.Text = "Segundos Paro TH-50"
        '
        'TexSegundosParoTH43
        '
        Me.TexSegundosParoTH43.AutoSize = True
        Me.TexSegundosParoTH43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH43.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoTH43.Location = New System.Drawing.Point(227, 360)
        Me.TexSegundosParoTH43.Name = "TexSegundosParoTH43"
        Me.TexSegundosParoTH43.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH43.TabIndex = 1221
        Me.TexSegundosParoTH43.Text = "Segundos Paro TH-43"
        '
        'Tex1EquipoParoAlmac
        '
        Me.Tex1EquipoParoAlmac.AutoSize = True
        Me.Tex1EquipoParoAlmac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1EquipoParoAlmac.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1EquipoParoAlmac.Location = New System.Drawing.Point(227, 183)
        Me.Tex1EquipoParoAlmac.Name = "Tex1EquipoParoAlmac"
        Me.Tex1EquipoParoAlmac.Size = New System.Drawing.Size(64, 19)
        Me.Tex1EquipoParoAlmac.TabIndex = 1219
        Me.Tex1EquipoParoAlmac.Text = "Equipo"
        '
        'TexSegundosParoTH54
        '
        Me.TexSegundosParoTH54.AutoSize = True
        Me.TexSegundosParoTH54.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH54.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoTH54.Location = New System.Drawing.Point(227, 548)
        Me.TexSegundosParoTH54.Name = "TexSegundosParoTH54"
        Me.TexSegundosParoTH54.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH54.TabIndex = 1227
        Me.TexSegundosParoTH54.Text = "Segundos Paro TH-54"
        '
        'TexSegundosParoTH41
        '
        Me.TexSegundosParoTH41.AutoSize = True
        Me.TexSegundosParoTH41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexSegundosParoTH41.ForeColor = System.Drawing.Color.Blue
        Me.TexSegundosParoTH41.Location = New System.Drawing.Point(668, 221)
        Me.TexSegundosParoTH41.Name = "TexSegundosParoTH41"
        Me.TexSegundosParoTH41.Size = New System.Drawing.Size(177, 19)
        Me.TexSegundosParoTH41.TabIndex = 1226
        Me.TexSegundosParoTH41.Text = "Segundos Paro TH-41"
        '
        'TiemposParoAlmacenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.ValorSegundosParoTH53_2)
        Me.Controls.Add(Me.TexSegundosParoTH53_2)
        Me.Controls.Add(Me.TexSegundosParoEC16)
        Me.Controls.Add(Me.ValorSegundosParoEC05)
        Me.Controls.Add(Me.ValorSegundosParoTH104)
        Me.Controls.Add(Me.ValorSegundosParoEC04)
        Me.Controls.Add(Me.ValorSegundosParoTH103)
        Me.Controls.Add(Me.ValorSegundosParoEC16)
        Me.Controls.Add(Me.TexSegundosParoEC05)
        Me.Controls.Add(Me.TexSegundosParoTH104)
        Me.Controls.Add(Me.TexSegundosParoEC04)
        Me.Controls.Add(Me.ValorSegundosParoTH52)
        Me.Controls.Add(Me.ValorSegundosParoTH41)
        Me.Controls.Add(Me.ValorSegundosParoTH53_1)
        Me.Controls.Add(Me.ValorSegundosParoTH54)
        Me.Controls.Add(Me.ValorSegundosParoTH48)
        Me.Controls.Add(Me.ValorSegundosParoTH50)
        Me.Controls.Add(Me.ValorSegundosParoTH42)
        Me.Controls.Add(Me.ValorSegundosParoTH43)
        Me.Controls.Add(Me.TexSegundosParoTH52)
        Me.Controls.Add(Me.TexSegundosParoTH53_1)
        Me.Controls.Add(Me.TexSegundosParoTH48)
        Me.Controls.Add(Me.TexSegundosParoTH42)
        Me.Controls.Add(Me.ValorSegundosParoTH51)
        Me.Controls.Add(Me.TexSegundosParoTH51)
        Me.Controls.Add(Me.BCF_RegresarSP_Almac)
        Me.Controls.Add(Me.BP_ResetDatosH1Tiemp)
        Me.Controls.Add(Me.BCF_MenúP_TiemposH1)
        Me.Controls.Add(Me.TexSegundosParoTH103)
        Me.Controls.Add(Me.Tex1SegundosParoAlmac)
        Me.Controls.Add(Me.TexTiemposParoAlmace)
        Me.Controls.Add(Me.Tex2SegundosParoAlmac)
        Me.Controls.Add(Me.Tex2EquipoParoAlmac)
        Me.Controls.Add(Me.TexSegundosParoTH50)
        Me.Controls.Add(Me.TexSegundosParoTH43)
        Me.Controls.Add(Me.Tex1EquipoParoAlmac)
        Me.Controls.Add(Me.TexSegundosParoTH54)
        Me.Controls.Add(Me.TexSegundosParoTH41)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TiemposParoAlmacenamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TiemposP_Elevado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TiemposP_Elevado As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents ValorSegundosParoTH53_2 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexSegundosParoTH53_2 As Label
    Friend WithEvents TexSegundosParoEC16 As Label
    Friend WithEvents ValorSegundosParoEC05 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH104 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoEC04 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH103 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoEC16 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexSegundosParoEC05 As Label
    Friend WithEvents TexSegundosParoTH104 As Label
    Friend WithEvents TexSegundosParoEC04 As Label
    Friend WithEvents ValorSegundosParoTH52 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH41 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH53_1 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH54 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH48 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH50 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH42 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorSegundosParoTH43 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexSegundosParoTH52 As Label
    Friend WithEvents TexSegundosParoTH53_1 As Label
    Friend WithEvents TexSegundosParoTH48 As Label
    Friend WithEvents TexSegundosParoTH42 As Label
    Friend WithEvents ValorSegundosParoTH51 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexSegundosParoTH51 As Label
    Friend WithEvents BCF_RegresarSP_Almac As FormChangeButton
    Friend WithEvents BP_ResetDatosH1Tiemp As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_MenúP_TiemposH1 As FormChangeButton
    Friend WithEvents TexSegundosParoTH103 As Label
    Friend WithEvents Tex1SegundosParoAlmac As Label
    Friend WithEvents TexTiemposParoAlmace As Label
    Friend WithEvents Tex2SegundosParoAlmac As Label
    Friend WithEvents Tex2EquipoParoAlmac As Label
    Friend WithEvents TexSegundosParoTH50 As Label
    Friend WithEvents TexSegundosParoTH43 As Label
    Friend WithEvents Tex1EquipoParoAlmac As Label
    Friend WithEvents TexSegundosParoTH54 As Label
    Friend WithEvents TexSegundosParoTH41 As Label
End Class
