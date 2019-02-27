Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Settings
    Public Const WM_HOTKEY As Integer = &H312
    'Public Const MOD_ALT As Integer = &H1 'Alt key
    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function
    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function


    Dim frmTracker As DWRTackerWindow
    Dim timer As Timer
    Dim dtmStartTime As DateTime
    Dim tsPausedTime As TimeSpan = TimeSpan.Zero
    Dim blnIsInitializing As Boolean = True
    'Dim keyTimerStartPause As Keys.Multiply
    Dim sngOtherTextSize As Single = 12


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        timer = New Timer()
        AddHandler timer.Tick, AddressOf updatetime
        InitializeFonts()

        btnStartPauseTimer.Tag = False

        frmTracker = New DWRTackerWindow
        frmTracker.Show()
        LoadSettingSaves()

        SetEnabled()
        SetPanelHeights()
        setFonts()
        InitializeTrackerItems()
        UpdateStatsView(frmTracker)
        RegisterKeys()


    End Sub

    Private Sub RegisterKeys()
        RegisterHotKey(Me.Handle, 100, Keys.None, Keys.Multiply)
        RegisterHotKey(Me.Handle, 200, Keys.None, Keys.Delete)

    End Sub

    Private Sub InitializeFonts()
        LoadFonts()
        LoadColors()

        SetFontDefaults()
        LoadFontSaves()

    End Sub
    Private Sub LoadColors()
        For Each color In New ColorConverter().GetStandardValues
            cmbTimerFontColor.Items.Add(color)
            cmbHeader1Color.Items.Add(color)
            cmbHeader2Color.Items.Add(color)
            cmbOtherLabelColor.Items.Add(color)
            cmbBackColor.Items.Add(color)
        Next
    End Sub
    Private Sub LoadFonts()
        For Each strFont As FontFamily In System.Drawing.FontFamily.Families
            If strFont.IsStyleAvailable(FontStyle.Regular) Then
                cmbTimerFont.Items.Add(strFont)
                cmbHeader1Font.Items.Add(strFont)
                cmbHeader2Font.Items.Add(strFont)
                cmbOtherLabelFont.Items.Add(strFont)
            End If
        Next
        Dim cfntCustomFonts As New PrivateFontCollection
        For Each fiFile As FileInfo In New DirectoryInfo(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Fonts\")).GetFiles
            If fiFile.Extension = ".ttf" Then
                cfntCustomFonts.AddFontFile(fiFile.FullName)
            End If
        Next
        For Each fntCustomFont As FontFamily In cfntCustomFonts.Families
            If fntCustomFont.IsStyleAvailable(FontStyle.Regular) Then
                cmbTimerFont.Items.Add(fntCustomFont)
                cmbHeader1Font.Items.Add(fntCustomFont)
                cmbHeader2Font.Items.Add(fntCustomFont)
                cmbOtherLabelFont.Items.Add(fntCustomFont)
            End If
        Next
        cmbTimerFont.DisplayMember = "Name"
        cmbHeader1Font.DisplayMember = "Name"
        cmbHeader2Font.DisplayMember = "Name"
        cmbOtherLabelFont.DisplayMember = "Name"

        cmbTimerFontColor.DisplayMember = "Name"
        cmbHeader1Color.DisplayMember = "Name"
        cmbHeader2Color.DisplayMember = "Name"
        cmbOtherLabelColor.DisplayMember = "Name"
        cmbBackColor.DisplayMember = "Name"

    End Sub

    Private Sub SetFontDefaults()
        If My.Settings.Font Is Nothing Or My.Settings.Font.Length < 1 Then
            My.Settings.Font = "Times New Roman"
        End If
        If My.Settings.TextColor Is Nothing Or My.Settings.TextColor.Length < 1 Then
            My.Settings.TextColor = "White"
        End If
        If My.Settings.BackgroundColor Is Nothing Or My.Settings.BackgroundColor.Length < 1 Then
            My.Settings.BackgroundColor = "DarkOliveGreen"
        End If
    End Sub

    Private Sub LoadFontSaves()
        nudTimerFontSize.Value = My.Settings.FontSize
        Dim strLastUsedFont As String = My.Settings.Font
        Dim blnFontStillExists As Boolean = False
        For Each item In cmbTimerFont.Items
            If item.Name = strLastUsedFont Then
                blnFontStillExists = True
                Exit For
            End If
        Next
        If blnFontStillExists Then

            cmbTimerFont.Text = My.Settings.Font
            cmbHeader1Font.Text = My.Settings.strHeader1Font
            cmbHeader2Font.Text = My.Settings.strHeader2Font
            cmbOtherLabelFont.Text = My.Settings.strOtherLabelFont
        Else
            cmbTimerFont.Text = "Times New Roman"
            cmbHeader1Font.Text = "Times New Roman"
            cmbHeader2Font.Text = "Times New Roman"
        End If
        cmbTimerFontColor.Text = My.Settings.TextColor
        cmbHeader1Color.Text = My.Settings.strHeader1Color
        cmbHeader2Color.Text = My.Settings.strHeader2Color
        cmbOtherLabelColor.Text = My.Settings.strOtherLabelColor
        cmbBackColor.Text = My.Settings.BackgroundColor
    End Sub

    Private Sub LoadSettingSaves()
        chkTimerView.Checked = My.Settings.blnTimerEnabled
        chkTrackerView.Checked = My.Settings.blnTrackerEnabled
        chkEnableCalculation.Checked = My.Settings.blnCalculationBlockEnabled
        chkEnableStats.Checked = My.Settings.blnStatsBlockEnabled
        chkHeader1Enabled.Checked = My.Settings.blnEnableHeader1
        chkHeader2Enabled.Checked = My.Settings.blnEnableHeader2
        chkBackgroundImage.Checked = My.Settings.blnUseBackgroundImage
        chkEnableRunPercent.Checked = My.Settings.blnEnableRunPercent
        txtImageFileLocation.Text = My.Settings.strBackgroundImageLocation
        frmTracker.BackColor = cmbBackColor.SelectedItem
        nudTimerFontSize.Value = My.Settings.FontSize
        tsPausedTime = My.Settings.PausedTime
        frmTracker.lblTimerOutput.Text = getTimespanString(tsPausedTime)
        btnSaveStats.Tag = False
        frmTracker.Height = My.Settings.intDWRTrackerHeight
        frmTracker.Width = My.Settings.intDWRTrackerWidth
        blnIsInitializing = False
        txtHeader1String.Text = My.Settings.strHeaderLine1
        txtHeader2String.Text = My.Settings.strHeaderLine2
        nudTimerDecimalPlaces.Value = My.Settings.intDecimalPlaces
        nudLine1FontSize.Value = My.Settings.intLine1FontSize
        nudLine2FontSize.Value = My.Settings.intLine2FontSize
        If chkBackgroundImage.Checked AndAlso My.Settings.strBackgroundImageLocation.Length > 0 Then
            SetBackgroundImage(My.Settings.strBackgroundImageLocation)
        End If
        btnOpenBGImgSelector.Enabled = chkBackgroundImage.Checked
        txtImageFileLocation.Enabled = chkBackgroundImage.Checked
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    Start_PauseTimer()
                Case "200"
                    ResetTimer()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub btnStartPauseTimer_Click(sender As Object, e As EventArgs) Handles btnStartPauseTimer.Click

        Start_PauseTimer()
    End Sub

    Private Sub updatetime()
        Dim tsCurrentTime As TimeSpan = ((Now - dtmStartTime) + tsPausedTime)



        frmTracker.lblTimerOutput.Text = getTimespanString(tsCurrentTime)
    End Sub
    Public Function getTimespanString(tsValue As TimeSpan) As String
        Dim intHours As Integer = (tsValue.Days * 24) + tsValue.Hours
        Dim intMinutes As Integer = tsValue.Minutes
        Dim intSeconds As Integer = tsValue.Seconds
        Dim strMilliseconds As String = tsValue.Milliseconds.ToString()
        Dim strSeconds As String = intSeconds
        Dim strMinutes As String = intMinutes
        If intMinutes > 0 OrElse intHours > 0 Then
            While strSeconds.Length < 2
                strSeconds = "0" & strSeconds
            End While
        End If
        If intHours > 0 Then
            While strMinutes.Length < 2
                strMinutes = "0" & strMinutes
            End While
        End If
        While strMilliseconds.Length < 3
            strMilliseconds = "0" & strMilliseconds
        End While
        Dim strOutput = ""
        If intHours > 0 Then strOutput &= intHours.ToString & ":"
        If intMinutes > 0 Then
            strOutput &= strMinutes.ToString & ":"
        Else
            If intHours > 0 Then
                strOutput &= "00:"
            End If
        End If
        strOutput &= strSeconds
        If nudTimerDecimalPlaces.Value > 0 Then strOutput &= "." & strMilliseconds.ToString().Substring(0, nudTimerDecimalPlaces.Value)
        Return strOutput
    End Function

    Private Sub btnResetTimer_Click(sender As Object, e As EventArgs) Handles btnResetTimer.Click
        ResetTimer()
    End Sub

    Private Sub cmbTimerFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTimerFont.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbTimerFont.Text IsNot Nothing Then
            My.Settings.Font = cmbTimerFont.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub cmbTimerFontColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTimerFontColor.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbTimerFontColor.Text IsNot Nothing Then
            My.Settings.TextColor = cmbTimerFontColor.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbBackColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBackColor.SelectedIndexChanged
        If frmTracker IsNot Nothing Then
            frmTracker.BackColor = cmbBackColor.SelectedItem
            setFonts()
        End If
        If cmbBackColor.Text IsNot Nothing Then
            My.Settings.BackgroundColor = cmbBackColor.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub nudTimerFontSize_ValueChanged(sender As Object, e As EventArgs) Handles nudTimerFontSize.ValueChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If blnIsInitializing = False Then
            My.Settings.FontSize = nudTimerFontSize.Value
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnResetTracker_Click(sender As Object, e As EventArgs) Handles btnResetTracker.Click
        frmTracker.ResetTracker()
    End Sub

    Public Sub ResetTimer()
        timer.Enabled = False
        btnStartPauseTimer.Tag = False
        frmTracker.lblTimerOutput.Text = getTimespanString(TimeSpan.Zero)
        tsPausedTime = TimeSpan.Zero
        btnStartPauseTimer.Text = "Start Timer"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        If MessageBox.Show("This will reset timer, tracker, and stats.  Press Ok to accept.",
                                   "warning", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ResetTimer()
            frmTracker.ResetTracker()
            ResetStats()
        End If
    End Sub

    Private Sub btnSetTimerTime_Click(sender As Object, e As EventArgs) Handles btnSetTimerTime.Click
        tsPausedTime = New TimeSpan(0, nudTimerSetHours.Value, nudTimerSetMinutes.Value, nudTimerSetSeconds.Value, nudTimerSetMseconds.Value)
        frmTracker.lblTimerOutput.Text = getTimespanString(tsPausedTime)
    End Sub

    Private Sub btnSetTimeInputsFromTimer_Click(sender As Object, e As EventArgs) Handles btnSetTimeInputsFromTimer.Click
        SetTimeInputs(tsPausedTime)
    End Sub

    Public Sub SetTimeInputs(tsInput As TimeSpan)
        nudTimerSetHours.Value = tsInput.Hours + (tsInput.Days * 24)
        nudTimerSetMinutes.Value = tsInput.Minutes
        nudTimerSetSeconds.Value = tsInput.Seconds
        nudTimerSetMseconds.Value = tsInput.Milliseconds
    End Sub

    Private Sub Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.PausedTime = tsPausedTime

        My.Settings.Save()
    End Sub

    Private Sub btnSaveStats_Click(sender As Object, e As EventArgs) Handles btnSaveStats.Click
        EnterStats()
    End Sub

    Private Sub ResetStats()
        My.Settings.intPower = 0
        My.Settings.intAgility = 0
        My.Settings.intHP = 0
        My.Settings.intMP = 0
        My.Settings.intLastPower = 0
        My.Settings.intLastAgility = 0
        My.Settings.intLastHP = 0
        My.Settings.intLastMP = 0
        My.Settings.Save()
        UpdateStatsView(frmTracker)
        ClearStatInputs()
        btnSaveStats.Tag = False
        btnSaveStats.Text = "Save Starting Stats"
    End Sub

    Private Sub btnResetStats_Click(sender As Object, e As EventArgs) Handles btnResetStats.Click
        If MessageBox.Show("This will reset all stats.  Press Ok to accept.",
                   "warning", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ResetStats()
        End If
    End Sub



    Public Sub ClearStatInputs()
        nudPower.Value = 0
        nudAgility.Value = 0
        nudHP.Value = 0
        nudMP.Value = 0
        nudAgility.Select()
        nudPower.Select()
    End Sub
    Private Sub nudStat_Enter(sender As Object, e As EventArgs) Handles nudPower.Enter, nudAgility.Enter, nudHP.Enter, nudMP.Enter, nudPower.Click, nudAgility.Click, nudHP.Click, nudMP.Click
        sender.Select(0, sender.Text.Length)
    End Sub

    Private Sub btnOpenMapForm_Click(sender As Object, e As EventArgs) Handles btnOpenMapForm.Click
        Dim frmMaps As New FMaps
        frmMaps.Show()
    End Sub


    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles nudTimerDecimalPlaces.ValueChanged
        If blnIsInitializing = False Then

            My.Settings.intDecimalPlaces = nudTimerDecimalPlaces.Value
            My.Settings.Save()
            If btnStartPauseTimer.Tag = False Then
                frmTracker.lblTimerOutput.Text = getTimespanString(tsPausedTime)
            End If
        End If
    End Sub

    Public Sub setFonts()
        frmTracker.lblTimerOutput.Font = New Font(DirectCast(cmbTimerFont.SelectedItem, FontFamily), nudTimerFontSize.Value)
        frmTracker.lblHeader1Output.Font = New Font(DirectCast(cmbHeader1Font.SelectedItem, FontFamily), nudLine1FontSize.Value)
        frmTracker.lblHeader2Output.Font = New Font(DirectCast(cmbHeader2Font.SelectedItem, FontFamily), nudLine2FontSize.Value)
        frmTracker.lblTimerOutput.ForeColor = cmbTimerFontColor.SelectedItem
        frmTracker.lblHeader1Output.ForeColor = cmbHeader1Color.SelectedItem
        frmTracker.lblHeader2Output.ForeColor = cmbHeader2Color.SelectedItem
        Dim clrOtherLabels As Color = cmbOtherLabelColor.SelectedItem
        frmTracker.lblStrengthHeader.ForeColor = clrOtherLabels
        frmTracker.lblAgilityHeader.ForeColor = clrOtherLabels
        frmTracker.lblHPHeader.ForeColor = clrOtherLabels
        frmTracker.lblMPHeader.ForeColor = clrOtherLabels
        frmTracker.lblCurrentStats.ForeColor = clrOtherLabels
        frmTracker.lblLastLevel.ForeColor = clrOtherLabels
        frmTracker.lblDLHeader.ForeColor = clrOtherLabels
        frmTracker.chkAssumeFightersRing.ForeColor = clrOtherLabels
        frmTracker.chkAssumeErdricksSword.ForeColor = clrOtherLabels
        frmTracker.lblAverageAttacks.ForeColor = clrOtherLabels
        frmTracker.lblHealmoreHeader.ForeColor = clrOtherLabels
        frmTracker.lblDeathNecklaceHPHeader.ForeColor = clrOtherLabels
        frmTracker.lblArmKnightRunPercent.ForeColor = clrOtherLabels
        frmTracker.lblRedDragRunPercent.ForeColor = clrOtherLabels
        frmTracker.lblDL1RunPercent.ForeColor = clrOtherLabels
        frmTracker.lblDL2RunPercent.ForeColor = clrOtherLabels
        frmTracker.lblRunPercent.ForeColor = clrOtherLabels
        frmTracker.lblAttackPower.ForeColor = clrOtherLabels
        frmTracker.lblDefense.ForeColor = clrOtherLabels
        Dim OtherLabelFont As Font = New Font(DirectCast(cmbOtherLabelFont.SelectedItem, FontFamily), sngOtherTextSize)
        frmTracker.lblStrengthHeader.Font = OtherLabelFont
        frmTracker.lblAgilityHeader.Font = OtherLabelFont
        frmTracker.lblHPHeader.Font = OtherLabelFont
        frmTracker.lblMPHeader.Font = OtherLabelFont
        frmTracker.lblCurrentStats.Font = OtherLabelFont
        frmTracker.lblLastLevel.Font = OtherLabelFont
        frmTracker.lblDLHeader.Font = OtherLabelFont
        frmTracker.chkAssumeFightersRing.Font = OtherLabelFont
        frmTracker.chkAssumeErdricksSword.Font = OtherLabelFont
        frmTracker.lblAverageAttacks.Font = OtherLabelFont
        frmTracker.lblHealmoreHeader.Font = OtherLabelFont
        frmTracker.lblDeathNecklaceHPHeader.Font = OtherLabelFont
        frmTracker.lblArmKnightRunPercent.Font = OtherLabelFont
        frmTracker.lblRedDragRunPercent.Font = OtherLabelFont
        frmTracker.lblDL1RunPercent.Font = OtherLabelFont
        frmTracker.lblDL2RunPercent.Font = OtherLabelFont
        frmTracker.lblRunPercent.Font = OtherLabelFont
        frmTracker.lblAttackPower.Font = OtherLabelFont
        frmTracker.lblDefense.Font = OtherLabelFont
        'frmTracker.Label1.BackColor = ComboBox3.SelectedItem
        SetPanelHeights()
    End Sub

    Private Sub InitializeTrackerItems()
        frmTracker.pbArmor.Tag = GetArmor(GetIndexInList(GetArmor, My.Settings.objArmorTag))
        frmTracker.pbWeapons.Tag = GetWeapons(GetIndexInList(GetWeapons, My.Settings.objWeaponTag))
        frmTracker.pbShields.Tag = GetShields(GetIndexInList(GetShields, My.Settings.objShieldTag))
        frmTracker.pbScale.Tag = My.Settings.strScaleTag
        frmTracker.pbRing.Tag = My.Settings.strRingTag
        frmTracker.pbFlute.Tag = My.Settings.strFluteTag
        frmTracker.pbPrincess.Tag = My.Settings.strPrincessTag
        frmTracker.pbHarp.Tag = My.Settings.strHarpTag
        frmTracker.pbKeys.Tag = My.Settings.strKeyTag
        frmTracker.pbDrop.Tag = My.Settings.strDropTag
        frmTracker.pbDN.Tag = My.Settings.strDNTag
        frmTracker.pbStaff.Tag = My.Settings.strStaffTag
        frmTracker.pbStones.Tag = My.Settings.strStonesTag
        frmTracker.pbToken.Tag = My.Settings.strTokenTag
        frmTracker.SetTrackerImages()
    End Sub

    Private Sub txtHeader1String_TextChanged(sender As Object, e As EventArgs) Handles txtHeader1String.TextChanged
        If blnIsInitializing = False Then
            My.Settings.strHeaderLine1 = txtHeader1String.Text
            frmTracker.lblHeader1Output.Text = txtHeader1String.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtHeader2String_TextChanged(sender As Object, e As EventArgs) Handles txtHeader2String.TextChanged
        If blnIsInitializing = False Then
            My.Settings.strHeaderLine2 = txtHeader2String.Text
            frmTracker.lblHeader2Output.Text = txtHeader2String.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles nudLine1FontSize.ValueChanged
        If blnIsInitializing = False Then
            setFonts()
            My.Settings.intLine1FontSize = nudLine1FontSize.Value
            My.Settings.Save()
        End If
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles nudLine2FontSize.ValueChanged
        If blnIsInitializing = False Then
            setFonts()
            My.Settings.intLine2FontSize = nudLine2FontSize.Value
            My.Settings.Save()
        End If
    End Sub

    Public Sub SetPanelHeights()
        Dim intHeaderHeight As Integer = (sngOtherTextSize * 2) + 8
        Dim intNewHeight As Integer = frmTracker.Height - 40
        If frmTracker.pnlDLCalculations.Visible Then
            intNewHeight -= frmTracker.pnlDLCalculations.Height
        End If
        If frmTracker.pnlStatsOutput.Visible Then
            intNewHeight -= frmTracker.pnlStatsOutput.Height
        End If
        If frmTracker.pnlItemTracker.Visible Then
            intNewHeight -= frmTracker.pnlItemTracker.Height
        End If
        If frmTracker.pnlRunPercentage.Visible Then
            intNewHeight -= frmTracker.pnlRunPercentage.Height
        End If
        If frmTracker.lblTimerOutput.Visible Then
            intNewHeight -= frmTracker.lblTimerOutput.Height
        End If
        If intNewHeight > intHeaderHeight Then
            intHeaderHeight = intNewHeight
        End If
        frmTracker.pnlHeaderOutput.Height = intHeaderHeight
        frmTracker.lblHeader1Output.Height = Math.Ceiling(frmTracker.pnlHeaderOutput.Height / 2)
        frmTracker.lblHeader2Output.Height = Math.Floor(frmTracker.pnlHeaderOutput.Height / 2)
        If blnIsInitializing = False Then
            My.Settings.intDWRTrackerHeight = frmTracker.Height
            My.Settings.intDWRTrackerWidth = frmTracker.Width
            My.Settings.Save()
        End If
    End Sub

    Public Sub SetEnabled()
        If chkHeader1Enabled.Checked OrElse chkHeader2Enabled.Checked Then
            frmTracker.pnlHeaderOutput.Visible = True
        Else
            frmTracker.pnlHeaderOutput.Visible = False
        End If
        If chkHeader1Enabled.Checked Then
            frmTracker.lblHeader1Output.Visible = True
        Else
            frmTracker.lblHeader1Output.Visible = False
        End If
        If chkHeader2Enabled.Checked Then
            frmTracker.lblHeader2Output.Visible = True
        Else
            frmTracker.lblHeader2Output.Visible = False
        End If
        If chkEnableStats.Checked Then
            frmTracker.pnlStatsOutput.Visible = True
        Else
            frmTracker.pnlStatsOutput.Visible = False
        End If
        If chkEnableCalculation.Checked Then
            frmTracker.pnlDLCalculations.Visible = True
        Else
            frmTracker.pnlDLCalculations.Visible = False
        End If
        If chkTimerView.Checked Then
            frmTracker.lblTimerOutput.Visible = True
        Else
            frmTracker.lblTimerOutput.Visible = False
        End If
        If chkTrackerView.Checked Then
            frmTracker.pnlItemTracker.Visible = True
        Else
            frmTracker.pnlItemTracker.Visible = False
        End If
        If chkEnableRunPercent.Checked Then
            frmTracker.pnlRunPercentage.Visible = True
        Else
            frmTracker.pnlRunPercentage.Visible = False
        End If
        SetPanelHeights()
    End Sub

    Private Sub chkEnableStats_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableStats.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()

            My.Settings.blnStatsBlockEnabled = chkEnableStats.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEnableCalculation_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableCalculation.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()
            My.Settings.blnCalculationBlockEnabled = chkEnableCalculation.Checked
            My.Settings.Save()

        End If
    End Sub

    Private Sub chkHeader1Enabled_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeader1Enabled.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()
            My.Settings.blnEnableHeader1 = chkHeader1Enabled.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkHeader2Enabled_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeader2Enabled.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()
            My.Settings.blnEnableHeader2 = chkHeader2Enabled.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEnableRunPercent_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableRunPercent.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()
            My.Settings.blnEnableRunPercent = chkEnableRunPercent.Checked
            My.Settings.Save()
        End If
    End Sub


    Private Sub btnOpenBGImgSelector_Click(sender As Object, e As EventArgs) Handles btnOpenBGImgSelector.Click
        OpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
        OpenFileDialog1.CheckFileExists = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImageFileLocation.Text = OpenFileDialog1.FileName
            If SetBackgroundImage(OpenFileDialog1.FileName) = True Then
                My.Settings.strBackgroundImageLocation = OpenFileDialog1.FileName
                My.Settings.Save()
            End If
        End If

    End Sub

    Private Sub chkBackgroundImage_CheckedChanged(sender As Object, e As EventArgs) Handles chkBackgroundImage.CheckedChanged
        SetBackgroundImageEnabled()
    End Sub
    Public Sub SetBackgroundImageEnabled()
        If blnIsInitializing = False Then
            btnOpenBGImgSelector.Enabled = chkBackgroundImage.Checked
            txtImageFileLocation.Enabled = chkBackgroundImage.Checked
            My.Settings.blnUseBackgroundImage = chkBackgroundImage.Checked
            My.Settings.Save()
            If chkBackgroundImage.Checked = False Then
                frmTracker.BackgroundImage = Nothing
            ElseIf txtImageFileLocation.Text.Length > 0 AndAlso IO.File.Exists(txtImageFileLocation.Text) Then
                SetBackgroundImage(txtImageFileLocation.Text)
            End If
        End If
    End Sub
    Public Function SetBackgroundImage(strImageLocation As String) As Boolean
        Try
            frmTracker.BackgroundImage = Image.FromFile(strImageLocation, True)
        Catch ex As Exception
            MessageBox.Show("Error loading image.  Please try again.")
            txtImageFileLocation.Text = ""
            Return False
        End Try
        Return True
    End Function

    Private Sub nudPower_KeyDown(sender As Object, e As KeyEventArgs) Handles nudPower.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudAgility.Focus()

        End If
    End Sub

    Private Sub nudAgility_KeyDown(sender As Object, e As KeyEventArgs) Handles nudAgility.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudHP.Focus()

        End If
    End Sub

    Private Sub nudHP_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHP.KeyDown
        If e.KeyCode = Keys.Enter Then
            nudMP.Focus()

        End If
    End Sub

    Private Sub nudMP_KeyDown(sender As Object, e As KeyEventArgs) Handles nudMP.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterStats()
        End If
    End Sub

    Private Sub EnterStats()

        If btnSaveStats.Tag = False Then
            If nudPower.Value = 0 OrElse nudAgility.Value = 0 OrElse nudHP.Value = 0 OrElse nudMP.Value = 0 Then
                If MessageBox.Show("A stat input is 0.  Press Ok to accept.",
                                   "warning", MessageBoxButtons.OKCancel) <> DialogResult.OK Then
                    nudPower.Focus()
                    Exit Sub
                End If
            End If
            My.Settings.intPower = nudPower.Value
            My.Settings.intAgility = nudAgility.Value
            My.Settings.intHP = nudHP.Value
            My.Settings.intMP = nudMP.Value
            My.Settings.intLastPower = nudPower.Value
            My.Settings.intLastAgility = nudAgility.Value
            My.Settings.intLastHP = nudHP.Value
            My.Settings.intLastMP = nudMP.Value
            btnSaveStats.Tag = True
        Else
            My.Settings.intPower += nudPower.Value
            My.Settings.intAgility += nudAgility.Value
            My.Settings.intHP += nudHP.Value
            My.Settings.intMP += nudMP.Value
            My.Settings.intLastPower = nudPower.Value
            My.Settings.intLastAgility = nudAgility.Value
            My.Settings.intLastHP = nudHP.Value
            My.Settings.intLastMP = nudMP.Value

            btnSaveStats.Tag = True
        End If

        btnSaveStats.Text = "Save Level Stats"
        My.Settings.Save()
        UpdateStatsView(frmTracker)
        ClearStatInputs()
    End Sub

    Private Sub Start_PauseTimer()
        If btnStartPauseTimer.Tag = False Then
            timer.Enabled = True
            btnStartPauseTimer.Tag = True
            dtmStartTime = Now
            btnSetTimeInputsFromTimer.Enabled = False
            btnStartPauseTimer.Text = "Pause Timer"
        Else
            tsPausedTime = ((Now - dtmStartTime) + tsPausedTime)
            btnStartPauseTimer.Tag = False
            timer.Enabled = False
            btnSetTimeInputsFromTimer.Enabled = True
            frmTracker.lblTimerOutput.Text = getTimespanString(tsPausedTime)
            My.Settings.PausedTime = tsPausedTime

            My.Settings.Save()
            btnStartPauseTimer.Text = "Start Timer"

        End If
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 100)
        UnregisterHotKey(Me.Handle, 200)
    End Sub

    Private Sub chkTrackerView_CheckedChanged(sender As Object, e As EventArgs) Handles chkTrackerView.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()
            My.Settings.blnTrackerEnabled = chkTrackerView.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkTimerView_CheckedChanged(sender As Object, e As EventArgs) Handles chkTimerView.CheckedChanged
        If blnIsInitializing = False Then
            SetEnabled()
            My.Settings.blnTimerEnabled = chkTimerView.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbHeader1Font_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeader1Font.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbHeader1Font.Text IsNot Nothing Then
            My.Settings.strHeader1Font = cmbHeader1Font.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub cmbHeader1Color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeader1Color.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbHeader1Color.Text IsNot Nothing Then
            My.Settings.strHeader1Color = cmbHeader1Color.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub cmbHeader2Font_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeader2Font.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbHeader2Font.Text IsNot Nothing Then
            My.Settings.strHeader2Font = cmbHeader2Font.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub cmbHeader2Color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeader2Color.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbHeader2Color.Text IsNot Nothing Then
            My.Settings.strHeader2Color = cmbHeader2Color.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub cmbOtherLabelFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOtherLabelFont.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbHeader2Font.Text IsNot Nothing Then
            My.Settings.strOtherLabelFont = cmbOtherLabelFont.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub cmbOtherLabelColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOtherLabelColor.SelectedIndexChanged
        If frmTracker IsNot Nothing AndAlso frmTracker.lblTimerOutput IsNot Nothing Then
            setFonts()
        End If
        If cmbHeader2Color.Text IsNot Nothing Then
            My.Settings.strOtherLabelColor = cmbOtherLabelColor.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub btnSetHeader1MatchTimer_Click(sender As Object, e As EventArgs) Handles btnSetHeader1MatchTimer.Click
        cmbHeader1Font.Text = cmbTimerFont.Text
        cmbHeader1Color.Text = cmbTimerFontColor.Text
    End Sub

    Private Sub btnSetHeader2Match1_Click(sender As Object, e As EventArgs) Handles btnSetHeader2Match1.Click
        cmbHeader2Font.Text = cmbHeader1Font.Text
        cmbHeader2Color.Text = cmbHeader1Color.Text
    End Sub

    Private Sub btnMatchOtherLabelsToTimer_Click(sender As Object, e As EventArgs) Handles btnMatchOtherLabelsToTimer.Click
        cmbOtherLabelFont.Text = cmbTimerFont.Text
        cmbOtherLabelColor.Text = cmbTimerFontColor.Text
    End Sub

    Private Sub chkEnableFactoryReset_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableFactoryReset.CheckedChanged
        btnResetToFactory.Enabled = chkEnableFactoryReset.Checked
    End Sub

    Private Sub btnResetToFactory_Click(sender As Object, e As EventArgs) Handles btnResetToFactory.Click
        If MessageBox.Show("This will reset all settings back to factory defaults.  Press Ok to accept.",
                                   "warning", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ResetTimer()
            frmTracker.ResetTracker()
            ResetStats()
            My.Settings.Reset()
            My.Settings.Save()
            Dim intTrackerHeight As Integer = My.Settings.intDWRTrackerHeight
            Dim intTrackerWidth As Integer = My.Settings.intDWRTrackerWidth
            InitializeFonts()

            btnStartPauseTimer.Tag = False

            LoadSettingSaves()

            SetEnabled()
            SetPanelHeights()
            setFonts()
            UpdateStatsView(frmTracker)
            RegisterKeys()
            frmTracker.Height = intTrackerHeight
            frmTracker.Width = intTrackerWidth

        End If
    End Sub
End Class
