﻿Module MCalcs
    Public Property rng As New Random()
    Public Function GetRunPercentage(intHeroAgility As Integer, objEnemy As Enemy)
        Dim lintHeroValues As New List(Of Integer)
        Dim lintEnemyValues As New List(Of Integer)
        Dim intSuccessfulRunValues As Integer = 0
        Dim intAllPossibleOptions As Integer = 0
        For intPossibleValue As Integer = 0 To 255
            lintHeroValues.Add(intHeroAgility * intPossibleValue)
            lintEnemyValues.Add(Math.Floor(objEnemy.Agility * intPossibleValue * GetEnemyGroupRunFactor(objEnemy.RunGroup)))
        Next
        For Each intHeroValue As Integer In lintHeroValues
            For Each intEnemyValue As Integer In lintEnemyValues
                intAllPossibleOptions += 1
                If intHeroValue >= intEnemyValue Then
                    intSuccessfulRunValues += 1
                End If
            Next
        Next
        Return ((intSuccessfulRunValues / intAllPossibleOptions) * 100)
    End Function

    Public Function GetEnemyGroupRunFactor(intEnemyGroup As Integer) As Decimal
        Select Case intEnemyGroup
            Case 1
                Return 0.25
            Case 2
                Return 0.375
            Case 3
                Return 0.5
            Case 4
                Return 1
            Case Else
                Return -1
        End Select

    End Function

    Public Class Enemy
        Public ReadOnly Property Name As String
        Public ReadOnly Property RunGroup As Integer
        Public ReadOnly Property Agility As Integer

        Sub New(strName As String, intAgility As Integer, intRunGroup As Integer)
            Name = strName
            Agility = intAgility
            RunGroup = intRunGroup
        End Sub
    End Class
    Public Class EnemyStats
        Public Shared ReadOnly Property Enemies As List(Of Enemy)
        '    Get
        '        If Enemies Is Nothing Then

        '            Enemies = New List(Of Enemy)
        '            Enemies.Add(New Enemy("Armored Knight", 86, 4))
        '            Enemies.Add(New Enemy("Red Dragon", 90, 4))
        '            Enemies.Add(New Enemy("Dragon Lord 1", 75, 4))
        '            Enemies.Add(New Enemy("Dragon Lord 2", 200, 4))
        '        End If
        '        Return Enemies
        '    End Get
        'End Property
        Shared Sub New()

            Enemies = New List(Of Enemy)
            Enemies.Add(New Enemy("Armored Knight", 86, 4))
            Enemies.Add(New Enemy("Red Dragon", 90, 4))
            Enemies.Add(New Enemy("Dragon Lord 1", 75, 4))
            Enemies.Add(New Enemy("Dragon Lord 2", 200, 4))
        End Sub

    End Class
    Public Enum Enemies
        ArmoredKnight
        RedDragon
        DragonLord1
        DragonLord2
    End Enum

