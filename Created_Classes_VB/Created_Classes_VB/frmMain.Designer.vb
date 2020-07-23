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
        Me.btnBox1 = New System.Windows.Forms.Button()
        Me.btnBox2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxLength = New System.Windows.Forms.TextBox()
        Me.tbxWidth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBox1
        '
        Me.btnBox1.Location = New System.Drawing.Point(32, 36)
        Me.btnBox1.Name = "btnBox1"
        Me.btnBox1.Size = New System.Drawing.Size(147, 44)
        Me.btnBox1.TabIndex = 0
        Me.btnBox1.Text = "Box 1 Volume"
        Me.btnBox1.UseVisualStyleBackColor = True
        '
        'btnBox2
        '
        Me.btnBox2.Location = New System.Drawing.Point(32, 107)
        Me.btnBox2.Name = "btnBox2"
        Me.btnBox2.Size = New System.Drawing.Size(147, 44)
        Me.btnBox2.TabIndex = 1
        Me.btnBox2.Text = "Box 2 Volume"
        Me.btnBox2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(32, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 44)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length"
        '
        'tbxLength
        '
        Me.tbxLength.Location = New System.Drawing.Point(336, 33)
        Me.tbxLength.Name = "tbxLength"
        Me.tbxLength.Size = New System.Drawing.Size(100, 29)
        Me.tbxLength.TabIndex = 4
        '
        'tbxWidth
        '
        Me.tbxWidth.Location = New System.Drawing.Point(336, 89)
        Me.tbxWidth.Name = "tbxWidth"
        Me.tbxWidth.Size = New System.Drawing.Size(100, 29)
        Me.tbxWidth.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Width"
        '
        'tbxHeight
        '
        Me.tbxHeight.Location = New System.Drawing.Point(336, 145)
        Me.tbxHeight.Name = "tbxHeight"
        Me.tbxHeight.Size = New System.Drawing.Size(100, 29)
        Me.tbxHeight.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Height"
        '
        'btnCustom
        '
        Me.btnCustom.Location = New System.Drawing.Point(266, 193)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(170, 43)
        Me.btnCustom.TabIndex = 9
        Me.btnCustom.Text = "Custom Volume"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 262)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.tbxHeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxWidth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxLength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBox2)
        Me.Controls.Add(Me.btnBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objects and Classes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBox1 As Button
    Friend WithEvents btnBox2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxLength As TextBox
    Friend WithEvents tbxWidth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxHeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCustom As Button
End Class
