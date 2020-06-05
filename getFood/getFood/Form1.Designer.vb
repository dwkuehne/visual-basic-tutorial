<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.tbxNumbers = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxPhone
        '
        Me.tbxPhone.Location = New System.Drawing.Point(12, 12)
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(262, 38)
        Me.tbxPhone.TabIndex = 0
        '
        'tbxNumbers
        '
        Me.tbxNumbers.Location = New System.Drawing.Point(333, 12)
        Me.tbxNumbers.Name = "tbxNumbers"
        Me.tbxNumbers.ReadOnly = True
        Me.tbxNumbers.Size = New System.Drawing.Size(262, 38)
        Me.tbxNumbers.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(159, 72)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(269, 57)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Enter Yo Digits"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 158)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.tbxNumbers)
        Me.Controls.Add(Me.tbxPhone)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form1"
        Me.Text = "Phone Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents tbxNumbers As TextBox
    Friend WithEvents btnGo As Button
End Class
