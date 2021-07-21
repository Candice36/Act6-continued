Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Format(Val(TextBox1.Text), "0.000")

    End Sub
End Class
