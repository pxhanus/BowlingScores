'Patricia Hanus
'151008
'Bowling Scores
'_______________________________________________________________________
Public Class Form1
    Dim highScore, lowScore, addScore As Integer
    Dim average As Double
    Private Sub btnEnterScores_Click(sender As Object, e As EventArgs) Handles btnEnterScores.Click
        Dim score As String
        score = InputBox("Enter a bowling score")

        Static numScores As Integer = 0

        If numScores = 0 Then
            highScore = Val(score)
            lowScore = Val(score)
        End If

        numScores += 1
        addScore += Val(score)
        If Val(score) > highScore Then
            highScore = Val(score)
        ElseIf Val(score) < lowScore Then
            lowScore = Val(score)
        Else
        End If
        average = addScore / numScores

    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Me.lblDisplay.Text = "The highest score is " & highScore & " and the lowest score is " & lowScore & ". The average score is " & average & "."
    End Sub
End Class
