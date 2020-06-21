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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbxInputOne = New System.Windows.Forms.TextBox()
        Me.tbxInputTwo = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblInputOne = New System.Windows.Forms.Label()
        Me.lblInputTwo = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxInputOne
        '
        Me.tbxInputOne.Location = New System.Drawing.Point(49, 41)
        Me.tbxInputOne.Name = "tbxInputOne"
        Me.tbxInputOne.Size = New System.Drawing.Size(192, 29)
        Me.tbxInputOne.TabIndex = 0
        '
        'tbxInputTwo
        '
        Me.tbxInputTwo.Location = New System.Drawing.Point(49, 119)
        Me.tbxInputTwo.Name = "tbxInputTwo"
        Me.tbxInputTwo.Size = New System.Drawing.Size(192, 29)
        Me.tbxInputTwo.TabIndex = 1
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(49, 186)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(192, 35)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "&Check Values"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblInputOne
        '
        Me.lblInputOne.AutoSize = True
        Me.lblInputOne.Location = New System.Drawing.Point(258, 44)
        Me.lblInputOne.Name = "lblInputOne"
        Me.lblInputOne.Size = New System.Drawing.Size(62, 24)
        Me.lblInputOne.TabIndex = 3
        Me.lblInputOne.Text = "Valid?"
        '
        'lblInputTwo
        '
        Me.lblInputTwo.AutoSize = True
        Me.lblInputTwo.Location = New System.Drawing.Point(258, 122)
        Me.lblInputTwo.Name = "lblInputTwo"
        Me.lblInputTwo.Size = New System.Drawing.Size(62, 24)
        Me.lblInputTwo.TabIndex = 4
        Me.lblInputTwo.Text = "Valid?"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(49, 260)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(187, 24)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "All Values Validated?"
        '
        'lblDigits
        '
        Me.lblDigits.AutoSize = True
        Me.lblDigits.Location = New System.Drawing.Point(49, 13)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(100, 24)
        Me.lblDigits.TabIndex = 6
        Me.lblDigits.Text = "Digits only!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Letters and Symbols"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 304)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDigits)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInputTwo)
        Me.Controls.Add(Me.lblInputOne)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.tbxInputTwo)
        Me.Controls.Add(Me.tbxInputOne)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Functions with Parameters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxInputOne As TextBox
    Friend WithEvents tbxInputTwo As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblInputOne As Label
    Friend WithEvents lblInputTwo As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblDigits As Label
    Friend WithEvents Label1 As Label
End Class
