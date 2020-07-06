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
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter some Text:"
        '
        'tbxInput
        '
        Me.tbxInput.Location = New System.Drawing.Point(173, 31)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(312, 29)
        Me.tbxInput.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(33, 163)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(428, 174)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "Output goes here"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(352, 66)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(133, 37)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(497, 377)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Manipulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnSubmit As Button
End Class
