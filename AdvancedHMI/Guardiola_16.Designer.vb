<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_16))
        Me.CT_SGU16 = New AdvancedHMIControls.TempController()
        Me.Guardiola16 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU16 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU16 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU16 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU16 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU16 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU16 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU16 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU16 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU16 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU16 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU16 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU16 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU16 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU16 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU16 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU16 = New System.Windows.Forms.Label()
        Me.TexGuardiola16 = New System.Windows.Forms.Label()
        Me.TexTempGU16 = New System.Windows.Forms.Label()
        Me.TexPID_GU16 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU16 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU16 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU16 = New System.Windows.Forms.Label()
        Me.IGU16 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU16
        '
        Me.CT_SGU16.Button1Text = Nothing
        Me.CT_SGU16.Button2Text = Nothing
        Me.CT_SGU16.ComComponent = Me.Guardiola16
        Me.CT_SGU16.DecimalPosition = 1
        Me.CT_SGU16.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU16.Location = New System.Drawing.Point(204, 431)
        Me.CT_SGU16.Name = "CT_SGU16"
        Me.CT_SGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU16.PLCAddressClick1 = ""
        Me.CT_SGU16.PLCAddressClick2 = ""
        Me.CT_SGU16.PLCAddressClick3 = ""
        Me.CT_SGU16.PLCAddressClick4 = ""
        Me.CT_SGU16.PLCAddressText = ""
        Me.CT_SGU16.PLCAddressValuePV = "PID_GUARDIOLA9.PV"
        Me.CT_SGU16.PLCAddressValueSP = "PID_GUARDIOLA9.SP"
        Me.CT_SGU16.PLCAddressVisible = ""
        Me.CT_SGU16.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU16.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU16.TabIndex = 747
        Me.CT_SGU16.Text = "S-GU-16"
        Me.CT_SGU16.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU16.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU16.Value2Text = "SP"
        Me.CT_SGU16.ValuePV = 0!
        Me.CT_SGU16.ValueSP = 0!
        '
        'Guardiola16
        '
        Me.Guardiola16.CIPConnectionSize = 508
        Me.Guardiola16.DisableMultiServiceRequest = False
        Me.Guardiola16.DisableSubscriptions = False
        Me.Guardiola16.IniFileName = ""
        Me.Guardiola16.IniFileSection = Nothing
        Me.Guardiola16.IPAddress = "10.1.108.20"
        Me.Guardiola16.PollRateOverride = 500
        Me.Guardiola16.Port = 44818
        Me.Guardiola16.ProcessorSlot = 0
        Me.Guardiola16.RoutePath = Nothing
        Me.Guardiola16.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola16
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
        Me.BasicButton1.ComComponent = Me.Guardiola16
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(960, 587)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA09"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 745
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU16
        '
        Me.LS_MarchaGU16.Blink = False
        Me.LS_MarchaGU16.ComComponent = Me.Guardiola16
        Me.LS_MarchaGU16.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU16.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU16.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU16.Location = New System.Drawing.Point(854, 316)
        Me.LS_MarchaGU16.Name = "LS_MarchaGU16"
        Me.LS_MarchaGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU16.PLCAddressClick = ""
        Me.LS_MarchaGU16.PLCAddressText = ""
        Me.LS_MarchaGU16.PLCAddressValue = "MARCHA_GU16"
        Me.LS_MarchaGU16.PLCAddressVisible = ""
        Me.LS_MarchaGU16.Size = New System.Drawing.Size(53, 56)
        Me.LS_MarchaGU16.TabIndex = 742
        Me.LS_MarchaGU16.Value = False
        Me.LS_MarchaGU16.ValueToWrite = 0
        '
        'BCF_MenúP_GU16
        '
        Me.BCF_MenúP_GU16.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU16.ComComponent = Nothing
        Me.BCF_MenúP_GU16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU16.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU16.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU16.KeypadWidth = 300
        Me.BCF_MenúP_GU16.Location = New System.Drawing.Point(226, 647)
        Me.BCF_MenúP_GU16.Name = "BCF_MenúP_GU16"
        Me.BCF_MenúP_GU16.Passcode = Nothing
        Me.BCF_MenúP_GU16.PasswordChar = False
        Me.BCF_MenúP_GU16.PLCAddressVisible = ""
        Me.BCF_MenúP_GU16.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU16.TabIndex = 741
        Me.BCF_MenúP_GU16.Text = "Menú Principal"
        Me.BCF_MenúP_GU16.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU16
        '
        Me.BP_FinCicloGU16.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU16.ComComponent = Me.Guardiola16
        Me.BP_FinCicloGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU16.Highlight = False
        Me.BP_FinCicloGU16.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU16.Location = New System.Drawing.Point(710, 212)
        Me.BP_FinCicloGU16.MaximumHoldTime = 3000
        Me.BP_FinCicloGU16.MinimumHoldTime = 500
        Me.BP_FinCicloGU16.Name = "BP_FinCicloGU16"
        Me.BP_FinCicloGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU16.PLCAddressClick = "BP_FIN_CICLO_GA9"
        Me.BP_FinCicloGU16.SelectTextAlternate = False
        Me.BP_FinCicloGU16.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU16.TabIndex = 740
        Me.BP_FinCicloGU16.Text = "Detener Ciclo"
        Me.BP_FinCicloGU16.TextAlternate = Nothing
        Me.BP_FinCicloGU16.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU16.ValueToWrite = 0
        '
        'BP_IniCicloGU16
        '
        Me.BP_IniCicloGU16.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU16.ComComponent = Me.Guardiola16
        Me.BP_IniCicloGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU16.Highlight = False
        Me.BP_IniCicloGU16.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU16.Location = New System.Drawing.Point(508, 212)
        Me.BP_IniCicloGU16.MaximumHoldTime = 3000
        Me.BP_IniCicloGU16.MinimumHoldTime = 500
        Me.BP_IniCicloGU16.Name = "BP_IniCicloGU16"
        Me.BP_IniCicloGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU16.PLCAddressClick = "BP_ARRANQUE_G9"
        Me.BP_IniCicloGU16.SelectTextAlternate = False
        Me.BP_IniCicloGU16.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU16.TabIndex = 739
        Me.BP_IniCicloGU16.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU16.TextAlternate = Nothing
        Me.BP_IniCicloGU16.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU16.ValueToWrite = 0
        '
        'BCF_RegresarGU16
        '
        Me.BCF_RegresarGU16.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU16.ComComponent = Nothing
        Me.BCF_RegresarGU16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU16.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU16.FormToOpen = Nothing
        Me.BCF_RegresarGU16.KeypadWidth = 300
        Me.BCF_RegresarGU16.Location = New System.Drawing.Point(645, 99)
        Me.BCF_RegresarGU16.Name = "BCF_RegresarGU16"
        Me.BCF_RegresarGU16.Passcode = Nothing
        Me.BCF_RegresarGU16.PasswordChar = False
        Me.BCF_RegresarGU16.PLCAddressVisible = ""
        Me.BCF_RegresarGU16.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU16.TabIndex = 738
        Me.BCF_RegresarGU16.Text = "Regresar"
        Me.BCF_RegresarGU16.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU16
        '
        Me.BP_DescargaGU16.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU16.ComComponent = Me.Guardiola16
        Me.BP_DescargaGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU16.Highlight = False
        Me.BP_DescargaGU16.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU16.Location = New System.Drawing.Point(960, 122)
        Me.BP_DescargaGU16.MaximumHoldTime = 3000
        Me.BP_DescargaGU16.MinimumHoldTime = 500
        Me.BP_DescargaGU16.Name = "BP_DescargaGU16"
        Me.BP_DescargaGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU16.PLCAddressClick = "BP_DESCARGAR_GA9"
        Me.BP_DescargaGU16.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA9"
        Me.BP_DescargaGU16.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA9"
        Me.BP_DescargaGU16.SelectTextAlternate = False
        Me.BP_DescargaGU16.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU16.TabIndex = 737
        Me.BP_DescargaGU16.Text = "Finalizar"
        Me.BP_DescargaGU16.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU16.UseVisualStyleBackColor = True
        Me.BP_DescargaGU16.ValueToWrite = 0
        '
        'BP_CofirDescagaGU16
        '
        Me.BP_CofirDescagaGU16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU16.ComComponent = Me.Guardiola16
        Me.BP_CofirDescagaGU16.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU16.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU16.Highlight = False
        Me.BP_CofirDescagaGU16.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU16.Location = New System.Drawing.Point(960, 63)
        Me.BP_CofirDescagaGU16.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU16.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU16.Name = "BP_CofirDescagaGU16"
        Me.BP_CofirDescagaGU16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU16.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA9"
        Me.BP_CofirDescagaGU16.PLCAddressVisible = "CONFIMAR_DESCARGA_GA9"
        Me.BP_CofirDescagaGU16.SelectTextAlternate = False
        Me.BP_CofirDescagaGU16.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU16.TabIndex = 736
        Me.BP_CofirDescagaGU16.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU16.TextAlternate = Nothing
        Me.BP_CofirDescagaGU16.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU16.ValueToWrite = 0
        '
        'BN_SalidaGU16
        '
        Me.BN_SalidaGU16.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU16.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU16.ComComponent = Me.Guardiola16
        Me.BN_SalidaGU16.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU16.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU16.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU16.Location = New System.Drawing.Point(357, 155)
        Me.BN_SalidaGU16.Maximum = 100.0R
        Me.BN_SalidaGU16.Minimum = 0R
        Me.BN_SalidaGU16.Name = "BN_SalidaGU16"
        Me.BN_SalidaGU16.NumericFormat = Nothing
        Me.BN_SalidaGU16.PLCAddressValue = "PID_GUARDIOLA9.OUT"
        Me.BN_SalidaGU16.ShowValue = True
        Me.BN_SalidaGU16.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU16.TabIndex = 735
        Me.BN_SalidaGU16.Text = "BarLevel3"
        Me.BN_SalidaGU16.TextSuffix = Nothing
        Me.BN_SalidaGU16.Value = 0R
        Me.BN_SalidaGU16.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU16
        '
        Me.BN_SP_TempGU16.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU16.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU16.ComComponent = Me.Guardiola16
        Me.BN_SP_TempGU16.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU16.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU16.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU16.Location = New System.Drawing.Point(215, 156)
        Me.BN_SP_TempGU16.Maximum = 100.0R
        Me.BN_SP_TempGU16.Minimum = 0R
        Me.BN_SP_TempGU16.Name = "BN_SP_TempGU16"
        Me.BN_SP_TempGU16.NumericFormat = Nothing
        Me.BN_SP_TempGU16.PLCAddressValue = "PID_GUARDIOLA9.SP"
        Me.BN_SP_TempGU16.ShowValue = True
        Me.BN_SP_TempGU16.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU16.TabIndex = 734
        Me.BN_SP_TempGU16.Text = "BarLevel1"
        Me.BN_SP_TempGU16.TextSuffix = Nothing
        Me.BN_SP_TempGU16.Value = 0R
        Me.BN_SP_TempGU16.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU16
        '
        Me.MD_OrdenTrabajoGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU16.ComComponent = Me.Guardiola16
        Me.MD_OrdenTrabajoGU16.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU16.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU16.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU16.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU16.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU16.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU16.Location = New System.Drawing.Point(988, 506)
        Me.MD_OrdenTrabajoGU16.Name = "MD_OrdenTrabajoGU16"
        Me.MD_OrdenTrabajoGU16.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU16.PLCAddressKeypad = "ORDEN_DE_CARGA_GA09"
        Me.MD_OrdenTrabajoGU16.PLCAddressValue = "ORDEN_DE_CARGA_GA09"
        Me.MD_OrdenTrabajoGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU16.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU16.TabIndex = 733
        Me.MD_OrdenTrabajoGU16.Value = 0R
        Me.MD_OrdenTrabajoGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU16
        '
        Me.MD_CosechaGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU16.ComComponent = Me.Guardiola16
        Me.MD_CosechaGU16.DecimalPosition = 0
        Me.MD_CosechaGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU16.KeypadMaxValue = 0R
        Me.MD_CosechaGU16.KeypadMinValue = 0R
        Me.MD_CosechaGU16.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU16.KeypadText = Nothing
        Me.MD_CosechaGU16.KeypadWidth = 300
        Me.MD_CosechaGU16.Location = New System.Drawing.Point(988, 409)
        Me.MD_CosechaGU16.Name = "MD_CosechaGU16"
        Me.MD_CosechaGU16.NumberOfDigits = 5
        Me.MD_CosechaGU16.PLCAddressKeypad = "GA09_LOTE_NUMERO"
        Me.MD_CosechaGU16.PLCAddressValue = "GA09_LOTE_NUMERO"
        Me.MD_CosechaGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU16.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU16.TabIndex = 732
        Me.MD_CosechaGU16.Value = 0R
        Me.MD_CosechaGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU16
        '
        Me.MD_HorasEstimadasGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU16.ComComponent = Me.Guardiola16
        Me.MD_HorasEstimadasGU16.DecimalPosition = 0
        Me.MD_HorasEstimadasGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU16.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU16.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU16.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU16.KeypadText = Nothing
        Me.MD_HorasEstimadasGU16.KeypadWidth = 300
        Me.MD_HorasEstimadasGU16.Location = New System.Drawing.Point(988, 316)
        Me.MD_HorasEstimadasGU16.Name = "MD_HorasEstimadasGU16"
        Me.MD_HorasEstimadasGU16.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU16.PLCAddressKeypad = "TIEMPO_SECADO_H_GA9"
        Me.MD_HorasEstimadasGU16.PLCAddressValue = "TIEMPO_SECADO_H_GA9"
        Me.MD_HorasEstimadasGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU16.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU16.TabIndex = 731
        Me.MD_HorasEstimadasGU16.Value = 0R
        Me.MD_HorasEstimadasGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU16
        '
        Me.MD_CicloGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU16.ComComponent = Me.Guardiola16
        Me.MD_CicloGU16.DecimalPosition = 0
        Me.MD_CicloGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU16.KeypadMaxValue = 0R
        Me.MD_CicloGU16.KeypadMinValue = 0R
        Me.MD_CicloGU16.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU16.KeypadText = Nothing
        Me.MD_CicloGU16.KeypadWidth = 300
        Me.MD_CicloGU16.Location = New System.Drawing.Point(988, 224)
        Me.MD_CicloGU16.Name = "MD_CicloGU16"
        Me.MD_CicloGU16.NumberOfDigits = 5
        Me.MD_CicloGU16.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA09"
        Me.MD_CicloGU16.PLCAddressValue = "NUMERO_CICLO_SECADO_GA09"
        Me.MD_CicloGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU16.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU16.TabIndex = 730
        Me.MD_CicloGU16.Value = 0R
        Me.MD_CicloGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU16
        '
        Me.TexCicloGU16.AutoSize = True
        Me.TexCicloGU16.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU16.ComComponent = Me.Guardiola16
        Me.TexCicloGU16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU16.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU16.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU16.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU16.HighlightKeyCharacter = "!"
        Me.TexCicloGU16.HighlightKeyCharacter2 = "."
        Me.TexCicloGU16.IniFileName = Nothing
        Me.TexCicloGU16.Location = New System.Drawing.Point(575, 520)
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Messages.Add(CType(resources.GetObject("TexCicloGU16.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU16.Name = "TexCicloGU16"
        Me.TexCicloGU16.PLCAddressValue = "NUMERO_CICLO_SECADO_GA07"
        Me.TexCicloGU16.PLCAddressVisible = ""
        Me.TexCicloGU16.ShowMessageNumber = False
        Me.TexCicloGU16.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU16.SpeakMessage = False
        Me.TexCicloGU16.TabIndex = 743
        Me.TexCicloGU16.Text = "No Seleccionado"
        Me.TexCicloGU16.TextPrefix = Nothing
        Me.TexCicloGU16.Value = 0
        '
        'MD_TempGU16
        '
        Me.MD_TempGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU16.ComComponent = Me.Guardiola16
        Me.MD_TempGU16.DecimalPosition = 1
        Me.MD_TempGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU16.KeypadMaxValue = 0R
        Me.MD_TempGU16.KeypadMinValue = 0R
        Me.MD_TempGU16.KeypadScaleFactor = 1.0R
        Me.MD_TempGU16.KeypadText = Nothing
        Me.MD_TempGU16.KeypadWidth = 300
        Me.MD_TempGU16.Location = New System.Drawing.Point(604, 334)
        Me.MD_TempGU16.Name = "MD_TempGU16"
        Me.MD_TempGU16.NumberOfDigits = 5
        Me.MD_TempGU16.PLCAddressKeypad = ""
        Me.MD_TempGU16.PLCAddressValue = "PID_GUARDIOLA9.PV"
        Me.MD_TempGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU16.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU16.TabIndex = 729
        Me.MD_TempGU16.Value = 0R
        Me.MD_TempGU16.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU16
        '
        Me.MD_HorasProcesoGU16.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU16.ComComponent = Me.Guardiola16
        Me.MD_HorasProcesoGU16.DecimalPosition = 0
        Me.MD_HorasProcesoGU16.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU16.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU16.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU16.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU16.KeypadText = Nothing
        Me.MD_HorasProcesoGU16.KeypadWidth = 300
        Me.MD_HorasProcesoGU16.Location = New System.Drawing.Point(465, 82)
        Me.MD_HorasProcesoGU16.Name = "MD_HorasProcesoGU16"
        Me.MD_HorasProcesoGU16.NumberOfDigits = 5
        Me.MD_HorasProcesoGU16.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU16.PLCAddressValue = "SECADO_G9_MONITOR"
        Me.MD_HorasProcesoGU16.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU16.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU16.TabIndex = 728
        Me.MD_HorasProcesoGU16.Value = 0R
        Me.MD_HorasProcesoGU16.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU16.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU16
        '
        Me.Tex_CicloGU16.AutoSize = True
        Me.Tex_CicloGU16.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU16.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU16.Location = New System.Drawing.Point(975, 202)
        Me.Tex_CicloGU16.Name = "Tex_CicloGU16"
        Me.Tex_CicloGU16.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU16.TabIndex = 727
        Me.Tex_CicloGU16.Text = "Numero de Ciclo"
        Me.Tex_CicloGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU16
        '
        Me.Tex_OrdenTrabajoGU16.AutoSize = True
        Me.Tex_OrdenTrabajoGU16.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU16.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU16.Location = New System.Drawing.Point(1028, 481)
        Me.Tex_OrdenTrabajoGU16.Name = "Tex_OrdenTrabajoGU16"
        Me.Tex_OrdenTrabajoGU16.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU16.TabIndex = 726
        Me.Tex_OrdenTrabajoGU16.Text = "OT"
        Me.Tex_OrdenTrabajoGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU16
        '
        Me.Tex_CosechaGU16.AutoSize = True
        Me.Tex_CosechaGU16.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU16.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU16.Location = New System.Drawing.Point(996, 384)
        Me.Tex_CosechaGU16.Name = "Tex_CosechaGU16"
        Me.Tex_CosechaGU16.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU16.TabIndex = 725
        Me.Tex_CosechaGU16.Text = "Cosecha"
        Me.Tex_CosechaGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU16
        '
        Me.Tex_HorasEstimadasGU16.AutoSize = True
        Me.Tex_HorasEstimadasGU16.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU16.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU16.Location = New System.Drawing.Point(928, 294)
        Me.Tex_HorasEstimadasGU16.Name = "Tex_HorasEstimadasGU16"
        Me.Tex_HorasEstimadasGU16.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU16.TabIndex = 724
        Me.Tex_HorasEstimadasGU16.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU16
        '
        Me.Tex_HorasProcesoGU16.AutoSize = True
        Me.Tex_HorasProcesoGU16.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU16.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU16.Location = New System.Drawing.Point(449, 53)
        Me.Tex_HorasProcesoGU16.Name = "Tex_HorasProcesoGU16"
        Me.Tex_HorasProcesoGU16.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU16.TabIndex = 723
        Me.Tex_HorasProcesoGU16.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola16
        '
        Me.TexGuardiola16.AutoSize = True
        Me.TexGuardiola16.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola16.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola16.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola16.Location = New System.Drawing.Point(678, 54)
        Me.TexGuardiola16.Name = "TexGuardiola16"
        Me.TexGuardiola16.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola16.TabIndex = 722
        Me.TexGuardiola16.Text = "Guardiola 16"
        '
        'TexTempGU16
        '
        Me.TexTempGU16.AutoSize = True
        Me.TexTempGU16.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU16.Location = New System.Drawing.Point(601, 313)
        Me.TexTempGU16.Name = "TexTempGU16"
        Me.TexTempGU16.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU16.TabIndex = 721
        Me.TexTempGU16.Text = "Temperatura °C"
        Me.TexTempGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU16
        '
        Me.TexPID_GU16.AutoSize = True
        Me.TexPID_GU16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU16.Location = New System.Drawing.Point(205, 73)
        Me.TexPID_GU16.Name = "TexPID_GU16"
        Me.TexPID_GU16.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU16.TabIndex = 720
        Me.TexPID_GU16.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU16
        '
        Me.TexBN_SalidaGU16.AutoSize = True
        Me.TexBN_SalidaGU16.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU16.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU16.Location = New System.Drawing.Point(350, 134)
        Me.TexBN_SalidaGU16.Name = "TexBN_SalidaGU16"
        Me.TexBN_SalidaGU16.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU16.TabIndex = 719
        Me.TexBN_SalidaGU16.Text = "Salida"
        Me.TexBN_SalidaGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU16
        '
        Me.TexBN_RealTempGU16.AutoSize = True
        Me.TexBN_RealTempGU16.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU16.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU16.Location = New System.Drawing.Point(285, 135)
        Me.TexBN_RealTempGU16.Name = "TexBN_RealTempGU16"
        Me.TexBN_RealTempGU16.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU16.TabIndex = 718
        Me.TexBN_RealTempGU16.Text = "Real"
        Me.TexBN_RealTempGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU16
        '
        Me.TexBN_SP_TempGU16.AutoSize = True
        Me.TexBN_SP_TempGU16.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU16.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU16.Location = New System.Drawing.Point(201, 135)
        Me.TexBN_SP_TempGU16.Name = "TexBN_SP_TempGU16"
        Me.TexBN_SP_TempGU16.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU16.TabIndex = 717
        Me.TexBN_SP_TempGU16.Text = "SetPoint"
        Me.TexBN_SP_TempGU16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU16
        '
        Me.IGU16.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU16.Location = New System.Drawing.Point(440, 307)
        Me.IGU16.Name = "IGU16"
        Me.IGU16.Size = New System.Drawing.Size(541, 274)
        Me.IGU16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU16.TabIndex = 744
        Me.IGU16.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola16
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 51)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 746
        '
        'Guardiola_16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU16)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU16)
        Me.Controls.Add(Me.BCF_MenúP_GU16)
        Me.Controls.Add(Me.BP_FinCicloGU16)
        Me.Controls.Add(Me.BP_IniCicloGU16)
        Me.Controls.Add(Me.BCF_RegresarGU16)
        Me.Controls.Add(Me.BP_DescargaGU16)
        Me.Controls.Add(Me.BP_CofirDescagaGU16)
        Me.Controls.Add(Me.BN_SalidaGU16)
        Me.Controls.Add(Me.BN_SP_TempGU16)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU16)
        Me.Controls.Add(Me.MD_CosechaGU16)
        Me.Controls.Add(Me.MD_HorasEstimadasGU16)
        Me.Controls.Add(Me.MD_CicloGU16)
        Me.Controls.Add(Me.TexCicloGU16)
        Me.Controls.Add(Me.MD_TempGU16)
        Me.Controls.Add(Me.MD_HorasProcesoGU16)
        Me.Controls.Add(Me.Tex_CicloGU16)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU16)
        Me.Controls.Add(Me.Tex_CosechaGU16)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU16)
        Me.Controls.Add(Me.Tex_HorasProcesoGU16)
        Me.Controls.Add(Me.TexGuardiola16)
        Me.Controls.Add(Me.TexTempGU16)
        Me.Controls.Add(Me.TexPID_GU16)
        Me.Controls.Add(Me.TexBN_SalidaGU16)
        Me.Controls.Add(Me.TexBN_RealTempGU16)
        Me.Controls.Add(Me.TexBN_SP_TempGU16)
        Me.Controls.Add(Me.IGU16)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_16"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU16 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola16 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU16 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU16 As FormChangeButton
    Friend WithEvents BP_FinCicloGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU16 As FormChangeButton
    Friend WithEvents BP_DescargaGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU16 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU16 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU16 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU16 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU16 As Label
    Friend WithEvents Tex_OrdenTrabajoGU16 As Label
    Friend WithEvents Tex_CosechaGU16 As Label
    Friend WithEvents Tex_HorasEstimadasGU16 As Label
    Friend WithEvents Tex_HorasProcesoGU16 As Label
    Friend WithEvents TexGuardiola16 As Label
    Friend WithEvents TexTempGU16 As Label
    Friend WithEvents TexPID_GU16 As Label
    Friend WithEvents TexBN_SalidaGU16 As Label
    Friend WithEvents TexBN_RealTempGU16 As Label
    Friend WithEvents TexBN_SP_TempGU16 As Label
    Friend WithEvents IGU16 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
