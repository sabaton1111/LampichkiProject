Public Class SaveForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beep()
        SaveMessageBox.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            ErrorSave.Show()
        End If
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            SaveFileDialog1.ShowDialog()
        End If
    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        SaveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt"
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(Label1.Text)
        writer.Write(TextBox1.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        writer.Write(Label2.Text)
        writer.Write(TextBox2.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        writer.Write(Label3.Text)
        writer.Write(TextBox3.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        writer.Write(BulbForm.TrueLabel.Text)
        writer.Write(BulbForm.NumberOfCorrectAnswers.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        writer.Write(BulbForm.IncorrectLabel.Text)
        writer.Write(BulbForm.NumberOfWrongAnswers.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        writer.Write(BulbForm.PropusnatiLabel.Text)
        writer.Write(BulbForm.NumberOfMissed.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        writer.Write("Резултат за интервал от време : ")
        writer.Write(BulbForm.TimeLabel.Text)
        writer.Write(TextBox4.Text)
        writer.Write(TextBox4.Text)
        If BulbForm.NumberOfCorrectAnswers.Text < BulbForm.NumberOfWrongAnswers.Text And BulbForm.NumberOfCorrectAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е лош")
            writer.Write(TextBox4.Text)
            writer.Write(TextBox4.Text)
        End If
        If BulbForm.NumberOfCorrectAnswers.Text = "0" And BulbForm.NumberOfWrongAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е много лош")
            writer.Write(TextBox4.Text)
            writer.Write(TextBox4.Text)
        End If
        If BulbForm.NumberOfCorrectAnswers.Text = BulbForm.NumberOfWrongAnswers.Text Then
            writer.Write("Вашият резултат не е много добър")
            writer.Write(TextBox4.Text)
            writer.Write(TextBox4.Text)
        End If
        If BulbForm.NumberOfCorrectAnswers.Text > BulbForm.NumberOfWrongAnswers.Text And BulbForm.NumberOfWrongAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е задоволителен")
            writer.Write(TextBox4.Text)
            writer.Write(TextBox4.Text)
        End If
        If BulbForm.NumberOfWrongAnswers.Text = "0" And BulbForm.NumberOfCorrectAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е отличен")
            writer.Write(TextBox4.Text)
            writer.Write(TextBox4.Text)
        End If
        writer.Close()
    End Sub
End Class