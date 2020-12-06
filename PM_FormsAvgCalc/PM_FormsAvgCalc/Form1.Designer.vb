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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.descriptorLabel = New System.Windows.Forms.Label()
        Me.gradeOneHeader = New System.Windows.Forms.Label()
        Me.gradeTwoHeader = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.gradeThreeHeader = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.buttonCalc = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.rewriteNotifier = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.headerLabel.Location = New System.Drawing.Point(12, 9)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(197, 26)
        Me.headerLabel.TabIndex = 1
        Me.headerLabel.Text = "Average Calculator"
        '
        'descriptorLabel
        '
        Me.descriptorLabel.AutoSize = True
        Me.descriptorLabel.Location = New System.Drawing.Point(27, 35)
        Me.descriptorLabel.Name = "descriptorLabel"
        Me.descriptorLabel.Size = New System.Drawing.Size(285, 13)
        Me.descriptorLabel.TabIndex = 2
        Me.descriptorLabel.Text = "Please enter your three grades in the fields provided below."
        '
        'gradeOneHeader
        '
        Me.gradeOneHeader.AutoSize = True
        Me.gradeOneHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.gradeOneHeader.Location = New System.Drawing.Point(13, 62)
        Me.gradeOneHeader.Name = "gradeOneHeader"
        Me.gradeOneHeader.Size = New System.Drawing.Size(67, 20)
        Me.gradeOneHeader.TabIndex = 3
        Me.gradeOneHeader.Text = "Grade 1"
        '
        'gradeTwoHeader
        '
        Me.gradeTwoHeader.AutoSize = True
        Me.gradeTwoHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.gradeTwoHeader.Location = New System.Drawing.Point(13, 122)
        Me.gradeTwoHeader.Name = "gradeTwoHeader"
        Me.gradeTwoHeader.Size = New System.Drawing.Size(67, 20)
        Me.gradeTwoHeader.TabIndex = 4
        Me.gradeTwoHeader.Text = "Grade 2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(30, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'gradeThreeHeader
        '
        Me.gradeThreeHeader.AutoSize = True
        Me.gradeThreeHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.gradeThreeHeader.Location = New System.Drawing.Point(13, 183)
        Me.gradeThreeHeader.Name = "gradeThreeHeader"
        Me.gradeThreeHeader.Size = New System.Drawing.Size(67, 20)
        Me.gradeThreeHeader.TabIndex = 6
        Me.gradeThreeHeader.Text = "Grade 3"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(30, 206)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'buttonCalc
        '
        Me.buttonCalc.Location = New System.Drawing.Point(67, 243)
        Me.buttonCalc.Name = "buttonCalc"
        Me.buttonCalc.Size = New System.Drawing.Size(75, 23)
        Me.buttonCalc.TabIndex = 8
        Me.buttonCalc.Text = "Calculate"
        Me.buttonCalc.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.resultLabel.Location = New System.Drawing.Point(209, 246)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(0, 20)
        Me.resultLabel.TabIndex = 9
        '
        'buttonClear
        '
        Me.buttonClear.Location = New System.Drawing.Point(67, 274)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(75, 23)
        Me.buttonClear.TabIndex = 10
        Me.buttonClear.Text = "Clear Values"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'rewriteNotifier
        '
        Me.rewriteNotifier.AutoSize = True
        Me.rewriteNotifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.rewriteNotifier.Location = New System.Drawing.Point(209, 280)
        Me.rewriteNotifier.Name = "rewriteNotifier"
        Me.rewriteNotifier.Size = New System.Drawing.Size(0, 20)
        Me.rewriteNotifier.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 309)
        Me.Controls.Add(Me.rewriteNotifier)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.buttonCalc)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.gradeThreeHeader)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.gradeTwoHeader)
        Me.Controls.Add(Me.gradeOneHeader)
        Me.Controls.Add(Me.descriptorLabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Average Calc Revamped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents headerLabel As Label
    Friend WithEvents descriptorLabel As Label
    Friend WithEvents gradeOneHeader As Label
    Friend WithEvents gradeTwoHeader As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents gradeThreeHeader As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents buttonCalc As Button
    Friend WithEvents resultLabel As Label
    Friend WithEvents buttonClear As Button
    Friend WithEvents rewriteNotifier As Label
End Class
