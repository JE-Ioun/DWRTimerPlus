<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DWRTackerWindow
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
        Me.components = New System.ComponentModel.Container()
        Me.pbToken = New System.Windows.Forms.PictureBox()
        Me.pbStones = New System.Windows.Forms.PictureBox()
        Me.pbStaff = New System.Windows.Forms.PictureBox()
        Me.pbDN = New System.Windows.Forms.PictureBox()
        Me.pbDrop = New System.Windows.Forms.PictureBox()
        Me.pbKeys = New System.Windows.Forms.PictureBox()
        Me.pbHarp = New System.Windows.Forms.PictureBox()
        Me.pbPrincess = New System.Windows.Forms.PictureBox()
        Me.pbFlute = New System.Windows.Forms.PictureBox()
        Me.pbRing = New System.Windows.Forms.PictureBox()
        Me.pbScale = New System.Windows.Forms.PictureBox()
        Me.pbWeapons = New System.Windows.Forms.PictureBox()
        Me.pbArmor = New System.Windows.Forms.PictureBox()
        Me.pbShields = New System.Windows.Forms.PictureBox()
        Me.lblCurrentStats = New System.Windows.Forms.Label()
        Me.lblLastLevel = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.txtMP = New System.Windows.Forms.TextBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtAgility = New System.Windows.Forms.TextBox()
        Me.txtLastAgility = New System.Windows.Forms.TextBox()
        Me.txtLastHP = New System.Windows.Forms.TextBox()
        Me.txtLastMP = New System.Windows.Forms.TextBox()
        Me.txtLastPower = New System.Windows.Forms.TextBox()
        Me.txtHealmores = New System.Windows.Forms.TextBox()
        Me.txtAverageAttacks = New System.Windows.Forms.TextBox()
        Me.lblDLHeader = New System.Windows.Forms.Label()
        Me.lblAverageAttacks = New System.Windows.Forms.Label()
        Me.lblHealmoreHeader = New System.Windows.Forms.Label()
        Me.lblStrengthHeader = New System.Windows.Forms.Label()
        Me.lblAgilityHeader = New System.Windows.Forms.Label()
        Me.lblHPHeader = New System.Windows.Forms.Label()
        Me.lblMPHeader = New System.Windows.Forms.Label()
        Me.txtDNAttacks = New System.Windows.Forms.TextBox()
        Me.lblDeathNecklaceHPHeader = New System.Windows.Forms.Label()
        Me.txtDeathNecklaceHP = New System.Windows.Forms.TextBox()
        Me.pnlDLCalculations = New System.Windows.Forms.Panel()
        Me.chkAssumeFightersRing = New System.Windows.Forms.CheckBox()
        Me.chkAssumeErdricksSword = New System.Windows.Forms.CheckBox()
        Me.pnlStatsOutput = New System.Windows.Forms.Panel()
        Me.pnlItemTracker = New System.Windows.Forms.Panel()
        Me.pnlHeaderOutput = New System.Windows.Forms.Panel()
        Me.lblHeader2Output = New System.Windows.Forms.Label()
        Me.lblHeader1Output = New System.Windows.Forms.Label()
        Me.lblTimerOutput = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlRunPercentage = New System.Windows.Forms.Panel()
        Me.lblRedDragRunPercent = New System.Windows.Forms.Label()
        Me.lblRunPercent = New System.Windows.Forms.Label()
        Me.lblRedDragRunPercentOut = New System.Windows.Forms.Label()
        Me.lblArmKnightRunPercentOut = New System.Windows.Forms.Label()
        Me.lblArmKnightRunPercent = New System.Windows.Forms.Label()
        Me.lblDL1RunPercentOut = New System.Windows.Forms.Label()
        Me.lblDL1RunPercent = New System.Windows.Forms.Label()
        Me.lblDL2RunPercentOut = New System.Windows.Forms.Label()
        Me.lblDL2RunPercent = New System.Windows.Forms.Label()
        Me.lblAttackPower = New System.Windows.Forms.Label()
        Me.txtAP = New System.Windows.Forms.TextBox()
        Me.lblDefense = New System.Windows.Forms.Label()
        Me.txtDefense = New System.Windows.Forms.TextBox()
        CType(Me.pbToken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHarp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrincess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWeapons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArmor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDLCalculations.SuspendLayout()
        Me.pnlStatsOutput.SuspendLayout()
        Me.pnlItemTracker.SuspendLayout()
        Me.pnlHeaderOutput.SuspendLayout()
        Me.pnlRunPercentage.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbToken
        '
        Me.pbToken.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbToken.Location = New System.Drawing.Point(53, 55)
        Me.pbToken.Name = "pbToken"
        Me.pbToken.Size = New System.Drawing.Size(51, 46)
        Me.pbToken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbToken.TabIndex = 11
        Me.pbToken.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbToken, "Erdrick's Token")
        '
        'pbStones
        '
        Me.pbStones.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbStones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbStones.Location = New System.Drawing.Point(53, 7)
        Me.pbStones.Name = "pbStones"
        Me.pbStones.Size = New System.Drawing.Size(51, 46)
        Me.pbStones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbStones.TabIndex = 10
        Me.pbStones.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbStones, "Stones of Sunlight")
        '
        'pbStaff
        '
        Me.pbStaff.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbStaff.Location = New System.Drawing.Point(106, 7)
        Me.pbStaff.Name = "pbStaff"
        Me.pbStaff.Size = New System.Drawing.Size(51, 46)
        Me.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbStaff.TabIndex = 9
        Me.pbStaff.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbStaff, "Staff of Rain")
        '
        'pbDN
        '
        Me.pbDN.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDN.Location = New System.Drawing.Point(53, 103)
        Me.pbDN.Name = "pbDN"
        Me.pbDN.Size = New System.Drawing.Size(51, 46)
        Me.pbDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDN.TabIndex = 8
        Me.pbDN.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbDN, "Death Necklace")
        '
        'pbDrop
        '
        Me.pbDrop.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDrop.Location = New System.Drawing.Point(106, 55)
        Me.pbDrop.Name = "pbDrop"
        Me.pbDrop.Size = New System.Drawing.Size(51, 46)
        Me.pbDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDrop.TabIndex = 7
        Me.pbDrop.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbDrop, "Rainbow Drop")
        '
        'pbKeys
        '
        Me.pbKeys.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbKeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbKeys.Location = New System.Drawing.Point(159, 55)
        Me.pbKeys.Name = "pbKeys"
        Me.pbKeys.Size = New System.Drawing.Size(51, 46)
        Me.pbKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbKeys.TabIndex = 6
        Me.pbKeys.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbKeys, "Magic Keys")
        '
        'pbHarp
        '
        Me.pbHarp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbHarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbHarp.Location = New System.Drawing.Point(159, 7)
        Me.pbHarp.Name = "pbHarp"
        Me.pbHarp.Size = New System.Drawing.Size(51, 46)
        Me.pbHarp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHarp.TabIndex = 5
        Me.pbHarp.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbHarp, "Silver Harp")
        '
        'pbPrincess
        '
        Me.pbPrincess.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbPrincess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPrincess.Location = New System.Drawing.Point(159, 103)
        Me.pbPrincess.Name = "pbPrincess"
        Me.pbPrincess.Size = New System.Drawing.Size(51, 46)
        Me.pbPrincess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPrincess.TabIndex = 4
        Me.pbPrincess.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbPrincess, "Princess Gwaelin")
        '
        'pbFlute
        '
        Me.pbFlute.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbFlute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbFlute.Location = New System.Drawing.Point(106, 103)
        Me.pbFlute.Name = "pbFlute"
        Me.pbFlute.Size = New System.Drawing.Size(51, 46)
        Me.pbFlute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFlute.TabIndex = 3
        Me.pbFlute.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbFlute, "Fairy Flute")
        '
        'pbRing
        '
        Me.pbRing.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbRing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRing.Location = New System.Drawing.Point(212, 82)
        Me.pbRing.Name = "pbRing"
        Me.pbRing.Size = New System.Drawing.Size(51, 46)
        Me.pbRing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRing.TabIndex = 2
        Me.pbRing.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbRing, "Fighter's Ring +2 Attack Power")
        '
        'pbScale
        '
        Me.pbScale.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbScale.Location = New System.Drawing.Point(212, 34)
        Me.pbScale.Name = "pbScale"
        Me.pbScale.Size = New System.Drawing.Size(51, 46)
        Me.pbScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbScale.TabIndex = 1
        Me.pbScale.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbScale, "Dragon's Scale +2 Defense")
        '
        'pbWeapons
        '
        Me.pbWeapons.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbWeapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbWeapons.Location = New System.Drawing.Point(265, 7)
        Me.pbWeapons.Name = "pbWeapons"
        Me.pbWeapons.Size = New System.Drawing.Size(51, 46)
        Me.pbWeapons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWeapons.TabIndex = 12
        Me.pbWeapons.TabStop = False
        '
        'pbArmor
        '
        Me.pbArmor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbArmor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbArmor.Location = New System.Drawing.Point(265, 55)
        Me.pbArmor.Name = "pbArmor"
        Me.pbArmor.Size = New System.Drawing.Size(51, 46)
        Me.pbArmor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbArmor.TabIndex = 13
        Me.pbArmor.TabStop = False
        '
        'pbShields
        '
        Me.pbShields.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbShields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbShields.Location = New System.Drawing.Point(265, 103)
        Me.pbShields.Name = "pbShields"
        Me.pbShields.Size = New System.Drawing.Size(51, 46)
        Me.pbShields.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbShields.TabIndex = 14
        Me.pbShields.TabStop = False
        '
        'lblCurrentStats
        '
        Me.lblCurrentStats.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCurrentStats.AutoSize = True
        Me.lblCurrentStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStats.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrentStats.Location = New System.Drawing.Point(62, 23)
        Me.lblCurrentStats.Name = "lblCurrentStats"
        Me.lblCurrentStats.Size = New System.Drawing.Size(66, 20)
        Me.lblCurrentStats.TabIndex = 15
        Me.lblCurrentStats.Text = "Current:"
        '
        'lblLastLevel
        '
        Me.lblLastLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblLastLevel.AutoSize = True
        Me.lblLastLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLastLevel.Location = New System.Drawing.Point(43, 45)
        Me.lblLastLevel.Name = "lblLastLevel"
        Me.lblLastLevel.Size = New System.Drawing.Size(85, 20)
        Me.lblLastLevel.TabIndex = 16
        Me.lblLastLevel.Text = "Last Level:"
        '
        'txtPower
        '
        Me.txtPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtPower.Enabled = False
        Me.txtPower.Location = New System.Drawing.Point(129, 23)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(33, 20)
        Me.txtPower.TabIndex = 17
        Me.txtPower.Text = "000"
        Me.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMP
        '
        Me.txtMP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtMP.Enabled = False
        Me.txtMP.Location = New System.Drawing.Point(234, 23)
        Me.txtMP.Name = "txtMP"
        Me.txtMP.Size = New System.Drawing.Size(33, 20)
        Me.txtMP.TabIndex = 18
        Me.txtMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHP
        '
        Me.txtHP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtHP.Enabled = False
        Me.txtHP.Location = New System.Drawing.Point(199, 23)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(33, 20)
        Me.txtHP.TabIndex = 19
        Me.txtHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAgility
        '
        Me.txtAgility.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtAgility.Enabled = False
        Me.txtAgility.Location = New System.Drawing.Point(164, 23)
        Me.txtAgility.Name = "txtAgility"
        Me.txtAgility.Size = New System.Drawing.Size(33, 20)
        Me.txtAgility.TabIndex = 20
        Me.txtAgility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLastAgility
        '
        Me.txtLastAgility.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtLastAgility.Enabled = False
        Me.txtLastAgility.Location = New System.Drawing.Point(164, 45)
        Me.txtLastAgility.Name = "txtLastAgility"
        Me.txtLastAgility.Size = New System.Drawing.Size(33, 20)
        Me.txtLastAgility.TabIndex = 24
        Me.txtLastAgility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLastHP
        '
        Me.txtLastHP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtLastHP.Enabled = False
        Me.txtLastHP.Location = New System.Drawing.Point(199, 45)
        Me.txtLastHP.Name = "txtLastHP"
        Me.txtLastHP.Size = New System.Drawing.Size(33, 20)
        Me.txtLastHP.TabIndex = 23
        Me.txtLastHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLastMP
        '
        Me.txtLastMP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtLastMP.Enabled = False
        Me.txtLastMP.Location = New System.Drawing.Point(234, 45)
        Me.txtLastMP.Name = "txtLastMP"
        Me.txtLastMP.Size = New System.Drawing.Size(33, 20)
        Me.txtLastMP.TabIndex = 22
        Me.txtLastMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLastPower
        '
        Me.txtLastPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtLastPower.Enabled = False
        Me.txtLastPower.Location = New System.Drawing.Point(129, 45)
        Me.txtLastPower.Name = "txtLastPower"
        Me.txtLastPower.Size = New System.Drawing.Size(33, 20)
        Me.txtLastPower.TabIndex = 21
        Me.txtLastPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHealmores
        '
        Me.txtHealmores.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtHealmores.Enabled = False
        Me.txtHealmores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHealmores.Location = New System.Drawing.Point(332, 27)
        Me.txtHealmores.Name = "txtHealmores"
        Me.txtHealmores.Size = New System.Drawing.Size(30, 22)
        Me.txtHealmores.TabIndex = 28
        Me.txtHealmores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAverageAttacks
        '
        Me.txtAverageAttacks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtAverageAttacks.Enabled = False
        Me.txtAverageAttacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAverageAttacks.Location = New System.Drawing.Point(150, 27)
        Me.txtAverageAttacks.Name = "txtAverageAttacks"
        Me.txtAverageAttacks.Size = New System.Drawing.Size(30, 22)
        Me.txtAverageAttacks.TabIndex = 26
        Me.txtAverageAttacks.Text = "000"
        Me.txtAverageAttacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDLHeader
        '
        Me.lblDLHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDLHeader.AutoSize = True
        Me.lblDLHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDLHeader.Location = New System.Drawing.Point(16, 5)
        Me.lblDLHeader.Name = "lblDLHeader"
        Me.lblDLHeader.Size = New System.Drawing.Size(30, 20)
        Me.lblDLHeader.TabIndex = 25
        Me.lblDLHeader.Text = "DL"
        '
        'lblAverageAttacks
        '
        Me.lblAverageAttacks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAverageAttacks.AutoSize = True
        Me.lblAverageAttacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageAttacks.Location = New System.Drawing.Point(35, 28)
        Me.lblAverageAttacks.Name = "lblAverageAttacks"
        Me.lblAverageAttacks.Size = New System.Drawing.Size(111, 20)
        Me.lblAverageAttacks.TabIndex = 30
        Me.lblAverageAttacks.Text = "Ave Atks / DN:"
        Me.lblAverageAttacks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHealmoreHeader
        '
        Me.lblHealmoreHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblHealmoreHeader.AutoSize = True
        Me.lblHealmoreHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealmoreHeader.Location = New System.Drawing.Point(236, 28)
        Me.lblHealmoreHeader.Name = "lblHealmoreHeader"
        Me.lblHealmoreHeader.Size = New System.Drawing.Size(90, 20)
        Me.lblHealmoreHeader.TabIndex = 31
        Me.lblHealmoreHeader.Text = "Healmores:"
        Me.lblHealmoreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStrengthHeader
        '
        Me.lblStrengthHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblStrengthHeader.AutoSize = True
        Me.lblStrengthHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrengthHeader.Location = New System.Drawing.Point(127, 1)
        Me.lblStrengthHeader.Name = "lblStrengthHeader"
        Me.lblStrengthHeader.Size = New System.Drawing.Size(41, 20)
        Me.lblStrengthHeader.TabIndex = 32
        Me.lblStrengthHeader.Text = "STR"
        '
        'lblAgilityHeader
        '
        Me.lblAgilityHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAgilityHeader.AutoSize = True
        Me.lblAgilityHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgilityHeader.Location = New System.Drawing.Point(164, 1)
        Me.lblAgilityHeader.Name = "lblAgilityHeader"
        Me.lblAgilityHeader.Size = New System.Drawing.Size(38, 20)
        Me.lblAgilityHeader.TabIndex = 33
        Me.lblAgilityHeader.Text = "AGI"
        '
        'lblHPHeader
        '
        Me.lblHPHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblHPHeader.AutoSize = True
        Me.lblHPHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPHeader.Location = New System.Drawing.Point(200, 1)
        Me.lblHPHeader.Name = "lblHPHeader"
        Me.lblHPHeader.Size = New System.Drawing.Size(31, 20)
        Me.lblHPHeader.TabIndex = 34
        Me.lblHPHeader.Text = "HP"
        '
        'lblMPHeader
        '
        Me.lblMPHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMPHeader.AutoSize = True
        Me.lblMPHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMPHeader.Location = New System.Drawing.Point(235, 1)
        Me.lblMPHeader.Name = "lblMPHeader"
        Me.lblMPHeader.Size = New System.Drawing.Size(32, 20)
        Me.lblMPHeader.TabIndex = 35
        Me.lblMPHeader.Text = "MP"
        '
        'txtDNAttacks
        '
        Me.txtDNAttacks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDNAttacks.Enabled = False
        Me.txtDNAttacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNAttacks.Location = New System.Drawing.Point(182, 27)
        Me.txtDNAttacks.Name = "txtDNAttacks"
        Me.txtDNAttacks.Size = New System.Drawing.Size(30, 22)
        Me.txtDNAttacks.TabIndex = 36
        Me.txtDNAttacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDeathNecklaceHPHeader
        '
        Me.lblDeathNecklaceHPHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDeathNecklaceHPHeader.AutoSize = True
        Me.lblDeathNecklaceHPHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeathNecklaceHPHeader.Location = New System.Drawing.Point(84, 52)
        Me.lblDeathNecklaceHPHeader.Name = "lblDeathNecklaceHPHeader"
        Me.lblDeathNecklaceHPHeader.Size = New System.Drawing.Size(62, 20)
        Me.lblDeathNecklaceHPHeader.TabIndex = 38
        Me.lblDeathNecklaceHPHeader.Text = "DN HP:"
        Me.lblDeathNecklaceHPHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDeathNecklaceHP
        '
        Me.txtDeathNecklaceHP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDeathNecklaceHP.Enabled = False
        Me.txtDeathNecklaceHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeathNecklaceHP.Location = New System.Drawing.Point(150, 51)
        Me.txtDeathNecklaceHP.Name = "txtDeathNecklaceHP"
        Me.txtDeathNecklaceHP.Size = New System.Drawing.Size(30, 22)
        Me.txtDeathNecklaceHP.TabIndex = 37
        Me.txtDeathNecklaceHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlDLCalculations
        '
        Me.pnlDLCalculations.BackColor = System.Drawing.Color.Transparent
        Me.pnlDLCalculations.Controls.Add(Me.chkAssumeFightersRing)
        Me.pnlDLCalculations.Controls.Add(Me.chkAssumeErdricksSword)
        Me.pnlDLCalculations.Controls.Add(Me.lblDeathNecklaceHPHeader)
        Me.pnlDLCalculations.Controls.Add(Me.txtDeathNecklaceHP)
        Me.pnlDLCalculations.Controls.Add(Me.txtDNAttacks)
        Me.pnlDLCalculations.Controls.Add(Me.lblHealmoreHeader)
        Me.pnlDLCalculations.Controls.Add(Me.lblAverageAttacks)
        Me.pnlDLCalculations.Controls.Add(Me.txtHealmores)
        Me.pnlDLCalculations.Controls.Add(Me.txtAverageAttacks)
        Me.pnlDLCalculations.Controls.Add(Me.lblDLHeader)
        Me.pnlDLCalculations.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDLCalculations.Location = New System.Drawing.Point(0, 335)
        Me.pnlDLCalculations.Name = "pnlDLCalculations"
        Me.pnlDLCalculations.Size = New System.Drawing.Size(386, 76)
        Me.pnlDLCalculations.TabIndex = 40
        '
        'chkAssumeFightersRing
        '
        Me.chkAssumeFightersRing.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkAssumeFightersRing.AutoSize = True
        Me.chkAssumeFightersRing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssumeFightersRing.Location = New System.Drawing.Point(244, 3)
        Me.chkAssumeFightersRing.Name = "chkAssumeFightersRing"
        Me.chkAssumeFightersRing.Size = New System.Drawing.Size(126, 24)
        Me.chkAssumeFightersRing.TabIndex = 40
        Me.chkAssumeFightersRing.Text = "Fighter's Ring"
        Me.chkAssumeFightersRing.UseVisualStyleBackColor = True
        '
        'chkAssumeErdricksSword
        '
        Me.chkAssumeErdricksSword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkAssumeErdricksSword.AutoSize = True
        Me.chkAssumeErdricksSword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAssumeErdricksSword.Location = New System.Drawing.Point(105, 3)
        Me.chkAssumeErdricksSword.Name = "chkAssumeErdricksSword"
        Me.chkAssumeErdricksSword.Size = New System.Drawing.Size(137, 24)
        Me.chkAssumeErdricksSword.TabIndex = 39
        Me.chkAssumeErdricksSword.Text = "Erdrick's Sword"
        Me.chkAssumeErdricksSword.UseVisualStyleBackColor = True
        '
        'pnlStatsOutput
        '
        Me.pnlStatsOutput.BackColor = System.Drawing.Color.Transparent
        Me.pnlStatsOutput.Controls.Add(Me.lblDefense)
        Me.pnlStatsOutput.Controls.Add(Me.txtDefense)
        Me.pnlStatsOutput.Controls.Add(Me.lblAttackPower)
        Me.pnlStatsOutput.Controls.Add(Me.txtAP)
        Me.pnlStatsOutput.Controls.Add(Me.lblMPHeader)
        Me.pnlStatsOutput.Controls.Add(Me.lblHPHeader)
        Me.pnlStatsOutput.Controls.Add(Me.lblAgilityHeader)
        Me.pnlStatsOutput.Controls.Add(Me.lblStrengthHeader)
        Me.pnlStatsOutput.Controls.Add(Me.txtLastAgility)
        Me.pnlStatsOutput.Controls.Add(Me.txtLastHP)
        Me.pnlStatsOutput.Controls.Add(Me.txtLastMP)
        Me.pnlStatsOutput.Controls.Add(Me.txtLastPower)
        Me.pnlStatsOutput.Controls.Add(Me.txtAgility)
        Me.pnlStatsOutput.Controls.Add(Me.txtHP)
        Me.pnlStatsOutput.Controls.Add(Me.txtMP)
        Me.pnlStatsOutput.Controls.Add(Me.txtPower)
        Me.pnlStatsOutput.Controls.Add(Me.lblLastLevel)
        Me.pnlStatsOutput.Controls.Add(Me.lblCurrentStats)
        Me.pnlStatsOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatsOutput.Location = New System.Drawing.Point(0, 265)
        Me.pnlStatsOutput.Name = "pnlStatsOutput"
        Me.pnlStatsOutput.Size = New System.Drawing.Size(386, 70)
        Me.pnlStatsOutput.TabIndex = 41
        '
        'pnlItemTracker
        '
        Me.pnlItemTracker.BackColor = System.Drawing.Color.Transparent
        Me.pnlItemTracker.Controls.Add(Me.pbShields)
        Me.pnlItemTracker.Controls.Add(Me.pbArmor)
        Me.pnlItemTracker.Controls.Add(Me.pbWeapons)
        Me.pnlItemTracker.Controls.Add(Me.pbToken)
        Me.pnlItemTracker.Controls.Add(Me.pbStones)
        Me.pnlItemTracker.Controls.Add(Me.pbStaff)
        Me.pnlItemTracker.Controls.Add(Me.pbDN)
        Me.pnlItemTracker.Controls.Add(Me.pbDrop)
        Me.pnlItemTracker.Controls.Add(Me.pbKeys)
        Me.pnlItemTracker.Controls.Add(Me.pbHarp)
        Me.pnlItemTracker.Controls.Add(Me.pbPrincess)
        Me.pnlItemTracker.Controls.Add(Me.pbFlute)
        Me.pnlItemTracker.Controls.Add(Me.pbRing)
        Me.pnlItemTracker.Controls.Add(Me.pbScale)
        Me.pnlItemTracker.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlItemTracker.Location = New System.Drawing.Point(0, 109)
        Me.pnlItemTracker.Name = "pnlItemTracker"
        Me.pnlItemTracker.Size = New System.Drawing.Size(386, 156)
        Me.pnlItemTracker.TabIndex = 42
        '
        'pnlHeaderOutput
        '
        Me.pnlHeaderOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlHeaderOutput.BackColor = System.Drawing.Color.Transparent
        Me.pnlHeaderOutput.Controls.Add(Me.lblHeader2Output)
        Me.pnlHeaderOutput.Controls.Add(Me.lblHeader1Output)
        Me.pnlHeaderOutput.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderOutput.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderOutput.Name = "pnlHeaderOutput"
        Me.pnlHeaderOutput.Size = New System.Drawing.Size(386, 65)
        Me.pnlHeaderOutput.TabIndex = 44
        '
        'lblHeader2Output
        '
        Me.lblHeader2Output.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader2Output.Location = New System.Drawing.Point(0, 13)
        Me.lblHeader2Output.Name = "lblHeader2Output"
        Me.lblHeader2Output.Size = New System.Drawing.Size(386, 13)
        Me.lblHeader2Output.TabIndex = 41
        Me.lblHeader2Output.Text = "Header 2"
        Me.lblHeader2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeader1Output
        '
        Me.lblHeader1Output.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader1Output.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader1Output.Name = "lblHeader1Output"
        Me.lblHeader1Output.Size = New System.Drawing.Size(386, 13)
        Me.lblHeader1Output.TabIndex = 40
        Me.lblHeader1Output.Text = "Header 1"
        Me.lblHeader1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimerOutput
        '
        Me.lblTimerOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblTimerOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTimerOutput.Location = New System.Drawing.Point(0, 51)
        Me.lblTimerOutput.Name = "lblTimerOutput"
        Me.lblTimerOutput.Size = New System.Drawing.Size(386, 58)
        Me.lblTimerOutput.TabIndex = 45
        Me.lblTimerOutput.Text = "0.000"
        Me.lblTimerOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRunPercentage
        '
        Me.pnlRunPercentage.BackColor = System.Drawing.Color.Transparent
        Me.pnlRunPercentage.Controls.Add(Me.lblDL2RunPercentOut)
        Me.pnlRunPercentage.Controls.Add(Me.lblDL2RunPercent)
        Me.pnlRunPercentage.Controls.Add(Me.lblDL1RunPercentOut)
        Me.pnlRunPercentage.Controls.Add(Me.lblDL1RunPercent)
        Me.pnlRunPercentage.Controls.Add(Me.lblArmKnightRunPercentOut)
        Me.pnlRunPercentage.Controls.Add(Me.lblArmKnightRunPercent)
        Me.pnlRunPercentage.Controls.Add(Me.lblRedDragRunPercentOut)
        Me.pnlRunPercentage.Controls.Add(Me.lblRunPercent)
        Me.pnlRunPercentage.Controls.Add(Me.lblRedDragRunPercent)
        Me.pnlRunPercentage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRunPercentage.Location = New System.Drawing.Point(0, 411)
        Me.pnlRunPercentage.Name = "pnlRunPercentage"
        Me.pnlRunPercentage.Size = New System.Drawing.Size(386, 100)
        Me.pnlRunPercentage.TabIndex = 46
        '
        'lblRedDragRunPercent
        '
        Me.lblRedDragRunPercent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRedDragRunPercent.AutoSize = True
        Me.lblRedDragRunPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedDragRunPercent.Location = New System.Drawing.Point(42, 68)
        Me.lblRedDragRunPercent.Name = "lblRedDragRunPercent"
        Me.lblRedDragRunPercent.Size = New System.Drawing.Size(82, 20)
        Me.lblRedDragRunPercent.TabIndex = 0
        Me.lblRedDragRunPercent.Text = "R. Dragon"
        Me.lblRedDragRunPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRunPercent
        '
        Me.lblRunPercent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRunPercent.AutoSize = True
        Me.lblRunPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunPercent.Location = New System.Drawing.Point(95, 6)
        Me.lblRunPercent.Name = "lblRunPercent"
        Me.lblRunPercent.Size = New System.Drawing.Size(196, 20)
        Me.lblRunPercent.TabIndex = 1
        Me.lblRunPercent.Text = "Run/Back Attack Chances"
        '
        'lblRedDragRunPercentOut
        '
        Me.lblRedDragRunPercentOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRedDragRunPercentOut.BackColor = System.Drawing.SystemColors.Window
        Me.lblRedDragRunPercentOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRedDragRunPercentOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedDragRunPercentOut.Location = New System.Drawing.Point(130, 67)
        Me.lblRedDragRunPercentOut.Name = "lblRedDragRunPercentOut"
        Me.lblRedDragRunPercentOut.Size = New System.Drawing.Size(69, 22)
        Me.lblRedDragRunPercentOut.TabIndex = 2
        Me.lblRedDragRunPercentOut.Text = "Label1"
        Me.lblRedDragRunPercentOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArmKnightRunPercentOut
        '
        Me.lblArmKnightRunPercentOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblArmKnightRunPercentOut.BackColor = System.Drawing.SystemColors.Window
        Me.lblArmKnightRunPercentOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArmKnightRunPercentOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmKnightRunPercentOut.Location = New System.Drawing.Point(130, 35)
        Me.lblArmKnightRunPercentOut.Name = "lblArmKnightRunPercentOut"
        Me.lblArmKnightRunPercentOut.Size = New System.Drawing.Size(69, 22)
        Me.lblArmKnightRunPercentOut.TabIndex = 4
        Me.lblArmKnightRunPercentOut.Text = "Label2"
        Me.lblArmKnightRunPercentOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArmKnightRunPercent
        '
        Me.lblArmKnightRunPercent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblArmKnightRunPercent.AutoSize = True
        Me.lblArmKnightRunPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmKnightRunPercent.Location = New System.Drawing.Point(33, 36)
        Me.lblArmKnightRunPercent.Name = "lblArmKnightRunPercent"
        Me.lblArmKnightRunPercent.Size = New System.Drawing.Size(91, 20)
        Me.lblArmKnightRunPercent.TabIndex = 3
        Me.lblArmKnightRunPercent.Text = "Arm. Knight"
        Me.lblArmKnightRunPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDL1RunPercentOut
        '
        Me.lblDL1RunPercentOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDL1RunPercentOut.BackColor = System.Drawing.SystemColors.Window
        Me.lblDL1RunPercentOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDL1RunPercentOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDL1RunPercentOut.Location = New System.Drawing.Point(285, 35)
        Me.lblDL1RunPercentOut.Name = "lblDL1RunPercentOut"
        Me.lblDL1RunPercentOut.Size = New System.Drawing.Size(69, 22)
        Me.lblDL1RunPercentOut.TabIndex = 6
        Me.lblDL1RunPercentOut.Text = "Label4"
        Me.lblDL1RunPercentOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDL1RunPercent
        '
        Me.lblDL1RunPercent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDL1RunPercent.AutoSize = True
        Me.lblDL1RunPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDL1RunPercent.Location = New System.Drawing.Point(236, 36)
        Me.lblDL1RunPercent.Name = "lblDL1RunPercent"
        Me.lblDL1RunPercent.Size = New System.Drawing.Size(43, 20)
        Me.lblDL1RunPercent.TabIndex = 5
        Me.lblDL1RunPercent.Text = "DL 1"
        Me.lblDL1RunPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDL2RunPercentOut
        '
        Me.lblDL2RunPercentOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDL2RunPercentOut.BackColor = System.Drawing.SystemColors.Window
        Me.lblDL2RunPercentOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDL2RunPercentOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDL2RunPercentOut.Location = New System.Drawing.Point(285, 67)
        Me.lblDL2RunPercentOut.Name = "lblDL2RunPercentOut"
        Me.lblDL2RunPercentOut.Size = New System.Drawing.Size(69, 22)
        Me.lblDL2RunPercentOut.TabIndex = 8
        Me.lblDL2RunPercentOut.Text = "Label6"
        Me.lblDL2RunPercentOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDL2RunPercent
        '
        Me.lblDL2RunPercent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDL2RunPercent.AutoSize = True
        Me.lblDL2RunPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDL2RunPercent.Location = New System.Drawing.Point(236, 68)
        Me.lblDL2RunPercent.Name = "lblDL2RunPercent"
        Me.lblDL2RunPercent.Size = New System.Drawing.Size(43, 20)
        Me.lblDL2RunPercent.TabIndex = 7
        Me.lblDL2RunPercent.Text = "DL 2"
        Me.lblDL2RunPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAttackPower
        '
        Me.lblAttackPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAttackPower.AutoSize = True
        Me.lblAttackPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttackPower.Location = New System.Drawing.Point(270, 1)
        Me.lblAttackPower.Name = "lblAttackPower"
        Me.lblAttackPower.Size = New System.Drawing.Size(30, 20)
        Me.lblAttackPower.TabIndex = 38
        Me.lblAttackPower.Text = "AP"
        '
        'txtAP
        '
        Me.txtAP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtAP.Enabled = False
        Me.txtAP.Location = New System.Drawing.Point(269, 23)
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(33, 20)
        Me.txtAP.TabIndex = 36
        Me.txtAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDefense
        '
        Me.lblDefense.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDefense.AutoSize = True
        Me.lblDefense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefense.Location = New System.Drawing.Point(301, 1)
        Me.lblDefense.Name = "lblDefense"
        Me.lblDefense.Size = New System.Drawing.Size(42, 20)
        Me.lblDefense.TabIndex = 41
        Me.lblDefense.Text = "DEF"
        '
        'txtDefense
        '
        Me.txtDefense.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDefense.Enabled = False
        Me.txtDefense.Location = New System.Drawing.Point(304, 23)
        Me.txtDefense.Name = "txtDefense"
        Me.txtDefense.Size = New System.Drawing.Size(33, 20)
        Me.txtDefense.TabIndex = 39
        Me.txtDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DWRTackerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(386, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTimerOutput)
        Me.Controls.Add(Me.pnlItemTracker)
        Me.Controls.Add(Me.pnlStatsOutput)
        Me.Controls.Add(Me.pnlDLCalculations)
        Me.Controls.Add(Me.pnlHeaderOutput)
        Me.Controls.Add(Me.pnlRunPercentage)
        Me.Name = "DWRTackerWindow"
        Me.ShowIcon = False
        Me.Text = "Tracker Display"
        CType(Me.pbToken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbKeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHarp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrincess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWeapons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArmor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDLCalculations.ResumeLayout(False)
        Me.pnlDLCalculations.PerformLayout()
        Me.pnlStatsOutput.ResumeLayout(False)
        Me.pnlStatsOutput.PerformLayout()
        Me.pnlItemTracker.ResumeLayout(False)
        Me.pnlHeaderOutput.ResumeLayout(False)
        Me.pnlRunPercentage.ResumeLayout(False)
        Me.pnlRunPercentage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbScale As PictureBox
    Friend WithEvents pbRing As PictureBox
    Friend WithEvents pbFlute As PictureBox
    Friend WithEvents pbPrincess As PictureBox
    Friend WithEvents pbHarp As PictureBox
    Friend WithEvents pbKeys As PictureBox
    Friend WithEvents pbDrop As PictureBox
    Friend WithEvents pbDN As PictureBox
    Friend WithEvents pbStaff As PictureBox
    Friend WithEvents pbStones As PictureBox
    Friend WithEvents pbToken As PictureBox
    Friend WithEvents pbWeapons As PictureBox
    Friend WithEvents pbArmor As PictureBox
    Friend WithEvents pbShields As PictureBox
    Friend WithEvents lblCurrentStats As Label
    Friend WithEvents lblLastLevel As Label
    Friend WithEvents txtPower As TextBox
    Friend WithEvents txtMP As TextBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtAgility As TextBox
    Friend WithEvents txtLastAgility As TextBox
    Friend WithEvents txtLastHP As TextBox
    Friend WithEvents txtLastMP As TextBox
    Friend WithEvents txtLastPower As TextBox
    Friend WithEvents txtHealmores As TextBox
    Friend WithEvents txtAverageAttacks As TextBox
    Friend WithEvents lblDLHeader As Label
    Friend WithEvents lblAverageAttacks As Label
    Friend WithEvents lblHealmoreHeader As Label
    Friend WithEvents lblStrengthHeader As Label
    Friend WithEvents lblAgilityHeader As Label
    Friend WithEvents lblHPHeader As Label
    Friend WithEvents lblMPHeader As Label
    Friend WithEvents txtDNAttacks As TextBox
    Friend WithEvents lblDeathNecklaceHPHeader As Label
    Friend WithEvents txtDeathNecklaceHP As TextBox
    Friend WithEvents pnlDLCalculations As Panel
    Friend WithEvents pnlStatsOutput As Panel
    Friend WithEvents pnlItemTracker As Panel
    Friend WithEvents pnlHeaderOutput As Panel
    Friend WithEvents lblHeader2Output As Label
    Friend WithEvents lblHeader1Output As Label
    Friend WithEvents lblTimerOutput As Label
    Friend WithEvents chkAssumeFightersRing As CheckBox
    Friend WithEvents chkAssumeErdricksSword As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlRunPercentage As Panel
    Friend WithEvents lblDL2RunPercentOut As Label
    Friend WithEvents lblDL2RunPercent As Label
    Friend WithEvents lblDL1RunPercentOut As Label
    Friend WithEvents lblDL1RunPercent As Label
    Friend WithEvents lblArmKnightRunPercentOut As Label
    Friend WithEvents lblArmKnightRunPercent As Label
    Friend WithEvents lblRedDragRunPercentOut As Label
    Friend WithEvents lblRunPercent As Label
    Friend WithEvents lblRedDragRunPercent As Label
    Friend WithEvents lblDefense As Label
    Friend WithEvents txtDefense As TextBox
    Friend WithEvents lblAttackPower As Label
    Friend WithEvents txtAP As TextBox
End Class
