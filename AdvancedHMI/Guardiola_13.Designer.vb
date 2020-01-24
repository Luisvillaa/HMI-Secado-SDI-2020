<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_13))
        Me.CT_SGU13 = New AdvancedHMIControls.TempController()
        Me.Guardiola13 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU13 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU13 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU13 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU13 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU13 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU13 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU13 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU13 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU13 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU13 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU13 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU13 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU13 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU13 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU13 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU13 = New System.Windows.Forms.Label()
        Me.TexGuardiola13 = New System.Windows.Forms.Label()
        Me.TexTempGU13 = New System.Windows.Forms.Label()
        Me.TexPID_GU13 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU13 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU13 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU13 = New System.Windows.Forms.Label()
        Me.IGU13 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU13
        '
        Me.CT_SGU13.Button1Text = Nothing
        Me.CT_SGU13.Button2Text = Nothing
        Me.CT_SGU13.ComComponent = Me.Guardiola13
        Me.CT_SGU13.DecimalPosition = 1
        Me.CT_SGU13.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU13.Location = New System.Drawing.Point(204, 433)
        Me.CT_SGU13.Name = "CT_SGU13"
        Me.CT_SGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU13.PLCAddressClick1 = ""
        Me.CT_SGU13.PLCAddressClick2 = ""
        Me.CT_SGU13.PLCAddressClick3 = ""
        Me.CT_SGU13.PLCAddressClick4 = ""
        Me.CT_SGU13.PLCAddressText = ""
        Me.CT_SGU13.PLCAddressValuePV = "PID_GUARDIOLA6.PV"
        Me.CT_SGU13.PLCAddressValueSP = "PID_GUARDIOLA6.SP"
        Me.CT_SGU13.PLCAddressVisible = ""
        Me.CT_SGU13.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU13.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU13.TabIndex = 685
        Me.CT_SGU13.Text = "S-GU-13"
        Me.CT_SGU13.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU13.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU13.Value2Text = "SP"
        Me.CT_SGU13.ValuePV = 0!
        Me.CT_SGU13.ValueSP = 0!
        '
        'Guardiola13
        '
        Me.Guardiola13.CIPConnectionSize = 508
        Me.Guardiola13.DisableMultiServiceRequest = False
        Me.Guardiola13.DisableSubscriptions = False
        Me.Guardiola13.IniFileName = ""
        Me.Guardiola13.IniFileSection = Nothing
        Me.Guardiola13.IPAddress = "10.1.108.20"
        Me.Guardiola13.PollRateOverride = 500
        Me.Guardiola13.Port = 44818
        Me.Guardiola13.ProcessorSlot = 0
        Me.Guardiola13.RoutePath = Nothing
        Me.Guardiola13.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola13
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
        Me.BasicButton1.ComComponent = Me.Guardiola13
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
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA06"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 683
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU13
        '
        Me.LS_MarchaGU13.Blink = False
        Me.LS_MarchaGU13.ComComponent = Me.Guardiola13
        Me.LS_MarchaGU13.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU13.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU13.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU13.Location = New System.Drawing.Point(859, 316)
        Me.LS_MarchaGU13.Name = "LS_MarchaGU13"
        Me.LS_MarchaGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU13.PLCAddressClick = ""
        Me.LS_MarchaGU13.PLCAddressText = ""
        Me.LS_MarchaGU13.PLCAddressValue = "MARCHA_GU13"
        Me.LS_MarchaGU13.PLCAddressVisible = ""
        Me.LS_MarchaGU13.Size = New System.Drawing.Size(48, 51)
        Me.LS_MarchaGU13.TabIndex = 680
        Me.LS_MarchaGU13.Value = False
        Me.LS_MarchaGU13.ValueToWrite = 0
        '
        'BCF_MenúP_GU13
        '
        Me.BCF_MenúP_GU13.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU13.ComComponent = Nothing
        Me.BCF_MenúP_GU13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU13.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU13.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU13.KeypadWidth = 300
        Me.BCF_MenúP_GU13.Location = New System.Drawing.Point(230, 646)
        Me.BCF_MenúP_GU13.Name = "BCF_MenúP_GU13"
        Me.BCF_MenúP_GU13.Passcode = Nothing
        Me.BCF_MenúP_GU13.PasswordChar = False
        Me.BCF_MenúP_GU13.PLCAddressVisible = ""
        Me.BCF_MenúP_GU13.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU13.TabIndex = 679
        Me.BCF_MenúP_GU13.Text = "Menú Principal"
        Me.BCF_MenúP_GU13.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU13
        '
        Me.BP_FinCicloGU13.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU13.ComComponent = Me.Guardiola13
        Me.BP_FinCicloGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU13.Highlight = False
        Me.BP_FinCicloGU13.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU13.Location = New System.Drawing.Point(711, 218)
        Me.BP_FinCicloGU13.MaximumHoldTime = 3000
        Me.BP_FinCicloGU13.MinimumHoldTime = 500
        Me.BP_FinCicloGU13.Name = "BP_FinCicloGU13"
        Me.BP_FinCicloGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU13.PLCAddressClick = "BP_FIN_CICLO_GA6"
        Me.BP_FinCicloGU13.SelectTextAlternate = False
        Me.BP_FinCicloGU13.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU13.TabIndex = 678
        Me.BP_FinCicloGU13.Text = "Detener Ciclo"
        Me.BP_FinCicloGU13.TextAlternate = Nothing
        Me.BP_FinCicloGU13.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU13.ValueToWrite = 0
        '
        'BP_IniCicloGU13
        '
        Me.BP_IniCicloGU13.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU13.ComComponent = Me.Guardiola13
        Me.BP_IniCicloGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU13.Highlight = False
        Me.BP_IniCicloGU13.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU13.Location = New System.Drawing.Point(509, 218)
        Me.BP_IniCicloGU13.MaximumHoldTime = 3000
        Me.BP_IniCicloGU13.MinimumHoldTime = 500
        Me.BP_IniCicloGU13.Name = "BP_IniCicloGU13"
        Me.BP_IniCicloGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU13.PLCAddressClick = "BP_ARRANQUE_G6"
        Me.BP_IniCicloGU13.SelectTextAlternate = False
        Me.BP_IniCicloGU13.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU13.TabIndex = 677
        Me.BP_IniCicloGU13.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU13.TextAlternate = Nothing
        Me.BP_IniCicloGU13.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU13.ValueToWrite = 0
        '
        'BCF_RegresarGU13
        '
        Me.BCF_RegresarGU13.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU13.ComComponent = Nothing
        Me.BCF_RegresarGU13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU13.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU13.FormToOpen = Nothing
        Me.BCF_RegresarGU13.KeypadWidth = 300
        Me.BCF_RegresarGU13.Location = New System.Drawing.Point(646, 99)
        Me.BCF_RegresarGU13.Name = "BCF_RegresarGU13"
        Me.BCF_RegresarGU13.Passcode = Nothing
        Me.BCF_RegresarGU13.PasswordChar = False
        Me.BCF_RegresarGU13.PLCAddressVisible = ""
        Me.BCF_RegresarGU13.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU13.TabIndex = 676
        Me.BCF_RegresarGU13.Text = "Regresar"
        Me.BCF_RegresarGU13.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU13
        '
        Me.BP_DescargaGU13.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU13.ComComponent = Me.Guardiola13
        Me.BP_DescargaGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU13.Highlight = False
        Me.BP_DescargaGU13.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU13.Location = New System.Drawing.Point(961, 122)
        Me.BP_DescargaGU13.MaximumHoldTime = 3000
        Me.BP_DescargaGU13.MinimumHoldTime = 500
        Me.BP_DescargaGU13.Name = "BP_DescargaGU13"
        Me.BP_DescargaGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU13.PLCAddressClick = "BP_DESCARGAR_GA6"
        Me.BP_DescargaGU13.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA6"
        Me.BP_DescargaGU13.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA6"
        Me.BP_DescargaGU13.SelectTextAlternate = False
        Me.BP_DescargaGU13.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU13.TabIndex = 675
        Me.BP_DescargaGU13.Text = "Finalizar"
        Me.BP_DescargaGU13.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU13.UseVisualStyleBackColor = True
        Me.BP_DescargaGU13.ValueToWrite = 0
        '
        'BP_CofirDescagaGU13
        '
        Me.BP_CofirDescagaGU13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU13.ComComponent = Me.Guardiola13
        Me.BP_CofirDescagaGU13.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU13.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU13.Highlight = False
        Me.BP_CofirDescagaGU13.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU13.Location = New System.Drawing.Point(961, 63)
        Me.BP_CofirDescagaGU13.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU13.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU13.Name = "BP_CofirDescagaGU13"
        Me.BP_CofirDescagaGU13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU13.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA6"
        Me.BP_CofirDescagaGU13.PLCAddressVisible = "CONFIMAR_DESCARGA_GA6"
        Me.BP_CofirDescagaGU13.SelectTextAlternate = False
        Me.BP_CofirDescagaGU13.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU13.TabIndex = 674
        Me.BP_CofirDescagaGU13.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU13.TextAlternate = Nothing
        Me.BP_CofirDescagaGU13.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU13.ValueToWrite = 0
        '
        'BN_SalidaGU13
        '
        Me.BN_SalidaGU13.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU13.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU13.ComComponent = Me.Guardiola13
        Me.BN_SalidaGU13.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU13.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU13.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU13.Location = New System.Drawing.Point(358, 155)
        Me.BN_SalidaGU13.Maximum = 100.0R
        Me.BN_SalidaGU13.Minimum = 0R
        Me.BN_SalidaGU13.Name = "BN_SalidaGU13"
        Me.BN_SalidaGU13.NumericFormat = Nothing
        Me.BN_SalidaGU13.PLCAddressValue = "PID_GUARDIOLA6.OUT"
        Me.BN_SalidaGU13.ShowValue = True
        Me.BN_SalidaGU13.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU13.TabIndex = 673
        Me.BN_SalidaGU13.Text = "BarLevel3"
        Me.BN_SalidaGU13.TextSuffix = Nothing
        Me.BN_SalidaGU13.Value = 0R
        Me.BN_SalidaGU13.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU13
        '
        Me.BN_SP_TempGU13.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU13.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU13.ComComponent = Me.Guardiola13
        Me.BN_SP_TempGU13.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU13.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU13.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU13.Location = New System.Drawing.Point(216, 156)
        Me.BN_SP_TempGU13.Maximum = 100.0R
        Me.BN_SP_TempGU13.Minimum = 0R
        Me.BN_SP_TempGU13.Name = "BN_SP_TempGU13"
        Me.BN_SP_TempGU13.NumericFormat = Nothing
        Me.BN_SP_TempGU13.PLCAddressValue = "PID_GUARDIOLA6.SP"
        Me.BN_SP_TempGU13.ShowValue = True
        Me.BN_SP_TempGU13.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU13.TabIndex = 672
        Me.BN_SP_TempGU13.Text = "BarLevel1"
        Me.BN_SP_TempGU13.TextSuffix = Nothing
        Me.BN_SP_TempGU13.Value = 0R
        Me.BN_SP_TempGU13.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU13
        '
        Me.MD_OrdenTrabajoGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU13.ComComponent = Me.Guardiola13
        Me.MD_OrdenTrabajoGU13.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU13.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU13.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU13.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU13.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU13.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU13.Location = New System.Drawing.Point(989, 506)
        Me.MD_OrdenTrabajoGU13.Name = "MD_OrdenTrabajoGU13"
        Me.MD_OrdenTrabajoGU13.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU13.PLCAddressKeypad = "ORDEN_DE_CARGA_GA06"
        Me.MD_OrdenTrabajoGU13.PLCAddressValue = "ORDEN_DE_CARGA_GA06"
        Me.MD_OrdenTrabajoGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU13.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU13.TabIndex = 671
        Me.MD_OrdenTrabajoGU13.Value = 0R
        Me.MD_OrdenTrabajoGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU13
        '
        Me.MD_CosechaGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU13.ComComponent = Me.Guardiola13
        Me.MD_CosechaGU13.DecimalPosition = 0
        Me.MD_CosechaGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU13.KeypadMaxValue = 0R
        Me.MD_CosechaGU13.KeypadMinValue = 0R
        Me.MD_CosechaGU13.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU13.KeypadText = Nothing
        Me.MD_CosechaGU13.KeypadWidth = 300
        Me.MD_CosechaGU13.Location = New System.Drawing.Point(989, 409)
        Me.MD_CosechaGU13.Name = "MD_CosechaGU13"
        Me.MD_CosechaGU13.NumberOfDigits = 5
        Me.MD_CosechaGU13.PLCAddressKeypad = "GA06_LOTE_NUMERO"
        Me.MD_CosechaGU13.PLCAddressValue = "GA06_LOTE_NUMERO"
        Me.MD_CosechaGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU13.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU13.TabIndex = 670
        Me.MD_CosechaGU13.Value = 0R
        Me.MD_CosechaGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU13
        '
        Me.MD_HorasEstimadasGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU13.ComComponent = Me.Guardiola13
        Me.MD_HorasEstimadasGU13.DecimalPosition = 0
        Me.MD_HorasEstimadasGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU13.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU13.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU13.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU13.KeypadText = Nothing
        Me.MD_HorasEstimadasGU13.KeypadWidth = 300
        Me.MD_HorasEstimadasGU13.Location = New System.Drawing.Point(989, 316)
        Me.MD_HorasEstimadasGU13.Name = "MD_HorasEstimadasGU13"
        Me.MD_HorasEstimadasGU13.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU13.PLCAddressKeypad = "TIEMPO_SECADO_H_GA6"
        Me.MD_HorasEstimadasGU13.PLCAddressValue = "TIEMPO_SECADO_H_GA6"
        Me.MD_HorasEstimadasGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU13.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU13.TabIndex = 669
        Me.MD_HorasEstimadasGU13.Value = 0R
        Me.MD_HorasEstimadasGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU13
        '
        Me.MD_CicloGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU13.ComComponent = Me.Guardiola13
        Me.MD_CicloGU13.DecimalPosition = 0
        Me.MD_CicloGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU13.KeypadMaxValue = 0R
        Me.MD_CicloGU13.KeypadMinValue = 0R
        Me.MD_CicloGU13.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU13.KeypadText = Nothing
        Me.MD_CicloGU13.KeypadWidth = 300
        Me.MD_CicloGU13.Location = New System.Drawing.Point(989, 224)
        Me.MD_CicloGU13.Name = "MD_CicloGU13"
        Me.MD_CicloGU13.NumberOfDigits = 5
        Me.MD_CicloGU13.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA06"
        Me.MD_CicloGU13.PLCAddressValue = "NUMERO_CICLO_SECADO_GA06"
        Me.MD_CicloGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU13.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU13.TabIndex = 668
        Me.MD_CicloGU13.Value = 0R
        Me.MD_CicloGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU13
        '
        Me.TexCicloGU13.AutoSize = True
        Me.TexCicloGU13.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU13.ComComponent = Me.Guardiola13
        Me.TexCicloGU13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU13.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU13.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU13.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU13.HighlightKeyCharacter = "!"
        Me.TexCicloGU13.HighlightKeyCharacter2 = "."
        Me.TexCicloGU13.IniFileName = Nothing
        Me.TexCicloGU13.Location = New System.Drawing.Point(575, 520)
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Messages.Add(CType(resources.GetObject("TexCicloGU13.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU13.Name = "TexCicloGU13"
        Me.TexCicloGU13.PLCAddressValue = "NUMERO_CICLO_SECADO_GA06"
        Me.TexCicloGU13.PLCAddressVisible = ""
        Me.TexCicloGU13.ShowMessageNumber = False
        Me.TexCicloGU13.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU13.SpeakMessage = False
        Me.TexCicloGU13.TabIndex = 681
        Me.TexCicloGU13.Text = "No Seleccionado"
        Me.TexCicloGU13.TextPrefix = Nothing
        Me.TexCicloGU13.Value = 0
        '
        'MD_TempGU13
        '
        Me.MD_TempGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU13.ComComponent = Me.Guardiola13
        Me.MD_TempGU13.DecimalPosition = 1
        Me.MD_TempGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU13.KeypadMaxValue = 0R
        Me.MD_TempGU13.KeypadMinValue = 0R
        Me.MD_TempGU13.KeypadScaleFactor = 1.0R
        Me.MD_TempGU13.KeypadText = Nothing
        Me.MD_TempGU13.KeypadWidth = 300
        Me.MD_TempGU13.Location = New System.Drawing.Point(605, 336)
        Me.MD_TempGU13.Name = "MD_TempGU13"
        Me.MD_TempGU13.NumberOfDigits = 5
        Me.MD_TempGU13.PLCAddressKeypad = ""
        Me.MD_TempGU13.PLCAddressValue = "PID_GUARDIOLA6.PV"
        Me.MD_TempGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU13.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU13.TabIndex = 667
        Me.MD_TempGU13.Value = 0R
        Me.MD_TempGU13.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU13
        '
        Me.MD_HorasProcesoGU13.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU13.ComComponent = Me.Guardiola13
        Me.MD_HorasProcesoGU13.DecimalPosition = 0
        Me.MD_HorasProcesoGU13.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU13.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU13.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU13.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU13.KeypadText = Nothing
        Me.MD_HorasProcesoGU13.KeypadWidth = 300
        Me.MD_HorasProcesoGU13.Location = New System.Drawing.Point(466, 82)
        Me.MD_HorasProcesoGU13.Name = "MD_HorasProcesoGU13"
        Me.MD_HorasProcesoGU13.NumberOfDigits = 5
        Me.MD_HorasProcesoGU13.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU13.PLCAddressValue = "SECADO_G6_MONITOR"
        Me.MD_HorasProcesoGU13.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU13.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU13.TabIndex = 666
        Me.MD_HorasProcesoGU13.Value = 0R
        Me.MD_HorasProcesoGU13.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU13.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU13
        '
        Me.Tex_CicloGU13.AutoSize = True
        Me.Tex_CicloGU13.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU13.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU13.Location = New System.Drawing.Point(976, 202)
        Me.Tex_CicloGU13.Name = "Tex_CicloGU13"
        Me.Tex_CicloGU13.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU13.TabIndex = 665
        Me.Tex_CicloGU13.Text = "Numero de Ciclo"
        Me.Tex_CicloGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU13
        '
        Me.Tex_OrdenTrabajoGU13.AutoSize = True
        Me.Tex_OrdenTrabajoGU13.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU13.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU13.Location = New System.Drawing.Point(1029, 481)
        Me.Tex_OrdenTrabajoGU13.Name = "Tex_OrdenTrabajoGU13"
        Me.Tex_OrdenTrabajoGU13.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU13.TabIndex = 664
        Me.Tex_OrdenTrabajoGU13.Text = "OT"
        Me.Tex_OrdenTrabajoGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU13
        '
        Me.Tex_CosechaGU13.AutoSize = True
        Me.Tex_CosechaGU13.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU13.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU13.Location = New System.Drawing.Point(997, 384)
        Me.Tex_CosechaGU13.Name = "Tex_CosechaGU13"
        Me.Tex_CosechaGU13.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU13.TabIndex = 663
        Me.Tex_CosechaGU13.Text = "Cosecha"
        Me.Tex_CosechaGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU13
        '
        Me.Tex_HorasEstimadasGU13.AutoSize = True
        Me.Tex_HorasEstimadasGU13.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU13.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU13.Location = New System.Drawing.Point(929, 294)
        Me.Tex_HorasEstimadasGU13.Name = "Tex_HorasEstimadasGU13"
        Me.Tex_HorasEstimadasGU13.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU13.TabIndex = 662
        Me.Tex_HorasEstimadasGU13.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU13
        '
        Me.Tex_HorasProcesoGU13.AutoSize = True
        Me.Tex_HorasProcesoGU13.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU13.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU13.Location = New System.Drawing.Point(450, 53)
        Me.Tex_HorasProcesoGU13.Name = "Tex_HorasProcesoGU13"
        Me.Tex_HorasProcesoGU13.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU13.TabIndex = 661
        Me.Tex_HorasProcesoGU13.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola13
        '
        Me.TexGuardiola13.AutoSize = True
        Me.TexGuardiola13.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola13.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola13.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola13.Location = New System.Drawing.Point(679, 54)
        Me.TexGuardiola13.Name = "TexGuardiola13"
        Me.TexGuardiola13.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola13.TabIndex = 660
        Me.TexGuardiola13.Text = "Guardiola 13"
        '
        'TexTempGU13
        '
        Me.TexTempGU13.AutoSize = True
        Me.TexTempGU13.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU13.Location = New System.Drawing.Point(602, 315)
        Me.TexTempGU13.Name = "TexTempGU13"
        Me.TexTempGU13.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU13.TabIndex = 659
        Me.TexTempGU13.Text = "Temperatura °C"
        Me.TexTempGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU13
        '
        Me.TexPID_GU13.AutoSize = True
        Me.TexPID_GU13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU13.Location = New System.Drawing.Point(205, 73)
        Me.TexPID_GU13.Name = "TexPID_GU13"
        Me.TexPID_GU13.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU13.TabIndex = 658
        Me.TexPID_GU13.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU13
        '
        Me.TexBN_SalidaGU13.AutoSize = True
        Me.TexBN_SalidaGU13.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU13.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU13.Location = New System.Drawing.Point(351, 134)
        Me.TexBN_SalidaGU13.Name = "TexBN_SalidaGU13"
        Me.TexBN_SalidaGU13.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU13.TabIndex = 657
        Me.TexBN_SalidaGU13.Text = "Salida"
        Me.TexBN_SalidaGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU13
        '
        Me.TexBN_RealTempGU13.AutoSize = True
        Me.TexBN_RealTempGU13.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU13.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU13.Location = New System.Drawing.Point(286, 135)
        Me.TexBN_RealTempGU13.Name = "TexBN_RealTempGU13"
        Me.TexBN_RealTempGU13.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU13.TabIndex = 656
        Me.TexBN_RealTempGU13.Text = "Real"
        Me.TexBN_RealTempGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU13
        '
        Me.TexBN_SP_TempGU13.AutoSize = True
        Me.TexBN_SP_TempGU13.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU13.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU13.Location = New System.Drawing.Point(202, 135)
        Me.TexBN_SP_TempGU13.Name = "TexBN_SP_TempGU13"
        Me.TexBN_SP_TempGU13.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU13.TabIndex = 655
        Me.TexBN_SP_TempGU13.Text = "SetPoint"
        Me.TexBN_SP_TempGU13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU13
        '
        Me.IGU13.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU13.Location = New System.Drawing.Point(441, 309)
        Me.IGU13.Name = "IGU13"
        Me.IGU13.Size = New System.Drawing.Size(541, 274)
        Me.IGU13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU13.TabIndex = 682
        Me.IGU13.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola13
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 53)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 684
        '
        'Guardiola_13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU13)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU13)
        Me.Controls.Add(Me.BCF_MenúP_GU13)
        Me.Controls.Add(Me.BP_FinCicloGU13)
        Me.Controls.Add(Me.BP_IniCicloGU13)
        Me.Controls.Add(Me.BCF_RegresarGU13)
        Me.Controls.Add(Me.BP_DescargaGU13)
        Me.Controls.Add(Me.BP_CofirDescagaGU13)
        Me.Controls.Add(Me.BN_SalidaGU13)
        Me.Controls.Add(Me.BN_SP_TempGU13)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU13)
        Me.Controls.Add(Me.MD_CosechaGU13)
        Me.Controls.Add(Me.MD_HorasEstimadasGU13)
        Me.Controls.Add(Me.MD_CicloGU13)
        Me.Controls.Add(Me.TexCicloGU13)
        Me.Controls.Add(Me.MD_TempGU13)
        Me.Controls.Add(Me.MD_HorasProcesoGU13)
        Me.Controls.Add(Me.Tex_CicloGU13)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU13)
        Me.Controls.Add(Me.Tex_CosechaGU13)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU13)
        Me.Controls.Add(Me.Tex_HorasProcesoGU13)
        Me.Controls.Add(Me.TexGuardiola13)
        Me.Controls.Add(Me.TexTempGU13)
        Me.Controls.Add(Me.TexPID_GU13)
        Me.Controls.Add(Me.TexBN_SalidaGU13)
        Me.Controls.Add(Me.TexBN_RealTempGU13)
        Me.Controls.Add(Me.TexBN_SP_TempGU13)
        Me.Controls.Add(Me.IGU13)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU13 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola13 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU13 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU13 As FormChangeButton
    Friend WithEvents BP_FinCicloGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU13 As FormChangeButton
    Friend WithEvents BP_DescargaGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU13 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU13 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU13 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU13 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU13 As Label
    Friend WithEvents Tex_OrdenTrabajoGU13 As Label
    Friend WithEvents Tex_CosechaGU13 As Label
    Friend WithEvents Tex_HorasEstimadasGU13 As Label
    Friend WithEvents Tex_HorasProcesoGU13 As Label
    Friend WithEvents TexGuardiola13 As Label
    Friend WithEvents TexTempGU13 As Label
    Friend WithEvents TexPID_GU13 As Label
    Friend WithEvents TexBN_SalidaGU13 As Label
    Friend WithEvents TexBN_RealTempGU13 As Label
    Friend WithEvents TexBN_SP_TempGU13 As Label
    Friend WithEvents IGU13 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
