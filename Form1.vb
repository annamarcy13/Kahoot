Imports Newtonsoft.Json

Public Class Kahoot
    Private score As Integer
    Private NumOfQuestions As Integer
    Private questionList As New List(Of Question)
    Private numOfbtn As Integer
    Private totalQs As Integer
    Private currentQuestionIdx As Integer = 0
    Private Const CORRECTTAG As String = "CORRECT"
    Private timeleft As Integer

    Private Sub Kahoot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Filename As String = "vbchapter5kahoot.json"
        LoadDataFile(Filename)
        printQuestionsToConsole()

        ResetGame()







    End Sub


    Sub LoadDataFile(filename As String)
        questionList.Clear()
        Dim reader As New IO.StreamReader(filename)
        Dim str As String = reader.ReadToEnd
        questionList = JsonConvert.DeserializeObject(Of List(Of Question))(str)
        totalQs = questionList.Count
        reader.Close()


    End Sub


    Sub ResetGame()


        currentQuestionIdx = 0
        LoadPanel()
    End Sub

    Sub LoadPanel()
        Timer1.Stop()
        If currentQuestionIdx >= numOfq Then

            EndGame.lblCorrectAns.Text = score
            EndGame.lblQuestionAmount.Text = totalQs.ToString
            Dim perc As Double = score / totalQs
            EndGame.lblPercentage.Text = perc.ToString("P2")
            EndGame.Show()
            Me.Close()
            Return
        End If
        PnlGuessAnswers.Controls.Clear()
        Dim currentQuestion As Question = questionList(currentQuestionIdx)
        LblQuestion.Text = currentQuestion.Question
        numOfbtn = currentQuestion.Answers.Count
        timeleft = currentQuestion.Time
        Dim btnWidth As Integer = PnlGuessAnswers.Width / 2
        Dim btnheight As Integer = PnlGuessAnswers.Height / Math.Ceiling(numOfbtn / 2)  'takes the height and rounds up the result
        'Loops through to create a button depending on how many answers there are in the list
        For b As Integer = 0 To numOfbtn - 1
            Dim btn As New Button With {
                    .Text = currentQuestion.Answers(b).ToString,
               .Width = btnWidth,
            .Height = btnheight,
            .Location = New Point(btnWidth * (b Mod 2), btnheight * Math.Floor(b / 2.0)), 'takes the remainder and takes the floor of btnHeight to adjust the scale of the button
            .BackColor = Color.LawnGreen,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", 20, FontStyle.Regular)
            }

            If currentQuestion.Correct = b Then
                btn.Tag = CORRECTTAG
            End If

            AddHandler btn.Click, AddressOf handleAnswerClick

            PnlGuessAnswers.Controls.Add(btn)

        Next
        lblTimer.Text = timeleft.ToString
        Timer1.Start()

    End Sub

    Private Sub handleAnswerClick(sender As Button, e As EventArgs)
        'Makes it so when clicking a button it returns either the first message box or the other msg if it was wrong

        If sender.Tag = CORRECTTAG Then
            MsgBox("You got it!")
            score += 1
            lblAnswersRight.Text = score.ToString
            NumOfQuestions += 1
        Else
            MsgBox("Incorrect!")
            NumOfQuestions += 1
        End If
        currentQuestionIdx += 1


        LoadPanel()


    End Sub

    Private numOfq
    Sub printQuestionsToConsole()
        numOfq = 0
        'loop through question list and print to console the q and the correct answer
        For Each q As Question In questionList
            numOfq += 1
            Console.WriteLine("".PadLeft(50, "-"))
            Console.WriteLine(q.Question)
            Console.WriteLine("".PadLeft(50, "-"))
            LblQuestion.Text = q.Question
        Next

        For Each c As Question In questionList
            Console.WriteLine("".PadLeft(50, "-"))
            Console.WriteLine(c.Correct)

        Next





    End Sub

    Private Sub CheckFile(filename As String)
        If IO.File.Exists(filename) Then
            LoadDataFile(filename)
        End If
    End Sub

    Private Sub OpenToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenJson.DefaultExt = "Json"
        OpenJson.Filter = "json files|*.json|All Files| *.*"
        OpenJson.Title = "Select your question JSON"


        If OpenJson.ShowDialog = DialogResult.OK Then
            '  MsgBox(OpenJson.FileName)
            LoadDataFile(OpenJson.FileName)
            printQuestionsToConsole()
            ResetGame()
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        LblQuestion.Controls.Clear()
        questionList.Clear()


    End Sub

    Private Sub BtnSkip_Click(sender As Object, e As EventArgs) Handles BtnSkip.Click
        currentQuestionIdx += 1
        LoadPanel()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeleft -= 1
        lblTimer.Text = timeleft.ToString
        If timeleft = 0 Then
            Timer1.Stop()
            MsgBox("Time has run out")
            currentQuestionIdx += 1
            LoadPanel()
        End If
    End Sub
End Class

Public Class Question
    Private _question As String
    Private _time As Integer
    Private _correct As Integer
    Private _Answers As List(Of String)

    Public Property Question As String
        Get
            Return _question
        End Get
        Set(value As String)
            _question = value
        End Set
    End Property

    Public Property Time As Integer
        Get
            Return _time
        End Get
        Set(value As Integer)
            _time = value
        End Set
    End Property

    Public Property Correct As Integer
        Get
            Return _correct
        End Get
        Set(value As Integer)
            _correct = value
        End Set
    End Property

    Public Property Answers As List(Of String)
        Get
            Return _Answers
        End Get
        Set(value As List(Of String))
            _Answers = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Question
    End Function
End Class
