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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxFirst = New System.Windows.Forms.TextBox()
        Me.tbxLast = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxColor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'tbxFirst
        '
        Me.tbxFirst.Location = New System.Drawing.Point(16, 53)
        Me.tbxFirst.Name = "tbxFirst"
        Me.tbxFirst.Size = New System.Drawing.Size(172, 29)
        Me.tbxFirst.TabIndex = 1
        '
        'tbxLast
        '
        Me.tbxLast.Location = New System.Drawing.Point(217, 53)
        Me.tbxLast.Name = "tbxLast"
        Me.tbxLast.Size = New System.Drawing.Size(172, 29)
        Me.tbxLast.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'tbxColor
        '
        Me.tbxColor.Location = New System.Drawing.Point(418, 53)
        Me.tbxColor.Name = "tbxColor"
        Me.tbxColor.Size = New System.Drawing.Size(172, 29)
        Me.tbxColor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Favorite Color"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(204, 103)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(199, 40)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 160)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.tbxColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxFirst)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validating Fields"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxFirst As TextBox
    Friend WithEvents tbxLast As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxColor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSubmit As Button
End Class
