Public Class DWRTackerWindow
    Dim strBaseUsePath As String = ""
    Dim strBaseWeaponsPath As String = ""
    Dim strBaseArmorPath As String = ""
    Dim strBaseShieldsPath As String = ""
    Dim strDarkIdentifier As String = "-grey.png"
    Private Sub DWRTackerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strBaseUsePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "img\used\")
        strBaseWeaponsPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "img\Weapons\")
        strBaseArmorPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "img\Armor\")
        strBaseShieldsPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "img\Shields\")
        'ResetTracker()
    End Sub

    Private Sub ItemTrackerNonRotation_Click(sender As Object, e As EventArgs) Handles pbScale.Click, pbRing.Click, pbFlute.Click, pbPrincess.Click, pbHarp.Click, pbKeys.Click, pbDrop.Click, pbDN.Click, pbStaff.Click, pbStones.Click, pbToken.Click
        Dim pbBuffer As PictureBox = DirectCast(sender, PictureBox)
        Dim strTag As String = DirectCast(pbBuffer.Tag, String)
        If strTag.Contains(strDarkIdentifier) Then
            pbBuffer.Tag = strTag.Replace(strDarkIdentifier, ".png")
        Else
            pbBuffer.Tag = strTag.Replace(".png", strDarkIdentifier)
        End If
        SaveTrackerItems()

        pbBuffer.Image = Image.FromFile(strBaseUsePath & pbBuffer.Tag, True)
        UpdateStatsView(Me)
    End Sub

    Public Sub SaveTrackerItems()
        My.Settings.strScaleTag = pbScale.Tag
        My.Settings.strRingTag = pbRing.Tag
        My.Settings.strFluteTag = pbFlute.Tag
        My.Settings.strPrincessTag = pbPrincess.Tag
        My.Settings.strHarpTag = pbHarp.Tag
        My.Settings.strKeyTag = pbKeys.Tag
        My.Settings.strDropTag = pbDrop.Tag
        My.Settings.strDNTag = pbDN.Tag
        My.Settings.strStaffTag = pbStaff.Tag
        My.Settings.strStonesTag = pbStones.Tag
        My.Settings.strTokenTag = pbToken.Tag
        My.Settings.objWeaponTag = pbWeapons.Tag.ToString
        My.Settings.objArmorTag = pbArmor.Tag.ToString
        My.Settings.objShieldTag = pbShields.Tag.ToString
        My.Settings.Save()
    End Sub

    Public Sub ResetTracker()
        pbScale.Tag = "dragon_scale-grey.png"
        pbRing.Tag = "fighters_ring-grey.png"
        pbFlute.Tag = "flute-grey.png"
        pbPrincess.Tag = "gwaelin-grey.png"
        pbHarp.Tag = "harp-grey.png"
        pbKeys.Tag = "key-grey.png"
        pbDrop.Tag = "rainbowdrop-grey.png"
        pbDN.Tag = "reckless_necklace_th-grey.png"
        pbStaff.Tag = "staff_of_rain-grey.png"
        pbStones.Tag = "stones_of_sunlight-grey.png"
        pbToken.Tag = "token-grey.png"
        pbWeapons.Tag = GetWeapons()(0)
        pbArmor.Tag = GetArmor()(0)
        pbShields.Tag = GetShields()(0)
        SaveTrackerItems()
        SetTrackerImages()
    End Sub

    Public Sub SetTrackerImages()
        pbScale.Image = Image.FromFile(strBaseUsePath & pbScale.Tag, True)
        pbRing.Image = Image.FromFile(strBaseUsePath & pbRing.Tag, True)
        pbFlute.Image = Image.FromFile(strBaseUsePath & pbFlute.Tag, True)
        pbPrincess.Image = Image.FromFile(strBaseUsePath & pbPrincess.Tag, True)
        pbHarp.Image = Image.FromFile(strBaseUsePath & pbHarp.Tag, True)
        pbKeys.Image = Image.FromFile(strBaseUsePath & pbKeys.Tag, True)
        pbDrop.Image = Image.FromFile(strBaseUsePath & pbDrop.Tag, True)
        pbDN.Image = Image.FromFile(strBaseUsePath & pbDN.Tag, True)
        pbStaff.Image = Image.FromFile(strBaseUsePath & pbStaff.Tag, True)
        pbStones.Image = Image.FromFile(strBaseUsePath & pbStones.Tag, True)
        pbToken.Image = Image.FromFile(strBaseUsePath & pbToken.Tag, True)
        pbWeapons.Image = Image.FromFile(strBaseWeaponsPath & pbWeapons.Tag.ToString(), True)
        pbArmor.Image = Image.FromFile(strBaseArmorPath & pbArmor.Tag.ToString(), True)
        pbShields.Image = Image.FromFile(strBaseShieldsPath & pbShields.Tag.ToString(), True)
        SetRotatingItemTooltip(pbWeapons)
        SetRotatingItemTooltip(pbArmor)
        SetRotatingItemTooltip(pbShields)
    End Sub
    Private Sub pbWeapons_Click(sender As Object, e As EventArgs) Handles pbWeapons.Click
        UpdateRotating(sender, strBaseWeaponsPath, GetWeapons())
        My.Settings.objWeaponTag = pbWeapons.Tag.ToString
        My.Settings.Save()
    End Sub

    Private Sub pbArmor_Click(sender As Object, e As EventArgs) Handles pbArmor.Click
        UpdateRotating(sender, strBaseArmorPath, GetArmor())
        My.Settings.objArmorTag = pbArmor.Tag.ToString
        My.Settings.Save()
    End Sub

    Private Sub pbShields_Click(sender As Object, e As EventArgs) Handles pbShields.Click
        UpdateRotating(sender, strBaseShieldsPath, GetShields())
        My.Settings.objShieldTag = pbShields.Tag.ToString
        My.Settings.Save()
    End Sub

    Private Sub UpdateRotating(sender As PictureBox, strBasePath As String, lstItems As List(Of StatItem))

        Dim intItemIndex As Integer = GetIndexInList(lstItems, sender.Tag)
        If intItemIndex = lstItems.Count - 1 Then
            sender.Tag = lstItems(0)
        Else
            sender.Tag = lstItems(intItemIndex + 1)
        End If
        SetRotatingItemTooltip(sender)

        sender.Image = Image.FromFile(strBasePath & sender.Tag.ToString(), True)
        UpdateStatsView(Me)
    End Sub



    Private Sub SetRotatingItemTooltip(control As PictureBox)
        ToolTip1.SetToolTip(control, control.Tag.strItemName & " " & control.Tag.intStatValue & " " & control.Tag.strStatType)
    End Sub

    Private Sub DWRTackerWindow_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Settings.SetPanelHeights()

    End Sub

    Private Sub chkAssumeErdricksSword_CheckedChanged(sender As Object, e As EventArgs) Handles chkAssumeErdricksSword.CheckedChanged
        UpdateStatsView(Me)

    End Sub

    Private Sub chkAssumeFightersRing_CheckedChanged(sender As Object, e As EventArgs) Handles chkAssumeFightersRing.CheckedChanged
        UpdateStatsView(Me)
    End Sub

    Private Sub pbWeapons_DoubleClick(sender As Object, e As EventArgs) Handles pbWeapons.DoubleClick
        pbWeapons_Click(sender, e)
    End Sub

    Private Sub pbArmor_DoubleClick(sender As Object, e As EventArgs) Handles pbArmor.DoubleClick
        pbArmor_Click(sender, e)
    End Sub

    Private Sub pbShields_DoubleClick(sender As Object, e As EventArgs) Handles pbShields.DoubleClick
        pbShields_Click(sender, e)
    End Sub
End Class