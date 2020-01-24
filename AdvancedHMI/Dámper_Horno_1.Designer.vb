<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dámper_Horno_1
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
        Me.MD_RealOutGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DámperH1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.MD_ProcenOutGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU15 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU14 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_BloqueoGU16 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU16 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU16 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU15 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU15 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU15 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU14 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU14 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU14 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU13 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU13 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU13 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU12 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU12 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU12 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU11 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU11 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU11 = New AdvancedHMIControls.BasicButton()
        Me.BP_BloqueoGU10 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU10 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU10 = New AdvancedHMIControls.BasicButton()
        Me.MD_ProcenOutGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_RealOutGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BP_BloqueoGU09 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualGU09 = New AdvancedHMIControls.BasicButton()
        Me.BP_LuzGU09 = New AdvancedHMIControls.BasicButton()
        Me.BP_ManualH1 = New AdvancedHMIControls.BasicButton()
        Me.MD_RealOutH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_ProcenOutH1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexProcenOutGU16 = New System.Windows.Forms.Label()
        Me.TexRealOutGU16 = New System.Windows.Forms.Label()
        Me.TexOutGU16 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU15 = New System.Windows.Forms.Label()
        Me.TexRealOutGU15 = New System.Windows.Forms.Label()
        Me.TexOutGU15 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU14 = New System.Windows.Forms.Label()
        Me.TexRealOutGU14 = New System.Windows.Forms.Label()
        Me.TexOutGU14 = New System.Windows.Forms.Label()
        Me.TexProcenOutGU13 = New System.Windows.Forms.Label()
        Me.TexRealOutGU13 = New System.Windows.Forms.Label()
        Me.TexOutGU13 = New System.Windows.Forms.Label()
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
        Me.BCF_RegresarH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_MenúP_MantH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.IF_OutGU16 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU15 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU14 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU13 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU12 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU11 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU10 = New System.Windows.Forms.PictureBox()
        Me.IF_OutGU09 = New System.Windows.Forms.PictureBox()
        Me.IF_OutH1 = New System.Windows.Forms.PictureBox()
        CType(Me.DámperH1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutGU09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_OutH1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MD_RealOutGU16
        '
        Me.MD_RealOutGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU16.ComComponent = Me.DámperH1
        Me.MD_RealOutGU16.DecimalPosition = 0
        Me.MD_RealOutGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU16.KeypadMaxValue = 0R
        Me.MD_RealOutGU16.KeypadMinValue = 0R
        Me.MD_RealOutGU16.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU16.KeypadText = Nothing
        Me.MD_RealOutGU16.KeypadWidth = 300
        Me.MD_RealOutGU16.Location = New System.Drawing.Point(550, 507)
        Me.MD_RealOutGU16.Name = "MD_RealOutGU16"
        Me.MD_RealOutGU16.NumberOfDigits = 5
        Me.MD_RealOutGU16.PLCAddressKeypad = ""
        Me.MD_RealOutGU16.PLCAddressValue = "PID_GUARDIOLA9.OUT"
        Me.MD_RealOutGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU16.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU16.TabIndex = 1014
        Me.MD_RealOutGU16.Value = 0R
        Me.MD_RealOutGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DámperH1
        '
        Me.DámperH1.CIPConnectionSize = 508
        Me.DámperH1.DisableMultiServiceRequest = False
        Me.DámperH1.DisableSubscriptions = False
        Me.DámperH1.IniFileName = ""
        Me.DámperH1.IniFileSection = Nothing
        Me.DámperH1.IPAddress = "10.1.108.20"
        Me.DámperH1.PollRateOverride = 500
        Me.DámperH1.Port = 44818
        Me.DámperH1.ProcessorSlot = 0
        Me.DámperH1.RoutePath = Nothing
        Me.DámperH1.Timeout = 4000
        '
        'MD_ProcenOutGU15
        '
        Me.MD_ProcenOutGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU15.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU15.DecimalPosition = 0
        Me.MD_ProcenOutGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU15.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU15.KeypadMinValue = 0R
        Me.MD_ProcenOutGU15.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU15.KeypadText = Nothing
        Me.MD_ProcenOutGU15.KeypadWidth = 300
        Me.MD_ProcenOutGU15.Location = New System.Drawing.Point(384, 573)
        Me.MD_ProcenOutGU15.Name = "MD_ProcenOutGU15"
        Me.MD_ProcenOutGU15.NumberOfDigits = 5
        Me.MD_ProcenOutGU15.PLCAddressKeypad = "PID_GUARDIOLA8.SO"
        Me.MD_ProcenOutGU15.PLCAddressValue = "PID_GUARDIOLA8.SO"
        Me.MD_ProcenOutGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU15.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU15.TabIndex = 1013
        Me.MD_ProcenOutGU15.Value = 0R
        Me.MD_ProcenOutGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU15
        '
        Me.MD_RealOutGU15.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU15.ComComponent = Me.DámperH1
        Me.MD_RealOutGU15.DecimalPosition = 0
        Me.MD_RealOutGU15.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU15.KeypadMaxValue = 0R
        Me.MD_RealOutGU15.KeypadMinValue = 0R
        Me.MD_RealOutGU15.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU15.KeypadText = Nothing
        Me.MD_RealOutGU15.KeypadWidth = 300
        Me.MD_RealOutGU15.Location = New System.Drawing.Point(384, 507)
        Me.MD_RealOutGU15.Name = "MD_RealOutGU15"
        Me.MD_RealOutGU15.NumberOfDigits = 5
        Me.MD_RealOutGU15.PLCAddressKeypad = ""
        Me.MD_RealOutGU15.PLCAddressValue = "PID_GUARDIOLA8.OUT"
        Me.MD_RealOutGU15.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU15.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU15.TabIndex = 1012
        Me.MD_RealOutGU15.Value = 0R
        Me.MD_RealOutGU15.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU15.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU14
        '
        Me.MD_ProcenOutGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU14.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU14.DecimalPosition = 0
        Me.MD_ProcenOutGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU14.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU14.KeypadMinValue = 0R
        Me.MD_ProcenOutGU14.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU14.KeypadText = Nothing
        Me.MD_ProcenOutGU14.KeypadWidth = 300
        Me.MD_ProcenOutGU14.Location = New System.Drawing.Point(220, 573)
        Me.MD_ProcenOutGU14.Name = "MD_ProcenOutGU14"
        Me.MD_ProcenOutGU14.NumberOfDigits = 5
        Me.MD_ProcenOutGU14.PLCAddressKeypad = "PID_GUARDIOLA7.SO"
        Me.MD_ProcenOutGU14.PLCAddressValue = "PID_GUARDIOLA7.SO"
        Me.MD_ProcenOutGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU14.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU14.TabIndex = 1011
        Me.MD_ProcenOutGU14.Value = 0R
        Me.MD_ProcenOutGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU14
        '
        Me.MD_RealOutGU14.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU14.ComComponent = Me.DámperH1
        Me.MD_RealOutGU14.DecimalPosition = 0
        Me.MD_RealOutGU14.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU14.KeypadMaxValue = 0R
        Me.MD_RealOutGU14.KeypadMinValue = 0R
        Me.MD_RealOutGU14.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU14.KeypadText = Nothing
        Me.MD_RealOutGU14.KeypadWidth = 300
        Me.MD_RealOutGU14.Location = New System.Drawing.Point(220, 507)
        Me.MD_RealOutGU14.Name = "MD_RealOutGU14"
        Me.MD_RealOutGU14.NumberOfDigits = 5
        Me.MD_RealOutGU14.PLCAddressKeypad = ""
        Me.MD_RealOutGU14.PLCAddressValue = "PID_GUARDIOLA7.OUT"
        Me.MD_RealOutGU14.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU14.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU14.TabIndex = 1010
        Me.MD_RealOutGU14.Value = 0R
        Me.MD_RealOutGU14.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU14.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU13
        '
        Me.MD_ProcenOutGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU13.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU13.DecimalPosition = 0
        Me.MD_ProcenOutGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU13.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU13.KeypadMinValue = 0R
        Me.MD_ProcenOutGU13.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU13.KeypadText = Nothing
        Me.MD_ProcenOutGU13.KeypadWidth = 300
        Me.MD_ProcenOutGU13.Location = New System.Drawing.Point(1038, 285)
        Me.MD_ProcenOutGU13.Name = "MD_ProcenOutGU13"
        Me.MD_ProcenOutGU13.NumberOfDigits = 5
        Me.MD_ProcenOutGU13.PLCAddressKeypad = "PID_GUARDIOLA6.SO"
        Me.MD_ProcenOutGU13.PLCAddressValue = "PID_GUARDIOLA6.SO"
        Me.MD_ProcenOutGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU13.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU13.TabIndex = 1009
        Me.MD_ProcenOutGU13.Value = 0R
        Me.MD_ProcenOutGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU13
        '
        Me.MD_RealOutGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU13.ComComponent = Me.DámperH1
        Me.MD_RealOutGU13.DecimalPosition = 0
        Me.MD_RealOutGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU13.KeypadMaxValue = 0R
        Me.MD_RealOutGU13.KeypadMinValue = 0R
        Me.MD_RealOutGU13.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU13.KeypadText = Nothing
        Me.MD_RealOutGU13.KeypadWidth = 300
        Me.MD_RealOutGU13.Location = New System.Drawing.Point(1038, 219)
        Me.MD_RealOutGU13.Name = "MD_RealOutGU13"
        Me.MD_RealOutGU13.NumberOfDigits = 5
        Me.MD_RealOutGU13.PLCAddressKeypad = ""
        Me.MD_RealOutGU13.PLCAddressValue = "PID_GUARDIOLA6.OUT"
        Me.MD_RealOutGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU13.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU13.TabIndex = 1008
        Me.MD_RealOutGU13.Value = 0R
        Me.MD_RealOutGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU12
        '
        Me.MD_ProcenOutGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU12.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU12.DecimalPosition = 0
        Me.MD_ProcenOutGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU12.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU12.KeypadMinValue = 0R
        Me.MD_ProcenOutGU12.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU12.KeypadText = Nothing
        Me.MD_ProcenOutGU12.KeypadWidth = 300
        Me.MD_ProcenOutGU12.Location = New System.Drawing.Point(874, 285)
        Me.MD_ProcenOutGU12.Name = "MD_ProcenOutGU12"
        Me.MD_ProcenOutGU12.NumberOfDigits = 5
        Me.MD_ProcenOutGU12.PLCAddressKeypad = "PID_GUARDIOLA5.SO"
        Me.MD_ProcenOutGU12.PLCAddressValue = "PID_GUARDIOLA5.SO"
        Me.MD_ProcenOutGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU12.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU12.TabIndex = 1007
        Me.MD_ProcenOutGU12.Value = 0R
        Me.MD_ProcenOutGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU12
        '
        Me.MD_RealOutGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU12.ComComponent = Me.DámperH1
        Me.MD_RealOutGU12.DecimalPosition = 0
        Me.MD_RealOutGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU12.KeypadMaxValue = 0R
        Me.MD_RealOutGU12.KeypadMinValue = 0R
        Me.MD_RealOutGU12.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU12.KeypadText = Nothing
        Me.MD_RealOutGU12.KeypadWidth = 300
        Me.MD_RealOutGU12.Location = New System.Drawing.Point(874, 219)
        Me.MD_RealOutGU12.Name = "MD_RealOutGU12"
        Me.MD_RealOutGU12.NumberOfDigits = 5
        Me.MD_RealOutGU12.PLCAddressKeypad = ""
        Me.MD_RealOutGU12.PLCAddressValue = "PID_GUARDIOLA5.OUT"
        Me.MD_RealOutGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU12.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU12.TabIndex = 1006
        Me.MD_RealOutGU12.Value = 0R
        Me.MD_RealOutGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU11
        '
        Me.MD_ProcenOutGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU11.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU11.DecimalPosition = 0
        Me.MD_ProcenOutGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU11.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU11.KeypadMinValue = 0R
        Me.MD_ProcenOutGU11.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU11.KeypadText = Nothing
        Me.MD_ProcenOutGU11.KeypadWidth = 300
        Me.MD_ProcenOutGU11.Location = New System.Drawing.Point(709, 285)
        Me.MD_ProcenOutGU11.Name = "MD_ProcenOutGU11"
        Me.MD_ProcenOutGU11.NumberOfDigits = 5
        Me.MD_ProcenOutGU11.PLCAddressKeypad = "PID_GUARDIOLA4.SO"
        Me.MD_ProcenOutGU11.PLCAddressValue = "PID_GUARDIOLA4.SO"
        Me.MD_ProcenOutGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU11.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU11.TabIndex = 1005
        Me.MD_ProcenOutGU11.Value = 0R
        Me.MD_ProcenOutGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU11
        '
        Me.MD_RealOutGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU11.ComComponent = Me.DámperH1
        Me.MD_RealOutGU11.DecimalPosition = 0
        Me.MD_RealOutGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU11.KeypadMaxValue = 0R
        Me.MD_RealOutGU11.KeypadMinValue = 0R
        Me.MD_RealOutGU11.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU11.KeypadText = Nothing
        Me.MD_RealOutGU11.KeypadWidth = 300
        Me.MD_RealOutGU11.Location = New System.Drawing.Point(709, 219)
        Me.MD_RealOutGU11.Name = "MD_RealOutGU11"
        Me.MD_RealOutGU11.NumberOfDigits = 5
        Me.MD_RealOutGU11.PLCAddressKeypad = ""
        Me.MD_RealOutGU11.PLCAddressValue = "PID_GUARDIOLA4.OUT"
        Me.MD_RealOutGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU11.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU11.TabIndex = 1004
        Me.MD_RealOutGU11.Value = 0R
        Me.MD_RealOutGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_BloqueoGU16
        '
        Me.BP_BloqueoGU16.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU16.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU16.Highlight = False
        Me.BP_BloqueoGU16.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU16.Location = New System.Drawing.Point(545, 671)
        Me.BP_BloqueoGU16.MaximumHoldTime = 3000
        Me.BP_BloqueoGU16.MinimumHoldTime = 500
        Me.BP_BloqueoGU16.Name = "BP_BloqueoGU16"
        Me.BP_BloqueoGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU16.PLCAddressClick = "BLOQUEO_GA09"
        Me.BP_BloqueoGU16.PLCAddressHighlightX = "BLOQUEO_GA09"
        Me.BP_BloqueoGU16.PLCAddressSelectTextAlternate = "BLOQUEO_GA09"
        Me.BP_BloqueoGU16.SelectTextAlternate = False
        Me.BP_BloqueoGU16.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU16.TabIndex = 1003
        Me.BP_BloqueoGU16.Text = "Bloquear"
        Me.BP_BloqueoGU16.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU16.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU16.ValueToWrite = 0
        '
        'BP_ManualGU16
        '
        Me.BP_ManualGU16.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU16.ComComponent = Me.DámperH1
        Me.BP_ManualGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU16.Highlight = False
        Me.BP_ManualGU16.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU16.Location = New System.Drawing.Point(545, 620)
        Me.BP_ManualGU16.MaximumHoldTime = 3000
        Me.BP_ManualGU16.MinimumHoldTime = 500
        Me.BP_ManualGU16.Name = "BP_ManualGU16"
        Me.BP_ManualGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU16.PLCAddressClick = "BP_G9"
        Me.BP_ManualGU16.PLCAddressHighlightX = "BP_G9"
        Me.BP_ManualGU16.PLCAddressSelectTextAlternate = "BP_G9"
        Me.BP_ManualGU16.SelectTextAlternate = False
        Me.BP_ManualGU16.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU16.TabIndex = 1002
        Me.BP_ManualGU16.Text = "Automático"
        Me.BP_ManualGU16.TextAlternate = "Manual"
        Me.BP_ManualGU16.UseVisualStyleBackColor = True
        Me.BP_ManualGU16.ValueToWrite = 0
        '
        'BP_LuzGU16
        '
        Me.BP_LuzGU16.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU16.ComComponent = Me.DámperH1
        Me.BP_LuzGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU16.Highlight = False
        Me.BP_LuzGU16.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU16.Location = New System.Drawing.Point(548, 421)
        Me.BP_LuzGU16.MaximumHoldTime = 3000
        Me.BP_LuzGU16.MinimumHoldTime = 500
        Me.BP_LuzGU16.Name = "BP_LuzGU16"
        Me.BP_LuzGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU16.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU16"
        Me.BP_LuzGU16.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU16"
        Me.BP_LuzGU16.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU16"
        Me.BP_LuzGU16.SelectTextAlternate = False
        Me.BP_LuzGU16.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU16.TabIndex = 1001
        Me.BP_LuzGU16.Text = "Encender"
        Me.BP_LuzGU16.TextAlternate = "Encendido"
        Me.BP_LuzGU16.UseVisualStyleBackColor = True
        Me.BP_LuzGU16.ValueToWrite = 0
        '
        'BP_BloqueoGU15
        '
        Me.BP_BloqueoGU15.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU15.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU15.Highlight = False
        Me.BP_BloqueoGU15.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU15.Location = New System.Drawing.Point(380, 671)
        Me.BP_BloqueoGU15.MaximumHoldTime = 3000
        Me.BP_BloqueoGU15.MinimumHoldTime = 500
        Me.BP_BloqueoGU15.Name = "BP_BloqueoGU15"
        Me.BP_BloqueoGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU15.PLCAddressClick = "BLOQUEO_GA08"
        Me.BP_BloqueoGU15.PLCAddressHighlightX = "BLOQUEO_GA08"
        Me.BP_BloqueoGU15.PLCAddressSelectTextAlternate = "BLOQUEO_GA08"
        Me.BP_BloqueoGU15.SelectTextAlternate = False
        Me.BP_BloqueoGU15.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU15.TabIndex = 1000
        Me.BP_BloqueoGU15.Text = "Bloquear"
        Me.BP_BloqueoGU15.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU15.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU15.ValueToWrite = 0
        '
        'BP_ManualGU15
        '
        Me.BP_ManualGU15.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU15.ComComponent = Me.DámperH1
        Me.BP_ManualGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU15.Highlight = False
        Me.BP_ManualGU15.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU15.Location = New System.Drawing.Point(380, 620)
        Me.BP_ManualGU15.MaximumHoldTime = 3000
        Me.BP_ManualGU15.MinimumHoldTime = 500
        Me.BP_ManualGU15.Name = "BP_ManualGU15"
        Me.BP_ManualGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU15.PLCAddressClick = "BP_G8"
        Me.BP_ManualGU15.PLCAddressHighlightX = "BP_G8"
        Me.BP_ManualGU15.PLCAddressSelectTextAlternate = "BP_G8"
        Me.BP_ManualGU15.SelectTextAlternate = False
        Me.BP_ManualGU15.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU15.TabIndex = 999
        Me.BP_ManualGU15.Text = "Automático"
        Me.BP_ManualGU15.TextAlternate = "Manual"
        Me.BP_ManualGU15.UseVisualStyleBackColor = True
        Me.BP_ManualGU15.ValueToWrite = 0
        '
        'BP_LuzGU15
        '
        Me.BP_LuzGU15.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU15.ComComponent = Me.DámperH1
        Me.BP_LuzGU15.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU15.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU15.Highlight = False
        Me.BP_LuzGU15.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU15.Location = New System.Drawing.Point(383, 421)
        Me.BP_LuzGU15.MaximumHoldTime = 3000
        Me.BP_LuzGU15.MinimumHoldTime = 500
        Me.BP_LuzGU15.Name = "BP_LuzGU15"
        Me.BP_LuzGU15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU15.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU15"
        Me.BP_LuzGU15.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU15"
        Me.BP_LuzGU15.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU15"
        Me.BP_LuzGU15.SelectTextAlternate = False
        Me.BP_LuzGU15.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU15.TabIndex = 998
        Me.BP_LuzGU15.Text = "Encender"
        Me.BP_LuzGU15.TextAlternate = "Encendido"
        Me.BP_LuzGU15.UseVisualStyleBackColor = True
        Me.BP_LuzGU15.ValueToWrite = 0
        '
        'BP_BloqueoGU14
        '
        Me.BP_BloqueoGU14.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU14.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU14.Highlight = False
        Me.BP_BloqueoGU14.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU14.Location = New System.Drawing.Point(217, 671)
        Me.BP_BloqueoGU14.MaximumHoldTime = 3000
        Me.BP_BloqueoGU14.MinimumHoldTime = 500
        Me.BP_BloqueoGU14.Name = "BP_BloqueoGU14"
        Me.BP_BloqueoGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU14.PLCAddressClick = "BLOQUEO_GA07"
        Me.BP_BloqueoGU14.PLCAddressHighlightX = "BLOQUEO_GA07"
        Me.BP_BloqueoGU14.PLCAddressSelectTextAlternate = "BLOQUEO_GA07"
        Me.BP_BloqueoGU14.SelectTextAlternate = False
        Me.BP_BloqueoGU14.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU14.TabIndex = 997
        Me.BP_BloqueoGU14.Text = "Bloquear"
        Me.BP_BloqueoGU14.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU14.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU14.ValueToWrite = 0
        '
        'BP_ManualGU14
        '
        Me.BP_ManualGU14.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU14.ComComponent = Me.DámperH1
        Me.BP_ManualGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU14.Highlight = False
        Me.BP_ManualGU14.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU14.Location = New System.Drawing.Point(217, 620)
        Me.BP_ManualGU14.MaximumHoldTime = 3000
        Me.BP_ManualGU14.MinimumHoldTime = 500
        Me.BP_ManualGU14.Name = "BP_ManualGU14"
        Me.BP_ManualGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU14.PLCAddressClick = "BP_G7"
        Me.BP_ManualGU14.PLCAddressHighlightX = "BP_G7"
        Me.BP_ManualGU14.PLCAddressSelectTextAlternate = "BP_G7"
        Me.BP_ManualGU14.SelectTextAlternate = False
        Me.BP_ManualGU14.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU14.TabIndex = 996
        Me.BP_ManualGU14.Text = "Automático"
        Me.BP_ManualGU14.TextAlternate = "Manual"
        Me.BP_ManualGU14.UseVisualStyleBackColor = True
        Me.BP_ManualGU14.ValueToWrite = 0
        '
        'BP_LuzGU14
        '
        Me.BP_LuzGU14.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU14.ComComponent = Me.DámperH1
        Me.BP_LuzGU14.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU14.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU14.Highlight = False
        Me.BP_LuzGU14.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU14.Location = New System.Drawing.Point(220, 421)
        Me.BP_LuzGU14.MaximumHoldTime = 3000
        Me.BP_LuzGU14.MinimumHoldTime = 500
        Me.BP_LuzGU14.Name = "BP_LuzGU14"
        Me.BP_LuzGU14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU14.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU14"
        Me.BP_LuzGU14.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU14"
        Me.BP_LuzGU14.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU14"
        Me.BP_LuzGU14.SelectTextAlternate = False
        Me.BP_LuzGU14.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU14.TabIndex = 995
        Me.BP_LuzGU14.Text = "Encender"
        Me.BP_LuzGU14.TextAlternate = "Encendido"
        Me.BP_LuzGU14.UseVisualStyleBackColor = True
        Me.BP_LuzGU14.ValueToWrite = 0
        '
        'BP_BloqueoGU13
        '
        Me.BP_BloqueoGU13.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU13.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU13.Highlight = False
        Me.BP_BloqueoGU13.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU13.Location = New System.Drawing.Point(1037, 383)
        Me.BP_BloqueoGU13.MaximumHoldTime = 3000
        Me.BP_BloqueoGU13.MinimumHoldTime = 500
        Me.BP_BloqueoGU13.Name = "BP_BloqueoGU13"
        Me.BP_BloqueoGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU13.PLCAddressClick = "BLOQUEO_GA06"
        Me.BP_BloqueoGU13.PLCAddressHighlightX = "BLOQUEO_GA06"
        Me.BP_BloqueoGU13.PLCAddressSelectTextAlternate = "BLOQUEO_GA06"
        Me.BP_BloqueoGU13.SelectTextAlternate = False
        Me.BP_BloqueoGU13.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU13.TabIndex = 994
        Me.BP_BloqueoGU13.Text = "Bloquear"
        Me.BP_BloqueoGU13.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU13.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU13.ValueToWrite = 0
        '
        'BP_ManualGU13
        '
        Me.BP_ManualGU13.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU13.ComComponent = Me.DámperH1
        Me.BP_ManualGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU13.Highlight = False
        Me.BP_ManualGU13.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU13.Location = New System.Drawing.Point(1037, 332)
        Me.BP_ManualGU13.MaximumHoldTime = 3000
        Me.BP_ManualGU13.MinimumHoldTime = 500
        Me.BP_ManualGU13.Name = "BP_ManualGU13"
        Me.BP_ManualGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU13.PLCAddressClick = "BP_G6"
        Me.BP_ManualGU13.PLCAddressHighlightX = "BP_G6"
        Me.BP_ManualGU13.PLCAddressSelectTextAlternate = "BP_G6"
        Me.BP_ManualGU13.SelectTextAlternate = False
        Me.BP_ManualGU13.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU13.TabIndex = 993
        Me.BP_ManualGU13.Text = "Automático"
        Me.BP_ManualGU13.TextAlternate = "Manual"
        Me.BP_ManualGU13.UseVisualStyleBackColor = False
        Me.BP_ManualGU13.ValueToWrite = 0
        '
        'BP_LuzGU13
        '
        Me.BP_LuzGU13.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU13.ComComponent = Me.DámperH1
        Me.BP_LuzGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU13.Highlight = False
        Me.BP_LuzGU13.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU13.Location = New System.Drawing.Point(1040, 133)
        Me.BP_LuzGU13.MaximumHoldTime = 3000
        Me.BP_LuzGU13.MinimumHoldTime = 500
        Me.BP_LuzGU13.Name = "BP_LuzGU13"
        Me.BP_LuzGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU13.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU13"
        Me.BP_LuzGU13.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU13"
        Me.BP_LuzGU13.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU13"
        Me.BP_LuzGU13.SelectTextAlternate = False
        Me.BP_LuzGU13.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU13.TabIndex = 992
        Me.BP_LuzGU13.Text = "Encender"
        Me.BP_LuzGU13.TextAlternate = "Encendido"
        Me.BP_LuzGU13.UseVisualStyleBackColor = True
        Me.BP_LuzGU13.ValueToWrite = 0
        '
        'BP_BloqueoGU12
        '
        Me.BP_BloqueoGU12.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU12.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU12.Highlight = False
        Me.BP_BloqueoGU12.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU12.Location = New System.Drawing.Point(873, 383)
        Me.BP_BloqueoGU12.MaximumHoldTime = 3000
        Me.BP_BloqueoGU12.MinimumHoldTime = 500
        Me.BP_BloqueoGU12.Name = "BP_BloqueoGU12"
        Me.BP_BloqueoGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU12.PLCAddressClick = "BLOQUEO_GA05"
        Me.BP_BloqueoGU12.PLCAddressHighlightX = "BLOQUEO_GA05"
        Me.BP_BloqueoGU12.PLCAddressSelectTextAlternate = "BLOQUEO_GA05"
        Me.BP_BloqueoGU12.SelectTextAlternate = False
        Me.BP_BloqueoGU12.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU12.TabIndex = 991
        Me.BP_BloqueoGU12.Text = "Bloquear"
        Me.BP_BloqueoGU12.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU12.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU12.ValueToWrite = 0
        '
        'BP_ManualGU12
        '
        Me.BP_ManualGU12.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU12.ComComponent = Me.DámperH1
        Me.BP_ManualGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU12.Highlight = False
        Me.BP_ManualGU12.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU12.Location = New System.Drawing.Point(873, 332)
        Me.BP_ManualGU12.MaximumHoldTime = 3000
        Me.BP_ManualGU12.MinimumHoldTime = 500
        Me.BP_ManualGU12.Name = "BP_ManualGU12"
        Me.BP_ManualGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU12.PLCAddressClick = "BP_G5"
        Me.BP_ManualGU12.PLCAddressHighlightX = "BP_G5"
        Me.BP_ManualGU12.PLCAddressSelectTextAlternate = "BP_G5"
        Me.BP_ManualGU12.SelectTextAlternate = False
        Me.BP_ManualGU12.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU12.TabIndex = 990
        Me.BP_ManualGU12.Text = "Automático"
        Me.BP_ManualGU12.TextAlternate = "Manual"
        Me.BP_ManualGU12.UseVisualStyleBackColor = True
        Me.BP_ManualGU12.ValueToWrite = 0
        '
        'BP_LuzGU12
        '
        Me.BP_LuzGU12.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU12.ComComponent = Me.DámperH1
        Me.BP_LuzGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU12.Highlight = False
        Me.BP_LuzGU12.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU12.Location = New System.Drawing.Point(876, 133)
        Me.BP_LuzGU12.MaximumHoldTime = 3000
        Me.BP_LuzGU12.MinimumHoldTime = 500
        Me.BP_LuzGU12.Name = "BP_LuzGU12"
        Me.BP_LuzGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU12.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU12"
        Me.BP_LuzGU12.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU12"
        Me.BP_LuzGU12.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU12"
        Me.BP_LuzGU12.SelectTextAlternate = False
        Me.BP_LuzGU12.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU12.TabIndex = 989
        Me.BP_LuzGU12.Text = "Encender"
        Me.BP_LuzGU12.TextAlternate = "Encendido"
        Me.BP_LuzGU12.UseVisualStyleBackColor = True
        Me.BP_LuzGU12.ValueToWrite = 0
        '
        'BP_BloqueoGU11
        '
        Me.BP_BloqueoGU11.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU11.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU11.Highlight = False
        Me.BP_BloqueoGU11.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU11.Location = New System.Drawing.Point(709, 383)
        Me.BP_BloqueoGU11.MaximumHoldTime = 3000
        Me.BP_BloqueoGU11.MinimumHoldTime = 500
        Me.BP_BloqueoGU11.Name = "BP_BloqueoGU11"
        Me.BP_BloqueoGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU11.PLCAddressClick = "BLOQUEO_GA04"
        Me.BP_BloqueoGU11.PLCAddressHighlightX = "BLOQUEO_GA04"
        Me.BP_BloqueoGU11.PLCAddressSelectTextAlternate = "BLOQUEO_GA04"
        Me.BP_BloqueoGU11.SelectTextAlternate = False
        Me.BP_BloqueoGU11.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU11.TabIndex = 988
        Me.BP_BloqueoGU11.Text = "Bloquear"
        Me.BP_BloqueoGU11.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU11.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU11.ValueToWrite = 0
        '
        'BP_ManualGU11
        '
        Me.BP_ManualGU11.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU11.ComComponent = Me.DámperH1
        Me.BP_ManualGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU11.Highlight = False
        Me.BP_ManualGU11.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU11.Location = New System.Drawing.Point(709, 332)
        Me.BP_ManualGU11.MaximumHoldTime = 3000
        Me.BP_ManualGU11.MinimumHoldTime = 500
        Me.BP_ManualGU11.Name = "BP_ManualGU11"
        Me.BP_ManualGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU11.PLCAddressClick = "BP_G4"
        Me.BP_ManualGU11.PLCAddressHighlightX = "BP_G4"
        Me.BP_ManualGU11.PLCAddressSelectTextAlternate = "BP_G4"
        Me.BP_ManualGU11.SelectTextAlternate = False
        Me.BP_ManualGU11.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU11.TabIndex = 987
        Me.BP_ManualGU11.Text = "Automático"
        Me.BP_ManualGU11.TextAlternate = "Manual"
        Me.BP_ManualGU11.UseVisualStyleBackColor = True
        Me.BP_ManualGU11.ValueToWrite = 0
        '
        'BP_LuzGU11
        '
        Me.BP_LuzGU11.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU11.ComComponent = Me.DámperH1
        Me.BP_LuzGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU11.Highlight = False
        Me.BP_LuzGU11.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU11.Location = New System.Drawing.Point(712, 133)
        Me.BP_LuzGU11.MaximumHoldTime = 3000
        Me.BP_LuzGU11.MinimumHoldTime = 500
        Me.BP_LuzGU11.Name = "BP_LuzGU11"
        Me.BP_LuzGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU11.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU11"
        Me.BP_LuzGU11.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU11"
        Me.BP_LuzGU11.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU11"
        Me.BP_LuzGU11.SelectTextAlternate = False
        Me.BP_LuzGU11.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU11.TabIndex = 986
        Me.BP_LuzGU11.Text = "Encender"
        Me.BP_LuzGU11.TextAlternate = "Encendido"
        Me.BP_LuzGU11.UseVisualStyleBackColor = True
        Me.BP_LuzGU11.ValueToWrite = 0
        '
        'BP_BloqueoGU10
        '
        Me.BP_BloqueoGU10.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU10.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU10.Highlight = False
        Me.BP_BloqueoGU10.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU10.Location = New System.Drawing.Point(545, 383)
        Me.BP_BloqueoGU10.MaximumHoldTime = 3000
        Me.BP_BloqueoGU10.MinimumHoldTime = 500
        Me.BP_BloqueoGU10.Name = "BP_BloqueoGU10"
        Me.BP_BloqueoGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU10.PLCAddressClick = "BLOQUEO_GA03"
        Me.BP_BloqueoGU10.PLCAddressHighlightX = "BLOQUEO_GA03"
        Me.BP_BloqueoGU10.PLCAddressSelectTextAlternate = "BLOQUEO_GA03"
        Me.BP_BloqueoGU10.SelectTextAlternate = False
        Me.BP_BloqueoGU10.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU10.TabIndex = 985
        Me.BP_BloqueoGU10.Text = "Bloquear"
        Me.BP_BloqueoGU10.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU10.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU10.ValueToWrite = 0
        '
        'BP_ManualGU10
        '
        Me.BP_ManualGU10.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU10.ComComponent = Me.DámperH1
        Me.BP_ManualGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU10.Highlight = False
        Me.BP_ManualGU10.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU10.Location = New System.Drawing.Point(545, 332)
        Me.BP_ManualGU10.MaximumHoldTime = 3000
        Me.BP_ManualGU10.MinimumHoldTime = 500
        Me.BP_ManualGU10.Name = "BP_ManualGU10"
        Me.BP_ManualGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU10.PLCAddressClick = "BP_G3"
        Me.BP_ManualGU10.PLCAddressHighlightX = "BP_G3"
        Me.BP_ManualGU10.PLCAddressSelectTextAlternate = "BP_G3"
        Me.BP_ManualGU10.SelectTextAlternate = False
        Me.BP_ManualGU10.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU10.TabIndex = 984
        Me.BP_ManualGU10.Text = "Automático"
        Me.BP_ManualGU10.TextAlternate = "Manual"
        Me.BP_ManualGU10.UseVisualStyleBackColor = True
        Me.BP_ManualGU10.ValueToWrite = 0
        '
        'BP_LuzGU10
        '
        Me.BP_LuzGU10.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU10.ComComponent = Me.DámperH1
        Me.BP_LuzGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU10.Highlight = False
        Me.BP_LuzGU10.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU10.Location = New System.Drawing.Point(548, 133)
        Me.BP_LuzGU10.MaximumHoldTime = 3000
        Me.BP_LuzGU10.MinimumHoldTime = 500
        Me.BP_LuzGU10.Name = "BP_LuzGU10"
        Me.BP_LuzGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU10.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU10"
        Me.BP_LuzGU10.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU10"
        Me.BP_LuzGU10.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU10"
        Me.BP_LuzGU10.SelectTextAlternate = False
        Me.BP_LuzGU10.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU10.TabIndex = 983
        Me.BP_LuzGU10.Text = "Encender"
        Me.BP_LuzGU10.TextAlternate = "Encendido"
        Me.BP_LuzGU10.UseVisualStyleBackColor = True
        Me.BP_LuzGU10.ValueToWrite = 0
        '
        'MD_ProcenOutGU10
        '
        Me.MD_ProcenOutGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU10.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU10.DecimalPosition = 0
        Me.MD_ProcenOutGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU10.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU10.KeypadMinValue = 0R
        Me.MD_ProcenOutGU10.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU10.KeypadText = Nothing
        Me.MD_ProcenOutGU10.KeypadWidth = 300
        Me.MD_ProcenOutGU10.Location = New System.Drawing.Point(546, 285)
        Me.MD_ProcenOutGU10.Name = "MD_ProcenOutGU10"
        Me.MD_ProcenOutGU10.NumberOfDigits = 5
        Me.MD_ProcenOutGU10.PLCAddressKeypad = "PID_GUARDIOLA3.SO"
        Me.MD_ProcenOutGU10.PLCAddressValue = "PID_GUARDIOLA3.SO"
        Me.MD_ProcenOutGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU10.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU10.TabIndex = 982
        Me.MD_ProcenOutGU10.Value = 0R
        Me.MD_ProcenOutGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU10
        '
        Me.MD_RealOutGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU10.ComComponent = Me.DámperH1
        Me.MD_RealOutGU10.DecimalPosition = 0
        Me.MD_RealOutGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU10.KeypadMaxValue = 0R
        Me.MD_RealOutGU10.KeypadMinValue = 0R
        Me.MD_RealOutGU10.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU10.KeypadText = Nothing
        Me.MD_RealOutGU10.KeypadWidth = 300
        Me.MD_RealOutGU10.Location = New System.Drawing.Point(546, 219)
        Me.MD_RealOutGU10.Name = "MD_RealOutGU10"
        Me.MD_RealOutGU10.NumberOfDigits = 5
        Me.MD_RealOutGU10.PLCAddressKeypad = ""
        Me.MD_RealOutGU10.PLCAddressValue = "PID_GUARDIOLA3.OUT"
        Me.MD_RealOutGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU10.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU10.TabIndex = 981
        Me.MD_RealOutGU10.Value = 0R
        Me.MD_RealOutGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU09
        '
        Me.MD_ProcenOutGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU09.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU09.DecimalPosition = 0
        Me.MD_ProcenOutGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU09.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU09.KeypadMinValue = 0R
        Me.MD_ProcenOutGU09.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU09.KeypadText = Nothing
        Me.MD_ProcenOutGU09.KeypadWidth = 300
        Me.MD_ProcenOutGU09.Location = New System.Drawing.Point(382, 285)
        Me.MD_ProcenOutGU09.Name = "MD_ProcenOutGU09"
        Me.MD_ProcenOutGU09.NumberOfDigits = 5
        Me.MD_ProcenOutGU09.PLCAddressKeypad = "PID_GUARDIOLA2.SO"
        Me.MD_ProcenOutGU09.PLCAddressValue = "PID_GUARDIOLA2.SO"
        Me.MD_ProcenOutGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU09.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU09.TabIndex = 980
        Me.MD_ProcenOutGU09.Value = 0R
        Me.MD_ProcenOutGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_RealOutGU09
        '
        Me.MD_RealOutGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutGU09.ComComponent = Me.DámperH1
        Me.MD_RealOutGU09.DecimalPosition = 0
        Me.MD_RealOutGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutGU09.KeypadMaxValue = 0R
        Me.MD_RealOutGU09.KeypadMinValue = 0R
        Me.MD_RealOutGU09.KeypadScaleFactor = 1.0R
        Me.MD_RealOutGU09.KeypadText = Nothing
        Me.MD_RealOutGU09.KeypadWidth = 300
        Me.MD_RealOutGU09.Location = New System.Drawing.Point(382, 219)
        Me.MD_RealOutGU09.Name = "MD_RealOutGU09"
        Me.MD_RealOutGU09.NumberOfDigits = 5
        Me.MD_RealOutGU09.PLCAddressKeypad = ""
        Me.MD_RealOutGU09.PLCAddressValue = "PID_GUARDIOLA2.OUT"
        Me.MD_RealOutGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU09.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutGU09.TabIndex = 979
        Me.MD_RealOutGU09.Value = 0R
        Me.MD_RealOutGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BP_BloqueoGU09
        '
        Me.BP_BloqueoGU09.BackColor = System.Drawing.SystemColors.Control
        Me.BP_BloqueoGU09.ComComponent = Me.DámperH1
        Me.BP_BloqueoGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_BloqueoGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_BloqueoGU09.Highlight = False
        Me.BP_BloqueoGU09.HighlightColor = System.Drawing.Color.Red
        Me.BP_BloqueoGU09.Location = New System.Drawing.Point(381, 383)
        Me.BP_BloqueoGU09.MaximumHoldTime = 3000
        Me.BP_BloqueoGU09.MinimumHoldTime = 500
        Me.BP_BloqueoGU09.Name = "BP_BloqueoGU09"
        Me.BP_BloqueoGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_BloqueoGU09.PLCAddressClick = "BLOQUEO_GA02"
        Me.BP_BloqueoGU09.PLCAddressHighlightX = "BLOQUEO_GA02"
        Me.BP_BloqueoGU09.PLCAddressSelectTextAlternate = "BLOQUEO_GA02"
        Me.BP_BloqueoGU09.SelectTextAlternate = False
        Me.BP_BloqueoGU09.Size = New System.Drawing.Size(95, 30)
        Me.BP_BloqueoGU09.TabIndex = 978
        Me.BP_BloqueoGU09.Text = "Bloquear"
        Me.BP_BloqueoGU09.TextAlternate = "Bloqueado"
        Me.BP_BloqueoGU09.UseVisualStyleBackColor = True
        Me.BP_BloqueoGU09.ValueToWrite = 0
        '
        'BP_ManualGU09
        '
        Me.BP_ManualGU09.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualGU09.ComComponent = Me.DámperH1
        Me.BP_ManualGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualGU09.Highlight = False
        Me.BP_ManualGU09.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualGU09.Location = New System.Drawing.Point(381, 332)
        Me.BP_ManualGU09.MaximumHoldTime = 3000
        Me.BP_ManualGU09.MinimumHoldTime = 500
        Me.BP_ManualGU09.Name = "BP_ManualGU09"
        Me.BP_ManualGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualGU09.PLCAddressClick = "BP_G2"
        Me.BP_ManualGU09.PLCAddressHighlightX = "BP_G2"
        Me.BP_ManualGU09.PLCAddressSelectTextAlternate = "BP_G2"
        Me.BP_ManualGU09.SelectTextAlternate = False
        Me.BP_ManualGU09.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualGU09.TabIndex = 977
        Me.BP_ManualGU09.Text = "Automático"
        Me.BP_ManualGU09.TextAlternate = "Manual"
        Me.BP_ManualGU09.UseVisualStyleBackColor = True
        Me.BP_ManualGU09.ValueToWrite = 0
        '
        'BP_LuzGU09
        '
        Me.BP_LuzGU09.BackColor = System.Drawing.SystemColors.Control
        Me.BP_LuzGU09.ComComponent = Me.DámperH1
        Me.BP_LuzGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_LuzGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_LuzGU09.Highlight = False
        Me.BP_LuzGU09.HighlightColor = System.Drawing.Color.Yellow
        Me.BP_LuzGU09.Location = New System.Drawing.Point(384, 133)
        Me.BP_LuzGU09.MaximumHoldTime = 3000
        Me.BP_LuzGU09.MinimumHoldTime = 500
        Me.BP_LuzGU09.Name = "BP_LuzGU09"
        Me.BP_LuzGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_LuzGU09.PLCAddressClick = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU09"
        Me.BP_LuzGU09.PLCAddressHighlightX = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU09"
        Me.BP_LuzGU09.PLCAddressSelectTextAlternate = "MANUAL_LUZ_INDICADORA_GUARDIOLA_GU09"
        Me.BP_LuzGU09.SelectTextAlternate = False
        Me.BP_LuzGU09.Size = New System.Drawing.Size(94, 30)
        Me.BP_LuzGU09.TabIndex = 976
        Me.BP_LuzGU09.Text = "Encender"
        Me.BP_LuzGU09.TextAlternate = "Encendido"
        Me.BP_LuzGU09.UseVisualStyleBackColor = True
        Me.BP_LuzGU09.ValueToWrite = 0
        '
        'BP_ManualH1
        '
        Me.BP_ManualH1.BackColor = System.Drawing.SystemColors.Control
        Me.BP_ManualH1.ComComponent = Me.DámperH1
        Me.BP_ManualH1.ForeColor = System.Drawing.Color.Black
        Me.BP_ManualH1.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_ManualH1.Highlight = False
        Me.BP_ManualH1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_ManualH1.Location = New System.Drawing.Point(218, 332)
        Me.BP_ManualH1.MaximumHoldTime = 3000
        Me.BP_ManualH1.MinimumHoldTime = 500
        Me.BP_ManualH1.Name = "BP_ManualH1"
        Me.BP_ManualH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_ManualH1.PLCAddressClick = "BP_PID_MANUAL"
        Me.BP_ManualH1.PLCAddressSelectTextAlternate = "BP_PID_MANUAL"
        Me.BP_ManualH1.SelectTextAlternate = False
        Me.BP_ManualH1.Size = New System.Drawing.Size(95, 30)
        Me.BP_ManualH1.TabIndex = 975
        Me.BP_ManualH1.Text = "Automático"
        Me.BP_ManualH1.TextAlternate = "Manual"
        Me.BP_ManualH1.UseVisualStyleBackColor = True
        Me.BP_ManualH1.ValueToWrite = 0
        '
        'MD_RealOutH1
        '
        Me.MD_RealOutH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_RealOutH1.ComComponent = Me.DámperH1
        Me.MD_RealOutH1.DecimalPosition = 0
        Me.MD_RealOutH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_RealOutH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_RealOutH1.KeypadMaxValue = 0R
        Me.MD_RealOutH1.KeypadMinValue = 0R
        Me.MD_RealOutH1.KeypadScaleFactor = 1.0R
        Me.MD_RealOutH1.KeypadText = Nothing
        Me.MD_RealOutH1.KeypadWidth = 300
        Me.MD_RealOutH1.Location = New System.Drawing.Point(218, 219)
        Me.MD_RealOutH1.Name = "MD_RealOutH1"
        Me.MD_RealOutH1.NumberOfDigits = 5
        Me.MD_RealOutH1.PLCAddressKeypad = ""
        Me.MD_RealOutH1.PLCAddressValue = "PID_HORNO.OUT"
        Me.MD_RealOutH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutH1.Size = New System.Drawing.Size(94, 41)
        Me.MD_RealOutH1.TabIndex = 973
        Me.MD_RealOutH1.Value = 0R
        Me.MD_RealOutH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_RealOutH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutGU16
        '
        Me.MD_ProcenOutGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutGU16.ComComponent = Me.DámperH1
        Me.MD_ProcenOutGU16.DecimalPosition = 0
        Me.MD_ProcenOutGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutGU16.KeypadMaxValue = 0R
        Me.MD_ProcenOutGU16.KeypadMinValue = 0R
        Me.MD_ProcenOutGU16.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutGU16.KeypadText = Nothing
        Me.MD_ProcenOutGU16.KeypadWidth = 300
        Me.MD_ProcenOutGU16.Location = New System.Drawing.Point(550, 573)
        Me.MD_ProcenOutGU16.Name = "MD_ProcenOutGU16"
        Me.MD_ProcenOutGU16.NumberOfDigits = 5
        Me.MD_ProcenOutGU16.PLCAddressKeypad = "PID_GUARDIOLA9.SO"
        Me.MD_ProcenOutGU16.PLCAddressValue = "PID_GUARDIOLA9.SO"
        Me.MD_ProcenOutGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU16.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutGU16.TabIndex = 1015
        Me.MD_ProcenOutGU16.Value = 0R
        Me.MD_ProcenOutGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_ProcenOutH1
        '
        Me.MD_ProcenOutH1.BackColor = System.Drawing.Color.Transparent
        Me.MD_ProcenOutH1.ComComponent = Me.DámperH1
        Me.MD_ProcenOutH1.DecimalPosition = 0
        Me.MD_ProcenOutH1.ForeColor = System.Drawing.Color.LightGray
        Me.MD_ProcenOutH1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_ProcenOutH1.KeypadMaxValue = 0R
        Me.MD_ProcenOutH1.KeypadMinValue = 0R
        Me.MD_ProcenOutH1.KeypadScaleFactor = 1.0R
        Me.MD_ProcenOutH1.KeypadText = Nothing
        Me.MD_ProcenOutH1.KeypadWidth = 300
        Me.MD_ProcenOutH1.Location = New System.Drawing.Point(218, 285)
        Me.MD_ProcenOutH1.Name = "MD_ProcenOutH1"
        Me.MD_ProcenOutH1.NumberOfDigits = 5
        Me.MD_ProcenOutH1.PLCAddressKeypad = "PID_HORNO.SO"
        Me.MD_ProcenOutH1.PLCAddressValue = "PID_HORNO.SO"
        Me.MD_ProcenOutH1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutH1.Size = New System.Drawing.Size(94, 41)
        Me.MD_ProcenOutH1.TabIndex = 974
        Me.MD_ProcenOutH1.Value = 0R
        Me.MD_ProcenOutH1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_ProcenOutH1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexProcenOutGU16
        '
        Me.TexProcenOutGU16.AutoSize = True
        Me.TexProcenOutGU16.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU16.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU16.Location = New System.Drawing.Point(561, 551)
        Me.TexProcenOutGU16.Name = "TexProcenOutGU16"
        Me.TexProcenOutGU16.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU16.TabIndex = 972
        Me.TexProcenOutGU16.Text = "% Salida"
        '
        'TexRealOutGU16
        '
        Me.TexRealOutGU16.AutoSize = True
        Me.TexRealOutGU16.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU16.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU16.Location = New System.Drawing.Point(577, 486)
        Me.TexRealOutGU16.Name = "TexRealOutGU16"
        Me.TexRealOutGU16.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU16.TabIndex = 971
        Me.TexRealOutGU16.Text = "Real"
        '
        'TexOutGU16
        '
        Me.TexOutGU16.AutoSize = True
        Me.TexOutGU16.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU16.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU16.Location = New System.Drawing.Point(546, 465)
        Me.TexOutGU16.Name = "TexOutGU16"
        Me.TexOutGU16.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU16.TabIndex = 970
        Me.TexOutGU16.Text = "Guardiola 16"
        '
        'TexProcenOutGU15
        '
        Me.TexProcenOutGU15.AutoSize = True
        Me.TexProcenOutGU15.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU15.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU15.Location = New System.Drawing.Point(396, 551)
        Me.TexProcenOutGU15.Name = "TexProcenOutGU15"
        Me.TexProcenOutGU15.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU15.TabIndex = 969
        Me.TexProcenOutGU15.Text = "% Salida"
        '
        'TexRealOutGU15
        '
        Me.TexRealOutGU15.AutoSize = True
        Me.TexRealOutGU15.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU15.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU15.Location = New System.Drawing.Point(412, 486)
        Me.TexRealOutGU15.Name = "TexRealOutGU15"
        Me.TexRealOutGU15.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU15.TabIndex = 968
        Me.TexRealOutGU15.Text = "Real"
        '
        'TexOutGU15
        '
        Me.TexOutGU15.AutoSize = True
        Me.TexOutGU15.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU15.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU15.Location = New System.Drawing.Point(381, 465)
        Me.TexOutGU15.Name = "TexOutGU15"
        Me.TexOutGU15.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU15.TabIndex = 967
        Me.TexOutGU15.Text = "Guardiola 15"
        '
        'TexProcenOutGU14
        '
        Me.TexProcenOutGU14.AutoSize = True
        Me.TexProcenOutGU14.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU14.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU14.Location = New System.Drawing.Point(230, 551)
        Me.TexProcenOutGU14.Name = "TexProcenOutGU14"
        Me.TexProcenOutGU14.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU14.TabIndex = 966
        Me.TexProcenOutGU14.Text = "% Salida"
        '
        'TexRealOutGU14
        '
        Me.TexRealOutGU14.AutoSize = True
        Me.TexRealOutGU14.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU14.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU14.Location = New System.Drawing.Point(246, 486)
        Me.TexRealOutGU14.Name = "TexRealOutGU14"
        Me.TexRealOutGU14.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU14.TabIndex = 965
        Me.TexRealOutGU14.Text = "Real"
        '
        'TexOutGU14
        '
        Me.TexOutGU14.AutoSize = True
        Me.TexOutGU14.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU14.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU14.Location = New System.Drawing.Point(215, 465)
        Me.TexOutGU14.Name = "TexOutGU14"
        Me.TexOutGU14.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU14.TabIndex = 964
        Me.TexOutGU14.Text = "Guardiola 14"
        '
        'TexProcenOutGU13
        '
        Me.TexProcenOutGU13.AutoSize = True
        Me.TexProcenOutGU13.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU13.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU13.Location = New System.Drawing.Point(1049, 264)
        Me.TexProcenOutGU13.Name = "TexProcenOutGU13"
        Me.TexProcenOutGU13.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU13.TabIndex = 960
        Me.TexProcenOutGU13.Text = "% Salida"
        '
        'TexRealOutGU13
        '
        Me.TexRealOutGU13.AutoSize = True
        Me.TexRealOutGU13.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU13.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU13.Location = New System.Drawing.Point(1065, 199)
        Me.TexRealOutGU13.Name = "TexRealOutGU13"
        Me.TexRealOutGU13.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU13.TabIndex = 959
        Me.TexRealOutGU13.Text = "Real"
        '
        'TexOutGU13
        '
        Me.TexOutGU13.AutoSize = True
        Me.TexOutGU13.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU13.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU13.Location = New System.Drawing.Point(1034, 178)
        Me.TexOutGU13.Name = "TexOutGU13"
        Me.TexOutGU13.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU13.TabIndex = 958
        Me.TexOutGU13.Text = "Guardiola 13"
        '
        'TexProcenOutGU12
        '
        Me.TexProcenOutGU12.AutoSize = True
        Me.TexProcenOutGU12.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU12.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU12.Location = New System.Drawing.Point(885, 264)
        Me.TexProcenOutGU12.Name = "TexProcenOutGU12"
        Me.TexProcenOutGU12.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU12.TabIndex = 957
        Me.TexProcenOutGU12.Text = "% Salida"
        '
        'TexRealOutGU12
        '
        Me.TexRealOutGU12.AutoSize = True
        Me.TexRealOutGU12.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU12.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU12.Location = New System.Drawing.Point(901, 199)
        Me.TexRealOutGU12.Name = "TexRealOutGU12"
        Me.TexRealOutGU12.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU12.TabIndex = 956
        Me.TexRealOutGU12.Text = "Real"
        '
        'TexOutGU12
        '
        Me.TexOutGU12.AutoSize = True
        Me.TexOutGU12.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU12.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU12.Location = New System.Drawing.Point(870, 178)
        Me.TexOutGU12.Name = "TexOutGU12"
        Me.TexOutGU12.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU12.TabIndex = 955
        Me.TexOutGU12.Text = "Guardiola 12"
        '
        'TexProcenOutGU11
        '
        Me.TexProcenOutGU11.AutoSize = True
        Me.TexProcenOutGU11.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU11.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU11.Location = New System.Drawing.Point(722, 264)
        Me.TexProcenOutGU11.Name = "TexProcenOutGU11"
        Me.TexProcenOutGU11.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU11.TabIndex = 954
        Me.TexProcenOutGU11.Text = "% Salida"
        '
        'TexRealOutGU11
        '
        Me.TexRealOutGU11.AutoSize = True
        Me.TexRealOutGU11.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU11.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU11.Location = New System.Drawing.Point(738, 199)
        Me.TexRealOutGU11.Name = "TexRealOutGU11"
        Me.TexRealOutGU11.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU11.TabIndex = 953
        Me.TexRealOutGU11.Text = "Real"
        '
        'TexOutGU11
        '
        Me.TexOutGU11.AutoSize = True
        Me.TexOutGU11.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU11.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU11.Location = New System.Drawing.Point(707, 178)
        Me.TexOutGU11.Name = "TexOutGU11"
        Me.TexOutGU11.Size = New System.Drawing.Size(97, 18)
        Me.TexOutGU11.TabIndex = 952
        Me.TexOutGU11.Text = "Guardiola 11"
        '
        'TexMantH1
        '
        Me.TexMantH1.AutoSize = True
        Me.TexMantH1.BackColor = System.Drawing.Color.DimGray
        Me.TexMantH1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexMantH1.ForeColor = System.Drawing.Color.White
        Me.TexMantH1.Location = New System.Drawing.Point(511, 71)
        Me.TexMantH1.Name = "TexMantH1"
        Me.TexMantH1.Size = New System.Drawing.Size(348, 34)
        Me.TexMantH1.TabIndex = 948
        Me.TexMantH1.Text = " Mantenimiento Horno 1"
        '
        'TexProcenOutGU10
        '
        Me.TexProcenOutGU10.AutoSize = True
        Me.TexProcenOutGU10.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU10.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU10.Location = New System.Drawing.Point(558, 264)
        Me.TexProcenOutGU10.Name = "TexProcenOutGU10"
        Me.TexProcenOutGU10.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU10.TabIndex = 947
        Me.TexProcenOutGU10.Text = "% Salida"
        '
        'TexRealOutGU10
        '
        Me.TexRealOutGU10.AutoSize = True
        Me.TexRealOutGU10.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU10.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU10.Location = New System.Drawing.Point(574, 199)
        Me.TexRealOutGU10.Name = "TexRealOutGU10"
        Me.TexRealOutGU10.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU10.TabIndex = 946
        Me.TexRealOutGU10.Text = "Real"
        '
        'TexOutGU10
        '
        Me.TexOutGU10.AutoSize = True
        Me.TexOutGU10.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU10.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU10.Location = New System.Drawing.Point(543, 178)
        Me.TexOutGU10.Name = "TexOutGU10"
        Me.TexOutGU10.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU10.TabIndex = 945
        Me.TexOutGU10.Text = "Guardiola 10"
        '
        'TexProcenOutGU09
        '
        Me.TexProcenOutGU09.AutoSize = True
        Me.TexProcenOutGU09.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutGU09.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutGU09.Location = New System.Drawing.Point(392, 264)
        Me.TexProcenOutGU09.Name = "TexProcenOutGU09"
        Me.TexProcenOutGU09.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutGU09.TabIndex = 943
        Me.TexProcenOutGU09.Text = "% Salida"
        '
        'TexRealOutGU09
        '
        Me.TexRealOutGU09.AutoSize = True
        Me.TexRealOutGU09.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutGU09.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutGU09.Location = New System.Drawing.Point(408, 199)
        Me.TexRealOutGU09.Name = "TexRealOutGU09"
        Me.TexRealOutGU09.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutGU09.TabIndex = 942
        Me.TexRealOutGU09.Text = "Real"
        '
        'TexOutGU09
        '
        Me.TexOutGU09.AutoSize = True
        Me.TexOutGU09.BackColor = System.Drawing.Color.Silver
        Me.TexOutGU09.ForeColor = System.Drawing.Color.Blue
        Me.TexOutGU09.Location = New System.Drawing.Point(377, 178)
        Me.TexOutGU09.Name = "TexOutGU09"
        Me.TexOutGU09.Size = New System.Drawing.Size(98, 18)
        Me.TexOutGU09.TabIndex = 941
        Me.TexOutGU09.Text = "Guardiola 09"
        '
        'TexProcenOutH1
        '
        Me.TexProcenOutH1.AutoSize = True
        Me.TexProcenOutH1.BackColor = System.Drawing.Color.Silver
        Me.TexProcenOutH1.ForeColor = System.Drawing.Color.Black
        Me.TexProcenOutH1.Location = New System.Drawing.Point(229, 264)
        Me.TexProcenOutH1.Name = "TexProcenOutH1"
        Me.TexProcenOutH1.Size = New System.Drawing.Size(71, 18)
        Me.TexProcenOutH1.TabIndex = 939
        Me.TexProcenOutH1.Text = "% Salida"
        '
        'TexRealOutH1
        '
        Me.TexRealOutH1.AutoSize = True
        Me.TexRealOutH1.BackColor = System.Drawing.Color.Silver
        Me.TexRealOutH1.ForeColor = System.Drawing.Color.Black
        Me.TexRealOutH1.Location = New System.Drawing.Point(245, 199)
        Me.TexRealOutH1.Name = "TexRealOutH1"
        Me.TexRealOutH1.Size = New System.Drawing.Size(40, 18)
        Me.TexRealOutH1.TabIndex = 938
        Me.TexRealOutH1.Text = "Real"
        '
        'TexOutH1
        '
        Me.TexOutH1.AutoSize = True
        Me.TexOutH1.BackColor = System.Drawing.Color.Silver
        Me.TexOutH1.ForeColor = System.Drawing.Color.Blue
        Me.TexOutH1.Location = New System.Drawing.Point(227, 178)
        Me.TexOutH1.Name = "TexOutH1"
        Me.TexOutH1.Size = New System.Drawing.Size(72, 18)
        Me.TexOutH1.TabIndex = 937
        Me.TexOutH1.Text = "Horno 01"
        '
        'BCF_RegresarH1
        '
        Me.BCF_RegresarH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarH1.ComComponent = Nothing
        Me.BCF_RegresarH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarH1.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarH1.FormToOpen = Nothing
        Me.BCF_RegresarH1.KeypadWidth = 300
        Me.BCF_RegresarH1.Location = New System.Drawing.Point(983, 51)
        Me.BCF_RegresarH1.Name = "BCF_RegresarH1"
        Me.BCF_RegresarH1.Passcode = Nothing
        Me.BCF_RegresarH1.PasswordChar = False
        Me.BCF_RegresarH1.PLCAddressVisible = ""
        Me.BCF_RegresarH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarH1.TabIndex = 1017
        Me.BCF_RegresarH1.Text = "Regresar"
        Me.BCF_RegresarH1.UseVisualStyleBackColor = False
        '
        'BCF_MenúP_MantH1
        '
        Me.BCF_MenúP_MantH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_MantH1.ComComponent = Nothing
        Me.BCF_MenúP_MantH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_MantH1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_MantH1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_MantH1.KeypadWidth = 300
        Me.BCF_MenúP_MantH1.Location = New System.Drawing.Point(205, 51)
        Me.BCF_MenúP_MantH1.Name = "BCF_MenúP_MantH1"
        Me.BCF_MenúP_MantH1.Passcode = Nothing
        Me.BCF_MenúP_MantH1.PasswordChar = False
        Me.BCF_MenúP_MantH1.PLCAddressVisible = ""
        Me.BCF_MenúP_MantH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_MantH1.TabIndex = 1016
        Me.BCF_MenúP_MantH1.Text = "Menú Principal"
        Me.BCF_MenúP_MantH1.UseVisualStyleBackColor = False
        '
        'IF_OutGU16
        '
        Me.IF_OutGU16.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU16.Location = New System.Drawing.Point(533, 456)
        Me.IF_OutGU16.Name = "IF_OutGU16"
        Me.IF_OutGU16.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU16.TabIndex = 963
        Me.IF_OutGU16.TabStop = False
        '
        'IF_OutGU15
        '
        Me.IF_OutGU15.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU15.Location = New System.Drawing.Point(369, 456)
        Me.IF_OutGU15.Name = "IF_OutGU15"
        Me.IF_OutGU15.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU15.TabIndex = 962
        Me.IF_OutGU15.TabStop = False
        '
        'IF_OutGU14
        '
        Me.IF_OutGU14.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU14.Location = New System.Drawing.Point(205, 456)
        Me.IF_OutGU14.Name = "IF_OutGU14"
        Me.IF_OutGU14.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU14.TabIndex = 961
        Me.IF_OutGU14.TabStop = False
        '
        'IF_OutGU13
        '
        Me.IF_OutGU13.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU13.Location = New System.Drawing.Point(1022, 169)
        Me.IF_OutGU13.Name = "IF_OutGU13"
        Me.IF_OutGU13.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU13.TabIndex = 951
        Me.IF_OutGU13.TabStop = False
        '
        'IF_OutGU12
        '
        Me.IF_OutGU12.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU12.Location = New System.Drawing.Point(858, 169)
        Me.IF_OutGU12.Name = "IF_OutGU12"
        Me.IF_OutGU12.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU12.TabIndex = 950
        Me.IF_OutGU12.TabStop = False
        '
        'IF_OutGU11
        '
        Me.IF_OutGU11.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU11.Location = New System.Drawing.Point(694, 169)
        Me.IF_OutGU11.Name = "IF_OutGU11"
        Me.IF_OutGU11.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU11.TabIndex = 949
        Me.IF_OutGU11.TabStop = False
        '
        'IF_OutGU10
        '
        Me.IF_OutGU10.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU10.Location = New System.Drawing.Point(530, 169)
        Me.IF_OutGU10.Name = "IF_OutGU10"
        Me.IF_OutGU10.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU10.TabIndex = 944
        Me.IF_OutGU10.TabStop = False
        '
        'IF_OutGU09
        '
        Me.IF_OutGU09.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutGU09.Location = New System.Drawing.Point(366, 169)
        Me.IF_OutGU09.Name = "IF_OutGU09"
        Me.IF_OutGU09.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutGU09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutGU09.TabIndex = 940
        Me.IF_OutGU09.TabStop = False
        '
        'IF_OutH1
        '
        Me.IF_OutH1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Malla7
        Me.IF_OutH1.Location = New System.Drawing.Point(202, 169)
        Me.IF_OutH1.Name = "IF_OutH1"
        Me.IF_OutH1.Size = New System.Drawing.Size(125, 207)
        Me.IF_OutH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_OutH1.TabIndex = 936
        Me.IF_OutH1.TabStop = False
        '
        'Dámper_Horno_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCF_RegresarH1)
        Me.Controls.Add(Me.MD_RealOutGU16)
        Me.Controls.Add(Me.MD_ProcenOutGU15)
        Me.Controls.Add(Me.MD_RealOutGU15)
        Me.Controls.Add(Me.MD_ProcenOutGU14)
        Me.Controls.Add(Me.MD_RealOutGU14)
        Me.Controls.Add(Me.MD_ProcenOutGU13)
        Me.Controls.Add(Me.MD_RealOutGU13)
        Me.Controls.Add(Me.MD_ProcenOutGU12)
        Me.Controls.Add(Me.MD_RealOutGU12)
        Me.Controls.Add(Me.MD_ProcenOutGU11)
        Me.Controls.Add(Me.MD_RealOutGU11)
        Me.Controls.Add(Me.BP_BloqueoGU16)
        Me.Controls.Add(Me.BP_ManualGU16)
        Me.Controls.Add(Me.BP_LuzGU16)
        Me.Controls.Add(Me.BP_BloqueoGU15)
        Me.Controls.Add(Me.BP_ManualGU15)
        Me.Controls.Add(Me.BP_LuzGU15)
        Me.Controls.Add(Me.BP_BloqueoGU14)
        Me.Controls.Add(Me.BP_ManualGU14)
        Me.Controls.Add(Me.BP_LuzGU14)
        Me.Controls.Add(Me.BP_BloqueoGU13)
        Me.Controls.Add(Me.BP_ManualGU13)
        Me.Controls.Add(Me.BP_LuzGU13)
        Me.Controls.Add(Me.BP_BloqueoGU12)
        Me.Controls.Add(Me.BP_ManualGU12)
        Me.Controls.Add(Me.BP_LuzGU12)
        Me.Controls.Add(Me.BP_BloqueoGU11)
        Me.Controls.Add(Me.BP_ManualGU11)
        Me.Controls.Add(Me.BP_LuzGU11)
        Me.Controls.Add(Me.BP_BloqueoGU10)
        Me.Controls.Add(Me.BP_ManualGU10)
        Me.Controls.Add(Me.BP_LuzGU10)
        Me.Controls.Add(Me.MD_ProcenOutGU10)
        Me.Controls.Add(Me.MD_RealOutGU10)
        Me.Controls.Add(Me.MD_ProcenOutGU09)
        Me.Controls.Add(Me.MD_RealOutGU09)
        Me.Controls.Add(Me.BP_BloqueoGU09)
        Me.Controls.Add(Me.BP_ManualGU09)
        Me.Controls.Add(Me.BP_LuzGU09)
        Me.Controls.Add(Me.BP_ManualH1)
        Me.Controls.Add(Me.MD_RealOutH1)
        Me.Controls.Add(Me.BCF_MenúP_MantH1)
        Me.Controls.Add(Me.MD_ProcenOutGU16)
        Me.Controls.Add(Me.MD_ProcenOutH1)
        Me.Controls.Add(Me.TexProcenOutGU16)
        Me.Controls.Add(Me.TexRealOutGU16)
        Me.Controls.Add(Me.TexOutGU16)
        Me.Controls.Add(Me.TexProcenOutGU15)
        Me.Controls.Add(Me.TexRealOutGU15)
        Me.Controls.Add(Me.TexOutGU15)
        Me.Controls.Add(Me.TexProcenOutGU14)
        Me.Controls.Add(Me.TexRealOutGU14)
        Me.Controls.Add(Me.TexOutGU14)
        Me.Controls.Add(Me.IF_OutGU16)
        Me.Controls.Add(Me.IF_OutGU15)
        Me.Controls.Add(Me.IF_OutGU14)
        Me.Controls.Add(Me.TexProcenOutGU13)
        Me.Controls.Add(Me.TexRealOutGU13)
        Me.Controls.Add(Me.TexOutGU13)
        Me.Controls.Add(Me.TexProcenOutGU12)
        Me.Controls.Add(Me.TexRealOutGU12)
        Me.Controls.Add(Me.TexOutGU12)
        Me.Controls.Add(Me.TexProcenOutGU11)
        Me.Controls.Add(Me.TexRealOutGU11)
        Me.Controls.Add(Me.TexOutGU11)
        Me.Controls.Add(Me.IF_OutGU13)
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
        Me.Name = "Dámper_Horno_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DámperH1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutGU09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_OutH1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCF_RegresarH1 As FormChangeButton
    Friend WithEvents MD_RealOutGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DámperH1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents MD_ProcenOutGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU15 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU14 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_BloqueoGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_BloqueoGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_ProcenOutGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_RealOutGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BP_BloqueoGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_LuzGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_ManualH1 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_RealOutH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_MenúP_MantH1 As FormChangeButton
    Friend WithEvents MD_ProcenOutGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_ProcenOutH1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexProcenOutGU16 As Label
    Friend WithEvents TexRealOutGU16 As Label
    Friend WithEvents TexOutGU16 As Label
    Friend WithEvents TexProcenOutGU15 As Label
    Friend WithEvents TexRealOutGU15 As Label
    Friend WithEvents TexOutGU15 As Label
    Friend WithEvents TexProcenOutGU14 As Label
    Friend WithEvents TexRealOutGU14 As Label
    Friend WithEvents TexOutGU14 As Label
    Friend WithEvents IF_OutGU16 As PictureBox
    Friend WithEvents IF_OutGU15 As PictureBox
    Friend WithEvents IF_OutGU14 As PictureBox
    Friend WithEvents TexProcenOutGU13 As Label
    Friend WithEvents TexRealOutGU13 As Label
    Friend WithEvents TexOutGU13 As Label
    Friend WithEvents TexProcenOutGU12 As Label
    Friend WithEvents TexRealOutGU12 As Label
    Friend WithEvents TexOutGU12 As Label
    Friend WithEvents TexProcenOutGU11 As Label
    Friend WithEvents TexRealOutGU11 As Label
    Friend WithEvents TexOutGU11 As Label
    Friend WithEvents IF_OutGU13 As PictureBox
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
