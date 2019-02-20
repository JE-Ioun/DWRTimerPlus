Public Class FMaps
    Dim strBaseMapsPath As String = ""
    Dim blnInitializing As Boolean = True
    Private Sub FMaps_Load(sender As Object, e As EventArgs) Handles Me.Load
        strBaseMapsPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "img\Maps\")
        SetAllMapTags()
        SetAllMapImages()
        CheckBox1.Checked = My.Settings.blnMapRoute
        CheckBox2.Checked = My.Settings.blnMapZoom
        blnInitializing = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        SetAllMapImages()
    End Sub

    Private Sub SetAllMapTags()
        tpCharlock.Tag = "charlock_full_base.png"
        tpGrave.Tag = "grave_full_base.png"
        tpMountain.Tag = "mountain_full_base.png"
        tpSwamp.Tag = "swamp_full_base.png"
        tpTablet.Tag = "tablet_full_base.png"
        tpVanillaWorld1.Tag = "alefgard.png"
        tpVanillaMap2.Tag = "DWR_Map.png"




    End Sub

    Private Sub SetAllMapImages()
        For Each tpBuffer As TabPage In tcMaps.TabPages
            If tpBuffer.Tag IsNot Nothing AndAlso tpBuffer.Tag.Length > 0 Then

                Dim strOldTag As String = DirectCast(tpBuffer.Tag, String)
                If CheckBox1.Checked Then
                    If strOldTag.Contains("-routed") = False Then
                        tpBuffer.Tag = strOldTag.Replace(".png", "-routed.png")
                    End If
                Else
                    If strOldTag.Contains("-routed") Then
                        tpBuffer.Tag = strOldTag.Replace("-routed.png", ".png")
                    End If
                End If
                tpBuffer.BackgroundImage = Image.FromFile(strBaseMapsPath & tpBuffer.Tag, True)

            End If
            If CheckBox2.Checked Then
                tpBuffer.BackgroundImageLayout = ImageLayout.Zoom
                tpBuffer.AutoScrollMinSize = tpBuffer.Size
            Else
                tpBuffer.BackgroundImageLayout = ImageLayout.None
                tpBuffer.AutoScrollMinSize = tpBuffer.BackgroundImage.Size
            End If
        Next
        If blnInitializing = False Then
            My.Settings.blnMapRoute = CheckBox1.Checked
            My.Settings.blnMapZoom = CheckBox2.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged


        SetAllMapImages()
    End Sub
End Class