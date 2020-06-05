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
        Me.tbxGetText = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.tbxRead = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbxGetText
        '
        Me.tbxGetText.Location = New System.Drawing.Point(17, 16)
        Me.tbxGetText.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.tbxGetText.Name = "tbxGetText"
        Me.tbxGetText.Size = New System.Drawing.Size(267, 38)
        Me.tbxGetText.TabIndex = 0
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(17, 64)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(267, 65)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "Translate"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'tbxRead
        '
        Me.tbxRead.Location = New System.Drawing.Point(17, 139)
        Me.tbxRead.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.tbxRead.Name = "tbxRead"
        Me.tbxRead.ReadOnly = True
        Me.tbxRead.Size = New System.Drawing.Size(267, 38)
        Me.tbxRead.TabIndex = 2
        '
        'Form1
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 194)
        Me.Controls.Add(Me.tbxRead)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.tbxGetText)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form1"
        Me.Text = "Pig Latin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxGetText As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents tbxRead As TextBox
End Class
