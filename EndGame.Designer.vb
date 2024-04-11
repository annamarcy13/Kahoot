<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndGame
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
        Me.lblCorrectAns = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuestionAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You Got"
        '
        'lblCorrectAns
        '
        Me.lblCorrectAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAns.Location = New System.Drawing.Point(223, 44)
        Me.lblCorrectAns.Name = "lblCorrectAns"
        Me.lblCorrectAns.Size = New System.Drawing.Size(87, 75)
        Me.lblCorrectAns.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 60)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Out Of"
        '
        'lblQuestionAmount
        '
        Me.lblQuestionAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionAmount.Location = New System.Drawing.Point(486, 44)
        Me.lblQuestionAmount.Name = "lblQuestionAmount"
        Me.lblQuestionAmount.Size = New System.Drawing.Size(87, 75)
        Me.lblQuestionAmount.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 60)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Which is a"
        '
        'lblPercentage
        '
        Me.lblPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(269, 178)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(242, 75)
        Me.lblPercentage.TabIndex = 5
        '
        'EndGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblQuestionAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCorrectAns)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EndGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EndGame"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCorrectAns As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuestionAmount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPercentage As Label
End Class
