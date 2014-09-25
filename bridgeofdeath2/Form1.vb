Public Class Form1

    Private Sub btnanser_Click(sender As Object, e As EventArgs) Handles btnanser.Click
        Dim strSecretName As String = "isaac"
        Dim strNameGuess As String = Me.txtName.Text
        Dim strSecretQuest As String = "seek the grail"
        Dim strQuestGuess As String = Me.txtQuest.Text
        Dim strSecretColor As String = "pink"
        Dim strColorGuess As String = Me.txtColor.Text

        If strSecretName = Me.txtName.Text Then
            Me.lblNameanser.Text = "you may pass"
        Else : Me.lblNameanser.Text = "you die!"
        End If
        If strSecretQuest = Me.txtQuest.Text Then
            Me.lblQuestanser.Text = "you may pass"
        Else : Me.lblQuestanser.Text = "you die!"
        End If
        If strSecretColor = Me.txtColor.Text Then
            Me.lblColoranser.Text = "you may pass"
        Else : Me.lblColoranser.Text = "you die!"
        End If
    End Sub
End Class
