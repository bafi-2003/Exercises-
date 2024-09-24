Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        number = TextBox1.Text


        If number < 0 Then
            MessageBox.Show("Negative number")
        ElseIf number = 0 Then
            MessageBox.Show("Zero")

        Else
            MessageBox.Show("Positve number ")


        End If


    End Sub
End Class
