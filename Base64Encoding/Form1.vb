Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim b As Byte() = Convert.FromBase64String(Label1.Text)

        TextBox1.Text = System.Text.Encoding.UTF8.GetString(b)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)

        Label1.Text = Convert.ToBase64String(byt)
    End Sub
End Class
