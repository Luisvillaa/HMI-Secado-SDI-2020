<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_08
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_08))
        Me.CT_SGU08 = New AdvancedHMIControls.TempController()
        Me.Guardiola08 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU08 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU08 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU08 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU08 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU08 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU08 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU08 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU08 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU08 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU08 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU08 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU08 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU08 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU08 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU08 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU08 = New System.Windows.Forms.Label()
        Me.TexGuardiola8 = New System.Windows.Forms.Label()
        Me.TexTempGU08 = New System.Windows.Forms.Label()
        Me.TexPID_GU08 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU08 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU08 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU08 = New System.Windows.Forms.Label()
        Me.IGU08 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU08, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU08
        '
        Me.CT_SGU08.Button1Text = Nothing
        Me.CT_SGU08.Button2Text = Nothing
        Me.CT_SGU08.ComComponent = Me.Guardiola08
        Me.CT_SGU08.DecimalPosition = 1
        Me.CT_SGU08.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU08.Location = New System.Drawing.Point(203, 432)
        Me.CT_SGU08.Name = "CT_SGU08"
        Me.CT_SGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU08.PLCAddressClick1 = ""
        Me.CT_SGU08.PLCAddressClick2 = ""
        Me.CT_SGU08.PLCAddressClick3 = ""
        Me.CT_SGU08.PLCAddressClick4 = ""
        Me.CT_SGU08.PLCAddressText = ""
        Me.CT_SGU08.PLCAddressValuePV = "PID_SGU08.PV"
        Me.CT_SGU08.PLCAddressValueSP = "PID_SGU08.SP"
        Me.CT_SGU08.PLCAddressVisible = ""
        Me.CT_SGU08.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU08.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU08.TabIndex = 675
        Me.CT_SGU08.Text = "S-GU-08"
        Me.CT_SGU08.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU08.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU08.Value2Text = "SP"
        Me.CT_SGU08.ValuePV = 0!
        Me.CT_SGU08.ValueSP = 0!
        '
        'Guardiola08
        '
        Me.Guardiola08.CIPConnectionSize = 508
        Me.Guardiola08.DisableMultiServiceRequest = False
        Me.Guardiola08.DisableSubscriptions = False
        Me.Guardiola08.IniFileName = ""
        Me.Guardiola08.IniFileSection = Nothing
        Me.Guardiola08.IPAddress = "10.1.108.18"
        Me.Guardiola08.PollRateOverride = 500
        Me.Guardiola08.Port = 44818
        Me.Guardiola08.ProcessorSlot = 0
        Me.Guardiola08.RoutePath = Nothing
        Me.Guardiola08.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola08
        Me.BarMeter1.HighlightColor = System.Drawing.Color.Red
        Me.BarMeter1.IniFileName = ""
        Me.BarMeter1.IniFileSection = Nothing
        Me.BarMeter1.Location = New System.Drawing.Point(96, 103)
        Me.BarMeter1.Maximum = 100.0R
        Me.BarMeter1.Minimum = 0R
        Me.BarMeter1.Name = "BarMeter1"
        Me.BarMeter1.PLCAddressText = ""
        Me.BarMeter1.PLCAddressValue = CType(resources.GetObject("BarMeter1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.BarMeter1.PLCAddressVisible = ""
        Me.BarMeter1.Size = New System.Drawing.Size(43, 237)
        Me.BarMeter1.TabIndex = 631
        Me.BarMeter1.Value = 0R
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Red
        Me.BasicButton1.ComComponent = Me.Guardiola08
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(961, 588)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_SGU08"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 673
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU08
        '
        Me.LS_MarchaGU08.Blink = False
        Me.LS_MarchaGU08.ComComponent = Me.Guardiola08
        Me.LS_MarchaGU08.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU08.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU08.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU08.Location = New System.Drawing.Point(855, 317)
        Me.LS_MarchaGU08.Name = "LS_MarchaGU08"
        Me.LS_MarchaGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU08.PLCAddressClick = ""
        Me.LS_MarchaGU08.PLCAddressText = ""
        Me.LS_MarchaGU08.PLCAddressValue = "MARCHA_SGU08"
        Me.LS_MarchaGU08.PLCAddressVisible = ""
        Me.LS_MarchaGU08.Size = New System.Drawing.Size(52, 55)
        Me.LS_MarchaGU08.TabIndex = 670
        Me.LS_MarchaGU08.Value = False
        Me.LS_MarchaGU08.ValueToWrite = 0
        '
        'BCF_MenúP_GU08
        '
        Me.BCF_MenúP_GU08.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU08.ComComponent = Nothing
        Me.BCF_MenúP_GU08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU08.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU08.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU08.KeypadWidth = 300
        Me.BCF_MenúP_GU08.Location = New System.Drawing.Point(231, 647)
        Me.BCF_MenúP_GU08.Name = "BCF_MenúP_GU08"
        Me.BCF_MenúP_GU08.Passcode = Nothing
        Me.BCF_MenúP_GU08.PasswordChar = False
        Me.BCF_MenúP_GU08.PLCAddressVisible = ""
        Me.BCF_MenúP_GU08.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU08.TabIndex = 669
        Me.BCF_MenúP_GU08.Text = "Menú Principal"
        Me.BCF_MenúP_GU08.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU08
        '
        Me.BP_FinCicloGU08.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU08.ComComponent = Me.Guardiola08
        Me.BP_FinCicloGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU08.Highlight = False
        Me.BP_FinCicloGU08.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU08.Location = New System.Drawing.Point(711, 226)
        Me.BP_FinCicloGU08.MaximumHoldTime = 3000
        Me.BP_FinCicloGU08.MinimumHoldTime = 500
        Me.BP_FinCicloGU08.Name = "BP_FinCicloGU08"
        Me.BP_FinCicloGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU08.PLCAddressClick = "BP_DETENER_CICLO_SGU08"
        Me.BP_FinCicloGU08.SelectTextAlternate = False
        Me.BP_FinCicloGU08.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU08.TabIndex = 668
        Me.BP_FinCicloGU08.Text = "Detener Ciclo"
        Me.BP_FinCicloGU08.TextAlternate = Nothing
        Me.BP_FinCicloGU08.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU08.ValueToWrite = 0
        '
        'BP_IniCicloGU08
        '
        Me.BP_IniCicloGU08.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU08.ComComponent = Me.Guardiola08
        Me.BP_IniCicloGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU08.Highlight = False
        Me.BP_IniCicloGU08.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU08.Location = New System.Drawing.Point(509, 226)
        Me.BP_IniCicloGU08.MaximumHoldTime = 3000
        Me.BP_IniCicloGU08.MinimumHoldTime = 500
        Me.BP_IniCicloGU08.Name = "BP_IniCicloGU08"
        Me.BP_IniCicloGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU08.PLCAddressClick = "BP_INICIO_CICLO_SGU08"
        Me.BP_IniCicloGU08.SelectTextAlternate = False
        Me.BP_IniCicloGU08.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU08.TabIndex = 667
        Me.BP_IniCicloGU08.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU08.TextAlternate = Nothing
        Me.BP_IniCicloGU08.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU08.ValueToWrite = 0
        '
        'BCF_RegresarGU08
        '
        Me.BCF_RegresarGU08.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU08.ComComponent = Nothing
        Me.BCF_RegresarGU08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU08.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU08.FormToOpen = Nothing
        Me.BCF_RegresarGU08.KeypadWidth = 300
        Me.BCF_RegresarGU08.Location = New System.Drawing.Point(646, 100)
        Me.BCF_RegresarGU08.Name = "BCF_RegresarGU08"
        Me.BCF_RegresarGU08.Passcode = Nothing
        Me.BCF_RegresarGU08.PasswordChar = False
        Me.BCF_RegresarGU08.PLCAddressVisible = ""
        Me.BCF_RegresarGU08.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU08.TabIndex = 666
        Me.BCF_RegresarGU08.Text = "Regresar"
        Me.BCF_RegresarGU08.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU08
        '
        Me.BP_DescargaGU08.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU08.ComComponent = Me.Guardiola08
        Me.BP_DescargaGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU08.Highlight = False
        Me.BP_DescargaGU08.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU08.Location = New System.Drawing.Point(961, 123)
        Me.BP_DescargaGU08.MaximumHoldTime = 3000
        Me.BP_DescargaGU08.MinimumHoldTime = 500
        Me.BP_DescargaGU08.Name = "BP_DescargaGU08"
        Me.BP_DescargaGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU08.PLCAddressClick = "BP_FINALIZAR_SGU08"
        Me.BP_DescargaGU08.PLCAddressHighlightX = "CONFIMAR_FINALIZAR_SGU08"
        Me.BP_DescargaGU08.PLCAddressSelectTextAlternate = "CONFIMAR_FINALIZAR_SGU08"
        Me.BP_DescargaGU08.SelectTextAlternate = False
        Me.BP_DescargaGU08.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU08.TabIndex = 665
        Me.BP_DescargaGU08.Text = "Finalizar"
        Me.BP_DescargaGU08.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU08.UseVisualStyleBackColor = True
        Me.BP_DescargaGU08.ValueToWrite = 0
        '
        'BP_CofirDescagaGU08
        '
        Me.BP_CofirDescagaGU08.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU08.ComComponent = Me.Guardiola08
        Me.BP_CofirDescagaGU08.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU08.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU08.Highlight = False
        Me.BP_CofirDescagaGU08.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU08.Location = New System.Drawing.Point(961, 64)
        Me.BP_CofirDescagaGU08.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU08.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU08.Name = "BP_CofirDescagaGU08"
        Me.BP_CofirDescagaGU08.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU08.PLCAddressClick = "BP_CONFIMAR_FINALIZAR_SGU08"
        Me.BP_CofirDescagaGU08.PLCAddressVisible = "CONFIMAR_FINALIZAR_SGU08"
        Me.BP_CofirDescagaGU08.SelectTextAlternate = False
        Me.BP_CofirDescagaGU08.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU08.TabIndex = 664
        Me.BP_CofirDescagaGU08.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU08.TextAlternate = Nothing
        Me.BP_CofirDescagaGU08.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU08.ValueToWrite = 0
        '
        'BN_SalidaGU08
        '
        Me.BN_SalidaGU08.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU08.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU08.ComComponent = Me.Guardiola08
        Me.BN_SalidaGU08.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU08.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU08.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU08.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU08.Location = New System.Drawing.Point(358, 156)
        Me.BN_SalidaGU08.Maximum = 100.0R
        Me.BN_SalidaGU08.Minimum = 0R
        Me.BN_SalidaGU08.Name = "BN_SalidaGU08"
        Me.BN_SalidaGU08.NumericFormat = Nothing
        Me.BN_SalidaGU08.PLCAddressValue = "PID_SGU08.OUT"
        Me.BN_SalidaGU08.ShowValue = True
        Me.BN_SalidaGU08.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU08.TabIndex = 663
        Me.BN_SalidaGU08.Text = "BarLevel3"
        Me.BN_SalidaGU08.TextSuffix = Nothing
        Me.BN_SalidaGU08.Value = 0R
        Me.BN_SalidaGU08.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU08
        '
        Me.BN_SP_TempGU08.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU08.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU08.ComComponent = Me.Guardiola08
        Me.BN_SP_TempGU08.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU08.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU08.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU08.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU08.Location = New System.Drawing.Point(216, 157)
        Me.BN_SP_TempGU08.Maximum = 100.0R
        Me.BN_SP_TempGU08.Minimum = 0R
        Me.BN_SP_TempGU08.Name = "BN_SP_TempGU08"
        Me.BN_SP_TempGU08.NumericFormat = Nothing
        Me.BN_SP_TempGU08.PLCAddressValue = "PID_SGU08.SP"
        Me.BN_SP_TempGU08.ShowValue = True
        Me.BN_SP_TempGU08.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU08.TabIndex = 662
        Me.BN_SP_TempGU08.Text = "BarLevel1"
        Me.BN_SP_TempGU08.TextSuffix = Nothing
        Me.BN_SP_TempGU08.Value = 0R
        Me.BN_SP_TempGU08.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU08
        '
        Me.MD_OrdenTrabajoGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU08.ComComponent = Me.Guardiola08
        Me.MD_OrdenTrabajoGU08.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU08.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU08.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU08.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU08.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU08.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU08.Location = New System.Drawing.Point(989, 507)
        Me.MD_OrdenTrabajoGU08.Name = "MD_OrdenTrabajoGU08"
        Me.MD_OrdenTrabajoGU08.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU08.PLCAddressKeypad = "ORDEN_DE_TRABAJO_SGU08"
        Me.MD_OrdenTrabajoGU08.PLCAddressValue = "ORDEN_DE_TRABAJO_SGU08"
        Me.MD_OrdenTrabajoGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU08.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU08.TabIndex = 661
        Me.MD_OrdenTrabajoGU08.Value = 0R
        Me.MD_OrdenTrabajoGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU08
        '
        Me.MD_CosechaGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU08.ComComponent = Me.Guardiola08
        Me.MD_CosechaGU08.DecimalPosition = 0
        Me.MD_CosechaGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU08.KeypadMaxValue = 0R
        Me.MD_CosechaGU08.KeypadMinValue = 0R
        Me.MD_CosechaGU08.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU08.KeypadText = Nothing
        Me.MD_CosechaGU08.KeypadWidth = 300
        Me.MD_CosechaGU08.Location = New System.Drawing.Point(989, 410)
        Me.MD_CosechaGU08.Name = "MD_CosechaGU08"
        Me.MD_CosechaGU08.NumberOfDigits = 5
        Me.MD_CosechaGU08.PLCAddressKeypad = ""
        Me.MD_CosechaGU08.PLCAddressValue = "COSECHA_SGU08"
        Me.MD_CosechaGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU08.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU08.TabIndex = 660
        Me.MD_CosechaGU08.Value = 0R
        Me.MD_CosechaGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU08
        '
        Me.MD_HorasEstimadasGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU08.ComComponent = Me.Guardiola08
        Me.MD_HorasEstimadasGU08.DecimalPosition = 0
        Me.MD_HorasEstimadasGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU08.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU08.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU08.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU08.KeypadText = Nothing
        Me.MD_HorasEstimadasGU08.KeypadWidth = 300
        Me.MD_HorasEstimadasGU08.Location = New System.Drawing.Point(989, 317)
        Me.MD_HorasEstimadasGU08.Name = "MD_HorasEstimadasGU08"
        Me.MD_HorasEstimadasGU08.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU08.PLCAddressKeypad = "TIEMPO_ESTIMADO_SGU08"
        Me.MD_HorasEstimadasGU08.PLCAddressValue = "TIEMPO_ESTIMADO_SGU08"
        Me.MD_HorasEstimadasGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU08.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU08.TabIndex = 659
        Me.MD_HorasEstimadasGU08.Value = 0R
        Me.MD_HorasEstimadasGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU08
        '
        Me.MD_CicloGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU08.ComComponent = Me.Guardiola08
        Me.MD_CicloGU08.DecimalPosition = 0
        Me.MD_CicloGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU08.KeypadMaxValue = 0R
        Me.MD_CicloGU08.KeypadMinValue = 0R
        Me.MD_CicloGU08.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU08.KeypadText = Nothing
        Me.MD_CicloGU08.KeypadWidth = 300
        Me.MD_CicloGU08.Location = New System.Drawing.Point(989, 225)
        Me.MD_CicloGU08.Name = "MD_CicloGU08"
        Me.MD_CicloGU08.NumberOfDigits = 5
        Me.MD_CicloGU08.PLCAddressKeypad = "NUMERO_CICLO_SECADO_SGU08"
        Me.MD_CicloGU08.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU08"
        Me.MD_CicloGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU08.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU08.TabIndex = 658
        Me.MD_CicloGU08.Value = 0R
        Me.MD_CicloGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU08
        '
        Me.TexCicloGU08.AutoSize = True
        Me.TexCicloGU08.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU08.ComComponent = Me.Guardiola08
        Me.TexCicloGU08.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU08.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU08.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU08.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU08.HighlightKeyCharacter = "!"
        Me.TexCicloGU08.HighlightKeyCharacter2 = "."
        Me.TexCicloGU08.IniFileName = Nothing
        Me.TexCicloGU08.Location = New System.Drawing.Point(577, 521)
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Messages.Add(CType(resources.GetObject("TexCicloGU08.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU08.Name = "TexCicloGU08"
        Me.TexCicloGU08.PLCAddressValue = "NUMERO_CICLO_SECADO_SGU08"
        Me.TexCicloGU08.PLCAddressVisible = ""
        Me.TexCicloGU08.ShowMessageNumber = False
        Me.TexCicloGU08.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU08.SpeakMessage = False
        Me.TexCicloGU08.TabIndex = 671
        Me.TexCicloGU08.Text = "No Seleccionado"
        Me.TexCicloGU08.TextPrefix = Nothing
        Me.TexCicloGU08.Value = 0
        '
        'MD_TempGU08
        '
        Me.MD_TempGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU08.ComComponent = Me.Guardiola08
        Me.MD_TempGU08.DecimalPosition = 1
        Me.MD_TempGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU08.KeypadMaxValue = 0R
        Me.MD_TempGU08.KeypadMinValue = 0R
        Me.MD_TempGU08.KeypadScaleFactor = 1.0R
        Me.MD_TempGU08.KeypadText = Nothing
        Me.MD_TempGU08.KeypadWidth = 300
        Me.MD_TempGU08.Location = New System.Drawing.Point(603, 336)
        Me.MD_TempGU08.Name = "MD_TempGU08"
        Me.MD_TempGU08.NumberOfDigits = 5
        Me.MD_TempGU08.PLCAddressKeypad = ""
        Me.MD_TempGU08.PLCAddressValue = "PID_SGU08.PV"
        Me.MD_TempGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU08.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU08.TabIndex = 657
        Me.MD_TempGU08.Value = 0R
        Me.MD_TempGU08.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU08
        '
        Me.MD_HorasProcesoGU08.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU08.ComComponent = Me.Guardiola08
        Me.MD_HorasProcesoGU08.DecimalPosition = 0
        Me.MD_HorasProcesoGU08.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU08.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU08.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU08.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU08.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU08.KeypadText = Nothing
        Me.MD_HorasProcesoGU08.KeypadWidth = 300
        Me.MD_HorasProcesoGU08.Location = New System.Drawing.Point(466, 83)
        Me.MD_HorasProcesoGU08.Name = "MD_HorasProcesoGU08"
        Me.MD_HorasProcesoGU08.NumberOfDigits = 5
        Me.MD_HorasProcesoGU08.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU08.PLCAddressValue = "TIEMPO_SECADO_SGU08"
        Me.MD_HorasProcesoGU08.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU08.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU08.TabIndex = 656
        Me.MD_HorasProcesoGU08.Value = 0R
        Me.MD_HorasProcesoGU08.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU08.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU08
        '
        Me.Tex_CicloGU08.AutoSize = True
        Me.Tex_CicloGU08.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU08.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU08.Location = New System.Drawing.Point(976, 203)
        Me.Tex_CicloGU08.Name = "Tex_CicloGU08"
        Me.Tex_CicloGU08.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU08.TabIndex = 655
        Me.Tex_CicloGU08.Text = "Numero de Ciclo"
        Me.Tex_CicloGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU08
        '
        Me.Tex_OrdenTrabajoGU08.AutoSize = True
        Me.Tex_OrdenTrabajoGU08.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU08.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU08.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU08.Location = New System.Drawing.Point(1029, 482)
        Me.Tex_OrdenTrabajoGU08.Name = "Tex_OrdenTrabajoGU08"
        Me.Tex_OrdenTrabajoGU08.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU08.TabIndex = 654
        Me.Tex_OrdenTrabajoGU08.Text = "OT"
        Me.Tex_OrdenTrabajoGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU08
        '
        Me.Tex_CosechaGU08.AutoSize = True
        Me.Tex_CosechaGU08.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU08.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU08.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU08.Location = New System.Drawing.Point(997, 385)
        Me.Tex_CosechaGU08.Name = "Tex_CosechaGU08"
        Me.Tex_CosechaGU08.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU08.TabIndex = 653
        Me.Tex_CosechaGU08.Text = "Cosecha"
        Me.Tex_CosechaGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU08
        '
        Me.Tex_HorasEstimadasGU08.AutoSize = True
        Me.Tex_HorasEstimadasGU08.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU08.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU08.Location = New System.Drawing.Point(929, 295)
        Me.Tex_HorasEstimadasGU08.Name = "Tex_HorasEstimadasGU08"
        Me.Tex_HorasEstimadasGU08.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU08.TabIndex = 652
        Me.Tex_HorasEstimadasGU08.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU08
        '
        Me.Tex_HorasProcesoGU08.AutoSize = True
        Me.Tex_HorasProcesoGU08.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU08.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU08.Location = New System.Drawing.Point(450, 54)
        Me.Tex_HorasProcesoGU08.Name = "Tex_HorasProcesoGU08"
        Me.Tex_HorasProcesoGU08.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU08.TabIndex = 651
        Me.Tex_HorasProcesoGU08.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola8
        '
        Me.TexGuardiola8.AutoSize = True
        Me.TexGuardiola8.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola8.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola8.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola8.Location = New System.Drawing.Point(679, 55)
        Me.TexGuardiola8.Name = "TexGuardiola8"
        Me.TexGuardiola8.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola8.TabIndex = 650
        Me.TexGuardiola8.Text = "Guardiola 08"
        '
        'TexTempGU08
        '
        Me.TexTempGU08.AutoSize = True
        Me.TexTempGU08.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU08.Location = New System.Drawing.Point(600, 315)
        Me.TexTempGU08.Name = "TexTempGU08"
        Me.TexTempGU08.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU08.TabIndex = 649
        Me.TexTempGU08.Text = "Temperatura °C"
        Me.TexTempGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU08
        '
        Me.TexPID_GU08.AutoSize = True
        Me.TexPID_GU08.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU08.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU08.Location = New System.Drawing.Point(203, 74)
        Me.TexPID_GU08.Name = "TexPID_GU08"
        Me.TexPID_GU08.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU08.TabIndex = 648
        Me.TexPID_GU08.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU08
        '
        Me.TexBN_SalidaGU08.AutoSize = True
        Me.TexBN_SalidaGU08.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU08.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU08.Location = New System.Drawing.Point(351, 135)
        Me.TexBN_SalidaGU08.Name = "TexBN_SalidaGU08"
        Me.TexBN_SalidaGU08.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU08.TabIndex = 647
        Me.TexBN_SalidaGU08.Text = "Salida"
        Me.TexBN_SalidaGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU08
        '
        Me.TexBN_RealTempGU08.AutoSize = True
        Me.TexBN_RealTempGU08.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU08.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU08.Location = New System.Drawing.Point(288, 136)
        Me.TexBN_RealTempGU08.Name = "TexBN_RealTempGU08"
        Me.TexBN_RealTempGU08.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU08.TabIndex = 646
        Me.TexBN_RealTempGU08.Text = "Real"
        Me.TexBN_RealTempGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU08
        '
        Me.TexBN_SP_TempGU08.AutoSize = True
        Me.TexBN_SP_TempGU08.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU08.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU08.Location = New System.Drawing.Point(202, 136)
        Me.TexBN_SP_TempGU08.Name = "TexBN_SP_TempGU08"
        Me.TexBN_SP_TempGU08.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU08.TabIndex = 645
        Me.TexBN_SP_TempGU08.Text = "SetPoint"
        Me.TexBN_SP_TempGU08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU08
        '
        Me.IGU08.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU08.Location = New System.Drawing.Point(440, 308)
        Me.IGU08.Name = "IGU08"
        Me.IGU08.Size = New System.Drawing.Size(541, 274)
        Me.IGU08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU08.TabIndex = 672
        Me.IGU08.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola08
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(189, 52)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 674
        '
        'Guardiola_08
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU08)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU08)
        Me.Controls.Add(Me.BCF_MenúP_GU08)
        Me.Controls.Add(Me.BP_FinCicloGU08)
        Me.Controls.Add(Me.BP_IniCicloGU08)
        Me.Controls.Add(Me.BCF_RegresarGU08)
        Me.Controls.Add(Me.BP_DescargaGU08)
        Me.Controls.Add(Me.BP_CofirDescagaGU08)
        Me.Controls.Add(Me.BN_SalidaGU08)
        Me.Controls.Add(Me.BN_SP_TempGU08)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU08)
        Me.Controls.Add(Me.MD_CosechaGU08)
        Me.Controls.Add(Me.MD_HorasEstimadasGU08)
        Me.Controls.Add(Me.MD_CicloGU08)
        Me.Controls.Add(Me.TexCicloGU08)
        Me.Controls.Add(Me.MD_TempGU08)
        Me.Controls.Add(Me.MD_HorasProcesoGU08)
        Me.Controls.Add(Me.Tex_CicloGU08)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU08)
        Me.Controls.Add(Me.Tex_CosechaGU08)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU08)
        Me.Controls.Add(Me.Tex_HorasProcesoGU08)
        Me.Controls.Add(Me.TexGuardiola8)
        Me.Controls.Add(Me.TexTempGU08)
        Me.Controls.Add(Me.TexPID_GU08)
        Me.Controls.Add(Me.TexBN_SalidaGU08)
        Me.Controls.Add(Me.TexBN_RealTempGU08)
        Me.Controls.Add(Me.TexBN_SP_TempGU08)
        Me.Controls.Add(Me.IGU08)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_08"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU08, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU08 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola08 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU08 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU08 As FormChangeButton
    Friend WithEvents BP_FinCicloGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU08 As FormChangeButton
    Friend WithEvents BP_DescargaGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU08 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU08 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU08 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU08 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU08 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU08 As Label
    Friend WithEvents Tex_OrdenTrabajoGU08 As Label
    Friend WithEvents Tex_CosechaGU08 As Label
    Friend WithEvents Tex_HorasEstimadasGU08 As Label
    Friend WithEvents Tex_HorasProcesoGU08 As Label
    Friend WithEvents TexGuardiola8 As Label
    Friend WithEvents TexTempGU08 As Label
    Friend WithEvents TexPID_GU08 As Label
    Friend WithEvents TexBN_SalidaGU08 As Label
    Friend WithEvents TexBN_RealTempGU08 As Label
    Friend WithEvents TexBN_SP_TempGU08 As Label
    Friend WithEvents IGU08 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
