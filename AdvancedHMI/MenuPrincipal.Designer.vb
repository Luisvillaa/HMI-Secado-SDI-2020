<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReportesHorno1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ReportesHorno2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ReportesHorno3 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.ReporteHorno1 = New AdvancedHMIControls.BasicDataLogger2()
        Me.FormChangeButton1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.FormChangeButton2 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.FormChangeButton5 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.FormChangeButton6 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.CF_MP_Cascarilla = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.CF_MP_Horno2 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.CF_MP_Horno1 = New MfgControl.AdvancedHMI.FormChangeButton()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesHorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesHorno2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesHorno3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteHorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(172, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 22)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Salir de HMI"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Allen_Bradley_Rockwell_Automation_logos
        Me.PictureBox4.Location = New System.Drawing.Point(19, 458)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(180, 77)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 67
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.modbus
        Me.PictureBox3.Location = New System.Drawing.Point(262, 469)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(162, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 66
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources._exit
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(195, 355)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox1.Location = New System.Drawing.Point(58, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'ReportesHorno1
        '
        Me.ReportesHorno1.CIPConnectionSize = 508
        Me.ReportesHorno1.DisableMultiServiceRequest = False
        Me.ReportesHorno1.DisableSubscriptions = False
        Me.ReportesHorno1.IniFileName = ""
        Me.ReportesHorno1.IniFileSection = Nothing
        Me.ReportesHorno1.IPAddress = "10.1.108.20"
        Me.ReportesHorno1.PollRateOverride = 500
        Me.ReportesHorno1.Port = 44818
        Me.ReportesHorno1.ProcessorSlot = 0
        Me.ReportesHorno1.RoutePath = Nothing
        Me.ReportesHorno1.Timeout = 4000
        '
        'ReportesHorno2
        '
        Me.ReportesHorno2.CIPConnectionSize = 508
        Me.ReportesHorno2.DisableMultiServiceRequest = False
        Me.ReportesHorno2.DisableSubscriptions = False
        Me.ReportesHorno2.IniFileName = ""
        Me.ReportesHorno2.IniFileSection = Nothing
        Me.ReportesHorno2.IPAddress = "10.1.108.20"
        Me.ReportesHorno2.PollRateOverride = 500
        Me.ReportesHorno2.Port = 44818
        Me.ReportesHorno2.ProcessorSlot = 0
        Me.ReportesHorno2.RoutePath = Nothing
        Me.ReportesHorno2.Timeout = 4000
        '
        'ReportesHorno3
        '
        Me.ReportesHorno3.DisableSubscriptions = False
        Me.ReportesHorno3.IniFileName = ""
        Me.ReportesHorno3.IniFileSection = Nothing
        Me.ReportesHorno3.IPAddress = "10.1.108.8"
        Me.ReportesHorno3.MaxReadGroupSize = 20
        Me.ReportesHorno3.PollRateOverride = 500
        Me.ReportesHorno3.SwapBytes = True
        Me.ReportesHorno3.SwapWords = False
        Me.ReportesHorno3.TcpipPort = CType(20257US, UShort)
        Me.ReportesHorno3.TimeOut = 3000
        Me.ReportesHorno3.UnitId = CType(1, Byte)
        '
        'ReporteHorno1
        '
        Me.ReporteHorno1.ComComponent = Me.ReportesHorno1
        Me.ReporteHorno1.FileFolder = "D:\Reportes"
        Me.ReporteHorno1.FileName = "Horno_1.log"
        Me.ReporteHorno1.LogInterval = 9000
        Me.ReporteHorno1.LogTriggerType = AdvancedHMIControls.BasicDataLogger2.TriggerType.TimeInterval
        Me.ReporteHorno1.MaximumPoints = 0
        Me.ReporteHorno1.PauseLogging = False
        Me.ReporteHorno1.PLCAddressPauseLogging = ""
        Me.ReporteHorno1.PollRate = 0
        Me.ReporteHorno1.Prefix = Nothing
        Me.ReporteHorno1.SynchronizingObject = Me
        Me.ReporteHorno1.TimeStampFormat = "dd-MMM-yy HH:mm:ss"
        Me.ReporteHorno1.Value = Nothing
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton1.FormToOpen = Nothing
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(12, 269)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = "1783"
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(186, 45)
        Me.FormChangeButton1.TabIndex = 68
        Me.FormChangeButton1.Text = "Producción"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'FormChangeButton2
        '
        Me.FormChangeButton2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FormChangeButton2.ComComponent = Nothing
        Me.FormChangeButton2.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton2.FormToOpen = GetType(MfgControl.AdvancedHMI.Almacenamiento)
        Me.FormChangeButton2.KeypadWidth = 300
        Me.FormChangeButton2.Location = New System.Drawing.Point(251, 65)
        Me.FormChangeButton2.Name = "FormChangeButton2"
        Me.FormChangeButton2.Passcode = Nothing
        Me.FormChangeButton2.PasswordChar = False
        Me.FormChangeButton2.PLCAddressVisible = ""
        Me.FormChangeButton2.Size = New System.Drawing.Size(186, 45)
        Me.FormChangeButton2.TabIndex = 63
        Me.FormChangeButton2.Text = "Almacenamiento"
        Me.FormChangeButton2.UseVisualStyleBackColor = False
        '
        'FormChangeButton5
        '
        Me.FormChangeButton5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FormChangeButton5.ComComponent = Nothing
        Me.FormChangeButton5.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton5.FormToOpen = GetType(MfgControl.AdvancedHMI.Ingeniería)
        Me.FormChangeButton5.KeypadWidth = 300
        Me.FormChangeButton5.Location = New System.Drawing.Point(252, 199)
        Me.FormChangeButton5.Name = "FormChangeButton5"
        Me.FormChangeButton5.Passcode = "1783"
        Me.FormChangeButton5.PasswordChar = False
        Me.FormChangeButton5.PLCAddressVisible = ""
        Me.FormChangeButton5.Size = New System.Drawing.Size(186, 45)
        Me.FormChangeButton5.TabIndex = 62
        Me.FormChangeButton5.Text = "Ingeniería"
        Me.FormChangeButton5.UseVisualStyleBackColor = False
        '
        'FormChangeButton6
        '
        Me.FormChangeButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormChangeButton6.ComComponent = Nothing
        Me.FormChangeButton6.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton6.FormToOpen = GetType(MfgControl.AdvancedHMI.Menú_Horno_3)
        Me.FormChangeButton6.KeypadWidth = 300
        Me.FormChangeButton6.Location = New System.Drawing.Point(12, 199)
        Me.FormChangeButton6.Name = "FormChangeButton6"
        Me.FormChangeButton6.Passcode = Nothing
        Me.FormChangeButton6.PasswordChar = False
        Me.FormChangeButton6.PLCAddressVisible = ""
        Me.FormChangeButton6.Size = New System.Drawing.Size(186, 45)
        Me.FormChangeButton6.TabIndex = 61
        Me.FormChangeButton6.Text = "Menú Horno 3"
        Me.FormChangeButton6.UseVisualStyleBackColor = False
        '
        'CF_MP_Cascarilla
        '
        Me.CF_MP_Cascarilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CF_MP_Cascarilla.ComComponent = Nothing
        Me.CF_MP_Cascarilla.ForeColor = System.Drawing.Color.Black
        Me.CF_MP_Cascarilla.FormToOpen = GetType(MfgControl.AdvancedHMI.Cascarilla)
        Me.CF_MP_Cascarilla.KeypadWidth = 300
        Me.CF_MP_Cascarilla.Location = New System.Drawing.Point(251, 132)
        Me.CF_MP_Cascarilla.Name = "CF_MP_Cascarilla"
        Me.CF_MP_Cascarilla.Passcode = Nothing
        Me.CF_MP_Cascarilla.PasswordChar = False
        Me.CF_MP_Cascarilla.PLCAddressVisible = ""
        Me.CF_MP_Cascarilla.Size = New System.Drawing.Size(186, 45)
        Me.CF_MP_Cascarilla.TabIndex = 60
        Me.CF_MP_Cascarilla.Text = "Cascarilla"
        Me.CF_MP_Cascarilla.UseVisualStyleBackColor = False
        '
        'CF_MP_Horno2
        '
        Me.CF_MP_Horno2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CF_MP_Horno2.ComComponent = Nothing
        Me.CF_MP_Horno2.ForeColor = System.Drawing.Color.Black
        Me.CF_MP_Horno2.FormToOpen = GetType(MfgControl.AdvancedHMI.Menú_Horno_2)
        Me.CF_MP_Horno2.KeypadWidth = 300
        Me.CF_MP_Horno2.Location = New System.Drawing.Point(12, 132)
        Me.CF_MP_Horno2.Name = "CF_MP_Horno2"
        Me.CF_MP_Horno2.Passcode = Nothing
        Me.CF_MP_Horno2.PasswordChar = False
        Me.CF_MP_Horno2.PLCAddressVisible = ""
        Me.CF_MP_Horno2.Size = New System.Drawing.Size(186, 45)
        Me.CF_MP_Horno2.TabIndex = 59
        Me.CF_MP_Horno2.Text = "Menú Horno 2"
        Me.CF_MP_Horno2.UseVisualStyleBackColor = False
        '
        'CF_MP_Horno1
        '
        Me.CF_MP_Horno1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CF_MP_Horno1.ComComponent = Nothing
        Me.CF_MP_Horno1.ForeColor = System.Drawing.Color.Black
        Me.CF_MP_Horno1.FormToOpen = GetType(MfgControl.AdvancedHMI.Menú_Horno_1)
        Me.CF_MP_Horno1.KeypadWidth = 300
        Me.CF_MP_Horno1.Location = New System.Drawing.Point(12, 65)
        Me.CF_MP_Horno1.Name = "CF_MP_Horno1"
        Me.CF_MP_Horno1.Passcode = Nothing
        Me.CF_MP_Horno1.PasswordChar = False
        Me.CF_MP_Horno1.PLCAddressVisible = ""
        Me.CF_MP_Horno1.Size = New System.Drawing.Size(186, 45)
        Me.CF_MP_Horno1.TabIndex = 58
        Me.CF_MP_Horno1.Text = "Menú Horno 1"
        Me.CF_MP_Horno1.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(454, 544)
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FormChangeButton2)
        Me.Controls.Add(Me.FormChangeButton5)
        Me.Controls.Add(Me.FormChangeButton6)
        Me.Controls.Add(Me.CF_MP_Cascarilla)
        Me.Controls.Add(Me.CF_MP_Horno2)
        Me.Controls.Add(Me.CF_MP_Horno1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HMI Secado SDI (ATP 2020)"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesHorno1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesHorno2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesHorno3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteHorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FormChangeButton2 As FormChangeButton
    Friend WithEvents FormChangeButton5 As FormChangeButton
    Friend WithEvents FormChangeButton6 As FormChangeButton
    Friend WithEvents CF_MP_Cascarilla As FormChangeButton
    Friend WithEvents CF_MP_Horno2 As FormChangeButton
    Friend WithEvents CF_MP_Horno1 As FormChangeButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ReportesHorno1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ReportesHorno2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ReportesHorno3 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents ReporteHorno1 As AdvancedHMIControls.BasicDataLogger2
    Friend WithEvents FormChangeButton1 As FormChangeButton
End Class
