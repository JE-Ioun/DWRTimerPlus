Module RotatingItems
    Public Function GetWeapons() As List(Of StatItem)
        Dim lsWeapons As New List(Of StatItem)
        lsWeapons.Add(New StatItem("erdricks_sword-grey.png", 0))
        lsWeapons.Add(New StatItem("bamboo_pole.png", 2))
        lsWeapons.Add(New StatItem("club.png", 4))
        lsWeapons.Add(New StatItem("copper_sword.png", 10))
        lsWeapons.Add(New StatItem("hand_axe.png", 15))
        lsWeapons.Add(New StatItem("broadsword.png", 20))
        lsWeapons.Add(New StatItem("flame_sword.png", 28))
        lsWeapons.Add(New StatItem("erdricks_sword.png", 40))
        Return lsWeapons
    End Function
    Public Function GetShields() As List(Of StatItem)
        Dim lsShields As New List(Of StatItem)
        lsShields.Add(New StatItem("silver_shield-grey.png", 0))
        lsShields.Add(New StatItem("small_shield.png", 4))
        lsShields.Add(New StatItem("large_shield.png", 10))
        lsShields.Add(New StatItem("silver_shield.png", 20))
        Return lsShields
    End Function
    Public Function GetArmor() As List(Of StatItem)
        Dim lsArmors As New List(Of StatItem)
        lsArmors.Add(New StatItem("erdricks_armour-dark.png", 0))
        lsArmors.Add(New StatItem("plain_clothes.png", 2))
        lsArmors.Add(New StatItem("leather_armour.png", 4))
        lsArmors.Add(New StatItem("chain_mail.png", 10))
        lsArmors.Add(New StatItem("half_plate.png", 16))
        lsArmors.Add(New StatItem("full_plate_armour.png", 24))
        lsArmors.Add(New StatItem("magic_armour.png", 24))
        lsArmors.Add(New StatItem("erdricks_armour.png", 28))
        Return lsArmors
    End Function

    Public Class StatItem
        Public ReadOnly Property strFileName As String
        Public ReadOnly Property intStatValue As Integer

        Sub New(FileName As String, StatValue As Integer)
            strFileName = FileName
            intStatValue = StatValue
        End Sub
        Public Overrides Function ToString() As String
            Return strFileName
        End Function
    End Class

    Public Sub UpdateStatsView(frmTracker As DWRTackerWindow)
        frmTracker.txtLastPower.Text = My.Settings.intLastPower
        frmTracker.txtLastAgility.Text = My.Settings.intLastAgility
        frmTracker.txtLastHP.Text = My.Settings.intLastHP
        frmTracker.txtLastMP.Text = My.Settings.intLastMP
        Dim intDisplayPower As Integer = My.Settings.intPower
        If frmTracker.chkAssumeErdricksSword.Checked Then
            intDisplayPower += 40
        Else
            intDisplayPower += DirectCast(frmTracker.pbWeapons.Tag, StatItem).intStatValue
        End If
        If frmTracker.chkAssumeFightersRing.Checked OrElse frmTracker.pbRing.Tag = "fighters_ring.png" Then
            intDisplayPower += 2
        End If
        frmTracker.txtPower.Text = intDisplayPower
        frmTracker.txtAgility.Text = My.Settings.intAgility
        frmTracker.txtHP.Text = My.Settings.intHP
        frmTracker.txtMP.Text = My.Settings.intMP
        Dim intAverageAttacks As Integer = CalculateAverageHits(intDisplayPower)
        Dim intAverageDNAttacks As Integer = CalculateAverageHits(intDisplayPower + 10)
        If intAverageAttacks > 0 Then
            frmTracker.txtAverageAttacks.Text = intAverageAttacks
        Else
            frmTracker.txtAverageAttacks.Text = "N/A"
        End If
        If intAverageDNAttacks > 0 Then
            frmTracker.txtDNAttacks.Text = intAverageDNAttacks
        Else
            frmTracker.txtDNAttacks.Text = "N/A"
        End If
        frmTracker.txtDeathNecklaceHP.Text = Math.Floor(My.Settings.intHP * 0.75)
        frmTracker.txtHealmores.Text = Math.Floor(My.Settings.intMP / 8)
        My.Settings.Save()
    End Sub

    Private Function CalculateAverageHits(intAttackPower As Integer) As Integer
        Dim intMaxDamage As Integer = Math.Floor((intAttackPower - 100) / 2)
        Dim intMinDamage As Integer = Math.Floor((intAttackPower - 100) / 4)
        Dim decAverageDamage As Decimal = (intMaxDamage + intMinDamage) / 2
        If decAverageDamage > 0 Then
            Dim decAverageDLHP As Decimal = (150 + 165) / 2
            Return Math.Ceiling(decAverageDLHP / decAverageDamage)
        Else
            Return -1
        End If
    End Function
End Module
