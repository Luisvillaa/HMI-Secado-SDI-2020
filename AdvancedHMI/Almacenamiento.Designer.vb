<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacenamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Almacenamiento))
        Me.BasicIndicator40 = New AdvancedHMIControls.BasicIndicator()
        Me.Elevado = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BasicIndicator39 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator38 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator37 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator36 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator35 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator34 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator33 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator32 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator31 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator30 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator29 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator28 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator27 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator26 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator25 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator24 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator23 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator22 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator21 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator20 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator19 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator18 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator17 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator16 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator15 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator14 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator13 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator12 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator11 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator10 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator9 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator8 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator7 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator6 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.MomentaryButton1 = New AdvancedHMIControls.MomentaryButton()
        Me.MessageDisplayByValue2 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MessageDisplayByValue1 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCF_MenúP_MantH1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.PB_Almacenamiento = New System.Windows.Forms.PictureBox()
        CType(Me.Elevado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Almacenamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BasicIndicator40
        '
        Me.BasicIndicator40.Color1 = System.Drawing.Color.White
        Me.BasicIndicator40.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator40.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator40.ComComponent = Me.Elevado
        Me.BasicIndicator40.Location = New System.Drawing.Point(688, 617)
        Me.BasicIndicator40.Name = "BasicIndicator40"
        Me.BasicIndicator40.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator40.OutlineWidth = 1
        Me.BasicIndicator40.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator40.PLCAddressSelectColor2 = "11124"
        Me.BasicIndicator40.PLCAddressSelectColor3 = "10077"
        Me.BasicIndicator40.SelectColor2 = False
        Me.BasicIndicator40.SelectColor3 = False
        Me.BasicIndicator40.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator40.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator40.TabIndex = 1083
        '
        'Elevado
        '
        Me.Elevado.DisableSubscriptions = False
        Me.Elevado.IniFileName = ""
        Me.Elevado.IniFileSection = Nothing
        Me.Elevado.IPAddress = "10.1.108.14"
        Me.Elevado.MaxReadGroupSize = 20
        Me.Elevado.PollRateOverride = 500
        Me.Elevado.SwapBytes = True
        Me.Elevado.SwapWords = False
        Me.Elevado.TcpipPort = CType(20257US, UShort)
        Me.Elevado.TimeOut = 3000
        Me.Elevado.UnitId = CType(17, Byte)
        '
        'BasicIndicator39
        '
        Me.BasicIndicator39.Color1 = System.Drawing.Color.White
        Me.BasicIndicator39.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator39.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator39.ComComponent = Me.Elevado
        Me.BasicIndicator39.Location = New System.Drawing.Point(353, 156)
        Me.BasicIndicator39.Name = "BasicIndicator39"
        Me.BasicIndicator39.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator39.OutlineWidth = 1
        Me.BasicIndicator39.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator39.PLCAddressSelectColor2 = "11017"
        Me.BasicIndicator39.PLCAddressSelectColor3 = "10073"
        Me.BasicIndicator39.SelectColor2 = False
        Me.BasicIndicator39.SelectColor3 = False
        Me.BasicIndicator39.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator39.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator39.TabIndex = 1082
        '
        'BasicIndicator38
        '
        Me.BasicIndicator38.Color1 = System.Drawing.Color.White
        Me.BasicIndicator38.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator38.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator38.ComComponent = Me.Elevado
        Me.BasicIndicator38.Location = New System.Drawing.Point(242, 618)
        Me.BasicIndicator38.Name = "BasicIndicator38"
        Me.BasicIndicator38.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator38.OutlineWidth = 1
        Me.BasicIndicator38.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator38.PLCAddressSelectColor2 = "11118"
        Me.BasicIndicator38.PLCAddressSelectColor3 = "10079"
        Me.BasicIndicator38.SelectColor2 = False
        Me.BasicIndicator38.SelectColor3 = False
        Me.BasicIndicator38.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator38.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator38.TabIndex = 1081
        '
        'BasicIndicator37
        '
        Me.BasicIndicator37.Color1 = System.Drawing.Color.White
        Me.BasicIndicator37.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator37.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator37.ComComponent = Me.Elevado
        Me.BasicIndicator37.Location = New System.Drawing.Point(328, 590)
        Me.BasicIndicator37.Name = "BasicIndicator37"
        Me.BasicIndicator37.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator37.OutlineWidth = 1
        Me.BasicIndicator37.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator37.PLCAddressSelectColor2 = "11119"
        Me.BasicIndicator37.PLCAddressSelectColor3 = "10071"
        Me.BasicIndicator37.SelectColor2 = False
        Me.BasicIndicator37.SelectColor3 = False
        Me.BasicIndicator37.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator37.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator37.TabIndex = 1080
        '
        'BasicIndicator36
        '
        Me.BasicIndicator36.Color1 = System.Drawing.Color.White
        Me.BasicIndicator36.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator36.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator36.ComComponent = Me.Elevado
        Me.BasicIndicator36.Location = New System.Drawing.Point(499, 618)
        Me.BasicIndicator36.Name = "BasicIndicator36"
        Me.BasicIndicator36.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator36.OutlineWidth = 1
        Me.BasicIndicator36.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator36.PLCAddressSelectColor2 = "11121"
        Me.BasicIndicator36.PLCAddressSelectColor3 = "10077"
        Me.BasicIndicator36.SelectColor2 = False
        Me.BasicIndicator36.SelectColor3 = False
        Me.BasicIndicator36.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator36.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator36.TabIndex = 1079
        '
        'BasicIndicator35
        '
        Me.BasicIndicator35.Color1 = System.Drawing.Color.White
        Me.BasicIndicator35.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator35.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator35.ComComponent = Me.Elevado
        Me.BasicIndicator35.Location = New System.Drawing.Point(423, 539)
        Me.BasicIndicator35.Name = "BasicIndicator35"
        Me.BasicIndicator35.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator35.OutlineWidth = 1
        Me.BasicIndicator35.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator35.PLCAddressSelectColor2 = "11120"
        Me.BasicIndicator35.PLCAddressSelectColor3 = "10076"
        Me.BasicIndicator35.SelectColor2 = False
        Me.BasicIndicator35.SelectColor3 = False
        Me.BasicIndicator35.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator35.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator35.TabIndex = 1078
        '
        'BasicIndicator34
        '
        Me.BasicIndicator34.Color1 = System.Drawing.Color.White
        Me.BasicIndicator34.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator34.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator34.ComComponent = Me.Elevado
        Me.BasicIndicator34.Location = New System.Drawing.Point(235, 428)
        Me.BasicIndicator34.Name = "BasicIndicator34"
        Me.BasicIndicator34.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator34.OutlineWidth = 1
        Me.BasicIndicator34.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator34.PLCAddressSelectColor2 = "10126"
        Me.BasicIndicator34.PLCAddressSelectColor3 = "10082"
        Me.BasicIndicator34.SelectColor2 = False
        Me.BasicIndicator34.SelectColor3 = False
        Me.BasicIndicator34.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator34.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator34.TabIndex = 1077
        '
        'BasicIndicator33
        '
        Me.BasicIndicator33.Color1 = System.Drawing.Color.White
        Me.BasicIndicator33.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator33.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator33.ComComponent = Me.Elevado
        Me.BasicIndicator33.Location = New System.Drawing.Point(322, 401)
        Me.BasicIndicator33.Name = "BasicIndicator33"
        Me.BasicIndicator33.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator33.OutlineWidth = 1
        Me.BasicIndicator33.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator33.PLCAddressSelectColor2 = "11125"
        Me.BasicIndicator33.PLCAddressSelectColor3 = "10081"
        Me.BasicIndicator33.SelectColor2 = False
        Me.BasicIndicator33.SelectColor3 = False
        Me.BasicIndicator33.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator33.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator33.TabIndex = 1076
        '
        'BasicIndicator32
        '
        Me.BasicIndicator32.Color1 = System.Drawing.Color.White
        Me.BasicIndicator32.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator32.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator32.ComComponent = Me.Elevado
        Me.BasicIndicator32.Location = New System.Drawing.Point(240, 251)
        Me.BasicIndicator32.Name = "BasicIndicator32"
        Me.BasicIndicator32.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator32.OutlineWidth = 1
        Me.BasicIndicator32.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator32.PLCAddressSelectColor2 = "11121"
        Me.BasicIndicator32.PLCAddressSelectColor3 = "10080"
        Me.BasicIndicator32.SelectColor2 = False
        Me.BasicIndicator32.SelectColor3 = False
        Me.BasicIndicator32.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator32.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator32.TabIndex = 1075
        '
        'BasicIndicator31
        '
        Me.BasicIndicator31.Color1 = System.Drawing.Color.White
        Me.BasicIndicator31.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator31.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator31.ComComponent = Me.Elevado
        Me.BasicIndicator31.Location = New System.Drawing.Point(745, 273)
        Me.BasicIndicator31.Name = "BasicIndicator31"
        Me.BasicIndicator31.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator31.OutlineWidth = 1
        Me.BasicIndicator31.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator31.PLCAddressSelectColor2 = "11115"
        Me.BasicIndicator31.PLCAddressSelectColor3 = "10074"
        Me.BasicIndicator31.SelectColor2 = False
        Me.BasicIndicator31.SelectColor3 = False
        Me.BasicIndicator31.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator31.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator31.TabIndex = 1074
        '
        'BasicIndicator30
        '
        Me.BasicIndicator30.Color1 = System.Drawing.Color.White
        Me.BasicIndicator30.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator30.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator30.ComComponent = Me.Elevado
        Me.BasicIndicator30.Location = New System.Drawing.Point(544, 410)
        Me.BasicIndicator30.Name = "BasicIndicator30"
        Me.BasicIndicator30.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator30.OutlineWidth = 1
        Me.BasicIndicator30.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator30.PLCAddressSelectColor2 = "11123"
        Me.BasicIndicator30.PLCAddressSelectColor3 = "10084"
        Me.BasicIndicator30.SelectColor2 = False
        Me.BasicIndicator30.SelectColor3 = False
        Me.BasicIndicator30.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator30.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator30.TabIndex = 1073
        '
        'BasicIndicator29
        '
        Me.BasicIndicator29.Color1 = System.Drawing.Color.White
        Me.BasicIndicator29.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator29.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator29.ComComponent = Me.Elevado
        Me.BasicIndicator29.Location = New System.Drawing.Point(257, 85)
        Me.BasicIndicator29.Name = "BasicIndicator29"
        Me.BasicIndicator29.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator29.OutlineWidth = 1
        Me.BasicIndicator29.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator29.PLCAddressSelectColor2 = "10046"
        Me.BasicIndicator29.PLCAddressVisible = "ElevadoSDI.MB1"
        Me.BasicIndicator29.SelectColor2 = False
        Me.BasicIndicator29.SelectColor3 = False
        Me.BasicIndicator29.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator29.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator29.TabIndex = 1072
        '
        'BasicIndicator28
        '
        Me.BasicIndicator28.Color1 = System.Drawing.Color.White
        Me.BasicIndicator28.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator28.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator28.ComComponent = Me.Elevado
        Me.BasicIndicator28.Location = New System.Drawing.Point(390, 85)
        Me.BasicIndicator28.Name = "BasicIndicator28"
        Me.BasicIndicator28.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator28.OutlineWidth = 1
        Me.BasicIndicator28.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator28.PLCAddressSelectColor2 = "10046"
        Me.BasicIndicator28.PLCAddressVisible = "ElevadoSDI.MB1"
        Me.BasicIndicator28.SelectColor2 = False
        Me.BasicIndicator28.SelectColor3 = False
        Me.BasicIndicator28.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator28.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator28.TabIndex = 1071
        '
        'BasicIndicator27
        '
        Me.BasicIndicator27.Color1 = System.Drawing.Color.White
        Me.BasicIndicator27.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator27.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator27.ComComponent = Me.Elevado
        Me.BasicIndicator27.Location = New System.Drawing.Point(535, 379)
        Me.BasicIndicator27.Name = "BasicIndicator27"
        Me.BasicIndicator27.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator27.OutlineWidth = 1
        Me.BasicIndicator27.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator27.PLCAddressSelectColor2 = "11116"
        Me.BasicIndicator27.PLCAddressSelectColor3 = "10075"
        Me.BasicIndicator27.SelectColor2 = False
        Me.BasicIndicator27.SelectColor3 = False
        Me.BasicIndicator27.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator27.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator27.TabIndex = 1070
        '
        'BasicIndicator26
        '
        Me.BasicIndicator26.Color1 = System.Drawing.Color.White
        Me.BasicIndicator26.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator26.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator26.ComComponent = Me.Elevado
        Me.BasicIndicator26.Location = New System.Drawing.Point(743, 85)
        Me.BasicIndicator26.Name = "BasicIndicator26"
        Me.BasicIndicator26.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator26.OutlineWidth = 1
        Me.BasicIndicator26.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator26.PLCAddressSelectColor2 = "11113"
        Me.BasicIndicator26.PLCAddressSelectColor3 = "10072"
        Me.BasicIndicator26.SelectColor2 = False
        Me.BasicIndicator26.SelectColor3 = False
        Me.BasicIndicator26.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator26.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator26.TabIndex = 1069
        '
        'BasicIndicator25
        '
        Me.BasicIndicator25.Color1 = System.Drawing.Color.White
        Me.BasicIndicator25.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator25.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator25.ComComponent = Me.Elevado
        Me.BasicIndicator25.Location = New System.Drawing.Point(758, 115)
        Me.BasicIndicator25.Name = "BasicIndicator25"
        Me.BasicIndicator25.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator25.OutlineWidth = 1
        Me.BasicIndicator25.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator25.PLCAddressSelectColor2 = "11112"
        Me.BasicIndicator25.PLCAddressSelectColor3 = "10086"
        Me.BasicIndicator25.SelectColor2 = False
        Me.BasicIndicator25.SelectColor3 = False
        Me.BasicIndicator25.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator25.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator25.TabIndex = 1068
        '
        'BasicIndicator24
        '
        Me.BasicIndicator24.Color1 = System.Drawing.Color.White
        Me.BasicIndicator24.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator24.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator24.ComComponent = Me.Elevado
        Me.BasicIndicator24.Location = New System.Drawing.Point(741, 399)
        Me.BasicIndicator24.Name = "BasicIndicator24"
        Me.BasicIndicator24.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator24.OutlineWidth = 1
        Me.BasicIndicator24.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator24.PLCAddressSelectColor2 = "11117"
        Me.BasicIndicator24.PLCAddressSelectColor3 = "10078"
        Me.BasicIndicator24.SelectColor2 = False
        Me.BasicIndicator24.SelectColor3 = False
        Me.BasicIndicator24.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator24.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator24.TabIndex = 1067
        '
        'BasicIndicator23
        '
        Me.BasicIndicator23.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator23.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator23.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator23.ComComponent = Me.Elevado
        Me.BasicIndicator23.Location = New System.Drawing.Point(240, 636)
        Me.BasicIndicator23.Name = "BasicIndicator23"
        Me.BasicIndicator23.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator23.OutlineWidth = 1
        Me.BasicIndicator23.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator23.PLCAddressSelectColor2 = "11056"
        Me.BasicIndicator23.SelectColor2 = False
        Me.BasicIndicator23.SelectColor3 = False
        Me.BasicIndicator23.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator23.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator23.TabIndex = 1066
        '
        'BasicIndicator22
        '
        Me.BasicIndicator22.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator22.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator22.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator22.ComComponent = Me.Elevado
        Me.BasicIndicator22.Location = New System.Drawing.Point(356, 636)
        Me.BasicIndicator22.Name = "BasicIndicator22"
        Me.BasicIndicator22.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator22.OutlineWidth = 1
        Me.BasicIndicator22.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator22.PLCAddressSelectColor2 = "11065"
        Me.BasicIndicator22.PLCAddressVisible = "ElevadoSDI.MB15"
        Me.BasicIndicator22.SelectColor2 = False
        Me.BasicIndicator22.SelectColor3 = False
        Me.BasicIndicator22.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator22.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator22.TabIndex = 1065
        '
        'BasicIndicator21
        '
        Me.BasicIndicator21.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator21.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator21.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator21.ComComponent = Me.Elevado
        Me.BasicIndicator21.Location = New System.Drawing.Point(534, 636)
        Me.BasicIndicator21.Name = "BasicIndicator21"
        Me.BasicIndicator21.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator21.OutlineWidth = 1
        Me.BasicIndicator21.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator21.PLCAddressSelectColor2 = "11066"
        Me.BasicIndicator21.SelectColor2 = False
        Me.BasicIndicator21.SelectColor3 = False
        Me.BasicIndicator21.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator21.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator21.TabIndex = 1064
        '
        'BasicIndicator20
        '
        Me.BasicIndicator20.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator20.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator20.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator20.ComComponent = Me.Elevado
        Me.BasicIndicator20.Location = New System.Drawing.Point(608, 636)
        Me.BasicIndicator20.Name = "BasicIndicator20"
        Me.BasicIndicator20.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator20.OutlineWidth = 1
        Me.BasicIndicator20.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator20.PLCAddressSelectColor2 = "11067"
        Me.BasicIndicator20.SelectColor2 = False
        Me.BasicIndicator20.SelectColor3 = False
        Me.BasicIndicator20.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator20.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator20.TabIndex = 1063
        '
        'BasicIndicator19
        '
        Me.BasicIndicator19.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator19.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator19.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator19.ComComponent = Me.Elevado
        Me.BasicIndicator19.Location = New System.Drawing.Point(682, 636)
        Me.BasicIndicator19.Name = "BasicIndicator19"
        Me.BasicIndicator19.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator19.OutlineWidth = 1
        Me.BasicIndicator19.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator19.PLCAddressSelectColor2 = "11068"
        Me.BasicIndicator19.SelectColor2 = False
        Me.BasicIndicator19.SelectColor3 = False
        Me.BasicIndicator19.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator19.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator19.TabIndex = 1062
        '
        'BasicIndicator18
        '
        Me.BasicIndicator18.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator18.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator18.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator18.ComComponent = Me.Elevado
        Me.BasicIndicator18.Location = New System.Drawing.Point(236, 447)
        Me.BasicIndicator18.Name = "BasicIndicator18"
        Me.BasicIndicator18.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator18.OutlineWidth = 1
        Me.BasicIndicator18.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator18.PLCAddressSelectColor2 = "11100"
        Me.BasicIndicator18.SelectColor2 = False
        Me.BasicIndicator18.SelectColor3 = False
        Me.BasicIndicator18.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator18.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator18.TabIndex = 1061
        '
        'BasicIndicator17
        '
        Me.BasicIndicator17.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator17.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator17.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator17.ComComponent = Me.Elevado
        Me.BasicIndicator17.Location = New System.Drawing.Point(353, 445)
        Me.BasicIndicator17.Name = "BasicIndicator17"
        Me.BasicIndicator17.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator17.OutlineWidth = 1
        Me.BasicIndicator17.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator17.PLCAddressSelectColor2 = "11099"
        Me.BasicIndicator17.SelectColor2 = False
        Me.BasicIndicator17.SelectColor3 = False
        Me.BasicIndicator17.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator17.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator17.TabIndex = 1060
        '
        'BasicIndicator16
        '
        Me.BasicIndicator16.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator16.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator16.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator16.ComComponent = Me.Elevado
        Me.BasicIndicator16.Location = New System.Drawing.Point(449, 290)
        Me.BasicIndicator16.Name = "BasicIndicator16"
        Me.BasicIndicator16.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator16.OutlineWidth = 1
        Me.BasicIndicator16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator16.PLCAddressSelectColor2 = "11037"
        Me.BasicIndicator16.SelectColor2 = False
        Me.BasicIndicator16.SelectColor3 = False
        Me.BasicIndicator16.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator16.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator16.TabIndex = 1059
        '
        'BasicIndicator15
        '
        Me.BasicIndicator15.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator15.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator15.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator15.ComComponent = Me.Elevado
        Me.BasicIndicator15.Location = New System.Drawing.Point(514, 290)
        Me.BasicIndicator15.Name = "BasicIndicator15"
        Me.BasicIndicator15.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator15.OutlineWidth = 1
        Me.BasicIndicator15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator15.PLCAddressSelectColor2 = "11051"
        Me.BasicIndicator15.SelectColor2 = False
        Me.BasicIndicator15.SelectColor3 = False
        Me.BasicIndicator15.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator15.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator15.TabIndex = 1058
        '
        'BasicIndicator14
        '
        Me.BasicIndicator14.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator14.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator14.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator14.ComComponent = Me.Elevado
        Me.BasicIndicator14.Location = New System.Drawing.Point(577, 290)
        Me.BasicIndicator14.Name = "BasicIndicator14"
        Me.BasicIndicator14.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator14.OutlineWidth = 1
        Me.BasicIndicator14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator14.PLCAddressSelectColor2 = "11038"
        Me.BasicIndicator14.SelectColor2 = False
        Me.BasicIndicator14.SelectColor3 = False
        Me.BasicIndicator14.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator14.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator14.TabIndex = 1057
        '
        'BasicIndicator13
        '
        Me.BasicIndicator13.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator13.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator13.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator13.ComComponent = Me.Elevado
        Me.BasicIndicator13.Location = New System.Drawing.Point(641, 290)
        Me.BasicIndicator13.Name = "BasicIndicator13"
        Me.BasicIndicator13.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator13.OutlineWidth = 1
        Me.BasicIndicator13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator13.PLCAddressSelectColor2 = "11052"
        Me.BasicIndicator13.SelectColor2 = False
        Me.BasicIndicator13.SelectColor3 = False
        Me.BasicIndicator13.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator13.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator13.TabIndex = 1056
        '
        'BasicIndicator12
        '
        Me.BasicIndicator12.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator12.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator12.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator12.ComComponent = Me.Elevado
        Me.BasicIndicator12.Location = New System.Drawing.Point(704, 290)
        Me.BasicIndicator12.Name = "BasicIndicator12"
        Me.BasicIndicator12.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator12.OutlineWidth = 1
        Me.BasicIndicator12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator12.PLCAddressSelectColor2 = "11050"
        Me.BasicIndicator12.SelectColor2 = False
        Me.BasicIndicator12.SelectColor3 = False
        Me.BasicIndicator12.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator12.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator12.TabIndex = 1055
        '
        'BasicIndicator11
        '
        Me.BasicIndicator11.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator11.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator11.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator11.ComComponent = Me.Elevado
        Me.BasicIndicator11.Location = New System.Drawing.Point(750, 290)
        Me.BasicIndicator11.Name = "BasicIndicator11"
        Me.BasicIndicator11.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator11.OutlineWidth = 1
        Me.BasicIndicator11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator11.PLCAddressSelectColor2 = "11053"
        Me.BasicIndicator11.SelectColor2 = False
        Me.BasicIndicator11.SelectColor3 = False
        Me.BasicIndicator11.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator11.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator11.TabIndex = 1054
        '
        'BasicIndicator10
        '
        Me.BasicIndicator10.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator10.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator10.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator10.ComComponent = Me.Elevado
        Me.BasicIndicator10.Location = New System.Drawing.Point(597, 417)
        Me.BasicIndicator10.Name = "BasicIndicator10"
        Me.BasicIndicator10.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator10.OutlineWidth = 1
        Me.BasicIndicator10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator10.PLCAddressSelectColor2 = "11054"
        Me.BasicIndicator10.SelectColor2 = False
        Me.BasicIndicator10.SelectColor3 = False
        Me.BasicIndicator10.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator10.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator10.TabIndex = 1053
        '
        'BasicIndicator9
        '
        Me.BasicIndicator9.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator9.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator9.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator9.ComComponent = Me.Elevado
        Me.BasicIndicator9.Location = New System.Drawing.Point(673, 417)
        Me.BasicIndicator9.Name = "BasicIndicator9"
        Me.BasicIndicator9.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator9.OutlineWidth = 1
        Me.BasicIndicator9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator9.PLCAddressSelectColor2 = "11055"
        Me.BasicIndicator9.SelectColor2 = False
        Me.BasicIndicator9.SelectColor3 = False
        Me.BasicIndicator9.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator9.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator9.TabIndex = 1052
        '
        'BasicIndicator8
        '
        Me.BasicIndicator8.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator8.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator8.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator8.ComComponent = Me.Elevado
        Me.BasicIndicator8.Location = New System.Drawing.Point(744, 417)
        Me.BasicIndicator8.Name = "BasicIndicator8"
        Me.BasicIndicator8.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator8.OutlineWidth = 1
        Me.BasicIndicator8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator8.PLCAddressSelectColor2 = "11071"
        Me.BasicIndicator8.PLCAddressVisible = "ElevadoSDI.MB24"
        Me.BasicIndicator8.SelectColor2 = False
        Me.BasicIndicator8.SelectColor3 = False
        Me.BasicIndicator8.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator8.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator8.TabIndex = 1051
        '
        'BasicIndicator7
        '
        Me.BasicIndicator7.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator7.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator7.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator7.ComComponent = Me.Elevado
        Me.BasicIndicator7.Location = New System.Drawing.Point(243, 270)
        Me.BasicIndicator7.Name = "BasicIndicator7"
        Me.BasicIndicator7.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator7.OutlineWidth = 1
        Me.BasicIndicator7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator7.PLCAddressSelectColor2 = "11070"
        Me.BasicIndicator7.SelectColor2 = False
        Me.BasicIndicator7.SelectColor3 = False
        Me.BasicIndicator7.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator7.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator7.TabIndex = 1050
        '
        'BasicIndicator6
        '
        Me.BasicIndicator6.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator6.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator6.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator6.ComComponent = Me.Elevado
        Me.BasicIndicator6.Location = New System.Drawing.Point(317, 270)
        Me.BasicIndicator6.Name = "BasicIndicator6"
        Me.BasicIndicator6.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator6.OutlineWidth = 1
        Me.BasicIndicator6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator6.PLCAddressSelectColor2 = "11069"
        Me.BasicIndicator6.SelectColor2 = False
        Me.BasicIndicator6.SelectColor3 = False
        Me.BasicIndicator6.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator6.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator6.TabIndex = 1049
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.Elevado
        Me.BasicIndicator5.Location = New System.Drawing.Point(390, 173)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor2 = "11050"
        Me.BasicIndicator5.SelectColor2 = False
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator5.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator5.TabIndex = 1048
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.Elevado
        Me.BasicIndicator4.Location = New System.Drawing.Point(453, 173)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "11036"
        Me.BasicIndicator4.SelectColor2 = False
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator4.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator4.TabIndex = 1047
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.Elevado
        Me.BasicIndicator3.Location = New System.Drawing.Point(516, 173)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressSelectColor2 = "11040"
        Me.BasicIndicator3.SelectColor2 = False
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator3.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator3.TabIndex = 1046
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.White
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.Elevado
        Me.BasicIndicator2.Location = New System.Drawing.Point(677, 115)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "11018"
        Me.BasicIndicator2.PLCAddressSelectColor3 = "10085"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator2.Size = New System.Drawing.Size(15, 15)
        Me.BasicIndicator2.TabIndex = 1045
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Blue
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.Elevado
        Me.BasicIndicator1.Location = New System.Drawing.Point(579, 173)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "11035"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(10, 10)
        Me.BasicIndicator1.TabIndex = 1044
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = True
        Me.PilotLight1.ComComponent = Me.Elevado
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(1005, 457)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "10046"
        Me.PilotLight1.PLCAddressVisible = "10051"
        Me.PilotLight1.Size = New System.Drawing.Size(58, 61)
        Me.PilotLight1.TabIndex = 1043
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'MomentaryButton1
        '
        Me.MomentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MomentaryButton1.ComComponent = Me.Elevado
        Me.MomentaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton1.Location = New System.Drawing.Point(910, 406)
        Me.MomentaryButton1.MaximumHoldTime = 3000
        Me.MomentaryButton1.MinimumHoldTime = 500
        Me.MomentaryButton1.Name = "MomentaryButton1"
        Me.MomentaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton1.PLCAddressClick = "00068"
        Me.MomentaryButton1.PLCAddressVisible = "10051"
        Me.MomentaryButton1.Size = New System.Drawing.Size(91, 133)
        Me.MomentaryButton1.TabIndex = 1042
        Me.MomentaryButton1.Text = "Silenciar Alarma"
        '
        'MessageDisplayByValue2
        '
        Me.MessageDisplayByValue2.AutoSize = True
        Me.MessageDisplayByValue2.BackColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue2.ComComponent = Me.Elevado
        Me.MessageDisplayByValue2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageDisplayByValue2.ForeColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue2.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue2.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue2.IniFileName = Nothing
        Me.MessageDisplayByValue2.Location = New System.Drawing.Point(937, 379)
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages8"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages9"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages10"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages11"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages12"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages13"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages14"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages15"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages16"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Name = "MessageDisplayByValue2"
        Me.MessageDisplayByValue2.PLCAddressValue = "40001"
        Me.MessageDisplayByValue2.PLCAddressVisible = "10051"
        Me.MessageDisplayByValue2.ShowMessageNumber = False
        Me.MessageDisplayByValue2.Size = New System.Drawing.Size(95, 24)
        Me.MessageDisplayByValue2.SpeakMessage = False
        Me.MessageDisplayByValue2.TabIndex = 1041
        Me.MessageDisplayByValue2.Text = "Sin Falla"
        Me.MessageDisplayByValue2.TextPrefix = Nothing
        Me.MessageDisplayByValue2.Value = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(877, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 1040
        Me.Label2.Text = "Falla:"
        '
        'MessageDisplayByValue1
        '
        Me.MessageDisplayByValue1.AutoSize = True
        Me.MessageDisplayByValue1.BackColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue1.ComComponent = Me.Elevado
        Me.MessageDisplayByValue1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageDisplayByValue1.ForeColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue1.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue1.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue1.IniFileName = Nothing
        Me.MessageDisplayByValue1.Location = New System.Drawing.Point(931, 230)
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages7"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages8"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages9"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages10"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages11"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages12"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages13"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages14"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages15"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages16"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages17"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages18"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages19"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages20"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages21"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages22"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages23"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages24"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages25"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages26"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages27"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages28"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages29"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages30"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages31"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Name = "MessageDisplayByValue1"
        Me.MessageDisplayByValue1.PLCAddressValue = "40041"
        Me.MessageDisplayByValue1.PLCAddressVisible = ""
        Me.MessageDisplayByValue1.ShowMessageNumber = False
        Me.MessageDisplayByValue1.Size = New System.Drawing.Size(106, 24)
        Me.MessageDisplayByValue1.SpeakMessage = False
        Me.MessageDisplayByValue1.TabIndex = 1039
        Me.MessageDisplayByValue1.Text = "En Pausa"
        Me.MessageDisplayByValue1.TextPrefix = Nothing
        Me.MessageDisplayByValue1.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(844, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 22)
        Me.Label1.TabIndex = 1038
        Me.Label1.Text = "Destino:"
        '
        'BCF_MenúP_MantH1
        '
        Me.BCF_MenúP_MantH1.BackColor = System.Drawing.Color.Blue
        Me.BCF_MenúP_MantH1.ComComponent = Nothing
        Me.BCF_MenúP_MantH1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCF_MenúP_MantH1.ForeColor = System.Drawing.Color.White
        Me.BCF_MenúP_MantH1.FormToOpen = GetType(MfgControl.AdvancedHMI.MenuPrincipal)
        Me.BCF_MenúP_MantH1.KeypadWidth = 300
        Me.BCF_MenúP_MantH1.Location = New System.Drawing.Point(1007, 37)
        Me.BCF_MenúP_MantH1.Name = "BCF_MenúP_MantH1"
        Me.BCF_MenúP_MantH1.Passcode = Nothing
        Me.BCF_MenúP_MantH1.PasswordChar = False
        Me.BCF_MenúP_MantH1.PLCAddressVisible = ""
        Me.BCF_MenúP_MantH1.Size = New System.Drawing.Size(151, 54)
        Me.BCF_MenúP_MantH1.TabIndex = 1037
        Me.BCF_MenúP_MantH1.Text = "Menú Principal"
        Me.BCF_MenúP_MantH1.UseVisualStyleBackColor = False
        '
        'PB_Almacenamiento
        '
        Me.PB_Almacenamiento.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Mimíco_Silos_SDI__HMI_
        Me.PB_Almacenamiento.Location = New System.Drawing.Point(191, 28)
        Me.PB_Almacenamiento.Name = "PB_Almacenamiento"
        Me.PB_Almacenamiento.Size = New System.Drawing.Size(607, 697)
        Me.PB_Almacenamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Almacenamiento.TabIndex = 1036
        Me.PB_Almacenamiento.TabStop = False
        '
        'Almacenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1348, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.BasicIndicator40)
        Me.Controls.Add(Me.BasicIndicator39)
        Me.Controls.Add(Me.BasicIndicator38)
        Me.Controls.Add(Me.BasicIndicator37)
        Me.Controls.Add(Me.BasicIndicator36)
        Me.Controls.Add(Me.BasicIndicator35)
        Me.Controls.Add(Me.BasicIndicator34)
        Me.Controls.Add(Me.BasicIndicator33)
        Me.Controls.Add(Me.BasicIndicator32)
        Me.Controls.Add(Me.BasicIndicator31)
        Me.Controls.Add(Me.BasicIndicator30)
        Me.Controls.Add(Me.BasicIndicator29)
        Me.Controls.Add(Me.BasicIndicator28)
        Me.Controls.Add(Me.BasicIndicator27)
        Me.Controls.Add(Me.BasicIndicator26)
        Me.Controls.Add(Me.BasicIndicator25)
        Me.Controls.Add(Me.BasicIndicator24)
        Me.Controls.Add(Me.BasicIndicator23)
        Me.Controls.Add(Me.BasicIndicator22)
        Me.Controls.Add(Me.BasicIndicator21)
        Me.Controls.Add(Me.BasicIndicator20)
        Me.Controls.Add(Me.BasicIndicator19)
        Me.Controls.Add(Me.BasicIndicator18)
        Me.Controls.Add(Me.BasicIndicator17)
        Me.Controls.Add(Me.BasicIndicator16)
        Me.Controls.Add(Me.BasicIndicator15)
        Me.Controls.Add(Me.BasicIndicator14)
        Me.Controls.Add(Me.BasicIndicator13)
        Me.Controls.Add(Me.BasicIndicator12)
        Me.Controls.Add(Me.BasicIndicator11)
        Me.Controls.Add(Me.BasicIndicator10)
        Me.Controls.Add(Me.BasicIndicator9)
        Me.Controls.Add(Me.BasicIndicator8)
        Me.Controls.Add(Me.BasicIndicator7)
        Me.Controls.Add(Me.BasicIndicator6)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.MomentaryButton1)
        Me.Controls.Add(Me.MessageDisplayByValue2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MessageDisplayByValue1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BCF_MenúP_MantH1)
        Me.Controls.Add(Me.PB_Almacenamiento)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Almacenamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Elevado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Almacenamiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BasicIndicator40 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents Elevado As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BasicIndicator39 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator38 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator37 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator36 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator35 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator34 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator33 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator32 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator31 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator30 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator29 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator28 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator27 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator26 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator25 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator24 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator23 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator22 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator21 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator20 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator19 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator18 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator17 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator16 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator15 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator14 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator13 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator12 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator11 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator10 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator9 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator8 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator7 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator6 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents MomentaryButton1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MessageDisplayByValue2 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents Label2 As Label
    Friend WithEvents MessageDisplayByValue1 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents Label1 As Label
    Friend WithEvents BCF_MenúP_MantH1 As FormChangeButton
    Friend WithEvents PB_Almacenamiento As PictureBox
End Class
