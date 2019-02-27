Module MCalcs
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
