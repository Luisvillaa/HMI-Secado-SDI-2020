<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú_Horno_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menú_Horno_3))
        Me.TexRecetaMHorno3 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MenuH3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.BCF_H01_MH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_SC05_MH3 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_SC03_MH3 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.MD_TempMH3SC05 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_SC04_MH3 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BCF_SC02_MH3 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.LS_MarchaMH3SC05 = New AdvancedHMIControls.PilotLight()
        Me.MD_TempMH3SC04 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.LS_MarchaMH3SC04 = New AdvancedHMIControls.PilotLight()
        Me.MD_TempMH3SC03 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.LS_MarchaMH3SC03 = New AdvancedHMIControls.PilotLight()
        Me.MD_TempMH3SC02 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.LS_MarchaMH3SC02 = New AdvancedHMIControls.PilotLight()
        Me.LT_MHorno3 = New AdvancedHMIControls.StackLight()
        Me.MD_TempMul2MH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempMul1MH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempChimeMH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.LS_MarchaMHorno3 = New AdvancedHMIControls.PilotLight()
        Me.MD_CargaMHorno3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_TempHogueraMH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_CascarillaXMminuMH3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_MenúP_MH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.Tex_TempMul2MH1 = New System.Windows.Forms.Label()
        Me.Tex_GU12_MH1 = New System.Windows.Forms.Label()
        Me.Tex_GU10_MH1 = New System.Windows.Forms.Label()
        Me.I_SC05_MH3 = New System.Windows.Forms.PictureBox()
        Me.I_SC03_MH3 = New System.Windows.Forms.PictureBox()
        Me.Tex_GU11_MH1 = New System.Windows.Forms.Label()
        Me.Tex_GU09_MH1 = New System.Windows.Forms.Label()
        Me.I_SC04_MH3 = New System.Windows.Forms.PictureBox()
        Me.I_SC02_MH3 = New System.Windows.Forms.PictureBox()
        Me.Tex_MenuHorno1 = New System.Windows.Forms.Label()
        Me.Tex_CargaMHorno1 = New System.Windows.Forms.Label()
        Me.Tex_TempHogueraMH1 = New System.Windows.Forms.Label()
        Me.Tex_CascarillaXMminuMH1 = New System.Windows.Forms.Label()
        Me.Tex_TempChimeMH1 = New System.Windows.Forms.Label()
        Me.Tex_TempMul1MH1 = New System.Windows.Forms.Label()
        Me.IHorno3M = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.MenuH3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.I_SC05_MH3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.I_SC03_MH3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.I_SC04_MH3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.I_SC02_MH3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IHorno3M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TexRecetaMHorno3
        '
        Me.TexRecetaMHorno3.AutoSize = True
        Me.TexRecetaMHorno3.BackColor = System.Drawing.Color.White
        Me.TexRecetaMHorno3.ComComponent = Me.MenuH3
        Me.TexRecetaMHorno3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexRecetaMHorno3.ForeColor = System.Drawing.Color.Blue
        Me.TexRecetaMHorno3.HighlightColor = System.Drawing.Color.Red
        Me.TexRecetaMHorno3.HighlightColor2 = System.Drawing.Color.Red
        Me.TexRecetaMHorno3.HighlightKeyCharacter = "!"
        Me.TexRecetaMHorno3.HighlightKeyCharacter2 = "."
        Me.TexRecetaMHorno3.IniFileName = Nothing
        Me.TexRecetaMHorno3.Location = New System.Drawing.Point(867, 116)
        Me.TexRecetaMHorno3.Messages.Add(CType(resources.GetObject("TexRecetaMHorno3.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaMHorno3.Messages.Add(CType(resources.GetObject("TexRecetaMHorno3.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaMHorno3.Messages.Add(CType(resources.GetObject("TexRecetaMHorno3.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaMHorno3.Messages.Add(CType(resources.GetObject("TexRecetaMHorno3.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaMHorno3.Messages.Add(CType(resources.GetObject("TexRecetaMHorno3.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.TexRecetaMHorno3.Name = "TexRecetaMHorno3"
        Me.TexRecetaMHorno3.PLCAddressValue = "40517"
        Me.TexRecetaMHorno3.PLCAddressVisible = ""
        Me.TexRecetaMHorno3.ShowMessageNumber = False
        Me.TexRecetaMHorno3.Size = New System.Drawing.Size(89, 22)
        Me.TexRecetaMHorno3.SpeakMessage = False
        Me.TexRecetaMHorno3.TabIndex = 881
        Me.TexRecetaMHorno3.Text = "Receta 0"
        Me.TexRecetaMHorno3.TextPrefix = Nothing
        Me.TexRecetaMHorno3.Value = 0
        '
        'MenuH3
        '
        Me.MenuH3.DisableSubscriptions = False
        Me.MenuH3.IniFileName = ""
        Me.MenuH3.IniFileSection = Nothing
        Me.MenuH3.IPAddress = "10.1.108.8"
        Me.MenuH3.MaxReadGroupSize = 20
        Me.MenuH3.PollRateOverride = 500
        Me.MenuH3.SwapBytes = True
        Me.MenuH3.SwapWords = False
        Me.MenuH3.TcpipPort = CType(20257US, UShort)
        Me.MenuH3.TimeOut = 3000
        Me.MenuH3.UnitId = CType(13, Byte)
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox10.Location = New System.Drawing.Point(483, 123)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(122, 40)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 909
        Me.PictureBox10.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox8.Location = New System.Drawing.Point(327, 405)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(74, 40)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 907
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox7.Location = New System.Drawing.Point(400, 405)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(250, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 906
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox6.Location = New System.Drawing.Point(649, 405)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(250, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 905
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox5.Location = New System.Drawing.Point(851, 444)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(34, 214)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 904
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox4.Location = New System.Drawing.Point(589, 444)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 214)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 903
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox3.Location = New System.Drawing.Point(327, 444)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 214)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 902
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox2.Location = New System.Drawing.Point(898, 405)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 901
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox1.Location = New System.Drawing.Point(1113, 444)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 900
        Me.PictureBox1.TabStop = False
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.MenuH3
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(295, 512)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "11035"
        Me.PilotLight1.PLCAddressVisible = "11035"
        Me.PilotLight1.Size = New System.Drawing.Size(19, 20)
        Me.PilotLight1.TabIndex = 899
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.MenuH3
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(556, 512)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "11034"
        Me.PilotLight2.PLCAddressVisible = "11034"
        Me.PilotLight2.Size = New System.Drawing.Size(19, 20)
        Me.PilotLight2.TabIndex = 898
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.MenuH3
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(818, 513)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "11033"
        Me.PilotLight3.PLCAddressVisible = "11033"
        Me.PilotLight3.Size = New System.Drawing.Size(19, 20)
        Me.PilotLight3.TabIndex = 897
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.MenuH3
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(1081, 513)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "11032"
        Me.PilotLight4.PLCAddressVisible = "11032"
        Me.PilotLight4.Size = New System.Drawing.Size(19, 20)
        Me.PilotLight4.TabIndex = 896
        Me.PilotLight4.Value = False
        Me.PilotLight4.ValueToWrite = 0
        '
        'BCF_H01_MH1
        '
        Me.BCF_H01_MH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_H01_MH1.ComComponent = Nothing
        Me.BCF_H01_MH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_H01_MH1.ForeColor = System.Drawing.Color.White
        Me.BCF_H01_MH1.FormToOpen = GetType(MfgControl.AdvancedHMI.Horno_3)
        Me.BCF_H01_MH1.KeypadWidth = 300
        Me.BCF_H01_MH1.Location = New System.Drawing.Point(250, 186)
        Me.BCF_H01_MH1.Name = "BCF_H01_MH1"
        Me.BCF_H01_MH1.Passcode = Nothing
        Me.BCF_H01_MH1.PasswordChar = False
        Me.BCF_H01_MH1.PLCAddressVisible = ""
        Me.BCF_H01_MH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_H01_MH1.TabIndex = 895
        Me.BCF_H01_MH1.Text = "Horno 03"
        Me.BCF_H01_MH1.UseVisualStyleBackColor = False
        '
        'BCF_SC05_MH3
        '
        Me.BCF_SC05_MH3.BackColor = System.Drawing.Color.Blue
        Me.BCF_SC05_MH3.ComComponent = Nothing
        Me.BCF_SC05_MH3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_SC05_MH3.ForeColor = System.Drawing.Color.White
        Me.BCF_SC05_MH3.FormToOpen = GetType(MfgControl.AdvancedHMI.Columnar_05)
        Me.BCF_SC05_MH3.KeypadWidth = 300
        Me.BCF_SC05_MH3.Location = New System.Drawing.Point(212, 677)
        Me.BCF_SC05_MH3.Name = "BCF_SC05_MH3"
        Me.BCF_SC05_MH3.Passcode = Nothing
        Me.BCF_SC05_MH3.PasswordChar = False
        Me.BCF_SC05_MH3.PLCAddressVisible = ""
        Me.BCF_SC05_MH3.Size = New System.Drawing.Size(99, 40)
        Me.BCF_SC05_MH3.TabIndex = 894
        Me.BCF_SC05_MH3.Text = "P-SC-05"
        Me.BCF_SC05_MH3.UseVisualStyleBackColor = False
        '
        'BCF_SC03_MH3
        '
        Me.BCF_SC03_MH3.BackColor = System.Drawing.Color.Blue
        Me.BCF_SC03_MH3.ComComponent = Nothing
        Me.BCF_SC03_MH3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_SC03_MH3.ForeColor = System.Drawing.Color.White
        Me.BCF_SC03_MH3.FormToOpen = GetType(MfgControl.AdvancedHMI.Columnar_03)
        Me.BCF_SC03_MH3.KeypadWidth = 300
        Me.BCF_SC03_MH3.Location = New System.Drawing.Point(736, 675)
        Me.BCF_SC03_MH3.Name = "BCF_SC03_MH3"
        Me.BCF_SC03_MH3.Passcode = Nothing
        Me.BCF_SC03_MH3.PasswordChar = False
        Me.BCF_SC03_MH3.PLCAddressVisible = ""
        Me.BCF_SC03_MH3.Size = New System.Drawing.Size(99, 40)
        Me.BCF_SC03_MH3.TabIndex = 892
        Me.BCF_SC03_MH3.Text = "P-SC-03"
        Me.BCF_SC03_MH3.UseVisualStyleBackColor = False
        '
        'MD_TempMH3SC05
        '
        Me.MD_TempMH3SC05.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMH3SC05.ComComponent = Me.MenuH3
        Me.MD_TempMH3SC05.DecimalPosition = 1
        Me.MD_TempMH3SC05.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMH3SC05.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMH3SC05.KeypadMaxValue = 0R
        Me.MD_TempMH3SC05.KeypadMinValue = 0R
        Me.MD_TempMH3SC05.KeypadScaleFactor = 1.0R
        Me.MD_TempMH3SC05.KeypadText = Nothing
        Me.MD_TempMH3SC05.KeypadWidth = 300
        Me.MD_TempMH3SC05.Location = New System.Drawing.Point(228, 572)
        Me.MD_TempMH3SC05.Name = "MD_TempMH3SC05"
        Me.MD_TempMH3SC05.NumberOfDigits = 5
        Me.MD_TempMH3SC05.PLCAddressKeypad = ""
        Me.MD_TempMH3SC05.PLCAddressValue = "40251"
        Me.MD_TempMH3SC05.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC05.Size = New System.Drawing.Size(67, 29)
        Me.MD_TempMH3SC05.TabIndex = 890
        Me.MD_TempMH3SC05.Value = 0R
        Me.MD_TempMH3SC05.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC05.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_SC04_MH3
        '
        Me.BCF_SC04_MH3.BackColor = System.Drawing.Color.Blue
        Me.BCF_SC04_MH3.ComComponent = Nothing
        Me.BCF_SC04_MH3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_SC04_MH3.ForeColor = System.Drawing.Color.White
        Me.BCF_SC04_MH3.FormToOpen = GetType(MfgControl.AdvancedHMI.Columnar_04)
        Me.BCF_SC04_MH3.KeypadWidth = 300
        Me.BCF_SC04_MH3.Location = New System.Drawing.Point(474, 675)
        Me.BCF_SC04_MH3.Name = "BCF_SC04_MH3"
        Me.BCF_SC04_MH3.Passcode = Nothing
        Me.BCF_SC04_MH3.PasswordChar = False
        Me.BCF_SC04_MH3.PLCAddressVisible = ""
        Me.BCF_SC04_MH3.Size = New System.Drawing.Size(99, 40)
        Me.BCF_SC04_MH3.TabIndex = 893
        Me.BCF_SC04_MH3.Text = "P-SC-04"
        Me.BCF_SC04_MH3.UseVisualStyleBackColor = False
        '
        'BCF_SC02_MH3
        '
        Me.BCF_SC02_MH3.BackColor = System.Drawing.Color.Blue
        Me.BCF_SC02_MH3.ComComponent = Nothing
        Me.BCF_SC02_MH3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_SC02_MH3.ForeColor = System.Drawing.Color.White
        Me.BCF_SC02_MH3.FormToOpen = GetType(MfgControl.AdvancedHMI.Columnar_02)
        Me.BCF_SC02_MH3.KeypadWidth = 300
        Me.BCF_SC02_MH3.Location = New System.Drawing.Point(998, 675)
        Me.BCF_SC02_MH3.Name = "BCF_SC02_MH3"
        Me.BCF_SC02_MH3.Passcode = Nothing
        Me.BCF_SC02_MH3.PasswordChar = False
        Me.BCF_SC02_MH3.PLCAddressVisible = ""
        Me.BCF_SC02_MH3.Size = New System.Drawing.Size(99, 40)
        Me.BCF_SC02_MH3.TabIndex = 891
        Me.BCF_SC02_MH3.Text = "P-SC-02"
        Me.BCF_SC02_MH3.UseVisualStyleBackColor = False
        '
        'LS_MarchaMH3SC05
        '
        Me.LS_MarchaMH3SC05.Blink = False
        Me.LS_MarchaMH3SC05.ComComponent = Me.MenuH3
        Me.LS_MarchaMH3SC05.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaMH3SC05.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaMH3SC05.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaMH3SC05.Location = New System.Drawing.Point(302, 614)
        Me.LS_MarchaMH3SC05.Name = "LS_MarchaMH3SC05"
        Me.LS_MarchaMH3SC05.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaMH3SC05.PLCAddressClick = ""
        Me.LS_MarchaMH3SC05.PLCAddressText = ""
        Me.LS_MarchaMH3SC05.PLCAddressValue = "11030"
        Me.LS_MarchaMH3SC05.PLCAddressVisible = ""
        Me.LS_MarchaMH3SC05.Size = New System.Drawing.Size(19, 20)
        Me.LS_MarchaMH3SC05.TabIndex = 889
        Me.LS_MarchaMH3SC05.Value = False
        Me.LS_MarchaMH3SC05.ValueToWrite = 0
        '
        'MD_TempMH3SC04
        '
        Me.MD_TempMH3SC04.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMH3SC04.ComComponent = Me.MenuH3
        Me.MD_TempMH3SC04.DecimalPosition = 1
        Me.MD_TempMH3SC04.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMH3SC04.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMH3SC04.KeypadMaxValue = 0R
        Me.MD_TempMH3SC04.KeypadMinValue = 0R
        Me.MD_TempMH3SC04.KeypadScaleFactor = 1.0R
        Me.MD_TempMH3SC04.KeypadText = Nothing
        Me.MD_TempMH3SC04.KeypadWidth = 300
        Me.MD_TempMH3SC04.Location = New System.Drawing.Point(490, 572)
        Me.MD_TempMH3SC04.Name = "MD_TempMH3SC04"
        Me.MD_TempMH3SC04.NumberOfDigits = 5
        Me.MD_TempMH3SC04.PLCAddressKeypad = ""
        Me.MD_TempMH3SC04.PLCAddressValue = "40200"
        Me.MD_TempMH3SC04.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC04.Size = New System.Drawing.Size(67, 29)
        Me.MD_TempMH3SC04.TabIndex = 888
        Me.MD_TempMH3SC04.Value = 0R
        Me.MD_TempMH3SC04.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC04.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'LS_MarchaMH3SC04
        '
        Me.LS_MarchaMH3SC04.Blink = False
        Me.LS_MarchaMH3SC04.ComComponent = Me.MenuH3
        Me.LS_MarchaMH3SC04.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaMH3SC04.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaMH3SC04.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaMH3SC04.Location = New System.Drawing.Point(561, 614)
        Me.LS_MarchaMH3SC04.Name = "LS_MarchaMH3SC04"
        Me.LS_MarchaMH3SC04.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaMH3SC04.PLCAddressClick = ""
        Me.LS_MarchaMH3SC04.PLCAddressText = ""
        Me.LS_MarchaMH3SC04.PLCAddressValue = "11029"
        Me.LS_MarchaMH3SC04.PLCAddressVisible = ""
        Me.LS_MarchaMH3SC04.Size = New System.Drawing.Size(19, 20)
        Me.LS_MarchaMH3SC04.TabIndex = 887
        Me.LS_MarchaMH3SC04.Value = False
        Me.LS_MarchaMH3SC04.ValueToWrite = 0
        '
        'MD_TempMH3SC03
        '
        Me.MD_TempMH3SC03.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMH3SC03.ComComponent = Me.MenuH3
        Me.MD_TempMH3SC03.DecimalPosition = 1
        Me.MD_TempMH3SC03.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMH3SC03.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMH3SC03.KeypadMaxValue = 0R
        Me.MD_TempMH3SC03.KeypadMinValue = 0R
        Me.MD_TempMH3SC03.KeypadScaleFactor = 1.0R
        Me.MD_TempMH3SC03.KeypadText = Nothing
        Me.MD_TempMH3SC03.KeypadWidth = 300
        Me.MD_TempMH3SC03.Location = New System.Drawing.Point(751, 572)
        Me.MD_TempMH3SC03.Name = "MD_TempMH3SC03"
        Me.MD_TempMH3SC03.NumberOfDigits = 5
        Me.MD_TempMH3SC03.PLCAddressKeypad = ""
        Me.MD_TempMH3SC03.PLCAddressValue = "40149"
        Me.MD_TempMH3SC03.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC03.Size = New System.Drawing.Size(67, 29)
        Me.MD_TempMH3SC03.TabIndex = 886
        Me.MD_TempMH3SC03.Value = 0R
        Me.MD_TempMH3SC03.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC03.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'LS_MarchaMH3SC03
        '
        Me.LS_MarchaMH3SC03.Blink = False
        Me.LS_MarchaMH3SC03.ComComponent = Me.MenuH3
        Me.LS_MarchaMH3SC03.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaMH3SC03.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaMH3SC03.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaMH3SC03.Location = New System.Drawing.Point(825, 615)
        Me.LS_MarchaMH3SC03.Name = "LS_MarchaMH3SC03"
        Me.LS_MarchaMH3SC03.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaMH3SC03.PLCAddressClick = ""
        Me.LS_MarchaMH3SC03.PLCAddressText = ""
        Me.LS_MarchaMH3SC03.PLCAddressValue = "11028"
        Me.LS_MarchaMH3SC03.PLCAddressVisible = ""
        Me.LS_MarchaMH3SC03.Size = New System.Drawing.Size(19, 20)
        Me.LS_MarchaMH3SC03.TabIndex = 885
        Me.LS_MarchaMH3SC03.Value = False
        Me.LS_MarchaMH3SC03.ValueToWrite = 0
        '
        'MD_TempMH3SC02
        '
        Me.MD_TempMH3SC02.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMH3SC02.ComComponent = Me.MenuH3
        Me.MD_TempMH3SC02.DecimalPosition = 1
        Me.MD_TempMH3SC02.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMH3SC02.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMH3SC02.KeypadMaxValue = 0R
        Me.MD_TempMH3SC02.KeypadMinValue = 0R
        Me.MD_TempMH3SC02.KeypadScaleFactor = 1.0R
        Me.MD_TempMH3SC02.KeypadText = Nothing
        Me.MD_TempMH3SC02.KeypadWidth = 300
        Me.MD_TempMH3SC02.Location = New System.Drawing.Point(1014, 572)
        Me.MD_TempMH3SC02.Name = "MD_TempMH3SC02"
        Me.MD_TempMH3SC02.NumberOfDigits = 5
        Me.MD_TempMH3SC02.PLCAddressKeypad = ""
        Me.MD_TempMH3SC02.PLCAddressValue = "40085"
        Me.MD_TempMH3SC02.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC02.Size = New System.Drawing.Size(67, 29)
        Me.MD_TempMH3SC02.TabIndex = 884
        Me.MD_TempMH3SC02.Value = 0R
        Me.MD_TempMH3SC02.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMH3SC02.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'LS_MarchaMH3SC02
        '
        Me.LS_MarchaMH3SC02.Blink = False
        Me.LS_MarchaMH3SC02.ComComponent = Me.MenuH3
        Me.LS_MarchaMH3SC02.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MarchaMH3SC02.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaMH3SC02.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaMH3SC02.Location = New System.Drawing.Point(1085, 615)
        Me.LS_MarchaMH3SC02.Name = "LS_MarchaMH3SC02"
        Me.LS_MarchaMH3SC02.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaMH3SC02.PLCAddressClick = ""
        Me.LS_MarchaMH3SC02.PLCAddressText = ""
        Me.LS_MarchaMH3SC02.PLCAddressValue = "11027"
        Me.LS_MarchaMH3SC02.PLCAddressVisible = ""
        Me.LS_MarchaMH3SC02.Size = New System.Drawing.Size(19, 20)
        Me.LS_MarchaMH3SC02.TabIndex = 883
        Me.LS_MarchaMH3SC02.Value = False
        Me.LS_MarchaMH3SC02.ValueToWrite = 0
        '
        'LT_MHorno3
        '
        Me.LT_MHorno3.ComComponent = Me.MenuH3
        Me.LT_MHorno3.ForeColor = System.Drawing.Color.White
        Me.LT_MHorno3.HighlightColor = System.Drawing.Color.Red
        Me.LT_MHorno3.HighlightKeyCharacter = "!"
        Me.LT_MHorno3.KeypadText = Nothing
        Me.LT_MHorno3.LightAmberEnable = True
        Me.LT_MHorno3.LightAmberValue = False
        Me.LT_MHorno3.LightBlueEnable = True
        Me.LT_MHorno3.LightBlueValue = False
        Me.LT_MHorno3.LightGreenEnable = True
        Me.LT_MHorno3.LightGreenValue = False
        Me.LT_MHorno3.LightRedEnable = True
        Me.LT_MHorno3.LightRedValue = False
        Me.LT_MHorno3.Location = New System.Drawing.Point(814, 53)
        Me.LT_MHorno3.Name = "LT_MHorno3"
        Me.LT_MHorno3.NumericFormat = Nothing
        Me.LT_MHorno3.PLCAddressKeypad = ""
        Me.LT_MHorno3.PLCAddressLightAmberValue = ""
        Me.LT_MHorno3.PLCAddressLightGreenValue = "11024"
        Me.LT_MHorno3.PLCAddressLightRedValue = "11025"
        Me.LT_MHorno3.PLCAddressText = ""
        Me.LT_MHorno3.PLCAddressVisible = ""
        Me.LT_MHorno3.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LT_MHorno3.Size = New System.Drawing.Size(23, 98)
        Me.LT_MHorno3.TabIndex = 882
        Me.LT_MHorno3.TextPrefix = Nothing
        Me.LT_MHorno3.TextSuffix = Nothing
        '
        'MD_TempMul2MH3
        '
        Me.MD_TempMul2MH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul2MH3.ComComponent = Me.MenuH3
        Me.MD_TempMul2MH3.DecimalPosition = 1
        Me.MD_TempMul2MH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul2MH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul2MH3.KeypadMaxValue = 0R
        Me.MD_TempMul2MH3.KeypadMinValue = 0R
        Me.MD_TempMul2MH3.KeypadScaleFactor = 1.0R
        Me.MD_TempMul2MH3.KeypadText = Nothing
        Me.MD_TempMul2MH3.KeypadWidth = 300
        Me.MD_TempMul2MH3.Location = New System.Drawing.Point(525, 202)
        Me.MD_TempMul2MH3.Name = "MD_TempMul2MH3"
        Me.MD_TempMul2MH3.NumberOfDigits = 5
        Me.MD_TempMul2MH3.PLCAddressKeypad = ""
        Me.MD_TempMul2MH3.PLCAddressValue = "40034"
        Me.MD_TempMul2MH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul2MH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul2MH3.TabIndex = 880
        Me.MD_TempMul2MH3.Value = 0R
        Me.MD_TempMul2MH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul2MH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempMul1MH3
        '
        Me.MD_TempMul1MH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempMul1MH3.ComComponent = Me.MenuH3
        Me.MD_TempMul1MH3.DecimalPosition = 1
        Me.MD_TempMul1MH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempMul1MH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempMul1MH3.KeypadMaxValue = 0R
        Me.MD_TempMul1MH3.KeypadMinValue = 0R
        Me.MD_TempMul1MH3.KeypadScaleFactor = 1.0R
        Me.MD_TempMul1MH3.KeypadText = Nothing
        Me.MD_TempMul1MH3.KeypadWidth = 300
        Me.MD_TempMul1MH3.Location = New System.Drawing.Point(483, 74)
        Me.MD_TempMul1MH3.Name = "MD_TempMul1MH3"
        Me.MD_TempMul1MH3.NumberOfDigits = 5
        Me.MD_TempMul1MH3.PLCAddressKeypad = ""
        Me.MD_TempMul1MH3.PLCAddressValue = "40027"
        Me.MD_TempMul1MH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul1MH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempMul1MH3.TabIndex = 879
        Me.MD_TempMul1MH3.Value = 0R
        Me.MD_TempMul1MH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempMul1MH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempChimeMH3
        '
        Me.MD_TempChimeMH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempChimeMH3.ComComponent = Me.MenuH3
        Me.MD_TempChimeMH3.DecimalPosition = 1
        Me.MD_TempChimeMH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempChimeMH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempChimeMH3.KeypadMaxValue = 0R
        Me.MD_TempChimeMH3.KeypadMinValue = 0R
        Me.MD_TempChimeMH3.KeypadScaleFactor = 1.0R
        Me.MD_TempChimeMH3.KeypadText = Nothing
        Me.MD_TempChimeMH3.KeypadWidth = 300
        Me.MD_TempChimeMH3.Location = New System.Drawing.Point(1042, 98)
        Me.MD_TempChimeMH3.Name = "MD_TempChimeMH3"
        Me.MD_TempChimeMH3.NumberOfDigits = 5
        Me.MD_TempChimeMH3.PLCAddressKeypad = ""
        Me.MD_TempChimeMH3.PLCAddressValue = "40013"
        Me.MD_TempChimeMH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempChimeMH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempChimeMH3.TabIndex = 878
        Me.MD_TempChimeMH3.Value = 0R
        Me.MD_TempChimeMH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempChimeMH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'LS_MarchaMHorno3
        '
        Me.LS_MarchaMHorno3.Blink = False
        Me.LS_MarchaMHorno3.ComComponent = Me.MenuH3
        Me.LS_MarchaMHorno3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.LS_MarchaMHorno3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MarchaMHorno3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MarchaMHorno3.Location = New System.Drawing.Point(873, 154)
        Me.LS_MarchaMHorno3.Name = "LS_MarchaMHorno3"
        Me.LS_MarchaMHorno3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MarchaMHorno3.PLCAddressClick = ""
        Me.LS_MarchaMHorno3.PLCAddressText = ""
        Me.LS_MarchaMHorno3.PLCAddressValue = "10023"
        Me.LS_MarchaMHorno3.PLCAddressVisible = ""
        Me.LS_MarchaMHorno3.Size = New System.Drawing.Size(83, 122)
        Me.LS_MarchaMHorno3.TabIndex = 877
        Me.LS_MarchaMHorno3.Text = "En Marcha"
        Me.LS_MarchaMHorno3.Value = False
        Me.LS_MarchaMHorno3.ValueToWrite = 0
        '
        'MD_CargaMHorno3
        '
        Me.MD_CargaMHorno3.BackColor = System.Drawing.Color.Transparent
        Me.MD_CargaMHorno3.ComComponent = Me.MenuH3
        Me.MD_CargaMHorno3.DecimalPosition = 0
        Me.MD_CargaMHorno3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CargaMHorno3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CargaMHorno3.KeypadMaxValue = 0R
        Me.MD_CargaMHorno3.KeypadMinValue = 0R
        Me.MD_CargaMHorno3.KeypadScaleFactor = 1.0R
        Me.MD_CargaMHorno3.KeypadText = Nothing
        Me.MD_CargaMHorno3.KeypadWidth = 300
        Me.MD_CargaMHorno3.Location = New System.Drawing.Point(445, 307)
        Me.MD_CargaMHorno3.Name = "MD_CargaMHorno3"
        Me.MD_CargaMHorno3.NumberOfDigits = 5
        Me.MD_CargaMHorno3.PLCAddressKeypad = ""
        Me.MD_CargaMHorno3.PLCAddressValue = "40481"
        Me.MD_CargaMHorno3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaMHorno3.Size = New System.Drawing.Size(113, 49)
        Me.MD_CargaMHorno3.TabIndex = 876
        Me.MD_CargaMHorno3.Value = 0R
        Me.MD_CargaMHorno3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CargaMHorno3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_TempHogueraMH3
        '
        Me.MD_TempHogueraMH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_TempHogueraMH3.ComComponent = Me.MenuH3
        Me.MD_TempHogueraMH3.DecimalPosition = 1
        Me.MD_TempHogueraMH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_TempHogueraMH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_TempHogueraMH3.KeypadMaxValue = 0R
        Me.MD_TempHogueraMH3.KeypadMinValue = 0R
        Me.MD_TempHogueraMH3.KeypadScaleFactor = 1.0R
        Me.MD_TempHogueraMH3.KeypadText = Nothing
        Me.MD_TempHogueraMH3.KeypadWidth = 300
        Me.MD_TempHogueraMH3.Location = New System.Drawing.Point(688, 243)
        Me.MD_TempHogueraMH3.Name = "MD_TempHogueraMH3"
        Me.MD_TempHogueraMH3.NumberOfDigits = 5
        Me.MD_TempHogueraMH3.PLCAddressKeypad = ""
        Me.MD_TempHogueraMH3.PLCAddressValue = "40020"
        Me.MD_TempHogueraMH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempHogueraMH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_TempHogueraMH3.TabIndex = 875
        Me.MD_TempHogueraMH3.Value = 0R
        Me.MD_TempHogueraMH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_TempHogueraMH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_CascarillaXMminuMH3
        '
        Me.MD_CascarillaXMminuMH3.BackColor = System.Drawing.Color.Transparent
        Me.MD_CascarillaXMminuMH3.ComComponent = Me.MenuH3
        Me.MD_CascarillaXMminuMH3.DecimalPosition = 0
        Me.MD_CascarillaXMminuMH3.ForeColor = System.Drawing.Color.LightGray
        Me.MD_CascarillaXMminuMH3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_CascarillaXMminuMH3.KeypadMaxValue = 0R
        Me.MD_CascarillaXMminuMH3.KeypadMinValue = 0R
        Me.MD_CascarillaXMminuMH3.KeypadScaleFactor = 1.0R
        Me.MD_CascarillaXMminuMH3.KeypadText = Nothing
        Me.MD_CascarillaXMminuMH3.KeypadWidth = 300
        Me.MD_CascarillaXMminuMH3.Location = New System.Drawing.Point(688, 141)
        Me.MD_CascarillaXMminuMH3.Name = "MD_CascarillaXMminuMH3"
        Me.MD_CascarillaXMminuMH3.NumberOfDigits = 5
        Me.MD_CascarillaXMminuMH3.PLCAddressKeypad = ""
        Me.MD_CascarillaXMminuMH3.PLCAddressValue = "40556"
        Me.MD_CascarillaXMminuMH3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuMH3.Size = New System.Drawing.Size(113, 49)
        Me.MD_CascarillaXMminuMH3.TabIndex = 874
        Me.MD_CascarillaXMminuMH3.Value = 0R
        Me.MD_CascarillaXMminuMH3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_CascarillaXMminuMH3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_MenúP_MH1
        '
        Me.BCF_MenúP_MH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_MH1.ComComponent = Nothing
        Me.BCF_MenúP_MH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_MH1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_MH1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_MH1.KeypadWidth = 300
        Me.BCF_MenúP_MH1.Location = New System.Drawing.Point(250, 69)
        Me.BCF_MenúP_MH1.Name = "BCF_MenúP_MH1"
        Me.BCF_MenúP_MH1.Passcode = Nothing
        Me.BCF_MenúP_MH1.PasswordChar = False
        Me.BCF_MenúP_MH1.PLCAddressVisible = ""
        Me.BCF_MenúP_MH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_MH1.TabIndex = 873
        Me.BCF_MenúP_MH1.Text = "Menú Principal"
        Me.BCF_MenúP_MH1.UseVisualStyleBackColor = False
        '
        'Tex_TempMul2MH1
        '
        Me.Tex_TempMul2MH1.AutoSize = True
        Me.Tex_TempMul2MH1.BackColor = System.Drawing.Color.White
        Me.Tex_TempMul2MH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_TempMul2MH1.Location = New System.Drawing.Point(532, 164)
        Me.Tex_TempMul2MH1.Name = "Tex_TempMul2MH1"
        Me.Tex_TempMul2MH1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul2MH1.TabIndex = 872
        Me.Tex_TempMul2MH1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 2"
        Me.Tex_TempMul2MH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_GU12_MH1
        '
        Me.Tex_GU12_MH1.AutoSize = True
        Me.Tex_GU12_MH1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_GU12_MH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_GU12_MH1.Location = New System.Drawing.Point(221, 469)
        Me.Tex_GU12_MH1.Name = "Tex_GU12_MH1"
        Me.Tex_GU12_MH1.Size = New System.Drawing.Size(88, 18)
        Me.Tex_GU12_MH1.TabIndex = 871
        Me.Tex_GU12_MH1.Text = "Columnar 5"
        '
        'Tex_GU10_MH1
        '
        Me.Tex_GU10_MH1.AutoSize = True
        Me.Tex_GU10_MH1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_GU10_MH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_GU10_MH1.Location = New System.Drawing.Point(748, 469)
        Me.Tex_GU10_MH1.Name = "Tex_GU10_MH1"
        Me.Tex_GU10_MH1.Size = New System.Drawing.Size(88, 18)
        Me.Tex_GU10_MH1.TabIndex = 870
        Me.Tex_GU10_MH1.Text = "Columnar 3"
        '
        'I_SC05_MH3
        '
        Me.I_SC05_MH3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Columnar_D
        Me.I_SC05_MH3.Location = New System.Drawing.Point(193, 455)
        Me.I_SC05_MH3.Name = "I_SC05_MH3"
        Me.I_SC05_MH3.Size = New System.Drawing.Size(168, 214)
        Me.I_SC05_MH3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.I_SC05_MH3.TabIndex = 869
        Me.I_SC05_MH3.TabStop = False
        '
        'I_SC03_MH3
        '
        Me.I_SC03_MH3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Columnar_D
        Me.I_SC03_MH3.Location = New System.Drawing.Point(717, 455)
        Me.I_SC03_MH3.Name = "I_SC03_MH3"
        Me.I_SC03_MH3.Size = New System.Drawing.Size(168, 214)
        Me.I_SC03_MH3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.I_SC03_MH3.TabIndex = 868
        Me.I_SC03_MH3.TabStop = False
        '
        'Tex_GU11_MH1
        '
        Me.Tex_GU11_MH1.AutoSize = True
        Me.Tex_GU11_MH1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_GU11_MH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_GU11_MH1.Location = New System.Drawing.Point(486, 469)
        Me.Tex_GU11_MH1.Name = "Tex_GU11_MH1"
        Me.Tex_GU11_MH1.Size = New System.Drawing.Size(88, 18)
        Me.Tex_GU11_MH1.TabIndex = 867
        Me.Tex_GU11_MH1.Text = "Columnar 4"
        '
        'Tex_GU09_MH1
        '
        Me.Tex_GU09_MH1.AutoSize = True
        Me.Tex_GU09_MH1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_GU09_MH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_GU09_MH1.Location = New System.Drawing.Point(1011, 469)
        Me.Tex_GU09_MH1.Name = "Tex_GU09_MH1"
        Me.Tex_GU09_MH1.Size = New System.Drawing.Size(88, 18)
        Me.Tex_GU09_MH1.TabIndex = 866
        Me.Tex_GU09_MH1.Text = "Columnar 2"
        '
        'I_SC04_MH3
        '
        Me.I_SC04_MH3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Columnar_D
        Me.I_SC04_MH3.Location = New System.Drawing.Point(455, 455)
        Me.I_SC04_MH3.Name = "I_SC04_MH3"
        Me.I_SC04_MH3.Size = New System.Drawing.Size(168, 214)
        Me.I_SC04_MH3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.I_SC04_MH3.TabIndex = 865
        Me.I_SC04_MH3.TabStop = False
        '
        'I_SC02_MH3
        '
        Me.I_SC02_MH3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Secadora_Columnar_D
        Me.I_SC02_MH3.Location = New System.Drawing.Point(979, 455)
        Me.I_SC02_MH3.Name = "I_SC02_MH3"
        Me.I_SC02_MH3.Size = New System.Drawing.Size(168, 214)
        Me.I_SC02_MH3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.I_SC02_MH3.TabIndex = 864
        Me.I_SC02_MH3.TabStop = False
        '
        'Tex_MenuHorno1
        '
        Me.Tex_MenuHorno1.AutoSize = True
        Me.Tex_MenuHorno1.BackColor = System.Drawing.Color.DimGray
        Me.Tex_MenuHorno1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tex_MenuHorno1.ForeColor = System.Drawing.Color.White
        Me.Tex_MenuHorno1.Location = New System.Drawing.Point(591, 42)
        Me.Tex_MenuHorno1.Name = "Tex_MenuHorno1"
        Me.Tex_MenuHorno1.Size = New System.Drawing.Size(226, 34)
        Me.Tex_MenuHorno1.TabIndex = 863
        Me.Tex_MenuHorno1.Text = "Menu Horno 03"
        '
        'Tex_CargaMHorno1
        '
        Me.Tex_CargaMHorno1.AutoSize = True
        Me.Tex_CargaMHorno1.BackColor = System.Drawing.Color.White
        Me.Tex_CargaMHorno1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_CargaMHorno1.Location = New System.Drawing.Point(463, 268)
        Me.Tex_CargaMHorno1.Name = "Tex_CargaMHorno1"
        Me.Tex_CargaMHorno1.Size = New System.Drawing.Size(83, 36)
        Me.Tex_CargaMHorno1.TabIndex = 862
        Me.Tex_CargaMHorno1.Text = "Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Carga"
        Me.Tex_CargaMHorno1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempHogueraMH1
        '
        Me.Tex_TempHogueraMH1.AutoSize = True
        Me.Tex_TempHogueraMH1.BackColor = System.Drawing.Color.White
        Me.Tex_TempHogueraMH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_TempHogueraMH1.Location = New System.Drawing.Point(695, 204)
        Me.Tex_TempHogueraMH1.Name = "Tex_TempHogueraMH1"
        Me.Tex_TempHogueraMH1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempHogueraMH1.TabIndex = 861
        Me.Tex_TempHogueraMH1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hoguera"
        Me.Tex_TempHogueraMH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_CascarillaXMminuMH1
        '
        Me.Tex_CascarillaXMminuMH1.AutoSize = True
        Me.Tex_CascarillaXMminuMH1.BackColor = System.Drawing.Color.White
        Me.Tex_CascarillaXMminuMH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_CascarillaXMminuMH1.Location = New System.Drawing.Point(688, 102)
        Me.Tex_CascarillaXMminuMH1.Name = "Tex_CascarillaXMminuMH1"
        Me.Tex_CascarillaXMminuMH1.Size = New System.Drawing.Size(114, 36)
        Me.Tex_CascarillaXMminuMH1.TabIndex = 860
        Me.Tex_CascarillaXMminuMH1.Text = "Kgs. Cascarilla" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Minuto"
        Me.Tex_CascarillaXMminuMH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempChimeMH1
        '
        Me.Tex_TempChimeMH1.AutoSize = True
        Me.Tex_TempChimeMH1.BackColor = System.Drawing.Color.White
        Me.Tex_TempChimeMH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_TempChimeMH1.Location = New System.Drawing.Point(1051, 59)
        Me.Tex_TempChimeMH1.Name = "Tex_TempChimeMH1"
        Me.Tex_TempChimeMH1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempChimeMH1.TabIndex = 859
        Me.Tex_TempChimeMH1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chimenea"
        Me.Tex_TempChimeMH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tex_TempMul1MH1
        '
        Me.Tex_TempMul1MH1.AutoSize = True
        Me.Tex_TempMul1MH1.BackColor = System.Drawing.Color.White
        Me.Tex_TempMul1MH1.ForeColor = System.Drawing.Color.Blue
        Me.Tex_TempMul1MH1.Location = New System.Drawing.Point(491, 35)
        Me.Tex_TempMul1MH1.Name = "Tex_TempMul1MH1"
        Me.Tex_TempMul1MH1.Size = New System.Drawing.Size(99, 36)
        Me.Tex_TempMul1MH1.TabIndex = 858
        Me.Tex_TempMul1MH1.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiple 1"
        Me.Tex_TempMul1MH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IHorno3M
        '
        Me.IHorno3M.BackColor = System.Drawing.Color.Transparent
        Me.IHorno3M.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Horno_sdi_1
        Me.IHorno3M.Location = New System.Drawing.Point(620, 68)
        Me.IHorno3M.Name = "IHorno3M"
        Me.IHorno3M.Size = New System.Drawing.Size(535, 330)
        Me.IHorno3M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IHorno3M.TabIndex = 857
        Me.IHorno3M.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ducto_Recto_sin_F
        Me.PictureBox9.Location = New System.Drawing.Point(483, 164)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(40, 243)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 908
        Me.PictureBox9.TabStop = False
        '
        'Menú_Horno_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.TexRecetaMHorno3)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.BCF_H01_MH1)
        Me.Controls.Add(Me.BCF_SC05_MH3)
        Me.Controls.Add(Me.BCF_SC03_MH3)
        Me.Controls.Add(Me.MD_TempMH3SC05)
        Me.Controls.Add(Me.BCF_SC04_MH3)
        Me.Controls.Add(Me.BCF_SC02_MH3)
        Me.Controls.Add(Me.LS_MarchaMH3SC05)
        Me.Controls.Add(Me.MD_TempMH3SC04)
        Me.Controls.Add(Me.LS_MarchaMH3SC04)
        Me.Controls.Add(Me.MD_TempMH3SC03)
        Me.Controls.Add(Me.LS_MarchaMH3SC03)
        Me.Controls.Add(Me.MD_TempMH3SC02)
        Me.Controls.Add(Me.LS_MarchaMH3SC02)
        Me.Controls.Add(Me.LT_MHorno3)
        Me.Controls.Add(Me.MD_TempMul2MH3)
        Me.Controls.Add(Me.MD_TempMul1MH3)
        Me.Controls.Add(Me.MD_TempChimeMH3)
        Me.Controls.Add(Me.LS_MarchaMHorno3)
        Me.Controls.Add(Me.MD_CargaMHorno3)
        Me.Controls.Add(Me.MD_TempHogueraMH3)
        Me.Controls.Add(Me.MD_CascarillaXMminuMH3)
        Me.Controls.Add(Me.BCF_MenúP_MH1)
        Me.Controls.Add(Me.Tex_TempMul2MH1)
        Me.Controls.Add(Me.Tex_GU12_MH1)
        Me.Controls.Add(Me.Tex_GU10_MH1)
        Me.Controls.Add(Me.I_SC05_MH3)
        Me.Controls.Add(Me.I_SC03_MH3)
        Me.Controls.Add(Me.Tex_GU11_MH1)
        Me.Controls.Add(Me.Tex_GU09_MH1)
        Me.Controls.Add(Me.I_SC04_MH3)
        Me.Controls.Add(Me.I_SC02_MH3)
        Me.Controls.Add(Me.Tex_MenuHorno1)
        Me.Controls.Add(Me.Tex_CargaMHorno1)
        Me.Controls.Add(Me.Tex_TempHogueraMH1)
        Me.Controls.Add(Me.Tex_CascarillaXMminuMH1)
        Me.Controls.Add(Me.Tex_TempChimeMH1)
        Me.Controls.Add(Me.Tex_TempMul1MH1)
        Me.Controls.Add(Me.IHorno3M)
        Me.Controls.Add(Me.PictureBox9)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Menú_Horno_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MenuH3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.I_SC05_MH3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.I_SC03_MH3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.I_SC04_MH3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.I_SC02_MH3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IHorno3M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TexRecetaMHorno3 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MenuH3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents BCF_H01_MH1 As FormChangeButton
    Friend WithEvents BCF_SC05_MH3 As FormChangeButton
    Friend WithEvents BCF_SC03_MH3 As FormChangeButton
    Friend WithEvents MD_TempMH3SC05 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_SC04_MH3 As FormChangeButton
    Friend WithEvents BCF_SC02_MH3 As FormChangeButton
    Friend WithEvents LS_MarchaMH3SC05 As AdvancedHMIControls.PilotLight
    Friend WithEvents MD_TempMH3SC04 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents LS_MarchaMH3SC04 As AdvancedHMIControls.PilotLight
    Friend WithEvents MD_TempMH3SC03 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents LS_MarchaMH3SC03 As AdvancedHMIControls.PilotLight
    Friend WithEvents MD_TempMH3SC02 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents LS_MarchaMH3SC02 As AdvancedHMIControls.PilotLight
    Friend WithEvents LT_MHorno3 As AdvancedHMIControls.StackLight
    Friend WithEvents MD_TempMul2MH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempMul1MH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempChimeMH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents LS_MarchaMHorno3 As AdvancedHMIControls.PilotLight
    Friend WithEvents MD_CargaMHorno3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_TempHogueraMH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_CascarillaXMminuMH3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_MenúP_MH1 As FormChangeButton
    Friend WithEvents Tex_TempMul2MH1 As Label
    Friend WithEvents Tex_GU12_MH1 As Label
    Friend WithEvents Tex_GU10_MH1 As Label
    Friend WithEvents I_SC05_MH3 As PictureBox
    Friend WithEvents I_SC03_MH3 As PictureBox
    Friend WithEvents Tex_GU11_MH1 As Label
    Friend WithEvents Tex_GU09_MH1 As Label
    Friend WithEvents I_SC04_MH3 As PictureBox
    Friend WithEvents I_SC02_MH3 As PictureBox
    Friend WithEvents Tex_MenuHorno1 As Label
    Friend WithEvents Tex_CargaMHorno1 As Label
    Friend WithEvents Tex_TempHogueraMH1 As Label
    Friend WithEvents Tex_CascarillaXMminuMH1 As Label
    Friend WithEvents Tex_TempChimeMH1 As Label
    Friend WithEvents Tex_TempMul1MH1 As Label
    Friend WithEvents IHorno3M As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
