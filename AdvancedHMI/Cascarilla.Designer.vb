<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cascarilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cascarilla))
        Me.MessageListByValue1 = New AdvancedHMIControls.MessageListByValue()
        Me.Cacarilla = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.PilotLight8 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight7 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight6 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight5 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.LS_MaxDH3 = New AdvancedHMIControls.PilotLight()
        Me.LS_MinDH3 = New AdvancedHMIControls.PilotLight()
        Me.LS_V3aDH3 = New AdvancedHMIControls.PilotLight()
        Me.LS_V3aDH4 = New AdvancedHMIControls.PilotLight()
        Me.LS_MaxDH4 = New AdvancedHMIControls.PilotLight()
        Me.LS_MinDH4 = New AdvancedHMIControls.PilotLight()
        Me.LS_V2aV3 = New AdvancedHMIControls.PilotLight()
        Me.LS_V2aDH2 = New AdvancedHMIControls.PilotLight()
        Me.LS_MaxDH2 = New AdvancedHMIControls.PilotLight()
        Me.LS_MinDH2 = New AdvancedHMIControls.PilotLight()
        Me.LS_V1aV2 = New AdvancedHMIControls.PilotLight()
        Me.LS_VaDH1 = New AdvancedHMIControls.PilotLight()
        Me.LS_MaxDH1 = New AdvancedHMIControls.PilotLight()
        Me.LS_MinDH1 = New AdvancedHMIControls.PilotLight()
        Me.LS_Transportador = New AdvancedHMIControls.PilotLight()
        Me.LS_Elevador = New AdvancedHMIControls.PilotLight()
        Me.LS_Ventilador = New AdvancedHMIControls.PilotLight()
        Me.LS_Disificador = New AdvancedHMIControls.PilotLight()
        Me.MD_VentDS_Manu = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentEC_Manu = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentDS_Auto = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentEC_Auto = New AdvancedHMIControls.DigitalPanelMeter()
        Me.TexTiempDS = New System.Windows.Forms.Label()
        Me.TexTiempEC = New System.Windows.Forms.Label()
        Me.LS_SisTrabaCascarilla = New AdvancedHMIControls.PilotLight()
        Me.LS_SisMarchaCascarilla = New AdvancedHMIControls.PilotLight()
        Me.MD_VentVE_Manu = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentTH_Manu = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentVE_Auto = New AdvancedHMIControls.DigitalPanelMeter()
        Me.MD_VentTH_Auto = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BCF_MenúP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.TexHorasTrabajo = New System.Windows.Forms.Label()
        Me.TexTiempVE = New System.Windows.Forms.Label()
        Me.TexTiempTH = New System.Windows.Forms.Label()
        Me.TexHorasTrabajoManu = New System.Windows.Forms.Label()
        Me.TexHorasTrabajoAuto = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.IF_Cascarilla = New System.Windows.Forms.PictureBox()
        CType(Me.Cacarilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IF_Cascarilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MessageListByValue1
        '
        Me.MessageListByValue1.ComComponent = Me.Cacarilla
        Me.MessageListByValue1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MessageListByValue1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageListByValue1.FormattingEnabled = True
        Me.MessageListByValue1.IniFileName = Nothing
        Me.MessageListByValue1.Location = New System.Drawing.Point(245, 583)
        Me.MessageListByValue1.MaxMessagesInList = 50
        Me.MessageListByValue1.MessageNumberToIgnore = 0
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages8"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages9"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages10"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Messages.Add(CType(resources.GetObject("MessageListByValue1.Messages11"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageListByValue1.Name = "MessageListByValue1"
        Me.MessageListByValue1.PLCAddressValue = "40031"
        Me.MessageListByValue1.PLCAddressVisible = "10005"
        Me.MessageListByValue1.RemoveDuplicateMessages = False
        Me.MessageListByValue1.ShowMessageNumber = False
        Me.MessageListByValue1.ShowTimeStamp = False
        Me.MessageListByValue1.Size = New System.Drawing.Size(868, 43)
        Me.MessageListByValue1.TabIndex = 1152
        Me.MessageListByValue1.TimeStampFormat = "MM/dd/yyyy HH:mm:ss"
        Me.MessageListByValue1.Value = -1
        '
        'Cacarilla
        '
        Me.Cacarilla.DisableSubscriptions = False
        Me.Cacarilla.IniFileName = ""
        Me.Cacarilla.IniFileSection = Nothing
        Me.Cacarilla.IPAddress = "10.1.108.17"
        Me.Cacarilla.MaxReadGroupSize = 20
        Me.Cacarilla.PollRateOverride = 500
        Me.Cacarilla.SwapBytes = True
        Me.Cacarilla.SwapWords = False
        Me.Cacarilla.TcpipPort = CType(20257US, UShort)
        Me.Cacarilla.TimeOut = 3000
        Me.Cacarilla.UnitId = CType(15, Byte)
        '
        'PilotLight8
        '
        Me.PilotLight8.Blink = False
        Me.PilotLight8.ComComponent = Me.Cacarilla
        Me.PilotLight8.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight8.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight8.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight8.Location = New System.Drawing.Point(456, 48)
        Me.PilotLight8.Name = "PilotLight8"
        Me.PilotLight8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight8.PLCAddressClick = "10067"
        Me.PilotLight8.PLCAddressText = ""
        Me.PilotLight8.PLCAddressValue = "10005"
        Me.PilotLight8.PLCAddressVisible = "10005"
        Me.PilotLight8.Size = New System.Drawing.Size(94, 138)
        Me.PilotLight8.TabIndex = 1151
        Me.PilotLight8.Text = "Falla"
        Me.PilotLight8.Value = False
        Me.PilotLight8.ValueToWrite = 0
        '
        'PilotLight7
        '
        Me.PilotLight7.Blink = False
        Me.PilotLight7.ComComponent = Me.Cacarilla
        Me.PilotLight7.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight7.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight7.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight7.Location = New System.Drawing.Point(626, 392)
        Me.PilotLight7.Name = "PilotLight7"
        Me.PilotLight7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight7.PLCAddressClick = ""
        Me.PilotLight7.PLCAddressText = ""
        Me.PilotLight7.PLCAddressValue = "10584"
        Me.PilotLight7.PLCAddressVisible = ""
        Me.PilotLight7.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight7.TabIndex = 1150
        Me.PilotLight7.Value = False
        Me.PilotLight7.ValueToWrite = 0
        '
        'PilotLight6
        '
        Me.PilotLight6.Blink = False
        Me.PilotLight6.ComComponent = Me.Cacarilla
        Me.PilotLight6.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight6.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight6.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight6.Location = New System.Drawing.Point(474, 392)
        Me.PilotLight6.Name = "PilotLight6"
        Me.PilotLight6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight6.PLCAddressClick = ""
        Me.PilotLight6.PLCAddressText = ""
        Me.PilotLight6.PLCAddressValue = "10585"
        Me.PilotLight6.PLCAddressVisible = ""
        Me.PilotLight6.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight6.TabIndex = 1149
        Me.PilotLight6.Value = False
        Me.PilotLight6.ValueToWrite = 0
        '
        'PilotLight5
        '
        Me.PilotLight5.Blink = False
        Me.PilotLight5.ComComponent = Me.Cacarilla
        Me.PilotLight5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight5.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight5.Location = New System.Drawing.Point(323, 392)
        Me.PilotLight5.Name = "PilotLight5"
        Me.PilotLight5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight5.PLCAddressClick = ""
        Me.PilotLight5.PLCAddressText = ""
        Me.PilotLight5.PLCAddressValue = "10587"
        Me.PilotLight5.PLCAddressVisible = ""
        Me.PilotLight5.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight5.TabIndex = 1148
        Me.PilotLight5.Value = False
        Me.PilotLight5.ValueToWrite = 0
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.Cacarilla
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(166, 392)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "10586"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight4.TabIndex = 1147
        Me.PilotLight4.Value = False
        Me.PilotLight4.ValueToWrite = 0
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.Cacarilla
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(874, 520)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "10595"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight3.TabIndex = 1146
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.Cacarilla
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(886, 286)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "10572"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight1.TabIndex = 1145
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.Cacarilla
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(886, 374)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "10571"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(24, 25)
        Me.PilotLight2.TabIndex = 1144
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'LS_MaxDH3
        '
        Me.LS_MaxDH3.Blink = False
        Me.LS_MaxDH3.ComComponent = Me.Cacarilla
        Me.LS_MaxDH3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MaxDH3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MaxDH3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MaxDH3.Location = New System.Drawing.Point(199, 336)
        Me.LS_MaxDH3.Name = "LS_MaxDH3"
        Me.LS_MaxDH3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MaxDH3.PLCAddressClick = ""
        Me.LS_MaxDH3.PLCAddressText = ""
        Me.LS_MaxDH3.PLCAddressValue = "10540"
        Me.LS_MaxDH3.PLCAddressVisible = ""
        Me.LS_MaxDH3.Size = New System.Drawing.Size(24, 25)
        Me.LS_MaxDH3.TabIndex = 1143
        Me.LS_MaxDH3.Value = False
        Me.LS_MaxDH3.ValueToWrite = 0
        '
        'LS_MinDH3
        '
        Me.LS_MinDH3.Blink = False
        Me.LS_MinDH3.ComComponent = Me.Cacarilla
        Me.LS_MinDH3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MinDH3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MinDH3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MinDH3.Location = New System.Drawing.Point(199, 424)
        Me.LS_MinDH3.Name = "LS_MinDH3"
        Me.LS_MinDH3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MinDH3.PLCAddressClick = ""
        Me.LS_MinDH3.PLCAddressText = ""
        Me.LS_MinDH3.PLCAddressValue = "10539"
        Me.LS_MinDH3.PLCAddressVisible = ""
        Me.LS_MinDH3.Size = New System.Drawing.Size(24, 25)
        Me.LS_MinDH3.TabIndex = 1142
        Me.LS_MinDH3.Value = False
        Me.LS_MinDH3.ValueToWrite = 0
        '
        'LS_V3aDH3
        '
        Me.LS_V3aDH3.Blink = False
        Me.LS_V3aDH3.ComComponent = Me.Cacarilla
        Me.LS_V3aDH3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_V3aDH3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_V3aDH3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_V3aDH3.Location = New System.Drawing.Point(375, 485)
        Me.LS_V3aDH3.Name = "LS_V3aDH3"
        Me.LS_V3aDH3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_V3aDH3.PLCAddressClick = ""
        Me.LS_V3aDH3.PLCAddressText = ""
        Me.LS_V3aDH3.PLCAddressValue = "10556"
        Me.LS_V3aDH3.PLCAddressVisible = ""
        Me.LS_V3aDH3.Size = New System.Drawing.Size(24, 25)
        Me.LS_V3aDH3.TabIndex = 1141
        Me.LS_V3aDH3.Value = False
        Me.LS_V3aDH3.ValueToWrite = 0
        '
        'LS_V3aDH4
        '
        Me.LS_V3aDH4.Blink = False
        Me.LS_V3aDH4.ComComponent = Me.Cacarilla
        Me.LS_V3aDH4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_V3aDH4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_V3aDH4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_V3aDH4.Location = New System.Drawing.Point(427, 433)
        Me.LS_V3aDH4.Name = "LS_V3aDH4"
        Me.LS_V3aDH4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_V3aDH4.PLCAddressClick = ""
        Me.LS_V3aDH4.PLCAddressText = ""
        Me.LS_V3aDH4.PLCAddressValue = "10555"
        Me.LS_V3aDH4.PLCAddressVisible = ""
        Me.LS_V3aDH4.Size = New System.Drawing.Size(24, 25)
        Me.LS_V3aDH4.TabIndex = 1140
        Me.LS_V3aDH4.Value = False
        Me.LS_V3aDH4.ValueToWrite = 0
        '
        'LS_MaxDH4
        '
        Me.LS_MaxDH4.Blink = False
        Me.LS_MaxDH4.ComComponent = Me.Cacarilla
        Me.LS_MaxDH4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MaxDH4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MaxDH4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MaxDH4.Location = New System.Drawing.Point(355, 336)
        Me.LS_MaxDH4.Name = "LS_MaxDH4"
        Me.LS_MaxDH4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MaxDH4.PLCAddressClick = ""
        Me.LS_MaxDH4.PLCAddressText = ""
        Me.LS_MaxDH4.PLCAddressValue = "10550"
        Me.LS_MaxDH4.PLCAddressVisible = ""
        Me.LS_MaxDH4.Size = New System.Drawing.Size(24, 25)
        Me.LS_MaxDH4.TabIndex = 1139
        Me.LS_MaxDH4.Value = False
        Me.LS_MaxDH4.ValueToWrite = 0
        '
        'LS_MinDH4
        '
        Me.LS_MinDH4.Blink = False
        Me.LS_MinDH4.ComComponent = Me.Cacarilla
        Me.LS_MinDH4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MinDH4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MinDH4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MinDH4.Location = New System.Drawing.Point(355, 424)
        Me.LS_MinDH4.Name = "LS_MinDH4"
        Me.LS_MinDH4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MinDH4.PLCAddressClick = ""
        Me.LS_MinDH4.PLCAddressText = ""
        Me.LS_MinDH4.PLCAddressValue = "10549"
        Me.LS_MinDH4.PLCAddressVisible = ""
        Me.LS_MinDH4.Size = New System.Drawing.Size(24, 25)
        Me.LS_MinDH4.TabIndex = 1138
        Me.LS_MinDH4.Value = False
        Me.LS_MinDH4.ValueToWrite = 0
        '
        'LS_V2aV3
        '
        Me.LS_V2aV3.Blink = False
        Me.LS_V2aV3.ComComponent = Me.Cacarilla
        Me.LS_V2aV3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_V2aV3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_V2aV3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_V2aV3.Location = New System.Drawing.Point(559, 486)
        Me.LS_V2aV3.Name = "LS_V2aV3"
        Me.LS_V2aV3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_V2aV3.PLCAddressClick = ""
        Me.LS_V2aV3.PLCAddressText = ""
        Me.LS_V2aV3.PLCAddressValue = "10553"
        Me.LS_V2aV3.PLCAddressVisible = ""
        Me.LS_V2aV3.Size = New System.Drawing.Size(24, 25)
        Me.LS_V2aV3.TabIndex = 1137
        Me.LS_V2aV3.Value = False
        Me.LS_V2aV3.ValueToWrite = 0
        '
        'LS_V2aDH2
        '
        Me.LS_V2aDH2.Blink = False
        Me.LS_V2aDH2.ComComponent = Me.Cacarilla
        Me.LS_V2aDH2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_V2aDH2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_V2aDH2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_V2aDH2.Location = New System.Drawing.Point(584, 441)
        Me.LS_V2aDH2.Name = "LS_V2aDH2"
        Me.LS_V2aDH2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_V2aDH2.PLCAddressClick = ""
        Me.LS_V2aDH2.PLCAddressText = ""
        Me.LS_V2aDH2.PLCAddressValue = "10554"
        Me.LS_V2aDH2.PLCAddressVisible = ""
        Me.LS_V2aDH2.Size = New System.Drawing.Size(24, 25)
        Me.LS_V2aDH2.TabIndex = 1136
        Me.LS_V2aDH2.Value = False
        Me.LS_V2aDH2.ValueToWrite = 0
        '
        'LS_MaxDH2
        '
        Me.LS_MaxDH2.Blink = False
        Me.LS_MaxDH2.ComComponent = Me.Cacarilla
        Me.LS_MaxDH2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MaxDH2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MaxDH2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MaxDH2.Location = New System.Drawing.Point(505, 336)
        Me.LS_MaxDH2.Name = "LS_MaxDH2"
        Me.LS_MaxDH2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MaxDH2.PLCAddressClick = ""
        Me.LS_MaxDH2.PLCAddressText = ""
        Me.LS_MaxDH2.PLCAddressValue = "10538"
        Me.LS_MaxDH2.PLCAddressVisible = ""
        Me.LS_MaxDH2.Size = New System.Drawing.Size(24, 25)
        Me.LS_MaxDH2.TabIndex = 1135
        Me.LS_MaxDH2.Value = False
        Me.LS_MaxDH2.ValueToWrite = 0
        '
        'LS_MinDH2
        '
        Me.LS_MinDH2.Blink = False
        Me.LS_MinDH2.ComComponent = Me.Cacarilla
        Me.LS_MinDH2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MinDH2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MinDH2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MinDH2.Location = New System.Drawing.Point(505, 424)
        Me.LS_MinDH2.Name = "LS_MinDH2"
        Me.LS_MinDH2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MinDH2.PLCAddressClick = ""
        Me.LS_MinDH2.PLCAddressText = ""
        Me.LS_MinDH2.PLCAddressValue = "10537"
        Me.LS_MinDH2.PLCAddressVisible = ""
        Me.LS_MinDH2.Size = New System.Drawing.Size(24, 25)
        Me.LS_MinDH2.TabIndex = 1134
        Me.LS_MinDH2.Value = False
        Me.LS_MinDH2.ValueToWrite = 0
        '
        'LS_V1aV2
        '
        Me.LS_V1aV2.Blink = False
        Me.LS_V1aV2.ComComponent = Me.Cacarilla
        Me.LS_V1aV2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_V1aV2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_V1aV2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_V1aV2.Location = New System.Drawing.Point(720, 486)
        Me.LS_V1aV2.Name = "LS_V1aV2"
        Me.LS_V1aV2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_V1aV2.PLCAddressClick = ""
        Me.LS_V1aV2.PLCAddressText = ""
        Me.LS_V1aV2.PLCAddressValue = "10551"
        Me.LS_V1aV2.PLCAddressVisible = ""
        Me.LS_V1aV2.Size = New System.Drawing.Size(24, 25)
        Me.LS_V1aV2.TabIndex = 1133
        Me.LS_V1aV2.Value = False
        Me.LS_V1aV2.ValueToWrite = 0
        '
        'LS_VaDH1
        '
        Me.LS_VaDH1.Blink = False
        Me.LS_VaDH1.ComComponent = Me.Cacarilla
        Me.LS_VaDH1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_VaDH1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_VaDH1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_VaDH1.Location = New System.Drawing.Point(740, 441)
        Me.LS_VaDH1.Name = "LS_VaDH1"
        Me.LS_VaDH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_VaDH1.PLCAddressClick = ""
        Me.LS_VaDH1.PLCAddressText = ""
        Me.LS_VaDH1.PLCAddressValue = "10552"
        Me.LS_VaDH1.PLCAddressVisible = ""
        Me.LS_VaDH1.Size = New System.Drawing.Size(24, 25)
        Me.LS_VaDH1.TabIndex = 1132
        Me.LS_VaDH1.Value = False
        Me.LS_VaDH1.ValueToWrite = 0
        '
        'LS_MaxDH1
        '
        Me.LS_MaxDH1.Blink = False
        Me.LS_MaxDH1.ComComponent = Me.Cacarilla
        Me.LS_MaxDH1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MaxDH1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MaxDH1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MaxDH1.Location = New System.Drawing.Point(656, 336)
        Me.LS_MaxDH1.Name = "LS_MaxDH1"
        Me.LS_MaxDH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MaxDH1.PLCAddressClick = ""
        Me.LS_MaxDH1.PLCAddressText = ""
        Me.LS_MaxDH1.PLCAddressValue = "10536"
        Me.LS_MaxDH1.PLCAddressVisible = ""
        Me.LS_MaxDH1.Size = New System.Drawing.Size(24, 25)
        Me.LS_MaxDH1.TabIndex = 1131
        Me.LS_MaxDH1.Value = False
        Me.LS_MaxDH1.ValueToWrite = 0
        '
        'LS_MinDH1
        '
        Me.LS_MinDH1.Blink = False
        Me.LS_MinDH1.ComComponent = Me.Cacarilla
        Me.LS_MinDH1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_MinDH1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_MinDH1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_MinDH1.Location = New System.Drawing.Point(656, 424)
        Me.LS_MinDH1.Name = "LS_MinDH1"
        Me.LS_MinDH1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_MinDH1.PLCAddressClick = ""
        Me.LS_MinDH1.PLCAddressText = ""
        Me.LS_MinDH1.PLCAddressValue = "10535"
        Me.LS_MinDH1.PLCAddressVisible = ""
        Me.LS_MinDH1.Size = New System.Drawing.Size(24, 25)
        Me.LS_MinDH1.TabIndex = 1130
        Me.LS_MinDH1.Value = False
        Me.LS_MinDH1.ValueToWrite = 0
        '
        'LS_Transportador
        '
        Me.LS_Transportador.Blink = False
        Me.LS_Transportador.ComComponent = Me.Cacarilla
        Me.LS_Transportador.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_Transportador.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_Transportador.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_Transportador.Location = New System.Drawing.Point(1015, 348)
        Me.LS_Transportador.Name = "LS_Transportador"
        Me.LS_Transportador.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_Transportador.PLCAddressClick = ""
        Me.LS_Transportador.PLCAddressText = ""
        Me.LS_Transportador.PLCAddressValue = "10592"
        Me.LS_Transportador.PLCAddressVisible = ""
        Me.LS_Transportador.Size = New System.Drawing.Size(24, 25)
        Me.LS_Transportador.TabIndex = 1129
        Me.LS_Transportador.Value = False
        Me.LS_Transportador.ValueToWrite = 0
        '
        'LS_Elevador
        '
        Me.LS_Elevador.Blink = False
        Me.LS_Elevador.ComComponent = Me.Cacarilla
        Me.LS_Elevador.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_Elevador.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_Elevador.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_Elevador.Location = New System.Drawing.Point(1016, 241)
        Me.LS_Elevador.Name = "LS_Elevador"
        Me.LS_Elevador.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_Elevador.PLCAddressClick = ""
        Me.LS_Elevador.PLCAddressText = ""
        Me.LS_Elevador.PLCAddressValue = "10594"
        Me.LS_Elevador.PLCAddressVisible = ""
        Me.LS_Elevador.Size = New System.Drawing.Size(24, 25)
        Me.LS_Elevador.TabIndex = 1128
        Me.LS_Elevador.Value = False
        Me.LS_Elevador.ValueToWrite = 0
        '
        'LS_Ventilador
        '
        Me.LS_Ventilador.Blink = False
        Me.LS_Ventilador.ComComponent = Me.Cacarilla
        Me.LS_Ventilador.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_Ventilador.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_Ventilador.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_Ventilador.Location = New System.Drawing.Point(929, 465)
        Me.LS_Ventilador.Name = "LS_Ventilador"
        Me.LS_Ventilador.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_Ventilador.PLCAddressClick = ""
        Me.LS_Ventilador.PLCAddressText = ""
        Me.LS_Ventilador.PLCAddressValue = "10593"
        Me.LS_Ventilador.PLCAddressVisible = ""
        Me.LS_Ventilador.Size = New System.Drawing.Size(24, 25)
        Me.LS_Ventilador.TabIndex = 1127
        Me.LS_Ventilador.Value = False
        Me.LS_Ventilador.ValueToWrite = 0
        '
        'LS_Disificador
        '
        Me.LS_Disificador.Blink = False
        Me.LS_Disificador.ComComponent = Me.Cacarilla
        Me.LS_Disificador.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.LS_Disificador.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_Disificador.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_Disificador.Location = New System.Drawing.Point(915, 415)
        Me.LS_Disificador.Name = "LS_Disificador"
        Me.LS_Disificador.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_Disificador.PLCAddressClick = ""
        Me.LS_Disificador.PLCAddressText = ""
        Me.LS_Disificador.PLCAddressValue = "10074"
        Me.LS_Disificador.PLCAddressVisible = ""
        Me.LS_Disificador.Size = New System.Drawing.Size(24, 25)
        Me.LS_Disificador.TabIndex = 1126
        Me.LS_Disificador.Value = False
        Me.LS_Disificador.ValueToWrite = 0
        '
        'MD_VentDS_Manu
        '
        Me.MD_VentDS_Manu.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentDS_Manu.ComComponent = Me.Cacarilla
        Me.MD_VentDS_Manu.DecimalPosition = 0
        Me.MD_VentDS_Manu.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentDS_Manu.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentDS_Manu.KeypadMaxValue = 0R
        Me.MD_VentDS_Manu.KeypadMinValue = 0R
        Me.MD_VentDS_Manu.KeypadScaleFactor = 1.0R
        Me.MD_VentDS_Manu.KeypadText = Nothing
        Me.MD_VentDS_Manu.KeypadWidth = 300
        Me.MD_VentDS_Manu.Location = New System.Drawing.Point(842, 214)
        Me.MD_VentDS_Manu.Name = "MD_VentDS_Manu"
        Me.MD_VentDS_Manu.NumberOfDigits = 5
        Me.MD_VentDS_Manu.PLCAddressKeypad = ""
        Me.MD_VentDS_Manu.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentDS_Manu.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentDS_Manu.TabIndex = 1125
        Me.MD_VentDS_Manu.Value = 0R
        Me.MD_VentDS_Manu.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentDS_Manu.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentEC_Manu
        '
        Me.MD_VentEC_Manu.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentEC_Manu.ComComponent = Me.Cacarilla
        Me.MD_VentEC_Manu.DecimalPosition = 0
        Me.MD_VentEC_Manu.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentEC_Manu.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentEC_Manu.KeypadMaxValue = 0R
        Me.MD_VentEC_Manu.KeypadMinValue = 0R
        Me.MD_VentEC_Manu.KeypadScaleFactor = 1.0R
        Me.MD_VentEC_Manu.KeypadText = Nothing
        Me.MD_VentEC_Manu.KeypadWidth = 300
        Me.MD_VentEC_Manu.Location = New System.Drawing.Point(842, 175)
        Me.MD_VentEC_Manu.Name = "MD_VentEC_Manu"
        Me.MD_VentEC_Manu.NumberOfDigits = 5
        Me.MD_VentEC_Manu.PLCAddressKeypad = ""
        Me.MD_VentEC_Manu.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentEC_Manu.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentEC_Manu.TabIndex = 1124
        Me.MD_VentEC_Manu.Value = 0R
        Me.MD_VentEC_Manu.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentEC_Manu.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentDS_Auto
        '
        Me.MD_VentDS_Auto.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentDS_Auto.ComComponent = Me.Cacarilla
        Me.MD_VentDS_Auto.DecimalPosition = 0
        Me.MD_VentDS_Auto.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentDS_Auto.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentDS_Auto.KeypadMaxValue = 0R
        Me.MD_VentDS_Auto.KeypadMinValue = 0R
        Me.MD_VentDS_Auto.KeypadScaleFactor = 1.0R
        Me.MD_VentDS_Auto.KeypadText = Nothing
        Me.MD_VentDS_Auto.KeypadWidth = 300
        Me.MD_VentDS_Auto.Location = New System.Drawing.Point(717, 214)
        Me.MD_VentDS_Auto.Name = "MD_VentDS_Auto"
        Me.MD_VentDS_Auto.NumberOfDigits = 5
        Me.MD_VentDS_Auto.PLCAddressKeypad = ""
        Me.MD_VentDS_Auto.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentDS_Auto.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentDS_Auto.TabIndex = 1123
        Me.MD_VentDS_Auto.Value = 0R
        Me.MD_VentDS_Auto.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentDS_Auto.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentEC_Auto
        '
        Me.MD_VentEC_Auto.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentEC_Auto.ComComponent = Me.Cacarilla
        Me.MD_VentEC_Auto.DecimalPosition = 0
        Me.MD_VentEC_Auto.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentEC_Auto.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentEC_Auto.KeypadMaxValue = 0R
        Me.MD_VentEC_Auto.KeypadMinValue = 0R
        Me.MD_VentEC_Auto.KeypadScaleFactor = 1.0R
        Me.MD_VentEC_Auto.KeypadText = Nothing
        Me.MD_VentEC_Auto.KeypadWidth = 300
        Me.MD_VentEC_Auto.Location = New System.Drawing.Point(717, 175)
        Me.MD_VentEC_Auto.Name = "MD_VentEC_Auto"
        Me.MD_VentEC_Auto.NumberOfDigits = 5
        Me.MD_VentEC_Auto.PLCAddressKeypad = ""
        Me.MD_VentEC_Auto.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentEC_Auto.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentEC_Auto.TabIndex = 1122
        Me.MD_VentEC_Auto.Value = 0R
        Me.MD_VentEC_Auto.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentEC_Auto.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TexTiempDS
        '
        Me.TexTiempDS.AutoSize = True
        Me.TexTiempDS.ForeColor = System.Drawing.Color.White
        Me.TexTiempDS.Location = New System.Drawing.Point(676, 218)
        Me.TexTiempDS.Name = "TexTiempDS"
        Me.TexTiempDS.Size = New System.Drawing.Size(31, 18)
        Me.TexTiempDS.TabIndex = 1121
        Me.TexTiempDS.Text = "DS"
        '
        'TexTiempEC
        '
        Me.TexTiempEC.AutoSize = True
        Me.TexTiempEC.ForeColor = System.Drawing.Color.White
        Me.TexTiempEC.Location = New System.Drawing.Point(675, 179)
        Me.TexTiempEC.Name = "TexTiempEC"
        Me.TexTiempEC.Size = New System.Drawing.Size(31, 18)
        Me.TexTiempEC.TabIndex = 1120
        Me.TexTiempEC.Text = "EC"
        '
        'LS_SisTrabaCascarilla
        '
        Me.LS_SisTrabaCascarilla.Blink = False
        Me.LS_SisTrabaCascarilla.ComComponent = Me.Cacarilla
        Me.LS_SisTrabaCascarilla.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.LS_SisTrabaCascarilla.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_SisTrabaCascarilla.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_SisTrabaCascarilla.Location = New System.Drawing.Point(305, 48)
        Me.LS_SisTrabaCascarilla.Name = "LS_SisTrabaCascarilla"
        Me.LS_SisTrabaCascarilla.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_SisTrabaCascarilla.PLCAddressClick = ""
        Me.LS_SisTrabaCascarilla.PLCAddressText = ""
        Me.LS_SisTrabaCascarilla.PLCAddressValue = "10039"
        Me.LS_SisTrabaCascarilla.PLCAddressVisible = ""
        Me.LS_SisTrabaCascarilla.Size = New System.Drawing.Size(94, 138)
        Me.LS_SisTrabaCascarilla.TabIndex = 1119
        Me.LS_SisTrabaCascarilla.Text = "Sistema en Trabajo"
        Me.LS_SisTrabaCascarilla.Value = False
        Me.LS_SisTrabaCascarilla.ValueToWrite = 0
        '
        'LS_SisMarchaCascarilla
        '
        Me.LS_SisMarchaCascarilla.Blink = False
        Me.LS_SisMarchaCascarilla.ComComponent = Me.Cacarilla
        Me.LS_SisMarchaCascarilla.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.LS_SisMarchaCascarilla.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.LS_SisMarchaCascarilla.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.LS_SisMarchaCascarilla.Location = New System.Drawing.Point(177, 48)
        Me.LS_SisMarchaCascarilla.Name = "LS_SisMarchaCascarilla"
        Me.LS_SisMarchaCascarilla.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS_SisMarchaCascarilla.PLCAddressClick = ""
        Me.LS_SisMarchaCascarilla.PLCAddressText = ""
        Me.LS_SisMarchaCascarilla.PLCAddressValue = "10004"
        Me.LS_SisMarchaCascarilla.PLCAddressVisible = ""
        Me.LS_SisMarchaCascarilla.Size = New System.Drawing.Size(94, 138)
        Me.LS_SisMarchaCascarilla.TabIndex = 1118
        Me.LS_SisMarchaCascarilla.Text = "Sistema en Marcha"
        Me.LS_SisMarchaCascarilla.Value = False
        Me.LS_SisMarchaCascarilla.ValueToWrite = 0
        '
        'MD_VentVE_Manu
        '
        Me.MD_VentVE_Manu.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentVE_Manu.ComComponent = Me.Cacarilla
        Me.MD_VentVE_Manu.DecimalPosition = 0
        Me.MD_VentVE_Manu.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentVE_Manu.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentVE_Manu.KeypadMaxValue = 0R
        Me.MD_VentVE_Manu.KeypadMinValue = 0R
        Me.MD_VentVE_Manu.KeypadScaleFactor = 1.0R
        Me.MD_VentVE_Manu.KeypadText = Nothing
        Me.MD_VentVE_Manu.KeypadWidth = 300
        Me.MD_VentVE_Manu.Location = New System.Drawing.Point(842, 134)
        Me.MD_VentVE_Manu.Name = "MD_VentVE_Manu"
        Me.MD_VentVE_Manu.NumberOfDigits = 5
        Me.MD_VentVE_Manu.PLCAddressKeypad = ""
        Me.MD_VentVE_Manu.PLCAddressValue = "40036"
        Me.MD_VentVE_Manu.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentVE_Manu.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentVE_Manu.TabIndex = 1117
        Me.MD_VentVE_Manu.Value = 0R
        Me.MD_VentVE_Manu.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentVE_Manu.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentTH_Manu
        '
        Me.MD_VentTH_Manu.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentTH_Manu.ComComponent = Me.Cacarilla
        Me.MD_VentTH_Manu.DecimalPosition = 0
        Me.MD_VentTH_Manu.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentTH_Manu.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentTH_Manu.KeypadMaxValue = 0R
        Me.MD_VentTH_Manu.KeypadMinValue = 0R
        Me.MD_VentTH_Manu.KeypadScaleFactor = 1.0R
        Me.MD_VentTH_Manu.KeypadText = Nothing
        Me.MD_VentTH_Manu.KeypadWidth = 300
        Me.MD_VentTH_Manu.Location = New System.Drawing.Point(842, 95)
        Me.MD_VentTH_Manu.Name = "MD_VentTH_Manu"
        Me.MD_VentTH_Manu.NumberOfDigits = 5
        Me.MD_VentTH_Manu.PLCAddressKeypad = ""
        Me.MD_VentTH_Manu.PLCAddressValue = "40039"
        Me.MD_VentTH_Manu.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentTH_Manu.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentTH_Manu.TabIndex = 1116
        Me.MD_VentTH_Manu.Value = 0R
        Me.MD_VentTH_Manu.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentTH_Manu.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentVE_Auto
        '
        Me.MD_VentVE_Auto.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentVE_Auto.ComComponent = Me.Cacarilla
        Me.MD_VentVE_Auto.DecimalPosition = 0
        Me.MD_VentVE_Auto.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentVE_Auto.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentVE_Auto.KeypadMaxValue = 0R
        Me.MD_VentVE_Auto.KeypadMinValue = 0R
        Me.MD_VentVE_Auto.KeypadScaleFactor = 1.0R
        Me.MD_VentVE_Auto.KeypadText = Nothing
        Me.MD_VentVE_Auto.KeypadWidth = 300
        Me.MD_VentVE_Auto.Location = New System.Drawing.Point(717, 134)
        Me.MD_VentVE_Auto.Name = "MD_VentVE_Auto"
        Me.MD_VentVE_Auto.NumberOfDigits = 5
        Me.MD_VentVE_Auto.PLCAddressKeypad = ""
        Me.MD_VentVE_Auto.PLCAddressValue = "40023"
        Me.MD_VentVE_Auto.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentVE_Auto.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentVE_Auto.TabIndex = 1115
        Me.MD_VentVE_Auto.Value = 0R
        Me.MD_VentVE_Auto.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentVE_Auto.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MD_VentTH_Auto
        '
        Me.MD_VentTH_Auto.BackColor = System.Drawing.Color.Transparent
        Me.MD_VentTH_Auto.ComComponent = Me.Cacarilla
        Me.MD_VentTH_Auto.DecimalPosition = 0
        Me.MD_VentTH_Auto.ForeColor = System.Drawing.Color.LightGray
        Me.MD_VentTH_Auto.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MD_VentTH_Auto.KeypadMaxValue = 0R
        Me.MD_VentTH_Auto.KeypadMinValue = 0R
        Me.MD_VentTH_Auto.KeypadScaleFactor = 1.0R
        Me.MD_VentTH_Auto.KeypadText = Nothing
        Me.MD_VentTH_Auto.KeypadWidth = 300
        Me.MD_VentTH_Auto.Location = New System.Drawing.Point(717, 95)
        Me.MD_VentTH_Auto.Name = "MD_VentTH_Auto"
        Me.MD_VentTH_Auto.NumberOfDigits = 5
        Me.MD_VentTH_Auto.PLCAddressKeypad = ""
        Me.MD_VentTH_Auto.PLCAddressValue = "40026"
        Me.MD_VentTH_Auto.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentTH_Auto.Size = New System.Drawing.Size(77, 33)
        Me.MD_VentTH_Auto.TabIndex = 1114
        Me.MD_VentTH_Auto.Value = 0R
        Me.MD_VentTH_Auto.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MD_VentTH_Auto.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BCF_MenúP_Cascarilla
        '
        Me.BCF_MenúP_Cascarilla.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_Cascarilla.ComComponent = Nothing
        Me.BCF_MenúP_Cascarilla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_Cascarilla.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_Cascarilla.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_Cascarilla.KeypadWidth = 300
        Me.BCF_MenúP_Cascarilla.Location = New System.Drawing.Point(609, 650)
        Me.BCF_MenúP_Cascarilla.Name = "BCF_MenúP_Cascarilla"
        Me.BCF_MenúP_Cascarilla.Passcode = Nothing
        Me.BCF_MenúP_Cascarilla.PasswordChar = False
        Me.BCF_MenúP_Cascarilla.PLCAddressVisible = ""
        Me.BCF_MenúP_Cascarilla.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_Cascarilla.TabIndex = 1113
        Me.BCF_MenúP_Cascarilla.Text = "Menú Principal"
        Me.BCF_MenúP_Cascarilla.UseVisualStyleBackColor = False
        '
        'TexHorasTrabajo
        '
        Me.TexHorasTrabajo.AutoSize = True
        Me.TexHorasTrabajo.ForeColor = System.Drawing.Color.White
        Me.TexHorasTrabajo.Location = New System.Drawing.Point(753, 48)
        Me.TexHorasTrabajo.Name = "TexHorasTrabajo"
        Me.TexHorasTrabajo.Size = New System.Drawing.Size(128, 18)
        Me.TexHorasTrabajo.TabIndex = 1111
        Me.TexHorasTrabajo.Text = "Horas de Trabajo"
        '
        'TexTiempVE
        '
        Me.TexTiempVE.AutoSize = True
        Me.TexTiempVE.ForeColor = System.Drawing.Color.White
        Me.TexTiempVE.Location = New System.Drawing.Point(676, 138)
        Me.TexTiempVE.Name = "TexTiempVE"
        Me.TexTiempVE.Size = New System.Drawing.Size(30, 18)
        Me.TexTiempVE.TabIndex = 1110
        Me.TexTiempVE.Text = "VE"
        '
        'TexTiempTH
        '
        Me.TexTiempTH.AutoSize = True
        Me.TexTiempTH.ForeColor = System.Drawing.Color.White
        Me.TexTiempTH.Location = New System.Drawing.Point(675, 99)
        Me.TexTiempTH.Name = "TexTiempTH"
        Me.TexTiempTH.Size = New System.Drawing.Size(28, 18)
        Me.TexTiempTH.TabIndex = 1109
        Me.TexTiempTH.Text = "TH"
        '
        'TexHorasTrabajoManu
        '
        Me.TexHorasTrabajoManu.AutoSize = True
        Me.TexHorasTrabajoManu.ForeColor = System.Drawing.Color.White
        Me.TexHorasTrabajoManu.Location = New System.Drawing.Point(852, 74)
        Me.TexHorasTrabajoManu.Name = "TexHorasTrabajoManu"
        Me.TexHorasTrabajoManu.Size = New System.Drawing.Size(58, 18)
        Me.TexHorasTrabajoManu.TabIndex = 1108
        Me.TexHorasTrabajoManu.Text = "Manual"
        '
        'TexHorasTrabajoAuto
        '
        Me.TexHorasTrabajoAuto.AutoSize = True
        Me.TexHorasTrabajoAuto.ForeColor = System.Drawing.Color.White
        Me.TexHorasTrabajoAuto.Location = New System.Drawing.Point(715, 74)
        Me.TexHorasTrabajoAuto.Name = "TexHorasTrabajoAuto"
        Me.TexHorasTrabajoAuto.Size = New System.Drawing.Size(87, 18)
        Me.TexHorasTrabajoAuto.TabIndex = 1107
        Me.TexHorasTrabajoAuto.Text = "Automatico"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(759, 489)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 18)
        Me.Label14.TabIndex = 1104
        Me.Label14.Text = "Valvula 1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(453, 489)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 18)
        Me.Label16.TabIndex = 1106
        Me.Label16.Text = "Valvula 3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(602, 489)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 18)
        Me.Label15.TabIndex = 1105
        Me.Label15.Text = "Valvula 2"
        '
        'IF_Cascarilla
        '
        Me.IF_Cascarilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IF_Cascarilla.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Mimico_Cascarilla_SDI__PLC_
        Me.IF_Cascarilla.Location = New System.Drawing.Point(166, 239)
        Me.IF_Cascarilla.Name = "IF_Cascarilla"
        Me.IF_Cascarilla.Size = New System.Drawing.Size(1017, 338)
        Me.IF_Cascarilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IF_Cascarilla.TabIndex = 1112
        Me.IF_Cascarilla.TabStop = False
        '
        'Cascarilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.MessageListByValue1)
        Me.Controls.Add(Me.PilotLight8)
        Me.Controls.Add(Me.PilotLight7)
        Me.Controls.Add(Me.PilotLight6)
        Me.Controls.Add(Me.PilotLight5)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.LS_MaxDH3)
        Me.Controls.Add(Me.LS_MinDH3)
        Me.Controls.Add(Me.LS_V3aDH3)
        Me.Controls.Add(Me.LS_V3aDH4)
        Me.Controls.Add(Me.LS_MaxDH4)
        Me.Controls.Add(Me.LS_MinDH4)
        Me.Controls.Add(Me.LS_V2aV3)
        Me.Controls.Add(Me.LS_V2aDH2)
        Me.Controls.Add(Me.LS_MaxDH2)
        Me.Controls.Add(Me.LS_MinDH2)
        Me.Controls.Add(Me.LS_V1aV2)
        Me.Controls.Add(Me.LS_VaDH1)
        Me.Controls.Add(Me.LS_MaxDH1)
        Me.Controls.Add(Me.LS_MinDH1)
        Me.Controls.Add(Me.LS_Transportador)
        Me.Controls.Add(Me.LS_Elevador)
        Me.Controls.Add(Me.LS_Ventilador)
        Me.Controls.Add(Me.LS_Disificador)
        Me.Controls.Add(Me.MD_VentDS_Manu)
        Me.Controls.Add(Me.MD_VentEC_Manu)
        Me.Controls.Add(Me.MD_VentDS_Auto)
        Me.Controls.Add(Me.MD_VentEC_Auto)
        Me.Controls.Add(Me.TexTiempDS)
        Me.Controls.Add(Me.TexTiempEC)
        Me.Controls.Add(Me.LS_SisTrabaCascarilla)
        Me.Controls.Add(Me.LS_SisMarchaCascarilla)
        Me.Controls.Add(Me.MD_VentVE_Manu)
        Me.Controls.Add(Me.MD_VentTH_Manu)
        Me.Controls.Add(Me.MD_VentVE_Auto)
        Me.Controls.Add(Me.MD_VentTH_Auto)
        Me.Controls.Add(Me.BCF_MenúP_Cascarilla)
        Me.Controls.Add(Me.TexHorasTrabajo)
        Me.Controls.Add(Me.TexTiempVE)
        Me.Controls.Add(Me.TexTiempTH)
        Me.Controls.Add(Me.TexHorasTrabajoManu)
        Me.Controls.Add(Me.TexHorasTrabajoAuto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.IF_Cascarilla)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Cascarilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Cacarilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IF_Cascarilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MessageListByValue1 As AdvancedHMIControls.MessageListByValue
    Friend WithEvents Cacarilla As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents PilotLight8 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight7 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight6 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight5 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MaxDH3 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MinDH3 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_V3aDH3 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_V3aDH4 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MaxDH4 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MinDH4 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_V2aV3 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_V2aDH2 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MaxDH2 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MinDH2 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_V1aV2 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_VaDH1 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MaxDH1 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_MinDH1 As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_Transportador As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_Elevador As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_Ventilador As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_Disificador As AdvancedHMIControls.PilotLight
    Friend WithEvents MD_VentDS_Manu As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentEC_Manu As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentDS_Auto As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentEC_Auto As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents TexTiempDS As Label
    Friend WithEvents TexTiempEC As Label
    Friend WithEvents LS_SisTrabaCascarilla As AdvancedHMIControls.PilotLight
    Friend WithEvents LS_SisMarchaCascarilla As AdvancedHMIControls.PilotLight
    Friend WithEvents MD_VentVE_Manu As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentTH_Manu As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentVE_Auto As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents MD_VentTH_Auto As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BCF_MenúP_Cascarilla As FormChangeButton
    Friend WithEvents TexHorasTrabajo As Label
    Friend WithEvents TexTiempVE As Label
    Friend WithEvents TexTiempTH As Label
    Friend WithEvents TexHorasTrabajoManu As Label
    Friend WithEvents TexHorasTrabajoAuto As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents IF_Cascarilla As PictureBox
End Class
