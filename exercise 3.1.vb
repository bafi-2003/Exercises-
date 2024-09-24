Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 10
            MessageBox.Show("Number:" & i)

        Next

        Dim number As Integer = Integer.Parse(TextBox1.Text)

        While number >= 0
            MessageBox.Show("number :" & number)
            number -= 1
        End While





    End Sub

End Class
