Public Class SaveMessageBox
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        SaveForm.Close()
        Me.Close()
        BulbForm.Show()
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        SaveForm.Show()
        Me.Close()
    End Sub
End Class