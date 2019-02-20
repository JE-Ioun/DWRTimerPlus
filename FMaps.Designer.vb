<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMaps
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tcMaps = New System.Windows.Forms.TabControl()
        Me.tpSwamp = New System.Windows.Forms.TabPage()
        Me.tpTablet = New System.Windows.Forms.TabPage()
        Me.tpGrave = New System.Windows.Forms.TabPage()
        Me.tpMountain = New System.Windows.Forms.TabPage()
        Me.tpCharlock = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.tpVanillaWorld1 = New System.Windows.Forms.TabPage()
        Me.tpVanillaMap2 = New System.Windows.Forms.TabPage()
        Me.tcMaps.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMaps
        '
        Me.tcMaps.Controls.Add(Me.tpSwamp)
        Me.tcMaps.Controls.Add(Me.tpTablet)
        Me.tcMaps.Controls.Add(Me.tpGrave)
        Me.tcMaps.Controls.Add(Me.tpMountain)
        Me.tcMaps.Controls.Add(Me.tpCharlock)
        Me.tcMaps.Controls.Add(Me.tpVanillaWorld1)
        Me.tcMaps.Controls.Add(Me.tpVanillaMap2)
        Me.tcMaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMaps.Location = New System.Drawing.Point(0, 0)
        Me.tcMaps.Name = "tcMaps"
        Me.tcMaps.SelectedIndex = 0
        Me.tcMaps.Size = New System.Drawing.Size(571, 681)
        Me.tcMaps.TabIndex = 0
        '
        'tpSwamp
        '
        Me.tpSwamp.BackColor = System.Drawing.Color.Black
        Me.tpSwamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpSwamp.Location = New System.Drawing.Point(4, 22)
        Me.tpSwamp.Name = "tpSwamp"
        Me.tpSwamp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSwamp.Size = New System.Drawing.Size(563, 655)
        Me.tpSwamp.TabIndex = 0
        Me.tpSwamp.Text = "Swamp"
        '
        'tpTablet
        '
        Me.tpTablet.BackColor = System.Drawing.Color.Black
        Me.tpTablet.Location = New System.Drawing.Point(4, 22)
        Me.tpTablet.Name = "tpTablet"
        Me.tpTablet.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTablet.Size = New System.Drawing.Size(357, 655)
        Me.tpTablet.TabIndex = 1
        Me.tpTablet.Text = "Tablet"
        '
        'tpGrave
        '
        Me.tpGrave.BackColor = System.Drawing.Color.Black
        Me.tpGrave.Location = New System.Drawing.Point(4, 22)
        Me.tpGrave.Name = "tpGrave"
        Me.tpGrave.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGrave.Size = New System.Drawing.Size(357, 655)
        Me.tpGrave.TabIndex = 2
        Me.tpGrave.Text = "Grave"
        '
        'tpMountain
        '
        Me.tpMountain.BackColor = System.Drawing.Color.Black
        Me.tpMountain.Location = New System.Drawing.Point(4, 22)
        Me.tpMountain.Name = "tpMountain"
        Me.tpMountain.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMountain.Size = New System.Drawing.Size(357, 655)
        Me.tpMountain.TabIndex = 3
        Me.tpMountain.Text = "Mountain"
        '
        'tpCharlock
        '
        Me.tpCharlock.BackColor = System.Drawing.Color.Black
        Me.tpCharlock.Location = New System.Drawing.Point(4, 22)
        Me.tpCharlock.Name = "tpCharlock"
        Me.tpCharlock.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCharlock.Size = New System.Drawing.Size(357, 655)
        Me.tpCharlock.TabIndex = 4
        Me.tpCharlock.Text = "Charlock"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(512, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Route"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(453, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Zoom"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'tpVanillaWorld1
        '
        Me.tpVanillaWorld1.AutoScroll = True
        Me.tpVanillaWorld1.Location = New System.Drawing.Point(4, 22)
        Me.tpVanillaWorld1.Name = "tpVanillaWorld1"
        Me.tpVanillaWorld1.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVanillaWorld1.Size = New System.Drawing.Size(563, 655)
        Me.tpVanillaWorld1.TabIndex = 5
        Me.tpVanillaWorld1.Text = "Vanilla Coords 1"
        Me.tpVanillaWorld1.UseVisualStyleBackColor = True
        '
        'tpVanillaMap2
        '
        Me.tpVanillaMap2.Location = New System.Drawing.Point(4, 22)
        Me.tpVanillaMap2.Name = "tpVanillaMap2"
        Me.tpVanillaMap2.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVanillaMap2.Size = New System.Drawing.Size(563, 655)
        Me.tpVanillaMap2.TabIndex = 6
        Me.tpVanillaMap2.Text = "Vanilla Coords 2"
        Me.tpVanillaMap2.UseVisualStyleBackColor = True
        '
        'FMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 681)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.tcMaps)
        Me.MinimumSize = New System.Drawing.Size(381, 94)
        Me.Name = "FMaps"
        Me.Text = "Maps"
        Me.tcMaps.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tcMaps As TabControl
    Friend WithEvents tpSwamp As TabPage
    Friend WithEvents tpTablet As TabPage
    Friend WithEvents tpGrave As TabPage
    Friend WithEvents tpMountain As TabPage
    Friend WithEvents tpCharlock As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents tpVanillaWorld1 As TabPage
    Friend WithEvents tpVanillaMap2 As TabPage
End Class
