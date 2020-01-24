<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horarios))
        Me.HorariosHorno2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.HorariosHorno1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.HorariosHorno3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.DigitalPanelMeter6 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter5 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter4 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton3 = New AdvancedHMIControls.BasicButton()
        Me.OrientedTextLabel33 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel34 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel35 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel36 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel37 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel38 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel39 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel40 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel41 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel42 = New AdvancedHMIControls.OrientedTextLabel()
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        Me.OrientedTextLabel17 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel18 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel19 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel20 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel21 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel22 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel23 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel24 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel25 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel26 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel27 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment213 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment214 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel28 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment215 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment216 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel29 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment217 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment218 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel30 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment219 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment220 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel31 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment221 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment222 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel32 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment223 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment224 = New AdvancedHMIControls.SevenSegment2()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.OrientedTextLabel15 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel16 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel13 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel14 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel12 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel11 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel10 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel9 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel8 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel7 = New AdvancedHMIControls.OrientedTextLabel()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.OrientedTextLabel5 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment29 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment210 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel6 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment211 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment212 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel4 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment27 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment28 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel3 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment25 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment26 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel2 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment23 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment24 = New AdvancedHMIControls.SevenSegment2()
        Me.OrientedTextLabel1 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SevenSegment22 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment21 = New AdvancedHMIControls.SevenSegment2()
        CType(Me.HorariosHorno2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosHorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosHorno3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HorariosHorno2
        '
        Me.HorariosHorno2.CIPConnectionSize = 508
        Me.HorariosHorno2.DisableMultiServiceRequest = False
        Me.HorariosHorno2.DisableSubscriptions = False
        Me.HorariosHorno2.IniFileName = ""
        Me.HorariosHorno2.IniFileSection = Nothing
        Me.HorariosHorno2.IPAddress = "10.1.108.18"
        Me.HorariosHorno2.PollRateOverride = 500
        Me.HorariosHorno2.Port = 44818
        Me.HorariosHorno2.ProcessorSlot = 0
        Me.HorariosHorno2.RoutePath = Nothing
        Me.HorariosHorno2.Timeout = 4000
        '
        'HorariosHorno1
        '
        Me.HorariosHorno1.CIPConnectionSize = 508
        Me.HorariosHorno1.DisableMultiServiceRequest = False
        Me.HorariosHorno1.DisableSubscriptions = False
        Me.HorariosHorno1.IniFileName = ""
        Me.HorariosHorno1.IniFileSection = Nothing
        Me.HorariosHorno1.IPAddress = "10.1.108.20"
        Me.HorariosHorno1.PollRateOverride = 500
        Me.HorariosHorno1.Port = 44818
        Me.HorariosHorno1.ProcessorSlot = 0
        Me.HorariosHorno1.RoutePath = Nothing
        Me.HorariosHorno1.Timeout = 4000
        '
        'HorariosHorno3
        '
        Me.HorariosHorno3.DisableSubscriptions = False
        Me.HorariosHorno3.IniFileName = ""
        Me.HorariosHorno3.IniFileSection = Nothing
        Me.HorariosHorno3.IPAddress = "10.1.108.8"
        Me.HorariosHorno3.MaxReadGroupSize = 20
        Me.HorariosHorno3.PollRateOverride = 500
        Me.HorariosHorno3.SwapBytes = True
        Me.HorariosHorno3.SwapWords = False
        Me.HorariosHorno3.TcpipPort = CType(20257US, UShort)
        Me.HorariosHorno3.TimeOut = 3000
        Me.HorariosHorno3.UnitId = CType(13, Byte)
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = Nothing
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(750, 667)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1324
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
        Me.BCF_MenúP_Cascarilla.Location = New System.Drawing.Point(420, 667)
        Me.BCF_MenúP_Cascarilla.Name = "BCF_MenúP_Cascarilla"
        Me.BCF_MenúP_Cascarilla.Passcode = Nothing
        Me.BCF_MenúP_Cascarilla.PasswordChar = False
        Me.BCF_MenúP_Cascarilla.PLCAddressVisible = ""
        Me.BCF_MenúP_Cascarilla.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_Cascarilla.TabIndex = 1323
        Me.BCF_MenúP_Cascarilla.Text = "Menú Principal"
        Me.BCF_MenúP_Cascarilla.UseVisualStyleBackColor = False
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.HorariosHorno2
        Me.DigitalPanelMeter6.DecimalPosition = 2
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(907, 632)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 4
        Me.DigitalPanelMeter6.PLCAddressKeypad = "40303"
        Me.DigitalPanelMeter6.PLCAddressValue = "40303"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(93, 48)
        Me.DigitalPanelMeter6.TabIndex = 1322
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter5
        '
        Me.DigitalPanelMeter5.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter5.ComComponent = Me.HorariosHorno2
        Me.DigitalPanelMeter5.DecimalPosition = 2
        Me.DigitalPanelMeter5.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter5.KeypadMaxValue = 0R
        Me.DigitalPanelMeter5.KeypadMinValue = 0R
        Me.DigitalPanelMeter5.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter5.KeypadText = Nothing
        Me.DigitalPanelMeter5.KeypadWidth = 300
        Me.DigitalPanelMeter5.Location = New System.Drawing.Point(907, 577)
        Me.DigitalPanelMeter5.Name = "DigitalPanelMeter5"
        Me.DigitalPanelMeter5.NumberOfDigits = 4
        Me.DigitalPanelMeter5.PLCAddressKeypad = "40302"
        Me.DigitalPanelMeter5.PLCAddressValue = "40302"
        Me.DigitalPanelMeter5.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.Size = New System.Drawing.Size(93, 48)
        Me.DigitalPanelMeter5.TabIndex = 1321
        Me.DigitalPanelMeter5.Value = 0R
        Me.DigitalPanelMeter5.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter4
        '
        Me.DigitalPanelMeter4.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter4.ComComponent = Me.HorariosHorno2
        Me.DigitalPanelMeter4.DecimalPosition = 2
        Me.DigitalPanelMeter4.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter4.KeypadMaxValue = 0R
        Me.DigitalPanelMeter4.KeypadMinValue = 0R
        Me.DigitalPanelMeter4.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter4.KeypadText = Nothing
        Me.DigitalPanelMeter4.KeypadWidth = 300
        Me.DigitalPanelMeter4.Location = New System.Drawing.Point(907, 434)
        Me.DigitalPanelMeter4.Name = "DigitalPanelMeter4"
        Me.DigitalPanelMeter4.NumberOfDigits = 4
        Me.DigitalPanelMeter4.PLCAddressKeypad = "40301"
        Me.DigitalPanelMeter4.PLCAddressValue = "40301"
        Me.DigitalPanelMeter4.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.Size = New System.Drawing.Size(93, 48)
        Me.DigitalPanelMeter4.TabIndex = 1320
        Me.DigitalPanelMeter4.Value = 0R
        Me.DigitalPanelMeter4.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter3
        '
        Me.DigitalPanelMeter3.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter3.ComComponent = Me.HorariosHorno2
        Me.DigitalPanelMeter3.DecimalPosition = 2
        Me.DigitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter3.KeypadMaxValue = 0R
        Me.DigitalPanelMeter3.KeypadMinValue = 0R
        Me.DigitalPanelMeter3.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter3.KeypadText = Nothing
        Me.DigitalPanelMeter3.KeypadWidth = 300
        Me.DigitalPanelMeter3.Location = New System.Drawing.Point(907, 380)
        Me.DigitalPanelMeter3.Name = "DigitalPanelMeter3"
        Me.DigitalPanelMeter3.NumberOfDigits = 4
        Me.DigitalPanelMeter3.PLCAddressKeypad = "40300"
        Me.DigitalPanelMeter3.PLCAddressValue = "40300"
        Me.DigitalPanelMeter3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.Size = New System.Drawing.Size(93, 48)
        Me.DigitalPanelMeter3.TabIndex = 1319
        Me.DigitalPanelMeter3.Value = 0R
        Me.DigitalPanelMeter3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.HorariosHorno2
        Me.DigitalPanelMeter2.DecimalPosition = 2
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(907, 196)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 4
        Me.DigitalPanelMeter2.PLCAddressKeypad = "40299"
        Me.DigitalPanelMeter2.PLCAddressValue = "40299"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(93, 48)
        Me.DigitalPanelMeter2.TabIndex = 1318
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.Color.Snow
        Me.BasicButton3.ComComponent = Me.HorariosHorno2
        Me.BasicButton3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton3.ForeColor = System.Drawing.Color.Black
        Me.BasicButton3.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Olive
        Me.BasicButton3.Location = New System.Drawing.Point(896, 272)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton3.PLCAddressClick = "10044"
        Me.BasicButton3.PLCAddressHighlightX = "10044"
        Me.BasicButton3.PLCAddressSelectTextAlternate = "10044"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(195, 47)
        Me.BasicButton3.TabIndex = 1317
        Me.BasicButton3.Text = "Activar Hora Pico"
        Me.BasicButton3.TextAlternate = "Desactivar Hora Pico"
        Me.BasicButton3.UseVisualStyleBackColor = False
        Me.BasicButton3.ValueToWrite = 0
        '
        'OrientedTextLabel33
        '
        Me.OrientedTextLabel33.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel33.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel33.Location = New System.Drawing.Point(1035, 639)
        Me.OrientedTextLabel33.Name = "OrientedTextLabel33"
        Me.OrientedTextLabel33.RotationAngle = 0R
        Me.OrientedTextLabel33.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel33.TabIndex = 1316
        Me.OrientedTextLabel33.Text = "Final"
        Me.OrientedTextLabel33.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel33.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel34
        '
        Me.OrientedTextLabel34.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel34.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel34.Location = New System.Drawing.Point(1035, 585)
        Me.OrientedTextLabel34.Name = "OrientedTextLabel34"
        Me.OrientedTextLabel34.RotationAngle = 0R
        Me.OrientedTextLabel34.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel34.TabIndex = 1315
        Me.OrientedTextLabel34.Text = "Inicio"
        Me.OrientedTextLabel34.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel34.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel35
        '
        Me.OrientedTextLabel35.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel35.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel35.Location = New System.Drawing.Point(1035, 438)
        Me.OrientedTextLabel35.Name = "OrientedTextLabel35"
        Me.OrientedTextLabel35.RotationAngle = 0R
        Me.OrientedTextLabel35.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel35.TabIndex = 1314
        Me.OrientedTextLabel35.Text = "Final"
        Me.OrientedTextLabel35.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel35.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel36
        '
        Me.OrientedTextLabel36.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel36.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel36.Location = New System.Drawing.Point(1035, 384)
        Me.OrientedTextLabel36.Name = "OrientedTextLabel36"
        Me.OrientedTextLabel36.RotationAngle = 0R
        Me.OrientedTextLabel36.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel36.TabIndex = 1313
        Me.OrientedTextLabel36.Text = "Inicio"
        Me.OrientedTextLabel36.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel36.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel37
        '
        Me.OrientedTextLabel37.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel37.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel37.Location = New System.Drawing.Point(1035, 204)
        Me.OrientedTextLabel37.Name = "OrientedTextLabel37"
        Me.OrientedTextLabel37.RotationAngle = 0R
        Me.OrientedTextLabel37.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel37.TabIndex = 1312
        Me.OrientedTextLabel37.Text = "Final"
        Me.OrientedTextLabel37.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel37.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel38
        '
        Me.OrientedTextLabel38.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel38.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel38.Location = New System.Drawing.Point(1035, 150)
        Me.OrientedTextLabel38.Name = "OrientedTextLabel38"
        Me.OrientedTextLabel38.RotationAngle = 0R
        Me.OrientedTextLabel38.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel38.TabIndex = 1311
        Me.OrientedTextLabel38.Text = "Inicio"
        Me.OrientedTextLabel38.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel38.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel39
        '
        Me.OrientedTextLabel39.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel39.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel39.Location = New System.Drawing.Point(892, 533)
        Me.OrientedTextLabel39.Name = "OrientedTextLabel39"
        Me.OrientedTextLabel39.RotationAngle = 0R
        Me.OrientedTextLabel39.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel39.TabIndex = 1310
        Me.OrientedTextLabel39.Text = "Horario Nocturno"
        Me.OrientedTextLabel39.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel39.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel40
        '
        Me.OrientedTextLabel40.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel40.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel40.Location = New System.Drawing.Point(892, 343)
        Me.OrientedTextLabel40.Name = "OrientedTextLabel40"
        Me.OrientedTextLabel40.RotationAngle = 0R
        Me.OrientedTextLabel40.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel40.TabIndex = 1309
        Me.OrientedTextLabel40.Text = "Hora Pico Tarde"
        Me.OrientedTextLabel40.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel40.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel41
        '
        Me.OrientedTextLabel41.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel41.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel41.Location = New System.Drawing.Point(892, 99)
        Me.OrientedTextLabel41.Name = "OrientedTextLabel41"
        Me.OrientedTextLabel41.RotationAngle = 0R
        Me.OrientedTextLabel41.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel41.TabIndex = 1308
        Me.OrientedTextLabel41.Text = "Hora Pico Mañana"
        Me.OrientedTextLabel41.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel41.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel42
        '
        Me.OrientedTextLabel42.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel42.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel42.Location = New System.Drawing.Point(912, 32)
        Me.OrientedTextLabel42.Name = "OrientedTextLabel42"
        Me.OrientedTextLabel42.RotationAngle = 0R
        Me.OrientedTextLabel42.Size = New System.Drawing.Size(117, 54)
        Me.OrientedTextLabel42.TabIndex = 1307
        Me.OrientedTextLabel42.Text = "Horno 3"
        Me.OrientedTextLabel42.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel42.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.Color.Snow
        Me.BasicButton2.ComComponent = Me.HorariosHorno2
        Me.BasicButton2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Olive
        Me.BasicButton2.Location = New System.Drawing.Point(569, 272)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton2.PLCAddressClick = "HORA_PICO_SELECCIONADA"
        Me.BasicButton2.PLCAddressSelectTextAlternate = "HORA_PICO_SELECCIONADA"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(195, 47)
        Me.BasicButton2.TabIndex = 1306
        Me.BasicButton2.Text = "Activar Hora Pico"
        Me.BasicButton2.TextAlternate = "Desactivar Hora Pico"
        Me.BasicButton2.UseVisualStyleBackColor = False
        Me.BasicButton2.ValueToWrite = 0
        '
        'OrientedTextLabel17
        '
        Me.OrientedTextLabel17.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel17.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel17.Location = New System.Drawing.Point(708, 639)
        Me.OrientedTextLabel17.Name = "OrientedTextLabel17"
        Me.OrientedTextLabel17.RotationAngle = 0R
        Me.OrientedTextLabel17.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel17.TabIndex = 1305
        Me.OrientedTextLabel17.Text = "Final"
        Me.OrientedTextLabel17.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel17.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel18
        '
        Me.OrientedTextLabel18.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel18.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel18.Location = New System.Drawing.Point(708, 585)
        Me.OrientedTextLabel18.Name = "OrientedTextLabel18"
        Me.OrientedTextLabel18.RotationAngle = 0R
        Me.OrientedTextLabel18.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel18.TabIndex = 1304
        Me.OrientedTextLabel18.Text = "Inicio"
        Me.OrientedTextLabel18.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel18.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel19
        '
        Me.OrientedTextLabel19.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel19.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel19.Location = New System.Drawing.Point(708, 438)
        Me.OrientedTextLabel19.Name = "OrientedTextLabel19"
        Me.OrientedTextLabel19.RotationAngle = 0R
        Me.OrientedTextLabel19.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel19.TabIndex = 1303
        Me.OrientedTextLabel19.Text = "Final"
        Me.OrientedTextLabel19.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel19.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel20
        '
        Me.OrientedTextLabel20.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel20.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel20.Location = New System.Drawing.Point(708, 384)
        Me.OrientedTextLabel20.Name = "OrientedTextLabel20"
        Me.OrientedTextLabel20.RotationAngle = 0R
        Me.OrientedTextLabel20.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel20.TabIndex = 1302
        Me.OrientedTextLabel20.Text = "Inicio"
        Me.OrientedTextLabel20.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel20.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel21
        '
        Me.OrientedTextLabel21.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel21.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel21.Location = New System.Drawing.Point(708, 204)
        Me.OrientedTextLabel21.Name = "OrientedTextLabel21"
        Me.OrientedTextLabel21.RotationAngle = 0R
        Me.OrientedTextLabel21.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel21.TabIndex = 1301
        Me.OrientedTextLabel21.Text = "Final"
        Me.OrientedTextLabel21.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel21.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel22
        '
        Me.OrientedTextLabel22.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel22.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel22.Location = New System.Drawing.Point(708, 150)
        Me.OrientedTextLabel22.Name = "OrientedTextLabel22"
        Me.OrientedTextLabel22.RotationAngle = 0R
        Me.OrientedTextLabel22.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel22.TabIndex = 1300
        Me.OrientedTextLabel22.Text = "Inicio"
        Me.OrientedTextLabel22.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel22.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel23
        '
        Me.OrientedTextLabel23.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel23.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel23.Location = New System.Drawing.Point(565, 533)
        Me.OrientedTextLabel23.Name = "OrientedTextLabel23"
        Me.OrientedTextLabel23.RotationAngle = 0R
        Me.OrientedTextLabel23.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel23.TabIndex = 1299
        Me.OrientedTextLabel23.Text = "Horario Nocturno"
        Me.OrientedTextLabel23.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel23.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel24
        '
        Me.OrientedTextLabel24.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel24.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel24.Location = New System.Drawing.Point(565, 343)
        Me.OrientedTextLabel24.Name = "OrientedTextLabel24"
        Me.OrientedTextLabel24.RotationAngle = 0R
        Me.OrientedTextLabel24.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel24.TabIndex = 1298
        Me.OrientedTextLabel24.Text = "Hora Pico Tarde"
        Me.OrientedTextLabel24.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel24.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel25
        '
        Me.OrientedTextLabel25.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel25.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel25.Location = New System.Drawing.Point(565, 99)
        Me.OrientedTextLabel25.Name = "OrientedTextLabel25"
        Me.OrientedTextLabel25.RotationAngle = 0R
        Me.OrientedTextLabel25.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel25.TabIndex = 1297
        Me.OrientedTextLabel25.Text = "Hora Pico Mañana"
        Me.OrientedTextLabel25.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel25.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel26
        '
        Me.OrientedTextLabel26.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel26.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel26.Location = New System.Drawing.Point(604, 32)
        Me.OrientedTextLabel26.Name = "OrientedTextLabel26"
        Me.OrientedTextLabel26.RotationAngle = 0R
        Me.OrientedTextLabel26.Size = New System.Drawing.Size(117, 54)
        Me.OrientedTextLabel26.TabIndex = 1296
        Me.OrientedTextLabel26.Text = "Horno 2"
        Me.OrientedTextLabel26.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel26.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel27
        '
        Me.OrientedTextLabel27.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel27.Location = New System.Drawing.Point(627, 644)
        Me.OrientedTextLabel27.Name = "OrientedTextLabel27"
        Me.OrientedTextLabel27.RotationAngle = 0R
        Me.OrientedTextLabel27.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel27.TabIndex = 1295
        Me.OrientedTextLabel27.Text = ":"
        Me.OrientedTextLabel27.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel27.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment213
        '
        Me.SevenSegment213.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment213.ComComponent = Me.HorariosHorno2
        Me.SevenSegment213.DecimalPosition = 0
        Me.SevenSegment213.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment213.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment213.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment213.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment213.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment213.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment213.KeypadMaxValue = 0R
        Me.SevenSegment213.KeypadMinValue = 0R
        Me.SevenSegment213.KeypadScaleFactor = 1.0R
        Me.SevenSegment213.KeypadText = Nothing
        Me.SevenSegment213.KeypadWidth = 300
        Me.SevenSegment213.Location = New System.Drawing.Point(653, 643)
        Me.SevenSegment213.Name = "SevenSegment213"
        Me.SevenSegment213.NumberOfDigits = 2
        Me.SevenSegment213.PLCAddressKeypad = ""
        Me.SevenSegment213.PLCAddressText = ""
        Me.SevenSegment213.PLCAddressValue = Nothing
        Me.SevenSegment213.PLCAddressVisible = ""
        Me.SevenSegment213.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment213.ShowOffSegments = True
        Me.SevenSegment213.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment213.TabIndex = 1294
        Me.SevenSegment213.Text = "SevenSegment213"
        Me.SevenSegment213.Value = 0R
        '
        'SevenSegment214
        '
        Me.SevenSegment214.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment214.ComComponent = Me.HorariosHorno2
        Me.SevenSegment214.DecimalPosition = 0
        Me.SevenSegment214.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment214.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment214.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment214.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment214.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment214.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment214.KeypadMaxValue = 0R
        Me.SevenSegment214.KeypadMinValue = 0R
        Me.SevenSegment214.KeypadScaleFactor = 1.0R
        Me.SevenSegment214.KeypadText = Nothing
        Me.SevenSegment214.KeypadWidth = 300
        Me.SevenSegment214.Location = New System.Drawing.Point(577, 643)
        Me.SevenSegment214.Name = "SevenSegment214"
        Me.SevenSegment214.NumberOfDigits = 2
        Me.SevenSegment214.PLCAddressKeypad = "HORA_NOCHE_TIEMPO2"
        Me.SevenSegment214.PLCAddressText = ""
        Me.SevenSegment214.PLCAddressValue = CType(resources.GetObject("SevenSegment214.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment214.PLCAddressVisible = ""
        Me.SevenSegment214.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment214.ShowOffSegments = True
        Me.SevenSegment214.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment214.TabIndex = 1293
        Me.SevenSegment214.Text = "SevenSegment214"
        Me.SevenSegment214.Value = 0R
        '
        'OrientedTextLabel28
        '
        Me.OrientedTextLabel28.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel28.Location = New System.Drawing.Point(627, 590)
        Me.OrientedTextLabel28.Name = "OrientedTextLabel28"
        Me.OrientedTextLabel28.RotationAngle = 0R
        Me.OrientedTextLabel28.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel28.TabIndex = 1292
        Me.OrientedTextLabel28.Text = ":"
        Me.OrientedTextLabel28.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel28.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment215
        '
        Me.SevenSegment215.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment215.ComComponent = Me.HorariosHorno2
        Me.SevenSegment215.DecimalPosition = 0
        Me.SevenSegment215.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment215.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment215.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment215.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment215.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment215.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment215.KeypadMaxValue = 0R
        Me.SevenSegment215.KeypadMinValue = 0R
        Me.SevenSegment215.KeypadScaleFactor = 1.0R
        Me.SevenSegment215.KeypadText = Nothing
        Me.SevenSegment215.KeypadWidth = 300
        Me.SevenSegment215.Location = New System.Drawing.Point(653, 589)
        Me.SevenSegment215.Name = "SevenSegment215"
        Me.SevenSegment215.NumberOfDigits = 2
        Me.SevenSegment215.PLCAddressKeypad = ""
        Me.SevenSegment215.PLCAddressText = ""
        Me.SevenSegment215.PLCAddressValue = Nothing
        Me.SevenSegment215.PLCAddressVisible = ""
        Me.SevenSegment215.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment215.ShowOffSegments = True
        Me.SevenSegment215.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment215.TabIndex = 1291
        Me.SevenSegment215.Text = "SevenSegment215"
        Me.SevenSegment215.Value = 0R
        '
        'SevenSegment216
        '
        Me.SevenSegment216.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment216.ComComponent = Me.HorariosHorno2
        Me.SevenSegment216.DecimalPosition = 0
        Me.SevenSegment216.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment216.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment216.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment216.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment216.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment216.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment216.KeypadMaxValue = 0R
        Me.SevenSegment216.KeypadMinValue = 0R
        Me.SevenSegment216.KeypadScaleFactor = 1.0R
        Me.SevenSegment216.KeypadText = Nothing
        Me.SevenSegment216.KeypadWidth = 300
        Me.SevenSegment216.Location = New System.Drawing.Point(577, 589)
        Me.SevenSegment216.Name = "SevenSegment216"
        Me.SevenSegment216.NumberOfDigits = 2
        Me.SevenSegment216.PLCAddressKeypad = "HORA_NOCHE_TIEMPO1"
        Me.SevenSegment216.PLCAddressText = ""
        Me.SevenSegment216.PLCAddressValue = CType(resources.GetObject("SevenSegment216.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment216.PLCAddressVisible = ""
        Me.SevenSegment216.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment216.ShowOffSegments = True
        Me.SevenSegment216.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment216.TabIndex = 1290
        Me.SevenSegment216.Text = "SevenSegment216"
        Me.SevenSegment216.Value = 0R
        '
        'OrientedTextLabel29
        '
        Me.OrientedTextLabel29.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel29.Location = New System.Drawing.Point(627, 442)
        Me.OrientedTextLabel29.Name = "OrientedTextLabel29"
        Me.OrientedTextLabel29.RotationAngle = 0R
        Me.OrientedTextLabel29.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel29.TabIndex = 1289
        Me.OrientedTextLabel29.Text = ":"
        Me.OrientedTextLabel29.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel29.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment217
        '
        Me.SevenSegment217.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment217.ComComponent = Me.HorariosHorno2
        Me.SevenSegment217.DecimalPosition = 0
        Me.SevenSegment217.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment217.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment217.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment217.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment217.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment217.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment217.KeypadMaxValue = 0R
        Me.SevenSegment217.KeypadMinValue = 0R
        Me.SevenSegment217.KeypadScaleFactor = 1.0R
        Me.SevenSegment217.KeypadText = Nothing
        Me.SevenSegment217.KeypadWidth = 300
        Me.SevenSegment217.Location = New System.Drawing.Point(653, 441)
        Me.SevenSegment217.Name = "SevenSegment217"
        Me.SevenSegment217.NumberOfDigits = 2
        Me.SevenSegment217.PLCAddressKeypad = "HORA_PICO_TIEMPO2_3"
        Me.SevenSegment217.PLCAddressText = ""
        Me.SevenSegment217.PLCAddressValue = CType(resources.GetObject("SevenSegment217.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment217.PLCAddressVisible = ""
        Me.SevenSegment217.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment217.ShowOffSegments = True
        Me.SevenSegment217.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment217.TabIndex = 1288
        Me.SevenSegment217.Text = "SevenSegment217"
        Me.SevenSegment217.Value = 0R
        '
        'SevenSegment218
        '
        Me.SevenSegment218.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment218.ComComponent = Me.HorariosHorno2
        Me.SevenSegment218.DecimalPosition = 0
        Me.SevenSegment218.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment218.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment218.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment218.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment218.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment218.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment218.KeypadMaxValue = 0R
        Me.SevenSegment218.KeypadMinValue = 0R
        Me.SevenSegment218.KeypadScaleFactor = 1.0R
        Me.SevenSegment218.KeypadText = Nothing
        Me.SevenSegment218.KeypadWidth = 300
        Me.SevenSegment218.Location = New System.Drawing.Point(577, 441)
        Me.SevenSegment218.Name = "SevenSegment218"
        Me.SevenSegment218.NumberOfDigits = 2
        Me.SevenSegment218.PLCAddressKeypad = "HORA_PICO_TIEMPO1_3"
        Me.SevenSegment218.PLCAddressText = ""
        Me.SevenSegment218.PLCAddressValue = CType(resources.GetObject("SevenSegment218.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment218.PLCAddressVisible = ""
        Me.SevenSegment218.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment218.ShowOffSegments = True
        Me.SevenSegment218.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment218.TabIndex = 1287
        Me.SevenSegment218.Text = "SevenSegment218"
        Me.SevenSegment218.Value = 0R
        '
        'OrientedTextLabel30
        '
        Me.OrientedTextLabel30.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel30.Location = New System.Drawing.Point(627, 388)
        Me.OrientedTextLabel30.Name = "OrientedTextLabel30"
        Me.OrientedTextLabel30.RotationAngle = 0R
        Me.OrientedTextLabel30.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel30.TabIndex = 1286
        Me.OrientedTextLabel30.Text = ":"
        Me.OrientedTextLabel30.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel30.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment219
        '
        Me.SevenSegment219.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment219.ComComponent = Me.HorariosHorno2
        Me.SevenSegment219.DecimalPosition = 0
        Me.SevenSegment219.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment219.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment219.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment219.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment219.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment219.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment219.KeypadMaxValue = 0R
        Me.SevenSegment219.KeypadMinValue = 0R
        Me.SevenSegment219.KeypadScaleFactor = 1.0R
        Me.SevenSegment219.KeypadText = Nothing
        Me.SevenSegment219.KeypadWidth = 300
        Me.SevenSegment219.Location = New System.Drawing.Point(653, 387)
        Me.SevenSegment219.Name = "SevenSegment219"
        Me.SevenSegment219.NumberOfDigits = 2
        Me.SevenSegment219.PLCAddressKeypad = "HORA_PICO_TIEMPO2_1"
        Me.SevenSegment219.PLCAddressText = ""
        Me.SevenSegment219.PLCAddressValue = CType(resources.GetObject("SevenSegment219.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment219.PLCAddressVisible = ""
        Me.SevenSegment219.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment219.ShowOffSegments = True
        Me.SevenSegment219.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment219.TabIndex = 1285
        Me.SevenSegment219.Text = "SevenSegment219"
        Me.SevenSegment219.Value = 0R
        '
        'SevenSegment220
        '
        Me.SevenSegment220.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment220.ComComponent = Me.HorariosHorno2
        Me.SevenSegment220.DecimalPosition = 0
        Me.SevenSegment220.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment220.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment220.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment220.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment220.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment220.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment220.KeypadMaxValue = 0R
        Me.SevenSegment220.KeypadMinValue = 0R
        Me.SevenSegment220.KeypadScaleFactor = 1.0R
        Me.SevenSegment220.KeypadText = Nothing
        Me.SevenSegment220.KeypadWidth = 300
        Me.SevenSegment220.Location = New System.Drawing.Point(577, 387)
        Me.SevenSegment220.Name = "SevenSegment220"
        Me.SevenSegment220.NumberOfDigits = 2
        Me.SevenSegment220.PLCAddressKeypad = "HORA_PICO_TIEMPO1_1"
        Me.SevenSegment220.PLCAddressText = ""
        Me.SevenSegment220.PLCAddressValue = CType(resources.GetObject("SevenSegment220.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment220.PLCAddressVisible = ""
        Me.SevenSegment220.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment220.ShowOffSegments = True
        Me.SevenSegment220.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment220.TabIndex = 1284
        Me.SevenSegment220.Text = "SevenSegment220"
        Me.SevenSegment220.Value = 0R
        '
        'OrientedTextLabel31
        '
        Me.OrientedTextLabel31.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel31.Location = New System.Drawing.Point(627, 209)
        Me.OrientedTextLabel31.Name = "OrientedTextLabel31"
        Me.OrientedTextLabel31.RotationAngle = 0R
        Me.OrientedTextLabel31.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel31.TabIndex = 1283
        Me.OrientedTextLabel31.Text = ":"
        Me.OrientedTextLabel31.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel31.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment221
        '
        Me.SevenSegment221.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment221.ComComponent = Me.HorariosHorno2
        Me.SevenSegment221.DecimalPosition = 0
        Me.SevenSegment221.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment221.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment221.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment221.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment221.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment221.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment221.KeypadMaxValue = 0R
        Me.SevenSegment221.KeypadMinValue = 0R
        Me.SevenSegment221.KeypadScaleFactor = 1.0R
        Me.SevenSegment221.KeypadText = Nothing
        Me.SevenSegment221.KeypadWidth = 300
        Me.SevenSegment221.Location = New System.Drawing.Point(653, 208)
        Me.SevenSegment221.Name = "SevenSegment221"
        Me.SevenSegment221.NumberOfDigits = 2
        Me.SevenSegment221.PLCAddressKeypad = "HORA_PICO_TIEMPO2_2"
        Me.SevenSegment221.PLCAddressText = ""
        Me.SevenSegment221.PLCAddressValue = CType(resources.GetObject("SevenSegment221.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment221.PLCAddressVisible = ""
        Me.SevenSegment221.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment221.ShowOffSegments = True
        Me.SevenSegment221.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment221.TabIndex = 1282
        Me.SevenSegment221.Text = "SevenSegment221"
        Me.SevenSegment221.Value = 0R
        '
        'SevenSegment222
        '
        Me.SevenSegment222.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment222.ComComponent = Me.HorariosHorno2
        Me.SevenSegment222.DecimalPosition = 0
        Me.SevenSegment222.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment222.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment222.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment222.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment222.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment222.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment222.KeypadMaxValue = 0R
        Me.SevenSegment222.KeypadMinValue = 0R
        Me.SevenSegment222.KeypadScaleFactor = 1.0R
        Me.SevenSegment222.KeypadText = Nothing
        Me.SevenSegment222.KeypadWidth = 300
        Me.SevenSegment222.Location = New System.Drawing.Point(577, 208)
        Me.SevenSegment222.Name = "SevenSegment222"
        Me.SevenSegment222.NumberOfDigits = 2
        Me.SevenSegment222.PLCAddressKeypad = "HORA_PICO_TIEMPO1_2"
        Me.SevenSegment222.PLCAddressText = ""
        Me.SevenSegment222.PLCAddressValue = CType(resources.GetObject("SevenSegment222.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment222.PLCAddressVisible = ""
        Me.SevenSegment222.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment222.ShowOffSegments = True
        Me.SevenSegment222.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment222.TabIndex = 1281
        Me.SevenSegment222.Text = "SevenSegment222"
        Me.SevenSegment222.Value = 0R
        '
        'OrientedTextLabel32
        '
        Me.OrientedTextLabel32.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel32.Location = New System.Drawing.Point(627, 151)
        Me.OrientedTextLabel32.Name = "OrientedTextLabel32"
        Me.OrientedTextLabel32.RotationAngle = 0R
        Me.OrientedTextLabel32.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel32.TabIndex = 1280
        Me.OrientedTextLabel32.Text = ":"
        Me.OrientedTextLabel32.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel32.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment223
        '
        Me.SevenSegment223.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment223.ComComponent = Me.HorariosHorno2
        Me.SevenSegment223.DecimalPosition = 0
        Me.SevenSegment223.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment223.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment223.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment223.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment223.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment223.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment223.KeypadMaxValue = 0R
        Me.SevenSegment223.KeypadMinValue = 0R
        Me.SevenSegment223.KeypadScaleFactor = 1.0R
        Me.SevenSegment223.KeypadText = Nothing
        Me.SevenSegment223.KeypadWidth = 300
        Me.SevenSegment223.Location = New System.Drawing.Point(653, 150)
        Me.SevenSegment223.Name = "SevenSegment223"
        Me.SevenSegment223.NumberOfDigits = 2
        Me.SevenSegment223.PLCAddressKeypad = "HORA_PICO_TIEMPO3"
        Me.SevenSegment223.PLCAddressText = ""
        Me.SevenSegment223.PLCAddressValue = CType(resources.GetObject("SevenSegment223.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment223.PLCAddressVisible = ""
        Me.SevenSegment223.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment223.ShowOffSegments = True
        Me.SevenSegment223.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment223.TabIndex = 1279
        Me.SevenSegment223.Text = "SevenSegment223"
        Me.SevenSegment223.Value = 0R
        '
        'SevenSegment224
        '
        Me.SevenSegment224.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment224.ComComponent = Me.HorariosHorno2
        Me.SevenSegment224.DecimalPosition = 0
        Me.SevenSegment224.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment224.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment224.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment224.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment224.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment224.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment224.KeypadMaxValue = 0R
        Me.SevenSegment224.KeypadMinValue = 0R
        Me.SevenSegment224.KeypadScaleFactor = 1.0R
        Me.SevenSegment224.KeypadText = Nothing
        Me.SevenSegment224.KeypadWidth = 300
        Me.SevenSegment224.Location = New System.Drawing.Point(577, 150)
        Me.SevenSegment224.Name = "SevenSegment224"
        Me.SevenSegment224.NumberOfDigits = 2
        Me.SevenSegment224.PLCAddressKeypad = "HORA_PICO_TIEMPO1"
        Me.SevenSegment224.PLCAddressText = ""
        Me.SevenSegment224.PLCAddressValue = CType(resources.GetObject("SevenSegment224.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment224.PLCAddressVisible = ""
        Me.SevenSegment224.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment224.ShowOffSegments = True
        Me.SevenSegment224.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment224.TabIndex = 1278
        Me.SevenSegment224.Text = "SevenSegment224"
        Me.SevenSegment224.Value = 0R
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Snow
        Me.BasicButton1.ComComponent = Me.HorariosHorno1
        Me.BasicButton1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Olive
        Me.BasicButton1.Location = New System.Drawing.Point(247, 271)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton1.PLCAddressClick = "HORA_PICO_SELECCIONADA"
        Me.BasicButton1.PLCAddressSelectTextAlternate = "HORA_PICO_SELECCIONADA"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(195, 47)
        Me.BasicButton1.TabIndex = 1277
        Me.BasicButton1.Text = "Activar Hora Pico"
        Me.BasicButton1.TextAlternate = "Desactivar Hora Pico"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'OrientedTextLabel15
        '
        Me.OrientedTextLabel15.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel15.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel15.Location = New System.Drawing.Point(386, 638)
        Me.OrientedTextLabel15.Name = "OrientedTextLabel15"
        Me.OrientedTextLabel15.RotationAngle = 0R
        Me.OrientedTextLabel15.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel15.TabIndex = 1276
        Me.OrientedTextLabel15.Text = "Final"
        Me.OrientedTextLabel15.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel15.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel16
        '
        Me.OrientedTextLabel16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel16.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel16.Location = New System.Drawing.Point(386, 584)
        Me.OrientedTextLabel16.Name = "OrientedTextLabel16"
        Me.OrientedTextLabel16.RotationAngle = 0R
        Me.OrientedTextLabel16.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel16.TabIndex = 1275
        Me.OrientedTextLabel16.Text = "Inicio"
        Me.OrientedTextLabel16.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel16.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel13
        '
        Me.OrientedTextLabel13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel13.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel13.Location = New System.Drawing.Point(386, 437)
        Me.OrientedTextLabel13.Name = "OrientedTextLabel13"
        Me.OrientedTextLabel13.RotationAngle = 0R
        Me.OrientedTextLabel13.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel13.TabIndex = 1274
        Me.OrientedTextLabel13.Text = "Final"
        Me.OrientedTextLabel13.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel13.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel14
        '
        Me.OrientedTextLabel14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel14.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel14.Location = New System.Drawing.Point(386, 383)
        Me.OrientedTextLabel14.Name = "OrientedTextLabel14"
        Me.OrientedTextLabel14.RotationAngle = 0R
        Me.OrientedTextLabel14.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel14.TabIndex = 1273
        Me.OrientedTextLabel14.Text = "Inicio"
        Me.OrientedTextLabel14.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel14.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel12
        '
        Me.OrientedTextLabel12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel12.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel12.Location = New System.Drawing.Point(386, 203)
        Me.OrientedTextLabel12.Name = "OrientedTextLabel12"
        Me.OrientedTextLabel12.RotationAngle = 0R
        Me.OrientedTextLabel12.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel12.TabIndex = 1272
        Me.OrientedTextLabel12.Text = "Final"
        Me.OrientedTextLabel12.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel12.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel11
        '
        Me.OrientedTextLabel11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel11.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel11.Location = New System.Drawing.Point(386, 149)
        Me.OrientedTextLabel11.Name = "OrientedTextLabel11"
        Me.OrientedTextLabel11.RotationAngle = 0R
        Me.OrientedTextLabel11.Size = New System.Drawing.Size(71, 41)
        Me.OrientedTextLabel11.TabIndex = 1271
        Me.OrientedTextLabel11.Text = "Inicio"
        Me.OrientedTextLabel11.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel11.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel10
        '
        Me.OrientedTextLabel10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel10.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel10.Location = New System.Drawing.Point(243, 532)
        Me.OrientedTextLabel10.Name = "OrientedTextLabel10"
        Me.OrientedTextLabel10.RotationAngle = 0R
        Me.OrientedTextLabel10.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel10.TabIndex = 1270
        Me.OrientedTextLabel10.Text = "Horario Nocturno"
        Me.OrientedTextLabel10.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel10.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel9
        '
        Me.OrientedTextLabel9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel9.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel9.Location = New System.Drawing.Point(243, 342)
        Me.OrientedTextLabel9.Name = "OrientedTextLabel9"
        Me.OrientedTextLabel9.RotationAngle = 0R
        Me.OrientedTextLabel9.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel9.TabIndex = 1269
        Me.OrientedTextLabel9.Text = "Hora Pico Tarde"
        Me.OrientedTextLabel9.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel9.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel8
        '
        Me.OrientedTextLabel8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel8.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel8.Location = New System.Drawing.Point(243, 98)
        Me.OrientedTextLabel8.Name = "OrientedTextLabel8"
        Me.OrientedTextLabel8.RotationAngle = 0R
        Me.OrientedTextLabel8.Size = New System.Drawing.Size(199, 41)
        Me.OrientedTextLabel8.TabIndex = 1268
        Me.OrientedTextLabel8.Text = "Hora Pico Mañana"
        Me.OrientedTextLabel8.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel8.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel7
        '
        Me.OrientedTextLabel7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel7.ForeColor = System.Drawing.Color.Blue
        Me.OrientedTextLabel7.Location = New System.Drawing.Point(263, 31)
        Me.OrientedTextLabel7.Name = "OrientedTextLabel7"
        Me.OrientedTextLabel7.RotationAngle = 0R
        Me.OrientedTextLabel7.Size = New System.Drawing.Size(117, 54)
        Me.OrientedTextLabel7.TabIndex = 1267
        Me.OrientedTextLabel7.Text = "Horno 1"
        Me.OrientedTextLabel7.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel7.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.HorariosHorno2
        Me.DigitalPanelMeter1.DecimalPosition = 2
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 0.01R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(907, 143)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 4
        Me.DigitalPanelMeter1.PLCAddressKeypad = "40298"
        Me.DigitalPanelMeter1.PLCAddressValue = "40298"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(93, 48)
        Me.DigitalPanelMeter1.TabIndex = 1266
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'OrientedTextLabel5
        '
        Me.OrientedTextLabel5.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel5.Location = New System.Drawing.Point(305, 643)
        Me.OrientedTextLabel5.Name = "OrientedTextLabel5"
        Me.OrientedTextLabel5.RotationAngle = 0R
        Me.OrientedTextLabel5.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel5.TabIndex = 1265
        Me.OrientedTextLabel5.Text = ":"
        Me.OrientedTextLabel5.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel5.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment29
        '
        Me.SevenSegment29.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment29.ComComponent = Me.HorariosHorno1
        Me.SevenSegment29.DecimalPosition = 0
        Me.SevenSegment29.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment29.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment29.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment29.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment29.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment29.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment29.KeypadMaxValue = 0R
        Me.SevenSegment29.KeypadMinValue = 0R
        Me.SevenSegment29.KeypadScaleFactor = 1.0R
        Me.SevenSegment29.KeypadText = Nothing
        Me.SevenSegment29.KeypadWidth = 300
        Me.SevenSegment29.Location = New System.Drawing.Point(331, 642)
        Me.SevenSegment29.Name = "SevenSegment29"
        Me.SevenSegment29.NumberOfDigits = 2
        Me.SevenSegment29.PLCAddressKeypad = ""
        Me.SevenSegment29.PLCAddressText = ""
        Me.SevenSegment29.PLCAddressValue = Nothing
        Me.SevenSegment29.PLCAddressVisible = ""
        Me.SevenSegment29.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment29.ShowOffSegments = True
        Me.SevenSegment29.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment29.TabIndex = 1264
        Me.SevenSegment29.Text = "SevenSegment29"
        Me.SevenSegment29.Value = 0R
        '
        'SevenSegment210
        '
        Me.SevenSegment210.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment210.ComComponent = Me.HorariosHorno1
        Me.SevenSegment210.DecimalPosition = 0
        Me.SevenSegment210.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment210.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment210.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment210.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment210.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment210.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment210.KeypadMaxValue = 0R
        Me.SevenSegment210.KeypadMinValue = 0R
        Me.SevenSegment210.KeypadScaleFactor = 1.0R
        Me.SevenSegment210.KeypadText = Nothing
        Me.SevenSegment210.KeypadWidth = 300
        Me.SevenSegment210.Location = New System.Drawing.Point(255, 642)
        Me.SevenSegment210.Name = "SevenSegment210"
        Me.SevenSegment210.NumberOfDigits = 2
        Me.SevenSegment210.PLCAddressKeypad = "HORA_NOCHE_TIEMPO2"
        Me.SevenSegment210.PLCAddressText = ""
        Me.SevenSegment210.PLCAddressValue = CType(resources.GetObject("SevenSegment210.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment210.PLCAddressVisible = ""
        Me.SevenSegment210.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment210.ShowOffSegments = True
        Me.SevenSegment210.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment210.TabIndex = 1263
        Me.SevenSegment210.Text = "SevenSegment210"
        Me.SevenSegment210.Value = 0R
        '
        'OrientedTextLabel6
        '
        Me.OrientedTextLabel6.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel6.Location = New System.Drawing.Point(305, 589)
        Me.OrientedTextLabel6.Name = "OrientedTextLabel6"
        Me.OrientedTextLabel6.RotationAngle = 0R
        Me.OrientedTextLabel6.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel6.TabIndex = 1262
        Me.OrientedTextLabel6.Text = ":"
        Me.OrientedTextLabel6.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel6.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment211
        '
        Me.SevenSegment211.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment211.ComComponent = Me.HorariosHorno1
        Me.SevenSegment211.DecimalPosition = 0
        Me.SevenSegment211.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment211.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment211.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment211.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment211.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment211.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment211.KeypadMaxValue = 0R
        Me.SevenSegment211.KeypadMinValue = 0R
        Me.SevenSegment211.KeypadScaleFactor = 1.0R
        Me.SevenSegment211.KeypadText = Nothing
        Me.SevenSegment211.KeypadWidth = 300
        Me.SevenSegment211.Location = New System.Drawing.Point(331, 588)
        Me.SevenSegment211.Name = "SevenSegment211"
        Me.SevenSegment211.NumberOfDigits = 2
        Me.SevenSegment211.PLCAddressKeypad = ""
        Me.SevenSegment211.PLCAddressText = ""
        Me.SevenSegment211.PLCAddressValue = Nothing
        Me.SevenSegment211.PLCAddressVisible = ""
        Me.SevenSegment211.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment211.ShowOffSegments = True
        Me.SevenSegment211.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment211.TabIndex = 1261
        Me.SevenSegment211.Text = "SevenSegment211"
        Me.SevenSegment211.Value = 0R
        '
        'SevenSegment212
        '
        Me.SevenSegment212.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment212.ComComponent = Me.HorariosHorno1
        Me.SevenSegment212.DecimalPosition = 0
        Me.SevenSegment212.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment212.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment212.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment212.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment212.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment212.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment212.KeypadMaxValue = 0R
        Me.SevenSegment212.KeypadMinValue = 0R
        Me.SevenSegment212.KeypadScaleFactor = 1.0R
        Me.SevenSegment212.KeypadText = Nothing
        Me.SevenSegment212.KeypadWidth = 300
        Me.SevenSegment212.Location = New System.Drawing.Point(255, 588)
        Me.SevenSegment212.Name = "SevenSegment212"
        Me.SevenSegment212.NumberOfDigits = 2
        Me.SevenSegment212.PLCAddressKeypad = "HORA_NOCHE_TIEMPO1"
        Me.SevenSegment212.PLCAddressText = ""
        Me.SevenSegment212.PLCAddressValue = CType(resources.GetObject("SevenSegment212.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment212.PLCAddressVisible = ""
        Me.SevenSegment212.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment212.ShowOffSegments = True
        Me.SevenSegment212.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment212.TabIndex = 1260
        Me.SevenSegment212.Text = "SevenSegment212"
        Me.SevenSegment212.Value = 0R
        '
        'OrientedTextLabel4
        '
        Me.OrientedTextLabel4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel4.Location = New System.Drawing.Point(305, 441)
        Me.OrientedTextLabel4.Name = "OrientedTextLabel4"
        Me.OrientedTextLabel4.RotationAngle = 0R
        Me.OrientedTextLabel4.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel4.TabIndex = 1259
        Me.OrientedTextLabel4.Text = ":"
        Me.OrientedTextLabel4.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel4.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment27
        '
        Me.SevenSegment27.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment27.ComComponent = Me.HorariosHorno1
        Me.SevenSegment27.DecimalPosition = 0
        Me.SevenSegment27.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment27.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment27.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment27.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment27.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment27.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment27.KeypadMaxValue = 0R
        Me.SevenSegment27.KeypadMinValue = 0R
        Me.SevenSegment27.KeypadScaleFactor = 1.0R
        Me.SevenSegment27.KeypadText = Nothing
        Me.SevenSegment27.KeypadWidth = 300
        Me.SevenSegment27.Location = New System.Drawing.Point(331, 440)
        Me.SevenSegment27.Name = "SevenSegment27"
        Me.SevenSegment27.NumberOfDigits = 2
        Me.SevenSegment27.PLCAddressKeypad = "HORA_PICO_TIEMPO2_3"
        Me.SevenSegment27.PLCAddressText = ""
        Me.SevenSegment27.PLCAddressValue = CType(resources.GetObject("SevenSegment27.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment27.PLCAddressVisible = ""
        Me.SevenSegment27.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment27.ShowOffSegments = True
        Me.SevenSegment27.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment27.TabIndex = 1258
        Me.SevenSegment27.Text = "SevenSegment27"
        Me.SevenSegment27.Value = 0R
        '
        'SevenSegment28
        '
        Me.SevenSegment28.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment28.ComComponent = Me.HorariosHorno1
        Me.SevenSegment28.DecimalPosition = 0
        Me.SevenSegment28.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment28.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment28.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment28.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment28.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment28.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment28.KeypadMaxValue = 0R
        Me.SevenSegment28.KeypadMinValue = 0R
        Me.SevenSegment28.KeypadScaleFactor = 1.0R
        Me.SevenSegment28.KeypadText = Nothing
        Me.SevenSegment28.KeypadWidth = 300
        Me.SevenSegment28.Location = New System.Drawing.Point(255, 440)
        Me.SevenSegment28.Name = "SevenSegment28"
        Me.SevenSegment28.NumberOfDigits = 2
        Me.SevenSegment28.PLCAddressKeypad = "HORA_PICO_TIEMPO1_3"
        Me.SevenSegment28.PLCAddressText = ""
        Me.SevenSegment28.PLCAddressValue = CType(resources.GetObject("SevenSegment28.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment28.PLCAddressVisible = ""
        Me.SevenSegment28.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment28.ShowOffSegments = True
        Me.SevenSegment28.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment28.TabIndex = 1257
        Me.SevenSegment28.Text = "SevenSegment28"
        Me.SevenSegment28.Value = 0R
        '
        'OrientedTextLabel3
        '
        Me.OrientedTextLabel3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel3.Location = New System.Drawing.Point(305, 387)
        Me.OrientedTextLabel3.Name = "OrientedTextLabel3"
        Me.OrientedTextLabel3.RotationAngle = 0R
        Me.OrientedTextLabel3.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel3.TabIndex = 1256
        Me.OrientedTextLabel3.Text = ":"
        Me.OrientedTextLabel3.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel3.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment25
        '
        Me.SevenSegment25.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment25.ComComponent = Me.HorariosHorno1
        Me.SevenSegment25.DecimalPosition = 0
        Me.SevenSegment25.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment25.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment25.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment25.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment25.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment25.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment25.KeypadMaxValue = 0R
        Me.SevenSegment25.KeypadMinValue = 0R
        Me.SevenSegment25.KeypadScaleFactor = 1.0R
        Me.SevenSegment25.KeypadText = Nothing
        Me.SevenSegment25.KeypadWidth = 300
        Me.SevenSegment25.Location = New System.Drawing.Point(331, 386)
        Me.SevenSegment25.Name = "SevenSegment25"
        Me.SevenSegment25.NumberOfDigits = 2
        Me.SevenSegment25.PLCAddressKeypad = "HORA_PICO_TIEMPO2_1"
        Me.SevenSegment25.PLCAddressText = ""
        Me.SevenSegment25.PLCAddressValue = CType(resources.GetObject("SevenSegment25.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment25.PLCAddressVisible = ""
        Me.SevenSegment25.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment25.ShowOffSegments = True
        Me.SevenSegment25.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment25.TabIndex = 1255
        Me.SevenSegment25.Text = "SevenSegment25"
        Me.SevenSegment25.Value = 0R
        '
        'SevenSegment26
        '
        Me.SevenSegment26.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment26.ComComponent = Me.HorariosHorno1
        Me.SevenSegment26.DecimalPosition = 0
        Me.SevenSegment26.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment26.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment26.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment26.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment26.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment26.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment26.KeypadMaxValue = 0R
        Me.SevenSegment26.KeypadMinValue = 0R
        Me.SevenSegment26.KeypadScaleFactor = 1.0R
        Me.SevenSegment26.KeypadText = Nothing
        Me.SevenSegment26.KeypadWidth = 300
        Me.SevenSegment26.Location = New System.Drawing.Point(255, 386)
        Me.SevenSegment26.Name = "SevenSegment26"
        Me.SevenSegment26.NumberOfDigits = 2
        Me.SevenSegment26.PLCAddressKeypad = "HORA_PICO_TIEMPO1_1"
        Me.SevenSegment26.PLCAddressText = ""
        Me.SevenSegment26.PLCAddressValue = CType(resources.GetObject("SevenSegment26.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment26.PLCAddressVisible = ""
        Me.SevenSegment26.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment26.ShowOffSegments = True
        Me.SevenSegment26.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment26.TabIndex = 1254
        Me.SevenSegment26.Text = "SevenSegment26"
        Me.SevenSegment26.Value = 0R
        '
        'OrientedTextLabel2
        '
        Me.OrientedTextLabel2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel2.Location = New System.Drawing.Point(305, 208)
        Me.OrientedTextLabel2.Name = "OrientedTextLabel2"
        Me.OrientedTextLabel2.RotationAngle = 0R
        Me.OrientedTextLabel2.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel2.TabIndex = 1253
        Me.OrientedTextLabel2.Text = ":"
        Me.OrientedTextLabel2.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel2.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment23
        '
        Me.SevenSegment23.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment23.ComComponent = Me.HorariosHorno1
        Me.SevenSegment23.DecimalPosition = 0
        Me.SevenSegment23.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment23.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment23.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment23.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment23.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment23.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment23.KeypadMaxValue = 0R
        Me.SevenSegment23.KeypadMinValue = 0R
        Me.SevenSegment23.KeypadScaleFactor = 1.0R
        Me.SevenSegment23.KeypadText = Nothing
        Me.SevenSegment23.KeypadWidth = 300
        Me.SevenSegment23.Location = New System.Drawing.Point(331, 207)
        Me.SevenSegment23.Name = "SevenSegment23"
        Me.SevenSegment23.NumberOfDigits = 2
        Me.SevenSegment23.PLCAddressKeypad = "HORA_PICO_TIEMPO2_2"
        Me.SevenSegment23.PLCAddressText = ""
        Me.SevenSegment23.PLCAddressValue = CType(resources.GetObject("SevenSegment23.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment23.PLCAddressVisible = ""
        Me.SevenSegment23.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment23.ShowOffSegments = True
        Me.SevenSegment23.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment23.TabIndex = 1252
        Me.SevenSegment23.Text = "SevenSegment23"
        Me.SevenSegment23.Value = 0R
        '
        'SevenSegment24
        '
        Me.SevenSegment24.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment24.ComComponent = Me.HorariosHorno1
        Me.SevenSegment24.DecimalPosition = 0
        Me.SevenSegment24.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment24.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment24.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment24.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment24.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment24.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment24.KeypadMaxValue = 0R
        Me.SevenSegment24.KeypadMinValue = 0R
        Me.SevenSegment24.KeypadScaleFactor = 1.0R
        Me.SevenSegment24.KeypadText = Nothing
        Me.SevenSegment24.KeypadWidth = 300
        Me.SevenSegment24.Location = New System.Drawing.Point(255, 207)
        Me.SevenSegment24.Name = "SevenSegment24"
        Me.SevenSegment24.NumberOfDigits = 2
        Me.SevenSegment24.PLCAddressKeypad = "HORA_PICO_TIEMPO1_2"
        Me.SevenSegment24.PLCAddressText = ""
        Me.SevenSegment24.PLCAddressValue = CType(resources.GetObject("SevenSegment24.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment24.PLCAddressVisible = ""
        Me.SevenSegment24.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment24.ShowOffSegments = True
        Me.SevenSegment24.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment24.TabIndex = 1251
        Me.SevenSegment24.Text = "SevenSegment24"
        Me.SevenSegment24.Value = 0R
        '
        'OrientedTextLabel1
        '
        Me.OrientedTextLabel1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrientedTextLabel1.Location = New System.Drawing.Point(305, 150)
        Me.OrientedTextLabel1.Name = "OrientedTextLabel1"
        Me.OrientedTextLabel1.RotationAngle = 0R
        Me.OrientedTextLabel1.Size = New System.Drawing.Size(25, 27)
        Me.OrientedTextLabel1.TabIndex = 1250
        Me.OrientedTextLabel1.Text = ":"
        Me.OrientedTextLabel1.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel1.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SevenSegment22
        '
        Me.SevenSegment22.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment22.ComComponent = Me.HorariosHorno1
        Me.SevenSegment22.DecimalPosition = 0
        Me.SevenSegment22.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment22.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment22.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment22.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment22.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment22.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment22.KeypadMaxValue = 0R
        Me.SevenSegment22.KeypadMinValue = 0R
        Me.SevenSegment22.KeypadScaleFactor = 1.0R
        Me.SevenSegment22.KeypadText = Nothing
        Me.SevenSegment22.KeypadWidth = 300
        Me.SevenSegment22.Location = New System.Drawing.Point(331, 149)
        Me.SevenSegment22.Name = "SevenSegment22"
        Me.SevenSegment22.NumberOfDigits = 2
        Me.SevenSegment22.PLCAddressKeypad = "HORA_PICO_TIEMPO3"
        Me.SevenSegment22.PLCAddressText = ""
        Me.SevenSegment22.PLCAddressValue = CType(resources.GetObject("SevenSegment22.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment22.PLCAddressVisible = ""
        Me.SevenSegment22.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment22.ShowOffSegments = True
        Me.SevenSegment22.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment22.TabIndex = 1249
        Me.SevenSegment22.Text = "SevenSegment22"
        Me.SevenSegment22.Value = 0R
        '
        'SevenSegment21
        '
        Me.SevenSegment21.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment21.ComComponent = Me.HorariosHorno1
        Me.SevenSegment21.DecimalPosition = 0
        Me.SevenSegment21.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment21.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment21.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment21.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment21.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment21.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment21.KeypadMaxValue = 0R
        Me.SevenSegment21.KeypadMinValue = 0R
        Me.SevenSegment21.KeypadScaleFactor = 1.0R
        Me.SevenSegment21.KeypadText = Nothing
        Me.SevenSegment21.KeypadWidth = 300
        Me.SevenSegment21.Location = New System.Drawing.Point(255, 149)
        Me.SevenSegment21.Name = "SevenSegment21"
        Me.SevenSegment21.NumberOfDigits = 2
        Me.SevenSegment21.PLCAddressKeypad = "HORA_PICO_TIEMPO1"
        Me.SevenSegment21.PLCAddressText = ""
        Me.SevenSegment21.PLCAddressValue = CType(resources.GetObject("SevenSegment21.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment21.PLCAddressVisible = ""
        Me.SevenSegment21.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment21.ShowOffSegments = True
        Me.SevenSegment21.Size = New System.Drawing.Size(49, 32)
        Me.SevenSegment21.TabIndex = 1248
        Me.SevenSegment21.Text = "SevenSegment21"
        Me.SevenSegment21.Value = 0R
        '
        'Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BCF_MenúP_Cascarilla)
        Me.Controls.Add(Me.DigitalPanelMeter6)
        Me.Controls.Add(Me.DigitalPanelMeter5)
        Me.Controls.Add(Me.DigitalPanelMeter4)
        Me.Controls.Add(Me.DigitalPanelMeter3)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.BasicButton3)
        Me.Controls.Add(Me.OrientedTextLabel33)
        Me.Controls.Add(Me.OrientedTextLabel34)
        Me.Controls.Add(Me.OrientedTextLabel35)
        Me.Controls.Add(Me.OrientedTextLabel36)
        Me.Controls.Add(Me.OrientedTextLabel37)
        Me.Controls.Add(Me.OrientedTextLabel38)
        Me.Controls.Add(Me.OrientedTextLabel39)
        Me.Controls.Add(Me.OrientedTextLabel40)
        Me.Controls.Add(Me.OrientedTextLabel41)
        Me.Controls.Add(Me.OrientedTextLabel42)
        Me.Controls.Add(Me.BasicButton2)
        Me.Controls.Add(Me.OrientedTextLabel17)
        Me.Controls.Add(Me.OrientedTextLabel18)
        Me.Controls.Add(Me.OrientedTextLabel19)
        Me.Controls.Add(Me.OrientedTextLabel20)
        Me.Controls.Add(Me.OrientedTextLabel21)
        Me.Controls.Add(Me.OrientedTextLabel22)
        Me.Controls.Add(Me.OrientedTextLabel23)
        Me.Controls.Add(Me.OrientedTextLabel24)
        Me.Controls.Add(Me.OrientedTextLabel25)
        Me.Controls.Add(Me.OrientedTextLabel26)
        Me.Controls.Add(Me.OrientedTextLabel27)
        Me.Controls.Add(Me.SevenSegment213)
        Me.Controls.Add(Me.SevenSegment214)
        Me.Controls.Add(Me.OrientedTextLabel28)
        Me.Controls.Add(Me.SevenSegment215)
        Me.Controls.Add(Me.SevenSegment216)
        Me.Controls.Add(Me.OrientedTextLabel29)
        Me.Controls.Add(Me.SevenSegment217)
        Me.Controls.Add(Me.SevenSegment218)
        Me.Controls.Add(Me.OrientedTextLabel30)
        Me.Controls.Add(Me.SevenSegment219)
        Me.Controls.Add(Me.SevenSegment220)
        Me.Controls.Add(Me.OrientedTextLabel31)
        Me.Controls.Add(Me.SevenSegment221)
        Me.Controls.Add(Me.SevenSegment222)
        Me.Controls.Add(Me.OrientedTextLabel32)
        Me.Controls.Add(Me.SevenSegment223)
        Me.Controls.Add(Me.SevenSegment224)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.OrientedTextLabel15)
        Me.Controls.Add(Me.OrientedTextLabel16)
        Me.Controls.Add(Me.OrientedTextLabel13)
        Me.Controls.Add(Me.OrientedTextLabel14)
        Me.Controls.Add(Me.OrientedTextLabel12)
        Me.Controls.Add(Me.OrientedTextLabel11)
        Me.Controls.Add(Me.OrientedTextLabel10)
        Me.Controls.Add(Me.OrientedTextLabel9)
        Me.Controls.Add(Me.OrientedTextLabel8)
        Me.Controls.Add(Me.OrientedTextLabel7)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.OrientedTextLabel5)
        Me.Controls.Add(Me.SevenSegment29)
        Me.Controls.Add(Me.SevenSegment210)
        Me.Controls.Add(Me.OrientedTextLabel6)
        Me.Controls.Add(Me.SevenSegment211)
        Me.Controls.Add(Me.SevenSegment212)
        Me.Controls.Add(Me.OrientedTextLabel4)
        Me.Controls.Add(Me.SevenSegment27)
        Me.Controls.Add(Me.SevenSegment28)
        Me.Controls.Add(Me.OrientedTextLabel3)
        Me.Controls.Add(Me.SevenSegment25)
        Me.Controls.Add(Me.SevenSegment26)
        Me.Controls.Add(Me.OrientedTextLabel2)
        Me.Controls.Add(Me.SevenSegment23)
        Me.Controls.Add(Me.SevenSegment24)
        Me.Controls.Add(Me.OrientedTextLabel1)
        Me.Controls.Add(Me.SevenSegment22)
        Me.Controls.Add(Me.SevenSegment21)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Horarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.HorariosHorno2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosHorno1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosHorno3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HorariosHorno2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents HorariosHorno1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents HorariosHorno3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BCF_MenúP_Cascarilla As FormChangeButton
    Friend WithEvents DigitalPanelMeter6 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter5 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter4 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton3 As AdvancedHMIControls.BasicButton
    Friend WithEvents OrientedTextLabel33 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel34 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel35 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel36 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel37 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel38 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel39 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel40 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel41 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel42 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
    Friend WithEvents OrientedTextLabel17 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel18 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel19 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel20 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel21 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel22 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel23 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel24 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel25 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel26 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel27 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment213 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment214 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel28 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment215 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment216 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel29 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment217 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment218 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel30 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment219 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment220 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel31 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment221 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment222 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel32 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment223 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment224 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents OrientedTextLabel15 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel16 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel13 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel14 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel12 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel11 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel10 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel9 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel8 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel7 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents OrientedTextLabel5 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment29 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment210 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel6 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment211 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment212 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel4 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment27 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment28 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel3 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment25 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment26 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel2 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment23 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment24 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents OrientedTextLabel1 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SevenSegment22 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment21 As AdvancedHMIControls.SevenSegment2
End Class
