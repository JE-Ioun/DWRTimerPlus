<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbTimerFont = New System.Windows.Forms.ComboBox()
        Me.cmbTimerFontColor = New System.Windows.Forms.ComboBox()
        Me.cmbBackColor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStartPauseTimer = New System.Windows.Forms.Button()
        Me.btnResetTimer = New System.Windows.Forms.Button()
        Me.btnResetTracker = New System.Windows.Forms.Button()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.nudTimerFontSize = New System.Windows.Forms.NumericUpDown()
        Me.nudTimerSetHours = New System.Windows.Forms.NumericUpDown()
        Me.nudTimerSetMinutes = New System.Windows.Forms.NumericUpDown()
        Me.nudTimerSetSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudTimerSetMseconds = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSetTimerTime = New System.Windows.Forms.Button()
        Me.btnSetTimeInputsFromTimer = New System.Windows.Forms.Button()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.lblAgility = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.btnSaveStats = New System.Windows.Forms.Button()
        Me.nudPower = New System.Windows.Forms.NumericUpDown()
        Me.nudAgility = New System.Windows.Forms.NumericUpDown()
        Me.nudHP = New System.Windows.Forms.NumericUpDown()
        Me.nudMP = New System.Windows.Forms.NumericUpDown()
        Me.btnResetStats = New System.Windows.Forms.Button()
        Me.tabForms = New System.Windows.Forms.TabControl()
        Me.tpControls = New System.Windows.Forms.TabPage()
        Me.btnSimulateDLFights = New System.Windows.Forms.Button()
        Me.tpTimerSettings = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudTimerDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpHeaderSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSetHeader2Match1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbHeader2Font = New System.Windows.Forms.ComboBox()
        Me.cmbHeader2Color = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkHeader2Enabled = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudLine2FontSize = New System.Windows.Forms.NumericUpDown()
        Me.txtHeader2String = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSetHeader1MatchTimer = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbHeader1Font = New System.Windows.Forms.ComboBox()
        Me.cmbHeader1Color = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkHeader1Enabled = New System.Windows.Forms.CheckBox()
        Me.txtHeader1String = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nudLine1FontSize = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbOther = New System.Windows.Forms.TabPage()
        Me.chkMHImages = New System.Windows.Forms.CheckBox()
        Me.chkEnableRunPercent = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnOpenBGImgSelector = New System.Windows.Forms.Button()
        Me.chkBackgroundImage = New System.Windows.Forms.CheckBox()
        Me.txtImageFileLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnMatchOtherLabelsToTimer = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbOtherLabelFont = New System.Windows.Forms.ComboBox()
        Me.cmbOtherLabelColor = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkTrackerView = New System.Windows.Forms.CheckBox()
        Me.chkTimerView = New System.Windows.Forms.CheckBox()
        Me.chkEnableCalculation = New System.Windows.Forms.CheckBox()
        Me.chkEnableStats = New System.Windows.Forms.CheckBox()
        Me.btnOpenMapForm = New System.Windows.Forms.Button()
        Me.tpAdmin = New System.Windows.Forms.TabPage()
        Me.chkEnableFactoryReset = New System.Windows.Forms.CheckBox()
        Me.btnResetToFactory = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblSimulations = New System.Windows.Forms.Label()
        Me.nudNumberOfSimulations = New System.Windows.Forms.NumericUpDown()
        Me.grpDLSimulationSettings = New System.Windows.Forms.GroupBox()
        Me.nudDLSimMinHealth = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.nudDLSimStartingHerbs = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.nudTimerFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimerSetHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimerSetMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimerSetSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimerSetMseconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAgility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabForms.SuspendLayout()
        Me.tpControls.SuspendLayout()
        Me.tpTimerSettings.SuspendLayout()
        CType(Me.nudTimerDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHeaderSettings.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudLine2FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudLine1FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOther.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tpAdmin.SuspendLayout()
        CType(Me.nudNumberOfSimulations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDLSimulationSettings.SuspendLayout()
        CType(Me.nudDLSimMinHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDLSimStartingHerbs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTimerFont
        '
        Me.cmbTimerFont.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbTimerFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimerFont.FormattingEnabled = True
        Me.cmbTimerFont.Location = New System.Drawing.Point(113, 19)
        Me.cmbTimerFont.Name = "cmbTimerFont"
        Me.cmbTimerFont.Size = New System.Drawing.Size(186, 21)
        Me.cmbTimerFont.TabIndex = 0
        Me.cmbTimerFont.TabStop = False
        '
        'cmbTimerFontColor
        '
        Me.cmbTimerFontColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbTimerFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimerFontColor.FormattingEnabled = True
        Me.cmbTimerFontColor.Location = New System.Drawing.Point(113, 46)
        Me.cmbTimerFontColor.Name = "cmbTimerFontColor"
        Me.cmbTimerFontColor.Size = New System.Drawing.Size(186, 21)
        Me.cmbTimerFontColor.TabIndex = 1
        Me.cmbTimerFontColor.TabStop = False
        '
        'cmbBackColor
        '
        Me.cmbBackColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBackColor.FormattingEnabled = True
        Me.cmbBackColor.Location = New System.Drawing.Point(113, 73)
        Me.cmbBackColor.Name = "cmbBackColor"
        Me.cmbBackColor.Size = New System.Drawing.Size(186, 21)
        Me.cmbBackColor.TabIndex = 2
        Me.cmbBackColor.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Font:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Text Color:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Background:"
        '
        'btnStartPauseTimer
        '
        Me.btnStartPauseTimer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStartPauseTimer.Location = New System.Drawing.Point(102, 17)
        Me.btnStartPauseTimer.Name = "btnStartPauseTimer"
        Me.btnStartPauseTimer.Size = New System.Drawing.Size(129, 44)
        Me.btnStartPauseTimer.TabIndex = 6
        Me.btnStartPauseTimer.TabStop = False
        Me.btnStartPauseTimer.Text = "Start Timer"
        Me.btnStartPauseTimer.UseVisualStyleBackColor = True
        '
        'btnResetTimer
        '
        Me.btnResetTimer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResetTimer.Location = New System.Drawing.Point(254, 22)
        Me.btnResetTimer.Name = "btnResetTimer"
        Me.btnResetTimer.Size = New System.Drawing.Size(49, 35)
        Me.btnResetTimer.TabIndex = 7
        Me.btnResetTimer.TabStop = False
        Me.btnResetTimer.Text = "Reset Timer"
        Me.btnResetTimer.UseVisualStyleBackColor = True
        '
        'btnResetTracker
        '
        Me.btnResetTracker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResetTracker.Location = New System.Drawing.Point(23, 224)
        Me.btnResetTracker.Name = "btnResetTracker"
        Me.btnResetTracker.Size = New System.Drawing.Size(91, 23)
        Me.btnResetTracker.TabIndex = 8
        Me.btnResetTracker.TabStop = False
        Me.btnResetTracker.Text = "Reset Tracker"
        Me.btnResetTracker.UseVisualStyleBackColor = True
        '
        'btnResetAll
        '
        Me.btnResetAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResetAll.Location = New System.Drawing.Point(217, 224)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(91, 23)
        Me.btnResetAll.TabIndex = 9
        Me.btnResetAll.TabStop = False
        Me.btnResetAll.Text = "Reset All"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'nudTimerFontSize
        '
        Me.nudTimerFontSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimerFontSize.Location = New System.Drawing.Point(113, 100)
        Me.nudTimerFontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudTimerFontSize.Name = "nudTimerFontSize"
        Me.nudTimerFontSize.Size = New System.Drawing.Size(186, 20)
        Me.nudTimerFontSize.TabIndex = 12
        Me.nudTimerFontSize.TabStop = False
        Me.nudTimerFontSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'nudTimerSetHours
        '
        Me.nudTimerSetHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimerSetHours.Location = New System.Drawing.Point(32, 174)
        Me.nudTimerSetHours.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudTimerSetHours.Name = "nudTimerSetHours"
        Me.nudTimerSetHours.Size = New System.Drawing.Size(57, 20)
        Me.nudTimerSetHours.TabIndex = 13
        Me.nudTimerSetHours.TabStop = False
        '
        'nudTimerSetMinutes
        '
        Me.nudTimerSetMinutes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimerSetMinutes.Location = New System.Drawing.Point(102, 174)
        Me.nudTimerSetMinutes.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudTimerSetMinutes.Name = "nudTimerSetMinutes"
        Me.nudTimerSetMinutes.Size = New System.Drawing.Size(57, 20)
        Me.nudTimerSetMinutes.TabIndex = 14
        Me.nudTimerSetMinutes.TabStop = False
        '
        'nudTimerSetSeconds
        '
        Me.nudTimerSetSeconds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimerSetSeconds.Location = New System.Drawing.Point(172, 174)
        Me.nudTimerSetSeconds.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudTimerSetSeconds.Name = "nudTimerSetSeconds"
        Me.nudTimerSetSeconds.Size = New System.Drawing.Size(57, 20)
        Me.nudTimerSetSeconds.TabIndex = 15
        Me.nudTimerSetSeconds.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(156, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 26)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 26)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "."
        '
        'nudTimerSetMseconds
        '
        Me.nudTimerSetMseconds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimerSetMseconds.Location = New System.Drawing.Point(242, 174)
        Me.nudTimerSetMseconds.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudTimerSetMseconds.Name = "nudTimerSetMseconds"
        Me.nudTimerSetMseconds.Size = New System.Drawing.Size(57, 20)
        Me.nudTimerSetMseconds.TabIndex = 18
        Me.nudTimerSetMseconds.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Hours"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(108, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Minutes"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Seconds"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "ms"
        '
        'btnSetTimerTime
        '
        Me.btnSetTimerTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSetTimerTime.Location = New System.Drawing.Point(69, 213)
        Me.btnSetTimerTime.Name = "btnSetTimerTime"
        Me.btnSetTimerTime.Size = New System.Drawing.Size(89, 43)
        Me.btnSetTimerTime.TabIndex = 24
        Me.btnSetTimerTime.TabStop = False
        Me.btnSetTimerTime.Text = "Set Timer"
        Me.btnSetTimerTime.UseVisualStyleBackColor = True
        '
        'btnSetTimeInputsFromTimer
        '
        Me.btnSetTimeInputsFromTimer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSetTimeInputsFromTimer.Enabled = False
        Me.btnSetTimeInputsFromTimer.Location = New System.Drawing.Point(172, 213)
        Me.btnSetTimeInputsFromTimer.Name = "btnSetTimeInputsFromTimer"
        Me.btnSetTimeInputsFromTimer.Size = New System.Drawing.Size(89, 43)
        Me.btnSetTimeInputsFromTimer.TabIndex = 25
        Me.btnSetTimeInputsFromTimer.TabStop = False
        Me.btnSetTimeInputsFromTimer.Text = "Fill From Current Time"
        Me.btnSetTimeInputsFromTimer.UseVisualStyleBackColor = True
        '
        'lblPower
        '
        Me.lblPower.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(100, 78)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(28, 13)
        Me.lblPower.TabIndex = 30
        Me.lblPower.Text = "Pow"
        '
        'lblAgility
        '
        Me.lblAgility.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAgility.AutoSize = True
        Me.lblAgility.Location = New System.Drawing.Point(100, 104)
        Me.lblAgility.Name = "lblAgility"
        Me.lblAgility.Size = New System.Drawing.Size(25, 13)
        Me.lblAgility.TabIndex = 31
        Me.lblAgility.Text = "AGI"
        '
        'lblHP
        '
        Me.lblHP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(100, 126)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(22, 13)
        Me.lblHP.TabIndex = 32
        Me.lblHP.Text = "HP"
        '
        'lblMP
        '
        Me.lblMP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMP.AutoSize = True
        Me.lblMP.Location = New System.Drawing.Point(100, 152)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(23, 13)
        Me.lblMP.TabIndex = 33
        Me.lblMP.Text = "MP"
        '
        'btnSaveStats
        '
        Me.btnSaveStats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveStats.Location = New System.Drawing.Point(102, 176)
        Me.btnSaveStats.Name = "btnSaveStats"
        Me.btnSaveStats.Size = New System.Drawing.Size(129, 30)
        Me.btnSaveStats.TabIndex = 4
        Me.btnSaveStats.Text = "Save Starting Stats"
        Me.btnSaveStats.UseVisualStyleBackColor = True
        '
        'nudPower
        '
        Me.nudPower.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudPower.Location = New System.Drawing.Point(138, 74)
        Me.nudPower.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudPower.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.nudPower.Name = "nudPower"
        Me.nudPower.Size = New System.Drawing.Size(93, 20)
        Me.nudPower.TabIndex = 0
        '
        'nudAgility
        '
        Me.nudAgility.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudAgility.Location = New System.Drawing.Point(138, 100)
        Me.nudAgility.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudAgility.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.nudAgility.Name = "nudAgility"
        Me.nudAgility.Size = New System.Drawing.Size(93, 20)
        Me.nudAgility.TabIndex = 1
        '
        'nudHP
        '
        Me.nudHP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudHP.Location = New System.Drawing.Point(138, 122)
        Me.nudHP.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudHP.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.nudHP.Name = "nudHP"
        Me.nudHP.Size = New System.Drawing.Size(93, 20)
        Me.nudHP.TabIndex = 2
        '
        'nudMP
        '
        Me.nudMP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudMP.Location = New System.Drawing.Point(138, 148)
        Me.nudMP.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMP.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.nudMP.Name = "nudMP"
        Me.nudMP.Size = New System.Drawing.Size(93, 20)
        Me.nudMP.TabIndex = 3
        '
        'btnResetStats
        '
        Me.btnResetStats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResetStats.Location = New System.Drawing.Point(120, 224)
        Me.btnResetStats.Name = "btnResetStats"
        Me.btnResetStats.Size = New System.Drawing.Size(91, 23)
        Me.btnResetStats.TabIndex = 39
        Me.btnResetStats.TabStop = False
        Me.btnResetStats.Text = "Reset Stats"
        Me.btnResetStats.UseVisualStyleBackColor = True
        '
        'tabForms
        '
        Me.tabForms.Controls.Add(Me.tpControls)
        Me.tabForms.Controls.Add(Me.tpTimerSettings)
        Me.tabForms.Controls.Add(Me.tpHeaderSettings)
        Me.tabForms.Controls.Add(Me.tbOther)
        Me.tabForms.Controls.Add(Me.tpAdmin)
        Me.tabForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabForms.Location = New System.Drawing.Point(0, 0)
        Me.tabForms.Name = "tabForms"
        Me.tabForms.SelectedIndex = 0
        Me.tabForms.Size = New System.Drawing.Size(339, 294)
        Me.tabForms.TabIndex = 40
        Me.tabForms.TabStop = False
        '
        'tpControls
        '
        Me.tpControls.Controls.Add(Me.btnSimulateDLFights)
        Me.tpControls.Controls.Add(Me.btnStartPauseTimer)
        Me.tpControls.Controls.Add(Me.btnResetStats)
        Me.tpControls.Controls.Add(Me.nudMP)
        Me.tpControls.Controls.Add(Me.btnResetTracker)
        Me.tpControls.Controls.Add(Me.btnResetAll)
        Me.tpControls.Controls.Add(Me.btnResetTimer)
        Me.tpControls.Controls.Add(Me.nudHP)
        Me.tpControls.Controls.Add(Me.nudPower)
        Me.tpControls.Controls.Add(Me.nudAgility)
        Me.tpControls.Controls.Add(Me.lblPower)
        Me.tpControls.Controls.Add(Me.lblAgility)
        Me.tpControls.Controls.Add(Me.btnSaveStats)
        Me.tpControls.Controls.Add(Me.lblHP)
        Me.tpControls.Controls.Add(Me.lblMP)
        Me.tpControls.Location = New System.Drawing.Point(4, 22)
        Me.tpControls.Name = "tpControls"
        Me.tpControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpControls.Size = New System.Drawing.Size(331, 268)
        Me.tpControls.TabIndex = 0
        Me.tpControls.Text = "Controls"
        Me.tpControls.UseVisualStyleBackColor = True
        '
        'btnSimulateDLFights
        '
        Me.btnSimulateDLFights.Location = New System.Drawing.Point(254, 176)
        Me.btnSimulateDLFights.Name = "btnSimulateDLFights"
        Me.btnSimulateDLFights.Size = New System.Drawing.Size(49, 30)
        Me.btnSimulateDLFights.TabIndex = 40
        Me.btnSimulateDLFights.Text = "Sim DL"
        Me.btnSimulateDLFights.UseVisualStyleBackColor = True
        '
        'tpTimerSettings
        '
        Me.tpTimerSettings.Controls.Add(Me.Label12)
        Me.tpTimerSettings.Controls.Add(Me.nudTimerDecimalPlaces)
        Me.tpTimerSettings.Controls.Add(Me.Label11)
        Me.tpTimerSettings.Controls.Add(Me.Label1)
        Me.tpTimerSettings.Controls.Add(Me.cmbTimerFont)
        Me.tpTimerSettings.Controls.Add(Me.cmbTimerFontColor)
        Me.tpTimerSettings.Controls.Add(Me.cmbBackColor)
        Me.tpTimerSettings.Controls.Add(Me.Label2)
        Me.tpTimerSettings.Controls.Add(Me.Label3)
        Me.tpTimerSettings.Controls.Add(Me.nudTimerFontSize)
        Me.tpTimerSettings.Controls.Add(Me.btnSetTimeInputsFromTimer)
        Me.tpTimerSettings.Controls.Add(Me.nudTimerSetHours)
        Me.tpTimerSettings.Controls.Add(Me.btnSetTimerTime)
        Me.tpTimerSettings.Controls.Add(Me.nudTimerSetMinutes)
        Me.tpTimerSettings.Controls.Add(Me.Label10)
        Me.tpTimerSettings.Controls.Add(Me.nudTimerSetSeconds)
        Me.tpTimerSettings.Controls.Add(Me.Label9)
        Me.tpTimerSettings.Controls.Add(Me.Label4)
        Me.tpTimerSettings.Controls.Add(Me.Label8)
        Me.tpTimerSettings.Controls.Add(Me.Label5)
        Me.tpTimerSettings.Controls.Add(Me.Label7)
        Me.tpTimerSettings.Controls.Add(Me.nudTimerSetMseconds)
        Me.tpTimerSettings.Controls.Add(Me.Label6)
        Me.tpTimerSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpTimerSettings.Name = "tpTimerSettings"
        Me.tpTimerSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTimerSettings.Size = New System.Drawing.Size(331, 268)
        Me.tpTimerSettings.TabIndex = 1
        Me.tpTimerSettings.Text = "Timer Settings"
        Me.tpTimerSettings.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Decimal Places:"
        '
        'nudTimerDecimalPlaces
        '
        Me.nudTimerDecimalPlaces.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimerDecimalPlaces.Location = New System.Drawing.Point(113, 126)
        Me.nudTimerDecimalPlaces.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudTimerDecimalPlaces.Name = "nudTimerDecimalPlaces"
        Me.nudTimerDecimalPlaces.Size = New System.Drawing.Size(186, 20)
        Me.nudTimerDecimalPlaces.TabIndex = 27
        Me.nudTimerDecimalPlaces.TabStop = False
        Me.nudTimerDecimalPlaces.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Font Size:"
        '
        'tpHeaderSettings
        '
        Me.tpHeaderSettings.Controls.Add(Me.GroupBox2)
        Me.tpHeaderSettings.Controls.Add(Me.GroupBox1)
        Me.tpHeaderSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpHeaderSettings.Name = "tpHeaderSettings"
        Me.tpHeaderSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHeaderSettings.Size = New System.Drawing.Size(331, 268)
        Me.tpHeaderSettings.TabIndex = 3
        Me.tpHeaderSettings.Text = "Header Settings"
        Me.tpHeaderSettings.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnSetHeader2Match1)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cmbHeader2Font)
        Me.GroupBox2.Controls.Add(Me.cmbHeader2Color)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.chkHeader2Enabled)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.nudLine2FontSize)
        Me.GroupBox2.Controls.Add(Me.txtHeader2String)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 118)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Header 2"
        '
        'btnSetHeader2Match1
        '
        Me.btnSetHeader2Match1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSetHeader2Match1.Location = New System.Drawing.Point(235, 27)
        Me.btnSetHeader2Match1.Name = "btnSetHeader2Match1"
        Me.btnSetHeader2Match1.Size = New System.Drawing.Size(58, 37)
        Me.btnSetHeader2Match1.TabIndex = 38
        Me.btnSetHeader2Match1.Text = "Match 1"
        Me.btnSetHeader2Match1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Font:"
        '
        'cmbHeader2Font
        '
        Me.cmbHeader2Font.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHeader2Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeader2Font.FormattingEnabled = True
        Me.cmbHeader2Font.Location = New System.Drawing.Point(84, 12)
        Me.cmbHeader2Font.Name = "cmbHeader2Font"
        Me.cmbHeader2Font.Size = New System.Drawing.Size(145, 21)
        Me.cmbHeader2Font.TabIndex = 37
        Me.cmbHeader2Font.TabStop = False
        '
        'cmbHeader2Color
        '
        Me.cmbHeader2Color.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHeader2Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeader2Color.FormattingEnabled = True
        Me.cmbHeader2Color.Location = New System.Drawing.Point(84, 39)
        Me.cmbHeader2Color.Name = "cmbHeader2Color"
        Me.cmbHeader2Color.Size = New System.Drawing.Size(145, 21)
        Me.cmbHeader2Color.TabIndex = 38
        Me.cmbHeader2Color.TabStop = False
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Text Color:"
        '
        'chkHeader2Enabled
        '
        Me.chkHeader2Enabled.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkHeader2Enabled.AutoSize = True
        Me.chkHeader2Enabled.Checked = True
        Me.chkHeader2Enabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeader2Enabled.Location = New System.Drawing.Point(236, 10)
        Me.chkHeader2Enabled.Name = "chkHeader2Enabled"
        Me.chkHeader2Enabled.Size = New System.Drawing.Size(59, 17)
        Me.chkHeader2Enabled.TabIndex = 32
        Me.chkHeader2Enabled.Text = "Enable"
        Me.chkHeader2Enabled.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Font Size:"
        '
        'nudLine2FontSize
        '
        Me.nudLine2FontSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudLine2FontSize.Location = New System.Drawing.Point(84, 92)
        Me.nudLine2FontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudLine2FontSize.Name = "nudLine2FontSize"
        Me.nudLine2FontSize.Size = New System.Drawing.Size(209, 20)
        Me.nudLine2FontSize.TabIndex = 29
        Me.nudLine2FontSize.TabStop = False
        Me.nudLine2FontSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'txtHeader2String
        '
        Me.txtHeader2String.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeader2String.Location = New System.Drawing.Point(84, 66)
        Me.txtHeader2String.Name = "txtHeader2String"
        Me.txtHeader2String.Size = New System.Drawing.Size(208, 20)
        Me.txtHeader2String.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Text"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSetHeader1MatchTimer)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmbHeader1Font)
        Me.GroupBox1.Controls.Add(Me.cmbHeader1Color)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.chkHeader1Enabled)
        Me.GroupBox1.Controls.Add(Me.txtHeader1String)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.nudLine1FontSize)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 118)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Header 1"
        '
        'btnSetHeader1MatchTimer
        '
        Me.btnSetHeader1MatchTimer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSetHeader1MatchTimer.Location = New System.Drawing.Point(235, 27)
        Me.btnSetHeader1MatchTimer.Name = "btnSetHeader1MatchTimer"
        Me.btnSetHeader1MatchTimer.Size = New System.Drawing.Size(58, 37)
        Me.btnSetHeader1MatchTimer.TabIndex = 37
        Me.btnSetHeader1MatchTimer.Text = "Match Timer"
        Me.btnSetHeader1MatchTimer.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Font:"
        '
        'cmbHeader1Font
        '
        Me.cmbHeader1Font.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHeader1Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeader1Font.FormattingEnabled = True
        Me.cmbHeader1Font.Location = New System.Drawing.Point(84, 12)
        Me.cmbHeader1Font.Name = "cmbHeader1Font"
        Me.cmbHeader1Font.Size = New System.Drawing.Size(145, 21)
        Me.cmbHeader1Font.TabIndex = 33
        Me.cmbHeader1Font.TabStop = False
        '
        'cmbHeader1Color
        '
        Me.cmbHeader1Color.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHeader1Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeader1Color.FormattingEnabled = True
        Me.cmbHeader1Color.Location = New System.Drawing.Point(84, 39)
        Me.cmbHeader1Color.Name = "cmbHeader1Color"
        Me.cmbHeader1Color.Size = New System.Drawing.Size(145, 21)
        Me.cmbHeader1Color.TabIndex = 34
        Me.cmbHeader1Color.TabStop = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Text Color:"
        '
        'chkHeader1Enabled
        '
        Me.chkHeader1Enabled.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkHeader1Enabled.AutoSize = True
        Me.chkHeader1Enabled.Checked = True
        Me.chkHeader1Enabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeader1Enabled.Location = New System.Drawing.Point(236, 10)
        Me.chkHeader1Enabled.Name = "chkHeader1Enabled"
        Me.chkHeader1Enabled.Size = New System.Drawing.Size(59, 17)
        Me.chkHeader1Enabled.TabIndex = 31
        Me.chkHeader1Enabled.Text = "Enable"
        Me.chkHeader1Enabled.UseVisualStyleBackColor = True
        '
        'txtHeader1String
        '
        Me.txtHeader1String.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeader1String.Location = New System.Drawing.Point(84, 66)
        Me.txtHeader1String.Name = "txtHeader1String"
        Me.txtHeader1String.Size = New System.Drawing.Size(208, 20)
        Me.txtHeader1String.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Text"
        '
        'nudLine1FontSize
        '
        Me.nudLine1FontSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudLine1FontSize.Location = New System.Drawing.Point(84, 92)
        Me.nudLine1FontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudLine1FontSize.Name = "nudLine1FontSize"
        Me.nudLine1FontSize.Size = New System.Drawing.Size(208, 20)
        Me.nudLine1FontSize.TabIndex = 27
        Me.nudLine1FontSize.TabStop = False
        Me.nudLine1FontSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Font Size:"
        '
        'tbOther
        '
        Me.tbOther.Controls.Add(Me.chkMHImages)
        Me.tbOther.Controls.Add(Me.chkEnableRunPercent)
        Me.tbOther.Controls.Add(Me.GroupBox4)
        Me.tbOther.Controls.Add(Me.GroupBox3)
        Me.tbOther.Controls.Add(Me.Label17)
        Me.tbOther.Controls.Add(Me.chkTrackerView)
        Me.tbOther.Controls.Add(Me.chkTimerView)
        Me.tbOther.Controls.Add(Me.chkEnableCalculation)
        Me.tbOther.Controls.Add(Me.chkEnableStats)
        Me.tbOther.Controls.Add(Me.btnOpenMapForm)
        Me.tbOther.Location = New System.Drawing.Point(4, 22)
        Me.tbOther.Name = "tbOther"
        Me.tbOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOther.Size = New System.Drawing.Size(331, 268)
        Me.tbOther.TabIndex = 2
        Me.tbOther.Text = "Extras"
        Me.tbOther.UseVisualStyleBackColor = True
        '
        'chkMHImages
        '
        Me.chkMHImages.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMHImages.AutoSize = True
        Me.chkMHImages.Location = New System.Drawing.Point(171, 90)
        Me.chkMHImages.Name = "chkMHImages"
        Me.chkMHImages.Size = New System.Drawing.Size(124, 17)
        Me.chkMHImages.TabIndex = 45
        Me.chkMHImages.Text = "MisterHomes Images"
        Me.chkMHImages.UseVisualStyleBackColor = True
        '
        'chkEnableRunPercent
        '
        Me.chkEnableRunPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkEnableRunPercent.AutoSize = True
        Me.chkEnableRunPercent.Checked = True
        Me.chkEnableRunPercent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableRunPercent.Location = New System.Drawing.Point(20, 90)
        Me.chkEnableRunPercent.Name = "chkEnableRunPercent"
        Me.chkEnableRunPercent.Size = New System.Drawing.Size(142, 17)
        Me.chkEnableRunPercent.TabIndex = 44
        Me.chkEnableRunPercent.Text = "Enable Run/Back Atk %"
        Me.chkEnableRunPercent.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btnOpenBGImgSelector)
        Me.GroupBox4.Controls.Add(Me.chkBackgroundImage)
        Me.GroupBox4.Controls.Add(Me.txtImageFileLocation)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 62)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        '
        'btnOpenBGImgSelector
        '
        Me.btnOpenBGImgSelector.Location = New System.Drawing.Point(12, 30)
        Me.btnOpenBGImgSelector.Name = "btnOpenBGImgSelector"
        Me.btnOpenBGImgSelector.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenBGImgSelector.TabIndex = 37
        Me.btnOpenBGImgSelector.Text = "Select File"
        Me.btnOpenBGImgSelector.UseVisualStyleBackColor = True
        '
        'chkBackgroundImage
        '
        Me.chkBackgroundImage.AutoSize = True
        Me.chkBackgroundImage.Checked = True
        Me.chkBackgroundImage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBackgroundImage.Location = New System.Drawing.Point(12, 10)
        Me.chkBackgroundImage.Name = "chkBackgroundImage"
        Me.chkBackgroundImage.Size = New System.Drawing.Size(138, 17)
        Me.chkBackgroundImage.TabIndex = 36
        Me.chkBackgroundImage.Text = "Use Background Image"
        Me.chkBackgroundImage.UseVisualStyleBackColor = True
        '
        'txtImageFileLocation
        '
        Me.txtImageFileLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImageFileLocation.Location = New System.Drawing.Point(93, 33)
        Me.txtImageFileLocation.Name = "txtImageFileLocation"
        Me.txtImageFileLocation.Size = New System.Drawing.Size(216, 20)
        Me.txtImageFileLocation.TabIndex = 35
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnMatchOtherLabelsToTimer)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.cmbOtherLabelFont)
        Me.GroupBox3.Controls.Add(Me.cmbOtherLabelColor)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 74)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Labels"
        '
        'btnMatchOtherLabelsToTimer
        '
        Me.btnMatchOtherLabelsToTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMatchOtherLabelsToTimer.Location = New System.Drawing.Point(251, 17)
        Me.btnMatchOtherLabelsToTimer.Name = "btnMatchOtherLabelsToTimer"
        Me.btnMatchOtherLabelsToTimer.Size = New System.Drawing.Size(58, 48)
        Me.btnMatchOtherLabelsToTimer.TabIndex = 37
        Me.btnMatchOtherLabelsToTimer.Text = "Match Timer"
        Me.btnMatchOtherLabelsToTimer.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Font:"
        '
        'cmbOtherLabelFont
        '
        Me.cmbOtherLabelFont.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOtherLabelFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOtherLabelFont.FormattingEnabled = True
        Me.cmbOtherLabelFont.Location = New System.Drawing.Point(77, 17)
        Me.cmbOtherLabelFont.Name = "cmbOtherLabelFont"
        Me.cmbOtherLabelFont.Size = New System.Drawing.Size(168, 21)
        Me.cmbOtherLabelFont.TabIndex = 33
        Me.cmbOtherLabelFont.TabStop = False
        '
        'cmbOtherLabelColor
        '
        Me.cmbOtherLabelColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOtherLabelColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOtherLabelColor.FormattingEnabled = True
        Me.cmbOtherLabelColor.Location = New System.Drawing.Point(77, 44)
        Me.cmbOtherLabelColor.Name = "cmbOtherLabelColor"
        Me.cmbOtherLabelColor.Size = New System.Drawing.Size(168, 21)
        Me.cmbOtherLabelColor.TabIndex = 34
        Me.cmbOtherLabelColor.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Text Color:"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.Location = New System.Drawing.Point(171, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 29)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Vanilla maps courtesy of gameboyf9, and RyuSeishin"
        '
        'chkTrackerView
        '
        Me.chkTrackerView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTrackerView.AutoSize = True
        Me.chkTrackerView.Checked = True
        Me.chkTrackerView.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrackerView.Location = New System.Drawing.Point(171, 49)
        Me.chkTrackerView.Name = "chkTrackerView"
        Me.chkTrackerView.Size = New System.Drawing.Size(125, 17)
        Me.chkTrackerView.TabIndex = 39
        Me.chkTrackerView.Text = "Enable Tracker View"
        Me.chkTrackerView.UseVisualStyleBackColor = True
        '
        'chkTimerView
        '
        Me.chkTimerView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTimerView.AutoSize = True
        Me.chkTimerView.Checked = True
        Me.chkTimerView.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimerView.Location = New System.Drawing.Point(171, 70)
        Me.chkTimerView.Name = "chkTimerView"
        Me.chkTimerView.Size = New System.Drawing.Size(114, 17)
        Me.chkTimerView.TabIndex = 38
        Me.chkTimerView.Text = "Enable Timer View"
        Me.chkTimerView.UseVisualStyleBackColor = True
        '
        'chkEnableCalculation
        '
        Me.chkEnableCalculation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkEnableCalculation.AutoSize = True
        Me.chkEnableCalculation.Checked = True
        Me.chkEnableCalculation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableCalculation.Location = New System.Drawing.Point(20, 70)
        Me.chkEnableCalculation.Name = "chkEnableCalculation"
        Me.chkEnableCalculation.Size = New System.Drawing.Size(140, 17)
        Me.chkEnableCalculation.TabIndex = 34
        Me.chkEnableCalculation.Text = "Enable Calculation View"
        Me.chkEnableCalculation.UseVisualStyleBackColor = True
        '
        'chkEnableStats
        '
        Me.chkEnableStats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkEnableStats.AutoSize = True
        Me.chkEnableStats.Checked = True
        Me.chkEnableStats.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableStats.Location = New System.Drawing.Point(20, 49)
        Me.chkEnableStats.Name = "chkEnableStats"
        Me.chkEnableStats.Size = New System.Drawing.Size(112, 17)
        Me.chkEnableStats.TabIndex = 33
        Me.chkEnableStats.Text = "Enable Stats View"
        Me.chkEnableStats.UseVisualStyleBackColor = True
        '
        'btnOpenMapForm
        '
        Me.btnOpenMapForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOpenMapForm.Location = New System.Drawing.Point(20, 5)
        Me.btnOpenMapForm.Name = "btnOpenMapForm"
        Me.btnOpenMapForm.Size = New System.Drawing.Size(119, 40)
        Me.btnOpenMapForm.TabIndex = 0
        Me.btnOpenMapForm.Text = "Show Maps Page"
        Me.btnOpenMapForm.UseVisualStyleBackColor = True
        '
        'tpAdmin
        '
        Me.tpAdmin.Controls.Add(Me.grpDLSimulationSettings)
        Me.tpAdmin.Controls.Add(Me.chkEnableFactoryReset)
        Me.tpAdmin.Controls.Add(Me.btnResetToFactory)
        Me.tpAdmin.Location = New System.Drawing.Point(4, 22)
        Me.tpAdmin.Name = "tpAdmin"
        Me.tpAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdmin.Size = New System.Drawing.Size(331, 268)
        Me.tpAdmin.TabIndex = 4
        Me.tpAdmin.Text = "Admin"
        Me.tpAdmin.UseVisualStyleBackColor = True
        '
        'chkEnableFactoryReset
        '
        Me.chkEnableFactoryReset.AutoSize = True
        Me.chkEnableFactoryReset.Location = New System.Drawing.Point(114, 23)
        Me.chkEnableFactoryReset.Name = "chkEnableFactoryReset"
        Me.chkEnableFactoryReset.Size = New System.Drawing.Size(59, 17)
        Me.chkEnableFactoryReset.TabIndex = 1
        Me.chkEnableFactoryReset.Text = "Enable"
        Me.chkEnableFactoryReset.UseVisualStyleBackColor = True
        '
        'btnResetToFactory
        '
        Me.btnResetToFactory.Enabled = False
        Me.btnResetToFactory.Location = New System.Drawing.Point(9, 7)
        Me.btnResetToFactory.Name = "btnResetToFactory"
        Me.btnResetToFactory.Size = New System.Drawing.Size(98, 47)
        Me.btnResetToFactory.TabIndex = 0
        Me.btnResetToFactory.Text = "Reset To Factory"
        Me.btnResetToFactory.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblSimulations
        '
        Me.lblSimulations.AutoSize = True
        Me.lblSimulations.Location = New System.Drawing.Point(14, 21)
        Me.lblSimulations.Name = "lblSimulations"
        Me.lblSimulations.Size = New System.Drawing.Size(85, 13)
        Me.lblSimulations.TabIndex = 49
        Me.lblSimulations.Text = "# of Simulations:"
        '
        'nudNumberOfSimulations
        '
        Me.nudNumberOfSimulations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudNumberOfSimulations.Location = New System.Drawing.Point(105, 19)
        Me.nudNumberOfSimulations.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.nudNumberOfSimulations.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudNumberOfSimulations.Name = "nudNumberOfSimulations"
        Me.nudNumberOfSimulations.Size = New System.Drawing.Size(183, 20)
        Me.nudNumberOfSimulations.TabIndex = 48
        Me.nudNumberOfSimulations.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'grpDLSimulationSettings
        '
        Me.grpDLSimulationSettings.Controls.Add(Me.nudDLSimStartingHerbs)
        Me.grpDLSimulationSettings.Controls.Add(Me.Label25)
        Me.grpDLSimulationSettings.Controls.Add(Me.nudDLSimMinHealth)
        Me.grpDLSimulationSettings.Controls.Add(Me.Label24)
        Me.grpDLSimulationSettings.Controls.Add(Me.nudNumberOfSimulations)
        Me.grpDLSimulationSettings.Controls.Add(Me.lblSimulations)
        Me.grpDLSimulationSettings.Location = New System.Drawing.Point(8, 60)
        Me.grpDLSimulationSettings.Name = "grpDLSimulationSettings"
        Me.grpDLSimulationSettings.Size = New System.Drawing.Size(314, 98)
        Me.grpDLSimulationSettings.TabIndex = 50
        Me.grpDLSimulationSettings.TabStop = False
        Me.grpDLSimulationSettings.Text = "DL Fight Simulation"
        '
        'nudDLSimMinHealth
        '
        Me.nudDLSimMinHealth.Location = New System.Drawing.Point(142, 45)
        Me.nudDLSimMinHealth.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nudDLSimMinHealth.Name = "nudDLSimMinHealth"
        Me.nudDLSimMinHealth.Size = New System.Drawing.Size(146, 20)
        Me.nudDLSimMinHealth.TabIndex = 50
        Me.nudDLSimMinHealth.Value = New Decimal(New Integer() {48, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(14, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(122, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Maximum Attack Health:"
        '
        'nudDLSimStartingHerbs
        '
        Me.nudDLSimStartingHerbs.Location = New System.Drawing.Point(142, 71)
        Me.nudDLSimStartingHerbs.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudDLSimStartingHerbs.Name = "nudDLSimStartingHerbs"
        Me.nudDLSimStartingHerbs.Size = New System.Drawing.Size(146, 20)
        Me.nudDLSimStartingHerbs.TabIndex = 52
        Me.nudDLSimStartingHerbs.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 13)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "Starting Herbs:"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 294)
        Me.Controls.Add(Me.tabForms)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.nudTimerFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimerSetHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimerSetMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimerSetSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimerSetMseconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAgility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabForms.ResumeLayout(False)
        Me.tpControls.ResumeLayout(False)
        Me.tpControls.PerformLayout()
        Me.tpTimerSettings.ResumeLayout(False)
        Me.tpTimerSettings.PerformLayout()
        CType(Me.nudTimerDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHeaderSettings.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudLine2FontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudLine1FontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOther.ResumeLayout(False)
        Me.tbOther.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tpAdmin.ResumeLayout(False)
        Me.tpAdmin.PerformLayout()
        CType(Me.nudNumberOfSimulations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDLSimulationSettings.ResumeLayout(False)
        Me.grpDLSimulationSettings.PerformLayout()
        CType(Me.nudDLSimMinHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDLSimStartingHerbs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbTimerFont As ComboBox
    Friend WithEvents cmbTimerFontColor As ComboBox
    Friend WithEvents cmbBackColor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStartPauseTimer As Button
    Friend WithEvents btnResetTimer As Button
    Friend WithEvents btnResetTracker As Button
    Friend WithEvents btnResetAll As Button
    Friend WithEvents nudTimerFontSize As NumericUpDown
    Friend WithEvents nudTimerSetHours As NumericUpDown
    Friend WithEvents nudTimerSetMinutes As NumericUpDown
    Friend WithEvents nudTimerSetSeconds As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudTimerSetMseconds As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSetTimerTime As Button
    Friend WithEvents btnSetTimeInputsFromTimer As Button
    Friend WithEvents lblPower As Label
    Friend WithEvents lblAgility As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblMP As Label
    Friend WithEvents btnSaveStats As Button
    Friend WithEvents nudPower As NumericUpDown
    Friend WithEvents nudAgility As NumericUpDown
    Friend WithEvents nudHP As NumericUpDown
    Friend WithEvents nudMP As NumericUpDown
    Friend WithEvents btnResetStats As Button
    Friend WithEvents tabForms As TabControl
    Friend WithEvents tpControls As TabPage
    Friend WithEvents tpTimerSettings As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents tbOther As TabPage
    Friend WithEvents btnOpenMapForm As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents nudTimerDecimalPlaces As NumericUpDown
    Friend WithEvents tpHeaderSettings As TabPage
    Friend WithEvents txtHeader2String As TextBox
    Friend WithEvents txtHeader1String As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents nudLine1FontSize As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents nudLine2FontSize As NumericUpDown
    Friend WithEvents chkHeader2Enabled As CheckBox
    Friend WithEvents chkHeader1Enabled As CheckBox
    Friend WithEvents chkEnableCalculation As CheckBox
    Friend WithEvents chkEnableStats As CheckBox
    Friend WithEvents btnOpenBGImgSelector As Button
    Friend WithEvents chkBackgroundImage As CheckBox
    Friend WithEvents txtImageFileLocation As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chkTrackerView As CheckBox
    Friend WithEvents chkTimerView As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSetHeader2Match1 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbHeader2Font As ComboBox
    Friend WithEvents cmbHeader2Color As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSetHeader1MatchTimer As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbHeader1Font As ComboBox
    Friend WithEvents cmbHeader1Color As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnMatchOtherLabelsToTimer As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbOtherLabelFont As ComboBox
    Friend WithEvents cmbOtherLabelColor As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkEnableRunPercent As CheckBox
    Friend WithEvents tpAdmin As TabPage
    Friend WithEvents chkEnableFactoryReset As CheckBox
    Friend WithEvents btnResetToFactory As Button
    Friend WithEvents chkMHImages As CheckBox
    Friend WithEvents btnSimulateDLFights As Button
    Friend WithEvents lblSimulations As Label
    Friend WithEvents nudNumberOfSimulations As NumericUpDown
    Friend WithEvents grpDLSimulationSettings As GroupBox
    Friend WithEvents nudDLSimMinHealth As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents nudDLSimStartingHerbs As NumericUpDown
    Friend WithEvents Label25 As Label
End Class
