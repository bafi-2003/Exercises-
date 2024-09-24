Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = txtName.Text
        Dim age As Integer = txtage.Text
        Dim colour As String = txtcolour.Text

        MessageBox.Show("Hello" & " " & name &
            " " & age & " " & colour)


    End Sub
End Class
