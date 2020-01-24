<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dámper_Horno_3
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
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.DámperH3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.MD_ProcenOutGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_ManualGU12 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU11 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU10 = New AdvancedHMIControls.BasicButton()
        Me.MD_ProcenOutGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_ManualGU09 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualH1 = New AdvancedHMIControls.BasicButton()
        Me.MD_RealOutH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_MenúP_MantH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.MD_ProcenOutH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexProcenOutGU12 = New System.Windows.Forms.Label()
        Me.TexRealOutGU12 = New System.Windows.Forms.Label()
        Me.TexOutGU12 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU11 = New System.Windows.Forms.Label()
        Me.TexRealOutGU11 = New System.Windows.Forms.Label()
        Me.TexOutGU11 = New System.Windows.Forms.Label()
        Me.TexMantH1 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU10 = New System.Windows.Forms.Label()
        Me.TexRealOutGU10 = New System.Windows.Forms.Label()
        Me.TexOutGU10 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU09 = New System.Windows.Forms.Label()
        Me.TexRealOutGU09 = New System.Windows.Forms.Label()
        Me.TexOutGU09 = New System.Windows.Forms.Label()
        Me.TexProcenOutH1 = New System.Windows.Forms.Label()
        Me.TexRealOutH1 = New System.Windows.Forms.Label()
        Me.TexOutH1 = New System.Windows.Forms.Label()
        Me.IF_OutGU12 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU11 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU10 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU09 = New System.Windows.Forms.PictureBox()
        Me.IF_OutH1 = New System.Windows.Forms.PictureBox()
        CType(Me.DámperH3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutH1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton1.FormToOpen = Nothing
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(1012, 654)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = Nothing
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(151, 54)
        Me.FormChangeButton1.TabIndex = 1019
        Me.FormChangeButton1.Text = "Horas"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton1.ComComponent = Me.DámperH3
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Yellow
        Me.BasicButton1.Location = New System.Drawing.Point(204, 126)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton1.PLCAddressClick = "00224"
        Me.BasicButton1.PLCAddressHighlightX = "10224"
        Me.BasicButton1.PLCAddressSelectTextAlternate = "10224"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(94, 30)
        Me.BasicButton1.TabIndex = 1018
        Me.BasicButton1.Text = "Marcha"
        Me.BasicButton1.TextAlternate = "En Marcha"
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'DámperH3
        '
        Me.DámperH3.DisableSubscriptions = False
        Me.DámperH3.IniFileName = ""
        Me.DámperH3.IniFileSection = Nothing
        Me.DámperH3.IPAddress = "10.1.108.8"
        Me.DámperH3.MaxReadGroupSize = 20
        Me.DámperH3.PollRateOverride = 500
        Me.DámperH3.SwapBytes = True
        Me.DámperH3.SwapWords = False
        Me.DámperH3.TcpipPort = CType(20257US, UShort)
        Me.DámperH3.TimeOut = 3000
        Me.DámperH3.UnitId = CType(13, Byte)
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = GetType(MfgControl.AdvancedHMI.Ingeniería)
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(967, 44)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1017
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'MD_ProcenOutGU12
        '
        Me.MD_ProcenOutGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU12.ComComponent = Me.DámperH3
        Me.MD_ProcenOutGU12.DecimalPosition = 0
        Me.MD_ProcenOutGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU12.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU12.KeypadMinValue = 0R
        Me.MD_ProcenOutGU12.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU12.KeypadText = Nothing
        Me.MD_ProcenOutGU12.KeypadWidth = 300
        Me.MD_ProcenOutGU12.Location = New System.Drawing.Point(858, 278)
        Me.MD_ProcenOutGU12.Name = "MD_ProcenOutGU12"
        Me.MD_ProcenOutGU12.NumberOfDigits = 5
        Me.MD_ProcenOutGU12.PLCAddressKeypad = "40297"
        Me.MD_ProcenOutGU12.PLCAddressValue = "40297"
        Me.MD_ProcenOutGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU12.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU12.TabIndex = 1015
        Me.MD_ProcenOutGU12.Value = 0R
        Me.MD_ProcenOutGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU12
        '
        Me.MD_RealOutGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU12.ComComponent = Me.DámperH3
        Me.MD_RealOutGU12.DecimalPosition = 0
        Me.MD_RealOutGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU12.KeypadMaxValue = 0R
        Me.MD_RealOutGU12.KeypadMinValue = 0R
        Me.MD_RealOutGU12.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU12.KeypadText = Nothing
        Me.MD_RealOutGU12.KeypadWidth = 300
        Me.MD_RealOutGU12.Location = New System.Drawing.Point(858, 212)
        Me.MD_RealOutGU12.Name = "MD_RealOutGU12"
        Me.MD_RealOutGU12.NumberOfDigits = 5
        Me.MD_RealOutGU12.PLCAddressKeypad = ""
        Me.MD_RealOutGU12.PLCAddressValue = "40263"
        Me.MD_RealOutGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU12.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU12.TabIndex = 1014
        Me.MD_RealOutGU12.Value = 0R
        Me.MD_RealOutGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU11
        '
        Me.MD_ProcenOutGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU11.ComComponent = Me.DámperH3
        Me.MD_ProcenOutGU11.DecimalPosition = 0
        Me.MD_ProcenOutGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU11.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU11.KeypadMinValue = 0R
        Me.MD_ProcenOutGU11.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU11.KeypadText = Nothing
        Me.MD_ProcenOutGU11.KeypadWidth = 300
        Me.MD_ProcenOutGU11.Location = New System.Drawing.Point(693, 278)
        Me.MD_ProcenOutGU11.Name = "MD_ProcenOutGU11"
        Me.MD_ProcenOutGU11.NumberOfDigits = 5
        Me.MD_ProcenOutGU11.PLCAddressKeypad = "40246"
        Me.MD_ProcenOutGU11.PLCAddressValue = "40246"
        Me.MD_ProcenOutGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU11.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU11.TabIndex = 1013
        Me.MD_ProcenOutGU11.Value = 0R
        Me.MD_ProcenOutGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU11
        '
        Me.MD_RealOutGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU11.ComComponent = Me.DámperH3
        Me.MD_RealOutGU11.DecimalPosition = 0
        Me.MD_RealOutGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU11.KeypadMaxValue = 0R
        Me.MD_RealOutGU11.KeypadMinValue = 0R
        Me.MD_RealOutGU11.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU11.KeypadText = Nothing
        Me.MD_RealOutGU11.KeypadWidth = 300
        Me.MD_RealOutGU11.Location = New System.Drawing.Point(693, 212)
        Me.MD_RealOutGU11.Name = "MD_RealOutGU11"
        Me.MD_RealOutGU11.NumberOfDigits = 5
        Me.MD_RealOutGU11.PLCAddressKeypad = ""
        Me.MD_RealOutGU11.PLCAddressValue = "40212"
        Me.MD_RealOutGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU11.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU11.TabIndex = 1012
        Me.MD_RealOutGU11.Value = 0R
        Me.MD_RealOutGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_ManualGU12
        '
        Me.BP_ManualGU12.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU12.ComComponent = Me.DámperH3
        Me.BP_ManualGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU12.Highlight = False
        Me.BP_ManualGU12.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU12.Location = New System.Drawing.Point(857, 325)
        Me.BP_ManualGU12.MaximumHoldTime = 3000
        Me.BP_ManualGU12.MinimumHoldTime = 500
        Me.BP_ManualGU12.Name = "BP_ManualGU12"
        Me.BP_ManualGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU12.PLCAddressClick = "00032"
        Me.BP_ManualGU12.PLCAddressHighlightX = "10032"
        Me.BP_ManualGU12.PLCAddressSelectTextAlternate = "10032"
        Me.BP_ManualGU12.SelectTextAlternate = False
        Me.BP_ManualGU12.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU12.TabIndex = 1011
        Me.BP_ManualGU12.Text = "Automático"
        Me.BP_ManualGU12.TextAlternate = "Manual"
        Me.BP_ManualGU12.UseVisualStyleBackColor = True
        Me.BP_ManualGU12.ValueToWrite = 0
        '
        'BP_ManualGU11
        '
        Me.BP_ManualGU11.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU11.ComComponent = Me.DámperH3
        Me.BP_ManualGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU11.Highlight = False
        Me.BP_ManualGU11.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU11.Location = New System.Drawing.Point(693, 325)
        Me.BP_ManualGU11.MaximumHoldTime = 3000
        Me.BP_ManualGU11.MinimumHoldTime = 500
        Me.BP_ManualGU11.Name = "BP_ManualGU11"
        Me.BP_ManualGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU11.PLCAddressClick = "00026"
        Me.BP_ManualGU11.PLCAddressHighlightX = "10026"
        Me.BP_ManualGU11.PLCAddressSelectTextAlternate = "10026"
        Me.BP_ManualGU11.SelectTextAlternate = False
        Me.BP_ManualGU11.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU11.TabIndex = 1010
        Me.BP_ManualGU11.Text = "Automático"
        Me.BP_ManualGU11.TextAlternate = "Manual"
        Me.BP_ManualGU11.UseVisualStyleBackColor = True
        Me.BP_ManualGU11.ValueToWrite = 0
        '
        'BP_ManualGU10
        '
        Me.BP_ManualGU10.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU10.ComComponent = Me.DámperH3
        Me.BP_ManualGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU10.Highlight = False
        Me.BP_ManualGU10.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU10.Location = New System.Drawing.Point(529, 325)
        Me.BP_ManualGU10.MaximumHoldTime = 3000
        Me.BP_ManualGU10.MinimumHoldTime = 500
        Me.BP_ManualGU10.Name = "BP_ManualGU10"
        Me.BP_ManualGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU10.PLCAddressClick = "00019"
        Me.BP_ManualGU10.PLCAddressHighlightX = "10019"
        Me.BP_ManualGU10.PLCAddressSelectTextAlternate = "10019"
        Me.BP_ManualGU10.SelectTextAlternate = False
        Me.BP_ManualGU10.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU10.TabIndex = 1009
        Me.BP_ManualGU10.Text = "Automático"
        Me.BP_ManualGU10.TextAlternate = "Manual"
        Me.BP_ManualGU10.UseVisualStyleBackColor = True
        Me.BP_ManualGU10.ValueToWrite = 0
        '
        'MD_ProcenOutGU10
        '
        Me.MD_ProcenOutGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU10.ComComponent = Me.DámperH3
        Me.MD_ProcenOutGU10.DecimalPosition = 0
        Me.MD_ProcenOutGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU10.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU10.KeypadMinValue = 0R
        Me.MD_ProcenOutGU10.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU10.KeypadText = Nothing
        Me.MD_ProcenOutGU10.KeypadWidth = 300
        Me.MD_ProcenOutGU10.Location = New System.Drawing.Point(530, 278)
        Me.MD_ProcenOutGU10.Name = "MD_ProcenOutGU10"
        Me.MD_ProcenOutGU10.NumberOfDigits = 5
        Me.MD_ProcenOutGU10.PLCAddressKeypad = "40195"
        Me.MD_ProcenOutGU10.PLCAddressValue = "40195"
        Me.MD_ProcenOutGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU10.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU10.TabIndex = 1008
        Me.MD_ProcenOutGU10.Value = 0R
        Me.MD_ProcenOutGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU10
        '
        Me.MD_RealOutGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU10.ComComponent = Me.DámperH3
        Me.MD_RealOutGU10.DecimalPosition = 0
        Me.MD_RealOutGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU10.KeypadMaxValue = 0R
        Me.MD_RealOutGU10.KeypadMinValue = 0R
        Me.MD_RealOutGU10.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU10.KeypadText = Nothing
        Me.MD_RealOutGU10.KeypadWidth = 300
        Me.MD_RealOutGU10.Location = New System.Drawing.Point(530, 212)
        Me.MD_RealOutGU10.Name = "MD_RealOutGU10"
        Me.MD_RealOutGU10.NumberOfDigits = 5
        Me.MD_RealOutGU10.PLCAddressKeypad = ""
        Me.MD_RealOutGU10.PLCAddressValue = "40161"
        Me.MD_RealOutGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU10.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU10.TabIndex = 1007
        Me.MD_RealOutGU10.Value = 0R
        Me.MD_RealOutGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU09
        '
        Me.MD_ProcenOutGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU09.ComComponent = Me.DámperH3
        Me.MD_ProcenOutGU09.DecimalPosition = 0
        Me.MD_ProcenOutGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU09.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU09.KeypadMinValue = 0R
        Me.MD_ProcenOutGU09.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU09.KeypadText = Nothing
        Me.MD_ProcenOutGU09.KeypadWidth = 300
        Me.MD_ProcenOutGU09.Location = New System.Drawing.Point(366, 278)
        Me.MD_ProcenOutGU09.Name = "MD_ProcenOutGU09"
        Me.MD_ProcenOutGU09.NumberOfDigits = 5
        Me.MD_ProcenOutGU09.PLCAddressKeypad = "40144"
        Me.MD_ProcenOutGU09.PLCAddressValue = "40144"
        Me.MD_ProcenOutGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU09.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU09.TabIndex = 1006
        Me.MD_ProcenOutGU09.Value = 0R
        Me.MD_ProcenOutGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU09
        '
        Me.MD_RealOutGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU09.ComComponent = Me.DámperH3
        Me.MD_RealOutGU09.DecimalPosition = 0
        Me.MD_RealOutGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU09.KeypadMaxValue = 0R
        Me.MD_RealOutGU09.KeypadMinValue = 0R
        Me.MD_RealOutGU09.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU09.KeypadText = Nothing
        Me.MD_RealOutGU09.KeypadWidth = 300
        Me.MD_RealOutGU09.Location = New System.Drawing.Point(366, 212)
        Me.MD_RealOutGU09.Name = "MD_RealOutGU09"
        Me.MD_RealOutGU09.NumberOfDigits = 5
        Me.MD_RealOutGU09.PLCAddressKeypad = ""
        Me.MD_RealOutGU09.PLCAddressValue = "40110"
        Me.MD_RealOutGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU09.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU09.TabIndex = 1005
        Me.MD_RealOutGU09.Value = 0R
        Me.MD_RealOutGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_ManualGU09
        '
        Me.BP_ManualGU09.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU09.ComComponent = Me.DámperH3
        Me.BP_ManualGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU09.Highlight = False
        Me.BP_ManualGU09.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU09.Location = New System.Drawing.Point(365, 325)
        Me.BP_ManualGU09.MaximumHoldTime = 3000
        Me.BP_ManualGU09.MinimumHoldTime = 500
        Me.BP_ManualGU09.Name = "BP_ManualGU09"
        Me.BP_ManualGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU09.PLCAddressClick = "00016"
        Me.BP_ManualGU09.PLCAddressHighlightX = "10016"
        Me.BP_ManualGU09.PLCAddressSelectTextAlternate = "10016"
        Me.BP_ManualGU09.SelectTextAlternate = False
        Me.BP_ManualGU09.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU09.TabIndex = 1004
        Me.BP_ManualGU09.Text = "Automático"
        Me.BP_ManualGU09.TextAlternate = "Manual"
        Me.BP_ManualGU09.UseVisualStyleBackColor = True
        Me.BP_ManualGU09.ValueToWrite = 0
        '
        'BP_ManualH1
        '
        Me.BP_ManualH1.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualH1.ComComponent = Me.DámperH3
        Me.BP_ManualH1.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualH1.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualH1.Highlight = False
        Me.BP_ManualH1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualH1.Location = New System.Drawing.Point(202, 325)
        Me.BP_ManualH1.MaximumHoldTime = 3000
        Me.BP_ManualH1.MinimumHoldTime = 500
        Me.BP_ManualH1.Name = "BP_ManualH1"
        Me.BP_ManualH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualH1.PLCAddressClick = "00014"
        Me.BP_ManualH1.PLCAddressHighlightX = "10014"
        Me.BP_ManualH1.PLCAddressSelectTextAlternate = "10014"
        Me.BP_ManualH1.SelectTextAlternate = False
        Me.BP_ManualH1.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualH1.TabIndex = 1003
        Me.BP_ManualH1.Text = "Automático"
        Me.BP_ManualH1.TextAlternate = "Manual"
        Me.BP_ManualH1.UseVisualStyleBackColor = True
        Me.BP_ManualH1.ValueToWrite = 0
        '
        'MD_RealOutH1
        '
        Me.MD_RealOutH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutH1.ComComponent = Me.DámperH3
        Me.MD_RealOutH1.DecimalPosition = 0
        Me.MD_RealOutH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutH1.KeypadMaxValue = 0R
        Me.MD_RealOutH1.KeypadMinValue = 0R
        Me.MD_RealOutH1.KeypadScaleFactor = 1.0R
        Me.MD_RealOutH1.KeypadText = Nothing
        Me.MD_RealOutH1.KeypadWidth = 300
        Me.MD_RealOutH1.Location = New System.Drawing.Point(202, 212)
        Me.MD_RealOutH1.Name = "MD_RealOutH1"
        Me.MD_RealOutH1.NumberOfDigits = 5
        Me.MD_RealOutH1.PLCAddressKeypad = ""
        Me.MD_RealOutH1.PLCAddressValue = "40047"
        Me.MD_RealOutH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutH1.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutH1.TabIndex = 1001
        Me.MD_RealOutH1.Value = 0R
        Me.MD_RealOutH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_MenúP_MantH1
        '
        Me.BCF_MenúP_MantH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_MantH1.ComComponent = Nothing
        Me.BCF_MenúP_MantH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_MantH1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_MantH1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_MantH1.KeypadWidth = 300
        Me.BCF_MenúP_MantH1.Location = New System.Drawing.Point(189, 44)
        Me.BCF_MenúP_MantH1.Name = "BCF_MenúP_MantH1"
        Me.BCF_MenúP_MantH1.Passcode = Nothing
        Me.BCF_MenúP_MantH1.PasswordChar = False
        Me.BCF_MenúP_MantH1.PLCAddressVisible = ""
        Me.BCF_MenúP_MantH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_MantH1.TabIndex = 1016
        Me.BCF_MenúP_MantH1.Text = "Menú Principal"
        Me.BCF_MenúP_MantH1.UseVisualStyleBackColor = False
        '
        'MD_ProcenOutH1
        '
        Me.MD_ProcenOutH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutH1.ComComponent = Me.DámperH3
        Me.MD_ProcenOutH1.DecimalPosition = 0
        Me.MD_ProcenOutH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutH1.KeypadMaxValue = 0R
        Me.MD_ProcenOutH1.KeypadMinValue = 0R
        Me.MD_ProcenOutH1.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutH1.KeypadText = Nothing
        Me.MD_ProcenOutH1.KeypadWidth = 300
        Me.MD_ProcenOutH1.Location = New System.Drawing.Point(202, 278)
        Me.MD_ProcenOutH1.Name = "MD_ProcenOutH1"
        Me.MD_ProcenOutH1.NumberOfDigits = 5
        Me.MD_ProcenOutH1.PLCAddressKeypad = "40088"
        Me.MD_ProcenOutH1.PLCAddressValue = "40088"
        Me.MD_ProcenOutH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutH1.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutH1.TabIndex = 1002
        Me.MD_ProcenOutH1.Value = 0R
        Me.MD_ProcenOutH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexProcenOutGU12
        '
        Me.TexProcenOutGU12.AutoSize = True
        Me.TexProcenOutGU12.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU12.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU12.Location = New System.Drawing.Point(869, 257)
        Me.TexProcenOutGU12.Name = "TexProcenOutGU12"
        Me.TexProcenOutGU12.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU12.TabIndex = 1000
        Me.TexProcenOutGU12.Text = "% Salida"
        '
        'TexRealOutGU12
        '
        Me.TexRealOutGU12.AutoSize = True
        Me.TexRealOutGU12.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU12.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU12.Location = New System.Drawing.Point(885, 192)
        Me.TexRealOutGU12.Name = "TexRealOutGU12"
        Me.TexRealOutGU12.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU12.TabIndex = 999
        Me.TexRealOutGU12.Text = "Real"
        '
        'TexOutGU12
        '
        Me.TexOutGU12.AutoSize = True
        Me.TexOutGU12.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU12.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU12.Location = New System.Drawing.Point(854, 171)
        Me.TexOutGU12.Name = "TexOutGU12"
        Me.TexOutGU12.Size = New System.Drawing.Size(97, 18)
        Me.TexOutGU12.TabIndex = 998
        Me.TexOutGU12.Text = "Columnar 05"
        '
        'TexProcenOutGU11
        '
        Me.TexProcenOutGU11.AutoSize = True
        Me.TexProcenOutGU11.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU11.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU11.Location = New System.Drawing.Point(706, 257)
        Me.TexProcenOutGU11.Name = "TexProcenOutGU11"
        Me.TexProcenOutGU11.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU11.TabIndex = 997
        Me.TexProcenOutGU11.Text = "% Salida"
        '
        'TexRealOutGU11
        '
        Me.TexRealOutGU11.AutoSize = True
        Me.TexRealOutGU11.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU11.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU11.Location = New System.Drawing.Point(722, 192)
        Me.TexRealOutGU11.Name = "TexRealOutGU11"
        Me.TexRealOutGU11.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU11.TabIndex = 996
        Me.TexRealOutGU11.Text = "Real"
        '
        'TexOutGU11
        '
        Me.TexOutGU11.AutoSize = True
        Me.TexOutGU11.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU11.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU11.Location = New System.Drawing.Point(691, 171)
        Me.TexOutGU11.Name = "TexOutGU11"
        Me.TexOutGU11.Size = New System.Drawing.Size(97, 18)
        Me.TexOutGU11.TabIndex = 995
        Me.TexOutGU11.Text = "Columnar 04"
        '
        'TexMantH1
        '
        Me.TexMantH1.AutoSize = True
        Me.TexMantH1.BackColor = System.Drawing.Color.DimGray
        Me.TexMantH1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexMantH1.ForeColor = System.Drawing.Color.White
        Me.TexMantH1.Location = New System.Drawing.Point(495, 64)
        Me.TexMantH1.Name = "TexMantH1"
        Me.TexMantH1.Size = New System.Drawing.Size(348, 34)
        Me.TexMantH1.TabIndex = 992
        Me.TexMantH1.Text = " Mantenimiento Horno 3"
        '
        'TexProcenOutGU10
        '
        Me.TexProcenOutGU10.AutoSize = True
        Me.TexProcenOutGU10.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU10.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU10.Location = New System.Drawing.Point(542, 257)
        Me.TexProcenOutGU10.Name = "TexProcenOutGU10"
        Me.TexProcenOutGU10.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU10.TabIndex = 991
        Me.TexProcenOutGU10.Text = "% Salida"
        '
        'TexRealOutGU10
        '
        Me.TexRealOutGU10.AutoSize = True
        Me.TexRealOutGU10.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU10.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU10.Location = New System.Drawing.Point(558, 192)
        Me.TexRealOutGU10.Name = "TexRealOutGU10"
        Me.TexRealOutGU10.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU10.TabIndex = 990
        Me.TexRealOutGU10.Text = "Real"
        '
        'TexOutGU10
        '
        Me.TexOutGU10.AutoSize = True
        Me.TexOutGU10.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU10.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU10.Location = New System.Drawing.Point(527, 171)
        Me.TexOutGU10.Name = "TexOutGU10"
        Me.TexOutGU10.Size = New System.Drawing.Size(97, 18)
        Me.TexOutGU10.TabIndex = 989
        Me.TexOutGU10.Text = "Columnar 03"
        '
        'TexProcenOutGU09
        '
        Me.TexProcenOutGU09.AutoSize = True
        Me.TexProcenOutGU09.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU09.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU09.Location = New System.Drawing.Point(376, 257)
        Me.TexProcenOutGU09.Name = "TexProcenOutGU09"
        Me.TexProcenOutGU09.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU09.TabIndex = 987
        Me.TexProcenOutGU09.Text = "% Salida"
        '
        'TexRealOutGU09
        '
        Me.TexRealOutGU09.AutoSize = True
        Me.TexRealOutGU09.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU09.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU09.Location = New System.Drawing.Point(392, 192)
        Me.TexRealOutGU09.Name = "TexRealOutGU09"
        Me.TexRealOutGU09.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU09.TabIndex = 986
        Me.TexRealOutGU09.Text = "Real"
        '
        'TexOutGU09
        '
        Me.TexOutGU09.AutoSize = True
        Me.TexOutGU09.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU09.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU09.Location = New System.Drawing.Point(361, 171)
        Me.TexOutGU09.Name = "TexOutGU09"
        Me.TexOutGU09.Size = New System.Drawing.Size(97, 18)
        Me.TexOutGU09.TabIndex = 985
        Me.TexOutGU09.Text = "Columnar 02"
        '
        'TexProcenOutH1
        '
        Me.TexProcenOutH1.AutoSize = True
        Me.TexProcenOutH1.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutH1.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutH1.Location = New System.Drawing.Point(213, 257)
        Me.TexProcenOutH1.Name = "TexProcenOutH1"
        Me.TexProcenOutH1.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutH1.TabIndex = 983
        Me.TexProcenOutH1.Text = "% Salida"
        '
        'TexRealOutH1
        '
        Me.TexRealOutH1.AutoSize = True
        Me.TexRealOutH1.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutH1.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutH1.Location = New System.Drawing.Point(229, 192)
        Me.TexRealOutH1.Name = "TexRealOutH1"
        Me.TexRealOutH1.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutH1.TabIndex = 982
        Me.TexRealOutH1.Text = "Real"
        '
        'TexOutH1
        '
        Me.TexOutH1.AutoSize = True
        Me.TexOutH1.BackColor = System.Drawing.Color.Silver
        Me.TexOutH1.ForeColor = System.Drawing.Color.Blue
        Me.TexOutH1.Location = New System.Drawing.Point(211, 171)
        Me.TexOutH1.Name = "TexOutH1"
        Me.TexOutH1.Size = New System.Drawing.Size(72, 18)
        Me.TexOutH1.TabIndex = 981
        Me.TexOutH1.Text = "Horno 03"
        '
        'IF_OutGU12
        '
        Me.IF_OutGU12.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU12.Location = New System.Drawing.Point(842, 162)
        Me.IF_OutGU12.Name = "IF_OutGU12"
        Me.IF_OutGU12.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU12.TabIndex = 994
        Me.IF_OutGU12.TabStop = False
        '
        'IF_OutGU11
        '
        Me.IF_OutGU11.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU11.Location = New System.Drawing.Point(678, 162)
        Me.IF_OutGU11.Name = "IF_OutGU11"
        Me.IF_OutGU11.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU11.TabIndex = 993
        Me.IF_OutGU11.TabStop = False
        '
        'IF_OutGU10
        '
        Me.IF_OutGU10.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU10.Location = New System.Drawing.Point(514, 162)
        Me.IF_OutGU10.Name = "IF_OutGU10"
        Me.IF_OutGU10.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU10.TabIndex = 988
        Me.IF_OutGU10.TabStop = False
        '
        'IF_OutGU09
        '
        Me.IF_OutGU09.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU09.Location = New System.Drawing.Point(350, 162)
        Me.IF_OutGU09.Name = "IF_OutGU09"
        Me.IF_OutGU09.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU09.TabIndex = 984
        Me.IF_OutGU09.TabStop = False
        '
        'IF_OutH1
        '
        Me.IF_OutH1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutH1.Location = New System.Drawing.Point(186, 162)
        Me.IF_OutH1.Name = "IF_OutH1"
        Me.IF_OutH1.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutH1.TabIndex = 980
        Me.IF_OutH1.TabStop = False
        '
        'Dámper_Horno_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.MD_ProcenOutGU12)
        Me.Controls.Add(Me.MD_RealOutGU12)
        Me.Controls.Add(Me.MD_ProcenOutGU11)
        Me.Controls.Add(Me.MD_RealOutGU11)
        Me.Controls.Add(Me.BP_ManualGU12)
        Me.Controls.Add(Me.BP_ManualGU11)
        Me.Controls.Add(Me.BP_ManualGU10)
        Me.Controls.Add(Me.MD_ProcenOutGU10)
        Me.Controls.Add(Me.MD_RealOutGU10)
        Me.Controls.Add(Me.MD_ProcenOutGU09)
        Me.Controls.Add(Me.MD_RealOutGU09)
        Me.Controls.Add(Me.BP_ManualGU09)
        Me.Controls.Add(Me.BP_ManualH1)
        Me.Controls.Add(Me.MD_RealOutH1)
        Me.Controls.Add(Me.BCF_MenúP_MantH1)
        Me.Controls.Add(Me.MD_ProcenOutH1)
        Me.Controls.Add(Me.TexProcenOutGU12)
        Me.Controls.Add(Me.TexRealOutGU12)
        Me.Controls.Add(Me.TexOutGU12)
        Me.Controls.Add(Me.TexProcenOutGU11)
        Me.Controls.Add(Me.TexRealOutGU11)
        Me.Controls.Add(Me.TexOutGU11)
        Me.Controls.Add(Me.IF_OutGU12)
        Me.Controls.Add(Me.IF_OutGU11)
        Me.Controls.Add(Me.TexMantH1)
        Me.Controls.Add(Me.TexProcenOutGU10)
        Me.Controls.Add(Me.TexRealOutGU10)
        Me.Controls.Add(Me.TexOutGU10)
        Me.Controls.Add(Me.IF_OutGU10)
        Me.Controls.Add(Me.TexProcenOutGU09)
        Me.Controls.Add(Me.TexRealOutGU09)
        Me.Controls.Add(Me.TexOutGU09)
        Me.Controls.Add(Me.IF_OutGU09)
        Me.Controls.Add(Me.TexProcenOutH1)
        Me.Controls.Add(Me.TexRealOutH1)
        Me.Controls.Add(Me.TexOutH1)
        Me.Controls.Add(Me.IF_OutH1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Dámper_Horno_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DámperH3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutH1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormChangeButton1 As FormChangeButton
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents DámperH3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents MD_ProcenOutGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_ManualGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_ProcenOutGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_ManualGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualH1 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_RealOutH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_MenúP_MantH1 As FormChangeButton
    Friend WithEvents MD_ProcenOutH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexProcenOutGU12 As Label
    Friend WithEvents TexRealOutGU12 As Label
    Friend WithEvents TexOutGU12 As Label
    Friend WithEvents TexProcenOutGU11 As Label
    Friend WithEvents TexRealOutGU11 As Label
    Friend WithEvents TexOutGU11 As Label
    Friend WithEvents IF_OutGU12 As PictureBox
    Friend WithEvents IF_OutGU11 As PictureBox
    Friend WithEvents TexMantH1 As Label
    Friend WithEvents TexProcenOutGU10 As Label
    Friend WithEvents TexRealOutGU10 As Label
    Friend WithEvents TexOutGU10 As Label
    Friend WithEvents IF_OutGU10 As PictureBox
    Friend WithEvents TexProcenOutGU09 As Label
    Friend WithEvents TexRealOutGU09 As Label
    Friend WithEvents TexOutGU09 As Label
    Friend WithEvents IF_OutGU09 As PictureBox
    Friend WithEvents TexProcenOutH1 As Label
    Friend WithEvents TexRealOutH1 As Label
    Friend WithEvents TexOutH1 As Label
    Friend WithEvents IF_OutH1 As PictureBox
End Class
