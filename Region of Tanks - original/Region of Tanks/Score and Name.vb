Imports System.Windows.Forms
Imports System.IO


Public Class frmScore

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim saveScoreDialog As New SaveFileDialog()

        Dim currentDir As String = Environment.CurrentDirectory
        Dim GameRecord As String
        GameRecord = DateTime.Now & ":  " & txtPlr1.Text & " vs " & txtPlr2.Text & ": " & frmTanks.score2 & " - " & frmTanks.score1 & vbCrLf & vbCrLf
        My.Computer.FileSystem.WriteAllText(currentDir & "\RegionOfTanks-Scores.txt", GameRecord, True)
        frmTanks.newGame()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
