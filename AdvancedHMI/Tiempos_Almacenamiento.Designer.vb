<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiempos_Almacenamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiempos_Almacenamiento))
        Me.TexHorasEC16 = New System.Windows.Forms.Label()
        Me.ValorHorasEC05 = New AdvancedHMIControls.SevenSegment2()
        Me.UniOpcAlmacenamiento = New AdvancedHMIDrivers.OpcDaCom(Me.components)
        Me.ValorHorasTH104 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasEC04 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH103 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasEC16 = New AdvancedHMIControls.SevenSegment2()
        Me.TexHorasEC05 = New System.Windows.Forms.Label()
        Me.TexHorasTH104 = New System.Windows.Forms.Label()
        Me.TexHorasEC04 = New System.Windows.Forms.Label()
        Me.ValorHorasTH52 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH41 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH53 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH54 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH48 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment26 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH42 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH43 = New AdvancedHMIControls.SevenSegment2()
        Me.TexHorasTH52 = New System.Windows.Forms.Label()
        Me.TexHorasTH53 = New System.Windows.Forms.Label()
        Me.TexHorasTH48 = New System.Windows.Forms.Label()
        Me.TexHorasTH42 = New System.Windows.Forms.Label()
        Me.ValorHorasTH51 = New AdvancedHMIControls.SevenSegment2()
        Me.ValorHorasTH40 = New AdvancedHMIControls.SevenSegment2()
        Me.TexHorasTH51 = New System.Windows.Forms.Label()
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_ResetDatosH1Tiemp = New AdvancedHMIControls.BasicButton()
        Me.BCF_MenúP_TiemposH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.TexHorasTH103 = New System.Windows.Forms.Label()
        Me.Tex1HorasH1Tiemp = New System.Windows.Forms.Label()
        Me.TexTiemposH1 = New System.Windows.Forms.Label()
        Me.Tex2HorasH1Tiemp = New System.Windows.Forms.Label()
        Me.Tex2EquiH1Tiemp = New System.Windows.Forms.Label()
        Me.TexHorasTH50 = New System.Windows.Forms.Label()
        Me.TexHorasTH43 = New System.Windows.Forms.Label()
        Me.TexTiempoTH40 = New System.Windows.Forms.Label()
        Me.Tex1EquiH1Tiemp = New System.Windows.Forms.Label()
        Me.TexHorasTH54 = New System.Windows.Forms.Label()
        Me.TexHorasTH41 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TexHorasEC16
        '
        Me.TexHorasEC16.AutoSize = True
        Me.TexHorasEC16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasEC16.ForeColor = System.Drawing.Color.White
        Me.TexHorasEC16.Location = New System.Drawing.Point(663, 454)
        Me.TexHorasEC16.Name = "TexHorasEC16"
        Me.TexHorasEC16.Size = New System.Drawing.Size(166, 19)
        Me.TexHorasEC16.TabIndex = 1208
        Me.TexHorasEC16.Text = "Horas Trabajo EC-16"
        '
        'ValorHorasEC05
        '
        Me.ValorHorasEC05.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasEC05.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasEC05.DecimalPosition = 0
        Me.ValorHorasEC05.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasEC05.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorHorasEC05.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasEC05.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasEC05.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasEC05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasEC05.KeypadMaxValue = 0R
        Me.ValorHorasEC05.KeypadMinValue = 0R
        Me.ValorHorasEC05.KeypadScaleFactor = 1.0R
        Me.ValorHorasEC05.KeypadText = Nothing
        Me.ValorHorasEC05.KeypadWidth = 300
        Me.ValorHorasEC05.Location = New System.Drawing.Point(860, 405)
        Me.ValorHorasEC05.Name = "ValorHorasEC05"
        Me.ValorHorasEC05.NumberOfDigits = 5
        Me.ValorHorasEC05.PLCAddressKeypad = ""
        Me.ValorHorasEC05.PLCAddressText = ""
        Me.ValorHorasEC05.PLCAddressValue = CType(resources.GetObject("ValorHorasEC05.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasEC05.PLCAddressVisible = ""
        Me.ValorHorasEC05.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasEC05.ShowOffSegments = True
        Me.ValorHorasEC05.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasEC05.TabIndex = 1207
        Me.ValorHorasEC05.Value = 0R
        '
        'UniOpcAlmacenamiento
        '
        Me.UniOpcAlmacenamiento.DisableSubscriptions = False
        Me.UniOpcAlmacenamiento.OPCGroup = ""
        Me.UniOpcAlmacenamiento.OPCServer = "UniOPC.Server.1"
        Me.UniOpcAlmacenamiento.OPCServerPath = "opcda://localhost"
        Me.UniOpcAlmacenamiento.OPCTopic = Nothing
        Me.UniOpcAlmacenamiento.PollRateOverride = 500
        Me.UniOpcAlmacenamiento.SynchronizingObject = Me
        '
        'ValorHorasTH104
        '
        Me.ValorHorasTH104.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH104.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH104.DecimalPosition = 0
        Me.ValorHorasTH104.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH104.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasTH104.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH104.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH104.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH104.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH104.KeypadMaxValue = 0R
        Me.ValorHorasTH104.KeypadMinValue = 0R
        Me.ValorHorasTH104.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH104.KeypadText = Nothing
        Me.ValorHorasTH104.KeypadWidth = 300
        Me.ValorHorasTH104.Location = New System.Drawing.Point(860, 358)
        Me.ValorHorasTH104.Name = "ValorHorasTH104"
        Me.ValorHorasTH104.NumberOfDigits = 5
        Me.ValorHorasTH104.PLCAddressKeypad = ""
        Me.ValorHorasTH104.PLCAddressText = ""
        Me.ValorHorasTH104.PLCAddressValue = CType(resources.GetObject("ValorHorasTH104.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH104.PLCAddressVisible = ""
        Me.ValorHorasTH104.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH104.ShowOffSegments = True
        Me.ValorHorasTH104.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH104.TabIndex = 1205
        Me.ValorHorasTH104.Value = 0R
        '
        'ValorHorasEC04
        '
        Me.ValorHorasEC04.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasEC04.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasEC04.DecimalPosition = 0
        Me.ValorHorasEC04.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasEC04.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasEC04.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasEC04.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasEC04.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasEC04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasEC04.KeypadMaxValue = 0R
        Me.ValorHorasEC04.KeypadMinValue = 0R
        Me.ValorHorasEC04.KeypadScaleFactor = 1.0R
        Me.ValorHorasEC04.KeypadText = Nothing
        Me.ValorHorasEC04.KeypadWidth = 300
        Me.ValorHorasEC04.Location = New System.Drawing.Point(864, 265)
        Me.ValorHorasEC04.Name = "ValorHorasEC04"
        Me.ValorHorasEC04.NumberOfDigits = 5
        Me.ValorHorasEC04.PLCAddressKeypad = ""
        Me.ValorHorasEC04.PLCAddressText = ""
        Me.ValorHorasEC04.PLCAddressValue = CType(resources.GetObject("ValorHorasEC04.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasEC04.PLCAddressVisible = ""
        Me.ValorHorasEC04.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasEC04.ShowOffSegments = True
        Me.ValorHorasEC04.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasEC04.TabIndex = 1202
        Me.ValorHorasEC04.Value = 0R
        '
        'ValorHorasTH103
        '
        Me.ValorHorasTH103.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH103.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH103.DecimalPosition = 0
        Me.ValorHorasTH103.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH103.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorHorasTH103.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH103.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH103.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH103.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH103.KeypadMaxValue = 0R
        Me.ValorHorasTH103.KeypadMinValue = 0R
        Me.ValorHorasTH103.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH103.KeypadText = Nothing
        Me.ValorHorasTH103.KeypadWidth = 300
        Me.ValorHorasTH103.Location = New System.Drawing.Point(860, 311)
        Me.ValorHorasTH103.Name = "ValorHorasTH103"
        Me.ValorHorasTH103.NumberOfDigits = 5
        Me.ValorHorasTH103.PLCAddressKeypad = ""
        Me.ValorHorasTH103.PLCAddressText = ""
        Me.ValorHorasTH103.PLCAddressValue = CType(resources.GetObject("ValorHorasTH103.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH103.PLCAddressVisible = ""
        Me.ValorHorasTH103.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH103.ShowOffSegments = True
        Me.ValorHorasTH103.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH103.TabIndex = 1203
        Me.ValorHorasTH103.Value = 0R
        '
        'ValorHorasEC16
        '
        Me.ValorHorasEC16.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasEC16.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasEC16.DecimalPosition = 0
        Me.ValorHorasEC16.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasEC16.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasEC16.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasEC16.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasEC16.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasEC16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasEC16.KeypadMaxValue = 0R
        Me.ValorHorasEC16.KeypadMinValue = 0R
        Me.ValorHorasEC16.KeypadScaleFactor = 1.0R
        Me.ValorHorasEC16.KeypadText = Nothing
        Me.ValorHorasEC16.KeypadWidth = 300
        Me.ValorHorasEC16.Location = New System.Drawing.Point(860, 452)
        Me.ValorHorasEC16.Name = "ValorHorasEC16"
        Me.ValorHorasEC16.NumberOfDigits = 5
        Me.ValorHorasEC16.PLCAddressKeypad = ""
        Me.ValorHorasEC16.PLCAddressText = ""
        Me.ValorHorasEC16.PLCAddressValue = CType(resources.GetObject("ValorHorasEC16.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasEC16.PLCAddressVisible = ""
        Me.ValorHorasEC16.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasEC16.ShowOffSegments = True
        Me.ValorHorasEC16.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasEC16.TabIndex = 1209
        Me.ValorHorasEC16.Value = 0R
        '
        'TexHorasEC05
        '
        Me.TexHorasEC05.AutoSize = True
        Me.TexHorasEC05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasEC05.ForeColor = System.Drawing.Color.Blue
        Me.TexHorasEC05.Location = New System.Drawing.Point(667, 407)
        Me.TexHorasEC05.Name = "TexHorasEC05"
        Me.TexHorasEC05.Size = New System.Drawing.Size(166, 19)
        Me.TexHorasEC05.TabIndex = 1206
        Me.TexHorasEC05.Text = "Horas Trabajo EC-05"
        '
        'TexHorasTH104
        '
        Me.TexHorasTH104.AutoSize = True
        Me.TexHorasTH104.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH104.ForeColor = System.Drawing.Color.White
        Me.TexHorasTH104.Location = New System.Drawing.Point(663, 360)
        Me.TexHorasTH104.Name = "TexHorasTH104"
        Me.TexHorasTH104.Size = New System.Drawing.Size(174, 19)
        Me.TexHorasTH104.TabIndex = 1204
        Me.TexHorasTH104.Text = "Horas Trabajo TH-104"
        '
        'TexHorasEC04
        '
        Me.TexHorasEC04.AutoSize = True
        Me.TexHorasEC04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasEC04.ForeColor = System.Drawing.Color.White
        Me.TexHorasEC04.Location = New System.Drawing.Point(667, 267)
        Me.TexHorasEC04.Name = "TexHorasEC04"
        Me.TexHorasEC04.Size = New System.Drawing.Size(166, 19)
        Me.TexHorasEC04.TabIndex = 1177
        Me.TexHorasEC04.Text = "Horas Trabajo EC-04"
        '
        'ValorHorasTH52
        '
        Me.ValorHorasTH52.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH52.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH52.DecimalPosition = 0
        Me.ValorHorasTH52.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH52.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasTH52.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH52.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH52.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH52.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH52.KeypadMaxValue = 0R
        Me.ValorHorasTH52.KeypadMinValue = 0R
        Me.ValorHorasTH52.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH52.KeypadText = Nothing
        Me.ValorHorasTH52.KeypadWidth = 300
        Me.ValorHorasTH52.Location = New System.Drawing.Point(423, 593)
        Me.ValorHorasTH52.Name = "ValorHorasTH52"
        Me.ValorHorasTH52.NumberOfDigits = 5
        Me.ValorHorasTH52.PLCAddressKeypad = ""
        Me.ValorHorasTH52.PLCAddressText = ""
        Me.ValorHorasTH52.PLCAddressValue = CType(resources.GetObject("ValorHorasTH52.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH52.PLCAddressVisible = ""
        Me.ValorHorasTH52.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH52.ShowOffSegments = True
        Me.ValorHorasTH52.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH52.TabIndex = 1200
        Me.ValorHorasTH52.Value = 0R
        '
        'ValorHorasTH41
        '
        Me.ValorHorasTH41.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH41.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH41.DecimalPosition = 0
        Me.ValorHorasTH41.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH41.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorHorasTH41.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH41.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH41.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH41.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH41.KeypadMaxValue = 0R
        Me.ValorHorasTH41.KeypadMinValue = 0R
        Me.ValorHorasTH41.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH41.KeypadText = Nothing
        Me.ValorHorasTH41.KeypadWidth = 300
        Me.ValorHorasTH41.Location = New System.Drawing.Point(864, 219)
        Me.ValorHorasTH41.Name = "ValorHorasTH41"
        Me.ValorHorasTH41.NumberOfDigits = 5
        Me.ValorHorasTH41.PLCAddressKeypad = ""
        Me.ValorHorasTH41.PLCAddressText = ""
        Me.ValorHorasTH41.PLCAddressValue = CType(resources.GetObject("ValorHorasTH41.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH41.PLCAddressVisible = ""
        Me.ValorHorasTH41.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH41.ShowOffSegments = True
        Me.ValorHorasTH41.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH41.TabIndex = 1201
        Me.ValorHorasTH41.Value = 0R
        '
        'ValorHorasTH53
        '
        Me.ValorHorasTH53.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH53.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH53.DecimalPosition = 0
        Me.ValorHorasTH53.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH53.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasTH53.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH53.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH53.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH53.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH53.KeypadMaxValue = 0R
        Me.ValorHorasTH53.KeypadMinValue = 0R
        Me.ValorHorasTH53.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH53.KeypadText = Nothing
        Me.ValorHorasTH53.KeypadWidth = 300
        Me.ValorHorasTH53.Location = New System.Drawing.Point(423, 499)
        Me.ValorHorasTH53.Name = "ValorHorasTH53"
        Me.ValorHorasTH53.NumberOfDigits = 5
        Me.ValorHorasTH53.PLCAddressKeypad = ""
        Me.ValorHorasTH53.PLCAddressText = ""
        Me.ValorHorasTH53.PLCAddressValue = CType(resources.GetObject("ValorHorasTH53.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH53.PLCAddressVisible = ""
        Me.ValorHorasTH53.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH53.ShowOffSegments = True
        Me.ValorHorasTH53.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH53.TabIndex = 1198
        Me.ValorHorasTH53.Value = 0R
        '
        'ValorHorasTH54
        '
        Me.ValorHorasTH54.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH54.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH54.DecimalPosition = 0
        Me.ValorHorasTH54.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH54.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorHorasTH54.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH54.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH54.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH54.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH54.KeypadMaxValue = 0R
        Me.ValorHorasTH54.KeypadMinValue = 0R
        Me.ValorHorasTH54.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH54.KeypadText = Nothing
        Me.ValorHorasTH54.KeypadWidth = 300
        Me.ValorHorasTH54.Location = New System.Drawing.Point(423, 546)
        Me.ValorHorasTH54.Name = "ValorHorasTH54"
        Me.ValorHorasTH54.NumberOfDigits = 5
        Me.ValorHorasTH54.PLCAddressKeypad = ""
        Me.ValorHorasTH54.PLCAddressText = ""
        Me.ValorHorasTH54.PLCAddressValue = CType(resources.GetObject("ValorHorasTH54.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH54.PLCAddressVisible = ""
        Me.ValorHorasTH54.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH54.ShowOffSegments = True
        Me.ValorHorasTH54.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH54.TabIndex = 1199
        Me.ValorHorasTH54.Value = 0R
        '
        'ValorHorasTH48
        '
        Me.ValorHorasTH48.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH48.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH48.DecimalPosition = 0
        Me.ValorHorasTH48.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH48.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasTH48.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH48.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH48.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH48.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH48.KeypadMaxValue = 0R
        Me.ValorHorasTH48.KeypadMinValue = 0R
        Me.ValorHorasTH48.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH48.KeypadText = Nothing
        Me.ValorHorasTH48.KeypadWidth = 300
        Me.ValorHorasTH48.Location = New System.Drawing.Point(423, 405)
        Me.ValorHorasTH48.Name = "ValorHorasTH48"
        Me.ValorHorasTH48.NumberOfDigits = 5
        Me.ValorHorasTH48.PLCAddressKeypad = ""
        Me.ValorHorasTH48.PLCAddressText = ""
        Me.ValorHorasTH48.PLCAddressValue = CType(resources.GetObject("ValorHorasTH48.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH48.PLCAddressVisible = ""
        Me.ValorHorasTH48.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH48.ShowOffSegments = True
        Me.ValorHorasTH48.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH48.TabIndex = 1196
        Me.ValorHorasTH48.Value = 0R
        '
        'SevenSegment26
        '
        Me.SevenSegment26.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment26.ComComponent = Me.UniOpcAlmacenamiento
        Me.SevenSegment26.DecimalPosition = 0
        Me.SevenSegment26.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment26.ForeColorInLimits = System.Drawing.Color.Blue
        Me.SevenSegment26.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment26.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment26.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment26.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment26.KeypadMaxValue = 0R
        Me.SevenSegment26.KeypadMinValue = 0R
        Me.SevenSegment26.KeypadScaleFactor = 1.0R
        Me.SevenSegment26.KeypadText = Nothing
        Me.SevenSegment26.KeypadWidth = 300
        Me.SevenSegment26.Location = New System.Drawing.Point(423, 452)
        Me.SevenSegment26.Name = "SevenSegment26"
        Me.SevenSegment26.NumberOfDigits = 5
        Me.SevenSegment26.PLCAddressKeypad = ""
        Me.SevenSegment26.PLCAddressText = ""
        Me.SevenSegment26.PLCAddressValue = CType(resources.GetObject("SevenSegment26.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment26.PLCAddressVisible = ""
        Me.SevenSegment26.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment26.ShowOffSegments = True
        Me.SevenSegment26.Size = New System.Drawing.Size(90, 23)
        Me.SevenSegment26.TabIndex = 1197
        Me.SevenSegment26.Value = 0R
        '
        'ValorHorasTH42
        '
        Me.ValorHorasTH42.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH42.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH42.DecimalPosition = 0
        Me.ValorHorasTH42.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH42.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasTH42.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH42.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH42.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH42.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH42.KeypadMaxValue = 0R
        Me.ValorHorasTH42.KeypadMinValue = 0R
        Me.ValorHorasTH42.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH42.KeypadText = Nothing
        Me.ValorHorasTH42.KeypadWidth = 300
        Me.ValorHorasTH42.Location = New System.Drawing.Point(423, 311)
        Me.ValorHorasTH42.Name = "ValorHorasTH42"
        Me.ValorHorasTH42.NumberOfDigits = 5
        Me.ValorHorasTH42.PLCAddressKeypad = ""
        Me.ValorHorasTH42.PLCAddressText = ""
        Me.ValorHorasTH42.PLCAddressValue = CType(resources.GetObject("ValorHorasTH42.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH42.PLCAddressVisible = ""
        Me.ValorHorasTH42.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH42.ShowOffSegments = True
        Me.ValorHorasTH42.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH42.TabIndex = 1194
        Me.ValorHorasTH42.Value = 0R
        '
        'ValorHorasTH43
        '
        Me.ValorHorasTH43.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH43.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH43.DecimalPosition = 0
        Me.ValorHorasTH43.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH43.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorHorasTH43.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH43.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH43.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH43.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH43.KeypadMaxValue = 0R
        Me.ValorHorasTH43.KeypadMinValue = 0R
        Me.ValorHorasTH43.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH43.KeypadText = Nothing
        Me.ValorHorasTH43.KeypadWidth = 300
        Me.ValorHorasTH43.Location = New System.Drawing.Point(423, 358)
        Me.ValorHorasTH43.Name = "ValorHorasTH43"
        Me.ValorHorasTH43.NumberOfDigits = 5
        Me.ValorHorasTH43.PLCAddressKeypad = ""
        Me.ValorHorasTH43.PLCAddressText = ""
        Me.ValorHorasTH43.PLCAddressValue = CType(resources.GetObject("ValorHorasTH43.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH43.PLCAddressVisible = ""
        Me.ValorHorasTH43.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH43.ShowOffSegments = True
        Me.ValorHorasTH43.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH43.TabIndex = 1195
        Me.ValorHorasTH43.Value = 0R
        '
        'TexHorasTH52
        '
        Me.TexHorasTH52.AutoSize = True
        Me.TexHorasTH52.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH52.ForeColor = System.Drawing.Color.White
        Me.TexHorasTH52.Location = New System.Drawing.Point(227, 595)
        Me.TexHorasTH52.Name = "TexHorasTH52"
        Me.TexHorasTH52.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH52.TabIndex = 1176
        Me.TexHorasTH52.Text = "Horas Trabajo TH-52"
        '
        'TexHorasTH53
        '
        Me.TexHorasTH53.AutoSize = True
        Me.TexHorasTH53.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH53.ForeColor = System.Drawing.Color.White
        Me.TexHorasTH53.Location = New System.Drawing.Point(227, 501)
        Me.TexHorasTH53.Name = "TexHorasTH53"
        Me.TexHorasTH53.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH53.TabIndex = 1175
        Me.TexHorasTH53.Text = "Horas Trabajo TH-53"
        '
        'TexHorasTH48
        '
        Me.TexHorasTH48.AutoSize = True
        Me.TexHorasTH48.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH48.ForeColor = System.Drawing.Color.White
        Me.TexHorasTH48.Location = New System.Drawing.Point(227, 407)
        Me.TexHorasTH48.Name = "TexHorasTH48"
        Me.TexHorasTH48.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH48.TabIndex = 1174
        Me.TexHorasTH48.Text = "Horas Trabajo TH-48"
        '
        'TexHorasTH42
        '
        Me.TexHorasTH42.AutoSize = True
        Me.TexHorasTH42.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH42.ForeColor = System.Drawing.Color.White
        Me.TexHorasTH42.Location = New System.Drawing.Point(227, 313)
        Me.TexHorasTH42.Name = "TexHorasTH42"
        Me.TexHorasTH42.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH42.TabIndex = 1173
        Me.TexHorasTH42.Text = "Horas Trabajo TH-42"
        '
        'ValorHorasTH51
        '
        Me.ValorHorasTH51.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH51.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH51.DecimalPosition = 0
        Me.ValorHorasTH51.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH51.ForeColorInLimits = System.Drawing.Color.White
        Me.ValorHorasTH51.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH51.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH51.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH51.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH51.KeypadMaxValue = 0R
        Me.ValorHorasTH51.KeypadMinValue = 0R
        Me.ValorHorasTH51.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH51.KeypadText = Nothing
        Me.ValorHorasTH51.KeypadWidth = 300
        Me.ValorHorasTH51.Location = New System.Drawing.Point(423, 219)
        Me.ValorHorasTH51.Name = "ValorHorasTH51"
        Me.ValorHorasTH51.NumberOfDigits = 5
        Me.ValorHorasTH51.PLCAddressKeypad = ""
        Me.ValorHorasTH51.PLCAddressText = ""
        Me.ValorHorasTH51.PLCAddressValue = CType(resources.GetObject("ValorHorasTH51.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH51.PLCAddressVisible = ""
        Me.ValorHorasTH51.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH51.ShowOffSegments = True
        Me.ValorHorasTH51.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH51.TabIndex = 1192
        Me.ValorHorasTH51.Value = 0R
        '
        'ValorHorasTH40
        '
        Me.ValorHorasTH40.BackColor = System.Drawing.Color.Transparent
        Me.ValorHorasTH40.ComComponent = Me.UniOpcAlmacenamiento
        Me.ValorHorasTH40.DecimalPosition = 0
        Me.ValorHorasTH40.ForecolorHighLimitValue = 999999.0R
        Me.ValorHorasTH40.ForeColorInLimits = System.Drawing.Color.Blue
        Me.ValorHorasTH40.ForecolorLowLimitValue = -999999.0R
        Me.ValorHorasTH40.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.ValorHorasTH40.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.ValorHorasTH40.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ValorHorasTH40.KeypadMaxValue = 0R
        Me.ValorHorasTH40.KeypadMinValue = 0R
        Me.ValorHorasTH40.KeypadScaleFactor = 1.0R
        Me.ValorHorasTH40.KeypadText = Nothing
        Me.ValorHorasTH40.KeypadWidth = 300
        Me.ValorHorasTH40.Location = New System.Drawing.Point(423, 265)
        Me.ValorHorasTH40.Name = "ValorHorasTH40"
        Me.ValorHorasTH40.NumberOfDigits = 5
        Me.ValorHorasTH40.PLCAddressKeypad = ""
        Me.ValorHorasTH40.PLCAddressText = ""
        Me.ValorHorasTH40.PLCAddressValue = CType(resources.GetObject("ValorHorasTH40.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ValorHorasTH40.PLCAddressVisible = ""
        Me.ValorHorasTH40.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ValorHorasTH40.ShowOffSegments = True
        Me.ValorHorasTH40.Size = New System.Drawing.Size(90, 23)
        Me.ValorHorasTH40.TabIndex = 1193
        Me.ValorHorasTH40.Value = 0R
        '
        'TexHorasTH51
        '
        Me.TexHorasTH51.AutoSize = True
        Me.TexHorasTH51.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH51.ForeColor = System.Drawing.Color.White
        Me.TexHorasTH51.Location = New System.Drawing.Point(227, 221)
        Me.TexHorasTH51.Name = "TexHorasTH51"
        Me.TexHorasTH51.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH51.TabIndex = 1172
        Me.TexHorasTH51.Text = "Horas Trabajo TH-51"
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
        Me.BCF_RegresarH1.TabIndex = 1191
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BP_ResetDatosH1Tiemp
        '
        Me.BP_ResetDatosH1Tiemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ResetDatosH1Tiemp.ComComponent = Me.UniOpcAlmacenamiento
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
        Me.BP_ResetDatosH1Tiemp.TabIndex = 1190
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
        Me.BCF_MenúP_TiemposH1.TabIndex = 1189
        Me.BCF_MenúP_TiemposH1.Text = "Menú Principal"
        Me.BCF_MenúP_TiemposH1.UseVisualStyleBackColor = False
        '
        'TexHorasTH103
        '
        Me.TexHorasTH103.AutoSize = True
        Me.TexHorasTH103.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH103.ForeColor = System.Drawing.Color.Blue
        Me.TexHorasTH103.Location = New System.Drawing.Point(667, 313)
        Me.TexHorasTH103.Name = "TexHorasTH103"
        Me.TexHorasTH103.Size = New System.Drawing.Size(174, 19)
        Me.TexHorasTH103.TabIndex = 1186
        Me.TexHorasTH103.Text = "Horas Trabajo TH-103"
        '
        'Tex1HorasH1Tiemp
        '
        Me.Tex1HorasH1Tiemp.AutoSize = True
        Me.Tex1HorasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1HorasH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1HorasH1Tiemp.Location = New System.Drawing.Point(405, 183)
        Me.Tex1HorasH1Tiemp.Name = "Tex1HorasH1Tiemp"
        Me.Tex1HorasH1Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex1HorasH1Tiemp.TabIndex = 1180
        Me.Tex1HorasH1Tiemp.Text = "Horas de Trabajo"
        Me.Tex1HorasH1Tiemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexTiemposH1
        '
        Me.TexTiemposH1.AutoSize = True
        Me.TexTiemposH1.BackColor = System.Drawing.Color.DimGray
        Me.TexTiemposH1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTiemposH1.ForeColor = System.Drawing.Color.White
        Me.TexTiemposH1.Location = New System.Drawing.Point(441, 86)
        Me.TexTiemposH1.Name = "TexTiemposH1"
        Me.TexTiemposH1.Size = New System.Drawing.Size(446, 34)
        Me.TexTiemposH1.TabIndex = 1178
        Me.TexTiemposH1.Text = "Horas Trabajo Almacenamiento"
        '
        'Tex2HorasH1Tiemp
        '
        Me.Tex2HorasH1Tiemp.AutoSize = True
        Me.Tex2HorasH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex2HorasH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex2HorasH1Tiemp.Location = New System.Drawing.Point(844, 183)
        Me.Tex2HorasH1Tiemp.Name = "Tex2HorasH1Tiemp"
        Me.Tex2HorasH1Tiemp.Size = New System.Drawing.Size(139, 19)
        Me.Tex2HorasH1Tiemp.TabIndex = 1185
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
        Me.Tex2EquiH1Tiemp.TabIndex = 1184
        Me.Tex2EquiH1Tiemp.Text = "Equipo"
        '
        'TexHorasTH50
        '
        Me.TexHorasTH50.AutoSize = True
        Me.TexHorasTH50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH50.ForeColor = System.Drawing.Color.Blue
        Me.TexHorasTH50.Location = New System.Drawing.Point(227, 454)
        Me.TexHorasTH50.Name = "TexHorasTH50"
        Me.TexHorasTH50.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH50.TabIndex = 1183
        Me.TexHorasTH50.Text = "Horas Trabajo TH-50"
        '
        'TexHorasTH43
        '
        Me.TexHorasTH43.AutoSize = True
        Me.TexHorasTH43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH43.ForeColor = System.Drawing.Color.Blue
        Me.TexHorasTH43.Location = New System.Drawing.Point(227, 360)
        Me.TexHorasTH43.Name = "TexHorasTH43"
        Me.TexHorasTH43.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH43.TabIndex = 1182
        Me.TexHorasTH43.Text = "Horas Trabajo TH-43"
        '
        'TexTiempoTH40
        '
        Me.TexTiempoTH40.AutoSize = True
        Me.TexTiempoTH40.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTiempoTH40.ForeColor = System.Drawing.Color.Blue
        Me.TexTiempoTH40.Location = New System.Drawing.Point(227, 267)
        Me.TexTiempoTH40.Name = "TexTiempoTH40"
        Me.TexTiempoTH40.Size = New System.Drawing.Size(175, 19)
        Me.TexTiempoTH40.TabIndex = 1181
        Me.TexTiempoTH40.Text = "Horas Trabajoo TH-40"
        '
        'Tex1EquiH1Tiemp
        '
        Me.Tex1EquiH1Tiemp.AutoSize = True
        Me.Tex1EquiH1Tiemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex1EquiH1Tiemp.ForeColor = System.Drawing.Color.Aqua
        Me.Tex1EquiH1Tiemp.Location = New System.Drawing.Point(227, 183)
        Me.Tex1EquiH1Tiemp.Name = "Tex1EquiH1Tiemp"
        Me.Tex1EquiH1Tiemp.Size = New System.Drawing.Size(64, 19)
        Me.Tex1EquiH1Tiemp.TabIndex = 1179
        Me.Tex1EquiH1Tiemp.Text = "Equipo"
        '
        'TexHorasTH54
        '
        Me.TexHorasTH54.AutoSize = True
        Me.TexHorasTH54.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH54.ForeColor = System.Drawing.Color.Blue
        Me.TexHorasTH54.Location = New System.Drawing.Point(227, 548)
        Me.TexHorasTH54.Name = "TexHorasTH54"
        Me.TexHorasTH54.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH54.TabIndex = 1188
        Me.TexHorasTH54.Text = "Horas Trabajo TH-54"
        '
        'TexHorasTH41
        '
        Me.TexHorasTH41.AutoSize = True
        Me.TexHorasTH41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexHorasTH41.ForeColor = System.Drawing.Color.Blue
        Me.TexHorasTH41.Location = New System.Drawing.Point(668, 221)
        Me.TexHorasTH41.Name = "TexHorasTH41"
        Me.TexHorasTH41.Size = New System.Drawing.Size(165, 19)
        Me.TexHorasTH41.TabIndex = 1187
        Me.TexHorasTH41.Text = "Horas Trabajo TH-41"
        '
        'Tiempos_Almacenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.TexHorasEC16)
        Me.Controls.Add(Me.ValorHorasEC05)
        Me.Controls.Add(Me.ValorHorasTH104)
        Me.Controls.Add(Me.ValorHorasEC04)
        Me.Controls.Add(Me.ValorHorasTH103)
        Me.Controls.Add(Me.ValorHorasEC16)
        Me.Controls.Add(Me.TexHorasEC05)
        Me.Controls.Add(Me.TexHorasTH104)
        Me.Controls.Add(Me.TexHorasEC04)
        Me.Controls.Add(Me.ValorHorasTH52)
        Me.Controls.Add(Me.ValorHorasTH41)
        Me.Controls.Add(Me.ValorHorasTH53)
        Me.Controls.Add(Me.ValorHorasTH54)
        Me.Controls.Add(Me.ValorHorasTH48)
        Me.Controls.Add(Me.SevenSegment26)
        Me.Controls.Add(Me.ValorHorasTH42)
        Me.Controls.Add(Me.ValorHorasTH43)
        Me.Controls.Add(Me.TexHorasTH52)
        Me.Controls.Add(Me.TexHorasTH53)
        Me.Controls.Add(Me.TexHorasTH48)
        Me.Controls.Add(Me.TexHorasTH42)
        Me.Controls.Add(Me.ValorHorasTH51)
        Me.Controls.Add(Me.ValorHorasTH40)
        Me.Controls.Add(Me.TexHorasTH51)
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BP_ResetDatosH1Tiemp)
        Me.Controls.Add(Me.BCF_MenúP_TiemposH1)
        Me.Controls.Add(Me.TexHorasTH103)
        Me.Controls.Add(Me.Tex1HorasH1Tiemp)
        Me.Controls.Add(Me.TexTiemposH1)
        Me.Controls.Add(Me.Tex2HorasH1Tiemp)
        Me.Controls.Add(Me.Tex2EquiH1Tiemp)
        Me.Controls.Add(Me.TexHorasTH50)
        Me.Controls.Add(Me.TexHorasTH43)
        Me.Controls.Add(Me.TexTiempoTH40)
        Me.Controls.Add(Me.Tex1EquiH1Tiemp)
        Me.Controls.Add(Me.TexHorasTH54)
        Me.Controls.Add(Me.TexHorasTH41)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Tiempos_Almacenamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TexHorasEC16 As Label
    Friend WithEvents ValorHorasEC05 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents UniOpcAlmacenamiento As AdvancedHMIDrivers.OpcDaCom
    Friend WithEvents ValorHorasTH104 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasEC04 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH103 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasEC16 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexHorasEC05 As Label
    Friend WithEvents TexHorasTH104 As Label
    Friend WithEvents TexHorasEC04 As Label
    Friend WithEvents ValorHorasTH52 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH41 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH53 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH54 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH48 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment26 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH42 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH43 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexHorasTH52 As Label
    Friend WithEvents TexHorasTH53 As Label
    Friend WithEvents TexHorasTH48 As Label
    Friend WithEvents TexHorasTH42 As Label
    Friend WithEvents ValorHorasTH51 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ValorHorasTH40 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents TexHorasTH51 As Label
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BP_ResetDatosH1Tiemp As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_MenúP_TiemposH1 As FormChangeButton
    Friend WithEvents TexHorasTH103 As Label
    Friend WithEvents Tex1HorasH1Tiemp As Label
    Friend WithEvents TexTiemposH1 As Label
    Friend WithEvents Tex2HorasH1Tiemp As Label
    Friend WithEvents Tex2EquiH1Tiemp As Label
    Friend WithEvents TexHorasTH50 As Label
    Friend WithEvents TexHorasTH43 As Label
    Friend WithEvents TexTiempoTH40 As Label
    Friend WithEvents Tex1EquiH1Tiemp As Label
    Friend WithEvents TexHorasTH54 As Label
    Friend WithEvents TexHorasTH41 As Label
End Class
