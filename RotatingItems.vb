Module RotatingItems
    Public Function GetWeapons() As List(Of StatItem)
        Dim lsWeapons As New List(Of StatItem)
        lsWeapons.Add(New StatItem("erdricks_sword-grey.png", 0, "None"))
        lsWeapons.Add(New StatItem("bamboo_pole.png", 2, "Bamboo Pole"))
        lsWeapons.Add(New StatItem("club.png", 4, "Club"))
        lsWeapons.Add(New StatItem("copper_sword.png", 10, "Copper Sword"))
        lsWeapons.Add(New StatItem("hand_axe.png", 15, "Hand Axe"))
        lsWeapons.Add(New StatItem("broadsword.png", 20, "Broadsword"))
        lsWeapons.Add(New StatItem("flame_sword.png", 28, "Flame Sword"))
        lsWeapons.Add(New StatItem("erdricks_sword.png", 40, "Erdrick's Sword"))
        For Each objWeapon In lsWeapons
            objWeapon.strStatType = "Attack Power"
        Next
        Return lsWeapons
    End Function
    Public Function GetShields() As List(Of StatItem)
        Dim lsShields As New List(Of StatItem)
        lsShields.Add(New StatItem("silver_shield-grey.png", 0, "None"))
        lsShields.Add(New StatItem("small_shield.png", 4, "None"))
        lsShields.Add(New StatItem("large_shield.png", 10, "None"))
        lsShields.Add(New StatItem("silver_shield.png", 20, "None"))
        For Each objShield In lsShields
            objShield.strStatType = "Defense"
        Next
        Return lsShields
    End Function
    Public Function GetArmor() As List(Of StatItem)
        Dim lsArmors As New List(Of StatItem)
        lsArmors.Add(New StatItem("erdricks_armour-dark.png", 0, "None"))
        lsArmors.Add(New StatItem("plain_clothes.png", 2, "Clothes"))
        lsArmors.Add(New StatItem("leather_armour.png", 4, "Leather Armor"))
        lsArmors.Add(New StatItem("chain_mail.png", 10, "Chain Mail"))
        lsArmors.Add(New StatItem("half_plate.png", 16, "Half Plate"))
        lsArmors.Add(New StatItem("full_plate_armour.png", 24, "Full Plate"))
        lsArmors.Add(New StatItem("magic_armour.png", 24, "Magic Armor"))
        lsArmors.Add(New StatItem("erdricks_armour.png", 28, "Erdrick's Armor"))
        For Each objArmor In lsArmors
            objArmor.strStatType = "Defense"
        Next
        Return lsArmors
    End Function

    Public Class StatItem
        Public ReadOnly Property strFileName As String
        Public ReadOnly Property intStatValue As Integer
        Public ReadOnly Property strItemName As String
        Public Property strStatType As String

        Sub New(FileName As String, StatValue As Integer, ItemName As String)
            strFileName = FileName
            intStatValue = StatValue
            strItemName = ItemName
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
        UpdateRunPercentages(frmTracker)
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

    Private Sub UpdateRunPercentages(frmTracker As DWRTackerWindow)
        Dim intHeroAgility As Integer = My.Settings.intAgility
        Dim intArmoredKnightPercentage As Integer = Math.Floor(GetRunPercentage(intHeroAgility, EnemyStats.Enemies(Enemies.ArmoredKnight)))
        Dim intRedDragonPercentage As Integer = Math.Floor(GetRunPercentage(intHeroAgility, EnemyStats.Enemies(Enemies.RedDragon)))
        Dim intDL1Percentage As Integer = Math.Floor(GetRunPercentage(intHeroAgility, EnemyStats.Enemies(Enemies.DragonLord1)))
        Dim intDL2Percentage As Integer = Math.Floor(GetRunPercentage(intHeroAgility, EnemyStats.Enemies(Enemies.DragonLord2)))
        If intArmoredKnightPercentage > 100 Then intArmoredKnightPercentage = 100
        If intRedDragonPercentage > 100 Then intRedDragonPercentage = 100
        If intDL1Percentage > 100 Then intDL1Percentage = 100
        If intDL2Percentage > 100 Then intDL2Percentage = 100

        frmTracker.lblArmKnightRunPercentOut.Text = intArmoredKnightPercentage & "/" & 100 - intArmoredKnightPercentage & "%"
        frmTracker.lblRedDragRunPercentOut.Text = intRedDragonPercentage & "/" & 100 - intRedDragonPercentage & "%"
        frmTracker.lblDL1RunPercentOut.Text = intDL1Percentage & "/" & 100 - intDL1Percentage & "%"
        frmTracker.lblDL2RunPercentOut.Text = intDL2Percentage & "/" & 100 - intDL2Percentage & "%"

    End Sub
End Module
