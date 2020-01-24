<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dámper_Horno_2
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
        Me.BCF_MenúP_MantH2 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.MD_ProcenOutGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DámperH2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.MD_RealOutGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU07 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU06 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_BloqueoGU08 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU08 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU08 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU07 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU07 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU07 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU06 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU06 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU06 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU05 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU05 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU05 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU04 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU04 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU04 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU03 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU03 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU03 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU02 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU02 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU02 = New AdvancedHMIControls.BasicButton()
        Me.MD_ProcenOutGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU01 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_BloqueoGU01 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU01 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU01 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualH2 = New AdvancedHMIControls.BasicButton()
        Me.MD_ProcenOutH2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutH2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexProcenOutGU08 = New System.Windows.Forms.Label()
        Me.TexRealOutGU08 = New System.Windows.Forms.Label()
        Me.TexOutGU08 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU07 = New System.Windows.Forms.Label()
        Me.TexRealOutGU07 = New System.Windows.Forms.Label()
        Me.TexOutGU07 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU06 = New System.Windows.Forms.Label()
        Me.TexRealOutGU06 = New System.Windows.Forms.Label()
        Me.TexOutGU06 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU05 = New System.Windows.Forms.Label()
        Me.TexRealOutGU05 = New System.Windows.Forms.Label()
        Me.TexOutGU05 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU04 = New System.Windows.Forms.Label()
        Me.TexRealOutGU04 = New System.Windows.Forms.Label()
        Me.TexOutGU04 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU03 = New System.Windows.Forms.Label()
        Me.TexRealOutGU03 = New System.Windows.Forms.Label()
        Me.TexOutGU03 = New System.Windows.Forms.Label()
        Me.TexMantH2 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU02 = New System.Windows.Forms.Label()
        Me.TexRealOutGU02 = New System.Windows.Forms.Label()
        Me.TexOutGU02 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU01 = New System.Windows.Forms.Label()
        Me.TexRealOutGU01 = New System.Windows.Forms.Label()
        Me.TexOutGU01 = New System.Windows.Forms.Label()
        Me.TexProcenOutH2 = New System.Windows.Forms.Label()
        Me.TexRealOutH2 = New System.Windows.Forms.Label()
        Me.TexOutH2 = New System.Windows.Forms.Label()
        Me.IF_OutGU08 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU07 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU06 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU05 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU04 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU03 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU01 = New System.Windows.Forms.PictureBox()
        Me.IF_OutH2 = New System.Windows.Forms.PictureBox()
        CType(Me.DámperH2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutH2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(1004, 51)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1102
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BCF_MenúP_MantH2
        '
        Me.BCF_MenúP_MantH2.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_MantH2.ComComponent = Nothing
        Me.BCF_MenúP_MantH2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_MantH2.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_MantH2.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_MantH2.KeypadWidth = 300
        Me.BCF_MenúP_MantH2.Location = New System.Drawing.Point(196, 51)
        Me.BCF_MenúP_MantH2.Name = "BCF_MenúP_MantH2"
        Me.BCF_MenúP_MantH2.Passcode = Nothing
        Me.BCF_MenúP_MantH2.PasswordChar = False
        Me.BCF_MenúP_MantH2.PLCAddressVisible = ""
        Me.BCF_MenúP_MantH2.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_MantH2.TabIndex = 1101
        Me.BCF_MenúP_MantH2.Text = "Menú Principal"
        Me.BCF_MenúP_MantH2.UseVisualStyleBackColor = False
        '
        'MD_ProcenOutGU08
        '
        Me.MD_ProcenOutGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU08.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU08.DecimalPosition = 0
        Me.MD_ProcenOutGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU08.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU08.KeypadMinValue = 0R
        Me.MD_ProcenOutGU08.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU08.KeypadText = Nothing
        Me.MD_ProcenOutGU08.KeypadWidth = 300
        Me.MD_ProcenOutGU08.Location = New System.Drawing.Point(541, 573)
        Me.MD_ProcenOutGU08.Name = "MD_ProcenOutGU08"
        Me.MD_ProcenOutGU08.NumberOfDigits = 5
        Me.MD_ProcenOutGU08.PLCAddressKeypad = "PID_SGU08.SO"
        Me.MD_ProcenOutGU08.PLCAddressValue = "PID_SGU08.SO"
        Me.MD_ProcenOutGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU08.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU08.TabIndex = 1100
        Me.MD_ProcenOutGU08.Value = 0R
        Me.MD_ProcenOutGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DámperH2
        '
        Me.DámperH2.CIPConnectionSize = 508
        Me.DámperH2.DisableMultiServiceRequest = False
        Me.DámperH2.DisableSubscriptions = False
        Me.DámperH2.IniFileName = ""
        Me.DámperH2.IniFileSection = Nothing
        Me.DámperH2.IPAddress = "10.1.108.18"
        Me.DámperH2.PollRateOverride = 500
        Me.DámperH2.Port = 44818
        Me.DámperH2.ProcessorSlot = 0
        Me.DámperH2.RoutePath = Nothing
        Me.DámperH2.Timeout = 4000
        '
        'MD_RealOutGU08
        '
        Me.MD_RealOutGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU08.ComComponent = Me.DámperH2
        Me.MD_RealOutGU08.DecimalPosition = 0
        Me.MD_RealOutGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU08.KeypadMaxValue = 0R
        Me.MD_RealOutGU08.KeypadMinValue = 0R
        Me.MD_RealOutGU08.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU08.KeypadText = Nothing
        Me.MD_RealOutGU08.KeypadWidth = 300
        Me.MD_RealOutGU08.Location = New System.Drawing.Point(541, 507)
        Me.MD_RealOutGU08.Name = "MD_RealOutGU08"
        Me.MD_RealOutGU08.NumberOfDigits = 5
        Me.MD_RealOutGU08.PLCAddressKeypad = ""
        Me.MD_RealOutGU08.PLCAddressValue = "PID_SGU08.OUT"
        Me.MD_RealOutGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU08.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU08.TabIndex = 1099
        Me.MD_RealOutGU08.Value = 0R
        Me.MD_RealOutGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU07
        '
        Me.MD_ProcenOutGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU07.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU07.DecimalPosition = 0
        Me.MD_ProcenOutGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU07.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU07.KeypadMinValue = 0R
        Me.MD_ProcenOutGU07.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU07.KeypadText = Nothing
        Me.MD_ProcenOutGU07.KeypadWidth = 300
        Me.MD_ProcenOutGU07.Location = New System.Drawing.Point(375, 573)
        Me.MD_ProcenOutGU07.Name = "MD_ProcenOutGU07"
        Me.MD_ProcenOutGU07.NumberOfDigits = 5
        Me.MD_ProcenOutGU07.PLCAddressKeypad = "PID_SGU07.SO"
        Me.MD_ProcenOutGU07.PLCAddressValue = "PID_SGU07.SO"
        Me.MD_ProcenOutGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU07.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU07.TabIndex = 1098
        Me.MD_ProcenOutGU07.Value = 0R
        Me.MD_ProcenOutGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU07
        '
        Me.MD_RealOutGU07.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU07.ComComponent = Me.DámperH2
        Me.MD_RealOutGU07.DecimalPosition = 0
        Me.MD_RealOutGU07.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU07.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU07.KeypadMaxValue = 0R
        Me.MD_RealOutGU07.KeypadMinValue = 0R
        Me.MD_RealOutGU07.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU07.KeypadText = Nothing
        Me.MD_RealOutGU07.KeypadWidth = 300
        Me.MD_RealOutGU07.Location = New System.Drawing.Point(375, 507)
        Me.MD_RealOutGU07.Name = "MD_RealOutGU07"
        Me.MD_RealOutGU07.NumberOfDigits = 5
        Me.MD_RealOutGU07.PLCAddressKeypad = ""
        Me.MD_RealOutGU07.PLCAddressValue = "PID_SGU07.OUT"
        Me.MD_RealOutGU07.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU07.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU07.TabIndex = 1097
        Me.MD_RealOutGU07.Value = 0R
        Me.MD_RealOutGU07.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU07.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU06
        '
        Me.MD_ProcenOutGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU06.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU06.DecimalPosition = 0
        Me.MD_ProcenOutGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU06.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU06.KeypadMinValue = 0R
        Me.MD_ProcenOutGU06.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU06.KeypadText = Nothing
        Me.MD_ProcenOutGU06.KeypadWidth = 300
        Me.MD_ProcenOutGU06.Location = New System.Drawing.Point(211, 573)
        Me.MD_ProcenOutGU06.Name = "MD_ProcenOutGU06"
        Me.MD_ProcenOutGU06.NumberOfDigits = 5
        Me.MD_ProcenOutGU06.PLCAddressKeypad = "PID_SGU06.SO"
        Me.MD_ProcenOutGU06.PLCAddressValue = "PID_SGU06.SO"
        Me.MD_ProcenOutGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU06.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU06.TabIndex = 1096
        Me.MD_ProcenOutGU06.Value = 0R
        Me.MD_ProcenOutGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU06
        '
        Me.MD_RealOutGU06.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU06.ComComponent = Me.DámperH2
        Me.MD_RealOutGU06.DecimalPosition = 0
        Me.MD_RealOutGU06.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU06.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU06.KeypadMaxValue = 0R
        Me.MD_RealOutGU06.KeypadMinValue = 0R
        Me.MD_RealOutGU06.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU06.KeypadText = Nothing
        Me.MD_RealOutGU06.KeypadWidth = 300
        Me.MD_RealOutGU06.Location = New System.Drawing.Point(211, 507)
        Me.MD_RealOutGU06.Name = "MD_RealOutGU06"
        Me.MD_RealOutGU06.NumberOfDigits = 5
        Me.MD_RealOutGU06.PLCAddressKeypad = ""
        Me.MD_RealOutGU06.PLCAddressValue = "PID_SGU06.OUT"
        Me.MD_RealOutGU06.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU06.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU06.TabIndex = 1095
        Me.MD_RealOutGU06.Value = 0R
        Me.MD_RealOutGU06.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU06.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU05
        '
        Me.MD_ProcenOutGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU05.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU05.DecimalPosition = 1
        Me.MD_ProcenOutGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU05.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU05.KeypadMinValue = 0R
        Me.MD_ProcenOutGU05.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU05.KeypadText = Nothing
        Me.MD_ProcenOutGU05.KeypadWidth = 300
        Me.MD_ProcenOutGU05.Location = New System.Drawing.Point(1029, 285)
        Me.MD_ProcenOutGU05.Name = "MD_ProcenOutGU05"
        Me.MD_ProcenOutGU05.NumberOfDigits = 5
        Me.MD_ProcenOutGU05.PLCAddressKeypad = "PID_SGU05.SO"
        Me.MD_ProcenOutGU05.PLCAddressValue = "PID_SGU05.SO"
        Me.MD_ProcenOutGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU05.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU05.TabIndex = 1094
        Me.MD_ProcenOutGU05.Value = 0R
        Me.MD_ProcenOutGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU05
        '
        Me.MD_RealOutGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU05.ComComponent = Me.DámperH2
        Me.MD_RealOutGU05.DecimalPosition = 1
        Me.MD_RealOutGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU05.KeypadMaxValue = 0R
        Me.MD_RealOutGU05.KeypadMinValue = 0R
        Me.MD_RealOutGU05.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU05.KeypadText = Nothing
        Me.MD_RealOutGU05.KeypadWidth = 300
        Me.MD_RealOutGU05.Location = New System.Drawing.Point(1029, 219)
        Me.MD_RealOutGU05.Name = "MD_RealOutGU05"
        Me.MD_RealOutGU05.NumberOfDigits = 5
        Me.MD_RealOutGU05.PLCAddressKeypad = ""
        Me.MD_RealOutGU05.PLCAddressValue = "PID_SGU05.OUT"
        Me.MD_RealOutGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU05.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU05.TabIndex = 1093
        Me.MD_RealOutGU05.Value = 0R
        Me.MD_RealOutGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU04
        '
        Me.MD_ProcenOutGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU04.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU04.DecimalPosition = 0
        Me.MD_ProcenOutGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU04.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU04.KeypadMinValue = 0R
        Me.MD_ProcenOutGU04.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU04.KeypadText = Nothing
        Me.MD_ProcenOutGU04.KeypadWidth = 300
        Me.MD_ProcenOutGU04.Location = New System.Drawing.Point(865, 285)
        Me.MD_ProcenOutGU04.Name = "MD_ProcenOutGU04"
        Me.MD_ProcenOutGU04.NumberOfDigits = 5
        Me.MD_ProcenOutGU04.PLCAddressKeypad = "PID_SGU04.SO"
        Me.MD_ProcenOutGU04.PLCAddressValue = "PID_SGU04.SO"
        Me.MD_ProcenOutGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU04.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU04.TabIndex = 1092
        Me.MD_ProcenOutGU04.Value = 0R
        Me.MD_ProcenOutGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU04
        '
        Me.MD_RealOutGU04.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU04.ComComponent = Me.DámperH2
        Me.MD_RealOutGU04.DecimalPosition = 0
        Me.MD_RealOutGU04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU04.KeypadMaxValue = 0R
        Me.MD_RealOutGU04.KeypadMinValue = 0R
        Me.MD_RealOutGU04.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU04.KeypadText = Nothing
        Me.MD_RealOutGU04.KeypadWidth = 300
        Me.MD_RealOutGU04.Location = New System.Drawing.Point(865, 219)
        Me.MD_RealOutGU04.Name = "MD_RealOutGU04"
        Me.MD_RealOutGU04.NumberOfDigits = 5
        Me.MD_RealOutGU04.PLCAddressKeypad = ""
        Me.MD_RealOutGU04.PLCAddressValue = "PID_SGU04.OUT"
        Me.MD_RealOutGU04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU04.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU04.TabIndex = 1091
        Me.MD_RealOutGU04.Value = 0R
        Me.MD_RealOutGU04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU03
        '
        Me.MD_ProcenOutGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU03.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU03.DecimalPosition = 0
        Me.MD_ProcenOutGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU03.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU03.KeypadMinValue = 0R
        Me.MD_ProcenOutGU03.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU03.KeypadText = Nothing
        Me.MD_ProcenOutGU03.KeypadWidth = 300
        Me.MD_ProcenOutGU03.Location = New System.Drawing.Point(700, 285)
        Me.MD_ProcenOutGU03.Name = "MD_ProcenOutGU03"
        Me.MD_ProcenOutGU03.NumberOfDigits = 5
        Me.MD_ProcenOutGU03.PLCAddressKeypad = "PID_SGU03.SO"
        Me.MD_ProcenOutGU03.PLCAddressValue = "PID_SGU03.SO"
        Me.MD_ProcenOutGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU03.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU03.TabIndex = 1090
        Me.MD_ProcenOutGU03.Value = 0R
        Me.MD_ProcenOutGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU03
        '
        Me.MD_RealOutGU03.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU03.ComComponent = Me.DámperH2
        Me.MD_RealOutGU03.DecimalPosition = 0
        Me.MD_RealOutGU03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU03.KeypadMaxValue = 0R
        Me.MD_RealOutGU03.KeypadMinValue = 0R
        Me.MD_RealOutGU03.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU03.KeypadText = Nothing
        Me.MD_RealOutGU03.KeypadWidth = 300
        Me.MD_RealOutGU03.Location = New System.Drawing.Point(700, 219)
        Me.MD_RealOutGU03.Name = "MD_RealOutGU03"
        Me.MD_RealOutGU03.NumberOfDigits = 5
        Me.MD_RealOutGU03.PLCAddressKeypad = ""
        Me.MD_RealOutGU03.PLCAddressValue = "PID_SGU03.OUT"
        Me.MD_RealOutGU03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU03.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU03.TabIndex = 1089
        Me.MD_RealOutGU03.Value = 0R
        Me.MD_RealOutGU03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_BloqueoGU08
        '
        Me.BP_BloqueoGU08.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU08.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU08.Highlight = False
        Me.BP_BloqueoGU08.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU08.Location = New System.Drawing.Point(541, 671)
        Me.BP_BloqueoGU08.MaximumHoldTime = 3000
        Me.BP_BloqueoGU08.MinimumHoldTime = 500
        Me.BP_BloqueoGU08.Name = "BP_BloqueoGU08"
        Me.BP_BloqueoGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU08.PLCAddressClick = "BLOQUEO_SGU08"
        Me.BP_BloqueoGU08.PLCAddressHighlightX = "BLOQUEO_SGU08"
        Me.BP_BloqueoGU08.PLCAddressSelectTextAlternate = "BLOQUEO_SGU08"
        Me.BP_BloqueoGU08.SelectTextAlternate = False
        Me.BP_BloqueoGU08.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU08.TabIndex = 1088
        Me.BP_BloqueoGU08.Text = "Bloquear"
        Me.BP_BloqueoGU08.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU08.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU08.ValueToWrite = 0
        '
        'BP_ManualGU08
        '
        Me.BP_ManualGU08.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU08.ComComponent = Me.DámperH2
        Me.BP_ManualGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU08.Highlight = False
        Me.BP_ManualGU08.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU08.Location = New System.Drawing.Point(540, 620)
        Me.BP_ManualGU08.MaximumHoldTime = 3000
        Me.BP_ManualGU08.MinimumHoldTime = 500
        Me.BP_ManualGU08.Name = "BP_ManualGU08"
        Me.BP_ManualGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU08.PLCAddressClick = "BP_SGU08"
        Me.BP_ManualGU08.PLCAddressHighlightX = "BP_SGU08"
        Me.BP_ManualGU08.PLCAddressSelectTextAlternate = "BP_SGU08"
        Me.BP_ManualGU08.SelectTextAlternate = False
        Me.BP_ManualGU08.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU08.TabIndex = 1087
        Me.BP_ManualGU08.Text = "Automático"
        Me.BP_ManualGU08.TextAlternate = "Manual"
        Me.BP_ManualGU08.UseVisualStyleBackColor = True
        Me.BP_ManualGU08.ValueToWrite = 0
        '
        'BP_LuzGU08
        '
        Me.BP_LuzGU08.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU08.ComComponent = Me.DámperH2
        Me.BP_LuzGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU08.Highlight = False
        Me.BP_LuzGU08.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU08.Location = New System.Drawing.Point(539, 421)
        Me.BP_LuzGU08.MaximumHoldTime = 3000
        Me.BP_LuzGU08.MinimumHoldTime = 500
        Me.BP_LuzGU08.Name = "BP_LuzGU08"
        Me.BP_LuzGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU08.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU08"
        Me.BP_LuzGU08.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU08"
        Me.BP_LuzGU08.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU08"
        Me.BP_LuzGU08.SelectTextAlternate = False
        Me.BP_LuzGU08.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU08.TabIndex = 1086
        Me.BP_LuzGU08.Text = "Encender"
        Me.BP_LuzGU08.TextAlternate = "Encendido"
        Me.BP_LuzGU08.UseVisualStyleBackColor = True
        Me.BP_LuzGU08.ValueToWrite = 0
        '
        'BP_BloqueoGU07
        '
        Me.BP_BloqueoGU07.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU07.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU07.Highlight = False
        Me.BP_BloqueoGU07.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU07.Location = New System.Drawing.Point(376, 671)
        Me.BP_BloqueoGU07.MaximumHoldTime = 3000
        Me.BP_BloqueoGU07.MinimumHoldTime = 500
        Me.BP_BloqueoGU07.Name = "BP_BloqueoGU07"
        Me.BP_BloqueoGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU07.PLCAddressClick = "BLOQUEO_SGU07"
        Me.BP_BloqueoGU07.PLCAddressHighlightX = "BLOQUEO_SGU07"
        Me.BP_BloqueoGU07.PLCAddressSelectTextAlternate = "BLOQUEO_SGU07"
        Me.BP_BloqueoGU07.SelectTextAlternate = False
        Me.BP_BloqueoGU07.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU07.TabIndex = 1085
        Me.BP_BloqueoGU07.Text = "Bloquear"
        Me.BP_BloqueoGU07.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU07.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU07.ValueToWrite = 0
        '
        'BP_ManualGU07
        '
        Me.BP_ManualGU07.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU07.ComComponent = Me.DámperH2
        Me.BP_ManualGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU07.Highlight = False
        Me.BP_ManualGU07.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU07.Location = New System.Drawing.Point(376, 620)
        Me.BP_ManualGU07.MaximumHoldTime = 3000
        Me.BP_ManualGU07.MinimumHoldTime = 500
        Me.BP_ManualGU07.Name = "BP_ManualGU07"
        Me.BP_ManualGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU07.PLCAddressClick = "BP_SGU07"
        Me.BP_ManualGU07.PLCAddressHighlightX = "BP_SGU07"
        Me.BP_ManualGU07.PLCAddressSelectTextAlternate = "BP_SGU07"
        Me.BP_ManualGU07.SelectTextAlternate = False
        Me.BP_ManualGU07.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU07.TabIndex = 1084
        Me.BP_ManualGU07.Text = "Automático"
        Me.BP_ManualGU07.TextAlternate = "Manual"
        Me.BP_ManualGU07.UseVisualStyleBackColor = True
        Me.BP_ManualGU07.ValueToWrite = 0
        '
        'BP_LuzGU07
        '
        Me.BP_LuzGU07.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU07.ComComponent = Me.DámperH2
        Me.BP_LuzGU07.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU07.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU07.Highlight = False
        Me.BP_LuzGU07.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU07.Location = New System.Drawing.Point(374, 421)
        Me.BP_LuzGU07.MaximumHoldTime = 3000
        Me.BP_LuzGU07.MinimumHoldTime = 500
        Me.BP_LuzGU07.Name = "BP_LuzGU07"
        Me.BP_LuzGU07.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU07.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU07"
        Me.BP_LuzGU07.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU07"
        Me.BP_LuzGU07.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU07"
        Me.BP_LuzGU07.SelectTextAlternate = False
        Me.BP_LuzGU07.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU07.TabIndex = 1083
        Me.BP_LuzGU07.Text = "Encender"
        Me.BP_LuzGU07.TextAlternate = "Encendido"
        Me.BP_LuzGU07.UseVisualStyleBackColor = True
        Me.BP_LuzGU07.ValueToWrite = 0
        '
        'BP_BloqueoGU06
        '
        Me.BP_BloqueoGU06.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU06.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU06.Highlight = False
        Me.BP_BloqueoGU06.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU06.Location = New System.Drawing.Point(208, 671)
        Me.BP_BloqueoGU06.MaximumHoldTime = 3000
        Me.BP_BloqueoGU06.MinimumHoldTime = 500
        Me.BP_BloqueoGU06.Name = "BP_BloqueoGU06"
        Me.BP_BloqueoGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU06.PLCAddressClick = "BLOQUEO_SGU06"
        Me.BP_BloqueoGU06.PLCAddressHighlightX = "BLOQUEO_SGU06"
        Me.BP_BloqueoGU06.PLCAddressSelectTextAlternate = "BLOQUEO_SGU06"
        Me.BP_BloqueoGU06.SelectTextAlternate = False
        Me.BP_BloqueoGU06.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU06.TabIndex = 1082
        Me.BP_BloqueoGU06.Text = "Bloquear"
        Me.BP_BloqueoGU06.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU06.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU06.ValueToWrite = 0
        '
        'BP_ManualGU06
        '
        Me.BP_ManualGU06.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU06.ComComponent = Me.DámperH2
        Me.BP_ManualGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU06.Highlight = False
        Me.BP_ManualGU06.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU06.Location = New System.Drawing.Point(208, 620)
        Me.BP_ManualGU06.MaximumHoldTime = 3000
        Me.BP_ManualGU06.MinimumHoldTime = 500
        Me.BP_ManualGU06.Name = "BP_ManualGU06"
        Me.BP_ManualGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU06.PLCAddressClick = "BP_SGU06"
        Me.BP_ManualGU06.PLCAddressHighlightX = "BP_SGU06"
        Me.BP_ManualGU06.PLCAddressSelectTextAlternate = "BP_SGU06"
        Me.BP_ManualGU06.SelectTextAlternate = False
        Me.BP_ManualGU06.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU06.TabIndex = 1081
        Me.BP_ManualGU06.Text = "Automático"
        Me.BP_ManualGU06.TextAlternate = "Manual"
        Me.BP_ManualGU06.UseVisualStyleBackColor = True
        Me.BP_ManualGU06.ValueToWrite = 0
        '
        'BP_LuzGU06
        '
        Me.BP_LuzGU06.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU06.ComComponent = Me.DámperH2
        Me.BP_LuzGU06.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU06.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU06.Highlight = False
        Me.BP_LuzGU06.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU06.Location = New System.Drawing.Point(211, 421)
        Me.BP_LuzGU06.MaximumHoldTime = 3000
        Me.BP_LuzGU06.MinimumHoldTime = 500
        Me.BP_LuzGU06.Name = "BP_LuzGU06"
        Me.BP_LuzGU06.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU06.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU06"
        Me.BP_LuzGU06.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU06"
        Me.BP_LuzGU06.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU06"
        Me.BP_LuzGU06.SelectTextAlternate = False
        Me.BP_LuzGU06.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU06.TabIndex = 1080
        Me.BP_LuzGU06.Text = "Encender"
        Me.BP_LuzGU06.TextAlternate = "Encendido"
        Me.BP_LuzGU06.UseVisualStyleBackColor = True
        Me.BP_LuzGU06.ValueToWrite = 0
        '
        'BP_BloqueoGU05
        '
        Me.BP_BloqueoGU05.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU05.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU05.Highlight = False
        Me.BP_BloqueoGU05.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU05.Location = New System.Drawing.Point(1028, 383)
        Me.BP_BloqueoGU05.MaximumHoldTime = 3000
        Me.BP_BloqueoGU05.MinimumHoldTime = 500
        Me.BP_BloqueoGU05.Name = "BP_BloqueoGU05"
        Me.BP_BloqueoGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU05.PLCAddressClick = "BLOQUEO_SGU05"
        Me.BP_BloqueoGU05.PLCAddressHighlightX = "BLOQUEO_SGU05"
        Me.BP_BloqueoGU05.PLCAddressSelectTextAlternate = "BLOQUEO_SGU05"
        Me.BP_BloqueoGU05.SelectTextAlternate = False
        Me.BP_BloqueoGU05.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU05.TabIndex = 1079
        Me.BP_BloqueoGU05.Text = "Bloquear"
        Me.BP_BloqueoGU05.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU05.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU05.ValueToWrite = 0
        '
        'BP_ManualGU05
        '
        Me.BP_ManualGU05.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU05.ComComponent = Me.DámperH2
        Me.BP_ManualGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU05.Highlight = False
        Me.BP_ManualGU05.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU05.Location = New System.Drawing.Point(1028, 332)
        Me.BP_ManualGU05.MaximumHoldTime = 3000
        Me.BP_ManualGU05.MinimumHoldTime = 500
        Me.BP_ManualGU05.Name = "BP_ManualGU05"
        Me.BP_ManualGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU05.PLCAddressClick = "BP_SGU05"
        Me.BP_ManualGU05.PLCAddressHighlightX = "BP_SGU05"
        Me.BP_ManualGU05.PLCAddressSelectTextAlternate = "BP_SGU05"
        Me.BP_ManualGU05.SelectTextAlternate = False
        Me.BP_ManualGU05.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU05.TabIndex = 1078
        Me.BP_ManualGU05.Text = "Automático"
        Me.BP_ManualGU05.TextAlternate = "Manual"
        Me.BP_ManualGU05.UseVisualStyleBackColor = True
        Me.BP_ManualGU05.ValueToWrite = 0
        '
        'BP_LuzGU05
        '
        Me.BP_LuzGU05.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU05.ComComponent = Me.DámperH2
        Me.BP_LuzGU05.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU05.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU05.Highlight = False
        Me.BP_LuzGU05.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU05.Location = New System.Drawing.Point(1031, 133)
        Me.BP_LuzGU05.MaximumHoldTime = 3000
        Me.BP_LuzGU05.MinimumHoldTime = 500
        Me.BP_LuzGU05.Name = "BP_LuzGU05"
        Me.BP_LuzGU05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU05.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU05"
        Me.BP_LuzGU05.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU05"
        Me.BP_LuzGU05.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU05"
        Me.BP_LuzGU05.SelectTextAlternate = False
        Me.BP_LuzGU05.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU05.TabIndex = 1077
        Me.BP_LuzGU05.Text = "Encender"
        Me.BP_LuzGU05.TextAlternate = "Encendido"
        Me.BP_LuzGU05.UseVisualStyleBackColor = True
        Me.BP_LuzGU05.ValueToWrite = 0
        '
        'BP_BloqueoGU04
        '
        Me.BP_BloqueoGU04.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU04.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU04.Highlight = False
        Me.BP_BloqueoGU04.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU04.Location = New System.Drawing.Point(864, 383)
        Me.BP_BloqueoGU04.MaximumHoldTime = 3000
        Me.BP_BloqueoGU04.MinimumHoldTime = 500
        Me.BP_BloqueoGU04.Name = "BP_BloqueoGU04"
        Me.BP_BloqueoGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU04.PLCAddressClick = "BLOQUEO_SGU04"
        Me.BP_BloqueoGU04.PLCAddressHighlightX = "BLOQUEO_SGU04"
        Me.BP_BloqueoGU04.PLCAddressSelectTextAlternate = "BLOQUEO_SGU04"
        Me.BP_BloqueoGU04.SelectTextAlternate = False
        Me.BP_BloqueoGU04.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU04.TabIndex = 1076
        Me.BP_BloqueoGU04.Text = "Bloquear"
        Me.BP_BloqueoGU04.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU04.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU04.ValueToWrite = 0
        '
        'BP_ManualGU04
        '
        Me.BP_ManualGU04.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU04.ComComponent = Me.DámperH2
        Me.BP_ManualGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU04.Highlight = False
        Me.BP_ManualGU04.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU04.Location = New System.Drawing.Point(864, 332)
        Me.BP_ManualGU04.MaximumHoldTime = 3000
        Me.BP_ManualGU04.MinimumHoldTime = 500
        Me.BP_ManualGU04.Name = "BP_ManualGU04"
        Me.BP_ManualGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU04.PLCAddressClick = "BP_SGU04"
        Me.BP_ManualGU04.PLCAddressHighlightX = "BP_SGU04"
        Me.BP_ManualGU04.PLCAddressSelectTextAlternate = "BP_SGU04"
        Me.BP_ManualGU04.SelectTextAlternate = False
        Me.BP_ManualGU04.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU04.TabIndex = 1075
        Me.BP_ManualGU04.Text = "Automático"
        Me.BP_ManualGU04.TextAlternate = "Manual"
        Me.BP_ManualGU04.UseVisualStyleBackColor = True
        Me.BP_ManualGU04.ValueToWrite = 0
        '
        'BP_LuzGU04
        '
        Me.BP_LuzGU04.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU04.ComComponent = Me.DámperH2
        Me.BP_LuzGU04.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU04.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU04.Highlight = False
        Me.BP_LuzGU04.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU04.Location = New System.Drawing.Point(867, 133)
        Me.BP_LuzGU04.MaximumHoldTime = 3000
        Me.BP_LuzGU04.MinimumHoldTime = 500
        Me.BP_LuzGU04.Name = "BP_LuzGU04"
        Me.BP_LuzGU04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU04.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU04"
        Me.BP_LuzGU04.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU04"
        Me.BP_LuzGU04.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU04"
        Me.BP_LuzGU04.SelectTextAlternate = False
        Me.BP_LuzGU04.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU04.TabIndex = 1074
        Me.BP_LuzGU04.Text = "Encender"
        Me.BP_LuzGU04.TextAlternate = "Encendido"
        Me.BP_LuzGU04.UseVisualStyleBackColor = True
        Me.BP_LuzGU04.ValueToWrite = 0
        '
        'BP_BloqueoGU03
        '
        Me.BP_BloqueoGU03.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU03.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU03.Highlight = False
        Me.BP_BloqueoGU03.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU03.Location = New System.Drawing.Point(700, 383)
        Me.BP_BloqueoGU03.MaximumHoldTime = 3000
        Me.BP_BloqueoGU03.MinimumHoldTime = 500
        Me.BP_BloqueoGU03.Name = "BP_BloqueoGU03"
        Me.BP_BloqueoGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU03.PLCAddressClick = "BLOQUEO_SGU03"
        Me.BP_BloqueoGU03.PLCAddressHighlightX = "BLOQUEO_SGU03"
        Me.BP_BloqueoGU03.PLCAddressSelectTextAlternate = "BLOQUEO_SGU03"
        Me.BP_BloqueoGU03.SelectTextAlternate = False
        Me.BP_BloqueoGU03.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU03.TabIndex = 1073
        Me.BP_BloqueoGU03.Text = "Bloquear"
        Me.BP_BloqueoGU03.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU03.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU03.ValueToWrite = 0
        '
        'BP_ManualGU03
        '
        Me.BP_ManualGU03.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU03.ComComponent = Me.DámperH2
        Me.BP_ManualGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU03.Highlight = False
        Me.BP_ManualGU03.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU03.Location = New System.Drawing.Point(700, 332)
        Me.BP_ManualGU03.MaximumHoldTime = 3000
        Me.BP_ManualGU03.MinimumHoldTime = 500
        Me.BP_ManualGU03.Name = "BP_ManualGU03"
        Me.BP_ManualGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU03.PLCAddressClick = "BP_SGU03"
        Me.BP_ManualGU03.PLCAddressHighlightX = "BP_SGU03"
        Me.BP_ManualGU03.PLCAddressSelectTextAlternate = "BP_SGU03"
        Me.BP_ManualGU03.SelectTextAlternate = False
        Me.BP_ManualGU03.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU03.TabIndex = 1072
        Me.BP_ManualGU03.Text = "Automático"
        Me.BP_ManualGU03.TextAlternate = "Manual"
        Me.BP_ManualGU03.UseVisualStyleBackColor = True
        Me.BP_ManualGU03.ValueToWrite = 0
        '
        'BP_LuzGU03
        '
        Me.BP_LuzGU03.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU03.ComComponent = Me.DámperH2
        Me.BP_LuzGU03.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU03.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU03.Highlight = False
        Me.BP_LuzGU03.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU03.Location = New System.Drawing.Point(703, 133)
        Me.BP_LuzGU03.MaximumHoldTime = 3000
        Me.BP_LuzGU03.MinimumHoldTime = 500
        Me.BP_LuzGU03.Name = "BP_LuzGU03"
        Me.BP_LuzGU03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU03.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU03"
        Me.BP_LuzGU03.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU03"
        Me.BP_LuzGU03.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU03"
        Me.BP_LuzGU03.SelectTextAlternate = False
        Me.BP_LuzGU03.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU03.TabIndex = 1071
        Me.BP_LuzGU03.Text = "Encender"
        Me.BP_LuzGU03.TextAlternate = "Encendido"
        Me.BP_LuzGU03.UseVisualStyleBackColor = True
        Me.BP_LuzGU03.ValueToWrite = 0
        '
        'BP_BloqueoGU02
        '
        Me.BP_BloqueoGU02.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU02.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU02.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU02.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU02.Highlight = False
        Me.BP_BloqueoGU02.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU02.Location = New System.Drawing.Point(536, 383)
        Me.BP_BloqueoGU02.MaximumHoldTime = 3000
        Me.BP_BloqueoGU02.MinimumHoldTime = 500
        Me.BP_BloqueoGU02.Name = "BP_BloqueoGU02"
        Me.BP_BloqueoGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU02.PLCAddressClick = "BLOQUEO_SGU02"
        Me.BP_BloqueoGU02.PLCAddressHighlightX = "BLOQUEO_SGU02"
        Me.BP_BloqueoGU02.PLCAddressSelectTextAlternate = "BLOQUEO_SGU02"
        Me.BP_BloqueoGU02.SelectTextAlternate = False
        Me.BP_BloqueoGU02.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU02.TabIndex = 1070
        Me.BP_BloqueoGU02.Text = "Bloquear"
        Me.BP_BloqueoGU02.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU02.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU02.ValueToWrite = 0
        '
        'BP_ManualGU02
        '
        Me.BP_ManualGU02.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU02.ComComponent = Me.DámperH2
        Me.BP_ManualGU02.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU02.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU02.Highlight = False
        Me.BP_ManualGU02.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU02.Location = New System.Drawing.Point(536, 332)
        Me.BP_ManualGU02.MaximumHoldTime = 3000
        Me.BP_ManualGU02.MinimumHoldTime = 500
        Me.BP_ManualGU02.Name = "BP_ManualGU02"
        Me.BP_ManualGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU02.PLCAddressClick = "BP_SGU02"
        Me.BP_ManualGU02.PLCAddressHighlightX = "BP_SGU02"
        Me.BP_ManualGU02.PLCAddressSelectTextAlternate = "BP_SGU02"
        Me.BP_ManualGU02.SelectTextAlternate = False
        Me.BP_ManualGU02.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU02.TabIndex = 1069
        Me.BP_ManualGU02.Text = "Automático"
        Me.BP_ManualGU02.TextAlternate = "Manual"
        Me.BP_ManualGU02.UseVisualStyleBackColor = True
        Me.BP_ManualGU02.ValueToWrite = 0
        '
        'BP_LuzGU02
        '
        Me.BP_LuzGU02.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU02.ComComponent = Me.DámperH2
        Me.BP_LuzGU02.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU02.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU02.Highlight = False
        Me.BP_LuzGU02.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU02.Location = New System.Drawing.Point(539, 133)
        Me.BP_LuzGU02.MaximumHoldTime = 3000
        Me.BP_LuzGU02.MinimumHoldTime = 500
        Me.BP_LuzGU02.Name = "BP_LuzGU02"
        Me.BP_LuzGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU02.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU02"
        Me.BP_LuzGU02.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU02"
        Me.BP_LuzGU02.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU02"
        Me.BP_LuzGU02.SelectTextAlternate = False
        Me.BP_LuzGU02.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU02.TabIndex = 1068
        Me.BP_LuzGU02.Text = "Encender"
        Me.BP_LuzGU02.TextAlternate = "Encendido"
        Me.BP_LuzGU02.UseVisualStyleBackColor = True
        Me.BP_LuzGU02.ValueToWrite = 0
        '
        'MD_ProcenOutGU02
        '
        Me.MD_ProcenOutGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU02.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU02.DecimalPosition = 0
        Me.MD_ProcenOutGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU02.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU02.KeypadMinValue = 0R
        Me.MD_ProcenOutGU02.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU02.KeypadText = Nothing
        Me.MD_ProcenOutGU02.KeypadWidth = 300
        Me.MD_ProcenOutGU02.Location = New System.Drawing.Point(537, 285)
        Me.MD_ProcenOutGU02.Name = "MD_ProcenOutGU02"
        Me.MD_ProcenOutGU02.NumberOfDigits = 5
        Me.MD_ProcenOutGU02.PLCAddressKeypad = "PID_SGU02.SO"
        Me.MD_ProcenOutGU02.PLCAddressValue = "PID_SGU02.SO"
        Me.MD_ProcenOutGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU02.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU02.TabIndex = 1067
        Me.MD_ProcenOutGU02.Value = 0R
        Me.MD_ProcenOutGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU02
        '
        Me.MD_RealOutGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU02.ComComponent = Me.DámperH2
        Me.MD_RealOutGU02.DecimalPosition = 0
        Me.MD_RealOutGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU02.KeypadMaxValue = 0R
        Me.MD_RealOutGU02.KeypadMinValue = 0R
        Me.MD_RealOutGU02.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU02.KeypadText = Nothing
        Me.MD_RealOutGU02.KeypadWidth = 300
        Me.MD_RealOutGU02.Location = New System.Drawing.Point(537, 219)
        Me.MD_RealOutGU02.Name = "MD_RealOutGU02"
        Me.MD_RealOutGU02.NumberOfDigits = 5
        Me.MD_RealOutGU02.PLCAddressKeypad = ""
        Me.MD_RealOutGU02.PLCAddressValue = "PID_SGU02.OUT"
        Me.MD_RealOutGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU02.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU02.TabIndex = 1066
        Me.MD_RealOutGU02.Value = 0R
        Me.MD_RealOutGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU01
        '
        Me.MD_ProcenOutGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU01.ComComponent = Me.DámperH2
        Me.MD_ProcenOutGU01.DecimalPosition = 0
        Me.MD_ProcenOutGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU01.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU01.KeypadMinValue = 0R
        Me.MD_ProcenOutGU01.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU01.KeypadText = Nothing
        Me.MD_ProcenOutGU01.KeypadWidth = 300
        Me.MD_ProcenOutGU01.Location = New System.Drawing.Point(373, 285)
        Me.MD_ProcenOutGU01.Name = "MD_ProcenOutGU01"
        Me.MD_ProcenOutGU01.NumberOfDigits = 5
        Me.MD_ProcenOutGU01.PLCAddressKeypad = "PID_SGU01.SO"
        Me.MD_ProcenOutGU01.PLCAddressValue = "PID_SGU01.SO"
        Me.MD_ProcenOutGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU01.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU01.TabIndex = 1065
        Me.MD_ProcenOutGU01.Value = 0R
        Me.MD_ProcenOutGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU01
        '
        Me.MD_RealOutGU01.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU01.ComComponent = Me.DámperH2
        Me.MD_RealOutGU01.DecimalPosition = 0
        Me.MD_RealOutGU01.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU01.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU01.KeypadMaxValue = 0R
        Me.MD_RealOutGU01.KeypadMinValue = 0R
        Me.MD_RealOutGU01.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU01.KeypadText = Nothing
        Me.MD_RealOutGU01.KeypadWidth = 300
        Me.MD_RealOutGU01.Location = New System.Drawing.Point(373, 219)
        Me.MD_RealOutGU01.Name = "MD_RealOutGU01"
        Me.MD_RealOutGU01.NumberOfDigits = 5
        Me.MD_RealOutGU01.PLCAddressKeypad = ""
        Me.MD_RealOutGU01.PLCAddressValue = "PID_SGU01.OUT"
        Me.MD_RealOutGU01.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU01.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU01.TabIndex = 1064
        Me.MD_RealOutGU01.Value = 0R
        Me.MD_RealOutGU01.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU01.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_BloqueoGU01
        '
        Me.BP_BloqueoGU01.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU01.ComComponent = Me.DámperH2
        Me.BP_BloqueoGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU01.Highlight = False
        Me.BP_BloqueoGU01.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU01.Location = New System.Drawing.Point(372, 383)
        Me.BP_BloqueoGU01.MaximumHoldTime = 3000
        Me.BP_BloqueoGU01.MinimumHoldTime = 500
        Me.BP_BloqueoGU01.Name = "BP_BloqueoGU01"
        Me.BP_BloqueoGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU01.PLCAddressClick = "BLOQUEO_SGU01"
        Me.BP_BloqueoGU01.PLCAddressHighlightX = "BLOQUEO_SGU01"
        Me.BP_BloqueoGU01.PLCAddressSelectTextAlternate = "BLOQUEO_SGU01"
        Me.BP_BloqueoGU01.SelectTextAlternate = False
        Me.BP_BloqueoGU01.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU01.TabIndex = 1063
        Me.BP_BloqueoGU01.Text = "Bloquear"
        Me.BP_BloqueoGU01.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU01.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU01.ValueToWrite = 0
        '
        'BP_ManualGU01
        '
        Me.BP_ManualGU01.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU01.ComComponent = Me.DámperH2
        Me.BP_ManualGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU01.Highlight = False
        Me.BP_ManualGU01.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU01.Location = New System.Drawing.Point(372, 332)
        Me.BP_ManualGU01.MaximumHoldTime = 3000
        Me.BP_ManualGU01.MinimumHoldTime = 500
        Me.BP_ManualGU01.Name = "BP_ManualGU01"
        Me.BP_ManualGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU01.PLCAddressClick = "BP_SGU01"
        Me.BP_ManualGU01.PLCAddressHighlightX = "BP_SGU01"
        Me.BP_ManualGU01.PLCAddressSelectTextAlternate = "BP_SGU01"
        Me.BP_ManualGU01.SelectTextAlternate = False
        Me.BP_ManualGU01.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU01.TabIndex = 1062
        Me.BP_ManualGU01.Text = "Automático"
        Me.BP_ManualGU01.TextAlternate = "Manual"
        Me.BP_ManualGU01.UseVisualStyleBackColor = False
        Me.BP_ManualGU01.ValueToWrite = 0
        '
        'BP_LuzGU01
        '
        Me.BP_LuzGU01.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU01.ComComponent = Me.DámperH2
        Me.BP_LuzGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU01.Highlight = False
        Me.BP_LuzGU01.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU01.Location = New System.Drawing.Point(375, 133)
        Me.BP_LuzGU01.MaximumHoldTime = 3000
        Me.BP_LuzGU01.MinimumHoldTime = 500
        Me.BP_LuzGU01.Name = "BP_LuzGU01"
        Me.BP_LuzGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU01.PLCAddressClick = "MANUAL_LUZ_INDICADORA_SGU01"
        Me.BP_LuzGU01.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_SGU01"
        Me.BP_LuzGU01.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_SGU01"
        Me.BP_LuzGU01.SelectTextAlternate = False
        Me.BP_LuzGU01.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU01.TabIndex = 1061
        Me.BP_LuzGU01.Text = "Encender"
        Me.BP_LuzGU01.TextAlternate = "Encendido"
        Me.BP_LuzGU01.UseVisualStyleBackColor = True
        Me.BP_LuzGU01.ValueToWrite = 0
        '
        'BP_ManualH2
        '
        Me.BP_ManualH2.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualH2.ComComponent = Me.DámperH2
        Me.BP_ManualH2.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualH2.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualH2.Highlight = False
        Me.BP_ManualH2.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualH2.Location = New System.Drawing.Point(209, 332)
        Me.BP_ManualH2.MaximumHoldTime = 3000
        Me.BP_ManualH2.MinimumHoldTime = 500
        Me.BP_ManualH2.Name = "BP_ManualH2"
        Me.BP_ManualH2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualH2.PLCAddressClick = "BP_PID_MANUAL"
        Me.BP_ManualH2.SelectTextAlternate = False
        Me.BP_ManualH2.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualH2.TabIndex = 1060
        Me.BP_ManualH2.Text = "Automático"
        Me.BP_ManualH2.TextAlternate = "Manual"
        Me.BP_ManualH2.UseVisualStyleBackColor = True
        Me.BP_ManualH2.ValueToWrite = 0
        '
        'MD_ProcenOutH2
        '
        Me.MD_ProcenOutH2.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutH2.ComComponent = Me.DámperH2
        Me.MD_ProcenOutH2.DecimalPosition = 0
        Me.MD_ProcenOutH2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutH2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutH2.KeypadMaxValue = 0R
        Me.MD_ProcenOutH2.KeypadMinValue = 0R
        Me.MD_ProcenOutH2.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutH2.KeypadText = Nothing
        Me.MD_ProcenOutH2.KeypadWidth = 300
        Me.MD_ProcenOutH2.Location = New System.Drawing.Point(209, 285)
        Me.MD_ProcenOutH2.Name = "MD_ProcenOutH2"
        Me.MD_ProcenOutH2.NumberOfDigits = 5
        Me.MD_ProcenOutH2.PLCAddressKeypad = "PID_HORNO.SO"
        Me.MD_ProcenOutH2.PLCAddressValue = "PID_HORNO.SO"
        Me.MD_ProcenOutH2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutH2.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutH2.TabIndex = 1059
        Me.MD_ProcenOutH2.Value = 0R
        Me.MD_ProcenOutH2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutH2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutH2
        '
        Me.MD_RealOutH2.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutH2.ComComponent = Me.DámperH2
        Me.MD_RealOutH2.DecimalPosition = 0
        Me.MD_RealOutH2.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutH2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutH2.KeypadMaxValue = 0R
        Me.MD_RealOutH2.KeypadMinValue = 0R
        Me.MD_RealOutH2.KeypadScaleFactor = 1.0R
        Me.MD_RealOutH2.KeypadText = Nothing
        Me.MD_RealOutH2.KeypadWidth = 300
        Me.MD_RealOutH2.Location = New System.Drawing.Point(209, 219)
        Me.MD_RealOutH2.Name = "MD_RealOutH2"
        Me.MD_RealOutH2.NumberOfDigits = 5
        Me.MD_RealOutH2.PLCAddressKeypad = ""
        Me.MD_RealOutH2.PLCAddressValue = "PID_HORNO.OUT"
        Me.MD_RealOutH2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutH2.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutH2.TabIndex = 1058
        Me.MD_RealOutH2.Value = 0R
        Me.MD_RealOutH2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutH2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexProcenOutGU08
        '
        Me.TexProcenOutGU08.AutoSize = True
        Me.TexProcenOutGU08.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU08.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU08.Location = New System.Drawing.Point(552, 551)
        Me.TexProcenOutGU08.Name = "TexProcenOutGU08"
        Me.TexProcenOutGU08.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU08.TabIndex = 1057
        Me.TexProcenOutGU08.Text = "% Salida"
        '
        'TexRealOutGU08
        '
        Me.TexRealOutGU08.AutoSize = True
        Me.TexRealOutGU08.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU08.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU08.Location = New System.Drawing.Point(568, 486)
        Me.TexRealOutGU08.Name = "TexRealOutGU08"
        Me.TexRealOutGU08.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU08.TabIndex = 1056
        Me.TexRealOutGU08.Text = "Real"
        '
        'TexOutGU08
        '
        Me.TexOutGU08.AutoSize = True
        Me.TexOutGU08.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU08.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU08.Location = New System.Drawing.Point(537, 465)
        Me.TexOutGU08.Name = "TexOutGU08"
        Me.TexOutGU08.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU08.TabIndex = 1055
        Me.TexOutGU08.Text = "Guardiola 08"
        '
        'TexProcenOutGU07
        '
        Me.TexProcenOutGU07.AutoSize = True
        Me.TexProcenOutGU07.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU07.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU07.Location = New System.Drawing.Point(387, 551)
        Me.TexProcenOutGU07.Name = "TexProcenOutGU07"
        Me.TexProcenOutGU07.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU07.TabIndex = 1054
        Me.TexProcenOutGU07.Text = "% Salida"
        '
        'TexRealOutGU07
        '
        Me.TexRealOutGU07.AutoSize = True
        Me.TexRealOutGU07.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU07.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU07.Location = New System.Drawing.Point(403, 486)
        Me.TexRealOutGU07.Name = "TexRealOutGU07"
        Me.TexRealOutGU07.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU07.TabIndex = 1053
        Me.TexRealOutGU07.Text = "Real"
        '
        'TexOutGU07
        '
        Me.TexOutGU07.AutoSize = True
        Me.TexOutGU07.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU07.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU07.Location = New System.Drawing.Point(372, 465)
        Me.TexOutGU07.Name = "TexOutGU07"
        Me.TexOutGU07.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU07.TabIndex = 1052
        Me.TexOutGU07.Text = "Guardiola 07"
        '
        'TexProcenOutGU06
        '
        Me.TexProcenOutGU06.AutoSize = True
        Me.TexProcenOutGU06.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU06.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU06.Location = New System.Drawing.Point(221, 551)
        Me.TexProcenOutGU06.Name = "TexProcenOutGU06"
        Me.TexProcenOutGU06.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU06.TabIndex = 1051
        Me.TexProcenOutGU06.Text = "% Salida"
        '
        'TexRealOutGU06
        '
        Me.TexRealOutGU06.AutoSize = True
        Me.TexRealOutGU06.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU06.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU06.Location = New System.Drawing.Point(237, 486)
        Me.TexRealOutGU06.Name = "TexRealOutGU06"
        Me.TexRealOutGU06.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU06.TabIndex = 1050
        Me.TexRealOutGU06.Text = "Real"
        '
        'TexOutGU06
        '
        Me.TexOutGU06.AutoSize = True
        Me.TexOutGU06.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU06.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU06.Location = New System.Drawing.Point(206, 465)
        Me.TexOutGU06.Name = "TexOutGU06"
        Me.TexOutGU06.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU06.TabIndex = 1049
        Me.TexOutGU06.Text = "Guardiola 06"
        '
        'TexProcenOutGU05
        '
        Me.TexProcenOutGU05.AutoSize = True
        Me.TexProcenOutGU05.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU05.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU05.Location = New System.Drawing.Point(1040, 264)
        Me.TexProcenOutGU05.Name = "TexProcenOutGU05"
        Me.TexProcenOutGU05.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU05.TabIndex = 1045
        Me.TexProcenOutGU05.Text = "% Salida"
        '
        'TexRealOutGU05
        '
        Me.TexRealOutGU05.AutoSize = True
        Me.TexRealOutGU05.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU05.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU05.Location = New System.Drawing.Point(1056, 199)
        Me.TexRealOutGU05.Name = "TexRealOutGU05"
        Me.TexRealOutGU05.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU05.TabIndex = 1044
        Me.TexRealOutGU05.Text = "Real"
        '
        'TexOutGU05
        '
        Me.TexOutGU05.AutoSize = True
        Me.TexOutGU05.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU05.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU05.Location = New System.Drawing.Point(1025, 178)
        Me.TexOutGU05.Name = "TexOutGU05"
        Me.TexOutGU05.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU05.TabIndex = 1043
        Me.TexOutGU05.Text = "Guardiola 05"
        '
        'TexProcenOutGU04
        '
        Me.TexProcenOutGU04.AutoSize = True
        Me.TexProcenOutGU04.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU04.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU04.Location = New System.Drawing.Point(876, 264)
        Me.TexProcenOutGU04.Name = "TexProcenOutGU04"
        Me.TexProcenOutGU04.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU04.TabIndex = 1042
        Me.TexProcenOutGU04.Text = "% Salida"
        '
        'TexRealOutGU04
        '
        Me.TexRealOutGU04.AutoSize = True
        Me.TexRealOutGU04.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU04.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU04.Location = New System.Drawing.Point(892, 199)
        Me.TexRealOutGU04.Name = "TexRealOutGU04"
        Me.TexRealOutGU04.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU04.TabIndex = 1041
        Me.TexRealOutGU04.Text = "Real"
        '
        'TexOutGU04
        '
        Me.TexOutGU04.AutoSize = True
        Me.TexOutGU04.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU04.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU04.Location = New System.Drawing.Point(861, 178)
        Me.TexOutGU04.Name = "TexOutGU04"
        Me.TexOutGU04.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU04.TabIndex = 1040
        Me.TexOutGU04.Text = "Guardiola 04"
        '
        'TexProcenOutGU03
        '
        Me.TexProcenOutGU03.AutoSize = True
        Me.TexProcenOutGU03.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU03.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU03.Location = New System.Drawing.Point(713, 264)
        Me.TexProcenOutGU03.Name = "TexProcenOutGU03"
        Me.TexProcenOutGU03.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU03.TabIndex = 1039
        Me.TexProcenOutGU03.Text = "% Salida"
        '
        'TexRealOutGU03
        '
        Me.TexRealOutGU03.AutoSize = True
        Me.TexRealOutGU03.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU03.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU03.Location = New System.Drawing.Point(729, 199)
        Me.TexRealOutGU03.Name = "TexRealOutGU03"
        Me.TexRealOutGU03.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU03.TabIndex = 1038
        Me.TexRealOutGU03.Text = "Real"
        '
        'TexOutGU03
        '
        Me.TexOutGU03.AutoSize = True
        Me.TexOutGU03.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU03.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU03.Location = New System.Drawing.Point(698, 178)
        Me.TexOutGU03.Name = "TexOutGU03"
        Me.TexOutGU03.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU03.TabIndex = 1037
        Me.TexOutGU03.Text = "Guardiola 03"
        '
        'TexMantH2
        '
        Me.TexMantH2.AutoSize = True
        Me.TexMantH2.BackColor = System.Drawing.Color.DimGray
        Me.TexMantH2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexMantH2.ForeColor = System.Drawing.Color.White
        Me.TexMantH2.Location = New System.Drawing.Point(502, 71)
        Me.TexMantH2.Name = "TexMantH2"
        Me.TexMantH2.Size = New System.Drawing.Size(348, 34)
        Me.TexMantH2.TabIndex = 1033
        Me.TexMantH2.Text = " Mantenimiento Horno 2"
        '
        'TexProcenOutGU02
        '
        Me.TexProcenOutGU02.AutoSize = True
        Me.TexProcenOutGU02.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU02.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU02.Location = New System.Drawing.Point(549, 264)
        Me.TexProcenOutGU02.Name = "TexProcenOutGU02"
        Me.TexProcenOutGU02.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU02.TabIndex = 1032
        Me.TexProcenOutGU02.Text = "% Salida"
        '
        'TexRealOutGU02
        '
        Me.TexRealOutGU02.AutoSize = True
        Me.TexRealOutGU02.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU02.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU02.Location = New System.Drawing.Point(565, 199)
        Me.TexRealOutGU02.Name = "TexRealOutGU02"
        Me.TexRealOutGU02.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU02.TabIndex = 1031
        Me.TexRealOutGU02.Text = "Real"
        '
        'TexOutGU02
        '
        Me.TexOutGU02.AutoSize = True
        Me.TexOutGU02.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU02.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU02.Location = New System.Drawing.Point(534, 178)
        Me.TexOutGU02.Name = "TexOutGU02"
        Me.TexOutGU02.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU02.TabIndex = 1030
        Me.TexOutGU02.Text = "Guardiola 02"
        '
        'TexProcenOutGU01
        '
        Me.TexProcenOutGU01.AutoSize = True
        Me.TexProcenOutGU01.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU01.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU01.Location = New System.Drawing.Point(383, 264)
        Me.TexProcenOutGU01.Name = "TexProcenOutGU01"
        Me.TexProcenOutGU01.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU01.TabIndex = 1028
        Me.TexProcenOutGU01.Text = "% Salida"
        '
        'TexRealOutGU01
        '
        Me.TexRealOutGU01.AutoSize = True
        Me.TexRealOutGU01.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU01.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU01.Location = New System.Drawing.Point(399, 199)
        Me.TexRealOutGU01.Name = "TexRealOutGU01"
        Me.TexRealOutGU01.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU01.TabIndex = 1027
        Me.TexRealOutGU01.Text = "Real"
        '
        'TexOutGU01
        '
        Me.TexOutGU01.AutoSize = True
        Me.TexOutGU01.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU01.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU01.Location = New System.Drawing.Point(368, 178)
        Me.TexOutGU01.Name = "TexOutGU01"
        Me.TexOutGU01.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU01.TabIndex = 1026
        Me.TexOutGU01.Text = "Guardiola 01"
        '
        'TexProcenOutH2
        '
        Me.TexProcenOutH2.AutoSize = True
        Me.TexProcenOutH2.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutH2.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutH2.Location = New System.Drawing.Point(220, 264)
        Me.TexProcenOutH2.Name = "TexProcenOutH2"
        Me.TexProcenOutH2.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutH2.TabIndex = 1024
        Me.TexProcenOutH2.Text = "% Salida"
        '
        'TexRealOutH2
        '
        Me.TexRealOutH2.AutoSize = True
        Me.TexRealOutH2.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutH2.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutH2.Location = New System.Drawing.Point(236, 199)
        Me.TexRealOutH2.Name = "TexRealOutH2"
        Me.TexRealOutH2.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutH2.TabIndex = 1023
        Me.TexRealOutH2.Text = "Real"
        '
        'TexOutH2
        '
        Me.TexOutH2.AutoSize = True
        Me.TexOutH2.BackColor = System.Drawing.Color.Silver
        Me.TexOutH2.ForeColor = System.Drawing.Color.Blue
        Me.TexOutH2.Location = New System.Drawing.Point(218, 178)
        Me.TexOutH2.Name = "TexOutH2"
        Me.TexOutH2.Size = New System.Drawing.Size(72, 18)
        Me.TexOutH2.TabIndex = 1022
        Me.TexOutH2.Text = "Horno 02"
        '
        'IF_OutGU08
        '
        Me.IF_OutGU08.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU08.Location = New System.Drawing.Point(524, 456)
        Me.IF_OutGU08.Name = "IF_OutGU08"
        Me.IF_OutGU08.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU08.TabIndex = 1048
        Me.IF_OutGU08.TabStop = False
        '
        'IF_OutGU07
        '
        Me.IF_OutGU07.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU07.Location = New System.Drawing.Point(360, 456)
        Me.IF_OutGU07.Name = "IF_OutGU07"
        Me.IF_OutGU07.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU07.TabIndex = 1047
        Me.IF_OutGU07.TabStop = False
        '
        'IF_OutGU06
        '
        Me.IF_OutGU06.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU06.Location = New System.Drawing.Point(196, 456)
        Me.IF_OutGU06.Name = "IF_OutGU06"
        Me.IF_OutGU06.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU06.TabIndex = 1046
        Me.IF_OutGU06.TabStop = False
        '
        'IF_OutGU05
        '
        Me.IF_OutGU05.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU05.Location = New System.Drawing.Point(1013, 169)
        Me.IF_OutGU05.Name = "IF_OutGU05"
        Me.IF_OutGU05.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU05.TabIndex = 1036
        Me.IF_OutGU05.TabStop = False
        '
        'IF_OutGU04
        '
        Me.IF_OutGU04.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU04.Location = New System.Drawing.Point(849, 169)
        Me.IF_OutGU04.Name = "IF_OutGU04"
        Me.IF_OutGU04.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU04.TabIndex = 1035
        Me.IF_OutGU04.TabStop = False
        '
        'IF_OutGU03
        '
        Me.IF_OutGU03.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU03.Location = New System.Drawing.Point(685, 169)
        Me.IF_OutGU03.Name = "IF_OutGU03"
        Me.IF_OutGU03.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU03.TabIndex = 1034
        Me.IF_OutGU03.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.PictureBox8.Location = New System.Drawing.Point(521, 169)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(125, 207)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 1029
        Me.PictureBox8.TabStop = False
        '
        'IF_OutGU01
        '
        Me.IF_OutGU01.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU01.Location = New System.Drawing.Point(357, 169)
        Me.IF_OutGU01.Name = "IF_OutGU01"
        Me.IF_OutGU01.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU01.TabIndex = 1025
        Me.IF_OutGU01.TabStop = False
        '
        'IF_OutH2
        '
        Me.IF_OutH2.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutH2.Location = New System.Drawing.Point(193, 169)
        Me.IF_OutH2.Name = "IF_OutH2"
        Me.IF_OutH2.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutH2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutH2.TabIndex = 1021
        Me.IF_OutH2.TabStop = False
        '
        'Dámper_Horno_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.BCF_MenúP_MantH2)
        Me.Controls.Add(Me.MD_ProcenOutGU08)
        Me.Controls.Add(Me.MD_RealOutGU08)
        Me.Controls.Add(Me.MD_ProcenOutGU07)
        Me.Controls.Add(Me.MD_RealOutGU07)
        Me.Controls.Add(Me.MD_ProcenOutGU06)
        Me.Controls.Add(Me.MD_RealOutGU06)
        Me.Controls.Add(Me.MD_ProcenOutGU05)
        Me.Controls.Add(Me.MD_RealOutGU05)
        Me.Controls.Add(Me.MD_ProcenOutGU04)
        Me.Controls.Add(Me.MD_RealOutGU04)
        Me.Controls.Add(Me.MD_ProcenOutGU03)
        Me.Controls.Add(Me.MD_RealOutGU03)
        Me.Controls.Add(Me.BP_BloqueoGU08)
        Me.Controls.Add(Me.BP_ManualGU08)
        Me.Controls.Add(Me.BP_LuzGU08)
        Me.Controls.Add(Me.BP_BloqueoGU07)
        Me.Controls.Add(Me.BP_ManualGU07)
        Me.Controls.Add(Me.BP_LuzGU07)
        Me.Controls.Add(Me.BP_BloqueoGU06)
        Me.Controls.Add(Me.BP_ManualGU06)
        Me.Controls.Add(Me.BP_LuzGU06)
        Me.Controls.Add(Me.BP_BloqueoGU05)
        Me.Controls.Add(Me.BP_ManualGU05)
        Me.Controls.Add(Me.BP_LuzGU05)
        Me.Controls.Add(Me.BP_BloqueoGU04)
        Me.Controls.Add(Me.BP_ManualGU04)
        Me.Controls.Add(Me.BP_LuzGU04)
        Me.Controls.Add(Me.BP_BloqueoGU03)
        Me.Controls.Add(Me.BP_ManualGU03)
        Me.Controls.Add(Me.BP_LuzGU03)
        Me.Controls.Add(Me.BP_BloqueoGU02)
        Me.Controls.Add(Me.BP_ManualGU02)
        Me.Controls.Add(Me.BP_LuzGU02)
        Me.Controls.Add(Me.MD_ProcenOutGU02)
        Me.Controls.Add(Me.MD_RealOutGU02)
        Me.Controls.Add(Me.MD_ProcenOutGU01)
        Me.Controls.Add(Me.MD_RealOutGU01)
        Me.Controls.Add(Me.BP_BloqueoGU01)
        Me.Controls.Add(Me.BP_ManualGU01)
        Me.Controls.Add(Me.BP_LuzGU01)
        Me.Controls.Add(Me.BP_ManualH2)
        Me.Controls.Add(Me.MD_ProcenOutH2)
        Me.Controls.Add(Me.MD_RealOutH2)
        Me.Controls.Add(Me.TexProcenOutGU08)
        Me.Controls.Add(Me.TexRealOutGU08)
        Me.Controls.Add(Me.TexOutGU08)
        Me.Controls.Add(Me.TexProcenOutGU07)
        Me.Controls.Add(Me.TexRealOutGU07)
        Me.Controls.Add(Me.TexOutGU07)
        Me.Controls.Add(Me.TexProcenOutGU06)
        Me.Controls.Add(Me.TexRealOutGU06)
        Me.Controls.Add(Me.TexOutGU06)
        Me.Controls.Add(Me.IF_OutGU08)
        Me.Controls.Add(Me.IF_OutGU07)
        Me.Controls.Add(Me.IF_OutGU06)
        Me.Controls.Add(Me.TexProcenOutGU05)
        Me.Controls.Add(Me.TexRealOutGU05)
        Me.Controls.Add(Me.TexOutGU05)
        Me.Controls.Add(Me.TexProcenOutGU04)
        Me.Controls.Add(Me.TexRealOutGU04)
        Me.Controls.Add(Me.TexOutGU04)
        Me.Controls.Add(Me.TexProcenOutGU03)
        Me.Controls.Add(Me.TexRealOutGU03)
        Me.Controls.Add(Me.TexOutGU03)
        Me.Controls.Add(Me.IF_OutGU05)
        Me.Controls.Add(Me.IF_OutGU04)
        Me.Controls.Add(Me.IF_OutGU03)
        Me.Controls.Add(Me.TexMantH2)
        Me.Controls.Add(Me.TexProcenOutGU02)
        Me.Controls.Add(Me.TexRealOutGU02)
        Me.Controls.Add(Me.TexOutGU02)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.TexProcenOutGU01)
        Me.Controls.Add(Me.TexRealOutGU01)
        Me.Controls.Add(Me.TexOutGU01)
        Me.Controls.Add(Me.IF_OutGU01)
        Me.Controls.Add(Me.TexProcenOutH2)
        Me.Controls.Add(Me.TexRealOutH2)
        Me.Controls.Add(Me.TexOutH2)
        Me.Controls.Add(Me.IF_OutH2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Dámper_Horno_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DámperH2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutH2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents BCF_MenúP_MantH2 As FormChangeButton
    Friend WithEvents MD_ProcenOutGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DámperH2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents MD_RealOutGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU07 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU06 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_BloqueoGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU07 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU06 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU05 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU04 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU03 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU02 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU02 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU02 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_ProcenOutGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU01 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_BloqueoGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualH2 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_ProcenOutH2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutH2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexProcenOutGU08 As Label
    Friend WithEvents TexRealOutGU08 As Label
    Friend WithEvents TexOutGU08 As Label
    Friend WithEvents TexProcenOutGU07 As Label
    Friend WithEvents TexRealOutGU07 As Label
    Friend WithEvents TexOutGU07 As Label
    Friend WithEvents TexProcenOutGU06 As Label
    Friend WithEvents TexRealOutGU06 As Label
    Friend WithEvents TexOutGU06 As Label
    Friend WithEvents IF_OutGU08 As PictureBox
    Friend WithEvents IF_OutGU07 As PictureBox
    Friend WithEvents IF_OutGU06 As PictureBox
    Friend WithEvents TexProcenOutGU05 As Label
    Friend WithEvents TexRealOutGU05 As Label
    Friend WithEvents TexOutGU05 As Label
    Friend WithEvents TexProcenOutGU04 As Label
    Friend WithEvents TexRealOutGU04 As Label
    Friend WithEvents TexOutGU04 As Label
    Friend WithEvents TexProcenOutGU03 As Label
    Friend WithEvents TexRealOutGU03 As Label
    Friend WithEvents TexOutGU03 As Label
    Friend WithEvents IF_OutGU05 As PictureBox
    Friend WithEvents IF_OutGU04 As PictureBox
    Friend WithEvents IF_OutGU03 As PictureBox
    Friend WithEvents TexMantH2 As Label
    Friend WithEvents TexProcenOutGU02 As Label
    Friend WithEvents TexRealOutGU02 As Label
    Friend WithEvents TexOutGU02 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TexProcenOutGU01 As Label
    Friend WithEvents TexRealOutGU01 As Label
    Friend WithEvents TexOutGU01 As Label
    Friend WithEvents IF_OutGU01 As PictureBox
    Friend WithEvents TexProcenOutH2 As Label
    Friend WithEvents TexRealOutH2 As Label
    Friend WithEvents TexOutH2 As Label
    Friend WithEvents IF_OutH2 As PictureBox
End Class
