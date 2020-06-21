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
        Me.lblMyLabel = New System.Windows.Forms.Label()
        Me.lbxList = New System.Windows.Forms.ListBox()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnMyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMyLabel
        '
        Me.lblMyLabel.AutoSize = True
        Me.lblMyLabel.Location = New System.Drawing.Point(12, 22)
        Me.lblMyLabel.Name = "lblMyLabel"
        Me.lblMyLabel.Size = New System.Drawing.Size(66, 24)
        Me.lblMyLabel.TabIndex = 0
        Me.lblMyLabel.Text = "Label1"
        '
        'lbxList
        '
        Me.lbxList.FormattingEnabled = True
        Me.lbxList.ItemHeight = 24
        Me.lbxList.Items.AddRange(New Object() {"Rock", "Paper", "Scissors", "Lizard", "Spock"})
        Me.lbxList.Location = New System.Drawing.Point(249, 22)
        Me.lbxList.Name = "lbxList"
        Me.lbxList.Size = New System.Drawing.Size(196, 196)
        Me.lbxList.TabIndex = 1
        '
        'tbxInput
        '
        Me.tbxInput.Location = New System.Drawing.Point(16, 71)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(164, 29)
        Me.tbxInput.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.Gainsboro
        Me.lblOutput.Location = New System.Drawing.Point(16, 255)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(429, 107)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Output Label"
        '
        'btnMyButton
        '
        Me.btnMyButton.Location = New System.Drawing.Point(16, 130)
        Me.btnMyButton.Name = "btnMyButton"
        Me.btnMyButton.Size = New System.Drawing.Size(164, 79)
        Me.btnMyButton.TabIndex = 4
        Me.btnMyButton.Text = "&Click!"
        Me.btnMyButton.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(457, 371)
        Me.Controls.Add(Me.btnMyButton)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.lbxList)
        Me.Controls.Add(Me.lblMyLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Functions and Subs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMyLabel As Label
    Friend WithEvents lbxList As ListBox
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnMyButton As Button
End Class
