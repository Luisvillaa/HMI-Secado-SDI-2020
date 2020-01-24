<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_10))
        Me.CT_SGU10 = New AdvancedHMIControls.TempController()
        Me.Guardiola10 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU10 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU10 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU10 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU10 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU10 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU10 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU10 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU10 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU10 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU10 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU10 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU10 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU10 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU10 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU10 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU10 = New System.Windows.Forms.Label()
        Me.TexGuardiola10 = New System.Windows.Forms.Label()
        Me.TexTempGU10 = New System.Windows.Forms.Label()
        Me.TexPID_GU10 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU10 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU10 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU10 = New System.Windows.Forms.Label()
        Me.IGU10 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU10
        '
        Me.CT_SGU10.Button1Text = Nothing
        Me.CT_SGU10.Button2Text = Nothing
        Me.CT_SGU10.ComComponent = Me.Guardiola10
        Me.CT_SGU10.DecimalPosition = 1
        Me.CT_SGU10.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU10.Location = New System.Drawing.Point(204, 432)
        Me.CT_SGU10.Name = "CT_SGU10"
        Me.CT_SGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU10.PLCAddressClick1 = ""
        Me.CT_SGU10.PLCAddressClick2 = ""
        Me.CT_SGU10.PLCAddressClick3 = ""
        Me.CT_SGU10.PLCAddressClick4 = ""
        Me.CT_SGU10.PLCAddressText = ""
        Me.CT_SGU10.PLCAddressValuePV = "PID_GUARDIOLA3.PV"
        Me.CT_SGU10.PLCAddressValueSP = "PID_GUARDIOLA3.SP"
        Me.CT_SGU10.PLCAddressVisible = ""
        Me.CT_SGU10.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU10.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU10.TabIndex = 679
        Me.CT_SGU10.Text = "S-GU-10"
        Me.CT_SGU10.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU10.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU10.Value2Text = "SP"
        Me.CT_SGU10.ValuePV = 0!
        Me.CT_SGU10.ValueSP = 0!
        '
        'Guardiola10
        '
        Me.Guardiola10.CIPConnectionSize = 508
        Me.Guardiola10.DisableMultiServiceRequest = False
        Me.Guardiola10.DisableSubscriptions = False
        Me.Guardiola10.IniFileName = ""
        Me.Guardiola10.IniFileSection = Nothing
        Me.Guardiola10.IPAddress = "10.1.108.20"
        Me.Guardiola10.PollRateOverride = 500
        Me.Guardiola10.Port = 44818
        Me.Guardiola10.ProcessorSlot = 0
        Me.Guardiola10.RoutePath = Nothing
        Me.Guardiola10.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola10
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
        Me.BasicButton1.ComComponent = Me.Guardiola10
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(960, 590)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA03"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 677
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU10
        '
        Me.LS_MarchaGU10.Blink = False
        Me.LS_MarchaGU10.ComComponent = Me.Guardiola10
        Me.LS_MarchaGU10.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU10.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU10.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU10.Location = New System.Drawing.Point(853, 318)
        Me.LS_MarchaGU10.Name = "LS_MarchaGU10"
        Me.LS_MarchaGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU10.PLCAddressClick = ""
        Me.LS_MarchaGU10.PLCAddressText = ""
        Me.LS_MarchaGU10.PLCAddressValue = "MARCHA_GU10"
        Me.LS_MarchaGU10.PLCAddressVisible = ""
        Me.LS_MarchaGU10.Size = New System.Drawing.Size(53, 56)
        Me.LS_MarchaGU10.TabIndex = 674
        Me.LS_MarchaGU10.Value = False
        Me.LS_MarchaGU10.ValueToWrite = 0
        '
        'BCF_MenúP_GU10
        '
        Me.BCF_MenúP_GU10.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU10.ComComponent = Nothing
        Me.BCF_MenúP_GU10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU10.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU10.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU10.KeypadWidth = 300
        Me.BCF_MenúP_GU10.Location = New System.Drawing.Point(229, 646)
        Me.BCF_MenúP_GU10.Name = "BCF_MenúP_GU10"
        Me.BCF_MenúP_GU10.Passcode = Nothing
        Me.BCF_MenúP_GU10.PasswordChar = False
        Me.BCF_MenúP_GU10.PLCAddressVisible = ""
        Me.BCF_MenúP_GU10.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU10.TabIndex = 673
        Me.BCF_MenúP_GU10.Text = "Menú Principal"
        Me.BCF_MenúP_GU10.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU10
        '
        Me.BP_FinCicloGU10.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU10.ComComponent = Me.Guardiola10
        Me.BP_FinCicloGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU10.Highlight = False
        Me.BP_FinCicloGU10.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU10.Location = New System.Drawing.Point(710, 227)
        Me.BP_FinCicloGU10.MaximumHoldTime = 3000
        Me.BP_FinCicloGU10.MinimumHoldTime = 500
        Me.BP_FinCicloGU10.Name = "BP_FinCicloGU10"
        Me.BP_FinCicloGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU10.PLCAddressClick = "BP_FIN_CICLO_GA3"
        Me.BP_FinCicloGU10.SelectTextAlternate = False
        Me.BP_FinCicloGU10.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU10.TabIndex = 672
        Me.BP_FinCicloGU10.Text = "Detener Ciclo"
        Me.BP_FinCicloGU10.TextAlternate = Nothing
        Me.BP_FinCicloGU10.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU10.ValueToWrite = 0
        '
        'BP_IniCicloGU10
        '
        Me.BP_IniCicloGU10.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU10.ComComponent = Me.Guardiola10
        Me.BP_IniCicloGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU10.Highlight = False
        Me.BP_IniCicloGU10.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU10.Location = New System.Drawing.Point(508, 227)
        Me.BP_IniCicloGU10.MaximumHoldTime = 3000
        Me.BP_IniCicloGU10.MinimumHoldTime = 500
        Me.BP_IniCicloGU10.Name = "BP_IniCicloGU10"
        Me.BP_IniCicloGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU10.PLCAddressClick = "BP_ARRANQUE_G3"
        Me.BP_IniCicloGU10.SelectTextAlternate = False
        Me.BP_IniCicloGU10.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU10.TabIndex = 671
        Me.BP_IniCicloGU10.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU10.TextAlternate = Nothing
        Me.BP_IniCicloGU10.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU10.ValueToWrite = 0
        '
        'BCF_RegresarGU10
        '
        Me.BCF_RegresarGU10.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU10.ComComponent = Nothing
        Me.BCF_RegresarGU10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU10.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU10.FormToOpen = Nothing
        Me.BCF_RegresarGU10.KeypadWidth = 300
        Me.BCF_RegresarGU10.Location = New System.Drawing.Point(645, 101)
        Me.BCF_RegresarGU10.Name = "BCF_RegresarGU10"
        Me.BCF_RegresarGU10.Passcode = Nothing
        Me.BCF_RegresarGU10.PasswordChar = False
        Me.BCF_RegresarGU10.PLCAddressVisible = ""
        Me.BCF_RegresarGU10.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU10.TabIndex = 670
        Me.BCF_RegresarGU10.Text = "Regresar"
        Me.BCF_RegresarGU10.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU10
        '
        Me.BP_DescargaGU10.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU10.ComComponent = Me.Guardiola10
        Me.BP_DescargaGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU10.Highlight = False
        Me.BP_DescargaGU10.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU10.Location = New System.Drawing.Point(960, 124)
        Me.BP_DescargaGU10.MaximumHoldTime = 3000
        Me.BP_DescargaGU10.MinimumHoldTime = 500
        Me.BP_DescargaGU10.Name = "BP_DescargaGU10"
        Me.BP_DescargaGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU10.PLCAddressClick = "BP_DESCARGAR_GA3"
        Me.BP_DescargaGU10.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA3"
        Me.BP_DescargaGU10.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA3"
        Me.BP_DescargaGU10.SelectTextAlternate = False
        Me.BP_DescargaGU10.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU10.TabIndex = 669
        Me.BP_DescargaGU10.Text = "Finalizar"
        Me.BP_DescargaGU10.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU10.UseVisualStyleBackColor = True
        Me.BP_DescargaGU10.ValueToWrite = 0
        '
        'BP_CofirDescagaGU10
        '
        Me.BP_CofirDescagaGU10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU10.ComComponent = Me.Guardiola10
        Me.BP_CofirDescagaGU10.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU10.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU10.Highlight = False
        Me.BP_CofirDescagaGU10.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU10.Location = New System.Drawing.Point(960, 65)
        Me.BP_CofirDescagaGU10.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU10.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU10.Name = "BP_CofirDescagaGU10"
        Me.BP_CofirDescagaGU10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU10.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA3"
        Me.BP_CofirDescagaGU10.PLCAddressVisible = "CONFIMAR_DESCARGA_GA3"
        Me.BP_CofirDescagaGU10.SelectTextAlternate = False
        Me.BP_CofirDescagaGU10.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU10.TabIndex = 668
        Me.BP_CofirDescagaGU10.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU10.TextAlternate = Nothing
        Me.BP_CofirDescagaGU10.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU10.ValueToWrite = 0
        '
        'BN_SalidaGU10
        '
        Me.BN_SalidaGU10.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU10.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU10.ComComponent = Me.Guardiola10
        Me.BN_SalidaGU10.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU10.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU10.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU10.Location = New System.Drawing.Point(357, 157)
        Me.BN_SalidaGU10.Maximum = 100.0R
        Me.BN_SalidaGU10.Minimum = 0R
        Me.BN_SalidaGU10.Name = "BN_SalidaGU10"
        Me.BN_SalidaGU10.NumericFormat = Nothing
        Me.BN_SalidaGU10.PLCAddressValue = "PID_GUARDIOLA3.OUT"
        Me.BN_SalidaGU10.ShowValue = True
        Me.BN_SalidaGU10.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU10.TabIndex = 667
        Me.BN_SalidaGU10.Text = "BarLevel3"
        Me.BN_SalidaGU10.TextSuffix = Nothing
        Me.BN_SalidaGU10.Value = 0R
        Me.BN_SalidaGU10.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU10
        '
        Me.BN_SP_TempGU10.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU10.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU10.ComComponent = Me.Guardiola10
        Me.BN_SP_TempGU10.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU10.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU10.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU10.Location = New System.Drawing.Point(215, 158)
        Me.BN_SP_TempGU10.Maximum = 100.0R
        Me.BN_SP_TempGU10.Minimum = 0R
        Me.BN_SP_TempGU10.Name = "BN_SP_TempGU10"
        Me.BN_SP_TempGU10.NumericFormat = Nothing
        Me.BN_SP_TempGU10.PLCAddressValue = "PID_GUARDIOLA3.SP"
        Me.BN_SP_TempGU10.ShowValue = True
        Me.BN_SP_TempGU10.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU10.TabIndex = 666
        Me.BN_SP_TempGU10.Text = "BarLevel1"
        Me.BN_SP_TempGU10.TextSuffix = Nothing
        Me.BN_SP_TempGU10.Value = 0R
        Me.BN_SP_TempGU10.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU10
        '
        Me.MD_OrdenTrabajoGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU10.ComComponent = Me.Guardiola10
        Me.MD_OrdenTrabajoGU10.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU10.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU10.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU10.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU10.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU10.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU10.Location = New System.Drawing.Point(988, 508)
        Me.MD_OrdenTrabajoGU10.Name = "MD_OrdenTrabajoGU10"
        Me.MD_OrdenTrabajoGU10.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU10.PLCAddressKeypad = "ORDEN_DE_CARGA_GA03"
        Me.MD_OrdenTrabajoGU10.PLCAddressValue = "ORDEN_DE_CARGA_GA03"
        Me.MD_OrdenTrabajoGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU10.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU10.TabIndex = 665
        Me.MD_OrdenTrabajoGU10.Value = 0R
        Me.MD_OrdenTrabajoGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU10
        '
        Me.MD_CosechaGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU10.ComComponent = Me.Guardiola10
        Me.MD_CosechaGU10.DecimalPosition = 0
        Me.MD_CosechaGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU10.KeypadMaxValue = 0R
        Me.MD_CosechaGU10.KeypadMinValue = 0R
        Me.MD_CosechaGU10.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU10.KeypadText = Nothing
        Me.MD_CosechaGU10.KeypadWidth = 300
        Me.MD_CosechaGU10.Location = New System.Drawing.Point(988, 411)
        Me.MD_CosechaGU10.Name = "MD_CosechaGU10"
        Me.MD_CosechaGU10.NumberOfDigits = 5
        Me.MD_CosechaGU10.PLCAddressKeypad = "GA03_LOTE_NUMERO"
        Me.MD_CosechaGU10.PLCAddressValue = "GA03_LOTE_NUMERO"
        Me.MD_CosechaGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU10.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU10.TabIndex = 664
        Me.MD_CosechaGU10.Value = 0R
        Me.MD_CosechaGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU10
        '
        Me.MD_HorasEstimadasGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU10.ComComponent = Me.Guardiola10
        Me.MD_HorasEstimadasGU10.DecimalPosition = 0
        Me.MD_HorasEstimadasGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU10.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU10.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU10.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU10.KeypadText = Nothing
        Me.MD_HorasEstimadasGU10.KeypadWidth = 300
        Me.MD_HorasEstimadasGU10.Location = New System.Drawing.Point(988, 318)
        Me.MD_HorasEstimadasGU10.Name = "MD_HorasEstimadasGU10"
        Me.MD_HorasEstimadasGU10.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU10.PLCAddressKeypad = "TIEMPO_SECADO_H_GA3"
        Me.MD_HorasEstimadasGU10.PLCAddressValue = "TIEMPO_SECADO_H_GA3"
        Me.MD_HorasEstimadasGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU10.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU10.TabIndex = 663
        Me.MD_HorasEstimadasGU10.Value = 0R
        Me.MD_HorasEstimadasGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU10
        '
        Me.MD_CicloGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU10.ComComponent = Me.Guardiola10
        Me.MD_CicloGU10.DecimalPosition = 0
        Me.MD_CicloGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU10.KeypadMaxValue = 0R
        Me.MD_CicloGU10.KeypadMinValue = 0R
        Me.MD_CicloGU10.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU10.KeypadText = Nothing
        Me.MD_CicloGU10.KeypadWidth = 300
        Me.MD_CicloGU10.Location = New System.Drawing.Point(988, 226)
        Me.MD_CicloGU10.Name = "MD_CicloGU10"
        Me.MD_CicloGU10.NumberOfDigits = 5
        Me.MD_CicloGU10.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA03"
        Me.MD_CicloGU10.PLCAddressValue = "NUMERO_CICLO_SECADO_GA03"
        Me.MD_CicloGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU10.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU10.TabIndex = 662
        Me.MD_CicloGU10.Value = 0R
        Me.MD_CicloGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU10
        '
        Me.TexCicloGU10.AutoSize = True
        Me.TexCicloGU10.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU10.ComComponent = Me.Guardiola10
        Me.TexCicloGU10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU10.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU10.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU10.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU10.HighlightKeyCharacter = "!"
        Me.TexCicloGU10.HighlightKeyCharacter2 = "."
        Me.TexCicloGU10.IniFileName = Nothing
        Me.TexCicloGU10.Location = New System.Drawing.Point(574, 522)
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Messages.Add(CType(resources.GetObject("TexCicloGU10.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU10.Name = "TexCicloGU10"
        Me.TexCicloGU10.PLCAddressValue = "NUMERO_CICLO_SECADO_GA03"
        Me.TexCicloGU10.PLCAddressVisible = ""
        Me.TexCicloGU10.ShowMessageNumber = False
        Me.TexCicloGU10.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU10.SpeakMessage = False
        Me.TexCicloGU10.TabIndex = 675
        Me.TexCicloGU10.Text = "No Seleccionado"
        Me.TexCicloGU10.TextPrefix = Nothing
        Me.TexCicloGU10.Value = 0
        '
        'MD_TempGU10
        '
        Me.MD_TempGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU10.ComComponent = Me.Guardiola10
        Me.MD_TempGU10.DecimalPosition = 1
        Me.MD_TempGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU10.KeypadMaxValue = 0R
        Me.MD_TempGU10.KeypadMinValue = 0R
        Me.MD_TempGU10.KeypadScaleFactor = 1.0R
        Me.MD_TempGU10.KeypadText = Nothing
        Me.MD_TempGU10.KeypadWidth = 300
        Me.MD_TempGU10.Location = New System.Drawing.Point(604, 337)
        Me.MD_TempGU10.Name = "MD_TempGU10"
        Me.MD_TempGU10.NumberOfDigits = 5
        Me.MD_TempGU10.PLCAddressKeypad = ""
        Me.MD_TempGU10.PLCAddressValue = "PID_GUARDIOLA3.PV"
        Me.MD_TempGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU10.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU10.TabIndex = 661
        Me.MD_TempGU10.Value = 0R
        Me.MD_TempGU10.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU10
        '
        Me.MD_HorasProcesoGU10.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU10.ComComponent = Me.Guardiola10
        Me.MD_HorasProcesoGU10.DecimalPosition = 0
        Me.MD_HorasProcesoGU10.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU10.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU10.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU10.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU10.KeypadText = Nothing
        Me.MD_HorasProcesoGU10.KeypadWidth = 300
        Me.MD_HorasProcesoGU10.Location = New System.Drawing.Point(465, 84)
        Me.MD_HorasProcesoGU10.Name = "MD_HorasProcesoGU10"
        Me.MD_HorasProcesoGU10.NumberOfDigits = 5
        Me.MD_HorasProcesoGU10.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU10.PLCAddressValue = "SECADO_G3_MONITOR"
        Me.MD_HorasProcesoGU10.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU10.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU10.TabIndex = 660
        Me.MD_HorasProcesoGU10.Value = 0R
        Me.MD_HorasProcesoGU10.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU10.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU10
        '
        Me.Tex_CicloGU10.AutoSize = True
        Me.Tex_CicloGU10.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU10.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU10.Location = New System.Drawing.Point(975, 204)
        Me.Tex_CicloGU10.Name = "Tex_CicloGU10"
        Me.Tex_CicloGU10.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU10.TabIndex = 659
        Me.Tex_CicloGU10.Text = "Numero de Ciclo"
        Me.Tex_CicloGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU10
        '
        Me.Tex_OrdenTrabajoGU10.AutoSize = True
        Me.Tex_OrdenTrabajoGU10.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU10.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU10.Location = New System.Drawing.Point(1028, 483)
        Me.Tex_OrdenTrabajoGU10.Name = "Tex_OrdenTrabajoGU10"
        Me.Tex_OrdenTrabajoGU10.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU10.TabIndex = 658
        Me.Tex_OrdenTrabajoGU10.Text = "OT"
        Me.Tex_OrdenTrabajoGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU10
        '
        Me.Tex_CosechaGU10.AutoSize = True
        Me.Tex_CosechaGU10.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU10.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU10.Location = New System.Drawing.Point(996, 386)
        Me.Tex_CosechaGU10.Name = "Tex_CosechaGU10"
        Me.Tex_CosechaGU10.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU10.TabIndex = 657
        Me.Tex_CosechaGU10.Text = "Cosecha"
        Me.Tex_CosechaGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU10
        '
        Me.Tex_HorasEstimadasGU10.AutoSize = True
        Me.Tex_HorasEstimadasGU10.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU10.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU10.Location = New System.Drawing.Point(928, 296)
        Me.Tex_HorasEstimadasGU10.Name = "Tex_HorasEstimadasGU10"
        Me.Tex_HorasEstimadasGU10.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU10.TabIndex = 656
        Me.Tex_HorasEstimadasGU10.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU10
        '
        Me.Tex_HorasProcesoGU10.AutoSize = True
        Me.Tex_HorasProcesoGU10.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU10.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU10.Location = New System.Drawing.Point(449, 55)
        Me.Tex_HorasProcesoGU10.Name = "Tex_HorasProcesoGU10"
        Me.Tex_HorasProcesoGU10.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU10.TabIndex = 655
        Me.Tex_HorasProcesoGU10.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola10
        '
        Me.TexGuardiola10.AutoSize = True
        Me.TexGuardiola10.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola10.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola10.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola10.Location = New System.Drawing.Point(678, 56)
        Me.TexGuardiola10.Name = "TexGuardiola10"
        Me.TexGuardiola10.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola10.TabIndex = 654
        Me.TexGuardiola10.Text = "Guardiola 10"
        '
        'TexTempGU10
        '
        Me.TexTempGU10.AutoSize = True
        Me.TexTempGU10.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU10.Location = New System.Drawing.Point(601, 316)
        Me.TexTempGU10.Name = "TexTempGU10"
        Me.TexTempGU10.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU10.TabIndex = 653
        Me.TexTempGU10.Text = "Temperatura °C"
        Me.TexTempGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU10
        '
        Me.TexPID_GU10.AutoSize = True
        Me.TexPID_GU10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU10.Location = New System.Drawing.Point(205, 75)
        Me.TexPID_GU10.Name = "TexPID_GU10"
        Me.TexPID_GU10.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU10.TabIndex = 652
        Me.TexPID_GU10.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU10
        '
        Me.TexBN_SalidaGU10.AutoSize = True
        Me.TexBN_SalidaGU10.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU10.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU10.Location = New System.Drawing.Point(350, 136)
        Me.TexBN_SalidaGU10.Name = "TexBN_SalidaGU10"
        Me.TexBN_SalidaGU10.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU10.TabIndex = 651
        Me.TexBN_SalidaGU10.Text = "Salida"
        Me.TexBN_SalidaGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU10
        '
        Me.TexBN_RealTempGU10.AutoSize = True
        Me.TexBN_RealTempGU10.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU10.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU10.Location = New System.Drawing.Point(285, 137)
        Me.TexBN_RealTempGU10.Name = "TexBN_RealTempGU10"
        Me.TexBN_RealTempGU10.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU10.TabIndex = 650
        Me.TexBN_RealTempGU10.Text = "Real"
        Me.TexBN_RealTempGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU10
        '
        Me.TexBN_SP_TempGU10.AutoSize = True
        Me.TexBN_SP_TempGU10.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU10.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU10.Location = New System.Drawing.Point(201, 137)
        Me.TexBN_SP_TempGU10.Name = "TexBN_SP_TempGU10"
        Me.TexBN_SP_TempGU10.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU10.TabIndex = 649
        Me.TexBN_SP_TempGU10.Text = "SetPoint"
        Me.TexBN_SP_TempGU10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU10
        '
        Me.IGU10.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU10.Location = New System.Drawing.Point(440, 310)
        Me.IGU10.Name = "IGU10"
        Me.IGU10.Size = New System.Drawing.Size(541, 274)
        Me.IGU10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU10.TabIndex = 676
        Me.IGU10.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola10
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 52)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 678
        '
        'Guardiola_10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU10)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU10)
        Me.Controls.Add(Me.BCF_MenúP_GU10)
        Me.Controls.Add(Me.BP_FinCicloGU10)
        Me.Controls.Add(Me.BP_IniCicloGU10)
        Me.Controls.Add(Me.BCF_RegresarGU10)
        Me.Controls.Add(Me.BP_DescargaGU10)
        Me.Controls.Add(Me.BP_CofirDescagaGU10)
        Me.Controls.Add(Me.BN_SalidaGU10)
        Me.Controls.Add(Me.BN_SP_TempGU10)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU10)
        Me.Controls.Add(Me.MD_CosechaGU10)
        Me.Controls.Add(Me.MD_HorasEstimadasGU10)
        Me.Controls.Add(Me.MD_CicloGU10)
        Me.Controls.Add(Me.TexCicloGU10)
        Me.Controls.Add(Me.MD_TempGU10)
        Me.Controls.Add(Me.MD_HorasProcesoGU10)
        Me.Controls.Add(Me.Tex_CicloGU10)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU10)
        Me.Controls.Add(Me.Tex_CosechaGU10)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU10)
        Me.Controls.Add(Me.Tex_HorasProcesoGU10)
        Me.Controls.Add(Me.TexGuardiola10)
        Me.Controls.Add(Me.TexTempGU10)
        Me.Controls.Add(Me.TexPID_GU10)
        Me.Controls.Add(Me.TexBN_SalidaGU10)
        Me.Controls.Add(Me.TexBN_RealTempGU10)
        Me.Controls.Add(Me.TexBN_SP_TempGU10)
        Me.Controls.Add(Me.IGU10)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU10 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola10 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU10 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU10 As FormChangeButton
    Friend WithEvents BP_FinCicloGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU10 As FormChangeButton
    Friend WithEvents BP_DescargaGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU10 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU10 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU10 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU10 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU10 As Label
    Friend WithEvents Tex_OrdenTrabajoGU10 As Label
    Friend WithEvents Tex_CosechaGU10 As Label
    Friend WithEvents Tex_HorasEstimadasGU10 As Label
    Friend WithEvents Tex_HorasProcesoGU10 As Label
    Friend WithEvents TexGuardiola10 As Label
    Friend WithEvents TexTempGU10 As Label
    Friend WithEvents TexPID_GU10 As Label
    Friend WithEvents TexBN_SalidaGU10 As Label
    Friend WithEvents TexBN_RealTempGU10 As Label
    Friend WithEvents TexBN_SP_TempGU10 As Label
    Friend WithEvents IGU10 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
