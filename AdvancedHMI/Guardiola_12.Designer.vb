<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_12))
        Me.CT_SGU12 = New AdvancedHMIControls.TempController()
        Me.Guardiola12 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU12 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU12 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU12 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU12 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU12 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU12 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU12 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU12 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU12 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU12 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU12 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU12 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU12 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU12 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU12 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU12 = New System.Windows.Forms.Label()
        Me.TexGuardiola12 = New System.Windows.Forms.Label()
        Me.TexTempGU12 = New System.Windows.Forms.Label()
        Me.TexPID_GU12 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU12 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU12 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU12 = New System.Windows.Forms.Label()
        Me.IGU12 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU12
        '
        Me.CT_SGU12.Button1Text = Nothing
        Me.CT_SGU12.Button2Text = Nothing
        Me.CT_SGU12.ComComponent = Me.Guardiola12
        Me.CT_SGU12.DecimalPosition = 1
        Me.CT_SGU12.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU12.Location = New System.Drawing.Point(204, 432)
        Me.CT_SGU12.Name = "CT_SGU12"
        Me.CT_SGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU12.PLCAddressClick1 = ""
        Me.CT_SGU12.PLCAddressClick2 = ""
        Me.CT_SGU12.PLCAddressClick3 = ""
        Me.CT_SGU12.PLCAddressClick4 = ""
        Me.CT_SGU12.PLCAddressText = ""
        Me.CT_SGU12.PLCAddressValuePV = "PID_GUARDIOLA5.PV"
        Me.CT_SGU12.PLCAddressValueSP = "PID_GUARDIOLA5.SP"
        Me.CT_SGU12.PLCAddressVisible = ""
        Me.CT_SGU12.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU12.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU12.TabIndex = 683
        Me.CT_SGU12.Text = "S-GU-12"
        Me.CT_SGU12.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU12.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU12.Value2Text = "SP"
        Me.CT_SGU12.ValuePV = 0!
        Me.CT_SGU12.ValueSP = 0!
        '
        'Guardiola12
        '
        Me.Guardiola12.CIPConnectionSize = 508
        Me.Guardiola12.DisableMultiServiceRequest = False
        Me.Guardiola12.DisableSubscriptions = False
        Me.Guardiola12.IniFileName = ""
        Me.Guardiola12.IniFileSection = Nothing
        Me.Guardiola12.IPAddress = "10.1.108.20"
        Me.Guardiola12.PollRateOverride = 500
        Me.Guardiola12.Port = 44818
        Me.Guardiola12.ProcessorSlot = 0
        Me.Guardiola12.RoutePath = Nothing
        Me.Guardiola12.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola12
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
        Me.BasicButton1.ComComponent = Me.Guardiola12
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
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA05"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 681
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU12
        '
        Me.LS_MarchaGU12.Blink = False
        Me.LS_MarchaGU12.ComComponent = Me.Guardiola12
        Me.LS_MarchaGU12.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU12.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU12.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU12.Location = New System.Drawing.Point(855, 317)
        Me.LS_MarchaGU12.Name = "LS_MarchaGU12"
        Me.LS_MarchaGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU12.PLCAddressClick = ""
        Me.LS_MarchaGU12.PLCAddressText = ""
        Me.LS_MarchaGU12.PLCAddressValue = "MARCHA_GU12"
        Me.LS_MarchaGU12.PLCAddressVisible = ""
        Me.LS_MarchaGU12.Size = New System.Drawing.Size(50, 53)
        Me.LS_MarchaGU12.TabIndex = 678
        Me.LS_MarchaGU12.Value = False
        Me.LS_MarchaGU12.ValueToWrite = 0
        '
        'BCF_MenúP_GU12
        '
        Me.BCF_MenúP_GU12.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU12.ComComponent = Nothing
        Me.BCF_MenúP_GU12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU12.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU12.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU12.KeypadWidth = 300
        Me.BCF_MenúP_GU12.Location = New System.Drawing.Point(228, 646)
        Me.BCF_MenúP_GU12.Name = "BCF_MenúP_GU12"
        Me.BCF_MenúP_GU12.Passcode = Nothing
        Me.BCF_MenúP_GU12.PasswordChar = False
        Me.BCF_MenúP_GU12.PLCAddressVisible = ""
        Me.BCF_MenúP_GU12.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU12.TabIndex = 677
        Me.BCF_MenúP_GU12.Text = "Menú Principal"
        Me.BCF_MenúP_GU12.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU12
        '
        Me.BP_FinCicloGU12.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU12.ComComponent = Me.Guardiola12
        Me.BP_FinCicloGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU12.Highlight = False
        Me.BP_FinCicloGU12.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU12.Location = New System.Drawing.Point(711, 220)
        Me.BP_FinCicloGU12.MaximumHoldTime = 3000
        Me.BP_FinCicloGU12.MinimumHoldTime = 500
        Me.BP_FinCicloGU12.Name = "BP_FinCicloGU12"
        Me.BP_FinCicloGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU12.PLCAddressClick = "BP_FIN_CICLO_GA5"
        Me.BP_FinCicloGU12.SelectTextAlternate = False
        Me.BP_FinCicloGU12.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU12.TabIndex = 676
        Me.BP_FinCicloGU12.Text = "Detener Ciclo"
        Me.BP_FinCicloGU12.TextAlternate = Nothing
        Me.BP_FinCicloGU12.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU12.ValueToWrite = 0
        '
        'BP_IniCicloGU12
        '
        Me.BP_IniCicloGU12.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU12.ComComponent = Me.Guardiola12
        Me.BP_IniCicloGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU12.Highlight = False
        Me.BP_IniCicloGU12.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU12.Location = New System.Drawing.Point(509, 220)
        Me.BP_IniCicloGU12.MaximumHoldTime = 3000
        Me.BP_IniCicloGU12.MinimumHoldTime = 500
        Me.BP_IniCicloGU12.Name = "BP_IniCicloGU12"
        Me.BP_IniCicloGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU12.PLCAddressClick = "BP_ARRANQUE_G5"
        Me.BP_IniCicloGU12.SelectTextAlternate = False
        Me.BP_IniCicloGU12.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU12.TabIndex = 675
        Me.BP_IniCicloGU12.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU12.TextAlternate = Nothing
        Me.BP_IniCicloGU12.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU12.ValueToWrite = 0
        '
        'BCF_RegresarGU12
        '
        Me.BCF_RegresarGU12.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU12.ComComponent = Nothing
        Me.BCF_RegresarGU12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU12.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU12.FormToOpen = Nothing
        Me.BCF_RegresarGU12.KeypadWidth = 300
        Me.BCF_RegresarGU12.Location = New System.Drawing.Point(646, 100)
        Me.BCF_RegresarGU12.Name = "BCF_RegresarGU12"
        Me.BCF_RegresarGU12.Passcode = Nothing
        Me.BCF_RegresarGU12.PasswordChar = False
        Me.BCF_RegresarGU12.PLCAddressVisible = ""
        Me.BCF_RegresarGU12.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU12.TabIndex = 674
        Me.BCF_RegresarGU12.Text = "Regresar"
        Me.BCF_RegresarGU12.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU12
        '
        Me.BP_DescargaGU12.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU12.ComComponent = Me.Guardiola12
        Me.BP_DescargaGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU12.Highlight = False
        Me.BP_DescargaGU12.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU12.Location = New System.Drawing.Point(961, 123)
        Me.BP_DescargaGU12.MaximumHoldTime = 3000
        Me.BP_DescargaGU12.MinimumHoldTime = 500
        Me.BP_DescargaGU12.Name = "BP_DescargaGU12"
        Me.BP_DescargaGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU12.PLCAddressClick = "BP_DESCARGAR_GA5"
        Me.BP_DescargaGU12.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA5"
        Me.BP_DescargaGU12.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA5"
        Me.BP_DescargaGU12.SelectTextAlternate = False
        Me.BP_DescargaGU12.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU12.TabIndex = 673
        Me.BP_DescargaGU12.Text = "Finalizar"
        Me.BP_DescargaGU12.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU12.UseVisualStyleBackColor = True
        Me.BP_DescargaGU12.ValueToWrite = 0
        '
        'BP_CofirDescagaGU12
        '
        Me.BP_CofirDescagaGU12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU12.ComComponent = Me.Guardiola12
        Me.BP_CofirDescagaGU12.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU12.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU12.Highlight = False
        Me.BP_CofirDescagaGU12.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU12.Location = New System.Drawing.Point(961, 64)
        Me.BP_CofirDescagaGU12.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU12.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU12.Name = "BP_CofirDescagaGU12"
        Me.BP_CofirDescagaGU12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU12.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA5"
        Me.BP_CofirDescagaGU12.PLCAddressVisible = "CONFIMAR_DESCARGA_GA5"
        Me.BP_CofirDescagaGU12.SelectTextAlternate = False
        Me.BP_CofirDescagaGU12.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU12.TabIndex = 672
        Me.BP_CofirDescagaGU12.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU12.TextAlternate = Nothing
        Me.BP_CofirDescagaGU12.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU12.ValueToWrite = 0
        '
        'BN_SalidaGU12
        '
        Me.BN_SalidaGU12.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU12.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU12.ComComponent = Me.Guardiola12
        Me.BN_SalidaGU12.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU12.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU12.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU12.Location = New System.Drawing.Point(358, 156)
        Me.BN_SalidaGU12.Maximum = 100.0R
        Me.BN_SalidaGU12.Minimum = 0R
        Me.BN_SalidaGU12.Name = "BN_SalidaGU12"
        Me.BN_SalidaGU12.NumericFormat = Nothing
        Me.BN_SalidaGU12.PLCAddressValue = "PID_GUARDIOLA5.OUT"
        Me.BN_SalidaGU12.ShowValue = True
        Me.BN_SalidaGU12.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU12.TabIndex = 671
        Me.BN_SalidaGU12.Text = "BarLevel3"
        Me.BN_SalidaGU12.TextSuffix = Nothing
        Me.BN_SalidaGU12.Value = 0R
        Me.BN_SalidaGU12.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU12
        '
        Me.BN_SP_TempGU12.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU12.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU12.ComComponent = Me.Guardiola12
        Me.BN_SP_TempGU12.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU12.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU12.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU12.Location = New System.Drawing.Point(216, 157)
        Me.BN_SP_TempGU12.Maximum = 100.0R
        Me.BN_SP_TempGU12.Minimum = 0R
        Me.BN_SP_TempGU12.Name = "BN_SP_TempGU12"
        Me.BN_SP_TempGU12.NumericFormat = Nothing
        Me.BN_SP_TempGU12.PLCAddressValue = "PID_GUARDIOLA5.SP"
        Me.BN_SP_TempGU12.ShowValue = True
        Me.BN_SP_TempGU12.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU12.TabIndex = 670
        Me.BN_SP_TempGU12.Text = "BarLevel1"
        Me.BN_SP_TempGU12.TextSuffix = Nothing
        Me.BN_SP_TempGU12.Value = 0R
        Me.BN_SP_TempGU12.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU12
        '
        Me.MD_OrdenTrabajoGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU12.ComComponent = Me.Guardiola12
        Me.MD_OrdenTrabajoGU12.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU12.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU12.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU12.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU12.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU12.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU12.Location = New System.Drawing.Point(989, 507)
        Me.MD_OrdenTrabajoGU12.Name = "MD_OrdenTrabajoGU12"
        Me.MD_OrdenTrabajoGU12.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU12.PLCAddressKeypad = "ORDEN_DE_CARGA_GA05"
        Me.MD_OrdenTrabajoGU12.PLCAddressValue = "ORDEN_DE_CARGA_GA05"
        Me.MD_OrdenTrabajoGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU12.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU12.TabIndex = 669
        Me.MD_OrdenTrabajoGU12.Value = 0R
        Me.MD_OrdenTrabajoGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU12
        '
        Me.MD_CosechaGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU12.ComComponent = Me.Guardiola12
        Me.MD_CosechaGU12.DecimalPosition = 0
        Me.MD_CosechaGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU12.KeypadMaxValue = 0R
        Me.MD_CosechaGU12.KeypadMinValue = 0R
        Me.MD_CosechaGU12.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU12.KeypadText = Nothing
        Me.MD_CosechaGU12.KeypadWidth = 300
        Me.MD_CosechaGU12.Location = New System.Drawing.Point(989, 410)
        Me.MD_CosechaGU12.Name = "MD_CosechaGU12"
        Me.MD_CosechaGU12.NumberOfDigits = 5
        Me.MD_CosechaGU12.PLCAddressKeypad = "GA05_LOTE_NUMERO"
        Me.MD_CosechaGU12.PLCAddressValue = "GA05_LOTE_NUMERO"
        Me.MD_CosechaGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU12.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU12.TabIndex = 668
        Me.MD_CosechaGU12.Value = 0R
        Me.MD_CosechaGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU12
        '
        Me.MD_HorasEstimadasGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU12.ComComponent = Me.Guardiola12
        Me.MD_HorasEstimadasGU12.DecimalPosition = 0
        Me.MD_HorasEstimadasGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU12.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU12.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU12.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU12.KeypadText = Nothing
        Me.MD_HorasEstimadasGU12.KeypadWidth = 300
        Me.MD_HorasEstimadasGU12.Location = New System.Drawing.Point(989, 317)
        Me.MD_HorasEstimadasGU12.Name = "MD_HorasEstimadasGU12"
        Me.MD_HorasEstimadasGU12.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU12.PLCAddressKeypad = "TIEMPO_SECADO_H_GA5"
        Me.MD_HorasEstimadasGU12.PLCAddressValue = "TIEMPO_SECADO_H_GA5"
        Me.MD_HorasEstimadasGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU12.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU12.TabIndex = 667
        Me.MD_HorasEstimadasGU12.Value = 0R
        Me.MD_HorasEstimadasGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU12
        '
        Me.MD_CicloGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU12.ComComponent = Me.Guardiola12
        Me.MD_CicloGU12.DecimalPosition = 0
        Me.MD_CicloGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU12.KeypadMaxValue = 0R
        Me.MD_CicloGU12.KeypadMinValue = 0R
        Me.MD_CicloGU12.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU12.KeypadText = Nothing
        Me.MD_CicloGU12.KeypadWidth = 300
        Me.MD_CicloGU12.Location = New System.Drawing.Point(989, 225)
        Me.MD_CicloGU12.Name = "MD_CicloGU12"
        Me.MD_CicloGU12.NumberOfDigits = 5
        Me.MD_CicloGU12.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA05"
        Me.MD_CicloGU12.PLCAddressValue = "NUMERO_CICLO_SECADO_GA05"
        Me.MD_CicloGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU12.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU12.TabIndex = 666
        Me.MD_CicloGU12.Value = 0R
        Me.MD_CicloGU12.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU12
        '
        Me.TexCicloGU12.AutoSize = True
        Me.TexCicloGU12.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU12.ComComponent = Me.Guardiola12
        Me.TexCicloGU12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU12.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU12.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU12.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU12.HighlightKeyCharacter = "!"
        Me.TexCicloGU12.HighlightKeyCharacter2 = "."
        Me.TexCicloGU12.IniFileName = Nothing
        Me.TexCicloGU12.Location = New System.Drawing.Point(578, 521)
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Messages.Add(CType(resources.GetObject("TexCicloGU12.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU12.Name = "TexCicloGU12"
        Me.TexCicloGU12.PLCAddressValue = "NUMERO_CICLO_SECADO_GA05"
        Me.TexCicloGU12.PLCAddressVisible = ""
        Me.TexCicloGU12.ShowMessageNumber = False
        Me.TexCicloGU12.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU12.SpeakMessage = False
        Me.TexCicloGU12.TabIndex = 679
        Me.TexCicloGU12.Text = "No Seleccionado"
        Me.TexCicloGU12.TextPrefix = Nothing
        Me.TexCicloGU12.Value = 0
        '
        'MD_TempGU12
        '
        Me.MD_TempGU12.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU12.ComComponent = Me.Guardiola12
        Me.MD_TempGU12.DecimalPosition = 1
        Me.MD_TempGU12.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU12.KeypadMaxValue = 0R
        Me.MD_TempGU12.KeypadMinValue = 0R
        Me.MD_TempGU12.KeypadScaleFactor = 1.0R
        Me.MD_TempGU12.KeypadText = Nothing
        Me.MD_TempGU12.KeypadWidth = 300
        Me.MD_TempGU12.Location = New System.Drawing.Point(605, 336)
        Me.MD_TempGU12.Name = "MD_TempGU12"
        Me.MD_TempGU12.NumberOfDigits = 5
        Me.MD_TempGU12.PLCAddressKeypad = ""
        Me.MD_TempGU12.PLCAddressValue = "PID_GUARDIOLA5.PV"
        Me.MD_TempGU12.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU12.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU12.TabIndex = 665
        Me.MD_TempGU12.Value = 0R
        Me.MD_TempGU12.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU12.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU05
        '
        Me.MD_HorasProcesoGU05.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU05.ComComponent = Me.Guardiola12
        Me.MD_HorasProcesoGU05.DecimalPosition = 0
        Me.MD_HorasProcesoGU05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU05.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU05.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU05.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU05.KeypadText = Nothing
        Me.MD_HorasProcesoGU05.KeypadWidth = 300
        Me.MD_HorasProcesoGU05.Location = New System.Drawing.Point(466, 83)
        Me.MD_HorasProcesoGU05.Name = "MD_HorasProcesoGU05"
        Me.MD_HorasProcesoGU05.NumberOfDigits = 5
        Me.MD_HorasProcesoGU05.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU05.PLCAddressValue = "SECADO_G5_MONITOR"
        Me.MD_HorasProcesoGU05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU05.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU05.TabIndex = 664
        Me.MD_HorasProcesoGU05.Value = 0R
        Me.MD_HorasProcesoGU05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU12
        '
        Me.Tex_CicloGU12.AutoSize = True
        Me.Tex_CicloGU12.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU12.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU12.Location = New System.Drawing.Point(976, 203)
        Me.Tex_CicloGU12.Name = "Tex_CicloGU12"
        Me.Tex_CicloGU12.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU12.TabIndex = 663
        Me.Tex_CicloGU12.Text = "Numero de Ciclo"
        Me.Tex_CicloGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU12
        '
        Me.Tex_OrdenTrabajoGU12.AutoSize = True
        Me.Tex_OrdenTrabajoGU12.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU12.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU12.Location = New System.Drawing.Point(1029, 482)
        Me.Tex_OrdenTrabajoGU12.Name = "Tex_OrdenTrabajoGU12"
        Me.Tex_OrdenTrabajoGU12.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU12.TabIndex = 662
        Me.Tex_OrdenTrabajoGU12.Text = "OT"
        Me.Tex_OrdenTrabajoGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU12
        '
        Me.Tex_CosechaGU12.AutoSize = True
        Me.Tex_CosechaGU12.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU12.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU12.Location = New System.Drawing.Point(997, 385)
        Me.Tex_CosechaGU12.Name = "Tex_CosechaGU12"
        Me.Tex_CosechaGU12.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU12.TabIndex = 661
        Me.Tex_CosechaGU12.Text = "Cosecha"
        Me.Tex_CosechaGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU12
        '
        Me.Tex_HorasEstimadasGU12.AutoSize = True
        Me.Tex_HorasEstimadasGU12.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU12.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU12.Location = New System.Drawing.Point(929, 295)
        Me.Tex_HorasEstimadasGU12.Name = "Tex_HorasEstimadasGU12"
        Me.Tex_HorasEstimadasGU12.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU12.TabIndex = 660
        Me.Tex_HorasEstimadasGU12.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU12
        '
        Me.Tex_HorasProcesoGU12.AutoSize = True
        Me.Tex_HorasProcesoGU12.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU12.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU12.Location = New System.Drawing.Point(450, 54)
        Me.Tex_HorasProcesoGU12.Name = "Tex_HorasProcesoGU12"
        Me.Tex_HorasProcesoGU12.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU12.TabIndex = 659
        Me.Tex_HorasProcesoGU12.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola12
        '
        Me.TexGuardiola12.AutoSize = True
        Me.TexGuardiola12.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola12.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola12.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola12.Location = New System.Drawing.Point(679, 55)
        Me.TexGuardiola12.Name = "TexGuardiola12"
        Me.TexGuardiola12.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola12.TabIndex = 658
        Me.TexGuardiola12.Text = "Guardiola 12"
        '
        'TexTempGU12
        '
        Me.TexTempGU12.AutoSize = True
        Me.TexTempGU12.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU12.Location = New System.Drawing.Point(602, 315)
        Me.TexTempGU12.Name = "TexTempGU12"
        Me.TexTempGU12.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU12.TabIndex = 657
        Me.TexTempGU12.Text = "Temperatura °C"
        Me.TexTempGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU12
        '
        Me.TexPID_GU12.AutoSize = True
        Me.TexPID_GU12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU12.Location = New System.Drawing.Point(203, 74)
        Me.TexPID_GU12.Name = "TexPID_GU12"
        Me.TexPID_GU12.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU12.TabIndex = 656
        Me.TexPID_GU12.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU12
        '
        Me.TexBN_SalidaGU12.AutoSize = True
        Me.TexBN_SalidaGU12.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU12.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU12.Location = New System.Drawing.Point(351, 135)
        Me.TexBN_SalidaGU12.Name = "TexBN_SalidaGU12"
        Me.TexBN_SalidaGU12.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU12.TabIndex = 655
        Me.TexBN_SalidaGU12.Text = "Salida"
        Me.TexBN_SalidaGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU12
        '
        Me.TexBN_RealTempGU12.AutoSize = True
        Me.TexBN_RealTempGU12.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU12.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU12.Location = New System.Drawing.Point(286, 136)
        Me.TexBN_RealTempGU12.Name = "TexBN_RealTempGU12"
        Me.TexBN_RealTempGU12.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU12.TabIndex = 654
        Me.TexBN_RealTempGU12.Text = "Real"
        Me.TexBN_RealTempGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU12
        '
        Me.TexBN_SP_TempGU12.AutoSize = True
        Me.TexBN_SP_TempGU12.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU12.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU12.Location = New System.Drawing.Point(202, 136)
        Me.TexBN_SP_TempGU12.Name = "TexBN_SP_TempGU12"
        Me.TexBN_SP_TempGU12.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU12.TabIndex = 653
        Me.TexBN_SP_TempGU12.Text = "SetPoint"
        Me.TexBN_SP_TempGU12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU12
        '
        Me.IGU12.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU12.Location = New System.Drawing.Point(440, 309)
        Me.IGU12.Name = "IGU12"
        Me.IGU12.Size = New System.Drawing.Size(541, 274)
        Me.IGU12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU12.TabIndex = 680
        Me.IGU12.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola12
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 52)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 682
        '
        'Guardiola_12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU12)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU12)
        Me.Controls.Add(Me.BCF_MenúP_GU12)
        Me.Controls.Add(Me.BP_FinCicloGU12)
        Me.Controls.Add(Me.BP_IniCicloGU12)
        Me.Controls.Add(Me.BCF_RegresarGU12)
        Me.Controls.Add(Me.BP_DescargaGU12)
        Me.Controls.Add(Me.BP_CofirDescagaGU12)
        Me.Controls.Add(Me.BN_SalidaGU12)
        Me.Controls.Add(Me.BN_SP_TempGU12)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU12)
        Me.Controls.Add(Me.MD_CosechaGU12)
        Me.Controls.Add(Me.MD_HorasEstimadasGU12)
        Me.Controls.Add(Me.MD_CicloGU12)
        Me.Controls.Add(Me.TexCicloGU12)
        Me.Controls.Add(Me.MD_TempGU12)
        Me.Controls.Add(Me.MD_HorasProcesoGU05)
        Me.Controls.Add(Me.Tex_CicloGU12)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU12)
        Me.Controls.Add(Me.Tex_CosechaGU12)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU12)
        Me.Controls.Add(Me.Tex_HorasProcesoGU12)
        Me.Controls.Add(Me.TexGuardiola12)
        Me.Controls.Add(Me.TexTempGU12)
        Me.Controls.Add(Me.TexPID_GU12)
        Me.Controls.Add(Me.TexBN_SalidaGU12)
        Me.Controls.Add(Me.TexBN_RealTempGU12)
        Me.Controls.Add(Me.TexBN_SP_TempGU12)
        Me.Controls.Add(Me.IGU12)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU12 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola12 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU12 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU12 As FormChangeButton
    Friend WithEvents BP_FinCicloGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU12 As FormChangeButton
    Friend WithEvents BP_DescargaGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU12 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU12 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU12 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU12 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU12 As Label
    Friend WithEvents Tex_OrdenTrabajoGU12 As Label
    Friend WithEvents Tex_CosechaGU12 As Label
    Friend WithEvents Tex_HorasEstimadasGU12 As Label
    Friend WithEvents Tex_HorasProcesoGU12 As Label
    Friend WithEvents TexGuardiola12 As Label
    Friend WithEvents TexTempGU12 As Label
    Friend WithEvents TexPID_GU12 As Label
    Friend WithEvents TexBN_SalidaGU12 As Label
    Friend WithEvents TexBN_RealTempGU12 As Label
    Friend WithEvents TexBN_SP_TempGU12 As Label
    Friend WithEvents IGU12 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