End Module
Public Module FightSimulator

    Public Function SimulateDLFights(intHeroAP As Integer,
                                    intHeroDef As Integer,
                                    intHeroAgil As Integer,
                                    intHeroHP As Integer,
                                    intHeroMP As Integer,
                                    intNumberOfHerbs As Integer,
                                    intNumberOfSimulations As Integer,
                                    intDL2HealmoreHealth As Integer,
                                     intEstimatedDifficulty As Integer) As Integer
        Dim intNumberSuccesses As Integer = 0
        For intIndex As Integer = 1 To intNumberOfSimulations
            Dim intCurrentHerbs As Integer = intNumberOfHerbs
            Dim intCurrentMP As Integer = intHeroMP
            EstimateDiveLosses(intEstimatedDifficulty, intCurrentHerbs, intCurrentMP)
            If SimulateDLFight(intHeroAP, intHeroDef, intHeroAgil, intHeroHP, intCurrentMP, intCurrentHerbs, intDL2HealmoreHealth) Then
                intNumberSuccesses += 1
            End If
        Next
        Return Math.Floor((intNumberSuccesses / intNumberOfSimulations) * 100)
    End Function
    Public Sub EstimateDiveLosses(intEstimatedDifficulty As Integer, ByRef intNumberOfHerbs As Integer, ByRef intCurrentMP As Integer)
        Select Case intEstimatedDifficulty
            Case 1
                Exit Sub
            Case 2
                intNumberOfHerbs = intNumberOfHerbs - Math.Floor(GetRandomDecimal(0, 2))
            Case 3
                intNumberOfHerbs = intNumberOfHerbs - Math.Floor(GetRandomDecimal(0, 3))
                intCurrentMP = intCurrentMP - (Math.Floor(GetRandomDecimal(0, 1)) * 8)
            Case 4
                intNumberOfHerbs = intNumberOfHerbs - Math.Floor(GetRandomDecimal(1, 3))
                intCurrentMP = intCurrentMP - (Math.Floor(GetRandomDecimal(0, 2)) * 8)
            Case 5
                intNumberOfHerbs = intNumberOfHerbs - Math.Floor(GetRandomDecimal(1, 3))
                intCurrentMP = intCurrentMP - (Math.Floor(GetRandomDecimal(0, 3)) * 8)
            Case 6
                intNumberOfHerbs = intNumberOfHerbs - Math.Floor(GetRandomDecimal(1, 5))
                intCurrentMP = intCurrentMP - (Math.Floor(GetRandomDecimal(1, 3)) * 8)
            Case 7
                intNumberOfHerbs = intNumberOfHerbs - Math.Floor(GetRandomDecimal(3, 5))
                intCurrentMP = intCurrentMP - (Math.Floor(GetRandomDecimal(1, 5)) * 8)
        End Select
    End Sub
    Public Function SimulateDLFight(intHeroAP As Integer,
                                    intHeroDef As Integer,
                                    intHeroAgil As Integer,
                                    intHeroHP As Integer,
                                    intHeroMP As Integer,
                                    intNumberOfHerbs As Integer,
                                    intDL2HealmoreHealth As Integer) As Boolean

        Dim intCurrentHP As Integer = intHeroHP
        intCurrentHP = SimulateDL1Fight(intHeroAP, intHeroDef, intHeroAgil, intHeroHP, intHeroMP, intNumberOfHerbs)
        If intCurrentHP <= 0 Then
            Return False
        Else
            Return SimulateDL2Fight(intHeroAP, intHeroDef, intHeroAgil, intHeroHP, intCurrentHP, intHeroMP, intNumberOfHerbs, intDL2HealmoreHealth)
        End If

    End Function



    Public Function SimulateDL1Fight(intHeroAP As Integer,
                                    intHeroDef As Integer,
                                    intHeroAgil As Integer,
                                    intHeroMaxHP As Integer,
                                    intHeroMP As Integer,
                                    intNumberOfHerbs As Integer) As Integer
        Dim DL1HP As Integer = GetRandomDecimal(75, 101)
        Dim DL1AP As Integer = 90
        Dim DL1Agil As Integer = 75
        Dim decBackAttackPercent As Decimal
        If Double.IsInfinity(17 / (2 * intHeroAgil)) Then
            decBackAttackPercent = 100
        Else
            decBackAttackPercent = 17 / (2 * intHeroAgil)
        End If

        Dim intCurrentHerbs As Integer = intNumberOfHerbs
        Dim intCurrentHP As Integer = intHeroMaxHP
        Dim intCurrentMP As Integer = intHeroMP

        'Back Attack?
        If GetRandomDecimal(1, 101) < decBackAttackPercent * 100 Then
            intCurrentHP -= DL1TurnDamage(intHeroDef, DL1AP)
            If IsDead(intCurrentHP) Then
                Return 0
            End If
        End If

        While IsDead(DL1HP) = False AndAlso IsDead(intCurrentHP) = False
            If (intHeroMaxHP - intCurrentHP) >= 15 AndAlso intNumberOfHerbs > 0 Then
                'Take Herb if lost 15 hp
                intCurrentHerbs -= 1
                intCurrentHP = TakeHerb(intCurrentHP)
                If intCurrentHP > intHeroMaxHP Then intCurrentHP = intHeroMaxHP
            Else
                'otherwise attack
                DL1HP -= GetAttackDamage(DL1Agil, intHeroAP)
            End If


            If IsDead(DL1HP) Then
                Return intCurrentHP
            End If

            'DL1 attacks
            intCurrentHP -= DL1TurnDamage(intHeroDef, DL1AP)

            If IsDead(intCurrentHP) Then
                Return 0
            End If

        End While
        Return intCurrentHP
    End Function

    Private Function IsDead(intHP As Integer) As Boolean
        If intHP <= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SimulateDL2Fight(intHeroAP As Integer,
                                    intHeroDef As Integer,
                                    intHeroAgil As Integer,
                                    intHeroMaxHP As Integer,
                                    intCurrentHP As Integer,
                                    intHeroMP As Integer,
                                    intNumberOfHerbs As Integer,
                                    intHealmoreHealth As Integer) As Boolean
        Dim DL2HP As Integer = GetRandomDecimal(150, 166)
        Dim DL2AP As Integer = 140
        Dim DL2Agil As Integer = 200
        Dim decBackAttackPercent As Decimal = 50 / (2 * intHeroAgil)
        Dim intCurrentHerbs As Integer = intNumberOfHerbs
        'Dim intCurrentHP As Integer = intHeroMaxHP
        Dim intCurrentMP As Integer = intHeroMP
        Dim strStats As String = "H_HP | H_MP | DL_HP | AP | Agi | MaxHP | MaxMP | hrbs" & vbNewLine
        strStats &= "Starting: " & vbTab & vbTab & intCurrentHP & " | " & intCurrentMP & " | " & DL2HP & " | " & intHeroAP & " | " & intHeroAgil & " | " & intHeroMaxHP & " | " & intHeroMP & " | " & intNumberOfHerbs & vbNewLine

        'Back Attack?
        If GetRandomDecimal(1, 101) < decBackAttackPercent * 100 Then
            intCurrentHP -= DL2TurnDamage(intHeroDef, DL2AP)
            strStats &= "BackAttack: " & vbTab & intCurrentHP & " | " & intCurrentMP & " | " & DL2HP & " | " & intHeroAP & " | " & intHeroAgil & " | " & intHeroMaxHP & " | " & intHeroMP & " | " & intNumberOfHerbs & vbNewLine
            If IsDead(intCurrentHP) Then
                strStats &= "206"
                'MessageBox.Show(strStats)
                Return False
            End If
        End If

        While IsDead(DL2HP) = False AndAlso IsDead(intCurrentHP) = False
            If intHealmoreHealth < 48 AndAlso
                (CalculateAveragedNumberOfAttacksLeft(intHeroAP, DL2Agil, DL2HP) - 2) > Math.Floor(intCurrentMP / 8) AndAlso
                intCurrentHP >= intHealmoreHealth AndAlso intCurrentHP < 48 Then
                'Do risky attack
                DL2HP -= GetAttackDamage(DL2Agil, intHeroAP)
                strStats &= "Risky Attack: " & vbTab & vbTab & intCurrentHP & " | " & intCurrentMP & " | " & DL2HP & " | " & intHeroAP & " | " & intHeroAgil & " | " & intHeroMaxHP & " | " & intHeroMP & " | " & intNumberOfHerbs & vbNewLine
            ElseIf intCurrentHP <= 48 AndAlso intCurrentMP >= 8 Then
                'Do Healmore
                intCurrentMP -= 8
                intCurrentHP += GetRandomDecimal(85, 101)
                If intCurrentHP > intHeroMaxHP Then intCurrentHP = intHeroMaxHP
                strStats &= "Heal: " & vbTab & vbTab & intCurrentHP & " | " & intCurrentMP & " | " & DL2HP & " | " & intHeroAP & " | " & intHeroAgil & " | " & intHeroMaxHP & " | " & intHeroMP & " | " & intNumberOfHerbs & vbNewLine

            Else
                'otherwise attack
                DL2HP -= GetAttackDamage(DL2Agil, intHeroAP)
                strStats &= "Attack: " & vbTab & vbTab & intCurrentHP & " | " & intCurrentMP & " | " & DL2HP & " | " & intHeroAP & " | " & intHeroAgil & " | " & intHeroMaxHP & " | " & intHeroMP & " | " & intNumberOfHerbs & vbNewLine
            End If


            If IsDead(DL2HP) Then
                Return True
            End If

            'DL1 attacks
            intCurrentHP -= DL2TurnDamage(intHeroDef, DL2AP)
            strStats &= "Round End: " & vbTab & intCurrentHP & " | " & intCurrentMP & " | " & DL2HP & " | " & intHeroAP & " | " & intHeroAgil & " | " & intHeroMaxHP & " | " & intHeroMP & " | " & intNumberOfHerbs & vbNewLine

            If IsDead(intCurrentHP) Then
                strStats &= "239"
                'MessageBox.Show(strStats)
                Return False
            End If

        End While

        Return True
    End Function
    Public Function CalculateAveragedNumberOfAttacksLeft(intAttackerAP As Integer, intDefenderDefense As Integer, intDefenderCurrentHP As Integer) As Integer
        Dim intMinAttack As Integer = Math.Floor((intAttackerAP / 4) - (intDefenderDefense / 8))
        Dim intMaxAttack As Integer = Math.Floor((intAttackerAP / 2) - (intDefenderDefense / 4))
        Return Math.Ceiling(intDefenderCurrentHP / ((intMinAttack + intMaxAttack) / 2))
    End Function


    Public Function TakeHerb(intCurrentHealth As Integer) As Integer
        Return intCurrentHealth + (GetRandomDecimal(23, 31))
    End Function

    Public Function DL1TurnDamage(intHeroDefense As Integer, intDLAttackPower As Integer) As Integer
        Dim intDamageDealt As Integer = 0
        If GetRandomDecimal(1, 5) = 1 Then
            Return 0

        End If

        If GetRandomDecimal(1, 5) < 4 Then
            intDamageDealt = GetRandomDecimal(20, 31)
        Else
            intDamageDealt = GetAttackDamage(intHeroDefense, intDLAttackPower)
        End If
        Return intDamageDealt
    End Function
    Public Function DL2TurnDamage(intHeroDefense As Integer, intDLAttackPower As Integer) As Integer
        Dim intDamageDealt As Integer = 0
        If GetRandomDecimal(1, 3) = 1 Then
            intDamageDealt = 40 + (2 * GetRandomDecimal(1, 5))

        Else
            intDamageDealt = GetAttackDamage(intHeroDefense, intDLAttackPower)
        End If
        Return intDamageDealt
    End Function

    Public Function GetAttackDamage(intDefenderDefense As Integer, intAttackerAttackPower As Integer) As Integer
        Dim intMinAttack As Integer = Math.Floor((intAttackerAttackPower / 4) - (intDefenderDefense / 8))
        Dim intMaxAttack As Integer = Math.Floor((intAttackerAttackPower / 2) - (intDefenderDefense / 4))
        If intMaxAttack < 0 Then intMinAttack = 0
        If intMaxAttack < 0 Then intMaxAttack = 0

        Dim intDamage As Integer = (GetRandomDecimal(intMinAttack, intMaxAttack + 1))
        If intDamage = 0 Then
            intDamage = GetRandomDecimal(0, 2)
        End If
        Return intDamage
    End Function

    Public Function GetRandomDecimal(decLowerBound As Decimal, decUpperBound As Decimal) As Decimal
        Dim intLargestDecimalCount As Integer = GetDecimalCount(decLowerBound)
        Dim intUpperBoundDecimalCount As Integer = GetDecimalCount(decUpperBound)
        Dim intRandomUpper As Integer = 0
        Dim intRandomLower As Integer = 0
        Dim intMultiplier As Integer = 0
        If intUpperBoundDecimalCount > intLargestDecimalCount Then
            intLargestDecimalCount = intUpperBoundDecimalCount
        End If
        intMultiplier = (Math.Pow(10, intLargestDecimalCount))
        intRandomUpper = decUpperBound * intMultiplier
        intRandomLower = decLowerBound * intMultiplier

        Return rng.Next(intRandomLower, intRandomUpper + 1) / intMultiplier

    End Function

    Public Function GetDecimalCount(decValue As Decimal) As Integer
        Dim strValue As String = decValue.ToString
        Dim intDecimalCount As Integer = 0
        If strValue.IndexOf(".") > -1 Then
            intDecimalCount = strValue.Length - strValue.IndexOf(".")
        End If
        Return intDecimalCount
    End Function
End Module
