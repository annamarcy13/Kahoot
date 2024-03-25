<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kahoot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.LblTotlPplAns = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSkip = New System.Windows.Forms.Button()
        Me.TxtAns1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblAnswersRight = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblQuestion
        '
        Me.LblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion.Location = New System.Drawing.Point(36, 9)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(1016, 126)
        Me.LblQuestion.TabIndex = 0
        '
        'LblTotlPplAns
        '
        Me.LblTotlPplAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotlPplAns.Location = New System.Drawing.Point(971, 200)
        Me.LblTotlPplAns.Name = "LblTotlPplAns"
        Me.LblTotlPplAns.Size = New System.Drawing.Size(81, 67)
        Me.LblTotlPplAns.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(971, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Answers"
        '
        'BtnSkip
        '
        Me.BtnSkip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSkip.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSkip.Location = New System.Drawing.Point(956, 147)
        Me.BtnSkip.Name = "BtnSkip"
        Me.BtnSkip.Size = New System.Drawing.Size(96, 36)
        Me.BtnSkip.TabIndex = 3
        Me.BtnSkip.Text = "Skip"
        Me.BtnSkip.UseVisualStyleBackColor = False
        '
        'TxtAns1
        '
        Me.TxtAns1.BackColor = System.Drawing.Color.Coral
        Me.TxtAns1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAns1.Location = New System.Drawing.Point(3, 317)
        Me.TxtAns1.Multiline = True
        Me.TxtAns1.Name = "TxtAns1"
        Me.TxtAns1.Size = New System.Drawing.Size(531, 127)
        Me.TxtAns1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(551, 317)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(525, 127)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 498)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(531, 127)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.MediumPurple
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(551, 498)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(531, 127)
        Me.TextBox3.TabIndex = 7
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(41, 184)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(68, 67)
        Me.lblTimer.TabIndex = 8
        '
        'lblAnswersRight
        '
        Me.lblAnswersRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswersRight.Location = New System.Drawing.Point(560, 135)
        Me.lblAnswersRight.Name = "lblAnswersRight"
        Me.lblAnswersRight.Size = New System.Drawing.Size(295, 167)
        Me.lblAnswersRight.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 143)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total Correct:"
        '
        'Kahoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 637)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAnswersRight)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtAns1)
        Me.Controls.Add(Me.BtnSkip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTotlPplAns)
        Me.Controls.Add(Me.LblQuestion)
        Me.Name = "Kahoot"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQuestion As Label
    Friend WithEvents LblTotlPplAns As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSkip As Button
    Friend WithEvents TxtAns1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblAnswersRight As Label
    Friend WithEvents Label2 As Label
End Class
