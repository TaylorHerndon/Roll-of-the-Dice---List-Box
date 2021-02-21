<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDice
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
        Me.ListBoxResults = New System.Windows.Forms.ListBox()
        Me.ButtonRoll = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxResults
        '
        Me.ListBoxResults.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxResults.FormattingEnabled = True
        Me.ListBoxResults.ItemHeight = 22
        Me.ListBoxResults.Location = New System.Drawing.Point(36, 48)
        Me.ListBoxResults.Name = "ListBoxResults"
        Me.ListBoxResults.Size = New System.Drawing.Size(711, 268)
        Me.ListBoxResults.TabIndex = 0
        '
        'ButtonRoll
        '
        Me.ButtonRoll.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRoll.Location = New System.Drawing.Point(36, 339)
        Me.ButtonRoll.Name = "ButtonRoll"
        Me.ButtonRoll.Size = New System.Drawing.Size(319, 66)
        Me.ButtonRoll.TabIndex = 3
        Me.ButtonRoll.Text = "ROLL"
        Me.ButtonRoll.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(384, 339)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(174, 66)
        Me.ButtonClear.TabIndex = 3
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(573, 339)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(174, 66)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ROLL OF THE DICE"
        '
        'RollOfTheDice
        '
        Me.AcceptButton = Me.ButtonRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonRoll)
        Me.Controls.Add(Me.ListBoxResults)
        Me.Name = "RollOfTheDice"
        Me.Text = "ROLL OF THE DICE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxResults As ListBox
    Friend WithEvents ButtonRoll As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Label1 As Label
End Class
