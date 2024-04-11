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
        Me.components = New System.ComponentModel.Container()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.BtnSkip = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblAnswersRight = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenJson = New System.Windows.Forms.OpenFileDialog()
        Me.PnlGuessAnswers = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblQuestion
        '
        Me.LblQuestion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion.Location = New System.Drawing.Point(-5, 24)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(1100, 126)
        Me.LblQuestion.TabIndex = 0
        '
        'BtnSkip
        '
        Me.BtnSkip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSkip.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSkip.Location = New System.Drawing.Point(988, 153)
        Me.BtnSkip.Name = "BtnSkip"
        Me.BtnSkip.Size = New System.Drawing.Size(96, 36)
        Me.BtnSkip.TabIndex = 3
        Me.BtnSkip.Text = "Skip"
        Me.BtnSkip.UseVisualStyleBackColor = False
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
        Me.lblAnswersRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswersRight.Location = New System.Drawing.Point(871, 201)
        Me.lblAnswersRight.Name = "lblAnswersRight"
        Me.lblAnswersRight.Size = New System.Drawing.Size(206, 94)
        Me.lblAnswersRight.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(641, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 98)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total Correct:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1089, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "File"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'OpenJson
        '
        Me.OpenJson.DefaultExt = "Json"
        Me.OpenJson.FileName = "OpenFileDialog1"
        '
        'PnlGuessAnswers
        '
        Me.PnlGuessAnswers.Location = New System.Drawing.Point(46, 311)
        Me.PnlGuessAnswers.Name = "PnlGuessAnswers"
        Me.PnlGuessAnswers.Size = New System.Drawing.Size(985, 314)
        Me.PnlGuessAnswers.TabIndex = 20
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Kahoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1089, 637)
        Me.Controls.Add(Me.PnlGuessAnswers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAnswersRight)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.BtnSkip)
        Me.Controls.Add(Me.LblQuestion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Kahoot"
        Me.Text = "Kahoot"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQuestion As Label
    Friend WithEvents BtnSkip As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblAnswersRight As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenJson As OpenFileDialog
    Friend WithEvents PnlGuessAnswers As Panel
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
