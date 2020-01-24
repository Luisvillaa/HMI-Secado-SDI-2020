<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guardiola_09
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guardiola_09))
        Me.CT_SGU09 = New AdvancedHMIControls.TempController()
        Me.Guardiola09 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.LS_MarchaGU09 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU02 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU09 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU09 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU09 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU09 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU09 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU09 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU09 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CosechaGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CicloGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexCicloGU09 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MD_TempGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU09 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_CicloGU09 = New System.Windows.Forms.Label()
        Me.Tex_OrdenTrabajoGU09 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU02 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU09 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU09 = New System.Windows.Forms.Label()
        Me.TexGuardiola9 = New System.Windows.Forms.Label()
        Me.TexTempGU09 = New System.Windows.Forms.Label()
        Me.TexPID_GU09 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU09 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU09 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU09 = New System.Windows.Forms.Label()
        Me.IGU09 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.Guardiola09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU09, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_SGU09
        '
        Me.CT_SGU09.Button1Text = Nothing
        Me.CT_SGU09.Button2Text = Nothing
        Me.CT_SGU09.ComComponent = Me.Guardiola09
        Me.CT_SGU09.DecimalPosition = 1
        Me.CT_SGU09.ForeColor = System.Drawing.Color.LightGray
        Me.CT_SGU09.Location = New System.Drawing.Point(203, 429)
        Me.CT_SGU09.Name = "CT_SGU09"
        Me.CT_SGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_SGU09.PLCAddressClick1 = ""
        Me.CT_SGU09.PLCAddressClick2 = ""
        Me.CT_SGU09.PLCAddressClick3 = ""
        Me.CT_SGU09.PLCAddressClick4 = ""
        Me.CT_SGU09.PLCAddressText = ""
        Me.CT_SGU09.PLCAddressValuePV = "PID_GUARDIOLA2.PV"
        Me.CT_SGU09.PLCAddressValueSP = "PID_GUARDIOLA2.SP"
        Me.CT_SGU09.PLCAddressVisible = ""
        Me.CT_SGU09.ScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CT_SGU09.Size = New System.Drawing.Size(200, 201)
        Me.CT_SGU09.TabIndex = 677
        Me.CT_SGU09.Text = "S-GU-09"
        Me.CT_SGU09.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU09.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_SGU09.Value2Text = "SP"
        Me.CT_SGU09.ValuePV = 0!
        Me.CT_SGU09.ValueSP = 0!
        '
        'Guardiola09
        '
        Me.Guardiola09.CIPConnectionSize = 508
        Me.Guardiola09.DisableMultiServiceRequest = False
        Me.Guardiola09.DisableSubscriptions = False
        Me.Guardiola09.IniFileName = ""
        Me.Guardiola09.IniFileSection = Nothing
        Me.Guardiola09.IPAddress = "10.1.108.20"
        Me.Guardiola09.PollRateOverride = 500
        Me.Guardiola09.Port = 44818
        Me.Guardiola09.ProcessorSlot = 0
        Me.Guardiola09.RoutePath = Nothing
        Me.Guardiola09.Timeout = 4000
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 70.0R
        Me.BarMeter1.BarHighWarningSetPoint = 60.0R
        Me.BarMeter1.BarLowSetPoint = 25.0R
        Me.BarMeter1.ComComponent = Me.Guardiola09
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
        Me.BasicButton1.ComComponent = Me.Guardiola09
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(962, 586)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "DATOS_INGRESADOS_ARRANQUE_GA02"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 675
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'LS_MarchaGU09
        '
        Me.LS_MarchaGU09.Blink = False
        Me.LS_MarchaGU09.ComComponent = Me.Guardiola09
        Me.LS_MarchaGU09.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU09.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU09.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU09.Location = New System.Drawing.Point(854, 314)
        Me.LS_MarchaGU09.Name = "LS_MarchaGU09"
        Me.LS_MarchaGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU09.PLCAddressClick = ""
        Me.LS_MarchaGU09.PLCAddressText = ""
        Me.LS_MarchaGU09.PLCAddressValue = "MARCHA_GU09"
        Me.LS_MarchaGU09.PLCAddressVisible = ""
        Me.LS_MarchaGU09.Size = New System.Drawing.Size(55, 58)
        Me.LS_MarchaGU09.TabIndex = 672
        Me.LS_MarchaGU09.Value = False
        Me.LS_MarchaGU09.ValueToWrite = 0
        '
        'BCF_MenúP_GU02
        '
        Me.BCF_MenúP_GU02.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU02.ComComponent = Nothing
        Me.BCF_MenúP_GU02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU02.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU02.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU02.KeypadWidth = 300
        Me.BCF_MenúP_GU02.Location = New System.Drawing.Point(224, 650)
        Me.BCF_MenúP_GU02.Name = "BCF_MenúP_GU02"
        Me.BCF_MenúP_GU02.Passcode = Nothing
        Me.BCF_MenúP_GU02.PasswordChar = False
        Me.BCF_MenúP_GU02.PLCAddressVisible = ""
        Me.BCF_MenúP_GU02.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU02.TabIndex = 671
        Me.BCF_MenúP_GU02.Text = "Menú Principal"
        Me.BCF_MenúP_GU02.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU09
        '
        Me.BP_FinCicloGU09.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU09.ComComponent = Me.Guardiola09
        Me.BP_FinCicloGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU09.Highlight = False
        Me.BP_FinCicloGU09.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU09.Location = New System.Drawing.Point(712, 219)
        Me.BP_FinCicloGU09.MaximumHoldTime = 3000
        Me.BP_FinCicloGU09.MinimumHoldTime = 500
        Me.BP_FinCicloGU09.Name = "BP_FinCicloGU09"
        Me.BP_FinCicloGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU09.PLCAddressClick = "BP_FIN_CICLO_GA2"
        Me.BP_FinCicloGU09.SelectTextAlternate = False
        Me.BP_FinCicloGU09.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU09.TabIndex = 670
        Me.BP_FinCicloGU09.Text = "Detener Ciclo"
        Me.BP_FinCicloGU09.TextAlternate = Nothing
        Me.BP_FinCicloGU09.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU09.ValueToWrite = 0
        '
        'BP_IniCicloGU09
        '
        Me.BP_IniCicloGU09.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU09.ComComponent = Me.Guardiola09
        Me.BP_IniCicloGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU09.Highlight = False
        Me.BP_IniCicloGU09.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU09.Location = New System.Drawing.Point(510, 219)
        Me.BP_IniCicloGU09.MaximumHoldTime = 3000
        Me.BP_IniCicloGU09.MinimumHoldTime = 500
        Me.BP_IniCicloGU09.Name = "BP_IniCicloGU09"
        Me.BP_IniCicloGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_IniCicloGU09.PLCAddressClick = "BP_ARRANQUE_G2"
        Me.BP_IniCicloGU09.SelectTextAlternate = False
        Me.BP_IniCicloGU09.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU09.TabIndex = 669
        Me.BP_IniCicloGU09.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU09.TextAlternate = Nothing
        Me.BP_IniCicloGU09.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU09.ValueToWrite = 0
        '
        'BCF_RegresarGU09
        '
        Me.BCF_RegresarGU09.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU09.ComComponent = Nothing
        Me.BCF_RegresarGU09.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU09.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU09.FormToOpen = Nothing
        Me.BCF_RegresarGU09.KeypadWidth = 300
        Me.BCF_RegresarGU09.Location = New System.Drawing.Point(647, 97)
        Me.BCF_RegresarGU09.Name = "BCF_RegresarGU09"
        Me.BCF_RegresarGU09.Passcode = Nothing
        Me.BCF_RegresarGU09.PasswordChar = False
        Me.BCF_RegresarGU09.PLCAddressVisible = ""
        Me.BCF_RegresarGU09.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU09.TabIndex = 668
        Me.BCF_RegresarGU09.Text = "Regresar"
        Me.BCF_RegresarGU09.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU09
        '
        Me.BP_DescargaGU09.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU09.ComComponent = Me.Guardiola09
        Me.BP_DescargaGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU09.Highlight = False
        Me.BP_DescargaGU09.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU09.Location = New System.Drawing.Point(962, 120)
        Me.BP_DescargaGU09.MaximumHoldTime = 3000
        Me.BP_DescargaGU09.MinimumHoldTime = 500
        Me.BP_DescargaGU09.Name = "BP_DescargaGU09"
        Me.BP_DescargaGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BP_DescargaGU09.PLCAddressClick = "BP_DESCARGAR_GA2"
        Me.BP_DescargaGU09.PLCAddressHighlightX = "CONFIMAR_DESCARGA_GA2"
        Me.BP_DescargaGU09.PLCAddressSelectTextAlternate = "CONFIMAR_DESCARGA_GA2"
        Me.BP_DescargaGU09.SelectTextAlternate = False
        Me.BP_DescargaGU09.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU09.TabIndex = 667
        Me.BP_DescargaGU09.Text = "Finalizar"
        Me.BP_DescargaGU09.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU09.UseVisualStyleBackColor = True
        Me.BP_DescargaGU09.ValueToWrite = 0
        '
        'BP_CofirDescagaGU09
        '
        Me.BP_CofirDescagaGU09.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU09.ComComponent = Me.Guardiola09
        Me.BP_CofirDescagaGU09.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU09.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU09.Highlight = False
        Me.BP_CofirDescagaGU09.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU09.Location = New System.Drawing.Point(962, 61)
        Me.BP_CofirDescagaGU09.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU09.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU09.Name = "BP_CofirDescagaGU09"
        Me.BP_CofirDescagaGU09.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU09.PLCAddressClick = "BP_CONFIMAR_DESCARGA_GA2"
        Me.BP_CofirDescagaGU09.PLCAddressVisible = "CONFIMAR_DESCARGA_GA2"
        Me.BP_CofirDescagaGU09.SelectTextAlternate = False
        Me.BP_CofirDescagaGU09.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU09.TabIndex = 666
        Me.BP_CofirDescagaGU09.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU09.TextAlternate = Nothing
        Me.BP_CofirDescagaGU09.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU09.ValueToWrite = 0
        '
        'BN_SalidaGU09
        '
        Me.BN_SalidaGU09.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU09.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU09.ComComponent = Me.Guardiola09
        Me.BN_SalidaGU09.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU09.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU09.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU09.HighlightColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU09.Location = New System.Drawing.Point(359, 153)
        Me.BN_SalidaGU09.Maximum = 100.0R
        Me.BN_SalidaGU09.Minimum = 0R
        Me.BN_SalidaGU09.Name = "BN_SalidaGU09"
        Me.BN_SalidaGU09.NumericFormat = Nothing
        Me.BN_SalidaGU09.PLCAddressValue = "PID_GUARDIOLA2.OUT"
        Me.BN_SalidaGU09.ShowValue = True
        Me.BN_SalidaGU09.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU09.TabIndex = 665
        Me.BN_SalidaGU09.Text = "BarLevel3"
        Me.BN_SalidaGU09.TextSuffix = Nothing
        Me.BN_SalidaGU09.Value = 0R
        Me.BN_SalidaGU09.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU09
        '
        Me.BN_SP_TempGU09.BarContentColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU09.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU09.ComComponent = Me.Guardiola09
        Me.BN_SP_TempGU09.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU09.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU09.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU09.HighlightColor = System.Drawing.Color.Yellow
        Me.BN_SP_TempGU09.Location = New System.Drawing.Point(217, 154)
        Me.BN_SP_TempGU09.Maximum = 100.0R
        Me.BN_SP_TempGU09.Minimum = 0R
        Me.BN_SP_TempGU09.Name = "BN_SP_TempGU09"
        Me.BN_SP_TempGU09.NumericFormat = Nothing
        Me.BN_SP_TempGU09.PLCAddressValue = "PID_GUARDIOLA2.SP"
        Me.BN_SP_TempGU09.ShowValue = True
        Me.BN_SP_TempGU09.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU09.TabIndex = 664
        Me.BN_SP_TempGU09.Text = "BarLevel1"
        Me.BN_SP_TempGU09.TextSuffix = Nothing
        Me.BN_SP_TempGU09.Value = 0R
        Me.BN_SP_TempGU09.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU09
        '
        Me.MD_OrdenTrabajoGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU09.ComComponent = Me.Guardiola09
        Me.MD_OrdenTrabajoGU09.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU09.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU09.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU09.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU09.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU09.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU09.Location = New System.Drawing.Point(990, 504)
        Me.MD_OrdenTrabajoGU09.Name = "MD_OrdenTrabajoGU09"
        Me.MD_OrdenTrabajoGU09.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU09.PLCAddressKeypad = "ORDEN_DE_CARGA_GA02"
        Me.MD_OrdenTrabajoGU09.PLCAddressValue = "ORDEN_DE_CARGA_GA02"
        Me.MD_OrdenTrabajoGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU09.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU09.TabIndex = 663
        Me.MD_OrdenTrabajoGU09.Value = 0R
        Me.MD_OrdenTrabajoGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CosechaGU09
        '
        Me.MD_CosechaGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU09.ComComponent = Me.Guardiola09
        Me.MD_CosechaGU09.DecimalPosition = 0
        Me.MD_CosechaGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU09.KeypadMaxValue = 0R
        Me.MD_CosechaGU09.KeypadMinValue = 0R
        Me.MD_CosechaGU09.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU09.KeypadText = Nothing
        Me.MD_CosechaGU09.KeypadWidth = 300
        Me.MD_CosechaGU09.Location = New System.Drawing.Point(990, 407)
        Me.MD_CosechaGU09.Name = "MD_CosechaGU09"
        Me.MD_CosechaGU09.NumberOfDigits = 5
        Me.MD_CosechaGU09.PLCAddressKeypad = "GA02_LOTE_NUMERO"
        Me.MD_CosechaGU09.PLCAddressValue = "GA02_LOTE_NUMERO"
        Me.MD_CosechaGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU09.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU09.TabIndex = 662
        Me.MD_CosechaGU09.Value = 0R
        Me.MD_CosechaGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU09
        '
        Me.MD_HorasEstimadasGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU09.ComComponent = Me.Guardiola09
        Me.MD_HorasEstimadasGU09.DecimalPosition = 0
        Me.MD_HorasEstimadasGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU09.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU09.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU09.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU09.KeypadText = Nothing
        Me.MD_HorasEstimadasGU09.KeypadWidth = 300
        Me.MD_HorasEstimadasGU09.Location = New System.Drawing.Point(990, 314)
        Me.MD_HorasEstimadasGU09.Name = "MD_HorasEstimadasGU09"
        Me.MD_HorasEstimadasGU09.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU09.PLCAddressKeypad = "TIEMPO_SECADO_H_GA2"
        Me.MD_HorasEstimadasGU09.PLCAddressValue = "TIEMPO_SECADO_H_GA2"
        Me.MD_HorasEstimadasGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU09.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU09.TabIndex = 661
        Me.MD_HorasEstimadasGU09.Value = 0R
        Me.MD_HorasEstimadasGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CicloGU09
        '
        Me.MD_CicloGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_CicloGU09.ComComponent = Me.Guardiola09
        Me.MD_CicloGU09.DecimalPosition = 0
        Me.MD_CicloGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CicloGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CicloGU09.KeypadMaxValue = 0R
        Me.MD_CicloGU09.KeypadMinValue = 0R
        Me.MD_CicloGU09.KeypadScaleFactor = 1.0R
        Me.MD_CicloGU09.KeypadText = Nothing
        Me.MD_CicloGU09.KeypadWidth = 300
        Me.MD_CicloGU09.Location = New System.Drawing.Point(990, 222)
        Me.MD_CicloGU09.Name = "MD_CicloGU09"
        Me.MD_CicloGU09.NumberOfDigits = 5
        Me.MD_CicloGU09.PLCAddressKeypad = "NUMERO_CICLO_SECADO_GA02"
        Me.MD_CicloGU09.PLCAddressValue = "NUMERO_CICLO_SECADO_GA02"
        Me.MD_CicloGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU09.Size = New System.Drawing.Size(113, 49)
        Me.MD_CicloGU09.TabIndex = 660
        Me.MD_CicloGU09.Value = 0R
        Me.MD_CicloGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CicloGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexCicloGU09
        '
        Me.TexCicloGU09.AutoSize = True
        Me.TexCicloGU09.BackColor = System.Drawing.Color.Transparent
        Me.TexCicloGU09.ComComponent = Me.Guardiola09
        Me.TexCicloGU09.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCicloGU09.ForeColor = System.Drawing.Color.Black
        Me.TexCicloGU09.HighlightColor = System.Drawing.Color.Red
        Me.TexCicloGU09.HighlightColor2 = System.Drawing.Color.Red
        Me.TexCicloGU09.HighlightKeyCharacter = "!"
        Me.TexCicloGU09.HighlightKeyCharacter2 = "."
        Me.TexCicloGU09.IniFileName = Nothing
        Me.TexCicloGU09.Location = New System.Drawing.Point(580, 518)
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Messages.Add(CType(resources.GetObject("TexCicloGU09.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexCicloGU09.Name = "TexCicloGU09"
        Me.TexCicloGU09.PLCAddressValue = "NUMERO_CICLO_SECADO_GA02"
        Me.TexCicloGU09.PLCAddressVisible = ""
        Me.TexCicloGU09.ShowMessageNumber = False
        Me.TexCicloGU09.Size = New System.Drawing.Size(166, 22)
        Me.TexCicloGU09.SpeakMessage = False
        Me.TexCicloGU09.TabIndex = 673
        Me.TexCicloGU09.Text = "No Seleccionado"
        Me.TexCicloGU09.TextPrefix = Nothing
        Me.TexCicloGU09.Value = 0
        '
        'MD_TempGU09
        '
        Me.MD_TempGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU09.ComComponent = Me.Guardiola09
        Me.MD_TempGU09.DecimalPosition = 1
        Me.MD_TempGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU09.KeypadMaxValue = 0R
        Me.MD_TempGU09.KeypadMinValue = 0R
        Me.MD_TempGU09.KeypadScaleFactor = 1.0R
        Me.MD_TempGU09.KeypadText = Nothing
        Me.MD_TempGU09.KeypadWidth = 300
        Me.MD_TempGU09.Location = New System.Drawing.Point(606, 335)
        Me.MD_TempGU09.Name = "MD_TempGU09"
        Me.MD_TempGU09.NumberOfDigits = 5
        Me.MD_TempGU09.PLCAddressKeypad = ""
        Me.MD_TempGU09.PLCAddressValue = "PID_GUARDIOLA2.PV"
        Me.MD_TempGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU09.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU09.TabIndex = 659
        Me.MD_TempGU09.Value = 0R
        Me.MD_TempGU09.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MD_TempGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU09
        '
        Me.MD_HorasProcesoGU09.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU09.ComComponent = Me.Guardiola09
        Me.MD_HorasProcesoGU09.DecimalPosition = 0
        Me.MD_HorasProcesoGU09.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU09.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU09.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU09.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU09.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU09.KeypadText = Nothing
        Me.MD_HorasProcesoGU09.KeypadWidth = 300
        Me.MD_HorasProcesoGU09.Location = New System.Drawing.Point(467, 80)
        Me.MD_HorasProcesoGU09.Name = "MD_HorasProcesoGU09"
        Me.MD_HorasProcesoGU09.NumberOfDigits = 5
        Me.MD_HorasProcesoGU09.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU09.PLCAddressValue = "SECADO_G2_MONITOR"
        Me.MD_HorasProcesoGU09.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU09.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU09.TabIndex = 658
        Me.MD_HorasProcesoGU09.Value = 0R
        Me.MD_HorasProcesoGU09.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU09.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_CicloGU09
        '
        Me.Tex_CicloGU09.AutoSize = True
        Me.Tex_CicloGU09.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CicloGU09.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CicloGU09.ForeColor = System.Drawing.Color.White
        Me.Tex_CicloGU09.Location = New System.Drawing.Point(977, 200)
        Me.Tex_CicloGU09.Name = "Tex_CicloGU09"
        Me.Tex_CicloGU09.Size = New System.Drawing.Size(136, 19)
        Me.Tex_CicloGU09.TabIndex = 657
        Me.Tex_CicloGU09.Text = "Numero de Ciclo"
        Me.Tex_CicloGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_OrdenTrabajoGU09
        '
        Me.Tex_OrdenTrabajoGU09.AutoSize = True
        Me.Tex_OrdenTrabajoGU09.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU09.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU09.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU09.Location = New System.Drawing.Point(1030, 479)
        Me.Tex_OrdenTrabajoGU09.Name = "Tex_OrdenTrabajoGU09"
        Me.Tex_OrdenTrabajoGU09.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU09.TabIndex = 656
        Me.Tex_OrdenTrabajoGU09.Text = "OT"
        Me.Tex_OrdenTrabajoGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU02
        '
        Me.Tex_CosechaGU02.AutoSize = True
        Me.Tex_CosechaGU02.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU02.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU02.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU02.Location = New System.Drawing.Point(998, 382)
        Me.Tex_CosechaGU02.Name = "Tex_CosechaGU02"
        Me.Tex_CosechaGU02.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU02.TabIndex = 655
        Me.Tex_CosechaGU02.Text = "Cosecha"
        Me.Tex_CosechaGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU09
        '
        Me.Tex_HorasEstimadasGU09.AutoSize = True
        Me.Tex_HorasEstimadasGU09.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU09.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU09.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU09.Location = New System.Drawing.Point(930, 292)
        Me.Tex_HorasEstimadasGU09.Name = "Tex_HorasEstimadasGU09"
        Me.Tex_HorasEstimadasGU09.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU09.TabIndex = 654
        Me.Tex_HorasEstimadasGU09.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU09
        '
        Me.Tex_HorasProcesoGU09.AutoSize = True
        Me.Tex_HorasProcesoGU09.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU09.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU09.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU09.Location = New System.Drawing.Point(451, 51)
        Me.Tex_HorasProcesoGU09.Name = "Tex_HorasProcesoGU09"
        Me.Tex_HorasProcesoGU09.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU09.TabIndex = 653
        Me.Tex_HorasProcesoGU09.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola9
        '
        Me.TexGuardiola9.AutoSize = True
        Me.TexGuardiola9.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola9.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola9.Location = New System.Drawing.Point(680, 52)
        Me.TexGuardiola9.Name = "TexGuardiola9"
        Me.TexGuardiola9.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola9.TabIndex = 652
        Me.TexGuardiola9.Text = "Guardiola 09"
        '
        'TexTempGU09
        '
        Me.TexTempGU09.AutoSize = True
        Me.TexTempGU09.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU09.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU09.Location = New System.Drawing.Point(603, 314)
        Me.TexTempGU09.Name = "TexTempGU09"
        Me.TexTempGU09.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU09.TabIndex = 651
        Me.TexTempGU09.Text = "Temperatura °C"
        Me.TexTempGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU09
        '
        Me.TexPID_GU09.AutoSize = True
        Me.TexPID_GU09.BackColor = System.Drawing.Color.Silver
        Me.TexPID_GU09.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU09.Location = New System.Drawing.Point(202, 71)
        Me.TexPID_GU09.Name = "TexPID_GU09"
        Me.TexPID_GU09.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU09.TabIndex = 650
        Me.TexPID_GU09.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU09
        '
        Me.TexBN_SalidaGU09.AutoSize = True
        Me.TexBN_SalidaGU09.BackColor = System.Drawing.Color.DimGray
        Me.TexBN_SalidaGU09.ForeColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU09.Location = New System.Drawing.Point(356, 132)
        Me.TexBN_SalidaGU09.Name = "TexBN_SalidaGU09"
        Me.TexBN_SalidaGU09.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU09.TabIndex = 649
        Me.TexBN_SalidaGU09.Text = "Salida"
        Me.TexBN_SalidaGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU09
        '
        Me.TexBN_RealTempGU09.AutoSize = True
        Me.TexBN_RealTempGU09.BackColor = System.Drawing.Color.DimGray
        Me.TexBN_RealTempGU09.ForeColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU09.Location = New System.Drawing.Point(289, 133)
        Me.TexBN_RealTempGU09.Name = "TexBN_RealTempGU09"
        Me.TexBN_RealTempGU09.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU09.TabIndex = 648
        Me.TexBN_RealTempGU09.Text = "Real"
        Me.TexBN_RealTempGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU09
        '
        Me.TexBN_SP_TempGU09.AutoSize = True
        Me.TexBN_SP_TempGU09.BackColor = System.Drawing.Color.DimGray
        Me.TexBN_SP_TempGU09.ForeColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU09.Location = New System.Drawing.Point(203, 133)
        Me.TexBN_SP_TempGU09.Name = "TexBN_SP_TempGU09"
        Me.TexBN_SP_TempGU09.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU09.TabIndex = 647
        Me.TexBN_SP_TempGU09.Text = "SetPoint"
        Me.TexBN_SP_TempGU09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU09
        '
        Me.IGU09.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Guardiola
        Me.IGU09.Location = New System.Drawing.Point(442, 306)
        Me.IGU09.Name = "IGU09"
        Me.IGU09.Size = New System.Drawing.Size(541, 274)
        Me.IGU09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU09.TabIndex = 674
        Me.IGU09.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.Guardiola09
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(189, 49)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 676
        '
        'Guardiola_09
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_SGU09)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.LS_MarchaGU09)
        Me.Controls.Add(Me.BCF_MenúP_GU02)
        Me.Controls.Add(Me.BP_FinCicloGU09)
        Me.Controls.Add(Me.BP_IniCicloGU09)
        Me.Controls.Add(Me.BCF_RegresarGU09)
        Me.Controls.Add(Me.BP_DescargaGU09)
        Me.Controls.Add(Me.BP_CofirDescagaGU09)
        Me.Controls.Add(Me.BN_SalidaGU09)
        Me.Controls.Add(Me.BN_SP_TempGU09)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU09)
        Me.Controls.Add(Me.MD_CosechaGU09)
        Me.Controls.Add(Me.MD_HorasEstimadasGU09)
        Me.Controls.Add(Me.MD_CicloGU09)
        Me.Controls.Add(Me.TexCicloGU09)
        Me.Controls.Add(Me.MD_TempGU09)
        Me.Controls.Add(Me.MD_HorasProcesoGU09)
        Me.Controls.Add(Me.Tex_CicloGU09)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU09)
        Me.Controls.Add(Me.Tex_CosechaGU02)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU09)
        Me.Controls.Add(Me.Tex_HorasProcesoGU09)
        Me.Controls.Add(Me.TexGuardiola9)
        Me.Controls.Add(Me.TexTempGU09)
        Me.Controls.Add(Me.TexPID_GU09)
        Me.Controls.Add(Me.TexBN_SalidaGU09)
        Me.Controls.Add(Me.TexBN_RealTempGU09)
        Me.Controls.Add(Me.TexBN_SP_TempGU09)
        Me.Controls.Add(Me.IGU09)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Guardiola_09"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guardiola09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU09, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_SGU09 As AdvancedHMIControls.TempController
    Friend WithEvents Guardiola09 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LS_MarchaGU09 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU02 As FormChangeButton
    Friend WithEvents BP_FinCicloGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU09 As FormChangeButton
    Friend WithEvents BP_DescargaGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU09 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU09 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU09 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CosechaGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CicloGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexCicloGU09 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MD_TempGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU09 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_CicloGU09 As Label
    Friend WithEvents Tex_OrdenTrabajoGU09 As Label
    Friend WithEvents Tex_CosechaGU02 As Label
    Friend WithEvents Tex_HorasEstimadasGU09 As Label
    Friend WithEvents Tex_HorasProcesoGU09 As Label
    Friend WithEvents TexGuardiola9 As Label
    Friend WithEvents TexTempGU09 As Label
    Friend WithEvents TexPID_GU09 As Label
    Friend WithEvents TexBN_SalidaGU09 As Label
    Friend WithEvents TexBN_RealTempGU09 As Label
    Friend WithEvents TexBN_SP_TempGU09 As Label
    Friend WithEvents IGU09 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
