<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.gbxGroup = New System.Windows.Forms.GroupBox()
        Me.rdoStart = New System.Windows.Forms.RadioButton()
        Me.rdoStop = New System.Windows.Forms.RadioButton()
        Me.timTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.pbxLight = New System.Windows.Forms.PictureBox()
        Me.gbxGroup.SuspendLayout()
        CType(Me.pbxLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxGroup
        '
        Me.gbxGroup.Controls.Add(Me.rdoStop)
        Me.gbxGroup.Controls.Add(Me.rdoStart)
        Me.gbxGroup.Location = New System.Drawing.Point(12, 12)
        Me.gbxGroup.Name = "gbxGroup"
        Me.gbxGroup.Size = New System.Drawing.Size(153, 130)
        Me.gbxGroup.TabIndex = 0
        Me.gbxGroup.TabStop = False
        Me.gbxGroup.Text = "Timer Controls"
        '
        'rdoStart
        '
        Me.rdoStart.AutoSize = True
        Me.rdoStart.Location = New System.Drawing.Point(18, 39)
        Me.rdoStart.Name = "rdoStart"
        Me.rdoStart.Size = New System.Drawing.Size(69, 28)
        Me.rdoStart.TabIndex = 0
        Me.rdoStart.TabStop = True
        Me.rdoStart.Text = "Start!"
        Me.rdoStart.UseVisualStyleBackColor = True
        '
        'rdoStop
        '
        Me.rdoStop.AutoSize = True
        Me.rdoStop.Location = New System.Drawing.Point(18, 73)
        Me.rdoStop.Name = "rdoStop"
        Me.rdoStop.Size = New System.Drawing.Size(71, 28)
        Me.rdoStop.TabIndex = 1
        Me.rdoStop.TabStop = True
        Me.rdoStop.Text = "Stop!"
        Me.rdoStop.UseVisualStyleBackColor = True
        '
        'timTimer
        '
        Me.timTimer.Interval = 1000
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 148)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(153, 44)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'pbxLight
        '
        Me.pbxLight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxLight.Image = Global.KuehneControls.My.Resources.Resources.off
        Me.pbxLight.Location = New System.Drawing.Point(182, 19)
        Me.pbxLight.Name = "pbxLight"
        Me.pbxLight.Size = New System.Drawing.Size(175, 173)
        Me.pbxLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLight.TabIndex = 2
        Me.pbxLight.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(369, 211)
        Me.Controls.Add(Me.pbxLight)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.gbxGroup)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kuehne Demonstration"
        Me.gbxGroup.ResumeLayout(False)
        Me.gbxGroup.PerformLayout()
        CType(Me.pbxLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxGroup As GroupBox
    Friend WithEvents rdoStop As RadioButton
    Friend WithEvents rdoStart As RadioButton
    Friend WithEvents timTimer As Timer
    Friend WithEvents btnSelect As Button
    Friend WithEvents pbxLight As PictureBox
End Class
