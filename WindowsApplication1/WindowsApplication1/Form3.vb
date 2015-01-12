Public Class HelpForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BulbForm.Show()
        Me.Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.ReadOnly = True
    End Sub
End Class