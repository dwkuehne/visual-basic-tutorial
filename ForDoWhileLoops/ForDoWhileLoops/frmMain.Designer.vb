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
        Me.btnForLoop = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnWhileLoop = New System.Windows.Forms.Button()
        Me.lbxList = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForLoop
        '
        Me.btnForLoop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnForLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForLoop.ForeColor = System.Drawing.Color.Black
        Me.btnForLoop.Location = New System.Drawing.Point(12, 40)
        Me.btnForLoop.Name = "btnForLoop"
        Me.btnForLoop.Size = New System.Drawing.Size(166, 36)
        Me.btnForLoop.TabIndex = 0
        Me.btnForLoop.Text = "&For Loop"
        Me.btnForLoop.UseVisualStyleBackColor = False
        '
        'btnDoUntil
        '
        Me.btnDoUntil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDoUntil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoUntil.ForeColor = System.Drawing.Color.Black
        Me.btnDoUntil.Location = New System.Drawing.Point(12, 146)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(166, 36)
        Me.btnDoUntil.TabIndex = 1
        Me.btnDoUntil.Text = "&Do Until Loop"
        Me.btnDoUntil.UseVisualStyleBackColor = False
        '
        'btnWhileLoop
        '
        Me.btnWhileLoop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWhileLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWhileLoop.ForeColor = System.Drawing.Color.Black
        Me.btnWhileLoop.Location = New System.Drawing.Point(12, 252)
        Me.btnWhileLoop.Name = "btnWhileLoop"
        Me.btnWhileLoop.Size = New System.Drawing.Size(166, 36)
        Me.btnWhileLoop.TabIndex = 2
        Me.btnWhileLoop.Text = "&While Loop"
        Me.btnWhileLoop.UseVisualStyleBackColor = False
        '
        'lbxList
        '
        Me.lbxList.FormattingEnabled = True
        Me.lbxList.ItemHeight = 24
        Me.lbxList.Location = New System.Drawing.Point(197, 44)
        Me.lbxList.Name = "lbxList"
        Me.lbxList.Size = New System.Drawing.Size(214, 244)
        Me.lbxList.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(197, 294)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(214, 36)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear the List Box"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(197, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(214, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit Application"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 385)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbxList)
        Me.Controls.Add(Me.btnWhileLoop)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnForLoop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Looping Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnForLoop As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnWhileLoop As Button
    Friend WithEvents lbxList As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
