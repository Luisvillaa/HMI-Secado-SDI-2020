<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Columnar_03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Columnar_03))
        Me.CT_PSC03 = New AdvancedHMIControls.TempController()
        Me.S_SC_03 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BarMeter1 = New AdvancedHMIControls.BarMeter()
        Me.BasicButton5 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton3 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.LS_MarchaGU02 = New AdvancedHMIControls.PilotLight()
        Me.BCF_MenúP_GU02 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_FinCicloGU01 = New AdvancedHMIControls.BasicButton()
        Me.BP_IniCicloGU02 = New AdvancedHMIControls.BasicButton()
        Me.BCF_RegresarGU02 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BP_DescargaGU02 = New AdvancedHMIControls.BasicButton()
        Me.BP_CofirDescagaGU02 = New AdvancedHMIControls.BasicButton()
        Me.BN_SalidaGU02 = New AdvancedHMIControls.BarLevel()
        Me.BN_SP_TempGU02 = New AdvancedHMIControls.BarLevel()
        Me.MD_OrdenTrabajoGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicButton4 = New AdvancedHMIControls.BasicButton()
        Me.MD_CosechaGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasEstimadasGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_HorasProcesoGU02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Tex_OrdenTrabajoGU02 = New System.Windows.Forms.Label()
        Me.Tex_CosechaGU02 = New System.Windows.Forms.Label()
        Me.Tex_HorasEstimadasGU02 = New System.Windows.Forms.Label()
        Me.Tex_HorasProcesoGU02 = New System.Windows.Forms.Label()
        Me.TexGuardiola2 = New System.Windows.Forms.Label()
        Me.TexTempGU02 = New System.Windows.Forms.Label()
        Me.TexPID_GU02 = New System.Windows.Forms.Label()
        Me.TexBN_SalidaGU02 = New System.Windows.Forms.Label()
        Me.TexBN_RealTempGU02 = New System.Windows.Forms.Label()
        Me.TexBN_SP_TempGU02 = New System.Windows.Forms.Label()
        Me.IGU01 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1 = New AdvancedHMIControls.GroupPanel()
        CType(Me.S_SC_03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGU01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CT_PSC03
        '
        Me.CT_PSC03.Button1Text = Nothing
        Me.CT_PSC03.Button2Text = Nothing
        Me.CT_PSC03.ComComponent = Me.S_SC_03
        Me.CT_PSC03.DecimalPosition = 1
        Me.CT_PSC03.ForeColor = System.Drawing.Color.LightGray
        Me.CT_PSC03.Location = New System.Drawing.Point(204, 423)
        Me.CT_PSC03.Name = "CT_PSC03"
        Me.CT_PSC03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CT_PSC03.PLCAddressClick1 = ""
        Me.CT_PSC03.PLCAddressClick2 = ""
        Me.CT_PSC03.PLCAddressClick3 = ""
        Me.CT_PSC03.PLCAddressClick4 = ""
        Me.CT_PSC03.PLCAddressText = ""
        Me.CT_PSC03.PLCAddressValuePV = "40149"
        Me.CT_PSC03.PLCAddressValueSP = "40152"
        Me.CT_PSC03.PLCAddressVisible = ""
        Me.CT_PSC03.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_PSC03.Size = New System.Drawing.Size(200, 201)
        Me.CT_PSC03.TabIndex = 543
        Me.CT_PSC03.Text = "P-SC-03"
        Me.CT_PSC03.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CT_PSC03.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.CT_PSC03.Value2Text = "SP"
        Me.CT_PSC03.ValuePV = 0!
        Me.CT_PSC03.ValueSP = 0!
        '
        'S_SC_03
        '
        Me.S_SC_03.DisableSubscriptions = False
        Me.S_SC_03.IniFileName = ""
        Me.S_SC_03.IniFileSection = Nothing
        Me.S_SC_03.IPAddress = "10.1.108.8"
        Me.S_SC_03.MaxReadGroupSize = 20
        Me.S_SC_03.PollRateOverride = 500
        Me.S_SC_03.SwapBytes = True
        Me.S_SC_03.SwapWords = False
        Me.S_SC_03.TcpipPort = CType(20257US, UShort)
        Me.S_SC_03.TimeOut = 3000
        Me.S_SC_03.UnitId = CType(13, Byte)
        '
        'BarMeter1
        '
        Me.BarMeter1.ArrowColor = System.Drawing.Color.Black
        Me.BarMeter1.ArrowWidth = 15
        Me.BarMeter1.BarHighAlarm_SetPoint = 750.0R
        Me.BarMeter1.BarHighWarningSetPoint = 600.0R
        Me.BarMeter1.BarLowSetPoint = 250.0R
        Me.BarMeter1.ComComponent = Me.S_SC_03
        Me.BarMeter1.HighlightColor = System.Drawing.Color.Red
        Me.BarMeter1.IniFileName = ""
        Me.BarMeter1.IniFileSection = Nothing
        Me.BarMeter1.Location = New System.Drawing.Point(95, 104)
        Me.BarMeter1.Maximum = 1000.0R
        Me.BarMeter1.Minimum = 0R
        Me.BarMeter1.Name = "BarMeter1"
        Me.BarMeter1.PLCAddressText = ""
        Me.BarMeter1.PLCAddressValue = CType(resources.GetObject("BarMeter1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.BarMeter1.PLCAddressVisible = ""
        Me.BarMeter1.Size = New System.Drawing.Size(43, 237)
        Me.BarMeter1.TabIndex = 631
        Me.BarMeter1.Value = 0R
        '
        'BasicButton5
        '
        Me.BasicButton5.BackColor = System.Drawing.Color.Blue
        Me.BasicButton5.ComComponent = Me.S_SC_03
        Me.BasicButton5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton5.ForeColor = System.Drawing.Color.White
        Me.BasicButton5.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton5.Highlight = False
        Me.BasicButton5.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton5.Location = New System.Drawing.Point(797, 501)
        Me.BasicButton5.MaximumHoldTime = 3000
        Me.BasicButton5.MinimumHoldTime = 500
        Me.BasicButton5.Name = "BasicButton5"
        Me.BasicButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton5.PLCAddressClick = ""
        Me.BasicButton5.PLCAddressVisible = "10208"
        Me.BasicButton5.SelectTextAlternate = False
        Me.BasicButton5.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton5.TabIndex = 541
        Me.BasicButton5.Text = "Mantenimiento"
        Me.BasicButton5.TextAlternate = ""
        Me.BasicButton5.UseVisualStyleBackColor = False
        Me.BasicButton5.ValueToWrite = 0
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.Color.Transparent
        Me.BasicButton3.ComComponent = Me.S_SC_03
        Me.BasicButton3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton3.ForeColor = System.Drawing.Color.Red
        Me.BasicButton3.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicButton3.Location = New System.Drawing.Point(576, 682)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton3.PLCAddressClick = ""
        Me.BasicButton3.PLCAddressVisible = "10150"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(166, 28)
        Me.BasicButton3.TabIndex = 539
        Me.BasicButton3.Text = "Ajuste PID"
        Me.BasicButton3.TextAlternate = ""
        Me.BasicButton3.UseVisualStyleBackColor = False
        Me.BasicButton3.ValueToWrite = 0
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.Color.Yellow
        Me.BasicButton2.ComComponent = Me.S_SC_03
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.Location = New System.Drawing.Point(774, 400)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton2.PLCAddressClick = ""
        Me.BasicButton2.PLCAddressVisible = "11033"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton2.TabIndex = 538
        Me.BasicButton2.Text = "Ciclo Finalizado"
        Me.BasicButton2.TextAlternate = "Ciclo en Marcaha"
        Me.BasicButton2.UseVisualStyleBackColor = False
        Me.BasicButton2.ValueToWrite = 0
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Red
        Me.BasicButton1.ComComponent = Me.S_SC_03
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(657, 82)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.PLCAddressClick = ""
        Me.BasicButton1.PLCAddressSelectTextAlternate = "10109"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton1.TabIndex = 537
        Me.BasicButton1.Text = "Datos Incompletos"
        Me.BasicButton1.TextAlternate = "OK"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.S_SC_03
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(763, 273)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "10110"
        Me.PilotLight1.PLCAddressVisible = "10110"
        Me.PilotLight1.Size = New System.Drawing.Size(49, 52)
        Me.PilotLight1.TabIndex = 536
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'LS_MarchaGU02
        '
        Me.LS_MarchaGU02.Blink = False
        Me.LS_MarchaGU02.ComComponent = Me.S_SC_03
        Me.LS_MarchaGU02.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaGU02.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaGU02.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaGU02.Location = New System.Drawing.Point(882, 580)
        Me.LS_MarchaGU02.Name = "LS_MarchaGU02"
        Me.LS_MarchaGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaGU02.PLCAddressClick = ""
        Me.LS_MarchaGU02.PLCAddressText = ""
        Me.LS_MarchaGU02.PLCAddressValue = "11005"
        Me.LS_MarchaGU02.PLCAddressVisible = ""
        Me.LS_MarchaGU02.Size = New System.Drawing.Size(49, 52)
        Me.LS_MarchaGU02.TabIndex = 534
        Me.LS_MarchaGU02.Value = False
        Me.LS_MarchaGU02.ValueToWrite = 0
        '
        'BCF_MenúP_GU02
        '
        Me.BCF_MenúP_GU02.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_GU02.ComComponent = Nothing
        Me.BCF_MenúP_GU02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_GU02.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_GU02.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_GU02.KeypadWidth = 300
        Me.BCF_MenúP_GU02.Location = New System.Drawing.Point(228, 640)
        Me.BCF_MenúP_GU02.Name = "BCF_MenúP_GU02"
        Me.BCF_MenúP_GU02.Passcode = Nothing
        Me.BCF_MenúP_GU02.PasswordChar = False
        Me.BCF_MenúP_GU02.PLCAddressVisible = ""
        Me.BCF_MenúP_GU02.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_GU02.TabIndex = 533
        Me.BCF_MenúP_GU02.Text = "Menú Principal"
        Me.BCF_MenúP_GU02.UseVisualStyleBackColor = False
        '
        'BP_FinCicloGU01
        '
        Me.BP_FinCicloGU01.BackColor = System.Drawing.Color.Red
        Me.BP_FinCicloGU01.ComComponent = Me.S_SC_03
        Me.BP_FinCicloGU01.ForeColor = System.Drawing.Color.Black
        Me.BP_FinCicloGU01.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_FinCicloGU01.Highlight = False
        Me.BP_FinCicloGU01.HighlightColor = System.Drawing.Color.Green
        Me.BP_FinCicloGU01.Location = New System.Drawing.Point(774, 147)
        Me.BP_FinCicloGU01.MaximumHoldTime = 3000
        Me.BP_FinCicloGU01.MinimumHoldTime = 500
        Me.BP_FinCicloGU01.Name = "BP_FinCicloGU01"
        Me.BP_FinCicloGU01.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_FinCicloGU01.PLCAddressClick = "00137"
        Me.BP_FinCicloGU01.PLCAddressVisible = "10110"
        Me.BP_FinCicloGU01.SelectTextAlternate = False
        Me.BP_FinCicloGU01.Size = New System.Drawing.Size(148, 52)
        Me.BP_FinCicloGU01.TabIndex = 532
        Me.BP_FinCicloGU01.Text = "Detener Ciclo"
        Me.BP_FinCicloGU01.TextAlternate = Nothing
        Me.BP_FinCicloGU01.UseVisualStyleBackColor = False
        Me.BP_FinCicloGU01.ValueToWrite = 0
        '
        'BP_IniCicloGU02
        '
        Me.BP_IniCicloGU02.BackColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU02.ComComponent = Me.S_SC_03
        Me.BP_IniCicloGU02.ForeColor = System.Drawing.Color.Black
        Me.BP_IniCicloGU02.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_IniCicloGU02.Highlight = False
        Me.BP_IniCicloGU02.HighlightColor = System.Drawing.Color.Green
        Me.BP_IniCicloGU02.Location = New System.Drawing.Point(572, 147)
        Me.BP_IniCicloGU02.MaximumHoldTime = 3000
        Me.BP_IniCicloGU02.MinimumHoldTime = 500
        Me.BP_IniCicloGU02.Name = "BP_IniCicloGU02"
        Me.BP_IniCicloGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BP_IniCicloGU02.PLCAddressClick = "00135"
        Me.BP_IniCicloGU02.PLCAddressVisible = "10109"
        Me.BP_IniCicloGU02.SelectTextAlternate = False
        Me.BP_IniCicloGU02.Size = New System.Drawing.Size(148, 52)
        Me.BP_IniCicloGU02.TabIndex = 531
        Me.BP_IniCicloGU02.Text = "Iniciar Ciclo"
        Me.BP_IniCicloGU02.TextAlternate = Nothing
        Me.BP_IniCicloGU02.UseVisualStyleBackColor = False
        Me.BP_IniCicloGU02.ValueToWrite = 0
        '
        'BCF_RegresarGU02
        '
        Me.BCF_RegresarGU02.BackColor = System.Drawing.Color.Blue
        Me.BCF_RegresarGU02.ComComponent = Nothing
        Me.BCF_RegresarGU02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_RegresarGU02.ForeColor = System.Drawing.Color.White
        Me.BCF_RegresarGU02.FormToOpen = Nothing
        Me.BCF_RegresarGU02.KeypadWidth = 300
        Me.BCF_RegresarGU02.Location = New System.Drawing.Point(989, 627)
        Me.BCF_RegresarGU02.Name = "BCF_RegresarGU02"
        Me.BCF_RegresarGU02.Passcode = Nothing
        Me.BCF_RegresarGU02.PasswordChar = False
        Me.BCF_RegresarGU02.PLCAddressVisible = ""
        Me.BCF_RegresarGU02.Size = New System.Drawing.Size(151, 54)
        Me.BCF_RegresarGU02.TabIndex = 530
        Me.BCF_RegresarGU02.Text = "Regresar"
        Me.BCF_RegresarGU02.UseVisualStyleBackColor = False
        '
        'BP_DescargaGU02
        '
        Me.BP_DescargaGU02.BackColor = System.Drawing.SystemColors.Control
        Me.BP_DescargaGU02.ComComponent = Me.S_SC_03
        Me.BP_DescargaGU02.ForeColor = System.Drawing.Color.Black
        Me.BP_DescargaGU02.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_DescargaGU02.Highlight = False
        Me.BP_DescargaGU02.HighlightColor = System.Drawing.Color.Green
        Me.BP_DescargaGU02.Location = New System.Drawing.Point(961, 113)
        Me.BP_DescargaGU02.MaximumHoldTime = 3000
        Me.BP_DescargaGU02.MinimumHoldTime = 500
        Me.BP_DescargaGU02.Name = "BP_DescargaGU02"
        Me.BP_DescargaGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BP_DescargaGU02.PLCAddressClick = "00138"
        Me.BP_DescargaGU02.PLCAddressHighlightX = "10160"
        Me.BP_DescargaGU02.PLCAddressSelectTextAlternate = "10160"
        Me.BP_DescargaGU02.SelectTextAlternate = False
        Me.BP_DescargaGU02.Size = New System.Drawing.Size(166, 41)
        Me.BP_DescargaGU02.TabIndex = 529
        Me.BP_DescargaGU02.Text = "Finalizar"
        Me.BP_DescargaGU02.TextAlternate = "Cancelar Finalizar"
        Me.BP_DescargaGU02.UseVisualStyleBackColor = True
        Me.BP_DescargaGU02.ValueToWrite = 0
        '
        'BP_CofirDescagaGU02
        '
        Me.BP_CofirDescagaGU02.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BP_CofirDescagaGU02.ComComponent = Me.S_SC_03
        Me.BP_CofirDescagaGU02.ForeColor = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU02.ForeColorAltername = System.Drawing.Color.Black
        Me.BP_CofirDescagaGU02.Highlight = False
        Me.BP_CofirDescagaGU02.HighlightColor = System.Drawing.Color.Green
        Me.BP_CofirDescagaGU02.Location = New System.Drawing.Point(961, 54)
        Me.BP_CofirDescagaGU02.MaximumHoldTime = 3000
        Me.BP_CofirDescagaGU02.MinimumHoldTime = 500
        Me.BP_CofirDescagaGU02.Name = "BP_CofirDescagaGU02"
        Me.BP_CofirDescagaGU02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BP_CofirDescagaGU02.PLCAddressClick = "00161"
        Me.BP_CofirDescagaGU02.PLCAddressVisible = "10160"
        Me.BP_CofirDescagaGU02.SelectTextAlternate = False
        Me.BP_CofirDescagaGU02.Size = New System.Drawing.Size(166, 41)
        Me.BP_CofirDescagaGU02.TabIndex = 528
        Me.BP_CofirDescagaGU02.Text = "Confirmar Finalizar"
        Me.BP_CofirDescagaGU02.TextAlternate = Nothing
        Me.BP_CofirDescagaGU02.UseVisualStyleBackColor = False
        Me.BP_CofirDescagaGU02.ValueToWrite = 0
        '
        'BN_SalidaGU02
        '
        Me.BN_SalidaGU02.BarContentColor = System.Drawing.Color.Blue
        Me.BN_SalidaGU02.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SalidaGU02.ComComponent = Me.S_SC_03
        Me.BN_SalidaGU02.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SalidaGU02.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SalidaGU02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SalidaGU02.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SalidaGU02.HighlightColor = System.Drawing.Color.Red
        Me.BN_SalidaGU02.Location = New System.Drawing.Point(358, 146)
        Me.BN_SalidaGU02.Maximum = 1000.0R
        Me.BN_SalidaGU02.Minimum = 0R
        Me.BN_SalidaGU02.Name = "BN_SalidaGU02"
        Me.BN_SalidaGU02.NumericFormat = Nothing
        Me.BN_SalidaGU02.PLCAddressValue = "40161"
        Me.BN_SalidaGU02.ShowValue = True
        Me.BN_SalidaGU02.Size = New System.Drawing.Size(40, 236)
        Me.BN_SalidaGU02.TabIndex = 527
        Me.BN_SalidaGU02.Text = "BarLevel3"
        Me.BN_SalidaGU02.TextSuffix = Nothing
        Me.BN_SalidaGU02.Value = 0R
        Me.BN_SalidaGU02.ValueScaleFactor = 1.0R
        '
        'BN_SP_TempGU02
        '
        Me.BN_SP_TempGU02.BarContentColor = System.Drawing.Color.Green
        Me.BN_SP_TempGU02.BorderColor = System.Drawing.Color.Wheat
        Me.BN_SP_TempGU02.ComComponent = Me.S_SC_03
        Me.BN_SP_TempGU02.FillDirection = MfgControl.AdvancedHMI.Controls.BarLevel.FillDirectionEnum.Up
        Me.BN_SP_TempGU02.FillStyle = MfgControl.AdvancedHMI.Controls.BarLevel.BarStyle.Hatch
        Me.BN_SP_TempGU02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BN_SP_TempGU02.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BN_SP_TempGU02.HighlightColor = System.Drawing.Color.Red
        Me.BN_SP_TempGU02.Location = New System.Drawing.Point(216, 147)
        Me.BN_SP_TempGU02.Maximum = 1000.0R
        Me.BN_SP_TempGU02.Minimum = 0R
        Me.BN_SP_TempGU02.Name = "BN_SP_TempGU02"
        Me.BN_SP_TempGU02.NumericFormat = Nothing
        Me.BN_SP_TempGU02.PLCAddressValue = "40152"
        Me.BN_SP_TempGU02.ShowValue = True
        Me.BN_SP_TempGU02.Size = New System.Drawing.Size(40, 236)
        Me.BN_SP_TempGU02.TabIndex = 526
        Me.BN_SP_TempGU02.Text = "BarLevel1"
        Me.BN_SP_TempGU02.TextSuffix = Nothing
        Me.BN_SP_TempGU02.Value = 0R
        Me.BN_SP_TempGU02.ValueScaleFactor = 1.0R
        '
        'MD_OrdenTrabajoGU02
        '
        Me.MD_OrdenTrabajoGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_OrdenTrabajoGU02.ComComponent = Me.S_SC_03
        Me.MD_OrdenTrabajoGU02.DecimalPosition = 0
        Me.MD_OrdenTrabajoGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_OrdenTrabajoGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_OrdenTrabajoGU02.KeypadMaxValue = 0R
        Me.MD_OrdenTrabajoGU02.KeypadMinValue = 0R
        Me.MD_OrdenTrabajoGU02.KeypadScaleFactor = 1.0R
        Me.MD_OrdenTrabajoGU02.KeypadText = Nothing
        Me.MD_OrdenTrabajoGU02.KeypadWidth = 300
        Me.MD_OrdenTrabajoGU02.Location = New System.Drawing.Point(989, 471)
        Me.MD_OrdenTrabajoGU02.Name = "MD_OrdenTrabajoGU02"
        Me.MD_OrdenTrabajoGU02.NumberOfDigits = 5
        Me.MD_OrdenTrabajoGU02.PLCAddressKeypad = "40314"
        Me.MD_OrdenTrabajoGU02.PLCAddressValue = "40314"
        Me.MD_OrdenTrabajoGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU02.Size = New System.Drawing.Size(113, 49)
        Me.MD_OrdenTrabajoGU02.TabIndex = 525
        Me.MD_OrdenTrabajoGU02.Value = 0R
        Me.MD_OrdenTrabajoGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_OrdenTrabajoGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicButton4
        '
        Me.BasicButton4.BackColor = System.Drawing.Color.Red
        Me.BasicButton4.ComComponent = Me.S_SC_03
        Me.BasicButton4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton4.ForeColor = System.Drawing.Color.Black
        Me.BasicButton4.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton4.Highlight = False
        Me.BasicButton4.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton4.Location = New System.Drawing.Point(985, 551)
        Me.BasicButton4.MaximumHoldTime = 3000
        Me.BasicButton4.MinimumHoldTime = 500
        Me.BasicButton4.Name = "BasicButton4"
        Me.BasicButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton4.PLCAddressClick = ""
        Me.BasicButton4.PLCAddressVisible = "10059"
        Me.BasicButton4.SelectTextAlternate = False
        Me.BasicButton4.Size = New System.Drawing.Size(166, 41)
        Me.BasicButton4.TabIndex = 540
        Me.BasicButton4.Text = "Falla"
        Me.BasicButton4.TextAlternate = ""
        Me.BasicButton4.UseVisualStyleBackColor = False
        Me.BasicButton4.ValueToWrite = 0
        '
        'MD_CosechaGU02
        '
        Me.MD_CosechaGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_CosechaGU02.ComComponent = Me.S_SC_03
        Me.MD_CosechaGU02.DecimalPosition = 0
        Me.MD_CosechaGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CosechaGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CosechaGU02.KeypadMaxValue = 0R
        Me.MD_CosechaGU02.KeypadMinValue = 0R
        Me.MD_CosechaGU02.KeypadScaleFactor = 1.0R
        Me.MD_CosechaGU02.KeypadText = Nothing
        Me.MD_CosechaGU02.KeypadWidth = 300
        Me.MD_CosechaGU02.Location = New System.Drawing.Point(989, 374)
        Me.MD_CosechaGU02.Name = "MD_CosechaGU02"
        Me.MD_CosechaGU02.NumberOfDigits = 5
        Me.MD_CosechaGU02.PLCAddressKeypad = ""
        Me.MD_CosechaGU02.PLCAddressValue = "40313"
        Me.MD_CosechaGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU02.Size = New System.Drawing.Size(113, 49)
        Me.MD_CosechaGU02.TabIndex = 524
        Me.MD_CosechaGU02.Value = 0R
        Me.MD_CosechaGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CosechaGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasEstimadasGU02
        '
        Me.MD_HorasEstimadasGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasEstimadasGU02.ComComponent = Me.S_SC_03
        Me.MD_HorasEstimadasGU02.DecimalPosition = 0
        Me.MD_HorasEstimadasGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasEstimadasGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasEstimadasGU02.KeypadMaxValue = 0R
        Me.MD_HorasEstimadasGU02.KeypadMinValue = 0R
        Me.MD_HorasEstimadasGU02.KeypadScaleFactor = 1.0R
        Me.MD_HorasEstimadasGU02.KeypadText = Nothing
        Me.MD_HorasEstimadasGU02.KeypadWidth = 300
        Me.MD_HorasEstimadasGU02.Location = New System.Drawing.Point(989, 281)
        Me.MD_HorasEstimadasGU02.Name = "MD_HorasEstimadasGU02"
        Me.MD_HorasEstimadasGU02.NumberOfDigits = 5
        Me.MD_HorasEstimadasGU02.PLCAddressKeypad = "40315"
        Me.MD_HorasEstimadasGU02.PLCAddressValue = "40315"
        Me.MD_HorasEstimadasGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU02.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasEstimadasGU02.TabIndex = 523
        Me.MD_HorasEstimadasGU02.Value = 0R
        Me.MD_HorasEstimadasGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasEstimadasGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempGU02
        '
        Me.MD_TempGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempGU02.ComComponent = Me.S_SC_03
        Me.MD_TempGU02.DecimalPosition = 1
        Me.MD_TempGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempGU02.KeypadMaxValue = 0R
        Me.MD_TempGU02.KeypadMinValue = 0R
        Me.MD_TempGU02.KeypadScaleFactor = 1.0R
        Me.MD_TempGU02.KeypadText = Nothing
        Me.MD_TempGU02.KeypadWidth = 300
        Me.MD_TempGU02.Location = New System.Drawing.Point(606, 446)
        Me.MD_TempGU02.Name = "MD_TempGU02"
        Me.MD_TempGU02.NumberOfDigits = 5
        Me.MD_TempGU02.PLCAddressKeypad = ""
        Me.MD_TempGU02.PLCAddressValue = "40149"
        Me.MD_TempGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU02.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempGU02.TabIndex = 522
        Me.MD_TempGU02.Value = 0R
        Me.MD_TempGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_HorasProcesoGU02
        '
        Me.MD_HorasProcesoGU02.BackColor = System.Drawing.Color.Transparent
        Me.MD_HorasProcesoGU02.ComComponent = Me.S_SC_03
        Me.MD_HorasProcesoGU02.DecimalPosition = 0
        Me.MD_HorasProcesoGU02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_HorasProcesoGU02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_HorasProcesoGU02.KeypadMaxValue = 0R
        Me.MD_HorasProcesoGU02.KeypadMinValue = 0R
        Me.MD_HorasProcesoGU02.KeypadScaleFactor = 1.0R
        Me.MD_HorasProcesoGU02.KeypadText = Nothing
        Me.MD_HorasProcesoGU02.KeypadWidth = 300
        Me.MD_HorasProcesoGU02.Location = New System.Drawing.Point(466, 73)
        Me.MD_HorasProcesoGU02.Name = "MD_HorasProcesoGU02"
        Me.MD_HorasProcesoGU02.NumberOfDigits = 5
        Me.MD_HorasProcesoGU02.PLCAddressKeypad = ""
        Me.MD_HorasProcesoGU02.PLCAddressValue = "40405"
        Me.MD_HorasProcesoGU02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU02.Size = New System.Drawing.Size(113, 49)
        Me.MD_HorasProcesoGU02.TabIndex = 521
        Me.MD_HorasProcesoGU02.Value = 0R
        Me.MD_HorasProcesoGU02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_HorasProcesoGU02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Tex_OrdenTrabajoGU02
        '
        Me.Tex_OrdenTrabajoGU02.AutoSize = True
        Me.Tex_OrdenTrabajoGU02.BackColor = System.Drawing.Color.DimGray
        Me.Tex_OrdenTrabajoGU02.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_OrdenTrabajoGU02.ForeColor = System.Drawing.Color.White
        Me.Tex_OrdenTrabajoGU02.Location = New System.Drawing.Point(1029, 446)
        Me.Tex_OrdenTrabajoGU02.Name = "Tex_OrdenTrabajoGU02"
        Me.Tex_OrdenTrabajoGU02.Size = New System.Drawing.Size(38, 22)
        Me.Tex_OrdenTrabajoGU02.TabIndex = 520
        Me.Tex_OrdenTrabajoGU02.Text = "OT"
        Me.Tex_OrdenTrabajoGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CosechaGU02
        '
        Me.Tex_CosechaGU02.AutoSize = True
        Me.Tex_CosechaGU02.BackColor = System.Drawing.Color.DimGray
        Me.Tex_CosechaGU02.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_CosechaGU02.ForeColor = System.Drawing.Color.White
        Me.Tex_CosechaGU02.Location = New System.Drawing.Point(997, 349)
        Me.Tex_CosechaGU02.Name = "Tex_CosechaGU02"
        Me.Tex_CosechaGU02.Size = New System.Drawing.Size(92, 22)
        Me.Tex_CosechaGU02.TabIndex = 519
        Me.Tex_CosechaGU02.Text = "Cosecha"
        Me.Tex_CosechaGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasEstimadasGU02
        '
        Me.Tex_HorasEstimadasGU02.AutoSize = True
        Me.Tex_HorasEstimadasGU02.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasEstimadasGU02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasEstimadasGU02.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasEstimadasGU02.Location = New System.Drawing.Point(929, 259)
        Me.Tex_HorasEstimadasGU02.Name = "Tex_HorasEstimadasGU02"
        Me.Tex_HorasEstimadasGU02.Size = New System.Drawing.Size(230, 19)
        Me.Tex_HorasEstimadasGU02.TabIndex = 518
        Me.Tex_HorasEstimadasGU02.Text = "Horas de Proceso Estimadas"
        Me.Tex_HorasEstimadasGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_HorasProcesoGU02
        '
        Me.Tex_HorasProcesoGU02.AutoSize = True
        Me.Tex_HorasProcesoGU02.BackColor = System.Drawing.Color.DimGray
        Me.Tex_HorasProcesoGU02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_HorasProcesoGU02.ForeColor = System.Drawing.Color.White
        Me.Tex_HorasProcesoGU02.Location = New System.Drawing.Point(450, 44)
        Me.Tex_HorasProcesoGU02.Name = "Tex_HorasProcesoGU02"
        Me.Tex_HorasProcesoGU02.Size = New System.Drawing.Size(146, 19)
        Me.Tex_HorasProcesoGU02.TabIndex = 517
        Me.Tex_HorasProcesoGU02.Text = "Horas de Proceso"
        Me.Tex_HorasProcesoGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexGuardiola2
        '
        Me.TexGuardiola2.AutoSize = True
        Me.TexGuardiola2.BackColor = System.Drawing.Color.DimGray
        Me.TexGuardiola2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexGuardiola2.ForeColor = System.Drawing.Color.White
        Me.TexGuardiola2.Location = New System.Drawing.Point(679, 45)
        Me.TexGuardiola2.Name = "TexGuardiola2"
        Me.TexGuardiola2.Size = New System.Drawing.Size(191, 34)
        Me.TexGuardiola2.TabIndex = 516
        Me.TexGuardiola2.Text = "Columnar 03"
        '
        'TexTempGU02
        '
        Me.TexTempGU02.AutoSize = True
        Me.TexTempGU02.BackColor = System.Drawing.Color.Silver
        Me.TexTempGU02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexTempGU02.Location = New System.Drawing.Point(603, 425)
        Me.TexTempGU02.Name = "TexTempGU02"
        Me.TexTempGU02.Size = New System.Drawing.Size(117, 18)
        Me.TexTempGU02.TabIndex = 515
        Me.TexTempGU02.Text = "Temperatura °C"
        Me.TexTempGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexPID_GU02
        '
        Me.TexPID_GU02.AutoSize = True
        Me.TexPID_GU02.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TexPID_GU02.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexPID_GU02.Location = New System.Drawing.Point(206, 64)
        Me.TexPID_GU02.Name = "TexPID_GU02"
        Me.TexPID_GU02.Size = New System.Drawing.Size(203, 44)
        Me.TexPID_GU02.TabIndex = 514
        Me.TexPID_GU02.Text = "Control Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID"
        Me.TexPID_GU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SalidaGU02
        '
        Me.TexBN_SalidaGU02.AutoSize = True
        Me.TexBN_SalidaGU02.BackColor = System.Drawing.Color.White
        Me.TexBN_SalidaGU02.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SalidaGU02.Location = New System.Drawing.Point(355, 125)
        Me.TexBN_SalidaGU02.Name = "TexBN_SalidaGU02"
        Me.TexBN_SalidaGU02.Size = New System.Drawing.Size(53, 18)
        Me.TexBN_SalidaGU02.TabIndex = 513
        Me.TexBN_SalidaGU02.Text = "Salida"
        Me.TexBN_SalidaGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_RealTempGU02
        '
        Me.TexBN_RealTempGU02.AutoSize = True
        Me.TexBN_RealTempGU02.BackColor = System.Drawing.Color.White
        Me.TexBN_RealTempGU02.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_RealTempGU02.Location = New System.Drawing.Point(288, 126)
        Me.TexBN_RealTempGU02.Name = "TexBN_RealTempGU02"
        Me.TexBN_RealTempGU02.Size = New System.Drawing.Size(40, 18)
        Me.TexBN_RealTempGU02.TabIndex = 512
        Me.TexBN_RealTempGU02.Text = "Real"
        Me.TexBN_RealTempGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexBN_SP_TempGU02
        '
        Me.TexBN_SP_TempGU02.AutoSize = True
        Me.TexBN_SP_TempGU02.BackColor = System.Drawing.Color.White
        Me.TexBN_SP_TempGU02.ForeColor = System.Drawing.Color.Blue
        Me.TexBN_SP_TempGU02.Location = New System.Drawing.Point(202, 126)
        Me.TexBN_SP_TempGU02.Name = "TexBN_SP_TempGU02"
        Me.TexBN_SP_TempGU02.Size = New System.Drawing.Size(68, 18)
        Me.TexBN_SP_TempGU02.TabIndex = 511
        Me.TexBN_SP_TempGU02.Text = "SetPoint"
        Me.TexBN_SP_TempGU02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IGU01
        '
        Me.IGU01.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Columnar_D
        Me.IGU01.Location = New System.Drawing.Point(463, 128)
        Me.IGU01.Name = "IGU01"
        Me.IGU01.Size = New System.Drawing.Size(500, 553)
        Me.IGU01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IGU01.TabIndex = 535
        Me.IGU01.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupPanel1.BackColor2 = System.Drawing.Color.Green
        Me.GroupPanel1.BackColor3 = System.Drawing.Color.Red
        Me.GroupPanel1.ComComponent = Me.S_SC_03
        Me.GroupPanel1.Controls.Add(Me.BarMeter1)
        Me.GroupPanel1.Location = New System.Drawing.Point(190, 43)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.SelectBackColor2 = False
        Me.GroupPanel1.SelectBackColor3 = False
        Me.GroupPanel1.Size = New System.Drawing.Size(232, 365)
        Me.GroupPanel1.TabIndex = 542
        '
        'Columnar_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.CT_PSC03)
        Me.Controls.Add(Me.BasicButton5)
        Me.Controls.Add(Me.BasicButton3)
        Me.Controls.Add(Me.BasicButton2)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.LS_MarchaGU02)
        Me.Controls.Add(Me.BCF_MenúP_GU02)
        Me.Controls.Add(Me.BP_FinCicloGU01)
        Me.Controls.Add(Me.BP_IniCicloGU02)
        Me.Controls.Add(Me.BCF_RegresarGU02)
        Me.Controls.Add(Me.BP_DescargaGU02)
        Me.Controls.Add(Me.BP_CofirDescagaGU02)
        Me.Controls.Add(Me.BN_SalidaGU02)
        Me.Controls.Add(Me.BN_SP_TempGU02)
        Me.Controls.Add(Me.MD_OrdenTrabajoGU02)
        Me.Controls.Add(Me.BasicButton4)
        Me.Controls.Add(Me.MD_CosechaGU02)
        Me.Controls.Add(Me.MD_HorasEstimadasGU02)
        Me.Controls.Add(Me.MD_TempGU02)
        Me.Controls.Add(Me.MD_HorasProcesoGU02)
        Me.Controls.Add(Me.Tex_OrdenTrabajoGU02)
        Me.Controls.Add(Me.Tex_CosechaGU02)
        Me.Controls.Add(Me.Tex_HorasEstimadasGU02)
        Me.Controls.Add(Me.Tex_HorasProcesoGU02)
        Me.Controls.Add(Me.TexGuardiola2)
        Me.Controls.Add(Me.TexTempGU02)
        Me.Controls.Add(Me.TexPID_GU02)
        Me.Controls.Add(Me.TexBN_SalidaGU02)
        Me.Controls.Add(Me.TexBN_RealTempGU02)
        Me.Controls.Add(Me.TexBN_SP_TempGU02)
        Me.Controls.Add(Me.IGU01)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Columnar_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.S_SC_03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGU01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CT_PSC03 As AdvancedHMIControls.TempController
    Friend WithEvents S_SC_03 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BarMeter1 As AdvancedHMIControls.BarMeter
    Friend WithEvents BasicButton5 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton3 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MarchaGU02 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_MenúP_GU02 As FormChangeButton
    Friend WithEvents BP_FinCicloGU01 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_IniCicloGU02 As AdvancedHMIControls.BasicButton
    Friend WithEvents BCF_RegresarGU02 As FormChangeButton
    Friend WithEvents BP_DescargaGU02 As AdvancedHMIControls.BasicButton
    Friend WithEvents BP_CofirDescagaGU02 As AdvancedHMIControls.BasicButton
    Friend WithEvents BN_SalidaGU02 As AdvancedHMIControls.BarLevel
    Friend WithEvents BN_SP_TempGU02 As AdvancedHMIControls.BarLevel
    Friend WithEvents MD_OrdenTrabajoGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicButton4 As AdvancedHMIControls.BasicButton
    Friend WithEvents MD_CosechaGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasEstimadasGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_HorasProcesoGU02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents Tex_OrdenTrabajoGU02 As Label
    Friend WithEvents Tex_CosechaGU02 As Label
    Friend WithEvents Tex_HorasEstimadasGU02 As Label
    Friend WithEvents Tex_HorasProcesoGU02 As Label
    Friend WithEvents TexGuardiola2 As Label
    Friend WithEvents TexTempGU02 As Label
    Friend WithEvents TexPID_GU02 As Label
    Friend WithEvents TexBN_SalidaGU02 As Label
    Friend WithEvents TexBN_RealTempGU02 As Label
    Friend WithEvents TexBN_SP_TempGU02 As Label
    Friend WithEvents IGU01 As PictureBox
    Friend WithEvents GroupPanel1 As AdvancedHMIControls.GroupPanel
End Class
