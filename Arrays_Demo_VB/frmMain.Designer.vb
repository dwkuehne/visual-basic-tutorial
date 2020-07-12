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
        Me.lbxFirstNames = New System.Windows.Forms.ListBox()
        Me.lbxLastNames = New System.Windows.Forms.ListBox()
        Me.lbxFullNames = New System.Windows.Forms.ListBox()
        Me.lbxTwoDimensional = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbxFirstNames
        '
        Me.lbxFirstNames.FormattingEnabled = True
        Me.lbxFirstNames.ItemHeight = 24
        Me.lbxFirstNames.Location = New System.Drawing.Point(12, 12)
        Me.lbxFirstNames.Name = "lbxFirstNames"
        Me.lbxFirstNames.Size = New System.Drawing.Size(246, 244)
        Me.lbxFirstNames.TabIndex = 0
        '
        'lbxLastNames
        '
        Me.lbxLastNames.FormattingEnabled = True
        Me.lbxLastNames.ItemHeight = 24
        Me.lbxLastNames.Location = New System.Drawing.Point(264, 12)
        Me.lbxLastNames.Name = "lbxLastNames"
        Me.lbxLastNames.Size = New System.Drawing.Size(246, 244)
        Me.lbxLastNames.TabIndex = 1
        '
        'lbxFullNames
        '
        Me.lbxFullNames.FormattingEnabled = True
        Me.lbxFullNames.ItemHeight = 24
        Me.lbxFullNames.Location = New System.Drawing.Point(516, 12)
        Me.lbxFullNames.Name = "lbxFullNames"
        Me.lbxFullNames.Size = New System.Drawing.Size(246, 244)
        Me.lbxFullNames.TabIndex = 2
        '
        'lbxTwoDimensional
        '
        Me.lbxTwoDimensional.FormattingEnabled = True
        Me.lbxTwoDimensional.ItemHeight = 24
        Me.lbxTwoDimensional.Location = New System.Drawing.Point(264, 265)
        Me.lbxTwoDimensional.Name = "lbxTwoDimensional"
        Me.lbxTwoDimensional.Size = New System.Drawing.Size(246, 244)
        Me.lbxTwoDimensional.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(776, 521)
        Me.Controls.Add(Me.lbxTwoDimensional)
        Me.Controls.Add(Me.lbxFullNames)
        Me.Controls.Add(Me.lbxLastNames)
        Me.Controls.Add(Me.lbxFirstNames)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrays Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxFirstNames As ListBox
    Friend WithEvents lbxLastNames As ListBox
    Friend WithEvents lbxFullNames As ListBox
    Friend WithEvents lbxTwoDimensional As ListBox
End Class
