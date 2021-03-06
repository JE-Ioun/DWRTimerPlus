﻿Public Class DWRTackerWindow
    Dim strBaseUsePath As String = ""
    Dim strBaseWeaponsPath As String = ""
    Dim strBaseArmorPath As String = ""
    Dim strBaseShieldsPath As String = ""
    Dim strDarkIdentifier As String = "-grey"
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
            pbBuffer.Tag = strTag.Replace(strDarkIdentifier, "")
        Else
            If pbBuffer.Tag.Contains("_h") Then
                pbBuffer.Tag = strTag.Replace("_h.png", strDarkIdentifier & "_h.png")
            Else
                pbBuffer.Tag = strTag.Replace(".png", strDarkIdentifier & ".png")

            End If
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
        If My.Settings.blnMisterHomesImages = True Then
            If pbStaff.Tag.Contains("_h") = False Then
                pbStaff.Tag = pbStaff.Tag.Replace(".png", "_h.png")
            End If

            If pbStones.Tag.Contains("_h") = False Then
                pbStones.Tag = pbStones.Tag.Replace(".png", "_h.png")
            End If

            If pbHarp.Tag.Contains("_h") = False Then
                pbHarp.Tag = pbHarp.Tag.Replace(".png", "_h.png")
            End If

            If pbToken.Tag.Contains("_h") = False Then
                pbToken.Tag = pbToken.Tag.Replace(".png", "_h.png")
            End If

            If pbDrop.Tag.Contains("_h") = False Then
                pbDrop.Tag = pbDrop.Tag.Replace(".png", "_h.png")
            End If

        End If

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
        If DirectCast(e, MouseEventArgs).Button = MouseButtons.Right Then
            UpdateRotating(sender, strBaseWeaponsPath, GetWeapons(), True)
        Else
            UpdateRotating(sender, strBaseWeaponsPath, GetWeapons(), False)
        End If
        My.Settings.objWeaponTag = pbWeapons.Tag.ToString
        My.Settings.Save()
    End Sub

    Private Sub pbArmor_Click(sender As Object, e As EventArgs) Handles pbArmor.Click
        If DirectCast(e, MouseEventArgs).Button = MouseButtons.Right Then
            UpdateRotating(sender, strBaseArmorPath, GetArmor(), True)
        Else
            UpdateRotating(sender, strBaseArmorPath, GetArmor(), False)
        End If
        My.Settings.objArmorTag = pbArmor.Tag.ToString
        My.Settings.Save()
    End Sub

    Private Sub pbShields_Click(sender As Object, e As EventArgs) Handles pbShields.Click
        If DirectCast(e, MouseEventArgs).Button = MouseButtons.Right Then
            UpdateRotating(sender, strBaseShieldsPath, GetShields(), True)
        Else
            UpdateRotating(sender, strBaseShieldsPath, GetShields(), False)
        End If
        My.Settings.objShieldTag = pbShields.Tag.ToString
        My.Settings.Save()
    End Sub

    Private Sub UpdateRotating(sender As PictureBox, strBasePath As String, lstItems As List(Of StatItem), Optional blnReverse As Boolean = False)

        Dim intItemIndex As Integer = GetIndexInList(lstItems, sender.Tag)
        Select Case blnReverse
            Case True
                If intItemIndex = 0 Then
                    sender.Tag = lstItems(lstItems.Count - 1)
                Else
                    sender.Tag = lstItems(intItemIndex - 1)
                End If
            Case False
                If intItemIndex = lstItems.Count - 1 Then
                    sender.Tag = lstItems(0)
                Else
                    sender.Tag = lstItems(intItemIndex + 1)
                End If
        End Select

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