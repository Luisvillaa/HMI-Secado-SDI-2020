<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_11))
        Me.CT_SGU11 = New AdvancedHMIControls.TempController()
        Me.Guardiola11 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU11 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU11 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU11 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU11 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU11 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU11 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU11 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU11 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU11 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU11 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU11 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU11 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU11 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU11 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU11 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU11 = New System.Windows.Forms.Label()
        Me.TexGuardiola11 = New System.Windows.Forms.Label()
        Me.TexTempGU11 = New System.Windows.Forms.Label()
        Me.TexPID_GU11 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU11 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU11 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU11 = New System.Windows.Forms.Label()
        Me.IGU11 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU11
        '
        Me.CT_SGU11.Button1Text = Nothing
        Me.CT_SGU11.Button2Text = Nothing
        Me.CT_SGU11.ComComponent = Me.Guardiola11
        Me.CT_SGU11.DecimalPosition = 1
        Me.CT_SGU11.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU11.Location = New System.Drawing.Point(204, 431)
        Me.CT_SGU11.Name = "CT_SGU11"
        Me.CT_SGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU11.PLCAddressClick1 = ""
        Me.CT_SGU11.PLCAddressClick2 = ""
        Me.CT_SGU11.PLCAddressClick3 = ""
        Me.CT_SGU11.PLCAddressClick4 = ""
        Me.CT_SGU11.PLCAddressText = ""
        Me.CT_SGU11.PLCAddressValuePV = "PID_GUARDIOLA4.PV"
        Me.CT_SGU11.PLCAddressValueSP = "PID_GUARDIOLA4.SP"
        Me.CT_SGU11.PLCAddressVisible = ""
        Me.CT_SGU11.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU11.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU11.TabIndex = 681
        Me.CT_SGU11.Text = "S-GU-11"
        Me.CT_SGU11.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU11.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU11.Value2Text = "SP"
        Me.CT_SGU11.ValuePV = 0!
        Me.CT_SGU11.ValueSP = 0!
        '
        'Guardiola11
        '
        Me.Guardiola11.CIPConnectionSize = 508
        Me.Guardiola11.DisableMultiServiceRequest = False
        Me.Guardiola11.DisableSubscriptions = False
        Me.Guardiola11.IniFileName = ""
        Me.Guardiola11.IniFileSection = Nothing
        Me.Guardiola11.IPAddress = "10.1.108.20"
        Me.Guardiola11.PollRateOverride = 500
        Me.Guardiola11.Port = 44818
        Me.Guardiola11.ProcessorSlot = 0
        Me.Guardiola11.RoutePath = Nothing
        Me.Guardiola11.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola11
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
        Me.BasicButton1.ComComponent = Me.Guardiola11
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(961, 589)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA04"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 679
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU11
        '
        Me.LS_MarchaGU11.Blink = False
        Me.LS_MarchaGU11.ComComponent = Me.Guardiola11
        Me.LS_MarchaGU11.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU11.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU11.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU11.Location = New System.Drawing.Point(855, 317)
        Me.LS_MarchaGU11.Name = "LS_MarchaGU11"
        Me.LS_MarchaGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU11.PLCAddressClick = ""
        Me.LS_MarchaGU11.PLCAddressText = ""
        Me.LS_MarchaGU11.PLCAddressValue = "MARCHA_GU11"
        Me.LS_MarchaGU11.PLCAddressVisible = ""
        Me.LS_MarchaGU11.Size = New System.Drawing.Size(53, 56)
        Me.LS_MarchaGU11.TabIndex = 676
        Me.LS_MarchaGU11.Value = False
        Me.LS_MarchaGU11.ValueToWrite = 0
        '
        'BCF_MenúP_GU11
        '
        Me.BCF_MenúP_GU11.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU11.ComComponent = Nothing
        Me.BCF_MenúP_GU11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU11.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU11.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU11.KeypadWidth = 300
        Me.BCF_MenúP_GU11.Location = New System.Drawing.Point(231, 648)
        Me.BCF_MenúP_GU11.Name = "BCF_MenúP_GU11"
        Me.BCF_MenúP_GU11.Passcode = Nothing
        Me.BCF_MenúP_GU11.PasswordChar = False
        Me.BCF_MenúP_GU11.PLCAddressVisible = ""
        Me.BCF_MenúP_GU11.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU11.TabIndex = 675
        Me.BCF_MenúP_GU11.Text = "Menú Principal"
        Me.BCF_MenúP_GU11.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU11
        '
        Me.BP_FinCicloGU11.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU11.ComComponent = Me.Guardiola11
        Me.BP_FinCicloGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU11.Highlight = False
        Me.BP_FinCicloGU11.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU11.Location = New System.Drawing.Point(711, 221)
        Me.BP_FinCicloGU11.MaximumHoldTime = 3000
        Me.BP_FinCicloGU11.MinimumHoldTime = 500
        Me.BP_FinCicloGU11.Name = "BP_FinCicloGU11"
        Me.BP_FinCicloGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU11.PLCAddressClick = "BP_FIN_CICLO_GA4"
        Me.BP_FinCicloGU11.SelectTextAlternate = False
        Me.BP_FinCicloGU11.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU11.TabIndex = 674
        Me.BP_FinCicloGU11.Text = "Detener Ciclo"
        Me.BP_FinCicloGU11.TextAlternate = Nothing
        Me.BP_FinCicloGU11.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU11.ValueToWrite = 0
        '
        'BP_IniCicloGU11
        '
        Me.BP_IniCicloGU11.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU11.ComComponent = Me.Guardiola11
        Me.BP_IniCicloGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU11.Highlight = False
        Me.BP_IniCicloGU11.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU11.Location = New System.Drawing.Point(509, 221)
        Me.BP_IniCicloGU11.MaximumHoldTime = 3000
        Me.BP_IniCicloGU11.MinimumHoldTime = 500
        Me.BP_IniCicloGU11.Name = "BP_IniCicloGU11"
        Me.BP_IniCicloGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU11.PLCAddressClick = "BP_ARRANQUE_G4"
        Me.BP_IniCicloGU11.SelectTextAlternate = False
        Me.BP_IniCicloGU11.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU11.TabIndex = 673
        Me.BP_IniCicloGU11.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU11.TextAlternate = Nothing
        Me.BP_IniCicloGU11.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU11.ValueToWrite = 0
        '
        'BCF_RegresarGU11
        '
        Me.BCF_RegresarGU11.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU11.ComComponent = Nothing
        Me.BCF_RegresarGU11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU11.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU11.FormToOpen = Nothing
        Me.BCF_RegresarGU11.KeypadWidth = 300
        Me.BCF_RegresarGU11.Location = New System.Drawing.Point(646, 100)
        Me.BCF_RegresarGU11.Name = "BCF_RegresarGU11"
        Me.BCF_RegresarGU11.Passcode = Nothing
        Me.BCF_RegresarGU11.PasswordChar = False
        Me.BCF_RegresarGU11.PLCAddressVisible = ""
        Me.BCF_RegresarGU11.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU11.TabIndex = 672
        Me.BCF_RegresarGU11.Text = "Regresar"
        Me.BCF_RegresarGU11.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU11
        '
        Me.BP_DescargaGU11.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU11.ComComponent = Me.Guardiola11
        Me.BP_DescargaGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU11.Highlight = False
        Me.BP_DescargaGU11.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU11.Location = New System.Drawing.Point(961, 123)
        Me.BP_DescargaGU11.MaximumHoldTime = 3000
        Me.BP_DescargaGU11.MinimumHoldTime = 500
        Me.BP_DescargaGU11.Name = "BP_DescargaGU11"
        Me.BP_DescargaGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU11.PLCAddressClick = "BP_DESCARGAR_GA4"
        Me.BP_DescargaGU11.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA4"
        Me.BP_DescargaGU11.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA4"
        Me.BP_DescargaGU11.SelectTextAlternate = False
        Me.BP_DescargaGU11.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU11.TabIndex = 671
        Me.BP_DescargaGU11.Text = "Finalizar"
        Me.BP_DescargaGU11.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU11.UseVisualStyleBackColor = True
        Me.BP_DescargaGU11.ValueToWrite = 0
        '
        'BP_CofirDescagaGU11
        '
        Me.BP_CofirDescagaGU11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU11.ComComponent = Me.Guardiola11
        Me.BP_CofirDescagaGU11.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU11.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU11.Highlight = False
        Me.BP_CofirDescagaGU11.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU11.Location = New System.Drawing.Point(961, 64)
        Me.BP_CofirDescagaGU11.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU11.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU11.Name = "BP_CofirDescagaGU11"
        Me.BP_CofirDescagaGU11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU11.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA4"
        Me.BP_CofirDescagaGU11.PLCAddressVisible = "CONFIMAR_DESCARGA_GA4"
        Me.BP_CofirDescagaGU11.SelectTextAlternate = False
        Me.BP_CofirDescagaGU11.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU11.TabIndex = 670
        Me.BP_CofirDescagaGU11.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU11.TextAlternate = Nothing
        Me.BP_CofirDescagaGU11.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU11.ValueToWrite = 0
        '
        'BN_SalidaGU11
        '
        Me.BN_SalidaGU11.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU11.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU11.ComComponent = Me.Guardiola11
        Me.BN_SalidaGU11.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU11.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU11.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU11.Location = New System.Drawing.Point(358, 156)
        Me.BN_SalidaGU11.Maximum = 100.0R
        Me.BN_SalidaGU11.Minimum = 0R
        Me.BN_SalidaGU11.Name = "BN_SalidaGU11"
        Me.BN_SalidaGU11.NumericFormat = Nothing
        Me.BN_SalidaGU11.PLCAddressValue = "PID_GUARDIOLA4.OUT"
        Me.BN_SalidaGU11.ShowValue = True
        Me.BN_SalidaGU11.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU11.TabIndex = 669
        Me.BN_SalidaGU11.Text = "BarLevel3"
        Me.BN_SalidaGU11.TextSuffix = Nothing
        Me.BN_SalidaGU11.Value = 0R
        Me.BN_SalidaGU11.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU11
        '
        Me.BN_SP_TempGU11.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU11.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU11.ComComponent = Me.Guardiola11
        Me.BN_SP_TempGU11.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU11.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU11.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU11.Location = New System.Drawing.Point(216, 157)
        Me.BN_SP_TempGU11.Maximum = 100.0R
        Me.BN_SP_TempGU11.Minimum = 0R
        Me.BN_SP_TempGU11.Name = "BN_SP_TempGU11"
        Me.BN_SP_TempGU11.NumericFormat = Nothing
        Me.BN_SP_TempGU11.PLCAddressValue = "PID_GUARDIOLA4.SP"
        Me.BN_SP_TempGU11.ShowValue = True
        Me.BN_SP_TempGU11.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU11.TabIndex = 668
        Me.BN_SP_TempGU11.Text = "BarLevel1"
        Me.BN_SP_TempGU11.TextSuffix = Nothing
        Me.BN_SP_TempGU11.Value = 0R
        Me.BN_SP_TempGU11.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU11
        '
        Me.MD_OrdenTrabajoGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU11.ComComponent = Me.Guardiola11
        Me.MD_OrdenTrabajoGU11.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU11.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU11.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU11.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU11.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU11.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU11.Location = New System.Drawing.Point(989, 507)
        Me.MD_OrdenTrabajoGU11.Name = "MD_OrdenTrabajoGU11"
        Me.MD_OrdenTrabajoGU11.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU11.PLCAddressKeypad = "ORDEN_DE_CARGA_GA04"
        Me.MD_OrdenTrabajoGU11.PLCAddressValue = "ORDEN_DE_CARGA_GA04"
        Me.MD_OrdenTrabajoGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU11.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU11.TabIndex = 667
        Me.MD_OrdenTrabajoGU11.Value = 0R
        Me.MD_OrdenTrabajoGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU11
        '
        Me.MD_CosechaGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU11.ComComponent = Me.Guardiola11
        Me.MD_CosechaGU11.DecimalPosition = 0
        Me.MD_CosechaGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU11.KeypadMaxValue = 0R
        Me.MD_CosechaGU11.KeypadMinValue = 0R
        Me.MD_CosechaGU11.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU11.KeypadText = Nothing
        Me.MD_CosechaGU11.KeypadWidth = 300
        Me.MD_CosechaGU11.Location = New System.Drawing.Point(989, 410)
        Me.MD_CosechaGU11.Name = "MD_CosechaGU11"
        Me.MD_CosechaGU11.NumberOfDigits = 5
        Me.MD_CosechaGU11.PLCAddressKeypad = "GA04_LOTE_NUMERO"
        Me.MD_CosechaGU11.PLCAddressValue = "GA04_LOTE_NUMERO"
        Me.MD_CosechaGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU11.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU11.TabIndex = 666
        Me.MD_CosechaGU11.Value = 0R
        Me.MD_CosechaGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU11
        '
        Me.MD_HorasEstimadasGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU11.ComComponent = Me.Guardiola11
        Me.MD_HorasEstimadasGU11.DecimalPosition = 0
        Me.MD_HorasEstimadasGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU11.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU11.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU11.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU11.KeypadText = Nothing
        Me.MD_HorasEstimadasGU11.KeypadWidth = 300
        Me.MD_HorasEstimadasGU11.Location = New System.Drawing.Point(989, 317)
        Me.MD_HorasEstimadasGU11.Name = "MD_HorasEstimadasGU11"
        Me.MD_HorasEstimadasGU11.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU11.PLCAddressKeypad = "TIEMPO_SECADO_H_GA4"
        Me.MD_HorasEstimadasGU11.PLCAddressValue = "TIEMPO_SECADO_H_GA4"
        Me.MD_HorasEstimadasGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU11.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU11.TabIndex = 665
        Me.MD_HorasEstimadasGU11.Value = 0R
        Me.MD_HorasEstimadasGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU11
        '
        Me.MD_CicloGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU11.ComComponent = Me.Guardiola11
        Me.MD_CicloGU11.DecimalPosition = 0
        Me.MD_CicloGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU11.KeypadMaxValue = 0R
        Me.MD_CicloGU11.KeypadMinValue = 0R
        Me.MD_CicloGU11.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU11.KeypadText = Nothing
        Me.MD_CicloGU11.KeypadWidth = 300
        Me.MD_CicloGU11.Location = New System.Drawing.Point(989, 225)
        Me.MD_CicloGU11.Name = "MD_CicloGU11"
        Me.MD_CicloGU11.NumberOfDigits = 5
        Me.MD_CicloGU11.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA04"
        Me.MD_CicloGU11.PLCAddressValue = "NUMERO_CICLO_SECADO_GA04"
        Me.MD_CicloGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU11.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU11.TabIndex = 664
        Me.MD_CicloGU11.Value = 0R
        Me.MD_CicloGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU11
        '
        Me.TexCicloGU11.AutoSize = True
        Me.TexCicloGU11.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU11.ComComponent = Me.Guardiola11
        Me.TexCicloGU11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU11.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU11.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU11.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU11.HighlightKeyCharacter = "!"
        Me.TexCicloGU11.HighlightKeyCharacter2 = "."
        Me.TexCicloGU11.IniFileName = Nothing
        Me.TexCicloGU11.Location = New System.Drawing.Point(578, 521)
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Messages.Add(CType(resources.GetObject("TexCicloGU11.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU11.Name = "TexCicloGU11"
        Me.TexCicloGU11.PLCAddressValue = "NUMERO_CICLO_SECADO_GA04"
        Me.TexCicloGU11.PLCAddressVisible = ""
        Me.TexCicloGU11.ShowMessageNumber = False
        Me.TexCicloGU11.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU11.SpeakMessage = False
        Me.TexCicloGU11.TabIndex = 677
        Me.TexCicloGU11.Text = "No Seleccionado"
        Me.TexCicloGU11.TextPrefix = Nothing
        Me.TexCicloGU11.Value = 0
        '
        'MD_TempGU11
        '
        Me.MD_TempGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU11.ComComponent = Me.Guardiola11
        Me.MD_TempGU11.DecimalPosition = 1
        Me.MD_TempGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU11.KeypadMaxValue = 0R
        Me.MD_TempGU11.KeypadMinValue = 0R
        Me.MD_TempGU11.KeypadScaleFactor = 1.0R
        Me.MD_TempGU11.KeypadText = Nothing
        Me.MD_TempGU11.KeypadWidth = 300
        Me.MD_TempGU11.Location = New System.Drawing.Point(605, 336)
        Me.MD_TempGU11.Name = "MD_TempGU11"
        Me.MD_TempGU11.NumberOfDigits = 5
        Me.MD_TempGU11.PLCAddressKeypad = ""
        Me.MD_TempGU11.PLCAddressValue = "PID_GUARDIOLA4.PV"
        Me.MD_TempGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU11.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU11.TabIndex = 663
        Me.MD_TempGU11.Value = 0R
        Me.MD_TempGU11.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU11
        '
        Me.MD_HorasProcesoGU11.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU11.ComComponent = Me.Guardiola11
        Me.MD_HorasProcesoGU11.DecimalPosition = 0
        Me.MD_HorasProcesoGU11.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU11.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU11.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU11.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU11.KeypadText = Nothing
        Me.MD_HorasProcesoGU11.KeypadWidth = 300
        Me.MD_HorasProcesoGU11.Location = New System.Drawing.Point(466, 83)
        Me.MD_HorasProcesoGU11.Name = "MD_HorasProcesoGU11"
        Me.MD_HorasProcesoGU11.NumberOfDigits = 5
        Me.MD_HorasProcesoGU11.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU11.PLCAddressValue = "SECADO_G4_MONITOR"
        Me.MD_HorasProcesoGU11.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU11.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU11.TabIndex = 662
        Me.MD_HorasProcesoGU11.Value = 0R
        Me.MD_HorasProcesoGU11.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU11.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU11
        '
        Me.Tex_CicloGU11.AutoSize = True
        Me.Tex_CicloGU11.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU11.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU11.Location = New System.Drawing.Point(976, 203)
        Me.Tex_CicloGU11.Name = "Tex_CicloGU11"
        Me.Tex_CicloGU11.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU11.TabIndex = 661
        Me.Tex_CicloGU11.Text = "Numero de Ciclo"
        Me.Tex_CicloGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU11
        '
        Me.Tex_OrdenTrabajoGU11.AutoSize = True
        Me.Tex_OrdenTrabajoGU11.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU11.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU11.Location = New System.Drawing.Point(1029, 482)
        Me.Tex_OrdenTrabajoGU11.Name = "Tex_OrdenTrabajoGU11"
        Me.Tex_OrdenTrabajoGU11.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU11.TabIndex = 660
        Me.Tex_OrdenTrabajoGU11.Text = "OT"
        Me.Tex_OrdenTrabajoGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU11
        '
        Me.Tex_CosechaGU11.AutoSize = True
        Me.Tex_CosechaGU11.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU11.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU11.Location = New System.Drawing.Point(997, 385)
        Me.Tex_CosechaGU11.Name = "Tex_CosechaGU11"
        Me.Tex_CosechaGU11.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU11.TabIndex = 659
        Me.Tex_CosechaGU11.Text = "Cosecha"
        Me.Tex_CosechaGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU11
        '
        Me.Tex_HorasEstimadasGU11.AutoSize = True
        Me.Tex_HorasEstimadasGU11.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU11.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU11.Location = New System.Drawing.Point(929, 295)
        Me.Tex_HorasEstimadasGU11.Name = "Tex_HorasEstimadasGU11"
        Me.Tex_HorasEstimadasGU11.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU11.TabIndex = 658
        Me.Tex_HorasEstimadasGU11.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU11
        '
        Me.Tex_HorasProcesoGU11.AutoSize = True
        Me.Tex_HorasProcesoGU11.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU11.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU11.Location = New System.Drawing.Point(450, 54)
        Me.Tex_HorasProcesoGU11.Name = "Tex_HorasProcesoGU11"
        Me.Tex_HorasProcesoGU11.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU11.TabIndex = 657
        Me.Tex_HorasProcesoGU11.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola11
        '
        Me.TexGuardiola11.AutoSize = True
        Me.TexGuardiola11.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola11.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola11.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola11.Location = New System.Drawing.Point(679, 55)
        Me.TexGuardiola11.Name = "TexGuardiola11"
        Me.TexGuardiola11.Size = New System.Drawing.Size(189, 34)
        Me.TexGuardiola11.TabIndex = 656
        Me.TexGuardiola11.Text = "Guardiola 11"
        '
        'TexTempGU11
        '
        Me.TexTempGU11.AutoSize = True
        Me.TexTempGU11.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU11.Location = New System.Drawing.Point(602, 315)
        Me.TexTempGU11.Name = "TexTempGU11"
        Me.TexTempGU11.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU11.TabIndex = 655
        Me.TexTempGU11.Text = "Temperatura °C"
        Me.TexTempGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU11
        '
        Me.TexPID_GU11.AutoSize = True
        Me.TexPID_GU11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU11.Location = New System.Drawing.Point(203, 74)
        Me.TexPID_GU11.Name = "TexPID_GU11"
        Me.TexPID_GU11.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU11.TabIndex = 654
        Me.TexPID_GU11.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU11
        '
        Me.TexBN_SalidaGU11.AutoSize = True
        Me.TexBN_SalidaGU11.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU11.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU11.Location = New System.Drawing.Point(351, 135)
        Me.TexBN_SalidaGU11.Name = "TexBN_SalidaGU11"
        Me.TexBN_SalidaGU11.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU11.TabIndex = 653
        Me.TexBN_SalidaGU11.Text = "Salida"
        Me.TexBN_SalidaGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU11
        '
        Me.TexBN_RealTempGU11.AutoSize = True
        Me.TexBN_RealTempGU11.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU11.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU11.Location = New System.Drawing.Point(286, 136)
        Me.TexBN_RealTempGU11.Name = "TexBN_RealTempGU11"
        Me.TexBN_RealTempGU11.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU11.TabIndex = 652
        Me.TexBN_RealTempGU11.Text = "Real"
        Me.TexBN_RealTempGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU11
        '
        Me.TexBN_SP_TempGU11.AutoSize = True
        Me.TexBN_SP_TempGU11.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU11.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU11.Location = New System.Drawing.Point(202, 136)
        Me.TexBN_SP_TempGU11.Name = "TexBN_SP_TempGU11"
        Me.TexBN_SP_TempGU11.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU11.TabIndex = 651
        Me.TexBN_SP_TempGU11.Text = "SetPoint"
        Me.TexBN_SP_TempGU11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU11
        '
        Me.IGU11.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU11.Location = New System.Drawing.Point(441, 309)
        Me.IGU11.Name = "IGU11"
        Me.IGU11.Size = New System.Drawing.Size(541, 274)
        Me.IGU11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU11.TabIndex = 678
        Me.IGU11.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola11
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 51)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 680
        '
        'Guardiola_11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU11)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU11)
        Me.Controls.Add(Me.BCF_MenúP_GU11)
        Me.Controls.Add(Me.BP_FinCicloGU11)
        Me.Controls.Add(Me.BP_IniCicloGU11)
        Me.Controls.Add(Me.BCF_RegresarGU11)
        Me.Controls.Add(Me.BP_DescargaGU11)
        Me.Controls.Add(Me.BP_CofirDescagaGU11)
        Me.Controls.Add(Me.BN_SalidaGU11)
        Me.Controls.Add(Me.BN_SP_TempGU11)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU11)
        Me.Controls.Add(Me.MD_CosechaGU11)
        Me.Controls.Add(Me.MD_HorasEstimadasGU11)
        Me.Controls.Add(Me.MD_CicloGU11)
        Me.Controls.Add(Me.TexCicloGU11)
        Me.Controls.Add(Me.MD_TempGU11)
        Me.Controls.Add(Me.MD_HorasProcesoGU11)
        Me.Controls.Add(Me.Tex_CicloGU11)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU11)
        Me.Controls.Add(Me.Tex_CosechaGU11)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU11)
        Me.Controls.Add(Me.Tex_HorasProcesoGU11)
        Me.Controls.Add(Me.TexGuardiola11)
        Me.Controls.Add(Me.TexTempGU11)
        Me.Controls.Add(Me.TexPID_GU11)
        Me.Controls.Add(Me.TexBN_SalidaGU11)
        Me.Controls.Add(Me.TexBN_RealTempGU11)
        Me.Controls.Add(Me.TexBN_SP_TempGU11)
        Me.Controls.Add(Me.IGU11)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU11 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola11 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU11 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU11 As FormChangeButton
    Friend WithEvents BP_FinCicloGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU11 As FormChangeButton
    Friend WithEvents BP_DescargaGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU11 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU11 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU11 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU11 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU11 As Label
    Friend WithEvents Tex_OrdenTrabajoGU11 As Label
    Friend WithEvents Tex_CosechaGU11 As Label
    Friend WithEvents Tex_HorasEstimadasGU11 As Label
    Friend WithEvents Tex_HorasProcesoGU11 As Label
    Friend WithEvents TexGuardiola11 As Label
    Friend WithEvents TexTempGU11 As Label
    Friend WithEvents TexPID_GU11 As Label
    Friend WithEvents TexBN_SalidaGU11 As Label
    Friend WithEvents TexBN_RealTempGU11 As Label
    Friend WithEvents TexBN_SP_TempGU11 As Label
    Friend WithEvents IGU11 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
