Public Class NotCheckedForm

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
        BulbForm.Show()
        BulbForm.LevelPanel.Enabled = True
        BulbForm.TimePanel.Enabled = True
    End Sub
End Class