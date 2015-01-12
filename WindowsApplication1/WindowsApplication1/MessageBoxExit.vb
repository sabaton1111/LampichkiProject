Public Class MessageBoxExit

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Me.Close()
        BulbForm.Close()
        SaveForm.Close()
        HelpForm.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        BulbForm.Show()
        Me.Close()
    End Sub
End Class